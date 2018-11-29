using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

using HallOfBeorn.Models.LotR;

namespace HallOfBeorn.Services.LotR.RingsDb
{
    public class RingsDbService : IRingsDbService
    {
        public RingsDbService(LotRCardRepository cardRepository)
        {
            foreach (var card in cardRepository.Cards())
            {
                cardsBySlug.Add(card.Slug, card);

                var cardId = GetCardId(card.Slug);
                if (!string.IsNullOrEmpty(cardId))
                {
                    slugByCardId[cardId] = card.Slug;
                }
            }

            initializeHeroPopularity();
            initializeCardPopularity();
        }

        private readonly Dictionary<string, LotRCard> cardsBySlug = new Dictionary<string,LotRCard>();
        private readonly Dictionary<string, string> slugByCardId = new Dictionary<string, string>();
        private readonly Dictionary<string, byte> popularityByCardId = new Dictionary<string, byte>();
        private readonly Dictionary<string, ushort> votesByCardId = new Dictionary<string, ushort>();

        private void addHeroPopularity(string cardId, ushort votes)
        {
            const ushort hero_5 = 300;
            const ushort hero_4 = 200;
            const ushort hero_3 = 150;
            const ushort hero_2 = 100;

            if (votes > hero_5)
                addPopularity(cardId, 5, votes);
            else if (votes > hero_4)
                addPopularity(cardId, 4, votes);
            else if (votes > hero_3)
                addPopularity(cardId, 3, votes);
            else if (votes > hero_2)
                addPopularity(cardId, 2, votes);
            else
                addPopularity(cardId, 1, votes);
        }

        private void addCardPopularity(string cardId, ushort votes)
        {
            const ushort votes_5 = 800;
            const ushort votes_4 = 550;
            const ushort votes_3 = 450;
            const ushort votes_2 = 300;

            if (votes > votes_5)
                addPopularity(cardId, 5, votes);
            else if (votes > votes_4)
                addPopularity(cardId, 4, votes);
            else if (votes > votes_3)
                addPopularity(cardId, 3, votes);
            else if (votes > votes_2)
                addPopularity(cardId, 2, votes);
            else
                addPopularity(cardId, 1, votes);
        }

        private void addPopularity(string cardId, byte popularity, ushort votes)
        {
            //addPopularity(cardId, popularity);
            if (popularityByCardId.ContainsKey(cardId)) {
                return;
            }

            popularityByCardId[cardId] = popularity;
            votesByCardId[cardId] = votes;
        }

        /*
        private void addPopularity(string cardId, byte popularity)
        {
            if (popularityByCardId.ContainsKey(cardId)) {
                return;
            }

            popularityByCardId[cardId] = popularity;
        }*/

        private void initializeHeroPopularity()
        {
            //5 Ring Heroes
            addHeroPopularity("01007", 943);
            addHeroPopularity("04101", 748);
            addHeroPopularity("10140", 662);
            addHeroPopularity("145002", 566);
            addHeroPopularity("01005", 562);
            addHeroPopularity("04128", 553);
            addHeroPopularity("01002", 519);
            addHeroPopularity("08112", 497);
            addHeroPopularity("01001", 496);
            addHeroPopularity("12001", 472);
            addHeroPopularity("01012", 472);
            addHeroPopularity("141002", 458);
            addHeroPopularity("141004", 452);
            addHeroPopularity("01004", 411);
            addHeroPopularity("04053", 388);
            addHeroPopularity("02116", 374);
            addHeroPopularity("142002", 347);
            addHeroPopularity("03002", 346);
            addHeroPopularity("01006", 344);
            addHeroPopularity("01010", 344);
            addHeroPopularity("02025", 323);

            //4 Ring Heroes
            addHeroPopularity("05001", 299);
            addHeroPopularity("11001", 294);
            addHeroPopularity("08084", 276);
            addHeroPopularity("02095", 274);
            addHeroPopularity("141003", 268);
            addHeroPopularity("01008", 260);
            addHeroPopularity("145003", 246);
            addHeroPopularity("08056", 238);
            addHeroPopularity("144003", 238);
            addHeroPopularity("09001", 235);
            addHeroPopularity("10001", 231);
            addHeroPopularity("10084", 227);
            addHeroPopularity("01003", 225);
            addHeroPopularity("01009", 210);
            addHeroPopularity("143002", 209);
            addHeroPopularity("17028", 206);

            //3 Ring Heroes
            addHeroPopularity("131002", 191);
            addHeroPopularity("08001", 182);
            addHeroPopularity("02001", 180);
            addHeroPopularity("10115", 178);
            addHeroPopularity("131005", 177);
            addHeroPopularity("02050", 170);
            addHeroPopularity("05002", 170);
            addHeroPopularity("01011", 170);
            addHeroPopularity("131003", 169);
            addHeroPopularity("07001", 168);
            addHeroPopularity("04028", 162);
            addHeroPopularity("06001", 157);
            addHeroPopularity("17055", 156);
            addHeroPopularity("12057", 155);
            addHeroPopularity("04001", 154);
            addHeroPopularity("131004", 154);
            addHeroPopularity("06134", 153);
            addHeroPopularity("16002", 151);
            addHeroPopularity("12138", 150);

            //2 Ring Heroes
            addHeroPopularity("06032", 147);
            addHeroPopularity("16001", 144);
            addHeroPopularity("08137", 135);
            addHeroPopularity("17109", 132);
            addHeroPopularity("132002", 129);
            addHeroPopularity("08025", 126);
            addHeroPopularity("04076", 126);
            addHeroPopularity("144002", 125);
            addHeroPopularity("07002", 124);
            addHeroPopularity("09002", 121);
            addHeroPopularity("143003", 119);
            addHeroPopularity("03001", 113);
            addHeroPopularity("06081", 112);
            addHeroPopularity("10028", 111);
            addHeroPopularity("11002", 110);
            addHeroPopularity("06107", 105);

            //1 Ring Heroes
            addHeroPopularity("12082", 94);
            addHeroPopularity("12030", 88);
            addHeroPopularity("132004", 85);
            addHeroPopularity("18002", 81);
            addHeroPopularity("132003", 73);
            addHeroPopularity("17001", 73);
            addHeroPopularity("02072", 65);
            addHeroPopularity("18001", 65);
            addHeroPopularity("17081", 62);
            addHeroPopularity("132005", 59);
            addHeroPopularity("12109", 58);
            addHeroPopularity("146003", 57);
            addHeroPopularity("141005", 54);
            addHeroPopularity("146004", 53);
            addHeroPopularity("10054", 45);
            addHeroPopularity("19001", 37);
            addHeroPopularity("06056", 33);
            addHeroPopularity("17135", 33);
            addHeroPopularity("19026", 15);
            addHeroPopularity("20002", 12);
            addHeroPopularity("20036", 10);
            addHeroPopularity("144001", 1);
            addHeroPopularity("146001", 1);
            addHeroPopularity("131001", 1);
            addHeroPopularity("20001", 1);
            addHeroPopularity("20003", 1);
            addHeroPopularity("20034", 1);
            addHeroPopularity("20035", 1);
            addHeroPopularity("141001", 1);
        }

