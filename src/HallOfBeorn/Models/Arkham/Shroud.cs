using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace HallOfBeorn.Models.Arkham
{
    public struct Shroud
    {
        public byte Value { get; set; }
        public bool PerInvestigator { get; set; }
        public bool IsVariable { get; set; }

        public static Shroud One
        {
            get { return new Shroud { Value = 1 }; }
        }
    }
}