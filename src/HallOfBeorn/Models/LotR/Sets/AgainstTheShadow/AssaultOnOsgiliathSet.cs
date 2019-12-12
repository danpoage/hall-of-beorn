/* Generated CardSet class: Assault on Osgiliath */

using System;

namespace HallOfBeorn.Models.LotR.Sets.AgainstTheShadow
{
    public class AssaultOnOsgiliathSet : CardSet
    {
        protected override void Initialize()
        {
            Name = "Assault on Osgiliath";
            Abbreviation = "AoO";
            Number = 19;
            SetType = Models.SetType.Adventure_Pack;
            Cycle = "Against the Shadow";

            addHero("Faramir", 11, Sphere.Lore, 2, 2, 2, 5)
                .WithTraits("Gondor.", "Ranger.", "Noble.")
                .WithKeywords("Ranged.")
                .WithTextLine("Ranged.")
                .WithTextLine("Faramir gets +1 Attack for each enemy in the staging area.")
                .WithFlavorLine("\"The road may pass, but they shall not! Not while Faramir is Captain.\" -Mablung, The Two Towers")
                .WithInfo(81, 1, Artist.Magali_Villeneuve);
            addAttachment("Sword of Morthond", 1, Sphere.Leadership, true)
                .WithTraits("Item.", "Weapon.")
                .WithTextLine("Attach to a Gondor ally.")
                .WithTextLine("Attached ally gains the Outlands trait.")
                .WithFlavorLine("The Morthond Valye made a great bay that beat up against the sheer southern faces of the mountains.")
                .WithFlavorLine("-The Return of the King")
                .WithInfo(82, 3, Artist.Sara_K_Diesel);
            addEvent("Men of the West", 254, Sphere.Leadership)
                .WithTraits("Outlands.")
                .WithTextLine("Action: Return X Outlands allies from your discard pile to your hand.")
                .WithFlavorLine("Death in the morning and at day's ending")
                .WithFlavorLine("lords took and lowly. Long now they sleep")
                .WithFlavorLine("under grass in Gondor by the Great River.")
                .WithFlavorLine("-The Return of the King")
                .WithInfo(83, 3, Artist.Darek_Zabrocki);
            addAlly("Knight of Minas Tirith", 3, Sphere.Tactics, false, 0, 3, 1, 3)
                .WithTraits("Gondor.", "Warrior.")
                .WithTextLine("If each of your heroes has a printed Tactics resource icon, Knight of Minas Tirith gains: \"Response: After Knight of Minas Tirith enters play, choose an enemy in the staging area. Engage that enemy and exhaust Knight of Minas Tirith to declare it as attacker (and resolve its attack) against that enemy.\"")
                .WithInfo(84, 3, Artist.Emile_Denis);
            addAttachment("Gondorian Fire", 0, Sphere.Tactics, false)
                .WithTraits("Gondor.")
                .WithTextLine("Attach to a Gondor or Dúnedain hero.")
                .WithTextLine("Action: Spend 1 resource from attached hero's resource pool to give attached hero +1 Attack for each resource in its resource pool until the end of the phase. (Limit once per phase.)")
                .WithInfo(85, 3, Artist.Michael_Rasmussen);
            addAlly("Pelargir Shipwright", 3, Sphere.Spirit, false, 0, 1, 1, 3)
                .WithTraits("Gondor.", "Craftsman.")
                .WithTextLine("Pelargir Shipwright gets +1 Willpower for each hero you control with a printed Spirit resource icon.")
                .WithFlavorLine("\"It is forty leagues and two from Pelargir to the landings at the Harlond...\"")
                .WithFlavorLine("-Aragorn, The Return of the King")
                .WithInfo(86, 3, Artist.David_A_Nash);
            addAttachment("Map of Earnil", 4, Sphere.Spirit, true)
                .WithTraits("Record.")
                .WithTextLine("Attach to a Spirit hero.")
                .WithTextLine("Reduce the cost to play Map of Earnil by 1 for each hero you control with a printed Spirit resource icon.")
                .WithTextLine("Action: Discard Map of Earnil to play any Spirit event card in your discard pile as if it were in your hand. Then, place that event on the bottom of your deck.")
                .WithInfo(87, 3, Artist.Florian_Stitz);
            addAttachment("Ranger Bow", 1, Sphere.Lore, false)
                .WithTraits("Weapon.")
                .WithKeywords("Restricted.")
                .WithTextLine("Attach to a Ranger character. Restricted.")
                .WithTextLine("Action: Exhaust Ranger Bow and attached character to deal 1 damage to an enemy in the staging area.")
                .WithFlavorLine("Two had great bows, almost of their own height, and great quivers of long green-feathered arrows.")
                .WithFlavorLine("-The Two Towers")
                .WithInfo(88, 3, Artist.Aurelien_Hubert);
            addEvent("Forest Patrol", 1, Sphere.Lore)
                .WithTextLine("Play only if you control at least 1 Ranger character.")
                .WithTextLine("Action: Deal 3 damage to an enemy with at least 1 Trap card attached to it.")
                .WithFlavorLine("\"For coming unbidden to this play death is our law.\" -Anborn, The Two Towers")
                .WithInfo(89, 3, Artist.Kristina_Gehrmann);
            addAttachment("Palantir", 1, Sphere.Neutral, true)
                .WithTraits("Artifact.", "Item.")
                .WithTextLine("Attach to a Noble hero.")
                .WithTextLine("Planning Action: Exhaust Palantir and attached hero to name a card type and look at the top 3 cards of the encounter deck. For each of those cards that matches the named type, draw a card. For each of those cards that does not match the named type, raise your threat by 2.")
                .WithInfo(90, 3, Artist.Sandara_Tang);
            addQuest("Retake the City", EncounterSet.AssaultOnOsgiliath, 1, 'A', null)
                .WithTextLine("Setup: Each player chooses 1 enemy and 1 unique location and add them to the staging area. Shuffle the encounter deck.")
                .WithFlavorLine("You have returned to Minas Tirith just in time to join the army of Gondor as it marches to Osgiliath. An army of orcs and southrons have garrisoned the ancient city, but Lord Boromir means to retake it. Eager to strike a blow against Mordor, you will see the city retaken or die in the attempt...")
                .WithOppositeTextLine("Player card effects cannot place progress tokens on locations in the staging area.")
                .WithOppositeTextLine("Forced: When an Osgiliath location leaves play as an explored location, the first player takes control of that location.")
                .WithOppositeTextLine("If the players control all Osgiliath locations in play at the end of the round, they have won the game.")
                .WithIncludedEncounterSets(EncounterSet.MordorElite, EncounterSet.Southrons)
                .WithInfo(91, 1, Artist.Tomasz_Jedruszek);
            addEnemy("Uruk Lieutenant", EncounterSet.AssaultOnOsgiliath, 40, 2, 6, 2, 3)
                .WithTraits("Orc.", "Uruk.", "Mordor.")
                .WithTextLine("When Revealed: Add the topmost Orc enemy from the encounter discard pile to the staging area.")
                .WithShadow("Shadow: Defending player discards an attachment he controls. (All attachments he controls instead if undefended.)")
                .WithEasyModeQuantity(0)
                .WithInfo(92, 2, Artist.Blake_Henriksen);
            addEnemy("Uruk Soldier", EncounterSet.AssaultOnOsgiliath, 30, 1, 4, 1, 2)
                .WithTraits("Orc.", "Uruk.", "Mordor.")
                .WithTextLine("Forced: After Uruk Soldier attacks and destroys a character, that character's controller returns a location he controls to the staging area, if able.")
                .WithShadow("Shadow: Defending player raises his threat by 1 for each location he controls.")
                .WithInfo(93, 4, Artist.Blake_Henriksen);
            addEnemy("Southron Phalanx", EncounterSet.AssaultOnOsgiliath, 25, 1, 1, 2, 3)
                .WithTraits("Harad.")
                .WithTextLine("While engaged with a player, Southron Phalanx gets +1 Attack for each location that player controls.")
                .WithShadow("Shadow: Attacking enemy gets +1 Attack for each location the defending player controls.")
                .WithInfo(94, 3, Artist.J_Lonnee);
            addEnemy("Southron Commander", EncounterSet.AssaultOnOsgiliath, 37, 3, 5, 3, 6)
                .WithTraits("Harad.")
                .WithTextLine("When Revealed: Southron Commander makes an immediate attack from the staging area against each player who controls at least 1 location.")
                .WithFlavorLine("\"...the Southrons were bold men and grim...\"")
                .WithFlavorLine("-The Return of the King")
                .WithEasyModeQuantity(0)
                .WithInfo(95, 2, Artist.J_Lonnee);
            addLocation("West Gate", EncounterSet.AssaultOnOsgiliath, 2, 5)
                .WithUnique()
                .WithTraits("Osgiliath.")
                .WithTextLine("Action: If there is no active location, search the encounter deck and discard pile for an Osgiliath location, reveal it and add it to the staging area. Then, make West Gate the active location. Shuffle the encounter deck.")
                .WithTextLine("Forced: After the player who controls West Gate lets an attack go undefended, return West Gate to the staging area.")
                .WithInfo(96, 1, Artist.Michael_Rasmussen);
            addLocation("The King's Library", EncounterSet.AssaultOnOsgiliath, 2, 3)
                .WithUnique()
                .WithTraits("Osgiliath.")
                .WithTextLine("Travel: Reveal the top card of the encounter deck and add it to the staging area to travel here.")
                .WithTextLine("Forced: After the player who controls the King's Library lets an attack go undefended, return the King's Library to the staging area.")
                .WithFlavorLine("\"For that is the ruin of Osgiliath on either side of Anduin, which our enemies took and burned long ago.\"")
                .WithFlavorLine("-Beregond, The Return of the King")
                .WithInfo(97, 1, Artist.Julian_Kok);
            addLocation("Ancient Harbor", EncounterSet.AssaultOnOsgiliath, 1, 5)
                .WithUnique()
                .WithTraits("Osgiliath.")
                .WithTextLine("The players cannot travel here.")
                .WithTextLine("Combat Action: Exhaust a hero to place 1 progress token on Ancient Harbor.\r\nForced: After the player who controls Ancient Harbor lets an attack go undefended, return Ancient Harbor to the staging area.")
                .WithInfo(98, 1, Artist.Michael_Rasmussen);
            addLocation("The Old Bridge", EncounterSet.AssaultOnOsgiliath, 1, 6)
                .WithUnique()
                .WithTraits("Osgiliath.")
                .WithTextLine("The players cannot travel here.")
                .WithTextLine("Planning Action: Spend 2 resources to play 1 progress token on The Old Bridge. (1 resource instead if there is another Osgiliath location in the staging area.)\r\nForced: After the player who controls The Old Bridge lets an attack go undefended, return The Old Bridge to the staging area.")
                .WithInfo(99, 1, Artist.Adam_Lane);
            addLocation("West Quarter", EncounterSet.AssaultOnOsgiliath, 2, 3)
                .WithTraits("Osgiliath.")
                .WithTextLine("While West Quarter is the active location, the current quest gains Siege.")
                .WithShadow("Shadow: If this attack destroys a character, that character's controller must return a location he controls with the highest Threat to the staging area.")
                .WithEasyModeQuantity(1)
                .WithInfo(100, 2, Artist.Marcia_GeorgeBogdan);
            addLocation("East Quarter", EncounterSet.AssaultOnOsgiliath, 2, 3)
                .WithTraits("Osgiliath.")
                .WithTextLine("While East Quarter is the active location, the current quest gains Battle.")
                .WithShadow("Shadow: If this attack destroys a character, that character's controller must return a location he controls with the highest Threat to the staging area.")
                .WithEasyModeQuantity(1)
                .WithInfo(101, 2, Artist.Julian_Kok);
            addLocation("Ruined Square", EncounterSet.AssaultOnOsgiliath, 1, 2)
                .WithTraits("Osgiliath.")
                .WithKeywords("Surge.")
                .WithTextLine("Surge.")
                .WithTextLine("Response: After an enemy is defeated, place 1 progress token on Ruined Square.")
                .WithTextLine("Forced: If a player controls Ruined Square when a character leaves play, return Ruined Square to the staging area.")
                .WithInfo(102, 3, Artist.Darek_Zabrocki);
            addLocation("Ruined Tower", EncounterSet.AssaultOnOsgiliath, 2, 2)
                .WithTraits("Osgiliath.")
                .WithTextLine("Travel: If there is 1 active location, exhaust a character to travel here. (There are now 2 active locations.)")
                .WithTextLine("Forced: After the player who controls Ruined Tower loses control of a location, return Ruined Tower to the staging area.")
                .WithInfo(103, 3, Artist.Ilich_Henriquez);
            addTreachery("Pinned Down", EncounterSet.AssaultOnOsgiliath)
                .WithTextLine("When Revealed: Add X to the archery total this round. X is the number of locations the players control. If the players control less than 4 locations, Pinned Down gains surge.")
                .WithShadow("Shadow: If this attack destroys a character, that character's controller must return a location he controls with the highest Threat to the staging area.")
                .WithInfo(104, 2, Artist.Darek_Zabrocki);
            addTreachery("Street Fighting", EncounterSet.AssaultOnOsgiliath)
                .WithTextLine("When Revealed: Discard cards from the top of the encounter deck until an Osgiliath location is discarded. The first player may exhaust a hero to take control of that location. Otherwise, add that location to the staging area. This effect cannot be canceled.")
                .WithFlavorLine("And now the fighting waxed furious...")
                .WithFlavorLine("-The Return of the King")
                .WithInfo(105, 2, Artist.Darek_Zabrocki);
            addTreachery("Counter-attack", EncounterSet.AssaultOnOsgiliath)
                .WithKeywords("Surge.")
                .WithTextLine("Surge.")
                .WithTextLine("When Revealed: Each player must either return the location he controls with the highest Threat to the staging area, or raise his threat by the total Threat of all locations he controls.")
                .WithErrata()
                .WithEasyModeQuantity(1)
                .WithInfo(106, 2, Artist.Blake_Henriksen);
        }
    }
}
