namespace HallOfBeorn.Models.LotR
{
    public static class Extensions
    {
        private static readonly HashSet<CardType> objectiveCardTypes 
          = new HashSet<CardType> {
          CardType.Objective,
          CardType.Objective_Ally,
          CardType.Objective_Hero,
          CardType.Objective_Location,
        };

        public static bool HasTrait(this LotRCard self, string trait)
        {
            return self != null && self.Traits.Any(t => t == trait);
        }

        public static bool IsPlayerCard(this LotRCard self)
        {
            return self != null && self.CardType.IsPlayerCard();
        }

        public static bool IsObjective(this LotRCard self)
        {
            return self != null && objectiveCardTypes.Contains(self.Type);
        }

        public static bool HasText(this LotRCard self, string text)
        {
            return self.Text.ContainsLower(text)
                || self.OppositeText.ContainsLower(text);
        }

        public static ILink ToCharacterLink(this LotRCard self)
        {
            var description = self.Sphere.ToSlug() + " " + self.CardType.ToSlug();
            var title = string.Format("{0} ({1})", self.Title, description.Trim());

            return new Link(LinkType.Hall_of_Beorn_LotR_Image, card, title);
        }

        public static string ToSlug(this Sphere self)
        {
            return self != Sphere.None ? self.ToString() : string.Empty;
        }

        public static string ToSlug(this CardType self)
        {
            return self.CardType.ToString().Replace("_", "-");
        }

        public static int ImportanceScore(this LotRCard self)
        {
            if (self == null)
                return 0;

            var count = 0;
            if (self.CardType.IsPlayerCard())
                count += 1;

            if (self.IsUnique)
                count += 2;

            if (self.CardType == CardType.Hero)
                count += 8;

            if (self.CardType == CardType.Ally)
                count += 5;

            if (self.CardType == CardType.Attachment 
                || card.CardType == CardType.Player_Side_Quest)
                count += 3;

            if (self.CardType == CardType.Event)
                count += 2;

            if (self.IsObjective())
                count += 2;

            if (self.CardType == CardType.Objective_Ally)
                count += 3;

            return count;
        }
    }
}
