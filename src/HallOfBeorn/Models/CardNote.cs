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
            FaqVersion = 0;
            Text = string.Empty;
            Url = string.Empty;
        }

        public CardNoteType Type { get; set; }
        public DateTime? Date { get; set; }
        public double FaqVersion { get; set; }
        public string Text { get; set; }
        public string Url { get; set; }

        public string GetDateText()
        {
            return Date.HasValue ?
                string.Format(" ({0:d})", Date.Value)
                : string.Empty;
        }
    }

    public enum CardNoteType
    {
        Clarification = 0,
        FAQ,
        Ruling
    }
}