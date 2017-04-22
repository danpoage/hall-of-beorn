using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace HallOfBeorn.Models.LotR.Sets
{
    public class TheRingGoesSouthNightmare : CardSet
    {
        private const string setName = "The Ring Goes South Nightmare";

        protected override void Initialize()
        {
            Name = setName;
            Abbreviation = "TRGSN";
            SetType = Models.SetType.Nightmare_Expansion;
            Cycle = "NIGHTMARE";
            Number = 2065;

            addCard(LotRCard.NightmareSetup(setName, setName)
                .WithText("You are playing Nightmare mode.\r\nSetup: Set each copy of Pale-green ~Tentacle aside, out of play.\r\nForced: When the players advance to stage 4B, each player puts 1 copy of Pale-green ~Tentacle into play engaged with him. Shuffle any remaining copies, and the encounter discard pile, into the encounter deck.")
                .WithOppositeText("Begin with the standard and encounter deck for The ~Ring Goes South scenario.\r\nRemove the following cards, in the specified quantities, from the standard encounter deck:\r\n2x Crebain from ~Dunland\r\n2x Howling ~Warg\r\n1x Tree-crowned ~Hill\r\n3x Hills of Hollin\r\n2x Snowdrifts\r\n1x Storm of Howls\r\nThen, shuffle the encounter cards in this Nightmare ~Deck into the remainder of the standard The ~Ring Goes South encounter deck.\r\nFinally, flip this setup card over and place it next to the quest deck. Its effect remains active throughout the game, which is now ready to begin.")
                .WithInfo(1, 1, Artist.JB_Casacop));
            addCard(LotRCard.Enemy("Pale-green Tentacle", string.Empty, setName, 22, 3, 5, 1, 5)
                .WithTraits("Tentacle.")
                .WithText("Cannot have attachments.\r\nWatcher in the Water Cannot take damage.\r\nForced: After Pale-green Tentacle attacks and destroys a character, return Pale-green Tentacle to the staging area.")
                .WithVictoryPoints(3)
                .WithInfo(2, 4, Artist.Lukasz_Jaskolski));
            addCard(LotRCard.Enemy("Hunting Hawk", string.Empty, setName, 44, 4, 4, 3, 5)
                .WithTraits("Creature.")
                .WithText("Cannot have attachments or be optionally engaged.\r\nWhile Hunting Hawk is in the staging area it gains, \"Forced: After a player plays an ally, he must either exhaust it, or place 1 damage on an active location.\"")
                .WithInfo(3, 2, Artist.Aurelien_Hubert));
            addCard(LotRCard.Enemy("Misty Mountain Warg", string.Empty, setName, 33, 2, 4, 3, 4)
                .WithTraits("Creature.", "Warg.")
                .WithText("When Revealed: Misty Mountain Warg makes an immediate attack against you. If it destroys a character, place 2 damage on each active location.")
                .WithShadow("Shadow: If this attack destroys a character, place 1 damage on an active location.")
                .WithInfo(4, 3, Artist.Florian_Devos));
            addCard(LotRCard.Location("Expanse of Hollin", string.Empty, setName, 254, 6)
                .WithTraits("Hills.")
                .WithText("X is 1 more than the number of enemies in play.\r\nForced: When Expanse of Hollin is explored, shuffle the encounter discard pile into the encounter deck. Then, discard the top card of the encounter deck for each damage here. Add each enemy discarded by this effect to the staging area.")
                .WithInfo(5, 3, Artist.Bon_Bernardo));
            addCard(LotRCard.Location("Slopes of Hithaeglir", string.Empty, setName, 3, 5)
                .WithTraits("Hills.")
                .WithText("Forced: After a \"when revealed\" effect is cancelled, place 1 damage on each active location.\r\nForced: When Slopes of Hithaeglir is explored, each player raises his threat by 1 for each damage here.")
                .WithInfo(6, 3, Artist.Yog_Joshi));
            addCard(LotRCard.Treachery("Hunted in Hollin", string.Empty, setName)
                .WithKeywords("Peril.")
                .WithText("When Revealed: Either raise your threat by 6, or engage the lowest engagement cost enemy in the staging area and reveal an encounter card.")
                .WithInfo(7, 2, Artist.Florian_Devos));
            addCard(LotRCard.Treachery("Shelterless Land", string.Empty, setName)
                .WithKeywords("Surge.", "Doomed 1.")
                .WithText("When Revealed: Until the end of the phase, add 1 to the total $ in the staging area for each damage on each active location.")
                .WithShadow("Shadow: Attacking enemy gets +1 Attack for each damage on each active location.")
                .WithInfo(8, 2, Artist.JB_Casacop));
        }
    }
}