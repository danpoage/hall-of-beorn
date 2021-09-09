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
            return string.Format("{0}-{1}", title.NormalizeCaseSensitiveString().Replace(" ", "-"), Slug);
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
                CardSet = this,
                CardType = DigitalCardType.Hero,
                Rarity = DigitalRarity.Hero,
                Slug = getSlug(title),
                Title = title,
                Sphere = sphere,
                
                IsUnique = true,                
                ThreatCost = threatCost,
                Trait = trait,
                Attack = attack,
                Willpower = willpower,
                HitPoints = hitPoints,
                Text = text,
                //Html = html,
                Artist = artist,
                
            };

            addCard(hero);
            return this;
        }

        protected DigitalCard addAlly(string title, bool isUnique, DigitalSphere sphere, byte level, byte cost, byte attack, byte willpower, byte hitPoints, DigitalTrait trait, string text, string html, Artist artist, DigitalRarity rarity = DigitalRarity.Starter)
        {
            var ally = new DigitalCard
            {
                CardSet = this,
                CardType = DigitalCardType.Ally,
                Rarity = rarity,
                Slug = getSlug(title),

                Title = title,
                IsUnique = isUnique,
                Level = level,
                Sphere = sphere,
                ResourceCost = cost,
                Attack = attack,
                Willpower = willpower,
                HitPoints = hitPoints,
                Trait = trait,
                Text = text,
                //Html = html,
                Artist = artist
            };
            addCard(ally);
            return ally;
        }

        protected DigitalCard addAttachment(string title, bool isUnique, DigitalSphere sphere, byte level, byte cost, 
            AttachmentSlot slot, string text, string html, Artist artist, DigitalRarity rarity = DigitalRarity.Starter)
        {
            var attachment = new DigitalCard
            {
                CardSet = this,
                CardType = DigitalCardType.Attachment,
                Rarity = rarity,
                Slug = getSlug(title),

                Title = title,
                IsUnique = isUnique,
                Level = level,
                Sphere = sphere,
                ResourceCost = cost,
                Slot = slot,
                Text = text,
                //Html = html,
                Artist = artist
            };
            addCard(attachment);
            return attachment;
        }

        //Advance Warning	Lore	1	1	Preparation	Exhaust the next Enemy that enters play during the Adventure phase
        protected DigitalCard addEvent(string title, DigitalSphere sphere, byte level, byte cost, 
            DigitalTrait? trait, string text, string html, Artist artist, DigitalRarity rarity = DigitalRarity.Starter)
        {
            var eventCard = new DigitalCard
            {
                CardSet = this,
                CardType = DigitalCardType.Event,
                Rarity = rarity,
                Slug = getSlug(title),

                Title = title,
                IsUnique = false,
                Level = level,
                Sphere = sphere,
                ResourceCost = cost,
                Trait = trait,
                Text = text,
                //Html = html,
                Artist = artist
            };
            addCard(eventCard);
            return eventCard;
        }

        public string Name { get; private set; }

        public string Slug { get; protected set; }

        public string Abbreviation { get; protected set; }

        public bool IsSpoiler { get; protected set; }

        public DigitalProduct Product { get; set; }
        
        public List<DigitalCard> Cards { get { return cards; } }

        public IEnumerable<string> Labels()
        {
            return Cards.Select(c => c.Title);
        }

        #region Static Properties
        public static DigitalCardSet Starter = new CardSets.StarterSet();
        public static DigitalCardSet ValorCards = new CardSets.ValorCards();
        public static DigitalCardSet DwalinPack = new CardSets.DwalinPack();
        public static DigitalCardSet EowynPack = new CardSets.EowynPack();
        public static DigitalCardSet FaramirPack = new CardSets.FaramirPack();
        public static DigitalCardSet LegolasPack = new CardSets.LegolasPack();
        #endregion
    }
}