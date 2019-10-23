using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace HallOfBeorn.Models.LotR.Compact
{
    public enum CardType : byte
    {
        None = 0,
        
        Event = 128,                    //10000000
        Event_Boon = 132,               //10000100

        Contract = 136,                 //10001000
        Player_Side_Quest = 140,        //

        Attachment_Generic = 160,       //10100000
        Attachment_Unique = 162,        //10100010
        Attachment_Unique_Boon = 166,   //10100110

        Ally_Generic = 176,             //10110000
        Ally_Unique = 178,              //10110010

        Hero = 186,                     //10111010
        Hero_Alt_Art = 187,             //10111011

        
        /*

         */
    }
}