        private void initializeCardPopularity()
        {
            //5 Ring Cards
            addCardPopularity("01073", 8864);
            addCardPopularity("01050", 8490);
            addCardPopularity("01026", 6592);
            addCardPopularity("01023", 5794);
            addCardPopularity("01057", 5563);
            addCardPopularity("01034", 5392);
            addCardPopularity("04108", 4875);
            addCardPopularity("04059", 4143);
            addCardPopularity("01046", 3859);
            addCardPopularity("04083", 3838);
            addCardPopularity("01048", 3618);
            addCardPopularity("04107", 3400);
            addCardPopularity("01045", 3176);
            addCardPopularity("01016", 2614);
            addCardPopularity("02056", 2479);
            addCardPopularity("10145", 2407);
            addCardPopularity("01014", 2392);
            addCardPopularity("04058", 2390);
            addCardPopularity("06005", 2374);
            addCardPopularity("01029", 2261);
            addCardPopularity("05018", 2212);
            addCardPopularity("02033", 2121);
            addCardPopularity("02026", 2103);
            addCardPopularity("01059", 2064);
            addCardPopularity("06006", 2059);
            addCardPopularity("01062", 1944);
            addCardPopularity("05007", 1938);
            addCardPopularity("131015", 1929);
            addCardPopularity("08117", 1923);
            addCardPopularity("01027", 1896);
            addCardPopularity("01069", 1864);
            addCardPopularity("04062", 1851);
            addCardPopularity("04134", 1840);
            addCardPopularity("01053", 1837);
            addCardPopularity("01070", 1808);
            addCardPopularity("01061", 1775);
            addCardPopularity("01060", 1774);
            addCardPopularity("02098", 1768);
            addCardPopularity("01028", 1717);
            addCardPopularity("02121", 1660);
            addCardPopularity("01035", 1653);
            addCardPopularity("141014", 1628);
            addCardPopularity("131014", 1606);
            addCardPopularity("07012", 1599);
            addCardPopularity("02004", 1554);
            addCardPopularity("02002", 1493);
            addCardPopularity("08146", 1490);
            addCardPopularity("01024", 1437);
            addCardPopularity("02103", 1428);
            addCardPopularity("05003", 1401);
            addCardPopularity("01013", 1397);
            addCardPopularity("04031", 1369);
            addCardPopularity("12009", 1347);
            addCardPopularity("01040", 1336);
            addCardPopularity("03009", 1318);
            addCardPopularity("01039", 1311);
            addCardPopularity("01051", 1305);
            addCardPopularity("01058", 1303);
            addCardPopularity("10004", 1287);
            addCardPopularity("04106", 1260);
            addCardPopularity("12059", 1257);
            addCardPopularity("01049", 1237);
            addCardPopularity("04129", 1220);
            addCardPopularity("02055", 1217);
            addCardPopularity("01072", 1196);
            addCardPopularity("04110", 1190);
            addCardPopularity("01066", 1189);
            addCardPopularity("07007", 1185);
            addCardPopularity("01044", 1166);
            addCardPopularity("01042", 1162);
            addCardPopularity("143006", 1160);
            addCardPopularity("05017", 1149);
            addCardPopularity("06010", 1140);
            addCardPopularity("10061", 1115);
            addCardPopularity("08119", 1098);
            addCardPopularity("02034", 1097);
            addCardPopularity("02119", 1078);
            addCardPopularity("143005", 1054);
            addCardPopularity("08121", 1051);
            addCardPopularity("02077", 1037);
            addCardPopularity("09012", 1035);
            addCardPopularity("131011", 1032);
            addCardPopularity("03011", 1021);
            addCardPopularity("04137", 1013);
            addCardPopularity("09004", 1010);
            addCardPopularity("08087", 995);
            addCardPopularity("02003", 991);
            addCardPopularity("12006", 982);
            addCardPopularity("07008", 970);
            addCardPopularity("10031", 963);
            addCardPopularity("04055", 955);
            addCardPopularity("01007", 943);
            addCardPopularity("11015", 937);
            addCardPopularity("02081", 934);
            addCardPopularity("08064", 929);
            addCardPopularity("02079", 925);
            addCardPopularity("02006", 896);
            addCardPopularity("01055", 854);
            addCardPopularity("142003", 851);
            addCardPopularity("01031", 837);
            addCardPopularity("06004", 837);
            addCardPopularity("01063", 831);
            addCardPopularity("06008", 828);
            addCardPopularity("10090", 827);
            addCardPopularity("142008", 827);
            addCardPopularity("12034", 818);
            addCardPopularity("07006", 804);

            //4 Ring Cards
            addCardPopularity("12085", 799);
            addCardPopularity("12032", 797);
            addCardPopularity("131010", 791);
            addCardPopularity("142009", 786);
            addCardPopularity("01065", 786);
            addCardPopularity("04131", 780);
            addCardPopularity("06143", 766);
            addCardPopularity("145008", 762);
            addCardPopularity("132018", 762);
            addCardPopularity("141006", 757);
            addCardPopularity("01043", 755);
            addCardPopularity("06037", 752);
            addCardPopularity("08141", 751);
            addCardPopularity("08002", 749);
            addCardPopularity("04101", 748);
            addCardPopularity("06009", 747);
            addCardPopularity("141013", 743);
            addCardPopularity("05008", 739);
            addCardPopularity("141016", 738);
            addCardPopularity("05009", 736);
            addCardPopularity("03008", 729);
            addCardPopularity("03007", 725);
            addCardPopularity("12084", 721);
            addCardPopularity("10010", 712);
            addCardPopularity("02005", 712);
            addCardPopularity("02030", 709);
            addCardPopularity("09014", 707);
            addCardPopularity("12062", 705);
            addCardPopularity("04006", 704);
            addCardPopularity("12117", 703);
            addCardPopularity("01018", 702);
            addCardPopularity("02008", 698);
            addCardPopularity("08063", 691);
            addCardPopularity("02104", 691);
            addCardPopularity("01041", 687);
            addCardPopularity("02010", 687);
            addCardPopularity("144010", 679);
            addCardPopularity("02120", 676);
            addCardPopularity("12091", 674);
            addCardPopularity("142006", 673);
            addCardPopularity("06108", 672);
            addCardPopularity("12064", 670);
            addCardPopularity("07011", 664);
            addCardPopularity("10140", 662);
            addCardPopularity("145004", 662);
            addCardPopularity("02075", 660);
            addCardPopularity("02057", 657);
            addCardPopularity("143009", 655);
            addCardPopularity("03003", 653);
            addCardPopularity("145010", 644);
            addCardPopularity("08088", 642);
            addCardPopularity("03004", 642);
            addCardPopularity("05006", 635);
            addCardPopularity("08118", 620);
            addCardPopularity("131006", 620);
            addCardPopularity("01020", 617);
            addCardPopularity("04003", 616);
            addCardPopularity("04135", 608);
            addCardPopularity("143010", 602);
            addCardPopularity("131008", 601);
            addCardPopularity("01022", 597);
            addCardPopularity("06002", 596);
            addCardPopularity("08092", 591);
            addCardPopularity("01030", 590);
            addCardPopularity("141015", 589);
            addCardPopularity("04079", 588);
            addCardPopularity("17008", 585);
            addCardPopularity("143014", 579);
            addCardPopularity("141009", 578);
            addCardPopularity("04133", 576);
            addCardPopularity("143004", 574);
            addCardPopularity("17006", 574);
            addCardPopularity("02100", 571);
            addCardPopularity("04077", 568);
            addCardPopularity("145002", 566);
            addCardPopularity("08113", 565);
            addCardPopularity("06003", 563);
            addCardPopularity("01005", 562);
            addCardPopularity("05013", 558);
            addCardPopularity("04036", 558);
            addCardPopularity("02053", 557);
            addCardPopularity("03013", 557);
            addCardPopularity("04057", 555);
            addCardPopularity("04128", 553);

            //3 Ring Cards
            addCardPopularity("16003", 548);
            addCardPopularity("10033", 547);
            addCardPopularity("131016", 541);
            addCardPopularity("01037", 539);
            addCardPopularity("04102", 537);
            addCardPopularity("08009", 536);
            addCardPopularity("01032", 534);
            addCardPopularity("06086", 534);
            addCardPopularity("143011", 534);
            addCardPopularity("08089", 533);
            addCardPopularity("143007", 532);
            addCardPopularity("01064", 530);
            addCardPopularity("06085", 529);
            addCardPopularity("08140", 529);
            addCardPopularity("04061", 527);
            addCardPopularity("08008", 527);
            addCardPopularity("01017", 526);
            addCardPopularity("10089", 525);
            addCardPopularity("11012", 523);
            addCardPopularity("01047", 523);
            addCardPopularity("06136", 522);
            addCardPopularity("131007", 519);
            addCardPopularity("01002", 519);
            addCardPopularity("132017", 519);
            addCardPopularity("16007", 517);
            addCardPopularity("04080", 513);
            addCardPopularity("10059", 512);
            addCardPopularity("142004", 511);
            addCardPopularity("01015", 502);
            addCardPopularity("08112", 497);
            addCardPopularity("01001", 496);
            addCardPopularity("08027", 494);
            addCardPopularity("10149", 490);
            addCardPopularity("142007", 485);
            addCardPopularity("08058", 473);
            addCardPopularity("12001", 472);
            addCardPopularity("01012", 472);
            addCardPopularity("144005", 467);
            addCardPopularity("12010", 466);
            addCardPopularity("10034", 463);
            addCardPopularity("08004", 459);
            addCardPopularity("04030", 458);
            addCardPopularity("141002", 458);
            addCardPopularity("12008", 456);
            addCardPopularity("12066", 456);
            addCardPopularity("10060", 456);
            addCardPopularity("10037", 455);
            addCardPopularity("11010", 453);
            addCardPopularity("12139", 453);
            addCardPopularity("141004", 452);
            addCardPopularity("142005", 450);

            //2 Ring Cards
            addCardPopularity("12083", 448);
            addCardPopularity("16011", 447);
            addCardPopularity("05014", 443);
            addCardPopularity("02102", 441);
            addCardPopularity("16005", 438);
            addCardPopularity("02059", 435);
            addCardPopularity("08065", 433);
            addCardPopularity("17032", 431);
            addCardPopularity("10116", 429);
            addCardPopularity("144007", 428);
            addCardPopularity("145009", 427);
            addCardPopularity("04004", 427);
            addCardPopularity("11014", 426);
            addCardPopularity("01054", 426);
            addCardPopularity("04010", 425);
            addCardPopularity("06084", 424);
            addCardPopularity("05015", 422);
            addCardPopularity("131009", 421);
            addCardPopularity("01036", 413);
            addCardPopularity("09003", 412);
            addCardPopularity("06115", 412);
            addCardPopularity("01004", 411);
            addCardPopularity("131013", 409);
            addCardPopularity("10006", 402);
            addCardPopularity("08138", 398);
            addCardPopularity("02123", 397);
            addCardPopularity("10146", 397);
            addCardPopularity("146005", 396);
            addCardPopularity("06137", 394);
            addCardPopularity("08120", 390);
            addCardPopularity("04053", 388);
            addCardPopularity("145005", 387);
            addCardPopularity("06135", 385);
            addCardPopularity("10122", 385);
            addCardPopularity("12116", 384);
            addCardPopularity("02009", 383);
            addCardPopularity("10032", 382);
            addCardPopularity("06060", 382);
            addCardPopularity("02051", 381);
            addCardPopularity("06041", 377);
            addCardPopularity("06114", 375);
            addCardPopularity("12004", 374);
            addCardPopularity("02116", 374);
            addCardPopularity("16004", 371);
            addCardPopularity("12037", 370);
            addCardPopularity("12060", 368);
            addCardPopularity("06087", 367);
            addCardPopularity("144006", 366);
            addCardPopularity("10029", 363);
            addCardPopularity("132016", 360);
            addCardPopularity("145007", 359);
            addCardPopularity("17004", 359);
            addCardPopularity("10120", 358);
            addCardPopularity("10143", 356);
            addCardPopularity("17060", 355);
            addCardPopularity("132006", 354);
            addCardPopularity("12002", 350);
            addCardPopularity("08057", 348);
            addCardPopularity("142002", 347);
            addCardPopularity("02078", 347);
            addCardPopularity("18007", 347);
            addCardPopularity("03002", 346);
            addCardPopularity("06089", 346);
            addCardPopularity("141010", 345);
            addCardPopularity("04084", 345);
            addCardPopularity("01006", 344);
            addCardPopularity("01010", 344);
            addCardPopularity("17005", 343);
            addCardPopularity("06034", 341);
            addCardPopularity("02007", 339);
            addCardPopularity("03006", 337);
            addCardPopularity("141012", 337);
            addCardPopularity("02032", 336);
            addCardPopularity("10062", 336);
            addCardPopularity("02029", 336);
            addCardPopularity("01052", 335);
            addCardPopularity("08114", 334);
            addCardPopularity("16010", 333);
            addCardPopularity("16008", 333);
            addCardPopularity("06112", 331);
            addCardPopularity("17033", 328);
            addCardPopularity("10092", 327);
            addCardPopularity("08139", 326);
            addCardPopularity("02096", 323);
            addCardPopularity("02025", 323);
            addCardPopularity("06141", 323);
            addCardPopularity("10118", 322);
            addCardPopularity("05004", 320);
            addCardPopularity("06110", 320);
            addCardPopularity("10124", 318);
            addCardPopularity("02122", 318);
            addCardPopularity("02080", 316);
            addCardPopularity("132015", 312);
            addCardPopularity("08086", 312);
            addCardPopularity("10091", 311);
            addCardPopularity("04130", 311);
            addCardPopularity("17030", 310);
            addCardPopularity("132008", 306);
            addCardPopularity("07010", 306);
            addCardPopularity("10005", 306);
            addCardPopularity("09007", 306);
            addCardPopularity("12058", 305);
            addCardPopularity("131012", 304);
            addCardPopularity("02117", 302);
            addCardPopularity("144008", 301);

            //1 Ring Cards
            addCardPopularity("05001", 299);
            addCardPopularity("144009", 298);
            addCardPopularity("10142", 298);
            addCardPopularity("11001", 294);
            addCardPopularity("04136", 294);
            addCardPopularity("03010", 293);
            addCardPopularity("10147", 292);
            addCardPopularity("10093", 292);
            addCardPopularity("06109", 291);
            addCardPopularity("04034", 290);
            addCardPopularity("06142", 288);
            addCardPopularity("06139", 287);
            addCardPopularity("07015", 285);
            addCardPopularity("04033", 284);
            addCardPopularity("03012", 282);
            addCardPopularity("10035", 282);
            addCardPopularity("12144", 281);
            addCardPopularity("08026", 278);
            addCardPopularity("09010", 277);
            addCardPopularity("08090", 276);
            addCardPopularity("08084", 276);
            addCardPopularity("02095", 274);
            addCardPopularity("18009", 272);
            addCardPopularity("09005", 271);
            addCardPopularity("141007", 271);
            addCardPopularity("143008", 270);
            addCardPopularity("17037", 269);
            addCardPopularity("141003", 268);
            addCardPopularity("17002", 268);
            addCardPopularity("12087", 265);
            addCardPopularity("08029", 262);
            addCardPopularity("06033", 260);
            addCardPopularity("01008", 260);
            addCardPopularity("146012", 257);
            addCardPopularity("04104", 256);
            addCardPopularity("06064", 255);
            addCardPopularity("145006", 254);
            addCardPopularity("10121", 252);
            addCardPopularity("12145", 252);
            addCardPopularity("06059", 250);
            addCardPopularity("145012", 249);
            addCardPopularity("08028", 246);
            addCardPopularity("145003", 246);
            addCardPopularity("01025", 246);
            addCardPopularity("11003", 246);
            addCardPopularity("04032", 246);
            addCardPopularity("11013", 244);
            addCardPopularity("02097", 244);
            addCardPopularity("17088", 244);
            addCardPopularity("06083", 243);
            addCardPopularity("17118", 243);
            addCardPopularity("146011", 242);
            addCardPopularity("06088", 239);
            addCardPopularity("06063", 239);
            addCardPopularity("08056", 238);
            addCardPopularity("144003", 238);
            addCardPopularity("08010", 237);
            addCardPopularity("02124", 237);
            addCardPopularity("11009", 236);
            addCardPopularity("02052", 236);
            addCardPopularity("09001", 235);
            addCardPopularity("10007", 235);
            addCardPopularity("08059", 234);
            addCardPopularity("12089", 233);
            addCardPopularity("17117", 233);
            addCardPopularity("10001", 231);
            addCardPopularity("141008", 230);
            addCardPopularity("10009", 229);
            addCardPopularity("02125", 228);
            addCardPopularity("17143", 228);
            addCardPopularity("10084", 227);
            addCardPopularity("04109", 226);
            addCardPopularity("01003", 225);
            addCardPopularity("01056", 225);
            addCardPopularity("07014", 222);
            addCardPopularity("146008", 222);
            addCardPopularity("10055", 219);
            addCardPopularity("144004", 216);
            addCardPopularity("08006", 215);
            addCardPopularity("18004", 215);
            addCardPopularity("10057", 214);
            addCardPopularity("04056", 213);
            addCardPopularity("16013", 213);
            addCardPopularity("12011", 211);
            addCardPopularity("06007", 211);
            addCardPopularity("01009", 210);
            addCardPopularity("143002", 209);
            addCardPopularity("12141", 209);
            addCardPopularity("17028", 206);
            addCardPopularity("146007", 205);
            addCardPopularity("01019", 203);
            addCardPopularity("16006", 203);
            addCardPopularity("132012", 202);
            addCardPopularity("06116", 202);
            addCardPopularity("10086", 202);
            addCardPopularity("141011", 202);
            addCardPopularity("06058", 199);
            addCardPopularity("17009", 199);
            addCardPopularity("01021", 198);
            addCardPopularity("04085", 198);
            addCardPopularity("12035", 196);
            addCardPopularity("17029", 196);
            addCardPopularity("09011", 195);
            addCardPopularity("18003", 194);
            addCardPopularity("131018", 192);
            addCardPopularity("12142", 192);
            addCardPopularity("131002", 191);
            addCardPopularity("07003", 190);
            addCardPopularity("08005", 189);
            addCardPopularity("06040", 188);
            addCardPopularity("12090", 187);
            addCardPopularity("01033", 187);
            addCardPopularity("06035", 185);
            addCardPopularity("10030", 184);
            addCardPopularity("08001", 182);
            addCardPopularity("18008", 182);
            addCardPopularity("02001", 180);
            addCardPopularity("04105", 179);
            addCardPopularity("02027", 179);
            addCardPopularity("10115", 178);
            addCardPopularity("12113", 178);
            addCardPopularity("17058", 178);
            addCardPopularity("131005", 177);
            addCardPopularity("07009", 177);
            addCardPopularity("17112", 176);
            addCardPopularity("144011", 175);
            addCardPopularity("18005", 175);
            addCardPopularity("09006", 173);
            addCardPopularity("17010", 172);
            addCardPopularity("04078", 171);
            addCardPopularity("02050", 170);
            addCardPopularity("05002", 170);
            addCardPopularity("01011", 170);
            addCardPopularity("131003", 169);
            addCardPopularity("07001", 168);
            addCardPopularity("08060", 164);
            addCardPopularity("08030", 164);
            addCardPopularity("02031", 163);
            addCardPopularity("143012", 163);
            addCardPopularity("18006", 163);
            addCardPopularity("04028", 162);
            addCardPopularity("09008", 162);
            addCardPopularity("12110", 162);
            addCardPopularity("18011", 162);
            addCardPopularity("02076", 161);
            addCardPopularity("132014", 161);
            addCardPopularity("10002", 160);
            addCardPopularity("12007", 159);
            addCardPopularity("10008", 159);
            addCardPopularity("10087", 158);
            addCardPopularity("18010", 158);
            addCardPopularity("06001", 157);
            addCardPopularity("01038", 156);
            addCardPopularity("08116", 156);
            addCardPopularity("144012", 156);
            addCardPopularity("17055", 156);
            addCardPopularity("132007", 155);
            addCardPopularity("12057", 155);
            addCardPopularity("07005", 155);
            addCardPopularity("11011", 155);
            addCardPopularity("04001", 154);
            addCardPopularity("131004", 154);
            addCardPopularity("04029", 154);
            addCardPopularity("06134", 153);
            addCardPopularity("04005", 153);
            addCardPopularity("10119", 153);
            addCardPopularity("17090", 153);
            addCardPopularity("10144", 152);
            addCardPopularity("16002", 151);
            addCardPopularity("17062", 151);
            addCardPopularity("17059", 151);
            addCardPopularity("17115", 151);
            addCardPopularity("02073", 150);
            addCardPopularity("12138", 150);
            addCardPopularity("06032", 147);
            addCardPopularity("08031", 145);
            addCardPopularity("17082", 145);
            addCardPopularity("146013", 145);
            addCardPopularity("16001", 144);
            addCardPopularity("17003", 142);
            addCardPopularity("06061", 141);
            addCardPopularity("01071", 141);
            addCardPopularity("132009", 141);
            addCardPopularity("17061", 141);
            addCardPopularity("18012", 140);
            addCardPopularity("17141", 139);
            addCardPopularity("132010", 138);
            addCardPopularity("02118", 137);
            addCardPopularity("04009", 137);
            addCardPopularity("17084", 136);
            addCardPopularity("08137", 135);
            addCardPopularity("17007", 135);
            addCardPopularity("146006", 135);
            addCardPopularity("02058", 134);
            addCardPopularity("16012", 134);
            addCardPopularity("11005", 133);
            addCardPopularity("01067", 133);
            addCardPopularity("09015", 133);
            addCardPopularity("17109", 132);
            addCardPopularity("17110", 131);
            addCardPopularity("08115", 130);
            addCardPopularity("132002", 129);
            addCardPopularity("02099", 128);
            addCardPopularity("08025", 126);
            addCardPopularity("04076", 126);
            addCardPopularity("144002", 125);
            addCardPopularity("10141", 125);
            addCardPopularity("07002", 124);
            addCardPopularity("04082", 124);
            addCardPopularity("17114", 123);
            addCardPopularity("12031", 122);
            addCardPopularity("09009", 122);
            addCardPopularity("09002", 121);
            addCardPopularity("12036", 121);
            addCardPopularity("145011", 120);
            addCardPopularity("143003", 119);
            addCardPopularity("10085", 115);
            addCardPopularity("02054", 115);
            addCardPopularity("12086", 113);
            addCardPopularity("03001", 113);
            addCardPopularity("05010", 112);
            addCardPopularity("06081", 112);
            addCardPopularity("07013", 111);
            addCardPopularity("10028", 111);
            addCardPopularity("11002", 110);
            addCardPopularity("142010", 107);
            addCardPopularity("10088", 107);
            addCardPopularity("17087", 107);
            addCardPopularity("06107", 105);
            addCardPopularity("12003", 104);
            addCardPopularity("06090", 104);
            addCardPopularity("17035", 104);
            addCardPopularity("12033", 102);
            addCardPopularity("08034", 102);
            addCardPopularity("11006", 102);
            addCardPopularity("09013", 100);
            addCardPopularity("131017", 100);
            addCardPopularity("06082", 100);
            addCardPopularity("12146", 100);
            addCardPopularity("04103", 99);
            addCardPopularity("17139", 99);
            addCardPopularity("19006", 99);
            addCardPopularity("08145", 98);
            addCardPopularity("12061", 98);
            addCardPopularity("12112", 98);
            addCardPopularity("06138", 96);
            addCardPopularity("05016", 96);
            addCardPopularity("12082", 94);
            addCardPopularity("11004", 94);
            addCardPopularity("04035", 92);
            addCardPopularity("06140", 90);
            addCardPopularity("06036", 90);
            addCardPopularity("12065", 90);
            addCardPopularity("12030", 88);
            addCardPopularity("17116", 88);
            addCardPopularity("12063", 87);
            addCardPopularity("12118", 87);
            addCardPopularity("04007", 86);
            addCardPopularity("132004", 85);
            addCardPopularity("08061", 85);
            addCardPopularity("08142", 85);
            addCardPopularity("06113", 84);
            addCardPopularity("06057", 84);
            addCardPopularity("06065", 83);
            addCardPopularity("17056", 82);
            addCardPopularity("04081", 81);
            addCardPopularity("12005", 81);
            addCardPopularity("18002", 81);
            addCardPopularity("02028", 80);
            addCardPopularity("02101", 78);
            addCardPopularity("17089", 75);
            addCardPopularity("08033", 74);
            addCardPopularity("17136", 74);
            addCardPopularity("132003", 73);
            addCardPopularity("04132", 73);
            addCardPopularity("17001", 73);
            addCardPopularity("01068", 72);
            addCardPopularity("12143", 72);
            addCardPopularity("06111", 71);
            addCardPopularity("08062", 70);
            addCardPopularity("17064", 70);
            addCardPopularity("08091", 69);
            addCardPopularity("04002", 69);
            addCardPopularity("19008", 68);
            addCardPopularity("12111", 67);
            addCardPopularity("17085", 67);
            addCardPopularity("04054", 66);
            addCardPopularity("10036", 66);
            addCardPopularity("05011", 65);
            addCardPopularity("02072", 65);
            addCardPopularity("18001", 65);
            addCardPopularity("132011", 64);
            addCardPopularity("12088", 63);
            addCardPopularity("04008", 63);
            addCardPopularity("17031", 63);
            addCardPopularity("19002", 63);
            addCardPopularity("11007", 62);
            addCardPopularity("17081", 62);
            addCardPopularity("131019", 61);
            addCardPopularity("05012", 61);
            addCardPopularity("08003", 61);
            addCardPopularity("132005", 59);
            addCardPopularity("10063", 59);
            addCardPopularity("12038", 59);
            addCardPopularity("12109", 58);
            addCardPopularity("08143", 58);
            addCardPopularity("08032", 58);
            addCardPopularity("17142", 58);
            addCardPopularity("05005", 57);
            addCardPopularity("07004", 57);
            addCardPopularity("146003", 57);
            addCardPopularity("18015", 57);
            addCardPopularity("19005", 56);
            addCardPopularity("06039", 55);
            addCardPopularity("10123", 55);
            addCardPopularity("17036", 55);
            addCardPopularity("141005", 54);
            addCardPopularity("11008", 54);
            addCardPopularity("10056", 53);
            addCardPopularity("146004", 53);
            addCardPopularity("18013", 53);
            addCardPopularity("10148", 51);
            addCardPopularity("12119", 50);
            addCardPopularity("12140", 50);
            addCardPopularity("08085", 49);
            addCardPopularity("146010", 48);
            addCardPopularity("19003", 48);
            addCardPopularity("10003", 46);
            addCardPopularity("10054", 45);
            addCardPopularity("17138", 45);
            addCardPopularity("08093", 44);
            addCardPopularity("19004", 44);
            addCardPopularity("06062", 42);
            addCardPopularity("03005", 42);
            addCardPopularity("17034", 42);
            addCardPopularity("17083", 42);
            addCardPopularity("19031", 39);
            addCardPopularity("08007", 38);
            addCardPopularity("145013", 38);
            addCardPopularity("06038", 37);
            addCardPopularity("02074", 37);
            addCardPopularity("12115", 37);
            addCardPopularity("19001", 37);
            addCardPopularity("19032", 36);
            addCardPopularity("17057", 35);
            addCardPopularity("19030", 35);
            addCardPopularity("06056", 33);
            addCardPopularity("146009", 33);
            addCardPopularity("17113", 33);
            addCardPopularity("17135", 33);
            addCardPopularity("17140", 31);
            addCardPopularity("12114", 30);
            addCardPopularity("08144", 29);
            addCardPopularity("17137", 28);
            addCardPopularity("17063", 25);
            addCardPopularity("131022", 22);
            addCardPopularity("131020", 22);
            addCardPopularity("19007", 22);
            addCardPopularity("143013", 21);
            addCardPopularity("132013", 21);
            addCardPopularity("10117", 20);
            addCardPopularity("04060", 20);
            addCardPopularity("16009", 20);
            addCardPopularity("10058", 19);
            addCardPopularity("19029", 19);
            addCardPopularity("144013", 18);
            addCardPopularity("19010", 18);
            addCardPopularity("17111", 15);
            addCardPopularity("19033", 15);
            addCardPopularity("19026", 15);
            addCardPopularity("131021", 14);
            addCardPopularity("17086", 13);
            addCardPopularity("17144", 13);
            addCardPopularity("18014", 12);
            addCardPopularity("20002", 12);
            addCardPopularity("19028", 12);
            addCardPopularity("19034", 11);
            addCardPopularity("04037", 10);
            addCardPopularity("132019", 10);
            addCardPopularity("20036", 10);
            addCardPopularity("19027", 10);
            addCardPopularity("20023", 8);
            addCardPopularity("20052", 8);
            addCardPopularity("19009", 7);
            addCardPopularity("19035", 7);
            addCardPopularity("132021", 5);
            addCardPopularity("132020", 4);
            addCardPopularity("20013", 4);
            addCardPopularity("20051", 4);
            addCardPopularity("20047", 4);
            addCardPopularity("20028", 4);
            addCardPopularity("20004", 4);
            addCardPopularity("20049", 4);
            addCardPopularity("20063", 4);
            addCardPopularity("132023", 3);
            addCardPopularity("132024", 3);
            addCardPopularity("20005", 3);
            addCardPopularity("20053", 3);
            addCardPopularity("132022", 2);
            addCardPopularity("20037", 2);
            addCardPopularity("20043", 2);
            addCardPopularity("20014", 2);
            addCardPopularity("20015", 2);
            addCardPopularity("20016", 2);
            addCardPopularity("20017", 2);
            addCardPopularity("20018", 2);
            addCardPopularity("20019", 2);
            addCardPopularity("20020", 2);
            addCardPopularity("20021", 2);
            addCardPopularity("20024", 2);
            addCardPopularity("20025", 2);
            addCardPopularity("20027", 2);
            addCardPopularity("20029", 2);
            addCardPopularity("20030", 2);
            addCardPopularity("20031", 2);
            addCardPopularity("20033", 2);
            addCardPopularity("20040", 2);
            addCardPopularity("20044", 2);
            addCardPopularity("20045", 2);
            addCardPopularity("20046", 2);
            addCardPopularity("20048", 2);
            addCardPopularity("20050", 2);
            addCardPopularity("20054", 2);
            addCardPopularity("20055", 2);
            addCardPopularity("20056", 2);
            addCardPopularity("20059", 2);
            addCardPopularity("20060", 2);
            addCardPopularity("20061", 2);
            addCardPopularity("20062", 2);
            addCardPopularity("20064", 2);
            addCardPopularity("20065", 2);
            addCardPopularity("144001", 1);
            addCardPopularity("146001", 1);
            addCardPopularity("131001", 1);
            addCardPopularity("20001", 1);
            addCardPopularity("20003", 1);
            addCardPopularity("20006", 1);
            addCardPopularity("20007", 1);
            addCardPopularity("20008", 1);
            addCardPopularity("20009", 1);
            addCardPopularity("20010", 1);
            addCardPopularity("20011", 1);
            addCardPopularity("20012", 1);
            addCardPopularity("20022", 1);
            addCardPopularity("20026", 1);
            addCardPopularity("20032", 1);
            addCardPopularity("20034", 1);
            addCardPopularity("20035", 1);
            addCardPopularity("20038", 1);
            addCardPopularity("20039", 1);
            addCardPopularity("20041", 1);
            addCardPopularity("20042", 1);
            addCardPopularity("20057", 1);
            addCardPopularity("20058", 1);
            addCardPopularity("141001", 1);
        }

