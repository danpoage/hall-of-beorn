using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using HallOfBeorn.Models.LotR;

namespace HallOfBeorn.Services.LotR.Categories
{
    public class QuestCategoryService : CategoryServiceBase<QuestCategory>
    {
        public QuestCategoryService(CardRepository cardRepository)
            : base(cardRepository)
        {
        }

        private Func<LotRCard, QuestCategory> CreateQuestCategoryFilter(string pattern, QuestCategory category)
        {
            return CreateQuestCategoryFilter(pattern, category, null);
        }

        private Func<LotRCard, QuestCategory> CreateQuestCategoryFilter(string pattern, QuestCategory category, params string[] negations)
        {
            Func<LotRCard, QuestCategory> filter = (card) =>
            {
                if (card.Keywords.Any(x => x.Contains(pattern)))
                {
                    return category;
                }

                foreach (var line in card.Text.Split(new string[] { "\r\n" }, StringSplitOptions.RemoveEmptyEntries))
                {
                    if (line.MatchesPattern(pattern))
                    {
                        if (negations == null || negations.Length == 0 || !negations.Any(x => line.ToLowerSafe().Contains(x.ToLowerSafe())))
                            return category;
                    }
                }

                return QuestCategory.None;
            };

            return filter;
        }

        private Func<LotRCard, QuestCategory> CreateQuestCategoryFilter(Predicate<LotRCard> filter, QuestCategory category)
        {
            return CreateQuestCategoryFilter(filter, category, new string[0]);
        }

        private Func<LotRCard, QuestCategory> CreateQuestCategoryFilter(Predicate<LotRCard> filter, QuestCategory category, params string[] negations)
        {
            if (negations.Length == 0)
            {
                return new Func<LotRCard, QuestCategory>(x => { return filter(x) ? category : QuestCategory.None; });
            }
            else
            {
                return new Func<LotRCard, QuestCategory>(x => { return filter(x) && !textContains(x, negations) ? category : QuestCategory.None; });
            }
        }

        protected override bool IsCategorizable(LotRCard card)
        {
            switch (card.CardType)
            {
                case CardType.Quest:
                case CardType.Campaign:
                case CardType.GenCon_Setup:
                case CardType.Nightmare_Setup:
                    return true;
                default:
                    return false;
            }
        }

        protected override List<Func<LotRCard, QuestCategory>> GetCategoryFilters()
        {
            return new List<Func<LotRCard, QuestCategory>>
            {
                CreateQuestCategoryFilter("Battle", QuestCategory.Battle),
                CreateQuestCategoryFilter("Siege", QuestCategory.Siege),
                CreateQuestCategoryFilter(x => { return (x.CardType == CardType.Quest && x.StageNumber == 1 && x.TextMatches("Setup:")); }, QuestCategory.Setup),
                CreateQuestCategoryFilter(x => { return (x.CardType == CardType.Quest && x.QuestPoints.IsX()); }, QuestCategory.Variable_Length),
                CreateQuestCategoryFilter(x => { return (x.CardType == CardType.Quest && (x.QuestPoints.IsNA() || x.QuestPoints == 0 || x.TextMatches("cannot advance"))); }, QuestCategory.Alternate_Progression),
                CreateQuestCategoryFilter(x => { return (x.CardType == CardType.Quest && x.TextMatches("(lose|lost) the game")); }, QuestCategory.Alternate_Defeat),
                CreateQuestCategoryFilter(x => { return (x.CardType == CardType.Quest && x.TextMatches("(win this|won the) game")); }, QuestCategory.Alternate_Victory, "crossed the Anduin"),
                CreateQuestCategoryFilter(x => { return (x.CardType == CardType.Quest && x.TextMatches("random stage")); }, QuestCategory.Wandering),
                CreateQuestCategoryFilter(x => { return (x.CardType == CardType.Quest && x.StageNumber == 1 && x.TextMatches("skip")); }, QuestCategory.Free),
                CreateQuestCategoryFilter(x => { return (x.CardType == CardType.Quest && x.QuestPoints >= 1 && x.QuestPoints <= 5); }, QuestCategory.Short),
                CreateQuestCategoryFilter(x => { return (x.CardType == CardType.Quest && x.QuestPoints >= 6 && x.QuestPoints <= 10); }, QuestCategory.Medium),
                CreateQuestCategoryFilter(x => { return (x.CardType == CardType.Quest && x.QuestPoints >= 11 && x.QuestPoints <= 15); }, QuestCategory.Long),
                CreateQuestCategoryFilter(x => { return (x.CardType == CardType.Quest && x.QuestPoints >= 16 && x.QuestPoints <= 253); }, QuestCategory.Extra_Long)
            };
        }
    }
}