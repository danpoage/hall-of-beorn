using HallOfBeorn.Models.LotR;
using HallOfBeorn.Models.LotR.ViewModels;

namespace HallOfBeorn.Services.LotR.Search
{
    public interface IPlanService
    {
        Plan CreatePlan(SearchViewModel model, UserSettings settings);
    }
}
