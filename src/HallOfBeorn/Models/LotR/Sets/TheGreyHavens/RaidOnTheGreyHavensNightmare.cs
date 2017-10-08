using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace HallOfBeorn.Models.LotR.Sets.TheGreyHavens
{
    public class RaidOnTheGreyHavensNightmare : CardSet
    {
        private const string setName = "Raid on the Grey Havens Nightmare";

        protected override void Initialize()
        {
            Name = setName;
            Abbreviation = "RotGHN";
            SetType = Models.SetType.Nightmare_Expansion;
            Cycle = "NIGHTMARE";
            Number = 2083;

            addCard(LotRCard.NightmareSetup(setName, setName)
                .WithText("You are playing Nightmare mode.\r\nCaptain Sahír and Na'asiyah each gain: \"Cannot have attachments.\"\r\nSetup: Instead of adding Dream-chaser to the staging area during setup, each player must search the encounter deck for a different unique location and add it to the staging area, one of which must be the Dream-chaser.")
                .WithTemplate(
@"<p>You are playing Nightmare mode.</p>
<p>Captain Sahír and Na'asiyah each gain: &ldquo;Cannot have attachments.&rdquo;</p>
<p><b>Setup:</b> Instead of adding Dream-chaser to the staging area during setup, each player must search the encounter deck for a different unique location and add it to the staging area, one of which must be the Dream-chaser.</p>")
                .WithOppositeText(
@"Begin with the standard quest deck and encounter deck for the Raid on the Grey Havens scenario.\r\nRemove the following cards, in the specified quantities, from the standard encounter deck:

1x Sahír's Advance (quest stage 2)
3x Corsair Arsonist
2x Elven Wave-runner
1x Umbar Raider

Then shuffle the encounter cards in this Nightmare Deck into the remainder of the standard Raid on the Grey Havens encounter deck.

Finally, flip this setup card over and place it next to the quest deck. Its effect remains active throughout the game, which is now ready to begin.")
                .WithTemplate2(
@"<p>Begin with the standard quest deck and encounter deck for the Raid on the Grey Havens scenario.\r\nRemove the following cards, in the specified quantities, from the standard encounter deck:</p>
<ul style='list-style-type:none'><b>
<li>1x Sahír's Advance (quest stage 2)</li>
<li>3x Corsair Arsonist</li>
<li>2x Elven Wave-runner</li>
<li>1x Umbar Raider</li>
</b></ul>
<p>Then shuffle the encounter cards in this Nightmare Deck into the remainder of the standard Raid on the Grey Havens encounter deck.</p>
<p>Finally, flip this setup card over and place it next to the quest deck. Its effect remains active throughout the game, which is now ready to begin.</p>")
                .WithInfo(1, 1, Artist.Borja_Pindado));
            addCard(LotRCard.Quest("Sahír's Advance", 2, setName, Card.VALUE_NA)
                .WithFlavor("A menacing ship leads the raiders, its charismatic captain bellowing orders to the Corsairs: \"Kill the defenders!\" he shouts. \"Destroy their ships!\"")
                .WithText("When Revealed: Add Na'asiyah and Captain Sahír to the staging area, enemy side faceup. Each player reveals the top card of the encounter deck. Place resources on Na'asiyah and Captain Sahír equal to the amount of damage on the Dream-chaser. Add 1 resource to each other Raider enemy in play.")
                .WithOppositeText("Resources on Na'asiyah are considered to be on Captain Sahír, as well (and can be removed as if they were on him).\r\nEach Raider enemy revealed by the encounter deck enters play with 1 resource on it.\r\nIf both Captain Sahír and Na'asiyah are in the victory display, the players win the game.")
                .WithInfo(2, 1, Artist.Sara_Winters));
            addCard(LotRCard.Enemy("Corsair Pillager", string.Empty, setName, 16, 3, 2, 3, 3)
                .WithTraits("Corsair.", "Raider.")
                .WithText("Durin the combat phase, Corsair Pillager makes 1 additional attack for each resource token on it.\r\nForced: After the players travel to an Aflame location, place 1 resource on Corsair Pillager for each damage on that location.")
                .WithInfo(3, 3, Artist.Joshua_Cairos));
            addCard(LotRCard.Enemy("Corsair Pyromaniac", string.Empty, setName, 44, 2, 2, 2, 4)
                .WithTraits("Corsair.", "Raider.")
                .WithText("Corsair Pyromaniac gets +1 Threat, +1 Attack, and +1 Defense for each resource token on it.\r\nForced: After a card is placed underneath The Havens Burn, place 1 resource on Corsair Pyromaniac.")
                .WithInfo(4, 3, Artist.Rafal_Hrynkiewicz));
            addCard(LotRCard.Enemy("Elite Marauder", string.Empty, setName, 32, 4, 6, 2, 5)
                .WithTraits("Corsair.")
                .WithText("For each excess point of combat damage dealt by Elite Marauder (damage that is dealt beyond the remaining hit points of the character damaged by its attack) you must place 1 damage on an Aflame location in the staging area.")
                .WithInfo(5, 1, Artist.Rafal_Hrynkiewicz));
            addCard(LotRCard.Location("Nárelenya", string.Empty, setName, 3, 7)
                .WithUnique()
                .WithTraits("Grey Havens.", "Ship.")
                .WithKeywords("Aflame 10.")
                .WithText("Immune to player card effects.\r\nForced: After the first player plays an ally from his hand, deal 1 damage to the Nárelenya.")
                .WithVictoryPoints(1)
                .WithInfo(6, 1, Artist.Leanna_Crossan));
            addCard(LotRCard.Location("Dawn Star", string.Empty, setName, 3, 6)
                .WithUnique()
                .WithTraits("Gondor.", "Ship.")
                .WithKeywords("Aflame 8.")
                .WithText("Immune to player card effects.\r\nForced: After the first player draws and number of cards, deal 1 damage to the Dawn Star.")
                .WithVictoryPoints(1)
                .WithInfo(7, 1, Artist.Leanna_Crossan));
            addCard(LotRCard.Location("Silver Wing", string.Empty, setName, 2, 5)
                .WithUnique()
                .WithTraits("Gondor.", "Ship.")
                .WithKeywords("Aflame 6.")
                .WithText("Immune to player card effects.\r\nForced: After the first player attacks and enemy, deal 1 damage to the Silver Wing.")
                .WithVictoryPoints(1)
                .WithInfo(8, 1, Artist.Leanna_Crossan));
            addCard(LotRCard.Location("Burning Tower", string.Empty, setName, 2, 6)
                .WithText("Grey Havens.")
                .WithKeywords("Aflame 5.")
                .WithText("While Burning Tower is in the staging area, damage cannot be healed.\r\nForced: After damage is placed on Burning Tower, choose X characters, where X is the amount of damage on Burning Tower. Deal 1 damage to each chosen character.")
                .WithInfo(9, 2, Artist.Borja_Pindado));
            addCard(LotRCard.Treachery("Sudden Assault", string.Empty, setName)
                .WithText("When Revealed: Each player must either deal 2 damage to an Aflame location in play, or reveal 1 card from the top of the encounter deck.")
                .WithShadow("Shadow: Either deal 2 damage to an Aflame location in play or attacking enemy makes an additional attack after this one.")
                .WithInfo(10, 3, Artist.Adam_Duff));
            addCard(LotRCard.Treachery("Infiltration", string.Empty, setName)
                .WithText("When Revealed: Remove 1 resource from each hero in play. Distribute those resources as evenly as possible among Raider enemies in play or set aside.")
                .WithShadow("Shadow: Damage from this attack is dealt to an Aflame location in play instead of the defending character.")
                .WithInfo(11, 2, Artist.Joshua_Cairos));
        }
    }
}