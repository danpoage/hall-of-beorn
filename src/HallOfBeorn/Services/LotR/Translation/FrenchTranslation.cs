﻿using System;
using System.Collections.Generic;
using HallOfBeorn.Models;

namespace HallOfBeorn.Services.LotR.Translation
{
    public class FrenchTranslation
        : TranslationBase
    {
        public FrenchTranslation()
            : base(Language.FR)
        {
        }

        protected override Dictionary<string, string> AddCardTypeNames()
        {
            return new Dictionary<string, string> {
                { "Player", "Joueur" },
                { "Hero", "Héros" },
                { "Ally", "Allié" },
                { "Character", "Personnage" },
                { "Attachment", "Attachement" },
                { "Event", "Événement" },
                { "Encounter", "Rencontrer" },
                { "Enemy", "Ennemi" },
                { "Location", "Lieu" },
                { "Treachery", "Traîtrise" },
                { "Objective", "Objectif" },
                { "Quest", "Quête" },
            };
        }

        protected override Dictionary<string, string> AddKeywords()
        {
            return new Dictionary<string, string> {
                { "Archery 1.", "Archerie 1." },
                { "Archery 2.", "Archerie 2." },
                { "Archery X.", "Archerie X." },
                { "Devoted.", "Dévoué." },
                { "Doomed 1.", "Maudit 1." },
                { "Guarded (enemy).", "Protégé (ennemi)." },
                { "Guarded (location).", "Protégé (lieu)." },
                { "Looter 0.", "Maraude 0." },
                { "Looter 1.", "Maraude 1." },
                { "Looter 2.", "Maraude 2." },
                { "Looter 3.", "Maraude 3." },
                { "Peril.", "Fatalité." },
                { "Ranged.", "À distance." },
                { "Restricted.", "Restreint." },
                { "Secrecy 1.", "Secret 1." },
                { "Sentinel.", "Sentinelle." },
                { "Steeds 1 Per Player.", "Coursiers 1 Per Player." },
                { "Steeds 1.", "Coursiers 1." },
                { "Steeds 2.", "Coursiers 2." },
                { "Steeds 3.", "Coursiers 3." },
                { "Steeds 4.", "Coursiers 4." },
                { "Surge.", "Renfort." },
                { "Time 7.", "Temps 7." },
                { "Vast.", "Vaste." },
            };
        }

        protected override Dictionary<string, string> AddTitles()
        {
            var all = new Dictionary<string, string>();

            //Core Set
            SafeMap(all, new Dictionary<string, string> {
                { "A Chosen Path", "Le Chemin Choisi" },
                { "A Fork in the Road", "Un Embranchement sur la Route" },
                { "A Light in the Dark", "Une Lumière dans les Ténèbres" },
                { "A Test of Will", "Tester sa Volonté" },
                { "Ambush on the Shore", "Embuscade sur la Rive" },
                { "Anduin Passage", "Traversée de l'Anduin" },
                
                { "Banks of the Anduin", "Berges de l'Anduin" },
                { "Beorn's Hospitality", "Hospitalité de Beorn" },
                { "Beorn's Path", "Le Chemin de Beorn" },
                { "Black Forest Bats", "Chauves-Souris de la Forêt Noire" },
                { "Blade Mastery", "Maîtrise des Armes" },
                { "Blade of Gondolin", "Lame de Gondolin" },
                { "Brok Ironfist", "Brok Poing-de-Fer" },

                { "Caught in a Web", "Pris dans la Toile" },
                { "Cavern Guardian", "Garde de la Caverne" },
                { "Celebrían's Stone", "Pierre de Celebrían" },
                { "Chieftan Ufthak", "Chef Ufthak" },
                { "Citadel Plate", "Armure de la Citadelle" },
                { "Common Cause", "Cause Commune" },
                
                { "Dark Knowledge", "Savoir Ténébreux" },
                { "Daughter of the Nimrodel", "Fille de la Nimrodel" },
                { "Despair", "Désespoir" },
                { "Dol Guldur Beastmaster", "Maître des Bêtes de Dol Guldur" },
                { "Dol Guldur Orcs", "Orques de Dol Guldur" },
                { "Don't Leave the Path", "Ne Quittez pas le Chemin" },
                { "Driven by Shadow", "Conduit par l'Ombre" },
                { "Dungeon Jailor", "Geôlier des Cachots" },
                { "Dungeon Torch", "Torche du Donjon" },
                { "Dwarven Axe", "Hache de Nain" },
                { "Dwarven Tomb", "Tombe de Nain" },

                { "East Bight Patrol", "Patrouille de la Brèche Est" },
                { "Eastern Crows", "Corbeaux de l'Est" },
                { "Enchanted Stream", "Rivière Enchantée" },
                { "Endless Caverns", "Cavernes Sans Fin" },
                { "Erebor Hammersmith", "Forgeron d'Erebor" },
                { "Ever Vigilant", "Toujours Vigilant" },
                { "Evil Storm", "Tempête Malfaisante" },
                { "Eyes of the Forest", "Les Yeux de la Forêt" },

                { "Feint", "Feinte" },
                { "Flies and Spiders", "Mouches et Araignées" },
                { "For Gondor!", "Pour le Gondor!" },
                { "Forest Gate", "Entrée de la Forêt" },
                { "Forest Snare", "Danger de la Forêt" },
                { "Forest Spider", "Araignée des Forêts" },
                { "Fortune or Fate", "Chance ou Destin" },

                { "Gandalf's Map", "Carte de Gandalf" },
                { "Gandalf's Search", "Recherches de Gandalf" },
                { "Gladden Fields", "Champs d'Iris" },
                { "Goblin Sniper", "Tireur Embusqué Gobelin" },
                { "Gondorian Spearman", "Lancier Gondorien" },
                { "Great Forest Web", "Grande Toile de la Forêt" },
                { "Grim Resolve", "Détermination Acharnée" },
                { "Guard of the Citadel", "Garde de la Citadelle" },

                { "Hasty Stroke", "Coup Précipité" },
                { "Henamarth Riversong", "Henamarth Chantrivière" },
                { "Hill Troll", "Troll des Collines" },
                { "Horn of Gondor", "Cor du Gondor" },
                { "Horseback Archer", "Archer à Cheval" },
                { "Hummerhorns", "Vrombicornes" },

                { "Iron Shackles", "Chaînes en Fer" },
                { "King Spider", "Roi Araignée" },

                { "Longbeard Orc Slayer", "Chasseur d'Orques Longue Barbe" },
                { "Lore of Imladris", "Savoir d'Imladris" },
                { "Lórien Guide", "Guide de la Lórien" },
                { "Lórien's Wealth", "Opulence de la Lórien" },

                { "Marsh Adder", "Serpent des Marais" },
                { "Massing at Night", "Rassemblement Nocturne" },
                { "Miner of the Iron Hills", "Mineur des Monts du Fer" },
                { "Misty Mountain Goblins", "Gobelins des Monts Brumeux" },
                { "Mountains of Mirkwood", "Montagnes de la Forêt Noire" },

                { "Nazgûl of Dol Guldur", "Nazgûl de Dol Guldur" },
                { "Necromancer's Pass", "Col du Nécromancien" },
                { "Northern Tracker", "Traqueur du Nord" },

                { "Old Forest Road", "Route de la Vieille Forêt" },
                { "Out of the Dungeons", "S'enfuir des Cachots" },

                { "Power in the Earth", "Le Pouvoir de la Terre" },
                { "Protector of Lórien", "Protecteur de la Lórien" },
                { "Pursued by Shadow", "Poursuivi par l'Ombre" },

                { "Quick Strike", "Coup Rapide" },

                { "Radagast's Cunning", "Ruse de Radagast" },
                { "Rain of Arrows", "Pluie de Flèches" },

                { "Secret Paths", "Chemins Secrets" },
                { "Self Preservation", "Instinct de Survie" },
                { "Shadow Key", "Clé-de-l'Ombre" },
                { "Silverlode Archer", "Archer du Cours d'Argent" },
                { "Sneak Attack", "Attaque Furtive" },
                { "Snowbourn Scout", "Éclaireur du Snowbourn" },
                { "Son of Arnor", "Fils de l'Arnor" },
                { "Stand and Fight", "Tenir et Combattre" },
                { "Stand Together", "Faire Face Ensemble" },
                { "Steward of Gondor", "Intendant du Gondor" },
                { "Strength of Will", "Force de la Volonté" },
                { "Swift Strike", "Coup Brutal" },

                { "The Brown Lands", "Les Terres Brunes" },
                { "The East Bight", "La Brèche Est" },
                { "The Favor of the Lady", "La Faveur de la Dame" },
                { "The Galadhrim's Greeting", "Salutations des Galadhrims" },
                { "The Necromancer's Reach", "A la Merci du Nécromancien" },
                { "The Necromancer's Tower", "La Tour du Nécromancien" },
                { "Thicket of Spears", "Haie de Lances" },
                { "Through the Caverns", "Par les Cavernes" },
                { "To the River...", "Vers le Fleuve..." },
                { "Tower Gate", "Porte de la Tour" },
                { "Treacherous Fog", "Brouillard Dangereux" },

                { "Under the Shadow", "Sous l'Ombre" },
                { "Unexpected Courage", "Courage Inattendu" },
                { "Ungoliant's Spawn", "Rejeton d'Ungoliant" },

                { "Valiant Sacrifice", "Sacrifice Héroique" },
                { "Veteran Axehand", "Vétéran à la Hache" },

                { "Wandering Took", "Touque Aventureux" },
                { "Will of the West", "Volonté de l'Ouest" },
                { "Wolf Rider", "Chevaucheur de Loup" }
            });
                
            //Children of Eorl
            SafeMap(all, new Dictionary<string,string> {
                { "Defend the Beacon", "Défendre le Feu d'Alarme" },
                { "Deeping Bowman", "Archer du Gouffre" },
                { "Open the Gates", "Ouvrez les Portes" },
                { "Wealth of Adventure", "Aventure Enrichissante" },
                { "Feast of Plenty", "Festin d'Abondance" },
                { "Deeping Defender", "Défenseur du Gouffre" },
                { "Morwen Steelsheen", "Morwen Lustre d'Acier" },
                { "It Should Be Spared", "Il Faut l'Épargner" },
                { "Spring the Trap", "Refermer le Piège" },
                { "Squire of the Mark", "Écuyer de la Marche" },
                { "Rammas Lookout", "Guetteur du Rammas" },
                { "Light-footed Steed", "Coursier au Pied Léger" },
                { "Rammas Sentry", "Sentinelle du Rammas" },
                { "Live Bait", "Appât vivant" },
                { "Worthy of Remembrance", "Digne de Souvenir" },
                { "Need Brooks No Delay", "Nécessité ne saurait attendre" },
                { "Wild Country", "Pays Sauvage" },
                { "Endless Grasslands", "Prairies Sans Fin" },
                { "Windworn Villages", "Villages Battus par les Vents" },
                { "Humpbacked Downs", "Côteaux Bossus" },
                { "Ride Through the Night", "Chevauchée Nocturne" },
                { "The Green Sea", "La Mer Verte" },
                { "Cold from the Mountains", "Froid des Montagnes" },
                { "Exhausting Winds", "Vents Éreintants" },
                { "Tired and Hungry", "Fatigué et Affamé" },
                { "Exposed to the Elements", "Exposé aux Éléments" },
                { "Old Farmhouse", "Vieille Grange" },
                { "Abandoned Mill", "Moulin Abandonné" },
                { "Dunland Chieftain", "Chef de Clan de Dun" },
                { "Wild Ravager", "Ravageur Sauvage" },
                { "Dunlending Berserker", "Berserker Dunlending" },
                { "Hillman Scout", "Éclaireur des Collines" },
                { "Surprise Attack", "Attaque Surprise" },
                { "A History of Strife", "Une Rivalité Ancestrale" },
                { "Recreant Rider", "Cavalier Renégat" },
                { "Deadly Defector", "Meurtrier Transfuge" },
                { "Orc Battalion", "Bataillon Orque" },
                { "Servant of the Eye", "Serviteur de l'Œil" },
                { "Black Land Scouts", "Éclaireurs des Terres Noires" },
                { "Orcish Horse-butcher", "Boucher Chevalin Orque" },
                { "Crimson Banner", "Bannière Pourpre" },
                { "White Mountain Reinforcements", "Renforts des Montagnes Blanches" },
                { "Brigand Ringleader", "Meneur Brigand" },
                { "Plundered Goods", "Biens Pillés" },
                { "Pillaging Swordsman", "Pillard Bretteur" },
                { "Grasping Slaver", "Chasseur d'Esclaves" },
                { "Vengeful Bowman", "Archer Vengeur" },
                { "Sneaky Thief", "Voleur Sournois" },
                { "Erelas Gates", "Portes de l'Erelas" },
                { "Crossroads", "La Croisée des Chemins" },
                { "Erelas Stables", "Étables de l'Erelas" },
                { "Chaos in the Hills", "Chaos dans les Collines" },
                { "Looted Weapons", "Armes Dérobées" },
                { "Stockpile Barricade", "Barricade de Fortune" },
                { "Erelas Beacon", "Feu d'Alarme de l'Erelas" },
                { "Host of Rohan", "Ost du Rohan" },
                { "Enraged Dunlending", "Dunlending Enragé" },
                { "Bald Hill", "Colline Pelée" },
                { "Wooden Barricade", "Barricade en Bois" },
                { "Rocky Slope", "Versants Rocheux" },
                { "Surrounding Grassland", "Prairies Environnantes" },
                { "Narrow Stair", "Escalier Étroit" },
                { "From All Sides", "De Tous les Côtés" },
                { "Another Wave", "Nouvelle Vague" },
                { "Assault Upon Erelas", "Assaut sur l'Erelas" },
                { "Reclaim the Beacon", "Reprendre le Feu d'Alarme" },
                { "Stolen Steeds", "Coursiers Volés" },
                { "Flinthoof", "Sabotdur" },
                { "Brightmane", "Claircrin" },
                { "Saddle-slasher", "Sabreur-de-Selle" },
                { "Rein-ripper", "Rompeur-de-Rêne" },
                { "Bridle-biter", "Broyeur-de-Bride" },
                { "Pommel-pouncer", "Arracheur-d'Arçon" },
                { "Spoiled Pasture", "Pâturage Dévasté" },
                { "Horse Thieves' Hovel", "Masure des Voleurs de Chevaux" },
                { "Horse Lord's Lodge", "Logis des Seigneurs des Chevaux" },
                { "Thirst for Horse Blood", "Soif de Sang Équin" },
                { "Overburdened", "Surchargé" },
                { "The Last Alliance", "La Dernière Alliance" },
                { "Drive them Away", "Repoussez-les" },
                { "Ambush!", "Embuscade !" },
                { "Battle for the Hill", "Bataille pour la Colline" },
                { "Hold the Hilltop", "Tenir le Sommet" },
                { "The Last Push", "L'Ultime Offensive" },
                { "Thieves and Coursers", "Voleurs et Coursiers" },
                { "The King's Stallion", "L'Étalon du Roi" },
                { "The Sweeping Tide", "Raz-de-Marée" },
            });

            //The Aldburg Plot
            SafeMap(all, new Dictionary<string,string> {
                { "A Case of Identity", "Une Affaire d'Identité" },
                { "A Fire Rises", "Un Début d'Incendie" },
                { "A Lesson in Caution", "Une Leçon de Prudence" },
                { "Aldburg Malcontent", "Aldburgeois Mécontent" },
                { "Buckland Shirriff", "Shirriff du Pays de Bouc" },
                { "Decrepit Hovel", "Taudis Décrépit" },
                { "Dunlending Agents", "Agents Dunlending" },
                { "Evil Under the Moon", "Le Mal sous la Lune" },
                { "False Lead", "Fausse Piste" },
                { "Fatty Bolger", "Gros Bolger" },
                { "Fear! Fire! Foes!", "Danger ! Au feu ! L'Ennemi !" },
                { "Garrison Barracks", "Caserne" },
                { "Gathering Clues", "Rassembler des Indices" },
                { "Great Mead Hall", "Grand Hall à Hydromel" },
                { "Horn-call of Buckland", "Sonnerie de Cor du Pays de Bouc" },
                { "Letter from Dunland", "Lettre du Pays de Dun" },
                { "Lily Cotton", "Lily Chaumine" },
                { "Misty Street", "Ruelle Embrumée" },
                { "Prison Key", "Clef de Prison" },
                { "Raven Signet Ring", "Chevalière au Corbeau" },
                { "Red Fletched Arrow", "Flèche aux Pennes rouges" },
                { "Red Harvest", "Moisson Rouge" },
                { "Rohirric Coins", "Pièces Rohiriques" },
                { "Ruby Cloak-pin", "Broche Rubis" },
                { "Silver Dagger", "Dague en Argent" },
                { "Spreading Inferno", "Brasier Dévorant" },
                { "Sudden Ambush", "Embuscade Soudaine" },
                { "Taken by the Night", "Emporté dans la Nuit" },
                { "The Armoury", "L'Armurerie" },
                { "The Horse's Tail", "Le Crin de Cheval" },
                { "The Man with the Twisted Lip", "L'Homme à la Lèvre Tordue" },
                { "The Prisoner in White", "Le Prisonnier en Blanc" },
                { "The Spy Master", "Le Maître-Espion" },
                { "The Uncertain Dawn", "Une Aube Incertaine" },
                { "The Whisperer", "La Chuchoteuse" },
                { "There and Back Again", "Un Aller et Retour" },
                { "Town Guard", "Garde de la Ville" },
                { "Traitor's Confession", "Confession du Traître" },
                { "Weep No More!", "Renonçons aux Larmes !" },
                { "Well-lit Hall", "Hall Lumineux" },
                { "Whisperer in the Darkness", "Chuchotement dans les Ténèbres" },
                { "Young Tom", "Tom le Jeune" },
            });

            //Fire on the Eastemnet
            SafeMap(all, new Dictionary<string,string> {
                { "Box of Earth", "Boîte de Terre" },
                { "Breath of Arda", "Souffle d'Arda" },
                { "Captured Steeds", "Coursiers Capturés" },
                { "Chieftain of the Skies", "Souverain du Ciel" },
                { "Cracking Horse Whip", "Fouet Claquant" },
                { "Eastemnet Pasture", "Pâturage de l'Estemnet" },
                { "Entwash Crossings", "Traversées de l'Entalluve" },
                { "Exhausted Pursuit", "Poursuite Éreintante" },
                { "Expanded Search", "Recherche Étendue" },
                { "Fang", "Croc" },
                { "Golden Crown", "Couronne d'Or" },
                { "Grip", "Étau" },
                { "Guided by Fate", "Guidé par le Destin" },
                { "Hidden Orc Camp", "Camp Orque Caché" },
                { "Hidden Roosts", "Perchoirs Cachés" },
                { "Messenger of Manwë", "Messager de Manwë" },
                { "Open Meadows", "Prairies Dégagées" },
                { "Orc Lookout", "Guetteur Orque" },
                { "Orcish Wrangler", "Éleveur Orque" },
                { "Panicked Horses", "Chevaux Paniqués" },
                { "Pillaged Stables", "Écuries Pillées" },
                { "Poachers in the Night", "Braconniers dans la Nuit" },
                { "Relentless Forces", "Forces Implacables" },
                { "Roving Herbmaster", "Herboriste Itinérante" },
                { "Shores of Anduin", "Rivages de l'Anduin" },
                { "To the River!", "À la Rivière !" },
                { "Veteran Eagle", "Vétéran Aigle" },
                { "White Mountain Beastmaster", "Maître des Bêtes des Montagnes Blanches" },
                { "Wild Steeds", "Coursiers Sauvages" },
                { "Wolf", "Loup" },
            });

            //The Gap of Rohan
            SafeMap(all, new Dictionary<string, string> {
                { "A Dangerous Pursuit", "Une Poursuite Dangereuse" },
                { "A Stout Heart", "Un Cœur Solide" },
                { "Archet Alekeeper", "Veilleur de Bière d'Archet" },
                { "Barliman Butterbur", "Prosper Poiredebeurré" },
                { "Biting Winds", "Vent Mordant" },
                { "Bree Pony", "Poney de Bree" },
                { "Bree-land Protector", "Protectrice du Pays de Bree" },
                { "Dunlending Rearguard", "Arrière-Garde Dunlending" },
                { "Exposed Ridge", "Crête Exposée" },
                { "Frantic Dunlending", "Dunlending Acharné" },
                { "Frozen Lake", "Lac Gelé" },
                { "Frozen Solid", "Pris par le Gel" },
                { "Gálmód’s Escort", "Escorte de Gálmód" },
                { "Gift of Foresight", "Don de Clairvoyance" },
                { "Giving Chase", "Partir en Chasse" },
                { "Half-pint", "Demi-Pinte" },
                { "Harry Goatleaf", "Harry Chèvrefeuille" },
                { "Pint", "Pinte" },
                { "Recapture the Traitor", "Recapturer le Traître" },
                { "Scheming Staddler", "Comploteuse Staddeloise" },
                { "Seasoned Forager", "Cueilleur Averti" },
                { "Slippery Hill", "Colline Glissante" },
                { "Snow Squall", "Rafale de Neige" },
                { "Snowbank", "Congère" },
                { "Stumble in the Snow", "Trébucher dans la Neige" },
                { "Unnatural Cold", "Froid Contre Nature" },
                { "White Wall", "Mur Blanc" },
            });

            //Scouring of the Shire
            SafeMap(all, new Dictionary<string,string> {
                { "Against the Rules", "Contre les Règles" },
                { "Ambush Sharkey's Men", "Tendre une Embuscade aux Hommes de Sharcoux" },
                { "Awake! Fire, Foes! Awake!", "Debout ! La Peur, le Feu, les Ennemis ! Debout !" },
                { "Brandywine Gate", "Porte du Brandevin" },
                { "Brick Building", "Bâtiment de Brique" },
                { "Bright Mail", "Mailles Brillantes" },
                { "Curse Upon the Shire", "Malédiction sur la Comté" },
                { "East Road", "Route de l'Est" },
                { "Escorted “Prisoners”", "“Prisonniers” Escortés" },
                { "Feather-capped Shirriff", "Shirriff au Chapeau à Plumes" },
                { "Find the Gaffer", "Trouver le Vieux" },
                { "Frodo Baggins", "Frodon Sacquet" },
                { "Gang of Ruffians", "Bande de Coquins" },
                { "Gríma's Choice", "Le Choix de Gríma" },
                { "Heightened Stature", "Haute Stature" },
                { "Hidden Blade", "Lame Dissimulée" },
                { "Highway Robber", "Voleur de Grand Chemin" },
                { "Hobbiton Road", "Route de Hobbitebourg" },
                { "Into the West", "À l'Ouest" },
                { "Many Partings", "Nombreuses Séparations" },
                { "Muster the Tooks", "Rassembler les Touque" },
                { "Once Beloved Place", "Lieu Jadis Apprécié" },
                { "One Ill Turn", "Un Mauvais Tour" },
                { "Raise the Shire", "Soulever la Comté" },
                { "Rouse the Cottons", "Éveiller les Chaumine" },
                { "Roused Hobbits", "Hobbits Éveillés" },
                { "Saruman", "Saroumane" },
                { "Scatha's Horn", "Cor de Scatha" },
                { "Set up Barriers", "Dresser des Barrières" },
                { "Sharkey's Men", "Hommes de Sharcoux" },
                { "Shirriff House", "Maison du Shirriff" },
                { "Star-like Gem", "Gemme Étincelante" },
                { "Take Him, Lads!", "Saisissez le, les Gars !" },
                { "The Battle of Bywater", "La Bataille de Lézeau" },
                { "The Lockholes", "Les Trous Prisons" },
                { "The Scouring of the Shire", "Le Nettoyage de la Comté" },
                { "The Very Last Stroke", "Le Tout Dernier Coup" },
                { "Thieving Ruffian", "Canaille" },
                { "Three-Farthing Stone", "Pierre des Trois Quartiers" },
                { "To the Road Again, Worm!", "En Route, Serpent !" },
                { "Voice of Saruman", "Voix de Saroumane" },
                { "Watch the East Road", "Surveiller la Route de l'Est" },
                { "Wooden Shed", "Cabane en Bois" },
            });

            return all;
        }

        protected override Dictionary<string, string> AddTraits()
        {
            return new Dictionary<string, string> {
                { "Armor.", "Armure." },
                { "Artifact.", "Artéfact." },
                
                { "Beorning.", "Beornide." },

                { "Clue.", "Indice." },
                { "Creature.", "Créature." },

                { "Doom.", "Destin." },
                { "Dunland.", "Pays de Dun." },
                
                { "Eagle.", "Aigle." },

                { "Garrison.", "Garnison." },
                { "Gate.", "Porte." },
                { "Gift.", "Présent." },
                
                { "Healer.", "Guérisseur." },
                { "Hideout.", "Refuge." },
                { "Hill.", "Collines." },
                { "Hills.", "Collines." },

                { "Inferno.", "Brasier." },
                { "Item.", "Objet." },

                { "Lake.", "Lac." },
                { "Mount.", "Monture." },
                { "Mountain.", "Montagne." },
                { "Orc.", "Orque." },
                { "Plains.", "Plaines." },

                { "Ranger.", "Rôdeur." },
                { "River.", "Rivière." },
                { "Road.", "Route." },
                { "Ruffian.", "Bandit." },
                
                { "Scout.", "Éclaireur." },
                { "Servant.", "Serviteur." },
                { "Sharkey.", "Sharcoux." },
                { "Shire.", "Comté." },
                { "Skill.", "Compétence." },
                { "Snow.", "Neige." },
                { "Spy.", "Espion." },
                { "Stair.", "Escalier." },
                { "Suspicious.", "Suspect." },

                { "Traitor.", "Traître." },
                { "Trap.", "Piège." },

                { "Underground.", "Souterrain." },

                { "Warrior.", "Guerrier." },
                { "Weather.", "Climat." },
                { "Westfold.", "Ouestfolde." },
                { "Woodman.", "Homme des Bois." },
            };
        }
    }
}