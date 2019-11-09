using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace HallOfBeorn.Models.Marvel
{
    public class MarvelCard
        : Card
    {
        public MarvelCardType CardType { get; set; }
        public string HeroName { get; set; }
        public byte? Thwart { get; set; }
        public byte? Attack { get; set; }
        public byte? Defense { get; set; }
        public byte? HeroHandSize { get; set; }
        public byte? HeroHitPoints { get; set; }
        public List<MarvelTrait> HeroTraits { get { return heroTraits; } }
        public string HeroText { get; private set; }
        public string HeroFlavorText { get; private set; }

        public string AlterEgoName { get; set; }
        public byte? Recover { get; set; }
        public byte? AlterEgoHandSize { get; set; }
        public byte? AlterEgoHitPoints { get; set; }
        public List<MarvelTrait> AlterEgoTraits { get { return alterEgoTraits; } }
        public string AlterEgoText { get; private set; }
        public string AlterEgoFlavorText { get; private set; }
        
        public string SetName { get; private set; }
        public byte? SetItemNumber { get; private set; }
        public byte? SetItemTotal { get; private set; }

        public MarvelProduct Product { get; set; }

        private readonly List<MarvelTrait> heroTraits = new List<MarvelTrait>();
        private readonly List<MarvelTrait> alterEgoTraits = new List<MarvelTrait>();

        public MarvelCard WithHeroTraits(params MarvelTrait[] traits)
        {
            heroTraits.AddRange(traits);
            return this;
        }

        public MarvelCard WithAlterEgo(string name, byte recover, byte handSize, byte hitPoints, 
            params MarvelTrait[] traits)
        {
            AlterEgoName = name;
            Recover = recover;
            AlterEgoHandSize = handSize;
            AlterEgoHitPoints = hitPoints;
            alterEgoTraits.AddRange(traits);

            SetTitle(Language.EN, string.Format("{0} ({1})", HeroName, AlterEgoName));
            return this;
        }

        public MarvelCard WithHeroText(string text)
        {
            HeroText = text;
            return this;
        }

        public MarvelCard WithHeroFlavorText(string flavorText)
        {
            HeroFlavorText = flavorText;
            return this;
        }

        public MarvelCard WithAlterEgoText(string text)
        {
            AlterEgoText = text;
            return this;
        }

        public MarvelCard WithAlterEgoFlavorText(string flavorText)
        {
            AlterEgoFlavorText = flavorText;
            return this;
        }

        public MarvelCard WithSetInfo(string setName, byte itemNumber, byte itemTotal)
        {
            SetName = setName;
            SetItemNumber = itemNumber;
            SetItemTotal = itemTotal;
            return this;
        }

        public MarvelCard WithInfo(byte cardNumber, byte quantity)
        {
            this.CardNumber = cardNumber;
            this.Quantity = quantity;
            return this;
        }
    }
}
