using System;

namespace HallOfBeorn.Models.LotR.Sets.StarterDeck
{
    public class DwarvesOfDurinSet
        : CardSet
    {
        public const string setName = "Dwarves of Durin";

        protected override void Initialize()
        {
            Name = setName;
            Abbreviation = "DoD";
            SetType = Models.SetType.Starter_Deck;
            Cycle = "Starter Deck";
            Number = 5003;

            addHero("Dáin Ironfoot", 11, Sphere.Leadership, 1, 2, 3, 5)
                .WithTraits("Dwarf.", "Noble.")
                .WithTextLine("While Dáin Ironfoot is ready, Dwarf characters get +1 Attack and +1 Willpower.")
                .WithFlavorLine("\"You have not heard of Dáin and the dwarves of the Iron Hills?\"")
                .WithFlavorLine("-Bilbo Baggins, The Hobbit")
                .WithCommunityVersion("Autumn/Dain-Ironfoot-Leadership")
                .WithCommunityVersion("RiddermarkLord/Dain-Ironfoot-Leadership-Hero-1")
                .WithCommunityVersion("RiddermarkLord/Dain-Ironfoot-Leadership-Hero-2")
                .WithCommunityVersion("RiddermarkLord/Dain-Ironfoot-Leadership-Hero-3")
                .WithCommunityVersion("Hrodebert/Dain-Ironfoot-Leadership-Hero-1")
                .WithCommunityVersion("Hrodebert/Dain-Ironfoot-Leadership-Hero-2")
                .WithCommunityVersion("Hrodebert/Dain-Ironfoot-Leadership-Hero-3")
                .WithErrata(1)
                .WithInfo(1, 1, Artist.Tiziano_Baracchi);
            addHero("Ori", 8, Sphere.Lore, 2, 2, 1, 3)
                .WithTraits("Dwarf.")
                .WithTextLine("If you control at least 5 Dwarf characters, draw 1 additional card at the beginning of the resource phase.")
                .WithFlavorLine("\"He could write well and speedily, and often used the Elvish characters.\"")
                .WithFlavorLine("-Gimli, The Fellowship of the Ring")
                .WithCommunityVersion("RiddermarkLord/Ori-Lore-Hero-1")
                .WithCommunityVersion("RiddermarkLord/Ori-Lore-Hero-2")
                .WithCommunityVersion("Hrodebert/Ori-Lore-Hero")
                .WithInfo(2, 1, Artist.Blake_Henriksen);
            addHero("Bifur", 7, Sphere.Lore, 2, 1, 2, 3)
                .WithTraits("Dwarf.")
                .WithTextLine("Action: Pay 1 resource from a hero's resource pool to add 1 resource to Bifur's resource pool. Any player may trigger this ability. (Limit once per round.)")
                .WithFlavorLine("\"And winter comes after autumn.\" - Bifur, The Hobbit")
                .WithCommunityVersion("Autumn/Bifor-Lore-Hero")
                .WithInfo(3, 1, Artist.Magali_Villeneuve);

            addAlly("Bombur", 3, Sphere.Lore, true, 0, 0, 1, 3)
                .WithTraits("Dwarf.")
                .WithTextLine("Action: Exhaust Bombur to choose a location. That location gets -1 Threat until the end of the phase. (That location does not contribute its Threat instead if it is an Underground location.)")
                .WithCommunityVersion("RiddermarkLord/Bombur-MotK-Lore-Hero")
                .WithInfo(4, 3, Artist.Winona_Nelson);
            addAlly("Dori", 3, Sphere.Lore, true, 1, 2, 1, 3)
                .WithTraits("Dwarf.")
                .WithTextLine("Response: After a hero is assigned any amount of damage, exhaust Dori to place that damage on Dori instead.")
                .WithFlavorLine("'I can't always be carrying burglars on my back,' said Dori, 'down tunnels and up trees! What do you think I am? A porter?'")
                .WithFlavorLine("-Dori, The Hobbit")
                .WithInfo(5, 3, Artist.Jake_Murray);
            addAlly("Erebor Hammersmith", 2, Sphere.Lore, false, 1, 1, 1, 3)
                .WithTraits("Dwarf.", "Craftsman.")
                .WithTextLine("Response: After you play Erebor Hammersmith, return the topmost attachment in any player's discard pile to his hand.")
                .WithFlavor("\"In Erebor in the Kingdom of Dain there is such skill...\" -Aragorn, The Return of the King")
                .WithInfo(6, 3, Artist.Empty_Room_Studios);
            addAlly("Erebor Record Keeper", 1, Sphere.Lore, false, 1, 0, 0, 1)
                .WithTraits("Dwarf.")
                .WithTextLine("Erebor ~Record Keeper cannot attack or defend.")
                .WithTextLine("Action: Exhaust Erebor ~Record Keeper and pay 1 Lore resource to choose and ready a Dwarf character.")
                .WithInfo(7, 3, Artist.Andrew_Johanson);
            addAlly("Ered Luin Miner", 3, Sphere.Neutral, false, 1, 1, 1, 2)
                .WithTraits("Dwarf.")
                .WithTextLine("Response: After Ered Luin Miner is discarded from your deck, put it into play under your control.")
                .WithFlavorLine("Tools were to be found in plenty that the miners and quarriers and builders of old had used; and at such work the dwarves were still very skilled.")
                .WithFlavorLine("-The Hobbit")
                .WithErrata(1)
                .WithInfo(8, 3, Artist.Lukasz_Jaskolski);
            addAlly("Ered Nimrais Prospector", 2, Sphere.Lore, false, 1, 0, 1, 2)
                .WithTraits("Dwarf.")
                .WithTextLine("Response: After Ered Nimrais Prospector enters play, discard the top 3 cards of your deck. Then, choose and shuffle 1 card from your discard pile back into your deck.")
                .WithInfo(9, 3, Artist.Jason_Ward);
            addAlly("Gandalf", 5, Sphere.Neutral, true, 4, 4, 4, 4)
                .WithTraits("Istari.")
                .WithTextLine("At the end of the round, discard Gandalf from play.")
                .WithTextLine("Response: After Gandalf enters play, (choose 1): draw 3 cards, deal 4 damage to 1 enemy in play, or reduce your threat by 5.")
                .WithCommunityVersion("Gandalf-Core-Set-Completion")
                .WithInfo(10, 3, Artist.Lucas_Graciano);
            addAlly("Glóin", 3, Sphere.Leadership, true, 2, 1, 1, 3)
                .WithTraits("Dwarf.")
                .WithTextLine("While you control at least 5 Dwarf characters, Glóin gains: 'Response: After you play Glóin from your hand, choose a hero. Add 2 resources to that hero's resource pool.'")
                .WithFlavorLine("Glóin lit several more torches, and then they all crept out, one by one...")
                .WithFlavorLine("-The Hobbit")
                .WithInfo(11, 3, Artist.Jeff_Lee_Johnson);
            addAlly("Longbeard Elder", 3, Sphere.Leadership, false, 2, 1, 1, 2)
                .WithTraits("Dwarf.")
                .WithTextLine("Response: After Longbeard Elder commits to a quest, look at the top card of the encounter deck. If that card is a location, place 1 progress token on the current quest. Otherwise, Longbeard Elder gets -1 Willpower until the end of the phase.")
                .WithInfo(12, 3, Artist.Eric_Braddock);
            addAlly("Miner of the Iron Hills", 2, Sphere.Lore, false, 0, 1, 1, 2)
                .WithTraits("Dwarf.")
                .WithTextLine("Response: After Miner of the Iron ~Hills enters play, choose and discard 1 Condition attachment from play.")
                .WithFlavor("...while the four dwarves sat around the table, and talked about mines and gold and troubles with goblins...\r\n-The Hobbit")
                .WithInfo(13, 2, Artist.Loren_Fetterman);
            addAttachment("Cram", 0, Sphere.Leadership, false)
                .WithTraits("Item.")
                .WithTextLine("Attach to a hero.")
                .WithTextLine("Action: Discard Cram to ready attached hero.")
                .WithInfo(14, 3, Artist.Adam_Lane);
            addAttachment("Healing Herbs", 0, Sphere.Lore, false)
                .WithTraits("Item.")
                .WithTextLine("Attach to a Lore hero.")
                .WithTextLine("Action: Discard Healing Herbs and exhaust attached hero to heal all damage on 1 character.")
                .WithErrata(1)
                .WithInfo(15, 3, Artist.Sara_Biddle);
            addAttachment("King Under the Mountain", 2, Sphere.Leadership, true)
                .WithTraits("Title.")
                .WithTextLine("Attach to a Dwarf hero.")
                .WithTextLine("Action: Exhaust King Under the Mountain to look at the top 2 cards of your deck. Add 1 to your hand and discard the other.")
                .WithFlavorLine("\"Long ago in my grandfather Thror's time our family was driven out of the far North, and came back with all their wealth and tools to this Mountain on the map.\"")
                .WithFlavorLine("-Thorin, The Hobbit")
                .WithInfo(16, 3, Artist.Magali_Villeneuve);
            addAttachment("Legacy of Durin", 1, Sphere.Lore, true)
                .WithTraits("Condition.")
                .WithTextLine("Attach to a Dwarf hero.")
                .WithTextLine("Response: After you play a Dwarf character from your hand, exhaust Legacy of Durin to draw 1 card.")
                .WithErrata(1)
                .WithInfo(17, 3, Artist.Ilich_Henriquez);
            addAttachment("Narvi's Belt", 2, Sphere.Leadership, true)
                .WithTraits("Item.")
                .WithTextLine("Attach to a Dwarf hero.")
                .WithTextLine("Action: Exhaust Narvi's Belt to give attached hero a Leadership, Lore, Tactics, or Spirit icon until the end of the phase.")
                .WithErrata(1)
                .WithInfo(18, 3, Artist.Carolina_Eade);
            addAttachment("Thrór's Map", 1, Sphere.Lore, true)
                .WithTraits("Artifact.", "Item.")
                .WithText("Attach to a hero.\r\nTravel Action: Discard Thrór's Map to choose a location in the staging area. Make that location the active location. (If there is another active location, return it to the staging area.)")
                .WithFlavor("\"This was made by Thrór, your grandfather, Thorin.\" he said in answer to the dwarves' excited questions. \"It is a plan of the Mountain.\" -Gandalf, The Hobbit")
                .WithErrata(2)
                .WithInfo(19, 3, Artist.Jake_Murray);
            addEvent("A Very Good Tale", 0, Sphere.Leadership)
                .WithTextLine("Action: Exhaust 2 allies you control to shuffle your deck and discard the top 5 cards. Put up to 2 allies discarded by this effect into play under your control. The total cost of the allies put into play cannot exceed the total cost of the allies exhausted to pay for this effect.")
                .WithInfo(20, 3, Artist.Magali_Villeneuve);
            addEvent("Hidden Cache", 0, Sphere.Neutral)
                .WithTextLine("Response: After Hidden Cache is discarded from your deck, add 2 resources to the resource pool of a hero you control.")
                .WithTextLine("Action: Spend 1 resource to draw 1 card.")
                .WithFlavorLine("...there was a good deal of food jumbled carlessly on shelves and on the ground, among an untidy litter of plunder...")
                .WithFlavorLine("-The Hobbit")
                .WithInfo(21, 3, Artist.Aurelien_Hubert);
            addEvent("Lure of Moria", 3, Sphere.Leadership)
                .WithTextLine("Action: Ready all Dwarf characters.")
                .WithTemplate("<p><b>Action:</b> Ready all {trait:Dwarf.@Dwarf} characters.</p><p class='flavor-text'>'The road that I speak of leads to the Mines of Moria,' said Gandalf. Only Gimli lifted up his head; a smouldering fire was in his eyes.<br>&ndash;The Fellowship of the Ring</p>")
                .WithInfo(22, 3, Artist.Mike_Nash);
            addEvent("We Are Not Idle", 0, Sphere.Leadership)
                .WithTextLine("Action: Exhaust X Dwarf heroes to add X resources to a hero's resource pool and draw 1 card.")
                .WithFlavorLine("\"You should see the stone-paved roads of many colours! And the halls and cavernous streets under the earth with arches carved like trees; and the terraces and towers upon the Mountain's sides! Then you would see that we have not been idle.\"")
                .WithFlavorLine("-Glóin, The Fellowship of the Ring")
                .WithErrata(1)
                .WithInfo(23, 3, Artist.Charles_Urbach);
            addEvent("Durin's Song", 1, Sphere.Leadership)
                .WithTraits("Song.")
                .WithTextLine("Action: Choose a Dwarf hero. That hero gets +2 Willpower, +2 Attack, and +2 Defense until the end of the round.")
                .WithFlavorLine("A king he was on carven throne")
                .WithFlavorLine("In many-pillared halls of stone")
                .WithFlavorLine("With golden roof and silver floor,")
                .WithFlavorLine("And runes of power upon the door.")
                .WithFlavorLine("-The Fellowship of the Ring")
                .WithInfo(24, 3, Artist.Cristi_Balanescu);

            //Sideboard
            addHero("Nori", 40, Sphere.Spirit, 2, 1, 2, 4)
                .WithTraits("Dwarf.")
                .WithTextLine("Response: After you play a Dwarf character from your hand, reduce your threat by 1.")
                .WithFlavorLine("\"Nori, at your service.\"")
                .WithFlavorLine("-Nori, The Hobbit")
                .WithCommunityVersion("RiddermarkLord/Nori-Spirit-Hero-1")
                .WithCommunityVersion("RiddermarkLord/Nori-Spirit-Hero-2")
                .WithCommunityVersion("Hrodebert/Nori-Spirit-Hero")
                .WithErrata(1)
                .WithInfo(25, 1, Artist.Blake_Henriksen);
            addAlly("Kili", 3, Sphere.Spirit, true, 1, 1, 1, 2)
                .WithTraits("Dwarf.")
                .WithTextLine("Response: After you play Kili from your hand during the planning phase, search your deck for Fili and put him into play under your control. Then, shuffle your deck.")
                .WithInfo(26, 3, Artist.Carmen_Cianelti);
            addAlly("Fili", 3, Sphere.Leadership, true, 1, 1, 1, 2)
                .WithTraits("Dwarf.")
                .WithTextLine("Response: After you play Fili from your hand during the planning phase, search your deck for Kili and put him into play under your control. Then, shuffle your deck.")
                .WithInfo(27, 3, Artist.Carmen_Cianelti);
            addAlly("Zigil Miner", 2, Sphere.Spirit, false, 1, 1, 1, 1)
                .WithTraits("Dwarf.")
                .WithTextLine("Action: Exhaust Zigil Miner and name a number to discard the top 2 cards of your deck. If at least one of those cards has cost equal to the named number, choose a hero you control. For each card that matches the named number, add 1 resource to that hero's resource pool.")
                .WithErrata(1)
                .WithInfo(28, 3, Artist.Magali_Villeneuve);
            addAlly("Erebor Guard", 4, Sphere.Spirit, false, 0, 1, 2, 3)
                .WithTraits("Dwarf.", "Warrior.")
                .WithKeywords("Sentinel.")
                .WithTextLine("Sentinel.")
                .WithTextLine("Response: When you play Erebor Guard from your hand, discard the top 2 cards of your deck to reduce its cost by 2.")
                .WithFlavorLine("...the fortress of the dwarves could not be taken by surprise.")
                .WithFlavorLine("-The Hobbit")
                .WithTemplate("<p class='main-text'>{keyword:Sentinel.}</p><p class='main-text'><b>Response:</b> When you play {self} from your hand, discard the top 2 cards of your deck to reduce its cost by 2.</p><p class='flavor-text'>...the fortress of the dwarves could not be taken by surprise. &ndash;The Hobbit</p>")
                .WithInfo(29, 3, Artist.Marius_Bota);
            addAttachment("Dwarf Pipe", 1, Sphere.Spirit, false)
                .WithTraits("Item.", "Pipe.")
                .WithTextLine("Attach to a Dwarf character. Limit 1 per character.")
                .WithTextLine("Response: After a card is discarded from the top of your deck, exhaust ~Dwarf ~Pipe to place that card on the bottom of your deck.")
                .WithFlavorLine("He held a small pipe with a wide flattened bowl...")
                .WithFlavorLine("-The Two Towers")
                .WithInfo(30, 3, Artist.Mark_Bulahao);
            addAttachment("Magic Ring", 2, Sphere.Neutral, false)
                .WithTraits("Artifact.", "Item.", "Ring.")
                .WithTextLine("Attach to a hero. Limit 1 per hero and 1 per deck.")
                .WithTextLine("Action: Exhaust Magic ~Ring and raise your threat by 1 to (choose 1): heal 1 damage from attached hero, add 1 resource to attached hero's pool, or ready attached hero.")
                .WithFlavorLine("\"In Eregion long ago many Elven-rings were made, magic rings as you call them, and they were, of course, of various kinds...\"")
                .WithFlavorLine("-Gandalf, The Fellowship of the Ring")
                .WithInfo(31, 1, Artist.Lucas_Durham);
        }
    }
}