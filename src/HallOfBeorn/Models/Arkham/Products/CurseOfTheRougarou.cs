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
        }
    }
}