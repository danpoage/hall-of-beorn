using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

using HallOfBeorn.Models.LotR;

namespace HallOfBeorn.Services.LotR
{
    public class RingsDbService
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

        private void addHeroPopularity(string cardId, ushort votes)
        {
            const ushort hero_5 = 260;
            const ushort hero_4 = 160;
            const ushort hero_3 = 115;
            const ushort hero_2 = 87;

            if (votes > hero_5)
                addPopularity(cardId, 5);
            else if (votes > hero_4)
                addPopularity(cardId, 4);
            else if (votes > hero_3)
                addPopularity(cardId, 3);
            else if (votes > hero_2)
                addPopularity(cardId, 2);
            else
                addPopularity(cardId, 1);
        }

        private void addCardPopularity(string cardId, ushort votes)
        {
            const ushort votes_5 = 500;
            const ushort votes_4 = 400;
            const ushort votes_3 = 200;
            const ushort votes_2 = 100;

            if (votes > votes_5)
                addPopularity(cardId, 5);
            else if (votes > votes_4)
                addPopularity(cardId, 4);
            else if (votes > votes_3)
                addPopularity(cardId, 3);
            else if (votes > votes_2)
                addPopularity(cardId, 2);
            else
                addPopularity(cardId, 1);
        }

        private void addPopularity(string cardId, byte popularity, ushort votes)
        {
            addPopularity(cardId, popularity);
        }

        private void addPopularity(string cardId, byte popularity)
        {
            if (popularityByCardId.ContainsKey(cardId)) {
                return;
            }

            popularityByCardId[cardId] = popularity;
        }

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

