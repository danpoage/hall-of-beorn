using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace HallOfBeorn.Models.Fluent
{
    public enum StatType: byte
    {
        None = 0,
        Unique,
        Threat_Cost,
        Willpower,
        Attack,
        Defense,
        Hit_Points,
        Engagement_Cost,
        Threat,
        Resource_Cost,
        Quest_Points
    }
}