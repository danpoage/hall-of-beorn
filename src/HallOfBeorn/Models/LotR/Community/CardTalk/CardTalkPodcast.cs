using System;
using System.Collections.Generic;
using System.Linq;
using HallOfBeorn.Services.LotR;

namespace HallOfBeorn.Models.LotR.Community.CardTalk
{
    public class CardTalkPodcast
        : Creator
    {
        public CardTalkPodcast()
            : base("Card Talk",
            "https://cardtalk2018.libsyn.com/",
            "http://cardtalk2018.libsyn.com/rss",
            LinkType.Card_Talk)
        {
            AddYear(2021);
            AddLink("Spirit Con Cards", "https://cardtalk2018.libsyn.com/spirit-con-cards", "Sep 21 2021")
                .WithLabels("The Galadhrim's Greeting", "Light the Beacons", "Spare Pipe", "Smoke and Think", "Lothíriel", "Lothiriel", " Éomer", "Eomer", "Elladan", "Elrohir", "Shadows Give Way",
                    "Double Back", "The Storm Comes", "Explore Secret Ways", "Asfaloth", "Glorfindel", "A Test of Will", "Hasty Stroke");
            AddLink("Guest Host Eric Shell: ALeP Spoiler and Con of the Rings Convo", "https://cardtalk2018.libsyn.com/guest-host-eric-shell-alep-spoiler-and-con-of-the-rings-convo", "Sep 14 2021")
                .WithLabels("Guided by Fate");
            AddLink("Lore Con Cards", "https://cardtalk2018.libsyn.com/lore-con-cards", "Sep 7 2021")
                .WithLabels("Gildor's Counsel", "Deep Knowledge", "The Long Defeat", "Ioreth", "Waters of the Nimrodel", "Out of the Wild", "Keen as Lances", "Gandalf",
                "Leather Boots", "Heed the Dream");
            AddLink("Leadership Con Cards", "https://cardtalk2018.libsyn.com/leadership-con-cards", "Aug 31 2021")
                .WithLabels("Campfire Tales", "Man the Walls", "Grom Resolve", "Strength of Arms", "Errand-rider", "Steward of Gondor", "Resourceful", "Necklace of Girion", 
                    "Unlikely Friendship", "Bifur", "Horn of Gondor", "Glóin", "Gloin", "Parting Gifts", "Rod of the Steward");
            AddLink("Meneldor", "https://cardtalk2018.libsyn.com/meneldor", "Aug 24 2021")
                .WithLabels("Meneldor");
            AddLink("Leadership Merry", "https://cardtalk2018.libsyn.com/repost-leadership-merry-0", "Aug 11 2021")
                .WithLabels("Merry");
            AddLink("Eagles of the Misty Mountains", "https://cardtalk2018.libsyn.com/eagles-of-the-misty-mountains", "Aug 4 2021")
                .WithLabels("Eagles of the Misty Mountains");
            AddLink("Hero Radagast", "https://cardtalk2018.libsyn.com/hero-radagast", "Jul 27 2021")
                .WithLabels("Radagast");
            AddLink("Guest Host Matt Kell AKA Kattattack22", "https://cardtalk2018.libsyn.com/guest-host-matt-kell-aka-kattattack22", "July 20 2021")
                .WithLabels("Followed");
            AddLink("Dawn Take You All", "https://cardtalk2018.libsyn.com/dawn-take-you-all", "July 6 2021")
                .WithLabels("Dawn Take You All");
            AddLink("Spoiler: Con of the Rings 2021", "https://cardtalk2018.libsyn.com/spoiler-con-of-the-rings-2021", "Jun 15 2021");
            AddLink("Daeron's Runes", "https://cardtalk2018.libsyn.com/daerons-runes", "Jun 8 2021")
                .WithLabels("Daeron's Runes");
            AddLink("A Test of Will", "https://cardtalk2018.libsyn.com/a-test-of-will", "Jun 1 2021")
                .WithLabels("A Test of Will");
            AddLink("Last Stand", "https://cardtalk2018.libsyn.com/last-stand", "May 25 2021")
                .WithLabels("Last Stand");
            AddLink("Leadership Eomer", "https://cardtalk2018.libsyn.com/leadership-eomer", "May 18 2021")
                .WithLabels("Éomer", "Eomer");
            AddLink("Grimbeorn the Old", "https://cardtalk2018.libsyn.com/grimbeorn-the-old", "May 11 2021")
                .WithLabels("Grimbeorn the Old");
            AddLink("Tactics Beregond", "https://cardtalk2018.libsyn.com/tactics-beregond", "May 5 2021")
                .WithLabels("Beregond");
            AddLink("Bywater Shirriff", "https://cardtalk2018.libsyn.com/bywater-shirriff", "Apr 27 2021")
                .WithLabels("Bywater Shirriff");
            AddLink("Envoy of Pelargir", "https://cardtalk2018.libsyn.com/envoy-of-pelargir", "Apr 20 2021")
                .WithLabels("Envoy of Pelargir");
            AddLink("Warden of Healing and Iroreth", "https://cardtalk2018.libsyn.com/warden-of-healing-and-ioreth", "Apr 7 2021")
                .WithLabels("Warden of Healing", "Ioreth");
            AddLink("Ally Elrond", "https://cardtalk2018.libsyn.com/ally-elrond", "Mar 30 2021")
                .WithLabels("Elrond");
            AddLink("Magic Ring", "https://cardtalk2018.libsyn.com/magic-ring", "Mar 23 2021")
                .WithLabels("Magic Ring");
            AddLink("Healing Herbs", "https://cardtalk2018.libsyn.com/healing-herbs", "Mar 9 2021")
                .WithLabels("Healing Herbs");
            AddLink("Superlative Caleb", "https://cardtalk2018.libsyn.com/superlative-caleb", "Mar 1 2021");
            AddLink("Superlative February - Show 12", "https://cardtalk2018.libsyn.com/superlative-february-show-12", "Feb 26 2021")
                .WithLabels("Gildor's Counsel", "Heed the Dream", "Far-sighted", "Deep Knowledge", "Drinkling Song", "Striders Path",
                    "A Burning Brand", "Asfaloth", "Elf-stone", "Fast Hitch", "Ranger Spikes");
            AddLink("Superlative February - Show 11", "https://cardtalk2018.libsyn.com/superlative-february-show-11", "Feb 24 2021");
            AddLink("Superlative February - Show 10", "https://cardtalk2018.libsyn.com/superlative-february-show-10", "Feb 22 2021");
            AddLink("Superlative February - Show 9", "https://cardtalk2018.libsyn.com/superlative-february-show-9", "Feb 19 2021");
            AddLink("Superlative February - Show 8", "https://cardtalk2018.libsyn.com/superlative-february-show-8", "Feb 17 2021");
            AddLink("Superlative February - Show 7", "https://cardtalk2018.libsyn.com/superlative-february-show-7", "Feb 15 2021");
            AddLink("Superlative February - Show 6", "https://cardtalk2018.libsyn.com/superlative-february-show-6", "Feb 12 2021");
            AddLink("Superlative February - Show 5", "https://cardtalk2018.libsyn.com/superlative-february-show-5", "Feb 10 2021");
            AddLink("Superlative February - Show 4", "https://cardtalk2018.libsyn.com/superlative-february-show-4", "Feb 8 2021");
            AddLink("Superlative February - Show 3", "https://cardtalk2018.libsyn.com/superlative-february-show-3", "Feb 5 2021");
            AddLink("Superlative February - Show 2", "https://cardtalk2018.libsyn.com/superlative-february-show-2", "Feb 3 2021");
            AddLink("Superlative February - Show 1", "https://cardtalk2018.libsyn.com/superlative-february-show-1", "Feb 1 2021"); 
            AddLink("Beorn's Hospitality", "https://cardtalk2018.libsyn.com/beorns-hospitality", "Jan 27 2021")
                .WithLabels("Beorn's Hospitality");
            AddLink("Lore of Imladris", "https://cardtalk2018.libsyn.com/lore-of-imladris", "Jan 19 2021")
                .WithLabels("Lore of Imladris");
            AddLink("Dunedain Remedy", "https://cardtalk2018.libsyn.com/dunedain-remedy", "Jan 11 2021")
                .WithLabels("Dúnedain Remedy", "Dunedain Remedy");
            AddLink("Self Preservation", "https://cardtalk2018.libsyn.com/self-preservation", "Jan 4 2021")
                .WithLabels("Self Preservation");

            AddYear(2020);
            AddLink("The End Comes", "https://cardtalk2018.libsyn.com/the-end-comes", "Dec 28 2020")
                .WithLabels("The End Comes");
            AddLink("Stone of Elostirion", "https://cardtalk2018.libsyn.com/stone-of-elostirion", "Dec 21 2020")
                .WithLabels("Stone of Elostirion");
            AddLink("Durin's Axe", "https://cardtalk2018.libsyn.com/durins-axe", "Dec 15 2020")
                .WithLabels("Durin's Axe");
            AddLink("Guest Host Eric Shell - A Long-extended Party", "https://cardtalk2018.libsyn.com/guest-host-eric-shell-a-long-expected-party", "Dec 11 2020")
                .WithLabels("Open the Gates");
            AddLink("Thengel - A Long-extended Party", "https://cardtalk2018.libsyn.com/thengel-a-long-extended-party", "Dec 9 2020")
                .WithLabels("Thengel");
            AddLink("Cram", "https://cardtalk2018.libsyn.com/cram", "Dec 7 2020")
                .WithLabels("Cram");
            AddLink("Peace, and Thought", "https://cardtalk2018.libsyn.com/peace-and-thought", "Nov 24 2020")
                .WithLabels("Peace, and Thought");
            AddLink("Announcing Superlative February", "https://cardtalk2018.libsyn.com/announcing-superlative-february", "Nov 18 2020");
            AddLink("Guest Host Joe Hoffman", "https://cardtalk2018.libsyn.com/guest-host-joe-hoffman", "Nov 17 2020")
                .WithLabels("Hobbit");
            AddLink("Ring Mail", "https://cardtalk2018.libsyn.com/ring-mail", "Nov 9 2020")
                .WithLabels("Ring Mail");
            AddLink("Guest Host Justin Gieb", "https://cardtalk2018.libsyn.com/guest-host-justin-gieb", "Oct 26 2020")
                .WithLabels("The Free Peoples");
            AddLink("Guest Host Russ Lundgren", "https://cardtalk2018.libsyn.com/guest-host-russ-lundgren", "Oct 20 2020")
                .WithLabels("Elrond", "Vilya", "Radagast", "Radagast's Staff", "Gandalf", "Eagle", "Loyal Hound", "Wild Stallion");
            AddLink("Card Talk's New Player Buying Guide", "https://cardtalk2018.libsyn.com/card-talks-new-player-buying-guide", "Oct 15 2020")
                .WithLabels("Glorfindel", "Elrond", "Vilya", "Outlands", "Hirluin the Fair", "Éowyn", "Eowyn");
            AddLink("Bofur", "https://cardtalk2018.libsyn.com/spirit-bofur", "Oct 13 2020")
                .WithLabels("Bofur");
            AddLink("Guest Host Vardaen (again!)", "https://cardtalk2018.libsyn.com/guest-host-vardaen-again-0", "Oct 5 2020")
                .WithLabels("Ghân-buri-Ghân", "Ghan-buri-Ghan");
            AddLink("Classic Card Talk Gloin", "https://cardtalk2018.libsyn.com/classic-card-talk-gloin", "Sep 28 2020")
                .WithLabels("Glóin", "Gloin");
            AddLink("Waters of Nimrodel", "https://cardtalk2018.libsyn.com/waters-of-nimrodel", "Sep 14 2020")
                .WithLabels("Waters of Nimrodel");
            AddLink("Ring of Barahir", "https://cardtalk2018.libsyn.com/ring-of-barahir", "Sep 8 2020")
                .WithLabels("Ring of Barahir");
            AddLink("Citadel Custodian", "https://cardtalk2018.libsyn.com/citadel-custodian", "Aug 31 2020")
                .WithLabels("Citadel Custodian");
            AddLink("Free to Choose", "https://cardtalk2018.libsyn.com/free-to-choose", "Aug 25 2020")
                .WithLabels("Free to Choose");
            AddLink("Farmer Maggot", "https://cardtalk2018.libsyn.com/farmer-maggot", "Aug 18 2020")
                .WithLabels("Farmer Maggot");
            AddLink("Card Talk Live: Ered Mithrin Cycle", "https://cardtalk2018.libsyn.com/card-talk-live-ered-mithrin-cycle", "Aug 10 2020")
                .WithLabels("Grimbeorn the Old", "Thranduil", "Bilbo Baggins");
            AddLink("Card Talk Live: Shadows of Mirkwood Cycle", "https://cardtalk2018.libsyn.com/card-talk-live-shadows-of-mirkwood-cycle", "Aug 6 2020")
                .WithLabels("Frodo Baggins", "Hobbit", "Bond of Friendship", "Fast Hitch", "Shadow of the Past", "Aragorn", "Unexpected Courage", "Erebor Hammersmith");
            AddLink("Leadership Hero Faramir", "https://cardtalk2018.libsyn.com/leadership-hero-faramir", "July 28 2020")
                .WithLabels("Faramir");
            AddLink("Miruvor", "https://cardtalk2018.libsyn.com/miruvor", "July 20 2020")
                .WithLabels("Miruvor");
            AddLink("Beravor", "https://cardtalk2018.libsyn.com/beravor", "July 13 2020")
                .WithLabels("Beravor");
            AddLink("SPOILER!!! Thorongil", "https://cardtalk2018.libsyn.com/spoiler-thorongil", "July 10 2020")
                .WithLabels("Thorongil");
            AddLink("SPOILER!!! Spirit Aragorn", "https://cardtalk2018.libsyn.com/spoiler-spirit-aragorn", "July 6 2020")
                .WithLabels("Aragorn");
            AddLink("SPOILER!!! Bond of Friendship Contract", "https://cardtalk2018.libsyn.com/spoiler-bond-of-friendship-contract", "Jun 30 2020")
                .WithLabels("Bond of Friendship");
            AddLink("Guest Hosts Bob and Chrissy", "https://cardtalk2018.libsyn.com/guest-hosts-bob-and-chrissy", "Jun 29 2020")
                .WithLabels("Prince Imrahil");
            AddLink("Tatics Hero Legolas", "https://cardtalk2018.libsyn.com/tactics-hero-legolas", "Jun 15 2020")
                .WithLabels("Legolas");
            AddLink("Ally Treebeard", "https://cardtalk2018.libsyn.com/ally-treebeard", "Jun 8 2020")
                .WithLabels("Treebeard");
            AddLink("Snowbourn Scout", "https://cardtalk2018.libsyn.com/snowbourn-scout", "Jun 1 2020")
                .WithLabels("Snowbourn Scout");
            AddLink("SPOILER!!! Red Book of Westmarch", "https://cardtalk2018.libsyn.com/spoiler-red-book-of-westmarch", "May 18 2020")
                .WithLabels("Red Book of Westmarch");
            AddLink("Guest Hosts Shane and Bob", "https://cardtalk2018.libsyn.com/guest-hosts-shane-and-bob", "May 13 2020")
                .WithLabels("We Are Not Idle");
            AddLink("Round Table Discussion: Attack on Dol Guldur", "https://cardtalk2018.libsyn.com/round-table-discussion-attack-on-dol-guldur", "May 6 2020")
                .WithLabels(Scenario.AttackOnDolGuldur);
            AddLink("Valiant Sacrifice", "https://cardtalk2018.libsyn.com/valiant-sacrifice", "May 4 2020")
                .WithLabels("Valiant Sacrifice");
            AddLink("Power in the Earth", "https://cardtalk2018.libsyn.com/power-in-the-earth", "Apr 27 2020")
                .WithLabels("Power in the Earth");
            AddLink("Timely Aid", "https://cardtalk2018.libsyn.com/timely-aid", "Apr 20 2020")
                .WithLabels("Timely Aid");
            AddLink("Sarah McLeod Intros Rosie Cotton", "https://cardtalk2018.libsyn.com/sarah-mcleod-intros-rosie-cotton", "Apr 13 2020")
                .WithLabels("Rosie Cotton");
            AddLink("Chad G and Christian S Talk about Rosie Cotton", "https://cardtalk2018.libsyn.com/chad-g-and-christian-s-talk-about-rosie-cotton", "Apr 13 2020")
                .WithLabels("Rosie Cotton");
            AddLink("Guest Host Steve Majka,AKA Vardaen", "https://cardtalk2018.libsyn.com/guest-host-steve-majka-aka-vardaen", "Apr 6 2020")
                .WithLabels("Elwing's Flight");
            AddLink("Unexpected Courage", "https://cardtalk2018.libsyn.com/unexpected-courage", "Mar 23 2020")
                .WithLabels("Unexpected Courage");
            AddLink("Guest Host John Rogers 2", "https://cardtalk2018.libsyn.com/guest-host-john-rogers-2", "Mar 16 2020")
                .WithLabels("The Long Defeat");
            AddLink("Guest Host Mark Chan", "https://cardtalk2018.libsyn.com/guest-host-mark-chan", "Mar 9 2020")
                .WithLabels("RiddermarkLord");
            AddLink("Risk Some Light", "https://cardtalk2018.libsyn.com/risk-some-light", "Mar 2 2020")
                .WithLabels("Risk Some Light", "Secrecy");
            AddLink("Guest Hosts Caleb Grace and MJ Newman", "https://cardtalk2018.libsyn.com/guest-hosts-caleb-grace-and-matt-newman", "Feb 28 2020")
                .WithLabels("Éomer", "Eomer", "Lothíriel", "Lothiriel");
            AddLink("Guest Host Brandon", "https://cardtalk2018.libsyn.com/guest-host-brandon", "Feb 26 2020")
                .WithLabels("Boromir");
            AddLink("Spirit Theoden and Theodred", "https://cardtalk2018.libsyn.com/spirit-theoden-and-theodred", "Feb 24")
                .WithLabels("Théoden", "Theoden", "Théodred", "Theodred");
            AddLink("Guest Host Ava Walsh", "https://cardtalk2018.libsyn.com/guest-host-ava-walsh", "Feb 21 2020")
                .WithLabels("Gandalf");
            AddLink("Spirit Legolas and Leadership Hero Gimli", "https://cardtalk2018.libsyn.com/spirit-legolas-and-leadership-hero-gimli", "Feb 19")
                .WithLabels("Legolas", "Gimli");
            AddLink("Guest Host Katie Muir", "https://cardtalk2018.libsyn.com/guest-host-katie-muir", "Feb 14")
                .WithLabels("Gimli");
            AddLink("Guest Host Sarah and Jason", "https://cardtalk2018.libsyn.com/guest-host-sarah-and-jason", "Feb 12")
                .WithLabels("Kahliel");
            AddLink("Smeagol and the One Ring", "https://cardtalk2018.libsyn.com/smeagol-and-the-one-ring", "Feb 10")
                .WithLabels("Sméagol", "Smeagol", "The One Ring");
            AddLink("Guest Host Chloe Walsh", "https://cardtalk2018.libsyn.com/guest-host-chloe-walsh", "Feb 7 2020")
                .WithLabels("Sméagol", "Smeagol");
            AddLink("Guest Host Tolkien Road Podcast", "https://cardtalk2018.libsyn.com/guest-host-tolkien-road-podcast", "Feb 5 2020");
            AddLink("Arwen Undomiel and any Hero Aragorn", "https://cardtalk2018.libsyn.com/hero-arwen-umdomiel-and-any-hero-aragorn", "Feb 3 2020")
                .WithLabels("Arwen Undómiel", "Arwen Undomiel", "Aragorn");
            AddLink("Feint", "https://cardtalk2018.libsyn.com/feint", "Jan 27 2020")
                .WithLabels("Feint");
            AddLink("Theodred", "https://cardtalk2018.libsyn.com/theodred", "Jan 20 2020")
                .WithLabels("Théodred", "Theodred");
            AddLink("COUPLES FEBRUARY!", "https://cardtalk2018.libsyn.com/couples-february", "Jan 16 2020");
            AddLink("SPOILER! Odo Proudfoot", "https://cardtalk2018.libsyn.com/spoiler-odo-proudfoot", "Jan 13 2020")
                .WithLabels("Odo Proudfoot");
            AddLink("Eleanor", "https://cardtalk2018.libsyn.com/eleanor", "Jan 6 2020")
                .WithLabels("Eleanor");
            AddLink("Hero Treebeard", "https://cardtalk2018.libsyn.com/hero-treebeard", "Dec 23 2019")
                .WithLabels("Treebeard");
            AddLink("Behind Strong Walls", "https://cardtalk2018.libsyn.com/behind-strong-walls", "Dec 16 2019")
                .WithLabels("Behind Strong Walls");
            AddLink("Gildor's Counsel", "https://cardtalk2018.libsyn.com/gildors-counsel", "Dec 9 2019")
                .WithLabels("Gildor's Counsel");
            AddLink("Strider's Path", "https://cardtalk2018.libsyn.com/striders-path", "Dec 2 2019")
                .WithLabels("Strider's Path");
            AddLink("Guest Host Caleb Grace 2", "https://cardtalk2018.libsyn.com/guest-host-caleb-grace-2", "Nov 25 2019");
            AddLink("Explore Secret Ways", "https://cardtalk2018.libsyn.com/explore-secret-ways", "Nov 18 2019")
                .WithLabels("Explore Secret Ways");
            AddLink("SPOILER! Lore Saruman and Saruman's Staff", "https://cardtalk2018.libsyn.com/spoiler-lore-saruman-and-sarumans-staff", "Nov 14 2019")
                .WithLabels("Saruman", "Saruman's Staff");
            AddLink("Fortune or Fate", "https://cardtalk2018.libsyn.com/fortune-or-fate", "Nov 13 2019")
                .WithLabels("Fortune or Fate");
            AddLink("Guest Host Aaron Fishbaugh", "https://cardtalk2018.libsyn.com/guest-host-aaron-fishbaugh", "Nov 4 2019")
                .WithLabels("Dori");
            AddLink("Leadership Orcrist", "https://cardtalk2018.libsyn.com/leadership-orcrist", "Oct 28 2019")
                .WithLabels("Orcrist");
            AddLink("Con of the Rings Recap", "https://cardtalk2018.libsyn.com/con-of-the-rings-recap", "Oct 23 2019");
            AddLink("The King's Return", "https://cardtalk2018.libsyn.com/the-kings-return", "Oct 21 2019")
                .WithLabels("The King's Return");
            AddLink("Lore Glamdring", "https://cardtalk2018.libsyn.com/lore-glamdring", "Oct 14 2019")
                .WithLabels("Glamdring");
            AddLink("Con of the Rings Designer Interview", "https://cardtalk2018.libsyn.com/con-of-the-rings-designer-interview", "Oct 11 2019");
            AddLink("Con of the Rings Participant Reflections", "https://cardtalk2018.libsyn.com/con-of-the-rings-participant-reflections", "Oct 8 2019");
            //AddLink("Necklace of Girion", "https://cardtalk2018.libsyn.com/necklace-of-girion", "Sep 30 2019")
            //    .WithLabels("Necklace of Girion");
            AddLink("Guest Host Kristian Priisholm", "https://cardtalk2018.libsyn.com/guest-host-kristian-priisholm", "Sep 23 2019")
                .WithLabels("Ring of Thrór", "Ring of Thror");
            //AddLink("Mithril Shirt", "https://cardtalk2018.libsyn.com/mithril-shirt", "Sep 16 2019")
                //.WithLabels("Mithril Shirt");
            AddLink("Community Tales", "https://cardtalk2018.libsyn.com/community-tales", "Sep 12 2019");

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
        }

        private CreatorLink AddLink(string cardSlug, LinkType type, string url, string title)
        {
            AssociateCardToUrl(cardSlug, url);
            var link = AddLink(new Link(LinkType.Card_Talk, url, title));

            LotRCard card = null;
            foreach (var cardSet in ProductRepository.Instance.CardSets())
            {
                card = cardSet.Cards.FirstOrDefault(c => c.Slug == cardSlug);
                if (card != null)
                {
                    break;
                }
            }

            if (card != null)
            {
                link.WithLabels(card.NormalizedTitle);
                if (card.Title != card.NormalizedTitle)
                {
                    link.WithLabels(card.Title);
                }
            }

            return link;
        }
    }
}