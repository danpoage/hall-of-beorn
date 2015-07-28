using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace HallOfBeorn.Models.Sets
{
    public class EscapeFromMountGram : CardSet
    {
        protected override void Initialize()
        {
            Name = "Escape from Mount Gram";
            Abbreviation = "EfMG";
            Number = 31;
            SetType = Models.SetType.Adventure_Pack;
            Cycle = "Angmar Awakened";

            Cards.Add(Card.Hero("Rossiel", "", Sphere.Lore, 8, 2, 1, 2, 3)
                .WithTraits("Silvan.")
                .WithText("If the active location shares a Trait with a location in the victory display, Rossiel gets +2 Willpower.\r\nIf the attacking enemy shares a Trait with an enemy in the victory display, Rossiel gets +2 Defense.")
                .WithFlavor("\"Did you not say that you wished to see Elf-magic?\" —Galadriel, The Fellowship of the Ring")
                .WithTemplate("<p>If the active location shares a <b><i>Trait</i></b> with a location in the victory display, {self} gets +2 {Willpower}.</p><p>If the attacking enemy shares a <b><i>Trait</i></b> with an enemy in the victory display, {self} gets +2 {Defense}.</p><p style='text-align:center;'><i>&quot;Did you not say that you wished to see Elf-magic?&quot;<br>&ndash;Galadriel, The Fellowship of the Ring</i></p>")
                .WithInfo(28, 1, Artist.Alexandre_Dainche));
            Cards.Add(Card.Ally("Veteran of Osgiliath", "", Sphere.Leadership, 3, 1, 2, 1, 2)
                .WithTraits("Gondor.", "Warrior.")
                .WithText("Veteran of Osgiliath gets +1 Willpower, +1 Attack, and +1 Defense while your threat is 40 or higher.")
                .WithFlavor("\"So do we ever watch the shores nigh Osgiliath, which our enemies now partly hold, and issue from it to harry our lands.\" —Faramir, The Two Towers")
                .WithTemplate("<p>{self} gets +1 {Willpower}, +1 {Attack}, and +1 {Defense} while your threat is 40 or higher.</p><p style='text-align:center'><i>&quot;So do we ever watch the shores nigh Osgiliath, which our enemies now partly hold, and issue from it to harry our lands.&quot;<br>&ndash;Faramir, The Two Towers</p>")
                .WithInfo(29, 3, Artist.John_Stanko));
            Cards.Add(Card.Event("Descendants of Kings", "", Sphere.Leadership, 1)
                .WithText("Ready up to X Dúnedain characters you control. X is the number of enemies engaged with you.")
                .WithFlavor("\"But when dark things come from the houseless hills, or creep from sunless woods, they fly from us.\" —Aragorn, The Fellowship of the Ring")
                .WithTemplate("<p>Ready up to X {trait:Dunedain.@Dúnedain} characters you control. X is the number of enemies engaged with you.</p><p style='text-align:center;'>&quot;But when dark things come from the houseless hills, or creep from sunless woods, they fly from us.&quot;<br>&ndash;Aragorn, The Fellowship of the Ring</p>")
                .WithInfo(30, 3, Artist.Smirtouille));
            Cards.Add(Card.Ally("Derndingle Warrior", "", Sphere.Tactics, 2, 1, 1, 2, 3)
                .WithTraits("Ent.")
                .WithKeywords("Sentinel.")
                .WithText("Cannot have restricted attachments. Enters play exhausted.\r\n While Derndingle Warrior is defending, it gains: \"Action: Deal 1 damage to Derndingle Warrior to give it +3 Defense for this attack.\" (Limit once per attack.)")
                .WithInfo(31, 3, Artist.Oscar_Romer));
            Cards.Add(Card.Event("Boomed and Trumpeted", "", Sphere.Tactics, 1)
                .WithTraits("Ent.")
                .WithText("Response: After an Ent character takes any amount of damage, ready it. That character gets +3 Attack until the end of the phase.")
                .WithFlavor("\"They roared and boomed and trumpeted, until stones began to crack and fall at the mere noise of them.\" —Merry, The Two Towers")
                .WithTemplate("<p><b>Response:</b> After an {trait:Ent.@Ent} character takes any amount of damage, ready it. That character gets +3 {Attack} until the end of the phase.</p><p style='text-align:center'>&quot;They roared and boomed and trumpeted, until stones began to crack and fall at the mere noise of them.&quot; &ndash;Merry, The Two Towers</p>")
                .WithInfo(32, 3, Artist.Jordan_Saia));
            Cards.Add(Card.Ally("Elven Jeweler", "", Sphere.Spirit, 2, 1, 1, 1, 2)
                .WithTraits("Noldor.", "Craftsman.")
                .WithText(" Discard 2 cards from your hand to put Elven Jeweler into play from your hand, under your control.")
                .WithFlavor("\"...to the Elven-smiths they were but trifles...\" -Gandalf, The Fellowship of the Ring")
                .WithInfo(33, 3, Artist.Cassandre_Bolan));
            Cards.Add(Card.PlayerSideQuest("Double Back", "", Sphere.Spirit, 0, 4)
                .WithText("Limit 1 per deck.\r\nResponse: When this stage is defeated, reduce each player's threat by 5.")
                .WithFlavor("He was taking a wandering course with many turns and doublings, to put off any pursuit. -The Fellowship of the Ring")
                .WithInfo(34, 3, Artist.Jorge_Barrero));
            Cards.Add(Card.Event("Leave No Trace", "", Sphere.Lore, 1)
                .WithText("Limit 3 copies of Leave No Trace in the victory display.\r\nResponse: After a non-unique location is explored, add Leave No Trace to the victory display to add that location to the victory display.")
                .WithInfo(35, 3, Artist.Aurelien_Hubert));
            Cards.Add(Card.Event("Distant Stars", "", Sphere.Lore, 0)
                .WithText("Action: Exhaust a Ranger or Scout character to discard a non-unique active location. Then, search the encounter deck and discard pile for a non-unique location and make it the active location. Shuffle the encounter deck.")
                .WithFlavor("\"I have crossed many mountains and many rivers, and trodden many plains, even into the far countries of Rhûn and Harad where the stars are strange...\" —Aragorn, The Fellowship of the Ring")
                .WithTemplate("<p><b>Action:</b> Exhaust a {trait:Ranger.@Ranger} or {trait:Scout.@Scout} character to discard a non-unique active location. Then, search the encounter deck and discard pile for a non-unique location and make it the active location. Shuffle the encounter deck.</p><p style='text-align:center'>&quot;I have crossed many mountains and many rivers, and trodden many plains, even into the far countries of Rhûn and Harad where the stars are strange...&quot;<br>&ndash;Aragorn, The Fellowship of the Ring</i></p>")
                .WithInfo(36, 3, Artist.John_Stanko));
            Cards.Add(Card.Event("Keen as Lances", "", Sphere.Neutral, 5)
                .WithText("Reduce the cost to play Keen as Lances by 1 for each card worth no victory points in the victory display.\r\nAction: Add Keen as Lances to the victory display. Then, choose one: add 2 resources to a hero's resource pool, draw 3 cards, or reduce your threat by 4.")
                .WithInfo(37, 3, Artist.Magali_Villeneuve));
        }
    }
}