using System;
using System.Collections.Generic;
using HallOfBeorn.Models;
using HallOfBeorn.Models.LotR;

namespace HallOfBeorn.Services.LotR.Design
{
    public interface ICardDesignService
    {
        IEnumerable<CardDesign> All(Language lang);
        IEnumerable<CardDesign> ForCards(IEnumerable<LotRCard> cards, Language lang);
    }
}