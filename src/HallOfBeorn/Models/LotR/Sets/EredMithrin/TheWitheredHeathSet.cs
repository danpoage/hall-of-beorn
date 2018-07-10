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
            addEvent("Beorn's Rage", 1, Sphere.Tactics)
                .WithText("Response: After a Beorning character is declared as an attacker or defender against and enemy, that enemy gets -2 Attack and -2 Defense until the end of the phase.")
                .WithFlavor("Swiftly he returned and his wrath ewas redoubled, so that nothing could withstand him, and no weapon seemed to bite upon him. -The Hobbit")
                .WithInfo(7, 3, Artist.Guillaume_Ducos);
            addEvent("The Hidden Way", 2, Sphere.Lore)
                .WithText("Response: At the beginning of the quest phase, search the top 5 cards of the encounter deck for a location and make it the active location, returning any previous active location to the staging area. Then, reveal 1 less encounter card this phase (to a minimum of 0). Shuffle the encounter deck.")
                .WithInfo(9, 3, Artist.Unknown);
        }
    }
}