using System;
using System.Collections.Generic;
using System.Text;

namespace HallOfBeorn.Models
{
    public class CardSet
    {
        public string Name { get; set; }
        public string Abbreviation { get; set; }
        public ushort Number { get; set; }
        public SetType SetType { get; set; }
        public ushort FirstCardNumber { get; set; }
        public ushort LastCardNumber { get; set; }
    }
}
