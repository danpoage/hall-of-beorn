using System;
using System.Collections.Generic;
using System.Linq;

namespace HallOfBeorn.Models.LotR
{
    public class CardDesign
    {
        public CardDesign(IEnumerable<LotRCard> versions, Func<string, bool, string> getTemplate)
        {
            if (versions == null || versions.Count() == 0)
            {
                throw new ArgumentException("versions empty");
            }

            this.versions.AddRange(versions);

            First = versions.First();
            Title = First.Title;
            NormalizedTitle = First.NormalizedTitle;
            FrontText = First.Text;
            FrontHtml = getTemplate(First.Slug, true);
            BackText = First.OppositeText;
            BackHtml = getTemplate(First.Slug, false);
            Sphere = First.Sphere;
            CardType = First.CardType;
            CardSubtype = First.CardSubtype;
            ThreatCost = First.ThreatCost;
            ResourceCost = First.ResourceCost;
            Willpower = First.Willpower;
            Attack = First.Attack;
            Defense = First.Defense;
            HitPoints = First.HitPoints;
            HasErrata = First.HasErrata;
            Traits = First.Traits;
            Keywords = First.Keywords;
        }

        private readonly List<LotRCard> versions = new List<LotRCard>();

        public static string GetSlug(LotRCard card)
        {
            return string.Format("{0}-{1}-{2}", 
                    card.NormalizedTitle.ToUrlSafeString(), 
                    Enum.GetName(typeof(Sphere), card.Sphere), 
                    Enum.GetName(typeof(CardType), card.CardType));
        }

        public string Slug { get { return GetSlug(First); } }
        public IEnumerable<LotRCard> Versions { get { return versions; } }
        public LotRCard First { get; private set; }

        public string Title { get; private set; }
        public string NormalizedTitle { get; private set; }
        public string FrontText { get; private set; }
        public string FrontHtml { get; private set; }
        public string BackText { get; private set; }
        public string BackHtml { get; private set; }
        public Sphere Sphere { get; private set; }
        public CardType CardType { get; private set; }
        public CardSubtype CardSubtype { get; private set; }
        public byte? ThreatCost { get; private set; }
        public byte? ResourceCost { get; private set; }
        public byte? Willpower { get; private set; }
        public byte? Attack { get; private set; }
        public byte? Defense { get; private set; }
        public byte? HitPoints { get; private set; }
        public bool HasErrata { get; private set; }
        public IEnumerable<string> Traits { get; private set; }
        public IEnumerable<string> Keywords { get; private set; }
    }
}