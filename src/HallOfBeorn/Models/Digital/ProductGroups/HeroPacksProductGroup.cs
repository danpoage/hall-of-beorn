using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace HallOfBeorn.Models.Digital.ProductGroups
{
    public class HeroPacksProductGroup : DigitalProductGroup
    {
        public HeroPacksProductGroup()
            : base("Hero Packs")
        {
            addChildProduct(DigitalProduct.DwalinPack);
            addChildProduct(DigitalProduct.EowynPack);
            addChildProduct(DigitalProduct.FaramirPack);
            addChildProduct(DigitalProduct.LegolasPack);
        }
    }
}