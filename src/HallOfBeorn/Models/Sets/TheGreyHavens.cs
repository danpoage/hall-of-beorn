using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace HallOfBeorn.Models.Sets
{
    public class TheGreyHavens : CardSet
    {
        protected override void Initialize()
        {
            Name = "The Grey Havens";
            Abbreviation = "TGH";
            Number = 30;
            SetType = Models.SetType.Deluxe_Expansion;

            Cards.Add(Card.Hero("Círdan the Shipwright", "", Sphere.Spirit, 12, 4, 2, 2, 4)
                .WithNormalizedTitle("Cirdan the Shipwright")
                .WithTraits("Noldor.", "Noble.")
                .WithText("Draw 1 additional card at the beginning of the resource phase.\r\nForced: After drawing cards at the beginning of the resource phase, choose and discard 1 of those cards.")
                .WithFlavor("Very tall he was, and his beard was long, and he was grey and old, save that his eyes were keen as stars...\r\n-The Return of the King")
                .WithInfo(1, 1, Artist.Aleksander_Karcz));
            Cards.Add(Card.Hero("Galdor of the Havens", "", Sphere.Lore, 9, 2, 2, 1, 4)
                .WithTraits("Noldor.")
                .WithText("Response: After drawing your setup hand, instead of taking a mulligan, you may discard any number of cards from your hand. Then, draw that many cards.\r\nAction: If you have no cards in your hand, draw 6 cards. (Limit once per game.)")
                .WithFlavor("\"What power still remains lies with us...\"\r\n-The Fellowship of the Ring")
                .WithInfo(2, 1, Artist.Lukasz_Jaskolski));
            Cards.Add(Card.Ally("Mithlond Sea-watcher", "", Sphere.Tactics, 2, 1, 1, 0, 2)
                .WithTraits("Noldor.", "Warrior.")
                .WithText("While the top card of your discard pile is an ally, Mithlond Sea-watcher gets +2 Attack and gains ranged.")
                .WithFlavor("But it was an old tradition that away over there stood the Grey Havens, from which at times elven-ships set sail, never to return.\r\n-The Fellowship of the Ring")
                .WithInfo(5, 3, Artist.Owen_William_Weber));
            Cards.Add(Card.Ally("Lindon Navigator", "", Sphere.Lore, 2, 2, 1, 1, 2)
                .WithTraits("Noldor.", "Scout.")
                .WithText("Lindon Navigator does not exhaust to commit to a quest, and can commit to quests while exhausted.\r\nForced: After resolving a quest to which Lindon Navigator was committed, either discard it from play or discard 1 card from your hand.")
                .WithInfo(9, 3, Artist.Tiziano_Baracchi));
            Cards.Add(Card.Event("Elwing's Flight", "", Sphere.Spirit, 2)
                .WithText("Quest Action: Ready a questing character and give that character +1 Willpower until the end of the phase. Resolve that effect again for each copy of Elwing's Flight currently in your discard pile (you may choose different targets).")
                .WithFlavor("There flying Elwing came to him\r\nand flame was in the darkness lit;\r\nmore bright than light of diamond\r\nthe fire upon her carcanet.\r\n-The Fellowship of the Ring")
                .WithInfo(13, 3, Artist.A_M_Sartor));
        }
    }
}