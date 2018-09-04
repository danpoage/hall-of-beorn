using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using HallOfBeorn.Models.Digital;
using HallOfBeorn.Services;

namespace HallOfBeorn.Services.Digital
{
    public class DigitalCardRepository : 
        CardRepository<DigitalProductRepository, DigitalProductGroup, DigitalProduct, DigitalCardSet, DigitalCard>
    {
        public DigitalCardRepository(DigitalProductRepository productRepository)
            : base(productRepository)
        {
        }
    }
}