        private void initializePopularityOld()
        {
            //5++ Star Heroes (200+ votes)
            addPopularity("10140", 5);
            addPopularity("01007", 5);
            addPopularity("04101", 5);

            //5+ Star Heroes (121-199 votes)
            addPopularity("145002", 5);
            addPopularity("04128", 5);
            addPopularity("08112", 5);
            addPopularity("01005", 5);
            addPopularity("12001", 5);
            addPopularity("01012", 5);

            //5 Star Heroes (88+ votes)
            addPopularity("04053", 5);
            addPopularity("141004", 5);
            addPopularity("01001", 5);
            addPopularity("142002", 5);
            addPopularity("01002", 5);
            addPopularity("01004", 5);
            addPopularity("141002", 5);
            addPopularity("11001", 5);
            addPopularity("03002", 5);
            addPopularity("02116", 5);
            addPopularity("145003", 5);
            addPopularity("02095", 5);

            //4 Star Heroes (58-87 votes)
            addPopularity("05001", 4);
            addPopularity("08084", 4);
            addPopularity("02025", 4);
            addPopularity("141003", 4);
            addPopularity("01006", 4);
            addPopularity("144003", 4);
            addPopularity("10084", 4);
            addPopularity("08056", 4);
            addPopularity("09001", 4);
            addPopularity("01010", 4);
            addPopularity("06001", 4);
            addPopularity("01008", 4);
            addPopularity("131005", 4);
            addPopularity("131002", 4);
            addPopularity("131004", 4);

            //3 Star Heroes (46-57 votes)
            addPopularity("143002", 3);
            addPopularity("12138", 3);
            addPopularity("16001", 3);
            addPopularity("16002", 3);
            addPopularity("02050", 3);
            addPopularity("12057", 3);
            addPopularity("08001", 3);
            addPopularity("10001", 3);
            addPopularity("131003", 3);
            addPopularity("06134", 3);
            addPopularity("07001", 3);
            addPopularity("10115", 3);
            addPopularity("132002", 3);
            addPopularity("06032", 3);
            addPopularity("11002", 3);

            //2 Star Heroes (32-45 votes)
            addPopularity("04001", 2);
            addPopularity("04028", 2);
            addPopularity("01003", 2);
            addPopularity("04076", 2);
            addPopularity("144002", 2);
            addPopularity("05002", 2);
            addPopularity("01009", 2);
            addPopularity("12082", 2);
            addPopularity("10028", 2);
            addPopularity("06107", 2);
            addPopularity("08137", 2);
            addPopularity("01011", 2);
            addPopularity("07002", 2);
            addPopularity("09002", 2);
            addPopularity("08025", 2);

            //1 Star Heroes (1-31 votes)
            addPopularity("143003", 1);
            addPopularity("06081", 1);
            addPopularity("12030", 1);
            addPopularity("02001", 1);
            addPopularity("132004", 1);
            addPopularity("132003", 1);
            addPopularity("12109", 1);
            addPopularity("02072", 1);
            addPopularity("03001", 1);
            addPopularity("132005", 1);
            addPopularity("141005", 1);
            addPopularity("10054", 1);
            addPopularity("17001", 1);
            addPopularity("06056", 1);
            addPopularity("17028", 1);
            addPopularity("144001", 1);

            //5++ star player cards
            addPopularity("01050", 5); //A Test of Will
            addPopularity("01073", 5); //Gandalf (Core)
            addPopularity("01026", 5); //Steward of Gondor
            addPopularity("01057", 5); //Unexpected Courage
            addPopularity("01023", 5); //Sneak Attack
            addPopularity("01034", 5); //Feint
            addPopularity("04108", 5); //Daeron's Runes
            addPopularity("04059", 5); //Elrond's Counsel
            addPopularity("04083", 5); //Warden of Healing
            addPopularity("01046", 5); //Galadhrim's Greeting

            //5+ star player cards
            addPopularity("04107", 5);
            addPopularity("01048", 5);
            addPopularity("01045", 5);
            addPopularity("10145", 5);
            addPopularity("06005", 5);
            addPopularity("06006", 5);
            addPopularity("02056", 5);
            addPopularity("08117", 5);
            addPopularity("04058", 5);
            addPopularity("05018", 5);
            addPopularity("131015", 5);
            addPopularity("01014", 5);
            addPopularity("02033", 5);
            addPopularity("04062", 5);
            addPopularity("05007", 5);
            addPopularity("04134", 5);
            addPopularity("01059", 5);
            addPopularity("07012", 5);
            addPopularity("01016", 5);
            addPopularity("01070", 5);
            addPopularity("01062", 5);
            addPopularity("01053", 5);
            addPopularity("02026", 5);
            addPopularity("131014", 5);
            addPopularity("01029", 5);
            addPopularity("02098", 5);
            addPopularity("05003", 5);
            addPopularity("01060", 5);
            addPopularity("01027", 5);
            addPopularity("04106", 5);
            addPopularity("141014", 5);
            addPopularity("12059", 5);
            addPopularity("04129", 5);
            addPopularity("02121", 5);
            addPopularity("06010", 5);
            addPopularity("01049", 5);
            addPopularity("04031", 5);
            addPopularity("01069", 5);
            addPopularity("01061", 5);
            addPopularity("01028", 5);
            addPopularity("01035", 5);
            addPopularity("07007", 5);
            addPopularity("12009", 5);
            addPopularity("03009", 5);
            addPopularity("08146", 5);
            addPopularity("10004", 5);
            addPopularity("02004", 5);
            addPopularity("12006", 5);
            addPopularity("09004", 5);
            addPopularity("01024", 5);
            addPopularity("01058", 5);
            addPopularity("07008", 5);
            addPopularity("08121", 5);
            addPopularity("131011", 5);
            addPopularity("01042", 5);
            addPopularity("143005", 5);
            addPopularity("04137", 5);
            addPopularity("01039", 5);
            addPopularity("05017", 5);
            addPopularity("02002", 5);
            addPopularity("01040", 5);
            addPopularity("06008", 5);
            addPopularity("03011", 5);
            addPopularity("08064", 5);
            addPopularity("09012", 5);
            addPopularity("04110", 5);
            addPopularity("142003", 5);
            addPopularity("06004", 5);
            addPopularity("01051", 5);
            addPopularity("02003", 5);
            addPopularity("01066", 5);
            addPopularity("04055", 5);
            addPopularity("10090", 5);
            addPopularity("02055", 5);
            addPopularity("02079", 5);
            addPopularity("08087", 5);
            addPopularity("11015", 5);
            addPopularity("143006", 5);
            addPopularity("02081", 5);
            addPopularity("12085", 5);
            addPopularity("12091", 5);
            addPopularity("01072", 5);
            addPopularity("06143", 5);
            addPopularity("08119", 5);
            addPopularity("02119", 5);
            addPopularity("02103", 5);
            addPopularity("10061", 5);
            addPopularity("04131", 5);
            addPopularity("10031", 5);
            addPopularity("12032", 5);

            //5 Star player cards (200+ votes)
            addPopularity("02034", 5);
            addPopularity("142009", 5);
            addPopularity("07006", 5);
            addPopularity("01044", 5);
            addPopularity("06009", 5);
            addPopularity("01031", 5);
            addPopularity("131010", 5);
            addPopularity("01013", 5);
            addPopularity("05008", 5);
            addPopularity("142008", 5);
            addPopularity("132018", 5);
            addPopularity("05013", 5);
            addPopularity("10140", 5);
            addPopularity("06002", 5);
            addPopularity("145008", 5);
            addPopularity("145010", 5);
            addPopularity("145004", 5);
            addPopularity("02077", 5);
            addPopularity("12062", 5);
            addPopularity("12084", 5);
            addPopularity("06108", 5);
            addPopularity("01063", 5);
            addPopularity("08118", 5);
            addPopularity("10010", 5);
            addPopularity("04133", 5);
            addPopularity("05006", 5);
            addPopularity("131006", 5);
            addPopularity("16007", 5);
            addPopularity("08063", 5);
            addPopularity("07011", 5);
            addPopularity("01055", 5);
            addPopularity("06037", 5);
            addPopularity("01007", 5);
            addPopularity("04101", 5);

            //4 Star Player Cards (121-199 votes)
            addPopularity("03003", 4, 196);
            addPopularity("08002", 4, 194);
            addPopularity("144010", 4, 194);
            addPopularity("04057", 4, 193);
            addPopularity("08088", 4, 193);
            addPopularity("06085", 4, 192);
            addPopularity("10089", 4, 192);
            addPopularity("08113", 4, 191);
            addPopularity("06086", 4, 191);
            addPopularity("143010", 4, 190);
            addPopularity("143004", 4, 189);
            addPopularity("02120", 4, 188);
            addPopularity("141016", 4, 186);
            addPopularity("08092", 4, 186);
            addPopularity("03008", 4, 185);
            addPopularity("12034", 4, 184);
            addPopularity("145002", 4, 184);
            addPopularity("142006", 4, 183);
            addPopularity("08141", 4, 183);
            addPopularity("02030", 4, 182);
            addPopularity("09014", 4, 182);
            addPopularity("02053", 4, 179);
            addPopularity("05009", 4, 177);
            addPopularity("131008", 4, 177);
            addPopularity("01065", 4, 177);
            addPopularity("04061", 4, 176);
            addPopularity("06003", 4, 176);
            addPopularity("04077", 4, 176);
            addPopularity("10059", 4, 175);
            addPopularity("03007", 4, 175);
            addPopularity("12064", 4, 175);
            addPopularity("04036", 4, 175);
            addPopularity("04079", 4, 175);
            addPopularity("12083", 4, 174);
            addPopularity("04128", 4, 174);
            addPopularity("10149", 4, 173);
            addPopularity("142007", 4, 172);
            addPopularity("12117", 4, 172);
            addPopularity("02104", 4, 171);
            addPopularity("131007", 4, 170);
            addPopularity("145009", 4, 168);
            addPopularity("04003", 4, 167);
            addPopularity("141006", 4, 166);
            addPopularity("16011", 4, 165);
            addPopularity("10033", 4, 164);
            addPopularity("01018", 4, 164);
            addPopularity("132017", 4, 164);
            addPopularity("142004", 4, 164);
            addPopularity("05014", 4, 163);
            addPopularity("02006", 4, 163);
            addPopularity("04102", 4, 162);
            addPopularity("04135", 4, 162);
            addPopularity("143014", 4, 160);
            addPopularity("08065", 4, 159);
            addPopularity("10120", 4, 158);
            addPopularity("11010", 4, 158);
            addPopularity("12066", 4, 158);
            addPopularity("143007", 4, 157);
            addPopularity("02057", 4, 157);
            addPopularity("08112", 4, 156);
            addPopularity("10060", 4, 155);
            addPopularity("01005", 4, 154);
            addPopularity("08009", 4, 154);
            addPopularity("01030", 4, 154);
            addPopularity("02005", 4, 154);
            addPopularity("143009", 4, 153);
            addPopularity("02075", 4, 153);
            addPopularity("12001", 4, 152);
            addPopularity("10146", 4, 152);
            addPopularity("02008", 4, 152);
            addPopularity("11012", 4, 150);
            addPopularity("141013", 4, 150);
            addPopularity("12010", 4, 148);
            addPopularity("03004", 4, 148);
            addPopularity("06136", 4, 148);
            addPopularity("142005", 4, 148);
            addPopularity("08089", 4, 148);
            addPopularity("01043", 4, 147);
            addPopularity("131016", 4, 146);
            addPopularity("04006", 4, 146);
            addPopularity("01012", 4, 146);
            addPopularity("04004", 4, 146);
            addPopularity("05015", 4, 145);
            addPopularity("144005", 4, 144);
            addPopularity("08058", 4, 143);
            addPopularity("12004", 4, 143);
            addPopularity("01054", 4, 143);
            addPopularity("16003", 4, 143);
            addPopularity("08140", 4, 142);
            addPopularity("08027", 4, 141);
            addPopularity("131009", 4, 141);
            addPopularity("145007", 4, 141);
            addPopularity("11014", 4, 140);
            addPopularity("145005", 4, 140);
            addPopularity("09003", 4, 138);
            addPopularity("04030", 4, 138);
            addPopularity("12008", 4, 135);
            addPopularity("04010", 4, 134);
            addPopularity("02102", 4, 133);
            addPopularity("10143", 4, 132);
            addPopularity("01022", 4, 132);
            addPopularity("02100", 4, 132);
            addPopularity("12002", 4, 132);
            addPopularity("08138", 4, 131);
            addPopularity("141009", 4, 130);
            addPopularity("06084", 4, 129);
            addPopularity("02010", 4, 129);
            addPopularity("16010", 4, 129);
            addPopularity("06114", 4, 128);
            addPopularity("06041", 4, 128);
            addPopularity("01017", 4, 127);
            addPopularity("01064", 4, 127);
            addPopularity("10116", 4, 126);
            addPopularity("144007", 4, 126);
            addPopularity("08086", 4, 125);
            addPopularity("12139", 4, 125);
            addPopularity("10091", 4, 124);
            addPopularity("01041", 4, 124);
            addPopularity("06087", 4, 124);
            addPopularity("04080", 4, 124);
            addPopularity("12060", 4, 123);
            addPopularity("01020", 4, 122);
            addPopularity("141015", 4, 122);
            addPopularity("10037", 4, 122);
            
            //3 Star Player Cards
            addPopularity("04053", 3, 120);
            addPopularity("06115", 3, 120);
            addPopularity("08090", 3, 119);
            addPopularity("06112", 3, 119);
            addPopularity("08004", 3, 118);
            addPopularity("01037", 3, 116);
            addPopularity("02059", 3, 116);
            addPopularity("08114", 3, 114);
            addPopularity("08008", 3, 114);
            addPopularity("08139", 3, 114);
            addPopularity("01047", 3, 114);
            addPopularity("06141", 3, 114);
            addPopularity("01032", 3, 113);
            addPopularity("141004", 3, 113);
            addPopularity("131013", 3, 113);
            addPopularity("10122", 3, 113);
            addPopularity("03013", 3, 112);
            addPopularity("12011", 3, 112);
            addPopularity("01001", 3, 112);
            addPopularity("02123", 3, 111);
            addPopularity("08120", 3, 111);
            addPopularity("10147", 3, 111);
            addPopularity("06135", 3, 109);
            addPopularity("10029", 3, 109);
            addPopularity("16004", 3, 109);
            addPopularity("132015", 3, 107);
            addPopularity("132006", 3, 107);
            addPopularity("142002", 3, 107);
            addPopularity("06083", 3, 107);
            addPopularity("10034", 3, 106);
            addPopularity("132016", 3, 106);
            addPopularity("06033", 3, 105);
            addPopularity("01036", 3, 105);
            addPopularity("01002", 3, 104);
            addPopularity("06034", 3, 102);
            addPopularity("11013", 3, 101);
            addPopularity("02097", 3, 101);
            addPopularity("01015", 3, 99);
            addPopularity("01004", 3, 99);
            addPopularity("06137", 3, 99);
            addPopularity("06089", 3, 99);
            addPopularity("10093", 3, 99);
            addPopularity("02117", 3, 98);
            addPopularity("10092", 3, 98);
            addPopularity("141002", 3, 97);
            addPopularity("12037", 3, 97);
            addPopularity("03006", 3, 96);
            addPopularity("143011", 3, 96);
            addPopularity("11003", 3, 95);
            addPopularity("10142", 3, 95);
            addPopularity("06110", 3, 95);
            addPopularity("08057", 3, 94);
            addPopularity("06109", 3, 94);
            addPopularity("145012", 3, 94);
            addPopularity("09010", 3, 93);
            addPopularity("10005", 3, 93);
            addPopularity("08010", 3, 93);
            addPopularity("04136", 3, 93);
            addPopularity("11001", 3, 92);
            addPopularity("09007", 3, 92);
            addPopularity("03002", 3, 91);
            addPopularity("144009", 3, 91);
            addPopularity("144006", 3, 91);
            addPopularity("02029", 3, 91);
            addPopularity("10057", 3, 90);
            addPopularity("02116", 3, 90);
            addPopularity("132008", 3, 90);
            addPopularity("145003", 3, 90);
            addPopularity("06060", 3, 90);
            addPopularity("04084", 3, 90);
            addPopularity("12116", 3, 90);
            addPopularity("02095", 3, 88);
            addPopularity("04034", 3, 88);
            addPopularity("06139", 3, 88);
            addPopularity("06088", 3, 87);
            addPopularity("02051", 3, 87);
            addPopularity("10062", 3, 85);
            addPopularity("06142", 3, 85);
            addPopularity("04130", 3, 84);
            addPopularity("01052", 3, 84);
            addPopularity("06058", 3, 84);
            addPopularity("143008", 3, 83);
            addPopularity("09005", 3, 81);
            addPopularity("06116", 3, 81);
            addPopularity("08028", 3, 80);
            addPopularity("04033", 3, 80);
            addPopularity("145006", 3, 79);
            addPopularity("07015", 3, 79);
            addPopularity("02032", 3, 78);
            addPopularity("10121", 3, 77);
            addPopularity("03010", 3, 77);
            addPopularity("02096", 3, 77);
            addPopularity("09006", 3, 77);
            addPopularity("12087", 3, 77);
            addPopularity("10035", 3, 77);
            addPopularity("06063", 3, 77);
            addPopularity("05001", 3, 76);
            addPopularity("08084", 3, 76);
            addPopularity("02122", 3, 76);
            addPopularity("10032", 3, 76);
            addPopularity("132012", 3, 75);
            addPopularity("02025", 3, 75);
            addPopularity("141003", 3, 75);
            addPopularity("02080", 3, 75);
            addPopularity("11009", 3, 74);
            addPopularity("07010", 3, 74);
            addPopularity("12058", 3, 74);
            addPopularity("12144", 3, 74);
            addPopularity("17008", 3, 74);
            addPopularity("141010", 3, 73);
            addPopularity("01006", 3, 72);
            addPopularity("144003", 3, 72);
            addPopularity("07003", 3, 72);
            addPopularity("08116", 3, 72);
            addPopularity("10055", 3, 71);
            
            //2 Star Player Cards
            addPopularity("10084", 2, 70);
            addPopularity("10086", 2, 70);
            addPopularity("08056", 2, 69);
            addPopularity("09001", 2, 69);
            addPopularity("08029", 2, 69);
            addPopularity("06064", 2, 68);
            addPopularity("12089", 2, 67);
            addPopularity("04109", 2, 67);
            addPopularity("02052", 2, 66);
            addPopularity("02007", 2, 66);
            addPopularity("02125", 2, 66);
            addPopularity("08006", 2, 65);
            addPopularity("01010", 2, 65);
            addPopularity("10124", 2, 65);
            addPopularity("17006", 2, 65);
            addPopularity("06035", 2, 64);
            addPopularity("05004", 2, 64);
            addPopularity("144004", 2, 64);
            addPopularity("02009", 2, 64);
            addPopularity("04029", 2, 64);
            addPopularity("10118", 2, 64);
            addPopularity("06001", 2, 63);
            addPopularity("06059", 2, 63);
            addPopularity("10009", 2, 62);
            addPopularity("08059", 2, 62);
            addPopularity("16008", 2, 62);
            addPopularity("141012", 2, 61);
            addPopularity("01008", 2, 61);
            addPopularity("17004", 2, 61);
            addPopularity("08060", 2, 60);
            addPopularity("03012", 2, 60);
            addPopularity("131005", 2, 60);
            addPopularity("141007", 2, 60);
            addPopularity("141011", 2, 60);
            addPopularity("131002", 2, 59);
            addPopularity("131004", 2, 59);
            addPopularity("10144", 2, 59);
            addPopularity("02078", 2, 59);
            addPopularity("07009", 2, 58);
            addPopularity("01033", 2, 58);
            addPopularity("12090", 2, 57);
            addPopularity("143002", 2, 57);
            addPopularity("04056", 2, 56);
            addPopularity("01056", 2, 56);
            addPopularity("12138", 2, 56);
            addPopularity("10030", 2, 55);
            addPopularity("12035", 2, 55);
            addPopularity("16001", 2, 55);
            addPopularity("16002", 2, 55);
            addPopularity("04105", 2, 54);
            addPopularity("10006", 2, 54);
            addPopularity("02050", 2, 54);
            addPopularity("10007", 2, 54);
            addPopularity("09011", 2, 54);
            addPopularity("12057", 2, 54);
            addPopularity("17005", 2, 54);
            addPopularity("08001", 2, 53);
            addPopularity("01025", 2, 53);
            addPopularity("10001", 2, 53);
            addPopularity("131012", 2, 53);
            addPopularity("132007", 2, 52);
            addPopularity("06090", 2, 52);
            addPopularity("16005", 2, 52);
            addPopularity("131003", 2, 51);
            addPopularity("04104", 2, 51);
            addPopularity("144008", 2, 51);
            addPopularity("12146", 2, 51);
            addPopularity("12141", 2, 51);
            addPopularity("06134", 2, 50);
            addPopularity("05010", 2, 50);
            addPopularity("12031", 2, 50);
            addPopularity("07001", 2, 50);
            addPopularity("08030", 2, 49);
            addPopularity("02031", 2, 49);
            addPopularity("06007", 2, 49);
            addPopularity("10115", 2, 48);
            addPopularity("10002", 2, 48);
            addPopularity("132002", 2, 48);
            addPopularity("06032", 2, 48);
            addPopularity("143012", 2, 48);
            addPopularity("08005", 2, 47);
            addPopularity("06040", 2, 47);
            addPopularity("04085", 2, 47);
            addPopularity("131018", 2, 47);
            addPopularity("132009", 2, 47);
            addPopularity("11002", 2, 46);
            addPopularity("08026", 2, 46);
            addPopularity("01067", 2, 46);
            addPopularity("08031", 2, 46);
            addPopularity("144012", 2, 46);
            addPopularity("12113", 2, 46);
            addPopularity("12145", 2, 46);
            addPopularity("10141", 2, 45);
            addPopularity("132014", 2, 45);
            addPopularity("04001", 2, 44);
            addPopularity("04028", 2, 44);
            addPopularity("145011", 2, 44);
            addPopularity("07014", 2, 44);
            addPopularity("01019", 2, 44);
            addPopularity("02027", 2, 43);
            addPopularity("01021", 2, 43);
            addPopularity("02124", 2, 43);
            addPopularity("02076", 2, 43);
            addPopularity("132010", 2, 43);
            addPopularity("12007", 2, 42);
            addPopularity("01003", 2, 42);
            addPopularity("04032", 2, 42);
            addPopularity("12086", 2, 40);
            addPopularity("04076", 2, 40);
            addPopularity("10119", 2, 40);
            addPopularity("12142", 2, 40);
            addPopularity("16013", 2, 40);
            
            //1 Star Player Cards
            addPopularity("08145", 1);
            addPopularity("06061", 1);
            addPopularity("09013", 1);
            addPopularity("02058", 1);
            addPopularity("144002", 1);
            addPopularity("12110", 1);
            addPopularity("05002", 1);
            addPopularity("10085", 1);
            addPopularity("12063", 1);
            addPopularity("141008", 1);
            addPopularity("144011", 1);
            addPopularity("08115", 1);
            addPopularity("01009", 1);
            addPopularity("04002", 1);
            addPopularity("07005", 1);
            addPopularity("12082", 1);
            addPopularity("10028", 1);
            addPopularity("06107", 1);
            addPopularity("08137", 1);
            addPopularity("12061", 1);
            addPopularity("01038", 1);
            addPopularity("01011", 1);
            addPopularity("02054", 1);
            addPopularity("09009", 1);
            addPopularity("07002", 1);
            addPopularity("09008", 1);
            addPopularity("11011", 1);
            addPopularity("09015", 1);
            addPopularity("10123", 1);
            addPopularity("09002", 1);
            addPopularity("08025", 1);
            addPopularity("06082", 1);
            addPopularity("11005", 1);
            addPopularity("08061", 1);
            addPopularity("06111", 1);
            addPopularity("12005", 1);
            addPopularity("143003", 1);
            addPopularity("11006", 1);
            addPopularity("08091", 1);
            addPopularity("10088", 1);
            addPopularity("06081", 1);
            addPopularity("06138", 1);
            addPopularity("10087", 1);
            addPopularity("02099", 1);
            addPopularity("04005", 1);
            addPopularity("131019", 1);
            addPopularity("12030", 1);
            addPopularity("07013", 1);
            addPopularity("02001", 1);
            addPopularity("12036", 1);
            addPopularity("12065", 1);
            addPopularity("17010", 1);
            addPopularity("04081", 1);
            addPopularity("01071", 1);
            addPopularity("132004", 1);
            addPopularity("12003", 1);
            addPopularity("11004", 1);
            addPopularity("06113", 1);
            addPopularity("06036", 1);
            addPopularity("132003", 1);
            addPopularity("02073", 1);
            addPopularity("04078", 1);
            addPopularity("12109", 1);
            addPopularity("04009", 1);
            addPopularity("02072", 1);
            addPopularity("02118", 1);
            addPopularity("05016", 1);
            addPopularity("03001", 1);
            addPopularity("06140", 1);
            addPopularity("16012", 1);
            addPopularity("17007", 1);
            addPopularity("04103", 1);
            addPopularity("12118", 1);
            addPopularity("17002", 1);
            addPopularity("04082", 1);
            addPopularity("132005", 1);
            addPopularity("04007", 1);
            addPopularity("10056", 1);
            addPopularity("05005", 1);
            addPopularity("17003", 1);
            addPopularity("10008", 1);
            addPopularity("04008", 1);
            addPopularity("132011", 1);
            addPopularity("12112", 1);
            addPopularity("10063", 1);
            addPopularity("11007", 1);
            addPopularity("04132", 1);
            addPopularity("08093", 1);
            addPopularity("08062", 1);
            addPopularity("06057", 1);
            addPopularity("05011", 1);
            addPopularity("141005", 1);
            addPopularity("12033", 1);
            addPopularity("12114", 1);
            addPopularity("08034", 1);
            addPopularity("10148", 1);
            addPopularity("01068", 1);
            addPopularity("131017", 1);
            addPopularity("08085", 1);
            addPopularity("12119", 1);
            addPopularity("05012", 1);
            addPopularity("04035", 1);
            addPopularity("16006", 1);
            addPopularity("10054", 1);
            addPopularity("08007", 1);
            addPopularity("10036", 1);
            addPopularity("08032", 1);
            addPopularity("08003", 1);
            addPopularity("02028", 1);
            addPopularity("17001", 1);
            addPopularity("17009", 1);
            addPopularity("142010", 1);
            addPopularity("12088", 1);
            addPopularity("10003", 1);
            addPopularity("12143", 1);
            addPopularity("06056", 1);
            addPopularity("08142", 1);
            addPopularity("10117", 1);
            addPopularity("02101", 1);
            addPopularity("12111", 1);
            addPopularity("06065", 1);
            addPopularity("07004", 1);
            addPopularity("12038", 1);
            addPopularity("06062", 1);
            addPopularity("143013", 1);
            addPopularity("03005", 1);
            addPopularity("17029", 1);
            addPopularity("06038", 1);
            addPopularity("04054", 1);
            addPopularity("12140", 1);
            addPopularity("17030", 1);
            addPopularity("17032", 1);
            addPopularity("08033", 1);
            addPopularity("02074", 1);
            addPopularity("08143", 1);
            addPopularity("132013", 1);
            addPopularity("145013", 1);
            addPopularity("17028", 1);
            addPopularity("131022", 1);
            addPopularity("11008", 1);
            addPopularity("06039", 1);
            addPopularity("12115", 1);
            addPopularity("131020", 1);
            addPopularity("10058", 1);
            addPopularity("17037", 1);
            addPopularity("17033", 1);
            addPopularity("17031", 1);
            addPopularity("04060", 1);
            addPopularity("132021", 1);
            addPopularity("144013", 1);
            addPopularity("16009", 1);
            addPopularity("17036", 1);
            addPopularity("144001", 1);
            addPopularity("04037", 1);
            addPopularity("132020", 1);
            addPopularity("132022", 1);
            addPopularity("132023", 1);
            addPopularity("132024", 1);

            /*
            
            */
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
    }
}