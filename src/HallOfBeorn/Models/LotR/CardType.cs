using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace HallOfBeorn.Models.LotR
{
    public enum CardType
    {
        None = 0,
        Quest = 1,
        Nightmare_Setup = 2,
        Campaign = 3,
        GenCon_Setup = 4,
        Scenario = 5,
        Encounter = 11,
        Enemy = 12,
        Ship_Enemy = 13,
        Location = 16,
        Treachery = 18,
        Encounter_Side_Quest = 19,
        Objective = 21,
        Objective_Hero = 22,
        Objective_Ally = 23,
        Objective_Location = 25,
        Ship_Objective = 29,
        Player = 31,
        Character = 32,
        Hero = 33,
        Ally = 34,
        Attachment = 35,
        Event = 36,
        Treasure = 37,
        Player_Side_Quest = 38
    }
}