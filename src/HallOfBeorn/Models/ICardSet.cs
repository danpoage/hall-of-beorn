using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HallOfBeorn.Models
{
    public interface ICardSet<TProduct, TCard> : INamed, ILabeled
        where TProduct: IProduct<TCard>
        where TCard: ICard
    {
        string Slug { get; }
        bool IsSpoiler { get; }

        TProduct Product { get; set; }
        List<TCard> Cards { get; }
    }
}
