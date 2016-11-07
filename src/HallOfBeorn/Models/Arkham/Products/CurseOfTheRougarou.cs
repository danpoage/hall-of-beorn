using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace HallOfBeorn.Models.Arkham.Products
{
    public class CurseOfTheRougarou : ArkhamProduct
    {
        private ArkhamEncounterSet set = ArkhamEncounterSet.CurseOfTheRougarou;

        public CurseOfTheRougarou()
            : base("Curse of the Rougarou", "CotR", "AHC09", 2, new DateTime(2016, 10,31))
        {
        }

        protected override void init()
        {
            addCard(ArkhamCard.ScenarioReference("Curse of the Rougarou", "Scenario Reference", set)
                .WithText("{Skull} -2 (-4 instead if you are at a {t:Bayou} location)\r\n{Cultist} -2. If The Rougarou is in you location, reveal another token.\r\n{Tablet}: Reveal another token. If you fail, until the end of the round, you cannot move.\r\n{Elder Thing} -4. If The Rougarou is at your location, it attacks you.")
                .WithBackText("{Skull} -3 (-6 instead if you are at a {t:Bayou} location)\r\n{Cultist} -3. If The Rougarou is in you location, reveal another token.\r\n{Tablet}: Reveal another token. If you fail, until the end of the round, you cannot move.\r\n{Elder Thing} -4. If The Rougarou is at your location or a connecting location, it attacks you.")
                .WithInfo(1, 1, Artist.None));
            addCard(ArkhamCard.Agenda("A Creature of the Bayou", "Darkened Skies", 1, Number.Of(5), set)
                .WithFlavor("")
                .WithBackFlavor("")
                .WithBackText("Shuffle the encounter discard pile into the encounter deck.\r\nIf The Rougarou is in play, find a non-{t:Bayou} location with the fewest clues on it. Move The Rougarou (one location at a time) until it enters that location.\r\nIf The Rougarou is not in play, after advancing to agenda 2a, add 1 doom to that agenda.")
                .WithInfo(2, 1, Artist.Ignacio_Bazan_Lazcano));
            addCard(ArkhamCard.Agenda("The Rougarou Feeds", "The Tenth Night", 2, Number.Of(6), set)
                .WithFlavor("")
                .WithBackFlavor("")
                .WithBackText("Shuffle all copies of On the Prowl from the encounter discard pile into the encounter deck.\r\nIf The Rougarou is in play, find a non-{t:Bayou} location with the fewest clues on it. Move The Rougarou (one location at a time) until it enters that location.\r\nIf The Rougarou is not in play, after advancing to agenda 3a, add 1 doom to that agenda.")
                .WithInfo(3, 1, Artist.Ignacio_Bazan_Lazcano));
            addCard(ArkhamCard.Agenda("The Curse Spreads", "Taken by the Curse", 3, Number.Of(8), set)
                .WithFlavor("")
                .WithText("Forced - At the end of the investigation phase, if The Rougarou is not engaged with an investigator: Add 1 doom to this agenda.")
                .WithBackFlavor("")
                .WithBackText("<hr><b>The bearer of the Curse of the Rougarou weakness read the following (out loud):</b>\r\n<p class='arkham-flavorText'>You feel something dripping from your hand, and are surprised to find your knuckles bloody and torn. Nearby, the bard of a tree is smashed and dripping with blood. The anger of your failure slowly fades as you realize the blood is yours.</p>\r\n<b>(&rarr;R1)</b><hr><b>If no investigators gained the Curse of the Rougarou:\r\n(&rarr;R1)</b>")
                .WithInfo(4, 1, Artist.Ignacio_Bazan_Lazcano));
            addCard(ArkhamCard.Act("Finding Lady Esprit", "Understanding the Curse", 1, Number.Of(1).PerInvestigator(), set)
                .WithFlavor("")
                .WithText("<b>Objective</b> - Only investigators at a {t:Bayou} location may spend the requisite number of clues, as a group, to advance.")
                .WithBackFlavor("")
                .WithBackText("Put the set-aside Lady Esprit into play at {t:Bayou} location. Put into play each set aside location. Put the set-aside The Rougarou enemy into play at any non-Bayou location. Shuffle the encounter discard pile and each encounter card from the <a href='/Arkham?EncounterSet=Curse+of+the+Rougarou' target='_blank'><i>Curse of the Rougarou</i></a> encounter set into the encounter deck.\r\n<hr>\r\n<b>The lead investigator reads the following (out loud):</b>\r\n<p class='arkham-flavorText'>As you leave Lady Esprit's shack, a terrible sickness courses through you, and you drop to your knees.</p>\r\nThe lead investigator puts the set-aside Curse of the Rougarou weakness into play in his or her threat area.")
                .WithInfo(5, 1, Artist.Darek_Zabrocki));
            addCard(ArkhamCard.Act("Hunting the Rougarou", "Taming the Rougarou", 2, Number.NA, set)
                .WithFlavor("The Rougarou is somewhere within the vast bayou. You must track it down and destroy it, lest the beast's curse consume you as well.")
                .WithText("<b>Forced -</b> After The Rougarou leaves a location: Place 1 clue from the token bank on that location.\r\n<b>Objective -</b> \"We have to destry the beast!\"<br>If The Rougarou is defeated: <b>(&rarr;R2)</b>\r\n<b>Objective -</b> \"Maybe there's another way...\"<br>While an investigator is engaged with The Rougarou, he or she may choose to advance. (Limit once per phase.)")
                .WithBackFlavor("Conversing with the creature is a daunting task. Whenever it is cornered, it bellows and attacks, like a feral beast. If there is still some semblance of humanity left inside the create, it is buried deep beneath the rage and bloodlust of the curse.")
                .WithBackText("If each of the following requirements are met, proceed to <b>(&rarr;R3).</b> Otherwise, flip this act back to its \"a\" side.<br><ul><li>\"We must learn more about the curse.\" The investigators must have 4<img src='/Images/Arkham/PerInvestigatorBlack.png' height='10' width='10'/> clues, as a group.</li><li>\"We must keep it contained.\" The Rougarou must have a {t:Trap} card attached to it.</li><li>\"We must protected ourseleves.\" The Rougarou must have at least 1<img src='/Images/Arkham/PerInvestigatorBlack.png' height='10' width='10'/> damage on it.</li><li>\"We must calm it down.\" The investigators must have either \"found a binding stone\" or \"found a strange doll.\"</li></ul>")
                .WithInfo(6, 1, Artist.Darek_Zabrocki));
        }
    }
}