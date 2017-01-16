using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace HallOfBeorn.Models.Arkham
{
    public class ArkhamProduct : INamed
    {
        public ArkhamProduct(string name, string abbreviation, string productCode, ushort productNumber, DateTime releaseDate)
        {
            this.Name = name;
            this.Abbreviation = abbreviation;
            this.ProductCode = productCode;
            this.ProductNumber = productNumber;
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
        public string ProductCode { get; protected set; }
        public ushort ProductNumber { get; protected set; }
        public DateTime ReleaseDate { get; protected set; }

        public IEnumerable<ArkhamCard> Cards()
        {
            return cards;
        }
    }
}