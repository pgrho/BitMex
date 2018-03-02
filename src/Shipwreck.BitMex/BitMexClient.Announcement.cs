using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace Shipwreck.BitMex
{
    partial class BitMexClient
    {
        public Task<Announcement[]> GetAnnouncementsAsync(AnnouncementColumns columns = AnnouncementColumns.All)
            => GetAsync<Announcement[]>("announcement", shouldAuthorize: false);

        public Task<Announcement[]> GetUrgentAnnouncementsAsync(AnnouncementColumns columns = AnnouncementColumns.All)
            => GetAsync<Announcement[]>("announcement/urgent", shouldAuthorize: false);
    }

 

    internal static class StringBuilderHelper
    {

    }
}
