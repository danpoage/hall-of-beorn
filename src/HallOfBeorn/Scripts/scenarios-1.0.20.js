var mode = 'Normal';

$(function () {

    initQuestMap();

    var scenarioChartInitialized = false;
    var chartsInitialized = false;

    if (!chartsInitialized) {
        loadCharts();
        chartsInitialized = true;
    }

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
    /*$('#toggleCharts').click(function () {
        if (!chartsInitialized) {
            loadCharts();
            chartsInitialized = true;
        }
        $('#chartsContainer').toggle();
        var text = $('#toggleCharts').html();
        var newText = text == 'Show Charts' ? 'Hide Charts' : 'Show Charts';
        $('#toggleCharts').html(newText);
    });*/
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

    var targetX = [];
    var targetY = [];
    var questMap = [];
    var imageMap = [];
    var textMap = [];
    var xMap = []; var yMap = [];
    var radius = 8;
    var questToCycleMap = [];
    var cycleToLinesMap = [];

    function addRange(map, number, code, label) {
        for (var i = number - radius; i <= number + radius; i++) {
            if (map[i] === undefined) {
                console.log(label + ' map not defined for value: ' + i);
                map[i] = [code];
            } else {
                //console.log(label + ' map already defined for value: ' + i);
                map[i].push(code);
            }
        }
    };

    function addCycle(cycle, quest, x, y) {
        questToCycleMap[quest] = cycle;

        if (cycleToLinesMap[cycle] === undefined) {
            cycleToLinesMap[cycle] = [{x: x, y: y}];
        } else {
            cycleToLinesMap[cycle].push({x: x, y: y});
        }
    };

    function addQuest(x, y, name, cycle, questUrl, imageUrl, text) {
        targetX[name] = x;
        targetY[name] = y;
        questMap[name] = questUrl;
        imageMap[name] = imageUrl;
        textMap[name] = text;

        addRange(xMap, x, name, 'X');
        addRange(yMap, y, name, 'Y');

        if (cycle) {
            addCycle(cycle, name, x, y);
        }
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

    function getCyclePoints(e) {
        var quest = getSelectedQuest(e);
        if (quest && questToCycleMap[quest] !== undefined) {
            var cycle = questToCycleMap[quest];
            return cycleToLinesMap[cycle]
        }
        return [];
    }

    function drawLines(e, quest) {
        //console.log('drawLines');

        var points = getCyclePoints(e);
        if (!points || points.length < 2) {
            return;
        }

        var c = document.getElementById("quest-map");
        var ctx = c.getContext("2d");
        var width = 2;
        var color = '#e3eaa7';

        for (var i = 1; i < points.length; i++) {
            drawArrow(c, ctx, width, color, points[i - 1].x, points[i - 1].y, points[i].x, points[i].y);
        }
    }

    function drawArrow(c, ctx, width, color, fromx, fromy, tox, toy) {
        var headlen = 10 / width;

        var angle = Math.atan2(toy - fromy, tox - fromx);

        //starting path of the arrow from the start square to the end square and drawing the stroke
        ctx.beginPath();
        ctx.moveTo(fromx, fromy);
        ctx.lineTo(tox, toy);
        ctx.strokeStyle = color; //"#cc0000";
        ctx.lineWidth = width;
        ctx.stroke();

        //starting a new path from the head of the arrow to one of the sides of the point
        ctx.beginPath();
        ctx.moveTo(tox, toy);
        ctx.lineTo(tox - headlen * Math.cos(angle - Math.PI / 7), toy - headlen * Math.sin(angle - Math.PI / 7));

        //path from the side point of the arrow, to the other side point
        ctx.lineTo(tox - headlen * Math.cos(angle + Math.PI / 7), toy - headlen * Math.sin(angle + Math.PI / 7));

        //path from the side point back to the tip of the arrow, and then again to the opposite side point
        ctx.lineTo(tox, toy);
        ctx.lineTo(tox - headlen * Math.cos(angle - Math.PI / 7), toy - headlen * Math.sin(angle - Math.PI / 7));

        //draws the paths created above
        ctx.strokeStyle = color; //"#cc0000";
        ctx.lineWidth = width;
        ctx.stroke();
        ctx.fillStyle = color; //"#cc0000";
        ctx.fill();
    }

    function hideLines(e) {
        //console.log('hideLines');
        var canvas = document.getElementById("quest-map");
        var context = canvas.getContext("2d");
        context.clearRect(0, 0, canvas.clientWidth, canvas.clientHeight);
    }

    //Core Set and Shadows of Mirkwood
    addQuest(927, 287, 'Passage Through Mirkwood', 'Core', 'Passage-Through-Mirkwood', 'Core-Set/Flies-and-Spiders-1A.jpg',
        'You are traveling through Mirkwood forest, carrying an urgent message from King Thanduil to the Lady Galadriel of Lorien. As you move along the dark trail, the spiders gather around you...');
    addQuest(846, 343, 'Journey Along the Anduin', 'Core', 'Journey-Along-the-Anduin', 'Core-Set/To-the-River-1A.jpg',
        'Emerging from Mirkwood Forest with an urgent message from Lady Galadriel, you must make your way south along the Anduin River in order to reach the forst of Lórien. As you leave the forest behind, you notice that you are being pursued, and thus quicken your pace...');
    addQuest(898, 476, 'Escape from Dol Guldur', 'Core', 'Escape-from-Dol-Guldur', 'Core-Set/The-Necromancer\'s-Tower-1A.jpg',
        'The Lady Galadriel of Lórien has asked you to investigate the area in the vicinity of Dol Guldar. While doing so, one of your allies was ambushed by Orcs, captured, and is now held in a dungeon cell...');
    addQuest(818, 320, 'The Hunt for Gollum', 'Core', 'The-Hunt-for-Gollum', 'The-Hunt-for-Gollum/The-Hunt-Begins-1A.jpg',
        'Gandalf has requested your assistance in the search for the elusive creature known as Gollum. Your search begins in the Anduin Valley between Mirkwood Forest and the Misty Mountains');
    addQuest(818, 275, 'Conflict at the Carrock', 'Core', 'Conflict-at-the-Carrock', 'Conflict-at-the-Carrock/Grimbeorn\'s-Quest-1A.jpg',
        'GRRRRRR GRRRRRRR GRRRRRRR... I smell Trolls...');
    addQuest(895, 403, 'A Journey to Rhosbogel', 'Core', 'A-Journey-to-Rhosgobel', 'A-Journey-To-Rhosgobel/The-Wounded-Eagle-1A.jpg',
        'After a fierce conflict with a group of Trolls, you come across a fallen Eagle, grievously wounded and on the verge of death.');
    addQuest(917, 658, 'The Hills of Emyn Muil', 'Core', 'The-Hills-of-Emyn-Muil', 'The-Hills-of-Emyn-Muil/The-Hills-of-Emyn-Muil-1A.jpg',
        'The hunt for Gollum has led you to the south, and you are now approaching Rauros falls and the nearby hills of Emyn Muil...');
    addQuest(946, 694, 'The Dead Marshes', 'Core', 'The-Dead-Marshes', 'The-Dead-Marshes/Into-the-Marshes-1A.jpg',
        'You have followed Gollum\'s trail for days, and are now closing in fast pursuit. In a last ditch effort to escape you, the creature has fled to The Dead Marshes.');
    addQuest(950, 287, 'Return to Mirkwood', 'Core', 'Return-to-Mirkwood', 'Return-to-Mirkwood/Through-the-Forest-1A.jpg',
        'Having captured Gollum, you must now escort him through Mirkwood Forest for interrogation at Thranduil\'s Palace.');

    //Khazad-dum and Dwarrowdelf
    addQuest(696, 441, 'Into the Pit', 'KD', 'Into-the-Pit', 'Khazad-dum/Entering-the-Mines-1A.jpg',
        'You have been sent by the White Council to Moria, to deliver a message to Balin and his Dwarven colony. No one has heard from him in a while.');
    addQuest(718, 441, 'The Seventh Level', 'KD', 'The-Seventh-Level', 'Khazad-dum/Search-for-the-Chamber-1A.jpg',
        'You are investigating the Seventh Level of Moria, searching for the Chamber of Records and any signs of Balin\'s Colony. In the heavy twilight of a hall, a bulky tome is discovered in the grip of a Dwarf skeleton. You carefully take possession of the book. Perhaps it will give you some answers...');
    addQuest(742, 441, 'Flight from Moria', 'KD', 'Flight-from-Moria', 'Khazad-dum/A-Presence-in-the-Dark-1A.jpg',
        'You have discovered the fate of the Dwarven colony, and seek to leave Moria. But exiting may not be as simple as entering...');
    addQuest(733, 404, 'The Redhorn Gate', 'KD', 'The-Redhorn-Gate', 'The-Redhorn-Gate/Up-the-Pass-1A.jpg',
        'Celeborn has bid you to visit her father in Rivendell. Your journey takes you though the Redhorn Gate...');
    addQuest(727, 351, 'Road to Rivendell', 'KD', 'Road-to-Rivendell', 'Road-to-Rivendell/Along-the-Misty-Mountains-1A.jpg',
        'Your party has braved the snows of the pass, but now must travel North along the Misty Mountains for league upon league as you escort Arwen to her father\'s house.');
    addQuest(764, 441, 'The Watcher in the Water', 'KD', 'The-Watcher-in-the-Water', 'The-Watcher-in-the-Water/To-the-West-door-1A.jpg',
        'Elrond has asked you to scout the Mines of Moria on your return to Lorien, hoping to discover if it is the source of increased Orc activity along the Misty Mountains.');
    addQuest(697, 464, 'The Long Dark', 'KD', 'The-Long-Dark', 'The-Long-Dark/Journey-in-the-Black-Pit-1A.jpg',
        'Your party is scouting the Mines of Moria, searching for signs of Orcs. Dark tunnels and twisting passages spread out in all directions, a labyrinthine maze that you could wander in forever if you take the wrong path.');
    addQuest(718, 464, 'Foundations of Stone', 'KD', 'Foundations-of-Stone', 'Foundations-of-Stone/The-Dripping-Walls-1A.jpg',
        'Your journey has led to a decrepit portion of the mines, untouched by Dwarven pick for many a year. The air grows thick with moisture, and the walls almost appear to be weeping.')
    addQuest(741, 464, 'Shadow and Flame', 'KD', 'Shadow-and-Flame', 'Shadow-and-Flame/Nearing-the-Gate-1A.jpg',
        'As you reach the eastern realm of Darrowdelf the craftsmanship of the Dwarves is proudly displayed. But the sound of drums sound in the deep, and it appears that these halls are infested with Orcs.');

    //Heirs of Numenor and Against the Shadow
    addQuest(926, 900, 'Peril in Pelargir', 'HoN', 'Peril-in-Pelargir', 'Heirs-of-Numenor/The-Leaping-Fish-Quest-1A.jpg',
        'The White Council has sent you by ship to Gondor to help fight the threat of Mordor. Upon arrival in the port city of Pelargir, you are greeted by Lord Alcaron who takes you to The Leaping Fish where you can speak privately.');
    addQuest(972, 863, 'Into Ithilien', 'HoN', 'Into-Ithilien', 'Heirs-of-Numenor/Ambush-in-Ithilien-1A.jpg',
        'You\'ve arrived in Ithilien with a sealed message for Faramir, only to learn that he has gone north to defend Cair Andros from massing enemy forces.');
    addQuest(964, 765, 'The Siege of Cair Andros', 'HoN', 'The-Siege-of-Cair-Andros', 'Heirs-of-Numenor/The-Defense-1A.jpg',
        'The island fortress of Cair Andros, which guards Gondor\'s northernmost causeways over the river Anduin, is under siege! Battering rams rumble up the eastern causeway and rafts filled with Orcs float across the river toward the lightly defended northern banks.');
    addQuest(958, 801, 'The Steward\'s Fear', 'HoN', 'The-Stewards-Fear', 'The-Steward\'s-Fear/Conspiracy-1A.jpg',
        'Even as foes mass from without, the Steward of Minas Tirith fears there are enemies within. You have been asked to investigate the possibility of a conspiracy within the White City...');
    addQuest(910, 779, 'The Drúadan Forest', 'HoN', 'The-Druadan-Forest', 'The-Druadan-Forest/The-Pursuit-1A.jpg',
        'The leader of the underworld cabal from Minas Tirith has fled with his remaining henchmen. You have followed his trail to The Drúadan Forest, hoping to bring the nameless villain to justice.');
    addQuest(933, 784, 'Encounter at Amon-din', 'HoN', 'Encounter-at-Amon-din', 'Encounter-at-Amon-Din/Savagery-of-the-Orcs-1A.jpg',
        'Emerging from the Druadan Forest with news of the conspirators\' demise, you begin your journey to Minas Tirith. As you wake the following day, you see dark plumes of smoke rising across the lands of Anórien.');
    addQuest(1002, 844, 'Assault on Osgiliath', 'HoN', 'Assault-on-Osgiliath', 'Assault-on-Osgiliath/Retake-the-City-1A.jpg',
        'You have returned to Minas Tirith just in time to join the army of Gondor as it marches to Osgiliath. An army of orcs and southrons have garrisoned the ancient city, but Lord Boromir means to retake it. Eager to strike a blow against Mordor, you will see the city retaken or die in the attempt...');
    addQuest(1002, 737, 'The Blood of Gondor', 'HoN', 'The-Blood-of-Gondor', 'The-Blood-of-Gondor/The-Ambush-1A.jpg',
        'After the assault on Osgiliath, Lord Alcaron urges Boromi to pursue the retreating enemy. Boromir agrees and gives permission to Faramir and his rangers. Grateful for you valiant efforts in Gondor\'s defense, Faramir invites you to join the hunt...');
    addQuest(1004, 796, 'The Morgul Vale', 'HoN', 'The-Morgul-Vale', 'The-Morgul-Vale/The-Rearguard-1A.jpg',
        'Lord Alcaron and Faramir have been captured by forces from Minas Morgul. You pursue their captors eastward into the dreaded vale.');

    //The Voice of Isengard and Ring-maker
    addQuest(662, 655, 'The Fords of Isen', 'VoI', 'The-Fords-of-Isen', 'The-Voice-of-Isengard/Fight-at-the-Fords-1A.jpg',
        'Riding north to the Gap of Rohan, you come upon a battle at the Fords of Isen. A Small number of Rohirrim have taken a defensive position, on the islet in the river\'s center where a large force of wild Dunlending assails them. You must move swifty lest the river run red with blood of Rohan...');
    addQuest(678, 603, 'To Catch an Orc', 'VoI', 'To-Catch-an-Orc', 'The-Voice-of-Isengard/Orders-from-Orthanc-1A.jpg',
        'Saruman has tasked you with a dangerous mission: journey up the Misty Mountains\' southern peack in search of the Orc, Mugash, and capture him alive.');
    addQuest(721, 593, 'Into Fangorn', 'VoI', 'Into-Fangorn', 'The-Voice-of-Isengard/Into-the-Woods-1A.jpg',
        'You\'ve captured the Orc captain, Mugash, in the mountains above Isengard. But as you make your way down Methedras, your captive escaped and flees east into Fangorn.');
    addQuest(584, 561, 'The Dunland Trap', 'VoI', 'The-Dunland-Trap', 'The-Dunland-Trap/The-Road-to-Tharbad-1A.jpg',
        'You are following the Old South Road from Isengard to Tharbad on an errand for Saruman when you are attacked by Wild Men of Dunland.');
    addQuest(593, 538, 'The Three Trials', 'VoI', 'The-Three-Trials', 'The-Three-Trials/The-Trials-Begin-1A.jpg',
        'At the edge of a cursed forest, the Boar Shaman explains that you must undertake three trials in order to recover the Antlered Crown, or face death. Each trial will test your worthiness. Guardian spirits watch over three sacred swords, protecting them from the undeserving.');
    addQuest(547, 462, 'Trouble in Tharbad', 'VoI', 'Trouble-in-Tharbad', 'Trouble-in-Tharbad/Double-Dealings-1A.jpg',
        'Your meeting with Nalir is interrupted by a host of Orcs led by a man, Bellach. In the ensuing chaos, you manage to escape with the Dwarf but the Orcs pursue. Outnumbered, you must throw the Orcs off your trail if you hope to escape...');
    addQuest(584, 453, 'The Nîn-in-Eilph', 'VoI', 'The-Nin-in-Eilph', 'The-Nin-in-Eilph/Fleeing-from-Tharbad-1A.jpg',
        'You\'ve entered the vast marshlands of the Nin–in–Eilph with Nalir in order to escape Bellach and his Orcs. Now, you must cross the swamp in order to reach Hollin on the other side.');
    addQuest(631, 465, 'Celebrimbor\'s Secret', 'VoI', 'Celebrimbors-Secret', 'Celebrimbor\'s-Secret/The-Ruins-of-Ost-in-Edhil-1A.jpg',
        'You have finally reached the ruins of Ost–in–Edhil, but Bellach and his Orcs have arrived before you. They appear to be searching for the hidden chamber. If you want to reach it first, you will have to move quickly and carefully...');
    addQuest(639, 507, 'The Antlered Crown', 'VoI', 'The-Antlered-Crown', 'The-Antlered-Crown/Battle-for-Dunland-1A.jpg',
        'On your return journey to Isengard, you find war in Dunland. The Raven Clan has refused the Boar\'s claim to The Antlered Crown, and chief Turch asks you to join his Clan as they march to battle. Seeing an opportunity to earn Saruman the friendship of a unified Dunland, you agree to join forces and fight...');

    //The Lost Realm and Angmar Awakened
    addQuest(501, 304, 'Intruders in Chetwood', 'LR', 'Intruders-in-Chetwood', 'The-Lost-Realm/Stop-the-War-Party-1A.jpg',
        'Rangers have sighted a large group of Orcs making its way towards Bree–land. The Dúnedain, Iârion, has asked you to help him intercept the war party before it can reach the quiet village. The Orcs are a day ahead of you and moving fast, but there is hope you can catch them with the Ranger\'s tracking skill...');
    addQuest(547, 280, 'The Weather Hills', 'LR', 'The-Weather-Hills', 'The-Lost-Realm/Scattered-Among-the-Hills-1A.jpg',
        'You\'ve pursued the remnants of an Orc war party east from the borders of Bree–land and into the wilderness beyond. Their trail climbs out of the lowlands and into the Weather Hills.');
    addQuest(467, 246, 'Deadmen\'s Dike', 'LR', 'Deadmens-Dike', 'The-Lost-Realm/The-Shades-of-Angmar-1A.jpg',
        'You\'ve brought the prisoners you rescued from the Weather Hills to Fornost. The Rangers gathered there are shocked to hear what you discovered at Amon Forn. Before their Chieftain can decide what to do, an unnatural fog covers the ruins in darkness, and the spectres of dead warriors emerge from the mists to attack you!');
    addQuest(537, 209, 'The Wastes of Eriador', 'LR', 'The-Wastes-of-Eriador', 'The-Wastes-of-Eriador/Across-the-Wastes-1A.jpg',
        'Following the surprise attack on Fornost, you have agreed to help the Ranger, Amarthiúl, track the villains who captured his friend, Iârion.');
    addQuest(648, 185, 'Escape from Mount Gram', 'LR', 'Escape-from-Mount-Gram', 'Escape-from-Mount-Gram/Unexpected-Rescue-1A.jpg',
        'You have been captured and imprisoned by the goblins of Mount Gram.');
    addQuest(692, 211, 'Across the Ettenmoors', 'LR', 'Across-the-Ettenmoors', 'Across-the-Ettenmoors/Into-the-Ettenmoors-1A.jpg',
        'You have escaped from the prisons of Mount Gram, but you are not safe yet.');
    addQuest(721, 274, 'The Treachery of Rhudaur', 'LR', 'The-Treachery-of-Rhudaur', 'The-Treachery-of-Rhudaur/Secrets-of-Rhudaur-1A.jpg',
        'You have decided to explore the ruins of this ancient keep, but Thaurdir pursues you, and time is of the essence.');
    addQuest(550, 97, 'The Battle of Carn Dûm', 'LR', 'The-Battle-of-Carn-Dum', 'The-Battle-of-Carn-Dum/The-Clutches-of-Carn-D%C3%BBm-1A.jpg',
        'Your company has made its way swiftly north, and finally the fortress of Carn Dûm looms before you. Unsure if you have arrived in time, you can only hope beyond hope that Iârion is still alive.');
    addQuest(574, 97, 'The Dread Realm', 'LR', 'The-Dread-Realm', 'The-Dread-Realm/The-Catacombs-of-Carn-D%C3%BBm-1A.jpg',
        'As you descend into the catacombs beneath Carn Dûm, you find yourself overcome with terror. Still, you press onward, knowing that Iârion\'s fate–and perhaps the fate of the north–lies in your hand.');

    //The Grey Havens and Dreamchaser
    addQuest(90, 574, 'Voyage Across Belegaer', 'GH', 'Voyage-Across-Belegaer', 'The-Grey-Havens/Departure-from-the-Havens-1A.jpg',
        'The Dream-chaser and her fleet depart from the Grey Havens, in search of the island from Calphon\'s dreams. Only a week out from the coast, the black sails of Corsair can be seen in pursuit!');
    addQuest(56, 945, 'The Fate of Númenor', 'GH', 'The-Fate-of-Numenor', 'The-Grey-Havens/Explore-the-Island-1A.jpg',
        'You arrive on the island\'s western beach, the edge of a dense jungle looming beyond. With no map to guide you and no idea of what to expect, you venture forward, deeper into the island...');
    addQuest(258, 313, 'Raid on the Grey Havens', 'GH', 'Raid-on-the-Grey-Havens', 'The-Grey-Havens/The-Corsairs\'-Assault-1A.jpg',
        'Corsairs are attacking the Grey Havens and burning the Elven fleet. You must defend the Havens from these fierce raiders and save as many ships as you can!');
    addQuest(313, 867, 'Flight of the Stormcaller', 'GH', 'Flight-of-the-Stormcaller', 'Flight-of-the-Stormcaller/Swift-Departure-1A.jpg',
        'Corsairs led by the treacherous Captain Sahír have stolen the black key you recovered in the ruins of Númenor. You must get it back!');
    addQuest(339, 867, 'The Thing in the Depths', 'GH', 'The-Thing-in-the-Depths', 'The-Thing-in-the-Depths/Take-the-Ship-1A.jpg',
        'Swinging across on ropes, your company boards the Stormcaller, and a fierce battle ensues!');
    addQuest(80, 947, 'Temple of the Deceived', 'GH', 'Temple-of-the-Deceived', 'Temple-of-the-Deceived/Searching-the-Island-1A.jpg',
        'Sahír has led you to an uncharted isle, and has agreed to help you find a chest he claims the black key will open. First, you must find the Gate Key that opens the way to the grand temple on the eastern side of the island.');
    addQuest(66, 966, 'The Drowned Ruins', 'GH', 'The-Drowned-Ruins', 'The-Drowned-Ruins/The-Grotto-1A.jpg',
        'In the sunken ruins of the temple, you find a grotto leading deep below the sea level. Much of the grotto is submerged underwater.');
    addQuest(716, 899, 'A Storm on Cobas Haven', 'GH', 'A-Storm-on-Cobas-Haven', 'A-Storm-on-Cobas-Haven/Outmaneuver-the-Enemy-1A.jpg',
        'Corsairs are attacking Dol Amroth to cover Sahír\'s escape to Umbar!');
    addQuest(761, 1083, 'The City of Corsairs', 'GH', 'The-City-of-Corsairs', 'The-City-of-Corsairs/The-Coast-of-Umbar-1A.jpg',
        'Deep in enemy waters, you must recover the artifact from the Stormcaller.');

    //The Sands of Harad and Haradrim
    addQuest(762, 1108, 'Escape from Umbar', 'SoH', 'Escape-from-Umbar', 'The-Sands-of-Harad/Stranded-in-Umbar-1A.jpg',
        'At the end of a long sea-voyage, you have reached the port of Umbar but your ship was dashed upon the rocks. Though you completed the quest that brought you to Harad, it has left you stranded in enemy territory, far from help.');
    addQuest(912, 1087, 'Desert Crossing', 'SoH', 'Desert-Crossing', 'The-Sands-of-Harad/The-Desert-of-Harad-1A.jpg',
        'You have escaped from Umbar and thrown off your pursuers by fleeing into the desert, but many barren miles lie between you and the other side. To turn back is to walk into the arms of the Haradrim, so you set out on a dangerous desert crossing.');
    addQuest(911, 1111, 'The Long Arm of Mordor', 'SoH', 'The-Long-Arm-of-Mordor', 'The-Sands-of-Harad/Surprise-Attack-1A.jpg',
        'A tribe of Haradrim has rescued you, but their village is attacked by Orcs!');
    addQuest(932, 1100, 'The Mûmakil', 'SoH', 'The-Mumakil', 'The-Mumakil/Welcome-to-the-Jungle-1A.jpg',
        'After seeing his village destroyed by Sauron’s Orcs, Kahliel has decided to travel north with you to Gondor. But it is a long road, and you will need mounts to ride. So your Haradrim allies have led you into the great jungle of Harad in search of the might Mumakil.');
    addQuest(1036, 1084, 'Race Across Harad', 'SoH', 'Race-Across-Harad', 'Race-Across-Harad/Setting-Out-1A.jpg',
        'Emerging from your hunt in the great jungle of the south, you set out across the vast desert of Harad on your long journey north to Gondor.');
    addQuest(951, 1043, 'Beneath the Sands', 'SoH', 'Beneath-the-Sands', 'Beneath-the-Sands/Searching-the-Caves-1A.jpg',
        'Several members of your group were seized by spiders in the night and dragged away from camp. When the sun came up, you followed their trail to a large cavern entrance and entered in.');
    addQuest(959, 995, 'The Black Serpent', 'SoH', 'The-Black-Serpent', 'The-Black-Serpent/The-Crossroads-Fort-1A.jpg',
        'The Black Serpent’s caravan has taken shelter in a dilapidated desert fortress on their way to Mordor. Their wagons are loaded with tribute for the Dark Lord. Your plan is to seize the wagons and use the caravan to infiltrate Cirith Gurat.');
    addQuest(1024, 976, 'The Dungeons of Cirith Gurat', 'SoH', 'The-Dungeons-of-Cirith-Gurat', 'The-Dungeons-of-Cirith-Gurat/Rescue-the-Prisoners-1A.jpg',
        'Posing as The Black Serpent’s men, you have infiltrated the Orc stronghold of Cirith Gurat in order to rescue the prisoners there.');
    addQuest(976, 919, 'The Crossings of Poros', 'SoH', 'The-Crossings-of-Poros', 'The-Crossings-of-Poros/Flight-to-Gondor-1A.jpg',
        'You have escaped the dungeons of Cirith Gurat with the rescued members of Kahliel\'s tribe, but it\'s still a long way to Gondor.');

    //Wilds of Rhoavanion and Ered Mithrin
    addQuest(842, 404, 'Journey Up the Anduin', 'WoR', 'Journey-Up-the-Anduin', 'The-Wilds-of-Rhovanion/Traveling-North-1A.jpg',
        'While traveling north through the Vales of Anduin on your way to Dale, you are alarmed by the number of dangerous creatures that you encounter.');
    addQuest(979, 284, 'Lost in Mirkwood', 'WoR', 'Lost-in-Mirkwood', 'The-Wilds-of-Rhovanion/Ambushed-at-Night-1A.jpg',
        'After several days of traveling through Mirkwood, you awaken suddenly in the night to see dozens of hungry eyes glaring at you from the darkness.');
    addQuest(1157, 200, 'The King\'s Quest', 'WoR', 'The-Kings-Quest', 'The-Wilds-of-Rhovanion/The-Iron-Hills-1A.jpg',
        'You have tracked the beast that attacked the village on the border of Brand’s realm to the mines beneath the Iron Hills. The Dwarves there have been driven from the lower depths by a new terror, and the mines have become a haunt for evil creatures.');
    addQuest(1024, 160, 'The Withered Heath', 'WoR', 'The-Withered-Heath', 'The-Withered-Heath/Searching-for-Dragon-Sign-1A.jpg',
        'You have journeyed to the Withered Heath in search of a giant Dragon. There you discover tracks that lead you to the cold heights of the Grey Mountains.');
    addQuest(914, 184, 'Roam Across Rhovanion', 'WoR', 'Roam Across Rhovanion', 'Roam-Across-Rhovanion/The-Goblin\'s-Task-1A.jpg',
        'The Goblin, Urdug, has agreed to show you a secret entrance to Mount Gundabad, but only if you help him recover some things he lost in Rhovanion.');
    addQuest(844, 187, 'Fire in the Night', 'WoR', 'Fire-in-the-Night', 'Fire-in-the-Night/Hrogar\'s-Hill-1A.jpg',
        'The Woodmen of Hrogar’s Hill have agreed to help you in your quest, but shortly after they welcome you to their town it is attacked by the very Dragon you seek: Dagnir has come to take vengeance on Wilderland!');
    addQuest(794, 176, 'The Ghost of Framsburg', 'WoR', 'The-Ghost-of-Framsburg', 'The-Ghost-of-Framsburg/The-Haunted-Keep-1A.jpg',
        'The search for the legendary sword of Fram has led you to the long-forgotten city of Framsburg. There is an evil air inside the keep, and you wonder what dangers wait for you in the darkness within.');
    addQuest(759, 156, 'Mount Gundabad', 'WoR', 'Mount-Gundabad', 'Mount-Gundabad/The-Side-Door-1A.jpg',
        'Mount Gundabad rises before you, and the Dragon, Dagnir, waits within.');
    addQuest(734, 156, 'The Fate of Wilderland', 'WoR', 'The-Fate-of-Wilderland', 'The-Fate-of-Wilderland/Urdug\'s-Assault-1A.jpg',
        'Dagnir is dead. In a move long-planned, Urdug has returned with an army of Goblins to lay claim to Gundabad and the Dragon\'s Wealth.');

    //A Shadow in the East and Vengeance of Mordor
    addQuest(1089, 363, 'The River Running', 'VoM', 'The-River-Running', 'A-Shadow-in-the-East/Chased-by-Easterlings-1A.jpg',
        'You are traveling south along the River Running on your way to Dorwinion when you are attacked by Easterling raiders in the night. The raiders set fire to your boat, trapping you on the east side of the river, and you are forced to flee south on foot.');
    addQuest(1271, 426, 'Danger in Dorwinion', 'VoM', 'Danger-in-Dorwinion', 'A-Shadow-in-the-East/A-City-in-Turmoil-1A.jpg',
        'A shadow hangs over the capital of Dorwinion. Fear grips the heart of the city on the Sea of Rhûn. People have been disappearing, and it is rumored that a cult of Sauron worshippers are responsible.');
    addQuest(1257, 504, 'Temple of Doom', 'VoM', 'Temple-of-Doom', 'A-Shadow-in-the-East/The-Forgotten-Temple-1A.jpg',
        'Your search for the missing Dorwinions has led you up the mountains of Rhûn. There you discover the remains of an ancient temple built to honor Sauron during the dark years of Middle-earth.');
    addQuest(1288, 448, 'Wrath and Ruin', 'VoM', 'Wrath-and-Ruin', 'Wrath-and-Ruin/Inside-the-Walls-1A.jpg',
        'Thane Ulchor has returned to Dorwinion at night with an army of Easterlings. His agents within the city slew the guards and opened the gate to let them in. You wake to find battle already raging in the streets.');
    addQuest(1343, 538, 'The City of Ulfast', 'VoM', 'The-City-of-Ulfast', 'The-City-of-Ulfast/Searching-for-Ulchor-1A.jpg',
        'After his defeat in Dorwinion. Ulchor fled east with the remnants of his army. You have pursued him to the City of Ulfast on the southern shore of the Sea of Rhûn. Determined to bring the villain to justice, you sneak into the city at night and begin searching for him.');
    addQuest(1360, 628, 'Challenge of the Wainriders', 'VoM', 'Challenge-of-the-Wainriders', 'Challenge-of-the-Wainriders/Wainrider-Camp-1A.jpg',
        'The Wainriders have challenged you to a chariot race. Win, and you earn your freedom. Lose, and the Wainriders will sell you as prisoners to Mordor.');
    addQuest(1288, 728, 'Under the Ash Mountains', 'VoM', 'Under-the-Ash-Mountains', 'Under-the-Ash-Mountains/Passage-into-Mordor-1A.jpg',
        'The tunnels of Torech Gorgor run beneath the Ash Mountains into Mordor.');
    addQuest(1234, 792, 'The Land of Sorrow', 'VoM', 'The-Land-of-Sorrow', 'The-Land-of-Sorrow/Slaves-of-the-Dark-Lord-1A.jpg',
        'You\'ve decided to risk everything to rescue Ulchor\'s captives from slavery.');
    addQuest(1117, 887, 'The Fortress of Nurn', 'VoM', 'The-Fortress-of-Nurn', 'The-Fortress-of-Nurn/Assault-on-Dol-Rhugar-1A.jpg',
        'Your quest to defeat Thane Ulchor has brought you to his stronghold in Mordor.');

    //The Hobbit Saga
    addQuest(683, 289, 'We Must Away Ere Break of Day', 'H', 'We-Must-Away-Ere-Break-of-Day', 'The-Hobbit-Over-Hill-and-Under-Hill/An-Unexpected-Party-1A.jpg',
        'The wizard Gandalf has chosen Bilbo Baggins to join Thorin and company on their quest to the Lonley Mountain.');
    addQuest(757, 286, 'Over the Misty Mountains Grim', 'H', 'Over-the-Misty-Mountains-Grim', 'The-Hobbit-Over-Hill-and-Under-Hill/A-Short-Rest-1A.jpg',
        'After a refreshing stay in the House of Elrond, Bilbo and his companions resumed their quest for the Lonely Mountain. But to reach Erebor, they first had to climb the high pass over the Misty Mountains.');
    addQuest(780, 285, 'Dungeons Deep and Caverns Dim', 'H', 'Dungeons-Deep-and-Caverns-Dim', 'The-Hobbit-Over-Hill-and-Under-Hill/Out-of-the-Frying-Pan-1A.jpg',
        'After killing the Great Goblin, Bilbo\'s companions fought to win their escape from the goblins. By the time they realized that Bilbo had been lost in the darkness, it was too late to turn back and search for him.');
    addQuest(940, 305, 'Flies and Spiders', 'H', 'Flies-and-Spiders', 'The-Hobbit-On-the-Doorstep/Into-Mirkwood-1A.jpg',
        '"Stick to the forest-track, keep your spirits up, hope for the best, and with a tremendous slice of luck you may come out one day and see the Long Marshes lying below you, and beyond them, high in the East, the Lonely Mountain where dear old Smaug lives."<br>-Gandalf, The Hobbit');
    addQuest(996, 202, 'The Lonely Mountain', 'H', 'The-Lonely-Mountain', 'The-Hobbit-On-the-Doorstep/A-Warm-Welcome-1A.jpg',
        'So one day, although autumn was now getting far on, and winds were cold, and leaves were falling fast, three large boats left Lake–town, laden with rowers, dwarves, Mr. Baggins, and many provisions.<br>–The Hobbit');
    addQuest(1017, 216, 'The Battle of Five Armies', 'H', 'The-Battle-of-Five-Armies', 'The-Hobbit-On-the-Doorstep/The-Gathering-of-the-Clouds-1A.jpg',
        '"Dread has come upon you all! Alas! It has come more swiftly than I guessed. The Goblins are upon you! Bolg of the North is coming. O Dain! whose father you slew in Moria. Beehold! the bats are above his army like a sea of locusts. They ride upon wolves and Wargs are in their train!"<br>- Gandalf, The Hobbit');

    //The Lord of the Rings Saga
    addQuest(406, 317, 'A Shadow of the Past', 'LotR', 'A-Shadow-of-the-Past', 'The-Black-Riders/Three-is-Company-1A.jpg',
        'The ring Frodo Baggins inherited from his uncle Bilbo is indeed The One Ring. After conferring with the wizard Gandalf, Frodo decides to leave the Shire and take the ring to Rivendell.');
    addQuest(436, 327, 'The Old Forest', 'LotR', 'The-Old-Forest', 'The-Old-Forest/Farewell-to-the-Shire-1A.jpg',
        'After being pursued through the Shire by mysterious riders in black, Frodo and his friends decide that the safest way for them to continue their journey to Rivendell is to travel through the Old Forest.');
    addQuest(460, 327, 'Fog on the Barrow-downs', 'LotR', 'Fog-on-the-Barrow-downs', 'Fog-on-the-Barrow-downs/The-House-of-Tom-Bombadil-1A.jpg',
        'After rescuing the hobbits from Old Man Willow, Tom Bombadil has invited Frodo and his friends to stay the night in his house. There they are greeted warmly by his wife, Goldberry, the River–daughter.');
    addQuest(560, 309, 'A Knife in the Dark', 'LotR', 'A-Knife-in-the-Dark', 'The-Black-Riders/Trouble-in-Bree-1A.jpg',
        'Frodo and his companions arrive at Bree to find the shadow of the Black Riders already on the crossroads town. Unsure of who to trust, they decide to lodge at The Prancing Pony. There they meet a friend of Gandalf named Strider who offers to lead them to Rivendell, but their movements are also tracked by less savory folk.');
    addQuest(693, 315, 'Flight to the Ford', 'LotR', 'Flight-to-the-Ford', 'The-Black-Riders/Pursued-by-the-Enemy-1A.jpg',
        'Frodo has been gravely injured in the attack on Weathertop and will perish if his companions cannot bring him to Rivendell in time. Strider leads the Hobbits towards the hidden valley, anxiously listening for the sound of Black Riders...');
    addQuest(715, 371, 'The Ring Goes South', 'LotR', 'The-Ring-Goes-South', 'The-Road-Darkens/The-Council-of-Elrond-1A.jpg',
        'In the House of Elrond, the evil wound that Frodo received on Weathertop is healed and he is reunited with his uncle Bilbo. The One Ring cannot remain hidden in Rivendell for long, so Lord Elrond summons a council to decide what should be done to protect the Free Peoples of Middle-earth.');
    addQuest(763, 464, 'Journey in the Dark', 'LotR', 'Journey-in-the-Dark', 'The-Road-Darkens/The-Long-Dark-of-Moria-1A.jpg',
        'Trapped inside the Mines of Moria, the Company of the Ring must find their way through many twisting passages to reach the eastern door. But with every step they take into the Mines, there is a growing sense of dread...');
    addQuest(884, 694, 'Breaking of the Fellowship', 'LotR', 'Breaking-of-the-Fellowship', 'The-Road-Darkens/The-Great-River-1A.jpg',
        'Having barely escaped from Moria, the Company of the Ring flees into the forest of Lórien where they are welcomed by the Elves of the Golden Wood and supplied with boats and other gifts by their Lord and Lady, Celeborn and Galadriel. Then, after a brief rest, they set out upon the River Anduin.');
    addQuest(805, 680, 'The Uruk-hai', 'LotR', 'The-Uruk-hai', 'The-Treason-of-Saruman/Follow-the-Orcs-1A.jpg',
        'The Orcs that attached the Fellowship at Amon Hen captured several members of the Company and are carrying them to Isengard. Aragorn and his companions decide to chase the Uruk-hai in an effort to rescue their friends...');
    addQuest(695, 695, 'Helm\'s Deep', 'LotR', 'Helms-Deep', 'The-Treason-of-Saruman/The-King-of-the-Golden-Hall-1A.jpg',
        'The pursuit of the Uruk-hai has brought the Heir of Elendil to Rohan just as Saruman declares war on that land. Aragorn and his companions travel to Edoras to aid King Théoden, but their arrival is met with suspicion...');
    addQuest(658, 617, 'The Road to Isengard', 'LotR', 'The-Road-to-Isengard', 'The-Treason-of-Saruman/Rouse-the-Ents-1A.jpg',
        'Saruman\'s army has been defeated at Helm\'s Deep, but the Wizard\'s fortress is beyond Rohan\'s power to capture. However, the Ents of Fangorn have also suffered great injury because of Saruman and his Orcs. They have the strength to break Isengard, but only if they can be roused to attack.');
    addQuest(970, 693, 'The Passage of the Marshes', 'LotR', 'The-Passage-of-the-Marshes', 'The-Land-of-Shadow/The-Taming-of-Sm%C3%A9agol-1A.jpg',
        'Frodo and Sam left the Fellowship above the falls of Rauros and crossed the great river to climb the Emyn Muil upon the Eastern shore. After days of wandering through that maze of rocky crags, they have finally reached the edge of the Dead Marshes only to discover that Gollum is following them.');
    addQuest(980, 736, 'Journey to the Cross-roads', 'LotR', 'Journey-to-the-Cross-roads', 'The-Land-of-Shadow/Ambush-the-Men-of-Harad-1A.jpg',
        '"These cursed Southrons come now marching up the ancient roads to swell the hosts of the Dark Tower. Yea, up the very roads that craft of Gondor made." —Mablung, The Two Towers');
    addQuest(1010, 774, 'Shelob\'s Lair', 'LotR', 'Shelobs-Lair', 'The-Land-of-Shadow/The-Stairs-of-Cirith-Ungol-1A.jpg',
        'Sméagol has led Frodo and Sam to the Morgul Vale, where he promises to show them a secret way over the Mountains of Shadow and into the land of Mordor, but Sam fears that Gollum may be leading them into a trap...');
    addQuest(722, 763, 'The Passing of the Grey Company', 'LotR', 'The-Passing-of-the-Grey-Company', 'The-Flame-of-the-West/The-Forbidden-Door-1A.jpg',
        '"I must take new counsel for myself and my kindred. We must ride our own road, and no longer in secret. For me the time of stealth has passed. I will ride by the swiftest way, and I will take the Paths of the Dead." -Aragorn, The Return of the King');
    addQuest(949, 900, 'The Siege of Gondor', 'LotR', 'The-Siege-of-Gondor', 'The-Flame-of-the-West/Attack-on-Pelargir-1A.jpg',
        '"There at Pelargir lay the main fleet of Umbar, fifty great ships and smaller vessels beyond count. Many of those that we pursued had reached the havens before us..."<br>-Gimli, The Return of the King');
    addQuest(958, 825, 'The Battle of the Pelennor Fields', 'LotR', 'The-Battle-of-the-Pelennor-Fields', 'The-Flame-of-the-West/The-Garrison-of-Gondor-1A.jpg',
        '"Here will the hammer-stroke fall hardest. And for that reason Mithrandir came hither in such haste. For if we fall, who shall stand?<br>-Beregond, The Return of the King');
    addQuest(1033, 774, 'The Tower of Cirith Ungol', 'LotR', 'The-Tower-of-Cirith-Ungol', 'The-Mountain-of-Fire/Pass-the-Two-Watchers-1A.jpg',
        'Frodo has been captured by the Orcs of Cirith Ungol and imprisoned at the top of their tower, but Sam is determined to rescue his master.');
    addQuest(1013, 701, 'The Black Gate Opens', 'LotR', 'The-Black-Gate-Opens', 'The-Mountain-of-Fire/Embassy-from-the-Dark-Tower-1A.jpg',
        'Aragorn has led the Men of the West to the very Gate of Mordor in a perilous gamble to keep the Eye of Sauron focused on him. After challenging the Dark Lord to come forth and face judgement, the Black Gate opens and an embassy from Barad-dûr rides out led by The Mouth of Sauron.');
    addQuest(1063, 762, 'Mount Doom', 'LotR', 'Mount-Doom', 'The-Mountain-of-Fire/The-Land-of-Mordor-1A.jpg',
        'Against all odds, the Ring-bearer has found his way into The Black Land of Modor, but a dangerous journey still lies before him and The Eye of Sauron yet searches for the spies who escaped from Cirith Ungol.');
    addQuest(409, 337, 'The Scouring of the Shire', 'LotR', 'The-Scouring-of-the-Shire', 'The-Scouring-of-the-Shire/Many-Partings-1A.png',
        'As they came out again into the open country at sundown they overtook an old man leaning on a staff, and he was clothed in rags of grey or dirty white, and at his heels went another beggar, slouching and whining. —The Return of the King');
    
    //GenCon and Fellowship
    addQuest(1024, 842, 'The Massing at Osgiliath', false, 'The-Massing-at-Osgiliath', 'The-Massing-at-Osgiliath/Beyond-Expectations-1A.jpg',
        'There are reports of increased Orc activity around Ithilien, and you have been sent to investigate. You enter Osgiliath and cross the river. On the outskirts of the city, you see a horde that surpassses all expectations coming down the Morgul Road.');
    addQuest(994, 235, 'The Battle of Lake-town', false, 'The-Battle-of-Lake-town', 'The-Battle-of-Lake-town/Terror-from-the-Mountain-1A.jpg',
        '"Then warning trumpets were suddenly sounded, and echoed along the rocky shores. The cheering stopped and the joy was quickly turned to dread. So it was that the dragon did not find them quite unprepared."<br>-The Hobbit');
    addQuest(745, 765, 'The Stone of Erech', false, 'The-Stone-of-Erech', 'The-Stone-of-Erech/The-Disappearance-1A.jpg',
        'The Lord of Lamedon has asked you to assist him in discovering the whereabouts of his lost son, Derufin. He hasn\'t been seen for days, and his father fears he may be in grave peril. Your search has led you to the Blackroot Vale, where the people live in dread of the Dead Men of Dunharrow.');
    addQuest(210, 178, 'The Ruins of Belegost', false, 'The-Ruins-of-Belegost', 'The-Ruins-of-Belegost/Ruins-of-the-First-Age-1A.jpg',
        'You have entered the dark, half–sunken ruins of Belegost in search of powerful artifacts and ancient treasure.');
    addQuest(487, 326, 'Murder at the Prancing Pony', false, 'Murder-at-the-Prancing-Pony', 'Murder-at-the-Prancing-Pony/Investigating-the-Crime-1A.jpg',
        'You have arrived in Bree to find the village abuzz over a recent crime.');
    addQuest(388, 259, 'The Siege of Annuminas', false, 'The-Siege-of-Annuminas', 'The-Siege-of-Annuminas/Rebuild-the-Defenses-1A.jpg',
        'An army from Angmar marches on the Dúnedain capital of Annúminas. You rush to prepare the defenses as best you can before the Orcs reach the city.');
    addQuest(923, 475, 'Attack on Dol Guldur', false, 'Attack-on-Dol-Guldur', 'Attack-on-Dol-Guldur/Assault-on-the-Golden-Wood-1A.jpg',
        'The Dark Lord of Mordor has declared war across Middle-earth. His Nazgûl lead the Morgul host against Minas Tirith in the south, while Easterlings lay siege to Erebor in the north. And in a move long-prepared, the armies of Dol Guldur cross the Anduin to assault Lórien...');
    addQuest(667, 949, 'The Hunt for the Dreadnaught', false, 'The-Hunt-for-the-Dreadnaught', 'The-Hunt-for-the-Dreadnaught/Searching-the-High-Seas-1A.jpg',
        'The vicious Corsairs of Umbar have been pillaging the Gondorian coastline for months, and rumors are swirling that they\'ve built the most devastating and gigantic ship ever known: The Dreadnaught. Many are suspicious of such extraordinary reports but, if true, the massive enemy is unlike any you\'ve faced before. It will take an equally-colossal effort to take down such a potent foe. No others can bear such a difficult task, so it\'s up to the heroes to assemble a formidable fleet, and then scour the seas for the mighty warship.');
    addQuest(1022, 188, 'The Siege of Erebor', false, 'The-Siege-of-Erebor', 'The-Siege-of-Erebor/The-Siege-of-Erebor-1A.png',
        '“When you think of the great Battle of the Pelennor, do not forget the battles in Dale and the valour of Durin’s Folk. Think of what might have been. Dragon-fire and savage swords in Eriador! There might be no Queen in Gondor.” —Gandalf, The Return of the King');


    addQuest(863, 287, 'The Oath', 'TPLES', 'The-Oath', 'Two-Player-Limited-Edition-Starter/After-the-Raid-1A.jpg',
        'Marauding Goblins have raided a woodman village on the eaves of Mirkwood forest. The Goblins killed the guards and took many of the villages captive. Those left behind beg you to rescue their loved ones.');
    addQuest(960, 258, 'The Caves of Nibin-Dûm', 'TPLES', 'The-Caves-of-Nibin-Dûm', 'Two-Player-Limited-Edition-Starter/The-Dark-of-Nibin-Dum-1A.jpg',
        'You have pursued the Goblins that attacked a woodman village to the mountains of Mirkwood. The trail leads over a steep ridge where you discover the forgotten Dwarf home of Nibin-Dûm. You light a torch and enter in.');

    //Children of Eorl and Oaths of the Rohirrim
    addQuest(883, 770, 'Ambush at Erelas', 'CoE', 'Ambush-at-Erelas', 'Children-of-Eorl/Drive-them-Away-1A.jpg',
        'Along the Great West Road, you come upon a Rohirrim camp in the shadow of the green, bald beacon hill of Erelas. But the quiet of your journey is interrupted by a sudden attack from the shadows! The clash of steel and the cries of men soon reach your ears. You must drive them away and free the camp from further destruction!');
    addQuest(860, 775, 'The Battle for the Beacon', 'CoE', 'The-Battle-for-the-Beacon', 'Children-of-Eorl/Battle-for-the-Hill-1A.jpg',
        'Dunlendings and traitorous Rohirrim have captured the beacon at Erelas. Reclaim the hill at any cost!');
    addQuest(824, 743, 'The Horse Lord’s Ire', 'CoE', 'The-Horse-Lord\'s-Ire', 'Children-of-Eorl/Thieves-and-Coursers-1A.jpg',
        'Orcs have invaded the Eastfold, rampaging across the land and capturing King Thengel’s prized warhorses.');
    addQuest(784, 713, 'The Aldburg Plot', 'CoE', 'The-Aldburg-Plot', 'The-Aldburg-Plot/Evil-Under-the-Moon-1A.jpg',
        'With the knowledge that a faction of rebels has taken up residence in Aldburg, Ealdwulf entreats you to root them out.');
    addQuest(815, 644, 'Fire on the Eastemnet', 'CoE', 'Fire-on-the-Eastemnet', 'Fire-on-the-Eastemnet/Poachers-in-the-Night-1A.png',
        'With fire and whip, the orc-host has regrouped to rob Rohan of its prized steeds.');
    addQuest(687, 646, 'The Gap of Rohan', 'CoE', 'The-Gap-of-Rohan', 'The-Gap-of-Rohan/Giving-Chase-1A.png',
        'You have pursued the traitor Gálmód to the Gap of Rohan. However, unseasonable snows have made your passage difficult.');
    addQuest(668, 696, 'The Glittering Caves', 'CoE', 'The-Glittering-Caves', 'The-Glittering-Caves/Search-the-Caves-1A.png',
        'Fleeing the violent blizzard, you are pursued by the wraith of Helm Hammerhand. He follows inexorably, seeking to claim the bones of your Dunlending captives. You must navigate the caverns below Helm’s Deep to find Helm’s great warhorn. Sounding it may be your only hope of restoring the wraith’s mind.');
    addQuest(741, 727, 'Mustering of the Rohirrim', 'CoE', 'Mustering-of-the-Rohirrim', 'Mustering-of-the-Rohirrim/Oaths-of-the-Rohirrim-1A.png',
        'The traitor Ealdwulf is raising an army to usurp the throne of Thengel-King.');
    addQuest(637, 656, 'Blood in the Isen', 'CoE', 'Blood-in-the-Isen', 'Blood-in-the-Isen/Crossing-the-Fords-1A.png',
        'The traitor Ealdwulf has manipulated a host of Dunlendings and traitorous Rohirrim in a bid for the throne of Rohan. His armies have massed on the banks of the Isen where the Dunlendings prepare to ford.');

    var mapElement = document.getElementById('quest-map');
    if (mapElement) {
        //Move handler
        mapElement.addEventListener('mousemove', function (e) {
            var x = getMapX(e);
            var y = getMapY(e);
            //console.log('move x: ' + x + ' y: ' + y);
            //console.log('page x: ' + e.pageX + ' page y: ' + e.pageY);
            var quest = getSelectedQuest(e);
            if (quest && quest.length == 1) {
                var centerX = targetX[quest];
                var centerY = targetY[quest];
                var imageUrl = 'https://s3.amazonaws.com/hallofbeorn-resources/Images/Cards/' + imageMap[quest];

                $('#tooltip-title').text(quest);
                $('#tooltip-text').html(textMap[quest]);
                $('#tooltip-link').attr({ href: questMap[quest] });
                $('#tooltip-image').show();
                $('#tooltip-image').attr({ src: imageUrl });
                
                var tooltipLeft = centerX + 80;
                if (tooltipLeft < 275) tooltipLeft = 275;
                if (tooltipLeft > 1000) tooltipLeft = 1000;
                var tooltipTop = centerY + 250;
                if (tooltipTop > 1200) {
                    console.log('top: ' + tooltipTop);
                    tooltipTop = tooltipTop - $('#map-tooltip').height() - 50;
                }
                $('#map-tooltip').css({ top: tooltipTop + 'px', left: tooltipLeft + 'px', position: 'absolute' });
                $('#map-tooltip').show();

                drawLines(e, quest);
            } else {
                $('#map-tooltip').hide();

                hideLines(e);
            }
        });

        //Click handler
        mapElement.addEventListener('click', function (e) {
            var x = getMapX(e);
            var y = getMapY(e);
            console.log('click: ' + x + ', ' + y);
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
    $.get("/LotR/ScenarioTotals?id=Core+Set,Shadows+of+Mirkwood").success(function (data) {
        loadTotals('#coreTotalsContainer', 'Core Set and Shadows of Mirkwood', data);
    });
    $.get("/LotR/ScenarioTotals?id=Khazad-dûm,Dwarrowdelf").success(function (data) {
        loadTotals('#kdTotalsContainer', 'Khazad-dûm and Dwarrowdelf', data);
    });
    $.get("/LotR/ScenarioTotals?id=Heirs+of+Númenor,Against+the+Shadow").success(function (data) {
        loadTotals('#honTotalsContainer', 'Heirs of Númenor and Against the Shadow', data);
    });
    $.get("/LotR/ScenarioTotals?id=The+Voice+of+Isengard,The+Ring-maker").success(function (data) {
        loadTotals('#voiTotalsContainer', 'The Voice of Isengard and The Ring-maker', data);
    });
    $.get("/LotR/ScenarioTotals?id=The+Lost+Realm,Angmar+Awakened").success(function (data) {
        loadTotals('#tlrTotalsContainer', 'The Lost Realm and Angmar Awakened', data);
    });
    $.get("/LotR/ScenarioTotals?id=The+Grey+Havens,Dream-chaser").success(function (data) {
        loadTotals('#tghTotalsContainer', 'The Grey Havens and Dream-chaser', data);
    });
    $.get("/LotR/ScenarioTotals?id=The+Sands+of+Harad,Haradrim").success(function (data) {
        loadTotals('#tsohTotalsContainer', 'The Sands of Harad and Haradrim', data);
    });
    $.get("/LotR/ScenarioTotals?id=The+Wilds+of+Rhovanion,Ered+Mithrin").success(function (data) {
        loadTotals('#tworTotalsContainer', 'The Wilds of Rhovanion and Ered Mithrin', data);
    });
    $.get("/LotR/ScenarioTotals?id=A+Shadow+in+the+East,Vengeance+of+Mordor").success(function (data) {
        loadTotals('#asiteTotalsContainer', 'A Shadow in the East and Vengeance of Mordor', data);
    });
    $.get("/LotR/ScenarioTotals?id=The+Hobbit").success(function (data) {
        loadTotals('#hobbitTotalsContainer', 'The Hobbit Saga', data);
    });
    $.get("/LotR/ScenarioTotals?id=The+Lord+of+the+Rings").success(function (data) {
        loadTotals('#lotrTotalsContainer', 'The Lord of the Rings Saga', data);
    });
    $.get("/LotR/ScenarioTotals?id=Gen+Con+Decks").success(function (data) {
        loadTotals('#genConTotalsContainer', 'Gen Con Decks', data);
    });
    $.get("/LotR/ScenarioTotals?id=Fellowship+Decks").success(function (data) {
        loadTotals('#fellowshipTotalsContainer', 'Fellowship Decks', data);
    });
    //TODO: We need at least two scenario packs in order for the chart to be useful
    /*
    $.get("/LotR/ScenarioTotals?id=Scenario+Packs").success(function (data) {
        loadTotals('#scenarioPackTotalsContainer', 'Scenario Packs', data);
    });
    */
    $.get("/LotR/ScenarioTotals?id=First+Age,Doom+Mastered").success(function (data) {
        loadTotals('#firstAgeTotalsContainer', 'First Age and Doom Mastered', data);
    });
    $.get("/LotR/ScenarioTotals?id=Children+of+Eorl,Oaths+of+the+Rohirrim").success(function (data) {
        loadTotals('#coeTotalsContainer', 'Children of Eorl and Oaths of the Rohirrim', data);
    });
}