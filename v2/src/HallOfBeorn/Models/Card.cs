using System;
using System.Collections.Generic;
using System.Text;

namespace HallOfBeorn.Models
{
    public class Card
    {
        public Card(ushort number)
        {
            Number = number;
        }

        public ushort Number { get; }
    }
}
