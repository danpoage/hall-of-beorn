using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace HallOfBeorn.Models.LotR.Sets.Haradrim
{
    public class TheMumakil : CardSet
    {
        private const string setName = "The Mûmakil";

        protected override void Initialize()
        {
            Name = "The Mûmakil";
            NormalizedName = "The Mumakil";
            Abbreviation = "TMk";
            Number = 43;
            SetType = Models.SetType.Adventure_Pack;
            Cycle = "Haradrim";

            addCard(LotRCard.Hero("Kahliel", string.Empty, Sphere.Leadership, 10, 2, 2, 2, 4)
                .WithTraits("Harad.", "Noble.")
                .WithText("You may use resources from Kahliel's resource pool to pay for Harad ally cards of any sphere.\r\nAction: Discard a Harad ally card from your hand to ready a Harad character in play. (Limit once per phase.)")
                .WithFlavor("...the Southrons were bold men and grim...\r\n-The Return of the King")
                .WithInfo(1, 1, Artist.Ryan_Valle));
            addCard(LotRCard.Ally("Andrath Guardsman", Sphere.Leadership, 2, 1, 0, 1, 2)
                .WithTraits("Dúnedain.", "Ranger.")
                .WithText("Response: After you play Andrath Guardsman from your hand, choose a non-unique enemy engaged with you. That enemy cannot attack you this round.")
                .WithFlavor("They forgot or ignored what little they had known of the Guardians, and of the labours of those that made possible the long peace of the Shire.\r\n-The Fellowship of the Ring")
                .WithInfo(2, 3, Artist.Adam_Lane));
            addCard(LotRCard.PlayerSideQuest("Prepare for Battle", string.Empty, Sphere.Leadership, 1, 6)
                .WithFlavor("\"Soon there will be battle on the fields. A sortie must be made ready.\"\r\n-Gandalf, The Return of the King")
                .WithText("Limit 1 copy of Prepare for Battle in the victory display.\r\nWhile this quest is in the victory display, the first player draws an additional card during the resource phase.")
                .WithVictoryPoints(1)
                .WithInfo(3, 3, Artist.Sebastian_Zakrzewski));
            addCard(LotRCard.Ally("Yazan", Sphere.Tactics, 5, 2, 3, 1, 3)
                .WithUnique()
                .WithTraits("Harad.", "Ranger.")
                .WithKeywords("Ranged.")
                .WithText("Response: After Yazan is declared as an attacker, deal 1 damage to a non-unique enemy in play. (Limit once per phase.)")
                .WithInfo(4, 3, Artist.David_A_Nash));
            addCard(LotRCard.Event("Wait no Longer", string.Empty, Sphere.Tactics, 2)
                .WithText("Response: At the beginning of the quest phase, search the top 5 cards of the encounter deck for an enemy and put it into play engaged with you. Then, reveal one less encounter card this phase (to a minimum of 0). Shuffle the encounter deck.")
                .WithFlavor("\"We must press our Enemy, and no longer wait upon him for the move.\"\r\n-Aragorn, The Return of the King")
                .WithInfo(5, 3, Artist.John_Pacer));
            addCard(LotRCard.Ally("Jubayr", Sphere.Spirit, 5, 1, 2, 3, 3)
                .WithUnique()
                .WithTraits("Harad.", "Warrior.")
                .WithKeywords("Sentinel.")
                .WithText("Response: After Jubayr exhausts to defend an attack, discard 1 facedown shadow card from a non-unique enemy. (Limit once per phase.)")
                .WithInfo(6, 3, Artist.Colin_Boyer));
            addCard(LotRCard.Attachment("Dwarf Pipe", string.Empty, Sphere.Spirit, 1)
                .WithTraits("Item.", "Pipe.")
                .WithText("Attach to a Dwarf character. Limit 1 per character.\r\nResponse: After a card is discarded from the top of your deck, exhaust ~Dwarf ~Pipe to place that card on the bottom of your deck.")
                .WithFlavor("He held a small pipe with a wide flattened bowl...\r\n-The Two Towers")
                .WithInfo(7, 3, Artist.Mark_Bulahao));
            addCard(LotRCard.Ally("Firyal", Sphere.Lore, 5, 3, 1, 2, 3)
                .WithUnique()
                .WithTraits("Harad.", "Scout.")
                .WithText("Response: After Firyal commits to the quest, look at the top card of the encounter deck. Then, you may discard the looked at card.")
                .WithInfo(8, 3, Artist.Tawny_Fritzinger));
            addCard(LotRCard.Event("Coney in a Trap", string.Empty, Sphere.Lore, 1)
                .WithText("Play only if you control a unique character with the Ranger trait and another unique character with the Warrior trait.\r\nResponse: After you engage an enemy, that enemy cannot attack you until the end of the round.")
                .WithInfo(9, 3, Artist.Jon_Bosco));
            addCard(LotRCard.Attachment("Kahliel's Headdress", string.Empty, Sphere.Neutral, 3)
                .WithUnique()
                .WithTraits("Artifact.", "Item.")
                .WithKeywords("Restricted.")
                .WithText("Attach to Kahliel. Each Harad character gets +1 Willpower.\r\nRefresh Action: Exhaust Kahliel's Headdress to shuffle the topmost Harad ally in your discard pile into your deck.")
                .WithInfo(10, 3, Artist.Lucas_Durham));
            addCard(LotRCard.Objective("Horse-hair Lasso", string.Empty, setName)
                .WithTraits("Capture.")
                .WithText("Response: After the attached enemy is dealt any amount of damage, the engaged player shuffles his deck and discards the top card. If the discarded card’s cost is equal to or greater than the attached enemy’s remaining hit points, add Horse-hair Lasso and attached enemy to the victory display.")
                .WithVictoryPoints(1)
                .WithInfo(11, 1, Artist.Nikolas_Hagialas));
            addCard(LotRCard.Objective("Poisoned Spear", string.Empty, setName)
                .WithTraits("Capture.")
                .WithText("Response: After the players quest successfully, the engaged player discards the top card of the encounter deck. If the discarded card’s [Threat] is equal to or greater than the attached enemy’s remaining hit points, add Poisoned Spear and attached enemy to the victory display.")
                .WithVictoryPoints(1)
                .WithInfo(12, 1, Artist.Leanna_Crossan));
            addCard(LotRCard.Objective("Pit Trap", string.Empty, setName)
                .WithTraits("Capture.")
                .WithText("Response: After the players travel to a location, if the active location's printed Threat is equal to or greater than the attached enemy's remaining hit points, the engaged player adds Pit Trap and attached enemy to the victory display.")
                .WithVictoryPoints(1)
                .WithInfo(13, 1, Artist.Lucas_Staniec));
            addCard(LotRCard.Objective("Noose of Vines", string.Empty, setName)
                .WithTraits("Capture.")
                .WithText("Response: After a character defends an attack against the attached enemy, if the defending character has more remaining hit points than the attached enemy, add Noose of Vines and attached enemy to the victory display.")
                .WithVictoryPoints(1)
                .WithInfo(14, 1, Artist.Dani_Hartel));
            addCard(LotRCard.Enemy("Wild Mûmak", string.Empty, setName, 40, 3, 6, 3, 9)
                .WithTraits("Creature.")
                .WithKeywords("Indestructible.")
                .WithText("Immune to player card effects.\r\nCannot take more tha 3 damage each round.\r\nForced: At the end of the round, the engaged player must choose: either return Wild Mûmak to the staging area, or it makes an immediate attack.")
                .WithVictoryPoints(3)
                .WithInfo(15, 4, Artist.Alvaro_Calvo_Escudero));
            addCard(LotRCard.Enemy("Harad Tiger", string.Empty, setName, 0, 4, 4, 3, 5)
                .WithTraits("Creature.")
                .WithText("Cannot be optionally engaged.\r\nForced: After Harad Tiger attacks and destroys a character, return it to the staging area.")
                .WithShadow("Shadow: Attacking enemy makes an additional attack against you after this one.")
                .WithEasyModeQuantity(0)
                .WithInfo(16, 1, Artist.Ramon_Puasa_Jr));
            addCard(LotRCard.Enemy("Territorial Ape", string.Empty, setName, 35, 2, 2, 2, 4)
                .WithTraits("Creature.")
                .WithText("Territorial Ape gets +X Threat and + X Attack, where X is the Threat of the active location.")
                .WithShadow("Shadow: Attacking enemy gets +1 Attack (+2 Attack instead if a location was explored this round).")
                .WithInfo(17, 4, Artist.Guillaume_Ducos));
            addCard(LotRCard.Enemy("Strangling Python", string.Empty, setName, 25, 1, 3, 1, 3)
                .WithTraits("Creature.")
                .WithKeywords("Surge.")
                .WithText("Forced: After Strangling Python damages a character, attach it to that character. (Counts as a Condition attachment with the text: \"Attached character cannot ready.\")")
                .WithEasyModeQuantity(1)
                .WithInfo(18, 2, Artist.Dmitry_Prosvirnin));
            addCard(LotRCard.Enemy("Giant Centipede", string.Empty, setName, 30, 3, 3, 1, 2)
                .WithTraits("Creature.")
                .WithText("Forced: After Giant Centipede damages a character, treat that character’s text box as if it were blank until the end of the round (except for Traits).")
                .WithShadow("Shadow: Treat the defending character’s text box as blank until the end of the round.")
                .WithInfo(19, 2, Artist.Dmitry_Prosvirnin));
            addCard(LotRCard.Location("Mûmak Trail", string.Empty, setName, 2, 3)
                .WithTraits("Forest.")
                .WithText("While Mumak Trail is the active location, it gains: \"Response: When Mumak Trail leaves play as an explored location, search the encounter deck and discard pile for a Wild Mumak and add it to the staging area. Shuffle the encounter deck.\"\r\nTravel: Raise each player's threat by 1 to travel here.")
                .WithInfo(20, 4, Artist.Lucas_Staniec));
            addCard(LotRCard.Treachery("Stampeding Oliphaunt", string.Empty, setName)
                .WithKeywords("Doomed 1.")
                .WithText("When Revealed: Choose a Wild Mûmak in the staging area to attack the first player. If no attacks are made this way, search the encounter deck and discard pile for a Mûmak Trail and add it to the staging area. Shuffle the encounter deck.")
                .WithFlavor("On the great beast thundered, blundering in blind wrath through pool and thicket. -The Two Towers")
                .WithInfo(21, 2, Artist.Alvaro_Calvo_Escudero));
            addCard(LotRCard.Treachery("The Savage South", string.Empty, setName)
                .WithText("When Revealed: Each player discards the top 5 cards of his deck. Each player discards each card he controls that shares a title with any of the 5 cards he just discarded.")
                .WithShadow("Shadow: Attacking enemy gets +1 Attack. If this attack destroys a character, return attacking enemy to the staging area.")
                .WithInfo(22, 2, Artist.Dimitri_Bielak));
            addCard(LotRCard.Treachery("Terrible Fever", string.Empty, setName)
                .WithText("When Revealed: Remove a hero from the quest and attach Terrible Fever to that hero. (Counts as a Condition attachment with the text: \"Forced: At the end of the round, deal 1 damage to attached character.\")")
                .WithShadow("Shadow: Defending character cannot ready until the end of the round.")
                .WithEasyModeQuantity(1)
                .WithInfo(23, 2, Artist.Marius_Bota));
            addCard(LotRCard.Treachery("Biting Insects", string.Empty, setName)
                .WithText("When Revealed: Each player discards a random card from his hand and assigns X damage among characters he controls. X is the discarded card's cost.")
                .WithShadow("Shadow: Discard a random card from your hand and assign X damage among characters you control. X is the discarded card's cost.")
                .WithEasyModeQuantity(1)
                .WithInfo(24, 2, Artist.Alexandr_Elichev));
            addCard(LotRCard.EncounterSideQuest("Guardians of the Jungle", string.Empty, setName, 6)
                .WithFlavor("The great apes of the jungle gather in the trees around you. They shadow your steps and slow your progress.")
                .WithText("Each location gets +1 Threat.\r\nForced: When Guardians of the Jungle becomes the current quest, search the encounter deck and discard pile for a Territorial Ape and put it into play engaged with the first player.")
                .WithVictoryPoints(10)
                .WithInfo(25, 1, Artist.Alvaro_Calvo_Escudero));
            addCard(LotRCard.Quest("Welcome to the Jungle", 1, setName, 12)
                .WithFlavor("After seeing his village destroyed by Sauron’s Orcs, Kahliel has decided to travel north with you to Gondor. But it is a long road, and you will need mounts to ride. So your Haradrim allies have led you into the great jungle of Harad in search of the might Mumakil.")
                .WithText("Setup: Set each copy of Wild Mûmak and each Capture objective aside, out of play. Each player adds 1 different location to the staging area. Shuffle the encounter deck.")
                .WithOppositeFlavor("The jungle is full of danger. The Haradrim warn you to stay alert lest the hunters become the hunted.")
                .WithOppositeText("Forced: After the active location leaves play as an explored location, shuffle 1 set aside Wild Mûmak into the encounter deck.\r\nThe players cannot advance unless the number of Wild Mûmak in play is equal to the number of players.")
                .WithInfo(26, 1, Artist.Joshua_Cairos));
            addCard(LotRCard.Quest("Capture the Oliphaunts", 2, setName, 8)
                .WithFlavor("You’ve tracked the Mûmakil through miles of dense jungle and battled with the creatures that dwell therein, but now comes the hard part: you must actually capture the Oliphaunts alive.")
                .WithText("When Revealed: Starting with the first player, each player attaches 1 random set-aside Capture objective to a Wild Mûmak in play.")
                .WithOppositeText("Forced: At the beginning of the quest phase, if there is no active location, reveal an additional encounter card this phase.\r\nThis stage cannot be defeated while there are any Capture objectives in play. If the players defeat this stage, they win the game.")
                .WithInfo(27, 1, Artist.Alexander_Gustafson));
        }
    }
}