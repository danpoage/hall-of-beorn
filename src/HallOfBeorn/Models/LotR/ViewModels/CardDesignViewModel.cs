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

        public LotRCard First { get { return design.First; } }
        public Language Lang { get; private set; }
        public string Title { get { return design.Title; } }
        public string OppositeTitle { get { return design.First.OppositeTitle; } }
        public bool IsUnique { get { return design.IsUnique; } }
        public bool HasErrata { get { return design.HasErrata; } }
        public string Slug { get { return design.Slug; } }
        public string OriginalVersionSlug { get { return design.First.Slug; } }
        public string DetailsLink { get { return string.Format("/LotR/Designs/{0}", design.Slug); } }

        public bool HasSphere { get { return design.Sphere != LotR.Sphere.None && design.Sphere != LotR.Sphere.Neutral; } }
        public string Sphere { get { return design.Sphere.ToString(); } }
        public CardType CardType { get { return design.CardType; } }
        public string CardTypeName { get { return design.CardType.ToCardTypeDescription(); } }
        public string CardSubtype { get { return design.CardSubtype != Models.CardSubtype.None ? design.CardSubtype.ToString() : null; } }

        public bool HasCharacterStats { 
            get { return design.Willpower > 0 || design.Attack > 0 || design.Defense > 0 || design.HitPoints > 0; }
        }

        public string ThreatCost { get { return design.ThreatCost.ToEnumDisplayString(); } }
        public string ResourceCost { get { return design.ResourceCost.ToEnumDisplayString(); } }
        public string EngagementCost { get { return design.EngagementCost.ToEnumDisplayString(); } }
        public string Willpower { get { return design.Willpower.ToEnumDisplayString(); } }
        public string Threat { get { return design.Threat.ToEnumDisplayString(); } }
        public string Attack { get { return design.Attack.ToEnumDisplayString(); } }
        public string Defense { get { return design.Defense.ToEnumDisplayString(); } }
        public string HitPoints { get { return design.HitPoints.ToEnumDisplayString(); } }
        public string QuestPoints { get { return design.QuestPoints.ToEnumDisplayString(); } }
        
        public string StageNumber { get { return design.StageNumber.ToString(); } }
        public string StageLetters
        {
            get
            {
                var from = design.First.StageLetter;
                var to = GetSecondStageLetter();

                return string.Format("{0}-{1}", from, to);
            }
        }

        public char GetSecondStageLetter()
        {
            return getSecondStageLetter(design.First);
        }

        private static char getSecondStageLetter(LotRCard card)
        {
            return card.BackStageLetter.HasValue ? card.BackStageLetter.Value : (Char)(Convert.ToUInt16(card.StageLetter) + 1);
        }

        public IEnumerable<string> Traits { get { return design.Traits; } }
        public IEnumerable<string> Keywords { get { return design.Keywords; } }

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

        private readonly List<CardTag> tags = new List<CardTag>();

        public bool HasTags()
        {
            return tags.Count > 0;
        }

        public IEnumerable<CardTag> Tags()
        {
            return tags;
        }

        public void LoadTags(IEnumerable<CardTag> tags)
        {
            foreach (var tag in tags)
            {
                this.tags.Add(tag);
            }
        }

        private readonly List<LinkViewModel> contentLinks = new List<LinkViewModel>();

        public IEnumerable<LinkViewModel> ContentLinks
        {
            get { return contentLinks; }
        }

        public void LoadContentLinks(IEnumerable<ILink> links)
        {
            foreach (var link in links)
            {
                contentLinks.Add(new LinkViewModel(link));
            }
        }

        public bool HasContentLinks()
        {
            return contentLinks.Count > 0;
        }
    }
}