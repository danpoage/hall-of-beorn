using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using HallOfBeorn.Models.LotR;
using HallOfBeorn.Models.LotR.ViewModels;

namespace HallOfBeorn.Services.LotR
{
    public class SearchService2
    {
        public IEnumerable<CardScore> Search(SearchViewModel model)
        {
            var scores = new List<CardScore>();

            return scores;
        }
    }
}