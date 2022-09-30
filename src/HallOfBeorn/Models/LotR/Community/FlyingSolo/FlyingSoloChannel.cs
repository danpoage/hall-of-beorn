using System;

namespace HallOfBeorn.Models.LotR.Community.FlyingSolo
{
    public class FlyingSoloChannel
        : Creator
    {
        public FlyingSoloChannel()
            : base("Flying Solo", "https://www.youtube.com/channel/UCgpYs4qK_pP5Z8736n7LBSw", "https://www.youtube.com/feeds/videos.xml?channel_id=UCgpYs4qK_pP5Z8736n7LBSw", LinkType.YouTube)
        {
            AddYear(2022);
            AddLink("LOTR Progression 19: Into Ithilien", "https://www.youtube.com/watch?v=S3rWajCjCdI", "2022-09-19")
                .WithLabels("Progression", "Into Ithilien") 
                .WithLabels("A stomp down of this quest! Tune in to catch the losses live on twitch at twitch.tv/FlyingSoloLive");
            AddLink("LOTR LCG Progression pt. 18 Peril in Pelegrir", "https://www.youtube.com/watch?v=CUQEX2Eb0-0", "2022-09-12")
                .WithLabels("Progression", "Peril in Pelargir")
                .WithLabels("Ok we had some connection issues near the end, nothing to bad but I will make a backup video next time instead of just pulling the stream. Deck is here https://ringsdb.com/decklist/view/31463/flyingsoloprogression18perilinpelargir-2.0 This is just the victory so if you want to see all the losses - Im live on twitch at http://twitch.tv/FlyingSoloLive");
            AddLink("LOTR LCG Progression 17 Revenge - Shadow and Flame rematch!", "https://www.youtube.com/watch?v=8XnG-t_-Dqs", "2022-09-11")
                .WithLabels("Progression", "Shadow and Flame")
                .WithDeckLabels(31437)
                .WithLabels("3 years ago I cheated and used burning brand on Aragorn! Now Im back to rectify this! Had a few losses before this one - want to see them? Catch it live on twitch at twitch.tv/FlyingSoloLive Here is the deck. https://ringsdb.com/decklist/view/31437/flyingsololotrprogressionpt17shadowandflame-2.0");
            AddLink("LOTR LCG progression 17 Shadow and Flame", "https://www.youtube.com/watch?v=cFUsVcY3qmg", "2022-02-03")
                .WithLabels("Progression", "Shadow and Flame")
                .WithDeckLabels(14328)
                .WithLabels("Finishing out the Dwarrowdelf cycle today, its a showdown with the Balrog. Here is the deck I used for the quest https://ringsdb.com/decklist/view/14328/flyingsololotrprogressionpt17shadowandflame-1.0 Post any questions, comments or rules corrections below thank you all");

            AddYear(2020);
            AddLink("LOTR LCG progression 16 Foundations of Stone", "https://www.youtube.com/watch?v=P6HkiTEBrSk", "2020-01-26")
                .WithLabels("Progression", "Foundations of Stone")
                .WithDeckLabels(14245)
                .WithLabels("Taking on Foundations of Stone as we close the gap in the Dwarrordelf cycle. Here's the deck I used https://ringsdb.com/decklist/view/14245/flyingsololotrprogressionpt16foundationofstoneyoutu-1.0 Got this in one take, so no death highlights. This is actually a pretty unexciting game, as I got pretty lucky with shadow and breezed past everything. Enjoy hahah!");
            AddLink("LOTR LCG Progression 15 The Long Dark", "https://www.youtube.com/watch?v=JUzmPs3vApA", "2020-01-22")
                .WithLabels("Progression", "The Long Dark")
                .WithDeckLabels(14201)
                .WithLabels("A nice easy romp today, you can view the deck I used here https://ringsdb.com/decklist/view/14201/flyingsololotrprogressionpt15thelongdark-1.0 Follow on mixer here http://mixer.com/flyingsolo And comment, questions, rules posts are all welcome. Next is foundations of stone as we come to the end of dwarrodelf.");
            AddLink("LOTR LCG Proression 14 The Watcher in the Water", "https://www.youtube.com/watch?v=ufOqrLU8tlU", "2022-01-20")
                .WithLabels("Progression", "The Watcher in the Water")
                .WithDeckLabels(189273)
                .WithLabels("This was a rough one, true believers. Many attempts Here's the deck I used https://ringsdb.com/deck/publish/189273 The death highlights start here https://youtu.be/ufOqrLU8tlU?t=1077 Enjoy the game! Post any questions, comments, or rules problems. Next up we go back into the mines with The Long Dark.");
            AddLink("LOTR Progression 13: The Road to Rivendell", "https://www.youtube.com/watch?v=PYr2bD8t80U", "2020-01-15")
                .WithLabels("Progression", "The Road to Rivendell")
                .WithDeckLabels(14135)
                .WithLabels("Hey all here we are on the Road to Rivendell, the deck is here https://ringsdb.com/decklist/view/14135/flyingsololotrprogressionpt13theroadtorivendell-1.0 Stay tuned until the end to see all the deaths before I got this win. Thanks for following!");
            AddLink("LOTR LCG progression series 12: The Redhorn Gate", "https://www.youtube.com/watch?v=EjJnM4BjubI", "2020-01-14")
                .WithLabels("Progression", "Redhorn Gate")
                .WithDeckLabels(14115)
                .WithLabels("Im back! After 6 months, the legend continues. It's the Redhorn gate.' Stay tuned to the end I added a highlight real of my quest failures for your enjoyment! Here is the deck I used https://ringsdb.com/decklist/view/14115/flyingsololotrprogressionpt12theredhorngate-1.0 Enjoy the game and stay tuned for episode 13!");
            
            AddYear(2019);
            AddLink("LOTR Progressions Series Pt. 11. Flight from Moria", "https://www.youtube.com/watch?v=7kbnchLiy3c", "2019-05-30")
                .WithLabels("Progression", "Flight from Moria")
                .WithDeckLabels(12119)
                .WithLabels("Your favourite Solo gamer Returns once again and this time it's down to the depths of Moria as we delve deeper into Moria and face off the Seventh Level. Here is the decklist if you want to see what I'm rolling out with. https://ringsdb.com/decklist/view/121... Like and Subscribe, feel free to comment, if you like it!");
            AddLink("LOTR Progressions Series Pt. 10. The Seventh Level", "https://www.youtube.com/watch?v=PqzplpE1S28", "2019-05-23")
                .WithLabels("Progression", "The Seventh Level")
                .WithDeckLabels(12119)
                .WithLabels("Your favourite Solo gamer Returns once again and this time it's down to the depths of Moria as we delve deeper into Moria and face off the Seventh Level. Here is the decklist if you want to see what I'm rolling out with. https://ringsdb.com/decklist/view/12119/flyingsololotrprogressionpt9intothepit-1.0 Like and Subscribe, feel free to comment, if you like it!");
            AddLink("LOTR Progression 13: The Road to Rivendell", "https://www.youtube.com/watch?v=PYr2bD8t80U", "2020-01-15")
                .WithLabels("Progression", "The Road to Rivendell")
                .WithDeckLabels(14135)
                .WithLabels("Hey all here we are on the Road to Rivendell, the deck is here https://ringsdb.com/decklist/view/14135/flyingsololotrprogressionpt13theroadtorivendell-1.0 Stay tuned until the end to see all the deaths before I got this win. Thanks for following!");
            AddLink("LOTR LCG progression series 12: The Redhorn Gate", "https://www.youtube.com/watch?v=EjJnM4BjubI", "2020-01-14")
                .WithLabels("Progression", "The Redhorn Gate")
                .WithDeckLabels(14115)
                .WithLabels("Im back! After 6 months, the legend continues. It's the Redhorn gate.' Stay tuned to the end I added a highlight real of my quest failures for your enjoyment! Here is the deck I used https://ringsdb.com/decklist/view/14115/flyingsololotrprogressionpt12theredhorngate-1.0 Enjoy the game and stay tuned for episode 13!");
            AddLink("LOTR Progressions Series Pt. 11. Flight from Moria", "https://www.youtube.com/watch?v=7kbnchLiy3c", "2019-05-30")
                .WithLabels("Progression", "Flight from Moria")
                .WithDeckLabels(12119)
                .WithLabels("Your favourite Solo gamer Returns once again and this time it's down to the depths of Moria as we delve deeper into Moria and face off the Seventh Level. Here is the decklist if you want to see what I'm rolling out with. https://ringsdb.com/decklist/view/121... Like and Subscribe, feel free to comment, if you like it!");
            AddLink("LOTR Progressions Series Pt. 10. The Seventh Level", "https://www.youtube.com/watch?v=PqzplpE1S28", "2019-05-23")
                .WithLabels("Progression", "The Seventh Level")
                .WithDeckLabels(12119)
                .WithLabels("Your favourite Solo gamer Returns once again and this time it's down to the depths of Moria as we delve deeper into Moria and face off the Seventh Level. Here is the decklist if you want to see what I'm rolling out with. https://ringsdb.com/decklist/view/12119/flyingsololotrprogressionpt9intothepit-1.0 Like and Subscribe, feel free to comment, if you like it!");
            AddLink("LOTR Progressions Series Pt. 9 Into the pit", "https://www.youtube.com/watch?v=QaMlpnZEHww", "2019-05-14")
                .WithLabels("Progression", "Into the Pit")
                .WithDeckLabels(12119)
                .WithLabels("Your favourite Solo gamer Returns once again and this time it's down to the depths of Moria as we delve into the pit. Here is the decklist if you want to see what I'm rolling out with. https://ringsdb.com/decklist/view/121...This is from my twitch stream at https://www.twitch.tv/flyingsolo so if you hear me talking to people, it's in the chat... I'm not crazy.");
            AddLink("LOTR Progressions Series Pt. 8 Return to Mirkwood.", "https://www.youtube.com/watch?v=fMyved0WnOI", "2019-05-10")
                .WithLabels("Progression", "Return to Mirkwood")
                .WithLabels("Your favourite Solo gamer Returns once again, and again, to Mirkwood. Re Equipped with a new deck and Re Energized with a cup of coffee. This is from my twitch stream at https://www.twitch.tv/flyingsolo so if you hear me talking to people, it's in the chat... I'm not crazy.");
            AddLink("LOTR Progressions Series Pt. 7 The Hills of Emyn Muil.", "https://www.youtube.com/watch?v=2wSV0OtJ6_A", "2019-05-06")
                .WithLabels("Progression", "Return to Mirkwood")
                .WithDeckLabels(154136)
                .WithLabels("Your favourite Solo gamer is sent to capture that slither snake Gollum before he falls into the hands of the enemy. This is from my twitch stream at https://www.twitch.tv/flyingsolo so if you hear me talking to people, it's in the chat... I'm not crazy. Here is the decklist. https://ringsdb.com/deck/view/154136");
            AddLink("LOTR Progressions Series Pt. 6 A Journey To Rhosgobel", "https://www.youtube.com/watch?v=ANm_6RubbNc", "2019-04-26")
                .WithLabels("Progression", "A Journey to Rhosgobel")
                .WithDeckLabels(152086)
                .WithLabels("Your favourite Solo gamer is sent to capture that slither snake Gollum before he falls into the hands of the enemy. This is from my twitch stream at https://www.twitch.tv/flyingsolo so if you hear me talking to people, it's in the chat... I'm not crazy. Here is the decklist. https://ringsdb.com/deck/view/152086");
            AddLink("LOTR Progressions Series Pt. 5 Conflick at the Carrock", "https://www.youtube.com/watch?v=h5L5EGaWWKU", "2019-04-25")
                .WithLabels("Progression", "Conflict at the Carrock")
                .WithDeckLabels(152251)
                .WithLabels("Your favourite Solo gamer is sent to capture that slither snake Gollum before he falls into the hands of the enemy. This is from my twitch stream at https://www.twitch.tv/flyingsolo so if you hear me talking to people, it's in the chat... I'm not crazy. Here is the decklist. https://ringsdb.com/deck/view/152251");
            AddLink("LOTR Progressions Series Pt. 4 The Hunt Begins", "https://www.youtube.com/watch?v=X0CW2TEpt8E", "2019-04-22")
                .WithLabels("Progression", "The Hunt for Gollum")
                .WithDeckLabels(151196)
                .WithLabels("Your favourite Solo gamer is sent to capture that slither snake Gollum before he falls into the hands of the enemy. This is from my twitch stream at https://www.twitch.tv/flyingsolo so if you hear me talking to people, it's in the chat... I'm not crazy. Here is the decklist. https://ringsdb.com/deck/view/151196");
            AddLink("Flying Solo LOTR LCG Progression Escape from Dol Guldur", "https://www.youtube.com/watch?v=9du0Tz_JkKw", "2019-04-19")
                .WithLabels("Progression", "Escape from Dol Guldur")
                .WithLabels("Taking on the famously difficult Escape from Dol Guldur. True Solo. Oh yes.");
            AddLink("LOTR LCG Progression Style Journey Along the Anduin.", "https://www.youtube.com/watch?v=gvmLYGwpdV0", "2019-05-14")
                .WithLabels("Progression", "Journey Along the Anduin")
                .WithLabels("LOTR Progression Series Part 1 - Journey Along the Anduin.");
        }
    }
}