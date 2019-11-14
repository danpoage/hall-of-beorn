using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace HallOfBeorn.Models.Marvel
{
    public class MarvelProduct
        : INamed
    {
        public MarvelProduct(
            string name, string abbreviation, string productCode, ushort productNumber, DateTime releaseDate)
        {
            Name = name;
            Abbreviation = abbreviation;
            ProductCode = productCode;
            ProductNumber = productNumber;
            ReleaseDate = releaseDate;
        }

        private readonly List<MarvelCard> cards = new List<MarvelCard>();

        public string Name { get; protected set; }
        public string Abbreviation { get; protected set; }
        public string ProductCode { get; protected set; }
        public ushort ProductNumber { get; protected set; }
        public DateTime ReleaseDate { get; protected set; }

        protected MarvelCard AddHero(string name, 
            byte thwart, byte attack, byte defense,
            byte handSize, byte hitPoints, params MarvelTrait[] traits)
        {
            var card = new MarvelCard
            {
                CardType = MarvelCardType.Hero,
                HeroName = name,
                Thwart = thwart,
                Attack = attack,
                Defense = defense,
                HeroHandSize = handSize,
                HeroHitPoints = hitPoints,
                Product = this,
                IsUnique = true,
            };
            card.WithHeroTraits(traits);
            cards.Add(card);
            return card;
        }

        public IEnumerable<MarvelCard> Cards()
        {
            return cards;
        }
    }
}