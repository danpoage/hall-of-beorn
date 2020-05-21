using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace HallOfBeorn.Models.RingsDb
{
    public class RingsDbDeckList
    {
        public uint id { get; set; }
        public string name { get; set; }
        public string date_creation { get; set; }
        public string date_update { get; set; }
        public string description_md { get; set; }
        public uint user_id { get; set; }
        public Dictionary<string, byte> heroes { get; set; } 
        public Dictionary<string, byte> slots { get; set; } 
        public Dictionary<string, byte> sideslots { get; set; } 
        public bool is_published { get; set; } 
        public ushort nb_votes { get; set; } 
        public ushort nb_favorites { get; set; } 
        public ushort nb_comments { get; set; }

        public string url { get; set; }
    }
}