using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace HallOfBeorn.Models.Arkham
{
    public class ArkhamCard
    {
        private ArkhamCard()
        {
            Level = Level.NA;
            AssetSlot = AssetSlot.NA;
        }

        private readonly List<string> traits = new List<string>();
        private readonly List<string> keywords = new List<string>();
        private readonly List<SkillIcon> skillTestIcons = new List<SkillIcon>();
        private readonly List<ConnectionSymbol> connections = new List<ConnectionSymbol>();

        public ArkhamProduct Product { get; set; }
        public ArkhamDeckType DeckType { get; set; }
        public ArkhamCardType CardType { get; set; }
        public string Title { get; protected set; }
        public string Subtitle { get; private set; }
        public bool IsUnique { get; protected set; }

        public Number? Willpower { get; protected set; }
        public Number? Intellect { get; protected set; }
        public Number? Combat { get; protected set; }
        public Number? Agility { get; protected set; }

        public Number? Cost { get; protected set; }
        public Level Level { get; protected set; }
        public AssetSlot AssetSlot { get; protected set; }
        
        public Number? Shroud { get; protected set; }
        public Number? ClueValue { get; protected set; }
        public ConnectionSymbol? LocationSymbol { get; private set; }

        public Number? DoomThreshold { get; private set; }
        public Number? ClueThreshold { get; private set; }

        public Number? FightValue { get; private set; }
        public Number? HealthValue { get; private set; }
        public Number? EvadeValue { get; private set; }
        public Number? Damage { get; private set; }
        public Number? Horror { get; private set; }

        public string FrontText { get; protected set; }
        public string FrontFlavor { get; protected set; }
        public string BackText { get; private set; }
        public string BackFlavor { get; private set; }

        public ushort CardNumber { get; protected set; }
        public byte Quanity { get; protected set; }
        public Artist Artist { get; protected set; }

        public ClassSymbol Class { get; private set; }
        public byte Health { get; private set; }
        public byte Sanity { get; private set; }
        public byte VictoryPoints { get; private set; }
        public ArkhamEncounterSet EncounterSet { get; private set; }

        protected void addTraits(IEnumerable<string> traits)
        {
            this.traits.AddRange(traits);
        }

        protected void addKeywords(IEnumerable<string> keywords)
        {
            this.keywords.AddRange(keywords);
        }

        protected void addSkillTestIcons(IEnumerable<SkillIcon> skillIcons)
        {
            this.skillTestIcons.AddRange(skillIcons);
        }

        public static string GetSlug(ArkhamCard card)
        {
            var name = card.Title.ToUrlSafeString();
            var level = (card.Level != Level.NA && card.Level != Level.Zero) ? ((sbyte)card.Level).ToString() : string.Empty;
            var product = card.Product.Abbreviation;
            return string.Format("{0}{1}-{2}", name, level, product);
        }

        public string Slug
        {
            get { return GetSlug(this); }
        }

        public IEnumerable<string> Traits()
        {
            return traits;
        }

        public IEnumerable<string> Keywords()
        {
            return keywords;
        }

        public IEnumerable<SkillIcon> SkillIcons()
        {
            return skillTestIcons;
        }

        public static ArkhamCard Investigator(string title, string subtitle, ClassSymbol cl, byte health, byte sanity)
        {
            return new ArkhamCard()
            {
                CardType = ArkhamCardType.Investigator,
                DeckType = ArkhamDeckType.Player,
                Title = title,
                IsUnique = true,
                Subtitle = subtitle,
                Class = cl,
                Health = health,
                Sanity = sanity
            };
        }

        public static ArkhamCard Asset(string title, ClassSymbol cl, Number cost, AssetSlot assetSlot)
        {
            return new ArkhamCard()
            {
                CardType = ArkhamCardType.Asset,
                DeckType = ArkhamDeckType.Player,
                Title = title,
                Class = cl,
                Cost = cost,
                AssetSlot = assetSlot
            };
        }

        public static ArkhamCard Event(string title, ClassSymbol cl, Number cost, Level level)
        {
            return new ArkhamCard()
            {
                CardType = ArkhamCardType.Event,
                DeckType = ArkhamDeckType.Player,
                Title = title,
                Class = cl,
                Cost = cost,
                Level = level
            };
        }

        public static ArkhamCard Enemy(string title, Number fightValue, Number healthValue, Number evadeValue, Number damage, Number horror)
        {
            return new ArkhamCard()
            {
                CardType = ArkhamCardType.Enemy,
                DeckType = ArkhamDeckType.Encounter,
                Title = title,
                FightValue = fightValue,
                HealthValue = healthValue,
                EvadeValue = evadeValue,
                Damage = damage,
                Horror = horror
            };
        }

        public static ArkhamCard Location(string title, ConnectionSymbol locationSymbol, Number shroud, Number clueValue)
        {
            return new ArkhamCard()
            {
                CardType = ArkhamCardType.Location,
                DeckType = ArkhamDeckType.Encounter,
                Title = title,
                LocationSymbol = locationSymbol,
                Shroud = shroud,
                ClueValue = clueValue
            };
        }

        public ArkhamCard WithUnique()
        {
            this.IsUnique = true;
            return this;
        }

        public ArkhamCard WithSubtitle(string subtitle)
        {
            this.Subtitle = subtitle;
            return this;
        }

        public ArkhamCard WithTraits(params string[] traits)
        {
            addTraits(traits);
            return this;
        }

        public ArkhamCard WithKeywords(params string[] keywords)
        {
            addKeywords(keywords);
            return this;
        }

        public ArkhamCard WithCost(Number cost)
        {
            this.Cost = cost;
            return this;
        }

        public ArkhamCard WithLevel(Level level)
        {
            this.Level = level;
            return this;
        }

        public ArkhamCard WithAssetSlot(AssetSlot assetSlot)
        {
            this.AssetSlot = assetSlot;
            return this;
        }

        public ArkhamCard WithVictoryPoints(byte victoryPoints)
        {
            this.VictoryPoints = victoryPoints;
            return this;
        }

        public ArkhamCard WithConnections(params ConnectionSymbol[] connections)
        {
            this.connections.AddRange(connections);
            return this;
        }

        public ArkhamCard WithSkills(byte willpower, byte intellect, byte combat, byte agility)
        {
            this.Willpower = Number.Of(willpower);
            this.Intellect = Number.Of(intellect);
            this.Combat = Number.Of(combat);
            this.Agility = Number.Of(agility);
            return this;
        }

        public ArkhamCard WithSkillTestIcons(params SkillIcon[] skillIcons)
        {
            addSkillTestIcons(skillIcons);
            return this;
        }

        public ArkhamCard WithShroud(byte value, bool perInvestigator, bool isX)
        {
            this.Shroud = new Number { Value = value, IsPerInvestigator = perInvestigator, IsX = isX };
            return this;
        }

        public ArkhamCard WithClueValue(byte value, bool perInvestigator, bool isX)
        {
            this.ClueValue = new Number { Value = value, IsPerInvestigator = perInvestigator, IsX = isX };
            return this;
        }

        public ArkhamCard WithDoomThreshold(Number doomThreshold)
        {
            this.DoomThreshold = doomThreshold;
            return this;
        }

        public ArkhamCard WithClueThreshold(Number clueThreshold)
        {
            this.ClueThreshold = clueThreshold;
            return this;
        }

        /*
        public ArkhamCard WithDamage(byte? damage)
        {
            this.Damage = damage;
            return this;
        }

        public ArkhamCard WithHorror(byte? horror)
        {
            this.Horror = horror;
            return this;
        }
        */

        public ArkhamCard WithFrontText(string text)
        {
            this.FrontText = text;
            return this;
        }

        public ArkhamCard WithFrontFlavor(string flavor)
        {
            this.FrontFlavor = flavor;
            return this;
        }

        public ArkhamCard WithBackText(string text)
        {
            this.BackText = text;
            return this;
        }

        public ArkhamCard WithBackFlavor(string flavor)
        {
            this.BackFlavor = flavor;
            return this;
        }

        public ArkhamCard WithInfo(byte cardNumber, byte quantity, Artist artist)
        {
            this.CardNumber = cardNumber;
            this.Quanity = quantity;
            this.Artist = artist;
            return this;
        }
    }
}