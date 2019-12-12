/* Generated CardSet class: Across the Ettenmoors */

using System;

namespace HallOfBeorn.Models.LotR.Sets.AngmarAwakened
{
    public class AcrossTheEttenmoorsSet : CardSet
    {
        protected override void Initialize()
        {
            Name = "Across the Ettenmoors";
            Abbreviation = "AtE";
            Number = 32;
            SetType = Models.SetType.Adventure_Pack;
            Cycle = "Angmar Awakened";

            addHero("Dori", 10, Sphere.Tactics, 1, 2, 2, 5)
                .WithTraits("Dwarf.")
                .WithKeywords("Sentinel.")
                .WithTextLine("Sentinel.")
                .WithTextLine("Response: After another hero is declared as a defender, exhaust Dori to add his Defense to the defending hero's Defense for this attack.")
                .WithFlavorLine("Dori was really a decent fellow in spite of his grumbling.")
                .WithFlavorLine("-The Hobbit")
                .WithInfo(54, 1, Artist.Sebastian_Giacobino);
            addAttachment("Ranger Provisions", 1, Sphere.Leadership, false)
                .WithTraits("Item.")
                .WithTextLine("Attach to a location. Limit 1 per location.")
                .WithTextLine("Response: After attached location is explored, the first player adds 1 resource to each of his heroes' resource pools.")
                .WithFlavorLine("\"Rangers have been here lately. It is they who left the firewood behind.\"")
                .WithFlavorLine("-Aragorn, The Fellowship of the Ring")
                .WithInfo(55, 3, Artist.Drazenka_Kimpel);
            addEvent("Dúnedain Message", 1, Sphere.Leadership)
                .WithTraits("Signal.")
                .WithTextLine("Action: Search your deck for a side quest and add it to your hand. Shuffle your deck.")
                .WithFlavorLine("\"I called for the help of the Dúnedain, and their watch was doubled...\"")
                .WithFlavorLine("-Gandalf, The Fellowship of the Ring")
                .WithInfo(56, 3, Artist.Sara_Biddle);
            addAlly("Longbeard Sentry", 3, Sphere.Tactics, false, 0, 1, 2, 3)
                .WithTraits("Dwarf.", "Warrior.")
                .WithTextLine("Action: Discard 2 cards from the top of your deck to give Longbeard Sentry sentinel and +1 Defense until the end of the phase. (Limit once per phase.)")
                .WithFlavorLine("\"...many of them have had experience in the dreadful dwarf and goblin wars, of which you have no doubt heard.\"")
                .WithFlavorLine("-Bilbo Baggins, The Hobbit")
                .WithInfo(57, 3, Artist.Michele_Frigo);
            addPlayerSideQuest("Delay the Enemy", 0, Sphere.Tactics, 8)
                .WithKeywords("Battle.")
                .WithTextLine("Limit 1 per deck.")
                .WithTextLine("Battle.")
                .WithTextLine("Response: When this stage is defeated, each player may choose and discard a non-unique enemy engaged with him.")
                .WithVictoryPoints(1)
                .WithInfo(58, 3, Artist.Mark_Behm);
            addAttachment("Steed of Imladris", 1, Sphere.Spirit, false)
                .WithTraits("Mount.")
                .WithKeywords("Restricted.")
                .WithTextLine("Attach to a Spirit or Noldor hero. Restricted.")
                .WithTextLine("Response: After attached hero commits to a quest, discard a card from your hand to place 2 progress on the active location.")
                .WithFlavorLine("In the dusk its headstall flickered and flashed, as if it were studded with gems like living stars.")
                .WithFlavorLine("-The Fellowship of the Ring")
                .WithInfo(59, 3, Artist.Eva_Maria_Toker);
            addEvent("Fair and Perilous", 1, Sphere.Spirit)
                .WithTextLine("Action: Choose a Noldor or Silvan character.")
                .WithTextLine("Until the end of the phase, add that character's Willpower to its Attack.")
                .WithFlavorLine("\"...you saw him for a moment as he is upon the other side: one of the mighty of the Firstborn.\"")
                .WithFlavorLine("-Gandalf, The Fellowship of the Ring")
                .WithInfo(60, 3, Artist.Magali_Villeneuve);
            addAlly("Wellinghall Preserver", 3, Sphere.Lore, false, 3, 2, 2, 3)
                .WithTraits("Ent.")
                .WithTextLine("Cannot have restricted attachments.")
                .WithTextLine("Enters play exhausted.")
                .WithTextLine("Response: After Wellinghall Preserver readies, heal 1 damage from an Ent character.")
                .WithInfo(61, 3, Artist.Tomasz_Jedruszek);
            addEvent("None Return", 1, Sphere.Lore)
                .WithTextLine("Limit 3 copies of None Return in the victory display.")
                .WithTextLine("Response: After a non-unique enemy is destroyed, add None Return to the victory display to add that enemy to the victory display.")
                .WithFlavorLine("\"None of the Orcs will ever return out of Lórien.\"")
                .WithFlavorLine("-Haldir, The Fellowship of the Ring")
                .WithInfo(62, 3, Artist.Kip_Ayers);
            addEvent("Hope Rekindled", 0, Sphere.Neutral)
                .WithTraits("Song.")
                .WithTextLine("Action: Reduce the cost of the next event that has a Valour trigger you play this phase by 2.")
                .WithTextLine("Valour Action: Search the top 10 cards of your deck for an event that has a Valour trigger and add it to your hand. Shuffle your deck.")
                .WithFlavorLine("Hope he rekindled, and in hope ended;")
                .WithFlavorLine("over death, over dread, over doom lifted")
                .WithFlavorLine("out of loss, out of life, unto long glory.")
                .WithFlavorLine("-The Return of the King")
                .WithTemplate("<p><b>Action:</b> Reduce the cost of the next event that has a <b>Valour</b> trigger you play this phase by 2.</p><p><b>Valour Action:</b> Search the top 10 cards of your deck for an event that has a <b>Valour</b> trigger and add it to your hand. Shuffle your deck.</p><p class='flavor-text'>Hope he rekindled, and in hope ended;<br>over death, over dread, over doom lifted<br>out of loss, out of life, unto long glory.<br>&ndash;The Return of the King</p>")
                .WithInfo(63, 3, Artist.Gabrielle_Portal);
            addQuest("Into the Ettenmoors", EncounterSet.AcrossTheEttenmoors, 1, 'A', 10)
                .WithTextLine("Setup: Set aside each of the 3 Across the Enttenmoors side quests and each of the 4 locations with the safe keyword. Reveal 1 of those side quests at random and 1 of those safe locations at random, adding them to the staging area with the safe location guarded by the side quest. Search the encounter deck for 1 copy of Savage Trollspawn per player and add them to the staging area. Shuffle the remaining side quests and safe locations back into the encounter deck. The first player gains control of Amarthiúl.")
                .WithOppositeTextLine("Forced: At the beginning of the quest phase, if there are no encounter side quests in play, discard cards from the top of the encounter deck until a side quest is discarded, reveal it, and add it to the staging area.")
                .WithOppositeTextLine("Forced: When a side quest is defeated, place progress tokens on Into the Etternmoors equal to that side quest's quest points.")
                .WithOppositeFlavorLine("You have escaped from the prisons of Mount Gram, but you are not safe yet.")
                .WithIncludedEncounterSets(EncounterSet.EriadorWilds, EncounterSet.FoulWeather)
                .WithInfo(64, 1, Artist.Alvaro_Calvo_Escudero);
            addQuest("A Miserable Journey", EncounterSet.AcrossTheEttenmoors, 2, 'A', 20)
                .WithTextLine("When Revealed: Shuffle the encounter discard pile into the encounter deck. Discard cards from the top of the encounter deck until a side quest is discarded. Reveal that side quest and add it to the staging area, if able.")
                .WithFlavorLine("Your trek through the Ettenmoors only gets worse as your injured company is pursued by hungry trolls and bettered by cold and rain.")
                .WithOppositeTextLine("Reveal 1 additional encounter card during the quest phase unless there is an active location with the safe keyword.")
                .WithOppositeFlavorLine("This land is barren and untamed. Food is scarce, and you must take care to avoid the Trolls and other creatures that roam the moors. If you are lucky, you may find a safe place to hide and rest for a short time before your journey continues.")
                .WithIncludedEncounterSets(EncounterSet.EriadorWilds, EncounterSet.FoulWeather)
                .WithInfo(65, 1, Artist.Victor_Garcia);
            addQuest("Journey's End", EncounterSet.AcrossTheEttenmoors, 3, 'A', 17)
                .WithTextLine("When Revealed: Shuffle the encounter discard pile into the encounter deck. Discard cards from the top of the encounter deck until a side quest is discarded. Reveal that side quest and add it to the staging area, if able.")
                .WithFlavorLine("You are getting closer to the edge of the Troll-fells, but exhaustion has taken its toll. One way or another, this journey is nearing its end...")
                .WithOppositeTextLine("Each damaged character gets -2 Willpower unless there is an active location with the safe keyword.")
                .WithOppositeTextLine("If the players defeat this stage, they have escaped the Ettenmoors with their lives, and win the game.")
                .WithOppositeFlavorLine("Your wounded companions only slow your progress. With Trolls on your heels and foul weather overhead, you press onward.")
                .WithIncludedEncounterSets(EncounterSet.EriadorWilds, EncounterSet.FoulWeather)
                .WithInfo(66, 1, Artist.Victor_Garcia);
            addObjectiveAlly("Amarthiúl", EncounterSet.AcrossTheEttenmoors, 1, 3, 3, 3)
                .WithUnique()
                .WithTraits("Dúnedain.", "Ranger.", "Warrior.")
                .WithTextLine("Response: After an enemy engages a player, give control of Amarthiúl to that player.")
                .WithTextLine("If Amarthiúl leaves play, the players lose the game.")
                .WithInfo(67, 1, Artist.Tomasz_Jedruszek);
            addObjectiveLocation("Secluded Cave", EncounterSet.AcrossTheEttenmoors, 7, false, 5)
                .WithTraits("Ettenmoors.", "Cave.")
                .WithKeywords("Guarded.", "Safe.")
                .WithTextLine("Guarded. Safe.")
                .WithTextLine("Immune to player card effects.")
                .WithTextLine("Response: After you travel to Secluded ~Cave, each player draws 3 cards.")
                .WithVictoryPoints(5)
                .WithInfo(68, 1, Artist.Ferdinand_Dumago_Ladera);
            addObjectiveLocation("The Hoarwell", EncounterSet.AcrossTheEttenmoors, 3, false, 5)
                .WithTraits("Ettenmoors.", "River.")
                .WithKeywords("Guarded.", "Safe.")
                .WithTextLine("Guarded. Safe.")
                .WithTextLine("Immune to player card effects.")
                .WithTextLine("Response: After you travel to The Hoarwell, heal 1 damage from each character in play.")
                .WithVictoryPoints(5)
                .WithInfo(69, 1, Artist.Alyn_Spiller);
            addObjectiveLocation("Abandoned Camp", EncounterSet.AcrossTheEttenmoors, 1, false, 5)
                .WithTraits("Ettenmoors.")
                .WithKeywords("Guarded.", "Safe.")
                .WithTextLine("Guarded. Safe.")
                .WithTextLine("Immune to player card effects.")
                .WithTextLine("Response: After you travel to Abandoned Camp, each player may return 1 card from his discard pile to his hand.")
                .WithVictoryPoints(5)
                .WithInfo(70, 1, Artist.Tomasz_Jedruszek);
            addObjectiveLocation("Patch of Woods", EncounterSet.AcrossTheEttenmoors, 5, false, 5)
                .WithTraits("Ettenmoors.", "Forest.")
                .WithKeywords("Guarded.", "Safe.")
                .WithTextLine("Guarded. Safe.")
                .WithTextLine("Immune to player card effects.")
                .WithTextLine("Response: After you travel to Patch of Woods, each player adds 1 resource to each of his heroes' resource pools.")
                .WithVictoryPoints(5)
                .WithInfo(71, 1, Artist.Leonid_Kozienko);
            addEnemy("Savage Trollspawn", EncounterSet.AcrossTheEttenmoors, 36, 1, 2, 3, 6)
                .WithTraits("Troll.")
                .WithTextLine("Savage Trollspawn gets +1 Attack for each damaged character the engaged player controls.")
                .WithShadow("Shadow: Attacking enemy gets +1 Attack for each damaged character the defending player controls.")
                .WithInfo(71, 4, Artist.Matthew_Starbuck);
            addEnemy("Coldfell Giant", EncounterSet.AcrossTheEttenmoors, 41, 3, 5, 4, 7)
                .WithTraits("Giant.")
                .WithTextLine("Forced: After Coldfell Giant engages you, deal 1 damage to 3 different characters you control.")
                .WithShadow("Shadow: If the defending character has at least 1 damage token on it, attacking enemy makes an additional attack after this one.")
                .WithEasyModeQuantity(0)
                .WithInfo(72, 2, Artist.Lukasz_Jaskolski);
            addEnemy("Cruel Mountain-troll", EncounterSet.AcrossTheEttenmoors, 46, 3, 6, 2, 9)
                .WithTraits("Troll.")
                .WithTextLine("For each excess point of combat damage dealt by Cruel Mountain-troll (damage that is dealt beyond the remaining hit points of the character damaged by its attack) you must remove 1 progress from each quest card in play.")
                .WithFlavorLine("Trolls were abroad, no longer dull-witted, but cunning...")
                .WithFlavorLine("-The Fellowship of the Ring")
                .WithEasyModeQuantity(0)
                .WithInfo(74, 2, Artist.Nicholas_Gregory);
            addEnemy("Ruthless Hill-troll", EncounterSet.AcrossTheEttenmoors, 31, 2, 4, 1, 12)
                .WithTraits("Troll.")
                .WithTextLine("Ruthless Hill-troll gets +2 Attack and +2 Defense while it has 3 or more damage on it.")
                .WithShadow("Shadow: Shuffle 1 location with the safe keyword (but not its attached encounter) back into the encounter deck.")
                .WithInfo(75, 2, Artist.Guillaume_Ducos);
            addEnemy("Goblin Pursuer", EncounterSet.AcrossTheEttenmoors, 16, 2, 2, 2, 3)
                .WithTraits("Goblin.", "Orc.")
                .WithTextLine("Damaged characters cannot be declared as attackers or defenders against Goblin Pursuer.")
                .WithShadow("Shadow: Attacking enemy gets +1 Attack (+3 Attack instead if this attack is undefended).")
                .WithInfo(76, 2, Artist.Joel_Hustak);
            addLocation("Troll-fells", EncounterSet.AcrossTheEttenmoors, 1, 6)
                .WithTraits("Ettenmoors.")
                .WithTextLine("While Troll-fells is the active location, Weather cards gain doomed 1.")
                .WithTextLine("When Revealed: If Troll fells is not revealed guarding a safe location, search the encounter deck and discard pile for a location with the safe keyword and attach it to Troll-fells, guarded. Shuffle the encounter deck.")
                .WithInfo(77, 2, Artist.Michael_Rasmussen);
            addLocation("Barren Moorland", EncounterSet.AcrossTheEttenmoors, 2, 4)
                .WithTraits("Ettenmoors.")
                .WithTextLine("While Barren Moorland is in the staging area, it gains: \"Forced: When an ally enters play, you must either exhaust it or deal 1 damage to it.\"")
                .WithTextLine("Travel: Deal 1 damage to each exhausted character.")
                .WithEasyModeQuantity(0)
                .WithInfo(78, 2, Artist.Leonid_Kozienko);
            addTreachery("Arador's Bane", EncounterSet.AcrossTheEttenmoors)
                .WithTextLine("When Revealed: Starting with the first player, each player must either engage an enemy in the staging area with a higher engagement cost than his threat, or search the encounter deck and discard pile for a Troll or Giant enemy and add it to the staging area. Deal each enemy that engages a player through this effect 2 shadow cards.")
                .WithEasyModeQuantity(1)
                .WithInfo(79, 2, Artist.Tomasz_Jedruszek);
            addTreachery("No Rest", EncounterSet.AcrossTheEttenmoors)
                .WithTextLine("When Revealed: Attach to an exhausted hero, or a ready hero is there are no exhausted heroes. (Counts as a Condition attachment with the text: \"Limit 1 per hero. Attached hero cannot ready and does not collect resources during the resource phase. Discard No Rest if the players travel to a safe location.\")")
                .WithInfo(80, 3, Artist.Cassandre_Bolan);
            addEncounterSideQuest("Lie Low", EncounterSet.AcrossTheEttenmoors, 8)
                .WithTextLine("Forced: At the end of the quest phase, if no progress was placed on Lie Low this round, each enemy gets -20 engagement cost until the end of the round.")
                .WithTextLine("Response: After this stage is defeated, choose an enemy in the staging area and shuffle it into the encounter deck.")
                .WithFlavorLine("Trolls and Giants have been pursuing you since your arrival in these moors. Your company must cover their tracks so the vile creatures do not follow.")
                .WithVictoryPoints(10)
                .WithInfo(81, 1, Artist.Mark_Behm);
            addEncounterSideQuest("Forage for Food", EncounterSet.AcrossTheEttenmoors, 6)
                .WithTextLine("Forced: After 1 or more resources are spent from a hero's resource pool, deal 1 damage to that hero.")
                .WithTextLine("Response: After this stage is defeated, heal 1 damage from each hero.")
                .WithFlavorLine("What little rations you managed to recover after your imprisonment have run dry. If the Trolls or the cold doesn't kill you, starvation surely will. There must be some food to find in these barren hills.")
                .WithVictoryPoints(10)
                .WithInfo(82, 1, Artist.Claudio_Pozas);
            addEncounterSideQuest("Scavenge for Supplies", EncounterSet.AcrossTheEttenmoors, 7)
                .WithTextLine("The cost to play each player card is increased by 1.")
                .WithTextLine("Forced: When this stage is defeated, search the encounter deck and discard pile for a Troll enemy and put it into play engaged with the player with the highest threat. Each player may play a card from his hand, at no cost.")
                .WithFlavorLine("You risk drawing the attention of nearby Trolls by venturing into their lair. Perhaps inside you can find supplies to help you get back to Rivendell...")
                .WithVictoryPoints(10)
                .WithInfo(83, 1, Artist.Marcel_Mercado);
        }
    }
}
