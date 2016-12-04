using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace HallOfBeorn.Models.Arkham
{
    public enum ConnectionSymbol
    {
        None = 0,
        Study,
        Hallway,
        Attic,
        Cellar,
        Parlor,

        Your_House, //Sideways S on Green?
        Rivertown, //Circle on Yellow
        Southside, //Square on Red
        St_Marys_Hospital, //Cross on Red
        Misktaonic_University, //Diamong on Yellow
        Downtown, //Triangle on Blue
        Easttown, //Crescent on Purple?
        Graveyard, //Hourglass on Black
        Northside, //T on Black
        
        //The Devourer Below
        Main_Path, //Sideways Green S
        Arkham_Woods, //Brown Rectangle
        Arkham_Woods_Unhallowed_Ground, //Blue Triangle
        Arkham_Woods_Twisting_Paths, //Black T
        Arkham_Woods_Old_House, //Yellow Diamond
        Arkham_Woods_Cliffside, //Black Hourglass
        Arkham_Woods_Tangled_Thicket, //Brown Double Dash
        Arkham_Woods_Quiet_Glade, //Brown Crescent
        Ritual_Site, //Black Cross

        //Curse of the Rougarou
        Cursed_Shores,
        New_Orleans,
        Brackish_Waters,
        Riverside,
        Forgotten_Marsh,
        Wilderness,
        Foul_Swamp,
        Unhallowed_Land
    }
}