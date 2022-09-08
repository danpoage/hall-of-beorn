using System;
using System.Collections.Generic;
using System.Linq;

namespace HallOfBeorn.Models.BeornBot
{
    public class BotLink
    {
        public string title { get; private set; }
        public string type { get; private set; }
        public string url { get; private set; }
        public string thumbnail_url { get; private set; }
        public List<string> labels { get; private set; }

        public static BotLink From(ILink link)
        {
            return new BotLink
            {
                title = link.Title,
                type = Enum.GetName(typeof(LinkType), link.Type).Replace("_", " "),
                url = link.Url,
                thumbnail_url = link.ThumbnailUrl,
                labels = new List<string>(link.Labels().Where(l => !string.IsNullOrEmpty(l)).Select(l => l.ToLower()))
            };
        }
    }
}