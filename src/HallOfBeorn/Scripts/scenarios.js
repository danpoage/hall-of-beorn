var mode = 'Normal';

$(function () {

    initQuestMap();

    var scenarioChartInitialized = false;
    var chartsInitialized = false;
    $('#toggleChart').click(function () {
        if (!scenarioChartInitialized) {
            var scenariosIndex = window.location.href.lastIndexOf("/Scenarios/");
            var id = '';
            if (scenariosIndex != -1) {
                id = window.location.href.substr(scenariosIndex + 11);
            }
            loadScenarioChart(id);
            scenarioChartInitialized = true;
        }
        $('#chartContainer').toggle();
        var text = $('#toggleChart').html();
        var newText = text == 'Show Chart' ? 'Hide Chart' : 'Show Chart';
        $('#toggleChart').html(newText);
    });
    $('#toggleCharts').click(function () {
        if (!chartsInitialized) {
            loadCharts();
            chartsInitialized = true;
        }
        $('#chartsContainer').toggle();
        var text = $('#toggleCharts').html();
        var newText = text == 'Show Charts' ? 'Hide Charts' : 'Show Charts';
        $('#toggleCharts').html(newText);
    });
    $('#easyModeButton').click(function () {
        $('#easyModeButton').removeClass('inactiveButton').addClass('activeButton');
        $('#normalModeButton').removeClass('activeButton').addClass('inactiveButton');
        $('#nightmareModeButton').removeClass('activeButton').addClass('inactiveButton');
        mode = 'Easy';
        loadCharts();
    });
    $('#normalModeButton').click(function () {
        $('#easyModeButton').removeClass('activeButton').addClass('inactiveButton');
        $('#normalModeButton').removeClass('inactiveButton').addClass('activeButton');
        $('#nightmareModeButton').removeClass('activeButton').addClass('inactiveButton');
        mode = 'Normal';
        loadCharts();
    });
    $('#nightmareModeButton').click(function () {
        $('#easyModeButton').removeClass('activeButton').addClass('inactiveButton');
        $('#normalModeButton').removeClass('activeButton').addClass('inactiveButton');
        $('#nightmareModeButton').removeClass('inactiveButton').addClass('activeButton');
        mode = 'Nightmare';
        loadCharts();
    });
});

