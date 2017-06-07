using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace HallOfBeorn.Models.LotR.Sets
{
    public class TheBattleOfCarnDumNightmare : CardSet
    {
        private const string setName = "The Battle of Carn Dûm Nightmare";

        protected override void Initialize()
        {
            Name = setName;
            NormalizedName = "The Battle of Carn Dum Nightmare";
            Abbreviation = "TBoCDN";
            SetType = Models.SetType.Nightmare_Expansion;
            Cycle = "NIGHTMARE";
            Number = 2079;

            addCard(LotRCard.NightmareSetup(setName, setName)
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
.WithInfo(1, 1, Artist.Rafal_Hrynkiewicz));
            addCard(LotRCard.Enemy("Orc Wight", string.Empty, setName, 30, 2, 3, 2, 4)
                .WithTraits("Orc.", "Undead.")
                .WithText("Forced: After Orc Wight enters play, deal it 2 shadow cards.")
                .WithShadow("Shadow: If attacking enemy has at least 1 other shadow card currently dealt to it, return it to the staging area after this attack.")
                .WithInfo(2, 2, Artist.Alexander_Kozachenko));
            addCard(LotRCard.Enemy("Thaurdir's Elite", string.Empty, setName, 45, 2, 5, 4, 6)
                .WithTraits("Orc.")
                .WithText("Forced: If there are 3 shadow cards dealt to Thaurdir's Elite, discard all shadow cards dealt to it and each player must discard an ally he controls.")
                .WithShadow("Shadow: Either raise your threat by 4, or discard an ally you control.")
                .WithInfo(3, 2, Artist.Unknown));
            addCard(LotRCard.Location("Stronghold Tower", string.Empty, setName, 3, 4)
                .WithTraits("Carn Dûm.")
                .WithText("While Stronghold Tower is in the staging area, shadow effects cannot be canceled.\r\nTravel: Each player must deal 2 damage to a character he controls to travel here.")
                .WithInfo(4, 2, Artist.Jokubas_Uoginitas));
            addCard(LotRCard.Treachery("Black Mare", string.Empty, setName)
                .WithUnique()
                .WithText("When Revealed: Attach to Thaurdir. (Counts as a Mount attachment with the text: \"Black Mare remains attached even if Thaurdir flips. Thaurdir gets +3 hit points. Forced: After Thaurdir is flipped, raise each player's threat by 1.\")")
                .WithShadow("Shadow: Attach Black Mare to Thaurdir.")
                .WithInfo(5, 1, Artist.Guillaume_Ducos));
            addCard(LotRCard.Treachery("Death and Decay", string.Empty, setName)
                .WithTraits("Sorcery.")
                .WithText("When Revealed: Discard the top 3 cards of each player's deck. Each player discards each attachment he controls that has the same title as a card in his discard pile. If no attachments are discarded from play by this effect, Death and Decay gains surge.")
                .WithInfo(6, 2, Artist.Rafal_Hrynkiewicz));
            addCard(LotRCard.Treachery("Howling of Wargs", string.Empty, setName)
                .WithText("When Revealed: Either deal 1 shadow card to each enemy in the staging area, or search the encounter deck and discard pile for a side quest and add it to the staging area. Shuffle the encounter deck if it is searched.")
                .WithShadow("Shadow: Deal 1 shadow card to each enemy engaged with you that has not attacked this phase.")
                .WithInfo(7, 2, Artist.Unknown));
            addCard(LotRCard.Treachery("Life Drain", string.Empty, setName)
                .WithTraits("Sorcery.")
                .WithText("When Revealed: Deal Life Drain to Thaurdir, as a shadow card.")
                .WithShadow("Shadow: If attacking enemy is Thaurdir, he gets +3 for this attack. If this attack destroys a character, attach Life Drain to Thaurdir. (Counts as a Condition attachment with the text: \"Thaurdir gets +3 hit points.\")")
                .WithInfo(8, 2, Artist.Unknown));
            addCard(LotRCard.EncounterSideQuest("Protect the Flanks", string.Empty, setName, 6)
                .WithFlavor("Orcs close in on all sides. If you do not hold them back, your forces will not survive long.")
                .WithKeywords("Siege.")
                .WithText("Forced: At the end of the combat phase, assign X damage among characters in play, where X is the total number of shadow cards dealt to enemies in the staging area.")
                .WithVictoryPoints(10)
                .WithInfo(9, 1, Artist.Rafal_Hrynkiewicz));
            addCard(LotRCard.EncounterSideQuest("Rally the Fighters", string.Empty, setName, 8)
                .WithFlavor("Your task seems hopeless and your fate dire, but somehow you must inspire your companions to fight onward!")
                .WithKeywords("Surge.")
                .WithText("~Shadow cards are immune to player card effects.\r\nResponse: After this quest is defeated, discard 1 shadow card from each enemy in play.")
                .WithVictoryPoints(10)
                .WithInfo(10, 1, Artist.Arden_Beckwith));
            addCard(LotRCard.EncounterSideQuest("Sever the Head", string.Empty, setName, 6)
                .WithFlavor("Your adversary Thaurdir will not let you interrupt his master's ritual. Only by fighting through his ranks of Orcs can you hope to do battle with the wraith himself.")
                .WithKeywords("Battle.")
                .WithText("Thaurdir gets +2 Threat, +2 Attack, and cannot take damage.")
                .WithVictoryPoints(10)
                .WithInfo(11, 1, Artist.Unknown));
        }
    }
}