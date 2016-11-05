using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace HallOfBeorn.Models.LotR.Simple
{
    public class SimpleScenarioCard
    {
        public string EncounterSet { get; set; }
        public string Title { get; set; }
        public uint NormalQuantity { get; set; }
        public uint EasyQuantity { get; set; }
        public uint NightmareQuantity { get; set; }
    }
}