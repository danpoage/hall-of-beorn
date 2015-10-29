$(function () {

    function addCard(card) {
        console.log('addCard');
        console.log(card);

        var imageHtml = '<img class="deck-card-image deck-card-image-hidden" src="' + card.CardImage + '"/>';
        var sphereHtml = '<img class="deck-sphere-icon" src="' + card.SphereIcon + '"/>';
        var titleHtml = '<a class="deck-card-title" href="' + card.Url + '" target="_blank">' + card.Title + '</a>';
        var removeHtml = '<img class="deck-item-remove" src="/Images/close-button.png"/>'

        var countHtml = card.MaxPerDeck == 3 ? '<select class="deck-item-count"><option>1</option><option>2</option><option>3</option></select>' : '<select  class="deck-item-count-one" disabled><option>1</option></select>';

        var selector = false;
        var itemClass = 'deck-card-item';
        var titleClass = '';
        var itemHtml = sphereHtml + titleHtml + removeHtml + countHtml + imageHtml;
        switch (card.CardType) {
            case 'Hero':
                selector = '#heroList';
                itemClass = 'hero-card-item';
                itemHtml = '<div><img class="hero-card-image" src="' + card.CardImage + '"/></div><div>' + sphereHtml + '<a href="' + card.Url + '" target="_blank">' + card.Title + '</a>' + removeHtml + '</div>';
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
            $(selector).append('<li class="deck-item ' + itemClass + '">' + itemHtml + '</li>');
        }
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