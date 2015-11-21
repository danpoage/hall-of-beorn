using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace HallOfBeorn.Models.ProductGroups
{
    public class NightmareDeckProductGroup : ProductGroup
    {
        public NightmareDeckProductGroup()
            : base("Nightmare Decks")
        {
            AddProduct(Product.PassageThroughMirkwoodNightmare);
            AddProduct(Product.JourneyAlongTheAnduinNightmare);
            AddProduct(Product.EscapeFromDolGuldurNightmare);

            AddProduct(Product.TheHuntForGollumNightmare);
            AddProduct(Product.ConflictAtTheCarrockNightmare);
            AddProduct(Product.AJourneyToRhosgobelNightmare);
            AddProduct(Product.TheHillsOfEmynMuilNightmare);
            AddProduct(Product.TheDeadMarshesNightmare);
            AddProduct(Product.ReturnToMirkwoodNightmare);

            AddProduct(Product.KhazadDumNightmare);

            AddProduct(Product.TheRedhornGateNightmare);
            AddProduct(Product.RoadToRivendellNightmare);
            AddProduct(Product.TheWatcherInTheWaterNightmare);
            AddProduct(Product.TheLongDarkNightmare);
            AddProduct(Product.FoundationsOfStoneNightmare);
            AddProduct(Product.ShadowAndFlameNightmare);

            AddProduct(Product.TheHobbitOverHillAndUnderHillNightmare);
            AddProduct(Product.TheHobbitOnTheDoorstepNightmare);

            AddProduct(Product.HeirsOfNumenorNightmare);
            AddProduct(Product.TheStewardsFearNightmare);
            AddProduct(Product.TheDruadanForestNightmare);
            AddProduct(Product.EncounterAtAmonDinNightmare);
            AddProduct(Product.AssaultOnOsgiliathNightmare);
            AddProduct(Product.TheBloodOfGondorNightmare);
            AddProduct(Product.TheMorgulValeNightmare);

            AddProduct(Product.TheVoiceOfIsengardNightmare);
            AddProduct(Product.TheDunlandTrapNightmare);
            AddProduct(Product.TheThreeTrialsNightmare);
            AddProduct(Product.TroubleInTharbadNightmare);

            AddProduct(Product.TheBlackRidersNightmare);
        }
    }
}