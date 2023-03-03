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

            return cs;
        }
    }
}