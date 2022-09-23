using System;
using System.Collections.Generic;
using System.Linq;
using HallOfBeorn.Services.LotR;

namespace HallOfBeorn.Models.LotR.Community.HallOfBeorn
{
    public class HallOfBeornBlog
        : Creator
    {
        public HallOfBeornBlog()
            : base("Hall of Beorn Blog",
            "https://hallofbeorn.wordpress.com",
            "https://hallofbeorn.wordpress.com/feed",
            LinkType.Hall_of_Beorn_Blog)
        {
            AddYear(2022);
            AddLink("Deck: Memories of the Second Age", "https://hallofbeorn.wordpress.com/2022/09/06/deck-memories-of-the-second-age/", "6 Sep 2022")
                .WithLabels("Elrond", "Galadriel", "Glorfindel", "Nenya", "Vilya", "Gil-galad", "Forth, the Three Hunters", "Three Hunters", "ALeP");
            AddLink("Deck: Ithilien Hunters", "https://hallofbeorn.wordpress.com/2022/09/02/deck-ithilien-hunters/", "2 Sep 2022")
                .WithLabels("Beregond", "Boromir", "Mablung", "Into Ithilien", "Forth, the Three Hunters", "Three Hunters", "ALeP");
            AddLink("Bear Market: Convention Multiplayer Staples - Part 2", "https://hallofbeorn.wordpress.com/2022/08/11/bear-market-convention-multiplayer-staples-part-2/", "11 Aug 2022")
                .WithLabels("Threat Control", "Frodo Baggins", "Sneak Attack", "Gandalf", "A Lesson in Caution", "Secret Vigil", "Éowyn", "Galadriel (hero)", "The Galadhrim's Greeting", "Double Back", "Aragorn (lore)", "Woodmen's Clearing", "Morwen Steelsheen")
                .WithLabels("Readying", "Armored Destrier", "Grim Resolve", "Need Drives Them", "Brand Son of Bain", "Merry", "Rohan Warhorse", "Hold Your Ground!", "Legolas", "Unexpected Courage", "Spare Hood and Cloak", "Lembas", "Leather Boots", "Wingfoot")
                .WithLabels("Multiplayer", "Con of the Rings", "ALeP");
            AddLink("Bear Market: Convention Multiplayer Staples - Part 1", "https://hallofbeorn.wordpress.com/2022/08/09/bear-market-convention-multiplayer-staples-part-1/", "9 Aug 2022")
                .WithLabels("Card Draw", "Gildor Inglorion", "Campfire Tales", "Prepare for Battle", "Legolas (ally)", "Foe-hammer", "Herubrand", "Galadriel", "Ancient Mathom", "Horn of the Mark", "Beravor", "Deep Knowledge", "Gléowine", "Gleowine", "Elrond (ally)")
                .WithLabels("Resource Acceleration", "Cost Reduction", "Théodred", "Theodred", "Ranger Provisions", "Legacy of Númenor", "Legacy of Numenor", "Mablung (hero)", "Beorn's Welcome", "Horn of Gondor", "Arwen Undómiel (hero)", "Arwen Undomiel (hero)", "Zigil Miner", "Gavin", "Bifur (hero)", "Seasoned Forager", "Love of Tales")
                .WithLabels("Multiplayer", "Con of the Rings", "ALeP");
            AddLink("Discussion: The Downfall of Númenor – Part 4", "https://hallofbeorn.wordpress.com/2022/07/29/discussion-the-downfall-of-numenor-part-4/", "29 July 2022")
                .WithLabels("Númenor", "Death Cult");
            AddLink("Bear Draft v7", "https://hallofbeorn.wordpress.com/2022/07/12/bear-draft-v7/", "12 July 2022")
                .WithLabels("Aragorn", "Brand son of Brain", "Celeborn", "Rowan", "Frodo Baggins", "Denethor", "Gimli", "Amarthiul", "Gildor Inglorion", "Ingold")
                .WithLabels("Legolas", "Eomer", "Beregond", "Mablung", "Glorfindel", "Prince Imrahil", "Eowyn", "Hirgon", "Grimbeorn the Old", "Herebrand")
                .WithLabels("Dunhere", "Merry", "Galadriel", "Arwen Undomiel", "Lanwyn", "Cirdan the Shipwright", "Bard son of Brand", "Dain Ironfoot", "Idraen", "Thengel")
                .WithLabels("Beravor", "Bifur", "Elrond", "Haldan", "Haldir of Lorien", "Thurindir", "Galdor of the Havens", "Damrod", "Radagast", "Nob");
            AddLink("Deck: Be Our Guest", "https://hallofbeorn.wordpress.com/2022/06/15/deck-be-our-guest/", "15 Jun 2022")
                .WithLabels("Osbera", "Balin", "Thorin Stonehelm", "Birna", "Beorn's Welcome", "Beorn", "Giant Bear", "Beorning Skin-changer");
            AddLink("The Downfall of Númenor – Part 3", "https://hallofbeorn.wordpress.com/2022/06/05/discussion-the-downfall-of-numenor-part-3/", "5 Jun 2022")
                .WithLabels("Death Cult");
            AddLink("News: A Long-extended Party – Mustering of the Rohirrim Spoilers", "https://hallofbeorn.wordpress.com/2022/05/26/news-a-long-extended-party-mustering-of-the-rohirrim-spoilers/", "26 May 2022")
                .WithLabels("ALeP", "Mustering of the Rohirrim", "Spoiler", "Osbera", "Beorning Pony");
            AddLink("Poll Results: Most Anticipated Starter Deck", "https://hallofbeorn.wordpress.com/2022/05/08/poll-results-most-anticipated-starter-deck/", "8 May 2022")
                .WithLabels("Starter Deck", "Elves of Lórien", "Elves of Lorien", "Riders of Rohan", "Dwarves of Durin", "Defenders of Gondor");
            AddLink("Bear Market: Five Powerful Staples that aren’t in the Starter Decks", "https://hallofbeorn.wordpress.com/2022/04/24/bear-market-five-powerful-staples-that-arent-in-the-starter-decks/", "24 April 2022")
                .WithLabels("Starter Deck", "Warden of Healing", "Arwen Undómiel (ally)", "Arwen Undomiel (ally)", "Dagger of Westernesse", "Armored Destrier", "Treebeard (ally)");
            AddLink("News: Ring-maker Campaign Spoiler", "https://hallofbeorn.wordpress.com/2022/04/01/news-ring-maker-campaign-spoiler/", "1 April 2022")
                .WithLabels("Nalir", "Spoiler", "April 1st");
            AddLink("Bear Market: Starter Deck Support", "https://hallofbeorn.wordpress.com/2022/03/07/bear-market-starter-deck-support/", "7 March 2022")
                .WithLabels("Starter Deck", "Doom Hangs Still", "Hold Your Ground!", "Favor of the Valar")
                .WithLabels("Denethor (leadership hero)", "Rod of the Steward", "Head the Dream")
                .WithLabels("Armored Destrier", "Entangling Nets", "Arrows from the Trees")
                .WithLabels("Prince Imrahil (tactics hero)", "Knight of the White Tower", "Guardian of Ithilien");
            AddLink("Deck: Valiant Defense", "https://hallofbeorn.wordpress.com/2022/02/28/deck-valiant-defense/", "28 Feb 2022")
                .WithLabels("Support Ukraine", "https://visionofthepalantir.com/2022/02/28/month-in-review-february-2022/", "ALeP")
                .WithDeckLabels(26030);
            AddLink("Deck: Bloodless Victory", "https://hallofbeorn.wordpress.com/2022/02/15/deck-bloodless-victory/", "15 Feb 2022")
                .WithLabels("William Butler Yeats", "J. Robert Oppenheimer", "Hiroshima", "The Children of Húrin", "The Children of Hurin", "Pacifism", "Frodo Baggins")
                .WithLabels("Pippin (lore)", "Gaffer Gamgee", "Forest Snare", "The Great Hunt", "Put Off Pursuit", "Fatty Bolger (lore)", "ALeP")
                .WithDeckLabels(25604);
            AddLink("Metagame: Balance of Power", "https://hallofbeorn.wordpress.com/2022/02/04/metagame-balance-of-power/", "4 Feb 2022")
                .WithLabels("Glorfindel (spirit)", "Asfaloth (lore)", "Elrond", "Vilya", "Master of the Forge", "Imladris Stargazer", "Warden of Healing". "Glóin (leadership hero)")
                .WithLabels("Sudden Pitfall", "Sleeping Sentry", "Dwarrowdelf Cycle")
                .WithDeckLabels(8682);
            AddLink("Poll Results: Favorite Cycle", "https://hallofbeorn.wordpress.com/2022/01/30/poll-results-favorite-cycle/", "30 Jan 2022")
                .WithLabels("Dwarrowdelf", "Dream-chaser", "The Ring Maker", "Ered Mithrin", "Angmar Awakened", "Shadows of Mirkwood", "Against the Shadow", "Haradrim", "Vengeance of Mordor");
            AddLink("Content Winner: Gratitude", "https://hallofbeorn.wordpress.com/2022/01/20/contest-winner-gratitude/", "20 Jan 2022")
                .WithLabels("ALeP", "The Scouring of the Shire", "Contest", "Community")
                .WithLabels("Piranesi by Susanna Clarke", "Klara and the Sun by Kazuo Ishiguro", "Inherent Vice by Thomas Pynchon", "The Travels of Jamie McPheeters by Robert Lewis Taylor", "Song of Solomon by Toni Morrison")
                .WithLabels("The Carrier Bag Theory of Fiction by Ursula K. Le Guin", "Creativity: A Short and Cheerful Guide by John Cleese", "Wilmington's Lie by David Zucchino", "The Demon-Haunted World: Science as a Candle in the Dark by Carl Sagan", "Tito by Neil Barnett")
                .WithLabels("Fear Innoculum by Tool", "Mingus Ah Um by Charles Mingus", "In Rainbows by Radiohead", "Izleti by Paraf", "New Direction by Gene Russell");
            AddLink("New: Celebrating 9 years of the Hall", "https://hallofbeorn.wordpress.com/2022/01/11/news-celebrating-9-years-of-the-hall/", "11 Jan 2022")
                .WithLabels("Community", "ALeP", "The Scouring of the Shire", "Contest", "anniversary", "9 years");
            
            AddYear(2021);
            AddLink("Contest: Gratitude", "https://hallofbeorn.wordpress.com/2021/12/20/contest-gratitude/", "20 Dec 2021")
                .WithLabels("Contest", "Community", "ALeP", "The Scouring of the Shire", "Analogia by George Dyson");
            AddLink("Discussion: The Downfall of Númenor – Part 2", "https://hallofbeorn.wordpress.com/2021/12/04/discussion-the-downfall-of-numenor-part-2/", "4 Dec 2021")
                .WithLabels("The Downfall of Númenor", "The Downfall of Numenor", "Discussion", "The Known World by Edward P. Jones", "Elbow Room by James Alan McPherson", "Song of Solomon by Toni Morrison", "The Lord of the Rings", "The Silmarillion", "J.R.R. Tolkien", "Letter from a Birmingham Jail by Martin Luther King Jr.");
            AddLink("Discussion: The Downfall of Númenor – Part 1", "https://hallofbeorn.wordpress.com/2021/12/02/discussion-the-downfall-of-numenor-part-1/", "2 Dec 2021")
                .WithLabels("The Downfall of Númenor", "The Downfall of Numenor", "Discussion", "The Silmarillion: Akallabêth by J.R.R. Tolkien", "No Name in the Street, by James Baldwin", "The Fire Next Time by James Baldwin")
                .WithLabels("Between the World and Me by Ta-Nehisi Coates", "Caste: The Origins of Our Discontents by Isabel Wilkerson", "The History of the Decline and Fall of the Roman Empire by Edward Gibbon", "The Lord of the Rings by J.R.R. Tolkien", "The Silmarillion by J.R.R. Tolkien");
            AddLink("News: A Bear in Croatia", "https://hallofbeorn.wordpress.com/2021/11/20/news-a-bear-in-croatia/", "20 Nov 2021")
                .WithLabels("Travel", "Community", "Croatia", "Zagreb", "Dubrovnik", "Christmas", "New Year's Day");
            AddLink("Alternate Art: Eagle Storm", "https://hallofbeorn.wordpress.com/2021/11/04/alternate-art-eagle-storm/", "4 Nov 2021")
                .WithLabels("Alternate Art", "Eagle", "Tribal Deck", "ALeP", "Ukiyo-e", "Tokaido", "Fire on the Eastemnet").WithDeckLabels(22660);
            AddLink("Metagame: The Core of the Problem", "https://hallofbeorn.wordpress.com/2021/10/18/metagame-the-core-of-the-problem/", "18 Nov 2021")
                .WithLabels("Core Set", "Revised Core Set", "Grim Resolve", "Brok Ironfist", "Celebrían's Stone", "Celebrían's Stone", "Silverlode Archer", "Ever Vigilant", "Greenwood Archer")
                .WithDeckLabels(23142, 23143, 23144, 23145);
            AddLink("Deck Spotlight: Bear Draft at Con of the Rings 2021", "https://hallofbeorn.wordpress.com/2021/10/05/deck-spotlight-bear-draft-at-con-of-the-rings-2021/", "5 Oct 2021")
                .WithLabels("Con of the Rings 2021", "Bear Draft", "Game Variant", "Draft" "Convention", "Community", "ALeP")
                .WithDeckLabels(22820, 22821, 22823, 22825, 22826, 22827, 22828, 22830);
            AddLink("News: Con of the Rings 2021", "https://hallofbeorn.wordpress.com/2021/09/29/news-con-of-the-rings-2021/", "Sep 29 2021")
                .WithLabels("Con of the Rings 2021", "Community", "Convention", "ALeP", "Bear Draft v6", "Cormac McCarthy", "The Crossing", "Cities on the Plain")
                .WithDeckLabels(15768, 12487, 18019, 19164, 18525, 20125, 22660);
            AddLink("News: A Long-extended Party - Hidden Roosts", "https://hallofbeorn.wordpress.com/2021/09/05/news-a-long-extended-party-hidden-roosts/", "5 Sep 2021")
                .WithLabels("Hidden Roosts", "Spoiler");
            AddLink("Key Concepts: Surviving the Early Game Part 4 - Lore", "https://hallofbeorn.wordpress.com/2021/09/02/key-concepts-surviving-the-early-game-part-4-lore/", "2 Sep 2021")
                .WithLabels("Beravor", "Erestor", "Galdor of the Havens", "Thurindir", "Fatty Bolger", "Warden of Healing", "Master of the Forge", "Galadhrim Minstrel", "Deeping Defender")
                .WithLabels("Protector of Lórien", "Protector of Lorien", "Asfaloth", "Wingfoot", "Lembas", "Daeron's Runes", "Deep Knowledge", "Heed the Dream", "Drinking Song", "Scout Ahead");
            AddLink("Key Concepts: Surviving the Early Game Part 3 - Spirit", "https://hallofbeorn.wordpress.com/2021/08/24/key-concepts-surviving-the-early-game-part-3-spirit/", "24 Aug 2021")
                .WithLabels("Éowyn", "Eowyn", "Arwen Undómiel", "Arwen Undomiel", "Dáin Ironfoot", "Dain Ironfoot", "Lothíriel", "Lothiriel", "Widfast",
                    "Escort from Edoras", "Imladris Stargazer", "Westfold Horse-breeder", "Unexpected Courage", "Miruvor", "Silver Circlet", "Spare Pipe", 
                    "A Test of Will", "Elrond's Counsel", "Elven-light", "Defiant Challenge", "Double Back");
            AddLink("Key Concepts: Surviving the Early Game Part 2 - Tactics", "https://hallofbeorn.wordpress.com/2021/08/01/key-concepts-surviving-the-early-game-part-2-tactics/", "1 Aug 2021")
                .WithLabels("Boromir", "Beorn", "Beregond", "Prince Imrahil", "Eowyn", "Éowyn", "Vassal of the Windlord", "Defender of Rammas", "Honour Guard", "Riddermark Knight",
                    "Gondorian Shield", "Dagger of Westernesse", "Outmatched", "Round Shield", "Feint", "The Eagles Are Coming!", "The Eagles Are Coming", "Behind Strong Walls", "Need Brooks No Delay");
            AddLink("Key Concepts: Surviving the Early Game Part 1 - Leadership", "https://hallofbeorn.wordpress.com/2021/07/20/key-concepts-surviving-the-early-game-part-1-leadership/", "20 July 2021")
                .WithLabels("Erkenbrand", "Sam Gamgee", "Denethor", "Gildor Inglorion", "Ingold", "Errand-rider", "Naith Guide", "Herald of Anorien", "Herald of Anórien", "Soldier of Gondor", 
                    "Steward of Gondor", "Celebrian's Stone", "Celebrían's Stone", "Cram", "Armored Destrier", 
                    "Sneak Attack", "Timely Aid", "Legacy of Numenor", "Legacy of Númenor", "Tighten Our Belts", "Send for Aid");
            AddLink("Bear Market: The Aldburg Plot", "https://hallofbeorn.wordpress.com/2021/07/11/bear-market-the-aldburg-plot/", "11 July 2021")
                .WithLabels("Halfast Gamgee" , "Tom Cotton", "Scouting Party", "The Door is Closed!", "The Door is Closed", "Leaf Brooch");
            AddLink("Play Report: Epic Helm's Deep", "https://hallofbeorn.wordpress.com/2021/06/21/play-report-epic-helms-deep/", "21 June 2021")
                .WithDeckLabels(21175);
            AddLink("News: Epic Helm's Deep, Streaming this Saturday", "https://hallofbeorn.wordpress.com/2021/06/15/news-epic-helms-deep-streaming-this-saturday/", "15 June 2021")
                .WithLabels("Helm's Deep", "Epic Multiplayer", "Streaming", "CardTalk", "Three is Company", "Wandering Took", "Vision of the Palantir", "Durin's Father", "The Purple Wizard")
                .WithLabels("https://www.youtube.com/channel/UCj-QcL_YcA_DQKe7bSe9byA", "https://www.youtube.com/channel/UCcXeDPMUTw2f_El7yvwjDww", "https://www.twitch.tv/wanderingtook")
                .WithLabels("Grimbeorn's Path", "Ride to Bruin")
                .WithDeckLabels(15768, 20125);
            AddLink("Bear Market: Children of Eorl", "https://hallofbeorn.wordpress.com/2021/06/06/bear-market-children-of-eorl/", "6 June 2021")
                .WithLabels("ALeP", "Children of Eorl", "Veteran of Osgiliath", "Favor of the Valar", "Anborn (lore ally)", "Put Off Pursuit", "Live Bait", "Ride to Ruin", "Thengel", "The Mustet of Rohan", "The Last Alliance")
                .WithLabels("Westfold Lancer", " Théoden", "Theoden", "Worthy of Remembrance", "Herubrand", "Éomer (leadership)", "Dúnhere", "Battle-fury")
                .WithDeckLabels(20125);
            AddLink("Alternate Art: Wilderland Wildlife Sanctuary", "https://hallofbeorn.wordpress.com/2021/05/30/alternate-art-wilderland-wildlife-sanctuary/", "30 May 2021")
                .WithDeckLabels(20986);
            AddLink("Bear Draft v6", "https://hallofbeorn.wordpress.com/2021/05/10/bear-draft-v6/", "10 May 2021")
                .WithLabels("Community", "Draft", "Game Variant", "ALeP", "Gondor", "Rohan", "Custom Scenario Kit", "The Wizard's Quest", "The Woodland Realm", "The Mines of Moria", "Escape from Khazad-dûm", "Escape from Khazad-dum", "Austin");
            AddLink("Alternate Art: Nurn Hobits", "https://hallofbeorn.wordpress.com/2021/04/17/alternate-art-nurn-hobbits/", "17 Apr 2021")
                .WithDeckLabels(19164);
            AddLink("News: A Long-extended Party - Beorn", "https://hallofbeorn.wordpress.com/2021/04/01/news-a-long-extended-party-beorn/", "1 Apr 2021")
                .WithLabels("April 1st");
            AddLink("Deck: Ride to Bruin", "https://hallofbeorn.wordpress.com/2021/03/26/deck-ride-to-bruin/", "26 Mar 2021")
                .WithDeckLabels(20125);
            AddLink("Deck: The Second Coming", "https://hallofbeorn.wordpress.com/2021/03/20/deck-the-second-coming/", "20 Mar 2021")
                .WithDeckLabels(20012);
            AddLink("Key Concepts: Learning How to Lose", "https://hallofbeorn.wordpress.com/2021/03/06/key-concepts-learning-how-to-lose/", "6 Mar 2021")
                .WithLabels("Mulligan", "Luck", "Setup", "Galdor of the Havens", "Thurindir", "Gather Informatio", "Glorfindel (spirit ally)", "Elven-light", "Lords of the Eldar", "The Great Hunt")
                .WithLabels("The Master Ring", "A Test of Will", "Eleanor", "The One Ring", "Éowyn", "Eowyn", "Escort from Edoras", "Sword that was Broken", "Visionary Leadership", "Silver Circlet", "Celebrían’s Stone", "Celebrian's Stone")
                .WithLabels("Gamling, Guthwine", "Stand and Fight", "Warden of Healing", "Beorn (tactics hero)", "Prince Imrahil (leadership hero)", "Dain Ironfoot (spirit hero)");
            AddLink("Contest Winners: Celebrating 8 Years", "https://hallofbeorn.wordpress.com/2021/02/15/contest-winners-celebrating-8-years/", "15 Feb 2021")
                .WithLabels("Contest", "Community", "favorites", "anniversary");
            AddLink("Custom Cards: A Little Help from our Friends", "https://hallofbeorn.wordpress.com/2021/02/12/custom-cards-a-little-help-from-our-friends/", "12 Feb 2021")
                .WithLabels("Custom Cards", "Unofficial", "Community", "Dain Ironfoot", "Denethor", "Erkenbrand", "Haldir of Lorien", "Hirgon", "Mablung", "Sam Gamgee", "Theodred");
            AddLink("Poll Results: Favorites from Wilds of Rhovanion and Ered Mithrin", "https://hallofbeorn.wordpress.com/2021/02/03/poll-results-favorites-from-wilds-of-rhovanion-and-ered-mithrin/", "3 Feb 2021")
                .WithLabels("Ered Mithrin", "Wilds of Rhovanion", "Drinking Song", "Grimbeorn the Old", "Reforged", "Thranduil", "Ancestral Armor", "Meneldor", "Hauberk of Mail", "Wild Stallion", "Gaffer Gamgee", "Haldan", "King of Dale")
                .WithLabels("Ring of Thror", "Necklace of Girion", "Bow of Yew", "Brand son of Bain", "Redwater Sentry", "North Realm Lookout", "Loyal Hound", "Bard son of Brand", "Warrior of Dale", "Long Lake Trader");
            AddLink("Bear Market: Tier 2 Favorites", "https://hallofbeorn.wordpress.com/2021/01/22/bear-market-tier-2-favorites/", "22 Jan 2021")
                .WithLabels("Gildor Inglorion (hero)", "Knight of the White Tower", "Ancestral Armor", "Pillars of the Kings")
                .WithLabels("Hirgon", "Meneldor", "Firefoot", "Oath of Eorl")
                .WithLabels("Merry (spirit hero)", "Elfhelm (spirit ally)", "Windfola", "Light the Beacons")
                .WithLabels("Bifur (hero)", "Silvan Tracker", "Woodmen's Clearing", "The Hidden Way");
            AddLink("Contest: Celebrating 8 Years", "https://hallofbeorn.wordpress.com/2021/01/13/contest-celebrating-8-years/", "13 Jan 2021")
                .WithLabels("8 years", "anniversary", "contest", "community", "Massing at Osgiliath", "Murder at the Prancing Pony", "The Land of Sorrow", "The Fortress of Nurn", "Preorder Promotion", "The Hunt for the Dreadnaught");

            AddYear(2020);
            AddLink("Deck 2020 - It's a Trap!", "https://hallofbeorn.wordpress.com/2020/12/31/deck-2020-its-a-trap/", "31 Dec 2020")
                .WithDeckLabels(18934);
            AddLink("News: A Long-extended Party - Worthy of Remembrance", "https://hallofbeorn.wordpress.com/2020/12/14/news-a-long-extended-party-worthy-of-remembrance/", "14 Dec 2020")
                .WithLabels("ALeP", "Spoiler", "Community", "Worthy of Remembrance");
            AddLink("Play Report: A Weary Pilgrim Hunts the Dreadnaught", "https://hallofbeorn.wordpress.com/2020/12/06/play-report-a-weary-pilgrim-hunts-the-dreadnaught/", "6 Dec 2020")
                .WithLabels("The Hunt for the Dreadnaught", "A Weary Pilgrim").WithDeckLabels(2019);
            AddLink("Alternate Art: The Old Elf and the Sea", "https://hallofbeorn.wordpress.com/2020/12/01/alternate-art-the-old-elf-and-the-sea/", "1 Dec 2020")
                .WithDeckLabels(18525);
            AddLink("Alternate Art: The Last Temptation of Boromir", "https://hallofbeorn.wordpress.com/2020/11/17/alternate-art-the-last-temptation-of-boromir/", "17 Nov 2020")
                .WithDeckLabels(18305);
            AddLink("Alternate Art: Gift of the First-Beorn", "https://hallofbeorn.wordpress.com/2020/11/01/alternate-art-gift-of-the-first-beorn/", "1 Nov 2020")
                .WithDeckLabels(16470);
            AddLink("Alternate Art: Nouveau Hunters", "https://hallofbeorn.wordpress.com/2020/10/20/alternate-art-nouveau-hunters/", "20 Oct 2020")
                .WithDeckLabels(18019);
            AddLink("Custom Cards: Filling in the Gaps", "https://hallofbeorn.wordpress.com/2020/10/10/custom-cards-filling-in-the-gaps/", "10 Oct 2020")
                .WithLabels("");
            AddLink("Contest Winners: Carry on the Story", "https://hallofbeorn.wordpress.com/2020/09/21/contest-winners-carry-on-the-story/", "21 Sep 2020");
            AddLink("Alternate Art: Nightmare in the Fog", "https://hallofbeorn.wordpress.com/2020/08/12/alternate-art-nightmare-in-the-fog/", "12 Aug 2020")
                .WithLabels("Nightmare Conflict at the Carrock")
                .WithDeckLabels(17174);
            AddLink("Contest: Carry on the Story", "https://hallofbeorn.wordpress.com/2020/08/06/contest-carry-on-the-story/", "6 Aug 2020");
            AddLink("Vision of the Palantir: Nightmare Conflict at the Carrock", "https://hallofbeorn.wordpress.com/2020/07/11/vision-of-the-palantir-nightmare-conflict-at-the-carrock/", "11 July 2020");
            AddLink("Discussion: Isolation and Tribalism", "https://hallofbeorn.wordpress.com/2020/06/04/isolation-and-tribalism/", "4 June 2020");
            AddLink("Alternate Art: Grimbeorn's Path", "https://hallofbeorn.wordpress.com/2020/05/04/alternate-art-grimbeorns-path/", "4 May 2020")
                .WithDeckLabels(15768);
            AddLink("News: LotR Dutch Blogger", "https://hallofbeorn.wordpress.com/2020/04/12/community-news-lotr-dutch-blogger/", "12 Apr 2020");
            AddLink("Custom Cards: Nightmare Escape from Umbar", "https://hallofbeorn.wordpress.com/2020/04/04/nightmare-escape-from-umbar/", "4 Apr 2020");
            AddLink("Alternate Art: All the Pretty Horses", "https://hallofbeorn.wordpress.com/2020/03/15/alternate-art-all-the-pretty-horses/", "15 Mar 2020")
                .WithDeckLabels(14898);
            AddLink("Alternate Art: Core Set Completion", "https://hallofbeorn.wordpress.com/2020/02/28/alternate-art-core-set-completion/", "28 Feb 2020");
            AddLink("Alternate Art: Wandering in Search of the Entwives", "https://hallofbeorn.wordpress.com/2020/02/14/alternate-art-wandering-in-search-of-the-entwives/", "14 Feb 2020")
                .WithDeckLabels(14502);
            AddLink("Long are the Waves on the Last Shore", "https://hallofbeorn.wordpress.com/2020/01/19/long-are-the-waves-on-the-last-shore/", "Mon, 20 Jan 2020 01:51:00 +0000");

            AddYear(2019);
            AddLink("Vengeance of Mordor: My Favorites So Far", "https://hallofbeorn.wordpress.com/2019/12/17/vengeance-of-mordor-my-favorites-so-far/", "Tue, 17 Dec 2019 07:08:37 +0000");
            AddLink("Alternate Art: Starlight on the Western Seas", "https://hallofbeorn.wordpress.com/2019/11/10/alternate-art-starlight-on-the-western-seas/", "Sun, 10 Nov 2019 18:31:18 +0000")
                .WithDeckLabels(13573);
            AddLink("Alternate Art: Bear Jamboree", "https://hallofbeorn.wordpress.com/2019/10/02/alternate-art-bear-jamboree/", "Wed, 02 Oct 2019 05:41:09 +0000")
                .WithDeckLabels(13323);
            AddLink("Alternate Art: The Three Hunters Aggro v2", "https://hallofbeorn.wordpress.com/2019/09/15/alternate-art-the-three-hunters-aggro-v2/", "Mon, 16 Sep 2019 04:46:13 +0000")
                .WithDeckLabels(13191);
            AddLink("Alternate Art: Errata", "https://hallofbeorn.wordpress.com/2019/09/08/alternate-art-errata/", "Sun, 08 Sep 2019 05:48:26 +0000");
            AddLink("Poll Results: Which archetypes most deserve more support", "https://hallofbeorn.wordpress.com/2019/09/01/poll-results-which-archetypes-most-deserve-more-support/", "Mon, 02 Sep 2019 02:59:48 +0000");
            AddLink("My favorites from The Wilds of Rhovanion and Ered Mithrin Cycle", "https://hallofbeorn.wordpress.com/2019/08/26/my-favorites-from-the-wilds-of-rhovanion-and-ered-mithrin-cycle/", "Tue, 27 Aug 2019 04:51:18 +0000")
                .WithLabels("Grimbeorn the Old", "Dáin Ironfoot", "Dain Ironfoot", "Gaffer Gamgee", "Meneldor", "Wild Stallion", "Giant Bear", "Ancestral Armor", "King of Dale", "Ring of Thrór", "Ring of Thror", "The Arkenstone", "Reforged", "Beorn's Rage");
            AddLink("Alternate Art: Seven Stars and Seven Stones", "https://hallofbeorn.wordpress.com/2019/08/17/alternate-art-seven-stars-and-seven-stones/", "Sat, 17 Aug 2019 07:35:00 +0000")
                .WithDeckLabels(12902);
            AddLink("Alternate Art: The Greatest Adventure", "https://hallofbeorn.wordpress.com/2019/07/04/alternate-art-the-greatest-adventure/", "Fri, 05 Jul 2019 04:03:16 +0000")
                .WithLabels("Dwarven Mining", "Theme Deck", "Tribal Deck")
                .WithDeckLabels(12487);
            AddLink("Alternate Art: A Weary Pilgrim", "https://hallofbeorn.wordpress.com/2019/06/20/alternate-art-a-weary-pilgrim/", "Thu, 20 Jun 2019 06:23:07 +0000")
                .WithDeckLabels(17830);
            AddLink("Alternate Art: Aggro Outlands", "https://hallofbeorn.wordpress.com/2019/05/14/alternate-art-aggro-outlands/", "Wed, 15 May 2019 03:22:59 +0000")
                .WithDeckLabels(12148);
            AddLink("Beorn 2020", "https://hallofbeorn.wordpress.com/2019/04/01/beorn-2020/", "Mon, 01 Apr 2019 05:01:04 +0000")
                .WithLabels("April 1st");
            AddLink("Bear Draft v5 at Lure of Middle-earth 2019", "https://hallofbeorn.wordpress.com/2019/03/02/bear-draft-v5-at-lure-of-middle-earth-2019/", "Sat, 02 Mar 2019 19:03:13 +0000")
                .WithLabels("Lure of Middle-earth", "Community", "Game Variant", "Europe", "Germany", "Draft");
            AddLink("Alternate Art: Whispers in the Trees", "https://hallofbeorn.wordpress.com/2019/02/13/alternate-art-whispers-in-the-trees/", "Wed, 13 Feb 2019 06:55:46 +0000")
                .WithDeckLabels(11169);
            AddLink("Alternate Art: The One Deck", "https://hallofbeorn.wordpress.com/2019/01/20/alternate-art-the-one-deck/", "Mon, 21 Jan 2019 02:25:44 +0000")
                .WithDeckLabels(8682);
            AddLink("A Few, Key, Words", "https://hallofbeorn.wordpress.com/2019/01/06/a-few-key-words/", "Mon, 07 Jan 2019 00:21:56 +0000");
            
            AddYear(2018);
            AddLink("Making Every Card Count", "https://hallofbeorn.wordpress.com/2018/12/21/making-every-card-count/", "Sat, 22 Dec 2018 05:02:52 +0000");
            AddLink("Alternate Art: Carrock and Eyrie", "https://hallofbeorn.wordpress.com/2018/12/08/alternate-art-carrock-and-eyrie/", "Sat, 08 Dec 2018 22:41:43 +0000")
                .WithDeckLabels(10529);
            AddLink("Adventures in Central Europe - Part One: Hungary", "https://hallofbeorn.wordpress.com/2018/11/10/adventures-in-central-europe-part-one-hungary/", "Sat, 10 Nov 2018 06:20:35 +0000")
                .WithDeckLabels(10317);
            AddLink("Bear Draft v4 at Con of the Rings 2018", "https://hallofbeorn.wordpress.com/2018/10/17/bear-draft-v4-at-con-of-the-rings-2018/", "Thu, 18 Oct 2018 04:36:31 +0000");
            AddLink("Hall of Beorn now includes the Digital Card Game", "https://hallofbeorn.wordpress.com/2018/09/11/hall-of-beorn-now-includes-the-digital-card-game/", "Tue, 11 Sep 2018 05:12:34 +0000");
            AddLink("Deck: Shire Yard Sale", "https://hallofbeorn.wordpress.com/2018/08/12/deck-shire-yard-sale/", "Sun, 12 Aug 2018 21:56:10 +0000")
                .WithDeckLabels(9547);
            AddLink("Bear Market: A Half Dozen Deliveries Destined for Dale", "https://hallofbeorn.wordpress.com/2018/07/09/6-deliveries-destined-for-dale/", "Mon, 09 Jul 2018 21:25:27 +0000")
                .WithLabels("Galadriel", "Raiment of War", "Spare Hood and Cloak", "Master of the Forge", "Narya", "Open the Armory");
            AddLink("Play Report: Journey up the Anduin and into Mirkwood", "https://hallofbeorn.wordpress.com/2018/06/26/journey-up-the-anduin-and-into-mirkwood/", "Tue, 26 Jun 2018 05:13:00 +0000")
                .WithDeckLabels(9082)
                .WithDeckLabels(9094);
            AddLink("Con of the Rings", "https://hallofbeorn.wordpress.com/2018/06/06/con-of-the-rings/", "Thu, 07 Jun 2018 04:07:08 +0000");
            AddLink("­News: Viva Las Chingonas!", "https://hallofbeorn.wordpress.com/2018/05/10/viva-las-chingonas/", "Fri, 11 May 2018 04:12:15 +0000")
                .WithDeckLabels(8553);
            AddLink("Poll Results: Where Should the Game Go?", "https://hallofbeorn.wordpress.com/2018/05/06/poll-results-where-should-the-game-go/", "Mon, 07 May 2018 04:39:12 +0000");
            AddLink("Deck: ­Las Chingonas!", "https://hallofbeorn.wordpress.com/2018/04/23/deck-las-chingonas/", "Tue, 24 Apr 2018 03:42:11 +0000")
                .WithDeckLabels(8553);
            AddLink("Discussion: We're Having Cubs!", "https://hallofbeorn.wordpress.com/2018/04/01/were-having-cubs/", "Sun, 01 Apr 2018 05:04:47 +0000")
                .WithLabels("April 1st");
            AddLink("Bear Market: Sands of Harad and Haradrim Cycle", "https://hallofbeorn.wordpress.com/2018/03/18/my-favorites-from-the-sands-of-harad-and-haradrim-cycle/", "Mon, 19 Mar 2018 04:55:46 +0000")
                .WithLabels("Hirgon", "Fastred", "Folco Boffin", "Jubayr", "Firyal", "Emyn Arnen Ranger", " Kahliel's Tribesman", "Rider of Rohan", "Steward of Orthanc", "Magic Ring", "Followed", "Fireside Song", 
                    "Proud Hunters", "Heirs of Eärendil", "Heirs of Earendil", "Wait No Longer", "Oath of Eorl", "The Storm Comes", "Keep Watch", "Prepare for Battle");
            AddLink("News: Portugal. The Country, and the Deck.", "https://hallofbeorn.wordpress.com/2018/02/18/portugal-the-country-and-the-deck/", "Sun, 18 Feb 2018 21:52:21 +0000")
                .WithDeckLabels(7913);
            AddLink("Play Report: Braving the Crossings of Poros", "https://hallofbeorn.wordpress.com/2018/02/11/braving-the-crossings-of-poros/", "Sun, 11 Feb 2018 22:33:01 +0000")
                .WithDeckLabels(5237);
            AddLink("Play Report: Withstanding the Onslaught at Helm's Deep", "https://hallofbeorn.wordpress.com/2018/01/19/withstanding-the-onslaught-at-helms-deep/", "Fri, 19 Jan 2018 06:16:40 +0000")
                .WithDeckLabels(6122);
            
            AddYear(2017);
            AddLink("Play Report: Escape from the Dungeons of Cirith Gurat", "https://hallofbeorn.wordpress.com/2017/12/07/escape-from-the-dungeons-of-cirith-gurat/", "Fri, 08 Dec 2017 05:58:11 +0000");
            AddLink("Poll Results: Your preferred play style", "https://hallofbeorn.wordpress.com/2017/12/01/poll-results-your-preferred-play-style/", "Fri, 01 Dec 2017 23:06:00 +0000");
            AddLink("Metagame: Wandering the Wilderlands", "https://hallofbeorn.wordpress.com/2017/11/18/wandering-the-wilderlands/", "Sun, 19 Nov 2017 05:53:03 +0000");
            AddLink("Alternate Art by Potawo", "https://hallofbeorn.wordpress.com/2017/11/12/alternate-art-by-potawo/", "Sun, 12 Nov 2017 20:20:22 +0000");
            AddLink("Game: Heavy Metal Thunder Mouse", "https://hallofbeorn.wordpress.com/2017/10/05/game-heavy-metal-thunder-mouse/", "Thu, 05 Oct 2017 20:08:48 +0000");
            AddLink("Deck: The Storm Comes", "https://hallofbeorn.wordpress.com/2017/09/07/deck-the-storm-comes/", "Thu, 07 Sep 2017 05:06:25 +0000")
                .WithDeckLabels(6279);
            AddLink("Deck: The Sixth Bear Army", "https://hallofbeorn.wordpress.com/2017/09/05/deck-the-sixth-bear-army/", "Tue, 05 Sep 2017 06:28:36 +0000")
                .WithDeckLabels(6251);
            AddLink("Fastred Outwits the Black Serpent", "https://hallofbeorn.wordpress.com/2017/08/05/fastred-outwits-the-black-serpent/", "Sat, 05 Aug 2017 22:08:19 +0000");
            AddLink("Caldara bests the Black Serpent", "https://hallofbeorn.wordpress.com/2017/07/23/caldara-bests-the-black-serpent/", "Mon, 24 Jul 2017 00:00:37 +0000");
            AddLink("Deck: Solo First Turn Win", "https://hallofbeorn.wordpress.com/2017/07/04/deck-solo-first-turn-win/", "Wed, 05 Jul 2017 03:38:57 +0000")
                .WithLabels("Bifur", "Bilbo Baggins", "Denethor", "Dwarven Sellsword", "Erebor Hammersmith", "Erebor Record Keeper", "Ered Nimrais Prospector", "Glóin", "Gloin",
                    "Good Meal", "Legacy of Durin", "Rod of the Steward", "Scroll of Isildur", "Tome of Atanatar",
                    "Daeron's Runes", "Deep Knowledge", "Gaining Strength", "Heed the Dream", "Justice Shall Be Done", "Legacy of Númenor", "Legacy of Numenor", "Lórien's Wealth", 
                    "Loriens' Wealth", "Lure of Moria", "Mithrandir's Advice", "Ravens of the Mountain", "Second Breakfast", "The Seeing-stone", "We Are Not Idle");
            AddLink("Poll Results: Where should the next cycle go?", "https://hallofbeorn.wordpress.com/2017/06/03/poll-results-where-should-the-next-cycle-go/", "Sat, 03 Jun 2017 21:07:09 +0000");
            AddLink("Play Report: A Vacation, with Spider Ceviche", "https://hallofbeorn.wordpress.com/2017/05/26/a-vacation-with-spider-ceviche/", "Sat, 27 May 2017 03:44:32 +0000")
                .WithLabels("Beneath the Sands", "A Bear of Vacation")
                .WithDeckLabels(5237);
            AddLink("Play Report: My Mûmak's Name is Homer", "https://hallofbeorn.wordpress.com/2017/04/14/my-mumaks-name-is-homer/", "Fri, 14 Apr 2017 06:24:18 +0000")
                .WithLabels("The Mûmakil", "The Mumakil")
                .WithDeckLabels(4655);
            AddLink("Play Report: Caldara and friends win the Race Across Harad", "https://hallofbeorn.wordpress.com/2017/04/02/caldara-and-friends-win-the-race-across-harad/", "Mon, 03 Apr 2017 03:02:00 +0000")
                .WithLabels("Race Across Harad")
                .WithDeckLabels(4655);
            AddLink("Discussion: Tolkien, Politics, and Hobbies vs. \"Real Life\"", "https://hallofbeorn.wordpress.com/2017/03/13/tolkien-politics-and-hobbies-vs-real-life/", "Mon, 13 Mar 2017 14:51:51 +0000");
            AddLink("Alternate Art: Aggro Caldara v3", "https://hallofbeorn.wordpress.com/2017/03/10/alternate-art-aggro-caldara-v3/", "Fri, 10 Mar 2017 19:23:29 +0000")
                .WithDeckLabels(4655);
            AddLink("Alternate Art: Printer Studio", "https://hallofbeorn.wordpress.com/2017/02/15/alternate-art-printer-studio/", "Thu, 16 Feb 2017 05:15:20 +0000");
            AddLink("Reworking the Early Card Pool", "https://hallofbeorn.wordpress.com/2017/01/11/reworking-the-early-card-pool/", "Wed, 11 Jan 2017 23:54:50 +0000");
            AddLink("Play Report: Dúnedain hold back The Long Arm of Mordor", "https://hallofbeorn.wordpress.com/2017/01/11/dunedain-hold-back-the-long-arm-of-mordor/", "Wed, 11 Jan 2017 23:20:04 +0000")
                .WithLabels("The Long Arm of Mordor")
                .WithDeckLabels(4140);

            AddYear(2016);
            AddLink("Poll Results: Favorite New Hero", "https://hallofbeorn.wordpress.com/2016/12/20/poll-results-favorite-new-hero/", "Tue, 20 Dec 2016 22:00:44 +0000")
                .WithLabels("Éowyn", "Eowyn", "Arwen Undómiel", "Arwen Undomiel", "Treebeard", "Aragorn", "Denethor", "Círdan the Shipwright", "Cirdan the Shipwright", "Erestor");
            AddLink("History: Big as a House", "https://hallofbeorn.wordpress.com/2016/12/12/big-as-a-house/", "Mon, 12 Dec 2016 21:04:17 +0000");
            AddLink("Play Report: Three Hunters Aggro Braves the Desert Crossing", "https://hallofbeorn.wordpress.com/2016/12/08/three-hunters-aggro-braves-the-desert-crossing/", "Fri, 09 Dec 2016 05:44:58 +0000")
                .WithDeckLabels(3784);
            AddLink("Play Report: The Model UN Embargoes Captain Sahír", "https://hallofbeorn.wordpress.com/2016/11/21/the-model-un-embargoes-captain-sahir/", "Tue, 22 Nov 2016 04:53:23 +0000")
                .WithLabels("City of Corsairs")
                .WithDeckLabels(3057);
            AddLink("Play Report: Surviving the Siege of Annúminas", "https://hallofbeorn.wordpress.com/2016/11/21/surviving-the-siege-of-annuminas/", "Mon, 21 Nov 2016 15:59:31 +0000")
                .WithLabels("Siege of Annúminas", "Siege of Annuminas")
                .WithDeckLabels(3678);
            AddLink("The Story So Far - Part 1: Shadows of Mirkwood", "https://hallofbeorn.wordpress.com/2016/11/11/the-story-so-far-part-1-shadows-of-mirkwood/", "Fri, 11 Nov 2016 16:46:34 +0000");
            AddLink("A new Power is rising", "https://hallofbeorn.wordpress.com/2016/11/10/a-new-power-is-rising/", "Thu, 10 Nov 2016 19:40:15 +0000");
            AddLink("Arkham LCG Card Search and A Call For Support", "https://hallofbeorn.wordpress.com/2016/11/04/arkham-lcg-card-search-and-a-call-for-support/", "Fri, 04 Nov 2016 16:45:29 +0000")
                .WithLabels("Patreon");
            AddLink("Play Report: Redemption at the Battle of the Pelennor Fields!", "https://hallofbeorn.wordpress.com/2016/10/18/redemption-at-the-battle-of-the-pelennor-fields/", "Wed, 19 Oct 2016 03:00:45 +0000")
                .WithLabels("The Battle of Pelennor Fields")
                .WithDeckLabels(3327);
            AddLink("Play Report: The Battle of the Pelennor Fields was a Massacre", "https://hallofbeorn.wordpress.com/2016/10/11/battle-of-the-pelennor-fields-was-a-massacre/", "Wed, 12 Oct 2016 03:35:08 +0000")
                .WithLabels("The Battle of Pelennor Fields")
                .WithDeckLabels(3235);
            AddLink("Alternate Art: Zero is not Nothing", "https://hallofbeorn.wordpress.com/2016/09/19/alternate-art-zero-is-not-nothing/", "Tue, 20 Sep 2016 04:48:37 +0000")
                .WithLabels("Dúnedain Remedy", "Dunedain Remedy", "A Very Good Tale", "Gondorian Fire", "Foe-hammer", "Blood of Númenor", "Blood of Numenor", "Elrond's Counsel", "Expert Treasure-hunter", "Deep Knowledge", "Good Meal", "Hidden Cache",
                    "Elfhelm", "Legolas", "Beregond", "Bifur");
            AddLink("Bear Draft v3: Card Pool", "https://hallofbeorn.wordpress.com/2016/09/07/bear-draft-v3-card-pool/", "Wed, 07 Sep 2016 19:35:21 +0000");
            AddLink("Bear Draft v3: Havens", "https://hallofbeorn.wordpress.com/2016/08/25/bear-draft-v3-havens/", "Thu, 25 Aug 2016 05:08:48 +0000");
            AddLink("Play Report: The Might of Caldara", "https://hallofbeorn.wordpress.com/2016/08/05/the-might-of-caldara/", "Fri, 05 Aug 2016 19:15:56 +0000")
                .WithDeckLabels(2270);
            AddLink("Bear Market: Hero Showdown", "https://hallofbeorn.wordpress.com/2016/07/25/hero-showdown/", "Mon, 25 Jul 2016 22:52:02 +0000")
                .WithLabels("Sam Gamgee", "Aragorn", "Denethor", "Erkenbrand", "Halbarad", "Beorn", "Mablung", "Boromir", "Bard the Bowman", "Dori",
                    "Arwen Undómiel", "Arwen Undomiel", "Galadriel", "Glorfindel", "Idraen", "Fatty Bolger", "Elrond", "Pippin", "Erestor", "Treebeard", "Faramir");
            AddLink("Community Deck Spotlight: Defenders of Annuminas", "https://hallofbeorn.wordpress.com/2016/07/22/community-deck-spotlight-defenders-of-annuminas/", "Fri, 22 Jul 2016 21:12:34 +0000")
                .WithDeckLabels(2125);
            AddLink("Bear Draft v3: Signature Squads", "https://hallofbeorn.wordpress.com/2016/07/17/bear-draft-v3-signature-squads/", "Mon, 18 Jul 2016 01:35:39 +0000");
            AddLink("News: An Unexpected Party", "https://hallofbeorn.wordpress.com/2016/07/11/an-unexpected-party/", "Tue, 12 Jul 2016 04:02:26 +0000");
            AddLink("Play Report: Bear on Board", "https://hallofbeorn.wordpress.com/2016/06/22/bear-on-board/", "Wed, 22 Jun 2016 06:57:02 +0000")
                .WithLabels("Grey Company", "Temple of the Deceived", "For Gondor!", "Party Animals")
                .WithDeckLabels(1783);
            AddLink("Alternate Art: Magali Villeneuve", "https://hallofbeorn.wordpress.com/2016/05/30/alternate-art-magali-villeneuve/", "Mon, 30 May 2016 23:21:17 +0000")
                .WithLabels("Gandalf", "Sam Gamgee", "Denethor", "Mablung", "Aragorn", "Éowyn", "Eowyn", "Théoden", "Theoden", "Haldir of Lórien", "Erestor")
                .WithLabels("Galadriel", "Gimli", "Boromir", "Legolas", "Bilbo Baggins", "Glorfindel", "Anborn", "Elrond");
            AddLink("Poll Results: Favorite Archetype as of 2015", "https://hallofbeorn.wordpress.com/2016/05/28/poll-results-favorite-archetype-as-of-2015/", "Sat, 28 May 2016 21:46:16 +0000");
            AddLink("Deck: The Grudge", "https://hallofbeorn.wordpress.com/2016/05/16/the-grudge/", "Mon, 16 May 2016 06:34:20 +0000")
                .WithDeckLabels(1203);
            AddLink("Deck: Counsels of the Wise", "https://hallofbeorn.wordpress.com/2016/04/19/deck-counsels-of-the-wise/", "Tue, 19 Apr 2016 19:49:11 +0000")
                .WithDeckLabels(938);
            AddLink("Discussion: The Game is Dying", "https://hallofbeorn.wordpress.com/2016/04/01/the-game-is-dying/", "Fri, 01 Apr 2016 05:00:41 +0000")
                .WithLabels("April 1st");
            AddLink("Make Middle-earth Great Again", "https://hallofbeorn.wordpress.com/2016/03/20/make-middle-earth-great-again/", "Mon, 21 Mar 2016 01:18:02 +0000");
            AddLink("Deck: Círdan, A Power Long Hidden", "https://hallofbeorn.wordpress.com/2016/02/14/cirdan-a-power-long-hidden/", "Mon, 15 Feb 2016 03:30:15 +0000")
                .WithDeckLabels(137);
            AddLink("Deck: Reaches of the Realm", "https://hallofbeorn.wordpress.com/2016/02/05/deck-reaches-of-the-realm/", "Sat, 06 Feb 2016 00:14:08 +0000")
                .WithLabels("Boromir", "Beregond", "Damrod", "Errand-rider", "Pelargir Ship Captain", "Defender of Rammas", "Honour Guard", "Ithilien Tracker",
                    "Mablung", "Warden of Healing", "Envoy of Pelargir", "Ingold", "Veteran of Osgiliath", "Knight of Minas Tirith", "Faramir", "Anborn", "Gandalf",
                    "Heir of Mardil", "Gondorian Shield", "Wingfoot", "Steward of Gondor", "Visionary Leadership", "Ranger Spikes", "Forest Snare",
                    "Wealth of Gondor", "Daeron's Runes", "Deep Knowledge", "Sneak Attack", "Sword of Númenor", "Sword of Numenor", "Ambush", "Sword-thain",
                    "Mutual Accord", "Behind Strong Walls", "For Gondor!", "For Gondor", "Send for Aid", "Gather Information");
            AddLink("Metagame: Part 6 - A Unique Challenge", "https://hallofbeorn.wordpress.com/2016/01/25/metagame-part-6-a-unique-challenge/", "Mon, 25 Jan 2016 06:00:00 +0000");
            AddLink("Poll Results: Favorite Support Hero", "https://hallofbeorn.wordpress.com/2016/01/12/poll-results-favorite-support-hero/", "Tue, 12 Jan 2016 23:03:24 +0000")
                .WithLabels("Elrond", "Galadriel", "Sam Gamgee", "Bill the Pony", "Arwen Undomiel", "Imladris Stargazer", "Galadriel's Handmaiden", "Zigil Miner", "Galadhrim Healer", 
                "Master of the Forge", "Lindir", "Harbor Master", "Erestor", "Galdor from the Havens", "Haldir of Lórien", "Haldir of Lorien", "Gildor Inglorion", "Gandalf", 
                "Light of Valinor", "Mirror of Galadriel", "Nenya", "Unexpected Courage", "Silver Harp", "A Burning Brand", "Vilya",
                "Elrond's Counsel", "Daeron's Runes", "Sneak Attack", "Elven-light", "A Test of Will", "Gather Information", "Double Back");
            AddLink("Metagame: Early Spring Cleaning", "https://hallofbeorn.wordpress.com/2016/01/10/early-spring-cleaning/", "Sun, 10 Jan 2016 22:53:59 +0000");

            AddYear(2015);
            AddLink("Alternate Art Staples", "https://hallofbeorn.wordpress.com/2015/12/23/alternate-art-staples/", "Thu, 24 Dec 2015 02:30:16 +0000");
            AddLink("Deck: The Dúnedain Trappers", "https://hallofbeorn.wordpress.com/2015/12/10/deck-the-dunedain-trappers/", "Thu, 10 Dec 2015 07:57:03 +0000")
                .WithLabels("Aragorn", "Amarthiúl", "Amarthiul", "Damrod", "Dúnedain Watcher", "Dunedain Watcher", "Galadriel", "Guardian of Arnor", 
                "Dúnedain Hunter", "Dunedain Hunter", "Northern Tracker", "Warden of Annúminas", "Warden of Annuminas", "Master of the Forge", "Sarn Ford Sentry", 
                "Celebrían’s Stone", "Celebrian's Stone", "Heir of Valandil", "Steward of Gondor", "Sword that was Broken", "Gondorian Fire", "Gondorian Shield",
                "Forst Snare", "Ranger Spikes", "Descendants of Kings", "Tighten Our Belts", "Feint", "Daeron's Runes", "Deep Knowledge");
            AddLink("Contest Winners: Bree-land Investigators", "https://hallofbeorn.wordpress.com/2015/12/04/contest-winners-bree-land-investigators/", "Sat, 05 Dec 2015 00:38:55 +0000");
            AddLink("Deck: The Bear's Revenge", "https://hallofbeorn.wordpress.com/2015/11/23/deck-the-bears-revenge/", "Mon, 23 Nov 2015 23:17:03 +0000")
                .WithDeckLabels(131);
            AddLink("Contest: Bree-land Investigators", "https://hallofbeorn.wordpress.com/2015/11/15/contest-bree-land-investigators/", "Sun, 15 Nov 2015 23:25:39 +0000");
            AddLink("Gen Con 2015 Bear Draft - Deck Lists", "https://hallofbeorn.wordpress.com/2015/10/28/gen-con-2015-bear-draft-deck-lists/", "Wed, 28 Oct 2015 21:30:02 +0000");
            AddLink("Bear Draft version 2", "https://hallofbeorn.wordpress.com/2015/10/26/bear-draft-version-2/", "Mon, 26 Oct 2015 23:41:50 +0000");
            AddLink("Custom Cards: Defenders of the Carrock", "https://hallofbeorn.wordpress.com/2015/10/21/custom-cards-defenders-of-the-carrock/", "Wed, 21 Oct 2015 07:58:43 +0000");
            AddLink("Deck: Rally the Troops", "https://hallofbeorn.wordpress.com/2015/09/21/deck-rally-the-troops/", "Tue, 22 Sep 2015 02:01:21 +0000");
            AddLink("Poll Results: Favorite Defending Hero", "https://hallofbeorn.wordpress.com/2015/09/15/poll-results-favorite-defending-hero/", "Wed, 16 Sep 2015 01:01:00 +0000");
            AddLink("Gothmog's Dark Corridor 2: The Dunland Trap", "https://hallofbeorn.wordpress.com/2015/09/13/gothmogs-dark-corridor-2-the-dunland-trap/", "Mon, 14 Sep 2015 00:13:27 +0000");
            AddLink("Beorn's Path 16 - Flight from Moria", "https://hallofbeorn.wordpress.com/2015/09/12/beorns-path-16-flight-from-moria/", "Sat, 12 Sep 2015 23:28:13 +0000");
            AddLink("Gothmog's Corridor 1: The Hunt for Gollum", "https://hallofbeorn.wordpress.com/2015/09/08/gothmogs-corridor-1-the-hunt-for-gollum/", "Tue, 08 Sep 2015 17:10:22 +0000");
            AddLink("Beorn's Path 15 - The Seventh Level", "https://hallofbeorn.wordpress.com/2015/09/07/beorns-path-15-the-seventh-level/", "Mon, 07 Sep 2015 23:03:41 +0000");
            AddLink("Support The Hall of Beorn Card Search on Patreon", "https://hallofbeorn.wordpress.com/2015/09/04/support-the-hall-of-beorn-card-search-on-patreon/", "Fri, 04 Sep 2015 18:36:55 +0000");
            AddLink("El Libro Rojo De Bolsón Cerrado", "https://hallofbeorn.wordpress.com/2015/08/31/el-libro-rojo-de-bolson-cerrado/", "Tue, 01 Sep 2015 01:17:42 +0000");
            AddLink("Bear Market: Rethinking Some Staples", "https://hallofbeorn.wordpress.com/2015/08/19/bear-market-rethinking-some-staples/", "Wed, 19 Aug 2015 22:55:52 +0000");
            AddLink("Deck: Refuge at Henneth Annûn", "https://hallofbeorn.wordpress.com/2015/08/16/deck-refuge-at-henneth-annun/", "Mon, 17 Aug 2015 02:07:58 +0000");
            AddLink("A Tribute to David Poage", "https://hallofbeorn.wordpress.com/2015/07/18/a-tribute-to-david-poage/", "Sun, 19 Jul 2015 00:09:15 +0000");
            AddLink("Deck: A Walk with Fangorn", "https://hallofbeorn.wordpress.com/2015/07/08/deck-a-walk-with-fangorn/", "Thu, 09 Jul 2015 03:46:05 +0000");
            AddLink("Poll Results: Favorite Attacking Hero", "https://hallofbeorn.wordpress.com/2015/06/27/poll-results-favorite-attacking-hero/", "Sat, 27 Jun 2015 18:13:42 +0000");
            AddLink("Bear Draft was a hit with the Austin LotR Group", "https://hallofbeorn.wordpress.com/2015/06/12/bear-draft-was-a-hit-with-the-austin-lotr-group/", "Fri, 12 Jun 2015 05:00:35 +0000");
            AddLink("Deck: Champion of Gondor", "https://hallofbeorn.wordpress.com/2015/06/05/deck-champion-of-gondor/", "Fri, 05 Jun 2015 22:46:40 +0000");
            AddLink("GenCon 2015: Bear Draft", "https://hallofbeorn.wordpress.com/2015/05/29/gencon-2015-bear-draft/", "Fri, 29 May 2015 08:35:17 +0000");
            AddLink("Epic Victory Defending Helm's Deep from The Treason of Saruman!", "https://hallofbeorn.wordpress.com/2015/05/15/epic-victory-defending-helms-deep-from-the-treason-of-saruman/", "Fri, 15 May 2015 06:28:19 +0000");
            AddLink("Deck: Revenge of the Nerds", "https://hallofbeorn.wordpress.com/2015/05/09/deck-revenge-of-the-nerds/", "Sat, 09 May 2015 21:55:44 +0000");
            AddLink("Helms Deep Falls to an Onslaught of Uruk-hai", "https://hallofbeorn.wordpress.com/2015/05/06/helms-deep-falls-to-an-onslaught-of-uruk-hai/", "Wed, 06 May 2015 06:04:27 +0000");
            AddLink("Beware the Spirits of the Deadmen's Dike", "https://hallofbeorn.wordpress.com/2015/05/01/beware-the-spirits-of-the-deadmens-dike/", "Sat, 02 May 2015 01:48:40 +0000");
            AddLink("Deck: The Wind Beneath My Wings", "https://hallofbeorn.wordpress.com/2015/04/27/deck-the-wind-beneath-my-wings/", "Mon, 27 Apr 2015 23:48:44 +0000");
            AddLink("Deck: The Might of Rohan", "https://hallofbeorn.wordpress.com/2015/04/19/deck-the-might-of-rohan/", "Sun, 19 Apr 2015 05:40:13 +0000");
            AddLink("Bear Market: 5 Invaluable Cards for Multi-player", "https://hallofbeorn.wordpress.com/2015/04/08/5-invaluable-cards-for-multi-player/", "Thu, 09 Apr 2015 04:31:04 +0000");
            AddLink("Contest Winner: Unicorn Power", "https://hallofbeorn.wordpress.com/2015/04/04/contest-winner-unicorn-power/", "Sat, 04 Apr 2015 18:34:30 +0000");
            AddLink("Appalachian Bear Rescue", "https://hallofbeorn.wordpress.com/2015/04/01/appalachian-bear-rescue/", "Wed, 01 Apr 2015 05:51:32 +0000")
                .WithLabels("April 1st");
            AddLink("Contest: Unicorn Power", "https://hallofbeorn.wordpress.com/2015/03/27/contest-unicorn-power/", "Fri, 27 Mar 2015 21:42:12 +0000");
            AddLink("Deck: For the Shire!", "https://hallofbeorn.wordpress.com/2015/03/26/deck-for-the-shire/", "Thu, 26 Mar 2015 23:44:48 +0000");
            AddLink("Key Concepts: Sideboarding", "https://hallofbeorn.wordpress.com/2015/03/15/key-concepts-sideboarding/", "Sun, 15 Mar 2015 20:47:43 +0000");
            AddLink("Poll Results: Favorite Core Set Staple", "https://hallofbeorn.wordpress.com/2015/02/23/poll-results-favorite-core-set-staple/", "Mon, 23 Feb 2015 06:26:05 +0000");
            AddLink("Contest Winner: Recipes from a Halfling's Pantry", "https://hallofbeorn.wordpress.com/2015/02/21/contest-winner-recipes-from-a-halflings-pantry/", "Sat, 21 Feb 2015 19:30:26 +0000");
            AddLink("Contest: Recipes from a Halfling's Pantry", "https://hallofbeorn.wordpress.com/2015/02/16/contest-recipes-from-a-halflings-pantry/", "Tue, 17 Feb 2015 00:22:25 +0000");
            AddLink("Deck: Eagles and Ents", "https://hallofbeorn.wordpress.com/2015/02/08/deck-eagles-and-ents/", "Mon, 09 Feb 2015 03:30:24 +0000");
            AddLink("Deck: Wisdom, Bravery and Folly", "https://hallofbeorn.wordpress.com/2015/02/04/deck-wisdom-bravery-and-folly/", "Wed, 04 Feb 2015 07:27:47 +0000");
            AddLink("Metagame: Part 5 - FAQs and an Evolving Metagame", "https://hallofbeorn.wordpress.com/2015/01/26/metagame-part-5-faqs-and-an-evolving-metagame/", "Mon, 26 Jan 2015 06:15:10 +0000");
            AddLink("Decks: The House of Elrond", "https://hallofbeorn.wordpress.com/2015/01/19/decks-the-house-of-elrond/", "Tue, 20 Jan 2015 05:55:29 +0000");
            AddLink("Custom Cards: Alternate Art Core Set Heroes", "https://hallofbeorn.wordpress.com/2015/01/17/custom-cards-alternate-art-core-set-heroes/", "Sat, 17 Jan 2015 21:19:04 +0000");
            AddLink("The Second Hand Took: Of Bears and Blogs", "https://hallofbeorn.wordpress.com/2015/01/16/the-second-hand-took-of-bears-and-blogs/", "Sat, 17 Jan 2015 01:37:07 +0000");
            AddLink("Bear Market: Leadership for Ents and Dúnedain", "https://hallofbeorn.wordpress.com/2015/01/11/bear-market-leadership-for-ents-and-dunedain/", "Sun, 11 Jan 2015 23:37:06 +0000");
            AddLink("Two Years of the Hall of Beorn", "https://hallofbeorn.wordpress.com/2015/01/04/two-years-of-the-hall-of-beorn/", "Sun, 04 Jan 2015 06:01:00 +0000");
            AddLink("Deck: Defenders of Rhovanion", "https://hallofbeorn.wordpress.com/2015/01/03/deck-defenders-of-rhovanion/", "Sat, 03 Jan 2015 21:26:46 +0000");

            AddYear(2014);
            AddLink("Poll Results: Most wanted from Ring-maker Cycle", "https://hallofbeorn.wordpress.com/2014/12/31/poll-results-most-wanted-from-ring-maker-cycle/", "Wed, 31 Dec 2014 06:30:53 +0000");
            AddLink("Contest: Master of Lore's Battle of Five Armies Custom Card", "https://hallofbeorn.wordpress.com/2014/12/30/contest-master-of-lores-battle-of-five-armies-custom-card/", "Wed, 31 Dec 2014 01:12:41 +0000");
            AddLink("Contest Winner: Heroic Deeds", "https://hallofbeorn.wordpress.com/2014/12/19/contest-winner-heroic-deeds/", "Fri, 19 Dec 2014 23:45:49 +0000");
            AddLink("The Grey Company at The Battle of Five Armies", "https://hallofbeorn.wordpress.com/2014/12/14/the-grey-company-at-the-battle-of-five-armies/", "Mon, 15 Dec 2014 03:20:44 +0000");
            AddLink("Deck: Brave Explorers", "https://hallofbeorn.wordpress.com/2014/12/13/deck-brave-explorers/", "Sun, 14 Dec 2014 01:32:25 +0000");
            AddLink("Contest: Heroic Deeds", "https://hallofbeorn.wordpress.com/2014/12/08/contest-heroic-deeds/", "Tue, 09 Dec 2014 04:46:33 +0000");
            AddLink("Deck: Look to the Skies", "https://hallofbeorn.wordpress.com/2014/12/03/deck-look-to-the-skies/", "Thu, 04 Dec 2014 00:37:51 +0000");
            AddLink("The Grey Company Was Sadly Unable to Discover Celebrimbor's Secret", "https://hallofbeorn.wordpress.com/2014/11/30/the-grey-company-was-sadly-unable-to-discover-celebrimbors-secret/", "Mon, 01 Dec 2014 02:49:22 +0000");
            AddLink("Contest: Ring-maker Winner", "https://hallofbeorn.wordpress.com/2014/11/28/contest-ring-maker-winner/", "Fri, 28 Nov 2014 17:55:08 +0000");
            AddLink("Contest: Ring-maker Entries", "https://hallofbeorn.wordpress.com/2014/11/24/contest-ring-maker-entries/", "Tue, 25 Nov 2014 04:18:34 +0000");
            AddLink("Breaking News: Giant Bear Dominates In Battle, None Surprised", "https://hallofbeorn.wordpress.com/2014/11/17/breaking-news-giant-bear-dominates-in-battle-none-surprised/", "Tue, 18 Nov 2014 04:05:54 +0000");
            AddLink("The Hobbits Overcome Bellach, and Discover Celebrimbor's Secret", "https://hallofbeorn.wordpress.com/2014/11/15/the-hobbits-overcome-bellach-and-discover-celebrimbors-secret/", "Sun, 16 Nov 2014 00:26:16 +0000");
            AddLink("Contest: Become a Ring-maker!", "https://hallofbeorn.wordpress.com/2014/11/14/contest-become-a-ring-maker/", "Fri, 14 Nov 2014 21:52:11 +0000");
            AddLink("Bear Market: Aggro Archetype", "https://hallofbeorn.wordpress.com/2014/11/11/bear-market-aggro-archetype/", "Tue, 11 Nov 2014 23:57:52 +0000");
            AddLink("Deck: Rohan Cavalry", "https://hallofbeorn.wordpress.com/2014/10/28/deck-rohan-cavalry/", "Tue, 28 Oct 2014 06:31:57 +0000");
            AddLink("Bear With Me: Advanced Search", "https://hallofbeorn.wordpress.com/2014/10/20/bear-with-me-advanced-search/", "Mon, 20 Oct 2014 23:05:09 +0000");
            AddLink("Contest Winner: Just Desserts For A Dark Road", "https://hallofbeorn.wordpress.com/2014/10/18/contest-winner-just-desserts-for-a-dark-road/", "Sat, 18 Oct 2014 05:36:16 +0000");
            AddLink("Contest: Just Desserts For A Dark Road (Updated)", "https://hallofbeorn.wordpress.com/2014/10/13/contest-just-desserts-for-a-dark-road/", "Tue, 14 Oct 2014 04:59:00 +0000");
            AddLink("Breaking of the Fellowship Did Not Break the Grey Company", "https://hallofbeorn.wordpress.com/2014/10/10/breaking-of-the-fellowship-did-not-break-the-grey-company/", "Sat, 11 Oct 2014 03:38:20 +0000");
            AddLink("Bear Market: Tempo Archetype", "https://hallofbeorn.wordpress.com/2014/10/01/bear-market-tempo-archetype/", "Wed, 01 Oct 2014 15:18:15 +0000");
            AddLink("Bear With Me: Text Analysis", "https://hallofbeorn.wordpress.com/2014/09/23/bear-with-me-text-analysis/", "Wed, 24 Sep 2014 00:06:08 +0000");
            AddLink("Key Concepts: Grading", "https://hallofbeorn.wordpress.com/2014/09/13/key-concepts-grading/", "Sun, 14 Sep 2014 02:00:45 +0000");
            AddLink("Not Too Much Trouble in Tharbad", "https://hallofbeorn.wordpress.com/2014/09/09/not-too-much-trouble-in-tharbad/", "Wed, 10 Sep 2014 02:18:25 +0000");
            AddLink("Deck: Daughters of Númenor (and Valinor)", "https://hallofbeorn.wordpress.com/2014/09/05/deck-daughters-of-numenor-and-valinor/", "Fri, 05 Sep 2014 22:23:17 +0000");
            AddLink("Deck: Sons of Númenor", "https://hallofbeorn.wordpress.com/2014/09/01/deck-sons-of-numenor/", "Tue, 02 Sep 2014 01:07:39 +0000");
            AddLink("Deck: Haldir the Hunter", "https://hallofbeorn.wordpress.com/2014/08/25/deck-haldir-the-hunter/", "Tue, 26 Aug 2014 00:27:25 +0000");
            AddLink("Deck: GenCon 2014 (Updated)", "https://hallofbeorn.wordpress.com/2014/08/11/deck-gencon-2014/", "Mon, 11 Aug 2014 19:19:54 +0000");
            AddLink("Metagame: Part 4 - Core Set Supplements", "https://hallofbeorn.wordpress.com/2014/08/05/metagame-part-4-core-set-supplements/", "Wed, 06 Aug 2014 01:01:45 +0000");
            AddLink("Deck: Out of Ithilien", "https://hallofbeorn.wordpress.com/2014/07/29/deck-out-of-ithilien/", "Wed, 30 Jul 2014 00:30:17 +0000")
                .WithLabels("Into Ithilien").WithDeckLabels(755);
            AddLink("3 Things I Like About the Ring-maker Cycle", "https://hallofbeorn.wordpress.com/2014/07/19/3-things-i-like-about-the-ring-maker-cycle/", "Sat, 19 Jul 2014 07:50:15 +0000");
            AddLink("Beorn's Path: Part 14 - Into the Pit", "https://hallofbeorn.wordpress.com/2014/07/16/beorns-path-part-14-into-the-pit/", "Thu, 17 Jul 2014 00:06:50 +0000")
                .WithLabels("Into the Pit", "Dain Ironfoot (leadership)", "Thalin", "Bifur (hero)", "Erebor Record Keeper", "Gondorian Spearman", "Veteran Axehand", "Erebor Hammersmith", "Miner of the Iron Hills", "Gléowine", "Gleowine", "Daughter of the Nimrodel", "Longbeard Orc Slayer", "Gandalf (core)")
                .WithLabels("Dúnedain Warning", "Dunedain Warning", "Dwarrowdelf Axe", "Protector of Lórien", "Protector of Lorien", "Narvi's Belt", "Steward of Gondor", "Parting Gifts", "Sneak Attack", "Feint", "Quick Strike");
            AddLink("Deck: Aggro Boromir", "https://hallofbeorn.wordpress.com/2014/07/10/deck-aggro-boromir/", "Thu, 10 Jul 2014 22:21:50 +0000")
                .WithDeckLabels(420);
            AddLink("Boromir Laughs At Dunlendings!", "https://hallofbeorn.wordpress.com/2014/07/09/boromir-laughs-at-dunlendings/", "Thu, 10 Jul 2014 00:24:29 +0000");
            AddLink("The Grey Company is Snared in The Dunland Trap", "https://hallofbeorn.wordpress.com/2014/07/06/the-grey-company-is-snared-in-the-dunland-trap/", "Mon, 07 Jul 2014 02:36:16 +0000")
                .WithLabels("The Dunland Trap", "http://youtu.be/HtZcKbz47cY");
            AddLink("Deck: The Window on the West", "https://hallofbeorn.wordpress.com/2014/06/30/deck-the-window-on-the-west/", "Tue, 01 Jul 2014 01:23:57 +0000");
            AddLink("Visita Susurros del Bosque Viejo", "https://hallofbeorn.wordpress.com/2014/06/29/visita-susurros-del-bosque-viejo/", "Sun, 29 Jun 2014 22:41:14 +0000")
                .WithLabels("Blog", "Español", "Espanol");
            AddLink("Poll Results: Favorite Strategy", "https://hallofbeorn.wordpress.com/2014/06/25/poll-results-favorite-strategy/", "Thu, 26 Jun 2014 04:55:35 +0000");
            AddLink("To Catch an Orc (Predator)", "https://hallofbeorn.wordpress.com/2014/06/20/to-catch-an-orc-predator/", "Sat, 21 Jun 2014 03:15:25 +0000");
            AddLink("Contest Winner: Leave None Alive", "https://hallofbeorn.wordpress.com/2014/06/17/contest-winner-leave-none-alive/", "Tue, 17 Jun 2014 16:52:39 +0000");
            AddLink("Deck: Creature Feature", "https://hallofbeorn.wordpress.com/2014/06/13/deck-creature-feature/", "Sat, 14 Jun 2014 03:45:25 +0000");
            AddLink("Contest: Leave None Alive", "https://hallofbeorn.wordpress.com/2014/06/09/contest-leave-none-alive/", "Mon, 09 Jun 2014 23:28:55 +0000");
            AddLink("Beorning Bee Keeper In Action!", "https://hallofbeorn.wordpress.com/2014/06/07/beorning-bee-keeper-in-action/", "Sat, 07 Jun 2014 20:11:07 +0000");
            AddLink("Bear Market: Silvan Cards", "https://hallofbeorn.wordpress.com/2014/05/09/bear-market-silvan-cards/", "Fri, 09 May 2014 05:28:15 +0000");
            AddLink("Deck: The White Council", "https://hallofbeorn.wordpress.com/2014/05/07/deck-the-white-council/", "Wed, 07 May 2014 05:38:10 +0000");
            AddLink("Deck: Boromir's Sacrifice", "https://hallofbeorn.wordpress.com/2014/04/30/deck-boromirs-sacrifice/", "Thu, 01 May 2014 04:33:42 +0000");
            AddLink("Poll Results: Favorite Epic Moments in The Lord of the Rings", "https://hallofbeorn.wordpress.com/2014/04/26/poll-results-favorite-epic-moments-in-the-lord-of-the-rings/", "Sat, 26 Apr 2014 23:52:42 +0000");
            AddLink("Key Concepts: Splashing", "https://hallofbeorn.wordpress.com/2014/04/16/key-concepts-splashing/", "Thu, 17 Apr 2014 04:06:38 +0000");
            AddLink("Key Concepts: Traits - Rohan", "https://hallofbeorn.wordpress.com/2014/04/04/key-concepts-traits-rohan/", "Fri, 04 Apr 2014 06:27:46 +0000")
                .WithLabels("Rohan", "Dúnhere", "Dunhere", "Forth Eorlingas", "Dagger of Westernesse", "Spear of the Mark", "Rohan Warhorse", "Westfold Horse-breeder", "Escort from Edoras", "West Road Traveller", "The Galadhrim’s Greeting")
                .WithLabels("Éomer (tactics)", "Eomer (tactics)", "Snowbourn Scout", "Westfold Outrider", "Éomund", "Eomund", "Westfold Horse-breaker")
                .WithLabels("Éowyn (spirit)", "Eowyn (spirit)", "Astonishing Speed", "Mutual Accord", "Visionary Leadership", "The Riddermark's Finest")
                .WithLabels("Gríma", "Grima", "Gléowine", "Gleowine", "Keys of Orthanc", "A Burning Brand", "Feint", "A Test of Will")
                .WithLabels("Háma (tactics)", "Hama (tactics)", "Forth Eorlingas!", "Foe-Hammer")
                .WithLabels("Théoden (tactics)", "Theoden (tactics)", "Steed of the Mark", "Unexpected Courage")
                .WithLabels("Théodred", "Theodred", "Gaining Strength", "Grim Resolve", "We Do Not Sleep", "Sneak Attack", "Éomund", "Eomund");
            AddLink("Friendship Is Magic", "https://hallofbeorn.wordpress.com/2014/04/01/friendship-is-magic/", "1 Apr 2014")
                .WithLabels("April 1st");
            AddLink("Deck: Ride Them Down!", "https://hallofbeorn.wordpress.com/2014/03/25/deck-ride-them-down/", "Tue, 25 Mar 2014 06:27:34 +0000");
            AddLink("Bear Market: 5 Great Glue Cards", "https://hallofbeorn.wordpress.com/2014/03/21/beorns-favorites-5-great-glue-cards/", "Fri, 21 Mar 2014 07:33:24 +0000")
                .WithLabels("Envoy of Pelargir", "Errand-rider", "Halfling Determination", "Westfold Horse-breeder", "Daeron's Runes");
            AddLink("Contest Winner: Raiding the Kitchen of Orthanc", "https://hallofbeorn.wordpress.com/2014/03/18/contest-winner-raiding-the-kitchen-of-orthanc/", "Tue, 18 Mar 2014 05:37:23 +0000");
            AddLink("A Good Cause", "https://hallofbeorn.wordpress.com/2014/03/13/a-good-cause/", "Fri, 14 Mar 2014 01:58:40 +0000");
            AddLink("The Lure of Power", "https://hallofbeorn.wordpress.com/2014/03/13/the-lure-of-power/", "Thu, 13 Mar 2014 18:02:54 +0000");
            AddLink("Deck: Westfold to the Rescue", "https://hallofbeorn.wordpress.com/2014/03/07/deck-westfold-to-the-rescue/", "Fri, 07 Mar 2014 06:01:33 +0000");
            AddLink("Contest: Raiding the Kitchen of Orthanc", "https://hallofbeorn.wordpress.com/2014/03/06/contest-raiding-the-kitchen-of-orthanc/", "Thu, 06 Mar 2014 06:04:08 +0000");
            AddLink("The Grey Company Dominates at the Fords of Isen", "https://hallofbeorn.wordpress.com/2014/03/02/the-grey-company-dominates-at-the-fords-of-isen/", "Mon, 03 Mar 2014 05:00:30 +0000");
            AddLink("12 Angry Glorfindels. Your Argument Is Invalid", "https://hallofbeorn.wordpress.com/2014/03/02/12-angry-glorfindels-your-argument-is-invalid/", "Mon, 03 Mar 2014 04:53:58 +0000");
            AddLink("Narrow Escape from the Fords of Isen", "https://hallofbeorn.wordpress.com/2014/03/01/narrow-escape-from-the-fords-of-isen/", "Sat, 01 Mar 2014 21:08:57 +0000");
            AddLink("Poll Results: What is your favorite section of Hall of Beorn?", "https://hallofbeorn.wordpress.com/2014/02/28/poll-results-what-is-your-favorite-section-of-hall-of-beorn/", "Fri, 28 Feb 2014 16:46:21 +0000");
            AddLink("Decks: The Battle of Five Armies", "https://hallofbeorn.wordpress.com/2014/02/27/decks-the-battle-of-five-armies/", "Thu, 27 Feb 2014 06:44:58 +0000");
            AddLink("News: Voice of Isengard Player Card Spoilers", "https://hallofbeorn.wordpress.com/2014/02/24/news-voice-of-isengard-player-card-spoilers/", "Mon, 24 Feb 2014 06:40:44 +0000");
            AddLink("Community News - February 2014", "https://hallofbeorn.wordpress.com/2014/02/23/community-news-february-2014/", "Sun, 23 Feb 2014 20:23:37 +0000");
            AddLink("Troll of the Week: The Critic", "https://hallofbeorn.wordpress.com/2014/02/19/troll-of-the-week-the-critic/", "Wed, 19 Feb 2014 16:32:30 +0000");
            AddLink("Key Concepts: Control", "https://hallofbeorn.wordpress.com/2014/01/31/key-concepts-control/", "Sat, 01 Feb 2014 04:13:36 +0000");
            AddLink("Custom Cards: The Last Stand of the Rohirrim", "https://hallofbeorn.wordpress.com/2014/01/29/custom-cards-the-last-stand-of-the-rohirrim/", "Thu, 30 Jan 2014 05:52:51 +0000");
            AddLink("A Hint of Things to Come?", "https://hallofbeorn.wordpress.com/2014/01/26/a-hint-of-things-to-come/", "Sun, 26 Jan 2014 20:00:41 +0000");
            AddLink("Deck: Digging Too Deep", "https://hallofbeorn.wordpress.com/2014/01/25/deck-digging-too-deep/", "Sat, 25 Jan 2014 21:43:40 +0000");
            AddLink("Deck: A Desperate Gambit", "https://hallofbeorn.wordpress.com/2014/01/20/deck-a-desperate-gambit/", "Mon, 20 Jan 2014 21:24:06 +0000");
            AddLink("History: Absent, But Not Forgotten", "https://hallofbeorn.wordpress.com/2014/01/19/history-absent-but-not-forgotten/", "Sun, 19 Jan 2014 08:46:15 +0000");
            AddLink("The Grey Company: Troll Exterminators For Hire", "https://hallofbeorn.wordpress.com/2014/01/13/the-grey-company-troll-exterminators-for-hire/", "Tue, 14 Jan 2014 03:11:44 +0000");
            AddLink("The Grey Company Defends The Carrock From Nightmarish Trolls", "https://hallofbeorn.wordpress.com/2014/01/12/the-grey-company-defends-the-carrock-from-nightmarish-trolls/", "Sun, 12 Jan 2014 20:26:38 +0000")
                .WithLabels("Conflict at the Carrock", "Nightmare");
            AddLink("History: Lord of the Rings LCG Timeline (Updated 4/30/2018)", "https://hallofbeorn.wordpress.com/2014/01/11/lore-lord-of-the-rings-lcg-timeline/", "Sat, 11 Jan 2014 22:06:36 +0000");
            AddLink("Key Concepts: Resource Curves", "https://hallofbeorn.wordpress.com/2014/01/07/key-concepts-resource-curves/", "Wed, 08 Jan 2014 03:59:19 +0000");
            AddLink("The Hall of Beorn Celebrates One Year!", "https://hallofbeorn.wordpress.com/2014/01/04/the-hall-of-beorn-celebrates-one-year/", "Sat, 04 Jan 2014 20:37:44 +0000")
                .WithLabels("Anniversary");
            AddLink("Poll Results: What other kinds of games do you play?", "https://hallofbeorn.wordpress.com/2014/01/03/poll-results-what-other-kinds-of-games-do-you-play/", "Fri, 03 Jan 2014 19:17:59 +0000");
            AddLink("Custom Cards: Hobbit Fealty", "https://hallofbeorn.wordpress.com/2014/01/03/custom-cards-hobbit-fealty/", "Fri, 03 Jan 2014 09:11:31 +0000");

            AddYear(2013);
            AddLink("Merry Christmas!", "https://hallofbeorn.wordpress.com/2013/12/24/merry-christmas/", "Tue, 24 Dec 2013 08:54:34 +0000");
            AddLink("Deck: Warriors of the White Tower", "https://hallofbeorn.wordpress.com/2013/12/17/deck-warriors-of-the-white-tower/", "Tue, 17 Dec 2013 07:37:52 +0000");
            AddLink("Deck: The Spirit of Gondor", "https://hallofbeorn.wordpress.com/2013/12/16/deck-the-spirit-of-gondor/", "Tue, 17 Dec 2013 04:25:25 +0000");
            AddLink("Deck: Faramir and the Rangers of Ithilien", "https://hallofbeorn.wordpress.com/2013/12/16/deck-faramir-and-the-rangers-of-ithilien/", "Mon, 16 Dec 2013 07:17:44 +0000");
            AddLink("Discussion: Peter Jackson, Please Don't Mess This Up!", "https://hallofbeorn.wordpress.com/2013/12/13/peter-jackson-please-dont-mess-this-up/", "Fri, 13 Dec 2013 22:04:49 +0000")
                .WithLabels("Peter Jackson", "The Hobbit", "Movies", "Beorn", "Adaptation");
            AddLink("Community News - December 2013", "https://hallofbeorn.wordpress.com/2013/12/11/community-news-december-2013/", "Wed, 11 Dec 2013 20:31:47 +0000");
            AddLink("Food In the Hobbit", "https://hallofbeorn.wordpress.com/2013/12/09/food-in-the-hobbit/", "Mon, 09 Dec 2013 22:40:50 +0000");
            AddLink("Contest Winner: A Very Good Tale", "https://hallofbeorn.wordpress.com/2013/12/07/contest-winner-a-very-good-tale/", "Sun, 08 Dec 2013 02:51:03 +0000");
            AddLink("The Grey Company Survives The Morgul Vale", "https://hallofbeorn.wordpress.com/2013/12/07/the-grey-company-survives-the-morgul-vale/", "Sat, 07 Dec 2013 22:01:59 +0000")
                .WithLabels("The Morgul Vale");
            AddLink("Deck: Boromir Leads the Charge!", "https://hallofbeorn.wordpress.com/2013/12/05/deck-boromir-leads-the-charge/", "Thu, 05 Dec 2013 22:11:51 +0000");
            AddLink("HallOfBeorn.com is live!", "https://hallofbeorn.wordpress.com/2013/11/29/hallofbeorn-com-is-live/", "Fri, 29 Nov 2013 23:10:40 +0000")
                 .WithLabels("hallofbeorn.com", "Card Search", "Search Engine");
            AddLink("The Grey Company Podcast - Episode 2", "https://hallofbeorn.wordpress.com/2013/11/28/the-grey-company-podcast-episode-2/", "Thu, 28 Nov 2013 07:15:52 +0000");
            AddLink("Poll Results: Hardest Standard Scenario", "https://hallofbeorn.wordpress.com/2013/11/22/poll-results-hardest-standard-scenario/", "Fri, 22 Nov 2013 18:18:11 +0000")
                 .WithLabels("Escape from Dol Guldur", "Into Ithilien", "The Siege of Cair Andros", "Shadow and Flame", "The Battle of Five Armies", "Return to Mirkwood", "Dungeons Deep and Caverns Dim", "The Drúadan Forest", "The Druadan Forest");
            AddLink("Contest: A Very Good Tale", "https://hallofbeorn.wordpress.com/2013/11/21/contest-a-very-good-tale/", "Fri, 22 Nov 2013 01:07:12 +0000");
            AddLink("Key Concepts: Factions", "https://hallofbeorn.wordpress.com/2013/11/16/key-concepts-factions/", "Sat, 16 Nov 2013 19:06:39 +0000");
            AddLink("Community News - November 2013", "https://hallofbeorn.wordpress.com/2013/11/16/community-news-november-2013/", "Sat, 16 Nov 2013 08:50:37 +0000");
            AddLink("The Grey Company Podcast - Episode 1", "https://hallofbeorn.wordpress.com/2013/11/13/the-grey-company-podcast-episode-1/", "Wed, 13 Nov 2013 17:27:18 +0000");
            AddLink("Key Concepts: Timing", "https://hallofbeorn.wordpress.com/2013/11/01/key-concepts-timing/", "Fri, 01 Nov 2013 18:40:10 +0000");
            AddLink("Deck: Caldara's Sacrifice", "https://hallofbeorn.wordpress.com/2013/10/31/deck-caldaras-sacrifice/", "Thu, 31 Oct 2013 18:43:56 +0000")
                .WithDeckLabels(825);
            AddLink("The Grey Company", "https://hallofbeorn.wordpress.com/2013/10/30/the-grey-company/", "Wed, 30 Oct 2013 15:04:58 +0000")
                .WithLabels("Podcast", "Progression Series", "Master of Lore", "Tales from the Cards", "Hall of Beorn");
            AddLink("Custom Cards: The Fifth Sphere", "https://hallofbeorn.wordpress.com/2013/10/26/custom-cards-the-fifth-sphere/", "Sat, 26 Oct 2013 20:39:04 +0000")
                .WithLabels("Friendship", "Community");
            AddLink("Key Concepts: Shielding", "https://hallofbeorn.wordpress.com/2013/10/11/key-concepts-shielding/", "Fri, 11 Oct 2013 06:21:47 +0000");
            AddLink("Trouble at the Lonely Mountain", "https://hallofbeorn.wordpress.com/2013/10/07/trouble-at-the-lonely-mountain/", "Tue, 08 Oct 2013 01:56:35 +0000");
            AddLink("Poll Results: Favorite Core Set or Shadows of Mirkwood Scenario", "https://hallofbeorn.wordpress.com/2013/09/30/poll-results-favorite-coreshadows-of-mirkwood-scenario/", "Tue, 01 Oct 2013 04:59:42 +0000");
            AddLink("Deck: Keep It Secret, Keep It Safe", "https://hallofbeorn.wordpress.com/2013/09/28/deck-keep-it-secret-keep-it-safe/", "Sat, 28 Sep 2013 13:04:56 +0000")
                .WithDeckLabels(184);
            AddLink("Community News - September 2013", "https://hallofbeorn.wordpress.com/2013/09/23/community-news-september-2013/", "Mon, 23 Sep 2013 16:23:17 +0000");
            AddLink("Beorn's Path: Part 13 - Return to Mirkwood", "https://hallofbeorn.wordpress.com/2013/09/22/beorns-path-part-13-return-to-mirkwood/", "Mon, 23 Sep 2013 01:30:22 +0000")
                .WithDeckLabels(737);
            AddLink("Deck: Rangers and Traps", "https://hallofbeorn.wordpress.com/2013/09/18/deck-rangers-and-traps/", "Thu, 19 Sep 2013 00:46:28 +0000")
                .WithDeckLabels(826);
            AddLink("Beorn's Path: Part 12 - The Dead Marshes", "https://hallofbeorn.wordpress.com/2013/09/12/beorns-path-part-12-the-dead-marshes/", "Thu, 12 Sep 2013 23:24:53 +0000")
                .WithDeckLabels(736);
            AddLink("Troll of the Week: \"Ray Lunettes\"", "https://hallofbeorn.wordpress.com/2013/09/10/troll-of-the-week-ray-lunettes/", "Tue, 10 Sep 2013 20:29:14 +0000");
            AddLink("Poll Results: Most Wanted Character in The Black Riders", "https://hallofbeorn.wordpress.com/2013/09/09/poll-results-most-wanted-character-in-the-black-riders/", "Mon, 09 Sep 2013 06:11:56 +0000");
            AddLink("Custom Cards: The Might of Gondor", "https://hallofbeorn.wordpress.com/2013/09/05/custom-cards-the-might-of-gondor/", "Thu, 05 Sep 2013 21:58:48 +0000");
            AddLink("Beorn's Path: Part 11 - The Hills of Emyn Muil", "https://hallofbeorn.wordpress.com/2013/09/01/beorns-path-part-11-the-hills-of-emyn-muil/", "Mon, 02 Sep 2013 01:00:33 +0000")
                .WithDeckLabels(734);
            AddLink("Bear Market: Old Cards with New Relevance", "https://hallofbeorn.wordpress.com/2013/08/29/beorns-favorites-old-cards-with-new-relevance/", "Fri, 30 Aug 2013 00:32:37 +0000");
            AddLink("Contest Winner: Most Underrated Hero", "https://hallofbeorn.wordpress.com/2013/08/29/contest-winner-most-underrated-hero/", "Thu, 29 Aug 2013 05:47:51 +0000");
            AddLink("Bear Market: 5 Great Cards From Black Riders", "https://hallofbeorn.wordpress.com/2013/08/21/beorns-favorites-5-great-cards-from-black-riders/", "Wed, 21 Aug 2013 15:21:22 +0000");
            AddLink("Contest: Most Underrated Hero", "https://hallofbeorn.wordpress.com/2013/08/19/contest-most-underrated-hero/", "Mon, 19 Aug 2013 19:33:08 +0000");
            AddLink("Decks: GenCon 2013", "https://hallofbeorn.wordpress.com/2013/08/04/decks-gencon-2013/", "Sun, 04 Aug 2013 14:26:24 +0000");
            AddLink("Beorn's Path: Part 10 - A Journey to Rhosgobel", "https://hallofbeorn.wordpress.com/2013/07/28/beorns-path-part-10-a-journey-to-rhosgobel/", "Sun, 28 Jul 2013 17:41:21 +0000")
                .WithLabels("A Journey to Rhosgobel").WithDeckLabels(733);
            AddLink("Beorn's Path: Part 9 - Conflict at the Carrock", "https://hallofbeorn.wordpress.com/2013/07/22/beorns-path-part-9-conflict-at-the-carrock/", "Mon, 22 Jul 2013 20:13:10 +0000")
                 .WithLabels("Conflict at the Carrock", "Grimbeorn the Old").WithDeckLabels(732);
            AddLink("Game Variant: Wandering Kinsfolk", "https://hallofbeorn.wordpress.com/2013/07/13/game-variant-wandering-kinsfolk/", "Sat, 13 Jul 2013 06:27:42 +0000");
            AddLink("The Hunt for Gollum is Underway", "https://hallofbeorn.wordpress.com/2013/07/03/the-hunt-for-gollum-is-underway/", "Wed, 03 Jul 2013 19:01:58 +0000");
            AddLink("Deck: Prisoner of the Dark Forest", "https://hallofbeorn.wordpress.com/2013/07/03/deck-prisoner-of-the-dark-forest/", "Wed, 03 Jul 2013 08:02:04 +0000");
            AddLink("Deck: Reclaiming Khazad-dûm", "https://hallofbeorn.wordpress.com/2013/07/01/deck-reclaiming-khazad-dum/", "Mon, 01 Jul 2013 08:44:14 +0000");
            AddLink("Troll of the Week: \"Alice\"", "https://hallofbeorn.wordpress.com/2013/06/29/troll-of-the-week-alice/", "Sat, 29 Jun 2013 21:04:49 +0000");
            AddLink("Deck: Three Kings, a Queen, and a Prince", "https://hallofbeorn.wordpress.com/2013/06/28/deck-three-kings-a-queen-and-a-prince/", "Fri, 28 Jun 2013 16:33:17 +0000");
            AddLink("Play Report: Illuminating the Long Dark", "https://hallofbeorn.wordpress.com/2013/06/24/illuminating-the-long-dark/", "Tue, 25 Jun 2013 02:40:33 +0000")
                .WithLabels("Aragorn (leadership)", "Elrohir (leadership)", "Elladan (tactics)", "Glorfindel (spirit)", "Eleanor", "Eowyn (spirit)", "YouTube", "OCTGN", "Derek", "Master of Lore", "http://masteroflore.wordpress.com/2013/06/24/blood-of-numenor/");
            AddLink("Key Concepts: Affinity", "https://hallofbeorn.wordpress.com/2013/06/23/key-concepts-affinity/", "Sun, 23 Jun 2013 06:00:03 +0000");
            AddLink("Deck: The Grey Company Defends Gondor", "https://hallofbeorn.wordpress.com/2013/06/20/deck-the-grey-company-defends-gondor/", "Thu, 20 Jun 2013 05:01:45 +0000");
            AddLink("Contest Winner: Favorite Beorning", "https://hallofbeorn.wordpress.com/2013/06/19/contest-winner-favorite-beorning/", "Wed, 19 Jun 2013 05:21:22 +0000");
            AddLink("Deck: Magali Tribute", "https://hallofbeorn.wordpress.com/2013/06/13/deck-magali-tribute/", "Fri, 14 Jun 2013 00:52:35 +0000");
            AddLink("Contest: Favorite Beorning", "https://hallofbeorn.wordpress.com/2013/06/12/contest-favorite-beorning/", "Wed, 12 Jun 2013 07:22:25 +0000");
            AddLink("Poll Results: Favorite Deck Archetype", "https://hallofbeorn.wordpress.com/2013/06/11/poll-results-favorite-deck-archetype/", "Wed, 12 Jun 2013 03:00:57 +0000");
            AddLink("Deck: Beorn Attacks!", "https://hallofbeorn.wordpress.com/2013/06/11/deck-beorn-attacks/", "Tue, 11 Jun 2013 05:18:41 +0000");
            AddLink("Art: Beorn Attacks!", "https://hallofbeorn.wordpress.com/2013/06/06/beorn-attacks/", "Thu, 06 Jun 2013 16:49:40 +0000");
            AddLink("Recipe: Beorn's Honey Cakes", "https://hallofbeorn.wordpress.com/2013/06/05/recipe-beorns-honey-cakes/", "Wed, 05 Jun 2013 21:02:30 +0000");
            AddLink("Play Report: Vanquishing the Steward's Fear!", "https://hallofbeorn.wordpress.com/2013/06/04/vanquishing-the-stewards-fear/", "Wed, 05 Jun 2013 02:07:04 +0000");
            AddLink("Contest: Create a Beorning", "https://hallofbeorn.wordpress.com/2013/06/04/contest-create-a-beorning/", "Tue, 04 Jun 2013 15:59:18 +0000");
            AddLink("Deck: Masters of the Forest", "https://hallofbeorn.wordpress.com/2013/06/02/deck-masters-of-the-forest/", "Mon, 03 Jun 2013 00:08:28 +0000");
            AddLink("Deck: The Field of Cormallen", "https://hallofbeorn.wordpress.com/2013/05/31/deck-the-field-of-cormallen/", "Fri, 31 May 2013 07:12:47 +0000");
            AddLink("Deck: Isildur's Heir", "https://hallofbeorn.wordpress.com/2013/05/28/deck-isildurs-heir/", "Tue, 28 May 2013 08:38:42 +0000");
            AddLink("Metagame: Part 3 - Traits and Choice", "https://hallofbeorn.wordpress.com/2013/05/27/metagame-part-3-traits-and-choice/", "Mon, 27 May 2013 23:50:23 +0000");
            AddLink("Poll Results: Most Wanted Attachment", "https://hallofbeorn.wordpress.com/2013/05/24/poll-results-most-wanted-attachment/", "Sat, 25 May 2013 01:26:58 +0000");
            AddLink("Deck: Flight to the Ford", "https://hallofbeorn.wordpress.com/2013/05/19/deck-flight-to-the-ford/", "Sun, 19 May 2013 19:36:49 +0000");
            AddLink("Custom Cards: Most Wanted Attachments", "https://hallofbeorn.wordpress.com/2013/04/10/custom-cards-most-wanted-attachments/", "Wed, 10 Apr 2013 10:02:52 +0000");
            AddLink("Beorn's Path: Part 8 - Playtesting (The Hunt For Gollum)", "https://hallofbeorn.wordpress.com/2013/04/08/beorns-path-part-8-playtesting-the-hunt-for-gollum/", "Mon, 08 Apr 2013 07:45:45 +0000")
                .WithDeckLabels(306);;
            AddLink("News: The Future of the Hall of Beorn", "https://hallofbeorn.wordpress.com/2013/04/01/news-the-future-of-the-hall-of-beorn/", "Mon, 01 Apr 2013 15:15:40 +0000")
                .WithLabels("April 1st");
            AddLink("Deck: Two Kingdoms Reunited", "https://hallofbeorn.wordpress.com/2013/03/31/deck-two-kingdoms-reunited/", "Sun, 31 Mar 2013 22:56:46 +0000");
            AddLink("Deck: Háma Takes Archery Lessons", "https://hallofbeorn.wordpress.com/2013/03/28/deck-hama-takes-archery-lessons/", "Fri, 29 Mar 2013 02:16:43 +0000");
            AddLink("Poll Results: Most Wanted Ally Card", "https://hallofbeorn.wordpress.com/2013/03/24/poll-results-most-wanted-ally-card/", "Sun, 24 Mar 2013 21:14:30 +0000");
            AddLink("Deck: Bard Goes Hunting", "https://hallofbeorn.wordpress.com/2013/03/16/deck-bard-goes-hunting/", "Sat, 16 Mar 2013 23:15:23 +0000");
            AddLink("Key Concepts: 5 Shadow Effects to Beware Of", "https://hallofbeorn.wordpress.com/2013/03/08/5-shadow-effects-to-beware-of/", "Fri, 08 Mar 2013 02:17:30 +0000");
            AddLink("Metagame: Part 2 - Errata", "https://hallofbeorn.wordpress.com/2013/03/01/metagame-part-2-errata/", "Fri, 01 Mar 2013 13:43:11 +0000");
            AddLink("Beorn's Path: Part 7 - Deck Tuning (The Hunt For Gollum)", "https://hallofbeorn.wordpress.com/2013/02/26/beorns-path-part-7-deck-tuning-the-hunt-for-gollum/", "Tue, 26 Feb 2013 01:55:59 +0000")
                .WithDeckLabels(306);
            AddLink("Poll Results: How do you play the game?", "https://hallofbeorn.wordpress.com/2013/02/20/poll-results-how-do-you-play-the-game/", "Wed, 20 Feb 2013 18:14:32 +0000");
            AddLink("Key Concepts: Efficiency", "https://hallofbeorn.wordpress.com/2013/02/19/key-concepts-efficiency/", "Wed, 20 Feb 2013 00:41:31 +0000");
            AddLink("Art: Does Asfaloth Fear the Witch-King? Naaaaay!!!", "https://hallofbeorn.wordpress.com/2013/02/18/does-asfaloth-fear-the-witch-king-naaaaay/", "Mon, 18 Feb 2013 20:23:18 +0000");
            AddLink("Deck: The Island of Misfit Heroes", "https://hallofbeorn.wordpress.com/2013/02/18/deck-the-island-of-misfit-heroes/", "Mon, 18 Feb 2013 17:13:16 +0000");
            AddLink("Key Concepts: Force Multiplication", "https://hallofbeorn.wordpress.com/2013/02/16/key-concepts-force-multiplication/", "Sat, 16 Feb 2013 10:22:10 +0000")
                .WithLabels("A Very Good Tale", "Boromir (tactics hero)", "Rohan", "Snowbourn Scout", "Escort From Edoras", "Faramir (leadership ally)", "Astonishing Speed")
                .WithLabels("Dain Ironfoot (leadership)", "Dori", "Longbeard Orc Slayer", "Erebor Battle Master", "Lure of Moria", "Ori", "Thorin Oakenshield", "King Under the Mountain")
                .WithLabels("Boromir (leadership hero)", "Errand-rider", "Citadel Custodian", "For Gondor!", "Unexpected Courage", "Cram", "Ellada (tactics)", "Elrohir (leadership)", "Light the Beacon", "Miruvor", "Grim Resolve");
            AddLink("Art: What I Did On My Vacation to Erebor", "https://hallofbeorn.wordpress.com/2013/02/13/what-i-did-on-my-vacation-to-erebor/", "Wed, 13 Feb 2013 20:40:00 +0000")
                .WithLabels("Justin Gerard", "http://quickhidehere.blogspot.com/");
            AddLink("Deck: Balin Holds the Line", "https://hallofbeorn.wordpress.com/2013/02/12/deck-balin-holds-the-line/", "Tue, 12 Feb 2013 23:33:05 +0000")
                .WithDeckLabels(842);
            AddLink("Beorn's Path: Part 6 - Escape from Dol Guldur", "https://hallofbeorn.wordpress.com/2013/02/12/beorns-path-part-6-escape-from-dol-guldur/", "Tue, 12 Feb 2013 18:24:39 +0000")
                .WithDeckLabels(307);
            AddLink("New Lord of the Rings LCG Blog: Master of Lore", "https://hallofbeorn.wordpress.com/2013/02/12/new-lord-of-the-rings-lcg-blog-master-of-lore/", "Tue, 12 Feb 2013 07:49:31 +0000")
                .WithLabels("Master of Lore", "Blog");
            AddLink("Game Variant: The Song of Tom Bombadil", "https://hallofbeorn.wordpress.com/2013/02/08/game-variant-the-song-of-tom-bombadil/", "Fri, 08 Feb 2013 23:29:28 +0000")
                .WithLabels("Game Variant", "Community");
            AddLink("Deck: The Rohirrim Ride with the Grey Company", "https://hallofbeorn.wordpress.com/2013/02/08/deck-the-rohirrim-ride-with-the-grey-company/", "Fri, 08 Feb 2013 01:05:30 +0000")
                .WithDeckLabels(827);
            AddLink("Beorn's Path: Part 5 - Building a Second Core Set Deck", "https://hallofbeorn.wordpress.com/2013/02/06/beorns-path-part-5-building-a-second-core-set-deck/", "Wed, 06 Feb 2013 17:56:54 +0000")
                .WithDeckLabels(307);
            AddLink("Deck: The Power of the Palantir", "https://hallofbeorn.wordpress.com/2013/02/05/deck-the-power-of-the-palantir/", "Tue, 05 Feb 2013 19:35:58 +0000")
                .WithDeckLabels(828);
            AddLink("Beorn's Path: Part 4 - Journey Along the Anduin", "https://hallofbeorn.wordpress.com/2013/02/04/beorns-path-part-4-journey-along-the-anduin/", "Mon, 04 Feb 2013 07:57:22 +0000")
                .WithDeckLabels(305);
            AddLink("Bear Market: 5 Fun Cards With Surprising Utility", "https://hallofbeorn.wordpress.com/2013/02/02/5-fun-cards-with-surprising-utility/", "Sat, 02 Feb 2013 06:42:48 +0000")
                .WithLabels("Radagast (ally)", "Campfire Tales", "Song of Mocking", "Rider of the Mark", "Love of Tales");
            AddLink("Beorn's Path: Part 3 - Deck Tuning", "https://hallofbeorn.wordpress.com/2013/01/31/beorns-path-part-3-deck-tuning/", "Thu, 31 Jan 2013 21:32:23 +0000")
                .WithDeckLabels(305);
            AddLink("Deck: Lore Mastery", "https://hallofbeorn.wordpress.com/2013/01/31/deck-lore-mastery/", "Thu, 31 Jan 2013 19:21:41 +0000")
                .WithDeckLabels(751);
            AddLink("Poll Results: Which Play Style(s) Are You?", "https://hallofbeorn.wordpress.com/2013/01/31/poll-results-which-play-styles-are-you/", "Thu, 31 Jan 2013 06:15:07 +0000")
                .WithLabels("Play Style", "Community", "Theme", "Cooperation", "Power", "Fun", "Competition");
            AddLink("Decks: Dwarves at the Circus", "https://hallofbeorn.wordpress.com/2013/01/30/decks-dwarves-at-the-circus/", "Wed, 30 Jan 2013 16:40:01 +0000")
                .WithDeckLabels(739, 740);
            AddLink("Metagame: Part 1 - Current State and Future Direction of Lord of the Rings LCG", "https://hallofbeorn.wordpress.com/2013/01/29/metagame-part-1-current-state-and-future-direction-of-lord-of-the-rings-lcg/", "Wed, 30 Jan 2013 03:56:29 +0000")
                .WithLabels("Heirs of Númenor", "Heirs of Numenor", "Difficulty", "Tactics", "sphere balance", "Battle", "Siege", "The Redhorn Gate", "Beregond", "Hama", "Beorn", "Thicket of Spears")
                .WithLabels("Ranger Spikes", "Master of Lore", "Core Set", "out of the box", "new players");
            AddLink("Key Concepts: Play Style", "https://hallofbeorn.wordpress.com/2013/01/28/key-concepts-play-style/", "Mon, 28 Jan 2013 10:02:16 +0000")
                .WithLabels("Multiplayer", "Solo", "Support", "Theme", "Combo", "Power", "Fun");
            AddLink("Deck: Location Control", "https://hallofbeorn.wordpress.com/2013/01/28/deck-location-control/", "Mon, 28 Jan 2013 03:58:36 +0000")
                .WithDeckLabels(738);
            AddLink("Beorn's Path: Part 2 - Playtesting", "https://hallofbeorn.wordpress.com/2013/01/25/beorns-path-part-2-playtesting/", "Fri, 25 Jan 2013 22:20:57 +0000")
                .WithDeckLabels(305);
            AddLink("Beorn's Path: Part 1 - Core Set Deck Building", "https://hallofbeorn.wordpress.com/2013/01/24/beorns-path-part-1-core-set-deck-building/", "Thu, 24 Jan 2013 08:05:59 +0000")
                .WithDeckLabels(293);
            AddLink("Deck: Gluttony", "https://hallofbeorn.wordpress.com/2013/01/23/deck-gluttony/", "Wed, 23 Jan 2013 19:20:02 +0000")
                .WithDeckLabels(660);
            AddLink("Deck: Boromir and the Seven Dwarves", "https://hallofbeorn.wordpress.com/2013/01/22/deck-boromir-and-the-seven-dwarves/", "Tue, 22 Jan 2013 20:02:05 +0000")
                .WithDeckLabels(659);
            AddLink("Bear Market: Who would I most want to have my back in a bar fight?", "https://hallofbeorn.wordpress.com/2013/01/21/who-would-i-most-want-to-have-my-back-in-a-bar-fight/", "Mon, 21 Jan 2013 19:44:52 +0000")
                .WithLabels("Eowyn (spirit)", "Denethor (lore)", "Gloin (hero)", "Boromir (tactics hero)");
            AddLink("Deck: Vilya, The Ring of Air", "https://hallofbeorn.wordpress.com/2013/01/19/deck-vilya-the-ring-of-air/", "Sat, 19 Jan 2013 05:08:04 +0000")
                .WithDeckLabels(645);
            AddLink("Key Concepts: Versatility", "https://hallofbeorn.wordpress.com/2013/01/18/key-concepts-versatility/", "Fri, 18 Jan 2013 23:02:42 +0000")
                .WithLabels("Gandalf (core)", "Dúnedain Warning", "Dunedain Warning", "Feint", "Miruvor", "Aragorn (lore)", "Imladris Stargazer", "Gildor Inglorion (lore)", "Denethor (lore)", "Henamarth Riverson", "Out of the Wild", "Dark Knowledge", "Dawn Take You All", "A Burning Brand", "We Are Not Idle");
            AddLink("Poll Results: Most Wanted Hero Card", "https://hallofbeorn.wordpress.com/2013/01/17/poll-results-most-wanted-hero-card/", "Thu, 17 Jan 2013 18:02:31 +0000")
                .WithLabels("Galadriel (hero)", "Faramir (hero)", "Sam Gamgee (hero)", "Halbarad (hero)", "Éomer", "Eomer", "Théoden", "Theoden", "Celeborn");
            AddLink("Decks: Direct Damage", "https://hallofbeorn.wordpress.com/2013/01/16/decks-direct-damage/", "Wed, 16 Jan 2013 00:19:20 +0000")
                .WithDeckLabels(642, 643);
            AddLink("Bear Market: 5 Overlooked Events for Heirs of Númenor", "https://hallofbeorn.wordpress.com/2013/01/15/5-overlooked-events-for-heirs-of-numenor/", "Tue, 15 Jan 2013 21:28:02 +0000")
                .WithLabels("Shadow of the Past", "Durin's Song", "Swift Strike", "A Watchfule Peace", "Out of the Wild");
            AddLink("Decks: Renewed Friendships", "https://hallofbeorn.wordpress.com/2013/01/14/decks-renewed-friendships/", "Mon, 14 Jan 2013 19:15:48 +0000")
                .WithDeckLabels(640, 641);
            AddLink("Deck: Secrets of Erebor 2", "https://hallofbeorn.wordpress.com/2013/01/12/deck-secrets-of-erebor-2/", "Sat, 12 Jan 2013 07:26:15 +0000")
                .WithDeckLabels(631, 632);
            AddLink("Key Concepts: Traits - Dwarf", "https://hallofbeorn.wordpress.com/2013/01/11/key-concepts-traits-dwarf/", "Sat, 12 Jan 2013 05:49:48 +0000")
                .WithLabels("Dwarf", "Dain Ironfoot", "Lure of Moria", "Hardy Leadership", "Thorin Oakenshield", "Ori", "Nori", "Bofur", "Fili", "Kili", "Erebor Record Keeper", "Erebor Battle Master", "Legacy of Durin", "We Are Not Idle");
            AddLink("Key Concepts: Support", "https://hallofbeorn.wordpress.com/2013/01/09/key-concepts-support/", "Wed, 09 Jan 2013 21:33:05 +0000")
                .WithLabels("Gimli", "Song of Wisdom", "Steward of Gondor", "Horn of Gondor", "Aragorn (lore)", "Beravor", "Frodo Baggins (spirit)", "Gleowine", "Warden of Healing", "Erebor Hammersmith", "Henamarth Riversong", "Imladris Stargazer", "Master of the Forge", "Master of Lore", "Ithilien Tracker", "Mirkwood Runner", "Northern Tracker", "Haldir of Lorien (ally)", "Gildor Inglorion (ally)")
                .WithLabels("Asfaloth", "Miruvor", "Protector of Lorien", "A Burning Brand", "Unexpected Courage", "Ranger Spikes", "Forest Snare", "Fast Hitch", "Song of Travel", "Daeron's Runes", "A Test of Will", "The Galadhrim's Greeting", "Radagast's Cunning", "Secret Paths", "Gildor's Counsel");
            AddLink("Decks: Battle of the Pelennor Fields", "https://hallofbeorn.wordpress.com/2013/01/09/decks-battle-of-the-pelennor-fields/", "Wed, 09 Jan 2013 00:07:40 +0000")
                .WithLabels("Aragorn (leadership)", "Prince Imrahil (leadership)", "Eowyn (spirit)", "Errand-rider", "Snowbourn Scout", "Westfold Horse-Breaker", "Escort from Edoras", "The Riddermark's Finest", "Dunedain Watcher", "Son of Arnor", "Elfhelm", "Faramir", "Gandalf (core)", "Steward of Gondor", "Dunedain Warning", "Celebrian's Stone", "Blood of Numenor", "Unexpected Courage", "Sword That Was Broken", "Wealth of Gondor", "Sneak Attack", "A Test of Will", "For Gondor!", "Hasty Stroke", "Mutual Accord", "Astonishing Speed", "We Do Not Sleep", "Light the Beacons")
                .WithLabels("Denethor (lore)", "Beregond (tactics)", "Gimli (tactics)", "Envoy of Pelargir", "Defender of Rammas", "Gondorian Spearman", "Horseback Archer", "Warden of Healing", "Ithilien Tracker", "Gleowine", "Gandalf (core)", "Horn of Gondor", "Citadel Plate", "Spear of the Citadel", "Blade of Gondolin", "A Burning Brand", "Dark Knowledge", "Song of Battle", "Feint", "Behind Strong Walls", "Foe-Hammer", "Quick Strike", "Swift Strike", "Thicket of Spears", "Peace, and Thought");
            AddLink("Deck: Secrets of Erebor", "https://hallofbeorn.wordpress.com/2013/01/07/deck-secrets-of-erebor/", "Mon, 07 Jan 2013 22:22:43 +0000")
                .WithDeckLabels(632);
            AddLink("Key Concepts: Roles", "https://hallofbeorn.wordpress.com/2013/01/07/key-concepts-roles/", "Mon, 07 Jan 2013 19:22:54 +0000")
                .WithLabels("Gleowine", "Imladris Stargazer", "Erebor Record Keeper", "Beorn (hero)", "Eowyn (spirit)", "Astonishing Speed", "We Do Not Sleep", "Eomund", "Beregond (tactics)", "Spear of the Citadel", "Citadel Plate", "Legolas (tactics)", "Hands Upon the Bow", "Quick Strike", "Behind Strong Walls", "Dain Ironfoot", "Aragorn (leadership)", "Glorfindel (lore)", "Elrond", "Elladan (tactics)", "Elrohir (leadership)", "Glorfindel (spirit)", "Rivendell Blade", "Light of Valinor", "Celebrian's Stone")
                .WithLabels("Errand-rider", "Trollshaw Scout", "Watcher of the Bruinen", "Silverlode Archer", "Dunedain Watcher", "Arwen Undomiel (ally)", "Imladris Stargazer", "Erestor (ally)", "Gandalf (core)", "Steward of Gondor", "Horn of Gondor", "Dunedain Warning", "Rivendell Blade", "Unexpected Courage", "Light of Valinor", "Song of Battle", "Song of Travel", "Elrond's Counsel", "A Test of Will", "Hasty Stroke", "Feint", "Sneak Attack");
            AddLink("Key Concepts: Synergy", "https://hallofbeorn.wordpress.com/2013/01/05/key-concepts-synergy/", "Sun, 06 Jan 2013 01:26:42 +0000")
                .WithLabels("Secret Paths", "Radagast's Cunning", "Erebor Hammersmith", "Dain Ironfoot (leadership)", "Bifur (lore hero)", "Ori", "Cram", "Erebor Record Keeper", "A Burning Brand", "Descendant of Thorondor", "Born Aloft", "Eagles of the Misty Mountains", "Sneak Attack");
            AddLink("Key Concepts: Pace", "https://hallofbeorn.wordpress.com/2013/01/04/key-concepts-pace/", "Fri, 04 Jan 2013 21:59:01 +0000")
                .WithLabels("Into Ithilien", "Asfaloth", "Northern Tracker", "Thror's Map", "Strider's Path", "Dain Ironfoot", "Elrond", "Dunhere", "Hail of Stones", "Hands Upon the Bow", "Winged Guardian", "Gloin", "Gimli")
                .WithLabels("Son of Arnor", "Thalin", "Dunedain Cache", "Háma", "Hama", "Celador (objective)", "Boromir", "Unexpected Courage", "Cram", "Miruvor", "Erebor Record Keeper", "Hasty Stroke", "Self Preservation")
                .WithLabels("Vassal of the Windlord", "A Test of Will", "Eleanor", "Vilya", "Imladris Stargazer", "Gildor Inglorion", "Citadel Plate", "Ring Mail", "Master of the Forge", "Daeron's Runes");
            AddLink("Welcome to the Hall of Beorn", "https://hallofbeorn.wordpress.com/2013/01/04/welcome-to-the-hall-of-beorn/", "Fri, 04 Jan 2013 18:34:17 +0000");
        }
    }
}