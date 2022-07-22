using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Web;

namespace HallOfBeorn.Models.LotR.ViewModels
{
    public class LinkViewModel
    {
        public LinkViewModel(ILink link)
        {
            _link = link;
        }

        private readonly ILink _link;

        public ILink Link { get { return _link; } }

        public string Url { get { return _link.Url; } }

        public string TypeName { get { return Enum.GetName(typeof(LinkType), _link.Type).Replace("__", "'").Replace("_", " "); } }
        
        public string Title { get { return _link.Title; } }
        
        public string FullTitle
        {
            get
            {
                return _link.Type != LinkType.None
                    ? string.Format("{0} - {1}", TypeName, _link.Title)
                    : _link.Title;
            }
        }

        public bool HasThumbnail { get { return !string.IsNullOrWhiteSpace(_link.ThumbnailUrl); } }

        public string ThumbnailUrl { get { return _link.ThumbnailUrl; } }

        public int ThumbnailHeight { get { return _link.ThumbnailHeight; } }
        
        public int ThumbnailWidth { get { return _link.ThumbnailWidth; } }
    }
}