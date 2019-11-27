/* Generated CardSet class: Beneath the Sands */

using System;

namespace HallOfBeorn.Models.LotR.Sets.Haradrim
{
    public class BeneathTheSandsSet : CardSet
    {
        protected override void Initialize()
        {
            Name = "Beneath the Sands";
            Abbreviation = "BtS";
            Number = 45;
            SetType = Models.SetType.Adventure_Pack;
            Cycle = "Haradrim";

            addHero("Hirgon", 9, Sphere.Tactics, 2, 2, 1, 4)
                .WithTraits("Gondor.", "Scout.")
                .WithTextLine("Response: After Hirgon quests successfully, play a Tactics ally from your hand, reducing its cost by 1 (to a minimum of 1). Then, you may raise your threat by 1 to give that ally +1 Attack and +1 Defense until the end of the round.")
                .WithFlavorLine("\"Hirgon I am, errand-rider of Denethor, who bring you this token of war.\"")
                .WithFlavorLine("-The Return of the King")
                .WithInfo(55, 1, Artist.Aleksander_Karcz);
            addAttachment("Haradrim Spear", 2, Sphere.Leadership, false)
                .WithTraits("Item.", "Weapon.")
                .WithKeywords("Restricted.")
                .WithTextLine("Attach to a Haradrim character.")
                .WithTextLine("Attached character gets +1 Attack.")
                .WithTextLine("Response: After attached character is declared as an attacker, it gets +3 Attack for this attack. After this attack resolves, discard Haradrim Spear.")
                .WithTemplate("<p class='main-text'>Attach to a {trait-character:Harad.@Harad} character. {keyword:Restricted.}</p><p class='main-text'>Attached character gets +1 {Attack}.</p><p class='main-text'><b>Response:</b> After attached character is declared as an attacker, it gets +3 {Attack} for this attack. After this attack resolves, discard {self}.</p>")
                .WithInfo(56, 3, Artist.Lucas_Durham);
            addEvent("Hunting Party", 1, Sphere.Leadership)
                .WithTextLine("Play only if you control a unique character with the Warrior trait and another unique character with the Scout trait.")
                .WithTextLine("Response: After the players have committed characters to the quest, discard a non-unique enemy in the staging area. Then, reveal an encounter card.")
                .WithInfo(57, 3, Artist.Andreia_Ugrai);
            addAttachment("The Red Arrow", 1, Sphere.Tactics, true)
                .WithTraits("Artifact.", "Item.")
                .WithTextLine("Limit 1 per deck. Attach to a Gondor hero.")
                .WithTextLine("Attached hero gets +1 Willpower.")
                .WithTextLine("Valour Response: After attached hero quests successfully, add The Red Arrow to the victory display to search the top 5 cards of your deck for an ally and put it into play.")
                .WithFlavorLine("\"The Red Arrow has not been seen in the Mark in all my years!\"")
                .WithFlavorLine("-Théoden, The Return of the King")
                .WithVictoryPoints(1)
                .WithInfo(58, 3, Artist.Stanislav_Dikolenko);
            addPlayerSideQuest("Keep Watch", 1, Sphere.Tactics, 6)
                .WithTextLine("Limit 1 copy of Keep Watch in the victory display.")
                .WithTextLine("While Keep Watch is in the victory display, each non-unique enemy engaged with a player gets -1 Attack.")
                .WithFlavorLine("\"I called for the help of the Dúnedain, and their watch was doubled...\"")
                .WithFlavorLine("-Gandalf, The Fellowship of the Ring")
                .WithVictoryPoints(1)
                .WithInfo(59, 3, Artist.Alvaro_Calvo_Escudero);
            addAlly("Rider of Rohan", 3, Sphere.Spirit, false, 2, 2, 0, 2)
                .WithTraits("Rohan.", "Scout.")
                .WithTextLine("While a side quest is in the victory display, Rider of ~Rohan does not exaust to quest.")
                .WithFlavorLine("\"Who are you, and what are you doing in this land?\" said the Rider, using the Common Speech of the West...")
                .WithFlavorLine("-The Two Towers")
                .WithInfo(60, 3, Artist.Javier_Charro_Martinez);
            addAttachment("Fireside Song", 2, Sphere.Spirit, false)
                .WithTraits("Song.")
                .WithTextLine("Attach to a Hobbit hero. Limit 1 per hero.")
                .WithTextLine("Attached hero gets +1 Willpower for each Song attached to it.")
                .WithFlavorLine("\"I sit beside the fire and think")
                .WithFlavorLine("of how the world will be")
                .WithFlavorLine("when winter comes without a spring")
                .WithFlavorLine("that I shall ever see.\"")
                .WithFlavorLine("-Bilbo Baggins, The Fellowship of the Ring")
                .WithInfo(61, 3, Artist.Jake_Murray);
            addAlly("Dúnedain Lookout", 2, Sphere.Lore, false, 1, 1, 1, 2)
                .WithTraits("Dúnedain.")
                .WithTextLine("Response: Discard Dúnedain Lookout to cancel the 'When Revealed' effects of an enemy just revealed from the encounter deck.")
                .WithFlavorLine("\"Travellers scowl at us, and countrymen gives us scornful names.\"")
                .WithFlavorLine("-Aragorn, The Fellowship of the Ring")
                .WithInfo(62, 3, Artist.Aleksander_Karcz);
            addAttachment("Doughty Ranger", 1, Sphere.Lore, false)
                .WithTraits("Skill.")
                .WithTextLine("Attach to a hero. Limit 1 per hero.")
                .WithTextLine("Attached hero gains the Ranger trait.")
                .WithTextLine("Response: After you play Doughty Ranger from your hand, draw a card.")
                .WithFlavorLine("...he went forth clad only in rusty green and brown, as a Ranger of the wilderness.")
                .WithFlavorLine("-The Fellowship of the Ring")
                .WithInfo(63, 3, Artist.Aleksander_Karcz);
            addEvent("The Free Peoples", 5, Sphere.Neutral)
                .WithTextLine("Play only if the characters you control have a total of at least 9 different Traits between them.")
                .WithTextLine("Action: Ready each character in play. Until the end of the phase, each character you control gets +1 Willpower.")
                .WithFlavorLine("\"For the rest, they shall represent the other Free Peoples of the World: Elves, Dwarves and Men.\"")
                .WithFlavorLine("-Elrond, The Fellowship of the Ring")
                .WithInfo(64, 3, Artist.Uriah_Voth);
            addEnemy("Brood Mother", EncounterSet.BeneathTheSands, 50, 4, 6, 4, 12)
                .WithUnique()
                .WithTraits("Creature.", "Spider.")
                .WithTextLine("Cannot have attachments. Cannot take damage.")
                .WithTextLine("Brood Mother engages the first player.")
                .WithTextLine("Forced: At the end of the round, search the encounter deck and discard pile for a Spider Broodling and add it to the staging area, if able. Shuffle the encounter deck.")
                .WithVictoryPoints(4)
                .WithInfo(65, 1, Artist.Dimitri_Bielak);
            addEnemy("Hive Guardian", EncounterSet.BeneathTheSands, 40, 3, 3, 2, 5)
                .WithTraits("Creature.", "Spider.")
                .WithTextLine("While On Track is in play, Hive Guardian gets +2 Attack and -5 engagement cost.")
                .WithShadow("Shadow: Attacking enemy gets +1 Attack (+2 Attack instead if On Track is in play).")
                .WithEasyModeQuantity(2)
                .WithInfo(66, 3, Artist.Sandara_Tang);
            addEnemy("Spider Broodling", EncounterSet.BeneathTheSands, 20, 1, 2, 1, 2)
                .WithTraits("Creature.", "Spider.")
                .WithTextLine("While On Track is in play, Spider Broodling gains surge.")
                .WithShadow("Shadow: If On Track is in play, put Spider Broodling into play engaged with you and deal it a shadow card.")
                .WithInfo(67, 5, Artist.Sergey_Glushakov);
            addLocation("Spider Burrow", EncounterSet.BeneathTheSands, 3, 2)
                .WithTraits("Underground.")
                .WithTextLine("Immune to player card effects.")
                .WithTextLine("Forced: After Spider Burrow becomes the active location, flip the Search objective to On Track and add Brood Mother to the staging area.")
                .WithTextLine("Forced: When Spider Burrow leaves play as an explored location, set Brood Mother aside, out of play (unless the players are at stage 3B).")
                .WithInfo(68, 2, Artist.Jokubas_Uoginitas);
            addLocation("Pitch Black Tunnel", EncounterSet.BeneathTheSands, Card.VALUE_X, 5)
                .WithTraits("Underground.")
                .WithKeywords("Track 4.")
                .WithTextLine("X is the number of characters controlled by the first player.")
                .WithTextLine("Travel: Reveal the top card of the encounter deck to travel here.")
                .WithEasyModeQuantity(1)
                .WithInfo(69, 2, Artist.Leanna_Crossan);
            addLocation("Nest of Vermin", EncounterSet.BeneathTheSands, 3, 4)
                .WithTraits("Underground.")
                .WithKeywords("Track 3.")
                .WithTextLine("Travel: Shuffle the encounter discard pile into the encounter deck and discard cards from the top until a Creature enemy is discarded. Add the discarded enemy to the staging area.")
                .WithFlavorLine("...a nasty, dirty, wet hole, filled with the ends of worms and an oozy smell...")
                .WithFlavorLine("-The Hobbit")
                .WithInfo(70, 2, Artist.Jokubas_Uoginitas);
            addLocation("Cobwebbed Cavern", EncounterSet.BeneathTheSands, 2, 3)
                .WithTraits("Underground.")
                .WithTextLine("While On Track is in play, Cobwebbed Cavern gets +2 Threat.")
                .WithShadow("Shadow: Exhaust a character you control.")
                .WithInfo(71, 3, Artist.Leanna_Crossan);
            addLocation("Blocked Passage", EncounterSet.BeneathTheSands, 2, 6)
                .WithTraits("Underground.")
                .WithKeywords("Track 2.")
                .WithTextLine("While On Track is in play, progress cannot be placed on locations in the staging area.")
                .WithShadow("Shadow: Discard an attachment you control.")
                .WithInfo(72, 3, Artist.Jokubas_Uoginitas);
            addTreachery("Forced Off Track", EncounterSet.BeneathTheSands)
                .WithTextLine("When Revealed: Either flip the Search objective to Off Track, or deal 1 damage to each questing character.")
                .WithShadow("Shadow: If On Track is in play, attacking enemy makes an additional attack against you after this one.")
                .WithEasyModeQuantity(2)
                .WithInfo(73, 3, Artist.Alvaro_Calvo_Escudero);
            addTreachery("Grabbed by Spiders", EncounterSet.BeneathTheSands)
                .WithKeywords("Surge.", "Doomed 1.")
                .WithTextLine("When Revealed: Attach to the main quest. Limit 1 per quest. (Counts as a Condition attachment with the text: \"Forced: After the Search objective is flipped to Off Track, each player discards an ally he controls. Then, discard Grabbed by Spiders.\"")
                .WithEasyModeQuantity(2)
                .WithInfo(74, 3, Artist.Rafal_Hrynkiewicz);
            addEncounterSideQuest("Lost Underground", EncounterSet.BeneathTheSands, 5)
                .WithTextLine("When Revealed: Flip the Search objective to Off Track. While Lost Underground is in play, the Search objective cannot flip. (Do not resolve the Track keyword.)")
                .WithTextLine("Response: When this stage is defeated, flip the Search objective to On Track and ignore its Forced effect until the end of the phase.")
                .WithFlavorLine("You've lost your way underground. You must retrace your steps to get on track.")
                .WithVictoryPoints(10)
                .WithInfo(75, 1, Artist.Jennifer_Hrabota_Lesser);
            addQuest("Searching the Caves", EncounterSet.BeneathTheSands, 1, 'A', 5)
                .WithTextLine("Setup: Set Brood Mother aside, out of play. Add the Search objective to the staging area (Off Track face up).")
                .WithFlavorLine("Several members of your group were seized by spiders in the night and dragged away from camp. When the sun came up, you followed their trail to a large cavern entrance and entered in.")
                .WithOppositeTextLine("When Revealed: Discard cards from the encounter deck until X locations are discarded, where X is the number of players. Add each location discarded by this effect to the staging area.")
                .WithOppositeFlavorLine("Inside the cavern entrance you find a large maze of tunnels criss-crossed with all manner of prints. It is impossible to discern which are the tracks you seek, so you begin to search all around.")
                .WithIncludedEncounterSets(EncounterSet.DesertCreatures, EncounterSet.HaradTerritory)
                .WithInfo(76, 1, Artist.Leanna_Crossan);
            addQuest("Getting Closer", EncounterSet.BeneathTheSands, 2, 'A', 5)
                .WithTextLine("When Revealed: Flip the Search objective to Off Track. Shuffle the encounter discard pile into the encounter deck and discard cards from the top until X enemies are discarded, where X is the number of players. Add each enemy discarded by this effect to the staging area.")
                .WithFlavorLine("It is hard to keep your way in the dark labyrinth, but you are certain that you are headed in the right direction.")
                .WithOppositeTextLine("While On Track is in play, encounter card effects cannot be canceled.")
                .WithOppositeFlavorLine("Cobwebs line the cavern walls and the spiders are growing more aggressive. You must be getting closer to their colony.")
                .WithIncludedEncounterSets(EncounterSet.DesertCreatures, EncounterSet.HaradTerritory)
                .WithInfo(77, 1, Artist.Marius_Bota);
            addQuest("The Spiders' Hive", EncounterSet.BeneathTheSands, 3, 'A', 5)
                .WithTextLine("When Revealed: The first player adds Brood Mother to the staging area. Each other player reveals an encounter card. Flip the Search objective to Off Track.")
                .WithFlavorLine("Your search has led you far underground, to a large cavern full of giant spider eggs. Along the walls, you see the cocooned bodies of your friends bound with many strands. At the center of the chamber is the enormous brood mother. She glares at you through many bulbous eyes and a poisonous froth bubbles from her fangs. You must find a way to defeat her in order to rescue your friends.")
                .WithOppositeTextLine("While there are at least 5 progress tokens on this stage, Brood Mother loses the text: \"Cannot take damage.\"")
                .WithOppositeTextLine("Forced: After the Search objective is flipped to Off Track, remove all progress tokens from this stage.")
                .WithOppositeTextLine("This stage cannot be defeated while Brood Mother is in play. If the players defeat this stage, they win the game.")
                .WithIncludedEncounterSets(EncounterSet.DesertCreatures, EncounterSet.HaradTerritory)
                .WithInfo(78, 1, Artist.Sandara_Tang);
            addObjective("Off Track", EncounterSet.BeneathTheSands)
                .WithTraits("Search.")
                .WithTextLine("Forced: At the end of the quest phase, place 1 progress here. Then, either return the topmost location in the encounter discard pile to the staging area, or raise each player's threat by 1 for each resource here.")
                .WithTextLine("Progress cannot be placed on the main quest.")
                .WithInfo(79, 1, Artist.Andreia_Ugrai);
            addObjective("On Track", EncounterSet.BeneathTheSands)
                .WithTraits("Search.")
                .WithTextLine("Forced: At the end of the quest phase, search the top 3 cards of the encounter deck for a card with 'On Track' in the lower right corner, add it to the staging area and discard the rest. If no card enters play from this effect, flip this objective.")
                .WithTextLine("Forced: After the players quest unsuccessfully, flip this objective.")
                .WithInfo(80, 1, Artist.Jennifer_Hrabota_Lesser);
        }
    }
}
