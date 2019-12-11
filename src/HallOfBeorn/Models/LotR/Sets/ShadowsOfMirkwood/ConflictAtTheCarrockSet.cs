/* Generated CardSet class: Conflict at the Carrock */

using System;

namespace HallOfBeorn.Models.LotR.Sets.ShadowsOfMirkwood
{
    public class ConflictAtTheCarrockSet : CardSet
    {
        protected override void Initialize()
        {
            Name = "Conflict at the Carrock";
            Abbreviation = "CatC";
            Number = 3;
            SetType = Models.SetType.Adventure_Pack;
            Cycle = "Shadows of Mirkwood";

            addHero("Frodo Baggins", 7, Sphere.Spirit, 2, 1, 2, 2)
                .WithTraits("Hobbit.")
                .WithTextLine("Response: After Frodo ~Baggins is damaged, cancel the damage and instead raise your threat by the amount of damage he would have been dealt. (Limit once per phase.)")
                .WithFlavor("Frodo began to feel restless, and the old paths seemed too well-trodden. he looked at maps and wondered what lay beyond their edges... -The Fellowship of the Ring")
                .WithInfo(25, 1, Artist.John_Stanko);
            addAttachment("Dúnedain Warning", 1, Sphere.Leadership, false)
                .WithTraits("Signal.")
                .WithTextLine("Attach to a hero.")
                .WithTextLine("Attached hero gains +1 Defense.")
                .WithTextLine("Action: Pay 1 resource from attached hero's pool to attach Dunedain Warning to another hero.")
                .WithInfo(26, 3, Artist.Taufiq);
            addEvent("Second Breakfast", 1, Sphere.Leadership)
                .WithTextLine("Action: Each player returns the topmost attachment card from his discard pile to his hand.")
                .WithFlavor("...he was just sitting down to a nice little second-breakfast in the dinning-room...\r\n-The Hobbit")
                .WithInfo(27, 3, Artist.Magali_Villeneuve);
            addAlly("Beorning Beekeeper", 4, Sphere.Tactics, false, 1, 2, 1, 3)
                .WithTraits("Beorning.")
                .WithTextLine("Action: Discard Beorning Beekeeper from play to deal 1 damage to each enemy in the staging area.")
                .WithFlavor("\"We are getting near,\" said Gandalf. \"We are on th eedge of his bee pastures.\" - The Hobbit")
                .WithInfo(28, 3, Artist.John_Matson);
            addAttachment("Born Aloft", 0, Sphere.Tactics, false)
                .WithTraits("Condition.")
                .WithTextLine("Attach to an ally.")
                .WithTextLine("Action: Discard Born Aloft from play to return attached ally to its owner's hand.")
                .WithFlavor("\"Very well,\" said Gandalf. \"Take us where and as far as you will!\" -The Hobbit")
                .WithInfo(29, 3, Artist.Salvador_Trakal);
            addAlly("Éomund", 3, Sphere.Spirit, true, 2, 1, 1, 2)
                .WithTraits("Rohan.")
                .WithTextLine("Response: After Éomund leaves play, ready all Rohan characters in play.")
                .WithFlavor("\"You I have not seen before, for you are young, but I have spoken with Éomund your father...\" -Aragorn, The Two Towers")
                .WithInfo(30, 3, Artist.Katherine_Dinger);
            addAttachment("Nor am I a Stranger", 1, Sphere.Spirit, false)
                .WithTraits("Title.")
                .WithTextLine("Attach to a character.")
                .WithTextLine("Attached character gains the Rohan trait.")
                .WithFlavor("\"Nor indeed am I a stranger: for I have been in this land before, more than once, and ridden with the host of the Rohirrim, though under other name and in other guise.\" -Aragorn, The Two Towers")
                .WithInfo(31, 3, Artist.Magali_Villeneuve);
            addAlly("Longbeard Map-Maker", 3, Sphere.Lore, false, 1, 1, 1, 3)
                .WithTraits("Dwarf.")
                .WithTextLine("Action: Spend 1 Lore resource to give Longbeard Map-Maker +1 Willpower until the end of the phase.")
                .WithFlavor("On the table in the light of a big lamp with a red shade he spread a piece of parchment rather like a map. -The Hobbit")
                .WithInfo(32, 3, Artist.Andrew_Silver);
            addAttachment("A Burning Brand", 2, Sphere.Lore, false)
                .WithTraits("Item.")
                .WithKeywords("Restricted.")
                .WithTextLine("Attach to a Lore character. Restricted.")
                .WithTextLine("Response: Exhaust A Burning Brand to cancel a shadow effect just triggered during an attack that attached character is defending.")
                .WithFlavor("\"Keep close to the fire, with your faces outward!\" cried Strider. \"Keep some of the longer sticks ready in your hands.\" -The Fellowship of the Ring")
                .WithTemplate("<p>Attach to a {sphere-character:Lore}. {keyword:Restricted.}</p><p><b>Response:</b> Exhaust {self} to cancel a shadow effect just triggered during an attack that attached character is defending.</p><p class='flavor-text'>&quot;Keep close to the fire, with your faces outward!&quot; cried Strider. &quot;Keep some of the longer sticks ready in your hands.&quot;<br>&ndash;The Fellowship of the Ring</p>")
                .WithErrata()
                .WithInfo(33, 3, Artist.Toni_Justamante_Jacobs);
            addAttachment("Song of Wisdom", 1, Sphere.Neutral, false)
                .WithTraits("Song.")
                .WithTextLine("Attach to a hero.")
                .WithTextLine("Attached hero gains a Lore resource icon.")
                .WithFlavor("It sit beside the fire and think\r\nof all that I have seen,\r\nof meadow-flowers and butterflies\r\nin summers that have been\r\n-The Fellowship of the Ring")
                .WithInfo(34, 3, Artist.Magali_Villeneuve);
            addQuest("Grimbeorn's Quest", "Conflict at the Carrock", 1, 'A', 7)
                .WithIncludedEncounterSets(EncounterSet.JourneyAlongTheAnduin, EncounterSet.Wilderlands)
                .WithTextLine("Setup: Add The Carrock to the staging area. Remove 4 unique Troll cards and 4 copies of the 'Sacked!' card from the encounter deck and set them aside, out of play. Then shuffle 1 'Sacked!' card per player back into the encounter deck.")
                .WithFlavor("While searching for Gollum in the Anduin valley, you recieve word that a group of Trolls have come to the Carrock.")
                .WithOppositeTextLine("Forced: After placing the 7th progress token on Grimbeorn's Quest, The Carrock becomes the active location. Discard the previous active location from play.")
                .WithOppositeFlavor("As this area is under the watch of the Beornings, you seek out their leader, Grimbeorn the Old, and discover he has already set out in a rage. You follow, hoping to find him before he confronts the Trolls.")
                .WithInfo(35, 1, Artist.Igor_Kieryluk);
            addQuest("Against the Trolls", "Conflict at the Carrock", 2, 'A', 1)
                .WithIncludedEncounterSets(EncounterSet.JourneyAlongTheAnduin, EncounterSet.Wilderlands)
                .WithFlavor("You approach the Carrock, and find that the Trolls have been watching you from the top of the rocky river landmark. As you approach, the Trolls close in and attack!")
                .WithOppositeTextLine("When Revealed: Place the unique Troll cards previously set aside into the staging area.")
                .WithOppositeTextLine("Players cannot defeat this stage if there are any Troll enemies in play.")
                .WithInfo(36, 1, Artist.Diego_Gisbert_Llorens);
            addObjectiveAlly("Grimbeorn the Old", "Conflict at the Carrock", 2, 4, 3, 10)                .WithUnique()
                .WithAlternateSlug("Baby-Bjorn-CatC")
                .WithTraits("Ally.")
                .WithTextLine("Grimbeorn the Old does not exhaust to defend against Troll enemies.")
                .WithTextLine("If Grimbeorn the Old has 8 or more resource tokens on him, he joins the first player as an ally.")
                .WithTextLine("Action: Spend 1 Leadership resource to place that resource on Grimbeorn the Old.")
                .WithInfo(37, 1, Artist.Mark_Winters);
            addEnemy("Louis", "Conflict at the Carrock", 34, 2, 4, 2, 10)
                .WithUnique()
                .WithTraits("Troll.")
                .WithTextLine("While Louis is engaged with a player, all Troll enemies gain, \"Forced: After this enemy attacks, the defending player must raise his threat by 3.\"")
                .WithTextLine("Response: After defeating Louis, you may choose and discard 1 \"Sacked!\" card from play.")
                .WithInfo(38, 1, Artist.Brian_Valenzuela);
            addEnemy("Morris", "Conflict at the Carrock", 34, 2, 4, 2, 10)
                .WithUnique()
                .WithTraits("Troll.")
                .WithTextLine("While Morris is engaged with a player, all Troll enemies get +1 Attack.")
                .WithTextLine("Response: After defeating Morris, you may choose and discard 1 'Sacked!' card from play.")
                .WithInfo(39, 1, Artist.Paul_Guzenko);
            addEnemy("Stuart", "Conflict at the Carrock", 34, 2, 4, 2, 10)
                .WithUnique()
                .WithTraits("Troll.")
                .WithTextLine("While Stuart is engaged with a player, all Troll enemies get +1 Defense.")
                .WithTextLine("Response: After defeating Stuart, you may choose and discard 1 'Sacked!' card from play.")
                .WithInfo(40, 1, Artist.Paul_Guzenko);
            addEnemy("Rupert", "Conflict at the Carrock", 34, 2, 4, 2, 10)
                .WithUnique()
                .WithTraits("Troll.")
                .WithTextLine("Forced: After Rupert attacks, shuffle all copies of the 'Sacked!' card from the discard pile back into the encounter deck.")
                .WithTextLine("Response: After defeating Rupert, you may choose and discard 1 'Sacked!' card from play.")
                .WithInfo(41, 1, Artist.Andrew_Silver);
            addEnemy("Muck Adder", "Conflict at the Carrock", 20, 1, 2, 0, 4)
                .WithTraits("Creature.")
                .WithTextLine("Forced: If Muck Adder damages a character, discard that character from play.")
                .WithShadow("Shadow: Defending character gets -1 Defense for the duration of this attack.")
                .WithEasyModeQuantity(2)
                .WithInfo(42, 4, Artist.Joe_Wilson);
            addLocation("The Carrock", "Conflict at the Carrock", 2, 6)
                .WithUnique()
                .WithTraits("Riverland.")
                .WithTextLine("Immune to player card effects.")
                .WithTextLine("Players cannot travel to The Carrock except through quest card effects.While The Carrock is the active location, Troll enemies get +1 Attack and +1 Defense.")
                .WithInfo(43, 1, Artist.Marco_Caradonna);
            addLocation("River Langflood", "Conflict at the Carrock", 2, 3)
                .WithTraits("Riverland.")
                .WithTextLine("While it is in the staging area, River Langflood gets +1 Threat for each Troll enemy in play.")
                .WithEasyModeQuantity(2)
                .WithInfo(44, 4, Artist.Marco_Caradonna);
            addLocation("Bee Pastures", "Conflict at the Carrock", 1, 2)
                .WithTraits("Wilderlands.")
                .WithTextLine("Response: After you travel to Bee Pastures, search the encounter deck and discard pile for Grimbeorn the Old and add him to the staging area. Then, shuffle the encounter deck.")
                .WithInfo(45, 3, Artist.David_Lecossu);
            addLocation("Oak-wood Grove", "Conflict at the Carrock", 2, 1)
                .WithTraits("Forest.")
                .WithTextLine("While Oak-wood Grove is the active location, resource tokens from any sphere may be spent as Leadership resource tokens.")
                .WithInfo(46, 3, Artist.David_Lecossu);
            addTreachery("A Frightened Beast", "Conflict at the Carrock")
                .WithTextLine("When Revealed: Each player raises his threat by the total Threat of all cards in the staging area. Any player may choose to discard from play 1 Creature ally card he controls to cancel this effect.")
                .WithFlavor("Then, one of the ponies took fright at nothing and bolted. -The Hobbit")
                .WithEasyModeQuantity(1)
                .WithInfo(47, 3, Artist.David_A_Nash);
            addTreachery("Sacked!", "Conflict at the Carrock")
                .WithTextLine("When Revealed: Attach to a hero with no 'Sacked!' cards attached controlled by the first player. (Cannot be canceled.) Counts as a condition attachment with the text: 'Attached hero cannot attack, defend, commit to a quest, trigger its effect, or collect resources.'")
                .WithShadow("Shadow: If attacking enemy is a Troll, resolve this card's 'when revealed' effect.")
                .WithEasyModeQuantity(4)
                .WithInfo(48, 5, Artist.Lorraine_Schleter);
            addTreachery("Roasted Slowly", "Conflict at the Carrock")
                .WithTextLine("When Revealed: Destroy all heroes with the card 'Sacked!' attached. Then, shuffle Roasted Slowly back into the encounter deck.")
                .WithShadow("Shadow: If attacking enemy is a Troll, remove 2 damage tokens from it.")
                .WithEasyModeQuantity(0)
                .WithInfo(49, 2, Artist.Diego_Gisbert_Llorens);
        }
    }
}
