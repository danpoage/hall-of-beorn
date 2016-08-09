using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace HallOfBeorn.Models
{
    public class CardTag
    {
        public CardTag()
        {
            Text = string.Empty;
            Description = string.Empty;
            Url = string.Empty;
        }

        public string Text { get; set; }
        public string Description { get; set; }
        public string Url { get; set; }
    }
}