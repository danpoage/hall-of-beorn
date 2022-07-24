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
            AddLink("Guardian of Esgaroth Community Review", "https://cardtalk2018.com/2022/07/21/guardian-of-esgaroth-community-review/", "Jul 21 2022")
                .WithLabels("Guardian of Esgaroth");
            AddLink("Encounter at Amon Din with Mono-Tactics – October 19, 2019", "https://cardtalk2018.com/2022/07/20/encounter-at-amon-din-with-mono-tactics-october-19-2019/", "Jul 20 2022")
                .WithLabels("Encounter at Amon Din").WithDeckLabels(12992);
            AddLink("Fellowship of the Ring", "https://cardtalk2018.com/2022/07/19/fellowship-of-the-ring/", "Jul 19 2022")
                .WithLabels("Fellowship of the Ring").WithDeckLabels(16864).WithDeckLabels(8835).WithDeckLabels(6252);
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
                .WithLabels("Windfola", "Eowyn", "Merry", "Forth, the Three Hunters", "Golden Belt", "Armored Destrier", "Elfhelm");
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
                .WithLabels("Aragor", "Arwen Undomiel", "Arwen Undómiel", "Beravor");
            AddLink("Drinking Song", "https://cardtalk2018.com/2022/06/28/drinking-song/", "Jun 28 2022")
                .WithLabels("Drinking Song", "Daeron's Runes", "Gandalf's Search", "Deep Knowledge", "Mithrandir's Advice", "Peace, and Thought", "Erestor", "Love of Tales", "Master of Lore", "Scroll of Isildur", "Erebor Hammersmith", "Council of the Wise");
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