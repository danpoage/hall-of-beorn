using System;

namespace HallOfBeorn.Models.LotR.Sets.TheLostRealm
{
    public class TheWeatherHillsNightmareSet : CardSet
    {
        protected override void Initialize()
        {
            Name = EncounterSet.TheWeatherHillsNightmare.Name;
            Abbreviation = "TWHN";
            SetType = Models.SetType.Nightmare_Expansion;
            Cycle = "NIGHTMARE";
            Number = 2073;

            addNightmareSetup(EncounterSet.TheWeatherHillsNightmare.Name)
                .WithText("You are playing Nightmare mode.\r\nSetup: Shuffle each copy of ~Captive Villager and Rearguard Ambusher into the ~Orc deck.\r\nThe players cannot win the game while a Captive Villager is guarded by an encounter card. If a Captive Villager leaves play, the players lose the game.")
                .WithFlavor("The land before them began to rise again, Away in the distance eastward they could not see a line of hills.\r\n-The Fellowship of the Ring")
                .WithOppositeText(
@"Begin with the standard quest deck and encounter deck for The ~Weather Hills scenario.

Remove the following cards, in the specified quantities, from the standard encounter deck:

3x Cornered ~Orc
3x Sheltered Valley
1x Concealed Orc-camp
1x ~Angmar Marauder
2x ~Angmar ~Orc
3x Ruins of ~Arnor
2x Tragic Discovery

Then, shuffle the encounter cards in this Nightmare Deck into the remainder of the standard The Weather Hills encounter deck.

Finally, flip this setup card over and place it next to the quest deck. Its effect remains active throughout the game, which is now ready to begin.")
                .WithTemplate2(
@"<p>Begin with the standard quest deck and encounter deck for The Weather Hills scenario.</p>
<p>Remove the following cards, in the specified quantities, from the standard encounter deck:</p>
<ul style='list-style-type:none'><b>
<li>3x Cornered Orc</li>
<li>3x Sheltered Valley</li>
<li>1x Concealed Orc-camp</li>
<li>1x Angmar Marauder</li>
<li>2x Angmar Orc</li>
<li>3x Ruins of Arnor</li>
<li>2x Tragic Discovery</li>
</b></ul>
<p>Then, shuffle the encounter cards in this Nightmare Deck into the remainder of the standard The Weather Hills encounter deck.</p>
<p>Finally, flip this setup card over and place it next to the quest deck. Its effect remains active throughout the game, which is now ready to begin.</p>")
                .WithInfo(11, 1, Artist.Juan_Carlos_Barquet);
            addObjectiveAlly("Captive Villager", EncounterSet.TheWeatherHillsNightmare.Name, 0, 0, 1, 2)
                .WithTraits("Bree.")
                .WithText("Forced: After Captive Villager enters play, reveal the top card of the Orc deck and attach it to Captie Villager, guarding it.\r\nWhile Captive Villager is free of encounters, the first player gains control of it and is considered to have +5 threat while making engagement checks.")
                .WithInfo(12, 3, Artist.Ben_Bernardo);
            addEnemy("Rearguard Ambusher", EncounterSet.TheWeatherHillsNightmare.Name, 17, 1, 4, 2, 4)
                .WithTraits("Orc.")
                .WithText("Cannot be optionally engaged.\r\nForced: After Rearguard Ambusher engages you, exhaust each damaged character you control.")
                .WithFlavor("His broad flat face was swart, his eyes were like coals, and his tongue was red; he wielded a great spear.\r\n-THe Fellowship of the Ring")
                .WithInfo(13, 3, Artist.Guillaume_Ducos);
            addEnemy("Angmar Raider", EncounterSet.TheWeatherHillsNightmare.Name, 44, 3, 5, 3, 5)
                .WithTraits("Orc.")
                .WithText("Forced: After a character the engaged player controls is healed, Angmar Raider makes an immediate attack.")
                .WithShadow("Shadow: Attacking enemy gets +2 Defense until the end of the phase.")
                .WithInfo(14, 4, Artist.JB_Casacop);
            addLocation("Weather-torn Valley", EncounterSet.TheWeatherHillsNightmare.Name, 5, 5)
                .WithTraits("Arnor.", "Hills.")
                .WithText("Progress cannot be placed on Weather-torn Valley while it is in the staging area.\r\nWhile Weather-torn valley is active location, Weather cards cannot be canceled.")
                .WithFlavor("...suddenly a light came in the sky, and there was a noise of thunder.\r\n-The Fellowship of the Ring")
                .WithInfo(15, 2, Artist.Juan_Carlos_Barquet);
            addLocation("Ruined Watch-tower", EncounterSet.TheWeatherHillsNightmare.Name, 3, 4)
                .WithTraits("Arnor.", "Ruins.")
                .WithText("While Ruined Watch-tower is in the staging area, it gains: \"Forced: When an Orc enemy is revealed, each player must deal 1 damage to a character he controls.\r\nWhile Ruined Watch-tower is the active location, each enemy gets +3 Defense.")
                .WithInfo(16, 3, Artist.Lukasz_Jaskolski);
            addTreachery("Rain-washed Tracks", EncounterSet.TheWeatherHillsNightmare.Name)
                .WithTraits("Weather.")
                .WithText("When Revealed: Either remove 1 resource token from the Mission objective, or add 8 to the total Threat in the staging area this phase.")
                .WithShadow("Shadow: Either remove 1 resource token from the Mission objective, or attacking enemy gets +3 Attack.")
                .WithInfo(17, 3, Artist.Monztre);
            addEncounterSideQuest("Track the Orcs", EncounterSet.TheWeatherHillsNightmare.Name, 8)
                .WithFlavor("The weather makes the Orcs difficult to track. It requires all of your skill to read the signs in the rough terrain.")
                .WithText("Each enemy gets +10 enagement cost and cannot be optionally engaged.\r\nWhen Revealed: Reveal the top of card of the Orc deck (reveal the top 2 card instead if there are 3 or more players in the game).")
                .WithVictoryPoints(10)
                .WithInfo(18, 1, Artist.Arden_Beckwith);
        }
    }
}
