using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace HallOfBeorn.Models.LotR.Community.TheGreyCompany
{
    public class TheGreyCompanyPodcast
        : Creator
    {
        public TheGreyCompanyPodcast()
            : base("The Grey Company", 
            "http://greycompanypodcast.wordpress.com/",
            "https://hallofbeorn-resources.s3.amazonaws.com/Audio/LotR/The-Grey-Company/The-Grey-Company.rss",
            LinkType.The_Grey_Company)
        {
            AddYear(2019);
            AddLink("68", "68 - Book Club XXV - The Grey Havens", new DateTime(2019, 5, 7));
            AddLink("67", "67 - Book Club XXIV - Long live the Halflings!", new DateTime(2019, 1, 17));

            AddYear(2018);
            AddLink("66", "66 - Book Club XXIII - Mount Doom", new DateTime(2018, 11, 14));
            AddLink("65b", "65b - The Con of the Rings Recap", new DateTime(2018, 10, 22));
            AddLink("65a", "65a - Tim and Luke of FFI", new DateTime(2018, 10, 15));
            AddLink("64", "64 - Book Club XXII - Debate at the Gate", new DateTime(2018, 9, 3));
            AddLink("63", "63 - Book Club XXI - Pyres and Healing", new DateTime(2018, 8, 20));
            AddLink("62", "62 - Book Club XX - To Battle!", new DateTime(2018, 7, 23));
            AddLink("61", "61 - Book Club XIX - Minas Tirith", new DateTime(2018, 6, 25));
            AddLink("60", "60 - Book Club XVIII - Shelob", new DateTime(2018, 6, 11));
            AddLink("59", "59 - Book Club XVII - Rabbits and Fish", new DateTime(2018, 5, 21));
            AddLink("58", "58 - Book Club XVI", new DateTime(2018, 3, 13));
            AddLink("57", "57 - Book Club XV", new DateTime(2018, 2, 14));
            AddLink("56", "56 - Book Club XIV", new DateTime(2018, 1, 26));
            AddLink("55", "55 - Book Club XIII", new DateTime(2018, 1, 7));

            AddYear(2017);
            AddLink("54", "54 - Book Club XII", new DateTime(2017, 12, 13));
            AddLink("The-Grey-Company-in-Space", "The Grey Company in Space", new DateTime(2017, 10, 5));
            AddLink("53", "53 - Book Club XI", new DateTime(2017, 7, 15));
            AddLink("52", "52 - Book Club X", new DateTime(2017, 6, 14));
            AddLink("51", "51 - Book Club IX", new DateTime(2017, 4, 4));
            AddLink("50", "50 - Deck Doctor", new DateTime(2017, 2, 14));

            AddYear(2016);
            AddLink("49", "49 - Sands of Harad", new DateTime(2016, 12, 30));
            AddLink("48", "48 - Book Club VIII", new DateTime(2016, 11, 16));
            AddLink("47", "47 - Power vs Theme", new DateTime(2016, 10, 10));
            AddLink("46", "46 - Book Club VII", new DateTime(2016, 9, 19));
            AddLink("45", "45 - Ally Showdown", new DateTime(2016, 8, 26));
            AddLink("44", "44 - Temple of the Deceived", new DateTime(2016, 7, 29));
            AddLink("43", "43 - Hero Showdown", new DateTime(2016, 7, 8));
            AddLink("42", "42 - Book Clun VI", new DateTime(2016, 6, 16));
            AddLink("41", "41 - Benchmarking", new DateTime(2016, 5, 26));
            AddLink("40", "40 - Stormcaller", new DateTime(2016, 5, 11));
            AddLink("39", "39 - Alternatives to Staples", new DateTime(2016, 4, 21));
            AddLink("38", "38 - Book Club V", new DateTime(2016, 3, 31));
            AddLink("37", "37 - The Grey Havens", new DateTime(2016, 3, 9));
            AddLink("36", "36 - Angmar Wrapup", new DateTime(2016, 2, 17));
            AddLink("35", "35 - Luck vs. Skill", new DateTime(2016, 1, 15));

            AddYear(2015);
            AddLink("34", "34 - Book Club IV - ", new DateTime(2015, 12, 29));
            AddLink("33", "33 - Staples and Sideboards", new DateTime(2015, 12, 3));
            AddLink("32", "32 - Anniversary Show", new DateTime(2015, 10, 30));
            AddLink("31", "31 - Book Club III - Three is Company", new DateTime(2015, 10, 14));
            AddLink("30", "30 - Over/Under", new DateTime(2015, 9, 25));
            AddLink("29", "29 -Book Club II - Long-expected Shadows", new DateTime(2015, 8, 23));
            AddLink("28", "28 - Caleb Grace (GenCon 2015)", new DateTime(2015, 8, 6));
            AddLink("27", "27 - Nightmare", new DateTime(2015, 7, 23));
            AddLink("26", "26 - Helm's Deep", new DateTime(2015, 6, 23));
            AddLink("25", "25 - Book Club I - Prologue", new DateTime(2015, 5, 31));
            AddLink("24b", "24b - The Lost Realm (Quests)", new DateTime(2015, 5, 13));
            AddLink("24a", "24a - The Lost Realm (Player Cards)", new DateTime(2015, 4, 9));
            AddLink("23", "23 - The Core Set", new DateTime(2015, 3, 19));

            AddLink("22", "22 - The Hobbit Special", new DateTime(2015, 2, 27));
            AssociateCardToEpisodeNumber("22", "Sam-Gamgee-TBR");
            AssociateCardToEpisodeNumber("22", "Pippin-TBR");
            AssociateCardToEpisodeNumber("22", "Merry-TBR");
            AssociateCardToEpisodeNumber("22", "Bill-the-Pony-TBR");
            
            AddLink("21", "21 - Evolution with Matt Newman", new DateTime(2015, 2, 3));
            AddLink("20b", "20b - More Lore", new DateTime(2015, 1, 27));
            AddLink("20a", "20a - Lore", new DateTime(2015, 1, 16));

            AddYear(2014);
            AddLink("19", "19 - Year in Review 2014", new DateTime(2014, 12, 30));
            
            AddLink("18", "18 - Leadership", new DateTime(2014, 11, 21));
            AssociateCardToEpisodeNumber("18", "Steward-of-Gondor-Core");
            AssociateCardToEpisodeNumber("18", "Faramir-Core");

            AddLink("17", "17 - Rohan", new DateTime(2014, 11, 5));
            AssociateCardToEpisodeNumber("17", "Eowyn-Core");
            AssociateCardToEpisodeNumber("17", "Theodred-Core");

            AddLink("16", "16 - Roads Darken", new DateTime(2014, 10, 21));

            AddLink("15b", "15b - Mirkwood Pioneer", new DateTime(2014, 9, 27));
            AssociateCardToEpisodeNumber("15b", "Mirkwood-Pioneer-NiE");

            AddLink("15a", "15a - Tri-Sphere", new DateTime(2014, 9, 20));
            AddLink("14", "14 - GenCon", new DateTime(2014, 8, 28));
            AddLink("13", "13 - Tactics", new DateTime(2014, 8, 12));
            AddLink("12", "12 - Common Mistakes", new DateTime(2014, 7, 22));
            AddLink("11b", "11b - Dunland Trap Fire Impressions", new DateTime(2014, 6, 30));
            AddLink("11a", "11a - The One Deck", new DateTime(2014, 6, 6));
            AddLink("10", "10 - Thematic Decks", new DateTime(2014, 5, 16));
            AddLink("09", "9 - Keeping the Game Fresh", new DateTime(2014, 4, 22));
            AddLink("08", "8 - Spirit", new DateTime(2014, 3, 27));
            AddLink("07", "7 - Mitril Loincloth", new DateTime(2014, 3, 13));
            AddLink("06", "6 - Deck Building Part Two", new DateTime(2014, 2, 17));
            AddLink("05", "5 - Nightmare Conflict at the Carrock", new DateTime(2014, 1, 24));

            AddYear(2013);
            AddLink("04", "4 - Gondor", new DateTime(2013, 12, 31));
            AddLink("03", "3 - The Morgul Vale", new DateTime(2013, 12, 11));
            AddLink("02", "2 - Deck Building Part One", new DateTime(2013, 11, 27));

            AddLink("01", "1 - Outlands", new DateTime(2013, 11, 13));
            AssociateCardToEpisodeNumber("01", "Hirluin-the-Fair-TSF");
            AssociateCardToEpisodeNumber("01", "Ethir-Swordsman-TSF");
            AssociateCardToEpisodeNumber("01", "Anfalas-Herdsman-TSF");
            AssociateCardToEpisodeNumber("01", "Warrior-of-Lossarnach-TSF");
            AssociateCardToEpisodeNumber("01", "Knights-of-the-Swan-TSF");
            
            AddLink("00", "Pilot - The Grey Company Arrives", new DateTime(2013, 10, 29));
        }

        private const string urlFormat = 
            "https://hallofbeorn-resources.s3.amazonaws.com/Audio/LotR/The-Grey-Company/{0}.mp3";

        private const string titleFormat =
            "{0} [{1}]";

        private static string GetUrl(string episodeNumber)
        {
            return string.Format(urlFormat, episodeNumber);
        }

        private void AssociateCardToEpisodeNumber(string episodeNumber, string cardSlug)
        {
            var url = GetUrl(episodeNumber);
            AssociateCardToUrl(cardSlug, url);
        }

        private void AddLink(string episodeNumber, string title, DateTime releaseDate)
        {
            var url = GetUrl(episodeNumber);
            var fullTitle = string.Format(titleFormat, title, releaseDate.ToString("MMM dd, yyyy"));
            AddLink(new Link(LinkType.The_Grey_Company, url, fullTitle));
        }
    }
}