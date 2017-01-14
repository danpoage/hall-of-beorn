using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace HallOfBeorn.Models.LotR.Sets
{
    public class MurderAtThePrancingPony : CardSet
    {
        private const string setName = "Murder at the Prancing Pony";
        private const string investigationSetName = "Investigation";

        protected override void Initialize()
        {
            Name = setName;
            Abbreviation = "MatPP";
            SetType = Models.SetType.Fellowship_Deck;
            Cycle = "GenCon";
            Number = 3006;

            Cards.Add(LotRCard.Hero("Legolas", "", Sphere.Tactics, 9, 1, 3, 1, 4)
                .WithTraits("Noble.", "Silvan.", "Warrior.")
                .WithKeywords("Ranged.")
                .WithText("Response: After Legolas participates in an attack that destroys an enemy, place 2 progress tokens on the current quest.")
                .WithTemplate("<p>{keyword:Ranged.}</p><p><b>Response:</b> After {self} participates in an attack that destroys an enemy, place 2 progress tokens on the current quest.</p>")
                .WithYear(2015)
                .WithInfo(5, 1, Artist.Sebastian_Giacobino));
            Cards.Add(LotRCard.GenConSetup("Murder at the Prancing Pony Scenario Rules 2-3", setName)
                .WithText("Scenario Rules\r\nThe Investigation Deck\r\nBegin the game by following the Setup instructions on stage 1A. When the players are instructed to \"build the investigation deck,\" do the following: Take the 4 remaining Hideout locations, plus each copy of Taken By Surprise, and shuffle them together without looking at them. This is the Investigation deck.\r\nThe players are not allowed to look at cards in the Investigation deck except when resolving the Investigation keyword or instructed by a card effect.\r\nThe Investigation List\r\nThe Investigation List\r\nThe Investigation List on page 5 of the rules has the name of all 5 Suspect enemies and all 5 Hideout locations. During the game, players should check enemies and locations off of their Investigation list in order to help them determine the correct Suspect and HIdeout by process of elimination.\r\nPage 2/5")
                .WithOppositeText("Investigate X\r\nInvestigate is a new keyword the represents the heroes' efforts to solve the crime. When an active location with the Investigate keyword is explored, the first player shuffles the Investigation deck and looks at the top X cards. Then, he placed those cards back on top of the Investigation deck in the same order.\r\nWhile the players are at stage 2B, the Investigate keyword on the active location is resolved before the second Forced effect on that stage.\r\nImmune to Player Card Effects\r\nCards with the text \"Immune to player card effects\" ignore the effects of all player cards. Additionally, cards that are immune to player card effects cannot be chosen as targets of player card effects.\r\nPage 3/5")
                .WithTemplate("<h2 class='rules-title'>Scenario Rules</h2><h3>Investigation Deck</h3><p>Begin the game by following the Setup instructions on stage 1A. When the players are instructed to \"build the investigation deck,\" do the following: Take the 4 remaining {trait:Suspect.@Suspect} enemies and 4 remaining {trait:Hideout.@Hideout} locations, plus each copy of {card:Taken-By-Surprise-MatPP@Taken By Surprise}, and shuffle them together without looking at them. This is the Investigation deck.\r\nThe players are not allowed to look at cards in the Investigation deck except when resolving the Investigation keyword or instructed by a card effect.</p><h3>The Investigation List</h3><p>The Investigation List on page 5 of the rules has the name of all 5 {trait:Suspect.@Suspect} enemies and all 5 {trait:Hideout.@Hideout} locations. During the game, players should check enemies and locations off of their Investigation list in order to help them determine the correct {trait:Suspect.@Suspect} and {trait:Hideout.@Hideout} by process of elimination.</p><div class='page-number'>Page 2/5</div>")
                .WithTemplate2("<h3>Investigate X</h3><p>Investigate is a new keyword the represents the heroes' efforts to solve the crime. When an active location with the Investigate keyword is explored, the first player shuffles the Investigation deck and looks at the top X cards. Then, he placed those cards back on top of the Investigation deck in the same order.</p><p>While the players are at stage 2B, the Investigate keyword on the active location is resolved before the second Forced effect on that stage.</p><h3>Immune to Player Card Effects</h3><p>Cards with the text &quot;Immune to player card effects&quot; ignore the effects of all player cards. Additionally, cards that are immune to player card effects cannot be chosen as targets of player card effects.</p><div class='page-number'>Page 3/5</div>")
                .WithInfo(0, 1, Artist.None));
            Cards.Add(LotRCard.GenConSetup("Murder at the Prancing Pony Scenario Rules 4-5", setName)
                .WithText("Making the Accusation\r\nIn order to advance from stage 2B to 3A, the players must \"make an accusation.\" To make the accusation, the first player names 1 Suspect and 1 Hideout. Then, he reveals the facedown, out of play Suspect and Hideout cards and adds them to the staging area.\r\nIf the revealed Suspect and Hideout are the same as those named by the first player, the accusation is correct and the players have successfully identified the killer and the outlaw's secret hideout.\r\nIf the out of play cards are not the same as the ones named by the first player, then the accusation is not correct, and the heroes have embroiled themselves in a deeper plot by pursuing the wrong the wrong Suspect or ivestigating the wrong Hideout. If the accusation is not correct, search the Investigation deck for each just named card that is not already in play and add it to the staging area. Then, raise each player's threat by 3.\r\nPage 4/5")
                .WithOppositeText("The Investigation List\r\n\r\nSuspects\r\n□ Todd the ~Troll\r\n□ Susie the ~Spider\r\n□ Wolf-pelt Jake\r\n□ Johnny Goblin-fingers\r\n□ Old Orc-Eyes\r\n\r\nHideouts\r\n□ Bill Ferny's House\r\nStaddle Hiding Hole\r\n□ Combe Storehouse\r\n□ Archet Trading Post\r\n□ Chetwood Campsite\r\n Page 5/5")
                .WithTemplate("<h3>Making the Accusation</h3><p>In order to advance from stage 2B to 3A, the players must &quot;make an accusation.&quot; To make the accusation, the first player names 1 {trait:Suspect} and 1 {trait:Hideout.@Hideout}. Then, he reveals the facedown, out of play {trait:Suspect.@Suspect} and {trait:Hideout.@Hideout} cards and adds them to the staging area.</p><p>If the revealed {trait:Suspect.@Suspect} and {trait:Hideout.@Hideout} are the same as those named by the first player, the accusation is correct and the players have successfully identified the killer and the outlaw's secret hideout.</p><p>If the out of play cards are not the same as the ones named by the first player, then the accusation is not correct, and the heroes have embroiled themselves in a deeper plot by pursuing the wrong the wrong {trait:Suspect.@Suspect} or ivestigating the wrong {trait:Hideout.@Hideout}. If the accusation is not correct, search the Investigation deck for each just named card that is not already in play and add it to the staging area. Then, raise each player's threat by 3.</p><div class='page-number'>Page 4/5</div>")
                .WithTemplate2("<h2>The Investigation List</h2><h3>Suspects</h3><ul class='no-style-list'><li>□ {card:Todd-the-Troll-MatPP@Todd the Troll}</li><li>□ {card:Susie-the-Spider-MatPP@Susie the Spider}</li><li>□ {card:Wolf-pelt-Jake-MatPP@Wolf-pelt Jake}</li><li>□ {card:Johnny-Goblin-fingers-MatPP@Johnny Goblin-fingers}</li><li>□ {card:Old-Orc-eyes-MatPP@Old Orc-eyes}</li></ul><br><h3>Hideouts</h3><ul class='no-style-list'><li>□ {card:Bill-Ferny%27s-House-MatPP@Bill Ferny's House}</li><li>□ {card:Staddle-Hiding-Hole-MatPP@Staddle Hiding Hole}</li><li>□ {card:Combe-Storehouse-MatPP@Combe Storehouse}</li><li>□ {card:Archet-Trading-Post-MatPP@Archet Trading Post}</li><li>□ {card:Chetwood-Campsite-MatPP@Chetwood Campsite}<li></ul><div class='page-number'>Page 5/5</div>")
                .WithInfo(0, 1, Artist.None));
            Cards.Add(LotRCard.Quest("Investigating the Crime", 1, setName, 12)
                .WithFlavor("You have arrived in Bree to find the village abuzz over a recent crime.")
                .WithText("Setup: Search the encounter deck for the 5 Suspect enemies and 5 Hideout locations. Randomly select 1 Suspect and 1 Hideout and set them aside out of play, facedown (without looking at them). Build the Investigation deck (see rules) and place it next to the quest deck. Make The Prancing Pony the active location and add 1 Ramshackle Manor to the staging area. Shuffle the encounter deck.")
                .WithOppositeFlavor("Someone has broken into The Prancing Pony, murdered a guest and made off with the victim's belongings. Barliman Butterbur begs you to find the killer before the trail grows cold.")
                .WithOppositeText("No more than 4 progress can be placed on this stage each round.\r\nForced: At the beginning of the quest phase, each player must choose: either raise his threat by 2, or reveal an additional encounter card this phase.")
                .WithTemplate("<p class='flavor-text'>You have arrived in Bree to find the village abuzz over a recent crime.</p><p><b>Setup:</b> Search the encounter deck for the 5 {trait:Suspect.@Suspect} enemies and 5 {trait:Hideout.@Hideout} locations. Randomly select 1 {trait:Suspect.@Suspect} and 1 {trait:Hideout.@Hideout} and set them aside out of play, facedown (without looking at them). Build the Investigation deck (see rules) and place it next to the quest deck. Make {card:The-Prancing-Pony-MatPP@The Prancing Pony} the active location and add 1 {card:Ramshackle-Manor-MatPP@Ramshackle Manor} to the staging area. Shuffle the encounter deck.</p>")
                .WithTemplate2("<p class='flavor-text'>Someone has broken into The Prancing Pony, murdered a guest and made off with the victim's belongings. Barliman Butterbur begs you to find the killer before the trail grows cold.</p><p>No more than 4 progress can be placed on this stage each round.</p><p><b>Forced:</b> At the beginning of the quest phase, each player must choose: either raise his threat by 2, or reveal an additional encounter card this phase.</p>")
                .WithIncludedEncounterSets(EncounterSet.Investigation)
                .WithInfo(1, 1, Artist.Adam_Lane));
            Cards.Add(LotRCard.Quest("Running out of Time", 2, setName, Card.VALUE_NA)
                .WithFlavor("Your investigation has uncovered a small but dangerous web of criminals lurking in the shadows of Bree-land. You suspect the killer you seek is the leader of this outlaw gang. It is imperative that you find the rogue and bring him to justice.")
                .WithText("When Revealed: Shuffle the encounter discard pile into the encounter deck and discard cards from the top of the encounter deck until X locations are discarded. X is the number of players in the game. Add each discarded location to the staging area.")
                .WithOppositeText("Forced: After the players quest unsuccessfully, choose 1 random card from the investigation deck and remove it from the game (without looking at it).\r\nForced: After the players place progress on this stage from questing successfully, the first player must choose: either reveal an encounter card and remain at this stage, or make the accusation (see rules) and advance to stage 3A.")
                .WithTemplate("<p class='flavor-text'>Your investigation has uncovered a small but dangerous web of criminals lurking in the shadows of Bree-land. You suspect the killer you seek is the leader of this outlaw gang. It is imperative that you find the rogue and bring him to justice.</p><p><b>When Revealed:</b> Shuffle the encounter discard pile into the encounter deck and discard cards from the top of the encounter deck until X locations are discarded. X is the number of players in the game. Add each discarded location to the staging area.</p>")
                .WithTemplate2("<p><b>Forced:</b> After the players quest unsuccessfully, choose 1 random card from the investigation deck and remove it from the game (without looking at it).</p><p><b>Forced:</b> After the players place progress on this stage from questing successfully, the first player must choose: either reveal an encounter card and remain at this stage, or make the accusation (see rules) and advance to {card:Apprehending-the-Killer-MatPP@stage 3A}.</p>")
                .WithIncludedEncounterSets(EncounterSet.Investigation)
                .WithInfo(2, 1, Artist.Romana_Kendelic));
            Cards.Add(LotRCard.Quest("Apprehending the Killer", 3, setName, Card.VALUE_NA)
                .WithFlavor("You've discovered the identity of the killer and the location of the rogue's secret hideout, but the villain is aware of your pursuit. You must move swiftly to apprehend the brigand!")
                .WithText("When Revealed: Each player besides the first player searches the encounter deck and discard pile for a Brigand enemy and adds it to the staging area. Shuffle the encounter deck.")
                .WithOppositeText("Ignore the Investigate keyword when the active location is explored.\r\nForced: At the beginning of the encounter phase, each suspect enemy in play engages the first player.\r\nWhile at least 1 Hideout location is in play, Suspect enemies cannot take damage. If there are no Suspect enemies in play, the players win the game.")
                .WithTemplate("<p class='flavor-text'>You've discovered the identity of the killer and the location of the rogue's secret hideout, but the villain is aware of your pursuit. You must move swiftly to apprehend the brigand!</p><p><b>When Revealed:</b> Each player besides the first player searches the encounter deck and discard pile for a {trait:Brigand.@Brigand} enemy and adds it to the staging area. Shuffle the encounter deck.</p>")
                .WithTemplate2("<p>Ignore the Investigate keyword when the active location is explored.</p><p><b>Forced:</b> At the beginning of the encounter phase, each {trait:Suspect.@Suspect} enemy in play engages the first player.</p><p><b>While at least 1 {trait:Hideout.@Hideout} location is in play, {trait:Suspect.@Suspect} enemies cannot take damage. If there are no {trait:Suspect.@Suspect} enemies in play, the players win the game.</b></p>")
                .WithIncludedEncounterSets(EncounterSet.Investigation)
                .WithInfo(3, 1, Artist.JB_Casacop));
            Cards.Add(LotRCard.Location("Bill Ferny's House", "", investigationSetName, 5, 5)
                .WithUnique()
                .WithTraits("Hideout.")
                .WithText("Immune to player card effects.\r\nWhile Bill Ferny's House is in the victory display, each Suspect, and each shadow card dealt to a Suspect, is immune to player card effects.\r\nTravel: Search the encounter deck, discard pile and victory display for Bill Ferny and add him to the staging area. Shuffle the encounter deck.")
                .WithVictoryPoints(5)
                .WithTemplate("<p>Immune to player card effects.</p><p>While {self} is in the victory display, each {trait:Suspect.@Suspect}, and each shadow card dealt to a {trait:Suspect.@Suspect}, is immune to player card effects.</p><p><b>Travel:</b> Search the encounter deck, discard pile and victory display for {card:Bill-Ferny-MatPP@Bill Ferny} and add him to the staging area. Shuffle the encounter deck.</p><br>{victory:5}")
                .WithInfo(4, 1, Artist.Michael_Rasmussen));
            Cards.Add(LotRCard.Location("Staddle Hiding Hole", "", investigationSetName, 5, 5)
                .WithUnique()
                .WithTraits("Hideout.")
                .WithText("Immune to player card effects.\r\nWhile Staddle Hiding Hole is in the victory display, each player not engaged with a Suspect cannot declare attackers against that Suspect.\r\nTravel: Search the encounter deck and discard pile for a Greenway Footpad, reveal it, and add it to the staging area. Shuffle the encounter deck.")
                .WithVictoryPoints(5)
                .WithInfo(5, 1, Artist.Michael_Rasmussen));
            Cards.Add(LotRCard.Location("Combe Storehouse", "", investigationSetName, 5, 5)
                .WithUnique()
                .WithTraits("Hideout.")
                .WithText("Immune to player card effects.\r\nWhile Combe Storehouse is in the victory display, each Suspect gains: \"Forced: After this enemy engages a player, it makes an immediate attack.\"\r\nTravel: Search the encounter deck and discard pile for a Lawless Ruffian and add it to the staging area. Shuffle the encounter deck.")
                .WithVictoryPoints(5)
                .WithInfo(6, 1, Artist.Alvaro_Calvo_Escudero));
            Cards.Add(LotRCard.Location("Archet Trading Post", "", investigationSetName, 5, 5)
                .WithUnique()
                .WithTraits("Hideout.")
                .WithText("Immune to player card effects.\r\nWhile Archet Trading Post is in the victory display, each Suspect cannot take more than 5 damage each round.\r\nTravel: Search the encounter deck and discard pile for a Bree-land Informant and add it to the staging area. Shuffle the encounter deck.")
                .WithVictoryPoints(5)
                .WithInfo(7, 1, Artist.Yoann_Boissonnet));
            Cards.Add(LotRCard.Location("Chetwood Campsite", "", investigationSetName, 5, 5)
                .WithUnique()
                .WithTraits("Hideout.")
                .WithText("Immune to player card effects.\r\nWhile Chetwood Campsite is in the victory display, each Suspect gets +1 Threat, +1 Attack and +1 Defense.\r\nTravel: Search the encounter deck and discard pile for a Chetwood Outlaw and add it to the staging area. Shuffle the encounter deck.")
                .WithVictoryPoints(5)
                .WithInfo(8, 1, Artist.Michael_Rasmussen));
            Cards.Add(LotRCard.Enemy("Todd the Troll", "", investigationSetName, 45, 2, 7, 2, 10)
                .WithUnique()
                .WithTraits("Suspect.", "Brigand.")
                .WithText("Cannot have attachments.\r\nExcess combat damage dealt by Todd the ~Troll (damage dealt beyond the remaining hit points of the character damaged by this attack) must be assigned as an increase to your threat.")
                .WithVictoryPoints(5)
                .WithInfo(9, 1, Artist.Rafal_Hrynkiewicz));
            Cards.Add(LotRCard.Enemy("Susie the Spider", "", investigationSetName, 45, Card.VALUE_X, 5, 3, 8)
                .WithUnique()
                .WithTraits("Suspect.", "Brigand.")
                .WithText("Cannot have attachments.\r\nX is the number of Brigand enemies in play.\r\nWhile at least 1 other Brigand is in play, Susie the ~Spider cannot take damage.")
                .WithVictoryPoints(5)
                .WithInfo(10, 1, Artist.Micah_Epstein));
            Cards.Add(LotRCard.Enemy("Wolf-pelt Jake", "", investigationSetName, 45, 4, 5, 3, 7)
                .WithUnique()
                .WithTraits("Suspect.", "Brigand.")
                .WithText("Cannot have attachments.\r\nForced: After Wolf-pelt Jake attacks and destroys an ally, return him to the staging area.")
                .WithFlavor("...in the wild lands beyond Bree there were mysterious wanderers.\r\n-The Fellowship of the Ring")
                .WithVictoryPoints(5)
                .WithInfo(11, 1, Artist.Alvaro_Calvo_Escudero));
            Cards.Add(LotRCard.Enemy("Johnny Goblin-fingers", "", investigationSetName, 45, 3, 4, 4, 6)
                .WithUnique()
                .WithTraits("Suspect.", "Brigand.")
                .WithText("Cannot have attachments.\r\nForced: When Johnny Goblin-finders attacks, the defending player discards 1 random card from his hand and raises his threat by X, where X is the printed cost of the discarded card.")
                .WithVictoryPoints(5)
                .WithInfo(12, 1, Artist.Romana_Kendelic));
            Cards.Add(LotRCard.Enemy("Old Orc-eyes", "", investigationSetName, 45, 3, 4, 3, 9)
                .WithUnique()
                .WithTraits("Suspect.", "Brigand.")
                .WithText("Cannot have attachments.\r\nForced: After an attack resolves in which Old Orc-eyes was dealt a shadow card with no shadow effect, he makes an additional attack against you. Do not deal Old Orc-eyes a shadow cad for this attack.")
                .WithVictoryPoints(5)
                .WithInfo(13, 1, Artist.Dmitry_Prosvirnin));
            Cards.Add(LotRCard.Treachery("Taken by Surprise", "", investigationSetName)
                .WithText("Forced: When a player looks at any number of cards from the Investigation deck, if Taken by Surprise is among the looked at cards, shuffle the encounter discard pile into the encounter deck and discard cards until an enemy is discarded. Put the discarded enemy into play engaged with the first player. Then remove Taken by Surprise from the game.")
                .WithInfo(14, 2, Artist.Alvaro_Calvo_Escudero));
            Cards.Add(LotRCard.Location("The Prancing Pony", "", setName, 2, 2)
                .WithUnique()
                .WithText("Forced: When the Prancing Pony is explored, the first player must choose: either look at the top 2 cards of the Investigation deck, or each player draws 2 cards.")
                .WithFlavor("...the old inn of Bree, The Prancing Pony, that has been kept by the family of Butterbur from time beyond record.\r\n-The Fellowship of the Ring")
                .WithInfo(15, 1, Artist.Lutful_Valeriya_Romanovna));
            Cards.Add(LotRCard.Location("Ramshackle Manor", "", setName, 2, 3)
                .WithTraits("Bree.")
                .WithKeywords("Investigate 2.")
                .WithText("When a player card effect reduces a player's threat by any amount, reducd that amount to 1.\r\nTravel: Raise each player's threat by 1 to travel here.")
                .WithFlavor("In one of the windows he caught a glimpse of a sallow face with sly, slanting eyes; but it vanished at once.\r\n-The Fellowship of the Ring")
                .WithInfo(16, 4, Artist.Lutful_Valeriya_Romanovna));
            Cards.Add(LotRCard.Location("Dark Alley", "", setName, 4, 3)
                .WithTraits("Bree.")
                .WithKeywords("Investigate 3.")
                .WithText("Enemies in the staging area cannot take damage.\r\nTravel: Shuffle the encounter discard pile into the encounter deck and discard cards until an enemy is discarded. Add the discarded enemy to the staging area.")
                .WithInfo(17, 3, Artist.Alvaro_Calvo_Escudero));
            Cards.Add(LotRCard.Location("Market Square", "", setName, 2, 4)
                .WithTraits("Bree.")
                .WithKeywords("Investigate 2.")
                .WithText("Forced: After a player places any amount of progress on a location in the staging area, he raises his threat by 1.\r\nTravel: Each player spends 1 resource to travel here.")
                .WithFlavor("...the whole of Bree was buzzing with excitement.\r\n-THe Fellowship of the Ring")
                .WithInfo(18, 3, Artist.Yoann_Boissonnet));
            Cards.Add(LotRCard.Location("Old Warehouse", "", setName, 3, 4)
                .WithTraits("Bree.")
                .WithKeywords("Investigate 1.")
                .WithText("Forced: When triggering the Investigate keyword on Old Warehouse, the first player must choose: either look at 2 additional card, or reduce each player's threat by 3.\r\nTravel: Reveal the top card of the encounter deck to travel here.")
                .WithInfo(19, 3, Artist.Lutful_Valeriya_Romanovna));
            Cards.Add(LotRCard.Location("Village Stable", "", setName, 3, 3)
                .WithTraits("Bree.")
                .WithKeywords("Investigate 1.")
                .WithText("Response: After triggering the Investigate keyword on Village Stable, if the looked at card is a Suspect or a Hideout, add Village Stable to the victory display to add that card to the staging area.\r\nTravel: Each player discards 1 random card from his hand to travel here.")
                .WithInfo(20, 2, Artist.Alvaro_Calvo_Escudero));
            Cards.Add(LotRCard.Enemy("Bill Ferny", "", setName, 42, 3, 2, 3, 5)
                .WithUnique()
                .WithTraits("Bree.")
                .WithText("Cannot be optionally engaged.\r\nThe first treachery revealed each round gains doomed 1 and its effects cannot be canceled.")
                .WithShadow("Shadow: Either raise your threat by 4, or this attack is considered undefended.")
                .WithVictoryPoints(3)
                .WithInfo(21, 1, Artist.Lutful_Valeriya_Romanovna));
            Cards.Add(LotRCard.Enemy("Bree-land Informant", "", setName, 30, 3, 2, 1, 3)
                .WithTraits("Bree.")
                .WithText("Response: After Bree-land Information makes an attack against you, if it was dealt a shadow card with no shadow effect, raise your threat by 1 and spend 1 resource to look at the bottom card of the Investigation deck. Then, discard Bree-land Informant.")
                .WithInfo(22, 2, Artist.Brian_Valenzuela));
            Cards.Add(LotRCard.Enemy("Lawless Ruffian", "", setName, 35, 2, 3, 2, 3)
                .WithTraits("Brigand.")
                .WithText("While engaged with a player with threat 35 or higher, Lawless Ruffian gets +2 Attack.")
                .WithShadow("Shadow: Attacking enemy makes an additional attack against you after this one.")
                .WithInfo(23, 3, Artist.Lutful_Valeriya_Romanovna));
            Cards.Add(LotRCard.Enemy("Greenway Footpad", "", setName, 25, 2, 4, 2, 4)
                .WithTraits("Brigand.")
                .WithText("When Revealed: Either raise each player's threat by 2 or Greenway Footpad makes an immediate attack against the first player.")
                .WithShadow("Shadow: Attacking enemy gets +1 Attack (+2 Attack instead if your threat is 35 or higher).")
                .WithInfo(24, 4, Artist.Brian_Valenzuela));
            Cards.Add(LotRCard.Enemy("Chetwood Outlaw", "", setName, 40, 4, 4, 3, 5)
                .WithTraits("Brigand.")
                .WithText("Forced: After you optionally engaged Chetwood Outlaw, raise your threat by 4.")
                .WithShadow("Shadow: Either raise your threat by 2, or return attacking enemy to the staging area after this attack.")
                .WithInfo(25, 3, Artist.Micah_Epstein));
            Cards.Add(LotRCard.Treachery("Hired Muscle", "", setName)
                .WithKeywords("Surge.")
                .WithText("When Revealed: Attach to a Brigand enemy without a copy of Hired Muscle attacked and return that enemy to the staging area. (Counts as a Condition attachment with the text: \"Attached enemy gets +1 Threat, +1 Attack, +1 Defense and gains: 'Forced: When attached enemy is defeated, look at the bottom of the Investigation deck.'\")")
                .WithInfo(26, 2, Artist.Rafal_Hrynkiewicz));
            Cards.Add(LotRCard.Treachery("Smoke and Mirrors", "", setName)
                .WithText("When Revealed: Discard the top X cards of the encounter deck, where X is 1 more than the Investigate value of the active location. Until the end of the phase, add the Threat of each card discarded by this effect to the total Threat in the staging area.")
                .WithShadow("Shadow: Discard an attachment you control.")
                .WithInfo(27, 3, Artist.Micah_Epstein));
            Cards.Add(LotRCard.Treachery("Rising Body Count", "", setName)
                .WithText("When Revealed: Either raise each player's threat by 2, or shuffle Rising Body Count into the Investigation deck.")
                .WithShadow("Shadow: If this attack destroys a character, either raise your threat by 2, or shuffle Rising Body Count into the Investigation deck.")
                .WithInfo(28, 2, Artist.Tiziano_Baracchi));
            Cards.Add(LotRCard.Treachery("Deadly Accusations", "", setName)
                .WithText("When Revealed: Raise each player's threat by X, where X is 1 more than the Investigate value of the active location.")
                .WithShadow("Shadow: Attacking enemy gets +X Attack, where X is the Investigate value of the active location.")
                .WithInfo(29, 2, Artist.Dmitry_Prosvirnin));
        }
    }
}