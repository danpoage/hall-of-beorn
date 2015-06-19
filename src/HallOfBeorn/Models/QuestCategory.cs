using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace HallOfBeorn.Models
{
    public enum QuestCategory
    {
        None = 0,
        Battle,
        Siege,
        Free,
        Setup,
        Alternate_Defeat,
        Alternate_Victory,
        Alternate_Progression,
        Variable_Length,
        Wandering,
        Short,
        Medium,
        Long,
        Extra_Long
    }
}