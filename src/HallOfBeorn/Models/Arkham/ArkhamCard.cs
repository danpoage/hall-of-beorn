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
            Subtitle = string.Empty;
            FrontText = string.Empty;
            FrontFlavor = string.Empty;
            BackText = string.Empty;
            BackFlavor = string.Empty;
        }

        private readonly List<string> traits = new List<string>();
        private readonly List<string> keywords = new List<string>();
        private readonly List<SkillIcon> skillTestIcons = new List<SkillIcon>();
        private readonly List<ConnectionSymbol> connections = new List<ConnectionSymbol>();

        public ArkhamProduct Product { get; set; }
        public ArkhamDeckType DeckType { get; set; }
        public ArkhamCardType CardType { get; set; }
        public ArkhamCardSubtype CardSubtype { get; set; }
        public string Title { get; private set; }
        public string Subtitle { get; private set; }
        public bool IsUnique { get; private set; }

        public Number? Willpower { get; private set; }
        public Number? Intellect { get; private set; }
        public Number? Combat { get; private set; }
        public Number? Agility { get; private set; }

        public Number? Cost { get; private set; }
        public byte? Level { get; private set; }
        public AssetSlot? Slot { get; private set; }
        
        public Number? Shroud { get; private set; }
        public Number? ClueValue { get; private set; }
        public ConnectionSymbol? LocationSymbol { get; private set; }

        public byte? Sequence { get; private set; }
        public Number? DoomThreshold { get; private set; }
        public Number? ClueThreshold { get; private set; }

        public Number? EnemyFightValue { get; private set; }
        public Number? EnemyHealthValue { get; private set; }
        public Number? EnemyEvadeValue { get; private set; }
        public Number? Damage { get; private set; }
        public Number? Horror { get; private set; }

        public string FrontText { get; protected set; }
        public string FrontFlavor { get; protected set; }
        public string BackText { get; private set; }
        public string BackFlavor { get; private set; }

        public ushort CardNumber { get; protected set; }
        public byte Quanity { get; protected set; }
        public Artist Artist { get; protected set; }

        public ClassSymbol ClassSymbol { get; private set; }
        public byte? Health { get; private set; }
        public byte? Sanity { get; private set; }
        public byte? VictoryPoints { get; private set; }
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
            var level = string.Empty;
            if (card.CardType == ArkhamCardType.Scenario_Reference) {
                level = card.Subtitle.Replace(" / ", "-");
            } else {
                level = (card.Level.HasValue && card.Level.Value > 0) ? card.Level.ToString() : string.Empty;
            }
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

        public IEnumerable<ConnectionSymbol> Connections()
        {
            return connections;
        }

        public static ArkhamCard Investigator(string title, string subtitle, ClassSymbol classSymbol, byte health, byte sanity)
        {
            return new ArkhamCard()
            {
                CardType = ArkhamCardType.Investigator,
                DeckType = ArkhamDeckType.Player,
                Title = title,
                IsUnique = true,
                Subtitle = subtitle,
                ClassSymbol = classSymbol,
                Health = health,
                Sanity = sanity
            };
        }

        public static ArkhamCard Asset(string title, ClassSymbol classSymbol, byte cost)
        {
            return Asset(title, classSymbol, cost, AssetSlot.None);
        }

        public static ArkhamCard Asset(string title, ClassSymbol classSymbol, byte cost, AssetSlot slot)
        {
            return Asset(title, classSymbol, Number.Of(cost), slot);
        }

        public static ArkhamCard Asset(string title, ClassSymbol classSymbol, Number cost, AssetSlot slot)
        {
            return new ArkhamCard()
            {
                CardType = ArkhamCardType.Asset,
                DeckType = ArkhamDeckType.Player,
                Title = title,
                ClassSymbol = classSymbol,
                Cost = cost,
                Slot = slot
            };
        }

        public static ArkhamCard Skill(string title, ClassSymbol classSymbol, byte level)
        {
            return new ArkhamCard
            {
                CardType = ArkhamCardType.Skill,
                DeckType = ArkhamDeckType.Player,
                Title = title,
                ClassSymbol = classSymbol,
                Level = level
            };
        }

        public static ArkhamCard Event(string title, ClassSymbol classSymbol, byte cost)
        {
            return Event(title, classSymbol, cost, 0);
        }

        public static ArkhamCard Event(string title, ClassSymbol classSymbol, byte cost, byte level)
        {
            return Event(title, classSymbol, Number.Of(cost), level);
        }

        public static ArkhamCard Event(string title, ClassSymbol classSymbol, Number cost, byte level)
        {
            return new ArkhamCard()
            {
                CardType = ArkhamCardType.Event,
                DeckType = ArkhamDeckType.Player,
                Title = title,
                ClassSymbol = classSymbol,
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
                EnemyFightValue = fightValue,
                EnemyHealthValue = healthValue,
                EnemyEvadeValue = evadeValue,
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

        public static ArkhamCard Treachery(string title, ArkhamCardSubtype subtype)
        {
            return new ArkhamCard
            {
                CardType = ArkhamCardType.Treachery,
                DeckType = ArkhamDeckType.Player,
                Title = title,
                CardSubtype = subtype
            };
        }

        public static ArkhamCard ScenarioReference(string title, string subtitle) 
        {
            return new ArkhamCard
            {
                CardType = ArkhamCardType.Scenario_Reference,
                DeckType = ArkhamDeckType.None,
                Title = title,
                Subtitle = subtitle
            };
        }

        public static ArkhamCard Agenda(string title, string subtitle, byte sequence, Number doomThreshold)
        {
            return new ArkhamCard()
            {
                CardType = ArkhamCardType.Agenda,
                DeckType = ArkhamDeckType.Agenda,
                Title = title,
                Subtitle = subtitle,
                Sequence = sequence,
                DoomThreshold = doomThreshold
            };
        }

        public static ArkhamCard Act(string title, string subtitle, byte sequence, Number clueThreshold)
        {
            return new ArkhamCard()
            {
                CardType = ArkhamCardType.Act,
                DeckType = ArkhamDeckType.Act,
                Title = title,
                Subtitle = subtitle,
                Sequence = sequence,
                ClueThreshold = clueThreshold
            };
        }

        public ArkhamCard WithUnique()
        {
            this.IsUnique = true;
            return this;
        }

        public ArkhamCard WithHealth(byte health)
        {
            this.Health = health;
            return this;
        }

        public ArkhamCard WithSanity(byte sanity)
        {
            this.Sanity = sanity;
            return this;
        }

        public ArkhamCard WithSubtype(ArkhamCardSubtype subtype)
        {
            this.CardSubtype = subtype;
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

        public ArkhamCard WithLevel(byte level)
        {
            this.Level = level;
            return this;
        }

        public ArkhamCard WithAssetSlot(AssetSlot slot)
        {
            this.Slot = slot;
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

        public ArkhamCard WithIcons(params SkillIcon[] skillIcons)
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

        public ArkhamCard WithText(string text)
        {
            return WithFrontText(text);
        }

        public ArkhamCard WithFlavor(string flavor)
        {
            return WithFrontFlavor(flavor);
        }

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