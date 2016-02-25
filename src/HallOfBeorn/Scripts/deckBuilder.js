$(function () {

    var storedDeck;
    if (location.search && location.search.indexOf('t=') != -1 && location.search.indexOf('&h=') != -1) {
        console.log('url has deck info: ' + location.search);

        var deckModel = getDeckModelFromUrl();
        loadDeckModel(deckModel);

        recalculateDeckTotal();
    } else {
        storedDeck = getLocal('currentDeck');
        if (storedDeck) {
            var deckModel = JSON.parse(storedDeck);
            loadDeckModel(deckModel);

            recalculateDeckTotal();
        }
    }


    function loadShortSlugs(deck, shortSlugs, type) {
        var url = '/Cards/DeckItemsByShortSlugs?shortSlugList=' + shortSlugs + "&type=" + type;

        //console.log('url for deck items by short slugs: ' + url);
        //console.log('deck before loading');
        //console.log(deck);

        $.ajax({
            url: url,
            type: "get",
            success: function (data) {

                if (data && data.length > 0) {
                    for (var i = 0; i < data.length; i++) {

                        //console.log('card to add from URL');
                        //console.log(data[i]);

                        switch (type) {
                            case 'Hero':
                                addDeckItem(deck, data[i].OctgnGuid, data[i].Count, deck.heroes);
                                break;
                            case 'Ally':
                                addDeckItem(deck, data[i].OctgnGuid, data[i].Count, deck.allies);
                                break;
                            case 'Attachment':
                                addDeckItem(deck, data[i].OctgnGuid, data[i].Count, deck.attachments);
                                break;
                            case 'Event':
                                addDeckItem(deck, data[i].OctgnGuid, data[i].Count, deck.events);
                                break;
                            case 'Player_Side_Quest':
                                addDeckItem(deck, data[i].OctgnGuid, data[i].Count, deck.sideQuests);
                                break;
                            default:
                                break;
                        }

                        addCard(data[i], data[i].Count);
                    }
                }
                //console.log('*** cards by short slugs!');
                //console.log(data);
            }
        });
    }

    function getDeckModelFromUrl() {
        var deck = getEmptyDeck();
        
        var parts = location.search.replace('?', '').split('&');
        
        if (parts && parts.length > 0) {
            for (var i = 0; i < parts.length; i++) {

                var keyAndVal = parts[i].split('=');
                if (keyAndVal && keyAndVal.length == 2) {

                    //console.log('keyAndVal: ' + keyAndVal[0]);
                    
                    switch (keyAndVal[0]) {
                        case 't':
                            deck.name = decodeURIComponent(keyAndVal[1]);
                            break;
                        case 'h':
                            loadShortSlugs(deck, keyAndVal[1], 'Hero');
                            break;
                        case 'al':
                            loadShortSlugs(deck, keyAndVal[1], 'Ally');
                            break;
                        case 'at':
                            loadShortSlugs(deck, keyAndVal[1], 'Attachment');
                            break;
                        case 'e':
                            loadShortSlugs(deck, keyAndVal[1], 'Event');
                            break;
                        case 'q':
                            loadShortSlugs(deck, keyAndVal[1], 'Player_Side_Quest');
                            break;
                        default:
                            break;
                    }
                }
            }
        }

        loadDeckModel(deck);

        //console.log('deck after load');
        //console.log(deck);

        return deck;
    }

    function updateTotalCards(number) {
        console.log('updateTotalCards');
        var total = parseInt($('#totalCards').text());
        if (!total) {
            total = 0;
        }

        setTotalCards(total + number);
    }

    function setTotalCards(total) {
        //console.log('setTotalCards');
        $('#totalCards').text(parseInt(total, 10));
    }

    function addCard(card, count) {
        
        if (card.CardType != 'Hero') {
            console.log('*** adding non hero card');
            updateTotalCards(count);
        }

        var imageHtml = '<img class="deck-card-image deck-card-image-hidden" src="' + card.CardImage + '"/>';
        var sphereHtml = '<img class="deck-sphere-icon" src="' + card.SphereIcon + '"/>';
        var titleHtml = '<a class="deck-card-title" href="' + card.Url + '" target="_blank">' + card.Title + '</a>';
        var removeHtml = '<img class="deck-item-remove" src="/Images/close-button.png"/>';

        var selected1 = ' selected', selected2 = '', selected3 = '';
        switch (count) {
            case 3:
                selected1 = '';
                selected3 = ' selected';
                break;
            case 2:
                selected1 = '';
                selected2 = ' selected';
                break;
            default:
                break;
        }

        var countHtml = card.MaxPerDeck == 3 ? '<select class="deck-item-count"><option value="1"' + selected1 + '>1</option><option value="2"' + selected2 + '>2</option><option value="3"' + selected3 + '>3</option></select>' : '<select  class="deck-item-count-one" disabled><option value="1" selected>1</option></select>';

        var octgnGuid = card.OctgnGuid;
        var octgnSlug = card.OctgnSlug;
        var selector = false;
        var itemClass = 'deck-card-item';
        var titleClass = '';
        var itemHtml = sphereHtml + titleHtml + removeHtml + countHtml + imageHtml;
        switch (card.CardType) {
            case 'Hero':
                selector = '#heroList';
                itemClass = 'hero-card-item';
                itemHtml = '<div><img class="hero-card-image" src="' + card.CardImage + '"/></div><div>' + sphereHtml + titleHtml + removeHtml + '</div>';
                break;
            case 'Ally':
                selector = '#allyList';
                break;
            case 'Attachment':
                selector = '#attachmentList';
                break;
            case 'Event':
                selector = '#eventList';
                break;
            case 'Player_Side_Quest':
                selector = '#sideQuestList';
                break;
            default:
                break;
        }

        if (selector) {
            $(selector).append('<li data-octgn="' + octgnGuid + '" data-slug="' + octgnSlug + '" class="deck-item ' + itemClass + '">' + itemHtml + '</li>');
        }
    }

    $('#saveOctgn').click(function (e) {
        var deck = getDeckModel();

        saveLocalDeck(deck);
        saveOctgnDeck(deck);
        
        recalculateDeckTotal();

        return false;
    });

    $('#saveLocal').click(function (e) {
        var deck = getDeckModel();

        saveLocalDeck(deck);

        recalculateDeckTotal();

        return false;
    });

    $('#loadDeck').click(function (e) {
        clearLocal('currentDeck');
    });

    $('#searchTab').click(function (e) {
        if (!$(this).hasClass('selected-tab')) {
            $('.option-tab').removeClass('selected-tab');
            $(this).addClass('selected-tab');
            $('.option-section').addClass('hidden');
            $('#searchSection').removeClass('hidden');
        }
    });

    $('#cardSetTab').click(function (e) {
        if (!$(this).hasClass('selected-tab')) {
            $('.option-tab').removeClass('selected-tab');
            $(this).addClass('selected-tab');
            $('.option-section').addClass('hidden');
            $('#cardSetSection').removeClass('hidden');
        }
    });

    $('#settingsTab').click(function (e) {
        if (!$(this).hasClass('selected-tab')) {
            $('.option-tab').removeClass('selected-tab');
            $(this).addClass('selected-tab');
            $('.option-section').addClass('hidden');
            $('#settingsSection').removeClass('hidden');
        }
    });

    $('#deckContainer').on('change', '.deck-item-count', function (e) {
        console.log('deck item count changed');
        recalculateDeckTotal();
    });

    function recalculateDeckTotal() {
        var total = 0;

        $('.deck-item-count').each(function (index, item) {
            total += parseInt($(item).val());
        });

        console.log('total: ' + total);

        setTotalCards(total);
    }

    function addDeckItem(deck, guid, count, item) {
        deck.counts[guid] = count;
        item.all.push(guid);

        switch (count) {
            case 3:
                updateTotalCards(3);
                item.count3.push(guid);
                break;
            case 2:
                updateTotalCards(2);
                item.count2.push(guid);
                break
            case 1:
            default:
                if (item.type != 'heroes') {
                    console.log('???');
                    console.log(item);
                    updateTotalCards(1);
                }
                item.count1.push(guid);
                break;
        }
    }

    function loadDeckModel(deck) {
        
        $('#Name').val(deck.name);

        var shareLink = '/Cards/Decks?t=' + encodeURIComponent(deck.name);

        var guids = [];
        if (deck.heroes.all.length > 0) {
            for (var i = 0; i < deck.heroes.all.length; i++) {
                guids.push(deck.heroes.all[i]);
            }
        }

        if (deck.allies.all.length > 0) {
            for (var i = 0; i < deck.allies.all.length; i++) {
                guids.push(deck.allies.all[i]);
            }
        }

        if (deck.attachments.all.length > 0) {
            for (var i = 0; i < deck.attachments.all.length; i++) {
                guids.push(deck.attachments.all[i]);
            }
        }

        if (deck.events.all.length > 0) {
            for (var i = 0; i < deck.events.all.length; i++) {
                guids.push(deck.events.all[i]);
            }
        }

        if (deck.sideQuests.all.length > 0) {
            for (var i = 0; i < deck.sideQuests.all.length; i++) {
                guids.push(deck.sideQuests.all[i]);
            }
        }

        $('#shareLink').html(shareLink);

        if (guids && guids.length > 0) {
            var url = '/Cards/DeckItems?guidList=' + guids.join(',');

            $.ajax({
                url: url,
                type: "get",
                success: function (data) {

                    var cardCount = 0;
                    if (data && data.length > 0) {

                        var hSlugs = [];
                        var alSlugs = [];
                        var atSlugs = [];
                        var eSlugs = [];
                        var qSlugs = [];

                        for (var i = 0; i < data.length; i++) {
                            cardCount = deck.counts[data[i].OctgnGuid];
                            addCard(data[i], cardCount);

                            var countSuffix = '';
                            if (cardCount > 1) {
                                countSuffix = '_' + cardCount;
                            }

                            switch (data[i].CardType) {
                                case 'Hero':
                                    hSlugs.push(data[i].OctgnSlug + countSuffix);
                                    break;
                                case 'Ally':
                                    alSlugs.push(data[i].OctgnSlug + countSuffix);
                                    break;
                                case 'Attachment':
                                    atSlugs.push(data[i].OctgnSlug + countSuffix);
                                    break;
                                case 'Event':
                                    eSlugs.push(data[i].OctgnSlug + countSuffix);
                                    break;
                                case 'Player_Side_Quest':
                                    qSlugs.push(data[i].OctgnSlug + countSuffix);
                                    break;
                                default:
                                    break;
                            }
                        }

                        if (hSlugs.length > 0) {
                            shareLink += '&h=' + hSlugs.join(',');
                        }

                        if (alSlugs.length > 0) {
                            shareLink += '&al=' + alSlugs.join(',');
                        }

                        if (atSlugs.length > 0) {
                            shareLink += '&at=' + atSlugs.join(',');
                        }

                        if (eSlugs.length > 0) {
                            shareLink += '&e=' + eSlugs.join(',');
                        }

                        if (qSlugs.length > 0) {
                            shareLink += '&q=' + qSlugs.join(',');
                        }

                        //console.log('full share link: ' + shareLink);
                        $('#shareLink').html(shareLink);
                    }
                }
            });
        }
    }

    function getEmptyDeck() {
        var deck = {
            name: '',
            counts: {
            },
            heroes: {
                type: 'heroes',
                all: [], count1: [], count2: [], count3: []
            },
            allies: {
                type: 'allies',
                all: [], count1: [], count2: [], count3: []
            },
            attachments: {
                type: 'attachments',
                all: [], count1: [], count2: [], count3: []
            },
            events: {
                type: 'events',
                all: [], count1: [], count2: [], count3: []
            },
            sideQuests: {
                type: 'sideQuests',
                all: [], count1: [], count2: [], count3: []
            }
        };

        return deck;
    }

    function getDeckModel() {
        var deck = getEmptyDeck();

        deck.name = $('#Name').val();

        $('#heroList').find('.deck-item').each(function (index, item) {
            guid = $(item).data('octgn');

            addDeckItem(deck, guid, 1, deck.heroes);
        });

        $('#allyList').find('.deck-item').each(function (index, item) {
            var count = parseInt($(item).find('.deck-item-count').val()),
                guid = $(item).data('octgn');

            addDeckItem(deck, guid, count, deck.allies);
        });

        $('#attachmentList').find('.deck-item').each(function (index, item) {
            var count = parseInt($(item).find('.deck-item-count').val()),
                guid = $(item).data('octgn');

            addDeckItem(deck, guid, count, deck.attachments);
        });

        $('#eventList').find('.deck-item').each(function (index, item) {
            var count = parseInt($(item).find('.deck-item-count').val()),
                guid = $(item).data('octgn');

            addDeckItem(deck, guid, count, deck.events);
        });

        $('#sideQuestList').find('.deck-item').each(function (index, item) {
            var count = $(item).find('.deck-item-count').val(),
                guid = $(item).data('octgn');

            addDeckItem(deck, guid, 1, deck.sideQuests);
        });

        return deck;
    }

    function saveLocalDeck(deck) {

        var deckData = JSON.stringify(deck);

        setLocal('currentDeck', deckData);
    }

    function saveOctgnDeck(deck) {
        
        var url = '/Cards/SaveOctgnDeck?name=' + encodeURIComponent(deck.name);
        if (deck.heroes.all.length > 0) {
            url += '&heroes=' + deck.heroes.all.join(',');
        }

        var itemFields = ['allies', 'attachments', 'events'],
            itemField = '', countField = '';

        for (var i = 1; i < 4; i++) {
            countField = 'count' + i;
            for (var j = 0; j < itemFields.length; j++) {
                itemField = itemFields[j];
                if (deck[itemField][countField].length > 0) {
                    url += '&' + itemField + i + '=' + deck[itemField][countField].join(',');
                }
            }
        }
        
        if (deck.sideQuests.all.length > 0) {
            url += '&sideQuests=' + deck.sideQuests.all.join(',');
        }

        window.open(url, '_blank');
    }

    $('#deckContainer').on('mouseenter', '.deck-card-title', function (e) {
        $(e.currentTarget).parent().find('.deck-card-image').removeClass('deck-card-image-hidden').addClass('deck-card-image-hover');
    });

    $('#deckContainer').on('mouseleave', '.deck-card-title', function (e) {
        $(e.currentTarget).parent().find('.deck-card-image').addClass('deck-card-image-hidden').removeClass('deck-card-image-hover');
    });

    $('#deckContainer').on('click', '.deck-item-remove', function (e) {
        $(e.currentTarget).parent().closest('.deck-item').remove();
    });

    $('#deckContainer').on('click', '.deck-item', function (e) {
        var octgnGuid = $(e.currentTarget).closest('.deck-item').data('octgn');
    });

    var $search = $("#Search");

    $search.autocomplete({
        source: function (request, response) {
            $.ajax({
                url: "/Cards/TitleSearch",
                type: "get",
                dataType: "json",
                data: {
                    term: request.term
                },
                success: function (data) {
                    response(data);
                }
            });
        },
        minLength: 2,
        select: function (event, elem) {
            if (elem && elem.item) {
                addCard(elem.item, 1);
            }
        }
    })
    .data("autocomplete")._renderItem = function (ul, item) {

        var $li = $('<li>'),
            $icon = $('<img class="deck-sphere-icon">'),
            $image = $('<img class="deck-card-image">');


        $icon.attr({
            src: item.SphereIcon,
            alt: item.Title
        });

        $image.attr({
            src: item.CardImage,
            alt: item.Title
        });

        $li.data('item.autocomplete', item);
        $li.append('<a href="#">');
        $li.find('a').append($image).append($icon).append(item.Title);

        return $li.appendTo(ul);
    };
    $search.autocomplete("widget").addClass("autocompleteClass");
});