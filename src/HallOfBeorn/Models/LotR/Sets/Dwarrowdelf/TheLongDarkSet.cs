/* Generated CardSet class: The Long Dark */

using System;

namespace HallOfBeorn.Models.LotR.Sets.Dwarrowdelf
{
    public class TheLongDarkSet : CardSet
    {
        protected override void Initialize()
        {
            Name = "The Long Dark";
            Abbreviation = "TLD";
            Number = 12;
            SetType = Models.SetType.Adventure_Pack;
            Cycle = "Dwarrowdelf";

            addHero("Háma", 9, Sphere.Tactics, 1, 3, 1, 4)
                .WithTraits("Rohan.", "Warrior.")
                .WithTextLine("Response: After Háma is declared as an attacker, return a Tactics event from your discard pile to your hand. Then, choose and discard 1 card from your hand. (Limit 3 times per game for the group.)")
                .WithFlavorLine("\"Yet in doubt a man of worth will trust to his own wisdom.\"")
                .WithFlavorLine("-The Two Towers")
                .WithErrata(1)
                .WithCommunityVersion("RiddermarkLord/Hama-Tactics-Hero-1")
                .WithInfo(76, 1, Artist.Magali_Villeneuve);
            addAlly("Erestor", 4, Sphere.Leadership, true, 2, 0, 1, 3)
                .WithTraits("Noldor.")
                .WithTextLine("Action: Choose and discard 1 card from your hand to draw 1 card. (Limit once per round.)")
                .WithFlavorLine("Beside Glorfindel there were several other counsellors of Elrond's household, of whom Erestor was the chief...")
                .WithFlavorLine("-The Fellowship of the Ring")
                .WithCommunityVersion("RiddermarkLord/Erestor-MotK-Leadership-Hero")
                .WithInfo(77, 3, Artist.Magali_Villeneuve);
            addEvent("Fresh Tracks", 1, Sphere.Leadership)
                .WithTextLine("Response: After an enemy is added to the staging area, deal 1 damage to that enemy. Players ignore that enemy while making engagement checks this round.")
                .WithInfo(78, 3, Artist.Garret_DeChellis);
            addAlly("Erebor Battle Master", 3, Sphere.Tactics, false, 0, 1, 1, 2)
                .WithTraits("Dwarf.", "Warrior.")
                .WithTextLine("Erebor Battle Master gets +1 Attack for each other Dwarf ally you control. (Limit +4 Attack.)")
                .WithErrata(2)
                .WithInfo(79, 3, Artist.Rafal_Hrynkiewicz);
            addAttachment("Ring Mail", 2, Sphere.Tactics, false)
                .WithTraits("Item.", "Armor.")
                .WithKeywords("Restricted.")
                .WithTextLine("Attach to a Dwarf or Hobbit character. Restricted.")
                .WithTextLine("Attached character gets +1 hit point and +1 Defense.")
                .WithFlavorLine("\"And all the arrows of all the hunters in the world would be in vain...")
                .WithFlavorLine("-Gimli, The Fellowship of the Ring")
                .WithInfo(80, 3, Artist.Magali_Villeneuve);
            addEvent("Out of Sight", 5, Sphere.Spirit)
                .WithKeywords("Secrecy 3.")
                .WithTextLine("Secrecy 3.")
                .WithTextLine("Action: Enemies engaged with you cannot attack you this phase.")
                .WithErrata(1)
                .WithInfo(81, 3, Artist.Ilich_Henriquez);
            addAttachment("Ever My Heart Rises", 0, Sphere.Spirit, false)
                .WithTraits("Condition.")
                .WithTextLine("Attach to a Dwarf character.")
                .WithTextLine("Response: After you travel to a Mountain or Underground location, ready attached character and reduce your threat by 1.")
                .WithFlavorLine("'This is more to my liking,' said the dwarf, stomping on the stones. 'Ever my heart rises as we draw near the mountains.' -The Two Towers")
                .WithInfo(82, 3, Artist.Carolina_Eade);
            addAlly("Warden of Healing", 2, Sphere.Lore, false, 1, 0, 1, 1)
                .WithTraits("Gondor.", "Healer.")
                .WithTextLine("Action: Exhaust Warden of Healing to heal 1 damage on up to 2 different characters. Then, you may pay 2 Lore resources to ready Warden of Healing.")
                .WithFlavorLine("\"But for long years we healers have only sought to patch the rents made by the men of swords.\" -Return of the King")
                .WithInfo(83, 3, Artist.Paulo_Puggioni);
            addEvent("Word of Command", 1, Sphere.Lore)
                .WithTextLine("Action: Exhaust an Istari character to search your deck for 1 card and add it to your hand. Shuffle your deck.")
                .WithFlavorLine("\"Picking up a faggot he held it aloft for a moment, and then with a word of command, naur an edraith ammen! he thrust the end of his staff into the midst of it. At once a great spout of green and blue flame sprang out, and the wood flared and sputtered.\" -The Fellowship of the Ring")
                .WithInfo(84, 3, Artist.Magali_Villeneuve);
            addAttachment("Love of Tales", 0, Sphere.Lore, false)
                .WithTraits("Condition.")
                .WithTextLine("Attach to a Lore hero. Limit 1 per hero.")
                .WithTextLine("Response: After a Song card is played, exhaust Love of Tales to add 1 resource to attached hero's resource pool.")
                .WithFlavorLine("\"I listened because I couldn't help myself, if you know what I mean. Lor bless me, sir, but I do love tales of that sort.\"")
                .WithFlavorLine("-Sam Gamgee, The Fellowship of the Ring")
                .WithErrata(1)
                .WithInfo(85, 3, Artist.Winona_Nelson);
            addQuest("Journey in the Black Pit", "The Long Dark", 1, 'A', 13)
                .WithTextLine("Setup: The first player attaches ~Cave Torch to a hero of his choice.")
                .WithFlavorLine("Your party is scouting the Mines of Moria, searching for signs of Orcs. Dark tunnels and twisting passages spread out in all directions, a labyrinthine maze that you could wander in forever if you take the wrong path.")
                .WithOppositeTextLine("When Revealed: Discard cards from the top of the encounter deck until you discard X locations, where X is one less than the number of players in the game (minimum 1). Add those locations to the staging area, and shuffle the other discarded cards back into the encounter deck.")
                .WithOppositeTextLine("Each location gets +1 threat. If the players quest unsuccessfully, trigger all \"Lost:\" effects in play.")
                .WithIncludedEncounterSets(EncounterSet.DeepsOfMoria, EncounterSet.TwistsAndTurns)
                .WithInfo(86, 1, Artist.David_A_Nash);
            addQuest("Continuing Eastward", "The Long Dark", 2, 'A', 17)
                .WithFlavorLine("Time carries no weight in the darkness, and the hours creep by with no end in sight. The number of Orcs in the mines increase as you head toward the East-gate, but there appears to be little real organization within their ranks. You press onward!")
                .WithOppositeTextLine("When Revealed: The first player makes a locate test. If this test is failed, reveal cards from the encounter deck equal to the number of players in the game and add them to the staging area. Then, trigger all \"Lost:\" effects in play.")
                .WithOppositeTextLine("If the players quest unsuccessfully, trigger all \"Lost:\" effects in play.")
                .WithOppositeTextLine("If the players defeat this stage, they have won the game.")
                .WithIncludedEncounterSets(EncounterSet.DeepsOfMoria, EncounterSet.TwistsAndTurns)
                .WithInfo(87, 1, Artist.David_A_Nash);
            addObjective("Durin's Greaves", "The Long Dark")
                .WithUnique()
                .WithTraits("Artifact.", "Armour.")
                .WithTextLine("When Revealed: The first player attaches Durin's Greaves to a hero of his choice as an attachment.")
                .WithTextLine("")
                .WithTextLine("Attached hero gets +1 Defense.")
                .WithInfo(88, 1, Artist.Sara_Biddle);
            addLocation("Abandoned Mine", "The Long Dark", 3, 3)
                .WithTraits("Underground.", "Dark.")
                .WithTextLine("Lost: Return the top 2 Goblin enemies in the encounter discard pile to the staging area, if able.")
                .WithFlavorLine("\"The wealth of Moria was not in gold and jewels, the toys of the Dwarves; nor in iron, their servant.\"")
                .WithFlavorLine("-Gandalf, The Fellowship of the Ring")
                .WithInfo(89, 3, Artist.Paulo_Puggioni);
            addLocation("Dwarven Forge", "The Long Dark", 2, 4)
                .WithTraits("Underground.", "Dark.")
                .WithTextLine("Lost: Each player must choose and discard 1 card from his hand.")
                .WithFlavorLine("There hammer on the anvil smote,")
                .WithFlavorLine("There chisel clove, and graver wrote;")
                .WithFlavorLine("There forged was blade, and bount was hilt...")
                .WithFlavorLine("-The Fellowship of the Ring")
                .WithInfo(90, 2, Artist.Cristi_Balanescu);
            addLocation("Silent Caverns", "The Long Dark", 1, 3)
                .WithTraits("Underground.")
                .WithTextLine("Lost: Exhaust all characters.")
                .WithInfo(91, 2, Artist.Trudi_Castle);
            addLocation("Twisting Passage", "The Long Dark", 3, 5)
                .WithTraits("Underground.", "Dark.")
                .WithTextLine("Forced: Before placing progress tokens on Twisting Passage, the first player must make a locate test. If this test is failed, do not place any progress tokens on Twisting Passage and trigger all 'Lost:' effects in play.")
                .WithInfo(92, 2, Artist.Ben_Zweifel);
            addTreachery("Fatigue", "The Long Dark")
                .WithTextLine("When Revealed: Each player must exhaust 1 character he controls, if able. Then, if any player controls no unexhausted characters, Fatigue gains surge.")
                .WithShadow("Shadow: The defending player must exhaust 1 character he controls, if able.")
                .WithInfo(93, 2, Artist.Charles_Urbach);
            addTreachery("Foul Air", "The Long Dark")
                .WithTextLine("When Revealed: The first player makes a locate test. If this test is failed, deal 2 damage to all characters and trigger all 'Lost:' effects in play.")
                .WithFlavorLine("\"...I do not like the smell of the left-hand way: there is a foul air down there, or I am not guide.\"")
                .WithFlavorLine("-Gandalf, The Fellowship of the Ring")
                .WithEasyModeQuantity(1)
                .WithInfo(94, 4, Artist.Jasper_Sandner);
            addTreachery("Gathering Ground", "The Long Dark")
                .WithTextLine("When Revealed: Attach this card to a location in the staging area with the highest combined threat and remaining quest points. (Counts as a Condition attachment with the text: 'Each enemy revealed from the encounter deck gains surge.')")
                .WithEasyModeQuantity(0)
                .WithInfo(95, 1, Artist.Jason_Juta);
            addTreachery("Vast and Intricate", "The Long Dark")
                .WithTextLine("When Revealed: The first player makes a locate test. If this test is failed, raise each player's threat by 7, remove all progress tokens from play, and trigger all 'Lost:' effects in play.")
                .WithFlavorLine("The Mines of Moria were vast and intricate beyond the imagination of Gimli, Glóin's son, dwarf of the mountain-race though he was.")
                .WithFlavorLine("-The Fellowship of the Ring")
                .WithEasyModeQuantity(1)
                .WithInfo(96, 2, Artist.Eric_Braddock);
            addEnemy("Cave Spider", "The Long Dark", 31, 3, 2, 1, 4)
                .WithTraits("Spider.", "Creature.")
                .WithTextLine("When Revealed: The first player draws 1 card. Then, that player must choose and discard 4 cards from his hand, if able.")
                .WithTextLine("Forced: After ~Cave ~Spider engages a player, that player must choose and discard 1 card from his hand, if able.")
                .WithInfo(97, 3, Artist.Allison_Theus);
            addEnemy("Goblin Sneak", "The Long Dark", 15, 2, 1, 1, 2)
                .WithTraits("Goblin.", "Orc.")
                .WithTextLine("Forced: After Goblin Sneak engages a player, discard the top card of the encounter deck. If it is a treachery card, Goblin Sneak engages the next player, if able.")
                .WithShadow("Shadow: Add Goblin Sneak to the staging area.")
                .WithInfo(98, 4, Artist.Timo_Karhula);
            addEnemy("Goblin Warlord", "The Long Dark", 39, 4, 3, 3, 5)
                .WithTraits("Goblin.", "Orc.")
                .WithTextLine("Lost: Each player must choose and discard 1 ally he controls from play, if able.")
                .WithShadow("Shadow: Trigger all 'Lost:' effects in play.")
                .WithEasyModeQuantity(0)
                .WithInfo(99, 1, Artist.Matthew_Starbuck);
            addEnemy("Rock Adder", "The Long Dark", 20, 1, 3, 0, 3)
                .WithTraits("Creature.")
                .WithTextLine("Rock Adder cannot be attacked unless it has dealt at least 1 damage this round.")
                .WithShadow("Shadow: If this attack is undefended, the defending player must discard 1 character he controls from play.")
                .WithInfo(100, 3, Artist.Allison_Theus);
        }
    }
}
