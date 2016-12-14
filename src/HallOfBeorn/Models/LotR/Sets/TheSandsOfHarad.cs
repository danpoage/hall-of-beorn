using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace HallOfBeorn.Models.LotR.Sets
{
    public class TheSandsOfHarad : CardSet
    {
        private string setEscape = EncounterSet.EscapeFromUmbar.Name;
        private string setLongArm = EncounterSet.TheLongArmOfMordor.Name;
        private string setMordorOrcs = EncounterSet.MordorOrcs.Name;
        private string setJungle = EncounterSet.JungleForest.Name;
        private string setHaradSoldiers = EncounterSet.HaradSoldiers.Name;
        private string setHaradTerritory = EncounterSet.HaradTerritory.Name;
        private string setCrossing = EncounterSet.DesertCrossing.Name;
        private string setCreatures = EncounterSet.DesertCreatures.Name;

        protected override void Initialize()
        {
            Name = "The Sands of Harad";
            Abbreviation = "TSoH";
            Number = 42;
            SetType = Models.SetType.Deluxe_Expansion;

            addCard(LotRCard.Hero("Gimli", string.Empty, Sphere.Leadership, 11, 2, 2, 2, 5)
                .WithTraits("Dwarf.", "Noble.", "Warrior.")
                .WithKeywords("Sentinel.")
                .WithText("Response: After Gimli is declared as a defender, spend 1 resource from his pool to ready another hero. If that hero is Legolas, he gets +1 Attack until the end of the phase. (Limit once per phase.)")
                .WithFlavor("\"Faithless is he that says farewell when the road darkens...\"\r\n-The Fellowship of the Ring")
                .WithInfo(1, 1, Artist.Owen_William_Weber));
            addCard(LotRCard.Hero("Legolas", string.Empty, Sphere.Spirit, 9, 1, 3, 1, 4)
                .WithTraits("Silvan.", "Noble.", "Scout.")
                .WithKeywords("Ranged.")
                .WithText("Response: After Legolas commits to a quest, discard a card from your hand to ready another hero. If that hero is Gimli, he gets +1 Willpower until the end of the phase. (Limit once per phase.)")
                .WithFlavor("\"I go to find the Sun!\"\r\n-The Fellowship of the Ring")
                .WithInfo(2, 1, Artist.Aleksander_Karcz));
            addCard(LotRCard.Ally("Greenwood Archer", string.Empty, Sphere.Leadership, 2, 0, 2, 0, 1)
                .WithGeneric()
                .WithTraits("Silvan.")
                .WithKeywords("Ranged.")
                .WithText("Response: After Greenwood Archer enters play, ready a hero.")
                .WithFlavor("They dwelt most often by the edges of the woods, from which they could escape at times to hunt...\r\n-The Hobbit")
                .WithInfo(3, 3, Artist.Unknown));
            addCard(LotRCard.Ally("Erebor Guard", string.Empty, Sphere.Spirit, 4, 0, 1, 2, 3)
                .WithGeneric()
                .WithTraits("Dwarf.", "Warrior.")
                .WithKeywords("Sentinel.")
                .WithText("Response: When you play Erebor Guard from your hand, discard the top 2 cards of your deck to reduce its cost by 2.")
                .WithFlavor("...the fortress of the dwarves could not be taken by surprise.\r\n-The Hobbit")
                .WithInfo(4, 3, Artist.Unknown));
            addCard(LotRCard.Ally("Halfling Bounder", string.Empty, Sphere.Lore, 2, 1, 1, 0, 2)
                .WithGeneric()
                .WithTraits("Hobbit.")
                .WithText("While there is a side quest in the victory display, Halfling Bounder gains: \"Response: Discard Halfling Bounder to cancel the 'when revealed' effects of an encounter card that was just revealed from the encounter deck.\"")
                .WithFlavor("\"The Bounders have never been so busy before.\"\r\n-Sam Gamgee, The Fellowship of the Ring")
                .WithInfo(5, 3, Artist.Aleksander_Karcz));
            addCard(LotRCard.Ally("Vigilant Dúnadan", string.Empty, Sphere.Tactics, 4, 1, 3, 2, 3)
                .WithNormalizedTitle("Vigilant Dunadan")
                .WithGeneric()
                .WithTraits("Dúnedain.", "Ranger.")
                .WithText("While there is a side quest in the victory display, Vigilant Dúnadan does not exhaust to defend.")
                .WithFlavor("\"I don't think we've rightly understood till now what they did for us.\"\r\n-Barliman Butterbur, The Return of the King")
                .WithInfo(6, 3, Artist.JB_Casacop));
            addCard(LotRCard.Event("Unlikely Friendship", string.Empty, Sphere.Leadership, 0)
                .WithText("Play only if you control a unique character with the Silvan trait and another unique character with the Dwarf trait.\r\nAction: Draw 1 card and add 1 resource to the resource pool of a hero you control.")
                .WithFlavor("...folk that saw them pass marvelled to see such companions...\r\n-The Return of the King")
                .WithInfo(7, 3, Artist.Aleksander_Karcz));
            addCard(LotRCard.Event("Well Warned", string.Empty, Sphere.Spirit, 0)
                .WithText("Play only if you control a unique character with the Noble trait and another unique character with the Scout trait.\r\nResponse: After a player engages an enemy, reduce his threat by X, where X is that enemy's printed Threat.")
                .WithFlavor("...the Captains of the West were well warned by their scouts...\r\n-The Return of the King")
                .WithInfo(8, 3, Artist.Unknown));
            addCard(LotRCard.Event("Dour-handed", string.Empty, Sphere.Tactics, 1)
                .WithText("Action: Deal X damage to an enemy engaged with you. X is the number of side quests in the victory display.")
                .WithFlavor("...the tides of fate had turned against them and their doom was at hand. -The Return of the King")
                .WithInfo(9, 3, Artist.JB_Casacop));
            addCard(LotRCard.Attachment("Dwarven Shield", string.Empty, Sphere.Leadership, 2)
                .WithGeneric()
                .WithTraits("Item.", "Armor.")
                .WithKeywords("Restricted.")
                .WithText("Attach to a Dwarf hero.\r\nAttached hero gets +1 Defense.\r\nResponse: After attached hero takes damage from an enemy attack, exhaust Dwarven Shield to add 1 resource to attached hero's pool.")
                .WithFlavor("...each of them had also a short broad sword at his side and a round shield slung at his back.\r\n-The Hobbit")
                .WithInfo(10, 3, Artist.Mariusz_Gandzel));
            addCard(LotRCard.Attachment("Mirkwood Long-knife", string.Empty, Sphere.Spirit, 2)
                .WithGeneric()
                .WithTraits("Item.", "Weapon.")
                .WithKeywords("Restricted.")
                .WithText("Attach to a Silvan hero.\r\nAttached hero gets +1 Willpower and +1 Attack.")
                .WithFlavor("Legolas had a bow and a quiver, and at his belt a long white knife.\r\n-The Fellowship of the Ring")
                .WithInfo(11, 3, Artist.Alexandr_Elichev));
            addCard(LotRCard.Attachment("The Road Goes Ever On", string.Empty, Sphere.Lore, 0)
                .WithTraits("Song.")
                .WithText("Attach to a quest card in play.\r\nResponse: When attached quest is defeated, the first player chooses a player. That player searches his deck for a side quest, adds it to his hand, and shuffles his deck.")
                .WithFlavor("\"Now far ahead the Road has gone,\r\nAnd I must follow, if I can...\"\r\n-Frodo Baggins, The Fellowship of the Ring")
                .WithInfo(12, 3, Artist.Unknown));
            addCard(LotRCard.PlayerSideQuest("The Storm Comes", string.Empty, Sphere.Neutral, 0, 5)
                .WithText("Limit 1 copy of The Storm Comes in the victory display.\r\nWhile this quest is in the victory display, the first ally played by each player each round does not require a resource match.")
                .WithFlavor("\"For behold! The storm comes, and now all friends should gather together, lest each singly be destroyed.\"\r\n-Gandalf, The Two Towers")
                .WithVictoryPoints(1)
                .WithInfo(13, 3, Artist.Tomasz_Jedruszek));
            addCard(LotRCard.Objective("\"Seize Them!\"", string.Empty, setEscape)
                .WithText("Forced: After an enemy attacks and destroys a character, remove X progress from the main quest, X is the attacking enemy's Threat.\r\nAt the end of the round, if the main quest has been in play the entire round and there are no progress tokens on it, the players lose the game.")
                .WithInfo(14, 1, Artist.Victor_Manuel_Leza_Moreno));

            addCard(LotRCard.Enemy("Carrion Bird", string.Empty, setCrossing, 40, 2, 2, 1, 3)
                .WithGeneric()
                .WithTraits("Creature.")
                .WithText("Carrior Birds gets -1 engagement cost for each damaged character in play.\r\nForced: After Carrion Bird engages you, discard a damaged character you control.")
                .WithInfo(24, 2, Artist.Dimitri_Bielak));
            addCard(LotRCard.Location("Burnt Sands", string.Empty, setCrossing, 2, 3)
                .WithTraits("Desert.")
                .WithText("While the temperature is 40 or higher, Burnt Sands gets +2 Threat.\r\nForced: After Burnt Sands becomes the active location, increase the temperature by 2.")
                .WithFlavor("...all seemed ruinous and dead, a desert burned and choked. -The Return of the King")
                .WithInfo(25, 4, Artist.Katy_Grierson));

            addCard(LotRCard.ObjectiveHero("Kahliel", setLongArm, 2, 2, 2, 3)
                .WithTraits("Harad.", "Noble.")
                .WithText("Response: At the beginning of the planning phase, add 1 resource to a hero's pool.\r\nIf Kahliel leaves play, you are eliminated from the game.")
                .WithInfo(31, 1, Artist.David_A_Nash));
            addCard(LotRCard.ObjectiveHero("Firyal", setLongArm, 3, 1, 2, 3)
                .WithTraits("Harad.", "Scout.")
                .WithText("Response: After Firyal commits to a quest, look at the top of the encounter deck. Then, you may discard that card.\r\nIf Firyal leaves play, you are eliminated from the game.")
                .WithInfo(32, 1, Artist.Tawny_Fritzinger));
            addCard(LotRCard.ObjectiveHero("Yazan", setLongArm, 2, 3, 1, 3)
                .WithTraits("Harad.", "Ranger.")
                .WithKeywords("Ranged.")
                .WithText("Response: After Yazan is declared as an attacker, deal 1 damage to a non-unique enemy in play. (Limit once per phase.)\r\nIf Yazan leaves play, you are eliminated from the game.")
                .WithInfo(33, 1, Artist.David_A_Nash));
            addCard(LotRCard.ObjectiveHero("Jubayr", setLongArm, 1, 2, 3, 3)
                .WithTraits("Harad.", "Warrior.")
                .WithKeywords("Sentinel.")
                .WithText("Response: After Jubayr is declared as a defender, discard 1 facedown shadow card from a non-unique enemy. (Limit once per phase.)\r\nIf Jubayr leaves play, you are eliminated from the game.")
                .WithInfo(34, 1, Artist.Unknown));

            addCard(LotRCard.Enemy("Uruk Chieftain", string.Empty, setMordorOrcs, 50, 4, 5, 3, 6)
                .WithUnique()
                .WithTraits("Orc.", "Uruk.")
                .WithText("Cannot have player card attachments or be optionally engaged.\r\nWhile the engaged player is engaged with another Orc enemy, ~Uruk Chieftain cannot take damage.\r\nForced: At the end of the encounter phase, ~Uruk Chieftain engages the player engaged with the most non-unique Orc enemies.")
                .WithInfo(61, 1, Artist.Sam_Lamont));

            addCard(LotRCard.Quest("Beasts of Legend", string.Empty, 1, 3, setCrossing, 16)
                .WithFlavor("You have wandered through the trackless desert and discovered the legendary nesting grounds of the wild Were-worms. The beasts rear up and circle to attack. You must drive them off or meet your end upon the desert sands.")
                .WithText("When Revealed: Increase the temperature by 2. Each player searches the encounter deck, discard pile, and victory display for a Were-worm and adds it to the staging area, if able. Shuffle the encounter deck.")
                .WithOppositeText("During the quest phase, add X [Threat] to the total [Threat] in the staging area, where X is the tens digit of the temperature.\r\nForced: At the end of the round, increase the temperature by 4.\r\nWhile at least 1 Were-worm is in play, the players cannot defeat this stage. If the players defeat this stage, they win the game. If the temperature is 60 or higher, the players lose the game.")
                .WithInfo(70, 1, Artist.Dimitri_Bielak));
        }
    }
}