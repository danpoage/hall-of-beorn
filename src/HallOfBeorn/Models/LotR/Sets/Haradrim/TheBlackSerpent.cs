using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace HallOfBeorn.Models.LotR.Sets.Haradrim
{
    public class TheBlackSerpent : CardSet
    {
        protected override void Initialize()
        {
            Name = "The Black Serpent";
            Abbreviation = "TBS";
            Number = 46;
            SetType = Models.SetType.Adventure_Pack;
            Cycle = "Haradrim";

            addCard(LotRCard.Hero("Fastred", string.Empty, Sphere.Spirit, 9, 1, 2, 3, 3)
                .WithTraits("Rohan.", "Warrior.")
                .WithText("Response: After Fastred defends an enemy attack, return that enemy to the staging area to reduce your threat by 2. (Limit once per phase.)")
                .WithFlavor("\"King's man! King's man!\" his heart cried within him.\r\n-The Return of the King")
                .WithInfo(81, 1, Artist.Lukasz_Jaskolski));
            addCard(LotRCard.Attachment("Song of Hope", string.Empty, Sphere.Leadership, 0)
                .WithTraits("Song.")
                .WithText("Attach to a hero. Limit 1 per hero.\r\nAction: Spend 1 resource from attached hero's pool to give attached hero +1 Willpower until the end of the phase. (Limit 3 times per phase.)")
                .WithFlavor("\"I will not say the Day is done.\r\nnor bid the Stars farewell.\"\r\n-Sam Gamgee, The Return of the King")
                .WithInfo(82, 3, Artist.Micah_Epstein));
            addCard(LotRCard.Event("Burst into Song", string.Empty, Sphere.Leadership, 2)
                .WithText("Action: Ready each hero with a Song attachment.")
                .WithFlavor("And then all the host of Rohan burst into song, and they sang as they slew, for the joy of battle was on them, and the sound of their singing that was fair and terrible came even to the City.\r\n-The Return of the King")
                .WithInfo(83, 3, Artist.Javier_Charro_Martinez));
            addCard(LotRCard.Ally("Defender of Cair Andros", Sphere.Tactics, 4, 1, 1, 0, 3)
                .WithTraits("Gondor.", "Warrior.")
                .WithText("Defender of Cair Andros gets +X Defense, where X is the tens digit of your threat. (Limit +4 [Defense].)\r\nValour Response: After Defender of Cair Andros is declared as a defender, deal 1 damage to the attacking enemy.")
                .WithInfo(84, 3, Artist.Kim_Sokol));
            addCard(LotRCard.Event("Oath of Eorl", string.Empty, Sphere.Tactics, 3)
                .WithText("Play only if you control a unique character with the Rohan trait and another unique character with the Gondor trait.\r\nResponse: At the beginning of the combat phase, you resolve the step in which you attack enemies before resolving enemy attacks this phase. (Each other player resolves the combat phase as normal after you resolve your attacks.)")
                .WithInfo(85, 3, Artist.Rafal_Hrynkiewicz));
            addCard(LotRCard.Attachment("Fearless Scout", string.Empty, Sphere.Spirit, 1)
                .WithTraits("Skill.")
                .WithText("Attach to a hero. Limit 1 per hero.\r\nAttached hero gains the Scout trait.\r\nResponse: After you play Fearless ~Scout from your hand, draw a card.")
                .WithFlavor("...he got right up to the fire-for fire it was-without disturbing anyone. -The Hobbit")
                .WithInfo(86, 3, Artist.Andreia_Ugrai));
            addCard(LotRCard.PlayerSideQuest("Rally the West", string.Empty, Sphere.Spirit, 1, 6)
                .WithFlavor("\"Foes and fire are before you, and your homes far behind. Yet, though you fight upon an alien field, the glory that you reap there shall be your own for ever.\"\r\n-Théoden, The Return of the King")
                .WithText("Limit 1 copy of Rally the West in the victory display.\r\nWhile this quest is in the victory display, each hero gets +1 Willpower.")
                .WithVictoryPoints(1)
                .WithInfo(87, 3, Artist.Stanislav_Dikolenko));
            addCard(LotRCard.Attachment("Dúnedain Pipe", string.Empty, Sphere.Lore, 1)
                .WithTraits("Item.", "Pipe.")
                .WithText("Attach to a ~Dúnedain character. Limit 1 per character.\r\nAction: Exhaust ~Dúnedain ~Pipe and place a card from your hand on the bottom of your deck to draw a card.")
                .WithFlavor("He had a tall tankard in front of him, and was smoking a long-stemmed pipe curiously carved.\r\n-The Fellowship of the Ring")
                .WithInfo(88, 3, Artist.Dani_Hartel));
            addCard(LotRCard.Event("Old Toby", string.Empty, Sphere.Lore, 2)
                .WithTraits("Pipeweed.")
                .WithText("Action: Draw 1 card for each Pipe you control. Heal 1 damage from each hero with a Pipe attachment.")
                .WithFlavor("How Old Toby came by the plant is not recorded, for to his dying day he would not tell.\r\n-The Fellowship of the Ring")
                .WithInfo(89, 3, Artist.Jason_Juta));
            addCard(LotRCard.Ally("Southron Refugee", Sphere.Neutral, 2, 1, 1, 0, 2)
                .WithTraits("Harad.")
                .WithText("Action: Exhaust Southron Refugee to reduce the cost of the next Harad ally you play this phase by 1.")
                .WithFlavor("...to the land of the Haradrim came only a tale from far off...\r\n-The Return of the King")
                .WithInfo(90, 3, Artist.Nikolas_Hagialas));
        }
    }
}