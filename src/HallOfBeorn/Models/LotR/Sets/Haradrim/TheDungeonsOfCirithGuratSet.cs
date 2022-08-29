/* Generated CardSet class: The Dungeons of Cirith Gurat */

using System;

namespace HallOfBeorn.Models.LotR.Sets.Haradrim
{
    public class TheDungeonsOfCirithGuratSet : CardSet
    {
        protected override void Initialize()
        {
            Name = "The Dungeons of Cirith Gurat";
            Abbreviation = "DoCG";
            Number = 47;
            SetType = Models.SetType.Adventure_Pack;
            Cycle = "Haradrim";

            addHero("Folco Boffin", 7, Sphere.Lore, 2, 2, 0, 2)
                .WithTraits("Hobbit.")
                .WithTextLine("Folco Boffin gets -1 threat cost for each Hobbit hero you control.")
                .WithTextLine("Action: Discard Folco Boffin to reduce your threat by 7. (Limit once per game for the group.)")
                .WithFlavorLine("...he had many friends, especially among the younger generation of Hobbits (descendants mostly from Old Took)")
                .WithFlavorLine("-The Fellowship of the Ring")
                .WithInfo(109, 1, Artist.Owen_William_Weber);
            addAlly("Knight of Dale", 4, Sphere.Leadership, false, 2, 2, 1, 3)
                .WithTraits("Dale.", "Warrior.")
                .WithTextLine("Action: Spend 1 Leadership resource to ready Knight of Dale. (limit once per round).")
                .WithTextLine("Valour Action: Ready Knight of Dale (limit once per round.)")
                .WithInfo(110, 3, Artist.Aleksander_Karcz);
            addAttachment("Diligent Noble", 1, Sphere.Leadership, false)
                .WithTraits("Skill.")
                .WithTextLine("Attach to a hero. Limit 1 per hero.")
                .WithTextLine("Attached hero gains the Noble trait.")
                .WithTextLine("Response: After you play Diligent ~Noble from your hand, draw a card.")
                .WithInfo(111, 3, Artist.Nikolas_Hagialas);
            addAlly("Riddermark Knight", 2, Sphere.Tactics, false, 0, 2, 0, 2)
                .WithTraits("Rohan.", "Warrior.")
                .WithTextLine("Response: After Riddermark Knight is declared as an attacker, it gets +2 Attack for this attack. At the end of this attack, discard Riddermark Knight.")
                .WithInfo(112, 3, Artist.Sebastian_Zakrzewski);
            addEvent("Fierce Defense", 3, Sphere.Tactics)
                .WithTextLine("Combat Action: Deal 3 damage to a non-unique enemy engaged with you.")
                .WithTextLine("Valour Combat Action: Discard a non-unique enemy engaged with you.")
                .WithInfo(113, 3, Artist.Stanislav_Dikolenko);
            addAlly("Eregion Survivor", 2, Sphere.Spirit, false, 1, 1, 1, 3)
                .WithTraits("Noldor.")
                .WithTextLine("As long as you do not have cards in your hand, Eregion Survivor gets +1 Willpower, +1 Attack and +1 Defense.")
                .WithInfo(114, 3, Artist.Katherine_Dinger);
            addEvent("Heirs of Eärendil", 1, Sphere.Spirit)
                .WithTextLine("Play only if you control a unique character with the Noldor trait and another unique character with the Dúnedain trait.")
                .WithTextLine("Action: Choose a non-unique location in the staging area and increase your threat by X to discard it. X is the chosen location's printed quest points.")
                .WithInfo(115, 3, Artist.Davis_Engel);
            addAlly("Leaflock", 3, Sphere.Lore, true, 0, 2, 2, 3)
                .WithTraits("Ent.")
                .WithTextLine("Cannot have restricted attachments. Enters play exhausted.")
                .WithTextLine("Leaflock gets +1 Willpower for each damaged Ent you control (limit +4 Willpower.)")
                .WithAges(Age.First_Age, Age.Second_Age, Age.Third_Age)
                .WithInfo(116, 3, Artist.Piya_Wannachaiwong);
            addAttachment("Legacy Blade", 0, Sphere.Lore, false)
                .WithTraits("Item.", "Weapon.")
                .WithKeywords("Restricted.")
                .WithTextLine("Attach to a hero. Restricted.")
                .WithTextLine("Attached hero gets +1 Attack for each side quest in the victory display. (Limit +3 Attack.)")
                .WithFlavorLine("...glad would he have been to know its fate who wrought it slowly long ago in the North-kingdom when the Dúnedain were young...")
                .WithFlavorLine("-The Return of the King")
                .WithInfo(117, 3, Artist.Lucas_Durham);
            addEvent("Open the Armory", 1, Sphere.Neutral)
                .WithTextLine("Action: Search the top 10 cards of your deck for a Weapon or Armor attachment and add it to your hand. Shuffle your deck.")
                .WithTextLine("Valour Action: Search the top 5 cards of your deck for a Weapon or Armor attachment and put it into play. Shuffle your deck.")
                .WithInfo(118, 3, Artist.Sabin_Boykinov);
            addObjective("The Captives of Cirith Gurat", EncounterSet.TheDungeonsOfCirithGurat)
                .WithTextLine("While a character is attached to an encounter card, it is considered to be a guarded objective with a blank text box.")
                .WithTextLine("Forced: When a character is attached to an encounter card, discard each token and attachment on that character.")
                .WithTextLine("Forced: When an objective is free of encounters, it is 'rescued' and that character's owner takes control of it, exhausted.")
                .WithInfo(119, 1, Artist.Monztre);
            addObjectiveAlly("Abaan", EncounterSet.TheDungeonsOfCirithGurat, 1, 1, 1, 3)
                .WithUnique()
                .WithTraits("Harad.")
                .WithTextLine("While Abaan is free of encounters, the first player gains control of Abaan.")
                .WithTextLine("Response: After Abaan exhausts, choose a Harad character to get +1 Willpower, +1 Attack, and +1 Defense until the end of the round.")
                .WithTextLine("If Abaan leaves play, the players lose the game.")
                .WithInfo(120, 1, Artist.Andreia_Ugrai);
            addEnemy("Jailer of Cirith Gurat", EncounterSet.TheDungeonsOfCirithGurat, 45, 4, 3, 2, 5)
                .WithTraits("Orc.", "Uruk.")
                .WithTextLine("Forced: After Jailer of Cirith Gurat engages you, attach an ally you control to it.")
                .WithShadow("Shadow: If attacking enemy's Threat is greater than defending ally's Willpower, attach defending ally to attacking enemy. Then, cancel this attack.")
                .WithEasyModeQuantity(1)
                .WithInfo(121, 2, Artist.Monztre);
            addEnemy("Prison Guard", EncounterSet.TheDungeonsOfCirithGurat, 30, 3, 4, 1, 4)
                .WithTraits("Orc.", "Uruk.")
                .WithTextLine("While Prison Guard is guarding an objective, it gets +2 Defense.")
                .WithTextLine("While Prison Guard is not guarding an objective, it gains: \"Forced: After Prison Guard attacks and damages an ally, attach that ally to Prison Guard.\"")
                .WithInfo(122, 3, Artist.Guillaume_Ducos);
            addEnemy("Dungeon Warg", EncounterSet.TheDungeonsOfCirithGurat, 25, 1, 3, 1, 3)
                .WithTraits("Creature.")
                .WithKeywords("Surge.")
                .WithTextLine("Surge.")
                .WithTextLine("When Revealed: Dungeon Warg makes an immediate attack against the player who controls the most allies.")
                .WithShadow("Shadow: Attacking enemy gets +1 Attack.")
                .WithEasyModeQuantity(2)
                .WithInfo(123, 3, Artist.Alvaro_Calvo_Escudero);
            addLocation("Gate of Iron", EncounterSet.TheDungeonsOfCirithGurat, 3, 2)
                .WithTraits("Dungeon.")
                .WithTextLine("While Gate of Iron is in the staging area, progress cannot be placed on locations in the staging area.")
                .WithTextLine("Travel: Discard the top card of the encounter deck. Then, the first player must discard a card from his hand with cost greater than the discarded card's Threat, or raise each player’s threat by 3.")
                .WithInfo(124, 3, Artist.Federico_Musetti);
            addLocation("Dungeon Cell", EncounterSet.TheDungeonsOfCirithGurat, 1, 5)
                .WithTraits("Dungeon.")
                .WithKeywords("Surge.")
                .WithTextLine("Surge.")
                .WithTextLine("Dungeon Cell gets +X Threat where X is the printed Willpower of the attached objective.")
                .WithTextLine("While Dungeon Cell is in the staging area, it gains: \"Forced: After an ally is destroyed, attach it to Dungeon Cell if there is no objective attached to Dungeon Cell.\"")
                .WithEasyModeQuantity(2)
                .WithInfo(125, 3, Artist.JB_Casacop);
            addLocation("Uruk Guardroom", EncounterSet.TheDungeonsOfCirithGurat, 4, 4)
                .WithTraits("Dungeon.")
                .WithTextLine("While Uruk Guardroom is in the staging area, increase the cost to play each ally by 1.")
                .WithTextLine("Travel: Shuffle the encounter discard pile into the encounter deck and discard cards until an Orc enemy is discarded. Add that enemy to the staging area.")
                .WithEasyModeQuantity(1)
                .WithInfo(126, 2, Artist.Federico_Musetti);
            addLocation("Mines of Cirith Gurat", EncounterSet.TheDungeonsOfCirithGurat, 2, 3)
                .WithTraits("Dungeon.")
                .WithTextLine("While Mines of Cirith Gurat is in the staging area, it gains: \"Forced: When a player card would reduce a player's threat by any amount, reduce that amount to 1.\"")
                .WithTextLine("Travel: Each player discards the top 3 cards of his deck and raises his threat by 1 for each ally he discards this way.")
                .WithInfo(127, 3, Artist.Kamila_Szutenberg);
            addLocation("Torture Room", EncounterSet.TheDungeonsOfCirithGurat, 3, 4)
                .WithTraits("Dungeon.")
                .WithTextLine("When Revealed: The first player discards cards from the top of his deck until he discards an ally. Attach that ally to Torture Room and discard each other copy of that ally from play.")
                .WithTextLine("While Torture Room is guarding an objective, it gains: \"Forced: At the end of the round, raise each player’s threat by 1.\"")
                .WithInfo(128, 2, Artist.Federico_Musetti);
            addTreachery("Taken Prisoner", EncounterSet.TheDungeonsOfCirithGurat)
                .WithTextLine("When Revealed: The first player attaches an ally he controls to an unattached enemy or location in the staging area. If he cannot, Taken Prisoner gains doomed 2.")
                .WithShadow("Shadow: Attacking enemy gets +1 Attack. If this attack destroys an ally, reveal the top card of the encounter deck.")
                .WithEasyModeQuantity(1)
                .WithInfo(129, 2, Artist.Lukasz_Jaskolski);
            addTreachery("Tormented by Orcs", EncounterSet.TheDungeonsOfCirithGurat)
                .WithTextLine("When Revealed: Each player raises his threat by 1 for each guarded objective he owns. If any player does not own a guarded objective, Tormented by Orcs gains surge.")
                .WithShadow("Shadow: Until the end of the phase, attacking enemy gets +1 Defense (+2 Defense instead if it is guarding an objective).")
                .WithInfo(130, 3, Artist.Guillaume_Ducos);
            addEncounterSideQuest("Captured!", EncounterSet.TheDungeonsOfCirithGurat, 5)
                .WithTextLine("When Revealed: Each player loses control of an ally he controls and attaches it to this stage. If no allies are attached to this stage, discard it and reveal an additional encounter card.")
                .WithTextLine("Forced: When this stage is defeated, each player reduces his threat by X, where X is the cost of the ally he controls that was attached to this stage.")
                .WithFlavorLine("Orcs spring from a secret passage and pull your friends inside!")
                .WithVictoryPoints(10)
                .WithInfo(131, 1, Artist.Marius_Bota);
            addQuest("Rescue the Prisoners", EncounterSet.TheDungeonsOfCirithGurat, 1, 'A', 10)
                .WithTextLine("Setup: Set Uruk Chieftain aside, out of play. Add The Captives of Cirith Gurat and 1 copy of ~Dungeon Cell to the staging area. Attach Abaan to ~Dungeon Cell. Each player searches the encounter deck for a different Orc enemy and adds it to the staging area. Shuffle the encounter deck. Starting with the first player, each player discards cards from the top of his deck until an ally that is not in play is discarded and attaches that ally to an unattached enemy in the staging area.")
                .WithOppositeTextLine("Each enemy and location in the staging area that is guarding an objective is immune to player card effects.")
                .WithOppositeTextLine("Forced: After any number of characters are rescued, reveal an encounter card.")
                .WithOppositeTextLine("This stage cannot be defeated while a guarded objective is in play.")
                .WithOppositeFlavorLine("Posing as The Black Serpent’s men, you have infiltrated the Orc stronghold of Cirith Gurat in order to rescue the prisoners there.")
                .WithIncludedEncounterSets(EncounterSet.MordorOrcs, EncounterSet.HaradTerritory)
                .WithInfo(132, 1, Artist.Drazenka_Kimpel);
            addQuest("Sneak Past the Guards", EncounterSet.TheDungeonsOfCirithGurat, 2, 'A', 15)
                .WithTextLine("When Revealed: Shuffle the encounter discard pile into the encounter deck. Each player discards cards from the encounter deck until an enemy is discarded and adds that enemy to the staging area.")
                .WithFlavorLine("You've rescued Kahliel's son and several others from their dungeon cells, but you’re not free yet: an entire garrison of Orcs occupies the fortress above you. One false move could bring them all down on top of you, so you quietly make your way towards the secret exit, hoping to avoid a fight.")
                .WithOppositeTextLine("Each enemy in the staging area cannot take damage and gets +X engagement cost, where X is the number of progress tokens here.")
                .WithOppositeTextLine("Forced: At the end of the round, reveal an encounter card. Then, place 1 resource here if no enemies were engaged this round.")
                .WithOppositeTextLine("The players cannot defeat this stage unless there are at least 2 resources here.")
                .WithIncludedEncounterSets(EncounterSet.MordorOrcs, EncounterSet.HaradTerritory)
                .WithInfo(133, 1, Artist.Joshua_Cairos);
            addQuest("Fight Your Way Out", EncounterSet.TheDungeonsOfCirithGurat, 3, 'A', 10)
                .WithTextLine("When Revealed: The first player adds ~Uruk ~Chieftain to the staging area. Each player chooses a hero he controls, discards all tokens and attachments from it, and attaches it to an unattached enemy in the staging area as a captive. Then, the players make a standard series of engagement checks against each enemy in the staging area. Reduce the engagement cost of each enemy not guarding an objective to 0 during these engagement checks.")
                .WithFlavorLine("One of the captives stumbles for exhaustion, and the noise alerts the guards.")
                .WithOppositeTextLine("Forced: At the beginning of the quest phase, discard cards from the encounter deck until an enemy is discarded and add that enemy to the staging area.")
                .WithOppositeTextLine("The players cannot defeat this stage while a guarded objective is in play. If the players defeat this stage, they win the game.")
                .WithOppositeFlavorLine("Horns echo through the dungeon, and the Orcs come running with weapons drawn. You will have to fight past them to escape.")
                .WithIncludedEncounterSets(EncounterSet.MordorOrcs, EncounterSet.HaradTerritory)
                .WithInfo(134, 1, Artist.Joshua_Cairos);
        }
    }
}
