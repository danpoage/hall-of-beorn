using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace HallOfBeorn.Models.LotR.Sets.AngmarAwakened
{
    public class TheWastesOfEriador : CardSet
    {
        protected override void Initialize()
        {
            Name = "The Wastes of Eriador";
            Abbreviation = "TWoE";
            Number = 30;
            SetType = Models.SetType.Adventure_Pack;
            Cycle = "Angmar Awakened";

            Cards.Add(LotRCard.Hero("Merry", "E4DD7F3E-0CD2-4330-A7D4-80487202C437", Sphere.Spirit, 6, 2, 1, 1, 2)
                .WithTraits("Hobbit.")
                .WithText("Response: After an enemy is revealed from the top of the encounter deck, exhaust Merry to reduce your threat by that enemy's Threat.")
                .WithFlavor("\"We have come a long way with you and been through some stiff times. We want to go on.\" —The Fellowship of the Ring")
                .WithTemplate("<b>Response:</b> After an enemy is revealed from the top of the encounter deck, exhaust {self} to reduce your threat by that enemy's {Threat}.</p><p class='flavor-text'>&quot;We have come a long way with you and been through some stiff times. We want to go on.&quot;<br/>&ndash;The Fellowship of the Ring</p>")
                .WithInfo(1, 1, Artist.Romana_Kendelic));
            Cards.Add(LotRCard.Ally("Ingold", Sphere.Leadership, 3, 0, 1, 1, 3)
                .WithUnique()
                .WithTraits("Gondor.")
                .WithText("Ingold gets +1 Willpower for each hero you control with at least 1 resource in its resource pool.")
                .WithFlavor("\"We wish for no strangers in the land at this time, unless they be mighty men of arms in whose faith and help we can trust.\" —The Return of the King") 
                .WithInfo(2, 3, Artist.Tiziano_Baracchi));
            Cards.Add(LotRCard.Event("Rallying Cry", "", Sphere.Leadership, 2)
                .WithText("Response: After an ally leaves play, add it to its owner’s hand instead of placing it in the discard pile.\r\nValour Action: Until the end of the phase, add each ally that leaves play to its owner's hand instead of placing it in the discard pile.")
                .WithTemplate("<p><b>Response:</b> After an ally leaves play, add it to its owner's hand instead of placing it in the discard pile.</p><p><b>Valour Action:</b> Until the end of the phase, add each ally that leaves play to its owner's hand instead of placing it in the discard pile.</p><p class='flavor-text'>He let blow the horns to rally all men to his banner that could come thither...<br/>&ndash;The Return of the King</p>")
                .WithInfo(3, 3, Artist.Lukasz_Jaskolski));
            Cards.Add(LotRCard.Ally("Honour Guard", Sphere.Tactics, 2, 0, 0, 1, 3)
                .WithTraits("Gondor.", "Warrior.")
                .WithText("Response: Exhaust Honour Guard to cancel 1 point of damage just dealt to a character.\r\nValour Response: Exhaust and discard Honour Guard to cancel up to 5 damage just dealt to a character.")
                .WithInfo(4, 3, Artist.Owen_William_Weber));
            Cards.Add(LotRCard.Attachment("Raven-winged Helm", "", Sphere.Tactics, 2)
                .WithTraits("Item.", "Armor.")
                .WithText("Attach to a hero with sentinel. Limit 1 per hero.\r\nResponse: Exhaust Raven-winged Helm to prevent 1 point of damage just dealt to attached character.")
                .WithFlavor("He had a small hauberk, its rings of forged of steel, maybe, yet black as jet; and a high-crowned helm with small raven-wings on either side, set with a silver star in the centre of the circlet. -The Return of the King")
                .WithTemplate("<p>Attach a {keyword-hero:Sentinel.} Limit 1 per hero.</p><p><b>Response:</b> Exhaust {self} to prevent 1 point of damage just dealt to attached character.</p><p class='flavor-text'>He had a small hauberk, its rings of forged of steel, maybe, yet black as jet; and a high-crowned helm with small raven-wings on either side, set with a silver star in the centre of the circlet.<br/>&ndash;The Return of the King<p>")
                .WithInfo(5, 3, Artist.Blake_Henriksen));
            Cards.Add(LotRCard.Ally("Curious Brandybuck", Sphere.Spirit, 2, 2, 0, 0, 2)
                .WithTraits("Hobbit.")
                .WithText("Forced: After the active location is explored, place Curious Brandybuck on the bottom of its owner's deck.\r\nResponse: After you travel to a location, put Curious Brandybuck into play from your hand, under any player's control.") 
                .WithInfo(6, 3, Artist.Matthew_Starbuck));
            Cards.Add(LotRCard.Attachment("Hobbit Pony", "", Sphere.Spirit, 0)
                .WithTraits("Mount.")
                .WithKeywords("Restricted.")
                .WithText("Attach to a Hobbit hero.\r\nQuest Action: If attached hero is not committed to the quest, exhaust Hobbit Pony and attached hero to commit attached hero to the quest.")
                .WithFlavor("He was riding a pony, and a scarf was swathed round his neck and over his chin to keep out the fog. —The Fellowship of the Ring") 
                .WithInfo(7, 3, Artist.Eva_Maria_Toker));
            Cards.Add(LotRCard.Ally("East Road Ranger", Sphere.Lore, 3, 1, 2, 1, 3)
                .WithTraits("Dúnedain.", "Scout.")
                .WithText("East Road Ranger gets +2 Willpower while committed to a side quest.")
                .WithFlavor("\"If you bring a Ranger with you, it is well to pay attention to him...\" -Gandalf, the Fellowship of the Ring")
                .WithTemplate("<p>{self} gets +2 {willpower} while committed to a side quest.</p><p class='flavor-text'>&quot;If you bring a Ranger with you, it is well to pay attention to him...&quot;<br/>&ndash;Gandalf, the Fellowship of the Ring</p>")
                .WithInfo(8, 3, Artist.Beth_Sobel));
            Cards.Add(LotRCard.PlayerSideQuest("Scout Ahead", "", Sphere.Lore, 0, 4)
                .WithText("Limit 1 per deck.\r\nResponse: When this stage is defeated, the first player searches the top X cards of the encounter deck for 1 non-objective card worth no victory points and adds it to the victory display. Put the remaining cards back in any order. X is the number of players in the game plus 4.")
                .WithFlavor("Strider made them take cover in a thicket at the side of the Road, while he went forward to explore. -The Fellowship of the Ring ")
                .WithInfo(9, 3, Artist.Tomasz_Jedruszek));
            Cards.Add(LotRCard.Ally("Ranger of Cardolan", Sphere.Neutral, 4, 2, 2, 2, 3)
                .WithTraits("Dúnedain.", "Ranger.")
                .WithText("Response: After you engage an enemy, if you control at least 1 Dúnedain hero, spend 1 resource to put ~Ranger of Cardolan into play from your hand, under your control. At the end of the round, if ~Ranger of Cardolan is still in play, shuffle it into its owner's deck.")
                .WithInfo(10, 3, Artist.Lukasz_Jaskolski));
            Cards.Add(LotRCard.Objective("Daybreak", "", "The Wastes of Eriador")
                .WithTraits("Time.")
                .WithText("It is Day. Enemies do not make engagement checks.\r\nForced: When it becomes Day, return each enemy in play to the staging area.\r\nForced: At the end of the round, flip this objective.")
                .WithInfo(11, 1, Artist.Wibben));
            Cards.Add(LotRCard.Objective("Nightfall", "", "The Wastes of Eriador")
                .WithTraits("Time.")
                .WithText("It is ~Night. Progress cannot be placed quest cards. Encounter card effects cannot be canceled.\r\nForced: When it becomes ~Night, reveal an encounter card.\r\nForced: At the end of the round, flip this objective.")
                .WithInfo(12, 1, Artist.Wibben));
            Cards.Add(LotRCard.Quest("Across the Wastes", 1, "The Wastes of Eriador", 20)
                .WithText("Setup: Set Pack Leader aside, out of play. Make Shrouded ~Hills the active location. Add the Time objective to the staging area with Daybreak faceup. The first player takes control of Amarthiúl. Shuffle the encounter deck. Reveal 1 card from the encounter deck per player.")
                .WithFlavor("Following the surprise attack on Fornost, you have agreed to help the Ranger, Amarthiúl, track the villains who captured his friend, Iârion.")
                .WithOppositeText("While it is Day, each hero gets +1 Willpower.\r\nForced: When it becomes ~Night, raise each player's threat by 1.")
                .WithOppositeFlavor("Your enemies' tracks lead you across the North Downs towards Angmar. In the barren lands between you and that dread realm, the nights are black and bitter cold, but it is the howling of Wargs that gives you chills.")
                .WithIncludedEncounterSets(EncounterSet.EriadorWilds, EncounterSet.FoulWeather)
                .WithInfo(13, 1, Artist.Ilich_Henriquez));
            Cards.Add(LotRCard.Quest("Howling at Night", 2, "The Wastes of Eriador", 15)
                .WithText("When Revealed: Shuffle the encounter discard pile into the encounter deck. Discard cards from the top of the encounter deck until X Warg enemies are discarded. X is the number of players in the game. Add each discarded enemy to the staging area.")
                .WithFlavor("Wargs have pursued you into the wastelands! They hound your every step, slowing your progress by day and attacking you when the sun has set.")
                .WithOppositeText("Forced: When it becomes Day, each player draws 1 card.\r\nForced: When it becomes ~Night, discard 1 non-objective ally from play (discard 2 non-objective allies instead if there are 3 or more players in the game).")
                .WithOppositeFlavor("Each night, another member of your company is caught at the edge of the firelight and dragged away. The sounds of snarling and screaming echo into the darkness.")
                .WithIncludedEncounterSets(EncounterSet.EriadorWilds, EncounterSet.FoulWeather)
                .WithInfo(14, 1, Artist.Aleksander_Karcz));
            Cards.Add(LotRCard.Quest("Battle with the Pack", 3, "The Wastes of Eriador", 5)
                .WithText("When Revealed: Flip the Time objective to Nightfall. Add Pack Leader to the staging area. Shuffle the encounter discard pile into the encounter deck. Discard cards from the top of the encounter deck until X Warg enemies are discarded. X is 1 less than the number of players in the game. Add each discarded enemy to the staging area.")
                .WithFlavor("You cannot go on like this. You must do something to discourage the Wargs from pursuing you further.")
                .WithOppositeText("Pack Leader cannot take damage unless there are at least 5 progress tokens on this stage.\r\nForced: When it becomes Day, discard all progress from this stage.\r\nThe players cannot defeat this stage while Pack Leader is in play. If Pack Leader is destroyed, the players win the game.")
                .WithOppositeFlavor("If you can defeat the alpha mail, that will scatter the pack...")
                .WithIncludedEncounterSets(EncounterSet.EriadorWilds, EncounterSet.FoulWeather)
                .WithInfo(15, 1, Artist.Lukasz_Jaskolski));
            Cards.Add(LotRCard.ObjectiveAlly("Amarthiúl", "", "The Wastes of Eriador", 1, 3, 3, 3)
                .WithUnique()
                .WithTraits("Dúnedain.", "Ranger.", "Warrior.")
                .WithText("Response: After an enemy engages a player, give control of Amarthiúl to that player.\r\nIf Amarthiúl leaves play, the players lose the game.")
                .WithInfo(16, 1, Artist.Tomasz_Jedruszek));
            Cards.Add(LotRCard.Enemy("Pack Leader", "", "The Wastes of Eriador", 1, 4, 5, 4, 8)
                .WithUnique()
                .WithTraits("Creature.", "Warg.")
                .WithText("Cannot have attachments.\r\nCannot be optionally engaged.\r\nForced: After Pack Leader engages you, exhaust a character you control for each Warg enemy engaged with you.")
                .WithVictoryPoints(3)
                .WithInfo(17, 1, Artist.Piya_Wannachaiwong));
            Cards.Add(LotRCard.Enemy("Northern Warg", "", "The Wastes of Eriador", 30, 2, 3, 1, 4)
                .WithTraits("Creature.", "Warg.")
                .WithText("When Revealed: Each Warg enemy gets +1 Threat until the end of the phase.")
                .WithShadow("Shadow: After this attack, attacking enemy engages the next player, then makes an immediate attack (deal a new shadow card for that attack).")
                .WithEasyModeQuantity(3)
                .WithInfo(18, 4, Artist.Rick_Price));
            Cards.Add(LotRCard.Enemy("Blood-thirsty Warg", "", "The Wastes of Eriador", 35, 2, 4, 2, 5)
                .WithTraits("Creature.", "Warg.")
                .WithText("While Blood-thirsty ~Warg is in the staging area, it gains: \"Forced: When it becomes ~Night, Blood-thirsty ~Warg engages the first player and makes an immediate attack.\"")
                .WithFlavor("The wold snarled and sprang towards them with a great leap.\r\n-The Fellowship of the Ring")
                .WithEasyModeQuantity(1)
                .WithInfo(19, 2, Artist.Crystal_Sully));
            Cards.Add(LotRCard.Enemy("Hunting Pack", "", "The Wastes of Eriador", 40, 3, 6, 3, 6)
                .WithTraits("Creature.", "Warg.")
                .WithText("Cannot have attachments.\r\nWhile a player is making an engagement check against Hunting Pack, it gets -1 engagement cost for each damaged character that player controls.")
                .WithFlavor("\"...who now will wish to journey south by night with the wild wolves on his tail?\" -Gandalf, The Fellowship of the Ring")
                .WithEasyModeQuantity(1)
                .WithInfo(20, 2, Artist.Crystal_Sully));
            Cards.Add(LotRCard.Enemy("White Warg", "", "The Wastes of Eriador", 20, 2, 2, 3, 3)
                .WithTraits("Creature.", "Warg.")
                .WithText("Forced: After White ~Warg engages you, deal 1 damage to a character you control (2 damage instead if it is ~Night).")
                .WithShadow("Shadow: If it is ~Night, attacking enemy makes an additional attack after this one.")
                .WithInfo(21, 3, Artist.Preston_Stone));
            Cards.Add(LotRCard.Enemy("Wolf of Angmar", "", "The Wastes of Eriador", 25, 1, 2, 1, 3)
                .WithTraits("Creature.", "Warg.")
                .WithKeywords("Surge.")
                .WithText("While it is ~Night, ~Wolf of ~Angmar gets +2 Attack.")
                .WithShadow("Shadow: Attacking enemy gets +1 Attack (+2 Attack instead if it is ~Night).")
                .WithEasyModeQuantity(2)
                .WithInfo(22, 3, Artist.Crystal_Sully));
            Cards.Add(LotRCard.Location("Eriador Wastes", "", "The Wastes of Eriador", 3, 5)
                .WithTraits("Arnor.", "Plains.")
                .WithText("While Eriador Wastes is in the staging area, no more than 5 progress can be placed on the current quest each round.\r\nTravel: The first player engages a Warg enemy in the staging area and deals it a shadow card.")
                .WithFlavor("\"...the long leagues of Eriador still lie before us.\" -Aragorn, The Fellowship of the Ring")
                .WithInfo(23, 2, Artist.Dawn_Carlos));
            Cards.Add(LotRCard.Location("Warg's Den", "", "The Wastes of Eriador", 4, 1)
                .WithTraits("Arnor.")
                .WithText("Immune to player card effects.\r\nTravel: The first player searches the encounter deck and discard pile for a Warg enemy, reveals it, and puts it into play engages with him. Shuffle the encounter deck.")
                .WithFlavor("The howling of the wolves was now all around them... -The Fellowship of the Ring")
                .WithEasyModeQuantity(1)
                .WithInfo(24, 2, Artist.Leonid_Kozienko));
            Cards.Add(LotRCard.Location("North Downs", "", "The Wastes of Eriador", 1, 4)
                .WithTraits("Arnor.", "Hills.")
                .WithText("While it is ~Night, North ~Downs gets +2 Threat.")
                .WithShadow("Shadow: Attacking enemy gets +1 Attack. If this attack destroys a character, remove all progress from the current quest.")
                .WithInfo(25, 3, Artist.Michael_Rasmussen));
            Cards.Add(LotRCard.Treachery("Sudden Darkness", "", "The Wastes of Eriador")
                .WithTraits("Weather.")
                .WithText("When Revealed: If it is ~Night, raise each player's threat by 4. If it is Day, flip the Time objective to Nightfall.")
                .WithShadow("Shadow: Put the topmost Warg enemy from the discard pile into play engaged with you and deal it a shadow card.")
                .WithEasyModeQuantity(1)
                .WithInfo(26, 2, Artist.Tomasz_Jedruszek));
            Cards.Add(LotRCard.Treachery("Predatory Wolves", "", "The Wastes of Eriador")
                .WithText("When Revealed: Each player must choose: either discard the highest cost ally he controls, or search the encounter deck and discard pile for a Warg enemy, reveal it, and add it to the staging area. Shuffle the encounter deck.")
                .WithShadow("Shadow: Exhaust a character you control.")
                .WithEasyModeQuantity(2)
                .WithInfo(27, 3, Artist.Lukasz_Jaskolski));
        }
    }
}