$(function () {

    function addCard(card) {
        console.log('addCard');
        console.log(card);

        var imageHtml = '<img class="deck-card-image deck-card-image-hidden" src="' + card.CardImage + '"/>';
        var sphereHtml = '<img class="deck-sphere-icon" src="' + card.SphereIcon + '"/>';
        var titleHtml = '<a class="deck-card-title" href="' + card.Url + '" target="_blank">' + card.Title + '</a>';
        var removeHtml = '<img class="deck-item-remove" src="/Images/close-button.png"/>';

        var countHtml = card.MaxPerDeck == 3 ? '<select class="deck-item-count"><option value="1">1</option><option value="2">2</option><option value="3">3</option></select>' : '<select  class="deck-item-count-one" disabled><option value="1">1</option></select>';

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

    //$('#octgnExport').click(function (e) {
    //    console.log('octgnExport');
    //    saveOctgnDeck();
    //});

    function getOctgnDeck() {
        var xml = '<?xml version="1.0" encoding="utf-8" standalone="yes"?><deck game="a21af4e8-be4b-4cda-a6b6-534f9717391f">';

        xml += '<section name="Hero" shared="False">';
        $('#heroList').find('.deck-item').each(function (index, item) {
            var title = $(item).find('.deck-card-title').html(), 
                octgnGuid = $(item).data('octgn');
            
            xml += '<card qty="1" id="' + octgnGuid + '">' + title + '</card>';
        });
        xml += '</section>';

        xml += '<section name="Ally" shared="False">';
        $('#allyList').find('.deck-item').each(function (index, item) {
            var title = $(item).find('.deck-card-title').html(),
                count = $(item).find('.deck-item-count').val(),
                octgnGuid = $(item).data('octgn');

            console.log('count: ' + count);

            xml += '<card qty="' + count +'" id="' + octgnGuid + '">' + title + '</card>';
        });
        xml += '</section>';

        xml += '<section name="Attachment" shared="False">';
        $('#attachmentList').find('.deck-item').each(function (index, item) {
            var title = $(item).find('.deck-card-title').html(),
                count = $(item).find('.deck-item-count').val(),
                octgnGuid = $(item).data('octgn');

            console.log('count: ' + count);

            xml += '<card qty="' + count + '" id="' + octgnGuid + '">' + title + '</card>';
        });
        xml += '</section>';

        xml += '<section name="Event" shared="False">';
        $('#eventList').find('.deck-item').each(function (index, item) {
            var title = $(item).find('.deck-card-title').html(),
                count = $(item).find('.deck-item-count').val(),
                octgnGuid = $(item).data('octgn');

            console.log('count: ' + count);

            xml += '<card qty="' + count + '" id="' + octgnGuid + '">' + title + '</card>';
        });
        xml += '</section>';

        xml += '<section name="Side Quest" shared="False">';
        $('#sideQuestList').find('.deck-item').each(function (index, item) {
            var title = $(item).find('.deck-card-title').html(),
                count = $(item).find('.deck-item-count').val(),
                octgnGuid = $(item).data('octgn');

            console.log('count: ' + count);

            xml += '<card qty="' + count + '" id="' + octgnGuid + '">' + title + '</card>';
        });
        xml += '</section>';

        xml += '</deck>';

        return xml;

        //var aFileParts = [ xml ];
        //var blob = new Blob(aFileParts, { type: 'application/octgn' });
        //window.open(URL.createObjectURL(blob));
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
                addCard(elem.item);
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