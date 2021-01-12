/* Generated CardSet class: The Mûmakil */

using System;

namespace HallOfBeorn.Models.LotR.Sets.Haradrim
{
    public class TheMumakilSet : CardSet
    {
        protected override void Initialize()
        {
            Name = "The Mûmakil";
            Abbreviation = "TMk";
            Number = 43;
            SetType = Models.SetType.Adventure_Pack;
            Cycle = "Haradrim";

            addHero("Kahliel", 10, Sphere.Leadership, 2, 2, 2, 4)
                .WithTraits("Harad.", "Noble.")
                .WithTextLine("You may use resources from Kahliel's resource pool to pay for Harad ally cards of any sphere.")
                .WithTextLine("Action: Discard a Harad ally from your hand to ready a Harad character in play. (Limit once per phase.)")
                .WithFlavorLine("...the Southrons were bold men and grim...")
                .WithFlavorLine("-The Return of the King")
                .WithCommunityVersion("RiddermarkLord/Kahliel-1")
                .WithInfo(1, 1, Artist.Ryan_Valle);
            addAlly("Andrath Guardsman", 2, Sphere.Leadership, false, 1, 0, 1, 2)
                .WithTraits("Dúnedain.", "Ranger.")
                .WithTextLine("Response: After you play Andrath Guardsman from your hand, choose a non-unique enemy engaged with you. That enemy cannot attack you this round.")
                .WithFlavorLine("They forgot or ignored what little they had known of the Guardians, and of the labours of those that made possible the long peace of the Shire.")
                .WithFlavorLine("-The Fellowship of the Ring")
                .WithInfo(2, 3, Artist.Adam_Lane);
            addPlayerSideQuest("Prepare for Battle", 1, Sphere.Leadership, 6)
                .WithTextLine("Limit 1 copy of Prepare for Battle in the victory display.")
                .WithTextLine("While this quest is in the victory display, the first player draws an additional card during the resource phase.")
                .WithFlavorLine("\"Soon there will be battle on the fields. A sortie must be made ready.\"")
                .WithFlavorLine("-Gandalf, The Return of the King")
                .WithVictoryPoints(1)
                .WithInfo(3, 3, Artist.Sebastian_Zakrzewski);
            addAlly("Yazan", 5, Sphere.Tactics, true, 2, 3, 1, 3)
                .WithTraits("Harad.", "Ranger.")
                .WithKeywords("Ranged.")
                .WithTextLine("Ranged.")
                .WithTextLine("Response: After Yazan is declared as an attacker, deal 1 damage to a non-unique enemy in play. (Limit once per phase.)")
                .WithTemplate("<p class='main-text'>{keyword:Ranged.}</p><p class='main-text'><b>Response:</b> After {self} is declared as an attacker, deal 1 damage to a non-unique enemy in play. (Limit once per phase.)</p>")
                .WithInfo(4, 3, Artist.David_A_Nash);
            addEvent("Wait no Longer", 2, Sphere.Tactics)
                .WithTextLine("Response: At the beginning of the quest phase, search the top 5 cards of the encounter deck for an enemy and put it into play engaged with you. Then, reveal 1 less encounter card this phase (to a minimum of 0). Shuffle the encounter deck.")
                .WithFlavorLine("\"We must press our Enemy, and no longer wait upon him for the move.\"")
                .WithFlavorLine("-Aragorn, The Return of the King")
                .WithInfo(5, 3, Artist.John_Pacer);
            addAlly("Jubayr", 5, Sphere.Spirit, true, 1, 2, 3, 3)
                .WithTraits("Harad.", "Warrior.")
                .WithKeywords("Sentinel.")
                .WithTextLine("Sentinel.")
                .WithTextLine("Response: After Jubayr exhausts to defend an attack, discard 1 facedown shadow card from a non-unique enemy. (Limit once per phase.)")
                .WithTemplate("<p class='main-text'>{keyword:Sentinel.}</p><p class='main-text'><b>Response:</b> After {self} exhausts to defend an attack, discard 1 facedown shadow card from a non-unique enemy. (Limit once per phase.)</p>")
                .WithInfo(6, 3, Artist.Colin_Boyer);
            addAttachment("Dwarf Pipe", 1, Sphere.Spirit, false)
                .WithTraits("Item.", "Pipe.")
                .WithTextLine("Attach to a Dwarf character. Limit 1 per character.")
                .WithTextLine("Response: After a card is discarded from the top of your deck, exhaust ~Dwarf ~Pipe to place that card on the bottom of your deck.")
                .WithFlavorLine("He held a small pipe with a wide flattened bowl...")
                .WithFlavorLine("-The Two Towers")
                .WithInfo(7, 3, Artist.Mark_Bulahao);
            addAlly("Firyal", 5, Sphere.Lore, true, 3, 1, 2, 3)
                .WithTraits("Harad.", "Scout.")
                .WithTextLine("Response: After Firyal commits to the quest, look at the top card of the encounter deck. Then, you may discard the looked at card.")
                .WithInfo(8, 3, Artist.Tawny_Fritzinger);
            addEvent("Coney in a Trap", 1, Sphere.Lore)
                .WithTextLine("Play only if you control a unique character with the Ranger trait and another unique character with the Warrior trait.")
                .WithTextLine("Response: After you engage an enemy, that enemy cannot attack you until the end of the round.")
                .WithInfo(9, 3, Artist.Jon_Bosco);
            addAttachment("Kahliel's Headdress", 3, Sphere.Neutral, true)
                .WithTraits("Artifact.", "Item.")
                .WithKeywords("Restricted.")
                .WithTextLine("Attach to Kahliel. Restricted.")
                .WithTextLine("Each Harad character gets +1 Willpower.")
                .WithTextLine("Refresh Action: Exhaust Kahliel's Headdress to shuffle the topmost Harad ally in your discard pile into your deck.")
                .WithTemplate("<p class='main-text'>Attach to {title:Kahliel}. {keyword:Restricted.}</p><p class='main-text'>Each {trait:Harad.@Harad} character gets +1 {Willpower}.</p><p class='main-text'><b>Refresh Action:</b> Exhaust {self} to shuffle the topmost {trait-ally:Harad.@Harad} ally in your discard pile into your deck.</p>")
                .WithInfo(10, 3, Artist.Lucas_Durham);
            addObjective("Horse-hair Lasso", EncounterSet.TheMumakil)
                .WithTraits("Capture.")
                .WithTextLine("Response: After the attached enemy is dealt any amount of damage, the engaged player shuffles his deck and discards the top card. If the discarded card’s cost is equal to or greater than the attached enemy’s remaining hit points, add Horse-hair Lasso and attached enemy to the victory display.")
                .WithVictoryPoints(1)
                .WithInfo(11, 1, Artist.Nikolas_Hagialas);
            addObjective("Poisoned Spear", EncounterSet.TheMumakil)
                .WithTraits("Capture.")
                .WithTextLine("Response: After the players quest successfully, the engaged player discards the top card of the encounter deck. If the discarded card’s [Threat] is equal to or greater than the attached enemy’s remaining hit points, add Poisoned Spear and attached enemy to the victory display.")
                .WithVictoryPoints(1)
                .WithInfo(12, 1, Artist.Leanna_Crossan);
            addObjective("Pit Trap", EncounterSet.TheMumakil)
                .WithTraits("Capture.")
                .WithTextLine("Response: After the players travel to a location, if the active location's printed Threat is equal to or greater than the attached enemy's remaining hit points, the engaged player adds Pit Trap and attached enemy to the victory display.")
                .WithVictoryPoints(1)
                .WithInfo(13, 1, Artist.Lucas_Staniec);
            addObjective("Noose of Vines", EncounterSet.TheMumakil)
                .WithTraits("Capture.")
                .WithTextLine("Response: After a character defends an attack against the attached enemy, if the defending character has more remaining hit points than the attached enemy, add Noose of Vines and attached enemy to the victory display.")
                .WithVictoryPoints(1)
                .WithInfo(14, 1, Artist.Dani_Hartel);
            addEnemy("Wild Mûmak", EncounterSet.TheMumakil, 40, 3, 6, 3, 9)
                .WithTraits("Creature.")
                .WithKeywords("Indestructible.")
                .WithTextLine("Indestructible. Immune to player card effects.")
                .WithTextLine("Cannot take more tha 3 damage each round.")
                .WithTextLine("Forced: At the end of the round, the engaged player must choose: either return Wild Mûmak to the staging area, or it makes an immediate attack.")
                .WithVictoryPoints(3)
                .WithInfo(15, 4, Artist.Alvaro_Calvo_Escudero);
            addEnemy("Harad Tiger", EncounterSet.TheMumakil, 0, 4, 4, 3, 5)
                .WithTraits("Creature.")
                .WithTextLine("Cannot be optionally engaged.")
                .WithTextLine("Forced: After Harad Tiger attacks and destroys a character, return it to the staging area.")
                .WithShadow("Shadow: Attacking enemy makes an additional attack against you after this one.")
                .WithEasyModeQuantity(0)
                .WithInfo(16, 1, Artist.Ramon_Puasa_Jr);
            addEnemy("Territorial Ape", EncounterSet.TheMumakil, 35, 2, 2, 2, 4)
                .WithTraits("Creature.")
                .WithTextLine("Territorial Ape gets +X Threat and + X Attack, where X is the Threat of the active location.")
                .WithShadow("Shadow: Attacking enemy gets +1 Attack (+2 Attack instead if a location was explored this round).")
                .WithInfo(17, 4, Artist.Guillaume_Ducos);
            addEnemy("Strangling Python", EncounterSet.TheMumakil, 25, 1, 3, 1, 3)
                .WithTraits("Creature.")
                .WithKeywords("Surge.")
                .WithTextLine("Surge.")
                .WithTextLine("Forced: After Strangling Python damages a character, attach it to that character. (Counts as a Condition attachment with the text: \"Attached character cannot ready.\")")
                .WithEasyModeQuantity(1)
                .WithInfo(18, 2, Artist.Dmitry_Prosvirnin);
            addEnemy("Giant Centipede", EncounterSet.TheMumakil, 30, 3, 3, 1, 2)
                .WithTraits("Creature.")
                .WithTextLine("Forced: After Giant Centipede damages a character, treat that character’s text box as if it were blank until the end of the round (except for Traits).")
                .WithShadow("Shadow: Treat the defending character’s text box as blank until the end of the round.")
                .WithInfo(19, 2, Artist.Dmitry_Prosvirnin);
            addLocation("Mûmak Trail", EncounterSet.TheMumakil, 2, 3)
                .WithTraits("Forest.")
                .WithTextLine("While Mumak Trail is the active location, it gains: \"Response: When Mumak Trail leaves play as an explored location, search the encounter deck and discard pile for a Wild Mumak and add it to the staging area. Shuffle the encounter deck.\"")
                .WithTextLine("Travel: Raise each player's threat by 1 to travel here.")
                .WithInfo(20, 4, Artist.Lucas_Staniec);
            addTreachery("Stampeding Oliphaunt", EncounterSet.TheMumakil)
                .WithKeywords("Doomed 1.")
                .WithTextLine("Doomed 1.")
                .WithTextLine("When Revealed: Choose a Wild Mûmak in the staging area to attack the first player. If no attacks are made this way, search the encounter deck and discard pile for a Mûmak Trail and add it to the staging area. Shuffle the encounter deck.")
                .WithFlavorLine("On the great beast thundered, blundering in blind wrath through pool and thicket. -The Two Towers")
                .WithInfo(21, 2, Artist.Alvaro_Calvo_Escudero);
            addTreachery("The Savage South", EncounterSet.TheMumakil)
                .WithTextLine("When Revealed: Each player discards the top 5 cards of his deck. Each player discards each card he controls that shares a title with any of the 5 cards he just discarded.")
                .WithShadow("Shadow: Attacking enemy gets +1 Attack. If this attack destroys a character, return attacking enemy to the staging area.")
                .WithInfo(22, 2, Artist.Dimitri_Bielak);
            addTreachery("Terrible Fever", EncounterSet.TheMumakil)
                .WithTextLine("When Revealed: Remove a hero from the quest and attach Terrible Fever to that hero. (Counts as a Condition attachment with the text: \"Forced: At the end of the round, deal 1 damage to attached character.\")")
                .WithShadow("Shadow: Defending character cannot ready until the end of the round.")
                .WithEasyModeQuantity(1)
                .WithInfo(23, 2, Artist.Marius_Bota);
            addTreachery("Biting Insects", EncounterSet.TheMumakil)
                .WithTextLine("When Revealed: Each player discards a random card from his hand and assigns X damage among characters he controls. X is the discarded card's cost.")
                .WithShadow("Shadow: Discard a random card from your hand and assign X damage among characters you control. X is the discarded card's cost.")
                .WithEasyModeQuantity(1)
                .WithInfo(24, 2, Artist.Alexandr_Elichev);
            addEncounterSideQuest("Guardians of the Jungle", EncounterSet.TheMumakil, 6)
                .WithTextLine("Each location gets +1 Threat.")
                .WithTextLine("Forced: When Guardians of the Jungle becomes the current quest, search the encounter deck and discard pile for a Territorial Ape and put it into play engaged with the first player.")
                .WithFlavorLine("The great apes of the jungle gather in the trees around you. They shadow your steps and slow your progress.")
                .WithVictoryPoints(10)
                .WithInfo(25, 1, Artist.Alvaro_Calvo_Escudero);
            addQuest("Welcome to the Jungle", EncounterSet.TheMumakil, 1, 'A', 12)
                .WithTextLine("Setup: Set each copy of Wild Mûmak and each Capture objective aside, out of play. Each player adds 1 different location to the staging area. Shuffle the encounter deck.")
                .WithFlavorLine("After seeing his village destroyed by Sauron’s Orcs, Kahliel has decided to travel north with you to Gondor. But it is a long road, and you will need mounts to ride. So your Haradrim allies have led you into the great jungle of Harad in search of the might Mumakil.")
                .WithOppositeTextLine("Forced: After the active location leaves play as an explored location, shuffle 1 set aside Wild Mûmak into the encounter deck.")
                .WithOppositeTextLine("The players cannot advance unless the number of Wild Mûmak in play is equal to the number of players.")
                .WithOppositeFlavorLine("The jungle is full of danger. The Haradrim warn you to stay alert lest the hunters become the hunted.")
                .WithInfo(26, 1, Artist.Joshua_Cairos);
            addQuest("Capture the Oliphaunts", EncounterSet.TheMumakil, 2, 'A', 8)
                .WithTextLine("When Revealed: Starting with the first player, each player attaches 1 random set-aside Capture objective to a Wild Mûmak in play.")
                .WithFlavorLine("You’ve tracked the Mûmakil through miles of dense jungle and battled with the creatures that dwell therein, but now comes the hard part: you must actually capture the Oliphaunts alive.")
                .WithOppositeTextLine("Forced: At the beginning of the quest phase, if there is no active location, reveal an additional encounter card this phase.")
                .WithOppositeTextLine("This stage cannot be defeated while there are any Capture objectives in play. If the players defeat this stage, they win the game.")
                .WithInfo(27, 1, Artist.Alexander_Gustafson);
        }
    }
}
