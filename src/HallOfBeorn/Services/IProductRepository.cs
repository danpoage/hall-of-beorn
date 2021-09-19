using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using HallOfBeorn.Models;

namespace HallOfBeorn.Services
{
    public interface IProductRepository<TGroup, TProduct, TCardSet, TCard>
        where TGroup: IProductGroup<TProduct, TCardSet, TCard>
        where TProduct: IProduct<TProduct, TCardSet, TCard>
        where TCardSet : ICardSet<TProduct, TCard>
        where TCard : ICard
    {
        IEnumerable<TGroup> ProductGroups();
        IEnumerable<TProduct> Products();
        IEnumerable<TCardSet> CardSets();
        IEnumerable<string> TraitLabels(string trait, Func<TCard, bool> filter);
    }
}
