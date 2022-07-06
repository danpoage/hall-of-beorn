using System;

namespace HallOfBeorn.Models.LotR.Sets.PreorderPromotion
{
    public class TheMinesOfMoriaPreorderPromotionSet
        : CardSet
    {
        public const string setName = "The Mines of Moria Preorder Promotion";
        private const string emptySetName = "";

        protected override void Initialize()
        {
            Name = setName;
            Abbreviation = "TMoM-PRM";
            Number = 7;
            SetType = Models.SetType.Preorder_Promotion;
            Cycle = "Custom Scenario Kit";

            addQuest("To the West-door", EncounterSet.TheMinesOfMoria, 1, 'A', 5)
                .WithFlavor("It has been years since there was news of Balin's expedition to Moria, but in recent months there have been rumors of growing darkness there. You traveled to the Mines to investigate these tidings. Upon reaching the Doors of Durin, you are surprised to find a foul-smelling pool at its feet, and a fell creature blocking your way.")
                .WithTextLine("Setup: Each player adds 1 resource to each of his heroes' resource pools. Add The Watcher to the staging area.")
                .WithOppositeTextLine("While this stage has at least 5 progress on it, The Watcher is considered to be engaged with each player and attacks each player in turn order during the combat phase. (Deal and resolve a shadow card for each attack.)")
                .WithOppositeTextLine("Forced: When The Watcher is defeated, flip it over and add Chamber of Mazarbul to the staging area.")
                .WithOppositeTextLine("This stage cannot be defeated while The Watcher is in play.")
                .WithPromotion()
                .WithInfo(1, 1, Artist.Ben_Zweifel);
            addEnemy("The Watcher", EncounterSet.TheMinesOfMoria, 50, 2, 4, 1, 4)
                .WithUnique()
                .WithTraits("Creature.")
                .WithTextLine("Immune to player card effects.")
                .WithTextLine("Cannot be optionally engaged.")
                .WithTextLine("The Watcher gets +2 Threat and +4 hit points per player.")
                .WithPromotion()
                .WithInfo(10, 1, Artist.Matthew_Starbuck);
            addLocation("Chamber of Mazarbul", EncounterSet.TheMinesOfMoria, Card.VALUE_X, 5)
                .WithUnique()
                .WithTraits("Underground.")
                .WithTextLine("X is 1 more than the stage number of the main quest.")
                .WithTextLine("Immune to player card effects.")
                .WithTextLine("The players cannot travel here unless they are at stage 3B.")
                .WithTextLine("Travel: Each player discards 1 random card from his hand.")
                .WithVictoryPoints(5)
                .WithPromotion()
                .WithInfo(11, 1, Artist.Emilio_Rodriguez);
            addLocation("Many-pillared Hall", emptySetName, 1, 4)
                .WithSetNumberAndCost(1, 0)
                .WithTraits("Underground.")
                .WithTextLine("Many-pillared Hall gets +1 Threat for each copy of Many-pillared Hall in the staging area.")
                .WithShadow("Shadow: Discard an attachment from the defending character.")
                .WithPromotion()
                .WithInfo(13, 1, Artist.Jose_Vega);
        }
    }
}
