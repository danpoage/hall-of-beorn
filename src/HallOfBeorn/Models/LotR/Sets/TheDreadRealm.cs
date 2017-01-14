using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace HallOfBeorn.Models.LotR.Sets
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

            Cards.Add(LotRCard.Hero("Arwen Undómiel", "", Sphere.Spirit, 9, 3, 1, 2, 3)
                .WithNormalizedTitle("Arwen Undomiel")
                .WithTraits("Noldor.", "Noble.")
                .WithText("Action: Discard a card from your hand to add 1 resource to a Noldor hero's resource pool, or to Aragorn's resource pool. (Limit once per round.)")
                .WithFlavor("...the light of stars was in her bright eyes, grey as a cloudless night; yet queenly she looked, and thought and knowledge were in her glance, as of one who has known many things that the years bring.\r\n-The Fellowship of the Ring")
                .WithInfo(140, 1, Artist.Magali_Villeneuve));
            Cards.Add(LotRCard.Ally("Éothain", "", Sphere.Leadership, 4, 2, 2, 1, 3)
                .WithNormalizedTitle("Eothain")
                .WithUnique()
                .WithTraits("Rohan.", "Warrior.")
                .WithText("Response: After a Rohan ally is discarded from play by a card effect, ready Éothain.")
                .WithFlavor("\"We must hasten south, lord. Let us leave these wild folk to their fancies. Or let us bind them and take them to our king.\"\r\n-The Two Towers")
                .WithTemplate("<p><b>Response:</b> After a {trait:Rohan.@Rohan} ally is discarded from play by a card effect, ready {self}.</p><p class='flavor-text'>&quot;We must hasten south, lord. Let us leave these wild folk to their fancies. Or let us bind them and take them to our king.&quot;<br>&ndash;The Two Towers</p>")
                .WithInfo(141, 3, Artist.Glen_Osterberger));
            Cards.Add(LotRCard.Attachment("Sword of Númenor", "", Sphere.Leadership, 1)
                .WithNormalizedTitle("Sword of Numenor")
                .WithTraits("Item.", "Weapon.")
                .WithKeywords("Restricted.")
                .WithText("Attach to a Dúnedain or Gondor hero.\r\nAttached hero gets +1 Attack.\r\nResponse: After attached hero participates in an attack that destroys an enemy with 5 or more printed hit points, exhaust Sword of Númenor to add 1 resource to attached hero's resource pool.")
                .WithFlavor("...the flowing characters of Númenor glinted like fire upon the blade.\r\n-The Fellowship of the Ring")
                .WithTemplate("<p>Attach to a {traits-hero:Dúnedain,Gondor}. {keyword:Restricted.}</p><p>Attached hero gets +1 {Attack}.</p><p><b>Response:</b> After attached hero participates in an attack that destroys an enemy with 5 or more printed hit points, exhaust {self} to add 1 resource to attached hero's resource pool.</p><p class='flavor-text'>...the flowing characters of Númenor glinted like fire upon the blade.<br>&ndash;The Fellowship of the Ring</p>")
                .WithInfo(142, 3, Artist.Romana_Kendelic));
            Cards.Add(LotRCard.Ally("Fornost Bowman", "", Sphere.Tactics, 3, 1, 1, 1, 3)
                .WithGeneric()
                .WithTraits("Dúnedain.", "Ranger.")
                .WithKeywords("Ranged.")
                .WithText("Fornost Bowman gets +1 Attack for each enemy engaged with you.")
                .WithFlavor("To the last battle at Fornost with the Witch-lord of Angmar they sent some bowmen to the aid of the king...\r\n-The Fellowship of the Ring")
                .WithInfo(143, 3, Artist.Jose_Vega));
            Cards.Add(LotRCard.Event("Hour of Wrath", "", Sphere.Tactics, 4)
                .WithText("Action: Choose a hero. Until the end of the phase, the chosen hero does not exhaust to attack or defend.\r\nValour Action: Choose a player. Until the end of the phase, each of that player's heroes do not exhaust to attack or defend.")
                .WithFlavor("These three were unscathed, for such was their fortune and the skill and might of their arms...\r\n-The Return of the King")
                .WithInfo(144, 3, Artist.Mark_Behm));
            Cards.Add(LotRCard.Event("Elven-light", "", Sphere.Spirit, 1)
                .WithText("Elven-light can only be played from your discard pile.\r\nAction: Return Elven-light to your hand from your discard pile. Then, draw 1 card.")
                .WithFlavor("Then Aragorn was abashed, for he saw the elven-light in her eyes and the wisdom of many days...\r\n-The Return of the King")
                .WithInfo(145, 3, Artist.Magali_Villeneuve));
            Cards.Add(LotRCard.Event("Tale of Tinúviel", "", Sphere.Spirit, 1)
                .WithNormalizedTitle("Tale of Tinuviel")
                .WithTraits("Song.")
                .WithText("Action: Exhaust a Noldor character to ready a Dúnedain character, or vice-versa. Until the end of the phase, add the exhausted character's printed Willpower to the other character's Willpower, Attack, and Defense.")
                .WithFlavor("Long was the way that fate them bore,\r\nO'er stony mountains cold and grey,\r\nThrough halls of iron and darkling door,\r\nAnd woods of nightshade morrowless.\r\n-The Fellowship of the Ring")
                .WithInfo(146, 3, Artist.Magali_Villeneuve));
            Cards.Add(LotRCard.Ally("Galadhrim Healer", "", Sphere.Lore, 2, 1, 0, 1, 1)
                .WithGeneric()
                .WithTraits("Silvan.", "Healer.")
                .WithText("Response: After Galadhrim Healer enters play, choose a player. Heal 1 damage from each hero controlled by that player.")
                .WithFlavor("\"Even if your Quest did not concern us closely, you should have refuge in this City, until you were healed and refreshed.\"\r\n-Celeborn, The Fellowship of the Ring")
                .WithInfo(147, 3, Artist.Magali_Villeneuve));
            Cards.Add(LotRCard.Attachment("Weather-stained Cloak", "", Sphere.Lore, 0)
                .WithTraits("Item.")
                .WithText("Attach to a Ranger character. Limit 1 per character.\r\nWhile attached character is commited to the quest, Weather-stained cloak gains: \"Response: Exhaust Weather-stained Cloak to cancel 1 point of damage just dealt to attached character.\"")
                .WithFlavor("They were clad in warm raiment and heavy cloaks...\r\n-The Return of the King")
                .WithInfo(148, 3, Artist.Jorge_Barrero));
            Cards.Add(LotRCard.Attachment("Sword-thain", "", Sphere.Neutral, 4)
                .WithUnique()
                .WithTraits("Title.")
                .WithText("Attach to a unique ally belonging to any sphere of influence.\r\nAttached character loses the ally card type and gains the hero card type.")
                .WithFlavor("\"But why, lord, did you receive me as sword-thain, if not to stay by your side?\"\r\n-Merry, The Return of the King")
                .WithInfo(149, 3, Artist.Tomasz_Jedruszek));
            Cards.Add(LotRCard.Quest("The Catacombs of Carn Dûm", 1, setName, 18)
                .WithNormalizedTitle("The Catacombs of Carn Dum")
                .WithFlavor("As you descend into the catacombs beneath Carn Dûm, you find yourself overcome with terror. Still, you press onward, knowing that Iârion's fate-and perhaps the fate of the north-lies in your hand.")
                .WithText("Setup: Set Daechanar and Altar of Midwinter aside, out of play. Each player reveals an encounter card from the top of the encounter deck. Each player reanimates the top card of his deck.")
                .WithOppositeFlavor("Daechanar's powers of sorcery and necromancy are strongest here, in the capital of the Witch-realm where the lord of the Nazgûl once resided.")
                .WithOppositeText("Reanimated Dead are Undead enemies with 2 Threat, 2 Attack, 2 Defense and 2 hit points.\r\nWhen the players advance to stage 2, all Sorcery cards attached to this stage are attached to stage 2B.")
                .WithInfo(150, 1, Artist.Logan_Feliciano));
            Cards.Add(LotRCard.Quest("Angmar Awakened", 2, setName, Card.VALUE_NA)
                .WithFlavor("A final scream fills the dreadful halls of Carn Dûm, and you suspect the worst. As you enter the site of Daechanar's dark ritual, your fears come to life. Iârion stands before you, cracking his neck and gripping the blade at his side tightly, as though testing his muscles. Only it isn't him.")
                .WithText("When Revealed: Add Daechanar to the staging area. Make Altar of Midwinter the active location, returning any previously active location to the staging area. Each player reanimates the top card of his deck.")
                .WithOppositeFlavor("Daechanar, in the body of your ally Iârion, laughs wickedly. Despair and frustration are the only thoughts that enter your mind. In the end, you were too late to stop this cruel fate. \"Finally! Yes, this body will do nicely.\" the wraith wearing the guise of your friend muses. He draws his blade.")
                .WithOppositeText("Reanimated Dead are Undead enemies with 2 Threat, 2 Attack, 2 Defense and 2 hit points.\r\nWhen Daechanar is defeated, advance to the next stage.")
                .WithInfo(151, 1, Artist.Lukasz_Jaskolski));
            Cards.Add(LotRCard.Quest("Daechanar's Fall", 3, setName, Card.VALUE_NA)
                .WithFlavor("The imposter in Iârion's body collapses in agony, and a piercing shriek echoes the halls as the sorcerer exits Iârion. \"Thank you,\" Iârion says with a pained smile before his eyes close for the last time. Before you can mourn your loss, the walls begin to shake and crack. The catacombs are collapsing!")
                .WithText("When Revealed: If there are less than X locations in the staging area, search the encounter deck and discard pile and add locations to the staging area until there are X locations in staging area. X is the number of players in the game.")
                .WithOppositeText("Reanimated Dead are Undead enemies with 2 Threat, 2 Attack, 2 Defense and 2 hit points.\r\nProgress that would be placed on this quest is instead placed on locations in the staging area, divided as you choose.\r\nForced: At the end of the phase, if there are any locations in play, deal 1 damage to all characters in play. If there are no locations in play, the players have escaped Carn Dûm, and win the game.")
                .WithInfo(152, 1, Artist.Alvaro_Calvo_Escudero));
            Cards.Add(LotRCard.Enemy("Daechanar", "", setName, 1, 5, 4, 5, 12)
                .WithUnique()
                .WithTraits("Undead.", "Dúnedain.", "Sorcerer.")
                .WithText("Cannot have attachments.\r\nDaechanar gets +1 Attack for each Sorcery card in play, and gains indestructible while at least 1 Sorcery card is in play.\r\nForced: When Daechanar is damaged, if there is at least 1 Sorcery card in play, cancel all damage just dealt and remove a Sorcery card from the game.")
                .WithVictoryPoints(10)
                .WithInfo(153, 1, Artist.Lukasz_Jaskolski));
            Cards.Add(LotRCard.Location("Altar of Midwinter", "", setName, 5, 9)
                .WithUnique()
                .WithTraits("Carn Dûm.", "Underground.")
                .WithText("While Daechanar is in play, progress cannot be placed on Altar of Widwinter.\r\nForced: At the end of the staging step, the first player must either reveal 1 additional card from the encounter deck, or reanimate the top card of his deck.")
                .WithVictoryPoints(5)
                .WithInfo(154, 1, Artist.Yoann_Boissonnet));
            Cards.Add(LotRCard.Enemy("Dwimmerlaik", "", setName, 34, 4, 5, 0, 9)
                .WithTraits("Undead.", "Wraith.")
                .WithText("Forced: After Dwimmerlaik attacks and destroys a character, the defending player reanimates that character and deals it 1 shadow card.")
                .WithShadow("Shadow: If this attacks destroys a character, reanimate that character and deal it 1 shadow card.")
                .WithEasyModeQuantity(1)
                .WithInfo(155, 3, Artist.Anthony_Devine));
            Cards.Add(LotRCard.Enemy("Witch of Angmar", "", setName, 26, 3, 2, 2, 4)
                .WithTraits("Undead.", "Sorcerer.")
                .WithText("Forced: When you resolve shadow cards dealt to Witch of Angmar, if they have the Sorcery trait, resolve their \"when revealed\" effects. (Resolve any shadow effects first.)")
                .WithEasyModeQuantity(2)
                .WithInfo(156, 3, Artist.Anthony_Devine));
            Cards.Add(LotRCard.Enemy("Wraith of Carn Dûm", "", setName, 18, 2, 4, 0, 5)
                .WithNormalizedTitle("Wraith of Carn Dum")
                .WithTraits("Undead.", "Wraith.")
                .WithText("Forced: When Wraith of Carn Dûm leaves play, attach it to a character in play. (Counts as a Sorcery attachment with the text: \"Attached character has -1 Willpower, -1 Attack, and -1 Defense. If the attached character leaves play, return Wraith of Carn Dûm to the staging area as an enemy.\")")
                .WithInfo(157, 2, Artist.Ilich_Henriquez));
            Cards.Add(LotRCard.Location("Sinister Dungeon", "", setName, 4, 1)
                .WithTraits("Carn Dûm.", "Underground.")
                .WithText("Forced: When Sinister Dungeon is explored, the first player reanimates a random card from his hand and deals Sinister Dungeon to it facedown as a shadow card.")
                .WithShadow("Shadow: Discard the top 2 cards of the encounter deck. Resolve the \"when revealed\" effects of each Sorcery card discarded by this effect.")
                .WithInfo(158, 3, Artist.Rafal_Hrynkiewicz));
            Cards.Add(LotRCard.Location("Tombs of Carn Dûm", "", setName, 3, 3)
                .WithNormalizedTitle("Tombs of Carn Dum")
                .WithTraits("Carn Dûm.", "Underground.")
                .WithText("ForcedL At the end of the round, discard the top card of each player's deck. Each player must reanimate each ally discarded by this effect.\r\nTravel: Deal 1 shadow card to each Undead enemy in play to travel here.")
                .WithFlavor("He could see nothing but the dim flame of the torches; but if the company halted, there seemed and endless whisper of voices all about him...\r\n-The Return of the King")
                .WithEasyModeQuantity(0)
                .WithInfo(159, 3, Artist.Logan_Feliciano));
            Cards.Add(LotRCard.Location("Dark Halls", "", setName, 2, 4)
                .WithTraits("Carn Dûm.", "Underground.")
                .WithText("While Dark Halls is in the staging area, each Reanimated Dead gets +1 Attack and +1 Defense.")
                .WithShadow("Shadow: If there is a copy of the defending character in your discard pile, reanimate it and deal it 1 shadow card.")
                .WithInfo(160, 2, Artist.Tomasz_Jedruszek));
            Cards.Add(LotRCard.Location("Unholy Crypt", "", setName, 1, 7)
                .WithTraits("Carn Dûm.", "Underground.")
                .WithText("Unholy Crypt gets +1 Threat for each Reanimated Dead in play.")
                .WithShadow("Shadow: if this attack destroys a character, reanimate that character and deal it 1 shadow card.")
                .WithInfo(161, 3, Artist.Mikhail_Greuli));
            Cards.Add(LotRCard.Treachery("Possession", "", setName)
                .WithTraits("Sorcery.")
                .WithKeywords("Doomed 1.")
                .WithText("When Revealed: Destroy the highest cost ally in play. That ally's controller reanimates that character, adds it to the staging area, and attaches Possesion to it. (Counts as a Condition attachment with the text: \"If Possession is discarded, the attached card is also discarded.\")")
                .WithEasyModeQuantity(0)
                .WithInfo(162, 2, Artist.Victor_Garcia));
            Cards.Add(LotRCard.Treachery("A Fell Dread", "", setName)
                .WithTraits("Sorcery.")
                .WithText("When Revealed: The player with the highest threat must attach A Fell Dread to a hero he controls without A Fell Dread Attached. (Counts as a Condition attachment with the text: \"Attached hero's Willpower is reduced to 0. During the quest phase, attached hero must commit to the quest, if able.\")")
                .WithInfo(163, 2, Artist.Tiziano_Baracchi));
            Cards.Add(LotRCard.Treachery("Death and Calamity", "", setName)
                .WithTraits("Sorcery.")
                .WithText("When Revealed: Attach Death and Calamity to the current quest. Then, the first player reanimates the top X cards of his deck, where X is the number of copies of Death and Calamity in play.")
                .WithShadow("Shadow: Attacking enemy gets +X Attack, where X is the number of Sorcery cards in play.")
                .WithEasyModeQuantity(2)
                .WithInfo(164, 4, Artist.Rafal_Hrynkiewicz));
        }
    }
}