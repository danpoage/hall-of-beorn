using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HallOfBeorn.Models
{
    public interface IProduct<TCard> : INamed
        where TCard : ICard
    {
        string Code { get; }
    }

    public interface IProduct<TProduct, TCardSet, TCard> : IProduct<TCard>, ILabeled
        where TProduct: IProduct<TCard>
        where TCardSet: ICardSet<TProduct, TCard>
        where TCard: ICard
    {
        IEnumerable<TCardSet> CardSets { get; }
    }
}
