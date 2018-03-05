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
        //console.log('x: ' + x + ' y: ' + y);
        var xCodes = getCodes(xMap, x, 'X');
        var yCodes = getCodes(yMap, y, 'Y');

        //console.log('x codes');
        //console.log(xCodes);
        //console.log('y codes');
        //console.log(yCodes);

        return arrayIntersectShouldBePartOfTheLanguage(xCodes, yCodes);
    };

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

    addQuest(994, 235, 'The Battle of Lake-town', 'The-Battle-of-Lake-town', 'The-Battle-of-Lake-town/Terror-from-the-Mountain-1A.jpg',
        '"Then warning trumpets were suddenly sounded, and echoed along the rocky shores. The cheering stopped and the joy was quickly turned to dread. So it was that the dragon did not find them quite unprepared."<br>-The Hobbit');
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
                $('#map-tooltip').css({ top: (y + 240) + 'px', left: (x + 80) + 'px', position: 'absolute' });
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