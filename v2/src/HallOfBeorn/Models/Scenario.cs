using System;
using System.Collections.Generic;
using System.Text;

namespace HallOfBeorn.Models
{
    public class Scenario
    {
        public Scenario(byte number)
        {
            Number = number;
        }

        public byte Number { get; }
    }
}