function initQuestMap() {
    $('#map-tooltip').hide();

    var questMap = [];
    var imageMap = [];
    var textMap = [];
    var xMap = []; var yMap = [];
    var radius = 8;

    function addRange(map, number, code, label) {
        for (var i = number - radius; i <= number + radius; i++) {
            if (map[i] === undefined) {
                //console.log(label + ' map not defined for value: ' + i);
                map[i] = [code];
            } else {
                //console.log(label + ' map already defined for value: ' + i);
                map[i].push(code);
            }
        }
    };

    function addQuest(x, y, name, questUrl, imageUrl, text) {
        questMap[name] = questUrl;
        imageMap[name] = imageUrl;
        textMap[name] = text;

        addRange(xMap, x, name, 'X');
        addRange(yMap, y, name, 'Y');
    };

    function getCodes(map, number, label) {
        return map[number] ? map[number] : [];
    };

    function arrayIntersectShouldBePartOfTheLanguage(a1, a2) {
        return a1.filter(function (n) {
            return a2.indexOf(n) !== -1;
        });
    };

    function getMapX(e) {
        return Math.round(e.pageX - $('#quest-map').offset().left)
    }

    function getMapY(e) {
        return Math.round(e.pageY - $('#quest-map').offset().top)
    }

    function getSelectedQuest(e) {
        var x = getMapX(e);
        var y = getMapY(e);
        var xCodes = getCodes(xMap, x, 'X');
        var yCodes = getCodes(yMap, y, 'Y');

        return arrayIntersectShouldBePartOfTheLanguage(xCodes, yCodes);
    };

    //Core Set and Shadows of Mirkwood
    addQuest(927, 287, 'Passage Through Mirkwood', 'Passage-Through-Mirkwood', 'Core-Set/Flies-and-Spiders-1A.jpg',
        'You are traveling through Mirkwood forest, carrying an urgent message from King Thanduil to the Lady Galadriel of Lorien. As you move along the dark trail, the spiders gather around you...');
    addQuest(846, 343, 'Journey Along the Anduin', 'Journey-Along-the-Anduin', 'Core-Set/To-the-River-1A.jpg',
        'Emerging from Mirkwood Forest with an urgent message from Lady Galadriel, you must make your way south along the Anduin River in order to reach the forst of Lórien. As you leave the forest behind, you notice that you are being pursued, and thus quicken your pace...');
    addQuest(898, 476, 'Escape from Dol Guldur', 'Escape-from-Dol-Guldur', 'Core-Set/The-Necromancer\'s-Tower-1A.jpg',
        'The Lady Galadriel of Lórien has asked you to investigate the area in the vicinity of Dol Guldar. While doing so, one of your allies was ambushed by Orcs, captured, and is now held in a dungeon cell...');
    addQuest(818, 320, 'The Hunt for Gollum', 'The-Hunt-for-Gollum', 'The-Hunt-for-Gollum/The-Hunt-Begins-1A.jpg',
        'Gandalf has requested your assistance in the search for the elusive creature known as Gollum. Your search begins in the Anduin Valley between Mirkwood Forest and the Misty Mountains');
    addQuest(818, 275, 'Conflict at the Carrock', 'Conflict-at-the-Carrock', 'Conflict-at-the-Carrock/Grimbeorn\'s-Quest-1A.jpg',
        'GRRRRRR GRRRRRRR GRRRRRRR... I smell Trolls...');
    addQuest(895, 403, 'A Journey to Rhosbogel', 'A-Journey-to-Rhosgobel', 'A-Journey-To-Rhosgobel/The-Wounded-Eagle-1A.jpg',
        'After a fierce conflict with a group of Trolls, you come across a fallen Eagle, grievously wounded and on the verge of death.');
    addQuest(917, 658, 'The Hills of Emyn Muil', 'The-Hills-of-Emyn-Muil', 'The-Hills-of-Emyn-Muil/The-Hills-of-Emyn-Muil-1A.jpg',
        'The hunt for Gollum has led you to the south, and you are now approaching Rauros falls and the nearby hills of Emyn Muil...');
    addQuest(946, 694, 'The Dead Marshes', 'The-Dead-Marshes', 'The-Dead-Marshes/Into-the-Marshes-1A.jpg',
        'You have followed Gollum\'s trail for days, and are now closing in fast pursuit. In a last ditch effort to escape you, the creature has fled to The Dead Marshes.');
    addQuest(950, 287, 'Return to Mirkwood', 'Return-to-Mirkwood', 'Return-to-Mirkwood/Through-the-Forest-1A.jpg',
        'Having captured Gollum, you must now escort him through Mirkwood Forest for interrogation at Thranduil\'s Palace.');

    //Khazad-dum and Dwarrowdelf
    addQuest(696, 441, 'Into the Pit', 'Into-the-Pit', 'Khazad-dum/Entering-the-Mines-1A.jpg',
        'You have been sent by the White Council to Moria, to deliver a message to Balin and his Dwarven colony. No one has heard from him in a while.');
    addQuest(718, 441, 'The Seventh Level', 'The-Seventh-Level', 'Khazad-dum/Search-for-the-Chamber-1A.jpg',
        'You are investigating the Seventh Level of Moria, searching for the Chamber of Records and any signs of Balin\'s Colony. In the heavy twilight of a hall, a bulky tome is discovered in the grip of a Dwarf skeleton. You carefully take possession of the book. Perhaps it will give you some answers...');
    addQuest(742, 441, 'Flight from Moria', 'Flight-from-Moria', 'Khazad-dum/A-Presence-in-the-Dark-1A.jpg',
        'You have discovered the fate of the Dwarven colony, and seek to leave Moria. But exiting may not be as simple as entering...');
    addQuest(733, 404, 'The Redhorn Gate', 'The-Redhorn-Gate', 'The-Redhorn-Gate/Up-the-Pass-1A.jpg',
        'Celeborn has bid you to visit her father in Rivendell. Your journey takes you though the Redhorn Gate...');
    addQuest(727, 351, 'Road to Rivendell', 'Road-to-Rivendell', 'Road-to-Rivendell/Along-the-Misty-Mountains-1A.jpg',
        'Your party has braved the snows of the pass, but now must travel North along the Misty Mountains for league upon league as you escort Arwen to her father\'s house.');
    addQuest(764, 441, 'The Watcher in the Water', 'The-Watcher-in-the-Water', 'The-Watcher-in-the-Water/To-the-West-door-1A.jpg',
        'Elrond has asked you to scout the Mines of Moria on your return to Lorien, hoping to discover if it is the source of increased Orc activity along the Misty Mountains.');
    addQuest(697, 464, 'The Long Dark', 'The-Long-Dark', 'The-Long-Dark/Journey-in-the-Black-Pit-1A.jpg',
        'Your party is scouting the Mines of Moria, searching for signs of Orcs. Dark tunnels and twisting passages spread out in all directions, a labyrinthine maze that you could wander in forever if you take the wrong path.');
    addQuest(718, 464, 'Foundations of Stone', 'Foundations-of-Stone', 'Foundations-of-Stone/The-Dripping-Walls-1A.jpg',
        'Your journey has led to a decrepit portion of the mines, untouched by Dwarven pick for many a year. The air grows thick with moisture, and the walls almost appear to be weeping.')
    addQuest(741, 464, 'Shadow and Flame', 'Shadow-and-Flame', 'Shadow-and-Flame/Nearing-the-Gate-1A.jpg',
        'As you reach the eastern realm of Darrowdelf the craftsmanship of the Dwarves is proudly displayed. But the sound of drums sound in the deep, and it appears that these halls are infested with Orcs.');

    //Heirs of Numenor and Against the Shadow
    addQuest(926, 900, 'Peril in Pelargir', 'Peril-in-Pelargir', 'Heirs-of-Numenor/The-Leaping-Fish-Quest-1A.jpg',
        'The White Council has sent you by ship to Gondor to help fight the threat of Mordor. Upon arrival in the port city of Pelargir, you are greeted by Lord Alcaron who takes you to The Leaping Fish where you can speak privately.');
    addQuest(972, 863, 'Into Ithilien', 'Into-Ithilien', 'Heirs-of-Numenor/Ambush-in-Ithilien-1A.jpg',
        'You\'ve arrived in Ithilien with a sealed message for Faramir, only to learn that he has gone north to defend Cair Andros from massing enemy forces.');
    addQuest(964, 765, 'The Siege of Cair Andros', 'The-Siege-of-Cair-Andros', 'Heirs-of-Numenor/The-Defense-1A.jpg',
        'The island fortress of Cair Andros, which guards Gondor\'s northernmost causeways over the river Anduin, is under siege! Battering rams rumble up the eastern causeway and rafts filled with Orcs float across the river toward the lightly defended northern banks.');
    addQuest(958, 801, 'The Steward\'s Fear', 'The-Stewards-Fear', 'The-Steward\'s-Fear/Conspiracy-1A.jpg',
        'Even as foes mass from without, the Steward of Minas Tirith fears there are enemies within. You have been asked to investigate the possibility of a conspiracy within the White City...');
    addQuest(910, 779, 'The Drúadan Forest', 'The-Druadan-Forest', 'The-Druadan-Forest/The-Pursuit-1A.jpg',
        'The leader of the underworld cabal from Minas Tirith has fled with his remaining henchmen. You have followed his trail to The Drúadan Forest, hoping to bring the nameless villain to justice.');
    addQuest(933, 784, 'Encounter at Amon-din', 'Encounter-at-Amon-din', 'Encounter-at-Amon-Din/Savagery-of-the-Orcs-1A.jpg',
        'Emerging from the Druadan Forest with news of the conspirators\' demise, you begin your journey to Minas Tirith. As you wake the following day, you see dark plumes of smoke rising across the lands of Anórien.');
    addQuest(1002, 844, 'Assault on Osgiliath', 'Assault-on-Osgiliath', 'Assault-on-Osgiliath/Retake-the-City-1A.jpg',
        'You have returned to Minas Tirith just in time to join the army of Gondor as it marches to Osgiliath. An army of orcs and southrons have garrisoned the ancient city, but Lord Boromir means to retake it. Eager to strike a blow against Mordor, you will see the city retaken or die in the attempt...');
    addQuest(1002, 737, 'The Blood of Gondor', 'The-Blood-of-Gondor', 'The-Blood-of-Gondor/The-Ambush-1A.jpg',
        'After the assault on Osgiliath, Lord Alcaron urges Boromi to pursue the retreating enemy. Boromir agrees and gives permission to Faramir and his rangers. Grateful for you valiant efforts in Gondor\'s defense, Faramir invites you to join the hunt...');
    addQuest(1004, 796, 'The Morgul Vale', 'The-Morgul-Vale', 'The-Morgul-Vale/The-Rearguard-1A.jpg',
        'Lord Alcaron and Faramir have been captured by forces from Minas Morgul. You pursue their captors eastward into the dreaded vale.');

    //The Hobbit Saga
    addQuest(683, 289, 'We Must Away Ere Break of Day', 'We-Must-Away-Ere-Break-of-Day', 'The-Hobbit-Over-Hill-and-Under-Hill/An-Unexpected-Party-1A.jpg',
        'The wizard Gandalf has chosen Bilbo Baggins to join Thorin and company on their quest to the Lonley Mountain.');
    addQuest(757, 286, 'Over the Misty Mountains Grim', 'Over-the-Misty-Mountains-Grim', 'The-Hobbit-Over-Hill-and-Under-Hill/A-Short-Rest-1A.jpg',
        'After a refreshing stay in the House of Elrond, Bilbo and his companions resumed their quest for the Lonely Mountain. But to reach Erebor, they first had to climb the high pass over the Misty Mountains.');
    addQuest(780, 285, 'Dungeons Deep and Caverns Dim', 'Dungeons-Deep-and-Caverns-Dim', 'The-Hobbit-Over-Hill-and-Under-Hill/Out-of-the-Frying-Pan-1A.jpg',
        'After killing the Great Goblin, Bilbo\'s companions fought to win their escape from the goblins. By the time they realized that Bilbo had been lost in the darkness, it was too late to turn back and search for him.');
    addQuest(940, 305, 'Flies and Spiders', 'Flies-and-Spiders', 'The-Hobbit-On-the-Doorstep/Into-Mirkwood-1A.jpg',
        '"Stick to the forest-track, keep your spirits up, hope for the best, and with a tremendous slice of luck you may come out one day and see the Long Marshes lying below you, and beyond them, high in the East, the Lonely Mountain where dear old Smaug lives."<br>-Gandalf, The Hobbit');
    addQuest(996, 202, 'The Lonely Mountain', 'The-Lonely-Mountain', 'The-Hobbit-On-the-Doorstep/A-Warm-Welcome-1A.jpg',
        'So one day, although autumn was now getting far on, and winds were cold, and leaves were falling fast, three large boats left Lake–town, laden with rowers, dwarves, Mr. Baggins, and many provisions.<br>–The Hobbit');
    addQuest(1017, 216, 'The Battle of Five Armies', 'The-Battle-of-Five-Armies', 'The-Hobbit-On-the-Doorstep/The-Gathering-of-the-Clouds-1A.jpg',
        '"Dread has come upon you all! Alas! It has come more swiftly than I guessed. The Goblins are upon you! Bolg of the North is coming. O Dain! whose father you slew in Moria. Beehold! the bats are above his army like a sea of locusts. They ride upon wolves and Wargs are in their train!"<br>- Gandalf, The Hobbit');

    //The Lord of the Rings Saga
    addQuest(406, 317, 'A Shadow of the Past', 'A-Shadow-of-the-Past', 'The-Black-Riders/Three-is-Company-1A.jpg',
        'The ring Frodo Baggins inherited from his uncle Bilbo is indeed The One Ring. After conferring with the wizard Gandalf, Frodo decides to leave the Shire and take the ring to Rivendell.');
    addQuest(560, 309, 'A Knife in the Dark', 'A-Knife-in-the-Dark', 'The-Black-Riders/Trouble-in-Bree-1A.jpg',
        'Frodo and his companions arrive at Bree to find the shadow of the Black Riders already on the crossroads town. Unsure of who to trust, they decide to lodge at The Prancing Pony. There they meet a friend of Gandalf named Strider who offers to lead them to Rivendell, but their movements are also tracked by less savory folk.');
    addQuest(693, 315, 'Flight to the Ford', 'Flight-to-the-Ford', 'The-Black-Riders/Pursued-by-the-Enemy-1A.jpg',
        'Frodo has been gravely injured in the attack on Weathertop and will perish if his companions cannot bring him to Rivendell in time. Strider leads the Hobbits towards the hidden valley, anxiously listening for the sound of Black Riders...');
    addQuest(715, 371, 'The Ring Goes South', 'The-Ring-Goes-South', 'The-Road-Darkens/The-Council-of-Elrond-1A.jpg',
        'In the House of Elrond, the evil wound that Frodo received on Weathertop is healed and he is reunited with his uncle Bilbo. The One Ring cannot remain hidden in Rivendell for long, so Lord Elrond summons a council to decide what should be done to protect the Free Peoples of Middle-earth.');
    addQuest(763, 464, 'Journey in the Dark', 'Journey-in-the-Dark', 'The-Road-Darkens/The-Long-Dark-of-Moria-1A.jpg',
        'Trapped inside the Mines of Moria, the Company of the Ring must find their way through many twisting passages to reach the eastern door. But with every step they take into the Mines, there is a growing sense of dread...');
    addQuest(884, 694, 'Breaking of the Fellowship', 'Breaking-of-the-Fellowship', 'The-Road-Darkens/The-Great-River-1A.jpg',
        'Having barely escaped from Moria, the Company of the Ring flees into the forest of Lórien where they are welcomed by the Elves of the Golden Wood and supplied with boats and other gifts by their Lord and Lady, Celeborn and Galadriel. Then, after a brief rest, they set out upon the River Anduin.');
    addQuest(805, 680, 'The Uruk-hai', 'The-Uruk-hai', 'The-Treason-of-Saruman/Follow-the-Orcs-1A.jpg',
        'The Orcs that attached the Fellowship at Amon Hen captured several members of the Company and are carrying them to Isengard. Aragorn and his companions decide to chase the Uruk-hai in an effort to rescue their friends...');
    addQuest(695, 695, 'Helm\'s Deep', 'Helms-Deep', 'The-Treason-of-Saruman/The-King-of-the-Golden-Hall-1A.jpg',
        'The pursuit of the Uruk-hai has brought the Heir of Elendil to Rohan just as Saruman declares war on that land. Aragorn and his companions travel to Edoras to aid King Théoden, but their arrival is met with suspicion...');
    addQuest(658, 617, 'The Road to Isengard', 'The-Road-to-Isengard', 'The-Treason-of-Saruman/Rouse-the-Ents-1A.jpg',
        'Saruman\'s army has been defeated at Helm\'s Deep, but the Wizard\'s fortress is beyond Rohan\'s power to capture. However, the Ents of Fangorn have also suffered great injury because of Saruman and his Orcs. They have the strength to break Isengard, but only if they can be roused to attack.');
    addQuest(970, 693, 'The Passage of the Marshes', 'The-Passage-of-the-Marshes', 'The-Land-of-Shadow/The-Taming-of-Sm%C3%A9agol-1A.jpg',
        'Frodo and Sam left the Fellowship above the falls of Rauros and crossed the great river to climb the Emyn Muil upon the Eastern shore. After days of wandering through that maze of rocky crags, they have finally reached the edge of the Dead Marshes only to discover that Gollum is following them.');
    addQuest(980, 736, 'Journey to the Cross-roads', 'Journey-to-the-Cross-roads', 'The-Land-of-Shadow/Ambush-the-Men-of-Harad-1A.jpg',
        '"These cursed Southrons come now marching up the ancient roads to swell the hosts of the Dark Tower. Yea, up the very roads that craft of Gondor made." —Mablung, The Two Towers');
    addQuest(1010, 774, 'Shelob\'s Lair', 'Shelobs-Lair', 'The-Land-of-Shadow/The-Stairs-of-Cirith-Ungol-1A.jpg',
        'Sméagol has led Frodo and Sam to the Morgul Vale, where he promises to show them a secret way over the Mountains of Shadow and into the land of Mordor, but Sam fears that Gollum may be leading them into a trap...');
    addQuest(722, 763, 'The Passing of the Grey Company', 'The-Passing-of-the-Grey-Company', 'The-Flame-of-the-West/The-Forbidden-Door-1A.jpg',
        '"I must take new counsel for myself and my kindred. We must ride our own road, and no longer in secret. For me the time of stealth has passed. I will ride by the swiftest way, and I will take the Paths of the Dead." -Aragorn, The Return of the King');
    addQuest(949, 900, 'The Siege of Gondor', 'The-Siege-of-Gondor', 'The-Flame-of-the-West/Attack-on-Pelargir-1A.jpg',
        '"There at Pelargir lay the main fleet of Umbar, fifty great ships and smaller vessels beyond count. Many of those that we pursued had reached the havens before us..."<br>-Gimli, The Return of the King');
    addQuest(958, 825, 'The Battle of the Pelennor Fields', 'The-Battle-of-the-Pelennor-Fields', 'The-Flame-of-the-West/The-Garrison-of-Gondor-1A.jpg',
        '"Here will the hammer-stroke fall hardest. And for that reason Mithrandir came hither in such haste. For if we fall, who shall stand?<br>-Beregond, The Return of the King');
    addQuest(1033, 774, 'The Tower of Cirith Ungol', 'The-Tower-of-Cirith-Ungol', 'The-Mountain-of-Fire/Pass-the-Two-Watchers-1A.jpg',
        'Frodo has been captured by the Orcs of Cirith Ungol and imprisoned at the top of their tower, but Sam is determined to rescue his master.');
    addQuest(1013, 701, 'The Black Gate Opens', 'The-Black-Gate-Opens', 'The-Mountain-of-Fire/Embassy-from-the-Dark-Tower-1A.jpg',
        'Aragorn has led the Men of the West to the very Gate of Mordor in a perilous gamble to keep the Eye of Sauron focused on him. After challenging the Dark Lord to come forth and face judgement, the Black Gate opens and an embassy from Barad-dûr rides out led by The Mouth of Sauron.');
    addQuest(1063, 762, 'Mount Doom', 'Mount-Doom', 'The-Mountain-of-Fire/The-Land-of-Mordor-1A.jpg',
        'Against all odds, the Ring-bearer has found his way into The Black Land of Modor, but a dangerous journey still lies before him and The Eye of Sauron yet searches for the spies who escaped from Cirith Ungol.');

    //GenCon and Fellowship
    addQuest(994, 235, 'The Battle of Lake-town', 'The-Battle-of-Lake-town', 'The-Battle-of-Lake-town/Terror-from-the-Mountain-1A.jpg',
        '"Then warning trumpets were suddenly sounded, and echoed along the rocky shores. The cheering stopped and the joy was quickly turned to dread. So it was that the dragon did not find them quite unprepared."<br>-The Hobbit');
    addQuest(745, 765, 'The Stone of Erech', 'The-Stone-of-Erech', 'The-Stone-of-Erech/The-Disappearance-1A.jpg',
        'The Lord of Lamedon has asked you to assist him in discovering the whereabouts of his lost son, Derufin. He hasn\'t been seen for days, and his father fears he may be in grave peril. Your search has led you to the Blackroot Vale, where the people live in dread of the Dead Men of Dunharrow.');
    addQuest(923, 475, 'Attack on Dol Guldur', 'Attack-on-Dol-Guldur', 'Attack-on-Dol-Guldur/Assault-on-the-Golden-Wood-1A.jpg',
        'The Dark Lord of Mordor has declared war across Middle-earth. His Nazgûl lead the Morgul host against Minas Tirith in the south, while Easterlings lay siege to Erebor in the north. And in a move long-prepared, the armies of Dol Guldur cross the Anduin to assault Lórien...');

    var mapElement = document.getElementById('quest-map');
    if (mapElement) {
        //Move handler
        mapElement.addEventListener('mousemove', function (e) {
            var x = getMapX(e);
            var y = getMapY(e);
            //console.log('mousemove x: ' + x + ' y: ' + y);
            var quest = getSelectedQuest(e);
            if (quest && quest.length == 1) {
                var imageUrl = 'https://s3.amazonaws.com/hallofbeorn-resources/Images/Cards/' + imageMap[quest];
                $('#map-tooltip').css({ top: (y + 250) + 'px', left: (x + 80) + 'px', position: 'absolute' });
                $('#tooltip-title').text(quest);
                $('#tooltip-text').html(textMap[quest]);
                $('#tooltip-link').attr({ href: questMap[quest] });
                $('#tooltip-image').show();
                $('#tooltip-image').attr({ src: imageUrl });
                $('#map-tooltip').show();
            } else {
                $('#map-tooltip').hide();
            }
        });

        //Click handler
        mapElement.addEventListener('click', function (e) {
            var x = getMapX(e);
            var y = getMapY(e);
            console.log('mousemove: ' + x + ', ' + y);
            var quest = getSelectedQuest(e);
            if (quest && quest.length == 1) {
                var link = '/LotR/Scenarios/' + questMap[quest];
                console.log('url: ' + link);
                window.open(link);
            }
        });
    }
}

