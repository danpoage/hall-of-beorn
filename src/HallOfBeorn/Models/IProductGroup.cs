using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HallOfBeorn.Models
{
    public interface IProductGroup<TProduct, TCardSet, TCard> : INamed
        where TProduct: IProduct<TProduct, TCardSet, TCard>
        where TCardSet: ICardSet<TProduct, TCard>
        where TCard : ICard
    {
        IEnumerable<TProduct> MainProducts { get; }
        IEnumerable<TProduct> ChildProducts { get; }
    }
}
