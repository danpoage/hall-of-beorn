using System;

namespace HallOfBeorn.Models.LotR.Community.LateOfTheRings
{
    public class LateOfTheRingsPodcast
        : Creator
    {
        public LateOfTheRingsPodcast()
            : base("Late of the Rings Podcast",
            "https://lateoftherings.buzzsprout.com/1042546",
            "https://feeds.buzzsprout.com/1042546.rss",
            LinkType.LateOfTheRings)
        {
            AddYear(2022);
            AddLink("Episode 25: Denethor in Law", "https://lateoftherings.buzzsprout.com/1042546/11558022-episode-25-denethor-in-law", "Oct 24, 2022")
                .WithLinks("Dwarrowdelf Leadership Player Cards", "https://www.reddit.com/r/lotrlcg/");
            AddLink("Episode 24: Martin Warg", "https://lateoftherings.buzzsprout.com/1042546/10902534-episode-24-martin-warg", "Jul 4, 2022")
                .WithLinks("Road to Rivendell", "Spoilers");
            AddLink("Episode 23: Chimp Blocker", "https://lateoftherings.buzzsprout.com/1042546/10353613-episode-23-chimp-blocker", "Mar 31, 2022")
                .WithLinks("Dwarrowdelf Tactics Player Cards", "Starter Decks");
            
            AddYear(2021);
            AddLink("Episode 22: Pineapple Push", "https://lateoftherings.buzzsprout.com/1042546/9811258-episode-22-pineapple-push", "Dec 31, 2021")
                .WithLinks("The Redhorn Gate", "Spoilers");
            AddLink("Episode 21: There's no such thing as free good meal", "https://lateoftherings.buzzsprout.com/1042546/9464884-episode-21-there-s-no-such-thing-as-free-good-meal", "Oct 31, 2021")
                .WithLinks("Dwarrowdelf Heroes and Neutral Player Cards", "https://www.dwarrowscholar.com/");
            AddLink("Episode 20: The Great Indoors", "https://lateoftherings.buzzsprout.com/1042546/9306171-episode-20-the-great-indoors", "Oct 4, 2021")
                .WithLinks("Flight from Moria", "Spoilers", "Revised Core Set");
            AddLink("Episode 19: Ancient Itifacts", "https://lateoftherings.buzzsprout.com/1042546/8701662-episode-19-ancient-itifacts", "Jun 14, 2021")
                .WithLinks("The Seventh Level", "Spoilers");
            AddLink("Episode 18: Get Orcanised", "https://lateoftherings.buzzsprout.com/1042546/8457962-episode-18-get-orcanised", "May 4, 2021")
                .WithLinks("Into the Pit", "Spoilers");
            AddLink("Episode 17: The Chaos of Expanding Takeaways", "https://lateoftherings.buzzsprout.com/1042546/8264990-episode-17-the-chaos-of-expanding-takeaways", "Apr 3, 2021")
                .WithLinks("Khazad-dum Player Cards", "Khazad-dûm", "");
            AddLink("Episode 16: It", "https://lateoftherings.buzzsprout.com/1042546/8167241-episode-16-it", "Mar 18, 2021")
                .WithLinks("The Return to Mirkwood", "Gollum", "Spoilers");
            AddLink("Episode 15: Johnny Cache", "https://lateoftherings.buzzsprout.com/1042546/8020574-episode-15-johnny-cache", "Feb 24, 2021")
                .WithLinks("Shadows of Mirkwood Leadership Player Cards", "Dúnedain", "Dunedain", "RingsDB");
            
            AddYear(2020);
            AddLink("Episode 14: The Beginning of the End Phase", "https://lateoftherings.buzzsprout.com/1042546/6862177-episode-14-the-beginning-of-the-end-phase", "Dec 15, 2020")
                .WithLinks("The Dead Marshes", "Gollum", "Spoilers");
            AddLink("Episode 13: The Cheese of Brie", "https://lateoftherings.buzzsprout.com/1042546/6132127-episode-13-the-cheese-of-brie", "Oct 30, 2020")
                .WithLinks("Shadows of Mirkwood Lore Player Cards");
            AddLink("Episode 12: Variable Quantities of Solace", "https://lateoftherings.buzzsprout.com/1042546/5748874-episode-12-variable-quantities-of-solace", "Oct 5, 2020")
                .WithLinks("The Hills of Emyn Muil", "Spoilers");
            AddLink("Episode 11: I am Norah Stranger", "https://lateoftherings.buzzsprout.com/1042546/5533066-episode-11-i-am-norah-stranger", "Sep 21, 2020")
                .WithLinks("Shadows of Mirkwood Spirit Player Cards");
            AddLink("Episode 10: Black Forest Bateaux", "https://lateoftherings.buzzsprout.com/1042546/5379535-episode-10-black-forest-bateaux", "Sep 10, 2020")
                .WithLinks("A Journey to Rhosgobel");
            AddLink("Episode 9: The Seagulls are Coming!", "https://lateoftherings.buzzsprout.com/1042546/4930835-episode-9-the-seagulls-are-coming", "Aug 10, 2020")
                .WithLinks("Shadows of Mirkwood Tactics Player Cards", "http://lotr-lcg-quest-companion.gamersdungeon.net/");
            AddLink("Episode 8: A Pint of Honey", "https://lateoftherings.buzzsprout.com/1042546/4597436-episode-8-a-pint-of-honey", "Jul 16, 2020")
                .WithLinks("Conflict at the Carrock", "Spoilers");
            AddLink("Episode 7: Radagast on Ice", "https://lateoftherings.buzzsprout.com/1042546/4361276-episode-7-radagast-on-ice", "Jun 29, 2020")
                .WithLinks("Shadows of Mirkwood Player Cards", "Ragagast", "http://lotrproject.com/");
            AddLink("Episode 6: It's a disaster", "https://lateoftherings.buzzsprout.com/1042546/4129457-episode-6-it-s-a-disaster", "Jun 11, 2020")
                .WithLinks("The Hunt for Gollum");
            AddLink("Episode 5: Lady Galadriel's Beef", "https://lateoftherings.buzzsprout.com/1042546/3884765-episode-5-lady-galadriel-s-beef", "May 23, 2020")
                .WithLinks("Escape from Dol Guldur");
            AddLink("Episode 4: Tickled by a King", "https://lateoftherings.buzzsprout.com/1042546/3745094-episode-4-tickled-by-a-king", "May 13, 2020")
                .WithLinks("Core Set", "Tactics", "Spirit", "Journey Along the Anduin");
            AddLink("Episode 3: Beorn's Inhospitality", "https://lateoftherings.buzzsprout.com/1042546/3616348-episode-3-beorn-s-inhospitality", "May 4, 2020")
                .WithLinks("Passage Through Mirkwood", "Lore");
            AddLink("Episode 2: All That Glitters is Not Bold", "https://lateoftherings.buzzsprout.com/1042546/3538111-episode-2-all-that-glitters-is-not-bold", "Apr 28, 2020")
                .WithLinks("Core Set", "Leadership", "Beorn's Path");
            AddLink("Episode 1: A Festering Bog", "https://lateoftherings.buzzsprout.com/1042546/3509338-episode-1-a-festering-bog", "Apr 26, 2020")
                .WithLinks("Premier", "RingsDB", "Core Set", "theme");
        }
    }
}
