using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace HallOfBeorn.Models.Arkham.Products
{
    public class CurseOfTheRougarou : ArkhamProduct
    {
        private ArkhamEncounterSet setTheBayou = ArkhamEncounterSet.TheBayou;
        private ArkhamEncounterSet setCurse = ArkhamEncounterSet.CurseOfTheRougarou;

        public CurseOfTheRougarou()
            : base("Curse of the Rougarou", "CotR", "AHC09", 2, new DateTime(2016, 10,31))
        {
        }

        protected override void init()
        {
            addCard(ArkhamCard.ScenarioReference("Curse of the Rougarou", "Scenario Reference", setTheBayou)
                .WithText("{Skull} -2 (-4 instead if you are at a {t:Bayou} location)\r\n{Cultist} -2. If The Rougarou is in you location, reveal another token.\r\n{Tablet}: Reveal another token. If you fail, until the end of the round, you cannot move.\r\n{Elder Thing} -4. If The Rougarou is at your location, it attacks you.")
                .WithBackText("{Skull} -3 (-6 instead if you are at a {t:Bayou} location)\r\n{Cultist} -3. If The Rougarou is in you location, reveal another token.\r\n{Tablet}: Reveal another token. If you fail, until the end of the round, you cannot move.\r\n{Elder Thing} -4. If The Rougarou is at your location or a connecting location, it attacks you.")
                .WithInfo(1, 1, Artist.None));
            addCard(ArkhamCard.Agenda("A Creature of the Bayou", "Darkened Skies", 1, Number.Of(5), setTheBayou)
                .WithFlavor("")
                .WithBackFlavor("")
                .WithBackText("Shuffle the encounter discard pile into the encounter deck.\r\nIf The Rougarou is in play, find a non-{t:Bayou} location with the fewest clues on it. Move The Rougarou (one location at a time) until it enters that location.\r\nIf The Rougarou is not in play, after advancing to agenda 2a, add 1 doom to that agenda.")
                .WithInfo(2, 1, Artist.Ignacio_Bazan_Lazcano));
            addCard(ArkhamCard.Agenda("The Rougarou Feeds", "The Tenth Night", 2, Number.Of(6), setTheBayou)
                .WithFlavor("")
                .WithBackFlavor("")
                .WithBackText("Shuffle all copies of On the Prowl from the encounter discard pile into the encounter deck.\r\nIf The Rougarou is in play, find a non-{t:Bayou} location with the fewest clues on it. Move The Rougarou (one location at a time) until it enters that location.\r\nIf The Rougarou is not in play, after advancing to agenda 3a, add 1 doom to that agenda.")
                .WithInfo(3, 1, Artist.Ignacio_Bazan_Lazcano));
            addCard(ArkhamCard.Agenda("The Curse Spreads", "Taken by the Curse", 3, Number.Of(8), setTheBayou)
                .WithFlavor("")
                .WithText("Forced - At the end of the investigation phase, if The Rougarou is not engaged with an investigator: Add 1 doom to this agenda.")
                .WithBackFlavor("")
                .WithBackText("<hr><b>The bearer of the Curse of the Rougarou weakness read the following (out loud):</b>\r\n<p class='arkham-flavorText'>You feel something dripping from your hand, and are surprised to find your knuckles bloody and torn. Nearby, the bard of a tree is smashed and dripping with blood. The anger of your failure slowly fades as you realize the blood is yours.</p>\r\n<b>(&rarr;R1)</b><hr><b>If no investigators gained the Curse of the Rougarou:\r\n(&rarr;R1)</b>")
                .WithInfo(4, 1, Artist.Ignacio_Bazan_Lazcano));
            addCard(ArkhamCard.Act("Finding Lady Esprit", "Understanding the Curse", 1, Number.Of(1).PerInvestigator(), setTheBayou)
                .WithFlavor("")
                .WithText("<b>Objective</b> - Only investigators at a {t:Bayou} location may spend the requisite number of clues, as a group, to advance.")
                .WithBackFlavor("")
                .WithBackText("Put the set-aside Lady Esprit into play at {t:Bayou} location. Put into play each set aside location. Put the set-aside The Rougarou enemy into play at any non-Bayou location. Shuffle the encounter discard pile and each encounter card from the <a href='/Arkham?EncounterSet=Curse+of+the+Rougarou' target='_blank'><i>Curse of the Rougarou</i></a> encounter set into the encounter deck.\r\n<hr>\r\n<b>The lead investigator reads the following (out loud):</b>\r\n<p class='arkham-flavorText'>As you leave Lady Esprit's shack, a terrible sickness courses through you, and you drop to your knees.</p>\r\nThe lead investigator puts the set-aside Curse of the Rougarou weakness into play in his or her threat area.")
                .WithInfo(5, 1, Artist.Darek_Zabrocki));
            addCard(ArkhamCard.Act("Hunting the Rougarou", "Taming the Rougarou", 2, Number.NA, setTheBayou)
                .WithFlavor("The Rougarou is somewhere within the vast bayou. You must track it down and destroy it, lest the beast's curse consume you as well.")
                .WithText("<b>Forced -</b> After The Rougarou leaves a location: Place 1 clue from the token bank on that location.\r\n<b>Objective -</b> \"We have to destry the beast!\"<br>If The Rougarou is defeated: <b>(&rarr;R2)</b>\r\n<b>Objective -</b> \"Maybe there's another way...\"<br>While an investigator is engaged with The Rougarou, he or she may choose to advance. (Limit once per phase.)")
                .WithBackFlavor("Conversing with the creature is a daunting task. Whenever it is cornered, it bellows and attacks, like a feral beast. If there is still some semblance of humanity left inside the create, it is buried deep beneath the rage and bloodlust of the curse.")
                .WithBackText("If each of the following requirements are met, proceed to <b>(&rarr;R3).</b> Otherwise, flip this act back to its \"a\" side.<br><ul><li>\"We must learn more about the curse.\" The investigators must have 4<img src='/Images/Arkham/PerInvestigatorBlack.png' height='10' width='10'/> clues, as a group.</li><li>\"We must keep it contained.\" The Rougarou must have a {t:Trap} card attached to it.</li><li>\"We must protected ourseleves.\" The Rougarou must have at least 1<img src='/Images/Arkham/PerInvestigatorBlack.png' height='10' width='10'/> damage on it.</li><li>\"We must calm it down.\" The investigators must have either \"found a binding stone\" or \"found a strange doll.\"</li></ul>")
                .WithInfo(6, 1, Artist.Darek_Zabrocki));
            addCard(ArkhamCard.Location("Cursed Shores", ConnectionSymbol.Cursed_Shores, Number.Of(1), Number.Of(0), setTheBayou)
                .WithTraits("New Orleans.", "Bayou.")
                .WithFlavor("Black storm clouds loom above you, watching patiently as you trudge through the bayou. Their shapes twist and churn in the night sky, blotting out the stars.")
                .WithBackText("{Action}: Take 1 damage. You get +2 to your skill value for the next skill test you make this turn.\r\n{Forced} - When you leave Cursed Shores: Choose and discard a skill card from your hand.")
                .WithInfo(7, 1, Artist.Unknown)); //Antonio Jse Manzamedo
            addCard(ArkhamCard.Location("New Orleans", ConnectionSymbol.New_Orleans, Number.Of(1), Number.Of(0), setTheBayou)
                .WithSubtitle("Garden District")
                .WithTraits("New Orleans.")
                .WithFlavor("It is late, but the city's nightlife is in full swing. Jazz clubs and speakeasies rule the night. But your interest lies elsewhere...")
                .WithBackText("{Action}: Test {Agility} (7) to try to break into a nearby greenhouse and take a look around. If you succeed, remember that the investigators have \"found a strange doll.\"")
                .WithBackFlavor("A trail of blood and mangled flesh led you here.<br>You suspect this is no ordinary garden.")
                .WithConnections(ConnectionSymbol.Cursed_Shores, ConnectionSymbol.New_Orleans)
                .WithInfo(8, 1, Artist.Unknown)); //James Ives
            addCard(ArkhamCard.Location("New Orleans", ConnectionSymbol.New_Orleans, Number.Of(3), Number.Of(1).PerInvestigator(), setTheBayou)
                .WithSubtitle("Broadmoor")
                .WithTraits("New Orleans.")
                .WithFlavor("It is late, but the city's nightlife is in full swing. Jazz clubs and speakeasies rule the night. But your interest lies elsewhere...")
                .WithBackText("{Action}: {Resign} \"We can't catch the beast!\" You make your way to safety, letting the beast roam free.")
                .WithBackFlavor("People are just now beginning to settle what began as an untamed marsh. Truth is, some evils run too deep to exorcise that easily.")
                .WithConnections(ConnectionSymbol.Cursed_Shores, ConnectionSymbol.New_Orleans)
                .WithVictoryPoints(1)
                .WithInfo(9, 1, Artist.Marius_Bota));
            addCard(ArkhamCard.Location("Brackish Waters", ConnectionSymbol.Brackish_Waters, Number.Of(1), Number.Of(0), setTheBayou)
                .WithTraits("Riverside.", "Bayou.")
                .WithFlavor("The reeking odor of dead fish overwhelms your senses. You can't help but hold your breath as you wade through the repugnant shallows.")
                .WithBackText("While you are at Brackish Waters, you cannot play assets.\r\n{Action} Discard 2 assets from your hand or from play: Test {Agility} (3) to wade through the dark waters and retrieve an abandoned fishing net. If you succeed, take control of the set-aside Fishing Net asset.")
                .WithConnections(ConnectionSymbol.Riverside, ConnectionSymbol.Cursed_Shores, ConnectionSymbol.Forgotten_Marsh, ConnectionSymbol.Foul_Swamp)
                .WithInfo(10, 1, Artist.Unknown)); //Michael Berube
            addCard(ArkhamCard.Location("Riverside", ConnectionSymbol.Riverside, Number.Of(3), Number.Of(1).PerInvestigator(), setTheBayou)
                .WithSubtitle("Audubon Park")
                .WithTraits("Riverside.")
                .WithFlavor("Even at this late hour, bells and shouts sound across the piers as dockworkers go about their business.")
                .WithBackText("{Forced} - When you evade an enemy at Audubon Park: Discard a random card from your hand.")
                .WithBackFlavor("Leaves flutter in the cold wind, breaking the stillness of the park. With an area strangely abandoned, you feel as though you don't belong here.")
                .WithConnections(ConnectionSymbol.Brackish_Waters, ConnectionSymbol.Riverside)
                .WithVictoryPoints(1)
                .WithBackArtist(Artist.Preston_Stone)
                .WithInfo(11, 1, Artist.Unknown)); //James Ives
            addCard(ArkhamCard.Location("Riverside", ConnectionSymbol.Riverside, Number.Of(4), Number.Of(0), setTheBayou)
                .WithSubtitle("Fauborg Marigny")
                .WithTraits("Riverside.")
                .WithFlavor("Even at this late hour, bells and shouts sound across the piers as dockworkers go about their business.")
                .WithBackText("While you are at Fauborg Marigny, reduce the cost of each asset you play by 1.\r\n{Action}: {Resign} \"We can't catch the beast!\" You make your way to safety, letting the beast roam free.")
                .WithConnections(ConnectionSymbol.Brackish_Waters, ConnectionSymbol.Riverside)
                .WithBackArtist(Artist.JB_Casacop)
                .WithInfo(12, 1, Artist.Unknown)); //James Ives
            addCard(ArkhamCard.Location("Forgotten Marsh", ConnectionSymbol.Forgotten_Marsh, Number.Of(2), Number.Of(0), setTheBayou)
                .WithTraits("Wilderness.", "Bayou.")
                .WithFlavor("You warily eye the web of vines and blackened bog waters before you, and your heart sinks. You long for the comforts of home, and yet you press onward.")
                .WithBackText("{Forced} - When you leave Forgotten Marsh: Lose 2 resources.")
                .WithConnections(ConnectionSymbol.Wilderness, ConnectionSymbol.Cursed_Shores, ConnectionSymbol.Brackish_Waters, ConnectionSymbol.Foul_Swamp)
                .WithBackArtist(Artist.Jason_Caffoe)
                .WithInfo(13, 1, Artist.Jason_Caffoe));
            addCard(ArkhamCard.Location("Wilderness", ConnectionSymbol.Wilderness, Number.Of(3), Number.Of(0), setTheBayou)
                .WithSubtitle("Trapper's Cabin")
                .WithTraits("Wilderness.")
                .WithFlavor("After hours of navigating through impenetrable fog and overgrowth, your clothes stick to your skin and you swat at what seems like the thousandth mosquito.")
                .WithBackText("While you are at Trapper's Cabin, you cannot gain resources.\r\n{Action} Spend 5 resources: Test {Intellect} (3) to convince an old trapper to sell you his last bear trap. If you succeed, take control of the set-aside Bear Trap asset.")
                .WithConnections(ConnectionSymbol.Forgotten_Marsh, ConnectionSymbol.Wilderness)
                .WithBackArtist(Artist.Unknown) //Grzegorz Bobrowski
                .WithInfo(14, 1, Artist.Preston_Stone));
            addCard(ArkhamCard.Location("Wilderness", ConnectionSymbol.Wilderness, Number.Of(3), Number.Of(1).PerInvestigator(), setTheBayou)
                .WithSubtitle("Twisted Underbrush")
                .WithTraits("Wilderness.")
                .WithFlavor("After hours of navigating through impenetrable fog and overgrowth, your clothes stick to your skin and you swat at what seems like the thousandth mosquito.")
                .WithBackText("{Action}: Gain 2 resources and take 1 horror.")
                .WithConnections(ConnectionSymbol.Forgotten_Marsh, ConnectionSymbol.Wilderness)
                .WithVictoryPoints(1)
                .WithBackArtist(Artist.Unknown) //Andreas Zanratos
                .WithInfo(15, 1, Artist.Preston_Stone));
            addCard(ArkhamCard.Location("Foul Swamp", ConnectionSymbol.Foul_Swamp, Number.Of(2), Number.Of(0), setTheBayou)
                .WithTraits("Unhallowed.", "Bayou.")
                .WithFlavor("The stench of death and decay washes over you as you slog through this putrid swamp. It's hard to imagine what could live in these waters, sullied as they are by rot and putrefaction.")
                .WithBackText("While you are at Foul Swamp, you cannot heal horror or cancel horror.\r\n{Action} Take up to 3 horror: Test {Willpower} (7) to search the boneyard. You get +1 {Willpower} for this test for each horror taken as part of this abilities cost. If you succeed, remember that the investigators have \"found an ancient binding stone.\"")
                .WithConnections(ConnectionSymbol.Unhallowed_Land, ConnectionSymbol.Cursed_Shores, ConnectionSymbol.Brackish_Waters, ConnectionSymbol.Forgotten_Marsh)
                .WithBackArtist(Artist.Unknown) //Andreas Adamek
                .WithInfo(16, 1, Artist.Unknown)); //Andreas Adamek
            addCard(ArkhamCard.Location("Unhallowed Land", ConnectionSymbol.Unhallowed_Land, Number.Of(2), Number.Of(1).PerInvestigator(), setTheBayou)
                .WithSubtitle("Ritual Grounds")
                .WithTraits("Unhallowed.")
                .WithFlavor("Iä! Iä Shub-Niggurath!<br>Que tous les démons volent de cette endroit,<br>The world is your prey, your bloodlust unending...")
                .WithBackText("{Forced} - After you end your turn at Ritual Grounds: Draw 1 card and take 1 horror.")
                .WithBackFlavor("A macabre display greets you as you venture deeper into the bayou, where black magick and occult rituals find their home.")
                .WithConnections(ConnectionSymbol.Foul_Swamp, ConnectionSymbol.Unhallowed_Land)
                .WithVictoryPoints(1)
                .WithBackArtist(Artist.Alexandr_Elichev)
                .WithInfo(17, 1, Artist.Anthony_Devine));
            addCard(ArkhamCard.Location("Unhallowed Land", ConnectionSymbol.Unhallowed_Land, Number.Of(4), Number.Of(0), setTheBayou)
                .WithSubtitle("Overgrown Cairns")
                .WithTraits("Unhallowed.")
                .WithFlavor("Iä! Iä Shub-Niggurath!<br>Que tous les démons volent de cette endroit,<br>The world is your prey, your bloodlust unending...")
                .WithBackText("{Action} - Spend 2 resources: Heal 2 horror. (Limit once per game.)")
                .WithBackFlavor("These cairnstones were placed here centuries ago, their purpose unknown.")
                .WithConnections(ConnectionSymbol.Foul_Swamp, ConnectionSymbol.Unhallowed_Land)
                .WithVictoryPoints(1)
                .WithBackArtist(Artist.Alexandr_Elichev)
                .WithInfo(18, 1, Artist.Anthony_Devine));
            addCard(ArkhamCard.Asset("Lady Esprit", ClassSymbol.None, 4, AssetSlot.Ally)
                .WithUnique()
                .WithEncounterSet(setTheBayou)
                .WithTraits("Ally.", "Sorcerer.")
                .WithIcons(SkillIcon.Willpower, SkillIcon.Intellect, SkillIcon.Wild)
                .WithText("{Action} Exhaust Lady Esprit and deal her 1 horror: Heal 2 damage or gain 2 resources. Any investigator at Lady Esprit's location may activate this ability.")
                .WithHealth(2).WithSanity(4)
                .WithInfo(19, 1, Artist.Arden_Beckwith));
            addCard(ArkhamCard.Asset("Bear Trap", ClassSymbol.None, Number.NA, AssetSlot.None)
                .WithEncounterSet(setTheBayou)
                .WithTraits("Trap.")
                .WithText("{Free Action}: Attach Bear Trap to your location.\r\n{Forced} - After The Rougarou enters attached location: Attach Bear Trap to The Rougarou.\r\nAttached enemy gets -1 fight and -1 evade.")
                .WithInfo(20, 1, Artist.Unknown));
            addCard(ArkhamCard.Asset("Fishing Net", ClassSymbol.None, Number.NA, AssetSlot.None)
                .WithEncounterSet(setTheBayou)
                .WithTraits("Trap.")
                .WithText("{Free Action} If The Rougarou is exhausted and at your location: Attach Fishing Net to The Rougarou.\r\nAttached enemy loses retaliate.")
                .WithInfo(21, 1, Artist.Unknown));
            addCard(ArkhamCard.Enemy("Bog Gator", Number.Of(2), Number.Of(2), Number.Of(2), Number.Of(1), Number.Of(1), setTheBayou)
                .WithTraits("Creature.")
                .WithKeywords("Prey - Lowest Agility.")
                .WithText("Prey - Lowest {Agility}.\r\nWhile Bog Gator is at a {t:Bayou} location, it gets +2 fight and +2 evade.")
                .WithFlavor("They were apex predators even before the curse took hold.")
                .WithInfo(22, 2, Artist.Unknown));
            addCard(ArkhamCard.Enemy("Swamp Leech", Number.Of(4), Number.Of(1), Number.NA, Number.Of(1), Number.Of(0), setTheBayou)
                .WithTraits("Creature.")
                .WithText("Spawn - Any {t:Bayou} location.\r\nSwamp Leech cannot be evaded.\r\n{Forced} - When Swamp Leech enters a non-{t:Bayou} location: Discard it.")
                .WithInfo(23, 3, Artist.Unknown)); //Daniel Dulitzky
            addCard(ArkhamCard.Treachery("Cursed Swamp", ArkhamCardSubtype.None, setTheBayou)
                .WithTraits("Hazard.")
                .WithText("{Revelation} - Test {Willpower} (3). For each point you fail by, take 1 damage. If you are at a Bayou location, you cannot commit cards to this skill test.")
                .WithInfo(24, 3, Artist.Nikolay_Stoyanov));
            addCard(ArkhamCard.Treachery("Spectral Mist", ArkhamCardSubtype.None, setTheBayou)
                .WithTraits("Hazard.")
                .WithText("{Revelation} - Attach to a {t:Bayou} location. Limit 1 per location.\r\nEach skill test performed at attached location gets +1 difficulty.\r\n{Action}: Test {Intellect} (2) to disrupt the source of the mist. If you suceed, discard Spectral Mist.")
                .WithInfo(25, 3, Artist.Darek_Zabrocki));
            addCard(ArkhamCard.Treachery("Dragged Under", ArkhamCardSubtype.None, setTheBayou)
                .WithTraits("Hazard.")
                .WithText("Revelation - Test {Agility{ (3). If you fail, add Dragged Under to your threat area.\r\n{Forced} - When you leave your current location: take 2 damage and discard Dragged Under.\r\n{Forced} - At the end of your turn: Test {Agility} (3). If you succeed, discard Dragged Under.")
                .WithInfo(26, 4, Artist.Sara_Biddle));
            addCard(ArkhamCard.Treachery("Ripples on the Surface", ArkhamCardSubtype.None, setTheBayou)
                .WithTraits("Terror.")
                .WithText("{Revelation} - Test {Willpower} (3). For each point you fail by, take 1 horror. If you are at a {t:Bayou} location, you cannot commit cards to this skill test.")
                .WithFlavor("There are dangers deep within the mire you can only begin to imagine.")
                .WithInfo(27, 3, Artist.Unknown)); //Alex Aguilar
            addCard(ArkhamCard.Enemy("The Rougarou", Number.Of(4), Number.Of(5).PerInvestigator(), Number.Of(3), Number.Of(2), Number.Of(2), setCurse)
                .WithSubtitle("Cursed Soul")
                .WithUnique()
                .WithTraits("Monster.", "Creature.", "Elite.")
                .WithKeywords("Aloof.", "Retaliate.")
                .WithText("Aloof. Retaliate.\r\nAs an additional cost for an investigator to engage The Rougarou, the investigators must spend 1 clue, as a group (2 clues instead if there are 3 or 4 investigators).\r\n{Forced} - After The Rougarou takes 1{Per Investigator} damage during a single phase: Find the location that is farthest from all investigator. Move The Rougarou (one location at a time) until it enters that location.")
                .WithInfo(28, 1, Artist.Nicholas_Gregory));
            addCard(ArkhamCard.Treachery("Curse of the Rougarou", ArkhamCardSubtype.Weakness, setCurse)
                .WithTraits("Curse.")
                .WithText("{Revelation} - Put Curse of the Rougarou into play in your threat area.\r\n{Forced} - At the end of your turn, if you have not dealt any damage this turn: Take 1 horror.")
                .WithFlavor("Your stomach convulses and you feel the first ghastly pangs of hunger.")
                .WithInfo(29, 1, Artist.Unknown));
            addCard(ArkhamCard.Asset("Monstrous Transformation", ClassSymbol.None, 0)
                .WithEncounterSet(setCurse)
                .WithTraits("Talent.")
                .WithKeywords("Fast.")
                .WithText("{k:Fast}\r\nSet the base value of your {Willpower} and {Intellect} to 2.\r\nSet the base value of your {Combat} and {Agility} to 5.\r\n{Action} Exhaust Monstrous Transformation: {Fight}. You deal +1 damage for this attack.")
                .WithInfo(30, 1, Artist.Jon_Bosco));
            addCard(ArkhamCard.Enemy("Slime-Covered Dhole", Number.Of(2), Number.Of(3), Number.Of(3), Number.Of(1), Number.Of(1), setCurse)
                .WithTraits("Monster.", "Dhole.")
                .WithKeywords("Hunter.")
                .WithText("Spawn - Any non-{t:Bayou} location.\r\nPrey - Lowest remaining health.\r\n{k:Hunter}\r\n{Forced} - When Slime-Covered Dhole enters a location: Each investigator at that location takes 1 horror.")
                .WithInfo(31, 2, Artist.Allison_Theus));
            addCard(ArkhamCard.Enemy("Marsh Gug", Number.Of(3), Number.Of(4), Number.Of(3), Number.Of(2), Number.Of(1), setCurse)
                .WithTraits("Monster.", "Gug.")
                .WithKeywords("Hunter.")
                .WithText("<b>Spawn</b> - Any {t:Bayou} location.\r\n{k:Hunter}")
                .WithFlavor("A great thrashing accompanied by an echoing roar turns your blood to ice.")
                .WithInfo(32, 2, Artist.Unknown)); //Kim Chi Zutya
            addCard(ArkhamCard.Enemy("Dark Young Host", Number.Of(4), Number.Of(5), Number.Of(2), Number.Of(2), Number.Of(2), setCurse)
                .WithTraits("Monster.", "Dark Young.")
                .WithText("<b>Spawn</b> - Any {t:Bayou} location.\r\n{Forced} - When 1 or more clues are placed on Dark Young Host's location: Place those clues on Dark Young Host.\r\n{Forced} - When Dark Young Host is defeated: Move all clues on Dark Young Host to its location.")
                .WithVictoryPoints(1)
                .WithInfo(33, 1, Artist.Jon_Bosco));
            addCard(ArkhamCard.Treachery("On the Prowl", ArkhamCardSubtype.None, setCurse)
                .WithKeywords("Surge.")
                .WithText("{k:Surge}\r\n{Revelation} - Find a non-{t:Bayou} location with the fewest clues on it. Move The Rougarou (one location at a time) until it enters that location.")
                .WithFlavor("A dreadful howl pierces your eardrums. The Rougarou is on the move...")
                .WithInfo(34, 5, Artist.Helge_C_Balzer));
            addCard(ArkhamCard.Treachery("Beast of the Bayou", ArkhamCardSubtype.None, setCurse)
                .WithText("{Revelation} - The Rougarou makes an immediate attack against each investigator at the Rougarou's location and each connecting location. If no attacks were made by this effect, place 1 doom on the current agenda.")
                .WithFlavor("Driven by hunger, it cares for naught but its next meal.")
                .WithInfo(35, 2, Artist.Unknown)); //Kim Artem
            addCard(ArkhamCard.Treachery("Insatiable Bloodlust", ArkhamCardSubtype.None, setCurse)
                .WithText("{Revelation} - Attach to The Rougarou.\r\nThe Rougarou gets +1 fight, +1 damage, +1 horror, and cannot be evaded.\r\n{Forced} - After The Rougarou takes damage: Discard Insatiable Bloodlust.")
                .WithInfo(36, 3, Artist.Helge_C_Balzer));
        }
    }
}