using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace HallOfBeorn.Services.LotR.Octgn
{
    public class OctgnSet
    {
        protected OctgnSet(string id, string name)
        {
            Id = id;
            Name = name;
        }

        private readonly Dictionary<string, string> cardsById = new Dictionary<string, string>();

        protected void addCard(string setId, string cardId, string name)
        {
            cardsById[cardId] = name;
        }

        public string Id { get; private set; }

        public string Name { get; private set; }

        public Dictionary<string, string> CardsById
        {
            get { return cardsById; }
        }
    }
}