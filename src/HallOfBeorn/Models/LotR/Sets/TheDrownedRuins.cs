using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace HallOfBeorn.Models.LotR.Sets
{
    public class TheDrownedRuins : CardSet
    {
        private string setName = "The Drowned Ruins";

        protected override void Initialize()
        {
            Name = setName;
            Abbreviation = "TDRu";
            Number = 39;
            SetType = Models.SetType.Adventure_Pack;
            Cycle = "Dream-chaser";

            Cards.Add(LotRCard.Hero("Argalad", string.Empty, Sphere.Lore, 9, 2, 2, 1, 4)
                .WithTraits("Silvan.", "Scout.")
                .WithKeywords("Ranged.")
                .WithText("Action: Exhaust Argalad to choose an enemy in the staging area. Until the end of the phase, that enemy gets -X Threat, where X is Argalad's Attack. If this effect reduces the enemy's Threat to 0, deal 1 damage to it. (Limit once per round.)")
                .WithInfo(82, 1, Artist.Andreia_Ugrai));
            Cards.Add(LotRCard.Ally("Dwarven Sellsword", Sphere.Leadership, 1, 2, 2, 2, 3)
                .WithTraits("Dwarf.", "Warrior.")
                .WithText("Forced: At the end of the round, discard Dwarven Sellsword unless the players as a group spend 1 Leadership resource.")
                .WithFlavor("...he did not altogether approve of dwarves and their love of gold...\r\n-The Hobbit")
                .WithInfo(83, 3, Artist.Marius_Bota));
            Cards.Add(LotRCard.Attachment("Dúnedain Remedy", string.Empty, Sphere.Leadership, 0)
                .WithTraits("Signal.")
                .WithText("Attach to a hero.\r\nResponse: After ~Dúnedain Remedy is attached to a hero, heal 1 damage on that hero.\r\nAction: Pay 1 resource from attached hero's resource pool to attach ~Dúnedain Remedy to another hero.")
                .WithInfo(84, 3, Artist.Drazenka_Kimpel));
            Cards.Add(LotRCard.Ally("Marksman of Lórien", Sphere.Tactics, 3, 0, 3, 0, 2)
                .WithTraits("Silvan.", "Warrior.")
                .WithKeywords("Ranged.")
                .WithText("Response: After Marksman of Lórien enters play, choose an enemy. That enemy gets -2 Defense until the end of the round.")
                .WithFlavor("\"Keen are the eyes of the Elves.\"\r\n-Aragorn, The Two Towers")
                .WithInfo(85, 3, Artist.Drazenka_Kimpel));
            Cards.Add(LotRCard.Event("Battle-fury", string.Empty, Sphere.Tactics, 1)
                .WithText("Play only before the staging step.\r\nQuest Action: Exhaust a hero you control to immediately declare it as an attacker (and resolve its attack) against any eligible enemy target. Then, the players as a group may spend 1 Spirit resource to commit that hero to the quest.")
                .WithFlavor("Fey he seemed, or the battle-fury of his fathers ran like new fire in his veins...\r\n-The Return of the King")
                .WithInfo(86, 3, Artist.Guillaume_Ducos));
            Cards.Add(LotRCard.Ally("Woodland Courier", Sphere.Spirit, 2, 1, 1, 0, 1)
                .WithTraits("Silvan.", "Scout.")
                .WithText("Response: After Woodland Courier enters play, place 1 progress on a location (2 progress instead if that location has the Forest trait).")
                .WithInfo(87, 3, Artist.Drazenka_Kimpel));
            Cards.Add(LotRCard.Attachment("Hithlain", "", Sphere.Spirit, 1)
                .WithTraits("Item.")
                .WithText("Attach to a location. Limit 1 per location.\r\nResponse: After a player plays a Silvan ally from his hand, place 1 progress on attached location.")
                .WithFlavor("He made his end of the rope fast about another tree, and then ran lightly along it, over the river and back again, as if he were on a round.\r\n-The Fellowship of the Ring")
                .WithInfo(88, 3, Artist.Mariusz_Gandzel));
            Cards.Add(LotRCard.Ally("Robin Smallburrow", Sphere.Lore, 2, 2, 0, 1, 2)
                .WithUnique()
                .WithTraits("Hobbit.", "Shirriff.")
                .WithText("Response: After you travel to a location, spend 1 Spirit resource to raise the engagement cost of each enemy in play by X until the end of the round, where X is that location's quest points. Any player may trigger this response.")
                .WithFlavor("\"Gave me a chance of walking round the country and seeing folk, and hearing the news, and knowing where the good beer was.\"\r\n-The Return of the King")
                .WithInfo(89, 3, Artist.Aleksander_Karcz));
            Cards.Add(LotRCard.Event("Interrogation", string.Empty, Sphere.Lore, 1)
                .WithText("Action: Choose an enemy with an attached Trap card. Look at the top X cards of the encounter deck, where X is that enemy's printed Threat. You may discard 1 of those cards. Return the rest to the top of the deck, in the same order.")
                .WithInfo(90, 3, Artist.Joshua_Cairos));
            Cards.Add(LotRCard.Attachment("Strider", "", Sphere.Neutral, 1)
                .WithUnique()
                .WithText("Attach to a hero.\r\nWhile you control 2 or fewer heroes, attached hero does not exhaust to commit to the quest.\r\nWhile you control 5 or fewer characters, attached hero gets +2 Willpower.")
                .WithFlavor("\"Strider can take you by paths that are seldom tridden. Will you have him?\"\r\n-Aragorn, The Fellowship of the Ring")
                .WithInfo(91, 3, Artist.Ken_McCuen));

            Cards.Add(LotRCard.Quest("The Grotto", 1, setName, 15)
                .WithFlavor("In the sunken ruins of the temple, you find a grotto leading deep below the sea level. Much of the grotto is submerged underwater.")
                .WithText("Setup: Set Shrine to Morgoth aside, out of play. Prepare the ~Grotto deck. Add the top 2 locations from the ~Grotto deck to the staging area, Grotto side faceup (the top 3 instead if there are 3 or more players in the game). The first player takes control of ~Captain Sahír, and the last player takes control of Na'asiyah (objective-ally sides faceup).")
                .WithOppositeText("While an underwater location is the active location, players cannot play attachments or allies.\r\nForced: After a double-sided location is explored, add the top location from the ~Grotto deck to the staging area, Grotto side faceup.\r\nYou cannot advance unless there are at least 3 Underwater locations in the victory display.")
                .WithIncludedEncounterSets(EncounterSet.TheStormcallerElite, EncounterSet.DrownedDead)
                .WithInfo(92, 1, Artist.Mariusz_Gandzel));
            Cards.Add(LotRCard.Quest("Sahír's Betrayal", 2, setName, null)
                .WithFlavor("In the center of the shrine, reverently placed on a large altar, lies a long black chest. As soon as you get close, Sahír knocks one of the heroes over and grabs it!")
                .WithText("When Revealed: Make the set aside Shrine to Morgoth the active location, Grotto side faceup. ~Captain Sahír flips to his enemy side (removing all tokens) and makes an immediate attack against the first player. Remove ~Captain Sahír from the game. Each player searches the encounter deck and discard pile for an Undead enemy and adds it to the staging area. Shuffle the encounter deck.")
                .WithOppositeFlavor("You dive at Sahír, but he swiftly runs to the entrance, laughing as he seals you in. \"Captain?! What about me?\" Na'asiyah scream angrily. As soon as the entrace is sealed shut, the walls shudder, and water begins to leak rapidly from the ceiling and walls. \"We have to get out of here!\" the heroes shout, as the water level starts to rise.")
                .WithOppositeText("While an Underwater location is the active location, players cannot play attachments or allies.")
                .WithIncludedEncounterSets(EncounterSet.TheStormcallerElite, EncounterSet.DrownedDead)
                .WithInfo(93, 1, Artist.Sara_Winters));
            Cards.Add(LotRCard.Location("Shrine to Morgoth", string.Empty, setName, 5, 18)
                .WithUnique()
                .WithSuffix("Grotto")
                .WithTraits("Ruins.", "Underground.", "Grotto.")
                .WithText("Shrine to Morgoth cannot have attachments and cannot enter the staging area.\r\nForced: At the beginning of the quest phase, flip Shrine to Morgoth to its Underwater side, without removing its progress tokens.\r\nWhen Shrine to Morgoth is placed in the victory display, the players have escaped from the flooded grotto and win the game.")
                .WithVictoryPoints(5)
                .WithInfo(94, 1, Artist.Federico_Musetti));
            Cards.Add(LotRCard.Location("Shrine to Morgoth", string.Empty, setName, 5, 18)
                .WithUnique()
                .WithSuffix("Underwater")
                .WithTraits("Ruins.", "Underground.", "Underwater.")
                .WithText("Shrine to Morgoth cannot have attachments and cannot enter the staging area.\r\nForced: If Shrine to Morgoth is the active location at the end of the quest phase, raise each player's threat by 5.\r\nWhen Shrine to Morgoth is placed in the victory display, the players have escaped the flooded grotto and win the game.")
                .WithVictoryPoints(5)
                .WithInfo(95, 1, Artist.Federico_Musetti));
            Cards.Add(LotRCard.Enemy("Sea-scorpion", string.Empty, setName, 30, 2, 2, 2, 4)
                .WithTraits("Creature.")
                .WithText("Sea-scorpion gets +2 Attack if the active location is underwater.")
                .WithShadow("Shadow: Attacking enemy gets +1 Attack (+2 Attack instead if the active location is Underwater).")
                .WithInfo(96, 3, Artist.Aleksander_Karcz));
            Cards.Add(LotRCard.Enemy("Cave Eel", string.Empty, setName, 20, 3, 3, 4, 2)
                .WithTraits("Creature.")
                .WithText("Cave Eel cannot be engaged unless the active location is underwater.\r\nForced: At the beginning of the encounter phase, return Cave Eel to the staging area unless the active location is Underwater.")
                .WithEasyModeQuantity(2)
                .WithInfo(97, 3, Artist.Lukasz_Jaskolski));
            Cards.Add(LotRCard.Location("Undersea Grotto", string.Empty, setName, 2, 3)
                .WithTraits("Underground.", "Grotto.")
                .WithText("While Undersea Grotto is the active location, reduce the cost of the first ally played by the players each round by 1.\r\nResponse: After you travel to Undersea Grotto, you may flip it to its Underwater side.")
                .WithInfo(98, 3, Artist.Mariusz_Gandzel));
            Cards.Add(LotRCard.Location("Cursed Caverns", string.Empty, setName, 3, 5)
                .WithTraits("Underground.", "Grotto.")
                .WithText("Response: After you travel to Cursed Caverns, you may flip it to its Underwater side.\r\nResponse: After the players explore Cursed Caverns as the active location, each player may raise his threat by 2 to draw the bottom card of his deck.")
                .WithInfo(99, 3, Artist.Timo_Karhula));
            Cards.Add(LotRCard.Location("Watter-logged Halls", string.Empty, setName, 2, 4)
                .WithTraits("Ruins.", "Underground.", "Grotto.")
                .WithText("While Water-logged Halls is the active location, each Undead enemy in play gets -1 Threat.\r\nResponse: After you travel to Water-logged Halls, you may flip it to its Underwater side.")
                .WithInfo(100, 2, Artist.Mariusz_Gandzel));
            Cards.Add(LotRCard.Location("Dark Abyss", string.Empty, setName, 5, 12)
                .WithTraits("Underground.", "Underwater.")
                .WithText("While Dark Abyss is the active location, characters cannot attack.\r\nForced: If Dark Abyss is the active location at the end of the quest phase, deal 1 damage to each character in play. Then, you may flip Dark Abyss to its Grotto side.")
                .WithVictoryPoints(2)
                .WithInfo(101, 3, Artist.Niten));
            addCard(LotRCard.Location("Twisting Hollow", string.Empty, setName, 4, 14)
                .WithTraits("Underground.", "Underwater.")
                .WithText("While Twisting Hollow is the active location, characters cannot ready from card effects.\r\nForced: If Twisting Hollow is the active location at the end of the quest phase, each player must discard 1 character. Then, you may flip Twisting Hollow to its Grotto side.")
                .WithVictoryPoints(2)
                .WithInfo(102, 3, Artist.Niten));
            Cards.Add(LotRCard.Location("Sunken Temple", string.Empty, setName, 3, 10)
                .WithTraits("Ruins.", "Underground.", "Underwater.")
                .WithText("While Sunken Temple is the active location, treat each attachment as if its printed text box is blank (except for Traits).\r\nForced: If Sunken Temple is the active location at the end of the quest phase, discard 1 resource from each objective-ally an each hero's resource pool. Then, you may flip Sunken Temple to its Grotto side.")
                .WithVictoryPoints(2)
                .WithInfo(103, 2, Artist.Federico_Musetti));
            Cards.Add(LotRCard.Location("Drowned Cave", string.Empty, setName, 3, 4)
                .WithTraits("Underground.", "Underwater.")
                .WithText("While Drowned Cave is the active location, Undead enemies cannot be engaged (return any engaged enemies to the staging area).\r\nForced: If Drowned Cave is the active location at the end of the quest phase, each player must discard the top 10 cards of his deck. Then, you may return Drowned Cave to the staging area.")
                .WithInfo(104, 2, Artist.Jordan_Saia));
            Cards.Add(LotRCard.Treachery("Powerful Undertow", string.Empty, setName)
                .WithTraits("Hazard.")
                .WithText("When Revealed: You cannot flip the active location this round. If the active location is Underwater, resolve its Forced effect as if it is the end of the quest phase. If there is no Underwater active location, Powerful Undertow gains doomed 3, instead.")
                .WithEasyModeQuantity(1)
                .WithInfo(105, 3, Artist.Jake_Bullock));
            Cards.Add(LotRCard.Treachery("Into the Abyss", string.Empty, setName)
                .WithText("When Revealed: Each player chooses a card type and discards each card in his hand that is not of the chosen type. If no cards are discarded by this effect, Into the Abyss gains surge.")
                .WithShadow("Shadow: If the active location is Underwater, search the encounter deck and discard pile for a Creature enemy, and add it to the staging area.")
                .WithInfo(106, 3, Artist.Jordan_Saia));
            Cards.Add(LotRCard.Treachery("Tangling and Grasping", string.Empty, setName)
                .WithTraits("Hazard.")
                .WithText("When Revealed: Each player must remove a character from the quest. If the active location is Underwater, deal 2 damage to each character removed from the quest by this effect.")
                .WithShadow("Shadow: Discard an attachment you control.")
                .WithInfo(107, 4, Artist.Lukasz_Jaskolski));
            Cards.Add(LotRCard.Treachery("Ancient Depths", string.Empty, setName)
                .WithText("When Revealed: Add the top location from the Grotto deck to the staging area and flip that location to its Underwater side. This effect cannot be canceled.")
                .WithShadow("Shadow: Attacking enemy gets +1 Attack (+2 Attack instead if the active location is Underwater).")
                .WithEasyModeQuantity(1)
                .WithInfo(108, 3, Artist.Beth_Sobel));
        }
    }
}