function loadScenarioChart(id) {
    $.get("/Cards/ScenarioDetails/" + id).success(function (result) {

        var enemyData = [];
        var locationData = [];
        var treacheryData = [];
        var shadowData = [];

        if (result.HasEasy) {
            enemyData.push(result.EasyEnemies);
            locationData.push(result.EasyLocations);
            treacheryData.push(result.EasyTreacheries);
            shadowData.push(result.EasyShadows);
        }

        enemyData.push(result.NormalEnemies);
        locationData.push(result.NormalLocations);
        treacheryData.push(result.NormalTreacheries);
        shadowData.push(result.NormalShadows);

        if (result.HasNightmare) {
            enemyData.push(result.NightmareEnemies);
            locationData.push(result.NightmareLocations);
            treacheryData.push(result.NightmareTreacheries);
            shadowData.push(result.NightmareShadows);
        }

        var series = [
            {
                name: 'Enemies',
                data: enemyData
            },
            {
                name: 'Locations',
                data: locationData
            },
            {
                name: 'Treacheries',
                data: treacheryData
            },
            {
                name: 'Shadows',
                data: shadowData
            }
        ];

        if (result.EasyHasObjectives || result.NormalHasObjectives || result.NightmareHasObjectives) {
            var objectiveData = [];
            if (result.HasEasy) {
                objectiveData.push(result.EasyObjectives);
            }
            objectiveData.push(result.NormalObjectives);
            if (result.HasNightmare) {
                objectiveData.push(result.NightmareObjectives);
            }

            series.push({
                name: 'Objectives',
                data: objectiveData
            });
        }
        if (result.EasyHasObjectiveAllies || result.NormalHasObjectiveAllies || result.NightmareHasObjectiveAllies) {
            var objectiveAllyData = [];
            if (result.HasEasy) {
                objectiveAllyData.push(result.EasyObjectiveAllies);
            }
            objectiveAllyData.push(result.NormalObjectiveAllies);
            if (result.HasNightmare) {
                objectiveAllyData.push(result.NightmareObjectiveAllies);
            }

            series.push({
                name: 'Objective Allies',
                data: objectiveAllyData
            });
        }
        if (result.EasyHasObjectiveLocations || result.NormalHasObjectiveLocations || result.NightmareHasObjectiveLocations) {
            var objectiveLocationData = [];
            if (result.HasEasy) {
                objectiveLocationData.push(result.EasyObjectiveLocations);
            }
            objectiveLocationData.push(result.NormalObjectiveLocations);
            if (result.HasNightmare) {
                objectiveLocationData.push(result.NightmareObjectiveLocations);
            }

            series.push({
                name: 'Objective Locations',
                data: objectiveLocationData
            });
        }
        if (result.EasyHasSurge || result.NormalHasSurge || result.NightmareHasSurge) {
            var surgeData = [];
            if (result.HasEasy) {
                surgeData.push(result.EasySurges);
            }
            surgeData.push(result.NormalSurges);
            if (result.HasNightmare) {
                surgeData.push(result.NightmareSurges);
            }

            series.push({
                name: 'Surge',
                data: surgeData
            });
        }
        if (result.EasyHasEncounterSideQuests || result.NormalHasEncounterSideQuests || result.NightmareHasEncounterSideQuests) {
            var encounterSideQuestData = [];

            if (result.HasEasy) {
                encounterSideQuestData.push(result.EasyEncounterSideQuests);
            }
            encounterSideQuestData.push(result.NormalEncounterSideQuests);
            if (result.HasNightmare) {
                encounterSideQuestData.push(result.NightmareEncounterSideQuests);
            }

            series.push({
                name: 'Side Quests',
                data: encounterSideQuestData
            });
        }

        var categories = [];

        if (result.HasEasy) {
            categories.push("Easy");
        }

        categories.push("Normal");

        if (result.HasNightmare) {
            categories.push("Nightmare");
        }

        $('#chartContainer').highcharts({
            chart: {
                type: 'bar'
            },
            title: {
                text: 'Statistics for ' + result.title
            },
            xAxis: {
                categories: categories
            },
            yAxis: {
                min: 0,
                title: {
                    text: 'Encounter Card Breakdowns'
                }
            },
            credits: {
                enabled: false
            },
            legend: {
                reversed: false
            },
            plotOptions: {
                series: {
                    cursor: 'pointer',
                    point: {
                        events: {
                            click: function (e) {
                                var cardType = 'Encounter';
                                var query = '';
                                var hasShadow = 'Any';
                                switch (this.series.name) {
                                    case 'Enemies':
                                        cardType = 'Enemy';
                                        break;
                                    case 'Locations':
                                        cardType = 'Location';
                                        break;
                                    case 'Treacheries':
                                        cardType = 'Treachery';
                                        break;
                                    case 'Objectives':
                                        cardType = 'Objective';
                                        break;
                                    case 'Objective Allies':
                                        cardType = 'Objective_Ally';
                                        break;
                                    case 'Objective Locations':
                                        cardType = 'Objective_Location';
                                        break;
                                    case 'Surge':
                                        query = 'Surge';
                                        break;
                                    case 'Shadows':
                                        hasShadow = 'Yes';
                                        break;
                                    case 'Encounter Side Quests':
                                        cardType = 'Encounter_Side_Quest';
                                        break;
                                }

                                var quest = encodeURIComponent(result.title);

                                var url = 'http://' + window.location.host + "/Cards/Search?CardType=" + cardType + "&Quest=" + quest + "&HasShadow=" + hasShadow;
                                if (query != '') {
                                    url += '&Query=' + query;
                                }

                                window.open(url);
                                return false;
                            }
                        }
                    }
                }
            },
            series: series,
            tooltip: {
                pointFormat: '<span style="font-size:11px;">{series.name}: {point.y}</span>'
            }
        });
    });
}

