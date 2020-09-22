using System;

namespace HallOfBeorn.Models.LotR.Sets.PreorderPromotion
{
    public class EscapeFromKhazadDumPreorderPromotionSet
        : CardSet
    {
        public const string setName = "Escape from Khazad-dûm Preorder Promotion";
        private const string emptySetName = "";

        protected override void Initialize()
        {
            Name = setName;
            Abbreviation = "EfKD-PRM";
            Number = 8;
            SetType = Models.SetType.Preorder_Promotion;
            Cycle = "Custom Scenario Kit";

            addQuest("Search for an Exit", EncounterSet.EscapeFromKhazadDum, 2, 'A', 20)
                .WithOppositeTitle("A Way Up")
                .WithFlavorLine("The Mines of Moria are vast beyond your imagination. Though you feel that you are making progress, one wrong turn could mean disaster.")
                .WithTextLine("When Revealed: The opposing team searches the top 5 cards of the encounter deck for a card with cost 1 or less (cost 2 or less instead if there are two or more players), sets it aside, and shuffles the encounter deck. Reveal the set aside card. It's 'when revealed' effects cannot be canceled.")
                .WithOppositeTextLine("Add the active location's Threat to the staging area.")
                .WithOppositeTextLine("During the travel phase, the players must travel, if able.")
                .WithInfo(5, 1, Artist.Ben_Zweifel);
            addEnemy("Durin's Bane", EncounterSet.EscapeFromKhazadDum, 50, 4, 8, 3, 15)
                .WithUnique()
                .WithTraits("Balrog.")
                .WithTextLine("Immuned to player card effects.")
                .WithTextLine("Cannot be optionally engaged.")
                .WithTextLine("Forced: After Durin's Bane attacks and destroys a character you control, raise your threat by 2 and heal 2 damage from Durin's Bane.")
                .WithVictoryPoints(5)
                .WithInfo(11, 1, Artist.Magali_Villeneuve);
            addEnemy("Black Bats", emptySetName, 23, 1, 3, 1, 2)
                .WithSetNumberAndCost(15, 0)
                .WithTraits("Creature.")
                .WithTextLine("When Revealed: Eithe raise each player's threat by 2, or reveal an additional encounter card.")
                .WithShadow("Shadow: Either raise your threat by 2, or this attack is considered undefended.")
                .WithHorizontalArt()
                .WithInfo(12, 3, Artist.Lukasz_Jaskolski);
            addLocation("Lightless Grotto", emptySetName, 2, 3)
                .WithSetNumberAndCost(21, 0)
                .WithTraits("Underground.")
                .WithTextLine("While Lightless Grotto is in the staging area, non-unique enemies in the staging area cannot take damage.")
                .WithTextLine("Travel: The first player chooses an enemy in the staging area and engages it.")
                .WithHorizontalArt()
                .WithInfo(31, 2, Artist.Ivan_Dixon);
        }
    }
}
