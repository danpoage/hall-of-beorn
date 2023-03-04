using System;

namespace HallOfBeorn.Models.LotR.Sets.DreamChaser
{
    public static class DreamChaserCampaignExpansion
    {
        public static CardSet Create()
        {
            var cs = CardSet.Create("Dream-chaser Campaign Expansion", "DCC", SetType.Campaign_Expansion, Cycles.DreamChaser, 402);

            cs.addShipObjective("Dream-chaser", EncounterSet.TheDreamChasersFleetCampaign, true, 5, 4, 4, 18)
                .WithTraits("Grey Havens.", "Ship.")
                .WithKeywords("Sentinel.")
                .WithTextLine("Immune to player card effects. Sentinel.")
                .WithTextLine("The Dream-chaser can always be committed to sailing tests (even if you are not the first player), and counts as 2 characters when committed to a Sailing test.")
                .WithTextLine("If the Dream-chaser is destroyed, the players lose the game.")
                .WithInfo(126, 1, Artist.Nele_Klumpe);
            cs.addShipObjective("Dream-chaser", EncounterSet.TheDreamChasersFleetCampaign, true, 6, 5, 5, 19)
                .WithSlugSuffix("Upgraded")
                .WithTraits("Grey Havens.", "Ship.", "Upgraded.")
                .WithKeywords("Sentinel.")
                .WithTextLine("Campaign Mode only.")
                .WithTextLine("Immune to player card effects. Sentinel.")
                .WithTextLine("The Dream-chaser can be committed to any sailing test and counts as 3 characters when committed to a Sailing test.")
                .WithTextLine("If the Dream-chaser is destroyed, the players lose the game.")
                .WithXP(4)
                .WithInfo(126, 1, Artist.Nele_Klumpe);

            cs.addShipObjective("Duskbringer", EncounterSet.TheDreamChasersFleetCampaign, true, 3, 4, 3, 16)
                .WithTraits("Gondor.", "Ship.")
                .WithKeywords("Sentinel.")
                .WithTextLine("Immune to player card effects. Sentinel.")
                .WithTextLine("Response: After you play a card with an odd printed cost, add 1 resource to a hero's resource pool. (Limit once per round.)")
                .WithTextLine("If the Diskbringer is destroyed, its controller is eliminated from the game.")
                .WithInfo(128, 1, Artist.Carlos_Palma_Cruchaga);
            cs.addShipObjective("Glórinaith", EncounterSet.TheDreamChasersFleetCampaign, true, 4, 4, 3, 17)
                .WithTraits("Grey Havens.", "Ship.")
                .WithKeywords("Ranged.")
                .WithTextLine("Immune to player card effects. Ranged.")
                .WithTextLine("Action: Discard the top 2 cards of any deck to deal 1 damage to an engaged non-unique enemy. (Limit once per round.)")
                .WithTextLine("If the Glórinaith is destroyed, its controller is eliminated from the game.")
                .WithInfo(129, 1, Artist.JB_Casacop);

            cs.addAttachment("Armor Plating", 0, Sphere.Neutral, false)
                .WithBoon()
                .WithTraits("Modification.", "Armor.")
                .WithTextLine("When Armor Plating leaves play, remove it from the game.")
                .WithTextLine("Attached Ship gets +1 Defense.")
                .WithInfo(172, 4, Artist.Tiziano_Baracchi);
            cs.addAttachment("Ballista", 0, Sphere.Neutral, false)
                .WithBoon()
                .WithTraits("Modification.", "Weapon.")
                .WithTextLine("When Ballista leaves play, remove it from the game.")
                .WithTextLine("Attached Ship gets +1 Attack.")
                .WithInfo(173, 4, Artist.Carlos_Palma_Cruchaga);

            cs.addTreachery("Ominous Fate", EncounterSet.VoyageAcrossBelegaerCampaign)
                .WithBurden()
                .WithKeywords("Surge.")
                .WithTextLine("Surge. Ominous Fate cannot be canceled.")
                .WithTextLine("When Revealed: Each player must either reveal an encounter card, raise their threat by X, or deal X damage divided among characters they control. X is the campaign card's part number. The players may add Ominous Fate to the victory display.")
                .WithShadow("Shadow: Reveal an encounter card.")
                .WithTextLine("☸")
                .WithInfo(176, 1, Artist.Leanna_Crossan);

            cs.addEnemy("Crowley", EncounterSet.VoyageAcrossBelegaerCampaign, 35, 2, 2, 2, 2)
                .WithUnique()
                .WithBurden()
                .WithTraits("Corsair.", "Raider.")
                .WithTextLine("For each resource on Crowley, he gets +1 Threat, +1 Attack, +1 Defense, and +1 hit points. If Crowley has 3 or more resources on him, he gains victory 3.")
                .WithTextLine("Forced: When Crowley enages you, place 1 resource on him. At the end of the combat phase, return him to the staging area.")
                .WithInfo(178, 1, Artist.Rafal_Hrynkiewicz);

            cs.addAttachment("Spyglass", 0, Sphere.Neutral, false)
                .WithBoon()
                .WithTraits("Item.")
                .WithTextLine("When Spyglass leaves play, remove it from the game.")
                .WithTextLine("Action: Exhaust Spyglass to choose one:")
                .WithTextLine("• Look at a shadow card.")
                .WithTextLine("• Look at the top and bottom card of your deck.")
                .WithTextLine("• Place 1 progress on a location (2 progress instead if it is Uncharted).")
                .WithInfo(180, 1, Artist.Drazenka_Kimpel);

            cs.addAttachment("Black Key", 0, Sphere.Neutral, true)
                .WithBoon()
                .WithTraits("Item.", "Artifact.")
                .WithTextLine("When Black Key leaves play, remove it from the game.")
                .WithTextLine("Attached character gets +1 Willpower, +1 Attack, +1 Defense.")
                .WithInfo(183, 1, Artist.Tiziano_Baracchi);

            return cs;
        }
    }
}