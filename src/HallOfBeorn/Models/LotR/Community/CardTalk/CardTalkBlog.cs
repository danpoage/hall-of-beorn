using System;
using System.Collections.Generic;
using System.Linq;

namespace HallOfBeorn.Models.LotR.Community.CardTalk
{
    public class CardTalkBlog 
        : Creator
    {
        public CardTalkBlog()
            : base("Card Talk Blog", "https://cardtalk2018.com/", "https://cardtalk2018.com/feed/", LinkType.Card_Talk_Blog)
        {
            AddYear(2022);
            AddLink("Deadmen’s Dike with New Angmar Awakened Minimum Purchase Deck – July 26, 2022", "https://cardtalk2018.com/2022/07/29/deadmens-dike-with-new-angmar-awakened-minimum-purchase-deck-july-26-2022/", "Jul 29 2022")
                .WithLabels("Deadmen's Dike", "Arwen Undómiel", "Arwen Undomiel", "Beravor", "Halbarad", "Curious Brandybuck", "East Road Ranger", "Galadhrim Healer", "Galadhrim Weaver", "Gandalf", "Guardian of Arnor", "Ranger of Cardolan", "Sarn Ford Sentry", "Weather Hills Watchman", "Wellinghall Preserver")
                .WithLabels("Athelas", "Forest Snare", "Heir of Valandil", "Steward of Gondor", "The Long Defeat", "Unexpected Courage", "A Test of Will", "Dwarven Tomb", "Elven-light", "Hasty Stroke", "Sneak Attack", "Will of the West");
            AddLink("Asfaloth – Community Review", "https://cardtalk2018.com/2022/07/28/asfaloth-community-review/", "Jul 28 2022")
                .WithLabels("Asfaloth", "Glorfindel");
            AddLink("The Blood of Gondor with Mono-Tactics – November 2, 2019", "https://cardtalk2018.com/2022/07/27/the-blood-of-gondor-with-mono-tactics-november-2-2019/", "Jul 27 2022")
                .WithLabels("The Blood of Gondor", "Tactics", "Beregond", "Éowyn", "Eowyn", "Legolas", "Beechbone", "Bofur", "Defender of Rammas", "Derndingle Warrior", "Dúnedain Hunter", "Dunedain Hunter", "Eagles of the Misty Mountains", "Gandalf", "Honour Guard", "Knights of the Swan")
                .WithLabels("Arod", "Dagger of Westernesse", "Favor of the Valar", "Gondorian Shield", "Rivendell Blade", "Secret Vigil", "Feint", "Foe-hammer", "Hands Upon the Bow");
            AddLink("Hobbit Cloak", "https://cardtalk2018.com/2022/07/26/hobbit-cloak/", "Jul 26 2022")
                .WithLabels("Hobbit Cloak", "Pippin", "Take No Notice", "Mablung", "Sneak Attack", "Gandalf", "The Shirefolk", "Elevensies", "The Galadhrim's Greeting", "Merry", "Galadriel", "Fastred", "Beregond")
                .WithLabels("Frodo Baggins", "Sam Gamgee", "Tom Cotton", "Gondorian Shield", "Shining Shield", "Cloak of Lórien", "Cloak of Lorien")
                .WithDeckLabels(17917);
            AddLink("Palantir Community Review", "https://cardtalk2018.com/2022/07/25/palantir-community-review/", "Jul 25 2022")
                .WithLabels("Palantir", "The Grey Wanderer", "Denethor", "Needful to Know", "Celduin Traveler", "Ithilien Lookout", "Far-sighted", "Double Back");
            AddLink("Assault on Osgiliath with Mono-Tactics 1 & 2 – October 19, 2019", "https://cardtalk2018.com/2022/07/22/assault-on-osgiliath-with-mono-tactics-1-2-october-19-2019/", "Jul 22 2022")
                .WithLabels("Assault on Osgiliath", "Tactics", "Beregond", "Éowyn", "Eowyn", "Legolas", "Beechbone", "Bofur", "Defender of Rammas", "Derndingle Warrior", "Dúnedain Hunter", "Dunedain Hunter", "Eagles of the Misty Mountains", "Gandalf", "Honour Guard", "Knights of the Swan")
                .WithLabels("Arod", "Dagger of Westernesse", "Favor of the Valar", "Gondorian Shield", "Rivendell Blade", "Secret Vigil", "Feint", "Foe-hammer", "Hands Upon the Bow");
            AddLink("Guardian of Esgaroth Community Review", "https://cardtalk2018.com/2022/07/21/guardian-of-esgaroth-community-review/", "Jul 21 2022")
                .WithLabels("Guardian of Esgaroth");
            AddLink("Encounter at Amon Din with Mono-Tactics – October 19, 2019", "https://cardtalk2018.com/2022/07/20/encounter-at-amon-din-with-mono-tactics-october-19-2019/", "Jul 20 2022")
                .WithLabels("Encounter at Amon Din").WithDeckLabels(12992);
            AddLink("Fellowship of the Ring", "https://cardtalk2018.com/2022/07/19/fellowship-of-the-ring/", "Jul 19 2022")
                .WithLabels("Fellowship of the Ring").WithDeckLabels(16864, 8835, 6252);
            AddLink("Spear of the Citadel Community Review", "https://cardtalk2018.com/2022/07/18/spear-of-the-citadel-community-review/", "Jul 18 2022")
                .WithLabels("Spear of the Citadel", "Beregond", "Master of the Forge");
            AddLink("FFG Announces First Repackaged Saga Expansion", "https://cardtalk2018.com/2022/07/15/ffg-announces-first-saga-repackaged-sgag-expansion/", "Jul 15 2022")
                .WithLabels("Frodo Baggins", "The One Ring", "Gandalf", "Sam Gamgee", "Merry", "Pippin", "Fatty Bolger");
            AddLink("Rhovanion Outrider Community Review", "https://cardtalk2018.com/2022/07/15/rhovanion-outrider-community-review/", "Jul 15 2022")
                .WithLabels("Rhovanion Outrider", "Brand son of Bain", "Map of Rhovanion", "Northern Tracker");
            AddLink("The Drúadan Forest with Mono-Tactics – August 25, 2019", "https://cardtalk2018.com/2022/07/14/the-druadan-forest-with-mono-tactics-august-25-2019/", "Jul 14 2022")
                .WithDeckLabels(12992);
            AddLink("Quickbeam (Ally)", "https://cardtalk2018.com/2022/07/13/quickbeam/", "Jul 13 2022")
                .WithLabels("Quickbeam").WithDeckLabels(2314);
            AddLink("Steward’s Fear with Mono-Tactics 4 – July 31, 2019", "https://cardtalk2018.com/2022/07/12/stewards-fear-with-mono-tactics-4-july-31-2019/", "Jul 12 2022")
                .WithDeckLabels(12732);
            AddLink("Windfola Community Review", "https://cardtalk2018.com/2022/07/11/windfola-community-review/", "Jul 11 2022")
                .WithLabels("Windfola", "Eowyn", "Éowyn", "Merry", "Forth, the Three Hunters", "Golden Belt", "Armored Destrier", "Elfhelm");
            AddLink("Intruders in Chetwood with Angmar Awakened Campaign Minimum Purchase Deck 2 – July 2, 2022", "https://cardtalk2018.com/2022/07/08/intruders-in-chetwood-with-angmar-awakened-campaign-minimum-purchase-deck-2-july-2-2022/", "Jul 8 2022")
                .WithLabels("Aragor", "Arwen Undomiel", "Arwen Undómiel", "Beravor");
            AddLink("Steward’s Fear with Mono-Tactics 3 – July 31, 2019", "https://cardtalk2018.com/2022/07/07/stewards-fear-with-mono-tactics-3-july-31-2019/", "Jul 7 2022")
                .WithDeckLabels(12732);
            AddLink("Erkenbrand Community Review", "https://cardtalk2018.com/2022/07/06/erkenbrand-community-review/", "Jul 6 2022")
                .WithLabels("Erkenbrand", "The Day's Rising", "Hauberk of Mail", "Armored Destrier").WithDeckLabels(12166);
            AddLink("Steward’s Fear with Mono-Tactics 2 – July 30, 2019", "https://cardtalk2018.com/2022/07/05/stewards-fear-with-mono-tactics-2-july-30-2019/", "Jul 5 2022")
                .WithDeckLabels(12732);
            AddLink("Forth, The Three Hunters! – Community Review", "https://cardtalk2018.com/2022/07/04/forth-the-three-hunters-community-review/", "Jul 4 2022")
                .WithLabels("Forth, the Three Hunters", "Aragorn", "Legolas", "Frodo Baggins", "Sam Gamgee", "Boromir", "Light of Valinor", "Unexpected Courage", "Shadowfax", "Magic Ring")
                .WithLabels("Steed of the North", "Steed of the Mark", "Rohan Warhorse", "Erestor").WithDeckLabels(18333);
            AddLink("Card Talk Blog's ", "https://cardtalk2018.com/2022/07/02/card-talk-blogs-1st-anniversary/", "Jul 2 2022")
                .WithLabels("Followed");
            AddLink("Intruders in Chetwood with Angmar Awakened Campaign Minimum Purchase Deck 1 – June 26, 2022", "https://cardtalk2018.com/2022/07/01/intruders-in-chetwood-with-angmar-awakened-campaign-minimum-purchase-deck-1-june-26-2022/", "Jul 1 2022")
                .WithLabels("Aragorn", "Arwen Undomiel", "Arwen Undómiel", "Beravor");
            AddLink("Drinking Song", "https://cardtalk2018.com/2022/06/28/drinking-song/", "Jun 28 2022")
                .WithLabels("Drinking Song", "Daeron's Runes", "Gandalf's Search", "Deep Knowledge", "Mithrandir's Advice", "Peace, and Thought", "Erestor", "Love of Tales", "Master of Lore", "Scroll of Isildur", "Erebor Hammersmith", "Council of the Wise")
                .WithDeckLabels(16418);
            AddLink("Steward’s Fear with Mono-Tactics 1 – July 30, 2019", "https://cardtalk2018.com/2022/06/24/stewards-fear-with-mono-tactics-1-july-30-2019/", "Jun 24 2022")
                .WithDeckLabels(12732);
            AddLink("Pippin (Ally)", "https://cardtalk2018.com/2022/06/22/pippin-ally/", "Jun 22 2022")
                .WithLabels("Pippin", "Tom Cotton", "Raise the Shire", "Halfling Determination", "Odo Proudfoot", "Fast Hitch", "Take No Notice", "Mablung", "Secret Vigil", "The Shirefolk", "Elevensies", "Galadriel", "Fastred", "The Galadhrim's Greeting", "Beregond")
                .WithLabels("Fellowship", "Messenger of the King", "Sword-thain", "Forth, the Three Hunters", "Celebrian's Stone", "Celebrían's Stone", "Dagger of Westerness", "Thorongil", "Rosie Cotton")
                .WithDeckLabels(15361, 22208);
            AddLink("Seige of Cair Andros with Mono-Tactics 4 – July 29, 2019", "https://cardtalk2018.com/2022/06/21/seige-of-cair-andros-with-mono-tactics-4-july-29-2019/", "Jun 21 2022")
                .WithLabels("Siege of Cair Andros").WithDeckLabels(12718);
            AddLink("The Fortress of Nurn 6 – June 12, 2022", "https://cardtalk2018.com/2022/06/17/the-fortress-of-nurn-6-june-12-2022/", "Jun 17 2022")
                .WithLabels("The Fortress of Nurn", "Eowyn", "Éowyn", "Beregond", "Thurindir", "Amarthiul", "Amarthiúl");
            AddLink("Honour Guard", "https://cardtalk2018.com/2022/06/15/honour-guard/", "Jun 15 2022")
                .WithLabels("Honour Guard", "Beorn", "Dori", "Ever Vigilant", "Grim Resolve", "Narya").WithDeckLabels(12992);
            AddLink("Seige of Cair Andros with Mono-Tactics 2 & 3 – July 29, 2019", "https://cardtalk2018.com/2022/06/14/seige-of-cair-andros-with-mono-tactics-2-3-july-29-2019/", "Jun 14 2022")
                .WithDeckLabels(12718);
            AddLink("The Fortress of Nurn 5 – June 4, 2022", "https://cardtalk2018.com/2022/06/10/the-fortress-of-nurn-5-june-4-2022/", "Jun 10 2022")
                .WithLabels("The Fortress of Nurn", "Amarthiúl", "Amarthiul", "Beregond", "Éowyn", "Eowyn", "Thurindir");
            AddLink("Seige of Cair Andros with Mono-Tactics 1 – July 29, 2019", "https://cardtalk2018.com/2022/06/07/seige-of-cair-andros-with-mono-tactics-1-july-29-2019/", "Jun 6 2022")
                .WithLabels("The Siege of Cair Andros").WithDeckLabels(12718);
            AddLink("Into Ithilien with Mono-Tactics – July 29, 2019", "https://cardtalk2018.com/2022/06/03/into-ithilien-with-mono-tactics-july-29-2019/", "Jun 3 2022")
                .WithLabels("Into Ithilien", "Tactics").WithDeckLabels(12718);
            AddLink("Curious Brandybuck", "https://cardtalk2018.com/2022/05/31/curious-brandybuck/", "May 31 2022")
                .WithLabels("Curious Brandybuck", "Tom Cotton", "Merry", "Pippin", "Horn of the Mark", "West Road Traveller", "Erestor", "Valiant Sacrifice")
                .WithDeckLabels(23873, 11716);
            AddLink("The Fortress of Nurn 4 – May 21, 2022", "https://cardtalk2018.com/2022/05/28/the-fortress-of-nurn-4-may-21-2022/", "May 28 2022")
                .WithLabels("The Fortress of Nurn", "Amarthiúl", "Amarthiul", "Aragorn", "Glorfindel", "Thurindir");
            AddLink("A Journey in the Dark", "https://cardtalk2018.com/2022/05/27/a-journey-in-the-dark/", "May 27 2022")
                .WithLabels("A Journey in the Dark", "Frodo Baggins", "The One Ring").WithDeckLabels(30023);
            AddLink("A Jorueny in the Dark (YouTube)", "https://youtu.be/ns6pbXon7gw", "May 27 2022")
                .WithLabels("A Journey in the Dark", "Frodo Baggins", "The One Ring").WithDeckLabels(30023);
            AddLink("Bill the Pony", "https://cardtalk2018.com/2022/05/24/bill-the-pony/", "May 24 2022")
                .WithLabels("Bill the Pony", "Citadel Plate", "Ring Mail", "Ancestral Armor", "Ent Draught", "Spare Hood and Cloak", "Spare Pipe", "Sam Gamgee", "Tom Cotton", "Fatty Bolger", "Bilbo Baggins", "Fellowship")
                .WithDeckLabels(17917, 13810);
            AddLink("The Fortress of Nurn 3 – May 8, 2022", "https://cardtalk2018.com/2022/05/20/the-fortress-of-nurn-3-may-8-2022/", "May 20 2022")
                .WithLabels("The Fortress of Nurn").WithDeckLabels(17959);
            AddLink("The Ring Goes South", "https://cardtalk2018.com/2022/05/19/the-ring-goes-south/", "May 19 2022")
                .WithLabels("The Ring Goes South", "Thorongil", "Unexpected Courage").WithDeckLabels(30023);
            AddLink("Reinforcements", "https://cardtalk2018.com/2022/05/18/reinforcements/", "May 18 2022")
                .WithLabels("Reinforcements", "Gandalf", "Meneldor", "Woodland Courier", "Marksman of Lórien", "Marksman of Lorien", "Mablung", "Son of Arnor", "Sarn Ford Sentry", "Sneak Attack")
                .WithLabels("The Galadhrim's Greeting", "Galadhrim Weaver", "Tome of Atanatar", "Second Breakfast", "Narya", "Strength of Arms", "A Very Good Tale")
                .WithLabels(LabelsByPlayerCategory(PlayerCategory.Leaves_Play))
                .WithDeckLabels(8451);
            AddLink("The Fortress of Nurn 2 – May 8, 2022", "https://cardtalk2018.com/2022/05/12/the-fortress-of-nurn-1-may-8-2022/", "May 12 2022")
                .WithLabels("The Fortress of Nurn").WithDeckLabels(17959);
            AddLink("Flight to the Ford", "https://cardtalk2018.com/2022/05/12/flight-to-the-ford/", "May 12 2022")
                .WithLabels("Flight to the Ford", "Frodo's Intuition").WithDeckLabels(30023);
            AddLink("The Great Hunt", "https://cardtalk2018.com/2022/05/11/the-great-hunt/", "May 11 2022")
                .WithLabels("The Great Hunt", "Strength of Arms", "Advanced Warning", "Song of Wisdom", "A Good Harvest", "Messenger of the King", "Thorongil", "Galadriel", "Aragorn", "Nenya", "Ring of Barahir")
                .WithLabels("Folco Boffin", "The Shirefolk", "Elrond's Counsel", "Woodmen's Clearing", "Aragorn", "Pippin", "Take No Notice", "Mablung", " Drinking Song", "Daeron's Runes", "Mithrandir's Advice", "Peace, and Thought", "Deep Knowledge")
                .WithDeckLabels(17606, 12392);
            AddLink("Into Ithilien with Mono-Tactics- May 5, 2019", "https://cardtalk2018.com/2022/05/06/into-ithilien-with-mono-tactics-may-5-2019/", "May 6 2022")
                .WithLabels("Into Ithilien", "Tactics").WithDeckLabels(12718);
            AddLink("A Knife in the Dark", "https://cardtalk2018.com/2022/05/05/a-knife-in-the-dark/", "May 5 2022")
                .WithLabels("A Knife in the Dark", "Sneak Attack", "Gandalf").WithDeckLabels(30023);
            AddLink("Into Ithilien with Mono-Spirit – April 13, 2019", "https://cardtalk2018.com/2022/05/03/into-ithilien-with-mono-spirit-april-13-2019/", "May 3 2022")
                .WithLabels("Into Ithilien", "Spirit", "Arwen Undómiel", "Arwen Undomiel", "Caldara", "Eleanor", "Damrod", "Dwalin", "Elfhelm", "Emery", "Ethir Swordsman", "Gandalf", "Háma", "Hama", "Lórien Guide", "Lorien Guide", "Pelargir Shipwright", "Prince Imrahil", "Warden of Annúminas", "Warden of Annuminas", "Zigil Miner")
                .WithLabels("Blood of Númenor", "Sword-thain")
                .WithLabels("A Test of Will", "Elven-light", "Fortune or Fate", "Hasty Stroke", "The Galadhrim's Greeting", "Will of the West");
            AddLink("Peril in Pelargir with Mono-Spirit – April 13, 2019", "https://cardtalk2018.com/2022/04/29/peril-in-pelargir-with-mono-spirit-april-13-2019/", "Apr 29 2022")
                .WithLabels("Peril in Pelargir", "Spirit", "Arwen Undómiel", "Arwen Undomiel", "Caldara", "Eleanor", "Damrod", "Dwalin", "Elfhelm", "Emery", "Ethir Swordsman", "Gandalf", "Háma", "Hama", "Lórien Guide", "Lorien Guide", "Pelargir Shipwright", "Prince Imrahil", "Warden of Annúminas", "Warden of Annuminas", "Zigil Miner")
                .WithLabels("Blood of Númenor", "Sword-thain")
                .WithLabels("A Test of Will", "Elven-light", "Fortune or Fate", "Hasty Stroke", "The Galadhrim's Greeting", "Will of the West");
            AddLink("Fog on the Barrow Downs", "https://cardtalk2018.com/2022/04/28/fog-on-the-barrow-downs/", "Apr 28 2022")
                .WithLabels("Fog on the Barrow Downs", "Dagger of Westernesse", "https://youtu.be/sxRClepE9ho");
            AddLink("Gwaihir (Hero)", "https://cardtalk2018.com/2022/04/26/gwaihir-hero/", "Apr 26 2022")
                .WithLabels("Gwaihir", "Eagles of the Misty Mountains", "Landroval", "Meneldor", "Eagle Emissary", "Vassel of the Windlord", "Wilyador", "Winged Guardian", "Descendent of Thorondor", "Support of the Eagles", "Born Aloft", "Meneldor's Flight", "Flight of the Eagles", "Sneak Attack", "Horns! Horns! Horns!", "Gwaihir's Debt")
                .WithLabels("A Very Good Tale", "Timely Aid", "The Red Arrow", "Send for Aid", "Vilya", "Stand and Fight", "Unexpected Courage", "Ent Draught", "Self Preservation", "Lembas", "Dúnedain Mark", "Dunedain Mark", "Dúnedain Warning", "Dunedain Warning", "Black Arrow", "Beregond", "The Eagles Are Coming!")
                .WithLabels("Éowyn", "Eowyn", "Thengel", "The Last Alliance", "Escort from Edoras", "Gamling", "Grimbold", "Morwen Steelsheen", "The Riddermark's Finest", "Théodwyn", "Theodwyn", "Westfold Horse-breaker", "Golden Shield", "Horn of the Mark", "Light-footed Steed", "Snowmane", "Thrór's Key", "Thror's Key", "A Test of Will")
                .WithDeckLabels(17992, 17621);
            AddLink("Second Breakfast, and a Double Giveaway!", "https://cardtalk2018.com/2022/04/23/second-breakfast-and-a-double-giveaway/", "Apr 23 2022")
                .WithLabels("Second Breakfast");
            AddLink("The Fortress of Nurn – April 18, 2022", "https://cardtalk2018.com/2022/04/22/the-fortress-of-nurn-april-18-2022/", "Apr 22 2022")
                .WithLabels("The Fortress of Nurn")
                .WithDeckLabels(17959);
            AddLink("The Old Forest", "https://cardtalk2018.com/2022/04/21/the-old-forest/", "Apr 21 2022")
                .WithLabels("The Old Forest", "Tom Bombadill", "Old Man Willow", "Red Book of Westmarch", "Rosie Cotton", "https://youtu.be/oFgos_hpVKE");
            AddLink("Peril in Pelargir with Mono-Tactics – Attempt 2 – April 11, 2019", "https://cardtalk2018.com/2022/04/19/peril-in-pelargir-with-mono-tactics-attempt-2-april-11-2019/", "Apr 19 2022")
                .WithLabels("Peril in Pelargir", "Tactics").WithDeckLabels(12718);
            AddLink("The Land of Sorrow – April 2, 2022", "https://cardtalk2018.com/2022/04/15/the-land-of-sorrow-april-2-2022/", "Apr 15 2022")
                .WithLabels("The Land of Sorrow", "The One Deck").WithDeckLabels(9896);
            AddLink("A Shadow of the Past", "https://cardtalk2018.com/2022/04/14/a-shadow-of-the-past/", "Apr 14 2022")
                .WithLabels("A Shadow of the Past", "Bilbo Baggins", "Gaffer Gamgee", "https://youtu.be/8cDLMA5cbeM");
            AddLink("Gléowine", "https://cardtalk2018.com/2022/04/13/gleowine/", "Apr 13 2022")
                .WithLabels("Gléowine", "Gleowine", "Rivendell Minstrel", "Galadhrim Minstrel", "Gríma", "Grima", "Song of Wisdom", "A Good Harvest", "Éomund", "Eomund", "Théoden", "Theoden")
                .WithLabels("Daeron's Runes", "Deep Knowledge", "Beravor", "Campfire Tales", "Hidden Cache", "Radagast's Cunning", "Secret Paths", "Sneak Attack", "Gandalf", "Grim Resolve")
                .WithLabels("Brand Son of Bain", "Narya", "Círdan the Shipwright", "Cirdan the Shipwright", "Gandalf", "The Free Peoples", "Leather Boots", "Spare Hood and Cloak", "Faramir", "Ancient Mathom", "Foe-hammer")
                .WithLabels("Messenger of the King")
                .WithDeckLabels(26846, 18426, 16418);
            AddLink("Second Breakfast #3", "https://cardtalk2018.com/2022/04/11/second-breakfast-3/", "Apr 11 2022")
                .WithLabels("Flies and Spiders")
                .WithDeckLabels(27355, 27237);
            AddLink("Card Talk Interviews with Caleb Grace and Tyler Parrot Available en Español", "https://cardtalk2018.com/2022/04/08/card-talk-interviews-with-caleb-grace-and-tyler-parrot-available-en-espanol/", "Apr 8 2022")
                .WithLabels("Caleb Grace", "Tyler Parrot", "Español", "Las Cartas de Poder");
            AddLink("Caves of Niben Dum – Paths of Mirkwood Campaign – April 2, 2022", "https://cardtalk2018.com/2022/04/08/caves-of-niben-dum-paths-of-mirkwood-campaign-march-20-2022/", "Apr 8 2022")
                .WithLabels("Caves of Niben Dum", "The Oath");
            AddYear(2021);
            AddLink("Blade of Gondolin", "https://cardtalk2018.com/2021/09/21/blade-of-gondolin/", "Sep 21 2021")
                .WithLabels("Blade of Gondolin");
            AddLink("Guided by Fate", "https://cardtalk2018.com/2021/09/14/guided-by-fate/", "Sep 14 2021")
                .WithLabels("Guided by Fate");
            AddLink("Spirit Théoden", "https://cardtalk2018.com/2021/09/07/spirit-theoden/", "Sep 7 2021")
                .WithLabels("Théoden", "Theoden");
            AddLink("Fast Hitch", "https://cardtalk2018.com/2021/08/31/fast-hitch/", "Aug 31 2021")
                .WithLabels("Fast Hitch");
            AddLink("Meneldor", "https://cardtalk2018.com/2021/08/24/meneldor/", "Aug 24 2021")
                .WithLabels("Meneldor");
            AddLink("Envoy of Pelargir", "https://cardtalk2018.com/2021/08/17/envoy-of-pelagrir/", "Aug 17 2021")
                .WithLabels("Envoy of Pelargir");
            AddLink("Leadership Éomer", "https://cardtalk2018.com/2021/08/10/leadership-eomer/", "Aug 10 2021")
                .WithLabels("Éomer", "Eomer");
            AddLink("Eagles of the  Misty Mountains", "https://cardtalk2018.com/2021/07/29/eagles-of-the-misty-mountains/", "July 29 2021")
                .WithLabels("Eagles of the Misty Mountains");
            AddLink("Radagast and Radagast's Staff", "https://cardtalk2018.com/2021/07/27/radagast-and-radaghasts-staff/", "July 27 2021")
                .WithLabels("Radagast", "Radagast's Staff");
            AddLink("Stone of Elostirion", "https://cardtalk2018.com/2021/07/20/stone-of-elostirion/", "July 20 2021")
                .WithLabels("Stone of Elostirion");
            AddLink("Followed", "https://cardtalk2018.com/2021/07/13/followed/", "July 13 2021")
                .WithLabels("Followed");
        }
    }
}