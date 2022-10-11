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
            
            AddLink("Card Talk Live Saga with Matt Passage through the Marshes (part 2)", "https://www.youtube.com/watch?v=jrH4cxiZvzs", "Jan 7, 2021")
                .WithLabels("The Passage Through the Marshes", "Saga", "Campaign");
            AddLink("Self Preservation", "https://www.youtube.com/watch?v=Z7Rxarbnq7o", "Jan 4, 2021")
                .WithLabels("Healing");
            AddLink("Card Talk Live Saga with Matt Passage Through the Marshes (part 1)", "https://www.youtube.com/watch?v=KhQWc7J5F3M", "Jan 3, 2021")
                .WithLabels("The Passage Through the Marshes", "Saga", "Campaign");
            
            AddYear(2020);
            AddLink("Card Talk Live Saga with Matt Road to Isengard", "https://www.youtube.com/watch?v=t-E9U1rTP-A", "Dec 31, 2020")
                .WithLabels("The Road to Isengard", "Saga", "Campaign");
            AddLink("Card Talk Live Saga with Matt Helm's Deep (part 2)", "https://www.youtube.com/watch?v=A-cZ2YUDl_k", "Dec 31, 2020")
                .WithLabels("Helm's Deep", "Saga", "Campaign");
            AddLink("The End Comes", "https://www.youtube.com/watch?v=CgFYOyqgcrE", "Dec 28, 2020")
                .WithLabels("Encounter Deck Control", "Dwarf");
            AddLink("Card Talk Live Saga with Matt Helm's Deep (part 1)", "https://www.youtube.com/watch?v=2jp4KU8GP2M", "Dec 23, 2020")
                .WithLabels("Helm's Deep", "Campaign", "Saga");
            AddLink("Stone of Elostirion", "https://www.youtube.com/watch?v=FUEukSpe1c4", "Dec 21, 2020")
                .WithLabels("Guarded", "Willpower Boost", "Card Draw");
            AddLink("Card Talk Live Saga with Matt Uruk Hai", "https://www.youtube.com/watch?v=IdGHpkHgfFw", "Dec 20, 2020")
                .WithLabels("The Uruk Hai", "Campaign", "Saga");
            AddLink("Can Guarded Cards Beat the Seventh Level", "https://www.youtube.com/watch?v=b4PsBShNg6A", "Dec 17, 2020")
                .WithLabels("The Seventh Level", "Guarded");
            AddLink("Durin's Axe", "https://www.youtube.com/watch?v=fNwA_k6Mjz0", "Dec 15, 2020")
                .WithLabels("Guarded", "Direct Damage");
            AddLink("Card Talk Live Saga with Matt Breaking the Fellowship", "https://www.youtube.com/watch?v=XDPsGpF-37M", "Dec 13, 2020")
                .WithLabels("Breaking of the Fellowship", "Campaign", "Saga");
            AddLink("Guest Host Eric Shell - A Long-extended Party", "https://www.youtube.com/watch?v=KwGclkfoz48", "Dec 11, 2020")
                .WithLabels("ALeP", "Eric Shell", "Shellin", "A Long-extended Party");
            AddLink("A Long-extended Party - Thengel", "https://www.youtube.com/watch?v=rDNch76uNaY", "Dec 9, 2020")
                .WithLabels("Thengel", "Rohan");
            AddLink("Cram", "https://www.youtube.com/watch?v=7MZKqpGBstU", "Dec 7, 2020")
                .WithLabels("Readying");
            AddLink("Card Talk Live Saga with Matt The Ring Goes South", "https://www.youtube.com/watch?v=BiaSOWSyU-8", "Dec 6, 2020")
                .WithLabels("The Ring Goes South", "Campaign", "Saga");
            AddLink("Card Talk Live Saga with Matt Journey in the Dark", "https://www.youtube.com/watch?v=ScUIjCPg14o", "Dec 6, 2020")
                .WithLabels("Journey in the Dark", "Saga", "Campaign");
            AddLink("Card Talk Live Saga with Matt The Ring Goes South", "https://www.youtube.com/watch?v=1v_P-Zo0-Fo", "Nov 29, 2020")
                .WithLabels("The Ring Goes South", "Campaign",  "Saga");
            AddLink("Card Talk Live Journey Along the Anduin", "https://www.youtube.com/watch?v=1CubTmBlgGc", "Nov 28, 2020")
                .WithLabels("Journey Along the Anduin");
            AddLink("Card Talk Live Saga with Matt Flight to the Ford", "https://www.youtube.com/watch?v=emWkoJYjH_A", "Nov 26, 2020")
                .WithLabels("Flight to the Ford", "Campaign", "Saga");
            AddLink("Card Talk Live Saga with Matt Passage of the Marshes (part 2)", "https://www.youtube.com/watch?v=uSnw24l-MoM", "Nov 26, 2020")
                .WithLabels("The Passage of the Marshes", "Campaign", "Saga");
            AddLink("Card Talk Live with Onidsen Into the Pit", "https://www.youtube.com/watch?v=-Ai974GtGrQ", "Nov 26, 2020")
                .WithLabels("Into the Pit", "Onidsen");
            AddLink("Card Talk Live Saga with Matt Passage of the Marshes (part 1)", "https://www.youtube.com/watch?v=-GsGMpOuirA", "Nov 25, 2020")
                .WithLabels("The Passage of the Marshes", "Campaign", "Saga");
            AddLink("Card Talk Live The Hills of Emyn Muil", "https://www.youtube.com/watch?v=a1t4LLYhsLU", "Nov 25, 2020")
                .WithLabels("The Hills of Emyn Muil");
            AddLink("Card Talk Live: Bond of Hobbitship takes on Massing at Osgiliath", "https://www.youtube.com/watch?v=ZOhDldAniDE", "Nv 25, 2020")
                .WithLabels("Bond of Friendship", "Hobbit", "Massing at Osgiliath");
            AddLink("Peace, and Thought", "https://www.youtube.com/watch?v=IEjsrrw8nkg", "Nov 24, 2020")
                .WithLabels("Card Draw", "Readying");
            AddLink("Card Talk Live Saga with Matt Road to Isengard", "https://www.youtube.com/watch?v=TiTL4bxZqAU", "Nov 22, 2020")
                .WithLabels("Road to Isengard", "Campaign", "Saga");
            AddLink("Superlative February Announcement", "https://www.youtube.com/watch?v=JrJktUSL24Q", "Nov 18, 2020")
                .WithLabels("News", "Superlative February");
            AddLink("Guest Host Joe Hoffman", "https://www.youtube.com/watch?v=uFgfKNPU4kI", "Nov 17, 2020")
                .WithLabels("Raise the Shire", "Hobbit");
            AddLink("Card Talk Live Saga with Matt A Knife in the Dark (part 2)", "https://www.youtube.com/watch?v=jv3pIrt6flU", "Nov 15 2020")
                .WithLabels("A Knife in the Dark", "Campaign", "Saga");
            AddLink("Card Talk Live Saga with Matt A Knife in the Dark (part 1)", "https://www.youtube.com/watch?v=np5pXuXTXTc", "Nov 15, 2020")
                .WithLabels("A Knife in the Dark", "Campaign", "Saga");
            AddLink("Ring Mail", "https://www.youtube.com/watch?v=hBly5hUmsTY", "Nov 9, 2020")
                .WithLabels("Armor", "Dwarf", "Hobbit");
            AddLink("Card Talk Live Saga with Matt A Shadow of the Past", "https://www.youtube.com/watch?v=yTNvaGD0MDA", "Nov 8, 2020")
                .WithLabels("A Shadow of the Past", "Campaign", "Saga");
            AddLink("Card Talk Live Saga with Matt Helm's Deep", "https://www.youtube.com/watch?v=6unfg1b1tbs", "Nov 1, 2020")
                .WithLabels("Helm's Deep", "Campaign", "Saga");
            AddLink("Guest Host Justin Gein", "https://www.youtube.com/watch?v=IKRkxQB-QQE", "Oct 26, 2020")
                .WithLabels("The Free Peoples");
            AddLink("Bond of Hobbiship vs Into Ithilien", "https://www.youtube.com/watch?v=pUTO_Lgv0Gg", "Oct 22, 2020")
                .WithLabels("Bond of Friendship", "Hobbit", "Into Ithilien");
            AddLink("Guest Host Russ Lundgren", "https://www.youtube.com/watch?v=XFpQHjUSH8I", "Oct 20, 2020")
                .WithLabels("Elrond (lore hero)");
            AddLink("Card Talk Live Saga with Matt The Uruk-hai", "https://www.youtube.com/watch?v=zqG-bTKb1j4", "Oct 18, 2020")
                .WithLabels("The Uruk-hai", "Campaign", "Saga");
            AddLink("Card Talk's New Player Buying Guide", "https://www.youtube.com/watch?v=GUn1t45GL5c", "Oct 15, 2020")
                .WithLabels("New Players", "Buying Guide");
            AddLink("Spirit Bofur", "https://www.youtube.com/watch?v=9tD2ZvdUbqw", "Oct 13, 2020")
                .WithLabels("Bofur (spirit ally)");
            AddLink("Card Talk Live Lost in Mirkwood", "https://www.youtube.com/watch?v=EfUI8KCJey8", "Oct 9, 2020")
                .WithLabels("Lost in Mirkwood", "Community");
            AddLink("Dungeons Deep and Caverns Dim: Matt's Sixth Sense", "https://www.youtube.com/watch?v=wiwXvqk7jRQ", "Oct 8, 2020")
                .WithLabels("Dungeons Deep and Caverns Dim");
            AddLink("Guest Host Vardaen (again!)", "https://www.youtube.com/watch?v=hq9m9SuiNI8", "Oct 5, 2020")
                .WithLabels("Ghan-buri-Ghan", "Vardaen");
            AddLink("Card Talk Live Nightmare Road to Rivendell", "https://www.youtube.com/watch?v=76sNvkbxVnI", "Sep 14, 2020")
                .WithLabels("Road to Rivendell", "Nightmare");
            AddLink("Waters of Nimrodel", "https://www.youtube.com/watch?v=C6_MfPWtoCo", "Sep 14, 2020")
                .WithLabels("Doomed", "Healing");
            AddLink("Card Talk Live Breaking of the Fellowship", "https://www.youtube.com/watch?v=8xvm-_Fjl-k", "Sep 13, 2020")
                .WithLabels("The Breaking of the Fellowship", "Saga", "Campaign");
            AddLink("Dungeons Deep and Caverns Dim: Fifth Time's the Charm?", "https://www.youtube.com/watch?v=a9UcWEHz35A", "Sep 10, 2020")
                .WithLabels("Dungeons Deep and Caverns Dim", "Saga");
            AddLink("Card Talk Live The Dungeons of Cirith Gurat", "https://www.youtube.com/watch?v=dGUjzRMY6jM", "Sep 8, 2020")
                .WithLabels("The Dungeonss of Cirith Gurat");
            AddLink("Ring of Barahir", "https://www.youtube.com/watch?v=Kahrd7CzzzY", "Sep 8, 2020")
                .WithLabels("Artifact", "Hit Point Boost");
            AddLink("Card Talk Live Into the Pit", "https://www.youtube.com/watch?v=rn5Xs5RMRpg", "Sep 7, 2020")
                .WithLabels("Into the Pit");
            AddLink("Dungeons Deep and Caverns Dim (part 4)", "https://www.youtube.com/watch?v=R3wRyRDxHsw", "Sep 3, 2020")
                .WithLabels("Dungeons Deep and Caverns Dim", "Saga");
            AddLink("Citadel Custodian", "https://www.youtube.com/watch?v=JUlA3NLXl-M", "Aug 31, 2020")
                .WithLabels("Gondor Swarm");
            AddLink("Dungeons Deep and Caverns Dim (part 3)", "https://www.youtube.com/watch?v=wuwQrjC3m6c", "Aug 29, 2020")
                .WithLabels("Dungeons Deep and Caverns Dim", "Saga");
            AddLink("Free to Choose", "https://www.youtube.com/watch?v=Ujm3h2zqPaM", "Aug 25, 2020")
                .WithLabels("Threat Reduction");
            AddLink("LotR LCG Ancient Mathoms", "https://www.youtube.com/watch?v=1OWL7YRVRsk", "Aug 21, 2020")
                .WithLabels("Across the Ettenmoors");
            AddLink("Farmer Maggot", "https://www.youtube.com/watch?v=xjVnvdhDPXo", "Aug 18, 2020")
                .WithLabels("Direct Damage", "Hobbit Ambush");
            AddLink("New Player GuideL Card Talk Talks Keywords", "https://www.youtube.com/watch?v=GXrFB-76Kos", "Aug 16, 2020")
                .WithLabels("New Players", "Keywords");
            AddLink("Dungeons Deep and Caverns Dim (part 2)", "https://www.youtube.com/watch?v=6u7AaReIAuY", "Aug 13, 2020")
                .WithLabels("Dungeons Deep and Caverns Dim", "Saga");
            AddLink("Dungeons Deep and Caverns Dim (part 1)", "https://www.youtube.com/watch?v=1tbR4wiuxiY", "Aug 12, 2020")
                .WithLabels("Dungeons Deep and Caverns Dim", "Saga");
            AddLink("Card Talk Live: Still Another Journey in the Dark (part 2)", "https://www.youtube.com/watch?v=uOb7LBBUVh4", "Aug 9, 2020")
                .WithLabels("Journey in the Dark", "Campaign", "Saga");
            AddLink("Card Talk Live: Desert Crossing, The Long Arm of Mordor, and Race Across Harad", "https://www.youtube.com/watch?v=njh_tSW6XH4", "Aug 6, 2020")
                .WithLabels("Desert Crossing", "The Long Arm of Mordor", "Race Across Harad");
            AddLink("Card Talk Live: The Fate of Wilderland", "https://www.youtube.com/watch?v=FzsaYa9WDw8", "Aug 2, 2020")
                .WithLabels("The Fate of Wilderland");
            AddLink("Card Talk Live Episode 2", "https://www.youtube.com/watch?v=sNAIlXrhXnA", "Aug 1, 2020")
                .WithLabels("Ered Mithrin Player Cards");
            AddLink("Card Talk Live Episode 1", "https://www.youtube.com/watch?v=gK_DYgxIQcw", "Aug 1, 2020")
                .WithLabels("Shadows of Mirkwood Player Cards");
            AddLink("Epic Multiplayer Storm on Cobas Haven", "https://www.youtube.com/watch?v=umyCZ8vCkDU", "Jul 30, 2020")
                .WithLabels("A Storm on Cobas Haven", "Epic Multiplayer");
            AddLink("Leadership Hero Faramir", "https://www.youtube.com/watch?v=N_PcOhmps7Q", "Jul 28, 2020")
                .WithLabels("Faramir (leadership hero)", "Ally Readying", "Enemy Engagement");
            AddLink("Card Talk Live: Journey in the Dark (part 1)", "https://www.youtube.com/watch?v=z7RsKuT39JQ", "Jul 26, 2020")
                .WithLabels("Journey in the Dark", "Campaign", "Saga");
            AddLink("Miruvor", "https://www.youtube.com/watch?v=WxZTu5lp0PM", "Jul 20, 2020")
                .WithLabels("Readying", "Willpower Boost", "Resource Smoothing");
            AddLink("Card Talk Live: The Drowned Ruins", "https://www.youtube.com/watch?v=icjxxUgwc8o", "Jul 18, 2020")
                .WithLabels("The Drowned Ruins");
            AddLink("Card Talk Live: Over the Misty Mountains Grim", "https://www.youtube.com/watch?v=HW8TzJCJgNk", "Jul 16, 2020")
                .WithLabels("Over the Misty Mountains Grim", "Saga");
            AddLink("Thorongil Bilbo on The Road to Rivendell", "https://www.youtube.com/watch?v=SJK6XBM2BLA", "Jul 14, 2020")
                .WithLabels("Bilbo Baggins", "Thorongil", "The Road to Rivendell");
            AddLink("Beravor", "https://www.youtube.com/watch?v=GJ5U6liT7TM", "Jul 13, 2020")
                .WithLabels("Card Draw", "Errata");
            AddLink("Card Talk Live: Journey in the Dark", "https://www.youtube.com/watch?v=28Ks2F_p994", "Jul 12, 2020")
                .WithLabels("Journey in the Dark", "Campaign", "Saga");
            AddLink("Card Talk Live - 4 Player Store on Cobas Haven", "https://www.youtube.com/watch?v=O9xxJVFp-Ns", "Jul 11, 2020")
                .WithLabels("A Storm on Cobas Haven", "Multiplayer", "Four Player");
            AddLink("Card Talk Live - 2 Player Storm on Cobas Haven", "https://www.youtube.com/watch?v=yzSEnOhIFSM", "Jul 10, 2020")
                .WithLabels("A Storm on Cobas Haven", "Multiplayer", "Two Player");
            AddLink("SPOILER!!! Thorongil", "https://www.youtube.com/watch?v=8eQqC8cBM5w", "Jul 10, 2020")
                .WithLabels("Hero Versions", "Spoiler");
            AddLink("Spirit Aragorn Takes on the Mumakil", "https://www.youtube.com/watch?v=sNmiMn81C1g", "Jul 9, 2020")
                .WithLabels("Aragorn (spirit hero)", "The Mumakil");
            AddLink("Card Talk Live Over the Misty Mountains Grim", "https://www.youtube.com/watch?v=A0qiyzyRry0", "Jul 8, 2020")
                .WithLabels("Over the Misty Mountains Grim", "Saga");
            AddLink("SPOILER!!! Spirit Aragorn", "https://www.youtube.com/watch?v=Szj1h-KmZGs", "Jul 6, 2020")
                .WithLabels("Aragorn (spirit hero)");
            AddLink("Card Talk Live - Deck Building with Gran", "https://www.youtube.com/watch?v=Khkswp-wA_A", "Jul 5, 2020")
                .WithLabels("Deck Building");
            AddLink("Card Talk Live - The Ring Goes South", "https://www.youtube.com/watch?v=FxiMJuGyR74", "Jul 3, 2020")
                .WithLabels("The Ring Goes South", "Saga", "Campaign");
            AddLink("Hobbits: Bond of Friendship - Journey Along the Anduin", "https://www.youtube.com/watch?v=lTyZG2vfPaQ", "Jul 1, 2020")
                .WithLabels("Journey Along the Anduin", "Bond of Friendship", "Hobbit");
            AddLink("SPOILER!!! Bond of Friendship Contract", "https://www.youtube.com/watch?v=jeTaCcY-uU4", "Jun 30, 2020")
                .WithLabels("Bond of Friendship", "Contract");
            AddLink("Guest Hosts Bob and Chrissy", "https://www.youtube.com/watch?v=rRjNCjVbvzM", "Jun 29, 2020")
                .WithLabels("Prince Imrahil (tactics hero)");
            AddLink("Dragon Sickness: We Must Away, Ere Break of Day", "https://www.youtube.com/watch?v=ml4R_SmOoLQ", "Jun 24, 2020")
                .WithLabels("We Must Away, Ere Break of Day", "Saga");
            AddLink("Card Talk Live - Nightmare Journey in the Dark/Road to Rivendell", "https://www.youtube.com/watch?v=5KmqYhqgUM4", "Jun 23, 2020")
                .WithLabels("Nightmare Journey in Dark", "Road to Rivendell");
            AddLink("Card Talk Live - Flight to the Ford", "https://www.youtube.com/watch?v=zRD35rb3qfg", "Jun 21, 2020")
                .WithLabels("Flight to the Ford", "Saga");
            AddLink("Knife in the Dark", "https://www.youtube.com/watch?v=jPiORJVGbzQ", "Jun 21, 2020")
                .WithLabels("A Knife in the Dark", "Saga");
            AddLink("Haldir Defends Everything Along the Anduin", "https://www.youtube.com/watch?v=ZwsFgQK1mGE", "Jun 19, 2020")
                .WithLabels("Journey Along the Anduin", "The Grey Wanderer");
            AddLink("Card Talk Plays - Desert Crossing", "https://www.youtube.com/watch?v=7F3vkNBsg9w", "Jun 17, 2020")
                .WithLabels("Desert Crossing");
            AddLink("Tactics Hero Legolas", "https://www.youtube.com/watch?v=7_h4jFdLCXA", "Jun 15, 2020")
                .WithLabels("Legolas (tactics hero)");
            AddLink("Card Talk Live - Nightmare Journey Along the Anduin", "https://www.youtube.com/watch?v=AO17yf32OkU", "Jun 13, 2020")
                .WithLabels("Journey Along the Anduin", "Nightmare");
            AddLink("Escape from Umbar with Dwarf Mining", "https://www.youtube.com/watch?v=wuwoNUdrhK4", "Jun 11, 2020")
                .WithLabels("Escape from Umbar", "Dwarf Mining");
            AddLink("Ally Treebeard", "https://www.youtube.com/watch?v=AI3TKxgTegE", "JUn 8, 2020")
                .WithLabels("Treebeard (ally)", "Ent");
            AddLink("Card Talk Live - Intruders in Chetwood", "https://www.youtube.com/watch?v=8KDqlMtnqO0", "Jun 6, 2020")
                .WithLabels("Intruders in Chetwood");
            AddLink("Escape from Dol Guldur", "https://www.youtube.com/watch?v=3ArDdhHGGH4", "Jun 3, 2020")
                .WithLabels("Escape from Dol Guldur");
            AddLink("Snowbourn Scout", "https://www.youtube.com/watch?v=GwUXvLG6_AU", "Jun 1, 2020")
                .WithLabels("Location Control");
            AddLink("Card Talk Live - Escape from Mount Gram", "https://www.youtube.com/watch?v=cqofmIXR9Hg", "May 30, 2020")
                .WithLabels("Escape from Mount Gram");
            AddLink("We Must Away 'Ere Break of Day", "https://www.youtube.com/watch?v=I78Khu3W2KI", "May 27, 2020")
                .WithLabels("We Must Away Ere Break of Day", "Saga");
            AddLink("Card Talk Live - The Oath", "https://www.youtube.com/watch?v=yfeKSGBTqaA", "May 24, 2020")
                .WithLabels("The Oath", "Two Player Limited Starter", "Grimbeorn the Old", "Balin", "Legolas", "The One Ring");
            AddLink("SPOILER!!! Read Book of Westmarch", "https://www.youtube.com/watch?v=JD7_8Amv9xg", "May 18, 2020")
                .WithLabels("Red Book of Westmarch", "Hobbit", "Resource Acceleration", "Willpower Boost", "Spoiler");
            AddLink("Card Talk Live - Nightmare Journey Along the Anduin", "https://www.youtube.com/watch?v=vfvehHfklj4", "May 17, 2020")
                .WithLabels("Journey Along the Anduin", "Nightmare");
            AddLink("Card Talk Live - Under the Ash Mountains", "https://www.youtube.com/watch?v=uDMNWSy2Ezs", "May 16, 2020")
                .WithLabels("Under the Ash Mountains");
            AddLink("Community Built Deck Play Through", "https://www.youtube.com/watch?v=DTqoH-6EDNM", "May 13, 2020")
                .WithLabels("Community", "Eowyn (tactics hero)", "Glorfindel (spirit hero)", "Na'asiyah", "Shadow and Flame");
            AddLink("Guest Host Shane and Bob", "https://www.youtube.com/watch?v=Y5_YXmxXM4w", "May 13, 2020")
                .WithLabels("We Are Not Idle", "Dwarf", "Card Draw", "Resource Acceleration", "Errata");
            AddLink("Round Table Discussion: Attack on Dol Guldur", "https://www.youtube.com/watch?v=vILrJU8LRPA", "May 5, 2020")
                .WithLabels("Attack on Dol Guldur");
            AddLink("Valiant Sacrifice", "https://www.youtube.com/watch?v=02ervnMJjQ8", "May 4, 2020")
                .WithLabels("Ally Leaves Play", "Card Draw");
            AddLink("Shadow of the Past", "https://www.youtube.com/watch?v=UYrsrI_DUNo", "Apr 27, 2020")
                .WithLabels("A Shadow of the Past", "Campaign", "Saga", "Hobbit");
            AddLink("Power in the Earth", "https://www.youtube.com/watch?v=uddEgvBHmek", "Apr 27, 2020")
                .WithLabels("Location Control", "Location Attachment");
            AddLink("Card Talk Plays - The Silvans Passage through Mirkwood", "https://www.youtube.com/watch?v=su-jf3mQmCc", "Apr 21, 2020")
                .WithLabels("Passage Through Mirkwood", "Silvan");
            AddLink("Timely Aid", "https://www.youtube.com/watch?v=W7o9-R3jX-U", "Apr 20, 2020")
                .WithLabels("Secrecy", "Ally Mustering");
            AddLink("Sarah McLeod intros Rosie Cotton", "https://www.youtube.com/shorts/UeccVd2y_bg", "Apr 13, 2020")
                .WithLabels("Hobbit", "Ally Stat Boost");
            AddLink("Guests Chad G. and Christian S. Talk About Rosie Cotton", "https://www.youtube.com/watch?v=MOy90l4xN_g", "Apr 13, 2020")
                .WithLabels("Hobbit", "Ally Stat Boost");
            AddLink("Guest Host Steve Majka AKA Vardean", "https://www.youtube.com/watch?v=gQZXqBm21nU", "Apr 6, 2020")
                .WithLabels("Elwing's Flight", "Readying", "Willpower Boost");
            AddLink("Unexpected Courage", "https://www.youtube.com/watch?v=rwvQ1fWJjPA", "Mar 23, 2020")
                .WithLabels("Readying");
            AddLink("Guest Host John Rogers 2", "https://www.youtube.com/watch?v=DjvGDMujpwM", "Mar 16, 2020")
                .WithLabels("Con of the Rings 2020");
            AddLink("Guest Host Mark Chan", "https://www.youtube.com/watch?v=OLsUNfZ0b4c", "Mar 9, 2020")
                .WithLabels("RiddermarkLord", "alt-art");
            AddLink("Risk Some Light", "https://www.youtube.com/watch?v=WCRcufaKTUE", "Mar 2, 2020")
                .WithLabels("Secrecy", "Encounter Deck Control");
            AddLink("Guest Hosts Caleb Grace and Matt Newman", "https://www.youtube.com/watch?v=JhJNfdakreg", "Feb 28, 2020")
                .WithLabels("Eomer", "Lothiriel", "Rohan", "Gondor");
            AddLink("Guest Host Brandon", "https://www.youtube.com/watch?v=oUgxfAOB63o", "Feb 26, 2020")
                .WithLabels("Boromir (tactics hero)", "Errata");
            AddLink("Spirit Theoden and Theodred", "https://www.youtube.com/watch?v=CgPbdaWyK30", "Feb 24, 2020")
                .WithLabels("Theoden (spirit hero)", "Theodred", "Rohan", "Cost Reduction", "Resource Acceleration");
            AddLink("Guest Host Ava Walsh", "https://www.youtube.com/watch?v=_paOA44ZyGI", "Feb 21, 2020")
                .WithLabels("Gandalf (core)");
            AddLink("Spirit Legolas and Leadership Gimli", "https://www.youtube.com/watch?v=PFZ92neleus", "Feb 19, 2020")
                .WithLabels("Legolas (spirit hero)", "Gimli (leadership hero)");
            AddLink("Guest Host Katie Muir", "https://www.youtube.com/watch?v=ppE7FZM2its", "Feb 14, 2020")
                .WithLabels("Gimli (leadership ally)");
            AddLink("Guest Hosts Sarah and Jason", "https://www.youtube.com/watch?v=mI5exBd6etA", "Feb 12, 2020")
                .WithLabels("Kahliel");
            AddLink("Smeagol and The One Ring", "https://www.youtube.com/watch?v=AkIEyaZGfdg", "Feb 10, 2020")
                .WithLabels("Smeagol (hero)", "Gollum", "The One Ring", "Stinker");
            AddLink("Guest Host Chloe Walsh", "https://www.youtube.com/watch?v=SAmEgdIw-0U", "Feb 7, 2020")
                .WithLabels("Smeagol (hero)", "Stinker");
            AddLink("Guest Host Tolkien Road", "https://www.youtube.com/watch?v=-kSqKjSxQmc", "2020-02-05T17:00:00+00:00")
                .WithLabels("Legendarium", "The Lord of the Rings", "Middle-earth", "Haldan");
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
            AddLink("SPOILER!!! Lore Saruman and Saruman's Staff", "https://www.youtube.com/watch?v=TO4FsbhkF0Y", "Nov 14, 2019")
                .WithLabels("Saruman (lore hero)", "Saruman's Staff", "Doomed", "Readying", "Resource Smoothing", "Spoiler");
            AddLink("Fortune or Fate", "https://www.youtube.com/watch?v=9ZmvaFVWyuY", "Nov 13, 2019")
                .WithLabels("Hero Recursion");
            AddLink("Guest Host Aaron Fishbaugh", "https://www.youtube.com/watch?v=7biEGd9OXn8", "Nov 4, 2019")
                .WithLabels("Dori (tactics hero)");
            AddLink("Leadership Orcrist", "https://www.youtube.com/watch?v=uR-u8gl6K2s", "Oct 28, 2019")
                .WithLabels("Orcrist (attachment)", "Guarded (enemy or location)", "Attack Boost", "Resource Acceleration");
            AddLink("Con of the Rings Recap", "https://www.youtube.com/watch?v=zMFGX5Rf5IM", "Oct 23, 2019")
                .WithLabels("Con of the Rings 2019");
            AddLink("The King's Return", "https://www.youtube.com/watch?v=BdUzTEA5O-I", "Oct 21, 2019")
                .WithLabels("Card Fetch", "Guarded Attachments");
            AddLink("Lore Glamdring", "https://www.youtube.com/watch?v=AX3RZed8wm8", "Oct 14, 2019")
                .WithLabels("Glamdring (attachment)", "Guarded (enemy or location)", "Attack Boost", "Card Draw");
            AddLink("Con of the Rings Designer Interview", "https://www.youtube.com/watch?v=Ujl1Qi5l7lw", "Oct 10, 2019")
                .WithLabels("Con of the Rings 2019", "Caleb Grace", "Matt Newman");
            AddLink("Con of the Rings Reflections", "https://www.youtube.com/watch?v=hSIi3PBwBW0", "Oct 9, 2019")
                .WithLabels("Con of the Rings 2019", "Joseph Forster", "Caleb Grace", "John Rogers", "Dan Poage", "Derek Kamal");
            AddLink("Necklace of Girion", "https://www.youtube.com/watch?v=hSIi3PBwBW0", "Sep 30, 2019")
                .WithLabels("Guarded (enemy or location)", "Willpower Boost", "Resource Acceleration");
            AddLink("Guest Host Kristian Priisholm", "https://www.youtube.com/watch?v=B5-NPX9tcDs", "Sep 24, 2019")
                .WithLabels("Ring of Thror", "Guarded (enemy or location)", "Dwarf", "Readying", "Attachment Mustering");
            AddLink("Mithril Shirt", "https://www.youtube.com/watch?v=LVrPvUtOhLQ", "Sep 16, 2019")
                .WithLabels("Mithril Shirt", "Guarded (location)", "Damage Prevention");
            AddLink("Community Tales - August 2019", "https://www.youtube.com/watch?v=5_oNzotrcuw", "Sep 12, 2019")
                .WithLabels("Community", "Reddit Poem");
            AddLink("The Arkenstone", "https://www.youtube.com/watch?v=usT_akP67DE", "Sep 9, 2019")
                .WithLabels("The Arkenstone (attachment)", "Guarded (enemy or location)", "Willpower Boost", "Threat Reduction", "Threat Smoothing", "Multiplayer");
            AddLink("Sting", "https://www.youtube.com/watch?v=ljaGNpy4QB4", "Aug 26, 2019")
                .WithLabels("Sting (attachment)", "Guarded (enemy)", "Willpower Boost", "Attack Boost", "Defense Boost", "Direct Damage");
            AddLink("Revisiting Tactics Hero Bilbo", "https://www.youtube.com/watch?v=PuMvS6-BZyc", "Aug 19, 2019")
                .WithLabels("Bilbo (tactics hero)", "Guarded Attachments", "Direct Damage", "Willpower Boost", "Staging Area Control");
            AddLink("Guest Host Derek Kamal", "https://www.youtube.com/watch?v=9jWUY-ZA338", "Aug 12, 2019")
                .WithLabels("Small Target", "Hobbit", "Combat Control");
            AddLink("Guest Host Matt Duckworth", "https://www.youtube.com/watch?v=IqUlz8J-3so", "Aug 8, 2019")
                .WithLabels("Faramir (lore hero)", "Attack Boost");
            AddLink("Community Tales July 2019 - GENCON EPISODE", "https://www.youtube.com/watch?v=99EWpqYka9U", "Aug 5, 2019")
                .WithLabels("GenCon 2019", "Community");
            AddLink("Fords of Isen", "https://www.youtube.com/watch?v=aPndsEhejwk", "Jul 23, 2019")
                .WithLabels("Fords of Isen", "Two Player", "Fastred", "Dunhere", "Glorfindel (spirit hero)", "Galadriel (hero)", "Gandalf (hero)", "Elrond (lore hero)");
            AddLink("Legacy of Numenor", "https://www.youtube.com/watch?v=BY4NnZpFEnA", "Jul 22, 2019")
                .WithLabels("Doomed", "Resource Acceleration");
            AddLink("Flight from Moria", "https://www.youtube.com/watch?v=rz12xxJNvEc", "Jul 17, 2019")
                .WithLabels("Flight from Moria", "Celeborn (hero)", "Galadriel (hero)", "Thranduil (hero)");
            AddLink("Ancient Mathoms Ep 2. Tactics Core Cards", "https://www.youtube.com/watch?v=DPujons7qzU", "Jul 16, 2019")
                .WithLabels("Tactics", "Core Set Player Cards");
            AddLink("Grima", "https://www.youtube.com/watch?v=s0pbNflnAnw", "Jul 15, 2019")
                .WithLabels("Doomed", "Cost Reduction");
            AddLink("Treachery of Rhudaur 2P", "https://www.youtube.com/watch?v=MG6TukqIG0Y", "Jul 11, 2019")
                .WithLabels("Treachery of Rhudaur", "Two Player", "Hirgon (hero)", "Grimbeorn the Old (hero)", "Theodred (hero)", "Galadriel (hero)", "Elrond (hero)", "Gandalf (hero)");
            AddLink("Across the Ettenmoors 2P", "https://www.youtube.com/watch?v=0yJGoVq5gTQ", "Jul 10, 2019")
                .WithLabels("Across the Ettenmoors", "Two Player", "Hirgon (hero)", "Grimbeorn the Old (hero)", "Theodred (hero)", "Galadriel (hero)", "Elrond (hero)", "Gandalf (hero)");
            AddLink("Ancient Mathoms Ep. 1 - Leadership Core Cards", "https://www.youtube.com/watch?v=EkSgKPzlxwA", "Jul 9, 2019")
                .WithLabels("Leadership", "Core Set Player Cards");
            AddLink("Guest Host Ted Banach, Winner of the \"Set Us Straight\" Contest", "https://www.youtube.com/watch?v=2C0MnI3BEY8", "Jul 8, 2019")
                .WithLabels("Gandalf (hero)");
            AddLink("Leadership Hero Frodo", "https://www.youtube.com/watch?v=voyjQpgv-38", "Jul 1, 2019")
                .WithLabels("Frodo Baggins (leadership hero)", "Treach Reduction", "Readying");
            AddLink("Community Tales June 2019", "https://www.youtube.com/watch?v=rt7Hsx9PzyI", " Jul 1, 2019")
                .WithLabels("Community", "News");
            AddLink("Fellowship", "https://www.youtube.com/watch?v=EIq9McKSgLM", "Jun 20, 2019")
                .WithLabels("Fellowship Contract", "Unique Allies");
            AddLink("Shadowfax", "https://www.youtube.com/watch?v=sEJFU4mc7us", "Jun 18, 2019")
                .WithLabels("Readying", "Gandalf", "Sentinel", "Ranged");
            AddLink("Elrond's Counsel", "https://www.youtube.com/watch?v=xFfG-JOyxog", "Jun 10, 2019")
                .WithLabels("Willpower Boost", "Threat Reduction", "Noldor", "Silvan");
            AddLink("Around the Community May 2019", "https://www.youtube.com/watch?v=L_wXAB7kmaI", "Jun 6, 2019")
                .WithLabels("Community", "News");
            AddLink("Tactics Hero Gimli", "https://www.youtube.com/watch?v=O3qF0pBo8dQ", "Jun 4, 2019")
                .WithLabels("Gimli (tactics hero)", "Hit Point Boost");
            AddLink("Fast Hitch", "https://www.youtube.com/watch?v=id1bxeLkayk", "May 20, 2019")
                .WithLabels("Readying", "Hobbit");
            AddLink("Journey Along the Anduin", "https://www.youtube.com/watch?v=DjxHXPePv7A", "May 16, 2019")
                .WithLabels("Core Set Quests");
            AddLink("The Ghost of Framsburg Silvan", "https://www.youtube.com/watch?v=3ZmxZEl6fu4", "May 14, 2019")
                .WithLabels("The Ghost of Framsburg", "Silvan", "Galadriel (hero)", "Celeborn (hero)", "Tranduil");
            AddLink("Guest Host John Rogers, Con of the Rings", "https://www.youtube.com/watch?v=YEXJp-dXScA", "May 13, 2019")
                .WithLabels("Con of the Rings 2019");
            AddLink("Lore Pippin", "https://www.youtube.com/watch?v=65-JyuB3Yww", "May 6, 2019")
                .WithLabels("Hobbit", "Card Draw", "Optional Engagement", "Staging Area Control");
            AddLink("Around the Community - April 2019", "https://www.youtube.com/watch?v=dNLpKyK9Rmw", "May 1, 2019")
                .WithLabels("Community", "News");
            AddLink("Journey Along the Anduin w/ Hobbit Taticians", "https://www.youtube.com/watch?v=uNaF2vSlzZM", "May 1, 2019")
                .WithLabels("Jounrey Along the Anduin", "Tom Cotton", "Bilbo Baggins (tactics hero)", "Merry (tactics hero)");
            AddLink("Which Aragorn?", "https://www.youtube.com/watch?v=U7EV9b5oN0k", "Apr 29, 2019")
                .WithLabels("Aragorn (leadership hero)", "Aragorn (lore hero)", "Aragorn (tactics hero)");
            AddLink("Brok Ironfist", "https://www.youtube.com/watch?v=H5IeA9H9dx4", "Apr 22, 2019")
                .WithLabels("Dwarf");
            AddLink("Deck Construction: The Rise of the Hobbit Tacticians", "https://www.youtube.com/watch?v=HtwszRjcKeA", "Apr 16, 2019")
                .WithLabels("Tom Cotton", "Bilbo Baggins (tactics hero)", "Merry (tactics hero)");
            AddLink("Fastred", "https://www.youtube.com/watch?v=goxYp3u1j5M", "Apr 15, 2019")
                .WithLabels("Staging Area Control", "Threat Reduction");
            AddLink("Lure of Middle-earth Recap with Dominik Schonleben", "https://www.youtube.com/watch?v=mSRDNow0ml4", "Apr 10, 2019")
                .WithLabels("Lure of Middle-earth 2019");
            AddLink("Around the Community March 2019", "https://www.youtube.com/watch?v=fLkRzQOyvfE", "Apr 7, 2019")
                .WithLabels("Community", "News");
            AddLink("Hero Smeagol", "https://www.youtube.com/watch?v=UmQ3fhAF-OQ", "Apr 4, 2019")
                .WithLabels("Smeagol (hero)", "Gollum (enemy)", "Stinker");
            AddLink("Frodo's Intuition", "https://www.youtube.com/watch?v=W_E3ytrPTsE", "Apr 2, 2019")
                .WithLabels("Fellowship", "Saga", "Hobbit", "Willpower Boost", "Card Draw");
            AddLink("Treachery of Rhudaur Dwarf Mining", "https://www.youtube.com/watch?v=RtlC6SQ8WCU", "Mar 20, 2019")
                .WithLabels("Treachery of Rhudaur", "Dwarf Mining", "Oin (hero)", "Thorin Oakenshield (hero)", "Dain Ironfoot (spirit hero)");
            AddLink("Guest Host Beorn (Dan Poage)", "https://www.youtube.com/watch?v=fn2EF3ivD4Q", "Mar 18, 2019")
                .WithLabels("Beorn (tactics hero)");
            AddLink("Celebrimbor's Secret Dwarf Mining", "https://www.youtube.com/watch?v=Ve3rZRrPjDg", "Mar 12, 2019")
                .WithLabels("Celebrimbor's Secret", "Dwarf Mining", "Oin (hero)", "Thorin Oakenshield (hero)", "Dain Ironfoot (spirit hero)");
            AddLink("Hero Elrond", "https://www.youtube.com/watch?v=LugsC5Luggs", "Mar 11, 2019")
                .WithLabels("Elrond (lore hero)", "Vilya", "Healing", "Resource Smoothing");
            AddLink("Guest Host Daan Prins (Durin's Father)", "https://www.youtube.com/watch?v=vwi1CM12sYM", "Mar 4, 2019")
                .WithLabels("Idraen", "Location Control", "Readying");
            AddLink("Around the Community February 2019", "https://www.youtube.com/watch?v=9KkzZM6-T9M", "Mar 1, 2019")
                .WithLabels("Community", "News");
            AddLink("Lost in Mirkwood Two Player", "https://www.youtube.com/watch?v=yTG9s6TOB2s", "Feb 28, 2019")
                .WithLabels("Lost in Mirkwood", "Two Player Game", "Thranduil (hero)", "Celeborn (hero)", "Galadriel (spirit hero)", "Hirgon (hero)", "Grimbeorn the Old (tactics hero)", "Theodred (leadership hero)");
            AddLink("The Seventh Level", "https://www.youtube.com/watch?v=BhaL9JOfhtA", "Feb 28, 2019")
                .WithLabels("The Seventh Level (quest)", "Celeborn (hero)", "Galadriel (spirit hero)", "Thranduil (leadership hero)");
            AddLink("Quicker Than Sight", "https://www.youtube.com/watch?v=Z2w8DW9JrH8", "Feb 27, 2019")
                .WithLabels("Shadow Cancellation", "Silvan Bounce");
            AddLink("Island Amid Perils", "https://www.youtube.com/watch?v=aiwI0zinpl0", "Feb 26, 2019")
                .WithLabels("Threat Reduction", "Silvan Bounce");
            AddLink("Feigned Voices", "https://www.youtube.com/watch?v=w_kLfmhYvow", "Feb 25, 2019")
                .WithLabels("Combat Control", "Silvan Bounce");
            AddLink("Into the Pit Silvans", "https://www.youtube.com/watch?v=m65kZStGmLk", "Feb 24, 2019")
                .WithLabels("Into the Pit (quest)", "Silvan", "Celeborn (hero)", "Galadriel (spirit hero)", "Thranduil (hero)");
            AddLink("The Three People", "https://www.youtube.com/watch?v=oDirdMoywAY", "Feb 23, 2019")
                .WithLabels("Ally Mustering", "Silvan Bounce", "Card Fetch");
            AddLink("O Lorien!", "https://www.youtube.com/watch?v=VVUORHCNZpI", "Feb 22, 2019")
                .WithLabels("Cost Reduction", "Silvan");
            AddLink("Across the Ettenmoors Two Player", "https://www.youtube.com/watch?v=rRCgwT6OSdA", "Feb 21, 2019")
                .WithLabels("Across the Ettenmoors (quest)", "Two Player Game", "Thranduil (hero)", "Celeborn (hero)", "Galadriel (spirit hero)", "Grimebeorn the Old (tactics hero)", "Hirgon (hero)", "Theodred (hero)");
            AddLink("The Elvenking", "https://www.youtube.com/watch?v=PTGngcecUZg", "Feb 20, 2019")
                .WithLabels("Readying", "Silvan Bounce");
            AddLink("Orophin", "https://www.youtube.com/watch?v=b1lBzY9O-8U", "Feb 19, 2019")
                .WithLabels("Ranged", "Silvan Bounce", "Ally Recursion");
            AddLink("Greenwood Archer", "https://www.youtube.com/watch?v=BbzpqyF3Smk", "Feb 18, 2019")
                .WithLabels("Ranged", "Hero Readying", "Silvan Bounce");
            AddLink("Galion", "https://www.youtube.com/watch?v=TAvzp7r1WS0", "Feb 16, 2019")
                .WithLabels("Silvan Bounce");
            AddLink("Galadhrim Weaver", "https://www.youtube.com/watch?v=3aDY1kK9jEQ", "Feb 15, 2019")
                .WithLabels("Discard Pile Recursion", "Silvan Bounce");
            AddLink("Lost in Mirkwood - Silvans", "", "")
                .WithLabels("Lost in the Mirkwood (quest)", "Celeborn (hero)", "Galadriel (spirit hero)", "Thranduil (hero)");
            AddLink("Galadhon Archer", "https://www.youtube.com/watch?v=NTmX5j8dEN0", "Feb 13, 2019")
                .WithLabels("Ranged", "Silvan Bounce", "Direct Daamge");
            AddLink("Galadhrim Minstrel", "https://www.youtube.com/watch?v=j8rH2hjKip8", "Feb 12, 2019")
                .WithLabels("Silvan Bounce", "Event Card Fetch");
            AddLink("Thranduil", "https://www.youtube.com/watch?v=KodzqO_5dqQ", "Feb 11, 2019")
                .WithLabels("Silvan Bounce", "Resource Smoothing", "Combat Control");
            AddLink("Rumil", "https://www.youtube.com/watch?v=bCtTScx8xj0", "Feb 8, 2019")
                .WithLabels("Silvan Bounce", "Ranged", "Direct Damage");
            AddLink("Journey Along the Anduin", "https://www.youtube.com/watch?v=roRQi38aaF8", "Feb 7, 2019")
                .WithLabels("Celeborn (hero)", "Galadriel (spirit hero)", "Thranduil (hero)");
            AddLink("Silvan Tracker", "https://www.youtube.com/watch?v=k_gqWSE1VI0", "Feb 6, 2019")
                .WithLabels("Healing", "Silvan (trait)");
            AddLink("Naith Guide", "https://www.youtube.com/watch?v=WJnhN3OZ40E", "Feb 5, 2019")
                .WithLabels("Action Advantage", "Silvan Bounce");
            AddLink("Celeborn", "https://www.youtube.com/watch?v=yFriaWoXITk", "Feb 4, 2019")
                .WithLabels("Silvan (trait)", "Silvan Bounce", "Willpower Boost", "Attack Boost", "Defense Boost");
            AddLink("Passage Through Mirkwood", "https://www.youtube.com/watch?v=2lLvf_3J_6c", "Feb 2, 2019")
                .WithLabels("Passage Through Mirkwood (quest)", "Celeborn (hero)", "Galadriel (spirit hero)", "Thranduil (hero)");
            AddLink("Around the Community January 2019", "https://www.youtube.com/watch?v=gVH6PnOulkA", "Feb 1, 2019")
                .WithLabels("Community", "News");
            AddLink("The Hunt for Gollum Silvan", "https://www.youtube.com/watch?v=0j8xzyqN2kQ", "Jan 29, 2019")
                .WithLabels("The Hunt for Gollum (quest)", "Celeborn (hero)", "Galadriel (spirit hero)", "Thranduil (hero)");
            AddLink("Guest Host Dominik Schonleben", "https://www.youtube.com/watch?v=v_eW--zmeXs", "Jan 28, 2019")
                .WithLabels("Saruman (ally)", "Doomed", "Staging Area Control");
            AddLink("Silvan February", "https://www.youtube.com/watch?v=8i7JvlL8quk", "Jan 22, 2019")
                .WithLabels("Silvan (trait)");
            AddLink("Guest Host Ian Martin", "https://www.youtube.com/watch?v=TlKrfIebrUo", "Jan 21, 2019")
                .WithLabels("Palantir (attachment)", "Encounter Deck Control", "Scrying", "Card Draw");
            AddLink("Sauron's Reach", "https://www.youtube.com/watch?v=UZvqZPgg2ks", "Jan 17, 2019")
                .WithLabels("Sauron's Reach (encounter set)");
            AddLink("Tactics Aragorn", "https://www.youtube.com/watch?v=mDRI9xCoZ08", "Jan 14, 2019")
                .WithLabels("Aragorn (tactics hero)", "Staging Area Control");
            AddLink("Guest Host Mr. Underhill", "", "Jan 7, 2019")
                .WithLabels("Aragorn (lore hero)", "Threat Reduction", "Doomed");
            
            AddYear(2018);
            AddLink("Spirit Theoden", "https://www.youtube.com/watch?v=juH70c-BcGw", "Dec 24, 2018")
                .WithLabels("Theoden (spirit hero)", "Rohan", "Cost Reduction");
            AddLink("Wilderlands", "https://www.youtube.com/watch?v=g30rNrRap9o", "Dec 20, 2018")
                .WithLabels("Wilderlands (encounter set)");
            AddLink("Escort from Edoras", "https://www.youtube.com/watch?v=nCgBjzaJ6UI", "Dec 17, 2018")
                .WithLabels("Rohan Sacrifice", "Willpower Boost");
            AddLink("Guest Host Chris Standford", "https://www.youtube.com/watch?v=DjN-FdkYxwU", "Dec 10, 2018")
                .WithLabels("Erestor (lore hero)", "Card Draw", "Noldor Discard");
            AddLink("Gaffer Gamgee", "https://www.youtube.com/watch?v=97eTgV3r5mw", "Dec 6, 2018")
                .WithLabels("Combat Control", "Hobbit Engagement Control");
            AddLink("Tactics Hero Bilbo", "https://www.youtube.com/watch?v=EBTy_qO_6DM", "Dec 5, 2018")
                .WithLabels("Bilbo Baggins (tactics hero)", "Guarded Attachments", "Direct Damage", "Willpower Boost");
            AddLink("Tactics Eowyn", "https://www.youtube.com/watch?v=2xsa2TPhoRI", "Dec 3, 2018")
                .WithLabels("Eowyn (tactics hero)", "Readying", "Attack Boost");
            AddLink("Guest Host Caleb Grace", "https://www.youtube.com/watch?v=wu5H7MXtX7w", "Nov 26, 2018")
                .WithLabels("Galadriel (spirit hero)", "Action Advantage", "Threat Reduction", "Card Draw");
            AddLink("Friend of Friends", "https://www.youtube.com/watch?v=uTv5cyhC3kM", "Nov 19, 2018")
                .WithLabels("Hobbit", "Willpower Boost", "Attack Boost", "Defense Boost", "Hit Point Boost");
            AddLink("The Oath", "https://www.youtube.com/watch?v=5hyCcPyU6wE", "Nov 14, 2018")
                .WithLabels("The Oath (quest)", "Thorin Stonehelm (tactics hero)", "Bifur (lore hero)", "Glorfindel (lore hero)");
            AddLink("Guest Host John Meek", "https://www.youtube.com/watch?v=EsWcaTxUe1M", "Nov 12, 2018")
                .WithLabels("Fatty Bolger", "Staging Area Control");
            AddLink("The Breaking of the Fellowship", "https://www.youtube.com/watch?v=LIUhe3Y7UBA", "Nov 9, 2018")
                .WithLabels("The Breaking of the Fellowship (quest)", "Saga", "Campaign", "Prince Imrahil (tactics hero)", "Hirluin the Fair", "Denethor (leadership hero)");
            AddLink("Peril in Pelargir", "https://www.youtube.com/watch?v=rlfIitV79a4", "Nov 9, 2018")
                .WithLabels("Peril in Pelargir (quest)", "Theodred (hero)", "Eomer (leadership hero)", "Theoden (spirit hero)");
            AddLink("We Must Away, Ere Break of Day (part 4)", "https://www.youtube.com/watch?v=saVbBFmFZng", "Nov 9, 2018")
                .WithLabels("We Must Away, Ere Break of Day (quest)", "Saga", "Pippin (lore hero)", "Sam Gamgee (leadership hero)", "Merry (tactics hero)");
            AddLink("Over the Misty Mountains Grim", "https://www.youtube.com/watch?v=9lEm8MTzBfE", "Nov 9, 2018")
                .WithLabels("Over the Misty Mountains Grim (quest)", "Saga", "Pippin (lore hero)", "Sam Gamgee (leadership hero)", "Merry (tactics hero)");
            AddLink("We Must Away, Ere Break of Day (part 3)", "https://www.youtube.com/watch?v=bgQHOlBO-5g", "Nov 9, 2018")
                .WithLabels("We Must Away, Ere Break of Day (quest)", "Saga", "Pippin (lore hero)", "Sam Gamgee (leadership hero)", "Merry (tactics hero)");
            AddLink("We Must Away, Ere Break of Day (part 2)", "https://www.youtube.com/watch?v=U8-r3tFMbm4", "Nov 9, 2018")
                .WithLabels("We Must Away, Ere Break of Day (quest)", "Saga", "Pippin (lore hero)", "Sam Gamgee (leadership hero)", "Merry (tactics hero)");
            AddLink("We Must Away, Ere Break of Day (part 1)", "https://www.youtube.com/watch?v=YUnsJfs9-us", "Nov 9, 2018")
                .WithLabels("We Must Away, Ere Break of Day (quest)", "Saga", "Pippin (lore hero)", "Sam Gamgee (leadership hero)", "Merry (tactics hero)");
            AddLink("The Hunt for Gollum (part 2)", "https://www.youtube.com/watch?v=Igezaiyubus", "Nov 9, 2018")
                .WithLabels("The Hunt for Gollum (quest)", "Legolas (tactics hero)", "Haldir of Lorien (lore hero)", "Glorfindel (spirit hero)");
            AddLink("Conflict at the Carrock (part 2)", "https://www.youtube.com/watch?v=lRTLQrRItXg", "Nov 8, 2018")
                .WithLabels("Conflict at the Carrock (quest)", "Legolas (tactics hero)", "Haldir of Lorien (lore hero)", "Glorfindel (spirit hero)");
            AddLink("Conflict at the Carrock (part 1)", "https://www.youtube.com/watch?v=rNIDnb_YmzE", "Nov 8, 2018")
                .WithLabels("Conflict at the Carrock (quest)", "Legolas (tactics hero)", "Haldir of Lorien (lore hero)", "Glorfindel (spirit hero)");
            AddLink("The Hunt for Gollum (part 1)", "https://www.youtube.com/watch?v=SRN3c9v0OVg", "Nov 8, 2018")
                .WithLabels("The Hunt for Gollum (quest)", "Legolas (tactics hero)", "Haldir of Lorien (lore hero)", "Glorfindel (spirit hero)");
            AddLink("Guest Host Samuel Shreeve", "https://www.youtube.com/watch?v=2hNfQ81GZzY", "Nov 8, 2018")
                .WithLabels("Theoden (tactics hero)", "Willpower Boost");
            AddLink("Dunedain Mark", "https://www.youtube.com/watch?v=8Rilf5n0DGE", "Nov 8, 2018")
                .WithLabels("Attack Boost", "Signal");
            AddLink("Guest Host Chad Garlinghouse", "https://www.youtube.com/watch?v=1lF1iO2gNFM", "Nov 8, 2018")
                .WithLabels("Haldir of Lorien (lore hero)", "Staging Area Attack", "Combat Control");
            AddLink("Andrath Guardsman", "https://www.youtube.com/watch?v=o2S7-2XjZNs", "Nov 8, 2018")
                .WithLabels("Combat Control", "Engaged Enemies");
            AddLink("Passage Through Mirkwood", "https://www.youtube.com/watch?v=cgtqUfZMl4w", "Nov 8, 2018")
                .WithLabels("Passage Through Mirkwood (encounter set)");
            AddLink("Dol Guldur Orcs", "https://www.youtube.com/watch?v=2YRJkI9keyk", "Nov 8, 2018")
                .WithLabels("Dol Guldur Orcs (encounter set)");
            AddLink("Spiders of Mirkwood", "https://www.youtube.com/watch?v=XnwDbqvY_9Q", "Nov 8, 2018")
                .WithLabels("Spiders of Mirkwood (encounter set)");
            AddLink("Ithilien Archer", "https://www.youtube.com/watch?v=3gLWmi1vK-Q", "Nov 8, 2018")
                .WithLabels("Ranger", "Staging Area Control");
            AddLink("Dunhere", "https://www.youtube.com/watch?v=ZRBt_-dYUbE", "Nov 8, 2018")
                .WithLabels("Staging Area Attack", "Attack Boost");
            AddLink("Lore Hero Denethor", "https://www.youtube.com/watch?v=EMHVqc9RRH4", "Nov 8, 2018")
                .WithLabels("Denethor (lore hero)", "Encounter Deck Control", "Encounter Deck Scrying");
            AddLink("Hero Gandalf", "https://www.youtube.com/watch?v=15gwVHUKQlo", "Nov 8, 2018")
                .WithLabels("Gandalf (hero)", "Player Deck Scrying");
            AddLink("Tactics Merry", "https://www.youtube.com/watch?v=CG0gSJowMo4", "Nov 8, 2018")
                .WithLabels("Merry (tactics hero)", "Attack Boost", "Readying");
            AddLink("Gondorian Spearman", "https://www.youtube.com/watch?v=k0z1wR3-n2Y", "Nov 8, 2018")
                .WithLabels("Direct Damage");
            AddLink("Hirluin the Fair", "https://www.youtube.com/watch?v=ZbZcDIFLH-4", "Nov 8, 2018")
                .WithLabels("Outlands", "Resource Smoothing", "Ranged");
            AddLink("Send for Aid", "https://www.youtube.com/watch?v=bTq6A2ngT0A", "Nov 8, 2018")
                .WithLabels("Side Quest", "Ally Mustering");
            AddLink("Get to Know Your Host", "https://www.youtube.com/watch?v=luGxlDt_zCA", "Nov 8, 2018")
                .WithLabels("Grant Thompson");
            AddLink("Escape from Dol Guldur (part 4)", "https://www.youtube.com/watch?v=ehhcIc8h4RU", "Nov 2, 2018")
                .WithLabels("Escape from Dol Guldur (quest)", "Legolas (tactics hero)", "Haldir of Lorien (lore hero)", "Glorfindel (spirit hero)");
            AddLink("Escape from Dol Guldur (part 3)", "https://www.youtube.com/watch?v=6-Yew-Ge2jY", "Nov 2, 2018")
                .WithLabels("Escape from Dol Guldur (quest)", "Legolas (tactics hero)", "Haldir of Lorien (lore hero)", "Glorfindel (spirit hero)");
            AddLink("Escape from Dol Guldur (part 2)", "https://www.youtube.com/watch?v=AMgoaQSqPv8", "Nov 1, 2018")
                .WithLabels("Escape from Dol Guldur (quest)", "Legolas (tactics hero)", "Haldir of Lorien (lore hero)", "Glorfindel (spirit hero)");
            AddLink("Escape from Dol Guldur (part 1)", "https://www.youtube.com/watch?v=o9dUiCqtmRc", "Nov 1, 2018")
                .WithLabels("Escape from Dol Guldur (quest)", "Legolas (tactics hero)", "Haldir of Lorien (lore hero)", "Glorfindel (spirit hero)");
            AddLink("Guest Host Joseph Forster", "https://www.youtube.com/watch?v=mh39OPSYcQg", "Nov 1, 2018")
                .WithLabels("Cirdan the Shipwright", "Card Draw", "Noldor Discard");
            AddLink("Journey Along the Anduin (part 3)", "https://www.youtube.com/watch?v=GRa4h8skHAQ", "Nov 1, 2018")
                .WithLabels("Journey Along the Anduin (quest)", "Legolas (tactics hero)", "Haldir of Lorien (lore hero)", "Glorfindel (spirit hero)");
            AddLink("Passage Through Mirkwood", "https://www.youtube.com/watch?v=_EtA0kkL1FM", "Nov 1, 2018")
                .WithLabels("Passage Through Mirkwood (quest)", "Legolas (tactics hero)", "Haldir of Lorien (lore hero)", "Glorfindel (spirit hero)");
            AddLink("Journey Along the Anduin (part 2)", "https://www.youtube.com/watch?v=lR4pbnix7H8", "Nov 1, 2018")
                .WithLabels("Journey Along the Anduin (quest)", "Legolas (tactics hero)", "Haldir of Lorien (lore hero)", "Glorfindel (spirit hero)");
            AddLink("Journey Along the Anduin (part 1)", "https://www.youtube.com/watch?v=lbAwKqYahzY", "Nov 1, 2018")
                .WithLabels("Journey Along the Anduin (quest)", "Legolas (tactics hero)", "Haldir of Lorien (lore hero)", "Glorfindel (spirit hero)");
            AddLink("Sneak Attack", "https://www.youtube.com/watch?v=l1ojKMBOnvk", "Nov 1, 2018")
                .WithLabels("Ally Mustering");
            AddLink("Elf Stone", "https://www.youtube.com/watch?v=TL6kKzgHNDE", "Nov 1, 2018")
                .WithLabels("Location Attachment", "Ally Mustering");
            AddLink("Rivendell Blade", "https://www.youtube.com/watch?v=xjUSJ9cJPso", "Nov 1, 2018")
                .WithLabels("Enemy Defense Reduction", "Restricted", "Weapon");
            AddLink("Derndingle Warrior", "https://www.youtube.com/watch?v=uIQKtyMisvY", "Nov 1, 2018")
                .WithLabels("Ent", "Defense Boost");
            AddLink("Leadership Hero Sam Gamgee", "https://www.youtube.com/watch?v=0No_gDKfpl0", "Nov 1, 2018")
                .WithLabels("Sam Gamgee (leadership hero)", "Readying", "Willpower Boost", "Attack Boost", "Defense Boost");
            AddLink("Thalin", "https://www.youtube.com/watch?v=iNM-73K9cP4", "Nov 1, 2018")
                .WithLabels("Thalin (hero)", "Direct Damage");
            AddLink("On The Doorstep Bilbo Baggins", "https://www.youtube.com/watch?v=KDDbeDNgkWg", "Nov 1, 2018")
                .WithLabels("Saga", "Bilbo Baggins (baggins hero)");
            AddLink("Steward of Gondor", "https://www.youtube.com/watch?v=8DJzJugGJhc", "Nov 1, 2018")
                .WithLabels("Reosurce Acceleration");
            AddLink("Leadership Ally Faramir", "https://www.youtube.com/watch?v=j5xO3s1vYac", "Nov 1, 2018")
                .WithLabels("Faramir (leadership ally)", "Willpower Boost", "Ally Swarm");
            AddLink("Citadel Plate", "https://www.youtube.com/watch?v=BoRuqCDJbMM", "Oct 31, 2018")
                .WithLabels("Hit Point Boost", "Restricted");
            AddLink("Spirit Eowyn", "https://www.youtube.com/watch?v=7YVBoI6gZ7c", "Oct 31, 2018")
                .WithLabels("Willpower Boost", "Multiplayer");
            AddLink("Core Gandalf", "https://www.youtube.com/watch?v=_9KnRGBMnYM", "Oct 31, 2018")
                .WithLabels("Gandalf (core)", "Card Draw", "Direct Damage", "Threat Reduction");
            AddLink("Spirit Hero Glorfindel", "https://www.youtube.com/watch?v=OlncM7cv-v0", "Oct 31, 2018")
                .WithLabels("Glorfindel (spirit hero)", "Secrecy", "Threat Raise");
            AddLink("Boots from Erebor", "https://www.youtube.com/watch?v=aiPP9eAFIfs", "Oct 31, 2018")
                .WithLabels("Hobbit", "Dwarf", "Hit Point Boost");
            AddLink("Leadership Aragorn", "https://www.youtube.com/watch?v=dQAkDQSIqnM", "Oct 31, 2018")
                .WithLabels("Aragorn (leadership hero)");
            AddLink("Hero Gloin", "https://www.youtube.com/watch?v=kfPiTlhyVsc", "Oct 31, 2018")
                .WithLabels("Resource Acceleration", "Healing", "Hit Point Boost", "Undefended Attack");
            AddLink("Tactics Hero Boromir", "https://www.youtube.com/watch?v=Tu0GfLHSYPo", "Oct 31, 2018")
                .WithLabels("Boromir (tactics hero)", "Readying", "Errata");
            AddLink("Lore Hero Bilbo", "https://www.youtube.com/watch?v=MwfT1GQq3rU", "Oct 30, 2018")
                .WithLabels("Bilbo Baggins (lore hero)", "Card Draw");
            AddLink("Frodo Baggins", "https://www.youtube.com/watch?v=zKMIzPASWMI", "Oct 29, 2018")
                .WithLabels("Frodo Baggins (spirit)", "Damage Prevention", "Threat Reduction", "Defense");
        }
    }
}