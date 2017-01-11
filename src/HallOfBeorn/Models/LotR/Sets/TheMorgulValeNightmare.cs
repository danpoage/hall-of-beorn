using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace HallOfBeorn.Models.LotR.Sets
{
    public class TheMorgulValeNightmare : CardSet
    {
        protected override void Initialize()
        {
            Name = "The Morgul Vale Nightmare";
            Abbreviation = "TMVN";
            SetType = Models.SetType.Nightmare_Expansion;
            Cycle = "NIGHTMARE";
            Number = 2061;

            Cards.Add(new LotRCard()
            {
                Title = "The Morgul Vale Nightmare",
                Id = "7DFF5DF8-99C4-4DE0-9EEC-83B27680D89B",
                CardType = CardType.Nightmare_Setup,
                Text = "You are playing Nightmare mode.\r\nSetup: Place 1 progress on To the Tower.",
                FlavorText = "\"If a man must needs walk in sight of the Black Gate, or tread the deadly flowers of Morgul Vale, then perils he will have. -Aragorn, The Return of the King",
                OppositeText =
@"Begin with the standard quest deck and encounter deck for the The ~Morgul Vale scenario.

Remove the following cards, in the specified quantities, from the standard encounter deck:

3x ~Forest Bat
1x Watcher in the Wood
3x ~Orc Arbalesters
1x The Power of ~Mordor
2x ~Morgul Sorcerer
2x ~Morgul Tracker
3x ~Morgul ~Road

Then, shuffle the encounter cards in this Nightmare Deck into the remainder of the standard The ~Morgul Vale encounter deck.

Finally, flip this setup card over and place it next to the quest deck. Its effects remain active throughout the game, which is now ready to begin.",
                EncounterSet = "The Morgul Vale Nightmare",
                Quantity = 1,
                CardNumber = 1,
                Artist = Artist.Darek_Zabrocki
            });
            Cards.Add(LotRCard.Enemy("Warrior of Nurn", "A8D4E2CA-E726-4690-AB2E-84D5B424D14D", "The Morgul Vale Nightmare", 18, 2, 4, 3, 5)
                .WithTraits("Traitor.")
                .WithText("Each Captain enemy gets +1 Defense.\r\nForced: At the end of the round, heal all damage from each Captain enemy in play.")
                .WithShadow("Shadow: Heal all damage from each Captain enemy in play.")
                .WithInfo(2, 3, Artist.Guillaume_Ducos));
            Cards.Add(LotRCard.Enemy("Orc Captor", "07F255F3-A756-4BBF-B342-47B2F165B34D", "The Morgul Vale Nightmare", 18, 2, 4, 3, 5)
                .WithTraits("Orc.", "Mordor.")
                .WithText("Forced: At the end of the round, if ~Orc Captor is in the staging area, place 1 progress token on To the Tower.")
                .WithShadow("Shadow: Attacking enemy gets +3 Defense until the end of the combat phase.")
                .WithInfo(3, 3, Artist.Niten));
            Cards.Add(LotRCard.Enemy("Sentry of the White Bridge", "3062BC6A-F29C-40B1-ADAF-EB08F815B02A", "The Morgul Vale Nightmare", 37, 255, 255, 4, 5)
                .WithTraits("Orc.", "Mordor.")
                .WithText("X is the number of progress tokens on To the Tower.")
                .WithShadow("Shadow: Attacking enemy gets +1 Attack. If this attack destroys a character, place 1 progress on To the Tower.")
                .WithInfo(4, 2, Artist.Piya_Wannachaiwong));
            Cards.Add(LotRCard.Location("Banks of Morgulduin", "7C4182AD-701C-4C6F-A085-17436DAA7AE1", "The Morgul Vale Nightmare", 4, 4)
                .WithTraits("River.")
                .WithText("Forced: When Banks of Morgulduin is explored, deal it facedown as a shadow card to a Captain enemy.")
                .WithShadow("Shadow: If attacking enemy is a Captain, deal it 3 additional shadow cards for this attack.")
                .WithInfo(5, 2, Artist.Katy_Grierson));
            Cards.Add(LotRCard.Location("Ephel Dúath", "0B1BA063-D77E-4A0A-8EC8-D4B269459DC0", "The Morgul Vale Nightmare", 2, 5)
                .WithTraits("Mountain.")
                .WithText("While Ephel Dúath is in the staging area, each Captain enemy gets +2 Attack.")
                .WithShadow("Shadow: Defending player must either place 1 progress token on To the Tower or treat this attack as undefended.")
                .WithInfo(6, 3, Artist.Alyn_Spiller));
            Cards.Add(LotRCard.Location("White-flowered Fields", "C7299C47-662E-42F0-BB39-A3FC3E7BD35F", "The Morgul Vale Nightmare", 3, 3)
                .WithTraits("Valley.")
                .WithText("Forced: At the end of the round, each player must either exhaust a hero he controls or place 1 progress token on To the Tower.")
                .WithShadow("Shadow: Return attacking enemy to the staging area after this attack.")
                .WithInfo(7, 2, Artist.Matthew_Cowdery));
            Cards.Add(LotRCard.Treachery("The Tower Beckons", "76504BE6-5D47-4BF9-9660-09CD25B4BB57", "The Morgul Vale Nightmare")
                .WithText("When Revealed: Place 1 progress token on To the Tower. Until the end of the phase, The Towers Beckons adds X Threat to the total Threat in the staging area, where X is the number of progress tokens on To the Tower.")
                .WithShadow("Shadow: Place 1 progress token on To the Tower.")
                .WithInfo(8, 2, Artist.Darek_Zabrocki));
            Cards.Add(LotRCard.Treachery("Noxious Fumes", "744652A9-FCCC-42A6-9CFA-6C71AC92F108", "The Morgul Vale Nightmare")
                .WithText("When Revealed: Place 1 progress token on To the Tower. Each player must assign damage among characters he controls equal to the number of progress token on To the Tower.")
                .WithShadow("Shadow: If this attack destroys a character, place 1 progress on To the Tower.")
                .WithInfo(9, 2, Artist.Trudi_Castle));
        }
    }
}