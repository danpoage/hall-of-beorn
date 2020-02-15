using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace HallOfBeorn.Models.LotR.Simple
{
    public class SimpleCardSet
    {
        public string Name { get; set; }
        public string Slug { get; set; }
        public string Abbreviation { get; set; }
        public string Cycle { get; set; }
        public string SetType { get; set; }
        public List<SimpleCard> Cards { get; set; }
    }
}