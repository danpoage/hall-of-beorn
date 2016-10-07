using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace HallOfBeorn.Models.Arkham
{
    public class Investigator : ArkhamCard
    {
        
        private readonly Dictionary<Skill, byte> skills = new Dictionary<Skill,byte>();

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

        public static Investigator New(string name, string nickName, ArkhamClass cl, byte health, byte sanity)
        {
            return new Investigator()
            {
                Name = name,
                NickName = nickName,
                Class = cl,
                Health = health,
                Sanity = sanity
            };
        }

        public Investigator WithTraits(params string[] traits)
        {
            addTraits(traits);
            return this;
        }

        public Investigator WithWillpower(byte willpower)
        {
            addSkill(Skill.Willpower, willpower);
            return this;
        }

        public Investigator WithIntellect(byte intellect)
        {
            addSkill(Skill.Intellect, intellect);
            return this;
        }

        public Investigator WithCombat(byte combat)
        {
            addSkill(Skill.Combat, combat);
            return this;
        }

        public Investigator WithAgility(byte agility)
        {
            addSkill(Skill.Agility, agility);
            return this;
        }

        public Investigator WithWild(byte wild)
        {
            addSkill(Skill.Wild, wild);
            return this;
        }

        public Investigator WithText(string text)
        {
            this.Text = text;
            return this;
        }

        public Investigator WithFlavor(string flavor)
        {
            this.Flavor = flavor;
            return this;
        }

        public Investigator WithInfo(byte number, byte quantity, string artist)
        {
            this.Number = number;
            this.Quanity = quantity;
            this.Artist = artist;
            return this;
        }
    }
}