using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

using HallOfBeorn.Models.LotR;

namespace HallOfBeorn.Services.LotR
{
    public class CategoryService
    {
        public CategoryService(CardRepository cardRepository)
        {
            cards = cardRepository.Cards();

            LoadCategories();
            LoadEncounterCategories();
            LoadQuestCategories();
        }

        private readonly IEnumerable<LotRCard> cards;
        private readonly Dictionary<string, Category> categories = new Dictionary<string, Category>();
        private readonly Dictionary<string, EncounterCategory> encounterCategories = new Dictionary<string, EncounterCategory>();
        private readonly Dictionary<string, QuestCategory> questCategories = new Dictionary<string, QuestCategory>();

        private readonly Dictionary<string, List<Category>> playerCategoriesBySlug = new Dictionary<string,List<Category>>();
        private readonly Dictionary<string, List<EncounterCategory>> encounterCategoriesBySlug = new Dictionary<string,List<EncounterCategory>>();
        private readonly Dictionary<string, List<QuestCategory>> questCategoriesBySlug = new Dictionary<string, List<QuestCategory>>();

        private bool IsCategorizable(LotRCard card)
        {
            if (string.IsNullOrEmpty(card.Text) && card.Keywords.Count() == 0)
                return false;

            switch (card.CardType)
            {
                case CardType.Hero:
                    return true;
                case CardType.Ally:
                    return true;
                case CardType.Attachment:
                    return true;
                case CardType.Event:
                    return true;
                default:
                    return false;
            }
        }

        private bool IsEncounterCategorizable(LotRCard card)
        {
            switch (card.CardType)
            {
                case CardType.Enemy:
                    return true;
                case CardType.Location:
                    return true;
                case CardType.Treachery:
                    return true;
                default:
                    return false;
            }
        }

        private bool IsQuestCategorizable(LotRCard card)
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

        private Func<LotRCard, Category> CreateCategoryFilter(Func<LotRCard, bool> predicate, Category category)
        {
            return new Func<LotRCard, Category>((card) => {
                return (predicate(card)) ? category : Category.None;
            });
        }

        private Func<LotRCard, Category> CreateCategoryFilter(string pattern, Category category)
        {
            return CreateCategoryFilter(pattern, category, null);
        }

