using System;
using System.Collections.Generic;
using System.Linq;
using HallOfBeorn.Models;
using HallOfBeorn.Models.LotR;
using HallOfBeorn.Models.LotR.ViewModels;
using HallOfBeorn.Services.LotR.Design;
using HallOfBeorn.Services.LotR.Links;
using HallOfBeorn.Services.LotR.Tags;

namespace HallOfBeorn.Handlers.LotR
{
    public class DesignsHandler
    {
        public DesignsHandler(
            ICardDesignService designService, INoteService noteService, ITagService tagService, ILinkService linkService)
        {
            this.designService = designService;
            this.noteService = noteService;
            this.tagService = tagService;
            this.linkService = linkService;
        }

        private readonly ICardDesignService designService;
        private readonly INoteService noteService;
        private readonly ITagService tagService;
        private readonly ILinkService linkService;

        public CardDesignViewModel HandleDesigns(string slug, Language lang)
        {
            var design = designService.Lookup(slug, lang);

            if (design != null)
            {
                var model = new CardDesignViewModel(design, lang);

                if (model.HasErrata)
                {
                    var notes = noteService.Notes(model.OriginalVersionSlug);
                    model.LoadNotes(notes);
                }

                var tags = tagService.GetTags(model.OriginalVersionSlug);
                model.LoadTags(tags);

                var links = linkService.GetLinks(model.OriginalVersionSlug);
                model.LoadContentLinks(links);

                return model;
            }

            return null;
        }
    }
}