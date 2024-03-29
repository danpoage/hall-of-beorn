﻿using System;
using System.Collections.Generic;
using System.Linq;

using HallOfBeorn.Models;
using HallOfBeorn.Models.LotR;
using HallOfBeorn.Models.LotR.Community.VisionOfThePalantir;

using HallOfBeorn.Services.LotR.Community;

namespace HallOfBeorn.Services.LotR.Links
{
    public class LinkService
        : ILinkService
    {
        public LinkService(ICardRepository<LotRCard> cardRepository,
            ICreatorService creatorService)
        {
            this.cardRepository = cardRepository;
            this.creatorService = creatorService;
            Initialize();
            InitializeCharacterLinks();
        }

        private readonly ICardRepository<LotRCard> cardRepository;
        private readonly ICreatorService creatorService;

        private readonly Dictionary<string, List<ILink>> linksBySlug
            = new Dictionary<string, List<ILink>>();

        private readonly Dictionary<string, string> twoPlayerStarterMap
            = new Dictionary<string, string> {
            { "Andrath-Guardsman-TPLES", "Andrath-Guardsman-TMk" },
            { "Aragorn-TPLES", "Aragorn-Core"},
            { "Arwen-Undomiel-TPLES", "Arwen-Undomiel-TWitW"},
            { "Bifur-TPLES", "Bifur-KD" },
            { "Blue-Mountain-Trader-TPLES", "Blue-Mountain-Trader-TDT" },
            { "Bofur-TPLES", "Bofur-TRG" },
            { "Defender-of-the-Naith-TPLES", "Defender-of-the-Naith-TiT" },
            { "Faramir-TPLES", "Faramir-Core" },
            { "Fili-TPLES", "Fili-THOHaUH" },
            { "Galadriel-TPLES", "Galadriel-RD" },
            { "Gandalf-TPLES", "Gandalf-Core" },
            { "Gildor-Inglorion-TPLES", "Gildor-Inglorion-UtAM" },
            { "Gimli-TPLES", "Gimli-ToS" },
            { "Glorfindel-TPLES", "Glorfindel-Core" },
            { "Kili-TPLES", "Kili-THOHaUH" },
            { "Naith-Guide-TPLES", "Naith-Guide-TDT" },
            { "Nori-TPLES", "Nori-THOHaUH" },
            { "Orophin-TPLES", "Orophin-CS" },
            { "Silverlode-Archer-TPLES", "Silverlode-Archer-Core" },
            { "Thorin-Stonehelm-TPLES", "Thorin-Stonehelm-WaR" },
            { "Woodland-Courier-TPLES", "Woodland-Courier-TDR" },
        };

        private void Initialize()
        {
            //Vision of the Palantir
            AddVisionOfThePalantirHuntForGollum("Bilbo-Baggins-THfG", "BilboBaggins");
            AddVisionOfThePalantirHuntForGollum("Campfire-Tales-THfG", "CampfireTales");
            AddVisionOfThePalantirHuntForGollum("Dunedain-Mark-THfG", "D%C3%BAnedainMark");
            AddVisionOfThePalantirHuntForGollum("Mustering-the-Rohirrim-THfG", "MusteringtheRohirrim");
            AddVisionOfThePalantirHuntForGollum("Rivendell-Minstrel-THfG", "RivendellMinstrel");
            AddVisionOfThePalantirHuntForGollum("Song-of-Kings-THfG", "SongofKings");
            AddVisionOfThePalantirHuntForGollum("Strider's-Path-THfG", "Strider'sPath");
            AddVisionOfThePalantirHuntForGollum("The-Eagles-Are-Coming-THfG", "TheEaglesAreComing!");
            AddVisionOfThePalantirHuntForGollum("Westfold-Horse-Breaker-THfG", "WestfoldHorse-Breaker");
            AddVisionOfThePalantirHuntForGollum("Winged-Guardian-THfG", "WingedGuardian");

            AddVisionOfThePalantirConflictAtTheCarrock("Frodo-Baggins-CatC", "FrodoBaggins");
            AddVisionOfThePalantirConflictAtTheCarrock("Dunedain-Warning-CatC", "D%C3%BAnedainWarning");
            AddVisionOfThePalantirConflictAtTheCarrock("Second-Breakfast-CatC", "SecondBreakfast");
            AddVisionOfThePalantirConflictAtTheCarrock("Beorning-Beekeeper-CatC", "BeorningBeekeeper");
            AddVisionOfThePalantirConflictAtTheCarrock("Born-Aloft-CatC", "BornAloft");
            AddVisionOfThePalantirConflictAtTheCarrock("Eomund-CatC", "%C3%89omund");
            AddVisionOfThePalantirConflictAtTheCarrock("Nor-Am-I-A-Stranger-CatC", "NoramIaStranger");
            AddVisionOfThePalantirConflictAtTheCarrock("Longbeard-Map-Maker-CatC", "LongbeardMap-Maker");
            AddVisionOfThePalantirConflictAtTheCarrock("A-Burning-Brand-CatC", "ABurningBrand");
            AddVisionOfThePalantirConflictAtTheCarrock("Song-of-Wisdom", "SongofWisdom");

            //TODO: Generalize this with a lamda
            AddLink("Bard-son-of-Brand-TWoR", LinkType.Vision_of_the_Palantir, "https://visionofthepalantir.com/2019/09/16/guarded-cards/", "Guarded Cards");
            AddLink("Beregond-TFotW", LinkType.Vision_of_the_Palantir, "https://visionofthepalantir.com/2019/09/16/guarded-cards/", "Guarded Cards");
            AddLink("Celebrian's-Stone-Core", LinkType.Vision_of_the_Palantir, "https://visionofthepalantir.com/2019/09/16/guarded-cards/", "Guarded Cards");
            AddLink("Frodo-Baggins-CatC", LinkType.Vision_of_the_Palantir, "https://visionofthepalantir.com/2019/09/16/guarded-cards/", "Guarded Cards");
            AddLink("Gandalf-RD", LinkType.Vision_of_the_Palantir, "https://visionofthepalantir.com/2019/09/16/guarded-cards/", "Guarded Cards");
            AddLink("Glamdring-RAR", LinkType.Vision_of_the_Palantir, "https://visionofthepalantir.com/2019/09/16/guarded-cards/", "Guarded Cards");
            AddLink("Golden-Shield-TFoW", LinkType.Vision_of_the_Palantir, "https://visionofthepalantir.com/2019/09/16/guarded-cards/", "Guarded Cards");
            AddLink("Hands-Upon-the-Bow-SAF", LinkType.Vision_of_the_Palantir, "https://visionofthepalantir.com/2019/09/16/guarded-cards/", "Guarded Cards");
            AddLink("Herugrim-ToS", LinkType.Vision_of_the_Palantir, "https://visionofthepalantir.com/2019/09/16/guarded-cards/", "Guarded Cards");
            AddLink("Mithril-Shirt-TFoW", LinkType.Vision_of_the_Palantir, "https://visionofthepalantir.com/2019/09/16/guarded-cards/", "Guarded Cards");
            AddLink("Necklace-of-Girion-TWoR", LinkType.Vision_of_the_Palantir, "https://visionofthepalantir.com/2019/09/16/guarded-cards/", "Guarded Cards");
            AddLink("Raven-winged-Helm-TWoE", LinkType.Vision_of_the_Palantir, "https://visionofthepalantir.com/2019/09/16/guarded-cards/", "Guarded Cards");
            AddLink("Resourceful-TWitW", LinkType.Vision_of_the_Palantir, "https://visionofthepalantir.com/2019/09/16/guarded-cards/", "Guarded Cards");
            AddLink("Ring-of-Barahir-TSF", LinkType.Vision_of_the_Palantir, "https://visionofthepalantir.com/2019/09/16/guarded-cards/", "Guarded Cards");
            AddLink("Ring-of-Thror-TGoF", LinkType.Vision_of_the_Palantir, "https://visionofthepalantir.com/2019/09/16/guarded-cards/", "Guarded Cards");
            AddLink("Rosie-Cotton-TMoF", LinkType.Vision_of_the_Palantir, "https://visionofthepalantir.com/2019/09/16/guarded-cards/", "Guarded Cards");
            AddLink("Sting-MG", LinkType.Vision_of_the_Palantir, "https://visionofthepalantir.com/2019/09/16/guarded-cards/", "Guarded Cards");
            AddLink("Sword-thain-TDR", LinkType.Vision_of_the_Palantir, "https://visionofthepalantir.com/2019/09/16/guarded-cards/", "Guarded Cards");
            AddLink("The-King's-Return-TFoW", LinkType.Vision_of_the_Palantir, "https://visionofthepalantir.com/2019/09/16/guarded-cards/", "Guarded Cards");
            AddLink("Tom-Cotton-TMoF", LinkType.Vision_of_the_Palantir, "https://visionofthepalantir.com/2019/09/16/guarded-cards/", "Guarded Cards");
            AddLink("Well-Equipped-TBoG", LinkType.Vision_of_the_Palantir, "https://visionofthepalantir.com/2019/09/16/guarded-cards/", "Guarded Cards");
            AddLink("West-Road-Traveller-RTM", LinkType.Vision_of_the_Palantir, "https://visionofthepalantir.com/2019/09/16/guarded-cards/", "Guarded Cards");

            //The Book of Elessar
            AddTheBookOfElessarHuntForGollum("Aragorn-XLore");
            AddTheBookOfElessarHuntForGollum("Arwen-Undomiel-TDR");
            AddTheBookOfElessarHuntForGollum("Glorfindel-FoS");
            AddTheBookOfElessarHuntForGollum("Dunedain-Pathfinder-RAH");
            AddTheBookOfElessarHuntForGollum("Galadriel's-Handmaiden-CS");
            AddTheBookOfElessarHuntForGollum("Gandalf-Core");
            AddTheBookOfElessarHuntForGollum("Henamarth-Riversong-Core");
            AddTheBookOfElessarHuntForGollum("Mablung-TLoS");
            AddTheBookOfElessarHuntForGollum("Northern-Tracker-Core");
            AddTheBookOfElessarHuntForGollum("Quickbeam-ToS");
            AddTheBookOfElessarHuntForGollum("Silvan-Refugeee-TDF");
            AddTheBookOfElessarHuntForGollum("Treebeard-TAC");
            AddTheBookOfElessarHuntForGollum("A-Burning-Brand-CatC");
            AddTheBookOfElessarHuntForGollum("Lembas-TiT");
            AddTheBookOfElessarHuntForGollum("Light-of-Valinor-FoS");
            AddTheBookOfElessarHuntForGollum("Protector-of-Lorien-Core");
            AddTheBookOfElessarHuntForGollum("Unexpected-Courge-Core");
            AddTheBookOfElessarHuntForGollum("A-Test-of-Will-Core");
            AddTheBookOfElessarHuntForGollum("Dearon's-Runes-FoS");
            AddTheBookOfElessarHuntForGollum("Elrond's-Counsel-TWiT");
            AddTheBookOfElessarHuntForGollum("Elven-light-TDR");

            AddTheBookOfElessarConflictAtTheCarrock("Aragorn-XTactics");
            AddTheBookOfElessarConflictAtTheCarrock("Arwen-Undomiel-TDR");
            AddTheBookOfElessarConflictAtTheCarrock("Glorfindel-FoS");
            AddTheBookOfElessarConflictAtTheCarrock("Dunedain-Hunter-XTactics");
            AddTheBookOfElessarConflictAtTheCarrock("Dunedain-Pathfinder-XSpirit");
            AddTheBookOfElessarConflictAtTheCarrock("Galadriel's-Handmaiden-XSpirit");
            AddTheBookOfElessarConflictAtTheCarrock("Gandalf-Core");
            AddTheBookOfElessarConflictAtTheCarrock("Legolas-XTacticsAlly");
            AddTheBookOfElessarConflictAtTheCarrock("Treebeard-XNeutral");
            AddTheBookOfElessarConflictAtTheCarrock("A-Burning-Brand-CatC");
            AddTheBookOfElessarConflictAtTheCarrock("Ancient-Mathom-XSpirit");
            AddTheBookOfElessarConflictAtTheCarrock("Dagger-of-Westernesse-XTactics");
            AddTheBookOfElessarConflictAtTheCarrock("Ring-of-Barahir-XSpirit");
            AddTheBookOfElessarConflictAtTheCarrock("Rivendell-Blade-XTactics");
            AddTheBookOfElessarConflictAtTheCarrock("Unexpected-Courage-Core");
            AddTheBookOfElessarConflictAtTheCarrock("A-Test-of-Will-Core");
            AddTheBookOfElessarConflictAtTheCarrock("Elrond's-Counsel-XSpirit");
            AddTheBookOfElessarConflictAtTheCarrock("Elven-light-XSpirit");
            AddTheBookOfElessarConflictAtTheCarrock("Feint-Core");
            AddTheBookOfElessarConflictAtTheCarrock("Power-of-Orthanc-XSpirit");
            AddTheBookOfElessarConflictAtTheCarrock("Double-Back");
            AddTheBookOfElessarConflictAtTheCarrock("Gather-Information");

            AddTheBookOfElessarAJourneyToRhosgobel("Aragorn-XLore");
            AddTheBookOfElessarAJourneyToRhosgobel("Arwen-Undomiel-TDR");
            AddTheBookOfElessarAJourneyToRhosgobel("Legolas-TSoH");
            AddTheBookOfElessarAJourneyToRhosgobel("Dunedain-Pathfinder-XSpirit");
            AddTheBookOfElessarAJourneyToRhosgobel("Galadriel's-Handmaiden-XSpirit");
            AddTheBookOfElessarAJourneyToRhosgobel("Haldir-of-Lórien-XLoreAlly");
            AddTheBookOfElessarAJourneyToRhosgobel("Radagast-XNeutralAlly");
            AddTheBookOfElessarAJourneyToRhosgobel("Warden-of-Healing-XLore");
            AddTheBookOfElessarAJourneyToRhosgobel("A-Burning-Brand-XLore");
            AddTheBookOfElessarAJourneyToRhosgobel("Healing-Herbs-XLore");
            AddTheBookOfElessarAJourneyToRhosgobel("Light-of-Valinor-FoS");
            AddTheBookOfElessarAJourneyToRhosgobel("Mirkwood-Long-knife-TSoH");
            AddTheBookOfElessarAJourneyToRhosgobel("Unexpected-Courage-Core");
            AddTheBookOfElessarAJourneyToRhosgobel("A-Test-of-Will-Core");
            AddTheBookOfElessarAJourneyToRhosgobel("Daeron's-Runes-FoS");
            AddTheBookOfElessarAJourneyToRhosgobel("Distant-Stars-XLore");
            AddTheBookOfElessarAJourneyToRhosgobel("Elrond's-Counsel-XSpirit");
            AddTheBookOfElessarAJourneyToRhosgobel("Elven-light-XSpirit");
            AddTheBookOfElessarAJourneyToRhosgobel("Lore-of-Imladris-Core");
            AddTheBookOfElessarAJourneyToRhosgobel("Lorien's-Wealth-Core");
            AddTheBookOfElessarAJourneyToRhosgobel("Double-Back");

            AddTheBookOfElessarTheHillsOfEmynMuil("Aragorn-TWitW");
            AddTheBookOfElessarTheHillsOfEmynMuil("Idrean");
            AddTheBookOfElessarTheHillsOfEmynMuil("Thurindir");
            AddTheBookOfElessarTheHillsOfEmynMuil("Arwen-Undomiel-TWitW");
            AddTheBookOfElessarTheHillsOfEmynMuil("Dunedain-Lookout-XLore");
            AddTheBookOfElessarTheHillsOfEmynMuil("Dunedain-Pathfinder-XSpirit");
            AddTheBookOfElessarTheHillsOfEmynMuil("East-Road-Ranger-XLore");
            AddTheBookOfElessarTheHillsOfEmynMuil("Northern-Tracker-Core");
            AddTheBookOfElessarTheHillsOfEmynMuil("Warden-of-Healing-XLore");
            AddTheBookOfElessarTheHillsOfEmynMuil("A-Burning-Brand-XLore");
            AddTheBookOfElessarTheHillsOfEmynMuil("Ancient-Mathom-XSpirit");
            AddTheBookOfElessarTheHillsOfEmynMuil("Dunedain-Pipe-XLore");
            AddTheBookOfElessarTheHillsOfEmynMuil("Elf-stone-XLore");
            AddTheBookOfElessarTheHillsOfEmynMuil("Unexpected-Courage-Core");
            AddTheBookOfElessarTheHillsOfEmynMuil("Warden-of-Arnor-XSpirit");
            AddTheBookOfElessarTheHillsOfEmynMuil("A-Test-of-Will-Core");
            AddTheBookOfElessarTheHillsOfEmynMuil("Backtrack-XSpirit");
            AddTheBookOfElessarTheHillsOfEmynMuil("Daeron's-Runes-FoS");
            AddTheBookOfElessarTheHillsOfEmynMuil("Secret-Paths-Core");
            AddTheBookOfElessarTheHillsOfEmynMuil("Strider's-Path-XLore");
            AddTheBookOfElessarTheHillsOfEmynMuil("Double-Back");
            AddTheBookOfElessarTheHillsOfEmynMuil("Gather-Information");
            AddTheBookOfElessarTheHillsOfEmynMuil("Scout-Ahead");

            AddTheBookOfElessarTheDeadMarshes("Aragorn-Core");
            AddTheBookOfElessarTheDeadMarshes("Arwen-Undomiel-TDR");
            AddTheBookOfElessarTheDeadMarshes("Beravor-Core");
            AddTheBookOfElessarTheDeadMarshes("Dunedain-Pathfinder-XSpirit");
            AddTheBookOfElessarTheDeadMarshes("Galadhrim-Minstrel-XLore");
            AddTheBookOfElessarTheDeadMarshes("Galadriel's-Handmaiden-XSpirit");
            AddTheBookOfElessarTheDeadMarshes("Gandalf-Core");
            AddTheBookOfElessarTheDeadMarshes("Henamarth-Riversong-Core");
            AddTheBookOfElessarTheDeadMarshes("Celebrian's-Stone-Core");
            AddTheBookOfElessarTheDeadMarshes("Dunedain-Pipe-XLore");
            AddTheBookOfElessarTheDeadMarshes("Dunedain-Warning-XLeadership");
            AddTheBookOfElessarTheDeadMarshes("Light-of-Valinor-FoS");
            AddTheBookOfElessarTheDeadMarshes("Ring-of-Barahir-XSpirit");
            AddTheBookOfElessarTheDeadMarshes("Sword-that-was-Broken-Leadership");
            AddTheBookOfElessarTheDeadMarshes("Unexpected-Courage-Core");
            AddTheBookOfElessarTheDeadMarshes("A-Test-of-Will-Core");
            AddTheBookOfElessarTheDeadMarshes("Daeron's-Runes-FoS");
            AddTheBookOfElessarTheDeadMarshes("Elrond's-Counsel-XSpirit");
            AddTheBookOfElessarTheDeadMarshes("Elven-light-XSpirit");
            AddTheBookOfElessarTheDeadMarshes("Sneak-Attack-Core");
            AddTheBookOfElessarTheDeadMarshes("Tale-of-Tinuviel-XSpirit");

            AddTheBookOfElessarTheReturnToMirkwood("Aragorn-TWitW");
            AddTheBookOfElessarTheReturnToMirkwood("Arwen-Undomiel-TDR");
            AddTheBookOfElessarTheReturnToMirkwood("Glorfindel-FoS");
            AddTheBookOfElessarTheReturnToMirkwood("Dunedain-Pathfinder-XSpirit");
            AddTheBookOfElessarTheReturnToMirkwood("Galadriel's-Handmaiden");
            AddTheBookOfElessarTheReturnToMirkwood("Gandalf-Core");
            AddTheBookOfElessarTheReturnToMirkwood("Henamarth-Riversong-Core");
            AddTheBookOfElessarTheReturnToMirkwood("Silvan-Refugee-XSpirit");
            AddTheBookOfElessarTheReturnToMirkwood("Woodland-Courier-XSpirit");
            AddTheBookOfElessarTheReturnToMirkwood("Asfaloth-FoS");
            AddTheBookOfElessarTheReturnToMirkwood("Dunedain-Pipe-XLore");
            AddTheBookOfElessarTheReturnToMirkwood("Forest-Snare-Core");
            AddTheBookOfElessarTheReturnToMirkwood("Lembas-XLore");
            AddTheBookOfElessarTheReturnToMirkwood("Light-of-Valinor-FoS");
            AddTheBookOfElessarTheReturnToMirkwood("Ranger-Bow-XLore");
            AddTheBookOfElessarTheReturnToMirkwood("Unexpected-Courage-Core");
            AddTheBookOfElessarTheReturnToMirkwood("A-Test-of-Will-Core");
            AddTheBookOfElessarTheReturnToMirkwood("Daeron's-Runes-FoS");
            AddTheBookOfElessarTheReturnToMirkwood("Elrond's-Counsel-XSpirit");
            AddTheBookOfElessarTheReturnToMirkwood("Elven-light-XSpirit");
            AddTheBookOfElessarTheReturnToMirkwood("Out-of-the-Wild-XLore");
            AddTheBookOfElessarTheReturnToMirkwood("Risk-Some-Light-XLore");
            AddTheBookOfElessarTheReturnToMirkwood("Scout-Ahead-XLore");
        }

        private void AddLink(string slug, Link link)
        {
            var normalizedSlug = GetNormalizedSlug(slug);

            if (!linksBySlug.ContainsKey(normalizedSlug))
            {
                linksBySlug[normalizedSlug] = new List<ILink>();
            }

            linksBySlug[normalizedSlug].Add(link);
        }

        private void AddLink(string slug, LinkType linkType, string url, string title)
        {
            AddLink(slug, new Link(linkType, url, title));
        }

        private void AddTheBookOfElessarHuntForGollum(string slug)
        {
            AddLink(slug, new Link(LinkType.The_Book_of_Elessar,
                "https://bookofelessar.com/decks/shadows-of-mirkwood-decks/the-hunt-for-gollum/",
                "Hunt for Gollum"));
        }

        private void AddTheBookOfElessarConflictAtTheCarrock(string slug)
        {
            AddLink(slug, new Link(LinkType.The_Book_of_Elessar, 
                "https://bookofelessar.com/decks/shadows-of-mirkwood-decks/conflict-at-the-carrock/",
                "Conflict at the Carrock"));
        }

        private void AddTheBookOfElessarAJourneyToRhosgobel(string slug)
        {
            AddLink(slug, new Link(LinkType.The_Book_of_Elessar,
                "https://bookofelessar.com/decks/shadows-of-mirkwood-decks/a-journey-to-rhosgobel/",
                "A Journey to Rhosgobel"));
        }

        private void AddTheBookOfElessarTheHillsOfEmynMuil(string slug)
        {
            AddLink(slug, new Link(LinkType.The_Book_of_Elessar,
                "https://bookofelessar.com/decks/shadows-of-mirkwood-decks/the-hills-of-emyn-muil/",
                "The Hills of Emyn Muil"));
        }

        private void AddTheBookOfElessarTheDeadMarshes(string slug)
        {
            AddLink(slug, new Link(LinkType.The_Book_of_Elessar,
                "https://bookofelessar.com/decks/shadows-of-mirkwood-decks/the-dead-marshes/",
                "The Dead Marshes"));
        }

        private void AddTheBookOfElessarTheReturnToMirkwood(string slug)
        {
            AddLink(slug, new Link(LinkType.The_Book_of_Elessar,
                "https://bookofelessar.com/decks/shadows-of-mirkwood-decks/return-to-mirkwood/",
                "The Return to Mirkwood"));
        }

        private void AddVisionOfThePalantirHuntForGollum(string slug, string cardName)
        {
            AddLink(slug, PlayerCardAnalysisLink.TheHuntForGollum(cardName));
        }

        private void AddVisionOfThePalantirConflictAtTheCarrock(string slug, string cardName)
        {
            AddLink(slug, PlayerCardAnalysisLink.ConflictAtTheCarrock(cardName));
        }

        private void AddVisionOfThePalantirAJourneyToRhosgobel(string slug, string cardName)
        {
            AddLink(slug, PlayerCardAnalysisLink.AJourneyToRhosgobel(cardName));
        }

        private void AddVisionOfThePalantirTheHillsOfEmynMuil(string slug, string cardName)
        {
            AddLink(slug, PlayerCardAnalysisLink.TheHillsOfEmynMuil(cardName));
        }

        private void AddVisionOfThePalantirTheDeadMarshes(string slug, string cardName)
        {
            AddLink(slug, PlayerCardAnalysisLink.TheDeadMarshes(cardName));
        }

        private void AddVisionOfThePalantirReturnToMirkwood(string slug, string cardName)
        {
            AddLink(slug, PlayerCardAnalysisLink.ReturnToMirkwood(cardName));
        }

        private string GetNormalizedSlug(string slug)
        {
            var card = cardRepository.FindBySlug(slug);
            return card != null
                ? card.Slug
                : string.Empty;
        }

        public IEnumerable<ILink> Links()
        {
            var map = new Dictionary<string, ILink>();

            foreach (var links in linksBySlug.Values)
            {
                foreach (var link in links)
                {
                    if (!map.ContainsKey(link.Url))
                    {
                        map[link.Url] = link;
                    }
                }
            }

            foreach (var creator in creatorService.Creators())
            {
                foreach (var link in creator.Links()
                    .Where(link => link.Labels().Any()))
                {
                    if (!map.ContainsKey(link.Url))
                    {
                        map[link.Url] = link;
                    }
                }
            }

            return map.Values;
        }

        public IEnumerable<ILink> GetLinks(string slug)
        {
            var links = new List<ILink>();

            if (string.IsNullOrWhiteSpace(slug))
            {
                return links;
            }

            foreach (var creator in creatorService.Creators())
            {
                links.AddRange(creator.GetLinks(slug));
            }

            //Map the Two Player Limited Edition Starter versions of cards to their original release.
            //We can share associations with original cards, as few players include the TPLES versions.
            if (slug.EndsWith("-TPLES"))
            {
                if (twoPlayerStarterMap.ContainsKey(slug))
                {
                    slug = twoPlayerStarterMap[slug];
                }
                else
                {
                    var card = cardRepository.FindBySlug(slug);
                    if (card != null)
                    {
                        var sphere = card.Sphere.ToEnumDisplayString();
                        var suffix = "-X" + sphere;
                        slug = slug.Replace("-TPLES", suffix);
                    }
                }
            }

            var normalizedSlug = GetNormalizedSlug(slug);
            
            if (linksBySlug.ContainsKey(normalizedSlug))
            {
                links.AddRange(linksBySlug[normalizedSlug]);
            }

            return links;
        }

        public IEnumerable<ILink> GetLinks(LinkType type, IEnumerable<string> labels)
        {
            var creator = creatorService.GetCreator(type);
            var links = creator != null ? creator.Links() : Enumerable.Empty<ILink>();
            return links.Where(link => labels.Any(label => link.HasLabel(label)));
        }

        private readonly Dictionary<string, Func<IEnumerable<LotRCard>>> getCardsByName
            = new Dictionary<string, Func<IEnumerable<LotRCard>>>();

        private void AddCharacterFilter(
            string name, Func<LotRCard, bool> predicate)
        {
            getCardsByName[name] = () => cardRepository.Cards()
                .Where(card => predicate(card));
        }

        private IEnumerable<ILink> GetCharacterLinks(IEnumerable<LotRCard> cards)
        {
            return cards
                .Where(card => card != null)
                .Select(card => Link.CreateLotRImageLink(card));
        }

        private bool CharacterLinksToCard(IEnumerable<LotRCard> cards, string slug)
        {
            return cards
                .Where(card => card != null && card.Slug == slug)
                .Any();
        }

        private IEnumerable<LotRCard> GetCards(Func<IEnumerable<LotRCard>> generator)
        {
            return generator()
                .Where(card => !card.CardSet.SetType.IsCommunity())
                .OrderByDescending(card => card.ImportanceScore())
                .ThenBy(card => card.Title)
                .ThenBy(card => card.Sphere);
        }

        private IEnumerable<LotRCard> GetCards(string name)
        {
            return cardRepository.Cards()
                .Where(card => card.Title.ContainsLower(name)
                    && !card.CardSet.SetType.IsCommunity())
                .OrderByDescending(card => card.ImportanceScore())
                .ThenBy(card => card.Title)
                .ThenBy(card => card.Sphere);
        }

        private HashSet<string> GetCardSlugs(string name)
        {
            var slugs = cardRepository.Cards()
                .Where(card => card.Title.ContainsLower(name)
                    && !card.CardSet.SetType.IsCommunity())
                .Select(card => card.Slug);

            return new HashSet<string>(slugs);
        }

        private Func<LotRCard, bool> GetTitleFilter(string title, params Func<LotRCard, bool>[] aliases)
        {
             var aliasCriteria = (aliases == null || aliases.Length == 0)
                ? new Func<LotRCard, bool>((card) => false)
                : new Func<LotRCard, bool>((card) => aliases.Any(opt => opt(card)));

             return (card) =>
                 ((card.IsPlayerCard() || card.IsObjective() || card.CardType == CardType.Enemy)
                 && (card.Title == title || card.NormalizedTitle == title))
                 || aliasCriteria(card);
        }

        private Func<LotRCard, bool> GetTraitOrTextFilter(string text, params Func<LotRCard, bool>[] options)
        {
            var optionalCriteria = (options == null || options.Length == 0)
                ? new Func<LotRCard, bool>((card) => false)
                : new Func<LotRCard, bool>((card) => options.Any(opt => opt(card)));

            return (card) =>
                ((card.IsPlayerCard() || card.IsObjective() || card.CardType == CardType.Enemy)
                && card.HasTraitOrText(text))
                || optionalCriteria(card);
        }

        private void AddCharacterTitleFilter(string title, params string[] aliases)
        {
            var count = aliases != null ? aliases.Length : 0;
            Func<LotRCard, bool>[] aliasFilters = new Func<LotRCard, bool>[count];

            if (count > 0)
            {
                var index = 0;
                foreach (var alias in aliases)
                {
                    aliasFilters[index] = (card) => card.Title == alias || card.NormalizedTitle == alias;
                    index++;
                }
            }

            AddCharacterFilter(title, GetTitleFilter(title, aliasFilters));
        }

        private void InitializeCharacterLinks()
        {
            AddCharacterTitleFilter("Anborn");

            AddCharacterTitleFilter("Angbor the Fearless");

            AddCharacterTitleFilter("Aragorn", "Strider", "Wingfoot", "Heir of Valandil");

            AddCharacterTitleFilter("Arwen Undomiel", "The Evening Star", "Elven-light");

            AddCharacterTitleFilter("Balin", "Balin's Doom");

            AddCharacterTitleFilter("Beorn", "Beorn's Rage");

            AddCharacterTitleFilter("Celebrian", "Celebrian's Stone");

            AddCharacterTitleFilter("Glamdring", "Foe-hammer");

            AddCharacterFilter("Istari", GetTraitOrTextFilter("Istari", 
                (card) => card.HasText("White Council"), (card) => card.Title.Contains("White Council")));

            AddCharacterFilter("Rangers of Ithilien", (card) =>
                (card.IsPlayerCard() || card.IsObjective())
                && ((card.HasTraits("Gondor", "Ranger")) 
                || card.HasTraitOrText("Trap"))
            );

            AddCharacterFilter("The Beornings", GetTraitOrTextFilter("Beorning"));
            
            AddCharacterFilter("The Eagles", GetTraitOrTextFilter("Eagle"));
            
            AddCharacterFilter("The Ents", GetTraitOrTextFilter("Ent"));

            AddCharacterFilter("The One Ring", GetTitleFilter("The One Ring", 
                (card) => card.Title == "Bilbo's Magic Ring", (card) => card.HasTraits("Master")));
        }

        public IEnumerable<ILink> GetCharacterLinks(string name)
        {
            var cards = getCardsByName.ContainsKey(name)
                ? GetCards(getCardsByName[name])
                : GetCards(name);

            return GetCharacterLinks(cards);
        }

        public bool LinksToCard(string name, string slug)
        {
           var cards = getCardsByName.ContainsKey(name)
                ? GetCards(getCardsByName[name])
                : GetCards(name);

            return CharacterLinksToCard(cards, slug);
        }

        public bool HasCreator(string slug, string title, string creator)
        {
            var type = LinkType.None;
            
            var name = creator.Replace(" ", "_");
            if (!Enum.TryParse<LinkType>(name, out type))
            {
                return false;
            }

            //TODO: Optimize this
            var linksByCreator = GetLinks(type, new List<string> { title });
            if (linksByCreator.Any())
            {
                return true;
            }

            var linksBySlug = GetLinks(slug);
            return linksBySlug.Where(link => link.Type == type).Any();
        }
    }
}
