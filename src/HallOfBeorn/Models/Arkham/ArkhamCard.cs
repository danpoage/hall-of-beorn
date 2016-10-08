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
            Cost = ArkhamCardCost.NA;
            Level = ArkhamCardLevel.NA;
            ItemSlot = ArkhamItemSlot.NA;
        }

        private readonly List<string> traits = new List<string>();

        public ArkhamProduct Product { get; set; }
        public ArkhamDeckType DeckType { get; set; }
        public ArkhamCardType CardType { get; set; }
        public string Name { get; protected set; }
        public bool IsUnique { get; protected set; }

        public ArkhamCardCost Cost { get; protected set; }
        public ArkhamCardLevel Level { get; protected set; }
        public ArkhamItemSlot ItemSlot { get; protected set; }
        
        public string Text { get; protected set; }
        public string Flavor { get; protected set; }

        public ushort Number { get; protected set; }
        public byte Quanity { get; protected set; }
        public Artist Artist { get; protected set; }

        private readonly Dictionary<Skill, byte> skills = new Dictionary<Skill, byte>();

        public string NickName { get; private set; }
        public ArkhamClass Class { get; private set; }
        public byte Health { get; private set; }
        public byte Sanity { get; private set; }

        protected void addSkill(Skill skill, byte value)
        {
            skills.Add(skill, value);
        }

        public IEnumerable<KeyValuePair<Skill, byte>> Skills()
        {
            return skills;
        }

        public static ArkhamCard Investigator(string name, string nickName, ArkhamClass cl, byte health, byte sanity)
        {
            return new ArkhamCard()
            {
                CardType = ArkhamCardType.Investigator,
                DeckType = ArkhamDeckType.Player,
                Name = name,
                IsUnique = true,
                NickName = nickName,
                Class = cl,
                Health = health,
                Sanity = sanity
            };
        }

        public static ArkhamCard Asset(string name, ArkhamClass cl, ArkhamCardCost cost, ArkhamItemSlot itemSlot)
        {
            return new ArkhamCard()
            {
                CardType = ArkhamCardType.Asset,
                DeckType = ArkhamDeckType.Player,
                Name = name,
                Class = cl,
                Cost = cost,
                ItemSlot = itemSlot
            };
        }

        public ArkhamCard WithUnique()
        {
            this.IsUnique = true;
            return this;
        }

        public ArkhamCard WithTraits(params string[] traits)
        {
            addTraits(traits);
            return this;
        }

        public ArkhamCard WithCost(ArkhamCardCost cost)
        {
            this.Cost = cost;
            return this;
        }

        public ArkhamCard WithLevel(ArkhamCardLevel level)
        {
            this.Level = level;
            return this;
        }

        public ArkhamCard WithItemSlot(ArkhamItemSlot itemSlot)
        {
            this.ItemSlot = itemSlot;
            return this;
        }

        public ArkhamCard WithWillpower(byte willpower)
        {
            addSkill(Skill.Willpower, willpower);
            return this;
        }

        public ArkhamCard WithIntellect(byte intellect)
        {
            addSkill(Skill.Intellect, intellect);
            return this;
        }

        public ArkhamCard WithCombat(byte combat)
        {
            addSkill(Skill.Combat, combat);
            return this;
        }

        public ArkhamCard WithAgility(byte agility)
        {
            addSkill(Skill.Agility, agility);
            return this;
        }

        public ArkhamCard WithWild(byte wild)
        {
            addSkill(Skill.Wild, wild);
            return this;
        }

        public ArkhamCard WithText(string text)
        {
            this.Text = text;
            return this;
        }

        public ArkhamCard WithFlavor(string flavor)
        {
            this.Flavor = flavor;
            return this;
        }

        public ArkhamCard WithInfo(byte number, byte quantity, Artist artist)
        {
            this.Number = number;
            this.Quanity = quantity;
            this.Artist = artist;
            return this;
        }

        protected void addTraits(IEnumerable<string> traits)
        {
            this.traits.AddRange(traits);
        }

        public IEnumerable<string> Traits()
        {
            return traits;
        }
    }
}