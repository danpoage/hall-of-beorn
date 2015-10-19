using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace HallOfBeorn.Models.Sets
{
    public class TheStewardsFearNightmare : CardSet
    {
        protected override void Initialize()
        {
            Name = "The Steward's Fear Nightmare";
            Abbreviation = "TSFN";
            SetType = Models.SetType.Nightmare_Expansion;
            Cycle = "NIGHTMARE";
            Number = 2056;

            Cards.Add(new Card()
            {
                Title = "The Steward's Fear Nightmare",
                HasSecondImage = true,
                Id = "149CC227-7C4D-4647-BE5B-C5F8C0ACB385",
                CardType = CardType.Nightmare_Setup,
                Text = "You are playing Nightmare mode.\r\nSteup: Shuffle each copy of False Accusations into the underworld deck. When randomly determining which Plot is the \"hidden\" plot cardm include the 2 new Plot cards from the Nightmare Deck, as well as the 3 Plot cards from the original scenario.\r\nForced: After an enemy is destroyed, shuffle it into the underworld deck if you are not at stage 3.\r\nForced: At the beginning of the refresh phase, if there is a Clue card in the staging area, shuffle it back into the underworld deck.",
                FlavorText = "\"Thus the will of Sauron entered into Minas Tirith...\" -Gandalf, The Return of the King",
                OppositeText =
@"Begin with the standard quest deck and encounter deck for The Steward's Fear scenario.

Remove the following cards, in the specified quantities, from the standard encounter deck:

3x Pickpocket
3x ~Underworld Dissident
2x Storehouse
2x Market Square

Then, shuffle the encounter cards in this Nightmare Deck into the remainder of the standard The Steward's Fear encounter deck.

Finally, flip this setup card over and place it next to the quest deck. Its effects remain active throughout the game, which is now ready to begin.",
                EncounterSet = "The Steward's Fear Nightmare",
                Quantity = 1,
                Number = 1,
                Artist = Artist.Mariusz_Gandzel
            });
            Cards.Add(new Card()
            {
                Title = "Rise to Power",
                Id = "C244A7CA-7076-41CB-BB40-C5BC166BD354",
                CardType = CardType.Objective,
                Traits = new List<string> { "Plot." },
                Text = "Rise to Power contributes X Threat to the staging area during the quest phase, where X is the number of resources on it.\r\nForced: At the end of the round, place 2 resources on Rise to Power.",
                EncounterSet = "The Steward's Fear Nightmare",
                Number = 2,
                Quantity = 1,
                Artist = Artist.Dleoblack
            });
            Cards.Add(new Card()
            {
                Title = "Assassination",
                Id = "2435BB15-22F8-4293-BB07-DEADDDD9600A",
                CardType = CardType.Objective,
                Traits = new List<string> { "Plot." },
                Text = "When Revealed: Attach Assassination to the hero with the highest threat cost. (Counts as a Plot attachment with the text: \"Each enemy gets +1 Attack. Attached hero cannot be healed. Damage from undefended attacks and A Knife in the Back must be assigned to attached hero. If attached hero leaves play, the players lose the game.\")",
                EncounterSet = "The Steward's Fear Nightmare",
                Number = 3,
                Quantity = 1,
                Artist = Artist.Arden_Beckwith
            });
            Cards.Add(new Card()
            {
                Title = "Murderous Turncoat",
                Id = "44A4FA8C-AD57-4FA2-A897-4704DFDFDB2F",
                CardType = CardType.Enemy,
                EngagementCost = 20,
                Threat = 1,
                Attack = 5,
                Defense = 3,
                HitPoints = 4,
                Traits = new List<string> { "Brigand." },
                Text = "When Revealed: Murderous Turncoat makes an immediate attack against the first player.\r\nForced: At the end of the combat phase, place Murderous Turncoat facedown underneath the active location if you are not at stage 3.",
                EncounterSet = "Brigands Nightmare",
                Number = 4,
                Quantity = 3,
                Artist = Artist.Jon_Bosco
            });
            Cards.Add(new Card()
            {
                Title = "Faithless Conspirator",
                Id = "22B86783-3F20-4C7B-A676-BD46CD17A395",
                CardType = CardType.Enemy,
                EngagementCost = 40,
                Threat = 4,
                Attack = 4,
                Defense = 2,
                HitPoints = 4,
                Traits = new List<string> { "Brigand." },
                Text = "If the active location has at least 1 facedown card underneath it, Faithless Conspirator cannot take damage.",
                Shadow = "Shadow: Return attacking enemy to the staging area after this attack.",
                EncounterSet = "The Steward's Fear Nightmare",
                Number = 5,
                Quantity = 3,
                Artist = Artist.Rick_Price
            });
            Cards.Add(new Card()
            {
                Title = "Traitors' Den",
                Id = "522E6C65-94D3-4CCE-A41D-2CDCC2BB1FF7",
                CardType = CardType.Location,
                Threat = 3,
                QuestPoints = 6,
                Traits = new List<string> { "Underworld.", "City." },
                Keywords = new List<string> { "Underworld 1." },
                Text = "Forced: At the end of the round, place 1 resource token on Traitors' Den. Then, if it has 4 or more resource tokens on it, remove all tokens from it and reveal at random one of the Plot cards removed from the game during setup. Add that card to the staging area.",
                EncounterSet = "The Steward's Fear Nightmare",
                Number = 6,
                Quantity = 2,
                Artist = Artist.Mariusz_Gandzel
            });
            Cards.Add(new Card()
            {
                Title = "Rath Celerdain",
                Id = "7C94352C-188A-4DC7-B137-314211007546",
                CardType = CardType.Location,
                Threat = 2,
                QuestPoints = 5,
                Traits = new List<string> { "City." },
                Text = "While Rath Celerdain is in the staging area, it gains: \"Forced: At the beginning of the encounter phase, reveal the top card of the underworld deck. If it is an objective, discard it.\"",
                FlavorText = "\"...go down to the lowest circle and ask for the Old Guesthouse in the Rath Celerdain, the Lampwrights' Street.\" -Beregond, The Return of the King",
                EncounterSet = "The Steward's Fear Nightmare",
                Number = 7,
                Quantity = 2,
                Artist = Artist.Mariusz_Gandzel
            });
            Cards.Add(new Card()
            {
                Title = "Arched Tunnel",
                Id = "BA32BD35-C25F-426E-BDAE-936F8E4274BE",
                CardType = CardType.Location,
                Threat = 4,
                QuestPoints = 3,
                Traits = new List<string> { "Underworld.", "City." },
                Keywords = new List<string> { "Underworld 1." },
                Text = "Travel: Reveal all facedown cards underneath Arched Tunnel, one at a time. Then, place the top card of the underworld deck facedown underneath Arched Tunnel, if able.",
                FlavorText = "And each time that it passed the line of the Great Gate it went through an arched tunnel... -The Return of the King",
                EncounterSet = "The Steward's Fear Nightmare",
                Number = 8,
                Quantity = 2,
                Artist = Artist.Mariusz_Gandzel
            });
            Cards.Add(new Card()
            {
                Title = "False Accusations",
                Id = "6C6E6E95-8825-45E0-AFB3-EA135E85943C",
                CardType = CardType.Treachery,
                Traits = new List<string> { "Scheme." },
                Text = "When Revealed: Each player must either raise his threat by 5 or exhaust each ready character he controls.",
                Shadow = "Shadow: After this attack, return attacking enemy to the staging area. Then, it makes engagement checks against each player.",
                EncounterSet = "The Steward's Fear Nightmare",
                Number = 9,
                Quantity = 2,
                Artist = Artist.Smirtouille
            });
            Cards.Add(new Card()
            {
                Title = "The Cabal's Champion",
                Id = "7DA32523-DCC9-4198-911F-2E7D1AF14087",
                CardType = CardType.Objective,
                Traits = new List<string> { "Title." },
                Keywords = new List<string> { "Surge.", "Doomed 1." },
                Text = "If The Cabal's Champion is unattached and in the staging area, attach it to a Villain enemy, if able. (Counts as a Title attachment with the text: \"Attached enemy gets +1 Threat, +1 Attack, +1 Defense, and +2 hit points.\")",
                EncounterSet = "The Steward's Fear Nightmare",
                Number = 10,
                Quantity = 3,
                Artist = Artist.Ed_Mattinian
            });
        }
    }
}