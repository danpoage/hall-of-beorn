using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace HallOfBeorn.Models.Arkham
{
    public class Shroud
    {
        public static Number Of(byte value)
        {
            return new Number { Value = value };
        }

        public static Number X
        {
            get { return new Number { IsX = true }; }
        }
    }
}