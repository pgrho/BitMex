using System;

namespace Shipwreck.BitMex
{
    [Flags]
    public enum AnnouncementColumns
    {
        None = 0,
        Id = 1,
        Link = 2,
        Title = 4,
        Content = 8,
        Date = 16,
        All = -1
    }

    internal static class AnnouncementColumnsHelper
    {
        public const string ID = "id";
        public const string LINK = "link";
        public const string TITLE = "title";
        public const string CONTENT = "content";
        public const string DATE = "date";


    }
}