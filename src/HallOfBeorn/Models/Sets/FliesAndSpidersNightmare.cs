using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace HallOfBeorn.Models.Sets
{
    public class FliesAndSpidersNightmare : CardSet
    {
        protected override void Initialize()
        {
            Name = "Flies and Spiders Nightmare";
            Abbreviation = "FaSN";
            SetType = Models.SetType.Nightmare_Expansion;
            Cycle = "NIGHTMARE";
            Number = 2056;

            Cards.Add(new Card()
            {
                Title = "Flies and Spiders Nightmare",
                HasSecondImage = true,
                Id = "BE5BF36B-9CB2-4135-9A8B-8D51492BB0B9",
                CardType = CardType.Nightmare_Setup,
                Text =
@"You are playing Nightmare mode.

Setup: Each player gives 1 poison to a hero he controls.",
                FlavorText = "Hundreds of angry spiders were goggling at them all round and about and above. It looked pretty hopeless. -The Hobbit",
                OppositeText =
@"Begin with the standard quest deck and encounter deck for the Flies and Spiders scenario.

Remove the following cards, in the specified quantities, from the standard encounter deck:

3x ~Dark Bats
3x Hidden ~Path
2x Fighting Among Friends
5x Wicked ~Spider
1x Fat ~Spider
1x ~Giant Web

Then, shuffle the encounter cards in this Nightmare Deck into the remainder of the standard Flies and Spiders encounter deck.

Finally, flip this setup card over and place it next to the quest deck. Its effects remain active throughout the game, which is now ready to begin.",
                EncounterSet = "Flies and Spiders Nightmare",
                Quantity = 1,
                Number = 1,
                Artist = Artist.Jon_Bosco
            });
            Cards.Add(new Card()
            {
                Title = "Attercop",
                Id = "AD12F733-8892-46E7-8B55-6169DBAAF9FE",
                CardType = CardType.Enemy,
                EngagementCost = 35,
                Threat = 4,
                Attack = 6,
                Defense = 3,
                HitPoints = 6,
                Traits = new List<string> { "Creature.", "Spider." },
                Keywords = new List<string> { "Venom." },
                Text =
@"Attercop gets -1 engagement cost for each poison in play.
Poisoned characters cannot be declared as attackers or defenders against Attercop.",
                EncounterSet = "Flies and Spiders Nightmare",
                Quantity = 3,
                Number = 2,
                Artist = Artist.Jon_Bosco
            });
            Cards.Add(new Card()
            {
                Title = "Venomous Spider",
                Id = "992446A3-2CA6-47D0-BD7C-0F2D31DA9435",
                CardType = CardType.Enemy,
                EngagementCost = 25,
                Threat = 3,
                Attack = 4,
                Defense = 2,
                HitPoints = 5,
                Traits = new List<string> { "Creature.", "Spider." },
                Keywords = new List<string> { "Venom." },
                Text = "Forced: After a character is declared as a defender against Venomous Spider, give it 1 poison.",
                Shadow = "Shadow: Give 2 poison to the defending character.",
                EncounterSet = "Flies and Spiders Nightmare",
                Quantity = 5,
                Number = 3,
                Artist = Artist.Florian_Devos
            });
            Cards.Add(new Card()
            {
                Title = "Dark Colony",
                Id = "4F684192-E515-44C1-93BB-249A5D7B63F7",
                CardType = CardType.Location,
                Threat = 4,
                QuestPoints = 4,
                Traits = new List<string> { "Forest." },
                Text = "While Dark Colony is the active location, poisoned characters cannot ready.\r\nTravel: A player at this stage must give 1 poison to a hero he controls to travel here.",
                FlavorText = "Suddenly he saw, too, that there were spiders huge and horrible sitting in the branches above him, and ring or no ring he trembled with fear lest they should discover him.\r\n -The Hobbit",
                EncounterSet = "Flies and Spiders Nightmare",
                Quantity = 2,
                Number = 4,
                Artist = Artist.Mark_Behm
            });
            Cards.Add(new Card()
            {
                Title = "Mirkwood Path",
                Id = "025C830F-367E-4B63-A2E3-FD0487AE6CFA",
                CardType = CardType.Location,
                Threat = 0,
                IsVariableThreat = true,
                QuestPoints = 3,
                Traits = new List<string> { "Forest." },
                Text = "X is the number of poison in play.\r\nForced: When this location is explored, make 1 hero unconscious.",
                Shadow = "Shadow: Attacking enemy gets +1 Attack for each poisoned character you control.",
                EncounterSet = "Flies and Spiders Nightmare",
                Quantity = 2,
                Number = 5,
                Artist = Artist.Trudi_Castle
            });
            Cards.Add(new Card()
            {
                Title = "Patch of Midnight",
                Id = "2D051679-CFC1-4D15-9620-ABE4DC47A848",
                CardType = CardType.Location,
                Threat = 3,
                QuestPoints = 5,
                Traits = new List<string> { "Forest." },
                Text = "While Patch of Midnight is the active location, treat the text box of each poisoned character as if it were blank (except for Traits).",
                Shadow = "Shadow: Raise your threat by 1 for each poisoned character you control.",
                EncounterSet = "Flies and Spiders Nightmare",
                Quantity = 3,
                Number = 6,
                Artist = Artist.Rafal_Hrynkiewicz
            });
            Cards.Add(new Card()
            {
                Title = "A Horrible Battle",
                Id = "47BA816A-6C46-49F3-9324-8A218286A579",
                CardType = CardType.Treachery,
                Text = "When Revealed: Each player must either give 1 poison to each hero he controls, or reveal an encounter card.",
                Shadow = "Shadow: Attacking enemy makes an additional attack against the defending player after this one.",
                EncounterSet = "Flies and Spiders Nightmare",
                Quantity = 2,
                Number = 7,
                Artist = Artist.Diego_Gisbert_Llorens
            });
            Cards.Add(new Card()
            {
                Title = "Spider Bite",
                Id = "DDC6F70E-3935-4FB7-961F-1806A29CC1D8",
                CardType = CardType.Treachery,
                Keywords = new List<string> { "Surge." },
                Text = "When Revealed: Attach to a hero that is not unconscious. (Counts as a Condition attachment with the text: \"Limit 1 per hero. Forced: At the end of the refresh phase, give attached hero 1 poison. When attached hero becomes unconscious, discard Spider Bite.\")",
                EncounterSet = "Flies and Spiders Nightmare",
                Quantity = 2,
                Number = 8,
                Artist = Artist.Florian_Devos
            });
        }
    }
}