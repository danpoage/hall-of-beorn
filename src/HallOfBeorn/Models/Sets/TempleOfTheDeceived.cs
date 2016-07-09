using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace HallOfBeorn.Models.Sets
{
    public class TempleOfTheDeceived : CardSet
    {
        private const string setName = "Temple of the Deceived";

        protected override void Initialize()
        {
            Name = setName;
            Abbreviation = "TotD";
            Number = 38;
            SetType = Models.SetType.Adventure_Pack;
            Cycle = "Dream-chaser";

            Cards.Add(Card.Hero("Elfhelm", "", Sphere.Leadership, 10, 2, 2, 2, 4)
                .WithTraits("Rohan.", "Scout.", "Warrior.")
                .WithText("Each Spirit hero with an attached Mount gets +1 Willpower.\r\nEach Tactics hero with an attached Mount gets +1 Attack.\r\nEach Leadership hero with an attached Mount gets +1 Defense.")
                .WithFlavor("Ahead nearer the walls Elfhelm's men were among the siege-engines, hewing, slaying, driving their foes into the fire-pits.\r\n-The Return of the King")
                .WithInfo(57, 1, Artist.DinoDrawing));
            Cards.Add(Card.Ally("Ceorl", "", Sphere.Leadership, 2, 1, 2, 0, 2)
                .WithUnique()
                .WithTraits("Rohan.", "Scout.")
                .WithText("Action: Spend 1 Spirit resource to ready Ceorl. Then, you may give control of Ceorl to another player. Any player may trigger this action. (Limit once per phase).")
                .WithFlavor("He drew himself up. Then he knelt, offering his notched sword to the king. \"Command me, lord!\" he cried.\r\n-The Two Towers")
                .WithInfo(58, 3, Artist.Aleksander_Karcz));
            Cards.Add(Card.Attachment("Armored Destrier", "", Sphere.Leadership, 2)
                .WithGeneric()
                .WithTraits("Mount.")
                .WithKeywords("Restricted.")
                .WithText("Attach to a Leadership or sentinel hero.\r\nResponse: After attached hero defends against an attack, exhaust Armored Destrier to ready attached hro. Then, discard a shadow card from another enemy engaged with the defending player.")
                .WithInfo(59, 3, Artist.Sandara_Tang));
            Cards.Add(Card.Ally("Déorwine", "", Sphere.Tactics, 4, 0, 1, 3, 3)
                .WithNormalizedTitle("Deorwine")
                .WithUnique()
                .WithKeywords("Sentinel.")
                .WithText("Action: While Déorwine is defending, spend 1 Leadership resource to cancel a shadow effect dealt to the attacking enemy. Any player may trigger this action.")
                .WithInfo(60, 3, Artist.Aleksander_Karcz));
            Cards.Add(Card.Event("Revealed in Wrath", "", Sphere.Tactics, 1)
                .WithText("Play only if you controla  Noldor hero.\r\nAction: Choose a non-unique enemy. Until the end of the phase, treat the chosen enemy's printed text box as if it were blank (except for Traits).")
                .WithFlavor("\"...seeing an Elf-lord revealed in his wrath, they were dismayed, and their horses were stricken with madness.\"\r\n-Gandalf, The Fellowship of the Ring")
                .WithInfo(61, 3, Artist.Sebastian_Giacobino));
            Cards.Add(Card.Ally("Rhovanion Outrider", "", Sphere.Spirit, 3, 1, 2, 1, 2)
                .WithGeneric()
                .WithTraits("Dale.", "Scout.")
                .WithText("Response: After Rhovanion Outrider coomits to the quest, place 1 progress on a location in the staging area. If that location is not explored by this effect, give Rhovanion Outrider +1 Willpower until the end of the phase.")
                .WithInfo(62, 3, Artist.Beth_Sobel));
            Cards.Add(Card.Event("Scouting Party", "", Sphere.Spirit, 2)
                .WithText("Response: After you commit characters to the quest, if each character you have commited to the quest is a Scout, each of these characters gets +2 Willpower until the end of the phase.")
                .WithInfo(63, 3, Artist.Guillaume_Ducos));
            Cards.Add(Card.Attachment("Entangling Nets", "", Sphere.Lore, 1)
                .WithGeneric()
                .WithTraits("Trap.")
                .WithText("Play Entagling Nets into the staging area, unattached.\r\nIf unattached, attach Entangling Nets to the next eligible enemy that enters the staging area.\r\nAttached enemy gets -2 Attack and -2 Defense.")
                .WithInfo(64, 3, Artist.Sam_Lamont));
            Cards.Add(Card.Event("Arrows from the Trees", "", Sphere.Lore, 1)
                .WithText("Play only after making engagement checks.\r\nEncounter Action: If no enemies were engaged this phase, deal 1 damage to each enemy in the staging area. Then, the players as a group may spend 3 Tactics resources to deal 2 additional damage to each enemy in the staging area.")
                .WithInfo(65, 3, Artist.Tristan_Denecke));
            Cards.Add(Card.Ally("Ered Luin Miner", "", Sphere.Neutral, 3, 1, 1, 1, 2)
                .WithTraits("Dwarf.")
                .WithText("Response: After Ered Luin Miner is discarded from the top of your deck, put it into play under your control.")
                .WithFlavor("Tools were to be found in plenty that the miners and quarriers and builders of old had used; and at such work the dwarves were still very skilled.\r\n-The Hobbit")
                .WithInfo(66, 3, Artist.Lukasz_Jaskolski));
        }
    }
}