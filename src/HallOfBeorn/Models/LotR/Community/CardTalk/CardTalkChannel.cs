using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace HallOfBeorn.Models.LotR.Community.CardTalk
{
    public class CardTalkChannel
        : Creator
    {
        public CardTalkChannel()
            : base("Card Talk Channel",
            "https://www.youtube.com/channel/UCj-QcL_YcA_DQKe7bSe9byA",
            "https://www.youtube.com/feeds/videos.xml?channel_id=UCj-QcL_YcA_DQKe7bSe9byA",
            LinkType.Card_Talk)
        {
            AddYear(2022);
            AddLink("Second Breakfast: An LotR LCG Live Play Series - Challenge #13", "https://www.youtube.com/watch?v=oJJaKG9SSRk", "Sep 25, 2022")
                .WithLabels("Challenge #13");
            AddLink("Dunedain Hunter", "https://www.youtube.com/watch?v=JX3iwjAddFg", "Sep 21, 2022")
                .WithLabels("Dunedain Hunter");
            AddLink("First Play of the Black Gate Opens", "https://www.youtube.com/watch?v=-M4QEbfrEgs", "Sep 15, 2022")
                .WithLabels("The Gate Opens");
            AddLink("Hero Halbarad", "https://www.youtube.com/watch?v=oUBC8sk2B-o", "Sep 6, 2022")
                .WithLabels("Halabarad (hero)");
            AddLink("The Shirefolk", "https://www.youtube.com/watch?v=Milz_U0MvwQ", "Aug 30, 2022")
                .WithLabels("The Shirefolk");
            AddLink("Second Breakfast: An LotR LCG Live Play Series - Challenge #12", "https://www.youtube.com/watch?v=8KzgqkV5hMo", "Aug 28, 2022")
                .WithLabels("Challenge #12");
            AddLink("Second Breakfast: An LotR LCG Live Play Series - Challenge #12 (part 2)", "https://www.youtube.com/watch?v=yse8mekLuPQ", "Aug 28, 2022")
                .WithLabels("Challenge #12");
            AddLink("The Siege of Gondor - THEATRICAL CAMPAIGN", "https://www.youtube.com/watch?v=tqoUMqpTU7o", "Aug 25, 2022")
                .WithLabels("The Siege of Gondor", "Campagin");
            AddLink("The Siege of Gondor - Note quite good enough", "https://www.youtube.com/watch?v=sgmoJTDYCIs", "Aug 18, 2022")
                .WithLabels("The Siege of Gondor");
            AddLink("Halfling Determination", "https://www.youtube.com/watch?v=O6xUKdeHLwo", "Aug 16, 2022")
                .WithLabels("Halfling Determination");
            AddLink("Second Breakfast: An LotR LCG Live Play Series - Challenge #11", "https://www.youtube.com/watch?v=GOAMXwXobrU", "Aug 14, 2022")
                .WithLabels("Challenge #11");
            AddLink("The Siege of Gondor - 10 Rounds", "https://www.youtube.com/watch?v=Pd8Zwkl1PNw", "Aug 11, 2022")
                .WithLabels("The Siege of Gondor");
            AddLink("Dwarven Tomb", "https://www.youtube.com/watch?v=Nr5opj9LnxA", "Aug 9, 2022")
                .WithLabels("Dwarven Tomb");
            AddLink("The Siege of Gondor - 8 Rounds", "https://www.youtube.com/watch?v=HzuL-lA5pEE", "Aug 4, 2022")
                .WithLabels("The Siege of Gondor");
            AddLink("Second Breakfast: An LotR LCG Live Play Series - Challenge #10", "https://www.youtube.com/watch?v=v8ak5ZDL-Jk", "Jul 31, 2022")
                .WithLabels("Challenge #10");
            AddLink("The Siege of Gondor - Misplay", "https://www.youtube.com/watch?v=HCXgkiPnmao", "Jul 28, 2022")
                .WithLabels("The Siege of Gondor");
            AddLink("Hobbit Cloak", "https://www.youtube.com/watch?v=owoCptVsJeg", "Jul 26, 2022")
                .WithLabels("Hobbit Cloak");
            AddLink("Passing of the Grey Company - THEATRICAL CAMPAIGN", "https://www.youtube.com/watch?v=Z_s4iaf3Qz8", "Jul 21, 2022")
                .WithLabels("Passing of the Grey Company", "Campaign");
            AddLink("Shelob's Lair - THEATRICAL CAMPAIGN", "https://www.youtube.com/watch?v=_rhrmwGmWuY", "JUl 14, 2022")
                .WithLabels("Shelob's Lair", "Campaign");
            AddLink("Ally Quickbeam", "https://www.youtube.com/watch?v=_ppZuuuG6wE", "Jul 13, 2022")
                .WithLabels("Quickbeam (ally)");
            AddLink("Journey to the Cross-roads - THEATRICAL CAMPAIGN", "https://www.youtube.com/watch?v=0ccD3Gb5Ufw", "Jul 7, 2022")
                .WithLabels("Journey to the Cross-roads", "Campaign");
            AddLink("Second Breakfast: An LotR LCG Live Play Series - Challenge #9", "https://www.youtube.com/watch?v=RKKROBp3KEQ", "Jul 3, 2022")
                .WithLabels("Challenge #9");
            AddLink("Passage of the Marshes - THEATRICAL CAMPAIGN", "https://www.youtube.com/watch?v=LpiEMy_h6i4", "Jun 30, 2022")
                .WithLabels("Passage of the Marshes", "Campaign");
            AddLink("Drinking Song", "https://www.youtube.com/watch?v=LpiEMy_h6i4", "Jun 28, 2022")
                .WithLabels("Drinking Song");
            AddLink("The Road to Isengard - THEATRICAL CAMPAIGN", "https://www.youtube.com/watch?v=ogkDP4dge5s", "Jun 23, 2022")
                .WithLabels("The Road to Isengard", "Campaign");
            AddLink("Tactics Pippin Ally", "https://www.youtube.com/watch?v=jEjG025aS_I", "Jun 22, 2022")
                .WithLabels("Pippin (Tactics Ally)");
            AddLink("Second Breakfast: An LotR LCG Live Play Series - Challenge #8", "https://www.youtube.com/watch?v=vBqvoB9_u_w", "Jun 19, 2022")
                .WithLabels("Challenge #8");
            AddLink("Helm's Deep - THEATRICAL CAMPAIGN", "https://www.youtube.com/watch?v=ug4KPueH8q4", "Jun 16, 2022")
                .WithLabels("Helm's Deep", "Campaign");
            AddLink("Honour Guard", "https://www.youtube.com/watch?v=2Bhn9cKhxpA", "Jun 16, 2022")
                .WithLabels("Honour Guard");
            AddLink("The Uruk-hai - THEATRICAL CAMPAIGN (misplay)", "https://www.youtube.com/watch?v=dOMAfuV4Enw", "Jun 9, 2022")
                .WithLabels("The Uruk-hai", "Campaign");
            AddLink("The Uruk-hai - THEATRICAL CAMPAIGN", "https://www.youtube.com/watch?v=57hsXkiE7Bk", "Jun 9, 2022")
                .WithLabels("The Uruk-hai", "Campaign");
            AddLink("Second Breakfast: An LotR LCG Live Play Series - Challenge #7", "https://www.youtube.com/watch?v=1T8eg0adAGg", "Jun 5, 2022")
                .WithLabels("Challenge #7");
            AddLink("Breaking of the Fellowship - THEATRICAL CAMPAIGN", "https://www.youtube.com/watch?v=3sIxgGG1GEc", "Jun 2, 2022")
                .WithLabels("Breaking of the Fellowship", "Campaign");
            AddLink("Curious Brandybuck", "https://www.youtube.com/watch?v=hCRdhE8wAh4", "May 31, 2022")
                .WithLabels("Curious Brandybuck");
            AddLink("A Journey in the Dark - THEATRICAL CAMPAIGN", "https://www.youtube.com/watch?v=ns6pbXon7gw&t=331s", "May 26, 2022")
                .WithLabels("A Journey in the Dark", "Campaign");
            AddLink("A Journey in the Dark - THEATRICAL CAMPAIGN (misplay)", "https://www.youtube.com/watch?v=EVQt8wjf5Jk", "May 26, 2022")
                .WithLabels("A Journey in the Dakr", "Campaign");
            AddLink("Bill the Pony", "https://www.youtube.com/watch?v=U-gx9ZWUPZs", "May 24, 2022")
                .WithLabels("Bill the Pony");
            AddLink("Second Breakfast: An LotR LCG Live Play Series - Challenge #6", "https://www.youtube.com/watch?v=vcLxQaqcZOw", "May 22, 2022")
                .WithLabels("Challenge #6");
            AddLink("The Rings Goes South - THEATRICAL CAMPAIGN", "https://www.youtube.com/watch?v=ZkkVYfRhY7M&t=46s", "May 19, 2022")
                .WithLabels("The Ring Goes South", "Campaign");
            AddLink("Guest Host Joe Holme AKA The Purple Wizard", "https://www.youtube.com/watch?v=PhDMV5KAVVo", "May 18, 2022")
                .WithLabels("The Purple Wizard", "Reinforcements");
            AddLink("Flight to the Ford - THEATRICAL CAMPAIGN", "https://www.youtube.com/watch?v=5hD6OILzbig", "May 12, 2022")
                .WithLabels("Flight to the Ford", "Campaign");
            AddLink("The Great Hunt", "https://www.youtube.com/watch?v=2EXX4ObM4z0", "May 11, 2022")
                .WithLabels("The Great Hunt");
            AddLink("Second Breakfast: An LotR LCG Live Play Series - Challenge #5", "https://www.youtube.com/watch?v=OdoI-_07U9o", "May 8, 2022")
                .WithLabels("Challenge #5");
            AddLink("A Knife in the Dark - THEATRICAL CAMPAIGN", "https://www.youtube.com/watch?v=pkYJAWTnqJ4", "May 5, 2022")
                .WithLabels("A Knife in the Dark", "Campaign");
            AddLink("Fog on the Barrow Downs - THEATRICAL CAMPAIGN", "https://www.youtube.com/watch?v=sxRClepE9ho", "Apr 28, 2022")
                .WithLabels("Fog on the Barrow Downs", "Campaign");
            AddLink("Guest Host Matthew Dempsey", "https://www.youtube.com/watch?v=gaHP8k8-i_U", "Apr 26, 2022")
                .WithLabels("Matthew Dempsey", "Gwaihir (hero)");
            AddLink("(GIVEAWAY!!) Second Breakfast: An LotR LCG Live Play Series - Challenge #4", "https://www.youtube.com/watch?v=rjlQvQ93BRs", "Apr 24, 2022")
                .WithLabels("Challenge #4", "GIVEAWAY");
            AddLink("The Old Forest - THEATRICAL CAMPAIGN", "https://www.youtube.com/watch?v=oFgos_hpVKE", "Apr 21, 2022")
                .WithLabels("The Old Forest", "Campaign");
            AddLink("Shadow of the Past - THEATRICAL CAMPAIGN", "https://www.youtube.com/watch?v=8cDLMA5cbeM", "Apr 14, 2022")
                .WithLabels("Shadow of the Past", "Campaign");
            AddLink("Gleowine", "https://www.youtube.com/watch?v=Sly5ZLQnCFw", "Apr 13, 2022")
                .WithLabels("Gleowine");
            AddLink("Second Breakfast: An LotR LCG Live Play Series - Challenge #3", "https://www.youtube.com/watch?v=nArDtBFmVI0", "Apr 10, 2022")
                .WithLabels("Challenge #3");
            AddLink("Erebor Hammersmith", "https://www.youtube.com/watch?v=HVIfaAUOcIM", "Apr 5, 2022")
                .WithLabels("Erebor Hammersmith");
            AddLink("Quick Strike and Dunhere", "https://www.youtube.com/watch?v=LnTuHz1AFCk", "Mar 31, 2022")
                .WithLabels("Quick Strike", "Dunhere");
            AddLink("Guest Host Tyler Parrott", "https://www.youtube.com/watch?v=gMg7ZJ4Tlms", "May 29, 2022")
                .WithLabels("Anarmar Awakened Campaign");
            AddLink("Gloin and Self Preservation", "https://www.youtube.com/watch?v=cKEv9abC5jc", "Mar 26, 2022")
                .WithLabels("Gloin", "Self Preservation");
            AddLink("Horseback Archer", "https://www.youtube.com/watch?v=uD5s4Er44KA", "Mar 22")
                .WithLabels("Horseback Archer");
            AddLink("Second Breakfast: An LotR LCG Live Play Series - Challenge #2", "https://www.youtube.com/watch?v=IAekPpwr62M", "Mar 20, 2022")
                .WithLabels("Challenge #2");
            AddLink("Eowyn and Stand and Fight", "https://www.youtube.com/watch?v=6nPm3rB6or8", "Mar 19, 2022")
                .WithLabels("Eowyn", "Stand and Fight");
            AddLink("Wrap-up of New Player February", "https://www.youtube.com/watch?v=KqtQINNYx0o", "Mar 15, 2022")
                .WithLabels("New Players");
            AddLink("Gimli with Citadel Plate", "https://www.youtube.com/watch?v=wM9INRcHSsQ", "Mar 14, 2022")
                .WithLabels("Gimli", "Citadel Plate");
            AddLink("Designer Caleb Grace Talks Revised Core Set", "https://www.youtube.com/watch?v=Sr6KFOrhQcU", "Mar 8, 2022")
                .WithLabels("Caleb Grace", "Revised Core Set");
            AddLink("Second Breakfast: An LotR LCG Live Play Series - Challenge #1", "https://www.youtube.com/watch?v=77PD3iiawgk", "Mar 6, 2022")
                .WithLabels("Challenge #1");
            AddLink("Sneaky Beorn", "https://www.youtube.com/watch?v=VDG7SysHobo", "Mar 2, 2022")
                .WithLabels("Sneak Attack", "Beorn", "Core Set", "Combo");
            AddLink("Designer Jeremy Zwirn Talks Revised Core Set", "https://www.youtube.com/watch?v=gxQYaYPzY_g&t=1291s", "Mar 1, 2022")
                .WithLabels("Jeremy Zwirn", "Revised Core Set");
            AddLink("Deck Building, Part 2 (with the Revised Core Set)", "https://www.youtube.com/watch?v=1zvI3K_H0Sw", "Feb 26, 2022")
                .WithLabels("Revised Core Set");
            AddLink("Deck Building (with the Revised Core Set)", "https://www.youtube.com/watch?v=rXfuXhJOtu4", "Feb 24, 2022")
                .WithLabels("Revised Core Set");
            AddLink("Thalin or Gondorian Spearman Against Eastern Crows", "https://www.youtube.com/watch?v=Sv7DVQpn0nc", "Feb 23, 2022")
                .WithLabels("Thalin", "Gondorian Spearman", "Easter Crows", "Core Set");
            AddLink("The Refresh Phase and Tips, Tricks, and Reminders", "https://www.youtube.com/watch?v=6aXzznZ_QeM", "Feb 18, 2022")
                .WithLabels("Refresh");
            AddLink("Son of Arnor with Forest Snare", "https://www.youtube.com/watch?v=n4wAzeV7ng8", "Feb 16, 2022")
                .WithLabels("Son of Arnor", "Forest Snare", "Core Set", "Combo");
            AddLink("Combat Phase", "https://www.youtube.com/watch?v=S8yh5U4Wo9M", "Feb 15, 2022")
                .WithLabels("Combat Phase");
            AddLink("Travel and Encounter Phases", "https://www.youtube.com/watch?v=1t1QgYyLFVM", "Feb 11, 2022")
                .WithLabels("Travel Phase", "Encounter Phase");
            AddLink("Quest Phase", "https://www.youtube.com/watch?v=u95LvpVjq-A", "Feb 10, 2022")
                .WithLabels("Quest Phase");
            AddLink("Aragorn and Theodred", "https://www.youtube.com/watch?v=nhJoIDOqYSw", "Feb 9, 2022")
                .WithLabels("Aragorn", "Theodred", "Core Set", "Combo");
            AddLink("Resource and Planning Phases", "https://www.youtube.com/watch?v=CtoEQwfuUc4", "Feb 8, 2022")
                .WithLabels("Resource Phase", "Planning Phase");
            AddLink("New Player February with Card Talk", "https://www.youtube.com/watch?v=yoTvbOjOg8M", "Feb 5, 2022")
                .WithLabels("New Players");
            AddLink("How To Set Up Your Game", "https://www.youtube.com/watch?v=PivCpoDjA4g", "Feb 4, 2022")
                .WithLabels("Setup", "New Players", "Core Set");
            AddLink("Core Combos: Sneak Attack/Gandalf", "https://www.youtube.com/watch?v=fgXoSYEjm18", "Feb 2, 2022")
                .WithLabels("Sneak Attack", "Gandalf", "Core Set", "Combo");
            AddLink("Introductory to New Player February", "https://www.youtube.com/watch?v=O8BdH6PkLLc", "Feb 1, 2022")
                .WithLabels("New Players");
            AddLink("ALeP Tactics Hero Glorfindel", "https://www.youtube.com/watch?v=xpChA1jnDUI", "Jan 25, 2022")
                .WithLabels("ALeP", "Glofindel (tactics hero)");
            AddLink("Smoke, and Think", "https://www.youtube.com/watch?v=oZnWQGxdFmE", "Jan 19, 2022")
                .WithLabels("Smoke and Think", "Pipe", "Hobbit", "Cost Reduction");
            AddLink("Spare Pipe", "https://www.youtube.com/watch?v=hN-4TYQTpZ0", "Jan 14, 2022")
                .WithLabels("Spare Pipe", "Event", "Card Fetch");
            
            AddYear(2021);
            AddLink("Hero Bombur", "https://www.youtube.com/watch?v=-TMyighLHGg", "Dec 28, 2021")
                .WithLabels("Bombur (lore hero)", "Dwarf Swarm");
            AddLink("Folco Boffin", "https://www.youtube.com/watch?v=uOyHXW_WUOk", "Dec 21, 2021")
                .WithLabels("Foclo Boffin", "Hobbit", "Secrecy");
            AddLink("Leadership Elfhelm Hero", "https://www.youtube.com/watch?v=CFWVEkwgdfI", "Dec 14, 2021")
                .WithLabels("Elfhelm (leadership hero)", "Mount");
            AddLink("Mirkwood Explorer", "https://www.youtube.com/watch?v=0NJaCRKhUNg", "Dec 8, 2021")
                .WithLabels("Mirkwood Explorer", "Location Control");
            AddLink("Guest Host Jeremy Zwirn", "https://www.youtube.com/watch?v=yWF5IPqSYXI", "Dec 1, 2021")
                .WithLabels("Jeremy Zwirn", "Gandalf (core)", "Smeagol (hero)");
            AddLink("Sword-thain", "https://www.youtube.com/watch?v=CP5SYWCFsyA", "Nov 23, 2021")
                .WithLabels("Sword-thain");
            AddLink("Ranger of Cardolan", "https://www.youtube.com/watch?v=r7FqCdLj4xE", "Nov 17, 2021")
                .WithLabels("Ranger of Cardolan", "Dunedain");
            AddLink("Lore Anborn", "https://www.youtube.com/watch?v=60Gq-DJcJR0", "Nov 9, 2021")
                .WithLabels("Anborn (lore ally)", "Ranger", "Trap");
            AddLink("Forlong", "https://www.youtube.com/watch?v=1XEqjU8xeVE", "Oct 26, 2021")
                .WithLabels("Forlong", "Outlands");
            AddLink("Ranger Bow", "https://www.youtube.com/watch?v=rYr7zyQuSf0", "Oct 19, 2021")
                .WithLabels("Ranger", "Direct Damage");
            AddLink("Con of the Rings 2021 Recap", "https://www.youtube.com/watch?v=S6qtuMjL2Hg", "Oct 12, 2021")
                .WithLabels("Con of the Rings 2021");
            AddLink("Card Talk Live Experimental Deck Builds", "https://www.youtube.com/watch?v=w27wIQbH8mA", "Oct 11, 2021")
                .WithLabels("Deck Building");
            AddLink("Card Talk Live Saga Campaign with Matt Black Gate Opens", "https://www.youtube.com/watch?v=JsWx9rnNoSE", "Oct 9, 2021")
                .WithLabels("The Black Gate Opens");
            AddLink("Card Talk live Journey up the Anduin", "https://www.youtube.com/watch?v=JvG11_4lElM", "Oct 8, 2021")
                .WithLabels("Journey Up the Anduin");
            AddLink("Epic Multiplayer Fire in the Night - Can't of the Rings 2021", "https://www.youtube.com/watch?v=EYRVvuIocng", "Oct 3, 2021")
                .WithLabels("Fire in the Night", "Can't of the Rings 2021");
            AddLink("Tactics Con Cards", "https://www.youtube.com/watch?v=eFBLdWRmJy4", "Sep 28, 2021")
                .WithLabels("Convention", "Tactics");
            AddLink("Spirit Con Cards", "https://www.youtube.com/watch?v=Pb7YIsd44ME", "Sep 21, 2021")
                .WithLabels("Convention", "Spirit");
            AddLink("Lonely Mountain - 5th Attempt", "https://www.youtube.com/watch?v=VCvsTaIjcTo", "Sep 16, 2021")
                .WithLabels("The Lonely Mountain", "Saga");
            AddLink("Guest Host Eric Shell: ALeP Spoiler and Con of the Rings Convo", "https://www.youtube.com/watch?v=Er_S5ANZrFA", "Sep 14, 2021")
                .WithLabels("Eric Shell", "Shellin", "ALeP", "Guided by Fate", "Con of the Rings");
            AddLink("Lonely Mountain - Fourth Attempt", "https://www.youtube.com/watch?v=1ft5qNKtpYU", "Sep 9, 2021")
                .WithLabels("The Lonely Mountain", "Saga");
            AddLink("Lore Con Cards", "https://www.youtube.com/watch?v=aqNoR5gjrSY", "Sep 7, 2021")
                .WithLabels("Convention", "Lore");
            AddLink("Card Talk Live Campaign with Matt Cirith Ungol", "https://www.youtube.com/watch?v=e3TdQO6ONfc", "Sep 6, 2021")
                .WithLabels("The Tower of Cirith Ungol", "Campaign");
            AddLink("Lonely Mountain, Third Attempt", "https://www.youtube.com/watch?v=g4iDO09-MjE", "Sep 2, 2021")
                .WithLabels("The Lonely Mountain", "Saga");
            AddLink("Leadership Con Cards", "https://www.youtube.com/watch?v=if1CDFoebFE", "Aug 31, 2021")
                .WithLabels("Convention", "Leadership");
            AddLink("Meneldor", "https://www.youtube.com/watch?v=vGB1rKyZGe0", "Aug 24, 2021")
                .WithLabels("Meneldor", "Eagle", "Location Control");
            AddLink("Card Talk Live Epic Helms Deep (part 2)", "https://www.youtube.com/watch?v=bc9E2OG1hhk", "Aug 7, 2021")
                .WithLabels("Helm's Deep", "Epic Multiplayer");
            AddLink("Card Talk Live Epic Helms Deep (part 1)", "https://www.youtube.com/watch?v=bc9E2OG1hhk", "Aug 7, 2021")
                .WithLabels("Helm's Deep", "Epic Multiplayer");
            AddLink("Card Talk Like DragnCards", "https://www.youtube.com/watch?v=BKE_hr_sGNY", "Jul 13, 2021")
                .WithLabels("DragnCards", "Play Online");
            AddLink("Card Talk Trivia (part 2)", "https://www.youtube.com/watch?v=f1QyoPVrnjc", "Jul 10, 2021")
                .WithLabels("Trivia");
            AddLink("Card Talk Trivia (part 1)", "https://www.youtube.com/watch?v=f1QyoPVrnjc", "JUl 10, 2021")
                .WithLabels("Trivia");
            AddLink("Dawn Take You All", "https://www.youtube.com/watch?v=yFeBURHqJfU", "Jul 6, 2021")
                .WithLabels("Dawn Take You All", "Shadow Control");
            AddLink("Card Talk Live with Matt Hunt for Gollum (part 2)", "https://www.youtube.com/watch?v=CU3mwuV4ySI", "Jul 5, 2021")
                .WithLabels("The Hunt for Gollum");
            AddLink("Card Talk Live with Matt Hunt for Gollum (part 1)", "https://www.youtube.com/watch?v=5FZOWK66MWM", "Jul 5, 2021")
                .WithLabels("The Hunt for Gollum");
            AddLink("Lonely Mountain 2nd Attempt", "https://www.youtube.com/watch?v=iXqx4cwX2NY", "Jun 30, 2021")
                .WithLabels("The Lonely Mountain", "Saga");
            AddLink("Leadership Merry", "https://www.youtube.com/watch?v=lJT-Z9Bj4Cw", "Jun 29, 2021")
                .WithLabels("Merry (leadership ally)");
            AddLink("Epic multiplayer Helm's Deep", "https://www.youtube.com/watch?v=6yrwr_wXPdQ", "Jun 19, 2021")
                .WithLabels("Helm's Deep", "Epic Multiplayer");
            AddLink("Spoiler: Con of the Rings 2021", "https://www.youtube.com/watch?v=b1pwxmvdOQ8", "2021-06-15")
                .WithLabels("Con of the Rings 2021", "Convention");
            AddLink("Daeron's Runes", "https://www.youtube.com/watch?v=r4lbpR-fEME", "2021-06-08")
                .WithLabels("Card Draw");
            AddLink("A Test of Will", "https://www.youtube.com/watch?v=RTb8m1yJvs8", "2021-06-01")
                .WithLabels("Treachery Control");
            AddLink("Last Stand", "https://www.youtube.com/watch?v=1YSyCRYM94I", "2021-05-25");
            AddLink("Leadership Eomer", "https://www.youtube.com/watch?v=UfHVtHwo_Ro", "2021-05-18")
                .WithLabels("Staging Area Attack");
            AddLink("Grimbeorn the Old", "https://www.youtube.com/watch?v=K7BbdSiBQtc", "2021-05-11")
                .WithLabels("Beorning", "Tank Defender", "Action Advantage", "Combat Control");
            AddLink("Tactics Beregond", "https://www.youtube.com/watch?v=K7BbdSiBQtc", "2021-05-05")
                .WithLabels("Tank Defender", "Cost Reduction", "Armor", "Weapon");
            AddLink("Bywater Shiriff", "https://www.youtube.com/watch?v=bnWWzKKNvNw", "2021-04-27T19:05:12+00:00")
                .WithLabels("");
            AddLink("Card Talk Saga Campgain with Matt Cirth Ungol (pt 2)", "https://www.youtube.com/watch?v=qHtlBlx8SIo", "2021-04-27T07:00:01+00:00")
                .WithLabels("");
            AddLink("Card Talk Saga Campgain with Matt Cirth Ungol", "https://www.youtube.com/watch?v=fu5Zt5P8RCg", "2021-04-27T05:59:59+00:00")
                .WithLabels("");
            AddLink("Dungeons Deep and Caverns Dim - 7th Attempt", "https://www.youtube.com/watch?v=O0Qb33ed0Ik", "2021-04-22T16:00:10+00:00")
                .WithLabels("");
            AddLink("Envoy of Pelargir", "https://www.youtube.com/watch?v=1VAI87wUeW4", "2021-04-20T12:04:49+00:00")
                .WithLabels("Gondor", "Resource Smoothing");
            AddLink("Warden of Healing and Ioreth", "https://www.youtube.com/watch?v=g9mYiyUtrkM", "2021-04-07T19:12:12+00:00")
                .WithLabels("Support", "Healing", "Gondor");
            AddLink("Ally Elrond", "https://www.youtube.com/watch?v=_gE3wz941NM", "2021-03-30T19:35:58+00:00")
                .WithLabels("Healing", "Card Draw", "Condition Removal");
            AddLink("Magic Ring", "https://www.youtube.com/watch?v=D5yCHTKnZ00", "2021-03-23T13:34:52+00:00")
                .WithLabels("Readying", "Healing", "Resource Acceleration", "Threat");
            AddLink("Card Talk Live Saga Campaign with Matt Battle of Pelennor Fields", "https://www.youtube.com/watch?v=c5Dd7u-Vwq0", "2021-03-16T07:16:52+00:00")
                .WithLabels("");
            AddLink("Healing Herbs", "https://www.youtube.com/watch?v=VkvNNws9B3w", "2021-03-09T16:05:52+00:00")
                .WithLabels("");
            AddLink("Card Talk Live Campagin with Matt Siege of Gondor", "https://www.youtube.com/watch?v=cFNxRz7sq1w", "2021-03-02T04:50:21+00:00")
                .WithLabels("Siege of Gondor", "Campaign");
            AddLink("Superlative Caleb", "https://www.youtube.com/watch?v=urRnKPd4dkM", "2021-03-01T18:15:57+00:00")
                .WithLabels("Caleb Grace");
            AddLink("Superlative February - Show 12", "https://www.youtube.com/watch?v=INxqczSBk_s", "2021-02-26T16:41:21+00:00");
            AddLink("Superlative February - Show 11", "https://www.youtube.com/watch?v=Pn_ZkB4BroE", "2021-02-24T19:31:46+00:00");
            AddLink("Superlative February - Show 10", "https://www.youtube.com/watch?v=fKkzf2uLxkw", "2021-02-22T17:00:19+00:00");
            AddLink("Superlative February - Show 9", "https://www.youtube.com/watch?v=h5-0vhxANrY", "2021-02-20T00:00:00+00:00");
            AddLink("Superlative February - Show 8", "https://www.youtube.com/watch?v=WbjeBMcO3Mk", "2021-02-18T00:00:00+00:00");
            AddLink("Card Talk Live with Matt Passing of the Grey Company", "https://www.youtube.com/watch?v=eJDCoRlBIpw", "2021-02-16T00:00:00+00:00")
                .WithLabels("The Passing of the Gray Company");
            AddLink("Superlative February - Show 7", "https://www.youtube.com/watch?v=Zrn2UHz86_Y", "2021-02-16");
            AddLink("Superlative February - Show 6", "https://www.youtube.com/watch?v=7cM9meK2qVE", "2021-02-14");
            AddLink("Superlative February - Show 5", "https://www.youtube.com/watch?v=Q0MPynMonzs", "2021-02-12");
            AddLink("Superlative February - Show 4", "https://www.youtube.com/watch?v=rLkfUYdoIHM", "2021-02-10");
            AddLink("Superlative February - Show 3", "https://www.youtube.com/watch?v=zmj7X8hKB-Q", "2021-02-08");
            AddLink("Superlative February - Show 2", "https://www.youtube.com/watch?v=dA0iq8joiiE", "2021-02-06");
            AddLink("Card Talk Live Saga Campaign with Matt Battle of Pelennor Fields", "https://www.youtube.com/watch?v=_Xtmggp6Bv8", "2021-02-04")
                .WithLabels("The Battle of Pelennor Fields", "Campaign");
            AddLink("Card Talk Live Saga Campaign with Matt Siege of Gondor", "https://www.youtube.com/watch?v=-9xLCIKtr1Q", "2021-02-02")
                .WithLabels("The Siege of Gondor", "Campaign");
            AddLink("Superlative February - Show 1", "https://www.youtube.com/watch?v=uS9iWZiiOLk", "2021-02-01");
            AddLink("Beorn's Hospitality", "https://www.youtube.com/watch?v=s0QwMnG9RQE", "2021-01-29")
                .WithLabels("Beorn's Hospitality", "Healing");
            AddLink("Card Talk Live Hunt for the Dreadnaught", "https://www.youtube.com/watch?v=2rhj4fqo_pU", "Jan 22, 2021")
                .WithLabels("The Hunt for the Dreadnaught");
            AddLink("Lore of Imladris", "https://www.youtube.com/watch?v=4ielqlAsqd4", "Jan 19, 2021")
                .WithLabels("Healing");
            AddLink("Card Talk Live Saga Camapaign with Matt Passing of the Grey Company (part 2)", "https://www.youtube.com/watch?v=EFtHSs3duCw", "Jan 18, 2021")
                .WithLabels("The Passing of the Grey Company", "Campaign", "Saga");
            AddLink("Card Talk Live Saga Camapaign with Matt Passing of the Grey Company (part 2)", "https://www.youtube.com/watch?v=Io_pOm4akew", "Jan 18, 2021")
                .WithLabels("The Passing of the Grey Company", "Campaign", "Saga");
            AddLink("Card Talk Live Saga Campaign with Matt Shelob's Lair", "https://www.youtube.com/watch?v=XIHA0F7CHHY", "Jan 18, 2021")
                .WithLabels("Shelob's Lair", "Campaign", "Saga");
            AddLink("Card Talk Live Saga Campaign with Matt Journey to the Crossroads", "https://www.youtube.com/watch?v=k_kPxBZHx78", "Jan 18, 2021")
                .WithLabels("Journey to the Crossroads", "Campaign", "Saga");
            AddLink("Card Talk Live Saga Campaign Passage Through the Marshes", "https://www.youtube.com/watch?v=94RlqhuZVsk", "Jan 17, 2021")
                .WithLabels("The Passage Through the Marshes", "Campaign", "Saga");
            AddLink("Card Talk Live with Onidsen Spiders of the Woodland Realm", "https://www.youtube.com/watch?v=szpDLDa2BTE", "Jan 15, 2021")
                .WithLabels("Spiders of the Woodland Realm", "Onidsen");
            AddLink("Card Talk Live Saga Campaign with Matt Shelob's Lair", "https://www.youtube.com/watch?v=hW73QGoQRMQ", "Jan 11, 2021")
                .WithLabels("Shelob's Lair", "Campaign", "Saga");
            AddLink("Card Talk Live Saga Campaign with Matt Journey to the Crossroads", "https://www.youtube.com/watch?v=Mm8lV3EEXMQ", "Jan 11, 2021")
                .WithLabels("Journey to the Crossroads", "Campaign", "Saga");
            AddLink("Card Talk Live Saga Campaign with Matt Passage through the Marshes", "https://www.youtube.com/watch?v=YW_qI8G8W7U", "Jan 11, 2021")
                .WithLabels("Passage Through the Marshes", "Campaign", "Saga");
            AddLink("Dunedain Remedy", "https://www.youtube.com/watch?v=YW_qI8G8W7U", "Jan 11, 2021")
                .WithLabels("Healing", "Signal");
            /*
            AddLink("", "", "")
                .WithLabels("");
            AddLink("", "", "")
                .WithLabels("");
            AddLink("", "", "")
                .WithLabels("");
            AddLink("", "", "")
                .WithLabels("");
            AddLink("", "", "")
                .WithLabels("");
            AddLink("", "", "")
                .WithLabels("");
            AddLink("", "", "")
                .WithLabels("");
            AddLink("", "", "")
                .WithLabels("");
            AddLink("", "", "")
                .WithLabels("");
            */


            AddYear(2020);
            AddLink("Guest Host Chloe Walsh", "https://www.youtube.com/watch?v=SAmEgdIw-0U", "2020-02-07T17:00:08+00:00");
            AddLink("Guest Host Tolkien Road", "https://www.youtube.com/watch?v=-kSqKjSxQmc", "2020-02-05T17:00:00+00:00");
            AddLink("Hero Arwen Umdomiel and any Hero Aragorn", "https://www.youtube.com/watch?v=MuyWpuMII-Q", "2020-02-03T17:00:11+00:00")
                .WithLabels("Arwen Undomiel (spirit hero)", "Aragorn (hero)");
            AddLink("Feint", "https://www.youtube.com/watch?v=XTGRkSOQSog", "2020-01-27T17:00:07+00:00")
                .WithLabels("Combat Control", "Errata");
            AddLink("Theodred", "https://www.youtube.com/watch?v=JfpIBmJ3BHU", "2020-01-20T17:00:04+00:00")
                .WithLabels("Resource Acceleration", "Questing");
            AddLink("Couples February!", "https://www.youtube.com/watch?v=wZWjLRBBZIs", "2020-01-16T17:00:14+00:00");
            AddLink("SPOILER! Odo Proudfoot", "https://www.youtube.com/watch?v=hDImxEfbaDg", "2020-01-13T17:00:13+00:00")
                .WithLabels("Hobbit", "Card Fetch");
            AddLink("Minimum Purchase Dunland Trap", "https://www.youtube.com/watch?v=XYH-Pee18vs", "2020-01-09T19:58:35+00:00")
                .WithLabels("The Dunland Trap");
            AddLink("Eleanor", "https://www.youtube.com/watch?v=uvJzEqG253Q", "2020-01-06T17:00:11+00:00")
                .WithLabels("Treachery Cancellation");

            AddYear(2019);
            AddLink("Hero Treebeard", "https://www.youtube.com/watch?v=D7dBd3ZIJEY", "2019-12-23T17:00:04+00:00")
                .WithLabels("Treebeard (lore hero)", "Willpower Boost", "Healing");
            AddLink("Behind Strong Walls", "https://www.youtube.com/watch?v=KGu6ZoQBSqE", "2019-12-16T17:29:14+00:00")
                .WithLabels("Readying", "Defense Boost");
            AddLink("Gildor's Counsel", "https://www.youtube.com/watch?v=wbS7foeQuu4", "2019-12-09T17:57:33+00:00")
                .WithLabels("Encounter Deck Control");
            AddLink("Strider's Path", "https://www.youtube.com/watch?v=R3SC_k3At64", "2019-12-02T19:37:59+00:00")
                .WithLabels("Strider's Path", "Location Control");
            AddLink("Guest Host Caleb Grace 2", "https://www.youtube.com/watch?v=ri5AtxinPq4", "2019-11-25T17:00:13+00:00")
                .WithLabels("Caleb Grace");
            AddLink("Explore Secret Ways", "https://www.youtube.com/watch?v=-tuqkZ_ztrQ", "2019-11-18T14:24:46+00:00")
                .WithLabels("Explore Secret Ways", "Location Control", "Victory Display");
        }
    }
}