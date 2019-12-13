using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace HallOfBeorn.Models.LotR.Sets.TheGreyHavens
{
    public class VoyageAcrossBelegaerNightmare : CardSet
    {
        private const string setName = "Voyage Across Belegaer Nightmare";

        protected override void Initialize()
        {
            Name = setName;
            Abbreviation = "VaBN";
            SetType = Models.SetType.Nightmare_Expansion;
            Cycle = "NIGHTMARE";
            Number = 2081;

            addCard(LotRCard.NightmareSetup(setName, setName)
                .WithText("You are playing Nightmare mode.")
                .WithFlavor("\"Then I thought in my heart that we drew near to the Sea; for wide was the water in the darkness, and sea-birds innumerable cried on its shores.\"\r\n-Legolas, The Return of the King")
                .WithOppositeText(
@"Begin with the standard quest deck and encounter deck for the Voyage Across Belegaer scenario.\r\nRemove the following cards, in the specified quantities, from the standard encounter deck:

2x Southron Sailor
1x Starlit Sea
1x Fog Bank
2x Calm Waters
2x Thrown Off Course
1x Scouting Ship

Then shuffle the encounter cards in this Nightmare Deck into the remainder of the standard Voyage Across Belegaer encounter deck.

Finally, flip this setup card over and place it next to the quest deck. Its effect remains active throughout the game, which is now ready to begin.

☸*: Some Cards in the Grey Havens Nightmare Decks have Sailing Success symbols (☸) with an asterisk (*) next to them. This indicates that the card has a Forced effect which will trigger when the card is discarded during a sailing test.")
                .WithTemplate2(
@"<p>Begin with the standard quest deck and encounter deck for the Voyage Across Belegaer scenario.\r\nRemove the following cards, in the specified quantities, from the standard encounter deck:</p>
<ul style='list-style-type:none'><b>
<li>2x Southron Sailor</li>
<li>1x Starlit Sea</li>
<li>1x Fog Bank</li>
<li>2x Calm Waters</li>
<li>2x Thrown Off Course</li>
<li>1x Scouting Ship</li>
</b></ul>
<p>Then shuffle the encounter cards in this Nightmare Deck into the remainder of the standard Voyage Across Belegaer encounter deck.</p>
<p>Finally, flip this setup card over and place it next to the quest deck. Its effect remains active throughout the game, which is now ready to begin.</p>
<p><b>☸*:</b> Some Cards in the Grey Havens Nightmare Decks have Sailing Success symbols (<b>☸</b>) with an asterisk (<b>*</b>) next to them. This indicates that the card has a <b>Forced</b> effect which will trigger when the card is discarded during a sailing test.</p>")
                .WithInfo(1, 1, Artist.Leanna_Crossan));
            addCard(LotRCard.Quest("Corsair Confrontation", 2, setName, 255)
                .WithKeywords("Sailing.")
                .WithFlavor("\"Corsairs ahead!\" an Elven lookout shouts. You are about to give the order to steer away from the warship, when Calaphon abruptly stops you. \"Wait! In my dream, I remember a great battle against a powerful fleet. Could this mean we are on the right track?\" Reluctantly, you prepare to fight.")
                .WithText("When Revealed: Search the encounter deck, discard pile and victory display for 1 copy of Corsair Warship and add it to the staging area. Shuffle the encounter deck.")
                .WithOppositeText("Sailing.\r\nForced: At the end of the quest phase, if there is no Corsair Warship in play, this stage is defeated.\r\nWhen this stage is defeated, if you are on course (☀), look at the top 2 stages of the quest deck and advance to one of your choice, placing the other on the bottom of the quest. Otherwise, advance to the top stage of the quest deck.")
                .WithVictoryPoints(3)
                .WithIncludedEncounterSets(EncounterSet.VastOceans, EncounterSet.StormyWeather, EncounterSet.UmbarFleet, EncounterSet.CorsairPirates, EncounterSet.TheDreamChasersFleet)
                .WithInfo(2, 1, Artist.Borja_Pindado));
            addCard(LotRCard.Quest("Lost at Sea", 2, setName, 255)
                .WithKeywords("Sailing.")
                .WithFlavor("These seas are strange and bewildering. Try as you might, you cannot find any stars you recognize in the overcast sky. You realize now that you may never find your way back to shore.")
                .WithText("When Revealed: Set your heading to the worst setting (⚡).")
                .WithOppositeText("Sailing. Cancel the first ☸ symbol found during each Sailing test.\r\nForced: At the end of the quest phase, if your heading is on-course (☀), this stage is defeated.\r\nWhen this stage is defeated, look at the top 3 stages of the quest deck and advance to one of your choice, placing the others on the bottom of the quest deck.")
                .WithVictoryPoints(3)
                .WithIncludedEncounterSets(EncounterSet.VastOceans, EncounterSet.StormyWeather, EncounterSet.UmbarFleet, EncounterSet.CorsairPirates, EncounterSet.TheDreamChasersFleet)
                .WithInfo(3, 1, Artist.Jeff_Lee_Johnson));
            addCard(LotRCard.Enemy("Brash Corsair", string.Empty, setName, 16, 3, 3, 4, 3)
                .WithTraits("Corsair.")
                .WithText("Forced: When the engaged player exhausts a Ship objective. Brash Corsair makes an immediate attack.")
                .WithInfo(4, 3, Artist.Suzanne_Helmigh));
            addCard(LotRCard.Enemy("Sahír's Pursuer", string.Empty, setName, 40, 3, 7, 3, 8)
                .WithTraits("Corsair.", "Ship.")
                .WithKeywords("Boarding 1.")
                .WithTextLine("Boarding 1. Cannot have attachments.")
                .WithTextLine("Forced: At the end of the encounter phase, if Sahír's Pursuer is in the staging area, the first player must either engage it or shift your heading off-course.")
                .WithInfo(5, 2, Artist.Jessica_Cheng));
            addCard(LotRCard.Location("Open Waters", string.Empty, setName, 2, 6)
                .WithTraits("Ocean.")
                .WithText("While Open Waters is in the staging area, each Ship enemy gets -5 engagement cost and +1 Threat.\r\nTravel: One player must exhaust a Ship objective to travel here.\r\n☸")
                .WithInfo(6, 2, Artist.DinoDrawing));
            addCard(LotRCard.Location("Shattered Sea", string.Empty, setName, 4, 4)
                .WithTraits("Ocean.")
                .WithText("While your heading is ⛅, Shattered Sea gets +2 Threat and +2 quest points.\r\nWhile your heading is Rainy, Shattered Sea gets +4 Threat and +4 quest points.\r\nWhile your heading is ⚡, Shattered Sea gets +6 Threat and +6 quest points.\r\n☸")
                .WithInfo(7, 2, Artist.Borja_Pindado));
            addCard(LotRCard.Treachery("Rogue Wave", string.Empty, setName)
                .WithTraits("Weather.")
                .WithText("When Revealed: Each player must either exhaust a Ship objective he controls or distribute 4 damage among characters he controls (6 damage instead if you are off course).")
                .WithShadow("Shadow: Attacking enemy gets +1 Attack for each quest card in the victory display.")
                .WithInfo(8, 3, Artist.Oleg_Saakyan));
            addCard(LotRCard.Treachery("Dreams of Númenor", string.Empty, setName)
                .WithText("When Revealed: Either set your heading to the worst setting (⚡) or exhaust all allies in play.\r\n☸")
                .WithShadow("Shadow: If you are off-coruse (Cloudy, Rainy, or Stormy), attacking enemy makes an additional attack after this one.")
                .WithInfo(9, 2, Artist.DinoDrawing));
            addCard(LotRCard.Treachery("Raging Squall", string.Empty, setName)
                .WithTraits("Weather.")
                .WithKeywords("Surge.")
                .WithTextLine("Surge.")
                .WithTextLine("*Forced: After Raging Squall is discarded from the encounter deck duirng a Sailing test, deal 1 damage to each character committed to that test.")
                .WithTextLine(string.Empty);
                .WithTextLine("☸*")
                .WithInfo(10, 2, Artist.Leanna_Crossan));
        }
    }
}
