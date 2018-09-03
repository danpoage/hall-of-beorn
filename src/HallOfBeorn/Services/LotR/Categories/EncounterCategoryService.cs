using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using HallOfBeorn.Models.LotR;

namespace HallOfBeorn.Services.LotR.Categories
{
    public class EncounterCategoryService : CategoryServiceBase<EncounterCategory>
    {
        public EncounterCategoryService(ICardRepository<LotRCard> cardRepository)
            : base(cardRepository)
        {
        }

        private Func<LotRCard, EncounterCategory> CreateEncounterCategoryFilter(string pattern, EncounterCategory category)
        {
            return CreateEncounterCategoryFilter(pattern, category, null);
        }

        private Func<LotRCard, EncounterCategory> CreateEncounterCategoryFilter(string pattern, EncounterCategory category, params string[] negations)
        {
            Func<LotRCard, EncounterCategory> filter = (card) =>
            {
                foreach (var line in card.Text.Split(new string[] { "\r\n" }, StringSplitOptions.RemoveEmptyEntries))
                {
                    if (line.MatchesPattern(pattern))
                    {
                        if (negations == null || negations.Length == 0 || !negations.Any(x => line.ToLowerSafe().Contains(x.ToLowerSafe())))
                            return category;
                    }
                }

                return EncounterCategory.None;
            };

            return filter;
        }

        protected override bool IsCategorizable(LotRCard card)
        {
            switch (card.CardType)
            {
                case CardType.Enemy:
                case CardType.Location:
                case CardType.Treachery:
                case CardType.Encounter_Side_Quest:
                case CardType.Ship_Enemy:
                case CardType.Objective:
                case CardType.Objective_Location:
                    return true;
                default:
                    return false;
            }    
        }

