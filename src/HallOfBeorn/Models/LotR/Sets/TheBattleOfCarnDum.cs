using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace HallOfBeorn.Models.LotR.Sets
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

            Cards.Add(LotRCard.Hero("Amarthiúl", "", Sphere.Leadership, 10, 1, 3, 3, 3)
                .WithNormalizedTitle("Amarthiul")
                .WithTraits("Dúnedain.", "Ranger.", "Warrior.")
                .WithText("While you are engaged with at least 1 enemy, Amarthiúl gains the Tactics resource icon.\r\nWhile you are engaged with at least 2 enemies, add 1 additional resource to Amarthiúl's resource pool when you collect resources during the resource phase.")
                .WithFlavor("\"The heirs of Elendil do not forget all things past...\" -Aragorn, The Return of the King")
                .WithTemplate("<p>While you are engaged with at least 1 enemy, {self} gains the {sphere:Tactics} resource icon.</p><p>While you are engaged with at least 2 enemies, add 1 additional resource to {self}'s resource pool when you collect resources during the resource phase.</p><p class='flavor-text'>&quot;The heirs of Elendil do not forget all things past...&quot;<br>&ndash;Aragorn, The Return of the King</p>")
                .WithInfo(115, 1, Artist.Tomasz_Jedruszek));
            Cards.Add(LotRCard.Ally("Guardian of Arnor", "", Sphere.Leadership, 3, 1, 1, 1, 3)
                .WithGeneric()
                .WithTraits("Dúnedain.", "Ranger.")
                .WithKeywords("Sentinel.")
                .WithText("Guardian of Arnor gets +1 Defense for each enemy engaged with you.")
                .WithFlavor("\"Travellers scowl at us, and countrymen give us scornful names.\" -Aragorn, The Fellowship of the Ring")
                .WithTemplate("<p>Sentinel.</p><p>{self} gets +1 {Defense} for each enemy engaged with you.</p><p class='flavor-text'>&quot;Travellers scowl at us, and countrymen give us scornful names.&quot;<br>&ndash;Aragorn, The Fellowship of the Ring</p>")
                .WithInfo(116, 3, Artist.Adam_Lane));
            Cards.Add(LotRCard.Event("Doom Hangs Still", "", Sphere.Leadership, 5)
                .WithText("Planning Action: Until the end of the round, players do not raise their threat from questing unsuccessfully.\r\nValour Planning Action: Raise each player's threat by 2 to skip the quest phase this round.")
                .WithFlavor("\"Dooms hangs still on a thread. Yet hope there is still, if we can stand but unconquered for a little while.\" -Gandalf, The Two Towers")
                .WithTemplate("<p><b>Planning Action:</b> Until the end of the round, players do not raise their threat from questing unsuccessfully.</p><p><b>Valour Planning Action:</b> Raise each player's threat by 2 to skip the quest phase this round.</p><p class='flavor-text'>&quot;Dooms hangs still on a thread. Yet hope there is still, if we can stand but unconquered for a little while.&quot;<br>&ndash;Gandalf, The Two Towers</p>")
                .WithInfo(117, 3, Artist.Tomasz_Jedruszek));
            Cards.Add(LotRCard.Ally("Beechbone", "", Sphere.Tactics, 3, 2, 2, 1, 4)
                .WithUnique()
                .WithTraits("Ent.")
                .WithText("Cannot have restricted attachments.\r\nEnters play exhausted.\r\nResponse: After Beechbone is declared as an attacker, deal 1 damage to him to deal X damage to the defending enemy. X is the amount of damage on Beechbone.")
                .WithInfo(118, 3, Artist.Katayanagi));
            Cards.Add(LotRCard.Event("Hold Your Ground!", "", Sphere.Tactics, 1)
                .WithText("Action: Choose and ready a sentinel character.\r\nValour Action: Ready all sentinel characters.")
                .WithFlavor("Aragorn and Boromir did not heed the command, but still held their ground, side by side, behind Gandalf at the far end of the bridge. -The Fellowship of the Ring")
                .WithTemplate("<p><b>Action:</b> Choose and ready a sentinel character.</p><p><b>Valour Action:</b> Ready all sentinel characters.</p><p class='flavor-text'>Aragorn and Boromir did not heed the command, but still held their ground, side by side, behind Gandalf at the far end of the bridge.<br>&ndash;The Fellowship of the Ring</p>")
                .WithInfo(119, 3, Artist.Alvaro_Calvo_Escudero));
            Cards.Add(LotRCard.Ally("Lindir", "", Sphere.Spirit, 3, 2, 1, 2, 2)
                .WithUnique()
                .WithTraits("Noldor.")
                .WithText("Response: After Lindir enters play, if you have less than 3 cards in your hand, draw until you have 3 cards in your hand.")
                .WithFlavor("\"To sheep other sheep no doubt appear different,\" laughed Lindir. \"Or to shepherds. But Mortals have not been our study. We have other business.\" -The Fellowship of the Ring")
                .WithTemplate("<p><b>Response:</b> After {self} enters play, if you have less than 3 cards in your hand, draw until you have 3 cards in your hand.</p><p class='flavor-text'>&quot;To sheep other sheep no doubt appear different,&quot; laughed Lindir. &quot;Or to shepherds. But Mortals have not been our study. We have other business.&quot;<br>&ndash;The Fellowship of the Ring</p>")
                .WithInfo(120, 3, Artist.Tawny_Fritzinger));
            Cards.Add(LotRCard.Event("Lords of the Eldar", "", Sphere.Spirit, 3)
                .WithText("Lords of the Eldar can only be played from your discard pile.\r\nAction: Place Lords of the Eldar on the bottom of your deck from your discard pile. Then, until the end of the round all Noldor characters get +1 Willpower, +1 Attack, and +1 Defense.")
                .WithFlavor("\"And here in Rivendell there live still some of his chief foes: the Elven-wise, lords of the Eldar...\" -Gandalf, The Fellowship of the Ring")
                .WithTemplate("<p>{self} can only be played from your discard pile.</p><p><b>Action:</b> Place {self} on the bottom of your deck from your discard pile. Then, until the end of the round all {trait:Noldor.@Noldor} characters get +1 {Willpower}, +1 {Attack}, and +1 {Defense}.")
                .WithInfo(121, 3, Artist.Rovina_Cai));
            Cards.Add(LotRCard.Attachment("The Long Defeat", "", Sphere.Lore, 1)
                .WithTraits("Condition.")
                .WithText("Attach to a quest card in play. Limit 1 per quest.\r\nResponse: After attached quest card is defeated, each player either draws 2 cards or heals up to 5 damage from among characters he controls.")
                .WithFlavor("\"...for ere the fall of Nargothrond or Gondolin I passed over the mountains, and together through ages of the world we have fought the long defeat.\" -Galadriel, The Fellowship of the Ring")
                .WithTemplate("<p>Attach to a quest card in play. Limit 1 per quest.</p><p><b>Response:</b> After attached quest card is defeated, each player either draws 2 cards or heals up to 5 damage from among characters he controls.</p><p class='flavor-text'>&quot;...for ere the fall of Nargothrond or Gondolin I passed over the mountains, and together through ages of the world we have fought the long defeat.&quot;<br>&ndash;Galadriel, The Fellowship of the Ring</p>")
                .WithInfo(122, 3, Artist.Jose_Vega));
            Cards.Add(LotRCard.Event("Quick Ears", "", Sphere.Lore, 1)
                .WithText("Response: Exhaust a Dúnedain or Ranger hero to cancel an enemy card just revealed from the encounter deck. Then, shuffle it back into the encounter deck and reveal an additional encounter card.")
                .WithFlavor("\"... though I cannot disappear, I have hunted many wild and wary things and I can usually avoid being seen, if I wish.\" -Aragorn, The Fellowship of the Ring")
                .WithTemplate("<p><b>Response:</b> Exhaust a {traits-hero:Dúnedain,Ranger} to cancel an enemy card just revealed from the encounter deck. Then, shuffle it back into the encounter deck and reveal an additional encounter card.</p><p class='flavor-text'>&quot;... though I cannot disappear, I have hunted many wild and wary things and I can usually avoid being seen, if I wish.&quot;<br>&ndash;Aragorn, The Fellowship of the Ring</p>")
                .WithInfo(123, 3, Artist.Eva_Maria_Toker));
            Cards.Add(LotRCard.Attachment("Favor of the Valar", "", Sphere.Neutral, 3)
                .WithTraits("Condition.")
                .WithText("Attach to a player's threat dial. Limit 1 per player.\r\nForced: When you would be eliminated by reaching your threat elimination level, instead discard Favor of the Valar and reduce your threat to 5 less than your threat elimination level. You are not eliminated.")
                .WithFlavor("\"...their hearts were lifted up in such a hope as they had not known since the darkness came out of the East...\" -The Return of the King")
                .WithTemplate("<p>Attach to a player's threat dial. Limit 1 per player.</p><p><b>Forced:</b> When you would be eliminated by reaching your threat elimination level, instead discard Favor of the Valar and reduce your threat to 5 less than your threat elimination level. You are not eliminated.</p><p class='flavor-text'>&quot;...their hearts were lifted up in such a hope as they had not known since the darkness came out of the East...&quot;<br>&ndash;The Return of the King</p>")
                .WithInfo(124, 3, Artist.Matthew_Cowdery));
            Cards.Add(LotRCard.Quest("The Clutches of Carn Dûm", 1, setName, 15)
                .WithFlavor("Your company has made its way swiftly north, and finally the fortress of Carn Dûm looms before you. Unsure if you have arrived in time, you can only hope beyond hope that Iârion is still alive.")
                .WithText("Setup: Add Thaurdir to the staging area, Captain side faceup. Add 1 copy of Carn Dûm garrison per player to the staging area. Search the encounter deck for 1 copy of Accursed Battlefield and make it the active location. Shuffle the encounter deck.")
                .WithTemplate("<p class='flavor-text'>Your company has made its way swiftly north, and finally the fortress of Carn Dûm looms before you. Unsure if you have arrived in time, you can only hope beyond hope that Iârion is still alive.</p><p><b>Setup:</b> Add {card:Thaurdir-TBoCD@Thaurdir} to the staging area, {trait:Captain.@Captain} side faceup. Add 1 copy of {card:Carn-Dûm-Garrison-TBoCD@Carn Dûm Garrison} per player to the staging area. Search the encounter deck for 1 copy of {card:Accursed-BAttlefield-TBoCD@Accursed Battlefield} and make it the active location. Shuffle the encounter deck.</p>")
                .WithOppositeFlavor("Thaurdir has mustered the defense of Carn Dûm. There is no turning back now. \"For Iârion!\" the Rangers begin to shout, unsheathing their swords.")
                .WithOppositeText("Thaurdir cannot leave the staging area and cannot take damage. At the end of the round, if Thaurdir is Champion side faceup, flip him.\r\nDo not discard unresolved shadow cards at the end of the combat phase.\r\nForced: If there are 3 shadow cards dealt to Thaurdir, flip him.")
                .WithTemplate2("<p class='flavor-text'>Thaurdir has mustered the defense of Carn Dûm. There is no turning back now. &quot;For Iârion!&quot; the Rangers begin to shout, unsheathing their swords.</p><p>{card:Thaurdir-TBoCD@Thaurdir} cannot leave the staging area and cannot take damage. At the end of the round, if {card:Thaurdir-TBoCD@Thaurdir} is {trait:Champion.@Champion} side faceup, flip him.</p><p>Do not discard unresolved shadow cards at the end of the combat phase.</p><p><b>Forced:</b> If there are 3 shadow cards dealt to {card:Thaurdir-TBoCD@Thaurdir}, flip him.</p>")
                .WithInfo(125, 1, Artist.Wibben));
            Cards.Add(LotRCard.Quest("Midwinter's Crux", 2, setName, 15)
                .WithFlavor("A swirling dark cloud starts to gather above you, and a cold wind tenses your muscles. \"I have a bad feeling about this...\" you hear Amarthiúl mutter. It seems Daechanar's ritual has begun. Sensing you have little time to spare, your company rushes to the gates of Carn Dûm")
                .WithText("When Revealed: Raise each player's threat by X, where X is the number of shadow cards in play. If Thaurdir is Captain side faceup, flip him.")
                .WithTemplate("<p class='flavor-text'>A swirling dark cloud starts to gather above you, and a cold wind tenses your muscles. \"I have a bad feeling about this...\" you hear Amarthiúl mutter. It seems Daechanar's ritual has begun. Sensing you have little time to spare, your company rushes to the gates of Carn Dûm</p><p><b>When Revealed:</b> Raise each player's threat by X, where X is the number of shadow cards in play. If {card:Thaurdir-TBoCD@Thaurdir} is {trait:Captain.@Captain} side faceup, flip him.</p>")
                .WithOppositeText("Thaurdir cannot leave the staging area, is considered to be engaged with each player, and attacks each player in turn during the combat phase (deal and discard a new shadow card for each attack). At the end of the round, if Thaurdir is Captain side faceup, flip him.\r\nWhile Midwinter's Crux has 15 or more progress on it, Thaurdir loses indestructible. You cannot defeat this stage while Thaurdir is in play.\r\nIf Thaurdir is defeated, you win the game")
                .WithTemplate2("<p>{card:Thaurdir-TBoCD@Thaurdir} cannot leave the staging area, is considered to be engaged with each player, and attacks each player in turn during the combat phase (deal and discard a new shadow card for each attack). At the end of the round, if {card:Thaurdir-TBoCD@Thaurdir} is {trait:Captain.@Captain} side faceup, flip him.</p><p>While {self} has 15 or more progress on it, {card:Thaurdir-TBoCD@Thaurdir} loses indestructible. You cannot defeat this stage while {card:Thaurdir-TBoCD@Thaurdir} is in play.</p><p><b>If {card:Thaurdir-TBoCD@Thaurdir} is defeated, you win the game</b></p>")
                .WithInfo(126, 1, Artist.Tomasz_Jedruszek));
            Cards.Add(LotRCard.Enemy("Thaurdir", "", setName, 50, 4, 6, 4, 9)
                .WithSuffix("Captain")
                .WithUnique()
                .WithTraits("Undead.", "Wraith.", "Captain.")
                .WithKeywords("Indestructible.")
                .WithText("Cannot have attachments.\r\nEach other enemy gets +10 engagement cost.\r\nForced: After Thaurdir is flipped or a treachery card with the Sorcery trait is revealed, deal 1 shadow card to each enemy in play.")
                .WithTemplate("<p>{keyword:Indestructible.} Cannot have attachments.</p><p>Each other enemy gets +10 engagement cost.</p><p><b>Forced:</b> After {self} is flipped or a treachery with the {trait:Sorcery.@Sorcery} trait is revealed, deal 1 shadow card to each enemy in play.</p>")
                .WithInfo(127, 1, Artist.Brian_Valenzuela));
            Cards.Add(LotRCard.Enemy("Thaurdir", "", setName, 50, 4, 6, 4, 9)
                .WithSuffix("Champion")
                .WithUnique()
                .WithTraits("Undead.", "Wraith.", "Champion.")
                .WithKeywords("Indestructible.")
                .WithText("Cannot have attachments.\r\nEach other enemy gets -10 engagement cost.\r\nForced: After Thaurdir is flipped or a treachery with the Sorcery trait is revealed, Thaurdir heals 3 damage and makes an immediate attack against the first player.")
                .WithTemplate("<p>{keyword:Indestructible.} Cannot have attachments.</p><p>Each other enemy gets -10 engagement cost.</p><p><b>Forced:</b> After {self} is flipped or a treachery with the {trait:Sorcery.@Sorcery} trait is revealed, {self} heals 3 damage and makes an immediate attack against the first player.</p>")
                .WithInfo(128, 1, Artist.Brian_Valenzuela));
            Cards.Add(LotRCard.Enemy("Carn Dûm Garrison", "", setName, 40, 1, 4, 3, 5)
                .WithNormalizedTitle("Carn Dum Garrison")
                .WithTraits("Orc.")
                .WithText("Carn Dûm gets +1 Threat for each shadow card currently dealt to it.")
                .WithShadow("Shadow: Attacking enemy gets +1 Attack for each shadow card currently dealt to it.")
                .WithTemplate("<p>{self} gets +1 {Threat} for each shadow card currently dealt to it.</p>{shadow}<p class='shadow-text'><b>Shadow:</b> Attacking enemy gets +1 {Attack} for each shadow card currently dealt to it.</p>")
                .WithEasyModeQuantity(3)
                .WithInfo(129, 4, Artist.Brian_Valenzuela));
            Cards.Add(LotRCard.Enemy("Orc Grunts", "", setName, 8, 1, 2, 1, 3)
                .WithTraits("Orc.")
                .WithKeywords("Doomed 1.", "Surge.")
                .WithText("Any time progress is placed on the current quest, reduce the amount of progress placed by 1.")
                .WithShadow("Shadow: Add Orc Grunts to the staging area.")
                .WithTemplate("<p>{keyword:Doomed 1.} {keyword:Surge.}</p><p>Any time progress is placed on the current quest, reduce the amount of progress placed by 1.</p>{shadow}<p class='shadow-text'><b>Shadow:</b> Add {self} to the staging area.</p>")
                .WithEasyModeQuantity(2)
                .WithInfo(130, 4, Artist.Rafal_Hrynkiewicz));
            Cards.Add(LotRCard.Enemy("Werewolf of Angmar", "", setName, 35, 2, 5, 4, 6)
                .WithTraits("Creature.", "Werewolf.")
                .WithText("Forced: After an event card is played, deal 1 shadow card to Werewolf of Angmar.\r\nForced: If there are 3 shadow cards dealt to Werewolf of Angmar and it is in the staging area, it engages the first player and makes an immediate attack (do not deal it a shadow card for this attack).")
                .WithTemplate("<p><b>Forced:</b> After an event card is played, deal 1 shadow card to {self}.</p><p><b>Forced:</b> If there are 3 shadow cards dealt to {self} and it is in the staging area, it engages the first player and makes an immediate attack (do not deal it a shadow card for this attack).</p>")
                .WithEasyModeQuantity(0)
                .WithInfo(131, 2, Artist.Matthew_Starbuck));
            Cards.Add(LotRCard.Location("Accursed Battlefield", "", setName, 2, 3)
                .WithTraits("Carn Dûm.")
                .WithText("While Accursed Battlefield is the active location, each quest card in play gains the battle keyword.")
                .WithShadow("Shadow: Attacking enemy gets +1 Attack (+3 Attack instead if the defending player's threat is higher than the attacking enemy's engagement cost).")
                .WithTemplate("<p>While {self} is the active location, each quest card in play gains the {keyword:Battle.@battle} keyword.</p>{shadow}<p class='shadow-text'><b>Shadow:</b> Attacking enemy gets +1 {Attack} (+3 {Attack} instead if the defending player's threat is higher than the attacking enemy's engagement cost).</p>")
                .WithInfo(132, 3, Artist.Rafal_Hrynkiewicz));
            Cards.Add(LotRCard.Location("Mountains of Angmar", "", setName, 3, 5)
                .WithTraits("Mountain.")
                .WithText("While Mountains of Angmar is the active location, each shadow card with no shadow effect gains: \"Shadow: Raise defending player's threat by 2.\"")
                .WithShadow("Shadow: Raise defending player's threat by 2.")
                .WithTemplate("<p>While {self} is the active location, each shadow card with no shadow effect gains: <i>&quot;<b>Shadow:</b> Raise defending player's threat by 2.&quot;</i></p>{shadow}<p class='shadow-text'><b>Shadow:</b> Raise defending player's threat by 2.</p>")
                .WithInfo(133, 2, Artist.Sergey_Glushakov));
            Cards.Add(LotRCard.Location("Blight of Carn Dûm", "", setName, 3, 3)
                .WithNormalizedTitle("Blight of Carn Dum")
                .WithTraits("Blight.", "Plains.")
                .WithText("Forced: After an enemy attacks, heal 1 damage from it.\r\nTravel: Deal each enemy in play 1 shadow card to travel here.")
                .WithShadow("Shadow: If the attacking enemy is Thaurdir, heal 3 damage from him.")
                .WithTemplate("<p><b>Forced:</b> After an enemy attacks, heal 1 damage from it.</p><p><b>Travel:</b> Deal each enemy in play 1 shadow card to travel here.</p>{shadow}<p class='shadow-text'><b>Shadow:</b> If the attacking enemy is {title:Thaurdir}, heal 3 damage from him.</p>")
                .WithInfo(134, 3, Artist.Logan_Feliciano));
            Cards.Add(LotRCard.Location("Fortress Walls", "", setName, 4, 3)
                .WithTraits("Carn Dûm.")
                .WithText("While Fortress Walls is the active location, for each resource spent by a player, raise that player's threat by 1.")
                .WithShadow("Shadow: If your threat is 40 or higher, attacking enemy makes an additional attack against you after this one.")
                .WithTemplate("<p>While {self} is the active location, for each resource spent by a player, raise that player's threat by 1.</p>{shadow}<p class='shadow-text'><b>Shadow:</b> If your threat is 40 or higher, attacking enemy makes an additional attack against you after this one.</p>")
                .WithEasyModeQuantity(1)
                .WithInfo(135, 3, Artist.Mikhail_Greuli));
            Cards.Add(LotRCard.Treachery("The Sky Darkens", "", setName)
                .WithTraits("Sorcery.")
                .WithText("When Revealed: Each player must discard a random card from his hand. Each player then searces his deck for each other copy of the card he discarded, and discards those as well. Shuffle each searched deck.")
                .WithShadow("Shadow: Discard a random card from the defending player's hand.")
                .WithTemplate("<p><b>When Revealed:</b> Each player must discard a random card from his hand. Each player then searces his deck for each other copy of the card he discarded, and discards those as well. Shuffle each searched deck.</p>{shadow}<p class='shadow-text'><b>Shadow:</b> Discard a random card from the defending player's hand.</p>")
                .WithEasyModeQuantity(0)
                .WithInfo(136, 2, Artist.Tomasz_Jedruszek));
            Cards.Add(LotRCard.Treachery("Vile Afflication", "", setName)
                .WithTraits("Sorcery.")
                .WithText("When Revealed: Each player must distribute damage among questing characters equal to the printed cost of the highest cost card in that player's discard pile.")
                .WithShadow("Shadow: Attacking enemy gets +1 Attack. If this attack destroys an ally, search your deck for another copy of that ally and discard it, if able.")
                .WithTemplate("<p><b>When Revealed:</b> Each player must distribute damage among questing characters equal to the printed cost of the highest cost card in that player's discard pile.</p>{shadow}<p class='shadow-text'><b>Shadow:</b> Attacking enemy gets +1 {Attack}. If this attack destroys an ally, search your deck for another copy of that ally and discard it, if able.</p>")
                .WithInfo(137, 3, Artist.Beth_Sobel));
            Cards.Add(LotRCard.Treachery("Daechanar's Will", "", setName)
                .WithText("When Revealed: Flip Thaurdir. Then, if he is Captain side faceup, Daechanar's Will gains surge.")
                .WithShadow("Shadow: Flip Thaurdir after this attack.")
                .WithTemplate("<p><b>When Revealed:</b> Flip {title:Thaurdir}. Then, if he is {trait:Captain.@Captain} side faceup, {self} gains {keyword:Surge.@surge.}</p>{shadow}<p class='shadow-text'><b>Shadow:</b> Flip {title:Thaurdir} after this attack.</p>")
                .WithEasyModeQuantity(1)
                .WithInfo(138, 2, Artist.Alvaro_Calvo_Escudero));
            Cards.Add(LotRCard.EncounterSideQuest("Furious Charge", "", setName, 5)
                .WithKeywords("Surge.")
                .WithFlavor("With reckless abandon, your company makes a mad dash for the gates!")
                .WithText("Forced: When at least 1 progress is placed on Furious Charge, each character gets -2 Defense until the end of the round. If Thaurdir is Captain side faceup, flip him.\r\nResponse: After Furious Charge is defeated, add 10 progress to the main quest.")
                .WithVictoryPoints(10)
                .WithTemplate("<p class='flavor-text'>With reckless abandon, your company makes a mad dash for the gates!</p><p>{keyword:Surge.}</p><p><b>Forced:</b> When at least 1 progress is placed on {self}, each character gets -2 {Defense} until the end of the round. If {title:Thaurdir} is {trait:Captain.@Captain} side faceup, flip him.</p><p><b>Response:</b> After {self} is defeated, add 10 progress to the main quest.</p><br>{victory:10}")
                .WithInfo(139, 1, Artist.Magali_Villeneuve));
        }
    }
}