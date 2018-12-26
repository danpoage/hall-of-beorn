using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using HallOfBeorn.Models.LotR;
using HallOfBeorn.Services.LotR;
using HallOfBeorn.Services.LotR.Octgn;

namespace OctgnBuilder
{
    public class OctgnHelper
    {
        public OctgnHelper()
        {
            _cardRepository = new LotRCardRepository(new ProductRepository());
        }

        private readonly LotRCardRepository _cardRepository;

        public LotRCard FindPlayerCard(string setName, string title)
        {
            return _cardRepository.OfficialPlayerCards()
                .Where(card => card.CardSet.Name == setName && card.Title == title)
                .FirstOrDefault();
        }
    }
}
