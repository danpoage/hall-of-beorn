using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace HallOfBeorn.Models.Arkham
{
    public class ArkhamProduct
    {
        public ArkhamProduct(string name, string abbreviation, string code, ushort number, DateTime releaseDate)
        {
            this.Name = name;
            this.Abbreviation = abbreviation;
            this.Number = number;
            this.Code = code;
            this.ReleaseDate = releaseDate;

            init();
        }

        private readonly List<ArkhamCard> cards = new List<ArkhamCard>();

        protected virtual void init()
        {
        }

        protected void addCard(ArkhamCard card)
        {
            card.Product = this;
            cards.Add(card);
        }

        public string Name { get; protected set; }
        public string Abbreviation { get; protected set; }
        public string Code { get; protected set; }
        public ushort Number { get; protected set; }
        public DateTime ReleaseDate { get; protected set; }

        public IEnumerable<ArkhamCard> Cards()
        {
            return cards;
        }
    }
}