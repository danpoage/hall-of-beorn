using HallOfBeorn.Models.LotR;
using HallOfBeorn.Models.LotR.ViewModels;

namespace HallOfBeorn.Handlers.LotR
{
    public interface ISearchViewHandler
    {
        void HandleSearch(SearchViewModel model, UserSettings settings);
    }
}
