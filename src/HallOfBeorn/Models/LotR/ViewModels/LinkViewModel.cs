using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Web;

namespace HallOfBeorn.Models.LotR.ViewModels
{
    public class LinkViewModel
    {
        public LinkViewModel(Link link)
        {
            _link = link;
        }

        private readonly Link _link;

        public string Url { get { return _link.Url; } }

        public string TypeName { get { return Enum.GetName(typeof(LinkType), _link.Type).Replace("__", "'").Replace("_", " "); } }
        
        public string Title { get { return _link.Title; } }

        public string FullTitle { get { return string.Format("{0} - {1}", TypeName, _link.Title); } }

        public bool HasThumbnail { get { return !string.IsNullOrWhiteSpace(_link.ThumbnailUrl); } }

        public string ThumbnailUrl { get { return _link.ThumbnailUrl; } }

        public int ThumbnailHeight { get { return _link.ThumbnailHeight; } }
        
        public int ThumbnailWidth { get { return _link.ThumbnailWidth; } }
    }
}