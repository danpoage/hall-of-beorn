using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace HallOfBeorn.Models
{
    public class Token
    {
        public bool IsTrigger { get; set; }
        public bool IsTrait { get; set; }
        public bool IsTitleReference { get; set; }
        public bool IsStrong { get; set; }
        public bool IsEmphasized { get; set; }

        public bool IsIcon { get { return !string.IsNullOrEmpty(ImagePath); } }
        public string ImagePath { get; set; }

        public string Text { get; set; }

        public bool HasPrefix { get { return !string.IsNullOrEmpty(Prefix); } }
        public string Prefix { get; set; }

        public bool HasSuffix { get { return !string.IsNullOrEmpty(Suffix); } }
        public string Suffix { get; set; }

        public string LeftMargin
        {
            get
            {
                if (!IsIcon)
                    return "0px";

                switch (Text)
                {
                    case "Baggins":
                    case "Fellowship":
                    case "Leadership":
                    case "Tactics":
                    case "Spirit":
                    case "Lore":
                        return "1px";
                    default:
                        if (HasSuffix)
                        {
                            return "8px";
                        }
                        else
                        {
                            return "2px";
                        }
                }
            }
        }
    }
}