using System;

namespace HallOfBeorn.Models.LotR.Sets.AngmarAwakened
{
    public class TheBattleOfCarnDumNightmareSet : CardSet
    {
        protected override void Initialize()
        {
            Name = EncounterSet.TheBattleOfCarnDumNightmare.Name;
            Abbreviation = "TBoCDN";
            SetType = Models.SetType.Nightmare_Expansion;
            Cycle = "NIGHTMARE";
            Number = 2079;

            addNightmareSetup(EncounterSet.TheBattleOfCarnDumNightmare.Name)
                .WithText("You are playing Nightmare mode.")
                .WithFlavor("Fear fell on all who beheld him; be he singled out the Captain of Gondor for the fullness of his hatred, and with a terrible cry he rode straight upon him.\r\n-The Return of the King")
                .WithOppositeText(
@"Begin with the standard quest deck and encounter deck for The Battle of Carn Dûm scenario.

Remove the following cards, in the specified quantities, from the standard encounter deck:

1x Vile Afflication
1x Furious Charge
1x Orc Ambush
1x Angmar Orc
3x Angmar Marauder
3x Terror of the North
2x Accursed Battlefield
1x Blight of Carn Dûm

Then, shuffle the encounter cards in this Nightmare Deck into the remainder of the standard The Battle of Carn Dûm encounter deck.

Finally, flip this setup card over and place it next to the quest deck. Its effect remains active throughout the game, which is now ready to begin.

Keyword: Siege

If a quest card has the siege keyword, when characters are commited to that quest, they count their total Defense instead of their total Willpower when resolving the quest. Enemies and locations in the staging area still use their Threat in opposition to this quest attempt.")
                .WithInfo(1, 1, Artist.Rafal_Hrynkiewicz);
            addEnemy("Orc Wight", EncounterSet.TheBattleOfCarnDumNightmare.Name, 30, 2, 3, 2, 4)
                .WithTraits("Orc.", "Undead.")
                .WithText("Forced: After Orc Wight enters play, deal it 2 shadow cards.")
                .WithShadow("Shadow: If attacking enemy has at least 1 other shadow card currently dealt to it, return it to the staging area after this attack.")
                .WithInfo(2, 3, Artist.Alexander_Kozachenko);
            addEnemy("Thaurdir's Elite", EncounterSet.TheBattleOfCarnDumNightmare.Name, 45, 2, 5, 4, 6)
                .WithTraits("Orc.")
                .WithText("Forced: If there are 3 shadow cards dealt to Thaurdir's Elite, discard all shadow cards dealt to it and each player must discard an ally he controls.")
                .WithShadow("Shadow: Either raise your threat by 4, or discard an ally you control.")
                .WithInfo(3, 2, Artist.Unknown);
            addLocation("Stronghold Tower", EncounterSet.TheBattleOfCarnDumNightmare.Name, 3, 4)
                .WithTraits("Carn Dûm.")
                .WithText("While Stronghold Tower is in the staging area, shadow effects cannot be canceled.\r\nTravel: Each player must deal 2 damage to a character he controls to travel here.")
                .WithInfo(4, 3, Artist.Jokubas_Uoginitas);
            addLocation("Gates of Carn Dûm", EncounterSet.TheBattleOfCarnDumNightmare.Name, 5, 2)
                .WithTraits("Carn Dûm.")
                .WithTextLine("Forced: After Gates of Carn Dûm is explored, deal it as a shadow card to the enemy in the staging area with the lowest engagement cost.")
                .WithShadow("Shadow: Attacking enemy gets +1 Attack and cannot take damage this round.")
                .WithInfo(5, 2, Artist.Lucas_Staniec);
            addTreachery("Death and Decay", EncounterSet.TheBattleOfCarnDumNightmare.Name)
                .WithTraits("Sorcery.")
                .WithText("When Revealed: Discard the top 3 cards of each player's deck. Each player discards each attachment he controls that has the same title as a card in his discard pile. If no attachments are discarded from play by this effect, Death and Decay gains surge.")
                .WithInfo(6, 3, Artist.Rafal_Hrynkiewicz);
            addTreachery("Howling of Wargs", EncounterSet.TheBattleOfCarnDumNightmare.Name)
                .WithText("When Revealed: Either deal 1 shadow card to each enemy in the staging area, or search the encounter deck and discard pile for a side quest and add it to the staging area. Shuffle the encounter deck if it is searched.")
                .WithShadow("Shadow: Deal 1 shadow card to each enemy engaged with you that has not attacked this phase.")
                .WithInfo(7, 2, Artist.Unknown);
            addTreachery("Black Mare", EncounterSet.TheBattleOfCarnDumNightmare.Name)
                .WithUnique()
                .WithText("When Revealed: Attach to Thaurdir. (Counts as a Mount attachment with the text: \"Black Mare remains attached even if Thaurdir flips. Thaurdir gets +3 hit points. Forced: After Thaurdir is flipped, raise each player's threat by 1.\")")
                .WithShadow("Shadow: Attach Black Mare to Thaurdir.")
                .WithInfo(8, 1, Artist.Guillaume_Ducos);
            addEncounterSideQuest("Protect the Flanks", EncounterSet.TheBattleOfCarnDumNightmare.Name, 6)
                .WithFlavor("Orcs close in on all sides. If you do not hold them back, your forces will not survive long.")
                .WithKeywords("Siege.")
                .WithTextLine("Siege.")
                .WithTextLine("Forced: At the end of the combat phase, assign X damage among characters in play, where X is the total number of shadow cards dealt to enemies in the staging area.")
                .WithVictoryPoints(10)
                .WithInfo(9, 1, Artist.Rafal_Hrynkiewicz);
            addEncounterSideQuest("Rally the Fighters", EncounterSet.TheBattleOfCarnDumNightmare.Name, 8)
                .WithFlavor("Your task seems hopeless and your fate dire, but somehow you must inspire your companions to fight onward!")
                .WithKeywords("Surge.")
                .WithTextLine("Surge.")
                .WithTextLine("~Shadow cards are immune to player card effects.\r\nResponse: After this quest is defeated, discard 1 shadow card from each enemy in play.")
                .WithVictoryPoints(10)
                .WithInfo(10, 1, Artist.Arden_Beckwith);
            addEncounterSideQuest("Sever the Head", EncounterSet.TheBattleOfCarnDumNightmare.Name, 6)
                .WithFlavor("Your adversary Thaurdir will not let you interrupt his master's ritual. Only by fighting through his ranks of Orcs can you hope to do battle with the wraith himself.")
                .WithKeywords("Battle.")
                .WithTextLine("Battle.")
                .WithTextLine("Thaurdir gets +2 Threat, +2 Attack, and cannot take damage.")
                .WithVictoryPoints(10)
                .WithInfo(11, 1, Artist.Unknown);
        }
    }
}
