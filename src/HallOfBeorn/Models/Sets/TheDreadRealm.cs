using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace HallOfBeorn.Models.Sets
{
    public class TheDreadRealm : CardSet
    {
        private const string setName = "The Dread Realm";

        protected override void Initialize()
        {
            Name = setName;
            Abbreviation = "TDR";
            Number = 34;
            SetType = Models.SetType.Adventure_Pack;
            Cycle = "Angmar Awakened";

            Cards.Add(Card.Hero("Arwen Undómiel", "", Sphere.Spirit, 9, 3, 1, 2, 3)
                .WithNormalizedTitle("Arwen Undomiel")
                .WithTraits("Noldor.", "Noble.")
                .WithText("Action: Discard a card from your hand to add 1 resource to a Noldor hero's resource pool, or to Aragorn's resource pool. (Limit once per round.)")
                .WithFlavor("...the light of stars was in her bright eyes, grey as a cloudless night; yet queenly she looked, and thought and knowledge were in her glance, as of one who has known many things that the years bring.\r\n-The Fellowship of the Ring")
                .WithInfo(140, 1, Artist.Magali_Villeneuve));
            Cards.Add(Card.Ally("Éothain", "", Sphere.Leadership, 4, 2, 2, 1, 3)
                .WithNormalizedTitle("Eothain")
                .WithUnique()
                .WithTraits("Rohan.", "Warrior.")
                .WithText("Response: After a Rohan ally is discarded from play by a card effect, ready Éothain.")
                .WithFlavor("\"We must hasten south, lord. Let us leave these wild folk to their fancies. Or let us bind them and take them to our king.\"\r\n-The Two Towers")
                .WithInfo(141, 3, Artist.Glen_Osterberger));
            Cards.Add(Card.Attachment("Sword of Númenor", "", Sphere.Leadership, 1)
                .WithNormalizedTitle("Sword of Numenor")
                .WithTraits("Item.", "Weapon.")
                .WithKeywords("Restricted.")
                .WithText("Attach to a Dúnedain or Gondor hero.\r\nAttached hero gets +1 Attack.\r\nResponse: After attached hero participates in an attack that destroys an enemy with 5 or more printed hit points, exhaust Sword of Númenor to add 1 resource to attached hero's resource pool.")
                .WithFlavor("...the flowing characters of Númenor glinted like fire upon the blade.\r\n-The Fellowship of the Ring")
                .WithInfo(142, 3, Artist.Romana_Kendelic));
            Cards.Add(Card.Ally("Fornost Bowman", "", Sphere.Tactics, 3, 1, 1, 1, 3)
                .WithGeneric()
                .WithTraits("Dúnedain.", "Ranger.")
                .WithKeywords("Ranged.")
                .WithText("Fornost Bowman gets +1 Attack for each enemy engaged with you.")
                .WithFlavor("To the last battle at Fornost with the Witch-lord of Angmar they sent some bowmen to the aid of the king...\r\n-The Fellowship of the Ring")
                .WithInfo(143, 3, Artist.Jose_Vega));
            Cards.Add(Card.Event("Hour of Wrath", "", Sphere.Tactics, 4)
                .WithText("Action: Choose a hero. Until the end of the phase, the chose hero does not exhaust to attack or defend.\r\nValour Action: Choose a player. Until the end of the phase, each of that player's heroes do not exhaust to attack or defend.")
                .WithFlavor("These three were unscathed, for such was their fortune and the skill and might of their arms...\r\n-The Return of the King")
                .WithInfo(144, 3, Artist.Mark_Behm));
            Cards.Add(Card.Event("Elven-light", "", Sphere.Spirit, 1)
                .WithText("Elven-light can only be played from your discard pile.\r\nAction: Return Elven-light to your hand from your discard pile. Then, draw 1 card.")
                .WithFlavor("Then Aragorn was abashed, for he saw the elven-light in her eyes and the wisdom of many days...\r\n-The Return of the King")
                .WithInfo(145, 3, Artist.Magali_Villeneuve));
            Cards.Add(Card.Event("Tale of Tinúviel", "", Sphere.Spirit, 1)
                .WithNormalizedTitle("Tale of Tinuviel")
                .WithTraits("Song.")
                .WithText("Action: Exhaust a Noldor character to ready a Dúnedain character, or vice-versa. Until the end of the phase, add the exhausted character's printed Willpower to the other character's Willpower, Attack, and Defense.")
                .WithFlavor("Long was the way that fate them bore,\r\nO'er stony mountains cold and grey,\r\nThrough halls of iron and darkling door,\r\nAnd woods of nightshade morrowless.\r\n-The Fellowship of the Ring")
                .WithInfo(146, 3, Artist.Magali_Villeneuve));
            Cards.Add(Card.Ally("Galadhrim Healer", "", Sphere.Lore, 2, 1, 0, 1, 1)
                .WithGeneric()
                .WithTraits("Silvan.", "Healer.")
                .WithText("Response: After Galadhrim Healer enters play, choose a player. Heal 1 damage from each hero controlled by that player.")
                .WithFlavor("\"Even if your Quest did not concern us closely, you should have refuge in this City, until you were healed and refreshed.\"\r\n-Celeborn, The Fellowship of the Ring")
                .WithInfo(147, 3, Artist.Magali_Villeneuve));
            Cards.Add(Card.Attachment("Weather-stained Cloak", "", Sphere.Lore, 0)
                .WithTraits("Item.")
                .WithText("Attach to a Ranger character. Limit 1 per character.\r\nWhile attached character is commited to the quest, Weather-stained cloak gains: \"Response: Exhaust Weather-stained Cloak to cancel 1 point of damage just dealt to attached character.\"")
                .WithFlavor("They were clad in warm raiment and heavy cloaks...\r\n-The Return of the King")
                .WithInfo(148, 3, Artist.Jorge_Barrero));
            Cards.Add(Card.Attachment("Sword-thain", "", Sphere.Neutral, 4)
                .WithTraits("Title.")
                .WithText("Attach to a unique ally belonging to any sphere of influence.\r\nAttached character loses the ally card type and gains the hero card type.")
                .WithFlavor("\"But why, lord, did you receive me as sword-thain, if not to stay by your side?\"\r\n-Merry, The Return of the King")
                .WithInfo(149, 3, Artist.Tomasz_Jedruszek));
        }
    }
}