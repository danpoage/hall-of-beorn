using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HallOfBeorn.Models
{
    public interface ILink
        : ILabeled
    {
        LinkType Type { get; }
        string Title { get; }
        string Text { get; }
        string Url { get; }
        string ThumbnailUrl { get; }
        int ThumbnailHeight { get; } 
        int ThumbnailWidth { get; }
        ILink WithLabel(string label);
        ILink WithLabels(string[] labels);
    }
}
