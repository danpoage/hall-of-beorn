namespace HallOfBeorn.Models.LotR.Play
{
    public enum SetupStep
    {
        None = 0,
        Setup_Begin,
        Setup_Shuffle_Decks,
        Setup_Place_Heroes_And_Set_Initial_Threat_Levels,
        Setup_Create_Token_Bank,
        Setup_Determine_First_Player,
        Setup_Draw_Setup_Hand,
        Setup_Quest_Cards,
        Setup_Follow_Scenario_Setup_Instructions,
        Setup_End,
    }

    public enum FrameworkStep
    {
        None = 0,

        Round_Begin,// = 100,

        Resource_Begin, // = 110,
        Resource_Gain_Resources, // = 120,
        Resource_Draw_Cards, // = 130,
        //Resource_Before_End_Player_Action_Window = 135,
        Resource_End, // = 140,

        Planning_Begin, // = 210,
        Planning_Special_Player_Action_Window, // = 220,
        Planning_Next_Player_Becomes_Active, // = 230,
        Planning_End, // = 240,

        Quest_Begin, // = 310,
        //Quest_Before_Commit_Player_Action_Window,
        Quest_Commit_Characters, // = 320,
        //Quest_Before_Staging_Player_Action_Window,
        Quest_Staging , //= 330,
        //Quest_Before_Resolution_Player_Action_Window,
        Quest_Resolution, // = 340,
        //Quest_Before_End_Player_Action_Window,
        Quest_End, // = 350,

        Travel_Begin, // = 410,
        Travel_Opportunity, // = 420,
        //Travel_Before_End_Player_Action_Window,
        Travel_End, // = 430,

        Encounter_Begin, // = 510,
        Encounter_Optional_Engagement, // = 520,
        //Encounter_Before_Engagement_Checks_Player_Action_Window,
        Encounter_Engagement_Checks, // = 530,
        //Encounter_Before_End_Player_Action_Window,
        Encounter_End, // = 540,

        Combat_Begin, // = 610,
        Combat_Deal_Shadow_Cards, // = 620,
        //Combat_Before_Enemy_Attacks_Player_Action_Window,
        Combat_Resolve_Enemy_Attacks_Begin, // = 630,

        Enemy_Attack_Initiates, // = 640,
        //Enemy_Attack_Before_Declare_Defender_Player_Action_Window,
        Enemy_Attack_Declare_Defender, // = 641,
        //Enemy_Attack_Before_Resolve_Shadow_Effects_Player_Action_Window,
        Enemy_Attack_Resolve_Shadow_Effects, // = 642,
        //Enemy_Attack_Before_Determine_Combat_Damage_Player_Action_Window,
        Enemy_Attack_Determine_Combat_Damage, // = 643,
        //Enemy_Attack_Before_End_Player_Action_Window,
        Enemy_Attack_Resolved, // = 644,
        Enemy_Attack_Next_Player_Becomes_Active, // = 6500,

        Combat_Resolve_Enemy_Attacks_End, // = 6600,

        Combat_Player_Attacks_Begin, // = 6700,

        Player_Attack_Initiates, // = 6800,
        Player_Attack_Ranged_Option, // = 6810,
        //Player_Attack_Before_Determine_Attack_Strength_Player_Action_Window,
        Player_Attack_Determine_Attack_Strength, // = 6820,
        //Player_Attack_Before_Determine_Combat_Damage_Player_Action_Window,
        Player_Attack_Determine_Combat_Damage, // = 6830,
        //Player_Attack_Befre_End_Player_Action_Window,
        Player_Attack_Resolved, // = 6840,
        Player_Attack_Next_Player_Becomes_Active, // = 6900,
        
        Combat_Player_Attacks_End, // = 6100,
        //Combat_Before_End_Player_Action_Window,
        Combat_End_Discard_All_Shadow_Cards, // = 6110,

        Refresh_Begin, // = 7100,
        Refresh_Ready_All_Cards, // = 7200,
        Refresh_Raise_Threat, // = 7300,
        Refresh_Pass_First_Player_Token, // = 7400,
        //Refresh_Before_End_Player_Action_Window = 741,
        Refresh_End, // = 7500,

        Round_End, // = 10000,
    }
}