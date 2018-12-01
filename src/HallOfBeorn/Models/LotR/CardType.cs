using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace HallOfBeorn.Models.LotR
{
    public enum CardType
    {
        None = 0,
        Player = 31,
        Character = 32,
        Hero = 33,
        Ally = 34,
        Attachment = 35,
        Event = 36,
        Treasure = 37,
        Player_Side_Quest = 38,
        Quest = 100,
        Setup = 101,
        Nightmare_Setup = 102,
        Campaign = 103,
        GenCon_Setup = 104,
        Scenario = 105,
        Encounter = 111,
        Enemy = 112,
        Ship_Enemy = 113,
        Location = 116,
        Treachery = 118,
        Encounter_Side_Quest = 119,
        Objective = 121,
        Objective_Hero = 122,
        Objective_Ally = 123,
        Objective_Location = 125,
        Ship_Objective = 129,
    }

    public static class CardTypeExtensionMethods
    {
        public static bool IsPlayerCard(this CardType self)
        {
            switch (self)
            {
                case CardType.Hero:
                case CardType.Ally:
                case CardType.Attachment:
                case CardType.Event:
                case CardType.Player_Side_Quest:
                case CardType.Treasure:
                    return true;
                default:
                    return false;
            }
        }

        public static bool IsEncounterCard(this CardType self)
        {
            switch (self)
            {
                case CardType.Encounter:
                case CardType.Encounter_Side_Quest:
                case CardType.Enemy:
                case CardType.Location:
                case CardType.Treachery:
                case CardType.Objective:
                case CardType.Objective_Ally:
                case CardType.Objective_Hero:
                case CardType.Objective_Location:
                case CardType.Ship_Enemy:
                case CardType.Ship_Objective:
                case CardType.Treasure:
                    return true;
                default:
                    return false;
            }
        }

        public static bool IsQuestCard(this CardType self)
        {
            switch (self)
            {
                case CardType.Quest:
                case CardType.Campaign:
                case CardType.GenCon_Setup:
                case CardType.Nightmare_Setup:
                case CardType.Scenario:
                    return true;
                default:
                    return false;
            }
        }
    }
}