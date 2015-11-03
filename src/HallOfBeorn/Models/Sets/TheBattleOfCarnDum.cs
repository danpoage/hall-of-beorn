using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace HallOfBeorn.Models.Sets
{
    public class TheBattleOfCarnDum : CardSet
    {
        private const string setName = "The Battle of Carn Dûm";

        protected override void Initialize()
        {
            Name = setName;
            NormalizedName = "The Battle of Carn Dum";
            Abbreviation = "TBoCD";
            Number = 33;
            SetType = Models.SetType.Adventure_Pack;
            Cycle = "Angmar Awakened";

            Cards.Add(Card.Hero("Amarthiúl", "", Sphere.Leadership, 10, 1, 3, 3, 3)
                .WithNormalizedTitle("Amarthiul")
                .WithTraits("Dúnedain.", "Ranger.", "Warrior.")
                .WithText("While you are engaged with at least 1 enemy, Amarthiúl gains the Tactics resource icon.\r\nWhile you are engaged with at least 2 enemies, add 1 additional resource to Amarthiúl's resource pool when you collect resources during the resource phase.")
                .WithFlavor("\"The heirs of Elendil do not forget all things past...\" -Aragorn, The Return of the King")
                .WithTemplate("<p>While you are engaged with at least 1 enemy, {self} gains the {sphere:Tactics} resource icon.</p><p>While you are engaged with at least 2 enemies, add 1 additional resource to {self}'s resource pool when you collect resources during the resource phase.</p><p style='text-align:center;'><i>&quot;The heirs of Elendil do not forget all things past...&quot;<br>&ndash;Aragorn, The Return of the King</i></p>")
                .WithInfo(115, 1, Artist.Tomasz_Jedruszek));
            Cards.Add(Card.Ally("Guardian of Arnor", "", Sphere.Leadership, 3, 1, 1, 1, 3)
                .WithGeneric()
                .WithTraits("Dúnedain.", "Ranger.")
                .WithKeywords("Sentinel.")
                .WithText("Guardian of Arnor gets +1 Defense for each enemy engaged with you.")
                .WithFlavor("\"Travellers scowl at us, and countrymen give us scornful names.\" -Aragorn, The Fellowship of the Ring")
                .WithTemplate("<p>Sentinel.</p><p>{self} gets +1 {Defense} for each enemy engaged with you.</p><p class='flavor-text'>&quot;Travellers scowl at us, and countrymen give us scornful names.&quot;<br>&ndash;Aragorn, The Fellowship of the Ring</p>")
                .WithInfo(116, 3, Artist.Adam_Lane));
            Cards.Add(Card.Event("Doom Hangs Still", "", Sphere.Leadership, 5)
                .WithText("Planning Action: Until the end of the round, players do not raise their threat from questing unsuccessfully.\r\nValour Planning Action: Raise each player's threat by 2 to skip the quest phase this round.")
                .WithFlavor("\"Dooms hangs still on a thread. Yet hope there is still, if we can stand but unconquered for a little while.\" -Gandalf, The Two Towers")
                .WithTemplate("<p><b>Planning Action:</b> Until the end of the round, players do not raise their threat from questing unsuccessfully.</p><p><b>Valour Planning Action:</b> Raise each player's threat by 2 to skip the quest phase this round.</p><p class='flavor-text'>&quot;Dooms hangs still on a thread. Yet hope there is still, if we can stand but unconquered for a little while.&quot;<br>&ndash;Gandalf, The Two Towers</p>")
                .WithInfo(117, 3, Artist.Tomasz_Jedruszek));
            Cards.Add(Card.Ally("Beechbone", "", Sphere.Tactics, 3, 2, 2, 1, 4)
                .WithUnique()
                .WithTraits("Ent.")
                .WithText("Cannot have attachments. Enters play exhausted.\r\nResponse: After Beechbone is declared as an attacker, deal 1 damage to him to deal X damage to the defending enemy. X is the amount of damage on Beechbone.")
                .WithTemplate("<p>Cannot have attachments. Enters play exhausted.</p><p><b>Response:</b> After {self} is declared as an attacker, deal 1 damage to him to deal X damage to the defending enemy. X is the amount of damage on {self}.</p>")
                .WithInfo(118, 3, Artist.Katayanagi));
            Cards.Add(Card.Event("Hold Your Ground!", "", Sphere.Tactics, 1)
                .WithText("Action: Choose and ready a sentinel character.\r\nValour Action: Ready all sentinel characters.")
                .WithFlavor("Aragorn and Boromir did not heed the command, but still held their ground, side by side, behind Gandalf at the far end of the bridge. -The Fellowship of the Ring")
                .WithTemplate("<p><b>Action:</b> Choose and ready a sentinel character.</p><p><b>Valour Action:</b> Ready all sentinel characters.</p><p class='flavor-text'>Aragorn and Boromir did not heed the command, but still held their ground, side by side, behind Gandalf at the far end of the bridge.<br>&ndash;The Fellowship of the Ring</p>")
                .WithInfo(119, 3, Artist.Alvaro_Calvo_Escudero));
            Cards.Add(Card.Ally("Lindir", "", Sphere.Spirit, 3, 2, 1, 2, 2)
                .WithUnique()
                .WithTraits("Noldor.")
                .WithText("Response: After Lindir enters play, if you have less than 3 cards in your hand, draw until you have 3 cards in your hand.")
                .WithFlavor("\"To sheep other sheep no doubt appear different,\" laughed Lindir. \"Or to shepherds. But Mortals have not been our study. We have other business.\" -The Fellowship of the Ring")
                .WithTemplate("<p><b>Response:</b> After {self} enters play, if you have less than 3 cards in your hand, draw until you have 3 cards in your hand.</p><p class='flavor-text'>&quot;To sheep other sheep no doubt appear different,&quot; laughed Lindir. &quot;Or to shepherds. But Mortals have not been our study. We have other business.&quot;<br>&ndash;The Fellowship of the Ring</p>")
                .WithInfo(120, 3, Artist.Tawny_Fritzinger));
            Cards.Add(Card.Event("Lords of the Eldar", "", Sphere.Spirit, 3)
                .WithText("Lords of the Eldar can only be played from your discard pile.\r\nAction: Place Lords of the Eldar on the bottom of your deck from your discard pile. Then, until the end of the round all Noldor characters get +1 Willpower, +1 Attack, and +1 Defense.")
                .WithFlavor("\"And here in Rivendell there live still some of his chief foes: the Elven-wise, lords of the Eldar...\" -Gandalf, The Fellowship of the Ring")
                .WithTemplate("<p>{self} can only be played from your discard pile.</p><p><b>Action:</b> Place {self} on the bottom of your deck from your discard pile. Then, until the end of the round all {trait:Noldor.@Noldor} characters get +1 {Willpower}, +1 {Attack}, and +1 {Defense}.")
                .WithInfo(121, 3, Artist.Rovina_Cai));
            Cards.Add(Card.Attachment("The Long Defeat", "", Sphere.Lore, 1)
                .WithTraits("Condition.")
                .WithText("Attach to a quest card in play. Limit 1 per quest.\r\nResponse: After attached quest card is defeated, each player either draws 2 cards or heals up to 5 damage from among characters he controls.")
                .WithFlavor("\"...for ere the fall of Nargothrond or Gondolin I passed over the mountains, and together through ages of the world we have fought the long defeat.\" -Galadriel, The Fellowship of the Ring")
                .WithTemplate("<p>Attach to a quest card in play. Limit 1 per quest.</p><p><b>Response:</b> After attached quest card is defeated, each player either draws 2 cards or heals up to 5 damage from among characters he controls.</p><p class='flavor-text'>&quot;...for ere the fall of Nargothrond or Gondolin I passed over the mountains, and together through ages of the world we have fought the long defeat.&quot;<br>&ndash;Galadriel, The Fellowship of the Ring</p>")
                .WithInfo(122, 3, Artist.Jose_Vega));
            Cards.Add(Card.Event("Quick Ears", "", Sphere.Lore, 1)
                .WithText("Response: Exhaust a Dúnedain or Ranger hero to cancel an enemy card just revealed from the encounter deck. Then, shuffle it back into the encounter deck and reveal an additional encounter card.")
                .WithFlavor("\"... though I cannot disappear, I have hunted many wild and wary things and I can usually avoid being seen, if I wish.\" -Aragorn, The Fellowship of the Ring")
                .WithTemplate("<p><b>Response:</b> Exhaust a {traits-hero:Dúnedain,Ranger} to cancel an enemy card just revealed from the encounter deck. Then, shuffle it back into the encounter deck and reveal an additional encounter card.</p><p class='flavor-text'>&quot;... though I cannot disappear, I have hunted many wild and wary things and I can usually avoid being seen, if I wish.&quot;<br>&ndash;Aragorn, The Fellowship of the Ring</p>")
                .WithInfo(123, 3, Artist.Eva_Maria_Toker));
            Cards.Add(Card.Attachment("Favor of the Valar", "", Sphere.Neutral, 3)
                .WithTraits("Condition.")
                .WithTemplate("Attach to a player's threat dial. Limit 1 per player.\r\nForced: When you would be eliminated by reaching your threat elimination level, instead discard Favor of the Valar and reduce your threat to 5 less than your threat elimination level. You are not eliminated.")
                .WithFlavor("\"...their hearts were lifted up in such a hope as they had not known since the darkness came out of the East...\" -The Return of the King")
                .WithTemplate("<p>Attach to a player's threat dial. Limit 1 per player.</p><p><b>Forced:</b> When you would be eliminated by reaching your threat elimination level, instead discard Favor of the Valar and reduce your threat to 5 less than your threat elimination level. You are not eliminated.</p><p class='flavor-text'>&quot;...their hearts were lifted up in such a hope as they had not known since the darkness came out of the East...&quot;<br>&ndash;The Return of the King</p>")
                .WithInfo(124, 3, Artist.Matthew_Cowdery));
        }
    }
}