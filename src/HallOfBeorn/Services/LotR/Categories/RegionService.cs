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
            Func<LotRCard, bool> isMinasTirith = c => c.NormalizedTitle.ContainsAny("minas tirith", "citadel", "white tower",
                "steward of gondor", "rod of the steward", "in service of the steward", "warden of healing",
                    "denethor", "faramir", "boromir", "ioreth", "beregond");

            Func<LotRCard, bool> isIthilien = c => c.NormalizedTitle.ContainsAny("ithilien", "emyn arnen", "faramir", "damrod", "anborn", "mablung");

            Func<LotRCard, bool> isOsgiliath = c => c.NormalizedTitle.ContainsAny("osgiliath");

            Func<LotRCard, bool> isPelargir = c => c.NormalizedTitle.ContainsAny("pelargir");

            Func<LotRCard, bool> isOutlands = c => c.NormalizedTitle.ContainsAny("linhir", "anfalas", "lossarnach", "ethir");

            Func<LotRCard, bool> isDolAmroth = c => c.NormalizedTitle.ContainsAny("dol amroth", "prince imrahil", "of the swan");

            Func<LotRCard, bool> isGondor = c => new List<Func<LotRCard, bool>> { 
                isMinasTirith, isIthilien, isOsgiliath, isPelargir, isOsgiliath, isOutlands, isDolAmroth }.Any(p => p(c));

            Func<LotRCard, bool> isEdoras = c => c.NormalizedTitle.ContainsAny(
                    "theoden", "theodred", "eomund", "eowyn", "eomer", "elfhelm", "hama", "deorwine", "guthlaf", "gleowine", "edoras", "riddermark", "rohirrim", "of the mark", "of rohan", "horseback");

            Func<LotRCard, bool> isWestfold = c => c.NormalizedTitle.ContainsAny("grimbold", "westfold", "west road");

            Func<LotRCard, bool> isEastfold = c => c.NormalizedTitle.ContainsAny("eomer", "eothain", "eastfold", "snowbourn", "the riddermark's finest");

            Func<LotRCard, bool> isHornburg = c => c.NormalizedTitle.ContainsAny("helm's deep", "erkenbrand", "gamling", "ceorl");

            Func<LotRCard, bool> isRohan = c => new List<Func<LotRCard, bool>> {
                isEdoras, isWestfold, isEastfold, isHornburg }.Any(p => p(c));

            Func<LotRCard, bool> isEyrie = c => c.Traits.Any(t => t == "Eagle.") || c.NormalizedTitle.ContainsAny("eyrie", "meneldor", "eagle");
            Func<LotRCard, bool> isMoria = c => c.NormalizedTitle.ContainsAny("moria", "zigil", "nanduhirion", "khazad", "of durin", "durin's");

            Func<LotRCard, bool> isMistyMountains = c => new List<Func<LotRCard, bool>> {
                isEyrie, isMoria }.Any(p => p(c));

            Func<LotRCard, bool> isBree = c => c.Traits.Any(t => t == "Bree.") || c.NormalizedTitle.ContainsAny("bill the pony");
            Func<LotRCard, bool> isTheShire = c => c.Traits.Any(t => t == "Hobbit.") || c.NormalizedTitle.ContainsAny("Hobbit", "The Shire");
            Func<LotRCard, bool> isTowerHills = c => c.NormalizedTitle.ContainsAny("elostirion");
            Func<LotRCard, bool> isArthedain = c => new List<Func<LotRCard, bool>> {
                isBree, isTheShire, isTowerHills }.Any(p => p(c));

            Func<LotRCard, bool> isRhovanionTitle = c => c.NormalizedTitle.ContainsAny("rhovanion");
            Func<LotRCard, bool> isMirkwood = c => c.NormalizedTitle.ContainsAny("mirkwood", "greenwood") || c.Traits.Any(t => t == "Woodman.");
            Func<LotRCard, bool> isCelduin = c => c.NormalizedTitle.ContainsAny("celduin");
            Func<LotRCard, bool> isCarrock = c => c.Traits.Any(t => t == "Beorning.") || c.NormalizedTitle.ContainsAny("Beorn");
            Func<LotRCard, bool> isRhovanion = c => new List<Func<LotRCard, bool>> {
                isRhovanionTitle, isMirkwood, isCelduin, isCarrock }.Any(p => p(c));

            Func<LotRCard, bool> isFangorn = c => c.Traits.Any(t => t == "Ent.") || c.NormalizedTitle.StartsWithAny("entmoot", "ent draught", "boomed and trumpeted", "the dam bursts");
            Func<LotRCard, bool> isHarad = c => c.Traits.Any(t => t == "Harad.") || c.NormalizedTitle.StartsWithAny("kahliel", "haradrim");

            return new List<Func<LotRCard, Region>>
            {
                CreateRegionFilter(isMistyMountains, Region.MISTY_MOUNTAINS),
                CreateRegionFilter((c) => c.NormalizedTitle.StartsWithAny("erebor", "longbeard", "thorin", "balin", "dwalin", "nori", "dori", "ori", "fili", "kili", "bifur", "bofur", "bombur", "gloin", "oin", "gimli"), Region.Erebor),
                CreateRegionFilter(isMoria, Region.Moria),
                CreateRegionFilter((c) => c.NormalizedTitle.ContainsAny("iron hills", "dain ironfoot"), Region.Iron_Hills),
                CreateRegionFilter(c => c.NormalizedTitle.ContainsAny("ered luin", "blue mountain"), Region.Blue_Mountains),
                CreateRegionFilter(c => c.NormalizedTitle.ContainsAny("cirdan", "of the havens", "erestor", "lindon", "lune", "mithlond"), Region.Grey_Havens),
                CreateRegionFilter(c => c.NormalizedTitle.ContainsAny("ered nimrais", "white mountain"), Region.White_Mountains),
                CreateRegionFilter(c => c.NormalizedTitle.ContainsAny(
                    "weather hills", "east road", "chetwood", "greenway", "fornost", "annuminas"), Region.ARNOR),
                CreateRegionFilter(isTheShire, Region.Shire),
                CreateRegionFilter(isTowerHills, Region.Tower_Hills),
                CreateRegionFilter(isBree, Region.Bree),
                CreateRegionFilter(isArthedain, Region.ARTHEDAIN),
                CreateRegionFilter(c => c.NormalizedTitle.ContainsAny("rivendell", "imladris", "trollshaw", "bruinen", "elrond", "arwen", "elladan", "elrohir", "glorfindel"), Region.Rivendell),
                CreateRegionFilter(isRhovanion, Region.RHOVANION),
                CreateRegionFilter(isCarrock, Region.Carrock),
                CreateRegionFilter(isCelduin, Region.Celduin),
                CreateRegionFilter(isEyrie, Region.Eyrie),
                CreateRegionFilter(c => c.NormalizedTitle.ContainsAny("saruman", "isengard", "orthanc"), Region.Isengard),
                CreateRegionFilter(c => c.NormalizedTitle.ContainsAny(
                    "lorien", "naith", "galadhon", "galadhrim", "nimrodel", "rumil", "orophin", "celeborn", "galadriel"), Region.Lorien),
                CreateRegionFilter(isMirkwood, Region.Mirkwood),

                CreateRegionFilter(isGondor, Region.GONDOR),
                CreateRegionFilter(isMinasTirith, Region.Minas_Tirith),
                CreateRegionFilter(isIthilien, Region.Ithilien),
                CreateRegionFilter(isOsgiliath, Region.Osgiliath),
                CreateRegionFilter(isPelargir, Region.Pelargir),
                CreateRegionFilter(isOutlands, Region.Outlands),
                CreateRegionFilter(isDolAmroth, Region.Dol_Amroth),
                CreateRegionFilter(isRohan, Region.ROHAN),
                CreateRegionFilter(isWestfold, Region.Westfold),
                CreateRegionFilter(isEastfold, Region.Eastfold),
                CreateRegionFilter(isEdoras, Region.Edoras),
                CreateRegionFilter(isHornburg, Region.Hornburg),
                CreateRegionFilter(isFangorn, Region.Fangorn),

                CreateRegionFilter(isHarad, Region.HARAD),
            };
        }
    }
}