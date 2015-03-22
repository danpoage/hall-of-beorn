using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HallOfBeorn.Models
{
    public enum CardStat : ushort
    {
        None = 0,
        Threat_Cost_0,
        Threat_Cost_5,
        Threat_Cost_6,
        Threat_Cost_7,
        Threat_Cost_8,
        Threat_Cost_9,
        Threat_Cost_10,
        Threat_Cost_11,
        Threat_Cost_12,
        Threat_Cost_13,
        Threat_Cost_14,
        Resource_Cost_0,
        Resource_Cost_X,
        Resource_Cost_Nil
    }
}
