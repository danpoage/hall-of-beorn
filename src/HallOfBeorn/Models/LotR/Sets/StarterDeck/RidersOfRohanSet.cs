using System;

namespace HallOfBeorn.Models.LotR.Sets.StarterDeck
{
    public class RidersOfRohanSet
        : CardSet
    {
        public const string setName = "Riders of Rohan";

        protected override void Initialize()
        {
            Name = setName;
            Abbreviation = "RoR";
            SetType = Models.SetType.Starter_Deck;
            Cycle = "Starter Deck";
            Number = 5006;

            addHero("Éomer", 10, Sphere.Tactics, 1, 3, 2, 4)
                .WithTraits("Rohan.", "Noble.", "Warrior.")
                .WithTextLine("Response: After a character leaves play, Éomer gets +2 Attack until the end of the round. (Limit once per round.)")
                .WithFlavorLine("\"I am named Éomer son of Éomund, and am called the Third Marshal of Riddermark.\" -The Two Towers")
                .WithCommunityVersion("RiddermarkLord/Eomer-Tactics-Hero-1")
                .WithCommunityVersion("RiddermarkLord/Eomer-Tactics-Hero-2")
                .WithInfo(1, 1, Artist.Magali_Villeneuve);
            addHero("Hirgon", 9, Sphere.Tactics, 2, 2, 1, 4)
                .WithTraits("Gondor.", "Scout.")
                .WithTextLine("Response: After Hirgon quests successfully, play a Tactics ally from your hand, reducing its cost by 1 (to a minimum of 1). Then, you may raise your threat by 1 to give that ally +1 Attack and +1 Defense until the end of the round.")
                .WithFlavorLine("\"Hirgon I am, errand-rider of Denethor, who bring you this token of war.\"")
                .WithFlavorLine("-The Return of the King")
                .WithInfo(2, 1, Artist.Aleksander_Karcz);
            addHero("Lothíriel", 8, Sphere.Spirit, 3, 1, 1, 3)
                .WithTraits("Gondor.", "Noble.")
                .WithTextLine("If Éomer is in play, Lothíriel gains the Rohan trait.")
                .WithTextLine("Response: After Lothíriel commits to a quest, choose an ally in your hand. If that ally shares a Trait with her, put that ally into play exhausted and committed to the quest. At the end of the phase, if that ally is still in play, shuffle it into your deck.")
                .WithCommunityVersion("Autumn/Lothiriel")
                .WithInfo(3, 1, Artist.Alvaro_Calvo_Escudero);

            addAlly("Éomund", 3, Sphere.Spirit, true, 2, 1, 1, 2)
                .WithTraits("Rohan.")
                .WithTextLine("Response: After Éomund leaves play, ready all Rohan characters in play.")
                .WithFlavor("\"You I have not seen before, for you are young, but I have spoken with Éomund your father...\" -Aragorn, The Two Towers")
                .WithInfo(4, 3, Artist.Katherine_Dinger);
            addAlly("Escort from Edoras", 2, Sphere.Spirit, false, 2, 0, 0, 1)
                .WithTraits("Rohan.")
                .WithTextLine("While committed to a quest, Escort from Edoras gets +2 Willpower.")
                .WithTextLine("Forced: After resolving a quest to which Escort from Edoras was committed, discard Escort from Edoras from play.")
                .WithInfo(5, 3, Artist.Mark_Winters);
            addAlly("Gandalf", 5, Sphere.Neutral, true, 4, 4, 4, 4)
                .WithTraits("Istari.")
                .WithTextLine("At the end of the round, discard Gandalf from play.")
                .WithTextLine("Response: After Gandalf enters play, (choose 1): draw 3 cards, deal 4 damage to 1 enemy in play, or reduce your threat by 5.")
                .WithCommunityVersion("Gandalf-Core-Set-Completion")
                .WithInfo(6, 2, Artist.Lucas_Graciano);
            addAlly("Guthlaf", 3, Sphere.Tactics, true, 1, 1, 2, 2)
                .WithTraits("Rohan.")
                .WithTextLine("If there is at least 1 Rohan hero in play, lower the cost to play Guthlaf by 1.")
                .WithTextLine("If there is at least 1 Gondor hero in play, Guthlaf gains sentinel.")
                .WithInfo(7, 3, Artist.Aaron_B_Miller);
            addAlly("Horseback Archer", 3, Sphere.Tactics, false, 0, 2, 1, 2)
                .WithTraits("Rohan.", "Archer.")
                .WithKeywords("Ranged.")
                .WithTextLine("Ranged.")
                .WithFlavor("A few of the riders appeared to be bowmen, skilled at shooting from a running horse. -The Two Towers")
                .WithInfo(8, 2, Artist.Loren_Fetterman);
            addAlly("Riddermark Knight", 2, Sphere.Tactics, false, 0, 2, 0, 2)
                .WithTraits("Rohan.", "Warrior.")
                .WithTextLine("Response: After Riddermark Knight is declared as an attacker, it gets +2 Attack for this attack. At the end of this attack, discard Riddermark Knight.")
                .WithInfo(9, 3, Artist.Sebastian_Zakrzewski);
            addAlly("West Road Traveller", 2, Sphere.Spirit, false, 2, 0, 0, 1)
                .WithTraits("Rohan.")
                .WithTextLine("Response: After you play West Road Traveller from your hand, switch the active location with any other location in the staging area.")
                .WithFlavor("The dark world was rushing by, and the wind sang loudly in his ears. -The Return of the King")
                .WithTemplate("<p><b>Response:</b> After you play {self} from your hand, switch the active location with any other location in the staging area.</p><p class='flavor-text'>The dark world was rushing by, and the wind sang loudly in his ears.<br>&ndash;The Return of the King</p>")
                .WithInfo(10, 3, Artist.Sara_Biddle);
            addAlly("Westfold Horse-Breaker", 2, Sphere.Spirit, false, 1, 0, 1, 1)
                .WithTraits("Rohan.")
                .WithTextLine("Action: Discard Westfold Horse-Breaker to choose and ready a hero.")
                .WithFlavor("\"Your own valour has done more, and the stout legs of the Westfold-men marching through the night.\" -Gandalf, The Two Towers")
                .WithInfo(11, 3, Artist.Magali_Villeneuve);
            addAlly("Westfold Horse-breeder", 1, Sphere.Spirit, false, 1, 0, 0, 1)
                .WithTraits("Rohan.")
                .WithTextLine("Response: After Westfold Horse-breeder enters play, search the top 10 cards of your deck for a Mount attachment and add it to your hand. Shuffle your deck.")
                .WithFlavorLine("\"They love their horses next to their kin.\" -Boromir, The Fellowship of the Ring")
                .WithInfo(12, 3, Artist.Mike_Capprotti);
            addAlly("Westfold Lancer", 3, Sphere.Tactics, false, 2, 2, 0, 2)
                .WithTraits("Rohan.", "Warrior.")
                .WithTextLine("Response: After Westfold Lancer quests successfully, discard it to choose a non-unique enemy in the staging area. Deal 2 damage to the chosen enemy.")
                .WithFlavorLine("...the white fury of the Northmen burned the hotter, and more skilled was their knighthood with long spears...")
                .WithFlavorLine("-The Return of the King")
                .WithInfo(13, 3, Artist.Stanislav_Dikolenko);
            addAlly("Westfold Outrider", 2, Sphere.Tactics, false, 0, 2, 1, 2)
                .WithTraits("Rohan.", "Scout.")
                .WithTextLine("Action: Discard Westfold Outrider to choose an enemy not engaged with you. Engage the chosen enemy.")
                .WithFlavorLine("\"Erkenbrand of Westfold has drawn off those men he could gather towards his fastness at Helm's Deep. The rest are scattered.\"-Rider of Rohan, The Two Towers")
                .WithInfo(14, 3, Artist.Diego_Gisbert_Llorens);
            addAttachment("Ancient Mathom", 1, Sphere.Spirit, false)
                .WithTraits("Mathom.")
                .WithTextLine("Attach to a location.")
                .WithTextLine("Response: After attached location is explored, the first player draws 3 cards.")
                .WithFlavor("The Mathom-house it was called; for anything that Hobbits had no immediate use for, but were unwilling to throw away, they called a mathom. Their dwellings were apt to become rather crowded with mathoms... -The Fellowship of the Ring")
                .WithInfo(15, 3, Artist.Anna_Mohrbacher);
            addAttachment("Firefoot", 2, Sphere.Tactics, true)
                .WithTraits("Mount.")
                .WithKeywords("Restricted.")
                .WithTextLine("Attach to a Tactics or Rohan hero. Restricted.")
                .WithTextLine("Attached hero gets +1 Attack (+2 Attack instead if attached hero is Éomer).")
                .WithTextLine("Response: After attached hero attacks alone, exhaust Firefoot to choose a non-unique enemy engaged with you. Excess damage dealt by this attack is assigned to the chosen enemy.")
                .WithInfo(16, 3, Artist.Nora_Brisotti);
            addAttachment("Horn of the Mark", 1, Sphere.Spirit, true)
                .WithTraits("Artifact.", "Item.")
                .WithKeywords("Restricted.")
                .WithTextLine("Attach to a Rohan hero or Merry. Restricted.")
                .WithTextLine("Response: When a character leaves play, if that character shares at least one trait with the attached hero, exhaust Horn of the Mark to draw 1 card.")
                .WithFlavorLine("Then Éowyn gave to Merry an ancient horn, small but cunningly wrought all of fair silver with a baldric of green.")
                .WithFlavorLine("-The Return of the King")
                .WithInfo(17, 3, Artist.Derek_D_Edgell);
            addAttachment("The Red Arrow", 1, Sphere.Tactics, true)
                .WithTraits("Artifact.", "Item.")
                .WithTextLine("Limit 1 per deck. Attach to a Gondor hero.")
                .WithTextLine("Attached hero gets +1 Willpower.")
                .WithTextLine("Valour Response: After attached hero quests successfully, add The Red Arrow to the victory display to search the top 5 cards of your deck for an ally and put it into play.")
                .WithFlavorLine("\"The Red Arrow has not been seen in the Mark in all my years!\"")
                .WithFlavorLine("-Théoden, The Return of the King")
                .WithLimitOnePerDeck()
                .WithVictoryPoints(1)
                .WithInfo(18, 1, Artist.Stanislav_Dikolenko);
            addAttachment("War Axe", 1, Sphere.Tactics, false)
                .WithTraits("Item.", "Weapon.")
                .WithKeywords("Restricted.")
                .WithTextLine("Attach to a Tactics character. Limit 1 per character. Restricted.")
                .WithTextLine("Attached characters gets +1 Attack for each attachment it has with the restricted keyword.")
                .WithFlavorLine("\"Gimli Glóin's son, have you your axe ready?\"")
                .WithFlavorLine("-Éomer, The Return of the King")
                .WithInfo(19, 3, Artist.Tamires_Para);
            addEvent("A Test of Will", 1, Sphere.Spirit)
                .WithTextLine("Response: Cancel the 'when revealed' effects of a card that was just revealed from the encounter deck.")
                .WithFlavor("\"There is naught that you can do, other than to resist, with hope or without it\"\r\n-Elrond, The Fellowship of the Ring")
                .WithTemplate("<p><b>Response:</b> Cancel the &ldquo;when revealed&rdquo; effects of a card that was just revealed from the encounter deck.</p><p class='flavor-text'>&quot;There is naught that you can do, other than to resist, with hope or without it&quot;<br>&ndash;Elrond, The Fellowship of the Ring</p>")
                .WithCommunityVersion("A-Test-of-Will-Core-Set-Completion")
                .WithCommunityVersion("A-Test-of-Will-Nouveau-Hunters")
                .WithCommunityVersion("Autumn/Test-of-Will")
                .WithInfo(20, 2, Artist.Ryan_Barger);
            addEvent("Astonishing Speed", 3, Sphere.Spirit)
                .WithTextLine("Action: Until the end of the phase, all Rohan characters get +2 Willpower.")
                .WithFlavor("With astonishing speed and skill they checked their steeds, wheeled, and came charging round. -The Two Towers")
                .WithInfo(21, 3, Artist.Anna_Christenson);
            addEvent("Feint", 1, Sphere.Tactics)
                .WithTextLine("Combat Action: Choose an enemy engaged with a player. That enemy cannot attack that player this phase.")
                .WithFlavor("A few brave men were strung before them to make a feint of resistance, and many there fell before the rest drew back and fled to either side. -The Hobbit")
                .WithErrata(1)
                .WithCommunityVersion("Feint-Core-Set-Completion")
                .WithInfo(22, 2, Artist.Lius_Lasahido);
            addEvent("Forth Eorlingas!", 2, Sphere.Tactics)
                .WithTextLine("Combat Action: Each Rohan hero can be declared as an attacker against enemies in the staging area this phase.")
                .WithFlavorLine("\"Oaths ye have taken: now fulfill them all, to lord and land and league of friendship!\" -Théoden, The Return of the King")
                .WithInfo(23, 3, Artist.Darek_Zabrocki);
            addEvent("Oath of Eorl", 3, Sphere.Tactics)
                .WithTextLine("Play only if you control a unique character with the Rohan trait and another unique character with the Gondor trait.")
                .WithTextLine("Response: At the beginning of the combat phase, you resolve the step in which you attack enemies before resolving enemy attacks this phase. (Each other player resolves the combat phase as normal after you resolve your attacks.)")
                .WithInfo(24, 3, Artist.Rafal_Hrynkiewicz);
            addEvent("The Muster of Rohan", 4, Sphere.Spirit)
                .WithTextLine("While paying for The Muster of ~Rohan, each Rohan hero you control is considered to have a Spirit icon.")
                .WithTextLine("Planning Action: ~Search the top 10 cards of your deck for up to 4 Rohan allies and put them into play. Shuffle your deck. If any of those allies are still in play at the end of the round, discard them.")
                .WithInfo(25, 3, Artist.Vilius_Petrauskas);
            addEvent("Wait no Longer", 2, Sphere.Tactics)
                .WithTextLine("Response: At the beginning of the quest phase, search the top 5 cards of the encounter deck for an enemy and put it into play engaged with you. Then, reveal 1 less encounter card this phase (to a minimum of 0). Shuffle the encounter deck.")
                .WithFlavorLine("\"We must press our Enemy, and no longer wait upon him for the move.\"")
                .WithFlavorLine("-Aragorn, The Return of the King")
                .WithInfo(26, 3, Artist.John_Pacer);

            //Sideboard
            addHero("Fastred", 9, Sphere.Spirit, 1, 2, 3, 3)
                .WithTraits("Rohan.", "Warrior.")
                .WithTextLine("Response: After Fastred defends an enemy attack, return that enemy to the staging area to reduce your threat by 2. (Limit once per phase.)")
                .WithFlavorLine("\"King's man! King's man!\" his heart cried within him.")
                .WithFlavorLine("-The Return of the King")
                .WithInfo(27, 1, Artist.Lukasz_Jaskolski);
            addAlly("The Riddermark's Finest", 2, Sphere.Spirit, false, 1, 1, 0, 2)
                .WithTraits("Creature.", "Rohan.")
                .WithTextLine("Action: Exhaust and discard The Riddermark's Finest to place 2 progress tokens on any location.")
                .WithFlavor("\"And there are no horses like the ones that are bred in that great vale between the Misty Mountains and the White.\"\r\n-Gandalf, The Fellowship of the Ring")
                .WithInfo(28, 3, Artist.Andrew_Johanson);
             addAttachment("Spear of the Mark", 1, Sphere.Tactics, false)
                .WithTraits("Item.", "Weapon.")
                .WithKeywords("Restricted.")
                .WithTextLine("Attach to a Rohan character. Restricted.")
                .WithTextLine("Attached character gets +1 Attack. (+2 Attack instead if attacking an enemy in the staging area).")
                .WithFlavorLine("Right through the press drove Théoden Thengel's son, and his spear was shivered as he threw down thier chieftan. -The Return of the King")
                .WithInfo(29, 3, Artist.Jon_Bosco);  
            addAttachment("Steed of the Mark", 1, Sphere.Spirit, false)
                .WithTraits("Mount.")
                .WithTextLine("Attach to a Gondor or Rohan hero.")
                .WithTextLine("Response: after attached hero commits to a quest, spend 1 resource from attached hero's resource pool to ready attached hero.")
                .WithFlavorLine("...fresh horses were always in readiness to bear his errand-riders to Rohan in the Noth... -The Return of the King")
                .WithInfo(30, 3, Artist.Sandara_Tang);         
            addAttachment("Rohan Warhorse", 1, Sphere.Tactics, false)
                .WithTraits("Mount.")
                .WithKeywords("Restricted.")
                .WithTextLine("Attach to a Tactics or Rohan hero. Restricted.")
                .WithTextLine("Response: After attached hero participates in an attack that destroys an enemy, exhaust Rohan Warhorse to ready attached hero.")
                .WithFlavorLine("Their horses were of great stature, strong and clean-limbed... -The Two Towers")
                .WithInfo(31, 3, Artist.Jeff_Lee_Johnson);
            addEvent("Charge of the Rohirrim", 2, Sphere.Tactics)
                .WithTextLine("Action: Until the end of the phase, each Rohan character with a Mount attachment gets +3 Attack.")
                .WithFlavorLine("\"Arise, arise, riders of Théoden!\" -Théoden, The Return of the King")
                .WithInfo(32, 3, Artist.Igor_Kieryluk);
        }
    }
}