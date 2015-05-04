using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace HallOfBeorn.Models.Products
{
    public class NightmareDeckProductGroup : ProductGroup
    {
        public NightmareDeckProductGroup()
            : base("Nightmare Decks")
        {
            AddProduct(new PassageThroughMirkwoodNightmareProduct());
            AddProduct(new JourneyAlongTheAnduinNightmareProduct());
            AddProduct(new EscapeFromDolGuldurNightmareProduct());

            AddProduct(new TheHuntForGollumNightmareProduct());
            AddProduct(new ConflictAtTheCarrockNightmareProduct());
            AddProduct(new AJourneyToRhosgobelNightmareProduct());
            AddProduct(new TheHillsOfEmynMuilNightmareProduct());
            AddProduct(new TheDeadMarshesNightmareProduct());
            AddProduct(new ReturnToMirkwoodNightmareProduct());

            AddProduct(new KhazadDumNightmareProduct());

            AddProduct(new TheRedhornGateNightmareProduct());
            AddProduct(new RoadToRivendellNightmareProduct());
            AddProduct(new TheWatcherInTheWaterNightmareProduct());
            AddProduct(new TheLongDarkNightmareProduct());
            AddProduct(new FoundationsOfStoneNightmareProduct());
            AddProduct(new ShadowAndFlameNightmareProduct());

            AddProduct(new TheHobbitOverHillAndUnderHillNightmareProduct());
            AddProduct(new TheHobbitOnTheDoorstepNightmareProduct());

            AddProduct(new HeirsOfNumenorNightmareProduct());
            AddProduct(new TheStewardsFearNightmareProduct());
            AddProduct(new TheDruadanForestNightmareProduct());
            AddProduct(new EncounterAtAmonDinNightmareProduct());
            AddProduct(new AssaultOnOsgiliathNightmareProduct());
            AddProduct(new TheBloodOfGondorNightmareProduct());
            AddProduct(new TheMorgulValeNightmareProduct());

            AddProduct(new TheBlackRidersNightmareProduct());
        }
    }
}