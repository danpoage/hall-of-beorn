using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace HallOfBeorn.Models.Digital
{
    public static class Extensions
    {
        public static string SphereName(this DigitalSphere sphere)
        {
            if (sphere == DigitalSphere.Any || sphere == DigitalSphere.None)
                return string.Empty;

            return sphere.ToString();
        }

        public static string TraitName(this DigitalTrait? trait)
        {
            if (!trait.HasValue)
                return string.Empty;

            switch (trait.Value)
            {
                case DigitalTrait.Dunadan:
                    return "Dúnadan";
                default:
                    return trait.Value.ToString();
            }
        }
    }
}