using System;

namespace HallOfBeorn.Models.LotR.Sets.VengeanceOfMordor
{
    public class TheLandOfSorrowSet
        : CardSet
    {
        public const string setName = "The Land of Sorrow";

        protected override void Initialize()
        {
            Name = setName;
            Abbreviation = "TLoSo";
            Number = 61;
            SetType = Models.SetType.Adventure_Pack;
            Cycle = "Vengeance of Mordor";

            IsSpoiler = true;

            addHero("Gwaihir", 13, Sphere.Tactics, 2, 4, 3, 4)
                .WithTraits("Creature.", "Eagle.")
                .WithKeywords("Ranged.", "Sentinel.")
                .WithTextLine("Ranged. Sentinel.")
                .WithTextLine("Cannot have restrited attachements. Gwaihir does not ready during the refresh phase.")
                .WithTextLine("Response: After an Eagle ally enters or leaves play, ready Gwaihir. (Limit once per phase.)")
                .WithInfo(108, 1, Artist.Carlos_Palma_Cruchaga);

            addAlly("Dale Messenger", 2, Sphere.Lore, false, 1, 1, 1, 2)
                .WithTraits("Dale.")
                .WithTextLine("Response: After Dale Messenger enters play, choose a player. That player heals 1 damage from each character he controls with a player card attachment.")
                .WithFlavorLine("\"We discover that messengers have come also to King Brand in Dale...\"")
                .WithFlavorLine("-Glóin, The Fellowship of the Ring")
                .WithInfo(111, 3, Artist.Sara_Biddle);
            addAttachment("Song of Healing", 0, Sphere.Lore, false)
                .WithTraits("Song.")
                .WithTextLine("Attach to a hero. Limit 1 per hero.")
                .WithTextLine("Action: Discard 1 card from your hand to heal 1 daamge from attached hero. Any player may trigger this effect.")
                .WithInfo(112, 3, Artist.Magali_Villeneuve);
            addAlly("Eagle Emissary", 2, Sphere.Tactics, false, 2, 1, 0, 2)
                .WithTraits("Creature.", "Eagle.")
                .WithTextLine("Cannot have restricted attachments.")
                .WithTextLine("Forced: After Eagle Emissary quests successfully, pay 1 Tactics resource or discard it from play.")
                .WithFlavorLine("...and out of the East there came a great Eagle flying, and he bore tidings beyond hope from The Lords of the West...")
                .WithFlavorLine("-The Return of the King")
                .WithInfo(113, 3, Artist.Carlos_Palma_Cruchaga);

            addAttachment("Spare Pipe", 1, Sphere.Spirit, false)
                .WithTraits("Item.", "Pipe.")
                .WithTextLine("Attach to a character.")
                .WithTextLine("Attached character gets +1 hit point.")
                .WithTextLine("Response: After you play Spare Pipe, search the top 5 cards of your deck for an event and add it to your hand. Shuffle your deck.")
                .WithFlavorLine("\"I have carried it a long way, though I don't know why.\"")
                .WithFlavorLine("-Pippin, The Two Towers")
                .WithInfo(115, 3, Artist.Unknown);

            addAlly("Wilyador", 1, Sphere.Neutral, true, 1, 3, 2, 3)
                .WithTraits("Creature.", "Eagle.")
                .WithKeywords("Ranged.", "Sentinel.")
                .WithTextLine("Ranged. Sentinel.")
                .WithTextLine("Cannot have restricted attachments.")
                .WithTextLine("Forced: At the end of the round, discard Wilyador unless the players as a group spend 1 resource.")
                .WithInfo(117, 3, Artist.Sam_White);

            addContract("Messenger of the King")
                .WithTextLine("You cannot choose more than 2 heroes during setup.")
                .WithTextLine("Setup: Choose a non-neutral unique ally from your deck and put it into play. Add the sum of that ally's printed Willpower, Attack, Defense, and hit points to your starting threat. Then, flip this card over and attach it to that ally.")
                .WithFlavorLine("\"I am a messenger of the King,\" he said. \"You are speaking to the King's friend, and one of the most renowned in all the lands of the West.\"")
                .WithFlavorLine("-Pippin, The Return of the King")
                .WithOppositeTextLine("Attached ally loses the ally card type and gains the hero card type.")
                .WithOppositeTextLine("Attached character cannot be readied more than once per phase.")
                .WithOppositeTextLine("Messenger of the King is immune to card effects while attached character is in play. If attached character leaves play, remove Messenger of the King from the game.")
                .WithTemplate("<p class='main-text'>You cannot choose more than 2 heroes during setup.</p><p class='main-text'><b>Setup:</b> Choose a <a href='/LotR?Query=-sphere%3ANeutral&CardType=Ally&IsUnique=Yes' title='Search non-neutral unique allies' target='_blank'>non-neutral unique ally</a> from your deck and put it into play. Add the sum of that ally's printed {Willpower}, {Attack}, {Defense}, and hit points to your starting threat. Then, flip this card over and attach it to that ally.</p><p class='flavor-text'>&ldquo;I am a messenger of the King,&rdquo; he said. &ldquo;You are speaking to the King's friend, and one of the most renowned in all the lands of the West.&rdquo;<br>&ndash;Pippin, The Return of the King</p>")
                .WithTemplate2("<p class='main-text'>Attached ally loses the ally card type and gains the hero card type.</p><p class='main-text'>Attached character cannot be readied more than once per phase.</p><p class='main-text'>{self} is immune to card effects while attached character is in play. <b>If attached character leaves play, remove {self} from the game.</b></p>")
                .WithInfo(134, 1, Artist.Justin_Gerard);
        }
    }
}