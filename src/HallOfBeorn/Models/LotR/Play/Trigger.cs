﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace HallOfBeorn.Models.LotR.Play
{
    public enum Trigger
    {
        After_Attached_Destroys_an_Enemy,

        After_Character_Declares_Attack,
        After_Character_Declares_Defense,
        After_Character_Destroyed,
        After_Character_Leaves_Play,
        After_Character_Enters_Play,
        
        After_Enemy_is_Revealed,
        After_Location_is_Revealed,

        After_Player_Raises_Threat,
        After_Player_Quests_Successfully,
        After_Player_Quests_Unsuccessfully,

        After_Self_Attack_Resolves,
        After_Self_Becomes_the_Active_Location,
        After_Self_Commits_to_Quest,
        After_Self_Declares_Attack,
        After_Self_Declares_Defense,
        After_Self_is_Destroyed,
        After_Self_Destroys_an_Enemy,
        After_Self_Engages,
        After_Self_Enters_Play,
        After_Self_Explored,
        After_Self_Leaves_Play,
        After_Self_Played_from_Hand,
        After_Self_Shadow_Card_Resolves,
        After_Self_Takes_Damage,
        
        After_Location_Progress_is_Placed,
        After_Quest_Progess_is_Placed,

        After_Shadow_is_Triggered,
        After_Travel,
        After_Treachery_is_Revealed,

        At_End_of_Phase,
        At_End_of_Round,

        Determine_Attachment_Targets,
        Determine_Attack_Targets,

        Determine_Card_Can_Ready_in_Refresh,
        Determine_Card_Cost,
        Determine_Card_Threat_Value,

        Determine_Character_Attack_Value,
        Determine_Character_Can_Attack,
        Determine_Character_Can_Defend,
        Determine_Character_Can_Quest,
        Determine_Character_Defense_Value,
        Determine_Character_Exhaust_to_Attack,
        Determine_Character_Exhaust_to_Defend,
        Determine_Character_Exhaust_to_Quest,
        Determine_Character_Has_Ranged,
        Determine_Character_Has_Sentinel,
        Determine_Character_Willpower_Value,
        Determine_Character_Damage_Received,

        Determine_Event_Target,

        Determine_Enemy_Can_Attack,
        Determine_Enemy_Can_Optionally_Engage,
        Determine_Enemy_Threat_Value,
        Determine_Enemy_Attack_Value,
        Determine_Enemy_Defense_Value,
        Determine_Enemy_Damage,
        Determine_Enemy_Shadow_Card_Dealt,

        Determine_Location_Travel_Option,

        Determine_Player_Can_Draw_Cards,
        Determine_Player_Cards_Drawn_in_Resource,
        Determine_Player_Threat_Raise_Refresh,

        Determine_Staging_Area_Threat,

        Determine_Hero_Resources_Collected_in_Resource,
        Determine_Hero_Sphere_Match,

        Encounter_Doomed,
        Encounter_Guarded,
        Encounter_Shadow,
        Encounter_Surge,

        Player_Action_Window,

        Travel,

        When_Revealed,

        When_Self_Attacks,
        When_Self_is_Attached,
        When_Self_Overkills,
        
    }
}
