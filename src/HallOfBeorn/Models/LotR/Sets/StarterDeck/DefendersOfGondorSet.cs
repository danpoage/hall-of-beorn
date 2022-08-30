using System;

namespace HallOfBeorn.Models.LotR.Sets.StarterDeck
{
    public class DefendersOfGondorSet
        : CardSet
    {
        public const string setName = "Defenders of Gondor";

        protected override void Initialize()
        {
            Name = setName;
            Abbreviation = "DoG";
            SetType = Models.SetType.Starter_Deck;
            Cycle = "Starter Deck";
            Number = 5005;

            addHero("Boromir", 11, Sphere.Leadership, 1, 3, 2, 5)
                .WithTraits("Gondor.", "Warrior.", "Noble.")
                .WithTextLine("While Boromir has at least 1 resource in his resource pool, Gondor allies get +1 Attack.")
                .WithFlavorLine("\"By our valour the wild fold of the East are still restrained, and the terror of Morgul kept at bay...\" -The Fellowship of the Ring")
                .WithCommunityVersion("RiddermarkLord/Boromir-Leadership-Hero")
                .WithInfo(1, 1, Artist.Magali_Villeneuve);
            addHero("Prince Imrahil", 11, Sphere.Leadership, 2, 3, 2, 4)
                .WithTraits("Gondor.", "Noble.")
                .WithTextLine("Response: After a character leaves play, ready Prince Imrahil. (Limit once per round.)")
                .WithFlavor("But beyond, in the great fief of Belfalas, dwelt Prince Imrahil in his castle of Dol Amroth by the sea, and he was of high blood, and his fold also, tall men and proud with sea-grey eyes. -The Return of the King.")
                .WithCommunityVersion("Prince-Imrahil-Grey-Company-Gen-Con-2015")
                .WithCommunityVersion("RiddermarkLord/Prince-Imrahil-Leadership-Hero-1")
                .WithCommunityVersion("Hrodebert/Prince-Imrahil-Leadership-Hero")
                .WithInfo(2, 1, Artist.David_A_Nash);
            addHero("Mablung", 10, Sphere.Tactics, 2, 2, 2, 4)
                .WithTraits("Gondor.", "Ranger.")
                .WithTextLine("Response: After you engage an enemy, add 1 resource to Mablung's resource pool. (Limit once per phase.)")
                .WithFlavorLine("But the Captains of the West were well warned by their scouts, skilled men from Henneth Annûn led by Mablung...")
                .WithFlavorLine("-The Return of the King")
                .WithCommunityVersion("RiddermarkLord/Mablung-Tactics-Hero-1")
                .WithInfo(3, 1, Artist.Sebastian_Giacobino);
            addAlly("Angbor the Fearless", 2, Sphere.Leadership, true, 2, 1, 0, 2)
                .WithTraits("Gondor.", "Warrior.")
                .WithTextLine("While your threat is 40 or higher, Angbor the Fearless gets +2 Attack and does not exhaust to quest.")
                .WithFlavorLine("\"Four thousands I sent marching from Pelargir through Lossarnach two days ago; and Angbor the fearless rides before them.\"")
                .WithFlavorLine("-Aragorn, The Return of the King")
                .WithInfo(4, 3, Artist.Vilius_Petrauskas);
            addAlly("Soldier of Gondor", 2, Sphere.Leadership, false, 1, 1, 1, 2)
                .WithTraits("Gondor.")
                .WithTextLine("Response: After Soldier of ~Gondor enters play, seach the top 5 cards of your deck for a Gondor ally and add it to your hand (any number of Gondor allies instead if your threat is 40 or higher). Shuffle your deck.")
                .WithInfo(5, 3, Artist.Stanislav_Dikolenko);
            addAlly("Citadel Custodian", 5, Sphere.Leadership, false, 1, 0, 1, 3)
                .WithTraits("Gondor.")
                .WithTextLine("Lower the cost to play Citadel Custodian by 1 for each Gondor ally in play.")
                .WithInfo(6, 3, Artist.Lorraine_Schleter);
            addAlly("Defender of Rammas", 2, Sphere.Tactics, false, 0, 1, 4, 1)
                .WithTraits("Gondor.", "Warrior.")
                .WithFlavorLine("\"And the Enemy must pay dearly for the crossing of the River.\" -Denethor, The Return of the King")
                .WithInfo(7, 3, Artist.Marcia_GeorgeBogdan);
            addAlly("Pelargir Ship Captain", 2, Sphere.Leadership, false, 1, 1, 0, 2)
                .WithTraits("Gondor.")
                .WithTextLine("Response: After Pelargir Ship Captain enters play, move 1 resource from the resource pool of a hero you control to another hero's resource pool.")
                .WithInfo(8, 3, Artist.Jake_Murray);
            addAlly("Errand-rider", 1, Sphere.Leadership, false, 0, 0, 0, 2)
                .WithTraits("Gondor.")
                .WithTextLine("Action: Exhaust Errand-rider to move 1 resource from the resource pool of a hero you control to another hero's resource pool.")
                .WithFlavorLine("For the people of the City used horses very little and they were seldom seen in their streets, save only those ridden by the errand-riders of their lord. -The Return of the King")
                .WithInfo(9, 3, Artist.Anna_Steinbauer);
            addAlly("Faramir", 4, Sphere.Leadership, true, 2, 1, 2, 3)
                .WithSlugSuffix("Ally")
                .WithTraits("Gondor.", "Noble.", "Ranger.")
                .WithTextLine("Action: Exhaust Faramir to choose a player. Each character controlled by that player gets +1 Willpower until the end of the phase.")
                .WithFlavor("\"He leads now in all perilous ventures. But his life is charmed, or fate spares him for some other end.\"\r\n-Mablung, Ranger of Ithilien,\r\nThe Two Towers")
                .WithCommunityVersion("Faramir-Core-Set-Completion")
                .WithCommunityVersion("Autumn/Faramir-Leadership-Ally")
                .WithInfo(10, 2, Artist.Jeff_Himmelman);
            addAlly("Gandalf", 5, Sphere.Neutral, true, 4, 4, 4, 4)
                .WithTraits("Istari.")
                .WithTextLine("At the end of the round, discard Gandalf from play.")
                .WithTextLine("Response: After Gandalf enters play, (choose 1): draw 3 cards, deal 4 damage to 1 enemy in play, or reduce your threat by 5.")
                .WithCommunityVersion("Gandalf-Core-Set-Completion")
                .WithInfo(11, 2, Artist.Lucas_Graciano);
            addAlly("Gondorian Spearman", 2, Sphere.Tactics, false, 0, 1, 1, 1)
                .WithTraits("Gondor.", "Warrior.")
                .WithKeywords("Sentinel.")
                .WithTextLine("Sentinel.")
                .WithTextLine("Response: After Gondorian Spearman is declared as a defender, deal 1 damage to the attacking enemy.")
                .WithFlavor("More than a thousand were there mustered. Their spears were like a springing wood. -The Two Towers")
                .WithInfo(12, 2, Artist.Winona_Nelson);
            addAlly("Envoy of Pelargir", 2, Sphere.Neutral, false, 1, 1, 0, 1)
                .WithTraits("Gondor.")
                .WithTextLine("Response: After Envoy of Pelargir enters play, add 1 resource to a Gondor or Noble hero's resource pool.")
                .WithInfo(13, 3, Artist.Magali_Villeneuve);          
            addAlly("Squire of the Citadel", 1, Sphere.Leadership, false, 0, 0, 1, 1)
                .WithTraits("Gondor.")
                .WithTextLine("Response: After Squire of the Citadel leaves play, add 1 resource to a Gondor hero's resource pool.")
                .WithFlavorLine("As he spoke he struck a small silver gong that stood near his footstool, and at once servants came forward.")
                .WithFlavorLine("-The Return of the King")
                .WithInfo(14, 3, Artist.Anna_Steinbauer);
            addAttachment("Captain of Gondor", 1, Sphere.Tactics, true)
                .WithTraits("Title.")
                .WithTextLine("Attach to a Warrior hero.")
                .WithTextLine("Response: After you optionally engage an enemy, exhaust ~Captain of ~Gondor to give attached hero +1 Attack and +1 Defense until the end of the round.")
                .WithFlavorLine("\"Boromir it was that drove the enemy at last back from this western shore...\" -Beregond, The Return of the King")
                .WithInfo(15, 3, Artist.Jarreau_Wimberly);
            addAttachment("Gondorian Shield", 1, Sphere.Tactics, false)
                .WithTraits("Armor.", "Item.")
                .WithKeywords("Restricted.")
                .WithTextLine("Attach to a hero. Restricted.")
                .WithTextLine("Limit 1 per hero.")
                .WithTextLine("Attached hero gains +1 Defense. (+2 Defense instead if attached hero has the Gondor trait.)")
                .WithFlavorLine("There flowered a White Tree, and that was for Gondor... -The Return of the King")
                .WithInfo(16, 3, Artist.Owen_William_Weber);
            addAttachment("Heir of Mardil", 1, Sphere.Leadership, true)
                .WithTraits("Title.")
                .WithTextLine("Attach to a Noble hero.")
                .WithTextLine("Response: After attached hero gains any number of resources from a card effect, exhaust Heir of Mardil to ready attached hero.")
                .WithFlavorLine("\"...in my turn I bore it, and so did each eldest son of our house, far back into the vanished years before the failing of the kings...\"")
                .WithFlavorLine("-Denethor, The Return of the King")
                .WithInfo(17, 3, Artist.Alexandre_Dainche);
            addAttachment("Steward of Gondor", 2, Sphere.Leadership, true)
                .WithTraits("Gondor.", "Title.")
                .WithTextLine("Attach to a hero. Attached hero gains the Gondor trait.")
                .WithTextLine("Action: Exhaust Steward of Gondor to add 2 resources to attached hero's resource pool.")
                .WithFlavor("\"It was commanded yesterday.\" -Denethor, The Return of the King")
                .WithInfo(18, 2, Artist.Empty_Room_Studios);
            addAttachment("Valiant Sword", 1, Sphere.Leadership, false)
                .WithTraits("Item.", "Weapon.")
                .WithKeywords("Restricted.")
                .WithTextLine("Attach to a Noble hero. Limit 1 per hero.")
                .WithTextLine("Restricted.")
                .WithTextLine("Attached hero gets +1 Attack (+2 Attack if your threat is 40 or higher).")
                .WithFlavorLine("...his sword of steel was valiant...")
                .WithFlavorLine("-The Fellowship of the Ring")
                .WithInfo(19, 3, Artist.Nikolas_Hagialas);
            addAttachment("Visionary Leadership", 2, Sphere.Leadership, true)
                .WithTraits("Skill.")
                .WithTextLine("Attach to a Gondor hero.")
                .WithTextLine("While attached hero has at least 1 resource in its resource pool, Gondor characters get +1 Willpower.")
                .WithFlavorLine("\"...still the lords of Gondor have keener sight than lesser men...\" -Denethor, The Return of the King")
                .WithInfo(20, 3, Artist.Milek_Jakubiec);
            addEvent("Behind Strong Walls", 1, Sphere.Tactics)
                .WithTextLine("Action: Ready a defending Gondor character. That character gets +1 Defense until the end of the phase.")
                .WithFlavorLine("...seven walls of stone so strong and old that it seemed to have been not builded by carven by giants out of the bones of the earth. -The Return of the King")
                .WithInfo(21, 3, Artist.Matt_Smith);         
            addEvent("Feint", 1, Sphere.Tactics)
                .WithTextLine("Combat Action: Choose an enemy engaged with a player. That enemy cannot attack that player this phase.")
                .WithFlavor("A few brave men were strung before them to make a feint of resistance, and many there fell before the rest drew back and fled to either side. -The Hobbit")
                .WithCommunityVersion("Feint-Core-Set-Completion")
                .WithInfo(22, 2, Artist.Lius_Lasahido);
            addEvent("Need Drives Them", 3, Sphere.Leadership)
                .WithTextLine("Action: Each player whose threat is 40 or higher readies all characters he controls.")
                .WithInfo(23, 3, Artist.Imad_Awan);
            addEvent("Pillars of the Kings", 4, Sphere.Leadership)
                .WithTextLine("While your threat is less than 40, reduce the cost to play Pillars of the Kings by 4.")
                .WithTextLine("Action: Set your threat to 40. If this effect raised your threat, draw a card (draw 4 cards instead if it raised your threat by 10 or more).")
                .WithFlavorLine("\"Behold the Argonath, the Pillars of the Kings!\"")
                .WithFlavorLine("-Aragorn, The Fellowship of the Ring")
                .WithInfo(24, 3, Artist.Sam_White);
            addEvent("Valiant Sacrifice", 1, Sphere.Leadership)
                .WithTextLine("Response: After an ally card leaves play, that card's controller draws 2 cards.")
                .WithFlavor("\"He fell defending the Hobbits, while I was away upon the hill.\"\r\n-Aragorn, The Two Towers")
                .WithInfo(25, 2, Artist.David_A_Nash);
            addEvent("Foe-hammer", 0, Sphere.Tactics)
                .WithTextLine("Response: After a hero you control attacks and destroys an enemy, exhaust a Weapon card attached to that hero to draw 3 cards.")
                .WithFlavorLine("It burned with a rage that made it gleam if goblins were about; now it was bright as blue flame for delight in the killing of the great lord of the cave.")
                .WithFlavorLine("-The Hobbit")
                .WithInfo(26, 3, Artist.Magali_Villeneuve);

            //Sideboard
            addHero("Beregond", 10, Sphere.Tactics, 0, 1, 4, 4)
                .WithTraits("Gondor.", "Warrior.")
                .WithKeywords("Sentinel.")
                .WithTextLine("Sentinel.")
                .WithTextLine("Lower the cost to play Weapon and Armor attachments on Beregond by 2.")
                .WithFlavorLine("\"It is over-late to send for aid when you are already besieged.\" -The Return of the King")
                .WithCommunityVersion("RiddermarkLord/Beregond-Tactics-Hero-1")
                .WithCommunityVersion("RiddermarkLord/Beregond-Tactics-Hero-2")
                .WithInfo(27, 1, Artist.Magali_Villeneuve);
            addHero("Faramir", 11, Sphere.Lore, 2, 2, 2, 5)
                .WithSlugSuffix("Hero")
                .WithTraits("Gondor.", "Ranger.", "Noble.")
                .WithKeywords("Ranged.")
                .WithTextLine("Ranged.")
                .WithTextLine("Faramir gets +1 Attack for each enemy in the staging area.")
                .WithFlavorLine("\"The road may pass, but they shall not! Not while Faramir is Captain.\"")
                .WithFlavorLine("-Mablung, The Two Towers")
                .WithCommunityVersion("RiddermarkLord/Faramir-Lore-Hero-1")
                .WithInfo(28, 1, Artist.Magali_Villeneuve);
            addAlly("Emyn Arnen Ranger", 2, Sphere.Lore, false, 0, 1, 1, 2)
                .WithTraits("Gondor.", "Ranger.")
                .WithTextLine("Response: After Emyn Arnen ~Ranger commits to the quest, choose an enemy with a Trap attachment. Until the end of the phase, Emyn Arnen ~Ranger gets +X Willpower, where X is the chosen enemy's printed Threat.")
                .WithInfo(29, 3, Artist.Aleksander_Karcz);
            addAttachment("Ranger Spikes", 2, Sphere.Lore, false)
                .WithTraits("Trap.")
                .WithTextLine("Play Ranger Spikes into the staging area unattached.If unattached, attach Ranger Spikes to the next eligible enemy that enters the staging area.Players do not make engagement checks against attached enemy. Attached enemy gets -2 Threat.")
                .WithInfo(30, 3, Artist.Titus_Lunter);
            addAttachment("Ithilien Pit", 1, Sphere.Lore, false)
                .WithTraits("Trap.")
                .WithTextLine("Play ~Ithilien Pit into the staging area unattached.")
                .WithTextLine("If unattached, attach ~Ithilien Pit to the next eligible enemy that enters the staging area.")
                .WithTextLine("Any character may choose attached enemy as the target of an attack.")
                .WithInfo(31, 3, Artist.David_Gaillet);
            addEvent("Coney in a Trap", 1, Sphere.Lore)
                .WithTextLine("Play only if you control a unique character with the Ranger trait and another unique character with the Warrior trait.")
                .WithTextLine("Response: After you engage an enemy, that enemy cannot attack you until the end of the round.")
                .WithInfo(32, 3, Artist.Jon_Bosco);
            addEvent("Helm of Secrecy", 4, Sphere.Neutral)
                .WithTextLine("Limit 1 per deck.")
                .WithTextLine("Action: Choose a hero you control and discard all tokens from it. Select a different non-Fellowship, non-Baggins hero from your collection with a threat cost less than or equal to the chosen hero. Swap those heroes, moving all eligible attachments to the hero from your collection.")
                .WithLimitOnePerDeck()
                .WithErrata(1)
                .WithInfo(33, 1, Artist.Andreia_Ugrai);
            addAttachment("Path of Need", 4, Sphere.Leadership, false)
                .WithTraits("Condition.")
                .WithTextLine("Limit 1 per deck. Attach to a location.")
                .WithTextLine("Heroes do not exhaust to attack, defend, or commit to a quest while attached location is the active location.")
                .WithFlavorLine("\"However it may prove, one must tread the path that need chooses!\"")
                .WithFlavorLine("-Gandalf, The Fellowship of the Ring")
                .WithLimitOnePerDeck()
                .WithInfo(34, 1, Artist.Magali_Villeneuve);
        }
    }
}