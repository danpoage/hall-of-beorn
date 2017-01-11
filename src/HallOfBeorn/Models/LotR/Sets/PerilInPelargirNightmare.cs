using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace HallOfBeorn.Models.LotR.Sets
{
    public class PerilInPelargirNightmare : CardSet
    {
        protected override void Initialize()
        {
            Name = "Peril in Pelargir Nightmare";
            Abbreviation = "PiPN";
            SetType = Models.SetType.Nightmare_Expansion;
            Cycle = "NIGHTMARE";
            Number = 2053;

            Cards.Add(new LotRCard()
            {
                Title = "Peril in Pelargir Nightmare",
                Id = "432019A2-BF0A-493B-A13E-D50D55AB3467",
                CardType = CardType.Nightmare_Setup,
                Text =
@"You are playing Nightmare mode.

Forced; At the end of the combat phase, if Alcaron's ~Scroll is in the staging area, attach it to the enemy in play with the highest Defense.

Forced: At the beginning of the refresh phase, if Alcaron's ~Scroll is attached to an enemy, place 1 progress token on that enemy.

If at any point there are 3 or more progress tokens on any enemy, that enemy has escaped with the ~scroll, and the players lose the game.",
                OppositeText =
@"Begin with the standard quest deck and encounter deck for the Peril in Pelargir scenario.

Remove the following cards, in the specified quantities, from the standard encounter deck:

4x Collateral Damage
2x ~Harbor Storehouse
3x Pickpocket
1x ~Harbor Thug

Then, shuffle the encounter cards in this Nightmare Deck into the remainder of the standard Peril in Pelargir encounter deck.

Finally, flip this setup card over and place it next to the quest deck. Its effects remain active throughout the game, which is now ready to begin.",
                EncounterSet = "Peril in Pelargir Nightmare",
                Quantity = 1,
                CardNumber = 1,
                Artist = Artist.Dleoblack
            });
            Cards.Add(new LotRCard()
            {
                Title = "Cunning Informant",
                Id = "65120EFB-8D2B-4236-99D4-CAF749735ED4",
                CardType = CardType.Enemy,
                EngagementCost = 21,
                Threat = 3,
                Attack = 2,
                Defense = 1,
                HitPoints = 3,
                Traits = new List<string> { "Brigand." },
                Text = 
@"While Alcaron's ~Scroll is attached to a hero, Cunning Informant gets +3 Attack.

During the encounter phase, if Alcaron's ~Scroll is attached to a hero, that hero's controller is considered to have +10 threat for the purpose of engagement checks.",
                EncounterSet = "Peril in Pelargir Nightmare",
                CardNumber = 2,
                Quantity = 3,
                Artist = Artist.Jason_Ward
            });
            Cards.Add(new LotRCard()
            {
                Title = "Harbor Brute",
                Id = "D56B2D1E-1432-4424-B907-5B1EC97662EC",
                CardType = CardType.Enemy,
                EngagementCost = 38,
                Threat = 4,
                Attack = 4,
                Defense = 4,
                HitPoints = 5,
                Traits = new List<string> { "Brigand.", "Thug." },
                Text = "When Revealed: If Alcaron's ~Scroll is attached to an enemy, detach it from that enemy and attach it to ~Harbor Brute. Move all progress tokens from that enemy to ~Harbor Brute.",
                EncounterSet = "Peril in Pelargir Nightmare",
                CardNumber = 3,
                Quantity = 2,
                Artist = Artist.Mark_Behm
            });
            Cards.Add(new LotRCard()
            {
                Title = "Pelargir Ringleader",
                Id = "84680482-9838-451A-A05F-C8D2ED4BC401",
                CardType = CardType.Enemy,
                EngagementCost = 35,
                Threat = 2,
                Attack = 3,
                Defense = 3,
                HitPoints = 4,
                Traits = new List<string> { "Brigand." },
                Text = "Forced: When Pelargir Ringleader engages a player, return the topmost Brigand enemy in the encounter discard pile to play, engaged with that player.",
                Shadow = "Shadow: Attacking enemy gets +2 Attack.",
                EncounterSet = "Peril in Pelargir Nightmare",
                CardNumber = 4,
                Quantity = 2,
                Artist = Artist.Mark_Behm
            });
            Cards.Add(new LotRCard()
            {
                Title = "Dockside Street",
                Id = "921AEE01-5C75-456A-A2F2-3CFA8D982957",
                CardType = CardType.Location,
                Threat = 2,
                QuestPoints = 6,
                Traits = new List<string> { "City." },
                Text = "While Dockside Street is in the staging area, enemies in the staging area cannot be damaged or optionally engaged.\r\nTravel: Exhaust the hero with Alcaron's ~Scroll attached to travel here.",
                EncounterSet = "Peril in Pelargir Nightmare",
                CardNumber = 5,
                Quantity = 3,
                Artist = Artist.Mark_Behm
            });
            Cards.Add(new LotRCard()
            {
                Title = "Pelargir Alley",
                Id = "5E79E0DB-5560-41B1-A98D-607D3A1E7E38",
                CardType = CardType.Location,
                Threat = 2,
                QuestPoints = 6,
                Traits = new List<string> { "City." },
                Text = "While Alcaron's ~Scroll is not attached to a hero, Pelargir Alley gets +3 Threat.",
                Shadow = "Shadow: If the defending player controls a hero with Alcaron's ~Scroll attached, attach Alcaron's ~Scroll to the attacking enemy.",
                EncounterSet = "Peril in Pelargir Nightmare",
                CardNumber = 6,
                Quantity = 2,
                Artist = Artist.Dleoblack
            });
            Cards.Add(new LotRCard()
            {
                Title = "Bedlam in the Streets",
                Id = "EE107EE2-1FDF-42BE-A1D8-DA1BFE5764E2",
                CardType = CardType.Treachery,
                Text = "When Revealed: Each player must either remove a hero he controls from the quest or engage an enemy in the staging area. Each enemy engaged by this effect makes an immediate attack.",
                Shadow = "Shadow: Attacking enemy gets +2 Attack.",
                EncounterSet = "Peril in Pelargir Nightmare",
                CardNumber = 7,
                Quantity = 3,
                Artist = Artist.Rafal_Hrynkiewicz
            });
            Cards.Add(new LotRCard()
            {
                Title = "The Thieves' Ploy",
                Id = "D381166E-5B02-4F07-8510-FB5EE4337BC1",
                CardType = CardType.Treachery,
                Keywords = new List<string> { "Surge." },
                Text = "When Revealed: If Alcaron's ~Scroll is attached to a hero, choose an enemy engaged with that hero's controller, if able. Attached Alcaron's ~Scroll to that enemy, then add 1 progress to that enemy.",
                EncounterSet = "Peril in Pelargir Nightmare",
                CardNumber = 8,
                Quantity = 2,
                Artist = Artist.JB_Casacop
            });
            Cards.Add(new LotRCard()
            {
                Title = "They're Getting Away!",
                Id = "E0A3703C-F681-4B47-9925-CE9248882B80",
                CardType = CardType.Treachery,
                Keywords = new List<string> { "Surge." },
                Text = "When Revealed: If Alcaron's ~Scroll is attached to an enemy, choose one: either add 1 progress token to that enemy, or each card in the staging area gets +2 Threat until the end of the phase.",
                EncounterSet = "Peril in Pelargir Nightmare",
                CardNumber = 9,
                Quantity = 2,
                Artist = Artist.JB_Casacop
            });
        }
    }
}