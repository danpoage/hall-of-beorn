using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace HallOfBeorn.Models.LotR.Sets.TheRingMaker
{
    public class TheThreeTrialsNightmare : CardSet
    {
        private const string setName = "The Three Trials Nightmare";

        protected override void Initialize()
        {
            Name = setName;
            Abbreviation = "TTTN";
            SetType = Models.SetType.Nightmare_Expansion;
            Cycle = "NIGHTMARE";
            Number = 2069;

            Cards.Add(new LotRCard()
            {
                Title = setName,
                CardType = CardType.Nightmare_Setup,
                Text = "You are playing Nightmare mode.\r\nEach engaged Guardian enemy contributes its Threat to the total Threat in the staging area.\r\nWhile the Trial of Intuition is the current trial, each Guardian enemy cannot be damaged, and each Barrow location cannot be the active location and is immune to player card effects.",
                FlavorText = "\"I am not ready for such a trial, if indeed I shall ever be so...\"\r\n-Gandalf, The Two Towers",
                OppositeText =
@"Begin with the standard quest deck and encounter deck for The Three Trials scenario.

Remove the following cards, in the specified quantities, from the standard encounter deck:

3x ~Spirit of the Wild
3x Grim Foothills
1x Tangled Woods
3x Turned Around

Then, shuffle the encounter cards in this Nightmare Deck into the remainder of the standard The Three Trials encounter deck.

Finally, flip this setup card over and place it next to the quest deck. Its effects remain active throughout the game, which is now ready to begin.",
                EncounterSet = setName,
                Quantity = 1,
                CardNumber = 1,
                Artist = Artist.Alvaro_Calvo_Escudero
            });
            Cards.Add(LotRCard.Enemy("Wolf Spirit", "", setName, 30, 2, 5, 1, 6)
                .WithTraits("Undead.", "Spirit.", "Wolf.")
                .WithText("If Wolf's Guardian is in play or in the victory display, each Wolf enemy gets +1 Attack.\r\nForced: At the beginning of the encounter phase, Wolf Spirit engages the player who controls Key of the Wolf or is engaged with Wolf's Guardian, if able.")
                .WithInfo(2, 3, Artist.Anthony_Devine));
            Cards.Add(LotRCard.Enemy("Boar Spirit", "", setName, 20, 1, 4, 2, 5)
                .WithTraits("Undead.", "Spirit.", "Boar.")
                .WithText("If Boar's Guardian is in play or in the victory display, each Boar enemy gets +1 Defense.\r\nForced: At the beginning of the encounter phase, Boar Spirit engages the player who controls Key of the Boar or is engaged with Boar's Guardian, if able.")
                .WithInfo(3, 3, Artist.Anthony_Devine));
            Cards.Add(LotRCard.Enemy("Raven Spirit", "", setName, 40, 3, 3, 3, 4)
                .WithTraits("Undead.", "Spirit.", "Raven.")
                .WithText("If Raven's Guardian is in play or in the victory display, each Raven enemy gets +1 Threat.\r\nForced: At the beginning of the encounter phase, Raven Spirit engages the player who controls Key of the Raven or is engaged with Raven's Guardian, if able.")
                .WithInfo(4, 3, Artist.Anthony_Devine));
            Cards.Add(LotRCard.Location("Sacred Forest", "", setName, 3, 5)
                .WithTraits("Forest.")
                .WithText("While Sacred Forest is in the staging area, each Guardian enemy gains: \"Forced: After any number of time counters are removed from this enemy, heal 2 damage on it for each time counter removed.\"\r\nTravel: Remove each time counter from an enemy in play to travel here.")
                .WithInfo(5, 3, Artist.Yoann_Boissonnet));
            Cards.Add(LotRCard.Location("Haunted Pillars", "", setName, 2, 3)
                .WithTraits("Forest.", "Hills.")
                .WithText("When faced with the option to travel, players must travel to Haunted Pillars, if able.\r\nWhen Revealed: Either return the active location to the staging area, or Haunted Pillars gains surge.")
                .WithShadow("Shadow: Attacking enemy gets +3 Defense until the end of the phase.")
                .WithInfo(6, 2, Artist.Alvaro_Calvo_Escudero));
            Cards.Add(LotRCard.Treachery("Cursed Burden", "", setName)
                .WithKeywords("Surge.")
                .WithTextLine("Surge.")
                .WithTextLine("When Revealed: Attach to a hero with a Key objective attached, if able. (Counts as a Condition attachment with the text: \"Limit 1 per hero. Attached hero cannot commit to the quest, and cannot attack or defend against enemies with a Trait shared by any of that hero's attached Key objectives.\")")
                .WithInfo(7, 3, Artist.Jessica_Savard));
            Cards.Add(LotRCard.Treachery("Trial of Ancestors", "", setName)
                .WithText("When Revealed: Attach to the current quest. (Counts as Condition attachment with the text: \"Each non-unique characters gets -1 Willpower and cannot attack enemies that share a Trait with the current trial's Key objective.\")")
                .WithShadow("Shadow: If the defending character is not unique, attacking enemy gets +10 Attack.")
                .WithInfo(8, 2, Artist.Davis_Engel));
        }
    }
}