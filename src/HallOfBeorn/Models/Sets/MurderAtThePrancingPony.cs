using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace HallOfBeorn.Models.Sets
{
    public class MurderAtThePrancingPony : CardSet
    {
        private const string setName = "Murder at the Prancing Pony";

        protected override void Initialize()
        {
            Name = setName;
            Abbreviation = "MatPP";
            SetType = Models.SetType.Fellowship_Deck;
            Cycle = "GenCon";
            Number = 3006;

            Cards.Add(Card.GenConSetup("Murder at the Prancing Pony Scenario Rules 2-3", setName)
                .WithText("Scenario Rules\r\nThe Investigation Deck\r\nBegin the game by following the Setup instructions on stage 1A. When the players are instructed to \"build the investigation deck,\" do the following: Take the 4 remaining Hideout locations, plus each copy of Taken By Surprise, and shuffle them together without looking at them. This is the Investigation deck.\r\nThe players are not allowed to look at cards in the Investigation deck except when resolving the Investigation keyword or instructed by a card effect.\r\nThe Investigation List\r\nThe Investigation List\r\nThe Investigation List on page 5 of the rules has the name of all 5 Suspect enemies and all 5 Hideout locations. During the game, players should check enemies and locations off of their Investigation list in order to help them determine the correct Suspect and HIdeout by process of elimination.\r\nPage 2/5")
                .WithOppositeText("Investigate X\r\nInvestigate is a new keyword the represents the heroes' efforts to solve the crime. When an active location with the Investigage keyword is explored, the first player shuffles the Investigation deck and looks at the top X cards. Then, he placed those cards back on top of the Investigation deck in the same order.\r\nWhile the players are at stage 2B, the Investigate keyword on the active location is resolved before the second Forced effect on that stage.\r\nImmune to Player Card Effects\r\nCards with the text \"Immune to player card effects\" ignore the effects of all player cards. Additionally, cards that are immune to player card effects cannot be chosen as targets of player card effects.\r\nPage 3/5")
                .WithInfo(0, 1, Artist.None));
            Cards.Add(Card.GenConSetup("Murder at the Prancing Pony Scenario Rules 4-5", setName)
                .WithText("Making the Accusation\r\nIn order to advance from stage 2B to 3A, the players must \"make an accusation.\" To make the accusation, the first player names 1 Suspect and 1 Hideout. Then, he reveals the facedown, out of play Suspect and Hideout cards and adds them to the staging area.\r\nIf the revealed Suspect and Hideout are the same as those named by the first player, the accusation is correct and the players have successfully identified the killer and the outlaw's secret hideout.\r\nIf the out of play cards are not the same as the ones named by the first player, then the accusation is not correct, and the heroes have embroiled themselves in a deeper plot by pursuing the wrong the wrong Suspect or ivestigating the wrong Hideout. If the accusation is not correct, search the Investigation deck for each just named card that is not already in play and add it to the staging area. Then, raise each player's threat by 3.\r\nPage 4/5")
                .WithOppositeText("The Investigation List\r\n\r\nSuspects\r\n□ Todd the Troll\r\n□ Susie the Spider\r\n□ Wolf-pelt Jake\r\n□ Johnny Goblin-fingers\r\n□ Old Orc-Eyes\r\n\r\nHideouts\r\n□ Bill Ferny's House\r\nStaddle Hiding Hole\r\n□ Combe Storehouse\r\n□ Archet Trading Post\r\n□ Chetwood Campsite\r\n Page 5/5")
                .WithInfo(0, 1, Artist.None));
            Cards.Add(Card.Quest("Investigating the Crime", "", 6, 1, setName, 12)
                .WithFlavor("You have arrived in Bree to find the village abuzz over a recent crime.")
                .WithText("Setup: Search the encounter deck for the 5 Suspect enemies and 5 Hideout locations. Randomly select 1 Suspect and 1 Hideout and set them aside out of play, facedown (without looking at them). Build the Investigation deck (see rules) and place it next to the quest deck. Make The Prancing Pony the active location and add 1 Ramshackle Manor to the staging area. Shuffle the encounter deck.")
                .WithOppositeFlavor("Someone has broken into The Prancing Pony, murdered a guest and made off with the victim's belongings. Barliman Butterbur begs you to find the killer before the trail grows cold.")
                .WithOppositeText("No more than 4 progress can be placed on this stage each round.\r\nForced: At the beginning of the quest phase, each player must choose: either raise his threat by 2, or reveal an additional encounter card this phase.")
                .WithInfo(1, 1, Artist.Adam_Lane));
            Cards.Add(Card.Quest("Running out of Time", "", 6, 2, setName, 255)
                .WithFlavor("Your investigation has uncovered a small but dangerous web of criminals lurking in the shadows of Bree-land. You suspect the killer you seek is the leader of this outlaw gang. It is imperative that you find the rogue and bring him to justice.")
                .WithText("When Revealed: Shuffle the encounter discard pile into the encounter deck and discard cards from the top of the encounter deck until X locations are discarded. X is the number of players in the game. Add each discarded location to the staging area.")
                .WithOppositeText("Forced: After the players quest unsuccessfully, choose 1 random card from the investigation deck and remove it from the game (without looking at it).\r\nForced: After the players place progress on this stage from questing successfully, the first player must choose: either reveal an encounter card and remain at this stage, or make the accusation (see rules) and advance to stage 3A.")
                .WithInfo(2, 1, Artist.Romana_Kendelic));
            Cards.Add(Card.Quest("Apprehending the Killer", "", 6, 3, setName, 255)
                .WithFlavor("You've discovered the identity of the killer and the location of the rogue's secret hideout, but the villain is aware of your pursuit. You must move swiftly to apprehend the brigand!")
                .WithText("When Revealed: Each player besides the first player searches the encounter deck and discard pile for a Brigand enemy and adds it to the staging area. Shuffle the encounter deck.")
                .WithOppositeText("Ignore the Investigate keyword when the active location is explored.\r\nForced: At the beginning of the encounter phase, each suspect enemy in play engages the first player.\r\nWhile at least 1 Hideout location is in play, Suspect enemies cannot take damage. If there are no Suspect enemies in play, the players win the game.")
                .WithInfo(3, 1, Artist.JB_Casacop));
            Cards.Add(Card.Location("Bill Ferny's House", "", setName, 5, 5)
                .WithUnique()
                .WithTraits("Hideout.")
                .WithText("Immune to player card effects.\r\nWhile Bill Ferny's House is in the victory display, each Suspect, and each shadow card dealt to a Suspect, is immune to player card effects.\r\nTravel: Search the encounter deck, discard pile and victory display for Bill Ferny and add him to the staging area. Shuffle the encounter deck.")
                .WithVictoryPoints(5)
                .WithInfo(4, 1, Artist.Michael_Rasmussen));

            Cards.Add(Card.Location("Combe Storehouse", "", setName, 5, 5)
                .WithUnique()
                .WithTraits("Hideout.")
                .WithText("Immune to player card effects.\r\nWhile Combe Storehouse is in the victory display, each Suspect gains: \"Forced: After this enemy engages a player, it makes an immediate attack.\"\r\nTravel: Search the encounter deck and discard pile for a Lawless Ruffian and add it to the staging area. Shuffle the encounter deck.")
                .WithVictoryPoints(5)
                .WithInfo(5, 1, Artist.Alvaro_Calvo_Escudero));

            Cards.Add(Card.Location("Archet Trading Post", "", setName, 5, 5)
                .WithUnique()
                .WithTraits("Hideout.")
                .WithText("Immune to player card effects.\r\nWhile Archet Trading Post is in the victory display, each Suspect cannot take more than 5 damage each round.\r\nTravel: Search the encounter deck and discard pile for a Bree-land Informant and add it to the staging area. Shuffle the encounter deck.")
                .WithVictoryPoints(5)
                .WithInfo(7, 1, Artist.Yoann_Boissonnet));
            Cards.Add(Card.Location("Chetwood Campsite", "", setName, 5, 5)
                .WithUnique()
                .WithTraits("Hideout.")
                .WithText("Immune to player card effects.\r\nWhile Chetwood Campsite is in the victory display, each Suspect gets +1 Threat, +1 Attack and +1 Defense.\r\nTravel: Search the encounter deck and discard pile for a Chetwood Outlaw and add it to the staging area. Shuffle the encounter deck.")
                .WithVictoryPoints(5)
                .WithInfo(8, 1, Artist.Michael_Rasmussen));

            Cards.Add(Card.Enemy("Johnny Goblin-fingers", "", setName, 45, 3, 4, 4, 6)
                .WithUnique()
                .WithTraits("Suspect.", "Brigand.")
                .WithText("Cannot have attachments.\r\nForced: When Johnny Goblin-finders attacks, the defending player discards 1 random card from his hand and raises his threat by X, where X is the printed cost of the discarded card.")
                .WithVictoryPoints(5)
                .WithInfo(12, 1, Artist.Romana_Kendelic));

            Cards.Add(Card.Enemy("Bill Ferny", "", setName, 42, 3, 2, 3, 5)
                .WithUnique()
                .WithTraits("Bree.")
                .WithText("Cannot be optionally engaged.\r\nThe first treachery revealed each round gains doomed 1 and its effects cannot be canceled.")
                .WithShadow("Shadow: Either raise your threat by 4, or this attack is considered undefended.")
                .WithInfo(21, 1, Artist.Lutful_Valeriya_Romanovna));
            Cards.Add(Card.Enemy("Bree-land Informant", "", setName, 30, 3, 2, 1, 3)
                .WithTraits("Bree.")
                .WithText("Response: After Bree-land Information makes an attack against you, if it was dealt a shadow card with no shadow effect, raise your threat by 1 and spend 1 resource to look at the bottom card of the Investigation deck. Then, discard Bree-land Informant.")
                .WithInfo(22, 3, Artist.Brian_Valenzuela));

            Cards.Add(Card.Enemy("Greenway Footpad", "", setName, 25, 2, 4, 2, 4)
                .WithTraits("Brigand.")
                .WithText("When Revealed: Either raise each player's threat by 2 or Greenway Footpad makes an immediate attack against the first player.")
                .WithShadow("Shadow: Attacking enemy gets +1 Attack (+2 Attack instead if your threat is 35 or higher).")
                .WithInfo(24, 3, Artist.Brian_Valenzuela));
            Cards.Add(Card.Enemy("Chetwood Outlaw", "", setName, 40, 4, 4, 3, 5)
                .WithTraits("Brigand.")
                .WithText("Forced: After you optionally engaged Chetwood Outlaw, raise your threat by 4.")
                .WithShadow("Shadow: Either raise your threat by 2, or return attacking enemy to the staging area after this attack.")
                .WithInfo(25, 3, Artist.Micah_Epstein));
            Cards.Add(Card.Treachery("Hired Muscle", "", setName)
                .WithKeywords("Surge.")
                .WithText("When Revealed: Attach to a Brigand enemy without a copy of Hired Muscle attacked and return that enemy to the staging area. (Counts as a Condition attachment with the text: \"Attached enemy gets +1 Threat, +1 Attack, +1 Defense and gains: 'Forced: When attached enemy is defeated, look at the bottom of the Investigation deck.'\")")
                .WithInfo(26, 3, Artist.Rafal_Hrynkiewicz));

            Cards.Add(Card.Treachery("Deadly Accusations", "", setName)
                .WithText("When Revealed: Raise each player's threat by X, where X is 1 more than the Investigate value of the active location.")
                .WithShadow("Shadow: Attacking enemy gets +1 Attack, where X is the Investigate value of the active location.")
                .WithInfo(29, 2, Artist.Dmitry_Prosvirnin));
        }
    }
}