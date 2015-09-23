using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace HallOfBeorn.Models.Sets
{
    public class TheTreacheryOfRhudaur : CardSet
    {
        private const string setName = "The Treachery of Rhudaur";

        protected override void Initialize()
        {
            Name = setName;
            Abbreviation = "TToR";
            Number = 33;
            SetType = Models.SetType.Adventure_Pack;
            Cycle = "Angmar Awakened";

            Cards.Add(Card.Hero("Erestor", "", Sphere.Lore, 10, 2, 2, 2, 4)
                .WithTraits("Noldor.")
                .WithText("Draw 3 additional cards at the beginning of the resource phase.\r\nAt the end of the round, discard all cards in your hand.")
                .WithFlavor("\"That is the path of despair. Of folly, I would say, if the long wisdom of Elrond did not forbid me.\"\r\n-The Fellowship of the Ring")
                .WithTemplate("<p>Draw 3 additional cards at the beginning of the resource phase.</p><p>At the end of the round, discard all cards in your hand.</p><p class='flavor-text'>&quot;That is the path of despair. Of folly, I would say, if the long wisdom of Elrond did not forbid me.&quot;<br>&ndash;The Fellowship of the Ring</p>")
                .WithInfo(84, 1, Artist.Arden_Beckwith));
            Cards.Add(Card.Event("Reinforcements", "", Sphere.Leadership, 3)
                .WithText("You must spend resources from 3 different heroes' resource pools to play this card.\r\nAction: The players, as a group, can put up to 2 allies into play from their hands. Each of these allies may enter play under any player's control. At the end of the phase, return each of those allies that are still in play to their owners' hands.")
                .WithInfo(85, 3, Artist.Oleg_Saakyan));
            Cards.Add(Card.PlayerSideQuest("Send for Aid", "", Sphere.Leadership, 1, 6)
                .WithFlavor("\"Often the Rohirrim have aided us, but now the Lord Denethor asks for all your strength and all your speed...\"\r\n-Hirgon, The Return of the King")
                .WithText("Limit 1 per deck.\r\nResponse: When this stage is defeated, each player may search the top 10 cards of his deck for an ally and put it into play under his control. Each player who did shuffles his deck.")
                .WithInfo(86, 3, Artist.Tomasz_Jedruszek));
            Cards.Add(Card.Attachment("Elven Spear", "", Sphere.Tactics, 0)
                .WithTraits("Item.", "Weapon.")
                .WithKeywords("Restricted.")
                .WithText("Attach to a Noldor or Silvan hero.\r\nAction: Discard a card from your hand to give attached hero +1 Attack until the end of the phase. Limit 3 times per phase.")
                .WithFlavor("Their spears and swords shone in the gloom with a gleam of chill flame, so deadly was the wrath of the hands that held them.\r\n-The Hobbit")
                .WithTemplate("<p>Attach to a {traits-hero:Noldor,Silvan}. {keyword:Restricted.}</p><p><b>Action:</b> Discard a card from your hand to give attached hero +1 {Attack} until the end of the phase. Limit 3 times per phase.</p><p class='flavor-text'>Their spears and swords shone in the gloom with a gleam of chill flame, so deadly was the wrath of the hands that held them.<br>&ndash;The Hobbit</p>")
                .WithInfo(87, 3, Artist.Arden_Beckwith));
            Cards.Add(Card.Event("Horn's Cry", "", Sphere.Tactics, 2)
                .WithText("Action: All enemies get -1 Attack until the end of the phase.\r\nValour Action: Choose a player. Each enemy engaged with that player gets -3 Attack until the end of the phase.")
                .WithFlavor("Loud the challenge rang and bellowed, like the shout of many throats under the cavernous roof.\r\n-The Fellowship of the Ring")
                .WithInfo(88, 3, Artist.David_Vargo));
            Cards.Add(Card.Ally("Galadhrim Weaver", "", Sphere.Spirit, 1, 1, 0, 0, 1)
                .WithGeneric()
                .WithTraits("Silvan.", "Craftsman.")
                .WithText("Cannot attack or defend.\r\nResponse: After Galadhrim Weaver enters play, shuffle the top card of your discard pile into your deck.")
                .WithFlavor("\"You are indeed high in the favour of the Lady! For she herself and her maidens wove this...\" -Lórien Elf, The Fellowship of the Ring")
                .WithInfo(89, 3, Artist.Sara_Betsy));
            Cards.Add(Card.Attachment("Silver Harp", "", Sphere.Spirit, 2)
                .WithTraits("Item.", "Instrument.")
                .WithKeywords("Restricted.")
                .WithText("Attach to a Spirit hero.r\nResponse: After a card is discarded from your hand, exhaust Silver Harp to return that card to your hand.")
                .WithFlavor("Elrond wore a mantle of grey and had a star upon his forehead, and a silver harp was in his hand... -The Return of the King")
                .WithInfo(90, 3, Artist.Arden_Beckwith));
            Cards.Add(Card.Ally("Galdor of the Havens", "", Sphere.Lore, 4, 2, 2, 1, 4)
                .WithTraits("Noldor.")
                .WithText("Response:  After 1 or more cards are discarded from your hand, draw 1 card. Limit once per round.")
                .WithFlavor("\"But have they the strength, have we here the strength to withstand the Enemy, the coming of Sauron at the last, when all else is overthrown?\"\r\n-The Fellowship of the Ring")
                .WithInfo(91, 3, Artist.Arden_Beckwith));
            Cards.Add(Card.Event("The Door is Closed", "", Sphere.Lore, 1)
                .WithText("Response: After an encounter card is revealed from the encounter deck, cancel its effects and discard it if there is a card with the same title in the victory display.")
                .WithFlavor("\"...I perceive the Dark Lord and know his mind, or all of his mind that concerns the Elves. And he gropes ever to see me and my thought. But still the door is closed!\"\r\n-Galadriel, The Fellowship of the Ring")
                .WithInfo(92, 3, Artist.Magali_Villeneuve));
            Cards.Add(Card.Attachment("Elf-friend", "", Sphere.Neutral, 1)
                .WithTraits("Title.")
                .WithText("Attach to a character.\r\nAttached character gains the Noldor and Silvan traits.")
                .WithFlavor("\"I name you Elf-friend; and may the stars shine upon the end of your road!\"\r\n-Gildor, The Fellowship of the Ring")
                .WithInfo(93, 3, Artist.Sebastian_Giacobino));

            Cards.Add(Card.ObjectiveAlly("Amarthiúl", "", setName, 1, 3, 3, 3)
                .WithUnique()
                .WithNormalizedTitle("Amarthiul")
                .WithTraits("Dúnedain.", "Ranger.", "Warrior.")
                .WithText("Response: After an enemy engages a player, give control of Amarthiúl to that player.\r\nIf Amarthiúl leaves play, the players lose the game.")
                .WithInfo(96, 1, Artist.Tomasz_Jedruszek));
        }
    }
}