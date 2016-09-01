using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace HallOfBeorn.Models
{
    public enum ErrataVersion
    {
        Any = 0,
        No_Errata = -1,
        Has_Errata = 1,
        FAQ_1_1 = 11,
        FAQ_1_2 = 12,
        FAQ_1_3 = 13,
        FAQ_1_4 = 14,
        FAQ_1_5 = 15,
        FAQ_1_6 = 16,
        FAQ_1_7 = 17
    }
}