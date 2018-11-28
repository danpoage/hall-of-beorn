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
            const ushort votes_5 = 600;
            const ushort votes_4 = 500;
            const ushort votes_3 = 300;
            const ushort votes_2 = 200;

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
            //5 Star Heroes
            addHeroPopularity("01007", 673);
            addHeroPopularity("04101", 572);
            addHeroPopularity("10140", 514);
            addHeroPopularity("145002", 433);
            addHeroPopularity("04128", 426);
            addHeroPopularity("01005", 404);
            addHeroPopularity("08112", 389);
            addHeroPopularity("01002", 385);
            addHeroPopularity("12001", 377);
            addHeroPopularity("01001", 347);
            addHeroPopularity("141004", 336);
            addHeroPopularity("01012", 335);
            addHeroPopularity("141002", 332);
            addHeroPopularity("01004", 304);
            addHeroPopularity("04053", 292);
            
            //4 Star Heroes
            addHeroPopularity("142002", 271);
            addHeroPopularity("02116", 264);
            addHeroPopularity("03002", 258);
            addHeroPopularity("02025", 244);
            addHeroPopularity("01010", 239);
            addHeroPopularity("01006", 233);
            addHeroPopularity("05001", 224);
            addHeroPopularity("11001", 217);
            addHeroPopularity("08084", 214);
            addHeroPopularity("02095", 205);
            addHeroPopularity("10084", 196);
            addHeroPopularity("141003", 192);
            addHeroPopularity("01008", 184);
            addHeroPopularity("145003", 180);
            addHeroPopularity("08056", 179);
            addHeroPopularity("10001", 179);
            addHeroPopularity("09001", 173);
            addHeroPopularity("144003", 172);
            
            //3 Star Heroes
            addHeroPopularity("143002", 162);
            addHeroPopularity("01003", 161);
            addHeroPopularity("10115", 144);
            addHeroPopularity("131005", 144);
            addHeroPopularity("08001", 142);
            addHeroPopularity("01009", 142);
            addHeroPopularity("131002", 141);
            addHeroPopularity("17028", 134);
            addHeroPopularity("06001", 130);
            addHeroPopularity("131004", 129);
            addHeroPopularity("16002", 124);
            addHeroPopularity("07001", 123);
            addHeroPopularity("12138", 123);
            addHeroPopularity("131003", 121);
            addHeroPopularity("12057", 119);
            addHeroPopularity("02050", 118);
            addHeroPopularity("06032", 117);
            addHeroPopularity("02001", 116);
            addHeroPopularity("05002", 114);
            addHeroPopularity("06134", 114);
            addHeroPopularity("16001", 114);
            addHeroPopularity("01011", 113);

            //2 Star Heroes
            addHeroPopularity("04028", 110);
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
            addHeroPopularity("11002", 87);
            addHeroPopularity("10028", 87);
            addHeroPopularity("143003", 85);
            addHeroPopularity("03001", 83);
            addHeroPopularity("06081", 77);
            addHeroPopularity("12082", 76);

            //1 Star Heroes
            addHeroPopularity("17109", 68);
            addHeroPopularity("132004", 67);
            addHeroPopularity("132003", 62);
            addHeroPopularity("12030", 61);
            addHeroPopularity("17001", 55);
            addHeroPopularity("132005", 49);
            addHeroPopularity("12109", 46);
            addHeroPopularity("02072", 44);
            addHeroPopularity("17081", 40);
            addHeroPopularity("146004", 40);
            addHeroPopularity("10054", 34);
            addHeroPopularity("141005", 33);
            addHeroPopularity("146003", 32);
            addHeroPopularity("06056", 26);
            addHeroPopularity("17135", 15);
            addHeroPopularity("144001", 1);
            addHeroPopularity("146001", 1);

            //Player Cards
            addCardPopularity("01073", 6430);
            addCardPopularity("01050", 6393);
            addCardPopularity("01026", 5025);
            addCardPopularity("01023", 4270);
            addCardPopularity("01057", 4225);
            addCardPopularity("01034", 4022);
            addCardPopularity("04108", 3698);
            addCardPopularity("04059", 3185);
            addCardPopularity("04083", 2890);
            addCardPopularity("01046", 2876);
            addCardPopularity("01048", 2791);
            addCardPopularity("04107", 2583);
            addCardPopularity("01045", 2402);
            addCardPopularity("10145", 1848);
            addCardPopularity("06005", 1820);
            addCardPopularity("01016", 1815);
            addCardPopularity("04058", 1799);
            addCardPopularity("01014", 1785);
            addCardPopularity("02056", 1711);
            addCardPopularity("06006", 1697);
            addCardPopularity("05018", 1667);
            addCardPopularity("01029", 1576);
            addCardPopularity("02033", 1524);
            addCardPopularity("01059", 1491);
            addCardPopularity("131015", 1486);
            addCardPopularity("08117", 1484);
            addCardPopularity("02026", 1479);
            addCardPopularity("05007", 1462);
            addCardPopularity("04062", 1445);
            addCardPopularity("01062", 1411);
            addCardPopularity("01027", 1377);
            addCardPopularity("01053", 1369);
            addCardPopularity("131014", 1328);
            addCardPopularity("01070", 1320);
            addCardPopularity("04134", 1302);
            addCardPopularity("01060", 1295);
            addCardPopularity("07012", 1293);
            addCardPopularity("01069", 1274);
            addCardPopularity("02121", 1245);
            addCardPopularity("02098", 1231);
            addCardPopularity("01061", 1226);
            addCardPopularity("141014", 1215);
            addCardPopularity("01028", 1204);
            addCardPopularity("01035", 1163);
            addCardPopularity("08146", 1121);
            addCardPopularity("05003", 1111);
            addCardPopularity("02004", 1060);
            addCardPopularity("01024", 1040);
            addCardPopularity("04031", 1023);
            addCardPopularity("01013", 1009);
            addCardPopularity("01040", 1007);
            addCardPopularity("03009", 998);
            addCardPopularity("12009", 997);
            addCardPopularity("10004", 990);
            addCardPopularity("02103", 985);
            addCardPopularity("02002", 982);
            addCardPopularity("04106", 978);
            addCardPopularity("12059", 974);
            addCardPopularity("01049", 959);
            addCardPopularity("04129", 953);
            addCardPopularity("01058", 950);
            addCardPopularity("01039", 934);
            addCardPopularity("06010", 922);
            addCardPopularity("02055", 901);
            addCardPopularity("01051", 899);
            addCardPopularity("07007", 898);
            addCardPopularity("143006", 890);
            addCardPopularity("04110", 877);
            addCardPopularity("01042", 859);
            addCardPopularity("09004", 846);
            addCardPopularity("01066", 845);
            addCardPopularity("143005", 832);
            addCardPopularity("05017", 829);
            addCardPopularity("01044", 819);
            addCardPopularity("01072", 816);
            addCardPopularity("08121", 806);
            addCardPopularity("03011", 800);
            addCardPopularity("08119", 793);
            addCardPopularity("12006", 790);
            addCardPopularity("04137", 789);
            addCardPopularity("09012", 785);
            addCardPopularity("131011", 770);
            addCardPopularity("10061", 760);
            addCardPopularity("07008", 753);
            addCardPopularity("02119", 747);
            addCardPopularity("08087", 743);
            addCardPopularity("02034", 738);
            addCardPopularity("08064", 732);
            addCardPopularity("04055", 724);
            addCardPopularity("02077", 713);
            addCardPopularity("02081", 713);
            addCardPopularity("02003", 712);
            addCardPopularity("10031", 702);
            addCardPopularity("06004", 699);
            addCardPopularity("06008", 695);
            addCardPopularity("11015", 687);
            addCardPopularity("02079", 677);
            addCardPopularity("01007", 673);
            addCardPopularity("01031", 645);
            addCardPopularity("02006", 643);
            addCardPopularity("142008", 631);
            addCardPopularity("142009", 631);
            addCardPopularity("12032", 628);
            addCardPopularity("142003", 622);
            addCardPopularity("07006", 619);
            addCardPopularity("01055", 613);
            addCardPopularity("10090", 612);
            addCardPopularity("06143", 610);
            addCardPopularity("131010", 610);
            addCardPopularity("12085", 605);
            addCardPopularity("01063", 600);
            addCardPopularity("132018", 594);
            addCardPopularity("145008", 585);
            addCardPopularity("01043", 583);
            addCardPopularity("04131", 578);
            addCardPopularity("08141", 578);
            addCardPopularity("04101", 572);
            addCardPopularity("141006", 568);
            addCardPopularity("05008", 565);
            addCardPopularity("06009", 560);
            addCardPopularity("08002", 558);
            addCardPopularity("10010", 551);
            addCardPopularity("07011", 547);
            addCardPopularity("01065", 547);
            addCardPopularity("08063", 536);
            addCardPopularity("145004", 536);
            addCardPopularity("141013", 533);
            addCardPopularity("06037", 531);
            addCardPopularity("05009", 526);
            addCardPopularity("144010", 524);
            addCardPopularity("03008", 519);
            addCardPopularity("141016", 519);
            addCardPopularity("01018", 518);
            addCardPopularity("142006", 517);
            addCardPopularity("10140", 514);
            addCardPopularity("12091", 511);
            addCardPopularity("06002", 509);
            addCardPopularity("09014", 508);
            addCardPopularity("145010", 508);
            addCardPopularity("03007", 507);
            addCardPopularity("12034", 506);
            addCardPopularity("02010", 506);
            addCardPopularity("02008", 506);
            addCardPopularity("02030", 500);
            addCardPopularity("03003", 495);
            addCardPopularity("06108", 495);
            addCardPopularity("05006", 494);
            addCardPopularity("04003", 493);
            addCardPopularity("12117", 491);
            addCardPopularity("12084", 485);
            addCardPopularity("04006", 484);
            addCardPopularity("131006", 482);
            addCardPopularity("02104", 482);
            addCardPopularity("08088", 481);
            addCardPopularity("05013", 478);
            addCardPopularity("12064", 470);
            addCardPopularity("08118", 469);
            addCardPopularity("143010", 467);
            addCardPopularity("143004", 461);
            addCardPopularity("06003", 461);
            addCardPopularity("02005", 460);
            addCardPopularity("02057", 459);
            addCardPopularity("12062", 458);
            addCardPopularity("01041", 457);
            addCardPopularity("131008", 457);
            addCardPopularity("08113", 452);
            addCardPopularity("143014", 451);
            addCardPopularity("141015", 449);
            addCardPopularity("02120", 448);
            addCardPopularity("10033", 446);
            addCardPopularity("08092", 446);
            addCardPopularity("03004", 445);
            addCardPopularity("04077", 445);
            addCardPopularity("06085", 444);
            addCardPopularity("08089", 444);
            addCardPopularity("131016", 442);
            addCardPopularity("143009", 442);
            addCardPopularity("02075", 442);
            addCardPopularity("143007", 439);
            addCardPopularity("04036", 435);
            addCardPopularity("04079", 435);
            addCardPopularity("145002", 433);
            addCardPopularity("132017", 427);
            addCardPopularity("04128", 426);
            addCardPopularity("01020", 425);
            addCardPopularity("16007", 423);
            addCardPopularity("01030", 421);
            addCardPopularity("08009", 418);
            addCardPopularity("04057", 417);
            addCardPopularity("16003", 415);
            addCardPopularity("04133", 411);
            addCardPopularity("04061", 410);
            addCardPopularity("131007", 410);
            addCardPopularity("142004", 410);
            addCardPopularity("01022", 409);
            addCardPopularity("02100", 409);
            addCardPopularity("04135", 408);
            addCardPopularity("10059", 407);
            addCardPopularity("08008", 405);
            addCardPopularity("01005", 404);
            addCardPopularity("02053", 400);
            addCardPopularity("04102", 400);
            addCardPopularity("06086", 399);
            addCardPopularity("142007", 398);
            addCardPopularity("03013", 396);
            addCardPopularity("01017", 393);
            addCardPopularity("10089", 393);
            addCardPopularity("141009", 393);
            addCardPopularity("11012", 390);
            addCardPopularity("08112", 389);
            addCardPopularity("10149", 389);
            addCardPopularity("01047", 388);
            addCardPopularity("12010", 387);
            addCardPopularity("01002", 385);
            addCardPopularity("01032", 382);
            addCardPopularity("08140", 381);
            addCardPopularity("04080", 381);
            addCardPopularity("143011", 381);
            addCardPopularity("01037", 379);
            addCardPopularity("12001", 377);
            addCardPopularity("06136", 371);
            addCardPopularity("16011", 371);
            addCardPopularity("144005", 370);
            addCardPopularity("17006", 370);
            addCardPopularity("05014", 369);
            addCardPopularity("17008", 369);
            addCardPopularity("08027", 366);
            addCardPopularity("01015", 366);
            addCardPopularity("10037", 363);
            addCardPopularity("10060", 358);
            addCardPopularity("08058", 356);
            addCardPopularity("11010", 353);
            addCardPopularity("01054", 351);
            addCardPopularity("01064", 351);
            addCardPopularity("142005", 348);
            addCardPopularity("01001", 347);
            addCardPopularity("02102", 345);
            addCardPopularity("12083", 345);
            addCardPopularity("04030", 343);
            addCardPopularity("08065", 341);
            addCardPopularity("10034", 340);
            addCardPopularity("12008", 338);
            addCardPopularity("12066", 336);
            addCardPopularity("141004", 336);
            addCardPopularity("01012", 335);
            addCardPopularity("12139", 335);
            addCardPopularity("10116", 332);
            addCardPopularity("131009", 332);
            addCardPopularity("141002", 332);
            addCardPopularity("144007", 332);
            addCardPopularity("10006", 329);
            addCardPopularity("08004", 326);
            addCardPopularity("06084", 323);
            addCardPopularity("145009", 322);
            addCardPopularity("04010", 322);
            addCardPopularity("11014", 321);
            addCardPopularity("10120", 318);
            addCardPopularity("131013", 318);
            addCardPopularity("10146", 316);
            addCardPopularity("05015", 314);
            addCardPopularity("01036", 313);
            addCardPopularity("08138", 312);
            addCardPopularity("04004", 312);
            addCardPopularity("02059", 311);
            addCardPopularity("08120", 309);
            addCardPopularity("09003", 309);
            addCardPopularity("12116", 307);
            addCardPopularity("12060", 306);
            addCardPopularity("01004", 304);
            addCardPopularity("06137", 304);
            addCardPopularity("10122", 302);
            addCardPopularity("145005", 300);
            addCardPopularity("06087", 293);
            addCardPopularity("04053", 292);
            addCardPopularity("144006", 292);
            addCardPopularity("16005", 291);
            addCardPopularity("12002", 290);
            addCardPopularity("06060", 289);
            addCardPopularity("10143", 285);
            addCardPopularity("17032", 285);
            addCardPopularity("16004", 284);
            addCardPopularity("12004", 282);
            addCardPopularity("06041", 281);
            addCardPopularity("06115", 278);
            addCardPopularity("02051", 276);
            addCardPopularity("04084", 276);
            addCardPopularity("06114", 275);
            addCardPopularity("145007", 274);
            addCardPopularity("10092", 274);
            addCardPopularity("08057", 272);
            addCardPopularity("06112", 272);
            addCardPopularity("142002", 271);
            addCardPopularity("10091", 269);
            addCardPopularity("06135", 269);
            addCardPopularity("08086", 268);
            addCardPopularity("17004", 268);
            addCardPopularity("132016", 267);
            addCardPopularity("02123", 265);
            addCardPopularity("12037", 265);
            addCardPopularity("02116", 264);
            addCardPopularity("10029", 263);
            addCardPopularity("02009", 262);
            addCardPopularity("06141", 261);
            addCardPopularity("132006", 260);
            addCardPopularity("10142", 259);
            addCardPopularity("10032", 259);
            addCardPopularity("03002", 258);
            addCardPopularity("10062", 258);
            addCardPopularity("08114", 257);
            addCardPopularity("17005", 257);
            addCardPopularity("16010", 256);
            addCardPopularity("09007", 254);
            addCardPopularity("132015", 246);
            addCardPopularity("10005", 244);
            addCardPopularity("02025", 244);
            addCardPopularity("141010", 243);
            addCardPopularity("01052", 243);
            addCardPopularity("08139", 240);
            addCardPopularity("01010", 239);
            addCardPopularity("02117", 237);
            addCardPopularity("07010", 236);
            addCardPopularity("06034", 236);
            addCardPopularity("10147", 235);
            addCardPopularity("16008", 235);
            addCardPopularity("08090", 234);
            addCardPopularity("01006", 233);
            addCardPopularity("10124", 233);
            addCardPopularity("12058", 233);
            addCardPopularity("144008", 233);
            addCardPopularity("03006", 232);
            addCardPopularity("08026", 231);
            addCardPopularity("09010", 229);
            addCardPopularity("02096", 228);
            addCardPopularity("02032", 227);
            addCardPopularity("10093", 227);
            addCardPopularity("02122", 227);
            addCardPopularity("06033", 226);
            addCardPopularity("06089", 225);
            addCardPopularity("02007", 225);
            addCardPopularity("146005", 225);
            addCardPopularity("05001", 224);
            addCardPopularity("10118", 224);
            addCardPopularity("132008", 222);
            addCardPopularity("04034", 220);
            addCardPopularity("10035", 220);
            addCardPopularity("17060", 220);
            addCardPopularity("04136", 218);
            addCardPopularity("06110", 218);
            addCardPopularity("11001", 217);
            addCardPopularity("07015", 216);
            addCardPopularity("02078", 215);
            addCardPopularity("08084", 214);
            addCardPopularity("06139", 211);
            addCardPopularity("03010", 210);
            addCardPopularity("02029", 210);
            addCardPopularity("09005", 208);
            addCardPopularity("04130", 206);
            addCardPopularity("06109", 206);
            addCardPopularity("144009", 206);
            addCardPopularity("02095", 205);
            addCardPopularity("17030", 205);
            addCardPopularity("12144", 204);
            addCardPopularity("17033", 204);
            addCardPopularity("05004", 202);
            addCardPopularity("06142", 202);
            addCardPopularity("02080", 202);
            addCardPopularity("12087", 200);
            addCardPopularity("143008", 200);
            addCardPopularity("08028", 199);
            addCardPopularity("145012", 199);
            addCardPopularity("04033", 199);
            addCardPopularity("141007", 198);
            addCardPopularity("10084", 196);
            addCardPopularity("03012", 196);
            addCardPopularity("06083", 196);
            addCardPopularity("17037", 194);
            addCardPopularity("141003", 192);
            addCardPopularity("08029", 191);
            addCardPopularity("10121", 190);
            addCardPopularity("02097", 190);
            addCardPopularity("141012", 189);
            addCardPopularity("12011", 188);
            addCardPopularity("01008", 184);
            addCardPopularity("10007", 183);
            addCardPopularity("08010", 183);
            addCardPopularity("11003", 183);
            addCardPopularity("11013", 182);
            addCardPopularity("04104", 182);
            addCardPopularity("145003", 180);
            addCardPopularity("145006", 180);
            addCardPopularity("08056", 179);
            addCardPopularity("01025", 179);
            addCardPopularity("10001", 179);
            addCardPopularity("11009", 175);
            addCardPopularity("06064", 175);
            addCardPopularity("141008", 174);
            addCardPopularity("06059", 174);
            addCardPopularity("09001", 173);
            addCardPopularity("144003", 172);
            addCardPopularity("06088", 169);
            addCardPopularity("06116", 168);
            addCardPopularity("02124", 168);
            addCardPopularity("04056", 167);
            addCardPopularity("144004", 167);
            addCardPopularity("08059", 165);
            addCardPopularity("10057", 164);
            addCardPopularity("10009", 164);
            addCardPopularity("12089", 164);
            addCardPopularity("143002", 162);
            addCardPopularity("01003", 161);
            addCardPopularity("12145", 161);
            addCardPopularity("04109", 160);
            addCardPopularity("17002", 160);
            addCardPopularity("10086", 158);
            addCardPopularity("04032", 158);
            addCardPopularity("08006", 157);
            addCardPopularity("07003", 157);
            addCardPopularity("131018", 156);
            addCardPopularity("141011", 156);
            addCardPopularity("132012", 155);
            addCardPopularity("01056", 155);
            addCardPopularity("07009", 154);
            addCardPopularity("12141", 153);
            addCardPopularity("02125", 152);
            addCardPopularity("07014", 151);
            addCardPopularity("10055", 151);
            addCardPopularity("16013", 151);
            addCardPopularity("12035", 150);
            addCardPopularity("09006", 150);
            addCardPopularity("06058", 150);
            addCardPopularity("04085", 149);
            addCardPopularity("06063", 149);
            addCardPopularity("08005", 147);
            addCardPopularity("06007", 147);
            addCardPopularity("01019", 146);
            addCardPopularity("16006", 145);
            addCardPopularity("17009", 145);
            addCardPopularity("10115", 144);
            addCardPopularity("131005", 144);
            addCardPopularity("08001", 142);
            addCardPopularity("01009", 142);
            addCardPopularity("12142", 142);
            addCardPopularity("17029", 142);
            addCardPopularity("17088", 142);
            addCardPopularity("131002", 141);
            addCardPopularity("06035", 141);
            addCardPopularity("02052", 141);
            addCardPopularity("12113", 140);
            addCardPopularity("146011", 140);
            addCardPopularity("09008", 139);
            addCardPopularity("146012", 138);
            addCardPopularity("131012", 137);
            addCardPopularity("09011", 136);
            addCardPopularity("10144", 136);
            addCardPopularity("01033", 136);
            addCardPopularity("01021", 134);
            addCardPopularity("17028", 134);
            addCardPopularity("10030", 132);
            addCardPopularity("04105", 130);
            addCardPopularity("06001", 130);
            addCardPopularity("143012", 130);
            addCardPopularity("131004", 129);
            addCardPopularity("08116", 129);
            addCardPopularity("132007", 128);
            addCardPopularity("132014", 126);
            addCardPopularity("17010", 125);
            addCardPopularity("16002", 124);
            addCardPopularity("10002", 123);
            addCardPopularity("08030", 123);
            addCardPopularity("06040", 123);
            addCardPopularity("07001", 123);
            addCardPopularity("12110", 123);
            addCardPopularity("12138", 123);
            addCardPopularity("12090", 122);
            addCardPopularity("144011", 122);
            addCardPopularity("131003", 121);
            addCardPopularity("08060", 119);
            addCardPopularity("12057", 119);
            addCardPopularity("02031", 119);
            addCardPopularity("02050", 118);
            addCardPopularity("06032", 117);
            addCardPopularity("04078", 117);
            addCardPopularity("146008", 117);
            addCardPopularity("06061", 116);
            addCardPopularity("04029", 116);
            addCardPopularity("02001", 116);
            addCardPopularity("10087", 116);
            addCardPopularity("17061", 115);
            addCardPopularity("146007", 115);
            addCardPopularity("05002", 114);
            addCardPopularity("06134", 114);
            addCardPopularity("132009", 114);
            addCardPopularity("16001", 114);
            addCardPopularity("01011", 113);
            addCardPopularity("08031", 112);
            addCardPopularity("17058", 112);
            addCardPopularity("04028", 110);
            addCardPopularity("07005", 110);
            addCardPopularity("132010", 110);
            addCardPopularity("146013", 110);
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
            addCardPopularity("08115", 99);
            addCardPopularity("12086", 98);
            addCardPopularity("132002", 97);
            addCardPopularity("145011", 97);
            addCardPopularity("07002", 97);
            addCardPopularity("144012", 96);
            addCardPopularity("16012", 96);
            addCardPopularity("11011", 95);
            addCardPopularity("17055", 95);
            addCardPopularity("09002", 94);
            addCardPopularity("12031", 94);
            addCardPopularity("10088", 94);
            addCardPopularity("146006", 94);
            addCardPopularity("09009", 93);
            addCardPopularity("17112", 93);
            addCardPopularity("04082", 92);
            addCardPopularity("144002", 92);
            addCardPopularity("06107", 91);
            addCardPopularity("17007", 90);
            addCardPopularity("17062", 90);
            addCardPopularity("02076", 89);
            addCardPopularity("05010", 88);
            addCardPopularity("12036", 88);
            addCardPopularity("11002", 87);
            addCardPopularity("09013", 87);
            addCardPopularity("10028", 87);
            addCardPopularity("08034", 87);
            addCardPopularity("17084", 87);
            addCardPopularity("12146", 86);
            addCardPopularity("143003", 85);
            addCardPopularity("04009", 85);
            addCardPopularity("07013", 84);
            addCardPopularity("03001", 83);
            addCardPopularity("12061", 83);
            addCardPopularity("11006", 83);
            addCardPopularity("10085", 82);
            addCardPopularity("02118", 82);
            addCardPopularity("17115", 82);
            addCardPopularity("08145", 80);
            addCardPopularity("06140", 80);
            addCardPopularity("131017", 79);
            addCardPopularity("17114", 79);
            addCardPopularity("17143", 79);
            addCardPopularity("06081", 77);
            addCardPopularity("12112", 77);
            addCardPopularity("12082", 76);
            addCardPopularity("12003", 75);
            addCardPopularity("06090", 75);
            addCardPopularity("05016", 74);
            addCardPopularity("06138", 73);
            addCardPopularity("06082", 73);
            addCardPopularity("12033", 72);
            addCardPopularity("17118", 72);
            addCardPopularity("04103", 71);
            addCardPopularity("12065", 71);
            addCardPopularity("06113", 70);
            addCardPopularity("04081", 69);
            addCardPopularity("17109", 68);
            addCardPopularity("12063", 67);
            addCardPopularity("132004", 67);
            addCardPopularity("11004", 66);
            addCardPopularity("06065", 66);
            addCardPopularity("17035", 65);
            addCardPopularity("02054", 64);
            addCardPopularity("17056", 64);
            addCardPopularity("06036", 63);
            addCardPopularity("12143", 63);
            addCardPopularity("132003", 62);
            addCardPopularity("08061", 62);
            addCardPopularity("02073", 62);
            addCardPopularity("12030", 61);
            addCardPopularity("04035", 61);
            addCardPopularity("08062", 61);
            addCardPopularity("17089", 60);
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
            addCardPopularity("10063", 51);
            addCardPopularity("17031", 51);
            addCardPopularity("132011", 50);
            addCardPopularity("132005", 49);
            addCardPopularity("04007", 49);
            addCardPopularity("05005", 49);
            addCardPopularity("02101", 48);
            addCardPopularity("05012", 48);
            addCardPopularity("08003", 48);
            addCardPopularity("17085", 48);
            addCardPopularity("04132", 47);
            addCardPopularity("12111", 47);
            addCardPopularity("131019", 46);
            addCardPopularity("12109", 46);
            addCardPopularity("10123", 46);
            addCardPopularity("17064", 46);
            addCardPopularity("12088", 45);
            addCardPopularity("04008", 44);
            addCardPopularity("02072", 44);
            addCardPopularity("10036", 42);
            addCardPopularity("10148", 42);
            addCardPopularity("11007", 40);
            addCardPopularity("07004", 40);
            addCardPopularity("17081", 40);
            addCardPopularity("146004", 40);
            addCardPopularity("10056", 37);
            addCardPopularity("08032", 37);
            addCardPopularity("06039", 37);
            addCardPopularity("02028", 36);
            addCardPopularity("17141", 36);
            addCardPopularity("08093", 35);
            addCardPopularity("08085", 35);
            addCardPopularity("10054", 34);
            addCardPopularity("06062", 34);
            addCardPopularity("17036", 34);
            addCardPopularity("141005", 33);
            addCardPopularity("12119", 33);
            addCardPopularity("146010", 33);
            addCardPopularity("17116", 33);
            addCardPopularity("08007", 32);
            addCardPopularity("146003", 32);
            addCardPopularity("06038", 31);
            addCardPopularity("12140", 31);
            addCardPopularity("145013", 31);
            addCardPopularity("08143", 29);
            addCardPopularity("12114", 29);
            addCardPopularity("17057", 29);
            addCardPopularity("17139", 29);
            addCardPopularity("04054", 28);
            addCardPopularity("11008", 28);
            addCardPopularity("06056", 26);
            addCardPopularity("03005", 26);
            addCardPopularity("12038", 26);
            addCardPopularity("146009", 26);
            addCardPopularity("17142", 26);
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
            addCardPopularity("02074", 15);
            addCardPopularity("10058", 15);
            addCardPopularity("17135", 15);
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