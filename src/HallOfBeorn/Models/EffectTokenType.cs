using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace HallOfBeorn.Models
{
    public enum EffectTokenType : byte
    {
        Text,
        Inline_Text,
        Flavor_Text,
        Trigger,
        Sphere_Icon,
        Willpower_Icon,
        Threat_Icon,
        Attack_Icon,
        Defense_Icon,
        Self,
        Card_Title,
        Specific_Card,
        Trait,
        Keyword
    }
}