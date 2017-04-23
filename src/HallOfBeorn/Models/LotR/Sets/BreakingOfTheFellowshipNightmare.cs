using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace HallOfBeorn.Models.LotR.Sets
{
    public class BreakingOfTheFellowshipNightmare : CardSet
    {
        private const string setName = "Breaking of the Fellowship Nightmare";

        protected override void Initialize()
        {
            Name = setName;
            Abbreviation = "BotFN";
            SetType = Models.SetType.Nightmare_Expansion;
            Cycle = "NIGHTMARE";
            Number = 2067;

            addCard(LotRCard.NightmareSetup(setName, setName)
                .WithText("You are playing Nightmare mode.")
                .WithFlavor("\"The day has come at last.\" her said: \"the day of choice which we have long delayed. What shall now become of our Company that has travelled so far in fellowship?\"\r\n-Aragorn, The Fellowship of the Ring")
                .WithOppositeText("Begin with the standard and encounter deck for the Breaking of the ~Fellowship scenario.\r\nRemove the following cards, in the specified quantities, from the standard encounter deck:\r\n4x Uruk-hai ~Archer\r\n2x ~River Anduin\r\n1x Slopes of Amon Hen\r\n2x Black Feathered Arrows\r\nThen, shuffle the encounter cards in this Nightmare ~Deck into the remainder of the standard Breaking of the ~Fellowship encounter deck.\r\nFinally, flip this setup card over and place it next to the quest deck. Its effect remains active throughout the game, which is now ready to begin.")
                .WithInfo(1, 1, Artist.Matthew_Cowdery));
            addCard(LotRCard.Enemy("Isengard Archer", string.Empty, setName, 44, 2, 4, 2, 4)
                .WithTraits("Orc.", "Uruk-hai.")
                .WithKeywords("Toughness 1.", "Archery 2.")
                .WithText("Forced: After Isengard Archer enters the staging area, each player at this stage deals 2 damage to a character he controls.")
                .WithShadow("Shadow: Deal 2 damage to an ally you control.")
                .WithInfo(2, 3, Artist.Tristan_Denecke));
            addCard(LotRCard.Enemy("Isengard Tracker", string.Empty, setName, 35, 3, 5, 1, 3)
                .WithTraits("Orc.", "Uruk-hai.")
                .WithKeywords("Tougness 2.", "Archery 1.")
                .WithText("Forced: After Isengard Tracker destroys a character, move it to the first player's staging area.")
                .WithShadow("Shadow: After this attack, move attacking enemy to the first player's staging area.")
                .WithInfo(3, 4, Artist.Victor_Manuel_Leza_Moreno));
            addCard(LotRCard.Location("Langflood River", string.Empty, setName, 4, 4)
                .WithTraits("River.", "Forest.")
                .WithText("While Langflood River is in the staging area, no more than 4 progress can be placed on this quest stage each round.\r\nForced: When Langflood River leaves play as an explored location, add it to the staging area to the left, if able.")
                .WithInfo(4, 3, Artist.Michael_Rasmussen));
            addCard(LotRCard.Location("Western Emyn Muil", string.Empty, setName, 3, 4)
                .WithTraits("Forest.", "Hills.")
                .WithText("While Western Emyn Muil is in the staging area, each Uruk-hai enemy at this stage gains Toughness 1.\r\nTravel: A player at this stage must engage the highest toughness enemy in the staging area to travel here.")
                .WithInfo(5, 3, Artist.Michael_Rasmussen));
            addCard(LotRCard.Treachery("Arrows in the Night", string.Empty, setName)
                .WithKeywords("Peril.")
                .WithText("When Revealed: Until the end of the round, add 6 to the archery total at this stage. You may discard X cards from hand to reduce the archery total at this stage by X until the end of the round.")
                .WithShadow("Shadow: Discard 1 random card from your hand.")
                .WithInfo(6, 2, Artist.Matthew_Cowdery));
            addCard(LotRCard.Treachery("Hunting the Ring", string.Empty, setName)
                .WithKeywords("Surge.")
                .WithText("When Revealed: Attach to the current quest. (Counts a Condition attachment with the text: \"Forced: At the end of the round, each player at this stage raises his threat by 1 for each enemy in the staging area. Then, discard Hunting the Ring and move each enemy in this staging area to the first player's staging area.\")")
                .WithInfo(7, 2, Artist.Tawny_Fritzinger));
            addCard(LotRCard.Treachery("Discord and Distrust", string.Empty, setName)
                .WithKeywords("Doomed 2.")
                .WithText("When Revealed: Until the end of the round, players cannot trigger Action or Response effects.")
                .WithShadow("Shadow: Until the end of the round, defending character cannot ready.")
                .WithInfo(8, 2, Artist.JB_Casacop));
        }
    }
}