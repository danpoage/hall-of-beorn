using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace HallOfBeorn.Models.LotR.Compact
{
    public enum CardType : byte
    {
        None = 0,
        
        //Player Cards
        PLAYER_CARD = 128,
        
        PLAYER_CHARACTER = 176,
        Hero = 186,
        Hero_Alt_Art = 187,
        
        ALLY = 161,
        Ally_Generic = 161,
        Ally_Unique	= 178,
        
        ATTACHMENT = 144,
        Attachment_Generic = 144,
        Attachment_Unique = 146,
        Attachment_Unique_Boon = 150,
        
        Event = 128,
        Event_Boon = 132,

        Player_Side_Quest = 160,
        
        Contract = 136,
    
	    //Encounter Cards (Non-Objective)
        ENCOUNTER_CARD = 64,
        
        ENEMY = 112,
        Enemy_Generic = 112,
        Enemy_Unique = 114,
        Ship_Enemy_Generic = 116,
        Ship_Enemy_Unique = 118,
        
        LOCATION = 96,
        Location_Unique = 98,
        Location_Generic = 96,

        Treachery = 64,
        Encounter_Side_Quest = 100,
	
        //Encounter Cards (Objective)
        ENCOUNTER_OBJECTIVE = 192,
        Objective_Hero = 250,
        Objective_Ally_Unique = 242,
        Objective_Ally_Generic = 240,
        Objective_Location_Unique = 226,
        Objective_Location_Generic = 224,
        Objective_Unique = 194,
        Objective_Generic = 192,
	
	    //Quest Cards
        Quest = 40,
        Campaign = 12,
        Setup = 9,
        Rules = 4,
        Rules_POD = 5,
    }
}
