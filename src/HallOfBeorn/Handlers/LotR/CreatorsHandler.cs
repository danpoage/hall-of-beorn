using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

using HallOfBeorn.Models.LotR.ViewModels;
using HallOfBeorn.Services.LotR.Community;

namespace HallOfBeorn.Handlers.LotR
{
    public class CreatorsHandler
    {
        public CreatorsHandler(ICreatorService creatorService)
        {
            this.creatorService = creatorService;
        }

        private readonly ICreatorService creatorService;

        public CreatorViewModel HandleCreators(string id)
        {
            if (string.IsNullOrEmpty(id))
            {
                return new CreatorViewModel(
                    creatorService.Podcasts(), 
                    creatorService.Blogs(),
                    creatorService.Channels());
            }

            var creator = creatorService.GetCreator(id);

            return creator != null
                ? new CreatorViewModel(creator)
                : null;
        }
    }
}
