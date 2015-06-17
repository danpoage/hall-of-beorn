using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

using HallOfBeorn.Models;
using HallOfBeorn.Models.Decks.HallOfBeorn;
using HallOfBeorn.Models.Decks.TalesFromTheCards;

namespace HallOfBeorn.Services
{
    public class DeckRepository
    {
        public DeckRepository()
        {
            AddDeck(new WarriorsOfTheWhiteTower());
            AddDeck(new TheSpiritOfGondor());
            AddDeck(new FaramirAndTheRangersOfIthilien());
            AddDeck(new BoromirLeadsTheCharge());
            AddDeck(new CaldarasSacrifice());
            AddDeck(new KeepItSecretKeepItSafe());
            AddDeck(new RangersAndTraps());
            AddDeck(new SecretsOfTheWise());
            AddDeck(new CalledToTheSea());
            AddDeck(new PrisonerOfTheDarkForest());
            AddDeck(new ReclaimingKhazadDum());
            AddDeck(new ThreeKingsAQueenAndAPrince());
            AddDeck(new TheGreyCompanyDefendsGondor());
            AddDeck(new MagaliTribute());
            AddDeck(new BeornAttacks());
            AddDeck(new MastersOfTheForest());
            AddDeck(new TheFieldOfCormallen());
            AddDeck(new IsildursHeir());
            AddDeck(new FlightToTheFord());
            AddDeck(new TwoKingdomsReunited());
            AddDeck(new HamaTakesArcheryLessons());
            AddDeck(new BardGoesHunting());
            AddDeck(new TheIslandOfMisfitHeroes());
            AddDeck(new BalinHoldsTheLine());
            AddDeck(new TheRohirrimRideWithTheGreyCompany());
            AddDeck(new ThePowerOfThePalantir());
            AddDeck(new LoreMastery());
            AddDeck(new EaglesAndHorsesAndBearsOhMy());
            AddDeck(new TheDwarvesAndFaramir());
            AddDeck(new LocationControl());
            AddDeck(new Gluttony());
            AddDeck(new BoromirAndTheSevenDwarves());
            AddDeck(new VilyaTheRingOfAir());
            AddDeck(new DirectDamageTacticsLeadership());
            AddDeck(new DirectDamageLeadershipSpiritLore());
            AddDeck(new RenewedFriendshipsDwarvesElvesAndMen());
            AddDeck(new RenewedFriendshipsElvesAndElfFriends());
            AddDeck(new BattleOfPelennorRideToRuin());
            AddDeck(new BattleOfPelennorAndTheWorldsEnding());
            AddDeck(new SecretsOfErebor());
            AddDeck(new SecretsOfErebor2());
            AddDeck(new TheOrcHuntersOfImladris());
            AddDeck(new WardensOfImladris());

            AddDeck(new RideToRuin());
            AddDeck(new SpearmanSuperhero());
            AddDeck(new PalantirSupport());
            AddDeck(new TrapsOfIthilien());
            AddDeck(new EleanorsBigAdventure());
            AddDeck(new OutlandsGoneWild());
            AddDeck(new BlazeOfGlory());
            AddDeck(new RidingWithRohan());
            AddDeck(new WhereEaglesDare());

            AddDeck(new BeornsPathPTMLeadershipLore());
            AddDeck(new BeornsPathJAtALeadershipLore());
            AddDeck(new BeornsPathEFDGTacticsSpirit());
            AddDeck(new BeornsPathTHFGLeadershipLore());
            AddDeck(new BeornsPathTHFGTacticsSpirit());
            AddDeck(new BeornsPathCatCLeadershipLore());
            AddDeck(new BeornsPathAJtRLeadershipLore());
            AddDeck(new BeornsPathTHoEMLeadershipLore());
            AddDeck(new BeornsPathTDMLeadershipLore());
            AddDeck(new BeornsPathRtMTacticsSpirit());
        }

        private void AddDeck(Deck deck)
        {
            decks.Add(deck);
        }

        private readonly List<Deck> decks = new List<Deck>();

        public IEnumerable<Deck> Decks()
        {
            return decks;
        }
    }
}