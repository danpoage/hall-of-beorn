using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace HallOfBeorn.Models.YouTube
{
    public class YouTubeLink : ILink
    {
        public YouTubeLink(string title, string videoId)
        {
            this.videoId = videoId;
            Url = string.Format(urlFormat, videoId);
            ThumbnailUrl = string.Format(thumbnailFormat, videoId);
            Text = string.Format(textFormat, ThumbnailUrl, title, thumbnailHeight, thumbnailWidth);
        }

        private readonly string videoId;
        private const string urlFormat = "https://www.youtube.com/watch?v={0}";
        private const string textFormat = "<img src='{0}' title='{1}' style='height:{2}px;width:{3}px'></img>";
        private const string thumbnailFormat = "https://i.ytimg.com/vi/{0}/hqdefault.jpg";
        private const int thumbnailHeight = 118;
        private const int thumbnailWidth = 210;

        public LinkType Type { get { return LinkType.YouTube; } }

        public string Title { get; private set; }

        public string Text { get; private set; }
        
        public string Url { get; private set; }

        public string Slug { get { return videoId; } }

        public string ThumbnailUrl { get; private set; }

        public int ThumbnailHeight { get { return thumbnailHeight; } }
        
        public int ThumbnailWidth { get { return thumbnailWidth; } }

        private readonly HashSet<string> labels = new HashSet<string>();
        public IEnumerable<string> Labels() { return labels; }

        public ILink WithLabel(string label)
        {
            if (!labels.Contains(label))
            {
                this.labels.Add(label);
            }
            return this;
        }

        public ILink WithLabels(params string[] labels)
        {
            foreach (var label in labels)
            {
                if (!labels.Contains(label))
                {
                    this.labels.Add(label);
                }
            }
            return this;
        }

        public bool HasLabel(string label)
        {
            return labels.Any(l => l.ToLowerSafe() == label.ToLowerSafe());
        }
    }
}