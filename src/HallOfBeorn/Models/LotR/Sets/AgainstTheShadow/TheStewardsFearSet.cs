/* Generated CardSet class: The Steward's Fear */

using System;

namespace HallOfBeorn.Models.LotR.Sets.AgainstTheShadow
{
    public class TheStewardsFearSet : CardSet
    {
        protected override void Initialize()
        {
            Name = "The Steward's Fear";
            Abbreviation = "TSF";
            Number = 16;
            SetType = Models.SetType.Adventure_Pack;
            Cycle = "Against the Shadow";

            addHero("Hirluin the Fair", 8, Sphere.Leadership, 1, 1, 1, 4)
                .WithTraits("Outlands.")
                .WithKeywords("Ranged.")
                .WithTextLine("Ranged.")
                .WithTextLine("You may use resources from Hirluin the Fair's resource pool to pay for Outlands ally cards of any sphere.")
                .WithFlavorLine("Hirluin the Fair of the Green Hills from Pinnath Gelin... -The Return of the King")
                .WithInfo(1, 1, Artist.Tony_Foti);
            addAlly("Warrior of Lossarnach", 2, Sphere.Leadership, false, 1, 1, 1, 1)
                .WithTraits("Outlands.")
                .WithTextLine("Each Outlands character you control gets +1 Defense.")
                .WithFlavorLine("... grim-faced they were, and shorter and somewhat swarthier than any men that Pippin had yet seen in Gondor. - The Return of the King")
                .WithInfo(2, 3, Artist.Mark_Winters);
            addEvent("Gaining Strength", 0, Sphere.Leadership)
                .WithTextLine("Action: Discard 2 resources from your hero's resource pool to add 3 resources to that hero's resource pool.")
                .WithFlavorLine("\"Nay, my friends, I am the lawful master of the Stone, and I had both the right and the strength to use it...\" -Aragorn, The Return of the King")
                .WithInfo(3, 3, Artist.Magali_Villeneuve);
            addAlly("Knights of the Swan", 1, Sphere.Tactics, false, 0, 0, 0, 1)
                .WithTraits("Outlands.")
                .WithTextLine("Each Outlands character you control gets +1 Attack.")
                .WithFlavorLine("...foremost on the field rode the swan-knights of Dol Amroth with their Prince and his blue banner at their head. -The Return of the King")
                .WithInfo(4, 3, Artist.Marcia_GeorgeBogdan);
            addAttachment("Gondorian Shield", 1, Sphere.Tactics, false)
                .WithTraits("Armor.", "Item.")
                .WithKeywords("Restricted.")
                .WithTextLine("Attach to a hero. Restricted.")
                .WithTextLine("Limit 1 per hero.")
                .WithTextLine("Attached hero gains +1 Defense. (+2 Defense instead if attached hero has the Gondor trait.)")
                .WithFlavorLine("There flowered a White Tree, and that was for Gondor... -The Return of the King")
                .WithTemplate("<p>Attach to a {type:hero}. {keyword:Restricted.}</p><p>Limit 1 per hero.</p><p>Attached hero gains +1 {Defense}. (+2 {Defense} instead if attached hero has the {trait:Gondor.@Gondor} trait.)</p><p class='flavor-text'>There flowered a White Tree, and that was for Gondor...<br>&ndash;The Return of the King</p>")
                .WithInfo(5, 3, Artist.Owen_William_Weber);
            addAlly("Ethir Swordsman", 2, Sphere.Spirit, false, 1, 1, 1, 1)
                .WithTraits("Outlands.")
                .WithTextLine("Each Outlands character you control gets +1 Willpower.")
                .WithFlavorLine("We heard of the horns in the hills ringing,")
                .WithFlavorLine("the swords shining in the South-kingdom.")
                .WithFlavorLine("-The Return of the King")
                .WithInfo(6, 3, Artist.Adam_Schumpert);
            addAttachment("Ring of Barahir", 1, Sphere.Spirit, true)
                .WithTraits("Artifact.", "Item.", "Ring.")
                .WithTextLine("Attach to a hero.")
                .WithTextLine("Attached hero gets +1 hit point for each Artifact attachment attached to it.")
                .WithTextLine("If attached hero is Aragorn, he also gains a Lore resource icon.")
                .WithInfo(7, 3, Artist.Sara_Biddle);
            addAlly("Anfalas Herdsman", 1, Sphere.Lore, false, 0, 0, 0, 1)
                .WithTraits("Outlands.")
                .WithTextLine("Each Outlands character you control gets +1 hit point.")
                .WithFlavorLine("From the Anfalas, the Langstrand far away, a long line of men of many sorts, hunters and herdsmen and men of little villages... -The Return of the King")
                .WithInfo(8, 3, Artist.Blake_Henriksen);
            addEvent("Mithrandir's Advice", 1, Sphere.Lore)
                .WithTextLine("Action: Draw 1 card for each hero you control with a printed Lore resource icon.")
                .WithFlavorLine("\"Let none now reject the counsels of Gandalf, whose long labours against Sauron come at last to their test.\" -Aragorn, The Return of the King")
                .WithInfo(9, 3, Artist.Nacho_Molina);
            addEvent("A Good Harvest", 0, Sphere.Neutral)
                .WithTextLine("Action: Name a sphere. Until the end of the phase, you can spend resources of any sphere when paying for cards that belong to the named sphere.")
                .WithFlavorLine("The townlands were rich, with wide tilth and many orchards, and homesteads there were with oast and garner, fold and byre, and many rills rippling through the green from the highlands down to the Anduin. -The Return of the King")
                .WithInfo(10, 3, Artist.Trudi_Castle);
            addQuest("Conspiracy", EncounterSet.TheStewardsFear, 1, 'A', null)
                .WithTextLine("Setup: Create the underworld deck. Remove Roots of Mindolluin from the encounter deck and set it aside, out of play. Shuffle all Villain cards and randomly set one aside, out of play, without looking at it. Remove the others from the game. Repeat this with all Plot cards.")
                .WithFlavorLine("Even as foes mass from without, the Steward of Minas Tirith fears there are enemies within. You have been asked to investigate the possibility of a conspiracy within the White City...")
                .WithOppositeTextLine("When Revealed: Search the encounter deck for The Fourth Star and make it the active location. Shuffle the encounter deck.")
                .WithOppositeTextLine("Forced: After the active location leaves play as an explored location, place 1 resource token on this quest.")
                .WithOppositeTextLine("If there are 4 or more resource tokens on Conspiracy, advance to the next stage.")
                .WithOppositeFlavorLine("You begin your investigation at The Fourth Star, a popular tavern...")
                .WithIncludedEncounterSets(EncounterSet.Brigands, EncounterSet.StreetsOfGondor)
                .WithInfo(11, 1, Artist.Milek_Jakubiec);
            addQuest("The Grand Design", EncounterSet.TheStewardsFear, 2, 'A', null)
                .WithTextLine("When Revealed: Reveal the set aside Plot card and add it to the staging area.")
                .WithFlavorLine("You have uncovered crucial information about the dissident plot, and even gleaned hints of teh conspirator's secretive leader. Clues have led you to a cavern deep in the heart of Mount Mindolluin. As you descend into the ancient rock, you begin to suspect the clues that led you here may have been misleading... that you may have been lured away from the city streets for a purpose.")
                .WithOppositeTextLine("When Revealed: Make Roots of Mindolluin the active location, returning any other active location to the staging area.")
                .WithOppositeTextLine("Forced: After the active location leaves play as an explored location place 1 resource token on this quest.")
                .WithOppositeTextLine("If there are 4 or more resource tokens on The Grand Design, advance to the next stage.")
                .WithIncludedEncounterSets(EncounterSet.Brigands, EncounterSet.StreetsOfGondor)
                .WithInfo(12, 1, Artist.Grzegorz_Pedrycz);
            addQuest("The Confrontation", EncounterSet.TheStewardsFear, 3, 'A', 15)
                .WithTextLine("When Revealed: Reveal the set aside Villain card and add it to the staging area.")
                .WithFlavorLine("You have unmasked the conspiracy and its champion is upon you. The wheels of treachery are in motion, and only a heroic effort can stop the cabal's plan in time...")
                .WithOppositeTextLine("When Revealed: Shuffle the underworld deck into the encounter deck.")
                .WithOppositeTextLine("The players cannot defeat this stage while a Villain is in play. If this stage is defeated, the players have won the game.")
                .WithIncludedEncounterSets(EncounterSet.Brigands, EncounterSet.StreetsOfGondor)
                .WithInfo(13, 1, Artist.David_A_Nash);
            addEnemy("Underworld Dissident", EncounterSet.TheStewardsFear, 25, 3, 2, 2, 2)
                .WithTraits("Brigand.")
                .WithTextLine("Underworld Dissident gets +1 Attack for each Underworld location in play.")
                .WithShadow("Shadow: If this attack is undefended, remove 1 token from the current quest.")
                .WithInfo(14, 5, Artist.Dan_Howard);
            addEnemy("Daughter of Berúthiel", EncounterSet.TheStewardsFear, 10, 3, 5, 3, 5)
                .WithUnique()
                .WithTraits("Gondor.", "Villain.")
                .WithTextLine("Daughter of Berúthiel cannot be optionally engaged.")
                .WithTextLine("Forced: After Daughter of Berúthiel attacks, return her to the staging area. The engaged player may raise his threat by 4 to prevent this effect.")
                .WithInfo(15, 1, Artist.Anna_Steinbauer);
            addEnemy("The Hand of Castamir", EncounterSet.TheStewardsFear, 30, 3, 4, 3, 6)
                .WithUnique()
                .WithTraits("Gondor.", "Villain.")
                .WithTextLine("Forced: After The Hand of Castamir attacks, reveal the top card of the encounter deck, resolve its effects, and discard it.")
                .WithTextLine("Forced: After a treachery card is revealed from the encounter deck, The Hand of Castamir makes an immediate attack against the first player.")
                .WithInfo(16, 1, Artist.Tiziano_Baracchi);
            addEnemy("Telemnar's Bane", EncounterSet.TheStewardsFear, 20, 3, 3, 2, 7)
                .WithUnique()
                .WithTraits("Gondor.", "Villain.")
                .WithTextLine("Forced: When Telemnar's Bane attacks, discard the top 3 cards of each player's deck.")
                .WithTextLine("Forced: After a player plays an event card, Telemnar's Bane makes an immediate attack against the first player.")
                .WithInfo(17, 1, Artist.Aurelien_Hubert);
            addLocation("Sewers", EncounterSet.TheStewardsFear, 3, 3)
                .WithTraits("Underworld.", "City.")
                .WithKeywords("Underworld 1.")
                .WithTextLine("Underworld 1.")
                .WithTextLine("When Revealed: Place the top card of the underworld deck facedown underneath the active location, if able.")
                .WithInfo(18, 3, Artist.Titus_Lunter);
            addLocation("Roots of Mindolluin", EncounterSet.TheStewardsFear, 2, 5)
                .WithUnique()
                .WithTraits("Underworld.")
                .WithKeywords("Underworld 1.")
                .WithTextLine("Underworld 1.")
                .WithTextLine("Each location in the staging area gets +2 quest points.")
                .WithFlavorLine("\"Were it buried beneath the roots of Mindolluin, still it would burn your mind away...\" -Gandalf, The Return of the King")
                .WithInfo(19, 1, Artist.Rafal_Hrynkiewicz);
            addLocation("Storehouse", EncounterSet.TheStewardsFear, 2, 2)
                .WithTraits("Underworld.", "City.")
                .WithKeywords("Underworld 1.")
                .WithTextLine("Underworld 1.")
                .WithShadow("Shadow: Attacking enemy gets +1 Attack. (+2 Attack instead if undefended.)")
                .WithFlavorLine("Great stores of goods and food, and beer, were found that had been hidden away... -The Return of the King")
                .WithInfo(20, 2, Artist.Titus_Lunter);
            addLocation("Houses of the Dead", EncounterSet.TheStewardsFear, 4, 4)
                .WithUnique()
                .WithTraits("Underworld.", "City.")
                .WithKeywords("Underworld 2.")
                .WithTextLine("Underworld 2.")
                .WithTextLine("Forced: After Houses of the Dead becomes the active location, exhaust all characters.")
                .WithFlavorLine("\"The houses of the dead are no places for the living.\" -Gandalf, The Return of the King")
                .WithEasyModeQuantity(0)
                .WithInfo(21, 1, Artist.Titus_Lunter);
            addLocation("The Fourth Star", EncounterSet.TheStewardsFear, 3, 5)
                .WithUnique()
                .WithTraits("City.")
                .WithKeywords("Underworld X.")
                .WithTextLine("Underworld X.")
                .WithTextLine("X is the number of players in the game.")
                .WithTextLine("Response: When The Fourth Star leaves play as an explored location, each player may draw 1 card.")
                .WithInfo(22, 1, Artist.Sabin_Boykinov);
            addTreachery("Unwelcome Discovery", EncounterSet.TheStewardsFear)
                .WithKeywords("Surge.")
                .WithTextLine("Surge.")
                .WithTextLine("When Revealed: Reveal 1 card from the underworld deck and add it to the staging area. If it is a Clue card, discard it instead.")
                .WithInfo(23, 2, Artist.David_Gaillet);
            addTreachery("A Knife in the Back", EncounterSet.TheStewardsFear)
                .WithTextLine("When Revealed: Randomly select 1 ally controlled by the first player, if able. The first player deals X damage to one of his heroes, where X is that ally's Attack. Then discard that ally. If no ally is discarded by this effect, A Knife in the Back gains surge.")
                .WithEasyModeQuantity(1)
                .WithInfo(24, 3, Artist.Carmen_Cianelti);
            addTreachery("False Lead", EncounterSet.TheStewardsFear)
                .WithTextLine("When Revealed: End the quest phase without resolving the quest.")
                .WithShadow("Shadow: If this attack destroys a character, remove all tokens from the current quest.")
                .WithInfo(25, 2, Artist.Darek_Zabrocki);
            addObjective("A Scrap of History", EncounterSet.TheStewardsFear)
                .WithTraits("Clue.")
                .WithTextLine("Action: Exhaust a hero to claim this objective, add it to the victory display, and place 1 resource token on the current quest.")
                .WithVictoryPoints(1)
                .WithInfo(26, 1, Artist.Aurelien_Hubert);
            addObjective("Secret Map", EncounterSet.TheStewardsFear)
                .WithTraits("Clue.")
                .WithTextLine("Action: Exhaust a hero to claim this objective and attach it to that hero.Action: If attached to a hero, add Secret Map to the victory display to place 3 progress tokens on the active location.")
                .WithVictoryPoints(1)
                .WithInfo(27, 1, Artist.Ilich_Henriquez);
            addObjective("A Prisoner", EncounterSet.TheStewardsFear)
                .WithTraits("Clue.")
                .WithTextLine("Action: Exhaust a hero to claim this objective, add it to the victory display, and place 2 resource tokens on the current quest.")
                .WithVictoryPoints(1)
                .WithInfo(28, 1, Artist.Even_Mehl_Amundsen);
            addObjective("Unholy Alliance", EncounterSet.TheStewardsFear)
                .WithTraits("Plot.")
                .WithTextLine("Reveal 1 additional card from the encounter deck and add it to the staging area during the staging step each round.If a hero is destroyed by an enemy attack, the players have lost the game.")
                .WithInfo(29, 1, Artist.Blake_Henriksen);
            addObjective("Up in Flames", EncounterSet.TheStewardsFear)
                .WithTraits("Plot.")
                .WithTextLine("Forced: At the end of the round, place 1 resource token on Up in Flames and discard the top X cards of each player's deck. X is the number of resource tokens on Up in Flames.If any player has no cards in his deck, the players have lost the game.")
                .WithInfo(30, 1, Artist.Marcia_GeorgeBogdan);
            addObjective("Poisoned Counsels", EncounterSet.TheStewardsFear)
                .WithTraits("Plot.")
                .WithTextLine("At the end of each round, raise each player's threat by 2.")
                .WithFlavorLine("\"... whispering was in your ears, poisoning your thought...\" -Gandalf, The Two Towers")
                .WithInfo(31, 1, Artist.David_A_Nash);
        }
    }
}
