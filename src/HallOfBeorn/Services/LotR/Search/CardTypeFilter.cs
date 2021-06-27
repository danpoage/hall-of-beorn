using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using HallOfBeorn.Models.LotR;

namespace HallOfBeorn.Services.LotR.Search
{
    public class CardTypeFilter : Filter
    {
        public CardTypeFilter(string target)
        {
            if (string.IsNullOrEmpty(target))
                return;

            CardType parsedType;
            if (!Enum.TryParse<CardType>(target.Replace(" ", "_").Replace("-", "_"), out parsedType))
            {
                return;
            }

            predicate = (score) =>
            {
                return HasCardType(score.Card, parsedType);
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

        private static HashSet<CardType> playerCardTypes = new HashSet<CardType>
        {
            CardType.Hero, CardType.Ally, CardType.Attachment, CardType.Event, CardType.Player_Side_Quest, CardType.Contract, CardType.Treasure
        };

        private static HashSet<CardType> characterCardTypes = new HashSet<CardType>
        {
            CardType.Hero, CardType.Ally, CardType.Objective_Hero, CardType.Objective_Ally,
        };

        private static HashSet<CardType> encounterCardTypes = new HashSet<CardType>
        {
            CardType.Enemy, CardType.Ship_Enemy, CardType.Location, CardType.Treachery, CardType.Encounter_Side_Quest,
            CardType.Objective, CardType.Objective_Hero, CardType.Objective_Ally, CardType.Objective_Location, CardType.Ship_Objective,
        };

        private static HashSet<CardType> objectiveCardTypes = new HashSet<CardType>
        {
            CardType.Objective, CardType.Objective_Hero, CardType.Objective_Ally, CardType.Objective_Location, CardType.Ship_Objective,
        };

        private static HashSet<CardType> setupCardTypes = new HashSet<CardType>
        {
            CardType.Nightmare_Setup, CardType.GenCon_Setup, CardType.Campaign, CardType.Scenario,
        };

        private static bool HasCardType(LotRCard card, CardType type)
        {
            if (type == Models.LotR.CardType.Player)
            {
                return playerCardTypes.Contains(card.CardType);
            }
            else if (type == Models.LotR.CardType.Character)
            {
                return characterCardTypes.Contains(card.CardType) || (card.CardType == CardType.Objective && card.HitPoints > 0);
            }
            else if (type == Models.LotR.CardType.Encounter)
            {
                return encounterCardTypes.Contains(card.CardType);
            }
            else if (type == Models.LotR.CardType.Objective)
            {
                return objectiveCardTypes.Contains(card.CardType);
            }
            else if (type == Models.LotR.CardType.Setup)
            {
                return setupCardTypes.Contains(card.CardType);
            }
            else
            {
                return card.CardType == type;
            }
        }
    }
}