using System;

using HallOfBeorn.Models;

namespace HallOfBeorn.Data.Sagas.TheLordOfTheRings
{
    public static class TheBlackRidersProduct
    {
        public static ProductBuilder Builder()
        {
            var builder = new ProductBuilder(ProductNames.TheBlackRiders, ProductCodes.TheBlackRiders, new DateTime(2013, 9, 13));

            var br = builder.SagaExpansion(CardSetNames.TheBlackRiders, CardSetAbbreviations.TheBlackRiders, 1003);

            br.addHero("Frodo Baggins", 0, Sphere.Fellowship, 2, 1, 2, 2)
                .WithTraits("Hobbit.", "Ring-bearer.")
                .WithTextLine("Response: Spend 1 Fellowship resource and exhaust The One ~Ring to cancel the effect of an encounter card just revealed from the encounter deck. Shuffle that card back into the encounter deck and reveal another encounter card.")
                .WithFlavor("\"I will take the Ring,\" he said, \"though I do not know the way.\"")
                .WithFlavor("-The Fellowship of the Ring")
                .WithInfo(1, 1, Artists.Jake_Murray);
            br.addHero("Sam Gamgee", 8, Sphere.Leadership, 3, 1, 1, 3)
                .WithTraits("Hobbit.")
                .WithTextLine("Response: After you engage an enemy with a higher engagement cost than your threat, ready Sam Gamgee. He gets +1 Willpower, +1 Attack and +1 Defense until the end of the round.")
                .WithFlavor("\"I'm going with him...and if any of those Black Riders try to stop him, they'll have Sam Gamgee to reckon with\"")
                .WithFlavor("-The Fellowship of the Ring")
                .WithInfo(2, 1, Artists.Alexandre_Dainche);
            br.addHero("Merry", 6, Sphere.Tactics, 2, 0, 1, 2)
                .WithTraits("Hobbit.")
                .WithTextLine("Merry gets +1 Attack for each Hobbit hero you control.")
                .WithTextLine("Response: After Merry participates in an attack that destroys an enemy, ready another character that participated in that attack.")
                .WithFlavor("\"You can trust us to stick to you through thick and thin to the bitter end\"")
                .WithFlavor("-The Fellowship of the Ring")
                .WithInfo(3, 1, Artists.Alexandre_Dainche);
            br.addHero("Pippin", 6, Sphere.Lore, 2, 1, 1, 2)
                .WithTraits("Hobbit.")
                .WithTextLine("Each enemy in play gets +1 engagement cost for each Hobbit hero you control.")
                .WithTextLine("Response: After you engage an enemy with an engagement cost higher than your threat, draw a card.")
                .WithFlavor("\"We Hobbits ought to stick together, and we will\"")
                .WithFlavor("-The Fellowship of the Ring")
                .WithInfo(4, 1, Artists.Alexandre_Dainche);
            br.addHero("Fatty Bolger", 7, Sphere.Spirit, 1, 1, 2, 3)
                .WithTraits("Hobbit.")
                .WithTextLine("Action: Exhaust Fatty Bolger to choose an enemy in the staging area and raise your threat by that enemy's Threat. Until the end of the phase, that enemy does not contribute its Threat. (Limit once per round.)")
                .WithFlavor("\"I only hope that you do not need rescuing before the day is out\"")
                .WithFlavor("-The Fellowship of the Ring")
                .WithInfo(5, 1, Artists.Sebastian_Giacobino);
            br.addAlly("Bill the Pony", 2, Sphere.Leadership, true, 1, 1, 0, 2)
                .WithTraits("Creature.", "Pony.")
                .WithTextLine("Cannot have attachments.")
                .WithTextLine("Lower the cost to play Bill the Pony by 2 if you control Sam Gamgee.")
                .WithTextLine("Each Hobbit character gets +1 hit point.")
                .WithFlavor("\"He gave me a look as plain as Mr. Pippin could speak it: if you don't let me go with you, Sam, I'll follow on my own\"")
                .WithFlavor("-Sam Gamgee, The Fellowship of the Ring")
                .WithInfo(6, 3, Artists.Christine_Bian);
            br.addAlly("Barliman Butterbur", 2, Sphere.Lore, true, 1, 0, 1, 3)
                .WithTraits("Bree.")
                .WithTextLine("If each hero you control has the Hobbit trait, damage from undefended attacks against you may be assigned to Barliman Butterbur.")
                .WithFlavor("If each hero you control has the Hobbit trait, damage from undefended attacks against you may be assigned to Barliman Butterbur.")
                .WithFlavor("-The Fellowship of the Ring")
                .WithInfo(7, 3, Artists.Owen_William_Weber);
            br.addAlly("Farmer Maggot", 3, Sphere.Tactics, true, 1, 2, 0, 2)
                .WithTraits("Hobbit.")
                .WithTextLine("Response: After Farmer Maggot enters play, deal 1 damage to an enemy engaged with you. (Deal 2 damage instead if that enemy's engagement cost is higher than your threat.)")
                .WithFlavor("\"It is lucky for you that I know you. I was going out to set my dogs on any strangers.\"")
                .WithFlavor("-The Fellowship of the Ring")
                .WithAlternateSlug("🍄")
                .WithInfo(8, 3, Artists.Adam_Lane);
            br.addEvent("Halfling Determination", 1, Sphere.Tactics)
                .WithTextLine("Action: Choose a Hobbit character. That character gets +2 Willpower, +2 Attack and +2 Defense until the end of the phase.")
                .WithFlavor("\"I have something to do before the end, and it lies ahead, not in the Shire. I must see it through, sir, if you understand me.\"")
                .WithFlavor("-Sam Gamgee, The Fellowship of the Ring")
                .WithInfo(9, 3, Artists.Magali_Villeneuve);
            br.addEvent("Smoke Rings", 2, Sphere.Spirit)
                .WithTextLine("Action: Reduce your threat by 1 for each Pipe you control. Each hero with a Pipe attachment gets +1 Willpower until the end of the phase.")
                .WithFlavor("...he smoked and blew smoke - rings with the same vigour and delight...")
                .WithFlavor("-The Fellowship of the Ring")
                .WithInfo(10, 3, Artists.Lane_Brown);
            br.addEvent("Take No Notice", 3, Sphere.Lore)
                .WithTextLine("Lower the cost play Take No Notice by 1 for each Hobbit or Ranger hero you control.")
                .WithTextLine("Action: Add 5 to each enemy's engagement cost until the end of the round.")
                .WithFlavor("...they made no noise that even hobbits would hear. Event the wild things in the fields and woods hardly noticed their passing.")
                .WithFlavor("-The Fellowship of the Ring")
                .WithInfo(11, 3, Artists.Adam_Lane);
            br.addEvent("Frodo's Intuition", 2, Sphere.Fellowship)
                .WithTextLine("Action: Each hero you control gets +1 Willpower until the end of the round. Draw 1 card for each Hobbit hero you control.")
                .WithFlavor("\"I wonder if that is Gandalf coming after us\" said Frodo, but even as he said it, he had a feeling that it was not so...")
                .WithFlavor("-The Fellowship of the Ring")
                .WithInfo(12, 3, Artists.Winona_Nelson);
            br.addAttachment("Hobbit Cloak", 1, Sphere.Leadership, false)
                .WithTraits("Item.")
                .WithTextLine("Attach to a Hobbit hero. Limit 1 per hero.")
                .WithTextLine("Attached hero gets +2 Defense while defending against an attack by an enemy with an engagement cost higher than your threat.")
                .WithFlavor("In their dark cloaks they were invisible as if they all had magic rings.")
                .WithFlavor("-The Fellowship of the Ring")
                .WithInfo(13, 3, Artists.Alexandre_Dainche);
            br.addAttachment("Dagger of Westernesse", 1, Sphere.Tactics, false)
                .WithTraits("Artifact.", "Item.", "Weapon.")
                .WithKeywords("Restricted.")
                .WithTextLine("Attach to a hero. Restricted.")
                .WithTextLine("Attached hero gets +1 Attack (+2 Attack instead if attacking an enemy with an engagement cost higher than your threat).")
                .WithFlavor("...these blades were forged many long years ago by Men of Westernesse: they were foes of the Dark Lord...")
                .WithFlavor("-The Fellowship of the Ring")
                .WithInfo(14, 3, Artists.Sara_Biddle);
            br.addAttachment("Hobbit Pipe", 0, Sphere.Spirit, false)
                .WithTraits("Pipe.")
                .WithTextLine("Attach to a Hobbit character. Limit 1 per character.")
                .WithTextLine("Response: After your threat is reduced by an event card effect, exhaust Hobbit Pipe to draw a card.")
                .WithFlavor("But even the Dúnedain of Gondor allow us this credit: Hobbits first put it into pipes. Not even the Wizards first thought of that before we did.")
                .WithFlavor("-The Fellowship of the Ring")
                .WithInfo(15, 3, Artists.Mike_Nash);
            br.addAttachment("Elf-stone", 1, Sphere.Lore, true)
                .WithTraits("Artifact.", "Item.")
                .WithTextLine("Attach to the active location. Attached location gets +1 quest point.")
                .WithTextLine("Response: After attached location leaves play as an explored location, the first player puts 1 ally into play from his hand.")
                .WithFlavor("\"It is a beryl, an elf-stone. Whether it was set there, or let fall by chance, I cannot say, but it brings hope to me\"")
                .WithFlavor("Aragorn, The Fellowship of the Ring")
                .WithInfo(16, 3, Artists.Sandara_Tang);
            br.addAttachment("Mr. Underhill", 0, Sphere.Neutral, true)
                .WithBoon()
                .WithTraits("Title.")
                .WithKeywords("Permanent.")
                .WithTextLine("Permanent.")
                .WithTextLine("Setup: Attach to the Ring-bearer.")
                .WithTextLine("Action: Add Mr. Underhill to the victory display to choose an enemy engaged with you. Until the end of the round, that enemy cannot attack you.")
                .WithFlavor("\"I will give you a travelling name now. When you go, go as Mr. Underhill.\"")
                .WithFlavor("-Gandalf, The Fellowship of the Ring")
                .WithInfo(17, 1, Artists.Sebastian_Giacobino);
            br.addAttachment("Tireless Ranger", 0, Sphere.Neutral, true)
                .WithBoon()
                .WithTraits("Title.")
                .WithKeywords("Permanent.")
                .WithTextLine("Permanent.")
                .WithTextLine("Setup: Attach to a hero.")
                .WithTextLine("Attached hero gets +1 Defense and gains the Ranger trait.")
                .WithFlavor("\"What roads would any dare to tread, what safety would there be in quiet lands, or in the homes of simple men at night, if the Dúnedain were asleep, or were all gone into the grave?\"")
                .WithFlavor("-Aragorn, The Fellowship of the Ring")
                .WithInfo(18, 1, Artists.Cristi_Balanescu);
            br.addAttachment("Skilled Healer", 0, Sphere.Neutral, true)
                .WithBoon()
                .WithTraits("Title.")
                .WithKeywords("Permanent.")
                .WithTextLine("Permanent.")
                .WithTextLine("Setup: Attach to a hero.")
                .WithTextLine("Attached hero gets +2 hit points and gains the Healer trait.")
                .WithFlavor("\"Few now have the skill of healing to match such evil weapons. But I will do what I can.\"")
                .WithFlavor("-Aragorn, The Fellowship of the Ring")
                .WithInfo(19, 1, Artists.Cristi_Balanescu);
            br.addAttachment("Valiant Warrior", 0, Sphere.Neutral, true)
                .WithBoon()
                .WithTraits("Title.")
                .WithKeywords("Permanent.")
                .WithTextLine("Permanent.")
                .WithTextLine("Setup: Attach to a hero.")
                .WithTextLine("Attached hero gets +1 Attack and gains the Warrior trait.")
                .WithFlavor("\"Three of the servants of Sauron were upon the Bridge, but they withdrew and I pursued them westward.\"")
                .WithFlavor("-Glorfindel, The Fellowship of the Ring")
                .WithInfo(20, 1, Artists.Magali_Villeneuve);
            br.addAttachment("Noble Hero", 0, Sphere.Neutral, true)
                .WithBoon()
                .WithTraits("Title.")
                .WithKeywords("Permanent.")
                .WithTextLine("Permanent.")
                .WithTextLine("Setup: Attach to a hero.")
                .WithTextLine("Attached hero gets +1 Willpower and gains the Noble trait.")
                .WithFlavor("Venerable he seemed as a king crowned with many winters, and yet hale as a tried warrior in the fullness of his strength")
                .WithFlavor("-The Fellowship of the Ring")
                .WithInfo(21, 1, Artists.Magali_Villeneuve);

            var shadow = br.EncounterSet(EncounterSetNames.AShadowOfThePast);
            shadow.addQuest("Three is Company", 1, 'A', 1)
                .WithTextLine("Setup: Set Buckleberry Ferry aside, out of play. Add 1 Black Rider to the staging area and make Bag End the active location. Shuffle the encounter deck.")
                .WithFlavor("The ring Frodo Baggins inherited from his uncle Bilbo is indeed The One Ring. After conferring with the wizard Gandalf, Frodo decides to leave the Shire and take the ring to Rivendell.")
                .WithOppositeTextLine("When a player fails a Hide test, each Nazgûl enemy in the staging area engages that player. (Trigger Forced effects after resolving this effect.)")
                .WithOppositeTextLine("The player cannot advance unless Bag End is in the victory display.")
                .WithOppositeFlavor("Frodo's friend insist on joining him in his adventure, but danger finds them sooner than anticipated when Black Riders appear in the Shire.")
                .WithIncludedEncounterSets(EncounterSetNames.Hunted, EncounterSetNames.TheRing, EncounterSetNames.TheBlackRiders)
                .WithInfo(22, 1, Artists.Cristi_Balanescu);

            return builder;
        }
    }
}
