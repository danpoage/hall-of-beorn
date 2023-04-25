using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using HallOfBeorn.Models.LotR;

namespace HallOfBeorn.Services.LotR.Categories
{
    public class PlayerCategoryService : CategoryServiceBase<PlayerCategory>
    {
        public PlayerCategoryService(ICardRepository<LotRCard> cardRepository)
            : base(cardRepository)
        {
        }

        private static PlayerCategoryService instance;

        public static PlayerCategoryService Instance
        {
            get
            {
                if (instance == null)
                {
                    throw new Exception("PlayerCategoryService not initialized");
                }

                return instance;
            }
            set
            {
                instance = value;
            }
        }

        private Func<LotRCard, PlayerCategory> CreateCategoryFilter(Func<LotRCard, bool> predicate, PlayerCategory category)
        {
            return new Func<LotRCard, PlayerCategory>((card) => {
                return (predicate(card)) ? category : PlayerCategory.None;
            });
        }

        private Func<LotRCard, PlayerCategory> CreateCategoryFilter(string pattern, PlayerCategory category)
        {
            return CreateCategoryFilter(pattern, category, null);
        }

        private Func<LotRCard, PlayerCategory> CreateCategoryFilter(string pattern, PlayerCategory category, params string[] negations)
        {
            Func<LotRCard, PlayerCategory> filter = (card) =>
            {
                foreach (var line in card.Text.Split(new string[] { "\r\n" }, StringSplitOptions.RemoveEmptyEntries))
                {
                    if (line.MatchesPattern(pattern))
                    {
                        if (negations == null || negations.Length == 0 || !negations.Any(x => line.ToLowerSafe().Contains(x.ToLowerSafe())))
                            return category;
                    }
                }

                return PlayerCategory.None;
            };

            return filter;
        }

