/* Generated CardSet class: The Drowned Ruins */

using System;

namespace HallOfBeorn.Models.LotR.Sets.DreamChaser
{
    public class TheDrownedRuinsSet : CardSet
    {
        protected override void Initialize()
        {
            Name = "The Drowned Ruins";
            Abbreviation = "TDRu";
            Number = 39;
            SetType = Models.SetType.Adventure_Pack;
            Cycle = "Dream-chaser";

            addHero("Argalad", 9, Sphere.Lore, 2, 2, 1, 4)
                .WithTraits("Silvan.", "Scout.")
                .WithKeywords("Ranged.")
                .WithTextLine("Ranged.")
                .WithTextLine("Action: Exhaust Argalad to choose an enemy in the staging area. Until the end of the phase, that enemy gets -X Threat, where X is Argalad's Attack. If this effect reduces the enemy's Threat to 0, deal 1 damage to it. (Limit once per round.)")
                .WithInfo(82, 1, Artist.Andreia_Ugrai);
            addAlly("Dwarven Sellsword", 1, Sphere.Leadership, false, 2, 2, 2, 3)
                .WithTraits("Dwarf.", "Warrior.")
                .WithTextLine("Forced: At the end of the round, discard Dwarven Sellsword unless the players as a group spend 1 Leadership resource.")
                .WithFlavorLine("...he did not altogether approve of dwarves and their love of gold...")
                .WithFlavorLine("-The Hobbit")
                .WithInfo(83, 3, Artist.Marius_Bota);
            addAttachment("Dúnedain Remedy", 0, Sphere.Leadership, false)
                .WithTraits("Signal.")
                .WithTextLine("Attach to a hero.")
                .WithTextLine("Response: After ~Dúnedain Remedy is attached to a hero, heal 1 damage on that hero.")
                .WithTextLine("Action: Pay 1 resource from attached hero's resource pool to attach ~Dúnedain Remedy to another hero.")
                .WithInfo(84, 3, Artist.Drazenka_Kimpel);
            addAlly("Marksman of Lórien", 3, Sphere.Tactics, false, 0, 3, 0, 2)
                .WithTraits("Silvan.", "Warrior.")
                .WithKeywords("Ranged.")
                .WithTextLine("Ranged.")
                .WithTextLine("Response: After Marksman of Lórien enters play, choose an enemy. That enemy gets -2 Defense until the end of the round.")
                .WithFlavorLine("\"Keen are the eyes of the Elves.\"")
                .WithFlavorLine("-Aragorn, The Two Towers")
                .WithInfo(85, 3, Artist.Drazenka_Kimpel);
            addEvent("Battle-fury", 1, Sphere.Tactics)
                .WithTextLine("Play only before the staging step.")
                .WithTextLine("Quest Action: Exhaust a hero you control to immediately declare it as an attacker (and resolve its attack) against any eligible enemy target. Then, the players as a group may spend 1 Spirit resource to commit that hero to the quest.")
                .WithFlavorLine("Fey he seemed, or the battle-fury of his fathers ran like new fire in his veins...")
                .WithFlavorLine("-The Return of the King")
                .WithInfo(86, 3, Artist.Guillaume_Ducos);
            addAlly("Woodland Courier", 2, Sphere.Spirit, false, 1, 1, 0, 1)
                .WithTraits("Silvan.", "Scout.")
                .WithTextLine("Response: After Woodland Courier enters play, place 1 progress on a location (2 progress instead if that location has the Forest trait).")
                .WithInfo(87, 3, Artist.Drazenka_Kimpel);
            addAttachment("Hithlain", 1, Sphere.Spirit, false)
                .WithTraits("Item.")
                .WithTextLine("Attach to a location. Limit 1 per location.")
                .WithTextLine("Response: After a player plays a Silvan ally from his hand, place 1 progress on attached location.")
                .WithFlavorLine("He made his end of the rope fast about another tree, and then ran lightly along it, over the river and back again, as if he were on a round.")
                .WithFlavorLine("-The Fellowship of the Ring")
                .WithInfo(88, 3, Artist.Mariusz_Gandzel);
            addAlly("Robin Smallburrow", 2, Sphere.Lore, true, 2, 0, 1, 2)
                .WithTraits("Hobbit.", "Shirriff.")
                .WithTextLine("Response: After you travel to a location, spend 1 Spirit resource to raise the engagement cost of each enemy in play by X until the end of the round, where X is that location's quest points. Any player may trigger this response.")
                .WithFlavorLine("\"Gave me a chance of walking round the country and seeing folk, and hearing the news, and knowing where the good beer was.\"")
                .WithFlavorLine("-The Return of the King")
                .WithCommunityVersion("Hrodebert/Robin-Smallburrow")
                .WithInfo(89, 3, Artist.Aleksander_Karcz);
            addEvent("Interrogation", 1, Sphere.Lore)
                .WithTextLine("Action: Choose an enemy with an attached Trap card. Look at the top X cards of the encounter deck, where X is that enemy's printed Threat. You may discard 1 of those cards. Return the rest to the top of the deck, in the same order.")
                .WithInfo(90, 3, Artist.Joshua_Cairos);
            addAttachment("Strider", 1, Sphere.Neutral, true)
                .WithTraits("Title.")
                .WithTextLine("Attach to a hero.")
                .WithTextLine("While you control 2 or fewer heroes, attached hero does not exhaust to commit to the quest.")
                .WithTextLine("While you control 5 or fewer characters, attached hero gets +2 Willpower.")
                .WithFlavorLine("\"Strider can take you by paths that are seldom tridden. Will you have him?\"")
                .WithFlavorLine("-Aragorn, The Fellowship of the Ring")
                .WithCommunityVersion("Autumn/Strider")
                .WithInfo(91, 3, Artist.Ken_McCuen);
            addQuest("The Grotto", EncounterSet.TheDrownedRuins, 1, 'A', 15)
                .WithTextLine("Setup: Set Shrine to Morgoth aside, out of play. Prepare the ~Grotto deck. Add the top 2 locations from the ~Grotto deck to the staging area, Grotto side faceup (the top 3 instead if there are 3 or more players in the game). The first player takes control of ~Captain Sahír, and the last player takes control of Na'asiyah (objective-ally sides faceup).")
                .WithFlavorLine("In the sunken ruins of the temple, you find a grotto leading deep below the sea level. Much of the grotto is submerged underwater.")
                .WithOppositeTextLine("While an underwater location is the active location, players cannot play attachments or allies.")
                .WithOppositeTextLine("Forced: After a double-sided location is explored, add the top location from the ~Grotto deck to the staging area, Grotto side faceup.")
                .WithOppositeTextLine("You cannot advance unless there are at least 3 Underwater locations in the victory display.")
                .WithIncludedEncounterSets(EncounterSet.TheStormcallerElite, EncounterSet.DrownedDead)
                .WithInfo(92, 1, Artist.Mariusz_Gandzel);
            addQuest("Sahír's Betrayal", EncounterSet.TheDrownedRuins, 2, 'A', null)
                .WithTextLine("When Revealed: Make the set aside Shrine to Morgoth the active location, Grotto side faceup. ~Captain Sahír flips to his enemy side (removing all tokens) and makes an immediate attack against the first player. Remove ~Captain Sahír from the game. Each player searches the encounter deck and discard pile for an Undead enemy and adds it to the staging area. Shuffle the encounter deck.")
                .WithFlavorLine("In the center of the shrine, reverently placed on a large altar, lies a long black chest. As soon as you get close, Sahír knocks one of the heroes over and grabs it!")
                .WithOppositeTextLine("While an Underwater location is the active location, players cannot play attachments or allies.")
                .WithOppositeFlavorLine("You dive at Sahír, but he swiftly runs to the entrance, laughing as he seals you in. \"Captain?! What about me?\" Na'asiyah scream angrily. As soon as the entrace is sealed shut, the walls shudder, and water begins to leak rapidly from the ceiling and walls. \"We have to get out of here!\" the heroes shout, as the water level starts to rise.")
                .WithIncludedEncounterSets(EncounterSet.TheStormcallerElite, EncounterSet.DrownedDead)
                .WithInfo(93, 1, Artist.Sara_Winters);
            addLocation("Shrine to Morgoth", EncounterSet.TheDrownedRuins, 5, 18)
                .WithUnique()
                .WithSlugSuffix("Grotto")
                .WithTraits("Ruins.", "Underground.", "Grotto.")
                .WithTextLine("Shrine to Morgoth cannot have attachments and cannot enter the staging area.")
                .WithTextLine("Forced: At the beginning of the quest phase, flip Shrine to Morgoth to its Underwater side, without removing its progress tokens.")
                .WithTextLine("When Shrine to Morgoth is placed in the victory display, the players have escaped from the flooded grotto and win the game.")
                .WithVictoryPoints(5)
                .WithInfo(94, 1, Artist.Federico_Musetti);
            addLocation("Shrine to Morgoth", EncounterSet.TheDrownedRuins, 5, 18)
                .WithUnique()
                .WithSlugSuffix("Underwater")
                .WithTraits("Ruins.", "Underground.", "Underwater.")
                .WithTextLine("Shrine to Morgoth cannot have attachments and cannot enter the staging area.")
                .WithTextLine("Forced: If Shrine to Morgoth is the active location at the end of the quest phase, raise each player's threat by 5.")
                .WithTextLine("When Shrine to Morgoth is placed in the victory display, the players have escaped the flooded grotto and win the game.")
                .WithVictoryPoints(5)
                .WithInfo(95, 1, Artist.Federico_Musetti);
            addEnemy("Sea-scorpion", EncounterSet.TheDrownedRuins, 30, 2, 2, 2, 4)
                .WithTraits("Creature.")
                .WithTextLine("Sea-scorpion gets +2 Attack if the active location is underwater.")
                .WithShadow("Shadow: Attacking enemy gets +1 Attack (+2 Attack instead if the active location is Underwater).")
                .WithInfo(96, 3, Artist.Aleksander_Karcz);
            addEnemy("Cave Eel", EncounterSet.TheDrownedRuins, 20, 3, 3, 4, 2)
                .WithTraits("Creature.")
                .WithTextLine("Cave Eel cannot be engaged unless the active location is underwater.")
                .WithTextLine("Forced: At the beginning of the encounter phase, return Cave Eel to the staging area unless the active location is Underwater.")
                .WithEasyModeQuantity(2)
                .WithInfo(97, 3, Artist.Lukasz_Jaskolski);
            addLocation("Undersea Grotto", EncounterSet.TheDrownedRuins, 2, 3)
                .WithTraits("Underground.", "Grotto.")
                .WithTextLine("While Undersea Grotto is the active location, reduce the cost of the first ally played by the players each round by 1.")
                .WithTextLine("Response: After you travel to Undersea Grotto, you may flip it to its Underwater side.")
                .WithInfo(98, 3, Artist.Mariusz_Gandzel);
            addLocation("Cursed Caverns", EncounterSet.TheDrownedRuins, 3, 5)
                .WithTraits("Underground.", "Grotto.")
                .WithTextLine("Response: After you travel to Cursed Caverns, you may flip it to its Underwater side.")
                .WithTextLine("Response: After the players explore Cursed Caverns as the active location, each player may raise his threat by 2 to draw the bottom card of his deck.")
                .WithInfo(99, 3, Artist.Timo_Karhula);
            addLocation("Watter-logged Halls", EncounterSet.TheDrownedRuins, 2, 4)
                .WithTraits("Ruins.", "Underground.", "Grotto.")
                .WithTextLine("While Water-logged Halls is the active location, each Undead enemy in play gets -1 Threat.")
                .WithTextLine("Response: After you travel to Water-logged Halls, you may flip it to its Underwater side.")
                .WithInfo(100, 2, Artist.Mariusz_Gandzel);
            addLocation("Dark Abyss", EncounterSet.TheDrownedRuins, 5, 12)
                .WithTraits("Underground.", "Underwater.")
                .WithTextLine("While Dark Abyss is the active location, characters cannot attack.")
                .WithTextLine("Forced: If Dark Abyss is the active location at the end of the quest phase, deal 1 damage to each character in play. Then, you may flip Dark Abyss to its Grotto side.")
                .WithVictoryPoints(2)
                .WithInfo(101, 3, Artist.Niten);
            addLocation("Twisting Hollow", EncounterSet.TheDrownedRuins, 4, 14)
                .WithTraits("Underground.", "Underwater.")
                .WithTextLine("While Twisting Hollow is the active location, characters cannot ready from card effects.")
                .WithTextLine("Forced: If Twisting Hollow is the active location at the end of the quest phase, each player must discard 1 character. Then, you may flip Twisting Hollow to its Grotto side.")
                .WithVictoryPoints(2)
                .WithInfo(102, 3, Artist.Niten);
            addLocation("Sunken Temple", EncounterSet.TheDrownedRuins, 3, 10)
                .WithTraits("Ruins.", "Underground.", "Underwater.")
                .WithTextLine("While Sunken Temple is the active location, treat each attachment as if its printed text box is blank (except for Traits).")
                .WithTextLine("Forced: If Sunken Temple is the active location at the end of the quest phase, discard 1 resource from each objective-ally an each hero's resource pool. Then, you may flip Sunken Temple to its Grotto side.")
                .WithVictoryPoints(2)
                .WithInfo(103, 2, Artist.Federico_Musetti);
            addLocation("Drowned Cave", EncounterSet.TheDrownedRuins, 3, 4)
                .WithTraits("Underground.", "Underwater.")
                .WithTextLine("While Drowned Cave is the active location, Undead enemies cannot be engaged (return any engaged enemies to the staging area).")
                .WithTextLine("Forced: If Drowned Cave is the active location at the end of the quest phase, each player must discard the top 10 cards of his deck. Then, you may return Drowned Cave to the staging area.")
                .WithInfo(104, 2, Artist.Jordan_Saia);
            addTreachery("Powerful Undertow", EncounterSet.TheDrownedRuins)
                .WithTraits("Hazard.")
                .WithTextLine("When Revealed: You cannot flip the active location this round. If the active location is Underwater, resolve its Forced effect as if it is the end of the quest phase. If there is no Underwater active location, Powerful Undertow gains doomed 3, instead.")
                .WithEasyModeQuantity(1)
                .WithInfo(105, 3, Artist.Jake_Bullock);
            addTreachery("Into the Abyss", EncounterSet.TheDrownedRuins)
                .WithTextLine("When Revealed: Each player chooses a card type and discards each card in his hand that is not of the chosen type. If no cards are discarded by this effect, Into the Abyss gains surge.")
                .WithShadow("Shadow: If the active location is Underwater, search the encounter deck and discard pile for a Creature enemy, and add it to the staging area.")
                .WithInfo(106, 3, Artist.Jordan_Saia);
            addTreachery("Tangling and Grasping", EncounterSet.TheDrownedRuins)
                .WithTraits("Hazard.")
                .WithTextLine("When Revealed: Each player must remove a character from the quest. If the active location is Underwater, deal 2 damage to each character removed from the quest by this effect.")
                .WithShadow("Shadow: Discard an attachment you control.")
                .WithInfo(107, 4, Artist.Lukasz_Jaskolski);
            addTreachery("Ancient Depths", EncounterSet.TheDrownedRuins)
                .WithTextLine("When Revealed: Add the top location from the Grotto deck to the staging area and flip that location to its Underwater side. This effect cannot be canceled.")
                .WithShadow("Shadow: Attacking enemy gets +1 Attack (+2 Attack instead if the active location is Underwater).")
                .WithEasyModeQuantity(1)
                .WithInfo(108, 3, Artist.Beth_Sobel);
        }
    }
}
