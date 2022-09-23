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
                .WithLabels("https://ringsdb.com/decklist/view/31437/flyingsololotrprogressionpt17shadowandflame-2.0")
                .WithLabels("3 years ago I cheated and used burning brand on Aragorn! Now Im back to rectify this! Had a few losses before this one - want to see them? Catch it live on twitch at twitch.tv/FlyingSoloLive Here is the deck. https://ringsdb.com/decklist/view/31437/flyingsololotrprogressionpt17shadowandflame-2.0");
            AddLink("LOTR LCG progression 17 Shadow and Flame", "https://www.youtube.com/watch?v=cFUsVcY3qmg", "2022-02-03")
                .WithLabels("Progression", "Shadow and Flame")
                .WithLabels("https://ringsdb.com/decklist/view/14328/flyingsololotrprogressionpt17shadowandflame-1.0")
                .WithLabels("Finishing out the Dwarrowdelf cycle today, its a showdown with the Balrog. Here is the deck I used for the quest https://ringsdb.com/decklist/view/14328/flyingsololotrprogressionpt17shadowandflame-1.0 Post any questions, comments or rules corrections below thank you all");

            AddYear(2020);
            AddLink("LOTR LCG progression 16 Foundations of Stone", "https://www.youtube.com/watch?v=P6HkiTEBrSk", "2020-01-26")
                .WithLabels("Progression", "Foundations of Stone")
                .WithLabels("https://ringsdb.com/decklist/view/14245/flyingsololotrprogressionpt16foundationofstoneyoutu-1.0")
                .WithLabels("Taking on Foundations of Stone as we close the gap in the Dwarrordelf cycle. Here's the deck I used https://ringsdb.com/decklist/view/14245/flyingsololotrprogressionpt16foundationofstoneyoutu-1.0 Got this in one take, so no death highlights. This is actually a pretty unexciting game, as I got pretty lucky with shadow and breezed past everything. Enjoy hahah!");
            AddLink("LOTR LCG Progression 15 The Long Dark", "https://www.youtube.com/watch?v=JUzmPs3vApA", "2020-01-22")
                .WithLabels("Progression", "The Long Dark")
                .WithLabels("https://ringsdb.com/decklist/view/14201/flyingsololotrprogressionpt15thelongdark-1.0")
                .WithLabels("A nice easy romp today, you can view the deck I used here https://ringsdb.com/decklist/view/14201/flyingsololotrprogressionpt15thelongdark-1.0 Follow on mixer here http://mixer.com/flyingsolo And comment, questions, rules posts are all welcome. Next is foundations of stone as we come to the end of dwarrodelf.");
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
            AddLink("", "", "")
                .WithLabels("");
            AddLink("", "", "")
                .WithLabels("");
        }
    }
}