function loadTotals(selector, title, data) {
    var scenarioTitles;
    var enemyData;
    var locationData;
    var treacheryData;
    var objectiveData;
    var objectiveAllyData;
    var objectiveLocationData;
    var shadowData;
    var surgeData;

    var modeData;
    switch (mode) {
        case 'Easy':
            modeData = data.EasyData;
            break;
        case 'Normal':
            modeData = data.NormalData;
            break;
        case 'Nightmare':
            modeData = data.NightmareData;
            break;
    }

    scenarioTitles = modeData.ScenarioTitles;
    enemyData = modeData.EnemyTotals;
    locationData = modeData.LocationTotals;
    treacheryData = modeData.TreacheryTotals;
    objectiveData = modeData.ObjectiveTotals;
    objectiveAllyData = modeData.ObjectiveAllyTotals;
    objectiveLocationData = modeData.ObjectiveLocationTotals;
    sideQuestData = modeData.SideQuestTotals;
    shadowData = modeData.ShadowTotals;
    surgeData = modeData.SurgeTotals;

    var seriesData = [{
        name: 'Enemies',
        data: enemyData
    }, {
        name: 'Locations',
        data: locationData
    }, {
        name: 'Treacheries',
        data: treacheryData
    }, {
        name: 'Shadows',
        data: shadowData
    }, {
        name: 'Surges',
        data: surgeData
    }];

    if (objectiveData[0] > 0 || objectiveData[1] > 0 || objectiveData[2] > 0) {
        seriesData.push({
            name: 'Objectives',
            data: objectiveData
        });
    }

    if (objectiveAllyData[0] > 0 || objectiveAllyData[1] > 0 || objectiveAllyData[2] > 0) {
        seriesData.push({
            name: 'Objective Allies',
            data: objectiveAllyData
        });
    }

    var hasObjectiveLocations = false;
    for (var i = 0; i < objectiveLocationData.length; i++) {
        if (objectiveLocationData[i] > 0) {
            hasObjectiveLocations = true;
            break;
        }
    }

    if (hasObjectiveLocations) {
        seriesData.push({
            name: 'Objective Locations',
            data: objectiveLocationData
        });
    }

    if (sideQuestData[0] > 0 || sideQuestData[1] > 0 || sideQuestData[2] > 0) {
        seriesData.push({
            name: 'Side Quests',
            data: sideQuestData
        });
    }

    $(selector).highcharts({
        chart: {
            type: 'area'
        },
        title: {
            text: title + ' (' + mode + ' Mode)',
            x: -20
        },
        subtitle: {
            text: 'Encounter Card Types By Scenario',
            x: -20
        },
        xAxis: {
            categories: scenarioTitles
        },
        yAxis: {
            title: {
                text: 'Percentage'
            },
            plotLines: [{
                value: 0,
                width: 1,
                color: '#808080'
            }]
        },
        credits: {
            enabled: false
        },
        tooltip: {
            pointFormat: '<span>{series.name}</span>: <b>{point.y}</b> ({point.percentage:.0f}%)<br/>'
        },
        legend: {
            layout: 'horizontal',
            align: 'center',
            verticalAlign: 'bottom',
            borderWidth: 0
        },
        plotOptions: {
            area: {
                stacking: 'percent',
                lineColor: '#ffffff',
                lineWidth: 1,
                marker: {
                    lineWidth: 1,
                    lineColor: '#ffffff'
                }
            }
        },
        series: seriesData
    });
}

