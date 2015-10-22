using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace HallOfBeorn.Services
{
    public class OctgnService
    {
        public OctgnService()
        {
            LoadCardMaps();
            LoadSetMaps();
        }

        private readonly Dictionary<string, string> setNamesByGuid = new Dictionary<string,string>();
        private readonly Dictionary<string, string> guidsBySetName = new Dictionary<string, string>();

        private void LoadCardMaps()
        {
        }

        private void LoadSetMaps()
        {
            //a21af4e8-be4b-4cda-a6b6-534f9717391f	Lord of the Rings

            setNamesByGuid.Add("51223bd0-ffd1-11df-a976-0801200c9000", "Core Set");
            setNamesByGuid.Add("51223bd0-ffd1-11df-a976-0801201c9000", "The Hunt for Gollum");
            setNamesByGuid.Add("51223bd0-ffd1-11df-a976-0801202c9000", "Conflict at the Carrock");
            setNamesByGuid.Add("51223bd0-ffd1-11df-a976-0801203c9000", "A Journey to Rhosgobel");
            setNamesByGuid.Add("51223bd0-ffd1-11df-a976-0801204c9000", "The Hills of Emyn Muil");
            setNamesByGuid.Add("51223bd0-ffd1-11df-a976-0801205c9000", "The Dead Marshes");
            setNamesByGuid.Add("51223bd0-ffd1-11df-a976-0801206c9000", "Return to Mirkwood");
            setNamesByGuid.Add("51223bd0-ffd1-11df-a976-0801207c9000", "Khazad-dum");
            setNamesByGuid.Add("2a6d92c0-4ba9-4046-bea5-3221ae6b475b", "The Redhorn Gate");
            setNamesByGuid.Add("51223bd0-ffd1-11df-a976-0801209c9000", "Road to Rivendell");
            setNamesByGuid.Add("51223bd0-ffd1-11df-a976-0801210c9000", "The Watcher in the Water");
            setNamesByGuid.Add("51223bd0-ffd1-11df-a976-0801211c9000", "The Long Dark");
            setNamesByGuid.Add("51223bd0-ffd1-11df-a976-0801212c9000", "Foundations of Stone");
            setNamesByGuid.Add("51223bd0-ffd1-11df-a976-0801213c9000", "Shadow and Flame");
            setNamesByGuid.Add("4823aae3-46ef-4a75-89f9-cbd3aa1b9000", "Heirs of Númenor");
            setNamesByGuid.Add("89742ddf-cbdf-4f94-9e73-81685990df1b", "The Stewards Fear");
            setNamesByGuid.Add("496b4b55-b8d3-48e4-9872-bea887d1f1b6", "The Drúadan Forest");
            setNamesByGuid.Add("fd89bdbf-7475-4f3e-96fc-8f5315a93000", "Encounter at Amon Dîn");
            setNamesByGuid.Add("fd89bdbf-7475-4f3e-96fc-8f5315a94000", "Assault on Osgiliath");
            setNamesByGuid.Add("fdef61cd-62ab-448a-bcf1-eb0b3d1d8edf", "The Blood of Gondor");
            setNamesByGuid.Add("4dd22911-a412-4d78-b5ae-6714c3342e9d", "The Morgul Vale");
            setNamesByGuid.Add("424cad9d-8552-4a76-aad1-46cad23903a8", "Voice of Isengard");
            setNamesByGuid.Add("ffa87013-5112-4571-8f23-4736e3005621", "The Dunland Trap");
            setNamesByGuid.Add("8da6cd8d-b3b8-48dd-95c3-68d3c4a29144", "The Three Trials");
            setNamesByGuid.Add("a7a8082e-9338-4fcc-af5c-3b2c9f9ccc90", "Trouble in Tharbad");
            setNamesByGuid.Add("b51f1056-c806-41b0-b89c-d9e37123ece0", "The Nîn-in-Eilph");
            setNamesByGuid.Add("44d751a2-8ec1-4928-aee2-41632b378e52", "Celebrimbor's Secret");
            setNamesByGuid.Add("fc19e7a8-54b3-4974-b670-52677bc492f7", "The Antlered Crown");
            setNamesByGuid.Add("159e44b5-8e8d-4ae9-9a25-7297e9967ce3", "The Lost Realm");
            setNamesByGuid.Add("b651805f-c7d1-4a19-af65-b368d446e5d5", "The Wastes of Eriador");
            setNamesByGuid.Add("c85005b4-44ad-4d64-adf1-49935a1bfb09", "Escape from Mount Gram");
            setNamesByGuid.Add("14e08670-f2ca-419e-a260-ca3570528224", "Across the Ettenmoors");
            setNamesByGuid.Add("3d1f5de7-e04d-4efb-99f7-96a2087c9459", "The Treachery of Rhudaur");
            setNamesByGuid.Add("51223bd0-ffd1-11df-a976-1801202c9000", "The Massing at Osgiliath");
            setNamesByGuid.Add("51223bd0-ffd1-11df-a976-1801203c9000", "The Battle of Lake-Town");
            setNamesByGuid.Add("4f22640f-ac14-4af3-8d94-c37adbb39703", "The Stone of Erech");
            setNamesByGuid.Add("32607cde-a499-48cb-b665-d91f9686020b", "The Old Forest");
            setNamesByGuid.Add("a0cb27b2-e62f-4fb4-ba98-7647ac6f81a4", "Fog on the Barrow-downs");
            setNamesByGuid.Add("5ed09135-3bac-49b6-b11f-1c59ea09268f", "The Ruins of Belegost");
            setNamesByGuid.Add("e84f94bf-201b-4adf-95d2-0012e0bb5000", "Core Set - Nightmare");
            //setNamesByGuid.Add("e84f94bf-201b-4adf-95d2-0012e0bb5100","Shadows of Mirkwood - Nightmare"); 
            setNamesByGuid.Add("940c6213-1cec-4116-b668-a6f3cda1fb98", "Khazad-dum - Nightmare");
            setNamesByGuid.Add("639c5e22-403f-45f8-90b9-0a2913a8926f", "Dwarrowdelf - Nightmare");
            setNamesByGuid.Add("fe61abff-2f64-4d14-b93e-8756280c7fd0", "The Hobbit - Over Hill and Under Hill - Nightmare");
            setNamesByGuid.Add("14523a71-dc30-46b1-a727-28ff5ecbcbaa", "The Hobbit - On the Doorstep - Nightmare");
            setNamesByGuid.Add("4bb66f68-a4b5-4226-8d64-de74bf2ac793", "Heirs of Númenor - Nightmare");
            setNamesByGuid.Add("ad480f8c-3505-4f59-b19a-aa474bba25dc", "Against the Shadow - Nightmare");
            setNamesByGuid.Add("f7c01338-9090-4367-830c-504830d7e257", "The Black Riders - Nightmare");
            setNamesByGuid.Add("51223bd0-ffd1-11df-a976-1801204c9000", "The Hobbit - Over Hill and Under Hill");
            setNamesByGuid.Add("1490fecb-d07e-48e0-96fe-46260fa17f19", "The Hobbit - On the Doorstep");
            setNamesByGuid.Add("b5a36fbd-c194-47f0-9e81-0fb71aecda31", "The Black Riders");
            setNamesByGuid.Add("a18ab620-936a-4c5e-acdb-5e28f998439a", "The Road Darkens ");
            setNamesByGuid.Add("760802ec-5ce2-4867-aa66-51a65bb5d372", "The Treason of Saruman");
            setNamesByGuid.Add("3f4acb38-f3b5-4263-9f6f-41c38aaf8a38", "The Land of Shadow");

            foreach (var pair in setNamesByGuid)
            {
                guidsBySetName.Add(pair.Value, pair.Key);
            }
        }

        public string GetOctgnCardGuid(string slug)
        {
            return string.Empty;
        }

        public string GetCardSlug(string octgnGuid)
        {
            return string.Empty;
        }

        public string GetOctgnSetGuid(string setName)
        {
            return guidsBySetName.ContainsKey(setName) ? guidsBySetName[setName] : string.Empty;
        }

        public string GetSetName(string octgnGuid)
        {
            return setNamesByGuid.ContainsKey(octgnGuid) ? setNamesByGuid[octgnGuid] : string.Empty;
        }
    }
}