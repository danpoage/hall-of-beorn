using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace HallOfBeorn.Models.LotR.Sets.TheLostRealm
{
    public class IntrudersInChetwoodNightmare : CardSet
    {
        private const string setName = "Intruders in Chetwood Nightmare";

        protected override void Initialize()
        {
            Name = setName;
            Abbreviation = "IiCN";
            SetType = Models.SetType.Nightmare_Expansion;
            Cycle = "NIGHTMARE";
            Number = 2072;

            addCard(LotRCard.NightmareSetup(setName, setName)
                .WithText("You are playing Nightmare mode.")
                .WithFlavor("\"If simple folk are free from care and fear, simple they will be, and we must be secret to keep them so.\"\r\n-Aragorn, The Fellowship of the Ring")
                .WithOppositeText(
@"Begin with the standard quest deck and encounter deck for the Intruders in ~Chetwood scenario.

Remove the following cards, in the specified quantities, from the standard encounter deck:

1x Angmar Orc
3x Angmar Marauder
2x Chetwood Forest
1x Outlying Homestead
2x Borders of Bree-land
1x Rugged Country
1x Shrouded Hills
3x Surprising Speed
2x Sudden Assault

Then, shuffle the encounter cards in this Nightmare Deck into the remainder of the standard Intruders in ~Chetwood encounter deck.

Finally, flip this setup card over and place it next to the quest deck. Its effect remains active throughout the game, which is now ready to begin.")
                .WithInfo(1, 1, Artist.Nicholas_Gregory));
            addCard(LotRCard.Enemy("Orc Abductor", string.Empty, setName, 45, 2, 4, 4, 5)
                .WithTraits("Orc.")
                .WithText("Forced: At the end of the round, if Orc Abductor is in the staging area, search the encounter deck, discard pile and victory display for Rescue Iârion and reveal it. Shuffle the encounter deck.")
                .WithShadow("Shadow: Deal 1 damage to defending character.")
                .WithInfo(2, 2, Artist.Unknown));
            addCard(LotRCard.Enemy("Soldier of Angmar", string.Empty, setName, 28, 2, 5, 3, 5)
                .WithTraits("Orc.")
                .WithText("Forced: After Soldier of Angmar attacks and destroys an ally, search the encounter deck, discard pile and victory display for Orc Ambush and reveal it. Shuffle the encounter deck.")
                .WithShadow("Shadow: Attacking enemy gets +2 Attack.")
                .WithInfo(3, 2, Artist.Unknown));
            addCard(LotRCard.Location("Northern Chetwood", string.Empty, setName, 4, 6)
                .WithTraits("Arnor.", "Forest.")
                .WithText("Forced: After progress is placed on Northern Chetwood (and it is still in play), search the encounter deck, discard pile and victory display for Lost in the Wilderness, and reveal it.")
                .WithShadow("Shadow: Discard 1 card at random from your hand for each point of damage deal by this attack.")
                .WithInfo(4, 2, Artist.Guillaume_Ducos));
            addCard(LotRCard.Location("Greenway Path", string.Empty, setName, 3, 5)
                .WithTraits("Arnor.")
                .WithText("Forced: At the end of the round, if Greenway Path is in the staging area, search the encounter deck, discard pile and victory display for Shadow the War Party, and reveal it.")
                .WithShadow("Shadow: Return attacking enemy to the staging area after this attack.")
                .WithInfo(5, 2, Artist.Unknown));
            addCard(LotRCard.Location("Outskirts of Archet", string.Empty, setName, 5, 3)
                .WithTraits("Arnor.")
                .WithText("Travel: Search the encounter deck, discard pile and victory display for Protect the Bree-landers, and reveal it.")
                .WithShadow("Shadow: Attacking enemy gets +1 Attack. if this attack destroys a character, raise your threat by 3.")
                .WithInfo(6, 2, Artist.Unknown));
            addCard(LotRCard.Treachery("A Great Host", string.Empty, setName)
                .WithText("When Revealed: Each player returns each enemy engaged with him to the staging area. Either search the encunter deck, discard pile and victory display for Orc Rearguard and reveal it, or each player must deal 4 damage to a character he controls. Shuffle the encounter deck.")
                .WithInfo(7, 2, Artist.Unknown));
            addCard(LotRCard.Treachery("Kill Them!", string.Empty, setName)
                .WithText("When Revealed: Search the encounter deck, discard pile and victory display for a copy of Orc War Party and add it to the staging area. Shuffle the encounter deck. Either remove all progress from the main quest, or each Orc War Party in the staging area makes an immediate attack against the player with the highest threat.")
                .WithInfo(8, 2, Artist.Lukasz_Jaskolski));
            addCard(LotRCard.EncounterSideQuest("Shadow the War Party", string.Empty, setName, 8)
                .WithFlavor("")
                .WithText("Each copy of Orc War Party cannot be engaged, cannot be dealt damage and gets +2 Threat.\r\nWhen Revealed: Return each engaged Orc War Party to the staging area.")
                .WithVictoryPoints(10)
                .WithInfo(9, 1, Artist.Nicholas_Gregory));
            addCard(LotRCard.EncounterSideQuest("Protect the Bree-landers", string.Empty, setName, 10)
                .WithFlavor("Every step brings the Orcs closer to Bree-land. If you can't find some way to delay the enemy, the war party will reach the village before you can stop them.")
                .WithKeywords("Surge.")
                .WithText("Forced: At the end of the quest phase, if no progress was placed on Protect the Bree-landers, place 1 resource on it. Then, raise each players threat by the number of resources on Protect the Bree-landers.")
                .WithVictoryPoints(10)
                .WithInfo(10, 1, Artist.Juan_Carlos_Barquet));
        }
    }
}