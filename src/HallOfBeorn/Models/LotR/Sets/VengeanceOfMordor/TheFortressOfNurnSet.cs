using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace HallOfBeorn.Models.LotR.Sets.VengeanceOfMordor
{
    public class TheFortressOfNurnSet
        : CardSet
    {
        public const string setName = "The Fortress of Nurn";

        protected override void Initialize()
        {
            Name = setName;
            Abbreviation = "TFoN";
            Number = 62;
            SetType = Models.SetType.Adventure_Pack;
            Cycle = "Vengeance of Mordor";

            IsSpoiler = true;

            addHero("Aragorn", 12, Sphere.Spirit, 2, 3, 2, 5)
                .WithTraits("Dúnedain.", "Ranger.", "Scout.")
                .WithKeywords("Sentinel.")
                .WithTextLine("Sentinel.")
                .WithTextLine("Action: Exhaust Aragorn to choose a location in the staging area. Until the end of the phase, that location gets -X Threat, where X is Aragorn's Willpower. If this effect reduces the location's Threat to 0, place 1 progress on it. (Limit once per round.)")
                .WithInfo(137, 1, Artist.Aleksander_Karcz);
            addAttachment("Shining Shield", 1, Sphere.Leadership, false)
                .WithTraits("Armor.", "Item.")
                .WithKeywords("Restricted.")
                .WithTextLine("Attach to a Noble hero. Limit 1 per hero.")
                .WithTextLine("Restricted.")
                .WithTextLine("Attached hero gets +1 Defense (+2 Defense instead if your threat is 40 or higher).")
                .WithFlavorLine("...his shinning shield was scored with runs...")
                .WithFlavorLine("-The Fellowship of the Ring")
                .WithInfo(138, 3, Artist.Alvaro_Calvo_Escudero);
            addEvent("Knowledge of the Enemy", 0, Sphere.Leadership)
                .WithTextLine("Planning Action: Choose a hero you control. Add 1 resource to its resource pool for each enemy engaged with you. You can only play 1 Knowledge of the Enemy each round.")
                .WithFlavorLine("\"If a man must needs walk in sight of the Black Gate, or tread the deadly flowers of Morgul Vale, then perils he will have.\"")
                .WithFlavorLine("-Aragorm, The Fellowship of the Ring")
                .WithInfo(139, 3, Artist.Kevin_Zamir_Goeke);
            addAlly("Haleth", 4, Sphere.Lore, true, 2, 2, 1, 3)
                .WithTraits("Woodman.", "Scout.")
                .WithTextLine("Response: After Haleth quests successfully, search the top 5 cards of your deck for an attachment and add it to your hand. Shuffle your deck.")
                .WithInfo(140, 3, Artist.Kevin_Zamir_Goeke);
            addEvent("Woodman Lore", 1, Sphere.Lore)
                .WithTextLine("Action: Ready up to X Woodman characters you control, where X is the number of locations with player card attachments.")
                .WithFlavorLine("The Woodman said that there was some new terror abroad...")
                .WithFlavorLine("-The Fellowship of the Ring")
                .WithInfo(141, 3, Artist.Alyn_Spiller);
            addAlly("Westfold Lancer", 3, Sphere.Tactics, false, 2, 2, 0, 2)
                .WithTraits("Rohan.", "Warrior.")
                .WithTextLine("Response: After Westfold Lancer quests successfully, discard it to choose a non-unique enemy in the staging area. Deal 2 damage to the chosen enemy.")
                .WithFlavorLine("...the white fury of the Northmen burned the hotter, and more skilled was their knighthood with long spears...")
                .WithFlavorLine("-The Return of the King")
                .WithInfo(142, 3, Artist.Stanislav_Dikolenko);
            addAttachment("Tireless Thoroughbred", 2, Sphere.Tactics, false)
                .WithTraits("Mount.")
                .WithKeywords("Restricted.")
                .WithTextLine("Attach to a Warrior character.")
                .WithTextLine("Restricted.")
                .WithTextLine("Attached character gains ranged and sentinel.")
                .WithFlavorLine("Then he leapt forward, spurring the earth, and was gone like the north wine from the mountains.")
                .WithFlavorLine("-The Two Towers.")
                .WithInfo(143, 3, Artist.Carlos_Palma_Cruchaga);
            addAlly("Misty Mountain Journeyman", 1, Sphere.Spirit, false, 2, 0, 0, 1)
                .WithTraits("Dúnedain.", "Scout.")
                .WithTextLine("You cannot play Misty Mountain Journeyman from your hand unless you are engaged with an enemy.")
                .WithFlavorLine("Rangers passed at times beyond the hills, but they were few and did not stay.")
                .WithFlavorLine("-The Fellowship of the Ring")
                .WithInfo(144, 3, Artist.Aleksander_Karcz);
            addEvent("A Desperate Path", 2, Sphere.Spirit)
                .WithTextLine("At the end of the staging step, discard cards from the top of the encounter deck until you discard a treachery. Resolve its 'when revealed' effects to ready each of your questing characters. Each of your questing characters gets +1 Willpower until the end of the phase.")
                .WithInfo(145, 3, Artist.Aleksander_Karcz);
            addAttachment("Thorongil", 3, Sphere.Neutral, true)
                .WithTraits("Title.")
                .WithTextLine("Attach to a non-Fellowship, non-Baggins hero you control.")
                .WithTextLine("Response: After you attach Thorongil to a hero, search your collection for a different non-Fellowship, non-Baggins version of that hero and attach it to Thorongil. While Thorongil is in play, attached hero gains the game text and resource icon of the attached hero card. If Thorongil leaves play, remove the hero card attached to it from the game.")
                .WithInfo(146, 3, Artist.Chris_Grun);
            addContract("Bond of Friendship")
                .WithTextLine("Your deck must be exactly 50 players cards and include exactly 10 cards from each of these four spheres: Leadership, Lore, Spirit, and Tactics. You cannot include more than 2 copies of any card by title in your deck.")
                .WithTextLine("When choosing your starting heroes, you may choose 4 heroes instead of 3. Each of your heroes must belong to a different sphere.")
                .WithFlavorLine("\"You can trust us to stick to you through think and thin - to the bitter end.\"")
                .WithFlavorLine("-Merry, The Fellowship of the Ring")
                .WithInfo(147, 1, Artist.Borja_Pindado);
        }
    }
}