using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using HallOfBeorn.Services.LotR;
using HallOfBeorn.Services.LotR.RingsDb;

namespace RingsDbBuilder
{
    public class RingsDbHelper
    {
        public RingsDbHelper()
        {
            _productRepository = new ProductRepository();
            _cardRepository = new LotRCardRepository(_productRepository);
            _ringsDbService = new RingsDbService(_cardRepository);
        }

        private readonly ProductRepository _productRepository;
        private readonly LotRCardRepository _cardRepository;
        private readonly RingsDbService _ringsDbService;
            
        public string GetSlug(string cardId)
        {
            return _ringsDbService.GetSlug(cardId);
        }
    }
}
