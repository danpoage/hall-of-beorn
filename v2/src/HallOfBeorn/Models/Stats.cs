using System;
using System.Collections.Generic;

namespace HallOfBeorn.Models
{
    public class Stats
    {
        private readonly Dictionary<StatType, byte> map = new Dictionary<StatType, byte>();

        public const byte VALUE_X = 254;
        public const byte VALUE_NA = 255;

        private byte? GetValue(StatType type)
        {
            return map.ContainsKey(type)
                ? map[type]
                : (byte?)null;
        }

        private void SetValue(StatType type, byte value)
        {
            map[type] = value;
        }

        public Sphere? Sphere
        {
            get { return (Sphere?)GetValue(StatType.Sphere); }
        }

        public bool IsUnique
        {
            get { return GetValue(StatType.IsUnique) == (byte)Uniqueness.Unique; }
        }

        public byte? Willpower
        {
            get { return GetValue(StatType.Willpower); }
        }

        public byte? Threat
        {
            get { return GetValue(StatType.Threat); }
        }

        public byte? EngagementCost
        {
            get { return GetValue(StatType.Engagement_Cost); }
        }

        public byte? QuestPoints
        {
            get { return GetValue(StatType.Quest_Points); }
        }

        public void SetUnique()
        {
            SetValue(StatType.IsUnique, (byte)Uniqueness.Unique);
        }

        public void SetHeroStats(byte threatCost, Sphere sphere, byte willpower, byte attack, byte defense, byte hitPoints)
        {
            SetUnique();
            SetValue(StatType.Threat_Cost, threatCost);
            SetValue(StatType.Sphere, (byte)sphere);
            SetValue(StatType.Willpower, willpower);
            SetValue(StatType.Attack, attack);
            SetValue(StatType.Defense, defense);
            SetValue(StatType.Hit_Points, hitPoints);
        }

        public void SetAllyStats(byte resourceCost, Sphere sphere, byte willpower, byte attack, byte defense, byte hitPoints)
        {
            SetValue(StatType.Resource_Cost, resourceCost);
            SetValue(StatType.Sphere, (byte)sphere);
            SetValue(StatType.Willpower, willpower);
            SetValue(StatType.Attack, attack);
            SetValue(StatType.Defense, defense);
            SetValue(StatType.Hit_Points, hitPoints);
        }

        public void SetCostAndSphere(byte resourceCost, Sphere sphere)
        {
            SetValue(StatType.Resource_Cost, resourceCost);
            SetValue(StatType.Sphere, (byte)sphere);
        }

        public void SetQuestPoints(byte questPoints)
        {
            SetValue(StatType.Quest_Points, questPoints);
        }

        public void SetThreat(byte threat)
        {
            SetValue(StatType.Threat, threat);
        }
    }
}