function loadCharts() {
    $.get("/Cards/ScenarioTotals?id=Core+Set,Shadows+of+Mirkwood").success(function (data) {
        loadTotals('#coreTotalsContainer', 'Core Set and Shadows of Mirkwood', data);
    });
    $.get("/Cards/ScenarioTotals?id=Khazad-dûm,Dwarrowdelf").success(function (data) {
        loadTotals('#kdTotalsContainer', 'Khazad-dûm and Dwarrowdelf', data);
    });
    $.get("/Cards/ScenarioTotals?id=Heirs+of+Númenor,Against+the+Shadow").success(function (data) {
        loadTotals('#honTotalsContainer', 'Heirs of Númenor and Against the Shadow', data);
    });
    $.get("/Cards/ScenarioTotals?id=The+Voice+of+Isengard,The+Ring-maker").success(function (data) {
        loadTotals('#voiTotalsContainer', 'The Voice of Isengard and The Ring-maker', data);
    });
    $.get("/Cards/ScenarioTotals?id=The+Lost+Realm,Angmar+Awakened").success(function (data) {
        loadTotals('#tlrTotalsContainer', 'The Lost Realm and Angmar Awakened', data);
    });
    $.get("/Cards/ScenarioTotals?id=The+Grey+Havens,Dream-chaser").success(function (data) {
        loadTotals('#tghTotalsContainer', 'The Grey Havens and Dream-chaser', data);
    });
    $.get("/Cards/ScenarioTotals?id=The+Hobbit").success(function (data) {
        loadTotals('#hobbitTotalsContainer', 'The Hobbit', data);
    });
    $.get("/Cards/ScenarioTotals?id=The+Lord+of+the+Rings").success(function (data) {
        loadTotals('#lotrTotalsContainer', 'The Lord of the Rings', data);
    });
    $.get("/Cards/ScenarioTotals?id=GenCon").success(function (data) {
        loadTotals('#genConTotalsContainer', 'GenCon', data);
    });
}