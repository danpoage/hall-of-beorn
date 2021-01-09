using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using HallOfBeorn.Models.LotR;
using HallOfBeorn.Models.LotR.ViewModels;

namespace HallOfBeorn.Services.LotR.Search
{
    public interface ISearchService
    {
        IOrderedEnumerable<CardScore> Search(SearchViewModel model, UserSettings settings);
    }
}
