using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace HallOfBeorn.Models.LotR
{
    public enum CardEffectType: byte
    {
        None = 0,
        Action = 1,
        Resource_Action = 2,
        Planning_Action = 3,
        Quest_Action = 4,
        Travel_Action = 5,
        Encounter_Action = 6,
        Combat_Action = 7,
        Refresh_Action = 8,
        Response = 9,
        Forced = 10,
        Passive = 11,
        Setup = 12,
        When_Revealed = 13,
        Travel = 14,
        Shadow = 15,
        Flavor_Text = 16
    }
}