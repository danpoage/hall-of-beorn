using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace HallOfBeorn.Models.RingsDb
{
    public class RingsDbDeck
    {
        public int id { get; set; }
        public string name { get; set; }
        public string nameCanonical { get; set; }
        public string dateCreation { get; set; }
        public string dateUpdate { get; set; }
        public string url { get; set; }
    }
}