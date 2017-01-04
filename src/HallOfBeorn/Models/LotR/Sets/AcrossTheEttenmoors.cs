using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace HallOfBeorn.Models.LotR.Sets
{
    public class AcrossTheEttenmoors : CardSet
    {
        private const string setName = "Across the Ettenmoors";

        protected override void Initialize()
        {
            Name = setName;
            Abbreviation = "AtE";
            Number = 32;
            SetType = Models.SetType.Adventure_Pack;
            Cycle = "Angmar Awakened";

            Cards.Add(LotRCard.Hero("Dori", "", Sphere.Tactics, 10, 1, 2, 2, 5)
                .WithTraits("Dwarf.")
                .WithKeywords("Sentinel.")
                .WithText("Response: After another hero is declared as a defender, exhaust Dori to add his Defense to the defending hero's Defense for this attack.")
                .WithFlavor("Dori was really a decent fellow in spite of his grumbling.\r\n-The Hobbit")
                .WithTemplate("<p><b>Response:</b> After another hero is declared as a defender, exhaust {self} to add his {Defense} to the defending hero's {Defense} for this attack.</p><p class='flavor-text'>Dori was really a decent fellow in spite of his grumbling.<br>&ndash;The Hobbit</p>")
                .WithInfo(54, 1, Artist.Sebastian_Giacobino));
            Cards.Add(LotRCard.Attachment("Ranger Provisions", "", Sphere.Leadership, 1)
                .WithTraits("Item.")
                .WithText("Attach to a location. Limit 1 per location.\r\nResponse: After attached location is explored, the first player adds 1 resource to each of his heroes' resource pools.")
                .WithFlavor("\"Rangers have been here lately. It is they who left the firewood behind.\"\r\n-Aragorn, The Fellowship of the Ring")
                .WithInfo(55, 3, Artist.Drazenka_Kimpel));
            Cards.Add(LotRCard.Event("Dúnedain Message", "", Sphere.Leadership, 1)
                .WithNormalizedTitle("Dunedain Message")
                .WithTraits("Signal.")
                .WithText("Action: Search your deck for a side quest and add it to your hand. Shuffle your deck.")
                .WithFlavor("\"I called for the help of the Dúnedain, and their watch was doubled...\"\r\n-Gandalf, The Fellowship of the Ring")
                .WithInfo(56, 3, Artist.Sara_Biddle));
            Cards.Add(LotRCard.Ally("Longbeard Sentry", "", Sphere.Tactics, 3, 0, 1, 2, 3)
                .WithGeneric()
                .WithTraits("Dwarf.", "Warrior.")
                .WithText("Action: Discard 2 cards from the top of your deck to give Longbeard Sentry sentinel and +1 Defense until the end of the phase. (Limit once per phase.)")
                .WithFlavor("\"...many of them have had experience in the dreadful dwarf and goblin wars, of which you have no doubt heard.\"\r\n-Bilbo Baggins, The Hobbit")
                .WithInfo(57, 3, Artist.Michele_Frigo));
            Cards.Add(LotRCard.PlayerSideQuest("Delay the Enemy", "", Sphere.Tactics, 0, 8)
                .WithKeywords("Battle.")
                .WithText("Limit 1 per deck.\r\nResponse: When this stage is defeated, each player may choose and discard a non-unique enemy engaged with him.")
                .WithVictoryPoints(1)
                .WithInfo(58, 3, Artist.Mark_Behm));
            Cards.Add(LotRCard.Attachment("Steed of Imladris", "", Sphere.Spirit, 1)
                .WithTraits("Mount.")
                .WithKeywords("Restricted.")
                .WithText("Attach to a Spirit or Noldor hero.\r\nResponse: After attached hero commits to a quest, discard a card from your hand to place 2 progress on the active location.")
                .WithFlavor("In the dusk its headstall flickered and flashed, as if it were studded with gems like living stars.\r\n-The Fellowship of the Ring")
                .WithInfo(59, 3, Artist.Eva_Maria_Toker));
            Cards.Add(LotRCard.Event("Fair and Perilous", "", Sphere.Spirit, 1)
                .WithText("Action: Choose a Noldor or Silvan character.\r\nUntil the end of the phase, add that character's Willpower to its Attack.")
                .WithFlavor("\"...you saw him for a moment as he is upon the other side: one of the mighty of the Firstborn.\"\r\n-Gandalf, The Fellowship of the Ring")
                .WithInfo(60, 3, Artist.Magali_Villeneuve));
            Cards.Add(LotRCard.Ally("Wellinghall Preserver", "", Sphere.Lore, 3, 3, 2, 2, 3)
                .WithGeneric()
                .WithTraits("Ent.")
                .WithText("Cannot have restricted attachments.\r\nEnters play exhausted.\r\nResponse: After Wellinghall Preserver readies, heal 1 damage from an Ent character.")
                .WithInfo(61, 3, Artist.Tomasz_Jedruszek));
            Cards.Add(LotRCard.Event("None Return", "", Sphere.Lore, 1)
                .WithText("Limit 3 copies of None Return in the victory display.\r\nResponse: After a non-unique enemy is destroyed, add None Return to the victory display to add that enemy to the victory display.")
                .WithFlavor("\"None of the Orcs will ever return out of Lórien.\"\r\n-Haldir, The Fellowship of the Ring")
                .WithInfo(62, 3, Artist.Kip_Ayers));
            Cards.Add(LotRCard.Event("Hope Rekindled", "", Sphere.Neutral, 0)
                .WithTraits("Song.")
                .WithText("Action: Reduce the cost of the next event that has a Valour trigger you play this phase by 2.\r\nValour Action: Search the top 10 cards of your deck for an event that has a Valour trigger and add it to your hand. Shuffle your deck.")
                .WithFlavor("Hope he rekindled, and in hope ended;\r\nover death, over dread, over doom lifted\r\nout of loss, out of life, unto long glory.\r\n-The Return of the King")
                .WithTemplate("<p><b>Action:</b> Reduce the cost of the next event that has a <b>Valour</b> trigger you play this phase by 2.</p><p><b>Valour Action:</b> Search the top 10 cards of your deck for an event that has a <b>Valour</b> trigger and add it to your hand. Shuffle your deck.</p><p class='flavor-text'>Hope he rekindled, and in hope ended;<br>over death, over dread, over doom lifted<br>out of loss, out of life, unto long glory.<br>&ndash;The Return of the King</p>")
                .WithInfo(63, 3, Artist.Gabrielle_Portal));
            Cards.Add(LotRCard.Quest("Into the Ettenmoors", 1, setName, 10)
                .WithText("Setup: Set aside each of the 3 Across the Enttenmoors side quests and each of the 4 locations with the safe keyword. Reveal 1 of those side quests at random and 1 of those safe locations at random, adding them to the staging area with the safe location guarded by the side quest. Search the encounter deck for 1 copy of Savage Trollspawn per player and add them to the staging area. Shuffle the remaining side quests and safe locations back into the encounter deck. The first player gains control of Amarthiúl.")
                .WithOppositeFlavor("You have escaped from the prisons of Mount Gram, but you are not safe yet.")
                .WithOppositeText("Forced: At the beginning of the quest phase, if there are no encounter side quests in play, discard cards from the top of the encounter deck until a side quest is discarded, reveal it, and add it to the staging area.\r\nForced: When a side quest is defeated, place progress tokens on Into the Etternmoors equal to that side quest's quest points.")
                .WithIncludedEncounterSets(EncounterSet.EriadorWilds, EncounterSet.FoulWeather)
                .WithInfo(64, 1, Artist.Alvaro_Calvo_Escudero));
            Cards.Add(LotRCard.Quest("A Miserable Journey", 2, setName, 20)
                .WithFlavor("Your trek through the Ettenmoors only gets worse as your injured company is pursued by hungry trolls and bettered by cold and rain.")
                .WithText("When Revealed: Shuffle the encounter discard pile into the encounter deck. Discard cards from the top of the encounter deck until a side quest is discarded. Reveal that side quest and add it to the staging area, if able.")
                .WithOppositeFlavor("This land is barren and untamed. Food is scarce, and you must take care to avoid the Trolls and other creatures that roam the moors. If you are lucky, you may find a safe place to hide and rest for a short time before your journey continues.")
                .WithOppositeText("Reveal 1 additional encounter card during the quest phase unless there is an active location with the safe keyword.")
                .WithIncludedEncounterSets(EncounterSet.EriadorWilds, EncounterSet.FoulWeather)
                .WithInfo(65, 1, Artist.Victor_Garcia));
            Cards.Add(LotRCard.Quest("Journey's End", 3, setName, 17)
                .WithFlavor("You are getting closer to the edge of the Troll-fells, but exhaustion has taken its toll. One way or another, this journey is nearing its end...")
                .WithText("When Revealed: Shuffle the encounter discard pile into the encounter deck. Discard cards from the top of the encounter deck until a side quest is discarded. Reveal that side quest and add it to the staging area, if able.")
                .WithOppositeFlavor("Your wounded companions only slow your progress. With Trolls on your heels and foul weather overhead, you press onward.")
                .WithOppositeText("Each damaged character gets -2 Willpower unless there is an active location with the safe keyword.\r\nIf the players defeat this stage, they have escaped the Ettenmoors with their lives, and win the game.")
                .WithIncludedEncounterSets(EncounterSet.EriadorWilds, EncounterSet.FoulWeather)
                .WithInfo(66, 1, Artist.Victor_Garcia));
            Cards.Add(LotRCard.ObjectiveAlly("Amarthiúl", "", setName, 1, 3, 3, 3)
                .WithUnique()
                .WithNormalizedTitle("Amarthiul")
                .WithTraits("Dúnedain.", "Ranger.", "Warrior.")
                .WithText("Response: After an enemy engages a player, give control of Amarthiúl to that player.\r\nIf Amarthiúl leaves play, the players lose the game.")
                .WithInfo(67, 1, Artist.Tomasz_Jedruszek));
            Cards.Add(LotRCard.ObjectiveLocation("Secluded Cave", setName, 7)
                .WithTraits("Ettenmoors.", "Cave.")
                .WithKeywords("Guarded.", "Safe.")
                .WithText("Immune to player card effects.\r\nResponse: After you travel to Secluded ~Cave, each player draws 3 cards.")
                .WithVictoryPoints(5)
                .WithInfo(68, 1, Artist.Ferdinand_Dumago_Ladera));
            Cards.Add(LotRCard.ObjectiveLocation("The Hoarwell", setName, 3)
                .WithTraits("Ettenmoors.", "River.")
                .WithKeywords("Guarded.", "Safe.")
                .WithText("Immune to player card effects.\r\nResponse: After you travel to The Hoarwell, heal 1 damage from each character in play.")
                .WithVictoryPoints(5)
                .WithInfo(69, 1, Artist.Alyn_Spiller));
            Cards.Add(LotRCard.ObjectiveLocation("Abandoned Camp", setName, 1)
                .WithTraits("Ettenmoors.")
                .WithKeywords("Guarded.", "Safe.")
                .WithText("Immune to player card effects.\r\nResponse: After you travel to Abandoned Camp, each player may return 1 card from his discard pile to his hand.")
                .WithVictoryPoints(5)
                .WithInfo(70, 1, Artist.Tomasz_Jedruszek));
            Cards.Add(LotRCard.ObjectiveLocation("Patch of Woods", setName, 5)
                .WithTraits("Ettenmoors.", "Forest.")
                .WithKeywords("Guarded.", "Safe.")
                .WithText("Immune to player card effects.\r\nResponse: After you travel to Patch of Woods, each player adds 1 resource to each of his heroes' resource pools.")
                .WithVictoryPoints(5)
                .WithInfo(71, 1, Artist.Leonid_Kozienko));
            Cards.Add(LotRCard.Enemy("Savage Trollspawn", "", setName, 36, 1, 2, 3, 6)
                .WithTraits("Troll.")
                .WithText("Savage Trollspawn gets +1 Attack for each damaged character the engaged player controls.")
                .WithShadow("Shadow: Attacking enemy gets +1 Attack for each damaged character the defending player controls.")
                .WithInfo(71, 4, Artist.Matthew_Starbuck));
            Cards.Add(LotRCard.Enemy("Coldfell Giant", "", setName, 41, 3, 5, 4, 7)
                .WithTraits("Giant.")
                .WithText("Forced: After Coldfell Giant engages you, deal 1 damage to 3 different characters you control.")
                .WithShadow("Shadow: If the defending character has at least 1 damage token on it, attacking enemy makes an additional attack after this one.")
                .WithEasyModeQuantity(0)
                .WithInfo(72, 2, Artist.Lukasz_Jaskolski));
            Cards.Add(LotRCard.Enemy("Cruel Mountain-troll", "", setName, 46, 3, 6, 2, 9)
                .WithTraits("Troll.")
                .WithText("For each excess point of combat damage dealt by Cruel Mountain-troll (damage that is dealt beyond the remaining hit points of the character damaged by its attack) you must remove 1 progress from each quest card in play.")
                .WithFlavor("Trolls were abroad, no longer dull-witted, but cunning...\r\n-The Fellowship of the Ring")
                .WithEasyModeQuantity(0)
                .WithInfo(74, 2, Artist.Nicholas_Gregory));
            Cards.Add(LotRCard.Enemy("Ruthless Hill-troll", "", setName, 31, 2, 4, 1, 12)
                .WithTraits("Troll.")
                .WithText("Ruthless Hill-troll gets +2 Attack and +2 Defense while it has 3 or more damage on it.")
                .WithShadow("Shadow: Shuffle 1 location with the safe keyword (but not its attached encounter) back into the encounter deck.")
                .WithInfo(75, 2, Artist.Guillaume_Ducos));
            Cards.Add(LotRCard.Enemy("Goblin Pursuer", "", setName, 16, 2, 2, 2, 3)
                .WithTraits("Goblin.", "Orc.")
                .WithText("Damaged characters cannot be declared as attackers or defenders against Goblin Pursuer.")
                .WithShadow("Shadow: Attacking enemy gets +1 Attack (+3 Attack instead if this attack is undefended).")
                .WithInfo(76, 2, Artist.Joel_Hustak));
            Cards.Add(LotRCard.Location("Troll-fells", "", setName, 1, 6)
                .WithTraits("Ettenmoors.")
                .WithText("While Troll-fells is the active location, Weather cards gain doomed 1.\r\nWhen Revealed: If Troll fells is not revealed guarding a safe location, search the encounter deck and discard pile for a location with the safe keyword and attach it to Troll-fells, guarded. Shuffle the encounter deck.")
                .WithInfo(77, 2, Artist.Michael_Rasmussen));
            Cards.Add(LotRCard.Location("Barren Moorland", "", setName, 2, 4)
                .WithTraits("Ettenmoors.")
                .WithText("While Barren Moorland is in the staging area, it gains: \"Forced: When an ally enters play, you must either exhaust it or deal 1 damage to it.\"\r\nTravel: Deal 1 damage to each exhausted character.")
                .WithEasyModeQuantity(0)
                .WithInfo(78, 2, Artist.Leonid_Kozienko));
            Cards.Add(LotRCard.Treachery("Arador's Bane", "", setName)
                .WithText("When Revealed: Starting with the first player, each player must either engage an enemy in the staging area with a higher engagement cost than his threat, or search the encounter deck and discard pile for a Troll or Giant enemy and add it to the staging area. Deal each enemy that engages a player through this effect 2 shadow cards.")
                .WithEasyModeQuantity(1)
                .WithInfo(79, 2, Artist.Tomasz_Jedruszek));
            Cards.Add(LotRCard.Treachery("No Rest", "", setName)
                .WithText("When Revealed: Attach to an exhausted hero, or a ready hero is there are no exhausted heroes. (Counts as a Condition attachment with the text: \"Limit 1 per hero. Attached hero cannot ready and does not collect resources during the resource phase. Discard No Rest if the players travel to a safe location.\")")
                .WithInfo(80, 3, Artist.Cassandre_Bolan));
            Cards.Add(LotRCard.EncounterSideQuest("Lie Low", "", setName, 8)
                .WithFlavor("Trolls and Giants have been pursuing you since your arrival in these moors. Your company must cover their tracks so the vile creatures do not follow.")
                .WithText("Forced: At the end of the quest phase, if no progress was placed on Lie Low this round, each enemy gets -20 engagement cost until the end of the round.\r\nResponse: After this stage is defeated, choose an enemy in the staging area and shuffle it into the encounter deck.")
                .WithVictoryPoints(10)
                .WithInfo(81, 1, Artist.Mark_Behm));
            Cards.Add(LotRCard.EncounterSideQuest("Forage for Food", "", setName, 6)
                .WithFlavor("What little rations you managed to recover after your imprisonment have run dry. If the Trolls or the cold doesn't kill you, starvation surely will. There must be some food to find in these barren hills.")
                .WithText("Forced: After 1 or more resources are spent from a hero's resource pool, deal 1 damage to that hero.\r\nResponse: After this stage is defeated, heal 1 damage from each hero.")
                .WithVictoryPoints(10)
                .WithInfo(82, 1, Artist.Claudio_Pozas));
            Cards.Add(LotRCard.EncounterSideQuest("Scavenge for Supplies", "", setName, 7)
                .WithFlavor("You risk drawing the attention of nearby Trolls by venturing into their lair. Perhaps inside you can find supplies to help you get back to Rivendell...")
                .WithText("The cost to play each player card is increased by 1.\r\nForced: When this stage is defeated, search the encounter deck and discard pile for a Troll enemy and put it into play engaged with the player with the highest threat. Each player may play a card from his hand, at no cost.")
                .WithVictoryPoints(10)
                .WithInfo(83, 1, Artist.Marcel_Mercado));
        }
    }
}