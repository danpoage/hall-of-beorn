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
                if (target.Value == Models.LotR.CardType.Player)
                {
                    return score.Card.CardType == Models.LotR.CardType.Hero || score.Card.CardType == Models.LotR.CardType.Ally || score.Card.CardType == Models.LotR.CardType.Attachment || score.Card.CardType == Models.LotR.CardType.Event || score.Card.CardType == Models.LotR.CardType.Player_Side_Quest;
                }
                else if (target.Value == Models.LotR.CardType.Character)
                {
                    return score.Card.CardType == Models.LotR.CardType.Hero || score.Card.CardType == Models.LotR.CardType.Ally || score.Card.CardType == Models.LotR.CardType.Objective_Ally || (score.Card.CardType == Models.LotR.CardType.Objective && score.Card.HitPoints > 0);
                }
                else if (target.Value == Models.LotR.CardType.Encounter)
                {
                    return score.Card.CardType == Models.LotR.CardType.Enemy || score.Card.CardType == Models.LotR.CardType.Location || score.Card.CardType == Models.LotR.CardType.Treachery || score.Card.CardType == Models.LotR.CardType.Objective || score.Card.CardType == Models.LotR.CardType.Objective_Ally || score.Card.CardType == Models.LotR.CardType.Objective_Location || score.Card.CardType == Models.LotR.CardType.Encounter_Side_Quest || score.Card.CardType == Models.LotR.CardType.Ship_Objective || score.Card.CardType == Models.LotR.CardType.Ship_Enemy;
                }
                else if (target.Value == Models.LotR.CardType.Objective)
                {
                    return score.Card.CardType == Models.LotR.CardType.Objective || score.Card.CardType == Models.LotR.CardType.Objective_Ally;
                }
                else
                    return target.Value == score.Card.CardType;
            };
        }
    }
}