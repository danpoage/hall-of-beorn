using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace HallOfBeorn.Models
{
    public enum CardType
    {
        None = 0,
        Quest = 1,
        Nightmare_Setup = 2,
        Campaign = 3,
        GenCon_Setup = 4,
        Encounter = 11,
        Enemy = 12,
        Location = 13,
        Treachery = 14,
        Objective = 15,
        Objective_Ally = 16,
        Objective_Location = 17,
        Encounter_Side_Quest = 19,
        Player = 21,
        Character = 22,
        Hero = 23,
        Ally = 24,
        Attachment = 25,
        Event = 26,
        Treasure = 27,
        Player_Side_Quest = 28
    }
}