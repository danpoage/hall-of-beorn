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

        private void addCard(DigitalCard card)
        {
            cards.Add(card);
        }

        protected DigitalCardSet addHero(string title, DigitalSphere sphere, byte threatCost, byte attack, byte willpower, byte hitPoints, DigitalTrait trait, string text, string html, Artist artist)
        {
            var hero = new DigitalCard
            {
                Title = title,
                Sphere = sphere,
                CardType = DigitalCardType.Hero,
                IsUnique = true,
                Rarity = DigitalRarity.Hero,
                Slug = getSlug(title),
                ThreatCost = threatCost,
                Trait = trait,
                Attack = attack,
                Willpower = willpower,
                HitPoints = hitPoints,
                Text = text,
                Html = html,
                Artist = artist,
                CardSet = this,
            };

            addCard(hero);
            return this;
        }

        protected DigitalCard addAlly(string title, bool isUnique, DigitalSphere sphere, byte level, byte resourceCost, byte attack, byte willpower, byte hitPoints, DigitalTrait trait, string text, string html, Artist artist)
        {
            var ally = new DigitalCard
            {
                CardSet = this,
                CardType = DigitalCardType.Ally,
                Rarity = DigitalRarity.Starter,
                Slug = getSlug(title),

                Title = title,
                IsUnique = isUnique,
                Level = level,
                Sphere = sphere,
                ResourceCost = resourceCost,
                Attack = attack,
                Willpower = willpower,
                HitPoints = hitPoints,
                Trait = trait,
                Text = text,
                Html = html,
                Artist = artist
            };
            addCard(ally);
            return ally;
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