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
            }

            initializePopularity();
        }

        private readonly Dictionary<string, Card> cardsBySlug = new Dictionary<string,Card>();
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
            addPopularity("010140", 5);
            addPopularity("01045", 5);
            addPopularity("04110", 5);
            addPopularity("01014", 5);
            addPopularity("04101", 5);
            addPopularity("01060", 5);
            addPopularity("010061", 5);
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
            addPopularity("0142006", 5);
            addPopularity("143004", 5);
            addPopularity("01062", 5);
            addPopularity("04053", 5);
            addPopularity("05017", 5);
            addPopularity("08141", 5);
            addPopularity("011001", 5);
            addPopularity("04135", 5);
            addPopularity("131010", 5);
            addPopularity("141014", 5);
            addPopularity("02098", 5);
            addPopularity("010091", 5);
            addPopularity("010120", 5);
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
            addPopularity("010001", 5);
            addPopularity("010032", 5);
            addPopularity("010059", 5);
            addPopularity("141003", 5);
            addPopularity("142005", 5);
            addPopularity("143008", 5);
            addPopularity("04006    ", 4);
            addPopularity("04077	", 4);
            addPopularity("02119	", 4);
            addPopularity("07007	", 4);
            addPopularity("0	8002	", 4);
            addPopularity("0	10033	", 4);
            addPopularity("0	10121	", 4);
            addPopularity("0	11012	", 4);
            addPopularity("0	4137	", 4);
            addPopularity("0	8056	", 4);
            addPopularity("0	8063	", 4);
            addPopularity("0	10009	", 4);
            addPopularity("0	10010	", 4);
            addPopularity("0	11013	", 4);
            addPopularity("132017	", 4);
            addPopularity("141016	", 4);
            addPopularity("0	1031	", 4);
            addPopularity("0	8113	", 4);
            addPopularity("0	8140	", 4);
            addPopularity("0	10060	", 4);
            addPopularity("0	11010	", 4);
            addPopularity("0	1024	", 4);
            addPopularity("0	1042	", 4);
            addPopularity("0	2004	", 4);
            addPopularity("0	2057	", 4);
            addPopularity("0	7011	", 4);
            addPopularity("0	10034	", 4);
            addPopularity("0	10089	", 4);
            addPopularity("143007	", 4);
            addPopularity("144006	", 4);
            addPopularity("0	1002	", 4);
            addPopularity("0	2100	", 4);
            addPopularity("0	10029	", 4);
            addPopularity("0	10118	", 4);
            addPopularity("0	10147	", 4);
            addPopularity("144004	", 4);
            addPopularity("0	6108	", 4);
            addPopularity("0	8114	", 4);
            addPopularity("0	10115	", 4);
            addPopularity("141006	", 4);
            addPopularity("0	1039	", 4);
            addPopularity("0	4057	", 4);
            addPopularity("0	4131	", 4);
            addPopularity("0	5001	", 4);
            addPopularity("0	5009	", 4);
            addPopularity("0	6037	", 4);
            addPopularity("0	6136	", 4);
            addPopularity("0	8087	", 4);
            addPopularity("131005	", 4);
            addPopularity("0	1001	", 4);
            addPopularity("0	1016	", 4);
            addPopularity("0	1029	", 4);
            addPopularity("0	1072	", 4);
            addPopularity("0	2056	", 4);
            addPopularity("0	3002	", 4);
            addPopularity("0	5015	", 4);
            addPopularity("0	6086	", 4);
            addPopularity("0	8059	", 4);
            addPopularity("0	9010	", 4);
            addPopularity("0	10035	", 4);
            addPopularity("0	10084	", 4);
            addPopularity("0	10116	", 4);
            addPopularity("0	10149	", 4);
            addPopularity("131011	", 4);
            addPopularity("142007	", 4);
            addPopularity("144002	", 4);
            addPopularity("144003	", 4);
            addPopularity("0	2055	", 4);
            addPopularity("0	6008	", 4);
            addPopularity("0	2120	", 4);
            addPopularity("0	8088	", 4);
            addPopularity("0	8120	", 4);
            addPopularity("0	10007	", 4);
            addPopularity("0	10062	", 4);
            addPopularity("0	10092	", 4);
            addPopularity("142004	", 4);
            addPopularity("0	1012	", 4);
            addPopularity("0	2034	", 4);
            addPopularity("0	2077	", 4);
            addPopularity("0	2095	", 4);
            addPopularity("0	4036	", 4);
            addPopularity("0	4133	", 4);
            addPopularity("0	6032	", 4);
            addPopularity("0	7006	", 4);
            addPopularity("0	9003	", 4);
            addPopularity("0	10028	", 4);
            addPopularity("0	10037	", 4);
            addPopularity("143010	", 4);
            addPopularity("0	1005	", 4);
            addPopularity("0	1051	", 4);
            addPopularity("0	1054	", 4);
            addPopularity("0	2005	", 4);
            addPopularity("0	2030	", 4);
            addPopularity("0	3009	", 4);
            addPopularity("0	4001	", 4);
            addPopularity("0	4028	", 4);
            addPopularity("0	8029	", 4);
            addPopularity("0	8058	", 4);
            addPopularity("0	11014	", 4);
            addPopularity("132015	", 4);
            addPopularity("143003	", 4);
            addPopularity("0	1035	", 3);
            addPopularity("0	2102	", 3);
            addPopularity("0	5006	", 3);
            addPopularity("0	6087	", 3);
            addPopularity("0	6114	", 3);
            addPopularity("0	8001	", 3);
            addPopularity("0	8008	", 3);
            addPopularity("0	8009	", 3);
            addPopularity("0	8027	", 3);
            addPopularity("0	9002	", 3);
            addPopularity("0	9005	", 3);
            addPopularity("0	10055	", 3);
            addPopularity("0	10086	", 3);
            addPopularity("0	11002	", 3);
            addPopularity("141015	", 3);
            addPopularity("144010	", 3);
            addPopularity("0	2059	", 3);
            addPopularity("0	2096	", 3);
            addPopularity("0	4084	", 3);
            addPopularity("0	5002	", 3);
            addPopularity("0	8028	", 3);
            addPopularity("0	8138	", 3);
            addPopularity("0	10002	", 3);
            addPopularity("0	10006	", 3);
            addPopularity("0	144007	", 3);
            addPopularity("0	1061	", 3);
            addPopularity("0	4076	", 3);
            addPopularity("0	5004	", 3);
            addPopularity("0	6035	", 3);
            addPopularity("0	6143	", 3);
            addPopularity("0	7002	", 3);
            addPopularity("0	7010	", 3);
            addPopularity("0	9008	", 3);
            addPopularity("0	10030	", 3);
            addPopularity("0	10088	", 3);
            addPopularity("0	10122	", 3);
            addPopularity("0	132016	", 3);
            addPopularity("0	132018	", 3);
            addPopularity("0	143002	", 3);
            addPopularity("0	1040	", 3);
            addPopularity("0	4104	", 3);
            addPopularity("0	4129	", 3);
            addPopularity("0	6057	", 3);
            addPopularity("0	6088	", 3);
            addPopularity("0	6142	", 3);
            addPopularity("0	8139	", 3);
            addPopularity("0	10005	", 3);
            addPopularity("0	10124	", 3);
            addPopularity("0	11009	", 3);
            addPopularity("0	131013	", 3);
            addPopularity("0	132009	", 3);
            addPopularity("141009	", 3);
            addPopularity("141011	", 3);
            addPopularity("0	144009	", 3);
            addPopularity("0	2078	", 3);
            addPopularity("0	2080	", 3);
            addPopularity("0	4010	", 3);
            addPopularity("0	4103	", 3);
            addPopularity("0	2124	", 3);
            addPopularity("0	8065	", 3);
            addPopularity("0	9006	", 3);
            addPopularity("0	9007	", 3);
            addPopularity("0	10143	", 3);
            addPopularity("0	131009	", 3);
            addPopularity("0	131016	", 3);
            addPopularity("0	1006	", 3);
            addPopularity("0	2008	", 3);
            addPopularity("0	2025	", 3);
            addPopularity("0	2075	", 3);
            addPopularity("0	3003	", 3);
            addPopularity("0	4003	", 3);
            addPopularity("0	4004	", 3);
            addPopularity("0	4034	", 3);
            addPopularity("0	6003	", 3);
            addPopularity("0	6063	", 3);
            addPopularity("0	6115	", 3);
            addPopularity("0	2122	", 3);
            addPopularity("0	2123	", 3);
            addPopularity("0	8057	", 3);
            addPopularity("0	8089	", 3);
            addPopularity("0	8137	", 3);
            addPopularity("0	9009	", 3);
            addPopularity("0	10087	", 3);
            addPopularity("0	10146	", 3);
            addPopularity("0	131008	", 3);
            addPopularity("0	1010	", 3);
            addPopularity("0	2003	", 3);
            addPopularity("0	2006	", 3);
            addPopularity("0	2050	", 3);
            addPopularity("0	2104	", 3);
            addPopularity("0	3011	", 3);
            addPopularity("0	4056	", 3);
            addPopularity("0	6059	", 3);
            addPopularity("0	6089	", 3);
            addPopularity("0	6112	", 3);
            addPopularity("0	6137	", 3);
            addPopularity("0	7003	", 3);
            addPopularity("0	7015	", 3);
            addPopularity("0	8004	", 3);
            addPopularity("0	8005	", 3);
            addPopularity("0	8025	", 3);
            addPopularity("0	8115	", 3);
            addPopularity("0	10141	", 3);
            addPopularity("0	11003	", 3);
            addPopularity("0	11006	", 3);
            addPopularity("0	132010	", 3);
            addPopularity("0	141010	", 3);
            addPopularity("0	141013	", 3);
            addPopularity("0	1047	", 2);
            addPopularity("0	1066	", 2);
            addPopularity("0	2010	", 2);
            addPopularity("0	2081	", 2);
            addPopularity("0	2097	", 2);
            addPopularity("0	3013	", 2);
            addPopularity("0	4136	", 2);
            addPopularity("0	6007	", 2);
            addPopularity("0	6041	", 2);
            addPopularity("0	6084	", 2);
            addPopularity("0	6135	", 2);
            addPopularity("0	2117	", 2);
            addPopularity("0	7009	", 2);
            addPopularity("0	8010	", 2);
            addPopularity("0	10144	", 2);
            addPopularity("0	132002	", 2);
            addPopularity("0	1003	", 2);
            addPopularity("0	1020	", 2);
            addPopularity("0	1044	", 2);
            addPopularity("0	1063	", 2);
            addPopularity("0	3007	", 2);
            addPopularity("0	4005	", 2);
            addPopularity("0	4080	", 2);
            addPopularity("0	4109	", 2);
            addPopularity("0	5010	", 2);
            addPopularity("0	6002	", 2);
            addPopularity("0	6004	", 2);
            addPopularity("0	6110	", 2);
            addPopularity("0	6116	", 2);
            addPopularity("0	6140	", 2);
            addPopularity("0	7014	", 2);
            addPopularity("0	10057	", 2);
            addPopularity("0	10085	", 2);
            addPopularity("0	10093	", 2);
            addPopularity("0	11011	", 2);
            addPopularity("0	132003	", 2);
            addPopularity("0	141007	", 2);
            addPopularity("0	143012	", 2);
            addPopularity("0	1004	", 2);
            addPopularity("0	1009	", 2);
            addPopularity("0	1013	", 2);
            addPopularity("0	1015	", 2);
            addPopularity("0	1017	", 2);
            addPopularity("0	1022	", 2);
            addPopularity("0	1025	", 2);
            addPopularity("0	2001	", 2);
            addPopularity("0	2009	", 2);
            addPopularity("0	2099	", 2);
            addPopularity("0	4029	", 2);
            addPopularity("0	4033	", 2);
            addPopularity("0	4061	", 2);
            addPopularity("0	4079	", 2);
            addPopularity("0	5008	", 2);
            addPopularity("0	6033	", 2);
            addPopularity("0	6034	", 2);
            addPopularity("0	6090	", 2);
            addPopularity("0	6107	", 2);
            addPopularity("0	6109	", 2);
            addPopularity("0	6141	", 2);
            addPopularity("0	7001	", 2);
            addPopularity("0	8030	", 2);
            addPopularity("0	8091	", 2);
            addPopularity("0	9011	", 2);
            addPopularity("0	131012	", 2);
            addPopularity("0	131018	", 2);
            addPopularity("0	144008	", 2);
            addPopularity("0	144012	", 2);
            addPopularity("0	1019	", 2);
            addPopularity("0	1037	", 2);
            addPopularity("0	1038	", 2);
            addPopularity("0	1052	", 2);
            addPopularity("0	1071	", 2);
            addPopularity("0	2032	", 2);
            addPopularity("0	2052	", 2);
            addPopularity("0	4032	", 2);
            addPopularity("0	4078	", 2);
            addPopularity("0	4102	", 2);
            addPopularity("0	4130	", 2);
            addPopularity("0	5014	", 2);
            addPopularity("0	6039	", 2);
            addPopularity("0	6060	", 2);
            addPopularity("0	6061	", 2);
            addPopularity("0	6064	", 2);
            addPopularity("0	6083	", 2);
            addPopularity("0	6134	", 2);
            addPopularity("0	7004	", 2);
            addPopularity("0	10054	", 2);
            addPopularity("0	10119	", 2);
            addPopularity("0	10142	", 2);
            addPopularity("0	11007	", 2);
            addPopularity("0	131006	", 2);
            addPopularity("0	132007	", 2);
            addPopularity("0	1008	", 1);
            addPopularity("0	1018	", 1);
            addPopularity("0	1028	", 1);
            addPopularity("0	1055	", 1);
            addPopularity("0	1065	", 1);
            addPopularity("0	2007	", 1);
            addPopularity("0	2029	", 1);
            addPopularity("0	2051	", 1);
            addPopularity("0	3004	", 1);
            addPopularity("0	3008	", 1);
            addPopularity("0	4002	", 1);
            addPopularity("0	4009	", 1);
            addPopularity("0	4030	", 1);
            addPopularity("0	5016	", 1);
            addPopularity("0	6036	", 1);
            addPopularity("0	6111	", 1);
            addPopularity("0	6139	", 1);
            addPopularity("0	7005	", 1);
            addPopularity("0	8026	", 1);
            addPopularity("0	8031	", 1);
            addPopularity("0	8033	", 1);
            addPopularity("0	8034	", 1);
            addPopularity("0	8060	", 1);
            addPopularity("0	8090	", 1);
            addPopularity("0	8145	", 1);
            addPopularity("0	10003	", 1);
            addPopularity("0	10008	", 1);
            addPopularity("0	11005	", 1);
            addPopularity("0	131007	", 1);
            addPopularity("0	132006	", 1);
            addPopularity("0	132011	", 1);
            addPopularity("0	132014	", 1);
            addPopularity("0	141005	", 1);
            addPopularity("0	141008	", 1);
            addPopularity("0	142010	", 1);
            addPopularity("0	1030	", 1);
            addPopularity("0	1032	", 1);
            addPopularity("0	1033	", 1);
            addPopularity("0	1041	", 1);
            addPopularity("0	1043	", 1);
            addPopularity("0	1058	", 1);
            addPopularity("0	1064	", 1);
            addPopularity("0	2054	", 1);
            addPopularity("0	2058	", 1);
            addPopularity("0	2072	", 1);
            addPopularity("0	3001	", 1);
            addPopularity("0	3010	", 1);
            addPopularity("0	4008	", 1);
            addPopularity("0	4054	", 1);
            addPopularity("0	5005	", 1);
            addPopularity("0	5011	", 1);
            addPopularity("0	6001	", 1);
            addPopularity("0	6040	", 1);
            addPopularity("0	6058	", 1);
            addPopularity("0	6082	", 1);
            addPopularity("0	6113	", 1);
            addPopularity("0	2116	", 1);
            addPopularity("0	2118	", 1);
            addPopularity("0	2125	", 1);
            addPopularity("0	7013	", 1);
            addPopularity("0	8003	", 1);
            addPopularity("0	8007	", 1);
            addPopularity("0	8032	", 1);
            addPopularity("0	8062	", 1);
            addPopularity("0	8116	", 1);
            addPopularity("0	8142	", 1);
            addPopularity("0	8143	", 1);
            addPopularity("0	9015	", 1);
            addPopularity("0	11004	", 1);
            addPopularity("0	131004	", 1);
            addPopularity("0	132005	", 1);
            addPopularity("0	141012	", 1);
            addPopularity("0	144011	", 1);
            addPopularity("0	1021	", 1);
            addPopularity("0	1036	", 1);
            addPopularity("0	1056	", 1);
            addPopularity("0	1067	", 1);
            addPopularity("0	1068	", 1);
            addPopularity("0	2027	", 1);
            addPopularity("0	2028	", 1);
            addPopularity("0	2031	", 1);
            addPopularity("0	2073	", 1);
            addPopularity("0	2074	", 1);
            addPopularity("0	2076	", 1);
            addPopularity("0	3005	", 1);
            addPopularity("0	3006	", 1);
            addPopularity("0	3012	", 1);
            addPopularity("0	4007	", 1);
            addPopularity("0	4035	", 1);
            addPopularity("0	4060	", 1);
            addPopularity("0	4081	", 1);
            addPopularity("0	4082	", 1);
            addPopularity("0	4085	", 1);
            addPopularity("0	4105	", 1);
            addPopularity("0	5012	", 1);
            addPopularity("0	6038	", 1);
            addPopularity("0	6062	", 1);
            addPopularity("0	6065	", 1);
            addPopularity("0	6081	", 1);
            addPopularity("0	6138	", 1);
            addPopularity("0	8006	", 1);
            addPopularity("0	8061	", 1);
            addPopularity("0	8085	", 1);
            addPopularity("0	8093	", 1);
            addPopularity("0	8144	", 1);
            addPopularity("0	9013	", 1);
            addPopularity("0	10036	", 1);
            addPopularity("0	10056	", 1);
            addPopularity("0	10063	", 1);
            addPopularity("0	10117	", 1);
            addPopularity("0	10123	", 1);
            addPopularity("0	10148	", 1);
            addPopularity("0	11008	", 1);
            addPopularity("0	131002	", 1);
            addPopularity("0	131003	", 1);
            addPopularity("0	131017	", 1);
            addPopularity("0	132004	", 1);
            addPopularity("0	132008	", 1);
            addPopularity("0	132012	", 1);
            addPopularity("0	143013	", 1);
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
                case "Ring-maker":
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
                case "TRD":
                    return 142;
                case "ToS":
                    return 143;
                case "TLoS":
                    return 144;
                default:
                    return 0;
            }
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