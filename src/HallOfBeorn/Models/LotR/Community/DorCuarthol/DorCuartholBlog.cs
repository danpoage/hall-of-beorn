using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace HallOfBeorn.Models.LotR.Community.DorCuarthol
{
    public class DorCuartholBlog
        : Creator
    {
        public DorCuartholBlog()
            : base("Dor Cuarthol",
            "https://dorcuarthol.wordpress.com/",
            "https://dorcuarthol.wordpress.com/feed",
            LinkType.Dor_Cuarthol)
        {
            AddYear(2020);
            AddLink("Hope Rekindled", "https://dorcuarthol.wordpress.com/2020/02/07/hope-rekindled-2/", "Fri, 07 Feb 2020 17:21:17 +0000");

            AddYear(2018);
            AddLink("Return of the Rings", "https://dorcuarthol.wordpress.com/2018/07/13/return-of-the-rings/", "Fri, 13 Jul 2018 07:00:55 +0000");

            AddYear(2017);
            AddLink("FAQ News - Keeping it Real in a World Gone Digital", "https://dorcuarthol.wordpress.com/2017/12/24/faq-news-keeping-it-real-in-a-world-gone-digital/", "Sun, 24 Dec 2017 09:30:29 +0000");
            AddLink("The Tale of Years", "https://dorcuarthol.wordpress.com/2017/04/20/the-tale-of-years/", "Thu, 20 Apr 2017 20:08:13 +0000");
            AddLink("I'm going on an adventure!", "https://dorcuarthol.wordpress.com/2017/02/05/im-going-on-an-adventure/", "Sun, 05 Feb 2017 17:09:33 +0000");
            AddLink("Places We've Been - Voice of the Ringmaker", "https://dorcuarthol.wordpress.com/2017/01/27/places-weve-been-voice-of-the-ringmaker/", "Fri, 27 Jan 2017 10:26:50 +0000");
            AddLink("Places We've Been - The Fellowship of the Ring", "https://dorcuarthol.wordpress.com/2017/01/05/places-weve-been-the-fellowship-of-the-ring/", "Thu, 05 Jan 2017 11:26:55 +0000");

            AddYear(2016);
            AddLink("The Old and the New", "https://dorcuarthol.wordpress.com/2016/12/24/the-old-and-the-new/", "Sat, 24 Dec 2016 09:44:51 +0000");
            AddLink("Places we've been - part 3", "https://dorcuarthol.wordpress.com/2016/12/17/places-weve-been-part-3/", "Sat, 17 Dec 2016 08:54:29 +0000");
            AddLink("Sailing Away", "https://dorcuarthol.wordpress.com/2016/12/01/sailing-away/", "Thu, 01 Dec 2016 15:46:47 +0000");
            AddLink("Places We've Been - Part 2", "https://dorcuarthol.wordpress.com/2016/11/17/places-weve-been-part-2/", "Thu, 17 Nov 2016 19:29:54 +0000");
            AddLink("Places We've Been - Part 1", "https://dorcuarthol.wordpress.com/2016/11/04/places-weve-been-part-1/", "Fri, 04 Nov 2016 11:49:18 +0000");
            AddLink("Decks of Autumn: The Old and the New", "https://dorcuarthol.wordpress.com/2016/10/15/decks-of-autumn-the-old-and-the-new/", "Sat, 15 Oct 2016 13:58:16 +0000");
            AddLink("The Enemy of My Enemy is my Objective Ally", "https://dorcuarthol.wordpress.com/2016/10/01/the-enemy-of-my-enemy-is-my-objective-ally/", "Sat, 01 Oct 2016 08:29:40 +0000");
            AddLink("Peering in to the Palantir", "https://dorcuarthol.wordpress.com/2016/09/17/peering-in-to-the-palantir/", "Sat, 17 Sep 2016 07:56:01 +0000");
            AddLink("Doom", "https://dorcuarthol.wordpress.com/2016/09/04/doom/", "Sun, 04 Sep 2016 09:02:06 +0000");
            AddLink("Lord of the Zombies", "https://dorcuarthol.wordpress.com/2016/08/27/lord-of-the-zombies/", "Sat, 27 Aug 2016 09:08:47 +0000");
            AddLink("Sphere Bleed? What Sphere Bleed?", "https://dorcuarthol.wordpress.com/2016/08/20/sphere-bleed-what-sphere-bleed/", "Sat, 20 Aug 2016 21:05:37 +0000");
            AddLink("Late Game Deckbuilding", "https://dorcuarthol.wordpress.com/2016/08/13/late-game-deckbuilding/", "Sat, 13 Aug 2016 17:34:23 +0000");
            AddLink("Back for good?", "https://dorcuarthol.wordpress.com/2016/08/13/back-for-good/", "Sat, 13 Aug 2016 11:11:09 +0000");
            AddLink("Hope Rekindled", "https://dorcuarthol.wordpress.com/2016/05/07/hope-rekindled/", "Sat, 07 May 2016 07:15:42 +0000");
            AddLink("Are We Having Fun?", "https://dorcuarthol.wordpress.com/2016/04/13/are-we-having-fun/", "Wed, 13 Apr 2016 10:29:24 +0000");
            AddLink("How fortunate you are that your job is also your hobby", "https://dorcuarthol.wordpress.com/2016/03/19/how-fortunate-you-are-that-your-job-is-also-your-hobby/", "Sat, 19 Mar 2016 08:42:55 +0000");
            AddLink("The Ins and Outs of Deck-Building - Part 2", "https://dorcuarthol.wordpress.com/2016/03/12/the-ins-and-outs-of-deck-building-part-2/", "Sat, 12 Mar 2016 19:42:26 +0000");
            AddLink("The Ins and Outs of Deck-Building - Part 1", "https://dorcuarthol.wordpress.com/2016/03/03/the-ins-and-outs-of-deck-building-part-1/", "Thu, 03 Mar 2016 13:08:58 +0000");
            AddLink("Of Battles Lost and Won", "https://dorcuarthol.wordpress.com/2016/02/14/of-battles-lost-and-won/", "Sun, 14 Feb 2016 16:52:55 +0000");
            AddLink("The Light of the Evenstar", "https://dorcuarthol.wordpress.com/2016/01/21/the-light-of-the-evenstar/", "Thu, 21 Jan 2016 17:19:20 +0000");
            AddLink("Arise now, Riders of Theoden", "https://dorcuarthol.wordpress.com/2016/01/14/arise-now-riders-of-theoden/", "Thu, 14 Jan 2016 08:34:07 +0000");

            AddYear(2015);
            AddLink("What is Dead May Never Die", "https://dorcuarthol.wordpress.com/2015/12/19/what-is-dead-may-never-die/", "Sat, 19 Dec 2015 20:59:18 +0000");
            AddLink("Dark Deeds in Bree", "https://dorcuarthol.wordpress.com/2015/11/15/dark-deeds-in-bree/", "Sun, 15 Nov 2015 17:20:17 +0000");
            AddLink("Rousing the Shire", "https://dorcuarthol.wordpress.com/2015/11/14/rousing-the-shire/", "Sat, 14 Nov 2015 11:12:35 +0000");
            AddLink("Where now the horse and the rider?", "https://dorcuarthol.wordpress.com/2015/10/22/where-now-the-horse-and-the-rider/", "Thu, 22 Oct 2015 09:09:08 +0000");
            AddLink("Lord of the Archetypes", "https://dorcuarthol.wordpress.com/2015/09/27/lord-of-the-archetypes/", "Sun, 27 Sep 2015 13:30:21 +0000");
            AddLink("Something Fishy This Way Comes", "https://dorcuarthol.wordpress.com/2015/09/06/something-fishy-this-way-comes/", "Sun, 06 Sep 2015 08:17:29 +0000");
            AddLink("Who's That Girl?", "https://dorcuarthol.wordpress.com/2015/08/23/whos-that-girl/", "Sun, 23 Aug 2015 08:57:45 +0000");
            AddLink("The Fatty Project", "https://dorcuarthol.wordpress.com/2015/08/20/the-fatty-project/", "Thu, 20 Aug 2015 07:13:21 +0000");
            AddLink("The Wizard's Surge", "https://dorcuarthol.wordpress.com/2015/08/08/the-wizards-surge/", "Sat, 08 Aug 2015 10:06:56 +0000");
            AddLink("A Fistful of Meeples", "https://dorcuarthol.wordpress.com/2015/08/06/a-fistful-of-meeples/", "Thu, 06 Aug 2015 09:55:33 +0000");
            AddLink("Surging Against the Shadow", "https://dorcuarthol.wordpress.com/2015/08/02/part-4-against-the-shadow/", "Sun, 02 Aug 2015 07:18:33 +0000");
            AddLink("Surging in the Dark", "https://dorcuarthol.wordpress.com/2015/07/21/surging-in-the-dark/", "Tue, 21 Jul 2015 14:31:29 +0000");
            AddLink("Surges Through Mirkwood", "https://dorcuarthol.wordpress.com/2015/07/15/surges-through-mirkwood/", "Wed, 15 Jul 2015 07:16:17 +0000");
            AddLink("Surge - Part 1", "https://dorcuarthol.wordpress.com/2015/07/09/surge-part-1/", "Thu, 09 Jul 2015 15:57:19 +0000");
            AddLink("The Wizard's Voice", "https://dorcuarthol.wordpress.com/2015/06/13/the-wizards-voice/", "Sat, 13 Jun 2015 08:50:55 +0000");
            AddLink("Riddles in the Dark", "https://dorcuarthol.wordpress.com/2015/06/06/riddles-in-the-dark/", "Sat, 06 Jun 2015 07:30:13 +0000");
            AddLink("When the Going Gets Tough", "https://dorcuarthol.wordpress.com/2015/05/23/when-the-going-gets-tough/", "Sat, 23 May 2015 07:30:52 +0000");
            AddLink("How Many Of?", "https://dorcuarthol.wordpress.com/2015/05/09/632/", "Sat, 09 May 2015 07:18:58 +0000");
            AddLink("Taking the Difficulty project to Isengard", "https://dorcuarthol.wordpress.com/2015/04/30/taking-the-difficulty-project-to-isengard/", "Thu, 30 Apr 2015 16:20:41 +0000");
            AddLink("Going Solo", "https://dorcuarthol.wordpress.com/2015/04/18/going-solo/", "Sat, 18 Apr 2015 11:16:51 +0000");
            AddLink("Difficulty in the Dark", "https://dorcuarthol.wordpress.com/2015/04/02/difficulty-in-the-dark/", "Thu, 02 Apr 2015 08:29:02 +0000");
            AddLink("A Balrog of Morgoth (What did you say?)", "https://dorcuarthol.wordpress.com/2015/03/14/a-balrog-of-morgoth-what-did-you-say/", "Sat, 14 Mar 2015 07:59:54 +0000");
            AddLink("A Question of Theme", "https://dorcuarthol.wordpress.com/2015/02/28/a-question-of-theme/", "Sat, 28 Feb 2015 09:04:15 +0000");
            AddLink("(Ro)Han Solo", "https://dorcuarthol.wordpress.com/2015/02/13/rohan-solo/", "Fri, 13 Feb 2015 15:14:42 +0000");
            AddLink("Difficulty Project - The Black Riders", "https://dorcuarthol.wordpress.com/2015/01/21/difficulty-project-the-black-riders/", "Wed, 21 Jan 2015 08:32:05 +0000");
            AddLink("2014 - some thoughts", "https://dorcuarthol.wordpress.com/2015/01/03/2014-some-thoughts/", "Sat, 03 Jan 2015 09:22:36 +0000");
            AddLink("Twelve Days of Tolkien", "https://dorcuarthol.wordpress.com/2014/12/24/twelve-days-of-tolkien/", "Wed, 24 Dec 2014 15:32:54 +0000");

            AddYear(2014);
            AddLink("Score, Difficulty, and Keeping Track", "https://dorcuarthol.wordpress.com/2014/12/18/score-difficulty-and-keeping-track/", "Thu, 18 Dec 2014 12:15:08 +0000");
            AddLink("About Time", "https://dorcuarthol.wordpress.com/2014/12/18/about-time/", "Thu, 18 Dec 2014 11:56:09 +0000");
            AddLink("Battle of the Five Armies", "https://dorcuarthol.wordpress.com/2014/12/13/battle-of-the-five-armies/", "Sat, 13 Dec 2014 09:29:03 +0000");
            AddLink("An Unexpected Desolation", "https://dorcuarthol.wordpress.com/2014/11/29/an-unexpected-desolation/", "Sat, 29 Nov 2014 09:43:49 +0000");
            AddLink("Heroes IV - Lore", "https://dorcuarthol.wordpress.com/2014/11/15/heroes-iv-lore/", "Sat, 15 Nov 2014 09:12:22 +0000");
            AddLink("Heroes III - Spirit", "https://dorcuarthol.wordpress.com/2014/11/01/heroes-iii-spirit/", "Sat, 01 Nov 2014 09:46:00 +0000");
            AddLink("Heroes 2 - Tactics", "https://dorcuarthol.wordpress.com/2014/10/18/heroes-2-tactics/", "Sat, 18 Oct 2014 09:02:07 +0000");
            AddLink("Heroes 1 - Leadership", "https://dorcuarthol.wordpress.com/2014/10/03/heroes-1-leadership/", "Fri, 03 Oct 2014 16:43:46 +0000");
            AddLink("Organised Nightmares", "https://dorcuarthol.wordpress.com/2014/09/11/organised-nightmares/", "Thu, 11 Sep 2014 08:09:03 +0000");
            AddLink("Victory & Defeat", "https://dorcuarthol.wordpress.com/2014/08/31/victory-defeat/", "Sun, 31 Aug 2014 08:20:57 +0000");
            AddLink("Not all those who wander are lost", "https://dorcuarthol.wordpress.com/2014/08/16/not-all-those-who-wander-are-lost/", "Sat, 16 Aug 2014 09:06:42 +0000");
            AddLink("Location, Location, Location", "https://dorcuarthol.wordpress.com/2014/08/09/location-location-location/", "Sat, 09 Aug 2014 16:31:56 +0000");
            AddLink("Co-operation, Victory and Glory", "https://dorcuarthol.wordpress.com/2014/07/25/co-operation-victory-and-glory/", "Fri, 25 Jul 2014 09:28:31 +0000");
            AddLink("Sticking Around", "https://dorcuarthol.wordpress.com/2014/07/12/sticking-around/", "Sat, 12 Jul 2014 20:58:48 +0000");
            AddLink("Faction: Mechanic and Theme", "https://dorcuarthol.wordpress.com/2014/07/04/faction-mechanic-and-theme/", "Fri, 04 Jul 2014 14:57:16 +0000");
            AddLink("Know your Fins", "https://dorcuarthol.wordpress.com/2014/06/30/know-your-fins/", "Mon, 30 Jun 2014 08:13:37 +0000");
            AddLink("The Stuff of Nightmares", "https://dorcuarthol.wordpress.com/2014/06/28/the-stuff-of-nightmares/", "Sat, 28 Jun 2014 14:54:22 +0000");
            AddLink("The First Age Dawns", "https://dorcuarthol.wordpress.com/2014/06/14/the-first-age-dawns/", "Sat, 14 Jun 2014 14:58:59 +0000");
            AddLink("Ents", "https://dorcuarthol.wordpress.com/2014/06/06/ents/", "Fri, 06 Jun 2014 08:28:16 +0000");
            AddLink("Levelling Up", "https://dorcuarthol.wordpress.com/2014/05/30/levelling-up/", "Fri, 30 May 2014 20:30:44 +0000");
            AddLink("Ordinary Heroes", "https://dorcuarthol.wordpress.com/2014/05/24/ordinary-heroes/", "Sat, 24 May 2014 11:49:23 +0000");
            AddLink("House Rules: ok?", "https://dorcuarthol.wordpress.com/2014/05/14/house-rules-ok/", "Wed, 14 May 2014 16:13:37 +0000");
            AddLink("A Few Thoughts", "https://dorcuarthol.wordpress.com/2014/05/09/a-few-thoughts/", "Fri, 09 May 2014 17:21:14 +0000");
            AddLink("No chance for Faramir, Captain of Gondor, to Show his Quality", "https://dorcuarthol.wordpress.com/2014/04/18/no-chance-for-faramir-captain-of-gondor-to-show-his-quality/", "Fri, 18 Apr 2014 14:07:31 +0000");
            AddLink("Sacrifice", "https://dorcuarthol.wordpress.com/2014/04/11/sacrifice/", "Fri, 11 Apr 2014 07:04:50 +0000");
            AddLink("Endurance", "https://dorcuarthol.wordpress.com/2014/03/28/endurance/", "Fri, 28 Mar 2014 18:00:37 +0000");
            AddLink("Taking the Hobbits to Isengard", "https://dorcuarthol.wordpress.com/2014/03/15/taking-the-hobbits-to-isengard/", "Sat, 15 Mar 2014 08:36:47 +0000");
            AddLink("Forth Eorlingas!", "https://dorcuarthol.wordpress.com/2014/03/07/forth-eorlingas/", "Fri, 07 Mar 2014 18:11:06 +0000");
            AddLink("The Opposite of Secrecy", "https://dorcuarthol.wordpress.com/2014/03/01/the-opposite-of-secrecy/", "Sat, 01 Mar 2014 09:24:30 +0000");
            AddLink("All too predictable courage.", "https://dorcuarthol.wordpress.com/2014/02/22/all-too-predictable-courage/", "Sat, 22 Feb 2014 09:21:38 +0000");
            AddLink("Lord of the Rings LCG - top 5 moans", "https://dorcuarthol.wordpress.com/2014/02/15/lord-of-the-rings-lcg-top-5-moans/", "Sat, 15 Feb 2014 10:07:14 +0000");
            AddLink("The Elves of Middle-Earth", "https://dorcuarthol.wordpress.com/2014/02/06/the-elves-of-middle-earth/", "Thu, 06 Feb 2014 09:22:48 +0000");
            AddLink("The Riders of Rohan", "https://dorcuarthol.wordpress.com/2014/02/01/the-riders-of-rohan/", "Sat, 01 Feb 2014 09:01:20 +0000");
            AddLink("Welcome", "https://dorcuarthol.wordpress.com/2014/01/30/welcome/", "Thu, 30 Jan 2014 21:14:38 +0000");
        }
    }
}