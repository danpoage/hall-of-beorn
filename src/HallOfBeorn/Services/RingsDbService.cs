using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

using HallOfBeorn.Models;

namespace HallOfBeorn.Services
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

        private readonly Dictionary<string, Card> cardsBySlug = new Dictionary<string,Card>();
        private readonly Dictionary<string, string> slugByCardId = new Dictionary<string, string>();
        private readonly Dictionary<string, byte> popularityByCardId = new Dictionary<string, byte>();

        private void addPopularity(string cardId, byte popularity)
        {
            popularityByCardId[cardId] = popularity;
        }

        private void initializePopularity()
        {
            addPopularity("01050", 5);
            addPopularity("04108", 5);
            addPopularity("01073", 5);
            addPopularity("01026", 5);
            addPopularity("01057", 5);
            addPopularity("04059", 5);
            addPopularity("04107", 5);
            addPopularity("01034", 5);
            addPopularity("01023", 5);
            addPopularity("08146", 5);
            addPopularity("04083", 5);
            addPopularity("143006", 5);
            addPopularity("07012", 5);
            addPopularity("04058", 5);
            addPopularity("06005", 5);
            addPopularity("02033", 5);
            addPopularity("010145", 5);
            addPopularity("01046", 5);
            addPopularity("09014", 5);
            addPopularity("10140", 5);
            addPopularity("01045", 5);
            addPopularity("04110", 5);
            addPopularity("01014", 5);
            addPopularity("04101", 5);
            addPopularity("01060", 5);
            addPopularity("10061", 5);
            addPopularity("05018", 5);
            addPopularity("01053", 5);
            addPopularity("011015", 5);
            addPopularity("01070", 5);
            addPopularity("08119", 5);
            addPopularity("08092", 5);
            addPopularity("08112", 5);
            addPopularity("010090", 5);
            addPopularity("01048", 5);
            addPopularity("04134", 5);
            addPopularity("08117", 5);
            addPopularity("01049", 5);
            addPopularity("08121", 5);
            addPopularity("141004", 5);
            addPopularity("04055", 5);
            addPopularity("010004", 5);
            addPopularity("01027", 5);
            addPopularity("010031", 5);
            addPopularity("143005", 5);
            addPopularity("05003", 5);
            addPopularity("06006", 5);
            addPopularity("08064", 5);
            addPopularity("143009", 5);
            addPopularity("09004", 5);
            addPopularity("06010", 5);
            addPopularity("142003", 5);
            addPopularity("142008", 5);
            addPopularity("02079", 5);
            addPopularity("04031", 5);
            addPopularity("02026", 5);
            addPopularity("02103", 5);
            addPopularity("131015", 5);
            addPopularity("08118", 5);
            addPopularity("143011", 5);
            addPopularity("04128", 5);
            addPopularity("142006", 5);
            addPopularity("143004", 5);
            addPopularity("01062", 5);
            addPopularity("04053", 5);
            addPopularity("05017", 5);
            addPopularity("08141", 5);
            addPopularity("11001", 5);
            addPopularity("04135", 5);
            addPopularity("131010", 5);
            addPopularity("141014", 5);
            addPopularity("02098", 5);
            addPopularity("10091", 5);
            addPopularity("10120", 5);
            addPopularity("143014", 5);
            addPopularity("04106", 5);
            addPopularity("05013", 5);
            addPopularity("06085", 5);
            addPopularity("07008", 5);
            addPopularity("131014", 5);
            addPopularity("142009", 5);
            addPopularity("141002", 5);
            addPopularity("02053", 5);
            addPopularity("02121", 5);
            addPopularity("09001", 5);
            addPopularity("09012", 5);
            addPopularity("01007", 5);
            addPopularity("01059", 5);
            addPopularity("01069", 5);
            addPopularity("04062", 5);
            addPopularity("05007", 5);
            addPopularity("142002", 5);
            addPopularity("144005", 5);
            addPopularity("02002", 5);
            addPopularity("06009", 5);
            addPopularity("08084", 5);
            addPopularity("08086", 5);
            addPopularity("10001", 5);
            addPopularity("10032", 5);
            addPopularity("10059", 5);
            addPopularity("141003", 5);
            addPopularity("142005", 5);
            addPopularity("143008", 5);
            addPopularity("04006", 4);
            addPopularity("04077", 4);
            addPopularity("02119", 4);
            addPopularity("07007", 4);
            addPopularity("08002", 4);
            addPopularity("10033", 4);
            addPopularity("10121", 4);
            addPopularity("11012", 4);
            addPopularity("04137", 4);
            addPopularity("08056", 4);
            addPopularity("08063", 4);
            addPopularity("010009", 4);
            addPopularity("010010", 4);
            addPopularity("011013", 4);
            addPopularity("132017", 4);
            addPopularity("141016", 4);
            addPopularity("01031", 4);
            addPopularity("08113", 4);
            addPopularity("08140", 4);
            addPopularity("010060", 4);
            addPopularity("011010", 4);
            addPopularity("01024", 4);
            addPopularity("01042", 4);
            addPopularity("02004", 4);
            addPopularity("02057", 4);
            addPopularity("07011", 4);
            addPopularity("010034", 4);
            addPopularity("010089", 4);
            addPopularity("143007", 4);
            addPopularity("144006", 4);
            addPopularity("01002", 4);
            addPopularity("02100", 4);
            addPopularity("10029", 4);
            addPopularity("10118", 4);
            addPopularity("10147", 4);
            addPopularity("144004", 4);
            addPopularity("06108", 4);
            addPopularity("08114", 4);
            addPopularity("10115", 4);
            addPopularity("141006", 4);
            addPopularity("01039", 4);
            addPopularity("04057", 4);
            addPopularity("04131", 4);
            addPopularity("05001", 4);
            addPopularity("05009", 4);
            addPopularity("06037", 4);
            addPopularity("06136", 4);
            addPopularity("08087", 4);
            addPopularity("131005", 4);
            addPopularity("01001", 4);
            addPopularity("01016", 4);
            addPopularity("01029", 4);
            addPopularity("01072", 4);
            addPopularity("02056", 4);
            addPopularity("03002", 4);
            addPopularity("05015", 4);
            addPopularity("06086", 4);
            addPopularity("08059", 4);
            addPopularity("09010", 4);
            addPopularity("10035", 4);
            addPopularity("10084", 4);
            addPopularity("10116", 4);
            addPopularity("10149", 4);
            addPopularity("131011", 4);
            addPopularity("142007", 4);
            addPopularity("144002", 4);
            addPopularity("144003", 4);
            addPopularity("02055", 4);
            addPopularity("06008", 4);
            addPopularity("02120", 4);
            addPopularity("08088", 4);
            addPopularity("08120", 4);
            addPopularity("10007", 4);
            addPopularity("010062", 4);
            addPopularity("010092", 4);
            addPopularity("142004", 4);
            addPopularity("01012", 4);
            addPopularity("02034", 4);
            addPopularity("02077", 4);
            addPopularity("02095", 4);
            addPopularity("04036", 4);
            addPopularity("04133", 4);
            addPopularity("06032", 4);
            addPopularity("07006", 4);
            addPopularity("09003", 4);
            addPopularity("10028", 4);
            addPopularity("10037", 4);
            addPopularity("143010", 4);
            addPopularity("01005", 4);
            addPopularity("01051", 4);
            addPopularity("01054", 4);
            addPopularity("02005", 4);
            addPopularity("02030", 4);
            addPopularity("03009", 4);
            addPopularity("04001", 4);
            addPopularity("04028", 4);
            addPopularity("08029", 4);
            addPopularity("08058", 4);
            addPopularity("011014", 4);
            addPopularity("132015", 4);
            addPopularity("143003", 4);
            addPopularity("01035", 3);
            addPopularity("02102", 3);
            addPopularity("05006", 3);
            addPopularity("06087", 3);
            addPopularity("06114", 3);
            addPopularity("08001", 3);
            addPopularity("08008", 3);
            addPopularity("08009", 3);
            addPopularity("08027", 3);
            addPopularity("09002", 3);
            addPopularity("09005", 3);
            addPopularity("10055", 3);
            addPopularity("10086", 3);
            addPopularity("11002", 3);
            addPopularity("141015", 3);
            addPopularity("144010", 3);
            addPopularity("02059", 3);
            addPopularity("02096", 3);
            addPopularity("04084", 3);
            addPopularity("05002", 3);
            addPopularity("08028", 3);
            addPopularity("08138", 3);
            addPopularity("10002", 3);
            addPopularity("10006", 3);
            addPopularity("144007", 3);
            addPopularity("01061", 3);
            addPopularity("04076", 3);
            addPopularity("05004", 3);
            addPopularity("06035", 3);
            addPopularity("06143", 3);
            addPopularity("07002", 3);
            addPopularity("07010", 3);
            addPopularity("09008", 3);
            addPopularity("10030", 3);
            addPopularity("10088", 3);
            addPopularity("10122", 3);
            addPopularity("132016", 3);
            addPopularity("132018", 3);
            addPopularity("143002", 3);
            addPopularity("01040", 3);
            addPopularity("04104", 3);
            addPopularity("04129", 3);
            addPopularity("06057", 3);
            addPopularity("06088", 3);
            addPopularity("06142", 3);
            addPopularity("08139", 3);
            addPopularity("10005", 3);
            addPopularity("10124", 3);
            addPopularity("11009", 3);
            addPopularity("131013", 3);
            addPopularity("132009", 3);
            addPopularity("141009", 3);
            addPopularity("141011", 3);
            addPopularity("144009", 3);
            addPopularity("02078", 3);
            addPopularity("02080", 3);
            addPopularity("04010", 3);
            addPopularity("04103", 3);
            addPopularity("02124", 3);
            addPopularity("08065", 3);
            addPopularity("09006", 3);
            addPopularity("09007", 3);
            addPopularity("010143", 3);
            addPopularity("131009", 3);
            addPopularity("131016", 3);
            addPopularity("01006", 3);
            addPopularity("02008", 3);
            addPopularity("02025", 3);
            addPopularity("02075", 3);
            addPopularity("03003", 3);
            addPopularity("04003", 3);
            addPopularity("04004", 3);
            addPopularity("04034", 3);
            addPopularity("06003", 3);
            addPopularity("06063", 3);
            addPopularity("06115", 3);
            addPopularity("02122", 3);
            addPopularity("02123", 3);
            addPopularity("08057", 3);
            addPopularity("08089", 3);
            addPopularity("08137", 3);
            addPopularity("09009", 3);
            addPopularity("010087", 3);
            addPopularity("010146", 3);
            addPopularity("131008", 3);
            addPopularity("01010", 3);
            addPopularity("02003", 3);
            addPopularity("02006", 3);
            addPopularity("02050", 3);
            addPopularity("02104", 3);
            addPopularity("03011", 3);
            addPopularity("04056", 3);
            addPopularity("06059", 3);
            addPopularity("06089", 3);
            addPopularity("06112", 3);
            addPopularity("06137", 3);
            addPopularity("07003", 3);
            addPopularity("07015", 3);
            addPopularity("08004", 3);
            addPopularity("08005", 3);
            addPopularity("08025", 3);
            addPopularity("08115", 3);
            addPopularity("10141", 3);
            addPopularity("11003", 3);
            addPopularity("11006", 3);
            addPopularity("132010", 3);
            addPopularity("141010", 3);
            addPopularity("141013", 3);
            addPopularity("01047", 2);
            addPopularity("01066", 2);
            addPopularity("02010", 2);
            addPopularity("02081", 2);
            addPopularity("02097", 2);
            addPopularity("03013", 2);
            addPopularity("04136", 2);
            addPopularity("06007", 2);
            addPopularity("06041", 2);
            addPopularity("06084", 2);
            addPopularity("06135", 2);
            addPopularity("02117", 2);
            addPopularity("07009", 2);
            addPopularity("08010", 2);
            addPopularity("010144", 2);
            addPopularity("132002", 2);
            addPopularity("01003", 2);
            addPopularity("01020", 2);
            addPopularity("01044", 2);
            addPopularity("01063", 2);
            addPopularity("03007", 2);
            addPopularity("04005", 2);
            addPopularity("04080", 2);
            addPopularity("04109", 2);
            addPopularity("05010", 2);
            addPopularity("06002", 2);
            addPopularity("06004", 2);
            addPopularity("06110", 2);
            addPopularity("06116", 2);
            addPopularity("06140", 2);
            addPopularity("07014", 2);
            addPopularity("10057", 2);
            addPopularity("10085", 2);
            addPopularity("10093", 2);
            addPopularity("01011", 2);
            addPopularity("132003", 2);
            addPopularity("141007", 2);
            addPopularity("143012", 2);
            addPopularity("01004", 2);
            addPopularity("01009", 2);
            addPopularity("01013", 2);
            addPopularity("01015", 2);
            addPopularity("01017", 2);
            addPopularity("01022", 2);
            addPopularity("01025", 2);
            addPopularity("02001", 2);
            addPopularity("02009", 2);
            addPopularity("02099", 2);
            addPopularity("04029", 2);
            addPopularity("04033", 2);
            addPopularity("04061", 2);
            addPopularity("04079", 2);
            addPopularity("05008", 2);
            addPopularity("06033", 2);
            addPopularity("06034", 2);
            addPopularity("06090", 2);
            addPopularity("06107", 2);
            addPopularity("06109", 2);
            addPopularity("06141", 2);
            addPopularity("07001", 2);
            addPopularity("08030", 2);
            addPopularity("08091", 2);
            addPopularity("09011", 2);
            addPopularity("131012", 2);
            addPopularity("131018", 2);
            addPopularity("144008", 2);
            addPopularity("144012", 2);
            addPopularity("01019", 2);
            addPopularity("01037", 2);
            addPopularity("01038", 2);
            addPopularity("01052", 2);
            addPopularity("01071", 2);
            addPopularity("02032", 2);
            addPopularity("02052", 2);
            addPopularity("04032", 2);
            addPopularity("04078", 2);
            addPopularity("04102", 2);
            addPopularity("04130", 2);
            addPopularity("05014", 2);
            addPopularity("06039", 2);
            addPopularity("06060", 2);
            addPopularity("06061", 2);
            addPopularity("06064", 2);
            addPopularity("06083", 2);
            addPopularity("06134", 2);
            addPopularity("07004", 2);
            addPopularity("10054", 2);
            addPopularity("10119", 2);
            addPopularity("10142", 2);
            addPopularity("11007", 2);
            addPopularity("131006", 2);
            addPopularity("132007", 2);
            addPopularity("01008", 1);
            addPopularity("01018", 1);
            addPopularity("01028", 1);
            addPopularity("01055", 1);
            addPopularity("01065", 1);
            addPopularity("02007", 1);
            addPopularity("02029", 1);
            addPopularity("02051", 1);
            addPopularity("03004", 1);
            addPopularity("03008", 1);
            addPopularity("04002", 1);
            addPopularity("04009", 1);
            addPopularity("04030", 1);
            addPopularity("05016", 1);
            addPopularity("06036", 1);
            addPopularity("06111", 1);
            addPopularity("06139", 1);
            addPopularity("07005", 1);
            addPopularity("08026", 1);
            addPopularity("08031", 1);
            addPopularity("08033", 1);
            addPopularity("08034", 1);
            addPopularity("08060", 1);
            addPopularity("08090", 1);
            addPopularity("08145", 1);
            addPopularity("010003", 1);
            addPopularity("010008", 1);
            addPopularity("011005", 1);
            addPopularity("131007", 1);
            addPopularity("132006", 1);
            addPopularity("132011", 1);
            addPopularity("132014", 1);
            addPopularity("141005", 1);
            addPopularity("141008", 1);
            addPopularity("142010", 1);
            addPopularity("01030", 1);
            addPopularity("01032", 1);
            addPopularity("01033", 1);
            addPopularity("01041", 1);
            addPopularity("01043", 1);
            addPopularity("01058", 1);
            addPopularity("01064", 1);
            addPopularity("02054", 1);
            addPopularity("02058", 1);
            addPopularity("02072", 1);
            addPopularity("03001", 1);
            addPopularity("03010", 1);
            addPopularity("04008", 1);
            addPopularity("04054", 1);
            addPopularity("05005", 1);
            addPopularity("05011", 1);
            addPopularity("06001", 1);
            addPopularity("06040", 1);
            addPopularity("06058", 1);
            addPopularity("06082", 1);
            addPopularity("06113", 1);
            addPopularity("02116", 1);
            addPopularity("02118", 1);
            addPopularity("02125", 1);
            addPopularity("07013", 1);
            addPopularity("08003", 1);
            addPopularity("08007", 1);
            addPopularity("08032", 1);
            addPopularity("08062", 1);
            addPopularity("08116", 1);
            addPopularity("08142", 1);
            addPopularity("08143", 1);
            addPopularity("09015", 1);
            addPopularity("011004", 1);
            addPopularity("131004", 1);
            addPopularity("132005", 1);
            addPopularity("141012", 1);
            addPopularity("144011", 1);
            addPopularity("01021", 1);
            addPopularity("01036", 1);
            addPopularity("01056", 1);
            addPopularity("01067", 1);
            addPopularity("01068", 1);
            addPopularity("02027", 1);
            addPopularity("02028", 1);
            addPopularity("02031", 1);
            addPopularity("02073", 1);
            addPopularity("02074", 1);
            addPopularity("02076", 1);
            addPopularity("03005", 1);
            addPopularity("03006", 1);
            addPopularity("03012", 1);
            addPopularity("04007", 1);
            addPopularity("04035", 1);
            addPopularity("04060", 1);
            addPopularity("04081", 1);
            addPopularity("04082", 1);
            addPopularity("04085", 1);
            addPopularity("04105", 1);
            addPopularity("05012", 1);
            addPopularity("06038", 1);
            addPopularity("06062", 1);
            addPopularity("06065", 1);
            addPopularity("06081", 1);
            addPopularity("06138", 1);
            addPopularity("08006", 1);
            addPopularity("08061", 1);
            addPopularity("08085", 1);
            addPopularity("08093", 1);
            addPopularity("08144", 1);
            addPopularity("09013", 1);
            addPopularity("10036", 1);
            addPopularity("10056", 1);
            addPopularity("10063", 1);
            addPopularity("10117", 1);
            addPopularity("10123", 1);
            addPopularity("10148", 1);
            addPopularity("11008", 1);
            addPopularity("131002", 1);
            addPopularity("131003", 1);
            addPopularity("131017", 1);
            addPopularity("132004", 1);
            addPopularity("132008", 1);
            addPopularity("132012", 1);
            addPopularity("143013", 1);
            addPopularity("04132", 1);

            addPopularity("06056", 1);
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
                return string.Format("{0:000}{1:000}", setNumber, card.Number);
            }
            else
            {
                return string.Format("{0:00}{1:000}", setNumber, card.Number);
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