        private Func<LotRCard, Category> CreateCategoryFilter(string pattern, Category category, params string[] negations)
        {
            Func<LotRCard, Category> filter = (card) =>
            {
                foreach (var line in card.Text.Split(new string[] { "\r\n" }, StringSplitOptions.RemoveEmptyEntries))
                {
                    if (line.MatchesPattern(pattern))
                    {
                        if (negations == null || negations.Length == 0 || !negations.Any(x => line.ToLowerSafe().Contains(x.ToLowerSafe())))
                            return category;
                    }
                }

                return Category.None;
            };

            return filter;
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

        private bool textContains(LotRCard card, string[] values)
        {
            foreach (var text in values)
            {
                if (!string.IsNullOrEmpty(card.Text) && card.Text.Contains(text))
                {
                    return true;
                }

                if (!string.IsNullOrEmpty(card.OppositeText) && card.OppositeText.Contains(text))
                {
                    return true;
                }
            }
            return false;
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

        private void LoadEncounterCategories()
        {
            var filters = new List<Func<LotRCard, EncounterCategory>> {
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

            foreach (var card in cards.Where(x => IsEncounterCategorizable(x)))
            {
                foreach (var filter in filters)
                {
                    var category = filter(card);
                    if (category == EncounterCategory.None)
                        continue;

                    if (!encounterCategoriesBySlug.ContainsKey(card.Slug)) {
                        encounterCategoriesBySlug[card.Slug] = new List<EncounterCategory>();
                    }
                    encounterCategoriesBySlug[card.Slug].Add(category);

                    var categoryKey = category.ToString();
                    if (!encounterCategories.ContainsKey(categoryKey))
                    {
                        encounterCategories.Add(categoryKey, category);
                    }
                }
            }
        }

        private void LoadQuestCategories()
        {
            var filters = new List<Func<LotRCard, QuestCategory>>
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

            foreach (var card in cards.Where(x => IsQuestCategorizable(x)))
            {
                foreach (var filter in filters)
                {
                    var category = filter(card);
                    if (category == QuestCategory.None)
                        continue;

                    if (!questCategoriesBySlug.ContainsKey(card.Slug)) {
                        questCategoriesBySlug[card.Slug] = new List<QuestCategory>();
                    }
                    questCategoriesBySlug[card.Slug].Add(category);

                    var categoryKey = category.ToString();
                    if (!questCategories.ContainsKey(categoryKey))
                    {
                        questCategories.Add(categoryKey, category);
                    }
                }
            }
        }

        private void LoadCategories()
        {
            var filters = new List<Func<LotRCard, Category>>
            {
                CreateCategoryFilter(@"(an additional|add[\s]{1}([\d]{1}|X))[\s]{1}resource", Category.Resource_Acceleration),
                CreateCategoryFilter(@"move[\s]{1}.*[\s]{1}resource|Pay 1 resource from a hero's resource pool to add 1 resource|add 1 resource to a Gondor or Noble|give attached hero a (Leadership|Tactics|Spirit|Lore)|gains a (Leadership|Tactics|Spirit|Lore)|you can spend resources of any sphere", Category.Resource_Smoothing),
                CreateCategoryFilter(@"(ally|allies){1,}.*into[\s]play|put into play the revealed card for no cost", Category.Mustering),
                CreateCategoryFilter(@"\+[\d]*[\s]Attack|add its Attack|its Attack for this attack", Category.Attack_Bonus),
                CreateCategoryFilter(@"\+[\d]*[\s]Defense", Category.Defense_Bonus),
                CreateCategoryFilter(@"\+[\d]*[\s]Willpower|add.*Willpower", Category.Willpower_Bonus, "Willpower to its Attack"),
                CreateCategoryFilter(@"\+[\d]*[\s]Hit[\s]Point", Category.Hit_Point_Bonus),
                CreateCategoryFilter(@"(draw|draws)[\s][\w]*[\s]card|look at the top 2 cards of your deck. Add 1 to your hand|take it into your hand|a card and add it to your hand|(draw|draws) 1 additional card", Category.Card_Draw),
                CreateCategoryFilter(@"search[\s].*your[\s]deck", Category.Card_Search),
                CreateCategoryFilter(@"(look|looks)[\s]at[\s].*[\s]deck|the top card of your deck faceup|exchange a card in your hand with the top card of your deck|reveal the top card of each player's deck", Category.Player_Scrying, "encounter deck", "Add 1 to your hand and discard the other"),
                CreateCategoryFilter(@"(look|looks)[\s]at[\s].*encounter[\s]deck", Category.Encounter_Scrying),
                CreateCategoryFilter("(enemy|enemies|engaged with you).*(cannot|do not) attack|enemy on the bottom of the encounter deck", Category.Combat_Control),
                CreateCategoryFilter(@"(heal|heals)[\s].*damage", Category.Healing),
                CreateCategoryFilter(@"discard.*Condition[\s]attachment", Category.Condition_Control),
                CreateCategoryFilter(@"place[\s].*progress|switch the active location|location enters play|location gets -.*Threat|While attached to a location|make it the active location|may be placed on the attached location|switch that location", Category.Location_Control),
                CreateCategoryFilter("ready.*(character|hero|ally|allies|him|her|them|Prince|Boromir)", Category.Readying, "While Dain Ironfoot is ready"),
                CreateCategoryFilter(@"(return.*discard[\s]pile.*hand|shuffle.*discard[\s]pile.*back|discard pile.*into play|discard pile.*shuffle|shuffle.*card.*discard pile.*into.*deck|(from|in) (your|the) discard pile)", Category.Recursion, "encounter discard pile", "Shuffle the encounter deck"),
                CreateCategoryFilter(@"deal[\s]([\d]|X)*[\s]damage|damage to the attacking enemy|damage to the defending enemy|Excess damage dealt by this attack is assigned|assigned as damage to the chosen enemy|deal an additional.*damage", Category.Direct_Damage, "1 damage to Erkenbrand", "deal 1 damage to him to ready him", "deal 1 damage to Treebeard", "deal 1 damage to Eärendil", "Deal 1 damage to Derndingle"),
                CreateCategoryFilter(@"(reveal 1 less|look at|revealed|enters play|top of the).*encounter[\s]deck", Category.Encounter_Control),
                CreateCategoryFilter(@"cancel.*shadow|shadow[\s]cards|look at 1 shadow card|Discard (a|each) shadow card", Category.Shadow_Control), 
                CreateCategoryFilter(@"(reduce|reduces|lower).*(his|your|player).*threat", Category.Threat_Control, "your threat is lower"),
                CreateCategoryFilter(@"((enemy|enemies).*staging[\s]area.*attack|attacker.*against.*enemy not engaged with you|Any character may choose attached enemy as the target of an attack)|deal 1 damage to an enemy in the staging area|attacking an enemy in the staging area|attacker against enemies in the staging area|Choose a.*enemy.*instead assigned as damage to the chosen enemy", Category.Staging_Area_Attack),
                CreateCategoryFilter("(choose (an enemy|a location).*staging area)|add.*each enemy's engagement cost|each enemy.*gets.*engagement cost|return that enemy to the staging area", Category.Staging_Area_Control),
                CreateCategoryFilter(@"after[\s].*[\s](enters|enters or leaves)[\s]play", Category.Enters_Play),
                CreateCategoryFilter(@"(after[\s].*[\s]leaves[\s]play|return (it|him|Keen-eyed Took) to your hand)|if that ally is still in play, add it to your hand", Category.Leaves_Play, "After attached location leaves play"),
                CreateCategoryFilter(@"(after[\s]you[\s]play[\s].*[\s]from[\s]your[\s]hand|after you play)", Category.Played_From_Hand),
                CreateCategoryFilter(@"attach 1 attachment card|an attachment of cost 3 or less and put it into play|you may attach that card facedown|to play Weapon and Armor attachments on|put into play the revealed card for no cost", Category.Equipping),
                CreateCategoryFilter((card) => { return card.Keywords.Any(x => x.StartsWith("Secrecy")) || card.Text.ToLowerSafe().Contains("if your threat is 20 or less") || card.Text.ToLowerSafe().Contains("gains secrecy") || card.Text.ToLowerSafe().Contains("treat your threat as if it is 20"); }, Category.Secrecy),
                CreateCategoryFilter("enemy.*engagement cost.*than your threat", Category.Surprise),
                CreateCategoryFilter((card) => { return card.Text.ToLowerSafe().Contains("victory display") && card.VictoryPoints == 0; }, Category.Victory_Display),
                CreateCategoryFilter("(discard (a|1|2|all|X) (card|cards) (from|in) your hand|discarded from your hand|discard (1 of those|any number of) cards)", Category.Discard_From_Hand, "Look at the top X cards of the encounter deck"),
                CreateCategoryFilter("discard pile", Category.Discard_Pile, "encounter deck and discard pile"),
                CreateCategoryFilter("(commit .* to|remove it from) the quest", Category.Quest_Control),
                CreateCategoryFilter("(two|2) or fewer heroes", Category.Two_Or_Fewer_Heroes),
                CreateCategoryFilter("(players as a group.*spend|triggered by each player|any player may trigger)", Category.Group_Effect),
                CreateCategoryFilter("(is discarded from the top of your deck|discard the top card of your deck|discard the top 2 cards of your deck|discard 2 cards from the top of your deck|the top 2 cards of your deck. Add 1 to your hand and discard the other)", Category.Discard_From_Deck),
                CreateCategoryFilter("declare .* attacker", Category.Declared_Attack),
                CreateCategoryFilter("(player|player card) attachment", Category.Attachment_Bonus),
                CreateCategoryFilter("((enemy|location) .* -(1|2|3|4|X) Threat|does not (count|contribute) its Threat)", Category.Staging_Threat_Reduction),
                CreateCategoryFilter("-(1|2|3|4|X) Attack", Category.Enemy_Attack_Reduction),
                CreateCategoryFilter("(-(1|2|3|4|X) Defense|does not count its defense)", Category.Enemy_Defense_Reduction),
                CreateCategoryFilter("reveal 1 less", Category.Encounter_Reveal_Reduction),
                CreateCategoryFilter("(engage (the chosen|that) enemy|into play engaged with you)", Category.Engagement_Control),
                CreateCategoryFilter("not engaged with you", Category.Target_Not_Engaged),
                CreateCategoryFilter("(attach .* to another (hero|ally|character)|move an .*attachment)", Category.Attachment_Movement),
                CreateCategoryFilter("a unique character with the .* trait and another unique character with the .* trait", Category.Trait_Pairing),
                CreateCategoryFilter("side quest (in|is in) the victory display", Category.Side_Quest_Bonus),
                CreateCategoryFilter((card) => { return card.Keywords.Any(kw => kw.Contains("Guarded")); }, Category.Guarded_Attachment),
                CreateCategoryFilter(@"attach to (an(\s{1}[\S]*\s{1}|\s)ally|a(\s{1}[\S]*\s{1}|\s{1})character)|attach to (a|an) [\S]* or [\S]* character", Category.Ally_Attachment),
                CreateCategoryFilter("attach.* to (a|the active|that) location", Category.Location_Attachment),
                CreateCategoryFilter("(cancel|prevent) 1 point of damage|place 1 of that damage|takes all damage assigned", Category.Damage_Control),
                CreateCategoryFilter("reduce the cost (of|to)", Category.Cost_Reduction),
                CreateCategoryFilter("each hero you control with (a|the) printed (Leadership|Tactics|Spirit|Lore) resource icon|if each of your heroes has a printed (Leadership|Tactics|Spirit|Lore) resource icon", Category.Mono_Sphere_Bonus),
                CreateCategoryFilter("Play only if each hero you control has (a|the) printed (Leadership|Tactics|Spirit|Lore)|You must use resources from 3 different heroes' pools", Category.Mono_Sphere_Required)
            };

            foreach (var card in cards.Where(x => IsCategorizable(x)))
            {
                foreach (var filter in filters)
                {
                    var category = filter(card);
                    if (category == Category.None)
                        continue;

                    if (!playerCategoriesBySlug.ContainsKey(card.Slug)) {
                        playerCategoriesBySlug[card.Slug] = new List<Category>();
                    }
                    playerCategoriesBySlug[card.Slug].Add(category);

                    var categoryKey = category.ToString();
                    if (!categories.ContainsKey(categoryKey))
                    {
                        categories.Add(categoryKey, category);
                    }
                }
            }
        }

        public bool HasPlayerCategory(LotRCard card, Category category)
        {
            return playerCategoriesBySlug.ContainsKey(card.Slug) && playerCategoriesBySlug[card.Slug].Any(x => x == category);
        }

        public bool HasEncounterCategory(LotRCard card, EncounterCategory category)
        {
            return encounterCategoriesBySlug.ContainsKey(card.Slug) && encounterCategoriesBySlug[card.Slug].Any(x => x == category);
        }

        public bool HasQuestCategory(LotRCard card, QuestCategory category)
        {
            return questCategoriesBySlug.ContainsKey(card.Slug) && questCategoriesBySlug[card.Slug].Any(x => x == category);
        }

        public IEnumerable<string> CategoryNames()
        {
            return categories.Values.ToList().Select(x => x.ToString().Replace('_', ' ')).OrderBy(x => x);
        }

        public IEnumerable<string> EncounterCategoryNames()
        {
            return encounterCategories.Values.ToList().Select(x => x.ToString().Replace('_', ' ')).OrderBy(x => x);
        }

        public IEnumerable<string> QuestCategoryNames()
        {
            return questCategories.Values.ToList().Select(x => x.ToString().Replace('_', ' ')).OrderBy(x => x);
        }

        public IEnumerable<Category> PlayerCategories(string slug)
        {
            return playerCategoriesBySlug.ContainsKey(slug) ? playerCategoriesBySlug[slug] : Enumerable.Empty<Category>();
        }

        public IEnumerable<EncounterCategory> EncounterCategories(string slug)
        {
            return encounterCategoriesBySlug.ContainsKey(slug) ? encounterCategoriesBySlug[slug] : Enumerable.Empty<EncounterCategory>();
        }

        public IEnumerable<QuestCategory> QuestCategories(string slug)
        {
            return questCategoriesBySlug.ContainsKey(slug) ? questCategoriesBySlug[slug] : Enumerable.Empty<QuestCategory>();
        }
    }
}