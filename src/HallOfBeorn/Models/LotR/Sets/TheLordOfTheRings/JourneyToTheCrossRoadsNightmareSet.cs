using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace HallOfBeorn.Models.LotR.Sets.TheLordOfTheRings
{
    public class JourneyToTheCrossRoadsNightmareSet : CardSet
    {
        private const string setName = "Journey to the Cross-roads Nightmare";

        protected override void Initialize()
        {
            Name = setName;
            Abbreviation = "JttCN";
            SetType = Models.SetType.Nightmare_Expansion;
            Cycle = "NIGHTMARE";
            Number = 2072;
   
            addCard(LotRCard.NightmareSetup(setName, setName)
                .WithText("You are playing Nightmare mode.\r\nSetup: Place 1 ~Southron ~Warrior per player facedown under The ~Cross-roads, then shuffle the facedown cards under The ~Cross-roads. Set any remaining ~Southron Warriors aside, out of play.")
                .WithFlavor("\"Great strength of them was reported to us some days ago, marching north. One of their regiments is due by our reckoning to pass by, some time ere noon...\"\r\n-Mablung, The Two Towers")
                .WithOppositeText("Begin with the standard quest deck and encounter deck for The Journey to the Cross-roads scenario.\r\nRemove the following cards, in the specified quantities, from the standard encounter deck:\r\n1x ~Captain of ~Harad\r\n1x Henneth Annun\r\n2x Southward ~Road\r\n4x ~Hills of ~Ithilien\r\n3x The Dark Lord's Summons\r\nThen, shuffle the encounter cards in this Nightmare ~Deck into the remainder of the standard the Journey to the Cross-roads encounter deck.\r\nFinally, flip this setup card over and place it next to the quest deck. Its effect remains active throughout the game, which is now ready to begin.")
                .WithInfo(1, 1, Artist.Guillaume_Ducos));
            addCard(LotRCard.Enemy("Southron Warrior", string.Empty, setName, 46, 3, 4, 2, 5)
                .WithTraits("Harad.")
                .WithKeywords("Archery 2.")
                .WithTextLine("Archery 2.")
                .WithTextLine("Forced: After ~Southron ~Warrior engages you, discard an ally you control.")
                .WithShadow("Shadow: Attacking enemy gets +1 Attack (+2 Attack instead if the defending character is damaged.")
                .WithInfo(2, 4, Artist.Guillaume_Ducos));
            addCard(LotRCard.Enemy("Southron Rearguard", string.Empty, setName, 38, 4, 6, 4, 8)
                .WithTraits("Harad.")
                .WithText("Cannot have attachments or be placed under The Black Gate.\r\n~Southron Rearguard gets -1 engagement cost for each progress token on stage 1B.")
                .WithShadow("Shadow: Return attacking enemy to the staging area.")
                .WithInfo(3, 2, Artist.Guillaume_Ducos));
            addCard(LotRCard.Location("Wooded Glade", string.Empty, setName, 4, 4)
                .WithTraits("Forest.")
                .WithText("While Wooded Glade is the active location, treat each non-objective attachment's text box as if it were blank.")
                .WithShadow("Shadow: Discard a non-objective attachment you control.")
                .WithInfo(4, 3, Artist.Guillaume_Ducos));
            addCard(LotRCard.Location("Dense Fern-brake", string.Empty, setName, 5, 5)
                .WithTraits("Forest.")
                .WithText("While Dense Fern-brake is the active location, enemies in the staging area are immune to player card effects.")
                .WithShadow("Shadow: Exhaust a character you control.")
                .WithInfo(5, 2, Artist.Lukasz_Jaskolski));
            addCard(LotRCard.Location("Shadowy Thicket", string.Empty, setName, 2, 8)
                .WithTraits("Forest.")
                .WithText("Shadowy Thicket gets +2 Threat for each facedown card under The Black Gate.\r\nTravel: The first player reveals the top facedown card under The Cross-roads and adds it to the staging area to travel here.")
                .WithFlavor("...presently the noise of fighting broke out near at hand, just above their hiding-place.\r\n-The Two Towers")
                .WithInfo(6, 3, Artist.Lukasz_Jaskolski));
            addCard(LotRCard.Treachery("Blind Wrath", string.Empty, setName)
                .WithText("When Revealed: Until the end of the round, each Harad enemy in the staging area gets +2 Threat, -30 engagement cost, and cannot be optionally engaged.")
                .WithShadow("Shadow: Attacking enemy gets +1 Attack. If this attack destroys a character, return attacking enemy to the staging area.")
                .WithInfo(7, 3, Artist.Ivan_Dixon));
            addCard(LotRCard.Treachery("Ware! Ware!", string.Empty, setName)
                .WithKeywords("Peril.", "Surge.")
                .WithTextLine("Peril. Surge.")
                .WithTextLine("When Revealed: Either place this card facedown under The Black Gate, or put the top card under The Cross-roads into play engaged with you.")
                .WithShadow("Shadow: Choose an enemy in the staging area. Engage that enemy and deal it a shadow card.")
                .WithInfo(8, 2, Artist.Uriah_Voth));
        }
    }
}
