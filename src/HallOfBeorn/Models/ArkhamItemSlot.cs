using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace HallOfBeorn.Models
{
    public enum ArkhamItemSlot : sbyte
    {
        NA = -1,
        None = 0,
        One_Hand,
        Both_Hands,
        Accessory,
        Body,
        Ally
    }
}