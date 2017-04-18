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

        private void addPopularity(string cardId, byte popularity)
        {
            popularityByCardId[cardId] = popularity;
        }

        private void initializePopularity()
        {
            //Five Star Heroes
            addPopularity("10140", 5);
            addPopularity("01007", 5);
            addPopularity("04101", 5);
            addPopularity("145002", 5);
            addPopularity("04128", 5);
            addPopularity("08112", 5);
            addPopularity("01005", 5);
            addPopularity("12001", 5);
            addPopularity("01012", 5);
            addPopularity("04053", 5);
            addPopularity("141004", 5);
            addPopularity("01001", 5);
            addPopularity("142002", 5);
            addPopularity("01002", 5);
            addPopularity("01004", 5);

            //Four Star Heroes
            addPopularity("141002", 4);
            addPopularity("03002", 4);
            addPopularity("11001", 4);
            addPopularity("02116", 4);
            addPopularity("145003", 4);
            addPopularity("02095", 4);
            addPopularity("05001", 4);
            addPopularity("02025", 4);
            addPopularity("08084", 4);
            addPopularity("141003", 4);
            addPopularity("01006", 4);
            addPopularity("144003", 4);
            addPopularity("10084", 4);
            addPopularity("08056", 4);
            addPopularity("09001", 4);
            addPopularity("01010", 4);

            //Three Star Heroes
            addPopularity("06001", 3);
            addPopularity("01008", 3);
            addPopularity("131005", 3);
            addPopularity("131002", 3);
            addPopularity("131004", 3);
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

            //Two Star Heroes
            addPopularity("10115", 2);
            addPopularity("132002", 2);
            addPopularity("06032", 2);
            addPopularity("11002", 2);
            addPopularity("04001", 2);
            addPopularity("04028", 2);
            addPopularity("01003", 2);
            addPopularity("04076", 2);
            addPopularity("144002", 2);
            addPopularity("05002", 2);
            addPopularity("01009", 2);
            addPopularity("06107", 2);
            addPopularity("12082", 2);
            addPopularity("10028", 2);
            addPopularity("08137", 2);
            addPopularity("01011", 2);
            addPopularity("07002", 2);
            addPopularity("09002", 2);
            addPopularity("08025", 2);

            //One Star Heroes
            addPopularity("143003", 1);
            addPopularity("06081", 1);
            addPopularity("02001", 1);
            addPopularity("12030", 1);
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

            //Five Star Player Cards
            addPopularity("01050", 5);
            addPopularity("01073", 5);
            addPopularity("01026", 5);
            addPopularity("01057", 5);
            addPopularity("01023", 5);
            addPopularity("01034", 5);
            addPopularity("04108", 5);
            addPopularity("04059", 5);
            addPopularity("04083", 5);
            addPopularity("01046", 5);
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
            addPopularity("01062", 5);
            addPopularity("01070", 5);
            addPopularity("01053", 5);
            addPopularity("131014", 5);
            addPopularity("02026", 5);
            addPopularity("02098", 5);
            addPopularity("01029", 5);
            addPopularity("01060", 5);
            addPopularity("05003", 5);
            addPopularity("01027", 5);
            addPopularity("04106", 5);
            addPopularity("141014", 5);
            addPopularity("12059", 5);
            addPopularity("04129", 5);
            addPopularity("02121", 5);
            addPopularity("06010", 5);
            addPopularity("04031", 5);
            addPopularity("01049", 5);
            addPopularity("01069", 5);
            addPopularity("01061", 5);
            addPopularity("01028", 5);
            addPopularity("01035", 5);
            addPopularity("07007", 5);
            addPopularity("12009", 5);
            addPopularity("03009", 5);
            addPopularity("02004", 5);
            addPopularity("08146", 5);
            addPopularity("10004", 5);
            addPopularity("12006", 5);
            addPopularity("01024", 5);
            addPopularity("09004", 5);
            addPopularity("01058", 5);
            addPopularity("07008", 5);
            addPopularity("01042", 5);
            addPopularity("131011", 5);
            addPopularity("08121", 5);
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
            addPopularity("02079", 5);
            addPopularity("02055", 5);
            addPopularity("10090", 5);
            addPopularity("08087", 5);
            addPopularity("11015", 5);
            addPopularity("143006", 5);
            addPopularity("02081", 5);
            addPopularity("12085", 5);
            addPopularity("12091", 5);
            addPopularity("01072", 5);
            addPopularity("02119", 5);
            addPopularity("06143", 5);
            addPopularity("02103", 5);
            addPopularity("08119", 5);
            addPopularity("10061", 5);
            addPopularity("04131", 5);
            addPopularity("10031", 5);
            addPopularity("12032", 5);
            addPopularity("02034", 5);
            addPopularity("142009", 5);
            addPopularity("07006", 5);
            addPopularity("01044", 5);
            addPopularity("06009", 5);
            addPopularity("01013", 5);
            addPopularity("01031", 5);
            addPopularity("131010", 5);
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
            addPopularity("01063", 5);
            addPopularity("12084", 5);
            addPopularity("06108", 5);
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

            //Four Star Player Cards
            addPopularity("03003", 4);
            addPopularity("08002", 4);
            addPopularity("144010", 4);
            addPopularity("06086", 4);
            addPopularity("04057", 4);
            addPopularity("08088", 4);
            addPopularity("06085", 4);
            addPopularity("10089", 4);
            addPopularity("08113", 4);
            addPopularity("02120", 4);
            addPopularity("143010", 4);
            addPopularity("143004", 4);
            addPopularity("141016", 4);
            addPopularity("08092", 4);
            addPopularity("03008", 4);
            addPopularity("12034", 4);
            addPopularity("145002", 4);
            addPopularity("142006", 4);
            addPopularity("08141", 4);
            addPopularity("02030", 4);
            addPopularity("09014", 4);
            addPopularity("02053", 4);
            addPopularity("05009", 4);
            addPopularity("131008", 4);
            addPopularity("01065", 4);
            addPopularity("04061", 4);
            addPopularity("06003", 4);
            addPopularity("04077", 4);
            addPopularity("10059", 4);
            addPopularity("03007", 4);
            addPopularity("10149", 4);
            addPopularity("12064", 4);
            addPopularity("04036", 4);
            addPopularity("04079", 4);
            addPopularity("12083", 4);
            addPopularity("04128", 4);
            addPopularity("142007", 4);
            addPopularity("02104", 4);
            addPopularity("12117", 4);
            addPopularity("131007", 4);
            addPopularity("145009", 4);
            addPopularity("10033", 4);
            addPopularity("04003", 4);
            addPopularity("141006", 4);
            addPopularity("02006", 4);
            addPopularity("16011", 4);
            addPopularity("01018", 4);
            addPopularity("132017", 4);
            addPopularity("142004", 4);
            addPopularity("05014", 4);
            addPopularity("04102", 4);
            addPopularity("02057", 4);
            addPopularity("04135", 4);
            addPopularity("143014", 4);
            addPopularity("08065", 4);
            addPopularity("10120", 4);
            addPopularity("11010", 4);
            addPopularity("12066", 4);
            addPopularity("02008", 4);
            addPopularity("08112", 4);
            addPopularity("01030", 4);
            addPopularity("143007", 4);
            addPopularity("01005", 4);
            addPopularity("10060", 4);
            addPopularity("08009", 4);
            addPopularity("10146", 4);
            addPopularity("02005", 4);
            addPopularity("143009", 4);
            addPopularity("02075", 4);
            addPopularity("12001", 4);
            addPopularity("11012", 4);
            addPopularity("141013", 4);
            addPopularity("01043", 4);
            addPopularity("12010", 4);
            addPopularity("03004", 4);
            addPopularity("04006", 4);
            addPopularity("06136", 4);
            addPopularity("01054", 4);
            addPopularity("142005", 4);
            addPopularity("08089", 4);
            addPopularity("01012", 4);
            addPopularity("131016", 4);
            addPopularity("04004", 4);
            addPopularity("05015", 4);
            addPopularity("144005", 4);
            addPopularity("08058", 4);
            addPopularity("12004", 4);
            addPopularity("145005", 4);
            addPopularity("16003", 4);
            addPopularity("08140", 4);
            addPopularity("08027", 4);
            addPopularity("131009", 4);
            addPopularity("145007", 4);
            addPopularity("11014", 4);
            addPopularity("09003", 4);
            addPopularity("04030", 4);
            addPopularity("04010", 4);
            addPopularity("02102", 4);
            addPopularity("12008", 4);
            addPopularity("02100", 4);
            addPopularity("10143", 4);
            addPopularity("01022", 4);
            addPopularity("12002", 4);
            addPopularity("08138", 4);
            
            //Three Star Player Cards
            addPopularity("141009", 3);
            addPopularity("06084", 3);
            addPopularity("02010", 3);
            addPopularity("16010", 3);
            addPopularity("06114", 3);
            addPopularity("06041", 3);
            addPopularity("01017", 3);
            addPopularity("01064", 3);
            addPopularity("06087", 3);
            addPopularity("10116", 3);
            addPopularity("144007", 3);
            addPopularity("08086", 3);
            addPopularity("12139", 3);
            addPopularity("10091", 3);
            addPopularity("01041", 3);
            addPopularity("04080", 3);
            addPopularity("12060", 3);
            addPopularity("01020", 3);
            addPopularity("141015", 3);
            addPopularity("06112", 3);
            addPopularity("10037", 3);
            addPopularity("04053", 3);
            addPopularity("06115", 3);
            addPopularity("08090", 3);
            addPopularity("02059", 3);
            addPopularity("08004", 3);
            addPopularity("01037", 3);
            addPopularity("08114", 3);
            addPopularity("08008", 3);
            addPopularity("03013", 3);
            addPopularity("08139", 3);
            addPopularity("01047", 3);
            addPopularity("06141", 3);
            addPopularity("01032", 3);
            addPopularity("141004", 3);
            addPopularity("131013", 3);
            addPopularity("10122", 3);
            addPopularity("01001", 3);
            addPopularity("12011", 3);
            addPopularity("02123", 3);
            addPopularity("08120", 3);
            addPopularity("10147", 3);
            addPopularity("06135", 3);
            addPopularity("10029", 3);
            addPopularity("16004", 3);
            addPopularity("132015", 3);
            addPopularity("132006", 3);
            addPopularity("142002", 3);
            addPopularity("06083", 3);
            addPopularity("10034", 3);
            addPopularity("132016", 3);
            addPopularity("01002", 3);
            addPopularity("06033", 3);
            addPopularity("01036", 3);
            addPopularity("06034", 3);
            addPopularity("11013", 3);
            addPopularity("02097", 3);
            addPopularity("01015", 3);
            addPopularity("01004", 3);
            addPopularity("06137", 3);
            addPopularity("06089", 3);
            addPopularity("10093", 3);
            addPopularity("02117", 3);
            addPopularity("10092", 3);
            addPopularity("141002", 3);
            addPopularity("12037", 3);
            addPopularity("03006", 3);
            addPopularity("143011", 3);
            addPopularity("11003", 3);
            addPopularity("10142", 3);
            addPopularity("06110", 3);
            addPopularity("08057", 3);
            addPopularity("06109", 3);
            addPopularity("145012", 3);
            addPopularity("09010", 3);
            addPopularity("10005", 3);
            addPopularity("08010", 3);
            addPopularity("04136", 3);
            addPopularity("03002", 3);
            addPopularity("11001", 3);
            addPopularity("09007", 3);
            addPopularity("144009", 3);
            addPopularity("144006", 3);
            addPopularity("02029", 3);
            addPopularity("10057", 3);
            addPopularity("02116", 3);
            addPopularity("132008", 3);
            addPopularity("145003", 3);
            addPopularity("06060", 3);
            addPopularity("04084", 3);
            addPopularity("12116", 3);
            addPopularity("02095", 3);
            addPopularity("04034", 3);
            addPopularity("06139", 3);
            addPopularity("06088", 3);
            addPopularity("02051", 3);
            addPopularity("10062", 3);
            addPopularity("06142", 3);
            addPopularity("04130", 3);
            addPopularity("01052", 3);
            addPopularity("06058", 3);
            addPopularity("143008", 3);
            addPopularity("09005", 3);
            addPopularity("06116", 3);
            addPopularity("08028", 3);
            addPopularity("09006", 3);
            addPopularity("04033", 3);
            addPopularity("145006", 3);
            addPopularity("07015", 3);
            addPopularity("02032", 3);
            addPopularity("02080", 3);
            addPopularity("10121", 3);
            addPopularity("03010", 3);
            addPopularity("02096", 3);
            addPopularity("12087", 3);
            addPopularity("10035", 3);
            addPopularity("06063", 3);
            addPopularity("05001", 3);
            addPopularity("02025", 3);
            addPopularity("08084", 3);
            addPopularity("02122", 3);
            addPopularity("10032", 3);

            //Two Star Player Cards
            addPopularity("132012", 2);
            addPopularity("141003", 2);
            addPopularity("11009", 2);
            addPopularity("07010", 2);
            addPopularity("12058", 2);
            addPopularity("12144", 2);
            addPopularity("17008", 2);
            addPopularity("141010", 2);
            addPopularity("01006", 2);
            addPopularity("144003", 2);
            addPopularity("07003", 2);
            addPopularity("08116", 2);
            addPopularity("10055", 2);
            addPopularity("10084", 2);
            addPopularity("10086", 2);
            addPopularity("08056", 2);
            addPopularity("09001", 2);
            addPopularity("08029", 2);
            addPopularity("06064", 2);
            addPopularity("12089", 2);
            addPopularity("04109", 2);
            addPopularity("01010", 2);
            addPopularity("02052", 2);
            addPopularity("02009", 2);
            addPopularity("02007", 2);
            addPopularity("02125", 2);
            addPopularity("08006", 2);
            addPopularity("10124", 2);
            addPopularity("17006", 2);
            addPopularity("06035", 2);
            addPopularity("05004", 2);
            addPopularity("144004", 2);
            addPopularity("04029", 2);
            addPopularity("10118", 2);
            addPopularity("06001", 2);
            addPopularity("06059", 2);
            addPopularity("10009", 2);
            addPopularity("01008", 2);
            addPopularity("08059", 2);
            addPopularity("16008", 2);
            addPopularity("131005", 2);
            addPopularity("141012", 2);
            addPopularity("17004", 2);
            addPopularity("08060", 2);
            addPopularity("03012", 2);
            addPopularity("141007", 2);
            addPopularity("141011", 2);
            addPopularity("131002", 2);
            addPopularity("131004", 2);
            addPopularity("10144", 2);
            addPopularity("02078", 2);
            addPopularity("07009", 2);
            addPopularity("01033", 2);
            addPopularity("12090", 2);
            addPopularity("143002", 2);
            addPopularity("04056", 2);
            addPopularity("01056", 2);
            addPopularity("12138", 2);
            addPopularity("10030", 2);
            addPopularity("12035", 2);
            addPopularity("16001", 2);
            addPopularity("16002", 2);
            addPopularity("04105", 2);
            addPopularity("10006", 2);
            addPopularity("02050", 2);
            addPopularity("10007", 2);
            addPopularity("09011", 2);
            addPopularity("12057", 2);
            addPopularity("17005", 2);
            addPopularity("08001", 2);
            addPopularity("01025", 2);
            addPopularity("10001", 2);
            addPopularity("131012", 2);
            addPopularity("132007", 2);
            addPopularity("06090", 2);
            addPopularity("16005", 2);
            addPopularity("131003", 2);
            addPopularity("04104", 2);
            addPopularity("144008", 2);
            addPopularity("12146", 2);
            addPopularity("12141", 2);
            addPopularity("06134", 2);
            addPopularity("05010", 2);
            addPopularity("12031", 2);
            addPopularity("07001", 2);
            addPopularity("08030", 2);
            addPopularity("02031", 2);
            addPopularity("06007", 2);
            addPopularity("10115", 2);
            addPopularity("10002", 2);
            addPopularity("132002", 2);
            addPopularity("06032", 2);
            addPopularity("143012", 2);
            addPopularity("08005", 2);
            addPopularity("06040", 2);
            addPopularity("04085", 2);
            addPopularity("131018", 2);
            addPopularity("132009", 2);
            addPopularity("11002", 2);
            addPopularity("08026", 2);
            addPopularity("01067", 2);
            addPopularity("08031", 2);
            addPopularity("144012", 2);
            addPopularity("12113", 2);
            addPopularity("12145", 2);
            addPopularity("10141", 2);
            addPopularity("132014", 2);
            addPopularity("04001", 2);
            addPopularity("04028", 2);
            addPopularity("145011", 2);
            addPopularity("07014", 2);
            addPopularity("01019", 2);
            addPopularity("02027", 2);
            addPopularity("01021", 2);
            addPopularity("02124", 2);
            addPopularity("02076", 2);
            addPopularity("132010", 2);
            addPopularity("12007", 2);
            addPopularity("01003", 2);
            addPopularity("04032", 2);

            //One Star Player Cards
            addPopularity("12086", 1);
            addPopularity("04076", 1);
            addPopularity("10119", 1);
            addPopularity("12142", 1);
            addPopularity("16013", 1);
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
            addPopularity("06107", 1);
            addPopularity("12082", 1);
            addPopularity("10028", 1);
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
            addPopularity("02001", 1);
            addPopularity("04005", 1);
            addPopularity("131019", 1);
            addPopularity("12030", 1);
            addPopularity("07013", 1);
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