using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace HallOfBeorn.Models.LotR.Sets
{
    public class EncounterAtAmonDinNightmare : CardSet
    {
        protected override void Initialize()
        {
            Name = "Encounter at Amon Dîn Nightmare";
            NormalizedName = "Encounter at Amon Din Nightmare";
            Abbreviation = "EaADN";
            SetType = Models.SetType.Nightmare_Expansion;
            Cycle = "NIGHTMARE";
            Number = 2058;

            Cards.Add(new LotRCard()
            {
                Title = "Encounter at Amon Dîn Nightmare",
                HasSecondImage = true,
                Id = "0D3A05E0-7224-4964-AEDE-9DCD0F40DBB4",
                CardType = CardType.Nightmare_Setup,
                Text =
@"You are playing Nightmare mode.

Ghulat cannot take damage unless there is at least 15 progress tokens on Protect the Villagers.

Setup: Place 1 progress token on Rescued Villagers.

Forced: At the beginning of the quest phase, either discard 1 villager token from Rescued Villagers, or reveal an encounter card.",
                FlavorText = "\"They are burning or despoiling all that is left in the vale.\" -Éomer, The Two Towers",
                OppositeText =
@"Begin with the standard quest deck and encounter deck for the Encounter at Amon Dîn scenario.

Remove the following cards, in the specified quantities, from the standard encounter deck:

2x Burning Farmhouse
2x Gondorian Hamlet
1x Marauding ~Orc
1x ~Orc Rabble
3x ~Orc Ravager
2x Craven ~Eagle
2x Trapped Inside
2x Panicked!
2x Scourge of ~Mordor

Then, shuffle the encounter cards in this Nightmare Deck into the remainder of the standard the Encounter at Amon Dîn encounter deck.

Finally, flip this setup card over and place it next to the quest deck. Its effects remain active throughout the game, which is now ready to begin.",
                EncounterSet = "Encounter at Amon Dîn Nightmare",
                Quantity = 1,
                Number = 1,
                Artist = Artist.Mariusz_Gandzel
            });
            Cards.Add(new LotRCard()
            {
                Title = "Orc Raiders",
                Id = "5960F48C-4C93-48F8-80A0-F00E118AB3FF",
                CardType = CardType.Enemy,
                EngagementCost = 32,
                Threat = 4,
                Attack = 5,
                Defense = 2,
                HitPoints = 6,
                Traits = new List<string> { "Orc." },
                Text = "When Revealed: Either discard 1 villager token from Rescued Villagers, or ~Orc Raiders makes an immediate attack against the first player.",
                Shadow = "Shadow: Attacking enemy makes an additional attack after this one.",
                EncounterSet = "Encounter at Amon Dîn Nightmare",
                Quantity = 2,
                Number = 2,
                Artist = Artist.Lukasz_Jaskolski
            });
            Cards.Add(new LotRCard()
            {
                Title = "Pillaging Orc",
                Id = "A73CC605-E9B9-4695-B5A4-0B831C5BC95E",
                CardType = CardType.Enemy,
                EngagementCost = 34,
                Threat = 2,
                Attack = 4,
                Defense = 3,
                HitPoints = 5,
                Traits = new List<string> { "Orc." },
                Text = "When Revealed: Either discard 1 villager token from Rescued Villagers, or reveal an additional encounter card.",
                Shadow = "Shadow: Deal attacking enemy 1 shadow card for each villager token on the active location.",
                EncounterSet = "Encounter at Amon Dîn Nightmare",
                Quantity = 3,
                Number = 3,
                Artist = Artist.Diego_Gisbert_Llorens
            });
            Cards.Add(new LotRCard()
            {
                Title = "Besieged Homestead",
                Id = "CC6EC534-36D1-4DF1-91C4-F7C703F98D14",
                CardType = Models.LotR.CardType.Location,
                Threat = 4,
                QuestPoints = 6,
                Traits = new List<string> { "Gondor." },
                Keywords = new List<string> { "Villagers 2." },
                Text = "Forced: When any amount of progress is placed on a location in the staging area, discard 1 villager token from that location.\r\nTravel: The first player searches the encounter deck for an enemy, reveals it, and puts it into play engaged with him. Shuffle the encounter deck.",
                VictoryPoints = 1,
                EncounterSet = "Encounter at Amon Dîn Nightmare",
                Quantity = 3,
                Number = 4,
                Artist = Artist.Lino_Drieghe
            });
            Cards.Add(new LotRCard()
            {
                Title = "Overrun Village",
                Id = "851B943D-4E1D-404F-95C9-B257F4DD7F67",
                CardType = Models.LotR.CardType.Location,
                Threat = 3,
                QuestPoints = 5,
                Traits = new List<string> { "Gondor." },
                Keywords = new List<string> { "Villagers 2." },
                Text = "While Overrun Village is in the staging area, it gains: \"Forced: After an enemy engages a player, discard 1 villager token from Overrun Village.\"\r\nTravel: Place 1 damage token on Dead Villagers.",
                VictoryPoints = 1,
                EncounterSet = "Encounter at Amon Dîn Nightmare",
                Quantity = 2,
                Number = 5,
                Artist = Artist.Mariusz_Gandzel
            });
            Cards.Add(new LotRCard()
            {
                Title = "Trapped Villagers",
                Id = "BFC45A8F-9DF6-45A5-8EA6-4C8ABC44923B",
                CardType = CardType.Treachery,
                Text = "When Revealed: Place 3 damage tokens on Dead Villagers. Until the end of the round, add 1 to the total Threat in the staging area for each damage token on Dead Villagers.",
                Shadow = "Shadow: Attacking enemy gets +2 Attack. If this attack destroys an ally, place 1 damage token on Dead Villagers.",
                EncounterSet = "Encounter at Amon Dîn Nightmare",
                Quantity = 3,
                Number = 6,
                Artist = Artist.Smirtouille
            });
            Cards.Add(new LotRCard()
            {
                Title = "Run for your Lives!",
                Id = "984385D8-E6A7-492A-99D9-E76E2F11FFA0",
                CardType = CardType.Treachery,
                Text = "When Revealed: Discard 1 villager token from Rescued Villagers. Assign X damage among characters in play. X is the number of damage tokens on Dead Villagers.",
                Shadow = "Shadow: Either discard 1 villager token from Rescued Villagers, or this attack is considered undefended.",
                EncounterSet = "Encounter at Amon Dîn Nightmare",
                Quantity = 2,
                Number = 7,
                Artist = Artist.Lukasz_Jaskolski
            });
            Cards.Add(new LotRCard()
            {
                Title = "Save Us!",
                Id = "F703C039-04F8-4852-BB6A-4AC576DF74EB",
                CardType = CardType.Treachery,
                Text = "When Revealed: Each player must choose: either discard 2 villager tokens from Rescued Villagers, or search the encounter deck and discard pile for an enemy, reveal it, and add it to the staging area. Shuffle the encounter deck.",
                Shadow = "Shadow: Attacking enemy gets +1 Attack. Deal is another shadow card.",
                EncounterSet = "Encounter at Amon Dîn Nightmare",
                Quantity = 2,
                Number = 8,
                Artist = Artist.Romana_Kendelic
            });
            Cards.Add(new LotRCard()
            {
                Title = "Those Now Sundered",
                Id = "9D7B45ED-C155-49D1-8063-CD781067BCF7",
                CardType = CardType.Treachery,
                Traits = new List<string> { "Panic." },
                Keywords = new List<string> { "Surge.", "Doomed 1." },
                Text = "When Revealed: Attach to Rescued Villagers. (Counts as a Condition attachment with the text: \"Forced: At the end of the round, discard 1 villager token from Rescued Villagers.\")",
                FlavorText = "\"Few maybe, of those now sundered will meet again.\" -Beregond, The Return of the King",
                EncounterSet = "Encounter at Amon Dîn Nightmare",
                Quantity = 2,
                Number = 9,
                Artist = Artist.Jose_Vega
            });
        }
    }
}