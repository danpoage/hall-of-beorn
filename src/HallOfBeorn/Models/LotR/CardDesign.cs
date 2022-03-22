using System;
using System.Collections.Generic;
using System.Linq;

namespace HallOfBeorn.Models.LotR
{
    public class CardDesign
    {
        public CardDesign(IEnumerable<LotRCard> versions,
            Language lang,
            Func<string, Language, string> getTitle,
            Func<string, bool, Language, string> getTemplate)
        {
            if (versions == null || versions.Count() == 0)
            {
                throw new ArgumentException("versions empty");
            }

            foreach (var version in versions)
            {
                if (!this.versions.ContainsKey(version.Slug))
                {
                    this.versions.Add(version.Slug, version);
                }
            }

            First = Versions.First();
            Title = getTitle(First.Title, lang);
            IsUnique = First.IsUnique;
            NormalizedTitle = Title.NormalizeCaseSensitiveString();
            FrontText = First.Text;
            FrontHtml = getTemplate(First.Slug, true, lang);
            BackText = First.OppositeText;
            BackHtml = getTemplate(First.Slug, false, lang);
            Sphere = First.Sphere;
            CardType = First.CardType;
            CardSubtype = First.CardSubtype;
            ThreatCost = First.ThreatCost;
            ResourceCost = First.ResourceCost;
            EngagementCost = First.EngagementCost;
            Threat = First.Threat;
            Willpower = First.Willpower;
            Attack = First.Attack;
            Defense = First.Defense;
            HitPoints = First.HitPoints;
            QuestPoints = First.QuestPoints;
            StageNumber = First.StageNumber;

            HasErrata = First.HasErrata;
            Traits = First.Traits;
            Keywords = First.Keywords;
        }

        private readonly Dictionary<string, LotRCard> versions = new Dictionary<string, LotRCard>();

        public static string GetSlug(LotRCard card)
        {
            var title = card.NormalizedTitle.ToUrlSafeString();

            var qualifier = string.Empty;
            if (card.CardType == CardType.Hero || (card.Sphere != Sphere.None && card.Sphere != Sphere.Neutral))
            {
                qualifier = Enum.GetName(typeof(Sphere), card.Sphere);
            }
            else
            {
                if (card.CardSet.SetType == SetType.Saga_Expansion)
                {
                    qualifier = "Saga";
                }
                else if (card.CardSet.SetType == SetType.Custom_Scenario_Kit)
                {
                    qualifier = "Kit";
                }
            }

            var type = Enum.GetName(typeof(CardType), card.CardType);

            return !string.IsNullOrEmpty(qualifier)
                ? string.Format("{0}-{1}-{2}", title, qualifier, type)
                : string.Format("{0}-{1}", title, type);
        }

        public string Slug { get { return GetSlug(First); } }

        public IEnumerable<LotRCard> Versions
        { 
            get { return versions.Values.OrderBy(ver => ver.CardSet.Product.FirstReleased); } 
        }

        public LotRCard First { get; private set; }

        public string Title { get; private set; }
        public bool IsUnique { get; private set; }
        public string NormalizedTitle { get; private set; }
        public string FrontText { get; private set; }
        public string FrontHtml { get; private set; }
        public string BackText { get; private set; }
        public string BackHtml { get; private set; }

        public Sphere Sphere { get; private set; }
        public CardType CardType { get; private set; }
        public CardSubtype CardSubtype { get; private set; }
        public byte? Threat { get; private set; }
        public byte? ThreatCost { get; private set; }
        public byte? ResourceCost { get; private set; }
        public byte? EngagementCost { get; private set; }
        public byte? Willpower { get; private set; }
        public byte? Attack { get; private set; }
        public byte? Defense { get; private set; }
        public byte? HitPoints { get; private set; }
        public byte? QuestPoints { get; private set; }
        public uint StageNumber { get; private set; }

        public bool HasErrata { get; private set; }
        public IEnumerable<string> Traits { get; private set; }
        public IEnumerable<string> Keywords { get; private set; }

        public bool IncludesVersion(string slug)
        {
            return versions.ContainsKey(slug);
        }
    }
}