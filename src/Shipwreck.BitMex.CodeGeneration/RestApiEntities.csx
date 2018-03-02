#r "nuget: Newtonsoft.Json, 11.0.0"

using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;

var dir = Path.GetDirectoryName(Path.GetFullPath("a"));

JObject jo;
using (var sr = new StreamReader(Path.Combine(dir, "../../swagger.json")))
using (var jr = new JsonTextReader(sr))
{
    jo = JObject.Load(jr);
}

string ToPascalCasing(string n)
{

    var un = char.ToUpper(n[0]) + n.Substring(1);

    switch (un)
    {
        case "TFAEnabled":
            un = "IsTfaEnabled";
            break;
    }

    return un;

}

using (var sw = new StreamWriter(Path.Combine(dir, "../Shipwreck.BitMex/Generated Codes/RestApiEntities.cs")))
{
    sw.WriteLine("using System;");
    sw.WriteLine("using System.Runtime.Serialization;");
    sw.WriteLine("using Newtonsoft.Json;");
    sw.WriteLine("using Newtonsoft.Json.Converters;");
    sw.WriteLine();
    sw.WriteLine("namespace Shipwreck.BitMex");
    sw.WriteLine("{");

    var enums = new Dictionary<string, string[]>();

    foreach (var cp in ((JObject)jo.Property("definitions").Value).Properties())
    {
        if (cp.Name == "x-any" || cp.Name == "Error")
        {
            continue;
        }
        sw.WriteLine("    [DataContract]");
        sw.WriteLine("    public partial class " + cp.Name);
        sw.WriteLine("    {");
        var required = (((JObject)cp.Value).Property("required")?.Value as JArray)?.Select(e => e.Value<string>()).ToList();

        foreach (var pp in ((JObject)((JObject)cp.Value).Property("properties").Value).Properties())
        {
            var n = pp.Name;

            var un = ToPascalCasing(n);

            var po = (JObject)pp.Value;

            var type = po.Property("type")?.Value.Value<string>();
            var format = po.Property("format")?.Value.Value<string>();
            //var def = po.Property("def")?.Value.Value<string>();
            //var maxLength = po.Property("maxLength")?.Value.Value<int>();

            string clrType = null, defaultValue = null;
            var isEnum = false;

            switch (type)
            {
                case "boolean":
                    clrType = "bool";
                    break;

                case "number":
                    switch (format)
                    {
                        case "int32":
                            clrType = "int";
                            break;

                        case "int64":
                            clrType = "long";
                            break;

                        case "double":
                            clrType = "double";
                            break;
                    }

                    if (clrType != null && required?.Contains(n) != true)
                    {
                        clrType += "?";
                    }
                    break;

                case "string":
                    switch (format)
                    {
                        case null:
                            var ep = po.Property("enum");
                            if (ep == null)
                            {
                                clrType = "string";
                            }
                            else
                            {
                                clrType = cp.Name + un;

                                var vs = (ep.Value as JArray)?.Select(e => e.Value<string>()).ToArray();
                                enums.TryGetValue(clrType, out var cur);
                                enums[clrType] = (cur ?? new string[0]).Concat(vs ?? new string[0]).Distinct().ToArray();
                                isEnum = true;
                            }
                            break;

                        case "date-time":
                            clrType = "DateTimeOffset";
                            break;

                        case "guid":
                            clrType = "Guid";
                            break;
                    }

                    if (clrType != null && clrType != "string" && !isEnum && required?.Contains(n) != true)
                    {
                        clrType += "?";
                    }

                    break;

                case "array":
                    var ip = po.Property("items");
                    if (ip != null)
                    {
                        var itemType = (ip.Value as JObject)?.Property("type")?.Value?.Value<string>();
                        var refs = (ip.Value as JObject)?.Property("$ref")?.Value?.Value<string>();
                        switch (itemType)
                        {
                            case "string":
                                clrType = "string[]";
                                break;

                            case null:
                                if (refs == "#/definitions/x-any")
                                {
                                    clrType = "object[]";
                                }
                                break;
                        }
                    }
                    break;

                case "object":
                    clrType = "object";
                    break;
            }

            if (clrType == null)
            {
                sw.WriteLine($"        // TODO: {type} {format}");
            }
            sw.WriteLine("        [DataMember]");
            sw.WriteLine($"        [JsonProperty(\"{n}\")]");
            if (isEnum)
            {
                sw.WriteLine("        [JsonConverter(typeof(StringEnumConverter))]");
            }
            sw.WriteLine($"        public {clrType ?? "object"} {un} {{ get; set; }}");
        }
        sw.WriteLine("    }");
    }
    foreach (var kv in enums)
    {
        sw.WriteLine("    [DataContract]");
        sw.WriteLine("    public enum " + kv.Key);
        sw.WriteLine("    {");
        foreach (var v in kv.Value)
        {
            sw.WriteLine($"        [EnumMember(Value = \"{v}\")]");
            sw.WriteLine("        " + ToPascalCasing(v) + ",");
        }
        sw.WriteLine("    }");
    }

    sw.WriteLine("}");
}