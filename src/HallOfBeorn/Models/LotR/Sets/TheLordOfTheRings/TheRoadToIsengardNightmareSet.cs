using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace HallOfBeorn.Models.LotR.Sets.TheLordOfTheRings
{
    public class TheRoadToIsengardNightmareSet : CardSet
    {
        private const string setName = "The Road to Isengard Nightmare";

        protected override void Initialize()
        {
            Name = setName;
            Abbreviation = "TRtIN";
            SetType = Models.SetType.Nightmare_Expansion;
            Cycle = "NIGHTMARE";
            Number = 2070;

            addCard(LotRCard.NightmareSetup(setName, setName)
                .WithText("You are playing Nightmare mode.\r\nForced: When Ent of Fangorn leaves play, remove it from the game.")
                .WithFlavor("\"Suddenly up came fires and foul flames: the vents and shafts all over the plain began to spout and belch. Several of the Ents got scorched and blistered.\"\r\n-Pippin, The Two Towers")
                .WithOppositeText("Begin with the standard quest deck and encounter deck for The ~Road to ~Isengard scenario.\r\nRemove the following cards, in the specified quantities, from the standard encounter deck:\r\n3x Snaga\r\n1x Ring-wall of ~Isengard\r\n2x Open Pit\r\n1x Machines of ~Isengard\r\n3x Blast of ~Sorcery\r\nThen, shuffle the encounter cards in this Nightmare ~Deck into the remainder of the standard The ~Road to ~Isengard encounter deck.\r\nFinally, flip this setup card over and place it next to the quest deck. Its effect remains active throughout the game, which is now ready to begin.")
                .WithInfo(1, 1, Artist.Monztre));
            addCard(LotRCard.Enemy("Orthanc Archer", string.Empty, setName, 38, 2, 3, 2, 3)
                .WithTraits("Orc.")
                .WithKeywords("Peril.", "Archery 2.")
                .WithText("When Revealed: Discard 1 random card from your hand and assign X damage among characters you control. X is the discarded card's printed cost.")
                .WithFlavor("\"There was no answer, except arrows and stones from the walls.\" -Merry, The Two Towers")
                .WithInfo(2, 3, Artist.Guillaume_Ducos));
            addCard(LotRCard.Enemy("Half-orc of Isengard", string.Empty, setName, 33, 3, 3, 2, 4)
                .WithTraits("Orc.", "Isengard.")
                .WithText("Forced: When Half-orc of Isengard attacks, either discard 1 random card from your hand, or Half-orc of Isengard gets +3 Attack for this attack.")
                .WithShadow("Shadow: If this attack destroys a character, discard 1 random card from your hand.")
                .WithInfo(3, 3, Artist.Guillaume_Ducos));
            addCard(LotRCard.Location("Poisonous Shaft", string.Empty, setName, 2, 5)
                .WithTraits("Isengard.")
                .WithText("While Poisonous Shaft is in the staging area, damaged characters cannot be readied by player card effects.\r\nWizardry: Each player discards a damaged character he controls.")
                .WithFlavor("At night plumes of vapour steamed from the vents, lit from beneath with red light, or blue, or venomous green.\r\n-THe Two Towers")
                .WithInfo(4, 3, Artist.Guillaume_Ducos));
            addCard(LotRCard.Location("Fortress of Isengard", string.Empty, setName, 3, 3)
                .WithTraits("Isengard.")
                .WithText("While Fortress of Isengard is in the staging area, each Orc enemy gets +1 Threat, +1 Attack and +1 Defense.\r\nWizardry: Return the topmost enemy in the encounter discard pile to the staging area.")
                .WithFlavor("This was the stronghold of Saruman, as fame reported it; for within living memory the men of Rohan had not passed its gates...\r\n-The Two Towers")
                .WithInfo(5, 3, Artist.Monztre));
            addCard(LotRCard.Treachery("Traitor of Many Colors", string.Empty, setName)
                .WithKeywords("Peril.", "Surge.")
                .WithText("When Revealed: If Saruman is in play, he makes an immediate attack against you.")
                .WithShadow("Shadow: Either discard 1 random card from your hand, or attacking enemy makes an additional attack against you after this one.")
                .WithInfo(6, 2, Artist.Tropa_Entertainment));
            addCard(LotRCard.Treachery("Fire and Foul Fumes", string.Empty, setName)
                .WithText("When Revealed: Each player assigns X damage among questing characters he controls, where X is the Threat of the active location. If there is no active location, Fire and Foul Fumes gains surge.")
                .WithShadow("Shadow: Assign X damage among characters you control. X is the Threat of the active location.")
                .WithInfo(7, 3, Artist.Guillaume_Ducos));
            addCard(LotRCard.Treachery("Daunting Power", string.Empty, setName)
                .WithText("When Revealed: Until the end of the round, characters cannot be declared as attackers. If there are no engaged enemies, raise each player's threat by 4.")
                .WithShadow("Shadow: Until the end of the round, defending character cannot ready.")
                .WithInfo(8, 2, Artist.Tropa_Entertainment));
            
        }
    }
}