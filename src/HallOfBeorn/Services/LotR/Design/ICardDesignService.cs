using System;
using System.Collections.Generic;
using HallOfBeorn.Models;
using HallOfBeorn.Models.LotR;

namespace HallOfBeorn.Services.LotR.Design
{
    public interface ICardDesignService
    {
        CardDesign Lookup(string slug, Language lang);
        IEnumerable<CardDesign> Designs(Language lang);
        IEnumerable<CardDesign> WithVersions(IEnumerable<LotRCard> cards, Language lang);
    }
}