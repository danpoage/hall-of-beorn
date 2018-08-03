using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace HallOfBeorn.Models.LotR.Sets.EredMithrin
{
    public class TheWitheredHeathSet : CardSet
    {
        private const string setName = "The Withered Heath";

        protected override void Initialize()
        {
            Name = setName;
            Abbreviation = "TWH";
            Number = 50;
            SetType = Models.SetType.Adventure_Pack;
            Cycle = "Ered Mithrin";

            IsSpoiler = true;

            addHero("Grimbeorn the Old", 11, Sphere.Tactics, 0, 3, 3, 5)
                .WithTraits("Beorning.", "Warrior.")
                .WithKeywords("Sentinel.")
                .WithText("Response: After Grimbeorn the Old defends an attack, spend 1 resource from his pool to declare him as an attacker against that enemy (and resolve his attack). The defending enemy gets -2 Defense for this attack.")
                .WithInfo(1, 1, Artist.Jason_Jenicke);
            addAlly("Guardian of Esgaroth", 2, Sphere.Leadership, false, 1, 1, 1, 1)
                .WithTraits("Dale.")
                .WithText("Guardian of Esgaroth gets +1 Willpower, +1 Attack, +1 Defense, and +1 hit point for each different player card attachment it has. (Limit +3 to each.)")
                .WithFlavor("The men of the lake-town Esgaroth were mostly indoors, for the breeze was from the black East and chill, but a few were walking on the quays, and watching...\r\n-The Hobbit")
                .WithInfo(2, 3, Artist.Guillaume_Ducos);
            addAttachment("Squire's Helm", 1, Sphere.Leadership, false)
                .WithTraits("Item.", "Armor.")
                .WithKeywords("Restricted.")
                .WithText("Attach to an ally. Limit 1 per ally. Attached ally gets +2 hit points.")
                .WithFlavor("\"There are no great weapon-hoards here, lord,\" answered Éomer. \"Maybe a light helm might be found to fit him...\"\r\n-The Return of the King")
                .WithTemplate("<p class='main-text'>Attach to an ally. {keyword:Restricted.}</p><p class='main-text'>Limit 1 per ally.</p><p class='main-text'>Attached ally gets +2 hit points.</p><p class='flavor-text'>&ldquo;There are no great weapon-hoards here, lord,&rdquo; answered Éomer. &ldquo;Maybe a light helm might be found to fit him...&rdquo;<br>&ndash;The Return of the King</p>")
                .WithInfo(3, 3, Artist.Sara_Biddle);
            addAlly("Beorning Skin-changer", 2, Sphere.Tactics, false, 1, 1, 1, 3)
                .WithTraits("Beorning.")
                .WithText("Combat Action: Choose a Beorning ally with printed cost 3 or more in your hand of discard pile. Discard ~Beorning Skin-changer to put that ally into play.")
                .WithFlavor("...sometimes he is a huge black bear, sometimes he is a great strong black-haired man with huge arms and a great bear.\"\r\n-Gandalf, The Hobbit")
                .WithInfo(4, 3, Artist.Unknown);
            addEvent("Beorn's Rage", 1, Sphere.Tactics)
                .WithText("Response: After a Beorning character is declared as an attacker or defender against an enemy, that enemy gets -2 Attack and -2 Defense until the end of the phase.")
                .WithFlavor("Swiftly he returned and his wrath was redoubled, so that nothing could withstand him, and no weapon seemed to bite upon him. -The Hobbit")
                .WithInfo(5, 3, Artist.Guillaume_Ducos);
            addAttachment("Woodmen's Clearing", 0, Sphere.Lore, false)
                .WithTraits("Condition.")
                .WithText("Attach to a location. Limit 1 per location.\r\nResponse: When attached location leaves play as an explored location, the first player reduces his threat by 3.")
                .WithInfo(6, 3, Artist.Unknown);
            addEvent("The Hidden Way", 2, Sphere.Lore)
                .WithText("Response: At the beginning of the quest phase, search the top 5 cards of the encounter deck for a location and make it the active location, returning any previous active location to the staging area. Then, reveal 1 less encounter card this phase (to a minimum of 0). Shuffle the encounter deck.")
                .WithInfo(7, 3, Artist.Unknown);
            addAlly("Long Lake Fisherman", 2, Sphere.Spirit, false, 1, 1, 0, 2)
                .WithTraits("Dale.")
                .WithText("Response: After Long Lake Fisherman enters play, name a number. Then, search the top 5 cards of your deck for a card whose printed cost is equal to that number and add it to your hand. Shuffle your deck.")
                .WithInfo(8, 3, Artist.Unknown);
            addAttachment("Grey Cloak", 0, Sphere.Spirit, false)
                .WithTraits("Item.")
                .WithText("Attach to a Spirit or Scout character. Limit 1 per character.\r\nEncounter Action: Exhaust attached character and discard Grey Cloak to choose a non-unique enemy in the staging area. That enemy does not make engagement checks against you this phase.")
                .WithInfo(9, 3, Artist.Unknown);
            addAttachment("The Arkenstone", 1, Sphere.Neutral, true)
                .WithTraits("Artifact.", "Item.")
                .WithKeywords("Guarded (enemy or location).")
                .WithText("Attach to a hero.\r\nEach unique character you control gains +1 Willpower.\r\nAction: Reduce your threat by 2 to attach The Arkenstone to a hero controller by another player and raise that player's threat by 2. (Limit once per round.)")
                .WithInfo(10, 3, Artist.Unknown);
        }
    }
}