        private uint getRingsDbSet(CardSet set)
        {
            switch (set.Cycle)
            {
                case "Shadows of Mirkwood":
                    return 2;
                case "Dwarrowdelf":
                    return 4;
                case "Against the Shadow":
                    return 6;
                case "The Ring-maker":
                    return 8;
                case "Angmar Awakened":
                    return 10;
                case "Dream-chaser":
                    return 12;
                case "Haradrim":
                    return 17;
                case "Ered Mithrin":
                    return 19;
                default:
                    break;
            }

            switch (set.Abbreviation)
            {
                //Core Set
                case "Core":
                    return 1;
                    
                //Khazad-dum
                case "KD":
                    return 3;
                    
                //Heirs of Numenor
                case "HoN":
                    return 5;
                    
                //The Voice of Isengard
                case "VoI":
                    return 7;

                //The Lost Realm
                case "TLR":
                    return 9;
                    
                //The Grey Havens
                case "TGH":
                    return 11;

                //The Sands of Harad
                case "TSoH":
                    return 16;

                //The Wilds of Rhovanion
                case "TWoR":
                    return 18;

                //The Hobbit
                case "THOHaUH":
                    return 131;
                case "THOtD":
                    return 132;

                //The Lord of the Rings
                case "TBR":
                    return 141;
                case "RD":
                    return 142;
                case "ToS":
                    return 143;
                case "TLoS":
                    return 144;
                case "TFotW":
                    return 145;
                case "TMoF":
                    return 146;
                default:
                    return 0;
            }
        }

        public string GetSlug(string cardId)
        {
            return slugByCardId.ContainsKey(cardId) ?
                slugByCardId[cardId]
                : string.Empty;
        }

        public string GetCardId(string slug)
        {
            if (!cardsBySlug.ContainsKey(slug))
            {
                return null;
            }

            var card = cardsBySlug[slug];

            if (card.CardSet == null)
            {
                return null;
            }

            var setNumber = getRingsDbSet(card.CardSet);

            if (setNumber >= 100)
            {
                return string.Format("{0:000}{1:000}", setNumber, card.CardNumber);
            }
            else
            {
                return string.Format("{0:00}{1:000}", setNumber, card.CardNumber);
            }
        }

        public byte GetPopularity(string slug)
        {
            var cardId = GetCardId(slug);

            return popularityByCardId.ContainsKey(cardId) ?
                popularityByCardId[cardId]
                : (byte)0;
        }

        public ushort GetVotes(string slug)
        {
            var cardId = GetCardId(slug);

            return votesByCardId.ContainsKey(cardId) ?
                votesByCardId[cardId]
                : (ushort)0;
        }
    }
}