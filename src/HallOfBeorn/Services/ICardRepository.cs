using System;
using System.Collections.Generic;
using HallOfBeorn.Models;

namespace HallOfBeorn.Services
{
    public interface ICardRepository<TCard>
        where TCard: ICard
    {
        IEnumerable<TCard> Cards();
        TCard FindBySlug(string slug);
    }
}
