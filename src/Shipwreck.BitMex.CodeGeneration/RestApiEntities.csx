#r "nuget: Newtonsoft.Json, 11.0.0"

using System.Collections.Generic;
using System.IO;
using System.Text;
using System.Text.RegularExpressions;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;

var dir = Path.GetDirectoryName(Path.GetFullPath("a"));

JObject jo;
using (var sr = new StreamReader(Path.Combine(dir, "swagger.json")))
using (var jr = new JsonTextReader(sr))
{
    jo = JObject.Load(jr);
}

using (var sw = new StreamWriter(Path.Combine(dir, "../Shipwreck.BitMex/Generated Codes/RestApiEntities.cs")))
{
    sw.WriteLine("using System;");
    sw.WriteLine("namespace Shipwreck.BitMex");
    sw.WriteLine("{");
    foreach (var cp in ((JObject)jo.Property("definitions").Value).Properties())
    {
        if (cp.Name == "x-any")
        {
            continue;
        }
        sw.WriteLine("    public partial class " + cp.Name);
        sw.WriteLine("    {");
        foreach (var pp in ((JObject)((JObject)cp.Value).Property("properties").Value).Properties())
        {
            var n = pp.Name;
            sw.WriteLine($"        public object {n} {{ get; set; }}");
        }
        sw.WriteLine("    }");
    }

    sw.WriteLine("}");
}