using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace HallOfBeorn.Models.Arkham
{
    public struct Number
    {
        public byte Value { get; set; }
        public bool IsNotApplicable { get; set; }
        public bool IsPerInvestigator { get; set; }
        public bool IsX { get; set; }

        private static readonly Dictionary<sbyte,Number> all = new Dictionary<sbyte, Number>();

        static Number()
        {
        }

        public static Number X
        {
            get { return new Number { Value = 0, IsX = true }; }
        }

        public static Number NA
        {
            get { return new Number { Value = 0, IsNotApplicable = true }; }
        }

        public static Number Of(byte value)
        {
            return new Number { Value = value };
        }

        public Number PerInvestigator()
        {
            this.IsPerInvestigator = true;
            return this;
        }

        public static Number Zero { get { return new Number { Value = 0 }; } }
        public static Number One { get { return new Number { Value = 1 }; } }
        public static Number Two { get { return new Number { Value = 2 }; } }
        public static Number Three { get { return new Number { Value = 3 }; } }

        public override string ToString()
        {
            return this.ToString("Per Investigator");
        }

        public string ToString(string perInvestigatorSuffix)
        {
            if (IsNotApplicable)
            {
                return "-";
            }

            if (IsX)
            {
                return IsPerInvestigator ? string.Format("X {0}", perInvestigatorSuffix) : "X";
            }

            return IsPerInvestigator ? string.Format("{0} {1}", Value, perInvestigatorSuffix) : Value.ToString();
        }

    }
}