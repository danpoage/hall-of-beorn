using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace HallOfBeorn.Models.Arkham
{
    public class ArkhamEncounterSet
    {
        public string Name { get; private set; }

        private static List<ArkhamEncounterSet> all = new List<ArkhamEncounterSet>();

        static ArkhamEncounterSet()
        {
            all.Add(TheGathering);
            all.Add(TheMidnightMasks);
            all.Add(TheDevourerBelow);
            all.Add(CultOfUmordhoth);
            all.Add(Rats);
            all.Add(Ghouls);
            all.Add(StrikingFear);
            all.Add(AncientEvils);
            all.Add(ChillingCold);
            all.Add(DarkCult);
            all.Add(Nightguants);
            all.Add(LockedDoors);
            all.Add(AgentsOfHastur);
            all.Add(AgentsOfYoSothoth);
            all.Add(AgentsOfShubNiggurath);
            all.Add(AgentsOfCthulhu);
            
            all.Add(CurseOfTheRougarou);
            all.Add(TheBayou);
        }

        public static List<ArkhamEncounterSet> All()
        {
            return all;
        }

        public static ArkhamEncounterSet TheGathering = new ArkhamEncounterSet { Name = "The Gathering" };
        public static ArkhamEncounterSet TheMidnightMasks = new ArkhamEncounterSet { Name = "The Midnight Masks" };
        public static ArkhamEncounterSet TheDevourerBelow = new ArkhamEncounterSet { Name = "The Devourer Below" };
        public static ArkhamEncounterSet CultOfUmordhoth = new ArkhamEncounterSet { Name = "Cult of Umordhoth" };
        public static ArkhamEncounterSet Rats = new ArkhamEncounterSet { Name = "Rats" };
        public static ArkhamEncounterSet Ghouls = new ArkhamEncounterSet { Name = "Ghouls" };
        public static ArkhamEncounterSet StrikingFear = new ArkhamEncounterSet { Name = "Striking Fear" };
        public static ArkhamEncounterSet AncientEvils = new ArkhamEncounterSet { Name = "Ancient Evils" };
        public static ArkhamEncounterSet ChillingCold = new ArkhamEncounterSet { Name = "Chilling Cold" };
        public static ArkhamEncounterSet DarkCult = new ArkhamEncounterSet { Name = "Dark Cult" };
        public static ArkhamEncounterSet Nightguants = new ArkhamEncounterSet { Name = "Nightgaunts" };
        public static ArkhamEncounterSet LockedDoors = new ArkhamEncounterSet { Name = "Locked Doors" };
        public static ArkhamEncounterSet AgentsOfYoSothoth = new ArkhamEncounterSet { Name = "Agents of Yo-Sothoth" };
        public static ArkhamEncounterSet AgentsOfShubNiggurath = new ArkhamEncounterSet { Name = "Agents of Shub-Niggurath" };
        public static ArkhamEncounterSet AgentsOfCthulhu = new ArkhamEncounterSet { Name = "Agents of Cthulhu" };
        public static ArkhamEncounterSet AgentsOfHastur = new ArkhamEncounterSet { Name = "Agents of Hastur" };

        public static ArkhamEncounterSet CurseOfTheRougarou = new ArkhamEncounterSet { Name = "Curse of the Rougarou" };
        public static ArkhamEncounterSet TheBayou = new ArkhamEncounterSet { Name = "The Bayou" };

        public static ArkhamEncounterSet ExtracurricularActivity = new ArkhamEncounterSet { Name = "Extracurricular Activity" };
        public static ArkhamEncounterSet TheHouseAlwaysWins = new ArkhamEncounterSet { Name = "The House Always Wins" };
        public static ArkhamEncounterSet BeastThralls = new ArkhamEncounterSet { Name = "Beast-thralls" };
        public static ArkhamEncounterSet Sorcery = new ArkhamEncounterSet { Name = "Sorcery" };
        public static ArkhamEncounterSet HideousAbominations = new ArkhamEncounterSet { Name = "Hideous Abominations" };
        public static ArkhamEncounterSet BadLuck = new ArkhamEncounterSet { Name = "Bad Luck" };
    }
}