        protected override bool IsCategorizable(LotRCard card)
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
                case CardType.Player_Side_Quest:
                    return true;
                default:
                    return false;
            }
        }

        protected override List<Func<LotRCard, PlayerCategory>> GetCategoryFilters()
        {
            return new List<Func<LotRCard, PlayerCategory>>
            {
                CreateCategoryFilter(@"(additional|add[\s]{1}([\d]{1}|X))[\s]{1}resource", PlayerCategory.Resource_Acceleration),
                CreateCategoryFilter(@"move[\s]{1}.*[\s]{1}resource|Pay 1 resource from a hero's resource pool to add 1 resource|add 1 resource to a Gondor or Noble|give attached hero a (Leadership|Tactics|Spirit|Lore)|gains a (Leadership|Tactics|Spirit|Lore)|you can spend resources of any sphere", PlayerCategory.Resource_Smoothing),
                CreateCategoryFilter(@"(ally|allies){1,}.*into[\s]play|put into play the revealed card for no cost", PlayerCategory.Mustering),
                CreateCategoryFilter(@"\+[\d]*[\s]Attack|add its Attack|its Attack for this attack", PlayerCategory.Attack_Bonus),
                CreateCategoryFilter(@"\+[\d]*[\s]Defense", PlayerCategory.Defense_Bonus),
                CreateCategoryFilter(@"\+[\d]*[\s]Willpower|add.*Willpower", PlayerCategory.Willpower_Bonus, "Willpower to its Attack"),
                CreateCategoryFilter(@"\+[\d]*[\s]Hit[\s]Point", PlayerCategory.Hit_Point_Bonus),
                CreateCategoryFilter(@"(draw|draws)[\s][\w]*[\s]card|look at the top 2 cards of your deck. Add 1 to your hand|take it into your hand|a card and add it to your hand|(draw|draws) (1|an) additional card", PlayerCategory.Card_Draw),
                CreateCategoryFilter(@"search[\s].*your[\s]deck", PlayerCategory.Card_Search),
                CreateCategoryFilter(@"(look|looks)[\s]at[\s].*[\s]deck|the top card of your deck faceup|exchange a card in your hand with the top card of your deck|reveal the top card of each player's deck", PlayerCategory.Player_Scrying, "encounter deck", "Add 1 to your hand and discard the other"),
                CreateCategoryFilter(@"(look|looks)[\s]at[\s].*encounter[\s]deck", PlayerCategory.Encounter_Scrying),
                CreateCategoryFilter("(enemy|enemies|engaged with you).*(cannot|do not) attack|enemy on the bottom of the encounter deck", PlayerCategory.Combat_Control),
                CreateCategoryFilter(@"(heal|heals)[\s].*damage", PlayerCategory.Healing),
                CreateCategoryFilter(@"discard.*Condition[\s]attachment", PlayerCategory.Condition_Control),
                CreateCategoryFilter(@"place[\s].*progress|switch the active location|location enters play|location gets -.*Threat|While attached to a location|make it the active location|may be placed on the attached location|switch that location|Choose a non-unique location|move up to 2 progress", PlayerCategory.Location_Control),
                CreateCategoryFilter("ready.*(character|hero|ally|allies|him|her|them|Prince|Boromir)", PlayerCategory.Readying, "While Dain Ironfoot is ready"),
                CreateCategoryFilter(@"(return.*discard[\s]pile.*hand|shuffle.*discard[\s]pile.*back|discard pile.*into play|discard pile.*shuffle|shuffle.*card.*discard pile.*into.*deck|(from|in) (your|the) discard pile)", PlayerCategory.Recursion, "encounter discard pile", "Shuffle the encounter deck"),
                CreateCategoryFilter(@"deal[\s]([\d]|X)*[\s]damage|damage to the attacking enemy|damage to the defending enemy|Excess damage dealt by this attack is assigned|assigned as damage to the chosen enemy|deal an additional.*damage|move any number of damage", PlayerCategory.Direct_Damage, "1 damage to Erkenbrand", "deal 1 damage to him to ready him", "deal 1 damage to Treebeard", "deal 1 damage to Eärendil", "Deal 1 damage to Derndingle"),
                CreateCategoryFilter(@"(reveal 1 less|look at|revealed|enters play|top of the).*encounter[\s]deck", PlayerCategory.Encounter_Control),
                CreateCategoryFilter(@"cancel.*shadow|shadow[\s]cards|look at 1 shadow card|Discard (a|each) shadow card", PlayerCategory.Shadow_Control), 
                CreateCategoryFilter(@"(reduce|reduces|lower).*(his|your|player).*threat", PlayerCategory.Threat_Control, "your threat is lower", "hero with lower threat cost"),
                CreateCategoryFilter(@"((enemy|enemies).*staging[\s]area.*attack|attacker.*against.*enemy not engaged with you|Any character may choose attached enemy as the target of an attack)|deal 1 damage to an enemy in the staging area|attacking an enemy in the staging area|attacker against enemies in the staging area|Choose a.*enemy.*instead assigned as damage to the chosen enemy|and resolve (his|her) attack.* against an enemy in the staging area", PlayerCategory.Staging_Area_Attack),
                CreateCategoryFilter("(choose (an enemy|a location).*staging area)|add.*each enemy's engagement cost|each enemy.*gets.*engagement cost|return that enemy to the staging area", PlayerCategory.Staging_Area_Control),
                CreateCategoryFilter(@"after[\s].*[\s](enters|enters or leaves)[\s]play", PlayerCategory.Enters_Play),
                CreateCategoryFilter(@"(after[\s].*[\s]leaves[\s]play|return (it|him|Keen-eyed Took) to your hand)|if that ally is still in play, add it to your hand", PlayerCategory.Leaves_Play, "After attached location leaves play"),
                CreateCategoryFilter(@"(after[\s]you[\s]play[\s].*[\s]from[\s]your[\s]hand|after you play)", PlayerCategory.Played_From_Hand),
                CreateCategoryFilter(@"attach 1 attachment card|an attachment of cost 3 or less and put it into play|you may attach that card facedown|to play Weapon and Armor attachments on|put into play the revealed card for no cost", PlayerCategory.Equipping),
                CreateCategoryFilter((card) => { return card.Keywords.Any(x => x.StartsWith("Secrecy")) || card.Text.ToLowerSafe().Contains("if your threat is 20 or less") || card.Text.ToLowerSafe().Contains("gains secrecy") || card.Text.ToLowerSafe().Contains("treat your threat as if it is 20"); }, PlayerCategory.Secrecy),
                CreateCategoryFilter("enemy.*engagement cost.*than your threat", PlayerCategory.Surprise),
                CreateCategoryFilter((card) => { return card.Text.ToLowerSafe().Contains("victory display") && card.VictoryPoints == 0; }, PlayerCategory.Victory_Display),
                CreateCategoryFilter("(discard (a|1|2|all|X) (card|cards) (from|in) your hand|discarded from your hand|discard (1 of those|any number of) cards)", PlayerCategory.Discard_From_Hand, "Look at the top X cards of the encounter deck"),
                CreateCategoryFilter("discard pile", PlayerCategory.Discard_Pile, "encounter deck and discard pile"),
                CreateCategoryFilter("(commit .* to|remove it from) the quest", PlayerCategory.Quest_Control),
                CreateCategoryFilter("(two|2) or fewer heroes", PlayerCategory.Two_Or_Fewer_Heroes),
                CreateCategoryFilter("(players as a group.*spend|triggered by each player|any player may trigger)", PlayerCategory.Group_Effect),
                CreateCategoryFilter("(is discarded from (the top of your|your) deck|discard the top card of your deck|discard the top 2 cards of your deck|discard 2 cards from the top of your deck|the top 2 cards of your deck. Add 1 to your hand and discard the other)", PlayerCategory.Discard_From_Deck),
                CreateCategoryFilter("declare .* attacker", PlayerCategory.Declared_Attack),
                CreateCategoryFilter("(player|player card) attachment", PlayerCategory.Attachment_Bonus),
                CreateCategoryFilter("((enemy|location) .* -(1|2|3|4|X) Threat|does not (count|contribute) its Threat)", PlayerCategory.Staging_Threat_Reduction),
                CreateCategoryFilter("-(1|2|3|4|X) Attack", PlayerCategory.Enemy_Attack_Reduction),
                CreateCategoryFilter("(-(1|2|3|4|X) Defense|does not count its defense)", PlayerCategory.Enemy_Defense_Reduction),
                CreateCategoryFilter("reveal 1 less", PlayerCategory.Encounter_Reveal_Reduction),
                CreateCategoryFilter("(engage (the chosen|that) enemy|into play engaged with you)", PlayerCategory.Engagement_Control),
                CreateCategoryFilter("not engaged with you", PlayerCategory.Target_Not_Engaged),
                CreateCategoryFilter("(attach .* to another (hero|ally|character)|move an .*attachment)", PlayerCategory.Attachment_Movement),
                CreateCategoryFilter("a unique character with the .* trait and another unique character with the .* trait", PlayerCategory.Trait_Pairing),
                CreateCategoryFilter("side quest (in|is in) the victory display", PlayerCategory.Side_Quest_Bonus),
                CreateCategoryFilter((card) => { return card.Keywords.Any(kw => kw.Contains("Guarded")); }, PlayerCategory.Guarded_Attachment),
                CreateCategoryFilter(@"attach to (an(\s{1}[\S]*\s{1}|\s)ally|a(\s{1}[\S]*\s{1}|\s{1})character)|attach to (a|an) [\S]* or [\S]* character", PlayerCategory.Ally_Attachment),
                CreateCategoryFilter("attach.* to (a|the active|that) location", PlayerCategory.Location_Attachment),
                CreateCategoryFilter("(cancel|prevent) 1 point of damage|place 1 of that damage|takes all damage assigned|(place|reduce) that damage|cancel X damage|cancel up to 2 damage", PlayerCategory.Damage_Control),
                CreateCategoryFilter("reduce the cost (of|to)", PlayerCategory.Cost_Reduction),
                CreateCategoryFilter("each hero you control with (a|the) printed (Leadership|Tactics|Spirit|Lore) resource icon|(?<!only )if each (of your heroes|hero you control) has a printed (Leadership|Tactics|Spirit|Lore) resource icon|If each hero you control belongs to the same sphere of influence", PlayerCategory.Mono_Sphere_Bonus),
                CreateCategoryFilter("Play only if each hero you control has (a|the) printed (Leadership|Tactics|Spirit|Lore)|You must use resources from 3 different heroes' pools", PlayerCategory.Mono_Sphere_Required),
                CreateCategoryFilter((card) => 
                    card.IsPlayerCard() && (card.HasTraits("Item.") || card.HasTraits("Artifact.")), PlayerCategory.Burglar_Treasure),
                CreateCategoryFilter((card) =>
                    {
                        return card.CardType == CardType.Ally && card.IsUnique && card.Sphere != Sphere.Neutral
                            && card.Slug != "Elrond-RD" && card.Slug != "Elrond-TPLES" 
                            && card.Slug != "Galadriel-RD" && card.Slug != "Galadriel-TPLES"
                            && !card.Text.ContainsLower("cannot have attachments"); 
                    },
                    PlayerCategory.Messenger_of_the_King),
                CreateCategoryFilter((card) => card.Text.ContainsLower("valour") || card.Text.Contains("40"), PlayerCategory.Valour),
                CreateCategoryFilter((card) => {
                    switch (card.Slug)
                    {
                        case "Entangling-Nets-TotD":
                        case "Keep-Watch-BtS":
                        case "In-the-Shadows-TLoS":
                        case "Horn's-Cry-TToR":
                        case "Beorn's-Rage-TWH":
                        case "Phial-of-Galadriel-RD":
                        case "Landroval-AJtR":
                        case "Dori-THOHaUH":
                        case "Honour-Guard-TWoE":
                        case "Loyal-Hound-TFoW":
                        case "Vigilant-Guard-ASoCH":
                        case "Close-Call-TDT":
                        case "Fortune-or-Fate-Core":
                        case "The-Houses-of-Healing-ASoCH":
                            return true;
                        default: return false;
                    }
                }, PlayerCategory.Beorn_Support),
                CreateCategoryFilter((card) => card.Traits.Contains("Woodman.") || card.Text.Contains("location"), PlayerCategory.Good_in_a_Woodman_Deck),
            };
        }
    }
}