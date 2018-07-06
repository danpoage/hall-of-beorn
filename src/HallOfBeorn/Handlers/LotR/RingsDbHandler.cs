using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using HallOfBeorn.Models.LotR;
using HallOfBeorn.Models.RingsDb;
using HallOfBeorn.Services.LotR.RingsDb;

namespace HallOfBeorn.Handlers.LotR
{
    public class RingsDbHandler
    {
        public RingsDbHandler(IRingsDbService ringsDbService)
        {
            _ringsDbService = ringsDbService;
        }

        private readonly IRingsDbService _ringsDbService;

        public object HandleRingsDbTopDecks(string slug)
        {
            var cardId = _ringsDbService.GetCardId(slug);

            var decks = new List<RingsDbDeck>();

            uint parsedId = 0;
            if (!uint.TryParse(cardId, out parsedId))
            {
                return decks;
            }

            using (var client = new System.Net.Http.HttpClient())
            {
                var url = "http://ringsdb.com/api/public/decklists/top_by_card/" + cardId + ".json";
                var response = client.GetAsync(url).Result;

                if (response.IsSuccessStatusCode)
                {
                    var responseContent = response.Content;
                    string responseString = responseContent.ReadAsStringAsync().Result;

                    decks = Newtonsoft.Json.JsonConvert.DeserializeObject<List<RingsDbDeck>>(responseString);

                    //Normalize the URL in each deck
                    foreach (var deck in decks)
                    {
                        deck.url = "http://ringsdb.com" + deck.url;
                    }
                }
            }

            return decks;
        }
    }
}