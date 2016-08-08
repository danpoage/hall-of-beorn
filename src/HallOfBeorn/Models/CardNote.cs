using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace HallOfBeorn.Models
{
    public class CardNote
    {
        public CardNote()
        {
            Date = null;
            FaqVersion = 0m;
            Text = string.Empty;
            Url = string.Empty;
        }

        public DateTime? Date { get; set; }
        public decimal FaqVersion { get; set; }
        public string Text { get; set; }
        public string Url { get; set; }
    }
}