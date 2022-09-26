using System;

namespace HallOfBeorn.Models.LotR.Community.TheBookOfElessar
{
    public class TheBookOfElessarChannel
        : Creator
    {
        public TheBookOfElessarChannel()
            : base("The Book of Elessar",
            "https://www.youtube.com/channel/UCUgU6nIpwNlADThJKEDV3Pg",
            "https://www.youtube.com/feeds/videos.xml?channel_id=UCUgU6nIpwNlADThJKEDV3Pg",
            LinkType.The_Book_of_Elessar)
        {
            AddYear(2022);
            AddLink("Escape from Mt. Gram (Angmar Awakened Campaign, pt. 5)", "https://www.youtube.com/watch?v=1J6MY1AGwtQ", "23 Sep 2022")
                .WithLabels("Escape from Mount Gram", "Angmar Awakened", "#lordoftheringslcg", "#lotrlcg")
                .WithLabels("This is the fifth quest in the Angmar Awakened cycle and new campaign! This is a pretty unique quest that required me to build specifically for it.")
                .WithDeckLabels(31789);
            AddLink("The Wastes of Eriador (Angmar Awakened Campaign, pt. 4)", "https://www.youtube.com/watch?v=kScaltP8J14", "16 Sep 2022")
                .WithLabels("The Wastes of Eriador", "Campaign", "Angmar Awakened", "#lordoftheringslcg", "#lotrlcg")
                .WithLabels("Here's (a very long) game of Wastes of Eriador! This quest can be quite slow because you can only place progress every other round. I got hung up by some curveballs from the encounter deck, too. So, thanks if you stick it out!")
                .WithDeckLabels(31581);
            AddLink("Deadmen's Dike (Angmar Awakened Campaign, pt. 3)", "https://www.youtube.com/watch?v=vWeqiDOpR8o", "9 Sep 2022")
                .WithLabels("Deadmen's Dike", "Angmar Awakened", "Campaign")
                .WithDeckLabels(31390)
                .WithLabels("#lordoftherings", "#lordoftheringslcg", "#lotrlcg", "This is the third quest in the repackaged Angmar Awakened campaign!");
            AddLink("Intruders in Chetwood (Angmar Awakened Campaign, pt. 1)", "https://www.youtube.com/watch?v=_2fAwytTdR8", "26 Aug 2022")
                .WithLables("Campaign", "Angmar Awakened", "Intruders in Chetwood", "#LordoftheRingsLCG", "#LordoftheRings", "#LOTRLCG", "This is the first quest in the new, repackaged Angmar Awakened campaign! Apologies for the weird lighting issues, I'll fix that in the next video.")
                .WithDeckLabels(31092);
            AddLink("There Came Gwaihir the Windlord (Eagles vs The River Running)", "https://www.youtube.com/watch?v=eGo11yW5CGE", "14 Mar 2022")
                .WithLabels("Gwahir", "Radagast", "Eagle", "The River Running", "#LOTRLCG", "#LordoftheRings", "#LivingCardGame")
                .WithLabels("A quick game with my new Gwaihir, Radagast, and eagles deck against The River Running, the first quest in the Shadow in the East deluxe expansion.")
                .WithDeckLabels();
            AddLink("Caves of Nibin-dum — Dark of Mirkwood (Revised Core Set Campaign, pt. 5)", "https://www.youtube.com/watch?v=HE1Fvh6EnxE", "11 Mar 2022")
                .WithLabels("Dark of Mirkwood", "Campaign", "Caves of Nibin-dum", "#lotrlcg", "LordoftheRings", "#LivingCardGame")
                .WithLabels("This is the second quest in the Dark of Mirkwood scenario pack, the Caves of Nibin-dum. I'm continuing the campaign mode from the new revised core set. If you only want to watch the game that I win, you can skip ahead to about the 26:00 mark. This is the deck I'm using through this campaign.")
                .WithDeckLabels(18253);
            AddLink("The Oath — Dark of Mirkwood (Revised Core Set Campaign, pt. 4)", "https://www.youtube.com/watch?v=vdsgf8Yze-k", "26 Feb 2022")
                .WithLabels("Dark of Mirkwood", "Campaign", "#LOTRLCG", "#LordoftheRings", "#LivingCardGame")
                .WithLabels("This is the first quest in the Dark of Mirkwood scenario pack. While this pack released on Feb. 25, 2022, these two quests were earlier released for the Collector's Edition 2-player starter. I never played them at that point in time, so this is fresh for me! This continues the campaign from the revised core set, and I am using the same deck as I used in those videos")
                .WithDeckLabels(18253);
            AddLink("Escape from Dol Guldur (Revised Core Set Campaign, pt. 3)", "https://www.youtube.com/watch?v=3fzb_CSb4Xk", "6 Feb 2022")
                .WithLabels("Revised Core Set", "Campaign", "Escape from Dol Guldur", "#LOTRLCG", "#LordoftheRings", "#LivingCardGame")
                .WithLabels("The revised core set for the Lord of the Rings Living Card Game released in January and with a new campaign mode for the 3 quests. This is the third quest, Escape from Dol Guldur, in campaign mode!")
                .WithDeckLabels(18253);
            AddLink("Journey Along the Anduin (Revised Core Set Campaign, pt. 2)", "https://www.youtube.com/watch?v=qf8_zym2No8", "4 Feb 2022")
                .WithLabels("Revised Core Set", "Campaign", "Journey Along the Anduin", "#LOTRLCG", "#LordoftheRings", "#LivingCardGame")
                .WithLabels("The revised core set for the Lord of the Rings Living Card Game released in January and with a new campaign mode for the 3 quests. This is the second quest, Journey Along the Anduin, in campaign mode! I am using a non-core-only deck, with a Silvan elf theme.")
                .WithDeckLabels(18253);
            AddLink("Passage Through Mirkwood (Revised Core Set Campaign, pt. 2)", "https://www.youtube.com/watch?v=TmB1xcJozmY", "2 Feb 2022")
                .WithLabels("Revised Core Set", "Campaign", "Passage Through Mirkwood", "#LOTRLCG", "#LordoftheRings", "#LivingCardGame")
                .WithLabels("The revised core set for the Lord of the Rings Living Card game released in January and with a new campaign mode for the 3 quests. This is the first quest, Passage through Mirkwood, in campaign mode! I am using a non-core-only deck, with a Silvan elf theme.")
                .WithDeckLabels(18253);
            
            AddYear(2021);
            AddLink("Gondor v Peril in Pelargir & Steward's Fear (Gondor's Perilous Valour)", "https://www.youtube.com/watch?v=3ay43ScHu7g", "1 Feb 2021")
                .WithLabels("Peril in Pelargir", "Steward's Fear", "#LordoftheRings", "#LOTRLCG")
                .WithLabels("Two more games with my Gondor's Perilous Valour deck! This deck uses the newest, and likely final, contract, A Perilous Voyage. This time, I actually was able to use it to full effect and flip it to side B. I felt a little disappointed with how quick and easy my Dreadnaught game was, so I wanted to do more games with this deck.")
                .WithDeckLabels(19372);
            AddLink("The Hunt for the Dreadnaught (Gondor's Perilous Valour)", "https://www.youtube.com/watch?v=Lg5PX3eSjgs", "19 Jan 2021")
                .WithLabels("The Hunt for the Dreadnaught", "#LOTRLCG", "#LordOfTheRings")
                .WithLabels("This is a game featuring the newest contract, A Perilous Voyage, which was released with the Hunt for the Dreadnaught pack! This quest is super fun, and I have grown to love this contract. The game is a bit short, but hope you enjoy!")
                .WithDeckLabels(19372);
            
            AddYear(2020);
            AddLink("The Uruk-hai - Lord of the Rings Living Card Game Saga Campaign", "https://www.youtube.com/watch?v=n4GD0xiNPxs", "16 Dec 2020");
            AddLink("Book of Elessar, Ep. 26 - To Catch an Orc", "https://www.youtube.com/watch?v=6H7V06JX1j8", "3 Dec 2020");
            AddLink("Rohan vs Escape from Umbar and The Mumakil", "https://www.youtube.com/watch?v=4jLK5_GBkgo", "16 Nov 2020");
            AddLink("Book of Elessar, Ep. 15: Shadow and Flame", "https://www.youtube.com/watch?v=H_GKqfPV3Uo", "2020-01-28T01:31:59+00:00");
            AddLink("Book of Elessar, Ep. 14 - Foundations of Stone", "https://www.youtube.com/watch?v=EGergQj7FUM", "2020-01-14T21:19:05+00:00");
            AddLink("Book of Elessar, Ep. 13 - The Long Dark", "https://www.youtube.com/watch?v=fnSPLHYm67A", "2020-01-01T15:01:50+00:00");

            AddYear(2019);
            AddLink("Book of Elessar, Ep. 12: The Watcher in the Water", "https://www.youtube.com/watch?v=4y1vHnvrug8", "2019-12-09T17:40:00+00:00");
            AddLink("Book of Elessar, Ep. 11 - The Road to Rivendell", "https://www.youtube.com/watch?v=Z892GSMaxI4", "2019-12-02T17:30:02+00:00");
            AddLink("Book of Elessar, Ep. 10 - The Redhorn Gate", "https://www.youtube.com/watch?v=4BqnqN1bnio", "2019-11-25T17:01:13+00:00");
            AddLink("Book of Elessar, Ep. 9: Flight from Moria", "https://www.youtube.com/watch?v=ix1BjJlca4I", "2019-11-19T02:00:45+00:00");
            AddLink("Book of Elessar, Ep. 8: The Seventh Level", "https://www.youtube.com/watch?v=YTJJwKTeJt0", "2019-11-11T18:18:36+00:00");
            AddLink("Book of Elessar, Ep. 7 - Into the Pit", "https://www.youtube.com/watch?v=bslrBrSKzHg", "2019-11-04T18:00:02+00:00");
            AddLink("Book of Elessar, Ep. 6: Return to Mirkwood", "https://www.youtube.com/watch?v=NCCL9OrUJ3c", "2019-10-18T17:00:06+00:00");
            AddLink("Book of Elessar, Ep. 5: The Dead Marshes", "https://www.youtube.com/watch?v=MY6OT6OfSzU", "2019-10-11T23:39:21+00:00");
            AddLink("Book of Elessar, Ep. 4: The Hills of Emyn Muil", "https://www.youtube.com/watch?v=QBOG-2GnJNw", "2019-10-04T22:00:34+00:00");
            AddLink("Book of Elessar, Ep. 3: A Journey to Rhosgobel", "https://www.youtube.com/watch?v=YOab58znthI", "2019-09-27T23:08:20+00:00");
            AddLink("Book of Elessar, Ep 2: Conflict at the Carrock", "https://www.youtube.com/watch?v=GDlieGGihL8", "2019-09-21T00:01:53+00:00");
            AddLink("Book of Elessar, Ep.1: The Hunt for Gollum", "https://www.youtube.com/watch?v=mfjEwukJzAk", "2019-09-09T17:19:02+00:00");
        }
    }
}