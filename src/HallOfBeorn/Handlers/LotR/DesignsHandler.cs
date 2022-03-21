using System;
using System.Collections.Generic;
using System.Linq;
using HallOfBeorn.Models;
using HallOfBeorn.Models.LotR;
using HallOfBeorn.Models.LotR.ViewModels;
using HallOfBeorn.Services.LotR.Design;
using HallOfBeorn.Services.LotR.Tags;

namespace HallOfBeorn.Handlers.LotR
{
    public class DesignsHandler
    {
        public DesignsHandler(ICardDesignService designService, INoteService noteService)
        {
            this.designService = designService;
            this.noteService = noteService;
        }

        private readonly ICardDesignService designService;
        private readonly INoteService noteService;

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

                return model;
            }

            return null;
        }
    }
}