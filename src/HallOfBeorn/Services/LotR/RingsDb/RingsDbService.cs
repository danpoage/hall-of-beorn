using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

using HallOfBeorn.Models.LotR;

namespace HallOfBeorn.Services.LotR.RingsDb
{
    public class RingsDbService : IRingsDbService
    {
        public RingsDbService(CardRepository cardRepository)
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

            initializePopularity();
        }

        private readonly Dictionary<string, LotRCard> cardsBySlug = new Dictionary<string,LotRCard>();
        private readonly Dictionary<string, string> slugByCardId = new Dictionary<string, string>();
        private readonly Dictionary<string, byte> popularityByCardId = new Dictionary<string, byte>();
        private readonly Dictionary<string, ushort> votesByCardId = new Dictionary<string, ushort>();

        private void addHeroPopularity(string cardId, ushort votes)
        {
            const ushort hero_5 = 260;
            const ushort hero_4 = 160;
            const ushort hero_3 = 115;
            const ushort hero_2 = 87;

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
            const ushort votes_5 = 500;
            const ushort votes_4 = 400;
            const ushort votes_3 = 200;
            const ushort votes_2 = 100;

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

        private void initializePopularity()
        {
            //5 Star Heroes (261+)
            addHeroPopularity("01007", 675);
            addHeroPopularity("04101", 576);
            addHeroPopularity("10140", 516);
            addHeroPopularity("145002", 433);
            addHeroPopularity("04128", 428);
            addHeroPopularity("01005", 405);
            addHeroPopularity("08112", 393);
            addHeroPopularity("01002", 387);
            addHeroPopularity("12001", 378);
            addHeroPopularity("01001", 349);
            addHeroPopularity("141004", 338);
            addHeroPopularity("01012", 336);
            addHeroPopularity("141002", 333);
            addHeroPopularity("01004", 306);
            addHeroPopularity("04053", 292);
            addHeroPopularity("142002", 272);
            addHeroPopularity("02116", 266);
            addHeroPopularity("03002", 261);

            //4 Star Heroes (161-245)
            addHeroPopularity("02025", 245);
            addHeroPopularity("01010", 240);
            addHeroPopularity("01006", 234);
            addHeroPopularity("05001", 225);
            addHeroPopularity("11001", 217);
            addHeroPopularity("08084", 215);
            addHeroPopularity("02095", 206);
            addHeroPopularity("10084", 196);
            addHeroPopularity("141003", 192);
            addHeroPopularity("01008", 187);
            addHeroPopularity("08056", 183);
            addHeroPopularity("145003", 182);
            addHeroPopularity("10001", 179);
            addHeroPopularity("09001", 173);
            addHeroPopularity("144003", 173);
            addHeroPopularity("143002", 162);
            addHeroPopularity("01003", 161);

            //3 Star Heroes (116-145)
            addHeroPopularity("10115", 145);
            addHeroPopularity("08001", 144);
            addHeroPopularity("131005", 144);
            addHeroPopularity("131002", 143);
            addHeroPopularity("01009", 142);
            addHeroPopularity("17028", 134);
            addHeroPopularity("06001", 132);
            addHeroPopularity("131004", 129);
            addHeroPopularity("16002", 126);
            addHeroPopularity("07001", 123);
            addHeroPopularity("12138", 123);
            addHeroPopularity("131003", 121);
            addHeroPopularity("12057", 119);
            addHeroPopularity("02050", 118);
            addHeroPopularity("06032", 117);
            addHeroPopularity("02001", 116);
            addHeroPopularity("16001", 116);

            //2 Star Heroes (88-114)
            addHeroPopularity("05002", 114);
            addHeroPopularity("06134", 114);
            addHeroPopularity("01011", 113);
            addHeroPopularity("04028", 111);
            addHeroPopularity("04001", 107);
            addHeroPopularity("04076", 105);
            addHeroPopularity("08137", 101);
            addHeroPopularity("08025", 101);
            addHeroPopularity("132002", 97);
            addHeroPopularity("07002", 97);
            addHeroPopularity("17055", 95);
            addHeroPopularity("09002", 94);
            addHeroPopularity("144002", 92);
            addHeroPopularity("06107", 91);
            addHeroPopularity("11002", 88);
            addHeroPopularity("10028", 88);

            //1 Star Heroes (<88)
            addHeroPopularity("143003", 85);
            addHeroPopularity("03001", 84);
            addHeroPopularity("06081", 78);
            addHeroPopularity("12082", 76);
            addHeroPopularity("132004", 69);
            addHeroPopularity("17109", 68);
            addHeroPopularity("132003", 63);
            addHeroPopularity("12030", 61);
            addHeroPopularity("17001", 55);
            addHeroPopularity("132005", 49);
            addHeroPopularity("12109", 46);
            addHeroPopularity("02072", 44);
            addHeroPopularity("146004", 41);
            addHeroPopularity("17081", 40);
            addHeroPopularity("10054", 35);
            addHeroPopularity("141005", 33);
            addHeroPopularity("146003", 33);
            addHeroPopularity("06056", 26);
            addHeroPopularity("17135", 16);
            addHeroPopularity("144001", 1);
            addHeroPopularity("146001", 1);

            //Player Cards
            addCardPopularity("01073", 6463);
            addCardPopularity("01050", 6430);
            addCardPopularity("01026", 5040);
            addCardPopularity("01023", 4274);
            addCardPopularity("01057", 4244);
            addCardPopularity("01034", 4037);
            addCardPopularity("04108", 3715);
            addCardPopularity("04059", 3210);
            addCardPopularity("04083", 2906);
            addCardPopularity("01046", 2893);
            addCardPopularity("01048", 2799);
            addCardPopularity("04107", 2595);
            addCardPopularity("01045", 2408);
            addCardPopularity("10145", 1856);
            addCardPopularity("06005", 1828);
            addCardPopularity("01016", 1820);
            addCardPopularity("04058", 1809);
            addCardPopularity("01014", 1791);
            addCardPopularity("02056", 1722);
            addCardPopularity("06006", 1705);
            addCardPopularity("05018", 1676);
            addCardPopularity("01029", 1579);
            addCardPopularity("02033", 1526);
            addCardPopularity("01059", 1500);
            addCardPopularity("08117", 1498);
            addCardPopularity("131015", 1491);
            addCardPopularity("02026", 1483);
            addCardPopularity("05007", 1462);
            addCardPopularity("04062", 1455);
            addCardPopularity("01062", 1419);
            addCardPopularity("01027", 1381);
            addCardPopularity("01053", 1372);
            addCardPopularity("131014", 1337);
            addCardPopularity("01070", 1322);
            addCardPopularity("04134", 1308);
            addCardPopularity("01060", 1301);
            addCardPopularity("07012", 1299);
            addCardPopularity("01069", 1281);
            addCardPopularity("02121", 1248);
            addCardPopularity("02098", 1235);
            addCardPopularity("01061", 1231);
            addCardPopularity("141014", 1215);
            addCardPopularity("01028", 1210);
            addCardPopularity("01035", 1167);
            addCardPopularity("08146", 1128);
            addCardPopularity("05003", 1113);
            addCardPopularity("02004", 1063);
            addCardPopularity("01024", 1045);
            addCardPopularity("04031", 1027);
            addCardPopularity("01040", 1014);
            addCardPopularity("01013", 1012);
            addCardPopularity("03009", 1003);
            addCardPopularity("12009", 997);
            addCardPopularity("10004", 992);
            addCardPopularity("02103", 987);
            addCardPopularity("02002", 986);
            addCardPopularity("04106", 981);
            addCardPopularity("12059", 976);
            addCardPopularity("01049", 963);
            addCardPopularity("04129", 961);
            addCardPopularity("01058", 956);
            addCardPopularity("01039", 935);
            addCardPopularity("06010", 922);
            addCardPopularity("02055", 907);
            addCardPopularity("01051", 902);
            addCardPopularity("07007", 901);
            addCardPopularity("143006", 895);
            addCardPopularity("04110", 881);
            addCardPopularity("01042", 860);
            addCardPopularity("01066", 848);
            addCardPopularity("09004", 846);
            addCardPopularity("143005", 833);
            addCardPopularity("05017", 832);
            addCardPopularity("01044", 824);
            addCardPopularity("01072", 822);
            addCardPopularity("08121", 817);
            addCardPopularity("03011", 806);
            addCardPopularity("08119", 799);
            addCardPopularity("12006", 794);
            addCardPopularity("04137", 789);
            addCardPopularity("09012", 785);
            addCardPopularity("131011", 772);
            addCardPopularity("10061", 763);
            addCardPopularity("07008", 756);
            addCardPopularity("02119", 749);
            addCardPopularity("08087", 746);
            addCardPopularity("02034", 739);
            addCardPopularity("08064", 739);
            addCardPopularity("04055", 727);
            addCardPopularity("02077", 718);
            addCardPopularity("02003", 715);
            addCardPopularity("02081", 713);
            addCardPopularity("10031", 705);
            addCardPopularity("06004", 705);
            addCardPopularity("06008", 701);
            addCardPopularity("11015", 687);
            addCardPopularity("02079", 680);
            addCardPopularity("01007", 675);
            addCardPopularity("01031", 645);
            addCardPopularity("02006", 645);
            addCardPopularity("142008", 634);
            addCardPopularity("142009", 634);
            addCardPopularity("12032", 633);
            addCardPopularity("142003", 622);
            addCardPopularity("10090", 619);
            addCardPopularity("07006", 619);
            addCardPopularity("01055", 618);
            addCardPopularity("06143", 617);
            addCardPopularity("131010", 610);
            addCardPopularity("12085", 608);
            addCardPopularity("01063", 607);
            addCardPopularity("132018", 599);
            addCardPopularity("145008", 588);
            addCardPopularity("01043", 587);
            addCardPopularity("04131", 584);
            addCardPopularity("08141", 581);
            addCardPopularity("04101", 576);
            addCardPopularity("141006", 571);
            addCardPopularity("05008", 565);
            addCardPopularity("08002", 564);
            addCardPopularity("06009", 563);
            addCardPopularity("07011", 551);
            addCardPopularity("10010", 551);
            addCardPopularity("01065", 549);
            addCardPopularity("08063", 542);
            addCardPopularity("145004", 536);
            addCardPopularity("141013", 533);
            addCardPopularity("06037", 531);
            addCardPopularity("05009", 529);
            addCardPopularity("03008", 525);
            addCardPopularity("144010", 525);
            addCardPopularity("01018", 523);
            addCardPopularity("141016", 522);
            addCardPopularity("142006", 522);
            addCardPopularity("10140", 516);
            addCardPopularity("06002", 515);
            addCardPopularity("12091", 514);
            addCardPopularity("09014", 512);
            addCardPopularity("03007", 509);
            addCardPopularity("12034", 509);
            addCardPopularity("145010", 508);
            addCardPopularity("02010", 506);
            addCardPopularity("02008", 506);
            addCardPopularity("02030", 503);
            addCardPopularity("03003", 502);
            addCardPopularity("05006", 497);
            addCardPopularity("06108", 495);
            addCardPopularity("12117", 495);
            addCardPopularity("04003", 493);
            addCardPopularity("04006", 491);
            addCardPopularity("12084", 486);
            addCardPopularity("08088", 484);
            addCardPopularity("131006", 483);
            addCardPopularity("02104", 482);
            addCardPopularity("05013", 479);
            addCardPopularity("12064", 473);
            addCardPopularity("08118", 471);
            addCardPopularity("143010", 470);
            addCardPopularity("06003", 464);
            addCardPopularity("02005", 463);
            addCardPopularity("01041", 462);
            addCardPopularity("143004", 462);
            addCardPopularity("12062", 461);
            addCardPopularity("02057", 459);
            addCardPopularity("131008", 457);
            addCardPopularity("141015", 455);
            addCardPopularity("08113", 453);
            addCardPopularity("03004", 452);
            addCardPopularity("143014", 452);
            addCardPopularity("02120", 450);
            addCardPopularity("08092", 448);
            addCardPopularity("06085", 447);
            addCardPopularity("08089", 447);
            addCardPopularity("04077", 447);
            addCardPopularity("10033", 446);
            addCardPopularity("02075", 446);
            addCardPopularity("131016", 445);
            addCardPopularity("143009", 445);
            addCardPopularity("04079", 441);
            addCardPopularity("143007", 439);
            addCardPopularity("04036", 438);
            addCardPopularity("145002", 433);
            addCardPopularity("16007", 432);
            addCardPopularity("132017", 430);
            addCardPopularity("01020", 429);
            addCardPopularity("04128", 428);
            addCardPopularity("04057", 425);
            addCardPopularity("08009", 424);
            addCardPopularity("01030", 423);
            addCardPopularity("16003", 420);
            addCardPopularity("131007", 412);
            addCardPopularity("04061", 411);
            addCardPopularity("04133", 411);
            addCardPopularity("08008", 411);
            addCardPopularity("142004", 410);
            addCardPopularity("01022", 409);
            addCardPopularity("02100", 409);
            addCardPopularity("04135", 408);
            addCardPopularity("10059", 407);
            addCardPopularity("01005", 405);
            addCardPopularity("04102", 405);
            addCardPopularity("02053", 401);
            addCardPopularity("06086", 399);
            addCardPopularity("03013", 399);
            addCardPopularity("142007", 398);
            addCardPopularity("10089", 398);
            addCardPopularity("08112", 393);
            addCardPopularity("01017", 393);
            addCardPopularity("141009", 393);
            addCardPopularity("01047", 392);
            addCardPopularity("11012", 390);
            addCardPopularity("10149", 389);
            addCardPopularity("12010", 387);
            addCardPopularity("01002", 387);
            addCardPopularity("04080", 387);
            addCardPopularity("143011", 384);
            addCardPopularity("01032", 382);
            addCardPopularity("08140", 382);
            addCardPopularity("01037", 381);
            addCardPopularity("16011", 380);
            addCardPopularity("12001", 378);
            addCardPopularity("05014", 375);
            addCardPopularity("08027", 372);
            addCardPopularity("06136", 371);
            addCardPopularity("144005", 371);
            addCardPopularity("17006", 370);
            addCardPopularity("17008", 369);
            addCardPopularity("01015", 366);
            addCardPopularity("10037", 366);
            addCardPopularity("08058", 362);
            addCardPopularity("10060", 361);
            addCardPopularity("01064", 356);
            addCardPopularity("11010", 353);
            addCardPopularity("02102", 353);
            addCardPopularity("01054", 352);
            addCardPopularity("142005", 350);
            addCardPopularity("04030", 349);
            addCardPopularity("01001", 349);
            addCardPopularity("08065", 345);
            addCardPopularity("12083", 345);
            addCardPopularity("10034", 343);
            addCardPopularity("12066", 342);
            addCardPopularity("12008", 338);
            addCardPopularity("141004", 338);
            addCardPopularity("12139", 337);
            addCardPopularity("01012", 336);
            addCardPopularity("131009", 335);
            addCardPopularity("141002", 333);
            addCardPopularity("10116", 332);
            addCardPopularity("10006", 332);
            addCardPopularity("144007", 332);
            addCardPopularity("08004", 326);
            addCardPopularity("145009", 325);
            addCardPopularity("06084", 323);
            addCardPopularity("04010", 322);
            addCardPopularity("11014", 321);
            addCardPopularity("10120", 318);
            addCardPopularity("131013", 318);
            addCardPopularity("10146", 316);
            addCardPopularity("05015", 314);
            addCardPopularity("08138", 313);
            addCardPopularity("01036", 313);
            addCardPopularity("09003", 312);
            addCardPopularity("04004", 312);
            addCardPopularity("02059", 311);
            addCardPopularity("08120", 310);
            addCardPopularity("12116", 307);
            addCardPopularity("01004", 306);
            addCardPopularity("12060", 306);
            addCardPopularity("06137", 304);
            addCardPopularity("10122", 302);
            addCardPopularity("145005", 301);
            addCardPopularity("06087", 293);
            addCardPopularity("144006", 293);
            addCardPopularity("12002", 293);
            addCardPopularity("16005", 293);
            addCardPopularity("04053", 292);
            addCardPopularity("06060", 289);
            addCardPopularity("16004", 287);
            addCardPopularity("10143", 285);
            addCardPopularity("12004", 285);
            addCardPopularity("17032", 285);
            addCardPopularity("06115", 281);
            addCardPopularity("06041", 281);
            addCardPopularity("145007", 277);
            addCardPopularity("02051", 277);
            addCardPopularity("10092", 277);
            addCardPopularity("06114", 276);
            addCardPopularity("04084", 276);
            addCardPopularity("08057", 272);
            addCardPopularity("142002", 272);
            addCardPopularity("06112", 272);
            addCardPopularity("10091", 269);
            addCardPopularity("06135", 269);
            addCardPopularity("08086", 268);
            addCardPopularity("17004", 268);
            addCardPopularity("132016", 267);
            addCardPopularity("02116", 266);
            addCardPopularity("02123", 265);
            addCardPopularity("10029", 265);
            addCardPopularity("12037", 265);
            addCardPopularity("132006", 263);
            addCardPopularity("02009", 262);
            addCardPopularity("03002", 261);
            addCardPopularity("10062", 261);
            addCardPopularity("06141", 261);
            addCardPopularity("10032", 261);
            addCardPopularity("08114", 260);
            addCardPopularity("10142", 259);
            addCardPopularity("16010", 259);
            addCardPopularity("09007", 257);
            addCardPopularity("17005", 257);
            addCardPopularity("132015", 248);
            addCardPopularity("10005", 246);
            addCardPopularity("141010", 246);
            addCardPopularity("02025", 245);
            addCardPopularity("01052", 243);
            addCardPopularity("01010", 240);
            addCardPopularity("02117", 240);
            addCardPopularity("08139", 240);
            addCardPopularity("08090", 239);
            addCardPopularity("16008", 238);
            addCardPopularity("03006", 237);
            addCardPopularity("07010", 236);
            addCardPopularity("06034", 236);
            addCardPopularity("10147", 235);
            addCardPopularity("01006", 234);
            addCardPopularity("10124", 233);
            addCardPopularity("12058", 233);
            addCardPopularity("144008", 233);
            addCardPopularity("08026", 231);
            addCardPopularity("02032", 230);
            addCardPopularity("10093", 230);
            addCardPopularity("09010", 229);
            addCardPopularity("06033", 229);
            addCardPopularity("02096", 228);
            addCardPopularity("06089", 228);
            addCardPopularity("02122", 227);
            addCardPopularity("146005", 227);
            addCardPopularity("05001", 225);
            addCardPopularity("10118", 225);
            addCardPopularity("02007", 225);
            addCardPopularity("17060", 225);
            addCardPopularity("132008", 223);
            addCardPopularity("10035", 223);
            addCardPopularity("04034", 221);
            addCardPopularity("04136", 218);
            addCardPopularity("02078", 218);
            addCardPopularity("06110", 218);
            addCardPopularity("11001", 217);
            addCardPopularity("07015", 216);
            addCardPopularity("08084", 215);
            addCardPopularity("03010", 213);
            addCardPopularity("04130", 211);
            addCardPopularity("06139", 211);
            addCardPopularity("02029", 210);
            addCardPopularity("09005", 208);
            addCardPopularity("06109", 206);
            addCardPopularity("02095", 206);
            addCardPopularity("144009", 206);
            addCardPopularity("06142", 205);
            addCardPopularity("02080", 205);
            addCardPopularity("17030", 205);
            addCardPopularity("04033", 204);
            addCardPopularity("12144", 204);
            addCardPopularity("17033", 204);
            addCardPopularity("05004", 202);
            addCardPopularity("06083", 201);
            addCardPopularity("12087", 200);
            addCardPopularity("143008", 200);
            addCardPopularity("08028", 199);
            addCardPopularity("145012", 199);
            addCardPopularity("141007", 198);
            addCardPopularity("10084", 196);
            addCardPopularity("03012", 196);
            addCardPopularity("17037", 194);
            addCardPopularity("08029", 193);
            addCardPopularity("141003", 192);
            addCardPopularity("10121", 190);
            addCardPopularity("02097", 190);
            addCardPopularity("141012", 189);
            addCardPopularity("12011", 188);
            addCardPopularity("01008", 187);
            addCardPopularity("11013", 185);
            addCardPopularity("08056", 183);
            addCardPopularity("10007", 183);
            addCardPopularity("08010", 183);
            addCardPopularity("11003", 183);
            addCardPopularity("145003", 182);
            addCardPopularity("04104", 182);
            addCardPopularity("145006", 180);
            addCardPopularity("01025", 179);
            addCardPopularity("10001", 179);
            addCardPopularity("06064", 178);
            addCardPopularity("11009", 175);
            addCardPopularity("141008", 175);
            addCardPopularity("06059", 174);
            addCardPopularity("09001", 173);
            addCardPopularity("144003", 173);
            addCardPopularity("06116", 171);
            addCardPopularity("06088", 169);
            addCardPopularity("02124", 168);
            addCardPopularity("10057", 167);
            addCardPopularity("04056", 167);
            addCardPopularity("144004", 167);
            addCardPopularity("08059", 167);
            addCardPopularity("10009", 165);
            addCardPopularity("12089", 165);
            addCardPopularity("08006", 162);
            addCardPopularity("143002", 162);
            addCardPopularity("01003", 161);
            addCardPopularity("04109", 161);
            addCardPopularity("12145", 161);
            addCardPopularity("17002", 160);
            addCardPopularity("10086", 159);
            addCardPopularity("132012", 158);
            addCardPopularity("04032", 158);
            addCardPopularity("07003", 157);
            addCardPopularity("131018", 156);
            addCardPopularity("141011", 156);
            addCardPopularity("01056", 155);
            addCardPopularity("02125", 155);
            addCardPopularity("10055", 154);
            addCardPopularity("07009", 154);
            addCardPopularity("12141", 153);
            addCardPopularity("07014", 151);
            addCardPopularity("16013", 151);
            addCardPopularity("12035", 150);
            addCardPopularity("09006", 150);
            addCardPopularity("06007", 150);
            addCardPopularity("06058", 150);
            addCardPopularity("04085", 149);
            addCardPopularity("06063", 149);
            addCardPopularity("08005", 147);
            addCardPopularity("01019", 146);
            addCardPopularity("10115", 145);
            addCardPopularity("16006", 145);
            addCardPopularity("17009", 145);
            addCardPopularity("08001", 144);
            addCardPopularity("131005", 144);
            addCardPopularity("12142", 144);
            addCardPopularity("131002", 143);
            addCardPopularity("12113", 143);
            addCardPopularity("01009", 142);
            addCardPopularity("17029", 142);
            addCardPopularity("17088", 142);
            addCardPopularity("06035", 141);
            addCardPopularity("02052", 141);
            addCardPopularity("146011", 141);
            addCardPopularity("09008", 139);
            addCardPopularity("146012", 138);
            addCardPopularity("131012", 137);
            addCardPopularity("04105", 136);
            addCardPopularity("01021", 136);
            addCardPopularity("09011", 136);
            addCardPopularity("10144", 136);
            addCardPopularity("01033", 136);
            addCardPopularity("17028", 134);
            addCardPopularity("10030", 132);
            addCardPopularity("06001", 132);
            addCardPopularity("143012", 130);
            addCardPopularity("131004", 129);
            addCardPopularity("08116", 129);
            addCardPopularity("132007", 128);
            addCardPopularity("132014", 126);
            addCardPopularity("16002", 126);
            addCardPopularity("12090", 125);
            addCardPopularity("17010", 125);
            addCardPopularity("10002", 123);
            addCardPopularity("08030", 123);
            addCardPopularity("06040", 123);
            addCardPopularity("07001", 123);
            addCardPopularity("12110", 123);
            addCardPopularity("12138", 123);
            addCardPopularity("08060", 122);
            addCardPopularity("144011", 122);
            addCardPopularity("131003", 121);
            addCardPopularity("146008", 120);
            addCardPopularity("12057", 119);
            addCardPopularity("02031", 119);
            addCardPopularity("02050", 118);
            addCardPopularity("06032", 117);
            addCardPopularity("04078", 117);
            addCardPopularity("06061", 116);
            addCardPopularity("04029", 116);
            addCardPopularity("02001", 116);
            addCardPopularity("10087", 116);
            addCardPopularity("16001", 116);
            addCardPopularity("17061", 115);
            addCardPopularity("146007", 115);
            addCardPopularity("05002", 114);
            addCardPopularity("06134", 114);
            addCardPopularity("132009", 114);
            addCardPopularity("01011", 113);
            addCardPopularity("146013", 113);
            addCardPopularity("08031", 112);
            addCardPopularity("17058", 112);
            addCardPopularity("04028", 111);
            addCardPopularity("07005", 110);
            addCardPopularity("132010", 110);
            addCardPopularity("09015", 108);
            addCardPopularity("04001", 107);
            addCardPopularity("02099", 106);
            addCardPopularity("02058", 106);
            addCardPopularity("17003", 106);
            addCardPopularity("04076", 105);
            addCardPopularity("10008", 104);
            addCardPopularity("12007", 103);
            addCardPopularity("02027", 103);
            addCardPopularity("10141", 103);
            addCardPopularity("08115", 102);
            addCardPopularity("01071", 102);
            addCardPopularity("17117", 102);
            addCardPopularity("11005", 101);
            addCardPopularity("01038", 101);
            addCardPopularity("08137", 101);
            addCardPopularity("01067", 101);
            addCardPopularity("08025", 101);
            addCardPopularity("17090", 101);
            addCardPopularity("04005", 100);
            addCardPopularity("10119", 100);
            addCardPopularity("17059", 100);
            addCardPopularity("17082", 100);
            addCardPopularity("12086", 98);
            addCardPopularity("132002", 97);
            addCardPopularity("145011", 97);
            addCardPopularity("07002", 97);
            addCardPopularity("12031", 96);
            addCardPopularity("144012", 96);
            addCardPopularity("16012", 96);
            addCardPopularity("11011", 95);
            addCardPopularity("17055", 95);
            addCardPopularity("09002", 94);
            addCardPopularity("10088", 94);
            addCardPopularity("02076", 94);
            addCardPopularity("146006", 94);
            addCardPopularity("09009", 93);
            addCardPopularity("17112", 93);
            addCardPopularity("04082", 92);
            addCardPopularity("144002", 92);
            addCardPopularity("06107", 91);
            addCardPopularity("17007", 90);
            addCardPopularity("17062", 90);
            addCardPopularity("11002", 88);
            addCardPopularity("05010", 88);
            addCardPopularity("10028", 88);
            addCardPopularity("12036", 88);
            addCardPopularity("09013", 87);
            addCardPopularity("08034", 87);
            addCardPopularity("17084", 87);
            addCardPopularity("12146", 86);
            addCardPopularity("131017", 85);
            addCardPopularity("12061", 85);
            addCardPopularity("143003", 85);
            addCardPopularity("04009", 85);
            addCardPopularity("07013", 84);
            addCardPopularity("03001", 84);
            addCardPopularity("11006", 83);
            addCardPopularity("10085", 82);
            addCardPopularity("02118", 82);
            addCardPopularity("17115", 82);
            addCardPopularity("08145", 80);
            addCardPopularity("06140", 80);
            addCardPopularity("17143", 80);
            addCardPopularity("17114", 79);
            addCardPopularity("06081", 78);
            addCardPopularity("12112", 77);
            addCardPopularity("12082", 76);
            addCardPopularity("12003", 75);
            addCardPopularity("06082", 75);
            addCardPopularity("06090", 75);
            addCardPopularity("05016", 74);
            addCardPopularity("06138", 73);
            addCardPopularity("12033", 72);
            addCardPopularity("17118", 72);
            addCardPopularity("04103", 71);
            addCardPopularity("12065", 71);
            addCardPopularity("06113", 70);
            addCardPopularity("04081", 69);
            addCardPopularity("132004", 69);
            addCardPopularity("17109", 68);
            addCardPopularity("12063", 67);
            addCardPopularity("11004", 66);
            addCardPopularity("06065", 66);
            addCardPopularity("17035", 65);
            addCardPopularity("02054", 64);
            addCardPopularity("17056", 64);
            addCardPopularity("132003", 63);
            addCardPopularity("06036", 63);
            addCardPopularity("12143", 63);
            addCardPopularity("08061", 62);
            addCardPopularity("02073", 62);
            addCardPopularity("17089", 62);
            addCardPopularity("12030", 61);
            addCardPopularity("04035", 61);
            addCardPopularity("08062", 61);
            addCardPopularity("17087", 60);
            addCardPopularity("06111", 59);
            addCardPopularity("12118", 59);
            addCardPopularity("142010", 56);
            addCardPopularity("08091", 55);
            addCardPopularity("04002", 55);
            addCardPopularity("08142", 55);
            addCardPopularity("12005", 55);
            addCardPopularity("17001", 55);
            addCardPopularity("06057", 54);
            addCardPopularity("08033", 52);
            addCardPopularity("05011", 51);
            addCardPopularity("01068", 51);
            addCardPopularity("05012", 51);
            addCardPopularity("10063", 51);
            addCardPopularity("17031", 51);
            addCardPopularity("132011", 50);
            addCardPopularity("12111", 50);
            addCardPopularity("132005", 49);
            addCardPopularity("04007", 49);
            addCardPopularity("05005", 49);
            addCardPopularity("02101", 48);
            addCardPopularity("08003", 48);
            addCardPopularity("17085", 48);
            addCardPopularity("04132", 47);
            addCardPopularity("131019", 46);
            addCardPopularity("12109", 46);
            addCardPopularity("10123", 46);
            addCardPopularity("17064", 46);
            addCardPopularity("12088", 45);
            addCardPopularity("04008", 44);
            addCardPopularity("02072", 44);
            addCardPopularity("10036", 42);
            addCardPopularity("10148", 42);
            addCardPopularity("146004", 41);
            addCardPopularity("11007", 40);
            addCardPopularity("10056", 40);
            addCardPopularity("07004", 40);
            addCardPopularity("17081", 40);
            addCardPopularity("08032", 37);
            addCardPopularity("06039", 37);
            addCardPopularity("02028", 36);
            addCardPopularity("146010", 36);
            addCardPopularity("17141", 36);
            addCardPopularity("10054", 35);
            addCardPopularity("08093", 35);
            addCardPopularity("08085", 35);
            addCardPopularity("06062", 34);
            addCardPopularity("17036", 34);
            addCardPopularity("17116", 34);
            addCardPopularity("141005", 33);
            addCardPopularity("12119", 33);
            addCardPopularity("146003", 33);
            addCardPopularity("08007", 32);
            addCardPopularity("06038", 31);
            addCardPopularity("12140", 31);
            addCardPopularity("145013", 31);
            addCardPopularity("08143", 29);
            addCardPopularity("12114", 29);
            addCardPopularity("17057", 29);
            addCardPopularity("17139", 29);
            addCardPopularity("17142", 29);
            addCardPopularity("04054", 28);
            addCardPopularity("11008", 28);
            addCardPopularity("06056", 26);
            addCardPopularity("03005", 26);
            addCardPopularity("12038", 26);
            addCardPopularity("146009", 26);
            addCardPopularity("17034", 24);
            addCardPopularity("17110", 24);
            addCardPopularity("17140", 22);
            addCardPopularity("17063", 21);
            addCardPopularity("10003", 20);
            addCardPopularity("17083", 20);
            addCardPopularity("17136", 20);
            addCardPopularity("10117", 19);
            addCardPopularity("12115", 19);
            addCardPopularity("16009", 19);
            addCardPopularity("131022", 18);
            addCardPopularity("131020", 18);
            addCardPopularity("144013", 17);
            addCardPopularity("143013", 16);
            addCardPopularity("17135", 16);
            addCardPopularity("02074", 15);
            addCardPopularity("10058", 15);
            addCardPopularity("08144", 14);
            addCardPopularity("17144", 13);
            addCardPopularity("132013", 12);
            addCardPopularity("04060", 12);
            addCardPopularity("131021", 11);
            addCardPopularity("17113", 11);
            addCardPopularity("17111", 10);
            addCardPopularity("132019", 9);
            addCardPopularity("17086", 6);
            addCardPopularity("04037", 5);
            addCardPopularity("132021", 4);
            addCardPopularity("132023", 3);
            addCardPopularity("132024", 3);
            addCardPopularity("17137", 3);
            addCardPopularity("17138", 3);
            addCardPopularity("132020", 2);
            addCardPopularity("132022", 2);
            addCardPopularity("144001", 1);
            addCardPopularity("146001", 1);
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