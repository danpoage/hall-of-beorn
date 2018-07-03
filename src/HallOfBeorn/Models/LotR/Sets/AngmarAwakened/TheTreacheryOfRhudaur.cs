using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace HallOfBeorn.Models.LotR.Sets.AngmarAwakened
{
    public class TheTreacheryOfRhudaur : CardSet
    {
        private const string setName = "The Treachery of Rhudaur";

        protected override void Initialize()
        {
            Name = setName;
            Abbreviation = "TToR";
            Number = 33;
            SetType = Models.SetType.Adventure_Pack;
            Cycle = "Angmar Awakened";

            Cards.Add(LotRCard.Hero("Erestor", "", Sphere.Lore, 10, 2, 2, 2, 4)
                .WithTraits("Noldor.")
                .WithText("Draw 3 additional cards at the beginning of the resource phase.\r\nAt the end of the round, discard all cards in your hand.")
                .WithFlavor("\"That is the path of despair. Of folly, I would say, if the long wisdom of Elrond did not forbid me.\"\r\n-The Fellowship of the Ring")
                .WithTemplate("<p>Draw 3 additional cards at the beginning of the resource phase.</p><p>At the end of the round, discard all cards in your hand.</p><p class='flavor-text'>&quot;That is the path of despair. Of folly, I would say, if the long wisdom of Elrond did not forbid me.&quot;<br>&ndash;The Fellowship of the Ring</p>")
                .WithInfo(84, 1, Artist.Arden_Beckwith));
            Cards.Add(LotRCard.Event("Reinforcements", "", Sphere.Leadership, 3)
                .WithText("You must use resources from 3 different heroes' pools to play this card.\r\nAction: The players, as a group, can put up to 2 allies into play from their hands. Each of these allies may enter play under any player's control. At the end of the phase, return each of those allies that are still in play to their owners' hands.")
                .WithInfo(85, 3, Artist.Oleg_Saakyan));
            Cards.Add(LotRCard.PlayerSideQuest("Send for Aid", "", Sphere.Leadership, 1, 6)
                .WithFlavor("\"Often the Rohirrim have aided us, but now the Lord Denethor asks for all your strength and all your speed...\"\r\n-Hirgon, The Return of the King")
                .WithText("Limit 1 per deck.\r\nResponse: When this stage is defeated, each player may search the top 10 cards of his deck for an ally and put it into play under his control. Each player who did shuffles his deck.")
                .WithInfo(86, 3, Artist.Tomasz_Jedruszek));
            Cards.Add(LotRCard.Attachment("Elven Spear", "", Sphere.Tactics, 0)
                .WithTraits("Item.", "Weapon.")
                .WithKeywords("Restricted.")
                .WithText("Attach to a Noldor or Silvan hero.\r\nAction: Discard a card from your hand to give attached hero +1 Attack until the end of the phase. Limit 3 times per phase.")
                .WithFlavor("Their spears and swords shone in the gloom with a gleam of chill flame, so deadly was the wrath of the hands that held them.\r\n-The Hobbit")
                .WithTemplate("<p>Attach to a {traits-hero:Noldor,Silvan}. {keyword:Restricted.}</p><p><b>Action:</b> Discard a card from your hand to give attached hero +1 {Attack} until the end of the phase. Limit 3 times per phase.</p><p class='flavor-text'>Their spears and swords shone in the gloom with a gleam of chill flame, so deadly was the wrath of the hands that held them.<br>&ndash;The Hobbit</p>")
                .WithInfo(87, 3, Artist.Arden_Beckwith));
            Cards.Add(LotRCard.Event("Horn's Cry", "", Sphere.Tactics, 2)
                .WithText("Action: All enemies get -1 Attack until the end of the phase.\r\nValour Action: Choose a player. Each enemy engaged with that player gets -3 Attack until the end of the phase.")
                .WithFlavor("Loud the challenge rang and bellowed, like the shout of many throats under the cavernous roof.\r\n-The Fellowship of the Ring")
                .WithInfo(88, 3, Artist.David_Vargo));
            Cards.Add(LotRCard.Ally("Galadhrim Weaver", Sphere.Spirit, 1, 1, 0, 0, 1)
                .WithTraits("Silvan.", "Craftsman.")
                .WithText("Cannot attack or defend.\r\nResponse: After Galadhrim Weaver enters play, shuffle the top card of your discard pile into your deck.")
                .WithFlavor("\"You are indeed high in the favour of the Lady! For she herself and her maidens wove this...\" -Lórien Elf, The Fellowship of the Ring")
                .WithInfo(89, 3, Artist.Sara_Betsy));
            Cards.Add(LotRCard.Attachment("Silver Harp", "", Sphere.Spirit, 2)
                .WithTraits("Item.", "Instrument.")
                .WithKeywords("Restricted.")
                .WithText("Attach to a Spirit hero.\r\nResponse: After a card is discarded from your hand, exhaust Silver Harp to return that card to your hand.")
                .WithFlavor("Elrond wore a mantle of grey and had a star upon his forehead, and a silver harp was in his hand... -The Return of the King")
                .WithInfo(90, 3, Artist.Arden_Beckwith));
            Cards.Add(LotRCard.Ally("Galdor of the Havens", Sphere.Lore, 4, 2, 2, 1, 4)
                .WithUnique()
                .WithTraits("Noldor.")
                .WithText("Response:  After 1 or more cards are discarded from your hand, draw 1 card. Limit once per round.")
                .WithFlavor("\"But have they the strength, have we here the strength to withstand the Enemy, the coming of Sauron at the last, when all else is overthrown?\"\r\n-The Fellowship of the Ring")
                .WithInfo(91, 3, Artist.Arden_Beckwith));
            Cards.Add(LotRCard.Event("The Door is Closed!", "", Sphere.Lore, 1)
                .WithText("Response: After an encounter card is revealed from the encounter deck, cancel its effects and discard it if there is a card with the same title in the victory display.")
                .WithFlavor("\"...I perceive the Dark Lord and know his mind, or all of his mind that concerns the Elves. And he gropes ever to see me and my thought. But still the door is closed!\"\r\n-Galadriel, The Fellowship of the Ring")
                .WithInfo(92, 3, Artist.Magali_Villeneuve));
            Cards.Add(LotRCard.Attachment("Elf-friend", "", Sphere.Neutral, 1)
                .WithTraits("Title.")
                .WithText("Attach to a character.\r\nAttached character gains the Noldor and Silvan traits.")
                .WithFlavor("\"I name you Elf-friend; and may the stars shine upon the end of your road!\"\r\n-Gildor, The Fellowship of the Ring")
                .WithInfo(93, 3, Artist.Sebastian_Giacobino));
            Cards.Add(LotRCard.Quest("Secrets of Rhudaur", 1, setName, Card.VALUE_NA)
                .WithKeywords("Time 5.")
                .WithFlavor("You have decided to explore the ruins of this ancient keep, but Thaurdir pursues you, and time is of the essence.")
                .WithText("Setup: Make The Great Hall the active location. Set Thaurdir aside, out of play. Add the 3 Treachery of Rhudaur side quests to the staging area, quest side faceup. Search the encounter deck for 1 copy of Ancient Causeway, and add it to the staging area (2 copies instead if there are 3 or 4 players in the game). The first player gains control of Amarthiúl.")
                .WithOppositeText("Forced: After the last time counter is removed from Secrets of Rhudaur, remove each Treachery of Rhudaur side quest from the game and immediately advance to stage 2.\r\nDuring the quest phase, Secrets of Rhudaur cannot be chosen as the current quest.\r\nIf there are no Treachery of Rhudaur side quests in play, immediately advance to stage 2.")
                .WithTemplate("<p class='flavor-text'>You have decided to explore the ruins of this ancient keep, but Thaurdir pursues you, and time is of the essence.</p><p><b>Setup:</b> Make {card:The-Great-Hall-TToR@The Great Hall} the active location. Set {card:Thaurdir-TToR@Thaurdir} aside, out of play. Add the <a href='/Cards/Search?CardSet=The+Treachery+of+Rhudaur&CardType=Encounter_Side_Quest' title='Side Quests from The Treachery of Rhudaur' target='_blank'>3 Treachery of Rhudaur side quests</a> to the staging area, quest side faceup. Search the encounter deck for 1 copy of {card:Ancient-Causeway-TLR@Ancient Causeway}, and add it to the staging area (2 copies instead if there are 3 or 4 players in the game). The first player gains control of {card:Amarthiul-TToR@Amarthiúl}.</p>")
                .WithTemplate2("<p>{keyword:Time 5.} <b>Forced</b> After the last time counter is removed from {self}, remove each <a href='/Cards/Search?CardSet=The+Treachery+of+Rhudaur&CardType=Encounter_Side_Quest' title='Side Quests from The Treachery of Rhudaur' target='_blank'>Treachery of Rhudaur side quests</a> from the game and immediately advance to {card:Thaurdir's-Pursuit-TToR@stage_2}.</p></p>During the quest phase, Secrets of Rhudaur cannot be chosen as the current quest.<br>If there are no <a href='/Cards/Search?CardSet=The+Treachery+of+Rhudaur&CardType=Encounter_Side_Quest' title='Side Quests from The Treachery of Rhudaur' target='_blank'>Treachery of Rhudaur side quests</a> in play, immediately advance to {card:Thaurdir's-Pursuit-TToR@stage_2}.</p>")
                .WithIncludedEncounterSets(EncounterSet.RuinsOfArnor, EncounterSet.CursedDead)
                .WithInfo(94, 1, Artist.Eva_Maria_Toker));
            Cards.Add(LotRCard.Quest("Thaurdir's Pursuit", 2, setName, 30)
                .WithFlavor("As you study the clues that you've found, you feel a chill wind flow through the keep. \"You will not leave this place alive,\" a sinister voice echoes throughout the halls. \"My master Daechanar will it so.\"\r\n\"Thaurdir!\" Amarthiúl exclaims, unsheathing his blades.")
                .WithText("When Revealed: Add Thaurdir to the staging area. Each player searches the encounter deck and discard pile for an Undead enemy and adds it to the staging area. Shuffle the encounter deck.")
                .WithOppositeFlavor("The wraith you fought in Fornost has followed you since your flight from Mount Gram. Your only hope is to escape with the clues you've found.")
                .WithOppositeText("Thaurdir's Pursuit has -5 quest points for each Clue objective attached to a character.\r\nThis stage cannot be defeated while Thaurdir has any hit point remaining. If this stage is defeated, the players win the game.")
                .WithTemplate("<p class='flavor-text'>As you study the clues that you've found, you feel a chill wind flow through the keep. &quot;You will not leave this place alive,&quot; a sinister voice echoes throughout the halls. &quot;My master Daechanar will it so.&quot;<br>&quot;Thaurdir!&quot; Amarthiúl exclaims, unsheathing his blades.</p><p><b>When Revealed:</b> Add {card:Thaurdir-TToR@Thaurdir} to the staging area. Each player searches the encounter deck and discard pile for an {trait:Undead.@Undead} enemy and adds it to the staging area. Shuffle the encounter deck.</p>")
                .WithTemplate2("<p class='flavor-text'>The wraith you fought in Fornost has followed you since your flight from Mount Gram. Your only hope is to escape with the clues you've found.</p><p>Thaurdir's Pursuit has -5 quest points for each <a href='/Cards/Search?CardSet=The+Treachery+of+Rhudaur&CardType=Objective&Trait=Clue.' title='Clue Objectives from The Treachery of Rhudaur' target='_blank'><b><i>Clue</i></b> objective</a> attached to a character.</p><p><b>This stage cannot be defeated while {card:Thaurdir-TToR@Thaurdir} has any hit point remaining. If this stage is defeated, the players win the game.</b></p>")
                .WithIncludedEncounterSets(EncounterSet.RuinsOfArnor, EncounterSet.CursedDead)
                .WithInfo(95, 1, Artist.Anthony_Devine));
            Cards.Add(LotRCard.ObjectiveAlly("Amarthiúl", "", setName, 1, 3, 3, 3)
                .WithUnique()
                .WithTraits("Dúnedain.", "Ranger.", "Warrior.")
                .WithText("Response: After an enemy engages a player, give control of Amarthiúl to that player.\r\nIf Amarthiúl leaves play, the players lose the game.")
                .WithInfo(96, 1, Artist.Tomasz_Jedruszek));
            Cards.Add(LotRCard.Location("The Great Hall", "", setName, 4, 8)
                .WithUnique()
                .WithTraits("Ruins.")
                .WithText("Forced: When The Great Hall is explored, each player discards the top 5 cards of the encounter deck and chooses an Undead enemy he discarded in this way to add to the staging area.")
                .WithTemplate("<b>Forced:</b> When {self} is explored, each player discards the top 5 cards of the encounter deck and chooses an {trait:Undead.@Undead} enemy he discarded in this way to add to the staging area.")
                .WithInfo(97, 1, Artist.Davis_Engel));
            Cards.Add(LotRCard.Enemy("Thaurdir", "", setName, 1, 4, 6, 4, 9)
                .WithUnique()
                .WithTraits("Undead.", "Wraith.")
                .WithKeywords("Indestructible.")
                .WithText("Cannot have attachments.\r\nForced: After a treachery card with the Sorcery trait is revealed from the encounter deck, Thaurdir heals 3 damage and makes an immediate attack against the first player.")
                .WithTemplate("<p>{keyword:Indestructible.} Cannot have attachments.</p><p><b>Forced:</b> After a treachery card with the {trait:Sorcery.@Sorcery} trait is revealed from the encounter deck, {self} heals 3 damage and makes an immediate attack against the first player.</p>")
                .WithInfo(98, 1, Artist.Joel_Hustak));
            Cards.Add(LotRCard.Enemy("Wight of Rhudaur", "", setName, 23, 2, 3, 3, 5)
                .WithTraits("Undead.", "Wight.")
                .WithText("While the current quest has 1 or more progress on it, Wight of Rhudaur gains surge.\r\nWhile the current quest has 0 progress on it, Wight of Rhudaur gains doomed 2.")
                .WithFlavor("...evil spirits out of Angmar and Rhudaur entered into the deserted mounds and dwelt there. -The Return of the King")
                .WithTemplate("<p>While the current quest has 1 or more progress on it, {self} gains {keyword:Surge.@surge}.</p><p>While the current quest has 0 progress on it, {self} gains {keyword:Doomed 2.@doomed 2}.</p><p class='flavor-text'>...evil spirits out of Angmar and Rhudaur entered into the deserted mounds and dwelt there.<br>&ndash;The Return of the King</p>")
                .WithInfo(99, 2, Artist.Anthony_Devine));
            Cards.Add(LotRCard.Enemy("Traitorous Wight", "", setName, 32, 2, 4, 2, 4)
                .WithTraits("Undead.", "Wraith.")
                .WithText("Forced: When Traitorous Wight engages a player, remove 2 progress from each quest card in play.")
                .WithShadow("Shadow: For each point of damage dealt by this attack, remove 1 progress from each quest in play.")
                .WithTemplate("<p><b>Forced:</b> When {self} engages a player, remove 2 progress from each quest card in play.</p>{shadow}<p class='shadow-text'><b>Shadow:</b> For each point of damage dealt by this attack, remove 1 progress from each quest in play.</p>")
                .WithEasyModeQuantity(2)
                .WithInfo(100, 3, Artist.Anthony_Devine));
            Cards.Add(LotRCard.Location("Forbidden Descent", "", setName, 2, 6)
                .WithTraits("Ruins.")
                .WithText("While Forbidden Descent is in the staging area, the first 2 progress that would be placed on a quest each round must be placed on Forbidden Descent, instead.\r\nForced: If Forbidden Descent leaves play from the staging area, raise each player’s threat by 2.")
                .WithTemplate("<p>While {self} is in the staging area, the first 2 progress that would be placed on a quest each round must be placed on {self}, instead.</p><p><b>Forced:</b> If {self} leaves play from the staging area, raise each player’s threat by 2.</p>")
                .WithInfo(101, 2, Artist.Titus_Lunter));
            Cards.Add(LotRCard.Location("Eerie Halls", "", setName, 5, 4)
                .WithTraits("Ruins.")
                .WithText("Action: Raise your threat by 1 to reduce the Threat of Eerie Halls by 1 until the end of the phase. (Any player may trigger this action.)")
                .WithShadow("Shadow: If the defending player does not control at least 1 Clue objective, the attacking enemy makes an additional attack after this one.")
                .WithTemplate("<p><b>Action:</b> Raise your threat by 1 to reduce the {Threat} of {self} by 1 until the end of the phase. (Any player may trigger this action.)</p>{shadow}<p class='shadow-text'><b>Shadow:</b> If the defending player does not control at least 1 <a title='Clue Objective (The Treachery of Rhudaur)' href='/Cards/Search?CardSet=The+Treachery+of+Rhudaur&Trait=Clue.&CardType=Objective' target='_blank'><b><i>Clue</i></b> objective</a>, the attacking enemy makes an additional attack after this one.</p>")
                .WithEasyModeQuantity(1)
                .WithInfo(102, 2, Artist.Joshua_Calloway));
            Cards.Add(LotRCard.Location("Ghostly Ruins", "", setName, 4, 4)
                .WithTraits("Ruins.")
                .WithText("Any time the encounter deck runs out of cards, return the topmost Undead enemy in the encounter discard pile to the staging area before resetting the encounter deck.\r\nTravel: Return the topmost Undead enemy in the encounter discard pile to the staging area.")
                .WithFlavor("\"I am not sure that I like it: it has a - well, rather a barrow-wightish look.\" -Merry, The Fellowship of the Ring")
                .WithTemplate("<p>Any time the encounter deck runs out of cards, return the topmost {trait:Undead.@Undead} enemy in the encounter discard pile to the staging area before resetting the encounter deck.<p></p><b>Travel:</b> Return the topmost {trait:Undead.@Undead} enemy in the encounter discard pile to the staging area.</p><p class='flavor-text'></p>")
                .WithEasyModeQuantity(0)
                .WithInfo(103, 2, Artist.Matthew_Cowdery));
            Cards.Add(LotRCard.Location("Decrepit Remains", "", setName, 1, 3)
                .WithTraits("Ruins.")
                .WithText("While Decrepit Remains is in the staging area, each location and quest in the staging area gets +2 quest points.")
                .WithShadow("Shadow: For each point of damage dealt by this attack, remove 1 progress from each quest in play.")
                .WithTemplate("<p>While {self} is in the staging area, each location and quest in the staging area gets +2 quest points.</p>{shadow}<p class='shadow-text'><b>Shadow:</b> For each point of damage dealt by this attack, remove 1 progress from each quest in play.</p>") 
                .WithInfo(104, 2, Artist.Wibben));
            Cards.Add(LotRCard.Treachery("Centuries of Sorrow", "", setName)
                .WithKeywords("Surge.")
                .WithText("When Revealed: The first player must choose a new quest to be the current quest, if able.")
                .WithShadow("Shadow: If the defending player does not control at least 1 Clue objective, this attack is considered undefended.")
                .WithTemplate("<p>{keyword:Surge.}</p><p><b>When Revealed:</b> The first player must choose a new quest to be the current quest, if able.</p>{shadow}<p class='shadow-text'><b>Shadow:</b> If the defending player does not control at least 1 <a title='Clue Objective (The Treachery of Rhudaur)' href='/Cards/Search?CardSet=The+Treachery+of+Rhudaur&Trait=Clue.&CardType=Objective' target='_blank'><b><i>Clue</i></b> objective</a>, this attack is considered undefended.</p>")
                .WithEasyModeQuantity(1)
                .WithInfo(105, 2, Artist.Marcel_Mercado));
            Cards.Add(LotRCard.Treachery("Curse of the Years", "", setName)
                .WithTraits("Sorcery.")
                .WithText("When Revealed: Deal 1 damage to each exhausted character. Each player with a threat of 35 or higher must also discard each exhausted attachment he controls.")
                .WithShadow("Shadow: Attacking enemy gets +1 Attack (+3 Attack instead if the defending player does not control at least 1 Clue objective.)")
                .WithTemplate("<p><b>When Revealed:</b> Deal 1 damage to each exhausted character. Each player with a threat of 35 or higher must also discard each exhausted attachment he controls.</p>{shadow}<p class='shadow-text'><b>Shadow:</b> Attacking enemy gets +1 {Attack} (+3 {Attack} instead if the defending player does not control at least 1 <a title='Clue Objective (The Treachery of Rhudaur)' href='/Cards/Search?CardSet=The+Treachery+of+Rhudaur&Trait=Clue.&CardType=Objective' target='_blank'><b><i>Clue</i></b> objective</a>.)")
                .WithEasyModeQuantity(1)
                .WithInfo(106, 3, Artist.David_Ogilvie));
            Cards.Add(LotRCard.Treachery("Dark Covenant", "", setName)
                .WithTraits("Sorcery.")
                .WithText("When Revealed: Discard the top 3 cards of the encounter deck. The first player must either remove X progress from among the quests in play, or assign X damage among characters he controls. X is the total Threat of the discarded cards.")
                .WithShadow("Shadow: If this attack destroys a character, raise your threat by the destroyed character's Willpower.")
                .WithTemplate("<p><b>When Revealed:</b> Discard the top 3 cards of the encounter deck. The first player must either remove X progress from among the quests in play, or assign X damage among characters he controls. X is the total {Threat} of the discarded cards.</p>{shadow}<p class='shadow-text'><b>Shadow:</b> If this attack destroys a character, raise your threat by the destroyed character's {Willpower}.</p>")
                .WithInfo(107, 3, Artist.Yoann_Boissonnet));
            Cards.Add(LotRCard.Treachery("Haunting Fog", "", setName)
                .WithTraits("Sorcery.") 
                .WithText("When Revealed: Each player must exhaust a character he controls. Attach Haunting Fog to the current quest. (Counts as a Condition attachment with the text: \"Attached quest gets +6 quest points.\"")
                .WithFlavor("Fog still hung in veils upon the crumbling rock-wall...\r\n-The Fellowship of the Ring")
                .WithTemplate("<p><b>When Revealed:</b> Each player must exhaust a character he controls. Attach {self} to the current quest. (Counts as a Condition attachment with the text: &quot;Attached quest gets +6 quest points.&quot;</p><p class='flavor-text'>Fog still hung in veils upon the crumbling rock-wall...<br>&ndash;The Fellowship of the Ring</p>")
                .WithInfo(108, 3, Artist.Logan_Feliciano));
            Cards.Add(LotRCard.EncounterSideQuest("Quiet the Spirits", "", setName, 16)
                .WithText("While Quiet the Spirits is the current quest, each Undead enemy that enters play immediately engages the player with the highest threat. Enemies that engage a player from this effect contribute their Threat to the total Threat in the staging area until the end of the phase.\r\nForced: After an enemy is destroyed, place 2 progress on Quiet the Spirits.\r\nWhen this quest is defeated, flip it over.")
                .WithTemplate("<p>While {self} is the current quest, each Undead enemy that enters play immediately engages the player with the highest threat. Enemies that engage a player from this effect contribute their {Threat} to the total {Threat} in the staging area until the end of the phase.</p><p><b>Forced:</b> After an enemy is destroyed, place 2 progress on {self}.</p><p><b>When this quest is defeated, {card:Daechanar's-Brand-TToR@flip it over}.</b></p>")
                .WithInfo(109, 1, Artist.Adam_Lane));
            Cards.Add(LotRCard.Objective("Daechanar's Brand", "", setName)
                .WithTraits("Clue.")
                .WithText("Action: Exhaust Amarthiúl or a hero to claim Daechanar's Brand. Then, attach Daechanar's Brand to that character.\r\nAttached character gets +1 Attack while attacking undead enemies.")
                .WithFlavor("When you touch this dark blade, you can feel a cursed power coursing through it. In Tengwar, the name \"Daechanar\" is inscribed upon its handle.")
                .WithTemplate("<p><b>Action:</b> Exhaust {card:Amarthiul-TToR@Amarthiúl} or a hero to claim {self}. Then, attach {self} to that character.</p><p>Attached character gets +1 {Attack} while attacking {trait:Undead.@Undead} enemies.</p><p class='flavor-text'>When you touch this dark blade, you can feel a cursed power coursing through it. In Tengwar, the name &quot;Daechanar&quot; is inscribed upon its handle.</p>")
                .WithInfo(110, 1, Artist.Preston_Stone));
            Cards.Add(LotRCard.EncounterSideQuest("Sift through the Debris", "", setName, 18)
                .WithText("While Sift through the Debris is the current quest, each location in the staging area gets +1 Threat.\r\nForced: After a location is explored, place 2 progress on Sift through the Debris.\r\nWhen this quest is defeated, flip it over.")
                .WithFlavor("You search through the ashes of the keep's destroyed rooms. If you are diligent, you may be able to find a clue as to Iârion's ancestry.")
                .WithTemplate("<p class='flavor-text'>You search through the ashes of the keep's destroyed rooms. If you are diligent, you may be able to find a clue as to Iârion's ancestry.</b></p><p>While {self} is the current quest, each location in the staging area gets +1 {Threat}</p><p><b>Forced:</b> After a location is explored, place 2 progress on {self}.</p><p><b>When this quest is defeated, {card:Heirloom-of-Iarchon-TToR@flip it over}.</b></p>")
                .WithInfo(111, 1, Artist.Tomasz_Jedruszek));
            Cards.Add(LotRCard.Objective("Heirloom of Iârchon", "", setName)
                .WithTraits("Clue.")
                .WithText("Action: Exhaust Amarthiúl or a hero to claim Heirloom of Iârchon. Then, attach Heirloom of Iârchon to that character.\r\nAttached character gets +1 Willpower.")
                .WithFlavor("You find a pendant, similar to the one you've seen Iârion wearing. The inscription on the back says:\r\n\"Iârchon, may this pendant guide you away from the shadow that dwells within us all. -Your loving father\"")
                .WithTemplate("<p><b>Action:</b> Exhaust Amarthiúl or a hero to claim {self}. Then, attach {self} to that character.</p><p>Attached character gets +1 {Willpower}.</p><p class='flavor-text'>You find a pendant, similar to the one you've seen Iârion wearing. The inscription on the back says:<br>&quot;Iârchon, may this pendant guide you away from the shadow that dwells within us all. &ndash;Your loving father&quot;</p>")
                .WithInfo(112, 1, Artist.Romana_Kendelic));
            Cards.Add(LotRCard.EncounterSideQuest("Decipher Ancient Texts", "", setName, 14)
                .WithText("While Decipher Ancient Texts is the current quest, allies get –2 Willpower.\r\nAction: Pay 1 resource to place 1 progress on Decipher Ancient Texts. (Any player may trigger this action. Limit 3 times per round.)\r\nWhen this quest is defeated, flip it over.")
                .WithFlavor("You look through the keep's many torn and ancient records, hoping to find information to help you understand the Enemy's plan...")
                .WithTemplate("<p class='flavor-text'>You look through the keep's many torn and ancient records, hoping to find information to help you understand the Enemy's plan...</p><p>While {self} is the current quest, allies get –2 {Willpower}.</p><p><b>Action:</b> Pay 1 resource to place 1 progress on {self}. (Any player may trigger this action. Limit 3 times per round.)</p><p><b>When this quest is defeated, {card:Orders-from-Angmar-TToR@flip it over}.</b></p>")
                .WithInfo(113, 1, Artist.Nick_Deligaris));
            Cards.Add(LotRCard.Objective("Orders from Angmar", "", setName)
                .WithTraits("Clue.")
                .WithText("Action: Exhaust Amarthiúl or a hero to claim Orders from Angmar. Then, attach Orders from Angmar to that character.\r\nAttached character gets +1 Defense while defending against undead enemies.")
                .WithFlavor("You find a tattered, barely legible scroll dated over 1000 years ago, summong those loyal to the Witch-king of Angmar for an assault on Rivendell.")
                .WithTemplate("<p><b>Action:</b> Exhaust Amarthiúl or a hero to claim {self}. Then, attach {self} to that character.</p><p>Attached character gets +1 {Defense} while defending against {trait:Undead.@Undead} enemies.</p><p class='flavor-text'>You find a tattered, barely legible scroll dated over 1000 years ago, summong those loyal to the Witch-king of Angmar for an assault on Rivendell.</p>")
                .WithInfo(114, 1, Artist.Chris_Metcalf));
        }
    }
}