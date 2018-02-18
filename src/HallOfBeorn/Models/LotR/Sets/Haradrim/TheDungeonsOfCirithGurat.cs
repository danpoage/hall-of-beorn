using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace HallOfBeorn.Models.LotR.Sets.Haradrim
{
    public class TheDungeonsOfCirithGurat : CardSet
    {
        private const string setName = "The Dungeons of Cirith Gurat";

        protected override void Initialize()
        {
            Name = "The Dungeons of Cirith Gurat";
            Abbreviation = "DoCG";
            Number = 47;
            SetType = Models.SetType.Adventure_Pack;
            Cycle = "Haradrim";

            addCard(LotRCard.Hero("Folco Boffin", string.Empty, Sphere.Lore, 7, 2, 2, 0, 2)
                .WithTraits("Hobbit.")
                .WithText("Folco Boffin gets -1 threat cost for each Hobbit hero you control.\r\nAction: Discard Folco Boffin to reduce your threat by 7. (Limit once per game for the group.)")
                .WithFlavor("...he had many friends, especially among the younger generation of Hobbits (descendants mostly from Old Took)\r\n-The Fellowship of the Ring")
                .WithInfo(109, 1, Artist.Owen_William_Weber));
            addCard(LotRCard.Ally("Knight of Dale", Sphere.Leadership, 4, 2, 2, 1, 3)
                .WithTraits("Dale.", "Warrior.")
                .WithText("Action: Spend 1 Leadership resource to ready Knight of Dale. (limit once per round).\r\nValour Action: Ready Knight of Dale (limit once per round.)")
                .WithInfo(110, 3, Artist.Aleksander_Karcz));
            addCard(LotRCard.Ally("Riddermark Knight", Sphere.Tactics, 2, 0, 2, 0, 2)
                .WithTraits("Rohan.", "Warrior.")
                .WithText("Response: After Riddermark Knight is declared as an attacker, it gets +2 Attack for this attack. At the end of this attack, discard Riddermark Knight.")
                .WithInfo(111, 3, Artist.Sebastian_Zakrzewski));
            addCard(LotRCard.Ally("Eregion Survivor", Sphere.Spirit, 2, 1, 1, 1, 3)
                .WithTraits("Noldor.")
                .WithText("As long as you do not have cards in your hand, Eregion Survivor gets +1 Willpower, +1 Attack and +1 Defense.")
                .WithInfo(112, 3, Artist.Katherine_Dinger));
            addCard(LotRCard.Ally("Leaflock", Sphere.Lore, 3, 0, 2, 2, 3)
                .WithUnique()
                .WithTraits("Ent.")
                .WithText("Cannot have restricted attachments. Enters play exhausted.\r\nLeaflock gets +1 Willpower for each damaged Ent you control (limit +4 Willpower.)")
                .WithInfo(113, 3, Artist.Piya_Wannachaiwong));
            addCard(LotRCard.Attachment("Diligent Noble", string.Empty, Sphere.Leadership, 1)
                .WithTraits("Skill.")
                .WithText("Attach to a hero. Limit 1 per hero.\r\nAttached hero gains the Noble trait.\r\nResponse: After you play Diligent ~Noble from your hand, draw a card.")
                .WithInfo(114, 3, Artist.Nikolas_Hagialas));
            addCard(LotRCard.Attachment("Legacy Blade", string.Empty, Sphere.Lore, 0)
                .WithTraits("Item.", "Weapon.")
                .WithKeywords("Restricted.")
                .WithText("Attach to a hero.\r\nAttached hero gets +1 Attack for each side quest in the victory display. (Limit +3 Attack.)")
                .WithFlavor("...glad would he have been to know its fate who wrought it slowly long ago in the North-kingdom when the Dúnedain were young...\r\n-The Return of the King")
                .WithInfo(115, 3, Artist.Lucas_Durham));
            addCard(LotRCard.Event("Fierce Defense", string.Empty, Sphere.Tactics, 3)
                .WithText("Combat Action: Deal 3 damage to a non-unique enemy engaged with you.\r\nValour Combat Action: Discard a non-unique enemy engaged with you.")
                .WithTemplate("<p class='main-text'><b>Combat Action:</b> Deal 3 damage to a non-unique enemy engaged with you.</p><p class='main-text'><b>Valour Combat Action:</b> Discard a non-unique enemy engaged with you.</p><p class='flavor-text'>When thirteen had fallen the rest fled shrieking, leaving the defenders unharmed, except for Sam who had a scrath along the scalp.<br>&mdash;The Fellowship of the Ring</p>")
                .WithInfo(116, 3, Artist.Stanislav_Dikolenko));
            addCard(LotRCard.Event("Heirs of Eärendil", string.Empty, Sphere.Spirit, 1)
                .WithText("Play only if you control a unique character with the Noldor trait and another unique character with the Dúnedain trait.\r\nAction: Choose a non-unique location in the staging area and increase your threat by X to discard it. X is the chosen location's printed quest points.")
                .WithInfo(117, 3, Artist.Davis_Engel));
            addCard(LotRCard.Event("Open the Armory", string.Empty, Sphere.Neutral, 1)
                .WithText("Action: Search the top 10 cards of your deck for a Weapon or Armor attachment and add it to your hand. Shuffle your deck.\r\nValour Action: Search the top 5 cards of your deck for a Weapon or Armor attachment and put it into play. Shuffle your deck.")
                .WithInfo(118, 3, Artist.Sabin_Boykinov));
            addObjective("The Captives of Cirith Gurat", setName)
                .WithText("While a character is attached to an encounter card, it is considered to be a guarded objective with a blank text box.\r\nForced: When a character is attached to an encounter card, discard each token and attachment on that character.\r\nForced: When an objective is free of encounters, it is 'rescued' and that character's owner takes control of it, exhausted.")
                .WithInfo(119, 1, Artist.Monztre);
            addObjectiveAlly("Abaan", setName, 1, 1, 1, 3)
                .WithUnique().WithTraits("Harad.")
                .WithText("While Abaan is free of encounters, the first player gains control of Abaan.\r\nResponse: After Abaan exhausts, choose a Harad character to get +1 Willpower, +1 Attack, and +1 Defense until the end of the round.\r\nIf Abaan leaves play, the players lose the game.")
                .WithInfo(120, 1, Artist.Andreia_Ugrai);
            addEnemy("Jailer of Cirith Gurat", setName, 45, 4, 3, 2, 5)
                .WithTraits("Orc.", "Uruk.")
                .WithText("Forced: After Jailer of Cirith Gurat engages you, attach an ally you control to it.")
                .WithShadow("Shadow: If attacking enemy's Threat is greater than defending ally's Willpower, attach defending ally to attacking enemy. Then, cancel this attack.")
                .WithEasyModeQuantity(1)
                .WithInfo(121, 2, Artist.Monztre);
            addEnemy("Prison Guard", setName, 30, 3, 4, 1, 4)
                .WithTraits("Orc.", "Uruk.")
                .WithText("While Prison Guard is guarding an objective, it gets +2 Defense.\r\nWhile Prison Guard is not guarding an objective, it gains: \"Forced: After Prison Guard attacks and damages an ally, attach that ally to Prison Guard.\"")
                .WithInfo(122, 3, Artist.Guillaume_Ducos);
            addEnemy("Dungeon Warg", setName, 25, 1, 3, 1, 3)
                .WithTraits("Creature.")
                .WithKeywords("Surge.")
                .WithText("When Revealed: Dungeon Warg makes an immediate attack against the player who controls the most allies.")
                .WithShadow("Shadow: Attacking enemy gets +1 Attack.")
                .WithEasyModeQuantity(2)
                .WithInfo(123, 3, Artist.Alvaro_Calvo_Escudero);
            addLocation("Gate of Iron", setName, 3, 2)
                .WithTraits("Dungeon.")
                .WithText("While Gate of Iron is in the staging area, progress cannot be placed on locations in the staging area.\r\nTravel: Discard the top card of the encounter deck. Then, the first player must discard a card from his hand with cost greater than the discarded card's Threat, or raise each player’s threat by 3.")
                .WithInfo(124, 3, Artist.Federico_Musetti);
            addLocation("Dungeon Cell", setName, 1, 5)
                .WithTraits("Dungeon.")
                .WithKeywords("Surge.")
                .WithText("Dungeon Cell gets +X Threat where X is the printed Willpower of the attached objective.\r\nWhile Dungeon Cell is in the staging area, it gains: \"Forced: After an ally is destroyed, attach it to Dungeon Cell if there is no objective attached to Dungeon Cell.\"")
                .WithEasyModeQuantity(2)
                .WithInfo(125, 3, Artist.JB_Casacop);
            addLocation("Uruk Guardroom", setName, 4, 4)
                .WithTraits("Dungeon.")
                .WithText("While Uruk Guardroom is in the staging area, increase the cost to play each ally by 1.\r\nTravel: Shuffle the encounter discard pile into the encounter deck and discard cards until an Orc enemy is discarded. Add that enemy to the staging area.")
                .WithInfo(126, 2, Artist.Federico_Musetti);
            addLocation("Mines of Cirith Gurat", setName, 2, 3)
                .WithTraits("Dungeon.")
                .WithText("While Mines of Cirith Gurat is in the staging area, it gains: \"Forced: When a player card would reduce a player's threat by any amount, reduce that amount to 1.\"\r\nTravel: Each player discards the top 3 cards of his deck and raises his threat by 1 for each ally he discards this way.")
                .WithInfo(127, 3, Artist.Kamila_Tzutenberg);
            addLocation("Torture Room", setName, 3, 4)
                .WithTraits("Dungeon.")
                .WithText("When Revealed: The first player discards cards from the top of his deck until he discards an ally. Attach that ally to Torture Room and discard each other copy of that ally from play.\r\nWhile Torture Room is guarding an objective, it gains: \"Forced: At the end of the round, raise each player’s threat by 1.\"")
                .WithInfo(128, 2, Artist.Federico_Musetti);
            addTreachery("Taken Prisoner", setName)
                .WithText("When Revealed: The first player attaches an ally he controls to an unattached enemy or location in the staging area. If he cannot, Taken Prisoner gains doomed 2.")
                .WithShadow("Shadow: Attacking enemy gets +1 Attack. If this attack destroys an ally, reveal the top card of the encounter deck.")
                .WithEasyModeQuantity(1)
                .WithInfo(129, 2, Artist.Lukasz_Jaskolski);
            addTreachery("Tormented by Orcs", setName)
                .WithText("When Revealed: Each player raises his threat by 1 for each guarded objective he owns. If any player does not own a guarded objective, Tormented by Orcs gains surge.")
                .WithShadow("Shadow: Until the end of the phase, attacking enemy gets +1 Defense (+2 Defense instead if it is guarding an objective).")
                .WithInfo(130, 3, Artist.Guillaume_Ducos);
            addEncounterSideQuest("Captured!", setName, 5)
                .WithFlavor("Orcs spring from a secret passage and pull your friends inside!")
                .WithText("When Revealed: Each player loses control of an ally he controls and attaches it to this stage. If no allies are attached to this stage, discard it and reveal an additional encounter card.\r\nForced: When this stage is defeated, each player reduces his threat by X, where X is the cost of the ally he controls that was attached to this stage.")
                .WithInfo(131, 1, Artist.Marius_Bota);
            addQuest("Rescue the Prisoners", setName, 1, 'A', 10)
                .WithText("Setup: Set Uruk Chieftain aside, out of play. Add The Captives of Cirith Gurat and 1 copy of ~Dungeon Cell to the staging area. Attach Abaan to ~Dungeon Cell. Each player searches the encounter deck for a different Orc enemy and adds it to the staging area. Shuffle the encounter deck. Starting with the first player, each player discards cards from the top of his deck until an ally that is not in play is discarded and attaches that ally to an unattached enemy in the staging area.")
                .WithOppositeFlavor("Posing as The Black Serpent’s men, you have infiltrated the Orc stronghold of Cirith Gurat in order to rescue the prisoners there.")
                .WithOppositeText("Each enemy and location in the staging area that is guarding an objective is immune to player card effects.\r\nForced: After any number of characters are rescued, reveal an encounter card.\r\nThis stage cannot be defeated while a guarded objective is in play.")
                .WithIncludedEncounterSets(EncounterSet.MordorOrcs, EncounterSet.HaradTerritory)
                .WithInfo(132, 1, Artist.Drazenka_Kimpel);
            addQuest("Sneak Past the Guards", setName, 2, 'A', 15)
                .WithFlavor("You've rescued Kahliel's son and several others from their dungeon cells, but you’re not free yet: an entire garrison of Orcs occupies the fortress above you. One false move could bring them all down on top of you, so you quietly make your way towards the secret exit, hoping to avoid a fight.")
                .WithText("When Revealed: Shuffle the encounter discard pile into the encounter deck. Each player discards cards from the encounter deck until an enemy is discarded and adds that enemy to the staging area.")
                .WithOppositeText("Each enemy in the staging area cannot take damage and gets +X engagement cost, where X is the number of progress tokens here.\r\nForced: At the end of the round, reveal an encounter card. Then, place 1 resource here if no enemies were engaged this round.\r\nThe players cannot defeat this stage unless there are at least 2 resources here.")
                .WithIncludedEncounterSets(EncounterSet.MordorOrcs, EncounterSet.HaradTerritory)
                .WithInfo(133, 1, Artist.Joshua_Cairos);
            addQuest("Fight Your Way Out", setName, 3, 'A', 10)
                .WithFlavor("One of the captives stumbles for exhaustion, and the noise alerts the guards.")
                .WithText("When Revealed: The first player adds ~Uruk ~Chieftain to the staging area. Each player chooses a hero he controls, discards all tokens and attachments from it, and attaches it to an unattached enemy in the staging area as a captive. Then, the players make a standard series of engagement checks against each enemy in the staging area. Reduce the engagement cost of each enemy not guarding an objective to 0 during these engagement checks.")
                .WithOppositeFlavor("Horns echo through the dungeon, and the Orcs come running with weapons drawn. You will have to fight past them to escape.")
                .WithOppositeText("Forced: At the beginning of the quest phase, discard cards from the encounter deck until an enemy is discarded and add that enemy to the staging area.\r\nThe players cannot defeat this stage while a guarded objective is in play. If the players defeat this stage, they win the game.")
                .WithIncludedEncounterSets(EncounterSet.MordorOrcs, EncounterSet.HaradTerritory)
                .WithInfo(134, 1, Artist.Joshua_Cairos);
        }
    }
}