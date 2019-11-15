using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace HallOfBeorn.Models.LotR.Sets.VengeanceOfMordor
{
    public class ChallengeOfTheWainridersSet 
        : CardSet
    {
        public const string setName = "Challenge of the Wainriders";

        protected override void Initialize()
        {
            Name = setName;
            Abbreviation = "CotW";
            Number = 59;
            SetType = Models.SetType.Adventure_Pack;
            Cycle = "Vengeance of Mordor";

            IsSpoiler = true;

            addHero("Saruman", 13, Sphere.Lore, 3, 4, 2, 4)
                .WithTraits("Istari.", "Isengard.")
                .WithText("When a player card effect would reduce your threat by any amount, reduce that amount to 1.\r\nWhen you play an event with the printed doomed keyword, Saruman gains the printed Leadership, Spirit, and Tactics icons.\r\nResponse: When you play a card with the Doomed keyword, ready Saruman.")
                .WithTemplate("<p class='main-text'>When a player card effect would reduce your threat by any amount, reduce that amount to 1.</p><p class='main-text'>When you play <a href='/LotR?Query=%2Bkeyword%3ADoomed&CardType=Event' target='_blank' title='Doomed Events'>an event with the printed doomed keyword</a>, {self} gains the printed {sphere:Leadership}, {sphere:Spirit}, and {sphere:Tactics} icons.<p><p class='main-text'><b>Response:</b> When you play a card with the doomed keyword, ready {self}.</p>")
                .WithInfo(54, 1, Artist.Martin_de_Diego_Sadaba);
            addAttachment("Power of Command", 1, Sphere.Leadership, false)
                .WithTraits("Master.")
                .WithText("Attach to the hero with The One Ring.\r\nLimit 1 per hero. Attached hero gets +1 Willpower.\r\nResponse: After attached hero commits to the quest, exhaust The One Ring and raise your threat by 1 to give each other unique character you control +1 Willpower until the end of the phase.")
                .WithInfo(55, 3, Artist.Borja_Pindado);
            addEvent("Horns! Horns! Horns!", 0, Sphere.Leadership)
                .WithKeywords("Doomed 2.")
                .WithText("Doomed 2.\r\nAction: Each player may put one ally card into play from his hand. At the end of the phase, shuffle each of those allies that are still in play into their owners' decks.")
                .WithInfo(56, 3, Artist.Federico_Musetti);
            addEvent("Far-sighted", 0, Sphere.Lore)
                .WithKeywords("Doomed 1.")
                .WithText("Doomed 1.\r\nAction: Look at the top 5 cards of the encounter deck. Put them back in the same order.")
                .WithFlavor("...Legolas was standing, gazing northwards into the darkness, thoughtful and silent as a young tree in a windless night.\r\n-The Two Towers")
                .WithInfo(58, 3, Artist.Vilius_Petrauskas);
            addAlly("Nori", 3, Sphere.Tactics, true, 1, 2, 1, 2)
                .WithTraits("Dwarf.")
                .WithText("Response: After Nori participates in an attack that destroys an enemy, put the top card of your discard pile on the bottom of your deck.")
                .WithFlavor("\"You've left the burglar behind again!\"\r\n-Nori, The Hobbit")
                .WithInfo(59, 3, Artist.David_Keen);
            addAttachment("Golden Belt", 0, Sphere.Tactics, false)
                .WithTraits("Item.")
                .WithText("Attach to a hero. Limit 1 per hero.\r\nAttached hero can have 1 additional restricted attachment.")
                .WithFlavor("The lady bowed her head, and she turned to Boromir and to him she gave a belt of gold...\r\n-The Fellowship of the Ring")
                .WithInfo(60, 3, Artist.Nino_Vecia);
            addAlly("Rohirrim Scout", 2, Sphere.Spirit, false, 1, 1, 0, 2)
                .WithTraits("Rohan.", "Scout.")
                .WithText("Action: Discard Rohirrim Scout to choose a non-unique enemy in the staging area. That enemy does not make engagement checks against you this round.")
                .WithFlavor("Swiftly a scout rode back and reported that wolf-riders were abroad in the valley...\r\n-The Two Towers")
                .WithInfo(61, 3, Artist.Federico_Musetti);
            addAttachment("Saruman's Staff", 2, Sphere.Neutral, true)
                .WithTraits("Artifact.", "Item.", "Staff.")
                .WithKeywords("Restricted.")
                .WithText("Attach to Saruman. Restricted.\r\nAction: Exhaust Saruman's Staff to (choose 1): Reduce the X value of the next Doomed X event you play this phase by 2, or search the top 5 cards of your deck for a Doomed event and add it to your hand. Shuffle your deck.)")
                .WithFlavor("His hand clutched his heavy black staff like a claw.\r\n-The Two Towers")
                .WithInfo(63, 3, Artist.Nikolas_Hagialas);
            addContract("The Grey Wanderer")
                .WithText("You cannot choose more than 1 starting hero.\r\nSetup: ~Search your deck for an attachment with a printed cost of 1 and put it into play. Then, flip this card over.")
                .WithFlavor("\"...the rule of no realm is mine, neither of Gondor nor any other, great or small. But all worthy things that are in peril as the world now stands, those are my card.\"\r\n-Gandalf, The Return of the King")
                .WithTemplate("<p class='main-text'>You cannot choose more than 1 starting hero.</p><p class='main-text'><b>Setup:</b> Search your deck for an <a href='/LotR?CardType=Attachment&Cost=1&CostOperator=eq' target='_blank' title='1-cost attachments'>attachment with a printed cost of 1</a> and put it into play. Then, flip this card over.</p><p class='flavor-text'>&rdquo;...the rule of no realm is mine, neither of Gondor nor any other, great or small. But all worthy things that are in peril as the world now stands, those are my card.&ldquo;<br>&ndash;Gandalf, The Return of the King</p>")
                .WithOppositeText("The first non-unique card you play each planning phase does not require a resource match.\r\nAction: Exhaust this card and raise your threat by 1 to (choose two): Ready your starting hero, add 2 resources to your starting hero's resource pool, or heal 3 damage from your starting hero.")
                .WithOppositeFlavor("\"...this shall be his great task, and maybe the end of his labours.\"\r\n-Elrond, The Fellowship of the Ring")
                .WithTemplate2("<p class='main-text'>The first non-unique card you play each planning phase does not require a resource match.</p><p class='main-text'><b>Action:</b> Exhaust this card and raise your threat by 1 to <i>(choose two)</i>: Ready your starting hero, add 2 resources to your starting hero's resource pool, or heal 3 damage from your starting hero.</p><p class='flavor-text'>&ldquo;...this shall be his great task, and maybe the end of his labours.&rdquo;<br>&ndash;Elrond, The Fellowship of the Ring</p>")
                .WithInfo(74, 1, Artist.Justin_Gerard);
        }
    }
}