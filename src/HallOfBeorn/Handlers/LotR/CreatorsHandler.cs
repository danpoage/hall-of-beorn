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
        private readonly IContentSourceService sourceService = new ContentSourceService();

        public ContentSourceViewModel HandleCreators(string id)
        {
            if (string.IsNullOrEmpty(id))
            {
                return new ContentSourceViewModel(sourceService.AllContentSources());
            }

            var source = sourceService.GetContentSource(id);

            return source != null
                ? new ContentSourceViewModel(source)
                : null;
        }
    }
}