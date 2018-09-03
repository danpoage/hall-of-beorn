using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace HallOfBeorn.Models.Digital
{
    public abstract class DigitalCardSet : ICardSet<DigitalProduct, DigitalCard>
    {
        protected DigitalCardSet(string name, string slug)
        {
            Name = name;
            Slug = slug;

            Initialize();
        }

        private readonly List<DigitalCard> cards = new List<DigitalCard>();

        private string getSlug(string title)
        {
            return string.Format("{0}-{1}", title.NormalizeCaseSensitiveString(), Slug);
        }

        protected abstract void Initialize();

        protected DigitalCardSet addHero(string title, DigitalSphere sphere, byte threatCost, byte attack, byte willpower, byte hitPoints, DigitalCardTrait trait, string text)
        {
            var hero = new DigitalCard
            {
                Title = title,
                CardType = DigitalCardType.Hero,
                IsUnique = true,
                Slug = getSlug(title),
                ThreatCost = threatCost,
                Trait = trait,
                Attack = attack,
                Willpower = willpower,
                HitPoints = hitPoints,
                Text = text,
                CardSet = this,
            };

            cards.Add(hero);
            return this;
        }

        public string Name { get; private set; }

        public string Slug { get; protected set; }

        public string Abbreviation { get; protected set; }

        public bool IsSpoiler { get; protected set; }

        public DigitalProduct Product { get; set; }
        
        public List<DigitalCard> Cards { get { return cards; } }

        #region Static Properties
        public static DigitalCardSet Starter = new CardSets.StarterSet();
        #endregion
    }
}