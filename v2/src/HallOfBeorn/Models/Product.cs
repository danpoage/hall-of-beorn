using System;
using System.Collections.Generic;
using System.Text;

namespace HallOfBeorn.Models
{
    public class Product
    {
        public Product(string code)
        {
            Code = code;
        }

        public string Code { get; }
    }
}
