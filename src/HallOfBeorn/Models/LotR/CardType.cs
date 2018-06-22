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
}