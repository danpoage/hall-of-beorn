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
HR          1   0   1   1   1   0   1   0
HR_ALT	    1	0	1	1	1	0	1	1
AL_UNQ	    1	0	1	1	0	0	1	0
AL_GEN	    1	0	1	1	0	0	0	0
AT_UNQ	    1	0	1	0	0	0	1	0
AT_GEN	    1	0	1	0	0	0	0	0
AT_UNQ_BON	1	0	1	0	0	1	1	0
EV	        1	0	0	0	0	0	0	0
EV_BON	    1	0	0	0	0	1	0	0
CNT	        1	0	0	0	1	0	0	0
PSQ	        1	0	1	0	0	0	0	0
								
ED								
EN_UNQ	    0	1	1	1	0	0	1	0
EN_GEN	    0	1	1	1	0	0	0	0
SE_UNQ	    0	1	1	1	0	1	1	0
SE_GEN	    0	1	1	1	0	1	0	0
LC_UNQ	    0	1	1	0	0	0	1	0
LC_GEN	    0	1	1	0	0	0	0	0
TR	        0	1	0	0	0	0	0	0
ESQ	        0	1	1	0	0	0	0	0
OBJ_H_UNQ	0	1	1	1	1	1	1	0
OBJ_A_UNQ	0	1	1	1	0	1	1	0
OBJ_A_GEN	0	1	1	1	0	1	0	0
OBJ_L_UNQ	0	1	1	0	0	1	1	0
OBJ_L_GEN	0	1	1	0	0	1	0	0
OBJ_UNQ	0	1	0	0	0	1	1	0
OBJ_GEN	0	1	0	0	0	1	0	0
								
QD								
QST	        0	0	1	0	1	0	0	0
CAMP	    0	0	0	0	1	0	0	0
SETUP	    0	0	0	0	1	0	0	1
RULES	    0	0	0	0	0	0	0	0
RULES_POD	0	0	0	0	0	0	0	1
         */
    }
}