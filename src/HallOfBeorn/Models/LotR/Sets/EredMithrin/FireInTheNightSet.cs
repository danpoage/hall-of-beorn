/* Generated CardSet class: Fire in the Night */

using System;

namespace HallOfBeorn.Models.LotR.Sets.EredMithrin
{
    public class FireInTheNightSet : CardSet
    {
        protected override void Initialize()
        {
            Name = "Fire in the Night";
            Abbreviation = "FitN";
            Number = 52;
            SetType = Models.SetType.Adventure_Pack;
            Cycle = "Ered Mithrin";

            addHero("Thranduil", 9, Sphere.Leadership, 1, 1, 3, 4)
                .WithTraits("Silvan.", "Noble.")
                .WithTextLine("Combat Action: Play a Silvan ally from your hand. You do not need a resource match for this ally. (Limit once per round.)")
                .WithFlavorLine("\"It is a crime to wander in my realm without leave.\"")
                .WithFlavorLine("-The Hobbit")
                .WithCommunityVersion("Hrodebert/Thranduil")
                .WithAges(Age.First_Age, Age.Second_Age, Age.Third_Age)
                .WithInfo(56, 1, Artist.Magali_Villeneuve);
            addAttachment("The Elvenking", 1, Sphere.Leadership, true)
                .WithTraits("Title.")
                .WithTextLine("Attach to a Silvan hero.")
                .WithTextLine("Action: Exhaust The Elvenking and return a Silvan ally you control to your hand to ready attached hero.")
                .WithFlavorLine("In a great hall with pillars hewn out of the living stong sat the Elvenking on a chair of carven wood.")
                .WithFlavorLine("-The Hobbit")
                .WithInfo(57, 3, Artist.Tropa_Entertainment);
            addAttachment("Orcrist", 1, Sphere.Leadership, true)
                .WithTraits("Artifact.", "Item.", "Weapon.")
                .WithKeywords("Guarded (enemy or location).", "Restricted.")
                .WithTextLine("Guarded (enemy or location).")
                .WithTextLine("Attach to a hero. Restricted.")
                .WithTextLine("Attached hero gets +2 Attack.")
                .WithTextLine("Response: After attached hero drestroys an enemy, add 1 resource to attached hero's pool.")
                .WithAges(Age.First_Age, Age.Second_Age, Age.Third_Age)
                .WithInfo(58, 3, Artist.Aleksander_Karcz);
            addAlly("Forest Road Traveler", 2, Sphere.Lore, false, 1, 1, 1, 2)
                .WithTraits("Woodman.", "Scout.")
                .WithTextLine("~Forest ~Road Traveler gets +1 Willpower, +1 Attack, and +1 Defense for each attachment on the active location.")
                .WithFlavorLine("Only on the Road would travellers be found...")
                .WithFlavorLine("-The Fellowship of the Ring")
                .WithInfo(59, 3, Artist.Derek_D_Edgell);
            addAttachment("Leather Boots", 1, Sphere.Lore, false)
                .WithTraits("Item.")
                .WithTextLine("Attach to a Lore or Ranger character. Limit 1 per character.")
                .WithTextLine("Response: After a Location is revealed from the encounter deck, exhaust Leather Boots to ready attached character.")
                .WithFlavorLine("His legs were stretched out before him, showing high boots of supple leather the fitted him well...")
                .WithFlavorLine("-The Fellowship of the Ring")
                .WithInfo(60, 3, Artist.Yoann_Boissonnet);
            addAlly("Giant Bear", 5, Sphere.Tactics, false, 0, 4, 3, 4)
                .WithTraits("Creature.", "Beorning.")
                .WithTextLine("Cannot have attachments.")
                .WithTextLine("Action: Ready ~Giant Bear. At the end of the phase in which you trigger this effect, shuffle ~Giant Bear into your deck. (Limit once per phase.)")
                .WithFlavorLine("\"As a bear he ranged far and wide\"")
                .WithFlavorLine("-Gandalf, The Hobbit")
                .WithInfo(61, 3, Artist.Brendan_C_Murphy);
            addAttachment("Outmatched", 1, Sphere.Tactics, false)
                .WithTraits("Condition.", "Trap.")
                .WithTextLine("Play into your play area unattached.")
                .WithTextLine("If unattached, attach to the next eligible enemy that engages you.")
                .WithTextLine("Response: After attached enemy resolves its attack, ready the defending character.")
                .WithInfo(62, 3, Artist.Preston_Stone);
            addAlly("Galion", 0, Sphere.Spirit, true, 0, 0, 0, 1)
                .WithTraits("Silvan.")
                .WithTextLine("Cannot attack or defend.")
                .WithTextLine("Response: After Galion enters play, he gets +1 Willpower until the end of the round.")
                .WithFlavorLine("\"Here am I waiting and waiting down hero, while you fellows drink and make merry and forget your tasks. Small wonder if I fall asleep from weariness!\"")
                .WithFlavorLine("-The Hobbit")
                .WithInfo(63, 3, Artist.Torbjorn_Kallstrom);
            addEvent("Quicker Than Sight", 0, Sphere.Spirit)
                .WithTextLine("Response: Return a Silvan ally you control to your hand to cancel a shadow effect just triggered during combat.")
                .WithFlavorLine("\"You would die before your stroke fell.\"")
                .WithFlavorLine("-Legolas, The Two Towers")
                .WithInfo(64, 3, Artist.Monztre);
            addAlly("Thalion", 4, Sphere.Neutral, true, 2, 2, 2, 3)
                .WithTraits("Dúnedain.", "Ranger.")
                .WithTextLine("While there is at least 1 side quest in the victory display, ready Thalion at the beginning of the combat phase.")
                .WithTextLine("While there are at least 3 side quests in the victory display, Thalion loses the ally card type, gains the hero card type and the resource icons of each sphere on a side quest in the victory display.")
                .WithInfo(65, 3, Artist.Aleksander_Karcz);
            addEncounterSideQuest("Draw Her Fire", EncounterSet.FireInTheNight, 5)
                .WithTextLine("Shadow cards dealt to Dagnir are immune to player card effects and their effects cannot be canceled.")
                .WithTextLine("Forced: After Draw Her Fire becomes the current quest, Dagnir makes an immediate attack against the first player.")
                .WithFlavorLine("Dagnir's assault is relentless and the people of Hrogar’s Hill need time to regroup. Someone mst draw the Dragon’s attention away from the town.")
                .WithVictoryPoints(10)
                .WithInfo(66, 1, Artist.Antonio_Jose_Manzanedo);
            addEncounterSideQuest("Fortify the Defense", EncounterSet.FireInTheNight, 10)
                .WithTextLine("Characters do not count their Defense when defending against Dagnir.")
                .WithTextLine("Response: When Fortify the Defense is defeated, each player chooses: either draw 3 cards, or each hero he controls gains 1 resource.")
                .WithFlavorLine("Hrogar's Hill was built to defend against Goblins and forest creatures; no one ever imagined a Dragon attack. You hurry to organize a proper defense.")
                .WithVictoryPoints(10)
                .WithInfo(67, 1, Artist.Tomasz_Jedruszek);
            addEncounterSideQuest("Rally the Woodmen", EncounterSet.FireInTheNight, 10)
                .WithTextLine("Allies cannot be declared as attackers against Dagnir.")
                .WithTextLine("Response: When Rally the Woodmen is defeated, each player searches the top 5 cards of his deck for an ally, puts it into play and shuffles his deck.")
                .WithFlavorLine("The men of Hrogar's Hill are strong and brave, but Dagnir’s mere presence weakens the resolve of even the mightiest warrior. The Woodmen need strong leadership to hold together.")
                .WithVictoryPoints(10)
                .WithInfo(68, 1, Artist.Nikolas_Hagialas);
            addEncounterSideQuest("Douse the Flames", EncounterSet.FireInTheNight, 10)
                .WithTextLine("Forced: At the end of the quest phase, deal 5 damage to Hrogar's Hill.")
                .WithTextLine("Response: When Douse the Flames is defeated, remove 10 damage from Hrogar's Hill.")
                .WithFlavorLine("Dagnir's fire spread from the outer wall to the nearby rooftops. If you don’t put them out quickly, Hrogar's Hill will burn.")
                .WithVictoryPoints(10)
                .WithInfo(69, 1, Artist.Alvaro_Calvo_Escudero);
            addEncounterSideQuest("Hold the Door", EncounterSet.FireInTheNight, 10)
                .WithTextLine("Each player's threat cannot be reduced.")
                .WithTextLine("Response: When Hold the Door is defeated, reduce each player's threat by 5.")
                .WithFlavorLine("The enraged Dagnir batters the gate to Hrogar's Hill and mighty doors of oak crack and split. You call for sturdy beams to brace the gate while you lean desperately against the doors.")
                .WithVictoryPoints(10)
                .WithInfo(70, 1, Artist.David_Keen);
            addEncounterSideQuest("Defend the Town", EncounterSet.FireInTheNight, 5)
                .WithTextLine("While Defend the Town is the current quest, reveal an additional encounter card during the quest phase.")
                .WithTextLine("Forced: At the end of the encounter phase, deal 1 damage to Hrogar's Hill for each enemy in the staging area.")
                .WithFlavorLine("The Goblins of Mount Gundabad follow Dagnir in her assault on Hrogar’s Hill. Their attacks spread the defense thin across the outer wall.")
                .WithVictoryPoints(10)
                .WithInfo(71, 1, Artist.Tomasz_Jedruszek);
            addEncounterSideQuest("Rout the Goblins", EncounterSet.FireInTheNight, 5)
                .WithTextLine("Rout the Goblins gets +5 quest points for each Goblin enemy in play.")
                .WithTextLine("When Revealed: Each player searches the encounter deck and discard pile for a different Goblin enemy and puts it into play engaged with him. Shuffle the encounter deck.")
                .WithFlavorLine("Goblins stream across the draw-bridge toward Hrogar’s Gate. They cannot be allowed into the town!")
                .WithVictoryPoints(10)
                .WithInfo(72, 1, Artist.Tomasz_Jedruszek);
            addEncounterSideQuest("Face the Dragon", EncounterSet.FireInTheNight, 10)
                .WithTextLine("Forced: After Dagnir attacks and destroys a character, heal 5 damage from her.")
                .WithTextLine("Forced: After Face the Dragon is defeated, deal 5 damage to Dagnir.")
                .WithFlavorLine("Arrows and spears bounce off Dagnir's armored hide like raindrops. Nothing seems to slow her assault. Perhaps if you cold strike at her underbelly you wold find a way to injure the Dragon.")
                .WithVictoryPoints(10)
                .WithInfo(73, 1, Artist.Tomasz_Jedruszek);
            addEnemy("Dagnir", EncounterSet.FireInTheNight, 50, Card.VALUE_X, 7, 5, 20)
                .WithUnique()
                .WithTraits("Dragon.")
                .WithTextLine("Immune to player card effects. X is 1 more than the number of side quests in the victory display.")
                .WithTextLine("Cannot leave the staging are or take more than X damage from non-quest effects each round.")
                .WithTextLine("While at least 3 side quests are in the victory display, Dagnir is considered to be engaged with each player.")
                .WithVictoryPoints(5)
                .WithInfo(74, 1, Artist.Antonio_Jose_Manzanedo);
            addEnemy("The Dragon's Thrall", EncounterSet.FireInTheNight, 30, 3, 3, 3, 4)
                .WithTraits("Goblin.", "Orc.")
                .WithTextLine("Forced: After The Dragon’s Thrall engages you, either deal 3 damage to Hrogar’s Hill, or it makes an immediate attack against you.")
                .WithShadow("Shadow: If this attack destroys a character, deal 3 damage to Hrogar's Hill.")
                .WithEasyModeQuantity(1)
                .WithInfo(75, 3, Artist.Martin_de_Diego_Sadaba);
            addEnemy("Orc of the Flame", EncounterSet.FireInTheNight, 25, 2, 2, 2, 3)
                .WithTraits("Goblin.", "Orc.")
                .WithTextLine("When Revealed: The first player must either deal 2 damage to a hero he controls, or deal 3 damage to Hrogar's Hill.")
                .WithShadow("Shadow: Attacking enemy gets +1 Attack (+2 Attack instead if Hrogar's Hill has at least 25 damage on it).")
                .WithInfo(76, 4, Artist.Martin_de_Diego_Sadaba);
            addLocation("Town Gate", EncounterSet.FireInTheNight, 3, 4)
                .WithTraits("Town.")
                .WithTextLine("While Town Gate is in the staging area, it gains: \"Forced: At the end of the quest phase, place 1 resource here. Then, if there are 3 resources here, discard Town Gate and deal 4 damage to Hrogar's Hill.\"")
                .WithTextLine("Travel: Dagnir makes an immediate attack against the first player.")
                .WithEasyModeQuantity(1)
                .WithInfo(77, 2, Artist.Jose_Vega);
            addLocation("Wooden Palisade", EncounterSet.FireInTheNight, 2, 3)
                .WithTraits("Town.")
                .WithTextLine("While Wooden Palisade is the active location, Dagnir gets -2 Attack.")
                .WithTextLine("Travel: The first player readies a hero he controls.")
                .WithFlavorLine("\"Within there rise the roofs of houses; and in the midst, set upon a green terrace, there stands aloft a great hall of Men.\"")
                .WithFlavorLine("-Legolas, The Two Towers")
                .WithInfo(78, 3, Artist.Davis_Engel);
            addLocation("Burning Watchtower", EncounterSet.FireInTheNight, Card.VALUE_X, 5)
                .WithTraits("Town.")
                .WithTextLine("X is 1 more than the number of side quests in the victory display.")
                .WithTextLine("Travel: Each player assigns X damage among characters he controls.")
                .WithEasyModeQuantity(1)
                .WithInfo(79, 3, Artist.Alvaro_Calvo_Escudero);
            addTreachery("Powerful in Wrath", EncounterSet.FireInTheNight)
                .WithKeywords("Doomed 1.")
                .WithTextLine("Doomed 1.")
                .WithTextLine("When Revealed: Discard the active location and deal X damage to Hrogar’s Hill, where X is that location’s Threat. If no damage is dealt this way, Powerful in Wraith gains surge.")
                .WithShadow("Shadow: Excess damage from this attack must be dealt to Hrogar's Hill.")
                .WithInfo(80, 2, Artist.Antonio_Jose_Manzanedo);
            addTreachery("The Dragon's Fury", EncounterSet.FireInTheNight)
                .WithTextLine("When Revealed: Dagnir makes an immediate attack against the first player. Undefended damage from this attack must be dealt to Hrogar's Hill.")
                .WithShadow("Shadow: Attacking enemy makes an additional attack against you after this one.")
                .WithEasyModeQuantity(1)
                .WithInfo(81, 3, Artist.Preston_Stone);
            addTreachery("Bright Flames", EncounterSet.FireInTheNight)
                .WithTextLine("When Revealed: Each player assigns X damage among characters he controls, where X is 1 more than the number of side quests in the victory display.")
                .WithShadow("Shadow: Attacking enemy gets +1 Attack for each side quest in the victory display.")
                .WithEasyModeQuantity(1)
                .WithInfo(82, 2, Artist.Alyn_Spiller);
            addQuest("Hrogar's Hill", EncounterSet.FireInTheNight, 1, 'A', 50)
                .WithTextLine("Setup: Search the encounter deck for all 8 encounter side quests, shuffle them together, and place them facedown next to the quest deck. This is the side quest deck. The first player adds Dagnir to the staging area and shuffles the encounter deck. Each other player reveals an encounter card.")
                .WithFlavorLine("The Woodmen of Hrogar’s Hill have agreed to help you in your quest, but shortly after they welcome you to their town it is attacked by the very Dragon you seek: Dagnir has come to take vengeance on Wilderland!")
                .WithOppositeTextLine("Forced: At the end of the planning phase, reveal the top card of the side quest deck and add it to the staging area. Dagnir makes an attack against Hrogar’s Hill. Do not deal a shadow card for this attack. The first player may declare a defender for this attack. Excess damage must be dealt to Hrogar's Hill.")
                .WithOppositeTextLine("This stage cannot be defeated while Dagnir has hit points remaining. If Dagnir has no hit points remaining, the players win the game. If this stage has damage equal to its quest points, the players lose the game.")
                .WithIncludedEncounterSets(EncounterSet.GreyMountainGoblins, EncounterSet.DarkWoods, EncounterSet.GatheringGloom)
                .WithInfo(83, 1, Artist.Andreas_Adamek);
        }
    }
}
