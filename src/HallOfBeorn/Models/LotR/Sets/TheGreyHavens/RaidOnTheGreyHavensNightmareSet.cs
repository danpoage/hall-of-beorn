using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace HallOfBeorn.Models.LotR.Sets.TheGreyHavens
{
    public class RaidOnTheGreyHavensNightmareSet : CardSet
    {
        private const string setName = "Raid on the Grey Havens Nightmare";

        protected override void Initialize()
        {
            Name = setName;
            Abbreviation = "RotGHN";
            SetType = Models.SetType.Nightmare_Expansion;
            Cycle = "NIGHTMARE";
            Number = 2083;

            addNightmareSetup(EncounterSet.RaidOnTheGreyHavensNightmare)
                .WithTextLine("You are playing Nightmare mode.")
                .WithTextLine("Captain Sahír and Na'asiyah each gain: \"Cannot have attachments.\"")
                .WithTextLine("Setup: Instead of adding Dream-chaser to the staging area during setup, each player must search the encounter deck for a different unique location and add it to the staging area, one of which must be the Dream-chaser.")
                .WithOppositeTextLine("Begin with the standard quest deck and encounter deck for the Raid on the Grey Havens scenario.")
                .WithOppositeTextLine("Remove the following cards, in the specified quantities, from the standard encounter deck:")
                .WithOppositeTextLine("1x Sahír's Advance (quest stage 2)")
                .WithOppositeTextLine("3x Corsair Arsonist")
                .WithOppositeTextLine("2x Elven Wave-runner")
                .WithOppositeTextLine("1x Umbar Raider")
                .WithOppositeTextLine("Then shuffle the encounter cards in this Nightmare Deck into the remainder of the standard Raid on the Grey Havens encounter deck.")
                .WithOppositeTextLine("Finally, flip this setup card over and place it next to the quest deck. Its effect remains active throughout the game, which is now ready to begin.")
                .WithInfo(1, 1, Artist.Borja_Pindado);
            addQuest("Sahír's Advance", EncounterSet.RaidOnTheGreyHavensNightmare, 2, 'A', Card.VALUE_NA)
                .WithFlavorLine("A menacing ship leads the raiders, its charismatic captain bellowing orders to the Corsairs: \"Kill the defenders!\" he shouts. \"Destroy their ships!\"")
                .WithTextLine("When Revealed: Add Na'asiyah and Captain Sahír to the staging area, enemy side faceup. Each player reveals the top card of the encounter deck. Place resources on Na'asiyah and Captain Sahír equal to the amount of damage on the Dream-chaser. Add 1 resource to each other Raider enemy in play.")
                .WithOppositeTextLine("Resources on Na'asiyah are considered to be on Captain Sahír, as well (and can be removed as if they were on him).")
                .WithOppositeTextLine("Each Raider enemy revealed by the encounter deck enters play with 1 resource on it.")
                .WithOppositeTextLine("If both Captain Sahír and Na'asiyah are in the victory display, the players win the game.")
                .WithIncludedEncounterSets(EncounterSet.CorsairRaiders, EncounterSet.TheStormcallerElite)
                .WithInfo(2, 1, Artist.Sara_Winters);
            addEnemy("Corsair Pillager", EncounterSet.RaidOnTheGreyHavensNightmare, 16, 3, 2, 3, 3)
                .WithTraits("Corsair.", "Raider.")
                .WithTextLine("Durin the combat phase, Corsair Pillager makes 1 additional attack for each resource token on it.")
                .WithTextLine("Forced: After the players travel to an Aflame location, place 1 resource on Corsair Pillager for each damage on that location.")
                .WithInfo(3, 3, Artist.Joshua_Cairos);
            addEnemy("Corsair Pyromaniac", EncounterSet.RaidOnTheGreyHavensNightmare, 44, 2, 2, 2, 4)
                .WithTraits("Corsair.", "Raider.")
                .WithTextLine("Corsair Pyromaniac gets +1 Threat, +1 Attack, and +1 Defense for each resource token on it.")
                .WithTextLine("Forced: After a card is placed underneath The Havens Burn, place 1 resource on Corsair Pyromaniac.")
                .WithInfo(4, 3, Artist.Rafal_Hrynkiewicz);
            addEnemy("Elite Marauder", EncounterSet.RaidOnTheGreyHavensNightmare, 32, 4, 6, 2, 5)
                .WithTraits("Corsair.")
                .WithTextLine("For each excess point of combat damage dealt by Elite Marauder (damage that is dealt beyond the remaining hit points of the character damaged by its attack) you must place 1 damage on an Aflame location in the staging area.")
                .WithInfo(5, 1, Artist.Rafal_Hrynkiewicz);
            addLocation("Nárelenya", EncounterSet.RaidOnTheGreyHavensNightmare, 3, 7)
                .WithUnique()
                .WithTraits("Grey Havens.", "Ship.")
                .WithKeywords("Aflame 10.")
                .WithTextLine("Aflame 10. Immune to player card effects.")
                .WithTextLine("Forced: After the first player plays an ally from his hand, deal 1 damage to the Nárelenya.")
                .WithVictoryPoints(1)
                .WithInfo(6, 1, Artist.Leanna_Crossan);
            addLocation("Dawn Star", EncounterSet.RaidOnTheGreyHavensNightmare, 3, 6)
                .WithUnique()
                .WithTraits("Gondor.", "Ship.")
                .WithKeywords("Aflame 8.")
                .WithTextLine("Aflame 8. Immune to player card effects.")
                .WithTextLine("Forced: After the first player draws and number of cards, deal 1 damage to the Dawn Star.")
                .WithVictoryPoints(1)
                .WithInfo(7, 1, Artist.Leanna_Crossan);
            addLocation("Silver Wing", EncounterSet.RaidOnTheGreyHavensNightmare, 2, 5)
                .WithUnique()
                .WithTraits("Gondor.", "Ship.")
                .WithKeywords("Aflame 6.")
                .WithTextLine("Aflame 6. Immune to player card effects.")
                .WithTextLine("Forced: After the first player attacks and enemy, deal 1 damage to the Silver Wing.")
                .WithVictoryPoints(1)
                .WithInfo(8, 1, Artist.Leanna_Crossan);
            addLocation("Burning Tower", EncounterSet.RaidOnTheGreyHavensNightmare, 2, 6)
                .WithTraits("Grey Havens.")
                .WithKeywords("Aflame 5.")
                .WithTextLine("Aflame 5.")
                .WithTextLine("While Burning Tower is in the staging area, damage cannot be healed.")
                .WithTextLine("Forced: After damage is placed on Burning Tower, choose X characters, where X is the amount of damage on Burning Tower. Deal 1 damage to each chosen character.")
                .WithInfo(9, 2, Artist.Borja_Pindado);
            addCard(LotRCard.Treachery("Sudden Assault", string.Empty, setName)
                .WithTextLine("When Revealed: Each player must either deal 2 damage to an Aflame location in play, or reveal 1 card from the top of the encounter deck.")
                .WithShadow("Shadow: Either deal 2 damage to an Aflame location in play or attacking enemy makes an additional attack after this one.")
                .WithInfo(10, 3, Artist.Adam_Duff));
            addCard(LotRCard.Treachery("Infiltration", string.Empty, setName)
                .WithTextLine("When Revealed: Remove 1 resource from each hero in play. Distribute those resources as evenly as possible among Raider enemies in play or set aside.")
                .WithShadow("Shadow: Damage from this attack is dealt to an Aflame location in play instead of the defending character.")
                .WithInfo(11, 2, Artist.Joshua_Cairos));
        }
    }
}
