using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace HallOfBeorn.Models.Sets
{
    public class AcrossTheEttenmoors : CardSet
    {
        protected override void Initialize()
        {
            Name = "Across the Ettenmoors";
            Abbreviation = "AtE";
            Number = 32;
            SetType = Models.SetType.Adventure_Pack;
            Cycle = "Angmar Awakened";

            Cards.Add(Card.Hero("Dori", "", Sphere.Tactics, 10, 1, 2, 2, 5)
                .WithTraits("Dwarf.")
                .WithKeywords("Sentinel.")
                .WithText("Response: After another hero is declared as a defender, exhaust Dori to add his Defense to the defending hero's Defense for this attack.")
                .WithFlavor("Dori was really a decent fellow in spite of his grumbling.\r\n-The Hobbit")
                .WithTemplate("<p><b>Response:</b> After another hero is declared as a defender, exhaust {self} to add his {Defense} to the defending hero's {Defense} for this attack.</p><p style='text-align:center;'><i>Dori was really a decent fellow in spite of his grumbling.<br>&ndash;The Hobbit</i></p>")
                .WithInfo(54, 1, Artist.Sebastian_Giacobino));
            Cards.Add(Card.Attachment("Ranger Provisions", "", Sphere.Leadership, 1)
                .WithTraits("Item.")
                .WithText("Attach to a location. Limit 1 per location.\r\nResponse: After attached location is explored, the first player adds 1 resource to each of his heroes' resource pools.")
                .WithFlavor("\"Rangers have been here lately. It is they who left the firewood behind.\"\r\n-Aragorn, The Fellowship of the Ring")
                .WithInfo(55, 3, Artist.Drazenka_Kimpel));
            Cards.Add(Card.Event("Dúnedain Message", "", Sphere.Leadership, 1)
                .WithNormalizedTitle("Dunedain Message")
                .WithTraits("Signal.")
                .WithText("Action: Search your deck for a side quest and add it to your hand. Suffle your deck.")
                .WithFlavor("\"I called for the help of the Dúnedain, and their watch has doubled...\"\r\n-Gandalf, The Fellowship of the Ring")
                .WithInfo(56, 3, Artist.Sara_Biddle));
            Cards.Add(Card.Ally("Longbeard Sentry", "", Sphere.Tactics, 3, 0, 1, 2, 3)
                .WithGeneric()
                .WithTraits("Dwarf.", "Warrior.")
                .WithText("Action: Discard 2 cards from the top of your deck to give Longbeard Sentry sentinel and +1 Defense until the end of the phase. (Limit once per phase.)")
                .WithFlavor("\"...many of them have had experience in the dreadful dwarf and goblin wars, of which you have no doubt heard.\"\r\n-Bilbo Baggins, The Hobbit")
                .WithInfo(57, 3, Artist.Michele_Frigo));
            Cards.Add(Card.PlayerSideQuest("Delay the Enemy", "", Sphere.Tactics, 0, 8)
                .WithKeywords("Battle.")
                .WithText("Limit 1 per deck.\r\nResponse: When this stage is defeated, each player may choose and discard a non-unique enemy engaged with him.")
                .WithVictoryPoints(1)
                .WithInfo(58, 3, Artist.Mark_Behm));
            Cards.Add(Card.Attachment("Steed of Imladris", "", Sphere.Spirit, 1)
                .WithTraits("Mount.")
                .WithKeywords("Restricted.")
                .WithText("Attach to a Spirit or Noldor hero.\r\nResponse: After attached hero commits to a quest, discard a card from your hand to place 2 progress on the active location.")
                .WithFlavor("In the dusk its headstall flickered and flashed, as if it were studded with gems like living stars.\r\n-The Fellowship of the Ring")
                .WithInfo(59, 3, Artist.Eva_Maria_Toker));
            Cards.Add(Card.Event("Fair and Perilous", "", Sphere.Spirit, 1)
                .WithText("Action: Choose a Noldor or Silvan character.\r\nUntil the end of the phase, add that character's Willpower to its Attack.")
                .WithFlavor("\"...you saw him for a moment as he is upon the other side: one of the mighty of the Firstborn.\"\r\n-Gandalf, The Fellowship of the Ring")
                .WithInfo(60, 3, Artist.Magali_Villeneuve));
            Cards.Add(Card.Ally("Wellinghall Preserver", "", Sphere.Lore, 3, 3, 2, 2, 3)
                .WithGeneric()
                .WithTraits("Ent.")
                .WithText("Cannot have restricted attachments.\r\nEnters play exhausted.\r\nResponse: After Wellinghall Preserver readies, heal 1 damage from an Ent character.")
                .WithInfo(61, 3, Artist.Tomasz_Jedruszek));
            Cards.Add(Card.Event("None Return", "", Sphere.Lore, 1)
                .WithText("Limit 3 copies of None Return in the victory display.\r\nResponse: After a non-unique enemy is destroyed, add None Return to the victory display to add that enemy to the victory display.")
                .WithFlavor("\"None of the Orcs will ever return out of Lórien.\"\r\n-Haldir, The Fellowship of the Ring")
                .WithInfo(62, 3, Artist.Kip_Ayers));
            Cards.Add(Card.Event("Hope Rekindled", "", Sphere.Neutral, 0)
                .WithTraits("Song.")
                .WithText("Action: Reduce the cost of the next event that has a Valour trigger you play this phase by 2.\r\nValour Action: Search the top 10 cards of your deck for an event that has a Valour trigger and add it to your hand. Shuffle your deck.")
                .WithFlavor("Hope he rekindled, and in hope ended;\r\nover death, over dread, over doom lifted\r\nout of loss, out of life, unto long glory.\r\n-The Return of the King")
                .WithTemplate("<p><b>Action:</b> Reduce the cost of the next event that has a <b>Valour</b> trigger you play this phase by 2.</p><p><b>Valour Action:</b> Search the top 10 cards of your deck for an event that has a <b>Valour</b> trigger and add it to your hand. Shuffle your deck.</p><p style='text-align:center'><i>Hope he rekindled, and in hope ended;<br>over death, over dread, over doom lifted<br>out of loss, out of life, unto long glory.<br>&ndash;The Return of the King</i></p>")
                .WithInfo(63, 3, Artist.Gabrielle_Portal));
        }
    }
}