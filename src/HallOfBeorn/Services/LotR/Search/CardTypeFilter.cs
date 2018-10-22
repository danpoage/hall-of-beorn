using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using HallOfBeorn.Models.LotR;

namespace HallOfBeorn.Services.LotR.Search
{
    public class CardTypeFilter : Filter
    {
        public CardTypeFilter(CardType? target)
        {
            if (!target.HasValue)
                return;

            predicate = (score) =>
            {
                return HasCardType(score.Card, target.Value);
            };
        }

        public CardTypeFilter(string value, bool isNegation)
        {
            var values = GetEnumValues<CardType>(value);

            if (values.Count() == 0)
                return;

            predicate = (score) =>
            {
                return isNegation ?
                    values.All(v => !HasCardType(score.Card, v))
                    : values.Any(v => HasCardType(score.Card, v));
            };
        }

        private static bool HasCardType(LotRCard card, CardType type)
        {
            if (type == Models.LotR.CardType.Player)
            {
                    return card.CardType == Models.LotR.CardType.Hero || card.CardType == Models.LotR.CardType.Ally || card.CardType == Models.LotR.CardType.Attachment || card.CardType == Models.LotR.CardType.Event || card.CardType == Models.LotR.CardType.Player_Side_Quest;
            }
            else if (type == Models.LotR.CardType.Character)
            {
                return card.CardType == Models.LotR.CardType.Hero || card.CardType == Models.LotR.CardType.Ally || card.CardType == Models.LotR.CardType.Objective_Ally || (card.CardType == Models.LotR.CardType.Objective && card.HitPoints > 0);
            }
            else if (type == Models.LotR.CardType.Encounter)
            {
                return card.CardType == Models.LotR.CardType.Enemy || card.CardType == Models.LotR.CardType.Location || card.CardType == Models.LotR.CardType.Treachery || card.CardType == Models.LotR.CardType.Objective || card.CardType == Models.LotR.CardType.Objective_Hero || card.CardType == Models.LotR.CardType.Objective_Ally || card.CardType == Models.LotR.CardType.Objective_Location || card.CardType == Models.LotR.CardType.Encounter_Side_Quest || card.CardType == Models.LotR.CardType.Ship_Objective || card.CardType == Models.LotR.CardType.Ship_Enemy;
            }
            else if (type == Models.LotR.CardType.Objective)
            {
                return card.CardType == Models.LotR.CardType.Objective || card.CardType == Models.LotR.CardType.Objective_Ally;
            }
            else if (type == Models.LotR.CardType.Setup)
            {
                return card.CardType == Models.LotR.CardType.Nightmare_Setup || card.CardType == Models.LotR.CardType.GenCon_Setup || card.CardType == Models.LotR.CardType.Campaign || card.CardType == Models.LotR.CardType.Scenario;
            }
            else
            {
                return card.CardType == type;
            }
        }
    }
}