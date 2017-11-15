using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace HallOfBeorn.Models.LotR.Sets.PrintOnDemand
{
    public class AttackOnDolGuldurSet : CardSet
    {
        private const string setName = "Attack on Dol Guldur";
        private const string alternateName = "Assault on Dol Guldur";

        protected override void Initialize()
        {
            Name = setName;
            AlternateName = alternateName;
            Abbreviation = "AoDG";
            SetType = Models.SetType.Fellowship_Deck;
            Cycle = "GenCon";
            Number = 3008;

            addCard(LotRCard.Quest("Assault on the Golden Wood", 1, setName, 254)
                .WithFlavor("The Dark Lord of Mordor has declared war across Middle-earth. His Nazgûl lead the Morgul host against Minas Tirith in the south, while Easterlings lay siege to Erebor in the north. And in a move long-prepared, the armies of Dol Guldur cross the Anduin to assault Lórien...")
                .WithText("Setup: Set Host of Lórien and all 4 Lieutenant enemies aside, out of play. Add Power of Lórien and 1 copy of Dol Guldur Marauder per player to the staging area. Shuffle the encounter deck.")
                .WithOppositeText("Forced: At the end of the round, place 1 resource here and move all progress from this stage to Power of Lórien. If there are 3 resources here, advance to stage 2A.\r\nResponse: At the end of the round, raise each player's threat by 1 to choose a stage. Each player at that stage draws 1 card and adds 1 resource to a hero's resource pool.")
                .WithInfo(1, 1, Artist.Stanislav_Dikolenko));

            addCard(LotRCard.Campaign("Standard Game Mode", setName, "Standard Game Mode")
                .WithText("Setup: Add Dol Guldur to the staging area, attach a threat dial to it, and set its value to 5. Then, increase it's value by 5 for each player. For the rest of the game, that threat dial is the siege tracker and it displays the city strength of Dol Guldur. Flip this card over.")
                .WithFlavor("\"...we were drawing nigh to Dol Guldur, and that is still a very evil place; we do not go that way.\"\r\n-Legolas, The Fellowship of the Ring")
                .WithOppositeText("While Dol Guldur's city strength is 0, each Lieutenant enemy loses indestructible.\r\nWhile the players are at stage 3, this card gains: \"Forced: After resolving the Forced effect on Dol Guldur, randomly select a stage 3 that was not in play this round and resolve its Forced effect. Then, discard all progress from the current stage 3 and advance to a new stage 3 of your choice.\"\r\nAt the end of the round, if Dol Guldur's city strength is 0 and there are no Lieutenant enemies in play, Dol Guldur is captured and the players win the game.")
                .WithOppositeFlavor("After the fall of the Dark Tower and the passing of Sauron the Shadow was lifted from the hearts of all who opposed him, but fear and despair fell upon his servants and allies. -The Return of the King")
                .WithInfo(31, 1, Artist.Alvaro_Calvo_Escudero));
            addCard(LotRCard.Campaign("Epic Multiplayer Mode", setName, "Epic Multiplayer Mode")
                .WithText("Setup: Create 3 separate staging area, each with its own quest deck and encounter deck. Divide the players into 3 teams, one for each staging area. One team puts Dol Guldur into play in their staging area, attaches a threat dial to it, and sets its value to 5. Then, increase its value by 5 for each player at each stage. For the rest of the game, that threat dial is the siege tracker and it displays the city strength of Dol Guldur. Each other team removes their copy of Dol Guldur. Each other team removes their copy of Dol Guldur from the game. Flip this card over.")
                .WithFlavor("...there was long battle under the trees and great ruin of fire...\r\n-The Return of the King")
                .WithOppositeText("While Dol Guldur's city strength is 0, each Lieutenant enemy loses indestructible.\r\nWhile the players are at stage 3, this card gains: \"Forced: After resolving the Forced effect on Dol Guldur, the team with Dol Guldur in their staging area resolves the forced effect on the stage 3 that was not in play at any stage this round. Then, each team discards all progress from their stage 3 and advances to a new stage 3 of their choice. Each team must choose a different stage.\"\r\nResponse: At the end of the round, a player who controls Host of Lórien or Power of Lórien may give control of that card to another player at any stage.\r\nIf the last player at a stage is eliminated, the siege falls and the entire group loses the game. At the end of the round, if Dol Guldur's city strength is 0 and there are no Lieutenant enemies in play at each stage, Dol Guldur is captured and the players win the game.")
                .WithOppositeFlavor("They took Dol Guldur, and Galadriel threw down its walls and laid bare its pits, and the forest was cleared.\r\n-The Return of the King")
                .WithInfo(32, 1, Artist.Carlos_Palma_Cruchaga));

            addCard(LotRCard.Hero("Celeborn", string.Empty, Sphere.Leadership, 11, 3, 2, 2, 4)
                .WithTraits("Silvan.", "Noble.")
                .WithText("Response: After a Silvan ally enters play, that ally gets +1 Willpower, +1 Attack, and +1 Defense until the end of the round.")
                .WithInfo(1, 1, Artist.Drazenka_Kimpel));
        }
    }
}