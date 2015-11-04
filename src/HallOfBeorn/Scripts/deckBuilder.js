$(function () {

    var storedDeck = getLocal('currentDeck');
    if (storedDeck) {
        var deckModel = JSON.parse(storedDeck);
        loadDeckModel(deckModel);
    }

    function getLocal(key) {
        if (typeof (Storage) !== "undefined") {
            return localStorage.getItem(key);
        }
    }

    function setLocal(key, data) {
        if (typeof (Storage) !== "undefined") {
            localStorage.setItem(key, data);
        }
    }

    function clearLocal(key) {
        if (typeof (Storage) !== "undefined") {
            localStorage.removeItem(key);
        }
    }

    function addCard(card, count) {
        console.log('addCard');
        console.log(card);

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
            $(selector).append('<li data-octgn="' + octgnGuid + '" class="deck-item ' + itemClass + '">' + itemHtml + '</li>');
        }
    }

    $('#saveOctgn').click(function (e) {
        //console.log('octgnExport');

        var deck = getDeckModel();

        saveLocalDeck(deck);
        saveOctgnDeck(deck);
        
        return false;
    });

    $('#saveLocal').click(function (e) {
        var deck = getDeckModel();

        saveLocalDeck(deck);

        return false;
    });

    $('#loadDeck').click(function (e) {
        console.log('loadDeck click');
        clearLocal('currentDeck');
    });

    function addDeckItem(deck, guid, count, item) {
        deck.counts[guid] = count;
        item.all.push(guid);

        switch (count) {
            case 3:
                item.count3.push(guid);
                break;
            case 2:
                item.count2.push(guid);
                break
            case 1:
            default:
                item.count1.push(guid);
                break;
        }
    }

    function loadDeckModel(deck) {
        console.log('loadDeckModel');
        console.log(deck);

        $('#Name').val(deck.name);

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

        console.log('guid list');
        console.log(guids);
        var url = '/Cards/DeckItems?guidList=' + guids.join(',');
        console.log('url: ' + url);

        $.ajax({
            url: url,
            type: "get",
            success: function (data) {
                console.log('deck items results');
                console.log(data);

                var cardCount = 0;
                if (data && data.length > 0) {
                    for (var i = 0; i < data.length; i++) {
                        //console.log('*** loading octgn guid: ' + data[i].OctgnGuid);
                        cardCount = deck.counts[data[i].OctgnGuid];
                        addCard(data[i], cardCount);
                    }
                }
            }
        });
    }

    function getCardCount(deck, guid) {

        /*
        if (deck.heroes.all.length > 0) {
            for (var i = 0; i < deck.heroes.length; i++) {
                if (deck.heroes.all[i] == guid) {
                    return 1;
                }
            }
        }

        if (deck.sideQuests.all.length > 0) {
            for (var i = 0; i < deck.sideQuests.length; i++) {
                if (deck.sideQuests.all[i] == guid) {
                    return 1;
                }
            }
        }

        var itemFields = ['allies', 'attachments', 'events'], 
            itemField = '', 
            countField = '';

        for (var i = 1; i < 4; i++) {
            countField = 'count' + i;
            for (var j = 0; j < itemFields.length; j++) {
                itemField = itemFields[j];
                if (deck[itemField][countField].length > 0) {
                    for (var k = 0; k < deck[itemField][countField].length; k++) {
                        if (deck[itemField][countField][k] == guid) {
                            return i;
                        }
                    }
                }
            }
        }

        return 1;
        */
    }

    function getDeckModel() {
        var deck = {
            name: $('#Name').val(),
            counts: {
            },
            heroes: {
                all: [], count1: []
            },
            allies: {
                all: [], count1: [], count2: [], count3: []
            },
            attachments: {
                all: [], count1: [], count2: [], count3: []
            },
            events: {
                all: [], count1: [], count2: [], count3: []
            },
            sideQuests: {
                all: [], count1: []
            }
        };

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
        console.log('saveLocalDeck');
        //console.log(deck);

        var deckData = JSON.stringify(deck);

        console.log('deckData');
        console.log(deckData);

        setLocal('currentDeck', deckData);
    }

    function saveOctgnDeck(deck) {
        console.log('saveOctgnDeck');
        console.log(deck);

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

        console.log('url: ' + url);
        window.open(url, '_blank');
    }

    $('#deckContainer').on('mouseenter', '.deck-card-title', function (e) {
        $(e.currentTarget).parent().find('.deck-card-image').removeClass('deck-card-image-hidden').addClass('deck-card-image-hover');
    });

    $('#deckContainer').on('mouseleave', '.deck-card-title', function (e) {
        console.log('mouse leaving title');
        $(e.currentTarget).parent().find('.deck-card-image').addClass('deck-card-image-hidden').removeClass('deck-card-image-hover');
    });

    $('#deckContainer').on('click', '.deck-item-remove', function (e) {
        $(e.currentTarget).parent().closest('.deck-item').remove();
    });

    $('#deckContainer').on('click', '.deck-item', function (e) {
        var octgnGuid = $(e.currentTarget).closest('.deck-item').data('octgn');
        console.log('selected OCTGN guid: ' + octgnGuid);
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