using System;
using System.Collections.Generic;
using System.Linq;
using HallOfBeorn.Models.LotR;

namespace HallOfBeorn.Services.LotR.Categories
{
    public class RegionService
        : CategoryServiceBase<Region>
    {
        public RegionService(ICardRepository<LotRCard> cardRepository)
            : base(cardRepository)
        {
        }

        private Func<LotRCard, Region> CreateRegionFilter(Func<LotRCard, bool> predicate, Region region)
        {
            return new Func<LotRCard, Region>((card) => {
                return (predicate(card)) ? region : Region.None;
            });
        }

        protected override bool IsCategorizable(LotRCard card)
        {
            return card.CardType.IsPlayerCard();
        }

        protected override List<Func<LotRCard, Region>> GetCategoryFilters()
        {
            return new List<Func<LotRCard, Region>>
            {
                CreateRegionFilter((c) => c.NormalizedTitle.ContainsAny("erebor", "longbeard", "thorin", "balin", "nori", "dori", "ori", "fili", "kili", "bifur", "bofur", "bombur", "gloin", "oin"), Region.Erebor),
                CreateRegionFilter((c) => c.NormalizedTitle.ContainsAny("zigil", "nanduhirion", "khazad", "durin"), Region.Moria),
                CreateRegionFilter((c) => c.NormalizedTitle.ContainsAny("iron hill", "dain ironfoot"), Region.Iron_Hills),
                CreateRegionFilter(c => c.NormalizedTitle.ContainsAny("ered luin", "blue mountain"), Region.Blue_Mountains),
                CreateRegionFilter(c => c.NormalizedTitle.ContainsAny("cirdan", "of the haven", "erestor", "lindon", "lune", "mithlond"), Region.Grey_Havens),
                CreateRegionFilter(c => c.NormalizedTitle.ContainsAny("ered nimrais", "white mountain"), Region.White_Mountains),
                CreateRegionFilter(c => c.NormalizedTitle.ContainsAny("weather hills", "east road", "chetwood", "greenway"), Region.ARNOR),
                CreateRegionFilter(c => c.Traits.Any(t => t == "Hobbit."), Region.Shire),
                CreateRegionFilter(c => c.NormalizedTitle.ContainsAny("elostirion"), Region.Tower_Hills),
                CreateRegionFilter(c => c.Traits.Any(t => t == "Bree." || c.NormalizedTitle.ContainsAny("bill the pony")), Region.Bree),
                CreateRegionFilter(c => c.NormalizedTitle.ContainsAny("rivendell", "imladris", "trollshaw", "bruinen", "elrond", "arwen", "elladan", "elrohir", "glorfindel"), Region.Rivendell),
                CreateRegionFilter(c => c.NormalizedTitle.ContainsAny("rhovanion", "celduin"), Region.RHOVANION),
                CreateRegionFilter(c => c.NormalizedTitle.ContainsAny("ered mithrin"), Region.Celduin),
                CreateRegionFilter(c => c.Traits.Any(t => t == "Eagle.") || c.NormalizedTitle.ContainsAny("eyrie", "meneldor", "eagle"), Region.Eyrie),
                CreateRegionFilter(c => c.NormalizedTitle.ContainsAny("saruman", "isengard", "orthanc"), Region.Isengard),
                CreateRegionFilter(c => c.NormalizedTitle.ContainsAny(
                    "lorien", "naith", "galadhon", "galadhrim", "nimrodel", "rumil", "orophin", "celeborn", "galadriel"), Region.Lorien),
                CreateRegionFilter(c => c.NormalizedTitle.ContainsAny("mirkwood", "greenwood"), Region.Mirkwood),

                CreateRegionFilter(c => c.Traits.Any(t => t == "Gondor." || t == "Outlands."), Region.GONDOR),
                CreateRegionFilter(c => c.NormalizedTitle.ContainsAny(
                    "minas tirith", "citadel", "white tower", "steward of gondor", "rod of the steward", "in service of the steward",
                    "denethor", "faramir", "boromir", "ioreth", "beregond"), Region.Minas_Tirith),
                CreateRegionFilter(c => c.NormalizedTitle.ContainsAny("ithilien", "emyn arnen", "damrod", "anborn", "mablung"), Region.Ithilien),
                CreateRegionFilter(c => c.NormalizedTitle.ContainsAny("osgiliath"), Region.Osgiliath),
                CreateRegionFilter(c => c.NormalizedTitle.ContainsAny("pelargir"), Region.Pelargir),
                CreateRegionFilter(c => c.NormalizedTitle.ContainsAny("linhir", "anfalas", "lossarnach", "ethir"), Region.Outlands),
                CreateRegionFilter(c => c.NormalizedTitle.ContainsAny("dol amroth", "prince imrahil", "the swan"), Region.Dol_Amroth),
            };
        }
    }
}