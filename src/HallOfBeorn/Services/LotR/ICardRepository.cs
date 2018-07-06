using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using HallOfBeorn.Models.LotR;

namespace HallOfBeorn.Services.LotR
{
    public interface ICardRepository
    {
        IEnumerable<LotRCard> Cards();
        LotRCard Find(string id);
        LotRCard FindBySlug(string slug);
    }
}