        protected override List<Func<LotRCard, EncounterCategory>> GetCategoryFilters()
        {
            return new List<Func<LotRCard, EncounterCategory>> {
                CreateEncounterCategoryFilter("exhaust (a|1) (character|hero|ally)", EncounterCategory.Exhaustion),
                CreateEncounterCategoryFilter("When Revealed:", EncounterCategory.When_Revealed),
                CreateEncounterCategoryFilter("(each|a|1) hero", EncounterCategory.Targets_Heroes),
                CreateEncounterCategoryFilter("(each|a|1) ally", EncounterCategory.Targets_Allies),
                CreateEncounterCategoryFilter("(each|a|1) character", EncounterCategory.Targets_Characters),
                CreateEncounterCategoryFilter("after you engage|after .*engages (you|a player)", EncounterCategory.Triggered_By_Engagement),
                CreateEncounterCategoryFilter("(character|hero|ally) (gets|get).*\\-([xX1-9]) Willpower|Willpower.*reduced", EncounterCategory.Willpower_Reduction),
                CreateEncounterCategoryFilter("(character|hero|ally) (gets|get).*\\-([xX1-9]) Attack|Attack.*reduced", EncounterCategory.Attack_Reduction),
                CreateEncounterCategoryFilter("(character|hero|ally) (gets|get).*\\-([xX1-9]) Defense|Defense.*reduced", EncounterCategory.Defense_Reduction),
                CreateEncounterCategoryFilter("(get|gets) .*\\+[xX1-9] Threat", EncounterCategory.Staging_Area_Threat_Raise),
                CreateEncounterCategoryFilter("(get|gets) .*\\+[xX1-9] Attack", EncounterCategory.Enemy_Attack_Boost),
                CreateEncounterCategoryFilter("(get|gets) .*\\+[xX1-9] Defense", EncounterCategory.Enemy_Defense_Boost),
                CreateEncounterCategoryFilter("Counts as a Condition attachment", EncounterCategory.Condition_Attachment),
                CreateEncounterCategoryFilter("While .* is the active location", EncounterCategory.While_Active),
                CreateEncounterCategoryFilter("While .* is in the staging area", EncounterCategory.While_In_Staging),
                CreateEncounterCategoryFilter("Cannot spend resources", EncounterCategory.Cannot_Spend_Resources),
                CreateEncounterCategoryFilter("Cannot play (event|events)", EncounterCategory.Cannnot_Play_Events),
                CreateEncounterCategoryFilter("Cannot play (ally|allies)", EncounterCategory.Cannot_Play_Allies),
                CreateEncounterCategoryFilter("cannot be .*engaged", EncounterCategory.Cannot_Engage),
                CreateEncounterCategoryFilter("makes an immediate attack", EncounterCategory.Immediate_Attack),
                CreateEncounterCategoryFilter("return .* to the staging area", EncounterCategory.Return_to_Staging_Area),
                CreateEncounterCategoryFilter("discard .* (card|cards) from (your|their|his) hand", EncounterCategory.Card_Discard),
                CreateEncounterCategoryFilter("excess .*damage dealt", EncounterCategory.Trample),
                CreateEncounterCategoryFilter("choose and discard", EncounterCategory.Chosen_Card_Discard, "random", "discard an attachment", "discard an ally"),
                CreateEncounterCategoryFilter("discard .* random card|discard .* (card|cards) at random", EncounterCategory.Random_Card_Discard),
                CreateEncounterCategoryFilter("gains surge", EncounterCategory.Optional_Surge),
                CreateEncounterCategoryFilter("each player", EncounterCategory.Targets_Each_Player),
                CreateEncounterCategoryFilter("first player", EncounterCategory.Targets_First_Player),
                CreateEncounterCategoryFilter("engaged player", EncounterCategory.Targets_Engaged_Player),
                CreateEncounterCategoryFilter("exhausted (character|hero|heroes|ally|allies)", EncounterCategory.Targets_Exhausted_Characters),
                CreateEncounterCategoryFilter("(deal|deals) [xX1-9] damage|deal damage to", EncounterCategory.Direct_Damage, "to The Balrog"),
                CreateEncounterCategoryFilter("raise (his|your|their) threat by", EncounterCategory.Player_Threat_Raise),
                CreateEncounterCategoryFilter("printed text boxes .*blank", EncounterCategory.Text_Blanking),
                CreateEncounterCategoryFilter("cannot play attachment|cannot have attachments", EncounterCategory.Attachment_Immunity),
                CreateEncounterCategoryFilter("immune to player card effects", EncounterCategory.Effect_Immunity),
                CreateEncounterCategoryFilter("a questing (hero|ally|character)|committed to a quest", EncounterCategory.Targets_Quester),
                CreateEncounterCategoryFilter("not commited to.*quest", EncounterCategory.Targets_Non_Quester),
                CreateEncounterCategoryFilter("as a defender|a character defends|cannot defend", EncounterCategory.Targets_Defender),
                CreateEncounterCategoryFilter("as an attacker|when.*is attacked|cannot be attacked", EncounterCategory.Targets_Attacker),
                CreateEncounterCategoryFilter("discard (a|1) (character|hero|ally)", EncounterCategory.Character_Discard),
                CreateEncounterCategoryFilter("discard an attachment", EncounterCategory.Attachment_Discard),
                CreateEncounterCategoryFilter("X is.*number of players", EncounterCategory.Scales_To_Number_of_Players),
                CreateEncounterCategoryFilter("(each|an).*enemy.*(staging area|into play)", EncounterCategory.Bring_Enemies_Into_Play),
                CreateEncounterCategoryFilter("Travel:", EncounterCategory.Travel),
                CreateEncounterCategoryFilter("Forced:", EncounterCategory.Forced),
                CreateEncounterCategoryFilter("unsuccessfully", EncounterCategory.Unsuccessful_Questing),
                CreateEncounterCategoryFilter("a shadow (effect|card)|deal (a|1|2) shadow card", EncounterCategory.Shadow_Card_Synergy, "do not deal a shadow card"),
                CreateEncounterCategoryFilter("(remove|removes) (a|all|that|the chosen) (hero|heroes|ally|ally|character|characters).*from the quest", EncounterCategory.Remove_From_Quest),
                CreateEncounterCategoryFilter("remove.*progress", EncounterCategory.Progress_Removal),
                CreateEncounterCategoryFilter("reveal.*additional", EncounterCategory.Reveal_Additional_Cards),
                CreateEncounterCategoryFilter("discard (a|that) character", EncounterCategory.Character_Discard, "to The Balrog"),
                CreateEncounterCategoryFilter("cannot draw cards", EncounterCategory.Cannot_Draw_Cards),
                CreateEncounterCategoryFilter("cannot play (ally|allies)", EncounterCategory.Cannot_Play_Allies),
                CreateEncounterCategoryFilter("while.*engaged", EncounterCategory.While_Engaged),
                CreateEncounterCategoryFilter("shuffle (it|them|all copies of .*) back into", EncounterCategory.Encounter_Recursion),
                CreateEncounterCategoryFilter("each player with a threat", EncounterCategory.High_Player_Threat)
            };
        }
    }
}