using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace HallOfBeorn.Models.YouTube
{
    public class RingsDbCardLink : ILink
    {
        public RingsDbCardLink(string setId, string cardId, string title)
        {
            Title = title;
            Text = title;
            Url = string.Format("http://ringsdb.com/card/{0:00}{1:000}", setId, cardId);
        }

        public LinkType Type { get { return LinkType.RingsDB; } }

        public string Title { get; private set; }

        public string Text { get; private set; }

        public string Url { get; private set; }

        public string ThumbnailUrl { get; private set; }

        public int ThumbnailHeight { get; private set; }

        public int ThumbnailWidth { get; private set; }

        private readonly HashSet<string> labels = new HashSet<string>();
        public IEnumerable<string> Labels { get { return labels; } }

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
    }
}