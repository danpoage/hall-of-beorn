using System;
using System.Collections.Generic;
using System.Linq;
using HallOfBeorn.Models;
using HallOfBeorn.Models.LotR;

namespace HallOfBeorn.Models.LotR.ViewModels
{
    public class CardDesignViewModel
    {
        public CardDesignViewModel(
            CardDesign design, Language lang)
        {
            this.design = design;
            Lang = lang;

            Image = new CardImageViewModel(design.First, Lang);

            FrontHtml = new TextTemplate(design.First).RenderFrontHtml(lang);
            BackHtml = new TextTemplate(design.First).RenderBackHtml(lang);

            foreach (var version in design.Versions)
            {
                this.versions.Add(new CardVersionViewModel(version, Lang));
            }
        }

        private readonly CardDesign design;
        private readonly List<CardVersionViewModel> versions = new List<CardVersionViewModel>();
        
        public Language Lang { get; private set; }
        public string Title { get { return design.Title; } }
        public string OppositeTitle { get { return design.First.OppositeTitle; } }
        public bool IsUnique { get { return design.IsUnique; } }
        public bool HasErrata { get { return design.HasErrata; } }
        public string Slug { get { return design.Slug; } }
        public string OriginalVersionSlug { get { return design.First.Slug; } }
        public string DetailsLink { get { return string.Format("/LotR/Designs/{0}", design.Slug); } }
        public string Sphere { get { return design.Sphere.ToString(); } }
        public string CardType { get { return design.CardType.ToCardTypeDescription(); } }
        public string CardSubtype { get { return design.CardSubtype != Models.CardSubtype.None ? design.CardSubtype.ToString() : null; } }

        public string FrontHtml { get; private set; }
        public string BackHtml { get; private set; }

        public IEnumerable<CardVersionViewModel> Versions
        {
            get { return versions.OrderBy(ver => ver.Year); }
        }

        public CardImageViewModel Image { get; private set; }

        private readonly List<CardNote> notes = new List<CardNote>();

        public IEnumerable<CardNote> Notes()
        {
            return notes;
        }

        public void LoadNotes(IEnumerable<CardNote> notes)
        {
            foreach (var note in notes)
            {
                this.notes.Add(note);
            }
        }
    }
}