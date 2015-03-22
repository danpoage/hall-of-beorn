using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HallOfBeorn.Models
{
    public struct Name
    {
        public Name(string value)
        {
            this.Value = value;
            this.Normalized = value.Normalize();
        }

        public readonly string Value;
        public readonly string Normalized;

        public bool IsNormalized()
        {
            return Value == Normalized;
        }
    }
}
