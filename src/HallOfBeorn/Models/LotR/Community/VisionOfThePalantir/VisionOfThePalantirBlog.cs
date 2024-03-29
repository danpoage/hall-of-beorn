﻿using System;
using System.Linq;
using HallOfBeorn.Services.LotR;

namespace HallOfBeorn.Models.LotR.Community.VisionOfThePalantir
{
    public class VisionOfThePalantirBlog
        : Creator
    {
        public VisionOfThePalantirBlog()
            : base("Vision of the Palantir",
            "https://visionofthepalantir.com/",
            "https://visionofthepalantir.com/feed",
            LinkType.Vision_of_the_Palantir)
        {
            AddYear(2021);
            AddLink("The Road to Isengard", "https://visionofthepalantir.com/2021/09/18/the-road-to-isengard/", "Sep 18 2021");
            AddLink("News: In-Flight Report Sept 2021", "https://visionofthepalantir.com/2021/09/16/news-in-flight-report-sept-2021/", "Sep 9 2021");
            AddLink("Vision of the Palantir Loot 2021", "https://visionofthepalantir.com/2021/09/04/vision-of-the-palantir-loot-2021/", "Sep 4 2021");
            AddLink("The Massing at Osgiliath", "https://visionofthepalantir.com/2021/09/01/the-massing-at-osgiliath/", "Sep 1 2021");
            AddLink("Month in Review: August 2021", "https://visionofthepalantir.com/2021/08/31/month-in-review-august-2021/", "Aug 31 2021");
            AddLink("Beleg's Storage", "https://visionofthepalantir.com/2021/08/25/belegs-storage/", "Aug 25 2021");
            AddLink("Player card review: The Drúadan Forest", "https://visionofthepalantir.com/2021/08/21/player-card-review-the-druadan-forest/", "Aug 21 2021")
                .WithLabels(Product.TheDruadanForest.PlayerCardLabels());
            AddLink("Nightmare The Watcher in the Water", "https://visionofthepalantir.com/2021/08/16/nightmare-the-watcher-in-the-water/", "Aug 16 2021")
                .WithLabels(Scenario.TheWatcherInTheWater.NightmareModeLabels());
            AddLink("Nightmare Road to Rivendell", "https://visionofthepalantir.com/2021/08/12/nightmare-road-to-rivendell/", "Aug 12 2021")
                .WithLabels(Scenario.RoadToRivendell.NightmareModeLabels());
            AddLink("Nightmare A Storm on Cobas Haven", "https://visionofthepalantir.com/2021/08/04/nightmare-a-storm-on-cobas-haven/", "Aug 4 2021")
                .WithLabels(Scenario.AStormOnCobasHaven.NightmareModeLabels());
            AddLink("Deckbuilding Across the Ettenmoors", "https://visionofthepalantir.com/2021/08/01/deckbuilding-across-the-ettenmoors/", "Aug 1 2021")
                .WithLabels(Scenario.AcrossTheEttenmoors.StandardModeLabels());
            AddLink("Month in Review: July 2021", "https://visionofthepalantir.com/2021/07/31/month-in-review-july-2021/", "July 31 2021");
            AddLink("Bi-monthly Poll: July 2021", "https://visionofthepalantir.com/2021/07/27/bi-monthly-poll-july-2021/", "July 27 2021");
            AddLink("Road to Rivendell: There and Back Again", "https://visionofthepalantir.com/2021/07/20/road-to-rivendell-there-and-back-again/", "July 20 2021")
                .WithLabels(Scenario.RoadToRivendell.StandardModeLabels());
            AddLink("The City of Ulfast", "https://visionofthepalantir.com/2021/07/15/the-city-of-ulfast/", "July 15 2021")
                .WithLabels(Product.TheCityOfUlfast);
            AddLink("Encounter Set Review: The Hunt for Gollum", "https://visionofthepalantir.com/2021/07/09/encounter-set-review-the-hunt-for-gollum/", "July 9 2021")
                .WithLabels(EncounterSet.TheHuntForGollum);
            AddLink("The Redhorn Gate: There and Back Again", "https://visionofthepalantir.com/2021/07/07/the-redhorn-gate-there-and-back-again/", "July 7 2021")
                .WithLabels(Product.TheRedhornGate);
            AddLink("Month in Review: June 2021", "https://visionofthepalantir.com/2021/06/30/month-in-review-june-2021/", "June 30 2021");
            AddLink("The Battle of Lake-town", "https://visionofthepalantir.com/2021/06/26/the-battle-of-lake-town/", "June 26 2021")
                .WithLabels(Product.TheBattleOfLakeTown);
            AddLink("Epic Multiplayer Helm's Deep Rules", "https://visionofthepalantir.com/2021/06/19/epic-multiplayer-helms-deep/", "June 19 2021");
            AddLink("Announcement: Epic Multiplayer Helm's Deep", "https://visionofthepalantir.com/2021/06/16/announcement-epic-multiplayer-helms-deep/", "June 16 2021");
            AddLink("The LOTR: LCG Calendar", "https://visionofthepalantir.com/2021/06/15/the-lotr-lcg-calendar/", "June 15 2021");
            AddLink("Keywords", "https://visionofthepalantir.com/2021/06/09/keywords/", "June 9 2021");
            AddLink("Month in Review: May 2021", "https://visionofthepalantir.com/2021/05/31/month-in-review-may-2021/", "May 31 2021");
            AddLink("Player card review: The Steward's Fear", "https://visionofthepalantir.com/2021/05/30/player-card-review-the-stewards-fear/", "May 30 2021")
                .WithLabels(Product.TheStewardsFear.PlayerCardLabels());
            AddLink("Monthly Poll: May 2021", "https://visionofthepalantir.com/2021/05/28/monthly-poll-may-2021/", "May 28 2021");
            AddLink("Challenge of the Wainriders", "https://visionofthepalantir.com/2021/05/25/challenge-of-the-wainriders/", "May 25 2021")
                .WithLabels(Product.ChallengeOfTheWainriders);
            AddLink("Nightmare Flight from Moria", "https://visionofthepalantir.com/2021/05/15/nightmare-flight-from-moria/", "May 15 2021")
                .WithLabels(EncounterSet.FlightFromMoriaNightmare);
            AddLink("Middle Earth Tour: Angmar Awakened", "https://visionofthepalantir.com/2021/05/06/middle-earth-tour-angmar-awakened/", "May 6 2021");
            AddLink("Storage Solutions 4.5", "https://visionofthepalantir.com/2021/05/02/storage-solutions-4-5/", "May 2 2021");
            AddLink("Month in Review: April 2021", "https://visionofthepalantir.com/2021/04/30/month-in-review-april-2021/", "April 30 2021");
            AddLink("Monthly Poll: April 2021", "https://visionofthepalantir.com/2021/04/27/monthly-poll-april-2021/", "April 27 2021");
            AddLink("Wrath and Ruin", "https://visionofthepalantir.com/2021/04/17/wrath-and-ruin/", "April 17 2021")
                .WithLabels(Product.WrathAndRuin);
            AddLink("Deckbuilding: Escape from Mount Gram", "https://visionofthepalantir.com/2021/04/11/deckbuilding-escape-from-mount-gram/", "April 11 2021")
                .WithLabels(Product.EscapeFromMountGram.PlayerCardLabels());
            AddLink("Stage Solutions IV", "https://visionofthepalantir.com/2021/04/01/storage-solutions-iv/", "April 1 2021");
            AddLink("Month in Review 2021", "https://visionofthepalantir.com/2021/03/31/month-in-review-march-2021/", "March 31 2021");
            AddLink("Monthly Poll: March 2021", "https://visionofthepalantir.com/2021/03/29/monthly-poll-march-2021/", "March 29 2021");
            AddLink("Player card review: Heirs of Númenor", "https://visionofthepalantir.com/2021/03/28/player-card-review-heirs-of-numenor/", "March 28 2021")
                .WithLabels(Product.HeirsOfNumenor.PlayerCardLabels());
            AddLink("Deckbuilding: The Wastes of Eriador", "https://visionofthepalantir.com/2021/03/23/deckbuilding-the-wastes-of-eriador/", "March 23 2021")
                .WithLabels(Product.TheWastesOfEriador.PlayerCardLabels());
            AddLink("Nightmare The Seventh Level", "https://visionofthepalantir.com/2021/03/21/nightmare-the-seventh-level/", "March 21 2021")
                .WithLabels(EncounterSet.TheSeventhLevelNightmare);
            AddLink("Middle Earth Tour: Ringmaker", "https://visionofthepalantir.com/2021/03/19/middle-earth-tour-ringmaker/", "March 19 2021");
            AddLink("Community support and swag", "https://visionofthepalantir.com/2021/03/04/community-support-and-swag/", "March 4 2021");
            AddLink("Middle Earth Tour: Against the Shadow", "https://visionofthepalantir.com/2021/03/02/middle-earth-tour-against-the-shadow/", "March 2 2021");
            AddLink("Month in Review: February 2021", "https://visionofthepalantir.com/2021/02/28/month-in-review-february-2021/", "Feb 28 2021");
            AddLink("Monthly Poll: February 2021", "https://visionofthepalantir.com/2021/02/25/monthly-poll-february-2021/", "Feb 25 2021");
            AddLink("Deckbuilding: The Fortress of Nurn", "https://visionofthepalantir.com/2021/02/22/deckbuilding-the-fortress-of-nurn/", "Feb 22 2021")
                .WithLabels(Product.TheFortressOfNurn.PlayerCardLabels());
            AddLink("Middle Earth Tour: Dwarrowdelf", "https://visionofthepalantir.com/2021/02/18/middle-earth-tour-dwarrowdelf/", "Feb 18 2021");
            AddLink("Under the Ash Mountains", "https://visionofthepalantir.com/2021/02/13/under-the-ash-mountains/", "Feb 13 2021")
                .WithLabels(Product.UnderTheAshMountains);
            AddLink("Middle Earth Tour: Shadows of Mirkwood", "https://visionofthepalantir.com/2021/02/08/middle-earth-tour-shadows-of-mirkwood/", "Feb 8 2021");
            AddLink("The Middle Earth Tour Project", "https://visionofthepalantir.com/2021/02/04/the-middle-earth-tour-project/", "Feb 4 2021");
            AddLink("Nightmare The Treachery of Rhudaur", "https://visionofthepalantir.com/2021/02/02/nightmare-the-treachery-of-rhudaur/", "Feb 2 2021")
                .WithLabels(EncounterSet.TheTreacheryOfRhudaurNightmare);
            AddLink("Month in Review: Janurary 2021", "https://visionofthepalantir.com/2021/01/31/month-in-review-january-2021/", "Jan 31 2021");
            AddLink("Monthly Poll: January 2021", "https://visionofthepalantir.com/2021/01/31/month-in-review-january-2021/", "Jan 27 2021");
            AddLink("Third year anniversary", "https://visionofthepalantir.com/2021/01/21/third-year-anniversary/", "Jan 21 2021");
            AddLink("Nightmare Into the Pit", "https://visionofthepalantir.com/2021/01/17/nightmare-into-the-pit/", "Jan 17 2021")
                .WithLabels(EncounterSet.IntoThePitNightmare);
            AddLink("Encounter Set Review: Escape from Dol Guldur", "https://visionofthepalantir.com/2021/01/06/encounter-set-review-escape-from-dol-guldur/", "Jan 6 2021")
                .WithLabels(EncounterSet.EscapeFromDolGuldur);
            AddLink("The Ruins of Belegost", "https://visionofthepalantir.com/2021/01/04/the-ruins-of-belegost/", "Jan 4 2021")
                .WithLabels(Product.TheRuinsOfBelegost);
            AddLink("2020: A year in numbers", "https://visionofthepalantir.com/2021/01/02/2020-a-year-in-numbers/", "Jan 2 2021");
            
            AddYear(2020);
            AddLink("Month in Review: December 2020", "https://visionofthepalantir.com/2020/12/31/month-in-review-december-2020/", "Dec 31 2020");
            AddLink("Escape from Dol Guldur", "https://visionofthepalantir.com/2020/12/27/escape-from-dol-guldur-2/", "Dec 27 2020")
                .WithLabels(Scenario.EscapeFromDolGuldur.StandardModeLabels());
            AddLink("Monthly Poll: December 2020", "https://visionofthepalantir.com/2020/12/23/monthly-poll-december-2020/", "Dec 23 2020");
            AddLink("Deckbuilding: Deadmen's Dike", "https://visionofthepalantir.com/2020/12/21/deckbuilding-deadmens-dike/", "Dec 21 2020")
                .WithLabels(Scenario.DeadmensDike.StandardModeLabels());
            AddLink("First Impressions: The Hunt for the Dreadnaught", "https://visionofthepalantir.com/2020/12/20/first-impressions-the-hunt-for-the-dreadnaught/", "Dec 20 2020");
            AddLink("A Long-extended Party", "https://visionofthepalantir.com/2020/12/08/a-long-extended-party/", "Dec 8 2020");
            AddLink("LOTR LCG: Art-icle", "https://visionofthepalantir.com/2020/12/05/lotr-lcg-art-icle/", "Dec 5 2020");
            AddLink("Month in Review: November 2020", "https://visionofthepalantir.com/2020/12/01/month-in-review-november-2020/", "Dec 1 2020");
            AddLink("Journey Along the Anduin", "https://visionofthepalantir.com/2020/11/29/journey-along-the-anduin-2/", "Nov 29 2020")
                .WithLabels(Scenario.JourneyAlongTheAnduin.StandardModeLabels());
            AddLink("Monthly Poll: November 2020", "https://visionofthepalantir.com/2020/11/27/monthly-poll-november-2020/", "Nov 27 2020");
            AddLink("Deckbuilding: The Weather Hills", "https://visionofthepalantir.com/2020/11/25/deckbuilding-the-weather-hills/", "Nov 25 2020")
                .WithLabels(Scenario.TheWeatherHills.StandardModeLabels());
            AddLink("The Temple of Doom", "https://visionofthepalantir.com/2020/11/19/the-temple-of-doom/", "Nov 19 2020")
                .WithLabels(Scenario.TempleOfDoom.StandardModeLabels());
            AddLink("Storage Solutions: Marc Lommert", "https://visionofthepalantir.com/2020/11/17/storage-solutions-marc-lommert/", "Nov 17 2020");
            AddLink("LOTR LCG Challenges", "https://visionofthepalantir.com/2020/11/08/lotr-lcg-challenges/", "Nov 8 2020");
            AddLink("Three Player Quests", "https://visionofthepalantir.com/2020/11/06/three-player-quests/", "Nov 6 2020");
            AddLink("Month in Review: October 2020", "https://visionofthepalantir.com/2020/10/31/month-in-review-october-2020/", "Oct 31 2020");
            AddLink("Monthly Poll: October 2020", "https://visionofthepalantir.com/2020/10/24/monthly-poll-october-2020/", " Oct 24 2020");
            AddLink("Vision of the Poll-antir 3", "https://visionofthepalantir.com/2020/10/18/vision-of-the-poll-antir-3/", "Oct 18 2020");
            AddLink("Storage Solutions: Sam Beck", "https://visionofthepalantir.com/2020/10/10/storage-solutions-sam-beck/", "Oct 10 2020");
            AddLink("Two Player Quests", "https://visionofthepalantir.com/2020/10/08/two-player-quests/", "Oct 8 2020");
            AddLink("Storage Solutions: exeivot", "https://visionofthepalantir.com/2020/10/06/storage-solutions-exeivot/", "Oct 6 2020");
            AddLink("Vision of the Palantir Loot 2020", "https://visionofthepalantir.com/2020/10/04/vision-of-the-palantir-loot-2020/", "Oct 4 2020");
            AddLink("First Impressions: The Fortress of Nurn", "https://visionofthepalantir.com/2020/10/02/first-impressions-the-fortress-of-nurn/", " Oct 2 2020")
                .WithLabels(Scenario.TheFortressOfNurn.StandardModeLabels());
            AddLink("Danger in Dorwinion", "https://visionofthepalantir.com/2020/10/01/danger-in-dorwinion/", "Oct 1 2020")
                .WithLabels(Scenario.DangerInDorwinion.StandardModeLabels());
            AddLink("Month in Review: September 2020", "https://visionofthepalantir.com/2020/09/30/month-in-review-september-2020/", "Sep 30 2020");
            AddLink("Dwarrowdelf cycle conclusion", "https://visionofthepalantir.com/2020/09/24/dwarrowdelf-cycle-conclusion/", "Sep 24 2020");
            AddLink("Passage through Mirkwood", "https://visionofthepalantir.com/2020/09/05/passage-through-mirkwood/", "Sep 5 2020")
                .WithLabels(Scenario.PassageThroughMirkwood.StandardModeLabels());
            AddLink("Month in Review: August 2020", "https://visionofthepalantir.com/2020/08/31/month-in-review-august-2020/", "Aug 31 2020");
            AddLink("Encounter Set Review: Wilderlands", "https://visionofthepalantir.com/2020/08/29/encounter-set-review-wilderlands/", "Aug 29 2020")
                .WithLabels(EncounterSet.Wilderlands);
            AddLink("Monthly Poll: August 2020", "https://visionofthepalantir.com/2020/08/26/monthly-poll-august-2020/", "Aug 26 2020");
            AddLink("The Fate of Wilderland", "https://visionofthepalantir.com/2020/08/24/the-fate-of-wilderland/", "Aug 24 2020")
                .WithLabels(Scenario.TheFateOfWilderland);
            AddLink("The River Running", "https://visionofthepalantir.com/2020/08/22/the-river-running/", "Aug 22 2020")
                .WithLabels(Scenario.TheRiverRunning.StandardModeLabels());
            AddLink("Nightmare The Dread Realm", "https://visionofthepalantir.com/2020/08/17/nightmare-the-dread-realm/", "Aug 17 2020")
                .WithLabels(Scenario.TheDreadRealm.NightmareModeLabels());
            AddLink("Player card review: Shadow and Flame", "https://visionofthepalantir.com/2020/08/08/player-card-review-shadow-and-flame/", "Aug 8 2020")
                .WithLabels(Product.ShadowAndFlame.PlayerCardLabels());
            AddLink("First Impressions: The Land of Sorrow", "https://visionofthepalantir.com/2020/08/06/first-impressions-the-land-of-sorrow/", "Aug 6 2020")
                .WithLabels(Product.TheLandOfShadow);
            AddLink("Month in Review: July 2020", "https://visionofthepalantir.com/2020/07/30/month-in-review-july-2020/", "July 30 2020");
            AddLink("Beneath the Sands", "https://visionofthepalantir.com/2020/07/28/beneath-the-sands/", "July 28 2020")
                .WithLabels(Product.BeneathTheSands);
            AddLink("Promo: Custom 3D printed tokens", "https://visionofthepalantir.com/2020/07/26/promo-custom-3d-printed-tokens/", "July 26 2020");
            AddLink("Monthly Poll: July 2020", "https://visionofthepalantir.com/2020/07/24/monthly-poll-july-2020/", "July 24 2020");
            AddLink("Nightmare Across the Ettenmoors", "https://visionofthepalantir.com/2020/07/22/nightmare-across-the-ettenmoors/", "July 22 2020")
                .WithLabels(Scenario.AcrossTheEttenmoors.NightmareModeLabels());
            AddLink("The Stone of Erech", "https://visionofthepalantir.com/2020/07/17/the-stone-of-erech/", "July 17 2020")
                .WithLabels(Scenario.TheStoneOfErech.StandardModeLabels());
            AddLink("The Ghost of Framsburg", "https://visionofthepalantir.com/2020/07/15/the-ghost-of-framsburg/", "July 15 2020")
                .WithLabels(Product.TheGhostOfFramsburg);
            AddLink("Nightmare Conflict at the Carrock", "https://visionofthepalantir.com/2020/07/11/nightmare-conflict-at-the-carrock/", "Sat, 11 Jul 2020")
                .WithLabels(Scenario.ConflictAtTheCarrock.NightmareModeLabels());
            AddLink("Thorongil", "https://visionofthepalantir.com/2020/07/04/thorongil/", "Sat, 04 Jul 2020")
                .WithLabels("Thoringil");
            AddLink("Mount Gundabad", "https://visionofthepalantir.com/2020/07/03/mount-gundabad/", "Fri, 03 Jul 2020")
                .WithLabels(Product.MountGundabad);
            AddLink("Month in Review: June 2020", "https://visionofthepalantir.com/2020/06/30/month-in-review-june-2020/", "Jun 30 2020");
            AddLink("Encounter Set Review: Sauron's Reach", "https://visionofthepalantir.com/2020/06/28/encounter-set-review-saurons-reach/", "Jun 28 2020")
                .WithLabels(EncounterSet.SauronsReach);
            AddLink("Monthly Poll: June 20202", "https://visionofthepalantir.com/2020/06/25/monthly-poll-june-2020/", "Jun 25 2020");
            AddLink("Encounter Set Review: Journey Along the Anduin", "https://visionofthepalantir.com/2020/06/17/encounter-set-review-journey-along-the-anduin/", "Jun 17 2020")
                .WithLabels(EncounterSet.JourneyAlongTheAnduin);
            AddLink("Master Cards", "https://visionofthepalantir.com/2020/06/15/master-cards/", "Jun 15 2020")
                .WithLabels(ProductRepository.Instance.TraitLabels("Master.", (c) => c.IsPlayerCard()));
            AddLink("Pipes", "https://visionofthepalantir.com/2020/06/11/pipes/", "Jun 11 2020")
                .WithLabels(ProductRepository.Instance.TraitLabels("Pipe.", (c) => c.IsPlayerCard()));
            AddLink("Deckbuilding: Intruders in Chetwood", "https://visionofthepalantir.com/2020/06/03/deckbuilding-intruders-in-chetwood/", "Jun 3 2020")
                .WithLabels(Scenario.IntrudersInChetwood.StandardModeLabels());
            AddLink("Month in Review: May 2020", "https://visionofthepalantir.com/2020/05/31/month-in-review-may-2020/", "May 31 2020");
            AddLink("Player Card Review: Foundations of Stone", "https://visionofthepalantir.com/2020/05/29/player-card-review-foundations-of-stone/", "May 29 2020")
                .WithLabels(Product.FoundationsOfStone.PlayerCardLabels());
            AddLink("Staples: Recursion", "https://visionofthepalantir.com/2020/05/27/staples-recursion/", "May 27 2020");
            AddLink("Monthly Poll: May 2020", "https://visionofthepalantir.com/2020/05/24/monthly-poll-may-2020/", "May 24 2020");
            AddLink("Murder at the Prancing Pony", "https://visionofthepalantir.com/2020/05/22/murder-at-the-prancing-pony/", "May 22 2020")
                .WithLabels(Scenario.MurderAtThePrancingPony.StandardModeLabels());
            AddLink("Nightmare A Journey to Rhosgobel", "https://visionofthepalantir.com/2020/05/20/nightmare-a-journey-to-rhosgobel/", "May 20 2020")
                .WithLabels(Scenario.AJourneyToRhosgobel.StandardModeLabels());
            AddLink("Staples: Mustering", "https://visionofthepalantir.com/2020/05/12/staples-mustering/", "May 12 2020");
            AddLink("Fire in the Night", "https://visionofthepalantir.com/2020/05/10/fire-in-the-night/", "May 10 2020")
                .WithLabels(Product.FireInTheNight);
            AddLink("Roam Across Rhovanion", "https://visionofthepalantir.com/2020/05/04/roam-across-rhovanion/", "May 4 2020")
                .WithLabels(Product.RoamAcrossRhovanion);
            AddLink("Month in Review: April 2020", "https://visionofthepalantir.com/2020/04/30/month-in-review-april-2020/", "April 30 2020");
            AddLink("Monthly Poll: April 2020", "https://visionofthepalantir.com/2020/04/25/monthly-poll-april-2020/", "April 25 2020");
            AddLink("Flies and Spiders", "https://visionofthepalantir.com/2020/04/18/flies-and-spiders/", "April 18 2020")
                .WithLabels(Scenario.FliesAndSpiders.StandardModeLabels());
            AddLink("Encounter Set Review: Spiders of Mirkwood", "https://visionofthepalantir.com/2020/04/14/encounter-set-review-spiders-of-the-mirkwood/", "April 14 2020")
                .WithLabels(EncounterSet.SpidersOfMirkwood);
            AddLink("The Withered Heath", "https://visionofthepalantir.com/2020/04/11/the-withered-heath/", "April 11 2020")
                .WithLabels(Product.TheWitheredHeath);
            AddLink("Solo Player Quests", "https://visionofthepalantir.com/2020/04/09/solo-player-quests/", "April 9 2020");
            AddLink("First Impressions: Under the Ash Mountains", "https://visionofthepalantir.com/2020/04/04/first-impressions-under-the-ash-mountains/", "April 4 2020")
                .WithLabels(Scenario.UnderTheAshMountains.StandardModeLabels());
            AddLink("Nightmare Escape from Dol Goldur", "https://visionofthepalantir.com/2020/04/01/nightmare-escape-from-dol-guldur/", "April 1 2020")
                .WithLabels(Scenario.EscapeFromDolGuldur.NightmareModeLabels());
            AddLink("Month in Review: March 2020", "https://visionofthepalantir.com/2020/03/30/month-in-review-march-2020/", "March 30 2020");
            AddLink("The Mumakil", "https://visionofthepalantir.com/2020/03/27/the-mumakil/", "March 27 2020")
                .WithLabels(Product.TheMumakil);
            AddLink("Monthly Poll: March 2020", "https://visionofthepalantir.com/2020/03/25/monthly-poll-march-2020/", "March 25 2020");
            AddLink("Player card review: The Long Dark", "https://visionofthepalantir.com/2020/03/21/player-card-review-the-long-dark/", "March 21 2020")
                .WithLabels(Product.TheLongDark.PlayerCardLabels());
            AddLink("Nightmare Return to Mirkwood", "https://visionofthepalantir.com/2020/03/11/nightmare-return-to-mirkwood/", "March 11 2020")
                .WithLabels(Scenario.ReturnToMirkwood.NightmareModeLabels());
            AddLink("Fellowship", "https://visionofthepalantir.com/2020/03/05/fellowship/", "March 5 2020")
                .WithLabels("Fellowship");
            AddLink("Encounter Set Review: Dol Guldur Orcs", "https://visionofthepalantir.com/2020/03/03/encounter-set-review-dol-guldur-orcs/", "March 3 2020")
                .WithLabels(EncounterSet.DolGuldurOrcs);
            AddLink("Month in Review: February 2020", "https://visionofthepalantir.com/2020/02/29/month-in-review-february-2020/", "Feb 29 2020");
            AddLink("Monthly Poll: February 2020", "https://visionofthepalantir.com/2020/02/26/monthly-poll-february-2020/", "Feb 26 2020");
            AddLink("Messenger of the King", "https://visionofthepalantir.com/2020/02/24/messenger-of-the-king/", "Feb 24 2020")
                .WithLabels("Messenger of the King");
            AddLink("The King's Quest", "https://visionofthepalantir.com/2020/02/22/the-kings-quest/", "Feb 22 2020")
                .WithLabels(Scenario.TheKingsQuest.StandardModeLabels());
            AddLink("First Impressions: The Challenge of the Wainriders", "https://visionofthepalantir.com/2020/02/16/first-impressions-the-challenge-of-the-wainriders/", "Feb 16 2020")
                .WithLabels(Scenario.ChallengeOfTheWainriders.StandardModeLabels());
            AddLink("Encounter Set Review: Passage Through Mirkwood", "https://visionofthepalantir.com/2020/02/10/encounter-set-review-passage-through-mirkwood/", "Feb 10 2020")
                .WithLabels(EncounterSet.PassageThroughMirkwood);
            AddLink("Lost In Mirkwood", "https://visionofthepalantir.com/2020/02/08/lost-in-mirkwood/", "Feb 8 2020")
                .WithLabels(Scenario.LostInMirkwood.StandardModeLabels());
            AddLink("Testing Quests (or: How I Learned to Stop Worrying and Love My Deck)", "https://visionofthepalantir.com/2020/02/05/testing-quests-or-how-i-learned-to-stop-worrying-and-love-my-deck/", "Feb 5 2020");
            AddLink("Player card review: The Watcher in the Water", "https://visionofthepalantir.com/2020/02/02/player-card-review-the-watcher-in-the-water/", "Feb 2 2020")
                .WithLabels(Product.TheWatcherInTheWater.PlayerCardLabels());
            AddLink("Month in Review: January 2020", "https://visionofthepalantir.com/2020/01/31/month-in-review-january-2020/", "Fri, 31 Jan 2020 11:45:29 +0000");
            AddLink("First Impressions: Wrath and Ruin", "https://visionofthepalantir.com/2020/01/28/first-impressions-wrath-and-ruin/", "Tue, 28 Jan 2020 15:41:14 +0000")
                .WithLabels(Product.WrathAndRuin);
            AddLink("Monthly Poll: January 2020", "https://visionofthepalantir.com/2020/01/26/monthly-poll-january-2020/", "Sun, 26 Jan 2020 13:36:06 +0000");
            AddLink("First Impressions: The City of Ulfast", "https://visionofthepalantir.com/2020/01/23/first-impressions-the-city-of-ulfast/", "Thu, 23 Jan 2020 17:27:14 +0000")
                .WithLabels(Product.TheCityOfUlfast);
            AddLink("Second year Anniversary", "https://visionofthepalantir.com/2020/01/21/second-year-anniversary/", "Tue, 21 Jan 2020 10:30:34 +0000");
            AddLink("Nightmare The Dead Marshes", "https://visionofthepalantir.com/2020/01/18/nightmare-the-dead-marshes/", "Sat, 18 Jan 2020 16:18:46 +0000")
                .WithLabels(Scenario.TheDeadMarshes.NightmareModeLabels());
            AddLink("Journey Up the Anduin", "https://visionofthepalantir.com/2020/01/08/journey-up-the-anduin/", "Wed, 08 Jan 2020 14:20:43 +0000")
                .WithLabels(Scenario.JourneyUpTheAnduin.StandardModeLabels());
            AddLink("Player card review: Road to Rivendell", "https://visionofthepalantir.com/2020/01/04/player-card-review-road-to-rivendell/", "Sat, 04 Jan 2020 13:04:18 +0000")
                .WithLabels(Product.RoadToRivendell.PlayerCardLabels());
            AddLink("Monthly Poll: December 2019", "https://visionofthepalantir.com/2020/01/01/monthly-poll-december-2019/", "Wed, 01 Jan 2020 00:00:35 +0000");
            
            AddYear(2019);
            AddLink("Month in Review: December 2019", "https://visionofthepalantir.com/2019/12/31/month-in-review-december-2019/", "Tue, 31 Dec 2019 12:04:12 +0000");
            AddLink("2019: A year in numbers", "https://visionofthepalantir.com/2019/12/28/2019-a-year-in-numbers/", "Sat, 28 Dec 2019 14:31:44 +0000");
            AddLink("Player card review: The Redhorn Gate", "https://visionofthepalantir.com/2019/12/17/player-card-review-the-redhorn-gate/", "Tue, 17 Dec 2019 12:13:22 +0000")
                .WithLabels(Product.TheRedhornGate.PlayerCardLabels());
            AddLink("Collectables in LOTR LCG", "https://visionofthepalantir.com/2019/12/14/collectables-in-lotr-lcg/", "Sat, 14 Dec 2019 11:47:50 +0000");
            AddLink("Creatures", "https://visionofthepalantir.com/2019/12/12/creatures/", "Thu, 12 Dec 2019 12:31:09 +0000")
                .WithLabels(ProductRepository.Instance.TraitLabels("Creature.", c => c.IsPlayerCard()));
            AddLink("Deckbuilding in the Ringmaker-cycle", "https://visionofthepalantir.com/2019/12/10/deckbuilding-in-the-ringmaker-cycle/", "Tue, 10 Dec 2019 12:42:02 +0000");
            AddLink("Score in LOTR LCG", "https://visionofthepalantir.com/2019/12/08/score-in-lotr-lcg/", "Sun, 08 Dec 2019 14:29:43 +0000");
            AddLink("The Black Serpent", "https://visionofthepalantir.com/2019/12/03/the-black-serpent/", "Tue, 03 Dec 2019 13:29:14 +0000")
                .WithLabels(Product.TheBlackSerpent.PlayerCardLabels());
            AddLink("Month in Review: November 2019", "https://visionofthepalantir.com/2019/11/30/month-in-review-november-2019/", "Sat, 30 Nov 2019 19:17:57 +0000");
            AddLink("Deckbuilding: The Antlered Crown", "https://visionofthepalantir.com/2019/11/28/deckbuilding-the-antlered-crown/", "Thu, 28 Nov 2019 12:25:16 +0000")
                .WithLabels(Scenario.TheAntleredCrown.StandardModeLabels());
            AddLink("The Crossings of Poros", "https://visionofthepalantir.com/2019/11/26/the-crossings-of-poros/", "Tue, 26 Nov 2019 13:19:01 +0000")
                .WithLabels(Product.TheCrossingsOfPoros);
            AddLink("Monthly Poll: November 2019", "https://visionofthepalantir.com/2019/11/21/monthly-poll-november-2019/", "Thu, 21 Nov 2019 15:15:54 +0000");
            AddLink("\"Best\" LOTR LCG packs to buy", "https://visionofthepalantir.com/2019/11/15/best-lotr-lcg-packs-to-buy/", "Fri, 15 Nov 2019 18:50:35 +0000");
            AddLink("Deckbuilding: Celebrimbor's Secret", "https://visionofthepalantir.com/2019/11/12/deckbuilding-celebrimbors-secret/", "Tue, 12 Nov 2019 13:11:24 +0000")
                .WithLabels(Scenario.CelebrimborsSecret.StandardModeLabels());
            AddLink("The Dungeons of Cirith Gurat", "https://visionofthepalantir.com/2019/11/10/the-dungeons-of-cirith-gurat/", "Sun, 10 Nov 2019 12:53:06 +0000")
                .WithLabels(Product.TheDungeonsOfCirithGurat);
            AddLink("Player card review: Khazad-Dum", "https://visionofthepalantir.com/2019/11/08/player-card-review-khazad-dum/", "Fri, 08 Nov 2019 13:38:02 +0000")
                .WithLabels(Product.KhazadDum.PlayerCardLabels());
            AddLink("Month in Review: October 2019", "https://visionofthepalantir.com/2019/10/31/month-in-review-october-2019/", "Thu, 31 Oct 2019 11:22:46 +0000");
            AddLink("Mono-Tactics", "https://visionofthepalantir.com/2019/10/28/mono-tactics/", "Mon, 28 Oct 2019 13:08:34 +0000");
            AddLink("Monthly Poll: October 2019", "https://visionofthepalantir.com/2019/10/26/monthly-poll-october-2019/", "Sat, 26 Oct 2019 11:21:46 +0000");
            AddLink("Mono-Leadership", "https://visionofthepalantir.com/2019/10/24/mono-leadership/", "Thu, 24 Oct 2019 13:19:53 +0000");
            AddLink("Storage Solutions III", "https://visionofthepalantir.com/2019/10/21/storage-solutions-iii/", "Mon, 21 Oct 2019 12:18:24 +0000");
            AddLink("Mono-Lore", "https://visionofthepalantir.com/2019/10/18/mono-lore/", "Fri, 18 Oct 2019 14:14:02 +0000");
            AddLink("Q&A: October 2019", "https://visionofthepalantir.com/2019/10/15/qa-october-2019/", "Tue, 15 Oct 2019 12:19:47 +0000");
            AddLink("Con of the Rings 2019: Experiences and memories", "https://visionofthepalantir.com/2019/10/13/con-of-the-rings-2019-experiences-and-memories/", "Sun, 13 Oct 2019 14:00:52 +0000");
            AddLink("Shadows of Mirkwood cycle conclusion", "https://visionofthepalantir.com/2019/10/08/shadows-of-mirkwood-cycle-conclusion/", "Tue, 08 Oct 2019 14:22:42 +0000");
            AddLink("Vision of the Palantir Loot 2019", "https://visionofthepalantir.com/2019/10/04/vision-of-the-palantir-loot-2019/", "Fri, 04 Oct 2019 20:19:15 +0000");
            AddLink("Mono-Spirit", "https://visionofthepalantir.com/2019/10/02/mono-spirit/", "Tue, 01 Oct 2019 23:29:27 +0000");
            AddLink("Month in review: September 2019", "https://visionofthepalantir.com/2019/09/29/month-in-review-september-2019/", "Sun, 29 Sep 2019 11:06:22 +0000");
            AddLink("Monthly Poll: September 2019", "https://visionofthepalantir.com/2019/09/25/monthly-poll-september-2019/", "Wed, 25 Sep 2019 08:27:49 +0000");
            AddLink("Deckbuilding: The Nîn-in-Eilph", "https://visionofthepalantir.com/2019/09/24/deckbuilding-the-nin-in-eilph/", "Tue, 24 Sep 2019 07:24:42 +0000")
                .WithLabels(Scenario.TheNinInEilph.StandardModeLabels());
            AddLink("Raid on the Grey Havens", "https://visionofthepalantir.com/2019/09/23/raid-on-the-grey-havens/", "Mon, 23 Sep 2019 14:38:21 +0000")
                .WithLabels(Scenario.RaidOnTheGreyHavens.StandardModeLabels());
            AddLink("Doomed", "https://visionofthepalantir.com/2019/09/19/doomed/", "Thu, 19 Sep 2019 11:06:56 +0000");
            AddLink("Guarded Cards", "https://visionofthepalantir.com/2019/09/16/guarded-cards/", "Mon, 16 Sep 2019 11:49:14 +0000");
            AddLink("Staples: Location control", "https://visionofthepalantir.com/2019/09/14/staples-location-control/", "Sat, 14 Sep 2019 13:34:47 +0000")
                .WithLabels("Asfaloth", "The Evening Star", "Mirkwood Explorer", "Map of Rhovanion", "Explorer's Almanac", "The Hidden Way", "Thror's Map", "Eryn Galen Settler",
                    "Thror's Key", "Heirs of Earendil", "Expert Trackers", "Northern Tracker", "South Away", "West Road Traveller", "Backtrack", "Warden of Arnor", "Rhovanion Outrider", "Strength of Will",
                    "Snowbourn Scout", "Mariner's Compass", "Ranger Summons", "Ranger of the North", 
                    "Legolas", "Blade of Gondolin", "Arod", "Meneldor");
            AddLink("Deckbuilding: Trouble in Tharbad", "https://visionofthepalantir.com/2019/09/10/deckbuilding-trouble-in-tharbad/", "Tue, 10 Sep 2019 07:20:00 +0000")
                .WithLabels(Scenario.TroubleInTharbad);
            AddLink("Escape from Umbar", "https://visionofthepalantir.com/2019/09/08/escape-from-umbar/", "Sun, 08 Sep 2019 12:40:41 +0000")
                .WithLabels(Scenario.EscapeFromUmbar.StandardModeLabels());
            AddLink("Dungeons Deep and Caverns Dim", "https://visionofthepalantir.com/2019/09/04/dungeons-deep-and-caverns-dim/", "Wed, 04 Sep 2019 18:04:37 +0000")
                .WithLabels(Scenario.DungeonsDeepAndCavernsDim);
            AddLink("Project Heat Death", "https://visionofthepalantir.com/2019/09/02/project-heat-death/", "Mon, 02 Sep 2019 08:38:36 +0000");
            AddLink("Month in Review: August 2019", "https://visionofthepalantir.com/2019/09/01/month-in-review-august-2019/", "Sun, 01 Sep 2019 09:14:01 +0000");
            AddLink("Monthly Poll: August 2019", "https://visionofthepalantir.com/2019/08/28/monthly-poll-august-2019/", "Wed, 28 Aug 2019 08:54:27 +0000");
            AddLink("Player card review: Return to Mirkwood", "https://visionofthepalantir.com/2019/08/27/player-card-review-return-to-mirkwood/", "Tue, 27 Aug 2019 06:36:56 +0000")
                .WithLabels(Product.ReturnToMirkwood.PlayerCardLabels());
            AddLink("Deckbuilding: The Three Trials", "https://visionofthepalantir.com/2019/08/24/deckbuilding-the-three-trials/", "Sat, 24 Aug 2019 13:21:29 +0000")
                .WithLabels(Scenario.TheThreeTrials);
            AddLink("Desert Crossing", "https://visionofthepalantir.com/2019/08/17/desert-crossing/", "Sat, 17 Aug 2019 15:19:10 +0000")
                .WithLabels(Scenario.DesertCrossing);
            AddLink("Flight from Moria: There and Back Again", "https://visionofthepalantir.com/2019/08/15/flight-from-moria-there-and-back-again/", "Thu, 15 Aug 2019 10:16:28 +0000")
                .WithLabels(Scenario.FlightFromMoria);
            AddLink("The Long Arm Of Mordor", "https://visionofthepalantir.com/2019/08/13/the-long-arm-of-mordor/", "Tue, 13 Aug 2019 07:14:00 +0000")
                .WithLabels(Scenario.TheLongArmOfMordor);
            AddLink("The Seventh Level: There and Back Again", "https://visionofthepalantir.com/2019/08/08/the-seventh-level-there-and-back-again/", "Thu, 08 Aug 2019 07:02:04 +0000")
                .WithLabels(Scenario.TheSeventhLevel);
            AddLink("First Impressions: A Shadow in the East", "https://visionofthepalantir.com/2019/08/06/first-impressions-a-shadow-in-the-east/", "Tue, 06 Aug 2019 06:42:31 +0000")
                .WithLabels(Product.AShadowInTheEast);
            AddLink("The Thing in the Depths", "https://visionofthepalantir.com/2019/08/04/the-thing-in-the-depths/", "Sun, 04 Aug 2019 12:10:31 +0000")
                .WithLabels(Product.TheThingInTheDepths);
            AddLink("Into the Pit: There and Back Again", "https://visionofthepalantir.com/2019/08/01/into-the-pit-there-and-back-again/", "Thu, 01 Aug 2019 07:59:31 +0000")
                .WithLabels(Scenario.IntoThePit);
            AddLink("Month in Review: July 2019", "https://visionofthepalantir.com/2019/07/31/month-in-review-july-2019/", "Wed, 31 Jul 2019 20:56:17 +0000");
            AddLink("Player card review: The Dead Marshes", "https://visionofthepalantir.com/2019/07/29/player-card-review-the-dead-marshes/", "Mon, 29 Jul 2019 06:45:22 +0000")
                .WithLabels(Product.TheDeadMarshes.PlayerCardLabels());
            AddLink("Deckbuilding: The Dunland Trap", "https://visionofthepalantir.com/2019/07/27/deckbuilding-the-dunland-trap/", "Sat, 27 Jul 2019 14:16:01 +0000")
                .WithLabels(Scenario.TheDunlandTrap);
            AddLink("Monthly Poll: July 2019", "https://visionofthepalantir.com/2019/07/26/monthly-poll-july-2019/", "Fri, 26 Jul 2019 09:15:46 +0000");
            AddLink("Intro to the Khazad-Dum cycle: There and Back Again", "https://visionofthepalantir.com/2019/07/25/intro-to-the-khazad-dum-cycle-there-and-back-again/", "Thu, 25 Jul 2019 06:51:50 +0000");
            AddLink("The City of Corsairs", "https://visionofthepalantir.com/2019/07/23/the-city-of-corsairs/", "Tue, 23 Jul 2019 18:34:59 +0000")
                .WithLabels(Product.TheCityOfCorsairs);
            AddLink("Storage Solutions: Kristian Priisholm", "https://visionofthepalantir.com/2019/07/20/storage-solutions-kristian-priisholm/", "Sat, 20 Jul 2019 08:35:27 +0000");
            AddLink("Return to Mirkwood: There and Back Again", "https://visionofthepalantir.com/2019/07/18/return-to-mirkwood-there-and-back-again/", "Thu, 18 Jul 2019 06:42:30 +0000")
                .WithLabels(Product.ReturnToMirkwood);
            AddLink("Storage Solutions: Idrial", "https://visionofthepalantir.com/2019/07/15/storage-solutions-idrial/", "Mon, 15 Jul 2019 08:33:25 +0000");
            AddLink("Deckbuilding: Into Fangorn", "https://visionofthepalantir.com/2019/07/13/deckbuilding-into-fangorn/", "Sat, 13 Jul 2019 12:13:11 +0000")
                .WithLabels(Scenario.IntoFangorn);
            AddLink("The Dead Marshes: There and Back Again", "https://visionofthepalantir.com/2019/07/11/the-dead-marshes-there-and-back-again/", "Thu, 11 Jul 2019 06:38:26 +0000")
                .WithLabels(Product.TheDeadMarshes);
            AddLink("A Storm on Cobas Haven", "https://visionofthepalantir.com/2019/07/09/a-storm-on-cobas-haven/", "Tue, 09 Jul 2019 07:18:37 +0000")
                .WithLabels(Product.AStormOnCobasHaven);
            AddLink("First Impressions: The Fate of Wilderland", "https://visionofthepalantir.com/2019/07/07/first-impressions-the-fate-of-wilderland/", "Sun, 07 Jul 2019 11:46:15 +0000")
                .WithLabels(Product.TheFateOfWilderland);
            AddLink("The Hills of Emyn Muil: There and Back Again", "https://visionofthepalantir.com/2019/07/04/the-hills-of-emyn-muil-there-and-back-again/", "Thu, 04 Jul 2019 06:42:24 +0000")
                .WithLabels(Product.TheHillsOfEmynMuil);
            AddLink("Deckbuilding: To Catch an Orc", "https://visionofthepalantir.com/2019/07/02/deckbuilding-to-catch-an-orc/", "Tue, 02 Jul 2019 06:39:17 +0000")
                .WithLabels(Scenario.ToCatchAnOrc);
            AddLink("Month in Review: June 2019", "https://visionofthepalantir.com/2019/06/30/month-in-review-june-2019/", "Sun, 30 Jun 2019 15:47:26 +0000");
            AddLink("Player card review: The Hills of Emyn Muil", "https://visionofthepalantir.com/2019/06/28/player-card-review-the-hills-of-emyn-muil/", "Fri, 28 Jun 2019 18:53:47 +0000")
                .WithLabels(Product.TheHillsOfEmynMuil.PlayerCardLabels());
            AddLink("A Journey to Rhosgobel: There and Back Again", "https://visionofthepalantir.com/2019/06/27/a-journey-to-rhosgobel-there-and-back-again/", "Thu, 27 Jun 2019 06:59:01 +0000")
                .WithLabels(Product.AJourneyToRhosgobel);
            AddLink("Monthly Poll: June 2019", "https://visionofthepalantir.com/2019/06/25/monthly-poll-june-2019/", "Tue, 25 Jun 2019 09:42:02 +0000");
            AddLink("Splash heroes", "https://visionofthepalantir.com/2019/06/23/splash-heroes/", "Sun, 23 Jun 2019 11:46:12 +0000")
                .WithLabels("Theodred", "Théodred", "Celebrían's Stone", "Celebrian's Stone", "Dúnedain Quest", "Dunedain Quest", "Heir of Mardil",
                    "Sam Gamgee", "Bill the Pony", "Hobbit Cloak", "Drinking Song", "Rosie Cotton",
                    "Gildor Inglorion", "Denethor", "In Service of the Steward", "Steward of Gondor", "Armored Destrier",
                    "Balin", "King Under the Mountain", "Narvi's Belt", "Unlikely Friendship", "Dwarven Shield",
                    "Amarthiúl", "Amarthiul", "Ranger Summons", "Outmatched", "Armored Destrier",
                    "Éowyn", "Eowyn", "Hour of Wrath", "Grappling Hook", "Golden Shield",
                    "Mablung", "Gondorian Shield", "Followed", "Outmatched", "Wait No Longer", "Dúnedain Hunter", "Dunedain Hunter",
                    "Na'asiyah", "Raiment of War", "Magic Ring",
                    "Beravor", "Leather Boots", "Athelas", "Wingfoot", "A Burning Brand",
                    "Folco Boffin", "Vanish from Sight", "Strider", "Prince Imrahil", "Houses of Healing", "Drinking Song",
                    "Bifur", "Unlikely Friendship", "Narvi's Belt", "A Good Harvest",
                    "Pippin", "Gaffer Gamgee", "Fast Hitch",
                    "Gríma", "Grima", "Keys of Orthanc", "Woodmen’s Clearing",
                    "Eleanor", "Silver Lamp", "Blood of Númenor", "Blood of Numenor", "Livery of the Tower", "Gondorian Shield", "Unexpected Courage",
                    "Windfola", "Elven-light", "Glorfindel", "Stand and Fight", "Reforged",
                    "Light of Valinor", "Asfaloth", "Elrond's Counsel",
                    "Merry", "Hobbit Pony", "Hobbit Pipe", "Late Adventurer",
                    "Arwen Undómiel", "Arwen Undomiel", "Silver Harp");
            AddLink("Conflict at the Carrock: There and Back Again", "https://visionofthepalantir.com/2019/06/20/conflict-at-the-carrock-there-and-back-again/", "Thu, 20 Jun 2019 06:37:59 +0000")
                .WithLabels(Scenario.ConflictAtTheCarrock);
            AddLink("Storage Solutions: Nemesis", "https://visionofthepalantir.com/2019/06/15/storage-solutions-nemesis/", "Sat, 15 Jun 2019 12:13:00 +0000");
            AddLink("The Hunt for Gollum: There and Back Again", "https://visionofthepalantir.com/2019/06/13/the-hunt-for-gollum-there-and-back-again/", "Thu, 13 Jun 2019 06:42:08 +0000")
                .WithLabels(Scenario.TheHuntForGollum);
            AddLink("Flight of the Stormcaller", "https://visionofthepalantir.com/2019/06/08/flight-of-the-stormcaller/", "Sat, 08 Jun 2019 12:35:07 +0000")
                .WithLabels(Scenario.FlightOfTheStormcaller);
            AddLink("Escape from Dol Guldur: There and Back Again", "https://visionofthepalantir.com/2019/06/06/escape-from-dol-guldur-there-and-back-again/", "Thu, 06 Jun 2019 06:54:08 +0000")
                .WithLabels(Scenario.EscapeFromDolGuldur);
            AddLink("Levels of LOTR LCG players", "https://visionofthepalantir.com/2019/06/02/levels-of-lotr-lcg-players/", "Sun, 02 Jun 2019 11:36:00 +0000");
            AddLink("Month in review: May 2019", "https://visionofthepalantir.com/2019/05/31/month-in-review-may-2019/", "Fri, 31 May 2019 13:35:48 +0000");
            AddLink("Journey Along the Anduin: There and Back Again", "https://visionofthepalantir.com/2019/05/30/journey-along-the-anduin-there-and-back-again/", "Thu, 30 May 2019 08:08:27 +0000")
                .WithLabels(Scenario.JourneyAlongTheAnduin);
            AddLink("Monthly Poll: May 2019", "https://visionofthepalantir.com/2019/05/28/monthly-poll-may-2019/", "Tue, 28 May 2019 06:42:26 +0000");
            AddLink("Player card review: A Journey to Rhosgobel", "https://visionofthepalantir.com/2019/05/27/player-card-review-a-journey-to-rhosgobel/", "Mon, 27 May 2019 17:41:22 +0000")
                .WithLabels(Product.AJourneyToRhosgobel.PlayerCardLabels());
            AddLink("Passage through Mirkwood: There and Back again", "https://visionofthepalantir.com/2019/05/23/passage-through-mirkwood-there-and-back-again/", "Thu, 23 May 2019 06:34:15 +0000")
                .WithLabels(Scenario.PassageThroughMirkwood);
            AddLink("Nightmare Journey Along the Anduin", "https://visionofthepalantir.com/2019/05/18/nightmare-journey-along-the-anduin/", "Sat, 18 May 2019 16:33:33 +0000")
                .WithLabels(Scenario.JourneyAlongTheAnduin.NightmareModeLabels());
            AddLink("Intro to the Mirkwood cycle", "https://visionofthepalantir.com/2019/05/16/intro-to-the-mirkwood-cycle/", "Thu, 16 May 2019 06:44:19 +0000");
            AddLink("Storage solutions: Dave Walsh of Card Talk", "https://visionofthepalantir.com/2019/05/14/storage-solutions-dave-walsh-of-card-talk/", "Tue, 14 May 2019 06:47:15 +0000");
            AddLink("Deckbuilding: The Fords of Isen", "https://visionofthepalantir.com/2019/05/12/deckbuilding-the-fords-of-isen/", "Sun, 12 May 2019 14:22:37 +0000")
                .WithLabels(Scenario.TheFordsOfIsen);
            AddLink("Story Mode: Rules", "https://visionofthepalantir.com/2019/05/09/story-mode-rules/", "Thu, 09 May 2019 06:35:44 +0000");
            AddLink("Storage Solutions: Solanum", "https://visionofthepalantir.com/2019/05/07/storage-solutions-solanum/", "Tue, 07 May 2019 06:37:39 +0000");
            AddLink("Staples: Direct Damage", "https://visionofthepalantir.com/2019/05/05/staples-direct-damage/", "Sun, 05 May 2019 10:50:48 +0000");
            AddLink("Introduction to the There and Back Again series", "https://visionofthepalantir.com/2019/05/02/introduction-to-the-there-and-back-again-series/", "Thu, 02 May 2019 16:04:29 +0000");
            AddLink("Storage Solutions: Catastrophic", "https://visionofthepalantir.com/2019/05/01/storage-solutions-catastrophic/", "Wed, 01 May 2019 06:32:09 +0000");
            AddLink("Month in review: April 2019", "https://visionofthepalantir.com/2019/04/30/month-in-review-april-2019/", "Tue, 30 Apr 2019 06:35:17 +0000");
            AddLink("Monthly Poll: April 2019", "https://visionofthepalantir.com/2019/04/27/monthly-poll-april-2019/", "Sat, 27 Apr 2019 15:19:57 +0000");
            AddLink("Storage Solutions: Codus", "https://visionofthepalantir.com/2019/04/25/storage-solutions-codus/", "Thu, 25 Apr 2019 13:52:40 +0000");
            AddLink("Player card review: Conflict at the Carrock", "https://visionofthepalantir.com/2019/04/24/player-card-review-conflict-at-the-carrock/", "Wed, 24 Apr 2019 06:38:23 +0000")
                .WithLabels(Product.ConflictAtTheCarrock.PlayerCardLabels());
            AddLink("Storage Solutions: McDog3", "https://visionofthepalantir.com/2019/04/21/storage-solutions-mcdog3/", "Sun, 21 Apr 2019 11:43:56 +0000");
            AddLink("First Impressions: Mount Gundabad", "https://visionofthepalantir.com/2019/04/19/first-impressions-mount-gundabad/", "Fri, 19 Apr 2019 07:45:40 +0000")
                .WithLabels(Scenario.MountGundabad);
            AddLink("The Temple of the Deceived", "https://visionofthepalantir.com/2019/04/10/the-temple-of-the-deceived/", "Wed, 10 Apr 2019 15:26:31 +0000")
                .WithLabels(Scenario.TempleOfTheDeceived);
            AddLink("Side-board", "https://visionofthepalantir.com/2019/04/05/side-board/", "Fri, 05 Apr 2019 18:17:29 +0000");
            AddLink("The Caves of Nibin-Dûm", "https://visionofthepalantir.com/2019/04/03/the-caves-of-nibin-dum/", "Wed, 03 Apr 2019 08:10:23 +0000")
                .WithLabels(Scenario.TheCavesOfNibinDum);
            AddLink("Steward", "https://visionofthepalantir.com/2019/04/01/steward/", "Mon, 01 Apr 2019 06:57:06 +0000")
                .WithLabels(ProductRepository.Instance.TraitLabels("Steward.", c => c.IsPlayerCard()));
            AddLink("Month in Review: March 2019", "https://visionofthepalantir.com/2019/03/30/month-in-review-march-2019/", "Sat, 30 Mar 2019 12:47:02 +0000");
            AddLink("Monthly Poll: March 2019", "https://visionofthepalantir.com/2019/03/28/monthly-poll-march-2019/", "Thu, 28 Mar 2019 13:35:40 +0000");
            AddLink("Player card review: Hunt for Gollum", "https://visionofthepalantir.com/2019/03/26/hunt-for-gollum/", "Tue, 26 Mar 2019 10:25:29 +0000")
                .WithLabels(Product.TheHuntForGollum.PlayerCardLabels());
            AddLink("The Drowned Ruins", "https://visionofthepalantir.com/2019/03/24/the-drowned-ruins/", "Sun, 24 Mar 2019 17:25:21 +0000")
                .WithLabels(Scenario.TheDrownedRuins);
            AddLink("Storage Solutions: Shellin", "https://visionofthepalantir.com/2019/03/17/storage-solutions-shellin/", "Sun, 17 Mar 2019 11:17:51 +0000");
            AddLink("Helm's Deep", "https://visionofthepalantir.com/2019/03/15/helms-deep/", "Fri, 15 Mar 2019 19:20:33 +0000")
                .WithLabels(Scenario.HelmsDeep);
            AddLink("Fog on the Barrow Downs", "https://visionofthepalantir.com/2019/03/13/fog-on-the-barrow-downs/", "Wed, 13 Mar 2019 17:59:26 +0000")
                .WithLabels(Scenario.FogOnTheBarrowDowns);
            AddLink("The Old Forest", "https://visionofthepalantir.com/2019/03/10/the-old-forest/", "Sun, 10 Mar 2019 15:33:13 +0000")
                .WithLabels(Scenario.TheOldForest);
            AddLink("The Fate of Númenor", "https://visionofthepalantir.com/2019/03/07/the-fate-of-numenor/", "Thu, 07 Mar 2019 15:35:13 +0000")
                .WithLabels(Scenario.TheFateOfNumenor);
            AddLink("Warrior", "https://visionofthepalantir.com/2019/03/04/warrior/", "Mon, 04 Mar 2019 12:28:23 +0000")
                .WithLabels(ProductRepository.Instance.TraitLabels("Warrior.", c => c.IsPlayerCard()));
            AddLink("Month in Review: February 2019", "https://visionofthepalantir.com/2019/03/01/month-in-review-february-2019/", "Fri, 01 Mar 2019 12:37:38 +0000");
            AddLink("Noble", "https://visionofthepalantir.com/2019/02/27/noble/", "Wed, 27 Feb 2019 15:19:18 +0000")
                .WithLabels(ProductRepository.Instance.TraitLabels("Noble.", c => c.IsPlayerCard()));
            AddLink("Monthly Poll: February 2019", "https://visionofthepalantir.com/2019/02/25/monthly-poll-february-2019/", "Mon, 25 Feb 2019 21:13:20 +0000");
            AddLink("Healer", "https://visionofthepalantir.com/2019/02/24/healer/", "Sun, 24 Feb 2019 12:53:05 +0000")
                .WithLabels(ProductRepository.Instance.TraitLabels("Healer.", c => c.IsPlayerCard()));;
            AddLink("Dale/Esgaroth", "https://visionofthepalantir.com/2019/02/22/dale-esgaroth/", "Fri, 22 Feb 2019 12:22:00 +0000")
                .WithLabels(ProductRepository.Instance.TraitLabels("Dale.", c => c.IsPlayerCard()))
                .WithLabels(ProductRepository.Instance.TraitLabels("Esgaroth.", c => c.IsPlayerCard()));
            AddLink("Multi-deck building", "https://visionofthepalantir.com/2019/02/19/multi-deck-building/", "Tue, 19 Feb 2019 14:40:28 +0000");
            AddLink("Neutral (Core set)", "https://visionofthepalantir.com/2019/02/16/neutral-core-set/", "Sat, 16 Feb 2019 10:31:36 +0000");
            AddLink("First Impressions: The Ghost of Framsburg", "https://visionofthepalantir.com/2019/02/13/first-impressions-the-ghost-of-framsburg/", "Wed, 13 Feb 2019 16:06:02 +0000")
                .WithLabels(Scenario.TheGhostOfFramsburg);
            AddLink("Lore Sphere (Core set)", "https://visionofthepalantir.com/2019/02/11/lore-sphere-core-set/", "Mon, 11 Feb 2019 12:56:03 +0000");
            AddLink("Valour", "https://visionofthepalantir.com/2019/02/09/valour/", "Sat, 09 Feb 2019 15:06:37 +0000");
            AddLink("Woodmen", "https://visionofthepalantir.com/2019/02/04/woodmen/", "Mon, 04 Feb 2019 14:42:42 +0000")
                .WithLabels(ProductRepository.Instance.TraitLabels("Woodman.", c => c.IsPlayerCard()));
            AddLink("Spirit Sphere (Core set)", "https://visionofthepalantir.com/2019/02/01/spirit-sphere-core-set/", "Fri, 01 Feb 2019 15:46:00 +0000");
            AddLink("Month in review: January 2019", "https://visionofthepalantir.com/2019/01/31/month-in-review-january-2019/", "Thu, 31 Jan 2019 11:55:37 +0000");
            AddLink("Monthly Poll: January 2019", "https://visionofthepalantir.com/2019/01/26/monthly-poll-january-2019/", "Sat, 26 Jan 2019 19:22:41 +0000");
            AddLink("The Battle of Carn Dûm", "https://visionofthepalantir.com/2019/01/24/the-battle-of-carn-dum/", "Thu, 24 Jan 2019 11:31:52 +0000")
                .WithLabels(Scenario.TheBattleOfCarnDum);
            AddLink("Tactic Sphere (Core set)", "https://visionofthepalantir.com/2019/01/22/tactic-sphere-core-set/", "Tue, 22 Jan 2019 13:28:08 +0000");
            AddLink("First Year Anniversary", "https://visionofthepalantir.com/2019/01/20/first-year-anniversary/", "Sat, 19 Jan 2019 23:00:51 +0000");
            AddLink("Leadership Sphere (Core set)", "https://visionofthepalantir.com/2019/01/15/leadership-sphere-core-set/", "Tue, 15 Jan 2019 12:49:51 +0000");
            AddLink("Voyage Across Belegaer", "https://visionofthepalantir.com/2019/01/12/voyage-across-belegaer/", "Sat, 12 Jan 2019 11:16:36 +0000")
                .WithLabels(Scenario.VoyageAcrossBelegaer);
            AddLink("Harad", "https://visionofthepalantir.com/2019/01/08/harad/", "Tue, 08 Jan 2019 08:08:32 +0000")
                .WithLabels(ProductRepository.Instance.TraitLabels("Harad.", c => c.IsPlayerCard()));
            AddLink("Nightmare The Hills of Emyn Muil", "https://visionofthepalantir.com/2019/01/05/nightmare-the-hills-of-emyn-muil/", "Sat, 05 Jan 2019 12:24:49 +0000")
                .WithLabels(Scenario.TheHillsOfEmynMuil.NightmareModeLabels());
            AddLink("Ships and Sailing tests", "https://visionofthepalantir.com/2019/01/02/ships-and-sailing-tests/", "Wed, 02 Jan 2019 16:25:02 +0000");
            
            AddYear(2018);
            AddLink("Monthly Poll: December 2018", "https://visionofthepalantir.com/2019/01/01/monthly-poll-december-2018/", "Mon, 31 Dec 2018 23:24:24 +0000");
            AddLink("2018: A year in numbers", "https://visionofthepalantir.com/2018/12/31/2018-a-year-in-numbers/", "Mon, 31 Dec 2018 01:00:26 +0000");
            AddLink("Month in review: December 2018", "https://visionofthepalantir.com/2018/12/30/month-in-review-december-2018/", "Sun, 30 Dec 2018 13:23:16 +0000");
            AddLink("Staples: Shadow card manipulation", "https://visionofthepalantir.com/2018/12/28/staples-shadow-card-manipulation/", "Fri, 28 Dec 2018 18:45:00 +0000");
            AddLink("First Impressions: Fire in the Night", "https://visionofthepalantir.com/2018/12/15/first-impressions-fire-in-the-night/", "Sat, 15 Dec 2018 21:40:10 +0000")
                .WithLabels(Product.FireInTheNight);
            AddLink("Lure of Middle Earth Announcement", "https://visionofthepalantir.com/2018/12/12/lure-of-middle-earth-announcement/", "Wed, 12 Dec 2018 15:57:48 +0000");
            AddLink("Gondor", "https://visionofthepalantir.com/2018/12/09/gondor/", "Sun, 09 Dec 2018 11:59:38 +0000")
                .WithLabels(ProductRepository.Instance.TraitLabels("Gondor.", c => c.IsPlayerCard()));
            AddLink("Escape from Mount Gram", "https://visionofthepalantir.com/2018/12/07/escape-from-mount-gram/", "Fri, 07 Dec 2018 11:09:05 +0000")
                .WithLabels(Scenario.EscapeFromMountGram);
            AddLink("Month in Review: November 2018", "https://visionofthepalantir.com/2018/11/30/month-in-review-november-2018/", "Fri, 30 Nov 2018 10:41:30 +0000");
            AddLink("Monthly Poll: November 2018", "https://visionofthepalantir.com/2018/11/26/monthly-poll-november-2018/", "Mon, 26 Nov 2018 12:32:55 +0000");
            AddLink("The Oath", "https://visionofthepalantir.com/2018/11/24/the-oath/", "Sat, 24 Nov 2018 14:21:41 +0000")
                .WithLabels(Scenario.TheOath);
            AddLink("Over the Misty Mountains Grim", "https://visionofthepalantir.com/2018/11/22/over-the-misty-mountains-grim/", "Thu, 22 Nov 2018 11:39:03 +0000")
                .WithLabels(Scenario.OverTheMistyMountainsGrim);
            AddLink("The Treachery of Rhudaur", "https://visionofthepalantir.com/2018/11/18/the-treachery-of-rhudaur/", "Sun, 18 Nov 2018 15:01:57 +0000")
                .WithLabels(Scenario.TheTreacheryOfRhudaur);
            AddLink("Q&A: November 2018", "https://visionofthepalantir.com/2018/11/14/qa-november-2018/", "Wed, 14 Nov 2018 14:24:39 +0000");
            AddLink("The Dread Realm", "https://visionofthepalantir.com/2018/11/11/the-dread-realm/", "Sun, 11 Nov 2018 14:45:26 +0000")
                .WithLabels(Scenario.TheDreadRealm);
            AddLink("Scout", "https://visionofthepalantir.com/2018/11/04/scout/", "Sun, 04 Nov 2018 14:53:07 +0000")
                .WithLabels(ProductRepository.Instance.TraitLabels("Scout.", c => c.IsPlayerCard()));
            AddLink("Month in Review: October 2018 and Q&A announcement", "https://visionofthepalantir.com/2018/10/30/month-in-review-october-2018-and-qa-announcement/", "Tue, 30 Oct 2018 12:33:06 +0000");
            AddLink("Across the Ettenmoors", "https://visionofthepalantir.com/2018/10/27/across-the-ettenmoors/", "Sat, 27 Oct 2018 10:28:52 +0000")
                .WithLabels(Scenario.AcrossTheEttenmoors);
            AddLink("Monthly Poll: October 2018", "https://visionofthepalantir.com/2018/10/24/monthly-poll-october-2018/", "Wed, 24 Oct 2018 17:42:41 +0000");
            AddLink("The Wastes of Eriador", "https://visionofthepalantir.com/2018/10/22/the-wastes-of-eriador/", "Mon, 22 Oct 2018 19:25:43 +0000")
                .WithLabels(Scenario.TheWastesOfEriador);
            AddLink("First Impressions: Roam Across Rhovanion", "https://visionofthepalantir.com/2018/10/20/first-impressions-roam-across-rhovanion/", "Sat, 20 Oct 2018 14:43:13 +0000")
                .WithLabels(Product.RoamAcrossRhovanion);
            AddLink("Con of the Rings 2018: Experiences and memories", "https://visionofthepalantir.com/2018/10/17/con-of-the-rings-2018-experiences-and-memories/", "Wed, 17 Oct 2018 14:17:02 +0000");
            AddLink("Vision of the Palantir Swag 2018", "https://visionofthepalantir.com/2018/10/13/vision-of-the-palantir-swag-2018/", "Sat, 13 Oct 2018 02:13:17 +0000");
            AddLink("Staples: Healing", "https://visionofthepalantir.com/2018/10/12/staples-healing/", "Fri, 12 Oct 2018 11:47:31 +0000");
            AddLink("Deadmen's Dike", "https://visionofthepalantir.com/2018/10/08/deadmens-dike/", "Mon, 08 Oct 2018 19:20:41 +0000")
                .WithLabels(Scenario.DeadmensDike);
            AddLink("Ranger", "https://visionofthepalantir.com/2018/10/07/ranger/", "Sun, 07 Oct 2018 09:11:56 +0000")
                .WithLabels(ProductRepository.Instance.TraitLabels("Ranger.", c => c.IsPlayerCard()));
            AddLink("Month in Review: September 2018", "https://visionofthepalantir.com/2018/09/30/month-in-review-september-2018/", "Sun, 30 Sep 2018 14:07:41 +0000");
            AddLink("Monthly Poll: September 2018", "https://visionofthepalantir.com/2018/09/27/monthly-poll-september-2018/", "Thu, 27 Sep 2018 10:42:00 +0000");
            AddLink("Nightmare Hunt for Gollum", "https://visionofthepalantir.com/2018/09/25/nightmare-hunt-for-gollum/", "Tue, 25 Sep 2018 12:36:08 +0000")
                .WithLabels(Scenario.TheHuntForGollum.NightmareModeLabels());
            AddLink("Storage Solutions II", "https://visionofthepalantir.com/2018/09/22/storage-solutions-ii/", "Sat, 22 Sep 2018 15:39:28 +0000");
            AddLink("The Weather Hills", "https://visionofthepalantir.com/2018/09/20/the-weather-hills/", "Thu, 20 Sep 2018 13:03:32 +0000")
                .WithLabels(Scenario.TheWeatherHills);
            AddLink("Dúnedain", "https://visionofthepalantir.com/2018/09/16/dunedain/", "Sun, 16 Sep 2018 13:33:11 +0000")
                .WithLabels(ProductRepository.Instance.TraitLabels("Dúnedain.", c => c.IsPlayerCard()));
            AddLink("The Uruk-Hai", "https://visionofthepalantir.com/2018/09/11/the-uruk-hai/", "Tue, 11 Sep 2018 20:35:05 +0000")
                .WithLabels(Scenario.TheUrukHai);
            AddLink("New Player Quests", "https://visionofthepalantir.com/2018/09/07/new-player-quests/", "Fri, 07 Sep 2018 18:26:17 +0000");
            AddLink("Staples: Scrying (Player deck)", "https://visionofthepalantir.com/2018/09/05/staples-scrying-player-deck/", "Wed, 05 Sep 2018 18:55:23 +0000");
            AddLink("Breaking of the Fellowship", "https://visionofthepalantir.com/2018/09/03/breaking-of-the-fellowship/", "Mon, 03 Sep 2018 12:07:40 +0000")
                .WithLabels(Scenario.BreakingOfTheFellowship);
            AddLink("Month in Review: August 2018", "https://visionofthepalantir.com/2018/08/29/month-in-review-august-2018/", "Wed, 29 Aug 2018 14:06:35 +0000");
            AddLink("Monthly Poll: August 2018", "https://visionofthepalantir.com/2018/08/26/monthly-poll-august-2018/", "Sun, 26 Aug 2018 12:26:22 +0000");
            AddLink("Intruders in Chetwood", "https://visionofthepalantir.com/2018/08/25/intruders-in-chetwood/", "Sat, 25 Aug 2018 11:05:49 +0000")
                .WithLabels(Scenario.IntrudersInChetwood);
            AddLink("Nightmare Passage through Mirkwood", "https://visionofthepalantir.com/2018/08/18/nightmare-passage-through-mirkwood/", "Sat, 18 Aug 2018 10:06:17 +0000")
                .WithLabels(Scenario.PassageThroughMirkwood.NightmareModeLabels());
            AddLink("First Impressions: The Withered Heath", "https://visionofthepalantir.com/2018/08/12/first-impressions-the-withered-heath/", "Sun, 12 Aug 2018 11:03:34 +0000");
            AddLink("The Nîn-in-Eilph", "https://visionofthepalantir.com/2018/08/09/the-nin-in-eilph/", "Thu, 09 Aug 2018 18:39:27 +0000");
            AddLink("Is Nightmare Mode worth the Nightmares?", "https://visionofthepalantir.com/2018/08/04/is-nightmare-mode-worth-the-nightmares/", "Fri, 03 Aug 2018 23:19:49 +0000");
            AddLink("The Three Trials", "https://visionofthepalantir.com/2018/08/02/the-three-trials/", "Thu, 02 Aug 2018 09:31:11 +0000")
                .WithLabels(Scenario.TheThreeTrials);
            AddLink("Month in Review: July 2018", "https://visionofthepalantir.com/2018/07/31/month-in-review-july-2018/", "Tue, 31 Jul 2018 09:09:48 +0000");
            AddLink("Traps", "https://visionofthepalantir.com/2018/07/30/traps/", "Mon, 30 Jul 2018 08:45:40 +0000")
                .WithLabels(ProductRepository.Instance.TraitLabels("Trap.", c => c.IsPlayerCard()));
            AddLink("Monthly Poll: July 2018", "https://visionofthepalantir.com/2018/07/27/monthly-poll-july-2018/", "Fri, 27 Jul 2018 12:58:40 +0000");
            AddLink("The Antlered Crown", "https://visionofthepalantir.com/2018/07/23/the-antlered-crown/", "Mon, 23 Jul 2018 11:51:59 +0000")
                .WithLabels(Scenario.TheAntleredCrown);
            AddLink("Staples: Readying", "https://visionofthepalantir.com/2018/07/20/staples-readying/", "Fri, 20 Jul 2018 18:52:20 +0000");
            AddLink("Journey in the Dark", "https://visionofthepalantir.com/2018/07/18/journey-in-the-dark/", "Wed, 18 Jul 2018 08:46:45 +0000")
                .WithLabels(Scenario.JourneyInTheDark);
            AddLink("Isengard", "https://visionofthepalantir.com/2018/07/17/isengard/", "Tue, 17 Jul 2018 11:13:16 +0000")
                .WithLabels(ProductRepository.Instance.TraitLabels("Isengard.", c => c.IsPlayerCard()));
            AddLink("LOTR LCG: Urban Dictionary", "https://visionofthepalantir.com/2018/07/14/lotr-lcg-urban-dictionary/", "Sat, 14 Jul 2018 11:33:03 +0000");
            AddLink("Victory Display", "https://visionofthepalantir.com/2018/07/11/victory-display/", "Wed, 11 Jul 2018 08:48:20 +0000");
            AddLink("Race Across Harad", "https://visionofthepalantir.com/2018/07/09/race-across-harad/", "Mon, 09 Jul 2018 08:32:08 +0000")
                .WithLabels(Scenario.RaceAcrossHarad);
            AddLink("Player Side Quests", "https://visionofthepalantir.com/2018/07/08/player-side-quests/", "Sun, 08 Jul 2018 12:29:21 +0000");
            AddLink("The Dunland Trap", "https://visionofthepalantir.com/2018/07/03/the-dunland-trap/", "Tue, 03 Jul 2018 09:11:54 +0000")
                .WithLabels(Scenario.TheDunlandTrap);
            AddLink("Month in Review: June 2018", "https://visionofthepalantir.com/2018/06/30/month-in-review-june/", "Sat, 30 Jun 2018 11:44:21 +0000");
            AddLink("Celebrimbor's Secret", "https://visionofthepalantir.com/2018/06/30/celebrimbors-secret/", "Sat, 30 Jun 2018 10:45:32 +0000")
                .WithLabels(Scenario.CelebrimborsSecret);
            AddLink("Monthly Poll: June 2018", "https://visionofthepalantir.com/2018/06/29/monthly-poll-june-2018/", "Fri, 29 Jun 2018 09:30:11 +0000");
            AddLink("A Beginners Guide to The Haradrim Cycle", "https://visionofthepalantir.com/2018/06/26/a-beginners-guide-to-the-haradrim-cycle/", "Tue, 26 Jun 2018 08:24:32 +0000");
            AddLink("The Ring Goes South", "https://visionofthepalantir.com/2018/06/24/the-ring-goes-south/", "Sun, 24 Jun 2018 12:43:13 +0000")
                .WithLabels(Scenario.TheRingGoesSouth);
            AddLink("First Impressions: Wilds of Rhovanion, Quests", "https://visionofthepalantir.com/2018/06/23/first-impressions-wilds-of-rhovanion-quests/", "Sat, 23 Jun 2018 14:14:01 +0000")
                .WithLabels(Scenario.JourneyUpTheAnduin)
                .WithLabels(Scenario.LostInMirkwood)
                .WithLabels(Scenario.TheKingsQuest);
            AddLink("Secrecy", "https://visionofthepalantir.com/2018/06/21/secrecy/", "Thu, 21 Jun 2018 08:04:19 +0000");
            AddLink("A Call to Arms", "https://visionofthepalantir.com/2018/06/19/a-call-to-arms/", "Tue, 19 Jun 2018 12:38:18 +0000");
            AddLink("First Impressions: Wilds of Rhovanion", "https://visionofthepalantir.com/2018/06/14/first-impressions-wilds-of-rhovanion/", "Thu, 14 Jun 2018 13:35:49 +0000")
                .WithLabels(Product.TheWildsOfRhovanion);
            AddLink("Flight to the Ford", "https://visionofthepalantir.com/2018/06/13/flight-to-the-ford/", "Wed, 13 Jun 2018 08:41:25 +0000")
                .WithLabels(Scenario.FlightToTheFord);
            AddLink("Into Fangorn", "https://visionofthepalantir.com/2018/06/11/into-fangorn/", "Mon, 11 Jun 2018 18:30:28 +0000")
                .WithLabels(Scenario.IntoFangorn);
            AddLink("Con of the Rings Announcement", "https://visionofthepalantir.com/2018/06/07/con-of-the-rings-announcement/", "Thu, 07 Jun 2018 01:17:56 +0000");
            AddLink("Trouble in Tharbad", "https://visionofthepalantir.com/2018/06/05/trouble-in-tharbad/", "Tue, 05 Jun 2018 17:39:27 +0000")
                .WithLabels(Scenario.TroubleInTharbad);
            AddLink("Staples: Condition Removal", "https://visionofthepalantir.com/2018/06/02/staples-condition-removal/", "Sat, 02 Jun 2018 09:00:49 +0000");
            AddLink("Month in Review: May 2018", "https://visionofthepalantir.com/2018/05/31/month-in-review-may-2018/", "Thu, 31 May 2018 12:13:14 +0000");
            AddLink("A Knife in the Dark", "https://visionofthepalantir.com/2018/05/30/a-knife-in-the-dark/", "Wed, 30 May 2018 15:14:58 +0000")
                .WithLabels(Scenario.AKnifeInTheDark);
            AddLink("Monthly Poll: May 2018", "https://visionofthepalantir.com/2018/05/28/monthly-poll-may-2018/", "Mon, 28 May 2018 16:01:28 +0000");
            AddLink("A Shadow of the Past", "https://visionofthepalantir.com/2018/05/23/a-shadow-of-the-past/", "Wed, 23 May 2018 07:34:39 +0000")
                .WithLabels(Scenario.AShadowOfThePast);
            AddLink("Staples: Scrying (Encounter Deck)", "https://visionofthepalantir.com/2018/05/21/staples-scrying-encounter-deck/", "Mon, 21 May 2018 14:46:12 +0000");
            AddLink("Staples: Threat Reduction", "https://visionofthepalantir.com/2018/05/20/staples-threat-reduction/", "Sun, 20 May 2018 10:54:31 +0000");
            AddLink("To Catch an Orc", "https://visionofthepalantir.com/2018/05/15/to-catch-an-orc/", "Tue, 15 May 2018 16:56:50 +0000")
                .WithLabels(Scenario.ToCatchAnOrc);
            AddLink("The Blood of Gondor", "https://visionofthepalantir.com/2018/05/13/the-blood-of-gondor/", "Sun, 13 May 2018 14:16:07 +0000")
                .WithLabels(Scenario.TheBloodOfGondor);
            AddLink("Fan-made content: Game modes and quests", "https://visionofthepalantir.com/2018/05/11/fan-made-content-game-modes-and-quests/", "Fri, 11 May 2018 11:45:54 +0000");
            AddLink("The Morgul Vale", "https://visionofthepalantir.com/2018/05/07/the-morgul-vale/", "Mon, 07 May 2018 11:48:53 +0000")
                .WithLabels(Scenario.TheMorgulVale);
            AddLink("The Fords of Isen", "https://visionofthepalantir.com/2018/05/03/the-fords-of-isen/", "Thu, 03 May 2018 17:42:44 +0000")
                .WithLabels(Scenario.TheFordsOfIsen);
            AddLink("Wose", "https://visionofthepalantir.com/2018/05/02/wose/", "Wed, 02 May 2018 12:01:39 +0000")
                .WithLabels(ProductRepository.Instance.TraitLabels("Wose.", c => c.IsPlayerCard()));
            AddLink("Patreon", "https://visionofthepalantir.com/2018/05/01/patreon/", "Tue, 01 May 2018 11:57:20 +0000");
            AddLink("Poll-antir Results", "https://visionofthepalantir.com/2018/04/29/poll-antir-results/", "Sun, 29 Apr 2018 12:27:48 +0000");
            AddLink("Month in Review: April 2018", "https://visionofthepalantir.com/2018/04/29/month-in-review-april-2018/", "Sun, 29 Apr 2018 10:32:58 +0000");
            AddLink("The Drúadan Forest", "https://visionofthepalantir.com/2018/04/25/the-druadan-forest/", "Wed, 25 Apr 2018 12:48:40 +0000")
                .WithLabels(Scenario.TheDruadanForest);
            AddLink("Assault on Osgiliath", "https://visionofthepalantir.com/2018/04/20/assault-on-osgiliath/", "Fri, 20 Apr 2018 14:34:55 +0000")
                .WithLabels(Scenario.AssaultOnOsgiliath);
            AddLink("Rohan", "https://visionofthepalantir.com/2018/04/15/rohan/", "Sun, 15 Apr 2018 12:53:44 +0000")
                .WithLabels(ProductRepository.Instance.TraitLabels("Rohan.", c => c.IsPlayerCard()));
            AddLink("LOTR LCG: The Collection", "https://visionofthepalantir.com/2018/04/13/lotr-lcg-the-collection/", "Fri, 13 Apr 2018 11:34:45 +0000");
            AddLink("Encounter at Amon Dîn", "https://visionofthepalantir.com/2018/04/11/encounter-at-amon-din/", "Wed, 11 Apr 2018 15:39:53 +0000")
                .WithLabels(Scenario.EncounterAtAmonDin);
            AddLink("Vision of the Poll-antir", "https://visionofthepalantir.com/2018/04/10/vision-of-the-poll-antir/", "Tue, 10 Apr 2018 15:06:22 +0000");
            AddLink("Blogroll and community resources", "https://visionofthepalantir.com/2018/04/08/blogroll-and-community-resources/", "Sun, 08 Apr 2018 11:08:57 +0000");
            AddLink("Staples: Card Draw", "https://visionofthepalantir.com/2018/04/07/staples-card-draw/", "Sat, 07 Apr 2018 14:25:57 +0000");
            AddLink("The Steward's Fear", "https://visionofthepalantir.com/2018/04/06/the-stewards-fear/", "Fri, 06 Apr 2018 14:08:22 +0000")
                .WithLabels(Scenario.TheStewardsFear);
            AddLink("Archer", "https://visionofthepalantir.com/2018/04/01/archer/", "Sat, 31 Mar 2018 23:01:43 +0000")
                .WithLabels(ProductRepository.Instance.TraitLabels("Archer.", c => c.IsPlayerCard()));
            AddLink("Month in review: March 2018", "https://visionofthepalantir.com/2018/03/29/month-in-review-march-2018/", "Wed, 28 Mar 2018 23:04:59 +0000");
            AddLink("Outlands", "https://visionofthepalantir.com/2018/03/28/outlands/", "Wed, 28 Mar 2018 13:39:58 +0000")
                .WithLabels(ProductRepository.Instance.TraitLabels("Outlands.", c => c.IsPlayerCard()));
            AddLink("We Must Away, Ere Break of Day", "https://visionofthepalantir.com/2018/03/25/we-must-away-ere-break-of-day/", "Sun, 25 Mar 2018 05:00:20 +0000")
                .WithLabels(Scenario.WeMustAwayEreBreakOfDay);
            AddLink("The Siege of Cair Andros", "https://visionofthepalantir.com/2018/03/24/the-siege-of-cair-andros/", "Sat, 24 Mar 2018 14:22:13 +0000")
                .WithLabels(Scenario.TheSiegeOfCairAndros);
            AddLink("Staples: Resource Acceleration", "https://visionofthepalantir.com/2018/03/23/staples-resource-acceleration/", "Fri, 23 Mar 2018 11:10:10 +0000");
            AddLink("Corsair", "https://visionofthepalantir.com/2018/03/20/corsair/", "Tue, 20 Mar 2018 16:12:51 +0000")
                .WithLabels(ProductRepository.Instance.TraitLabels("Corsair.", c => c.IsPlayerCard()));
            AddLink("Into Ithilien", "https://visionofthepalantir.com/2018/03/18/into-ithilien/", "Sun, 18 Mar 2018 14:30:19 +0000")
                .WithLabels(Scenario.IntoIthilien);
            AddLink("Beorning", "https://visionofthepalantir.com/2018/03/16/beorning/", "Fri, 16 Mar 2018 17:34:31 +0000")
                .WithLabels(ProductRepository.Instance.TraitLabels("Beorning.", c => c.IsPlayerCard()));
            AddLink("Peril in Pelargir", "https://visionofthepalantir.com/2018/03/13/peril-in-pelargir/", "Tue, 13 Mar 2018 18:26:56 +0000")
                .WithLabels(Scenario.PerilInPelargir);
            AddLink("Shadow and Flame", "https://visionofthepalantir.com/2018/03/10/shadow-and-flame/", "Sat, 10 Mar 2018 15:08:00 +0000")
                .WithLabels(Scenario.ShadowAndFlame);
            AddLink("Storage Solutions", "https://visionofthepalantir.com/2018/03/09/storage-solutions/", "Fri, 09 Mar 2018 18:15:43 +0000");
            AddLink("Q&A: March 2018", "https://visionofthepalantir.com/2018/03/09/qa-march-2018/", "Fri, 09 Mar 2018 09:26:04 +0000");
            AddLink("Istari", "https://visionofthepalantir.com/2018/03/05/istari/", "Mon, 05 Mar 2018 17:12:23 +0000")
                .WithLabels(ProductRepository.Instance.TraitLabels("Istari.", c => c.IsPlayerCard()));
            AddLink("Foundations of Stone", "https://visionofthepalantir.com/2018/03/04/foundations-of-stone/", "Sun, 04 Mar 2018 09:51:08 +0000")
                .WithLabels(Scenario.FoundationsOfStone);
            AddLink("The Watcher in the Water", "https://visionofthepalantir.com/2018/03/02/the-watcher-in-the-water/", "Fri, 02 Mar 2018 13:27:00 +0000")
                .WithLabels(Scenario.TheWatcherInTheWater);
            AddLink("Craftsmen", "https://visionofthepalantir.com/2018/02/28/craftsmen/", "Wed, 28 Feb 2018 18:54:30 +0000")
                .WithLabels(ProductRepository.Instance.TraitLabels("Craftsman.", c => c.IsPlayerCard()));
            AddLink("The Long Dark", "https://visionofthepalantir.com/2018/02/28/the-long-dark/", "Wed, 28 Feb 2018 14:23:12 +0000")
                .WithLabels(Scenario.TheLongDark);
            AddLink("Month in review and Q&A announcement", "https://visionofthepalantir.com/2018/02/25/month-in-review-and-qa-announcement/", "Sun, 25 Feb 2018 15:09:55 +0000");
            AddLink("Road to Rivendell", "https://visionofthepalantir.com/2018/02/24/road-to-rivendell/", "Sat, 24 Feb 2018 20:27:29 +0000")
                .WithLabels(Scenario.RoadToRivendell);
            AddLink("Silvan", "https://visionofthepalantir.com/2018/02/22/silvan/", "Thu, 22 Feb 2018 15:48:32 +0000")
                .WithLabels(ProductRepository.Instance.TraitLabels("Silvan.", c => c.IsPlayerCard()));
            AddLink("The Redhorn Gate", "https://visionofthepalantir.com/2018/02/18/the-redhorn-gate/", "Sun, 18 Feb 2018 16:51:53 +0000")
                .WithLabels(Scenario.TheRedhornGate);
            AddLink("Flight from Moria", "https://visionofthepalantir.com/2018/02/16/flight-from-moria/", "Fri, 16 Feb 2018 09:16:21 +0000")
                .WithLabels(Scenario.FlightFromMoria);
            AddLink("Ents", "https://visionofthepalantir.com/2018/02/12/ents/", "Mon, 12 Feb 2018 00:30:40 +0000")
                .WithLabels(ProductRepository.Instance.TraitLabels("Ent.", c => c.IsPlayerCard()));
            AddLink("The Seventh Level", "https://visionofthepalantir.com/2018/02/10/the-seventh-level/", "Sat, 10 Feb 2018 15:52:54 +0000")
                .WithLabels(Scenario.TheSeventhLevel);
            AddLink("Bree", "https://visionofthepalantir.com/2018/02/08/bree/", "Thu, 08 Feb 2018 09:00:36 +0000")
                .WithLabels(ProductRepository.Instance.TraitLabels("Bree.", c => c.IsPlayerCard()));
            AddLink("Into the Pit", "https://visionofthepalantir.com/2018/02/07/into-the-pit/", "Wed, 07 Feb 2018 12:20:02 +0000")
                .WithLabels(Scenario.IntoThePit);
            AddLink("Return to Mirkwood", "https://visionofthepalantir.com/2018/02/04/return-to-mirkwood/", "Sun, 04 Feb 2018 13:34:48 +0000")
                .WithLabels(Scenario.ReturnToMirkwood);
            AddLink("The Dead Marshes", "https://visionofthepalantir.com/2018/02/02/the-dead-marshes/", "Fri, 02 Feb 2018 22:19:14 +0000")
                .WithLabels(Scenario.TheDeadMarshes);
            AddLink("Minstrel", "https://visionofthepalantir.com/2018/02/01/minstrel/", "Thu, 01 Feb 2018 12:16:17 +0000")
                .WithLabels(ProductRepository.Instance.TraitLabels("Minstrel.", c => c.IsPlayerCard()));
            AddLink("Update January", "https://visionofthepalantir.com/2018/01/31/update-february/", "Wed, 31 Jan 2018 17:40:33 +0000");
            AddLink("A Journey to Rhosgobel", "https://visionofthepalantir.com/2018/01/31/a-journey-to-rhosgobel/", "Wed, 31 Jan 2018 14:41:15 +0000")
                .WithLabels(Scenario.AJourneyToRhosgobel);
            AddLink("The Hills of Emyn Muil", "https://visionofthepalantir.com/2018/01/28/the-hills-of-emyn-muil/", "Sun, 28 Jan 2018 12:00:35 +0000")
                .WithLabels(Scenario.TheHillsOfEmynMuil);
            AddLink("Hobbits", "https://visionofthepalantir.com/2018/01/25/hobbits/", "Thu, 25 Jan 2018 15:50:05 +0000")
                .WithLabels(ProductRepository.Instance.TraitLabels("Hobbit.", c => c.IsPlayerCard()));
            AddLink("Conflict at the Carrock", "https://visionofthepalantir.com/2018/01/25/conflict-at-the-carrock/", "Thu, 25 Jan 2018 04:44:49 +0000")
                .WithLabels(Scenario.ConflictAtTheCarrock);
            AddLink("The Eagles", "https://visionofthepalantir.com/2018/01/24/the-eagles/", "Wed, 24 Jan 2018 14:04:07 +0000")
                .WithLabels(ProductRepository.Instance.TraitLabels("Eagle.", c => c.IsPlayerCard()));
            AddLink("The Hunt for Gollum", "https://visionofthepalantir.com/2018/01/24/the-hunt-for-gollum/", "Wed, 24 Jan 2018 12:10:54 +0000")
                .WithLabels(Scenario.TheHuntForGollum);
            AddLink("Noldor", "https://visionofthepalantir.com/2018/01/22/noldor/", "Mon, 22 Jan 2018 13:59:34 +0000")
                .WithLabels(ProductRepository.Instance.TraitLabels("Noldor.", c => c.IsPlayerCard()));
            AddLink("Escape from Dol Guldur", "https://visionofthepalantir.com/2018/01/21/escape-from-dol-guldur/", "Sun, 21 Jan 2018 15:42:58 +0000")
                .WithLabels(Scenario.EscapeFromDolGuldur);
            AddLink("Welcome", "https://visionofthepalantir.com/2018/01/21/welcome/", "Sun, 21 Jan 2018 11:56:01 +0000");
            AddLink("Dwarves", "https://visionofthepalantir.com/2018/01/20/dwarves/", "Sat, 20 Jan 2018 19:38:09 +0000")
                .WithLabels(ProductRepository.Instance.TraitLabels("Dwarf.", c => c.IsPlayerCard()));
            AddLink("Journey Along the Anduin", "https://visionofthepalantir.com/2018/01/20/journey-along-the-anduin/", "Sat, 20 Jan 2018 16:14:37 +0000")
                .WithLabels(Scenario.JourneyAlongTheAnduin);
            AddLink("Passage through Mirkwood", "https://visionofthepalantir.com/2018/01/20/ptm/", "Sat, 20 Jan 2018 10:11:53 +0000")
                .WithLabels(Scenario.PassageThroughMirkwood);
        }
    }
}