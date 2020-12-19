/* Generated CardSet class: The Drúadan Forest */

using System;

namespace HallOfBeorn.Models.LotR.Sets.AgainstTheShadow
{
    public class TheDruadanForestSet : CardSet
    {
        protected override void Initialize()
        {
            Name = "The Drúadan Forest";
            Abbreviation = "TDF";
            Number = 17;
            SetType = Models.SetType.Adventure_Pack;
            Cycle = "Against the Shadow";

            addHero("Mirlonde", 8, Sphere.Lore, 2, 2, 1, 3)
                .WithTraits("Silvan.")
                .WithTextLine("Each hero you control with a printed Lore resource icon gets -1 threat cost.")
                .WithFlavorLine("\"...the Elves feared and distrusted the world outside...\"")
                .WithFlavorLine("-The Fellowship of the Ring")
                .WithCommunityVersion("Autumn/Mirlonde")
                .WithInfo(32, 1, Artist.Magali_Villeneuve);
            addAlly("Forlong", 3, Sphere.Leadership, true, 1, 1, 1, 3)
                .WithTraits("Outlands.")
                .WithTextLine("While you control Outlands allies that belong to 4 different spheres, ready Forlong at the beginning of each phase.")
                .WithFlavorLine("\"Forlong!\" men shouted. \"True heart, true friend!\" -The Return of the King")
                .WithInfo(33, 3, Artist.Emile_Denis);
            addEvent("Strength of Arms", 2, Sphere.Leadership)
                .WithTextLine("Play only if each hero you control has a printed Leadership resource icon.")
                .WithTextLine("Action: Ready each ally in play.")
                .WithFlavorLine("And so the companies came and were hailed and cheered and passed through the Gate, men of the Outlands marching to defend the City of Gondor in a dark hour... -The Return of the King")
                .WithInfo(34, 3, Artist.Jon_Bosco);
            addAttachment("Mighty Prowess", 1, Sphere.Tactics, false)
                .WithTraits("Skill.")
                .WithTextLine("Attach to a Tactics hero. Limit 1 per hero.")
                .WithTextLine("Response: After attached hero attacks and destroys an enemy, deal 1 damage to another enemy that shares a Trait with the enemy just destroyed.")
                .WithFlavorLine("He slew many of them and the rest fled. -The Two Towers")
                .WithInfo(35, 3, Artist.Blake_Henriksen);
            addEvent("Trained for War", 2, Sphere.Tactics)
                .WithTextLine("Play only if each hero you control has the printed Tactics resource icon.")
                .WithTextLine("Action: Until the end of the phase, if the current quest does not have Siege, it gains Battle.")
                .WithErrata(1)
                .WithInfo(36, 3, Artist.Magali_Villeneuve);
            addAlly("Silvan Refugee", 1, Sphere.Spirit, false, 2, 0, 0, 1)
                .WithTraits("Silvan.")
                .WithTextLine("Forced: After a character leaves play, discard Silvan Refugee from play.")
                .WithFlavorLine("\"The Elves have their own labours and their own sorrows...\" -Gildor, The Fellowship of the Ring")
                .WithTemplate("<p><b>Forced:</b> After a character leaves play, discard {self} from play.</p><p class='flavor-text'>&quot;The Elves have their own labours and their own sorrows...&quot;<br/>&ndash;Gildor, The Fellowship of the Ring</p>")
                .WithInfo(37, 3, Artist.Lorraine_Schleter);
            addEvent("Against the Shadow", 2, Sphere.Spirit)
                .WithTextLine("Play only if each hero you control has the printed Spirit resource icon.")
                .WithTextLine("Action: Until the end of the phase, Spirit characters use their Willpower instead of Defense.")
                .WithFlavorLine("\"Courage will now be your best defense against the storm that is at hand...\" -Gandalf, The Return of the King")
                .WithInfo(38, 3, Artist.Andrew_Ryan);
            addAlly("Harbor Master", 3, Sphere.Lore, false, 1, 2, 0, 2)
                .WithTraits("Noldor.")
                .WithTextLine("Response: After a card effect adds any number of resources to the resource pool of a hero you control, Harbor Master gains +1 Defense until the end of the round.")
                .WithFlavorLine("For the Elves of the High Kindred had not yet forsaken Middle-earth, and they dwelt still at that time at the Grey Havens...-The Fellowship of the Ring")
                .WithInfo(39, 3, Artist.Kristina_Gehrmann);
            addEvent("Advance Warning", 2, Sphere.Lore)
                .WithTextLine("Play only if each hero you control has a printed Lore resource icon.")
                .WithTextLine("Action: Until the end of the phase, enemies do not make engagement checks")
                .WithFlavorLine("Suddenly he halted and listened. Had he heard a whistle or not? Or was it the call of some strange bird? -The Two Towers")
                .WithInfo(40, 3, Artist.Adam_Lane);
            addAlly("White Tower Watchman", 3, Sphere.Neutral, false, 1, 0, 2, 3)
                .WithTraits("Gondor.")
                .WithTextLine("If each hero you control belongs to the same sphere of influence, you may assign damage from undefended enemy attacks to White Tower Watchman instead of a hero you control.")
                .WithFlavorLine("The watchmen cried aloud, and all men in the City stood to arms. -The Return of the King")
                .WithInfo(41, 3, Artist.Ilich_Henriquez);
            addQuest("The Pursuit", EncounterSet.TheDruadanForest, 1, 'A', 11)
                .WithTextLine("Setup: Search the encounter deck for Drû-buri-Drû and set him aside, out of play. Shuffle the encounter deck.")
                .WithFlavorLine("The leader of the underworld cabal from Minas Tirith has fled with his remaining henchmen. You have followed his trail to The Drúadan Forest, hoping to bring the nameless villain to justice.")
                .WithOppositeTextLine("When Revealed: Reveal 1 card from the encounter deck per player and add it to the staging area.")
                .WithOppositeFlavorLine("The Drúadan Forest is a wild and dangerous place. It is said that Woses, reclusive forest dwellers, still reside among the trees. You wonder if your quarry has considered the dangers of this course.")
                .WithIncludedEncounterSets(EncounterSet.BroodingForest)
                .WithInfo(42, 1, Artist.Emile_Denis);
            addQuest("An Untimely End", EncounterSet.TheDruadanForest, 2, 'A', 17)
                .WithFlavorLine("As you move deeper into the forest, the wilderness quickly swallows all trace of civilization. Pushing through a dense patch of undergrowth, you came upon a dark and tangled grove. The scent of death strikes you.")
                .WithOppositeTextLine("Archery damage must be assigned to allies, if able.")
                .WithOppositeFlavorLine("In the grove, the fleeing traitors lie slain, pierced by poisoned arrows. As you search the pain-wracked corpses for the body of their leader, the ominous echo of drums begins to sound among the trees. You desperately begin to retrace your steps from the woods, lest the fate of the traitors becomes your own.")
                .WithIncludedEncounterSets(EncounterSet.BroodingForest)
                .WithInfo(43, 1, Artist.Adam_Lane);
            addQuest("The Passage Out", EncounterSet.TheDruadanForest, 3, 'A', 14)
                .WithKeywords("Siege.")
                .WithTextLine("When Revealed: Add Drû-buri-Drû to the staging area.")
                .WithFlavorLine("You sense that the edge of the forest must be near at hand, but Woses are master huntsmen and a band of them block your path. your situation seems hopeless: there are simply too many of them. As they begin their attack, you realize your only hope of survival is to convince the Pukel-men that you are not their enemy.")
                .WithOppositeTextLine("Siege.")
                .WithOppositeTextLine("Characters use their Willpower instead of Attack when attacking enemies. If an enemy would be damaged this way, place progress tokens on it instead of damage tokens. When an enemy has progress equal to its hit points, add it to the victory display and place those progress tokens on the quest.")
                .WithOppositeTextLine("If the players defeat this stage, they have won the game.")
                .WithIncludedEncounterSets(EncounterSet.BroodingForest)
                .WithInfo(44, 1, Artist.Jason_Ward);
            addEnemy("Drû-buri-Drû", EncounterSet.TheDruadanForest, 1, 4, 5, 3, 6)
                .WithUnique()
                .WithTraits("Wose.")
                .WithTextLine("Allies cannot defend against Drû-buri-Drû.")
                .WithTextLine("While Drû-buri-Drû is in the victory display, characters get +1 Willpower and +1 Defense.")
                .WithTextLine("Unless Drû-buri-Drû is in the victory display, the players cannot win.")
                .WithInfo(45, 1, Artist.David_A_Nash);
            addEnemy("Drúadan Drummer", EncounterSet.TheDruadanForest, 40, 0, 1, 2, 2)
                .WithTraits("Wose.")
                .WithTextLine("Each Wose enemy in the staging area gets +2 Threat.")
                .WithShadow("Shadow: Each Wose enemy engaged with the defending player gets +1 Attack.")
                .WithEasyModeQuantity(1)
                .WithInfo(46, 3, Artist.Jason_Ward);
            addEnemy("Drúadan Elite", EncounterSet.TheDruadanForest, 35, 2, 3, 2, 4)
                .WithTraits("Wose.")
                .WithKeywords("Archery 2.", "Prowl X.")
                .WithTextLine("Archery 2. Prowl X.")
                .WithTextLine("X is the number of players in the game.")
                .WithShadow("Shadow: Return attacking enemy to the staging area after it attacks unless any player pays 1 resource.")
                .WithInfo(47, 3, Artist.Jason_Ward);
            addEnemy("Drúadan Hunter", EncounterSet.TheDruadanForest, 25, 2, 4, 3, 3)
                .WithTraits("Wose.")
                .WithKeywords("Prowl 1.", "Archery X.")
                .WithTextLine("Prowl 1. Archery X.")
                .WithTextLine("X is the number of heroes in play with no resources in their resource pool.")
                .WithShadow("Shadow: Attacking enemy gets +2 Attack.")
                .WithEasyModeQuantity(2)
                .WithInfo(48, 4, Artist.Jason_Ward);
            addEnemy("Drúadan Thief", EncounterSet.TheDruadanForest, 5, 2, 2, 1, 2)
                .WithTraits("Wose.")
                .WithKeywords("Surge.", "Prowl 1.")
                .WithTextLine("Surge. Prowl 1.")
                .WithShadow("Shadow: Return attacking enemy to the staging area after it attacks unless any player pays 1 resource.")
                .WithInfo(49, 3, Artist.Jason_Ward);
            addLocation("Ancestral Clearing", EncounterSet.TheDruadanForest, 4, 3)
                .WithTraits("Forest.")
                .WithTextLine("The cost to play each player card is increased by 1.")
                .WithTextLine("Travel: Exhaust a hero to travel here.")
                .WithFlavorLine("\"They still haunt The Drúadan Forest...\" -Elfhelm, The Return of the King")
                .WithEasyModeQuantity(0)
                .WithInfo(50, 1, Artist.Grzegorz_Pedrycz);
            addLocation("Garden of Poisons", EncounterSet.TheDruadanForest, 2, 3)
                .WithTraits("Forest.")
                .WithTextLine("Heroes cannot gain resources from card effects.")
                .WithTextLine("Travel: Each player must pay 1 resource to travel here.")
                .WithFlavorLine("\"...they use poisoned arrows, it is said...\" - Elfhelm, The Return of the King")
                .WithInfo(51, 3, Artist.Simon_Dominic);
            addLocation("Glade of Cleansing", EncounterSet.TheDruadanForest, Card.VALUE_X, 5)
                .WithTraits("Forest.")
                .WithTextLine("Each Wose enemy gains Archery 1.")
                .WithTextLine("X is equal to the total archery value of the highest archery Wose enemy in play.")
                .WithFlavorLine("\"...they are woodcrafty beyond compare.\" -Elfhelm, The Return of the King")
                .WithEasyModeQuantity(1)
                .WithInfo(52, 3, Artist.Titus_Lunter);
            addTreachery("Men in the Dark", EncounterSet.TheDruadanForest)
                .WithTextLine("When Revealed: Each hero must pay 1 resource or take 1 damage. If no hero takes damage from this effect, Men in the Dark gains surge.")
                .WithShadow("Shadow: Attacking enemy gets +1 Attack for each hero the defending player controls with no resources.")
                .WithInfo(53, 3, Artist.Marcia_GeorgeBogdan);
            addTreachery("Stars in Sky", EncounterSet.TheDruadanForest)
                .WithKeywords("Prowl 2.")
                .WithTextLine("Prowl 2.")
                .WithTextLine("When Revealed: Each questing hero must pay 1 resource or it is removed from the quest.")
                .WithShadow("Shadow: Discard all resources from the defending character's resource pool.")
                .WithInfo(54, 3, Artist.Blake_Henriksen);
            addTreachery("Leaves on Tree", EncounterSet.TheDruadanForest)
                .WithKeywords("Surge.")
                .WithTextLine("Surge.")
                .WithTextLine("When Revealed: Each player must pay 1 resource for each attachment he controls or discard all attachments he controls.")
                .WithShadow("Shadow: Discard an attachment from the defending character.")
                .WithInfo(55, 2, Artist.Jason_Ward);
        }
    }
}
