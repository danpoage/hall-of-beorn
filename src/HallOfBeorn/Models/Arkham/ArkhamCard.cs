using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace HallOfBeorn.Models.Arkham
{
    public class ArkhamCard
    {
        private readonly List<string> traits = new List<string>();

        public ArkhamProduct Product { get; set; }
        public string Name { get; protected set; }
        public bool IsUnique { get; protected set; }

        public ArkhamCardLevel? Level { get; protected set; }
        
        public string Text { get; protected set; }
        public string Flavor { get; protected set; }

        public ushort Number { get; protected set; }
        public byte Quanity { get; protected set; }
        public string Artist { get; protected set; }

        protected void addTraits(IEnumerable<string> traits)
        {
            this.traits.AddRange(traits);
        }

        public IEnumerable<string> Traits()
        {
            return traits;
        }
    }
}