using System;
using System.Collections.Generic;

namespace HallOfBeorn.Models
{
    public class CardSide
    {
        public readonly Dictionary<TextType, Content> TextBox = new Dictionary<TextType, Content>();
        public List<Artist> Artists = new List<Artist>();
    }
}
