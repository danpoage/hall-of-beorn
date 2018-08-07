using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace HallOfBeorn.Models.LotR.Sets.EredMithrin
{
    public class FireInTheNightSet : CardSet
    {
        private const string setName = "Fire in the Night";

        protected override void Initialize()
        {
            Name = setName;
            Abbreviation = "FitN";
            Number = 52;
            SetType = Models.SetType.Adventure_Pack;
            Cycle = "Ered Mithrin";

            IsSpoiler = true;

            addHero("Thranduil", 9, Sphere.Leadership, 1, 1, 3, 4)
                .WithTraits("Silvan.", "Noble.")
                .WithText("Combat Action: Play a Silvan ally from your hand. You do not need a resource match for this ally. (Limit once per round.)")
                .WithFlavor("\"It is a crime to wander in my realm without leave.\"\r\n-The Hobbit")
                .WithInfo(56, 1, Artist.Magali_Villeneuve);
            addAttachment("The Elvenking", 1, Sphere.Leadership, true)
                .WithTraits("Title.")
                .WithText("Attach to a Silvan hero.\r\nAction: Exhaust The Elvenking and return a Silvan ally you control to your hand to ready attached hero.")
                .WithFlavor("In a great hall with pillars hewn out of the living stong sat the Elvenking on a chair of carven wood.\r\n-The Hobbit")
                .WithInfo(57, 3, Artist.Tropa_Entertainment);
            addAttachment("Orcrist", 1, Sphere.Leadership, true)
                .WithTraits("Artifact.", "Item.", "Weapon.")
                .WithKeywords("Guarded (enemy or location).", "Restricted.")
                .WithText("Attach to a hero.\r\nAttached hero gets +2 Attack.\r\nResponse: After attached hero drestroys an enemy, add 1 resource to attached hero's pool.")
                .WithTemplate("<p class='main-text'>{keyword:Guarded+%28enemy+or+location%29.@Guarded (enemy or location).}</p><p class='main-text'>Attach to a hero. {keyword:Restricted.}</p><p class='main-text'>Attached hero gets +2 {Attack}.</p><p class='main-text'><b>Response:</b> After attach hero destroys an enemy, add 1 resource to attached hero's pool.</p>")
                .WithInfo(58, 3, Artist.Aleksander_Karcz);
            addAlly("Galion", 0, Sphere.Spirit, true, 0, 0, 0, 1)
                .WithTraits("Silvan.")
                .WithText("Cannot attack or defend.\r\nResponse: After Galion enters play, he gets +1 Willpower until the end of the round.")
                .WithFlavor("\"Here am I waiting and waiting down hero, while you fellows drink and make merry and forget your tasks. Small wonder if I fall asleep from weariness!\"\r\n-The Hobbit")
                .WithInfo(63, 3, Artist.Torbjorn_Kallstrom);
            addAlly("Forest Road Traveler", 2, Sphere.Lore, false, 1, 1, 1, 2)
                .WithTraits("Woodman.", "Scout.")
                .WithText("~Forest ~Road Traveler gets +1 Willpower, +1 Attack, and +1 Defense for each attachment on the active location.")
                .WithFlavor("Only on the Road would travellers be found...\r\n-The Fellowship of the Ring")
                .WithInfo(67, 3, Artist.Unknown);
            addAlly("Thalion", 4, Sphere.Neutral, true, 2, 2, 2, 3)
                .WithTraits("Dúnedain.", "Ranger.")
                .WithText("While there is at least 1 side quest in the victory display, ready Thalion at the beginning of the combat phase.\r\nWhile there are at least 3 side quests in the victory display, Thalion loses the ally card type, gains the hero card type and the resource icons of each sphere on a side quest in the victory display.")
                .WithInfo(69, 3, Artist.Unknown);

        }
    }
}