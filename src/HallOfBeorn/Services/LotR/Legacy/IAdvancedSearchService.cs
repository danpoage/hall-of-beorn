using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using HallOfBeorn.Models.LotR;
using HallOfBeorn.Models.LotR.ViewModels;

namespace HallOfBeorn.Services.LotR.Search
{
    [Obsolete]
    public interface IAdvancedSearchService
    {
        List<CardScore> Search(SearchViewModel searchModel, List<CardScore> results);
    }
}
