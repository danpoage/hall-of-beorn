using System;
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
        }

        private readonly ICardRepository<LotRCard> cardRepository;
        private readonly ICreatorService creatorService;

        private readonly Dictionary<string, List<ILink>> linksBySlug
            = new Dictionary<string, List<ILink>>();

        private void Initialize()
        {
            //Card Talk
            AddLink("Andrath-Guardsman-TMk", LinkType.Card_Talk, "https://cardtalk2018.libsyn.com/andrath-guardsman", "Andrath Guardsman");
            AddLink("Aragorn-Core", LinkType.Card_Talk, "https://cardtalk2018.libsyn.com/leadership-aragorn", "Leadership Aragorn");
            AddLink("Aragorn-Core", LinkType.Card_Talk, "https://cardtalk2018.libsyn.com/which-aragorn", "Which Aragorn?");
            AddLink("Aragorn-FotBD", LinkType.Card_Talk, "https://cardtalk2018.libsyn.com/which-aragorn", "Which Aragorn?");
            AddLink("Aragorn-TLR", LinkType.Card_Talk, "https://cardtalk2018.libsyn.com/tactics-aragorn", "Tactics Aragorn");
            AddLink("Aragorn-TLR", LinkType.Card_Talk, "https://cardtalk2018.libsyn.com/which-aragorn", "Which Aragorn?");
            AddLink("Aragorn-TOF", LinkType.Card_Talk, "https://cardtalk2018.libsyn.com/which-aragorn", "Which Aragorn?");
            AddLink("Aragorn-TPLES", LinkType.Card_Talk, "https://cardtalk2018.libsyn.com/which-aragorn", "Which Aragorn?");
            AddLink("Aragorn-TWitW", LinkType.Card_Talk, "https://cardtalk2018.libsyn.com/guest-host-mr-underhill-ryan-kelly", "Guest Host Ryan Kelly");
            AddLink("Aragorn-TWitW", LinkType.Card_Talk, "https://cardtalk2018.libsyn.com/which-aragorn", "Which Aragorn?");
            AddLink("Beorn-THOHaUH", LinkType.Card_Talk, "https://cardtalk2018.libsyn.com/guest-host-beorn-dan-poage", "Guest Host Dan Poage");
            AddLink("Bilbo-Baggins-MG", LinkType.Card_Talk, "https://cardtalk2018.libsyn.com/tactics-hero-bilbo", "Tactics Hero Bilbo");
            AddLink("Bilbo-Baggins-MG", LinkType.Card_Talk, "https://cardtalk2018.libsyn.com/revisiting-tactics-hero-bilbo", "Revisting Tactics Bilbo Baggins");
            AddLink("Bilbo-Baggins-THfG", LinkType.Card_Talk, "https://cardtalk2018.libsyn.com/lore-hero-bilbo", "Lore Hero Bilbo");
            AddLink("Bilbo-Baggins-THOtD", LinkType.Card_Talk, "https://cardtalk2018.libsyn.com/on-the-doorstep-bilbo-baggins", "On the Doorstep Bilbo");
            AddLink("Boots-from-Eredor-KD", LinkType.Card_Talk, "https://cardtalk2018.libsyn.com/boots-from-erebor", "Boots from Erebor");
            AddLink("Boromir-TDM", LinkType.Card_Talk, "https://cardtalk2018.libsyn.com/tactics-hero-boromir", "Tactics Hero Boromir");
            AddLink("Boromir-TSoA", LinkType.Card_Talk, "https://cardtalk2018.libsyn.com/tactics-hero-boromir", "Tactics Hero Boromir");
            AddLink("Brok-Ironfist-Core", LinkType.Card_Talk, "https://cardtalk2018.libsyn.com/brok-ironfist", "Brok Ironfist");
            AddLink("Celeborn-AoDG", LinkType.Card_Talk, "https://cardtalk2018.libsyn.com/celeborn", "Celeborn");
            AddLink("Celeborn-TDT", LinkType.Card_Talk, "https://cardtalk2018.libsyn.com/celeborn", "Celeborn");
            AddLink("Cirdan-the-Shipwright-TGH", LinkType.Card_Talk, "https://cardtalk2018.libsyn.com/guest-host-joseph-forster", "Guest Host Joseph Forster");
            AddLink("Citadel-Plate-Core", LinkType.Card_Talk, "https://cardtalk2018.libsyn.com/citadel-plate", "Citadel Plate");
            AddLink("Denethor-Core", LinkType.Card_Talk, "https://cardtalk2018.libsyn.com/lore-hero-denethor", "Lore Hero Denethor");
            AddLink("Derndingle-Warrior-EfMG", LinkType.Card_Talk, "https://cardtalk2018.libsyn.com/derndingle-warrior", "Derndingle-Warrior");
            AddLink("Dunedain-Mark-THfG", LinkType.Card_Talk, "https://cardtalk2018.libsyn.com/dunedain-mark", "Dúnedain Mark");
            AddLink("Dunhere-Core", LinkType.Card_Talk, "https://cardtalk2018.libsyn.com/dunhere", "Dúnhere");
            AddLink("Elf-stone-TBR", LinkType.Card_Talk, "https://cardtalk2018.libsyn.com/elf-stone", "Elf-stone");
            AddLink("Elrond-SaF", LinkType.Card_Talk, "https://cardtalk2018.libsyn.com/hero-elrond", "Hero Elrond");
            AddLink("Elrond's-Counsel-TWitW", LinkType.Card_Talk, "https://cardtalk2018.libsyn.com/elronds-counsel", "Elrond's Counsel");
            AddLink("Eowyn-Core", LinkType.Card_Talk, "https://cardtalk2018.libsyn.com/spirit-eowyn", "Spirit Éowyn");
            AddLink("Eowyn-TFotW", LinkType.Card_Talk, "https://cardtalk2018.libsyn.com/tactics-eowyn", "Tactics Éowyn");
            AddLink("Erestor-TToR", LinkType.Card_Talk, "https://cardtalk2018.libsyn.com/guest-host-chris-stanford", "Guest Host Chris Stanford");
            AddLink("Escort-from-Edoras-AJtR", LinkType.Card_Talk, "https://cardtalk2018.libsyn.com/escort-from-edoras", "Escort from Edoras");
            AddLink("Faramir-Core", LinkType.Card_Talk, "https://cardtalk2018.libsyn.com/leadership-ally-faramir", "Leadership Ally Faramir");
            AddLink("Fast-Hitch-TDM", LinkType.Card_Talk, "https://cardtalk2018.libsyn.com/fast-hitch", "Fast Hitch");
            AddLink("Fastred-TBS", LinkType.Card_Talk, "https://cardtalk2018.libsyn.com/hero-fastred", "Hero Fastred");
            AddLink("Fatty-Bolger-TBR", LinkType.Card_Talk, "https://cardtalk2018.libsyn.com/guest-host-jon-meek", "Guest Host Jon Meek");
            AddLink("Feigned-Voices-TPLES", LinkType.Card_Talk, "https://cardtalk2018.libsyn.com/feigned-voices", "Feigned Voices");
            AddLink("Feigned-Voices-TTT", LinkType.Card_Talk, "https://cardtalk2018.libsyn.com/feigned-voices", "Feigned Voices");
            AddLink("Fellowship-ASitE", LinkType.Card_Talk, "https://cardtalk2018.libsyn.com/fellowship-contract", "Fellowship Contract");
            AddLink("Friend-of-Friends-TMoF", LinkType.Card_Talk, "https://cardtalk2018.libsyn.com/friend-of-friends", "Friend of Friends");
            AddLink("Frodo-Baggins-ASitE", LinkType.Card_Talk, "https://cardtalk2018.libsyn.com/leadership-hero-frodo", "Leadership Hero Frodo");
            AddLink("Frodo-Baggins-CatC", LinkType.Card_Talk, "https://cardtalk2018.libsyn.com/frodo-baggins", "Spirit Hero Frodo Baggins");
            AddLink("Frodo's-Intuition-TBR", LinkType.Card_Talk, "https://cardtalk2018.libsyn.com/frodos-intuition", "Frodo's Intuition");
            AddLink("Gaffer-Gamgee-MG", LinkType.Card_Talk, "https://cardtalk2018.libsyn.com/gaffer-gamgee", "Gaffer Gamgee");
            AddLink("Galadhon-Archer-NiE", LinkType.Card_Talk, "https://cardtalk2018.libsyn.com/galadhon-archer", "Galadhon Archer");
            AddLink("Galadhrim-Minstrel-TiT", LinkType.Card_Talk, "https://cardtalk2018.libsyn.com/galadhrim-minstrel", "Galadhrim Minstrel");
            AddLink("Galadhrim-Minstrel-TPLES", LinkType.Card_Talk, "https://cardtalk2018.libsyn.com/galadhrim-minstrel", "Galadhrim Minstrel");
            AddLink("Galadhrim-Weaver-TToR", LinkType.Card_Talk, "https://cardtalk2018.libsyn.com/galadhrim-weaver", "Galadhrim Weaver");
            AddLink("Galadriel-CS", LinkType.Card_Talk, "https://cardtalk2018.libsyn.com/guest-host-caleb-grace", "Guest Host Caleb Grace");
            AddLink("Galion-FitN", LinkType.Card_Talk, "https://cardtalk2018.libsyn.com/galion", "Galion");
            AddLink("Gandalf-Core", LinkType.Card_Talk, "https://cardtalk2018.libsyn.com/core-gandalf", "Core Gandalf");
            AddLink("Gandalf-RD", LinkType.Card_Talk, "https://cardtalk2018.libsyn.com/hero-gandalf", "Hero Gandalf");
            AddLink("Gimli-Core", LinkType.Card_Talk, "https://cardtalk2018.libsyn.com/tactics-hero-gimli", "Tatics Hero Gimli");
            AddLink("Gloin-Core", LinkType.Card_Talk, "https://cardtalk2018.libsyn.com/hero-gloin", "Hero Glóin");
            AddLink("Glorfindel-FoS", LinkType.Card_Talk, "https://cardtalk2018.libsyn.com/spirit-hero-glorfindel", "Spirit Hero Glorfindel");
            AddLink("Greenwood-Archer-TSoH", LinkType.Card_Talk, "https://cardtalk2018.libsyn.com/greenwood-archer", "Greenwood Archer");
            AddLink("Grima-Hero-VoI", LinkType.Card_Talk, "https://cardtalk2018.libsyn.com/grima", "Gríma");
            AddLink("Haldir-of-Lorien-TiT", LinkType.Card_Talk, "https://cardtalk2018.libsyn.com/guest-chad-garlinghouse", "Guest Chad Garlinghouse");
            AddLink("Hirluin-the-Fair-TSF", LinkType.Card_Talk, "https://cardtalk2018.libsyn.com/hirluin-the-fair", "Hirluin the Fair");
            AddLink("Island-Amid-Perils-NiE", LinkType.Card_Talk, "https://cardtalk2018.libsyn.com/island-amid-perils", "Island Amid Perils");
            AddLink("Ithilien-Archer-EaAD", LinkType.Card_Talk, "https://cardtalk2018.libsyn.com/ithilien-archer", "Ithilien Archer");
            AddLink("Merry-TBR", LinkType.Card_Talk, "https://cardtalk2018.libsyn.com/tactics-merry", "Tactics Merry");
            AddLink("Mithril-Shirt-TFoW", LinkType.Card_Talk, "https://cardtalk2018.libsyn.com/mithril-shirt", "Mithril Shirt");
            AddLink("Naith-Guide-TDT", LinkType.Card_Talk, "https://cardtalk2018.libsyn.com/naith-guide", "Naith Guide");
            AddLink("Naith-Guide-TPLES", LinkType.Card_Talk, "https://cardtalk2018.libsyn.com/naith-guide", "Naith Guide");
            AddLink("Necklace-of-Girion-TWoR", LinkType.Card_Talk, "https://cardtalk2018.libsyn.com/necklace-of-girion", "Necklace of Girion");
            AddLink("O-Lorien-TiT", LinkType.Card_Talk, "https://cardtalk2018.libsyn.com/o-lorien", "O Lórien!");
            AddLink("Orophin-CS", LinkType.Card_Talk, "https://cardtalk2018.libsyn.com/orophin", "Orophin");
            AddLink("Orophin-TPLES", LinkType.Card_Talk, "https://cardtalk2018.libsyn.com/orophin", "Orophin");
            AddLink("Palantir-AoO", LinkType.Card_Talk, "https://cardtalk2018.libsyn.com/guest-host-ian-martin", "Guest Host Ian Martin");
            AddLink("Pippin-TBR", LinkType.Card_Talk, "https://cardtalk2018.libsyn.com/lore-pippin", "Lore Pippin");
            AddLink("Quicker-Than-Sight-FitN", LinkType.Card_Talk, "https://cardtalk2018.libsyn.com/quicker-than-sight", "Quicker Than Sight");
            AddLink("Rivendell-Blade-RtR", LinkType.Card_Talk, "https://cardtalk2018.libsyn.com/rivendell-blade", "Rivendell Blade");
            AddLink("Rumil-TTT", LinkType.Card_Talk, "https://cardtalk2018.libsyn.com/rumil", "Rúmil");
            AddLink("Sam-Gamgee-TBR", LinkType.Card_Talk, "https://cardtalk2018.libsyn.com/leadership-hero-sam-gamgee", "Leadership Hero Sam Gamgee");
            AddLink("Send-for-Aid-TToR", LinkType.Card_Talk, "https://cardtalk2018.libsyn.com/send-for-aid", "Send for Aid");
            AddLink("Shadowfax-ToS", LinkType.Card_Talk, "https://cardtalk2018.libsyn.com/shadowfax", "Shadowfax");
            AddLink("Silvan-Tracker-TDM", LinkType.Card_Talk, "https://cardtalk2018.libsyn.com/silvan-tracker", "Silvan Tracker");
            AddLink("Smeagol-ASitE", LinkType.Card_Talk, "https://cardtalk2018.libsyn.com/hero-smeagol", "Hero Sméagol");
            AddLink("Sneak-Attack-Core", LinkType.Card_Talk, "https://cardtalk2018.libsyn.com/sneak-attack", "Sneak Attack");
            AddLink("Steward-of-Gondor-Core", LinkType.Card_Talk, "https://cardtalk2018.libsyn.com/steward-of-gondor", "Steward of Gondor");
            AddLink("Steward-of-Gondor-TPLES", LinkType.Card_Talk, "https://cardtalk2018.libsyn.com/steward-of-gondor", "Steward of Gondor");
            AddLink("Sting-MG", LinkType.Card_Talk, "https://cardtalk2018.libsyn.com/tactics-sting", "Tactics Sting");
            AddLink("Thalin-Core", LinkType.Card_Talk, "https://cardtalk2018.libsyn.com/thalin", "Thalin");
            AddLink("The-Arkenstone-TWH", LinkType.Card_Talk, "https://cardtalk2018.libsyn.com/the-arkenstone", "The Arkenstone");
            AddLink("The-Elvenking-FitN", LinkType.Card_Talk, "https://cardtalk2018.libsyn.com/the-elvenking", "The Elvenking");
            AddLink("The-Tree-People-TDT", LinkType.Card_Talk, "https://cardtalk2018.libsyn.com/the-tree-people", "The Tree People");
            AddLink("Theoden-TMV", LinkType.Card_Talk, "https://cardtalk2018.libsyn.com/guest-host-samuel-shreeve", "Guest Host Samuel Shreeve");
            AddLink("Theoden-ToS", LinkType.Card_Talk, "https://cardtalk2018.libsyn.com/spirit-theoden", "Spirit Théoden");
            AddLink("Thranduil-FitN", LinkType.Card_Talk, "https://cardtalk2018.libsyn.com/thranduil", "Thranduil");

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

        public IEnumerable<ILink> GetLinks(string slug)
        {
            var links = new List<ILink>();

            if (string.IsNullOrWhiteSpace(slug))
            {
                return links;
            }

            foreach (var creator in creatorService.AllCreators())
            {
                links.AddRange(creator.GetLinks(slug));
            }

            //Remove the Two Player Limited Edition Starter slug suffix
            //so that we can get the links for the original version of this card
            if (slug.EndsWith("-TPLES"))
            {
                if (slug == "Gandalf-TPLES")
                {
                    slug = "Gandalf-Core";
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
    }
}
