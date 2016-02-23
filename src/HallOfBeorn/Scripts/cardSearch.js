function hasMoreOptions() {
    if ($('#Cost').val() != 'Any') {
        return true;
    }

    if ($('#ThreatCost').val() != 'Any') {
        return true;
    }

    if ($('#EngagementCost').val() != 'Any') {
        return true;
    }

    if ($('#Attack').val() != 'Any') {
        return true;
    }

    if ($('#Defense').val() != 'Any') {
        return true;
    }

    if ($('#HitPoints').val() != 'Any') {
        return true;
    }

    if ($('#Willpower').val() != 'Any') {
        return true;
    }

    if ($('#Threat').val() != 'Any') {
        return true;
    }

    if ($('#QuestPoints').val() != 'Any') {
        return true;
    }

    if ($('#Trait').val() != 'Any') {
        return true;
    }

    if ($('#Keyword').val() != 'Any') {
        return true;
    }

    if ($('#VictoryPoints').val() != 'Any') {
        return true;
    }

    if ($('#Category').val() != 'Any') {
        return true;
    }

    if ($('#EncounterCategory').val() != 'Any') {
        return true;
    }

    if ($('#QuestCategory').val() != 'Any') {
        return true;
    }

    if ($('#Artist').val() != 'Any') {
        return true;
    }

    return false;
}

function getParameterByName(name, url) {
    if (!url) url = window.location.href;
    name = name.replace(/[\[\]]/g, "\\$&");
    var regex = new RegExp("[?&]" + name + "(=([^&#]*)|&|#|$)"),
        results = regex.exec(url);
    if (!results) return null;
    if (!results[2]) return '';
    return decodeURIComponent(results[2].replace(/\+/g, " "));
}

$(document).ready(function () {
    var cardSet = getParameterByName('CardSet');
    if (cardSet) {
        $("#CardSet").val(cardSet);
    }

    if (hasMoreOptions()) {
        $('#moreOptionsButton').text('Fewer Search Options');
        $('#moreOptionsContainer').show();
    }

    $('.search-explanation-button').click(function () {
        var text = $(this).parent().find('#search-explanation-text');
        text.toggle();

        if (!text.is(':visible')) {
            $('.search-explanation').addClass('search-explanation-default');
        } else {
            $('.search-explanation').removeClass('search-explanation-default');
        }
    });

    $('.search-explanation-message').click(function () {
        $(this).toggle();

        if (!$(this).is(':visible')) {
            $('.search-explanation').addClass('search-explanation-default');
        } else {
            $('.search-explanation').removeClass('search-explanation-default');
        }
    });

    $('#moreOptionsButton').click(function () {
        $('#moreOptionsContainer').toggle();

        if ($('#moreOptionsContainer').is(":visible")) {
            $('#moreOptionsButton').text('Fewer Search Options');
        } else {
            $('#moreOptionsButton').text('More Search Options');
        }
    });

    $('#resetButton').click(function () {
        $('#Sort').val('Any');
        $('#Query').focus().val('');

        $('#CardSet').val('Any');
        $('#Scenario').val('Any');
        $('#EncounterSet').val('Any');

        $('#CardType').val('Any');
        $('#CardSubtype').val('Any');
        $('#DeckType').val('Any');

        $('#Sphere').val('Any');
        $('#IsUnique').val('Any');
        $('#SetType').val('Any');

        $('#Cost').val('Any');
        $('#CostOperator').val('=');
        $('#ThreatCost').val('Any');
        $('#ThreatCostOperator').val('=');
        $('#EngagementCost').val('Any');
        $('#EngagementCostOperator').val('=');

        $('#Attack').val('Any');
        $('#AttackOp').val('=');
        $('#Defense').val('Any');
        $('#DefenseOp').val('=');
        $('#HitPoints').val('Any');
        $('#HitPointsOp').val('=');
        $('#Willpower').val('Any');
        $('#WillpowerOp').val('=');
        $('#Threat').val('Any');
        $('#ThreatOp').val('=');
        $('#QuestPoints').val('Any');
        $('#QuestPointsOp').val('=');

        $('#Trait').val('Any');
        $('#Keyword').val('Any');
        $('#VictoryPoints').val('Any');

        $('#Category').val('Any');
        $('#EncounterCategory').val('Any');
        $('#QuestCategory').val('Any');

        $('#Artist').val('Any');
    });

    $('#Query').keypress(function (e) {
        if (e.which == 13) {
            $('form').submit();
            return false;
        }
    });

    $('.search-select-checkbox').click(function (e) {

        if (e.currentTarget) {
            var value = e.currentTarget.checked;

            items = [];

            switch (e.currentTarget.id) {
                case 'MESOM':
                    items = [ '#MEC02', '#MEC03', '#MEC04', '#MEC05', '#MEC06', '#MEC07' ];
                    break;
                case "MEDWD":
                    items = [ '#MEC09', '#MEC10', '#MEC11', '#MEC12', '#MEC13', '#MEC14' ];
                    break;
                default:
                    break;
            }

            if (items.length > 0) {
                for (var i = 0; i < items.length; i++) {
                    $(items[i]).prop('checked', value);
                    $(items[i]).prop('disabled', value);
                }
            }
        }
    });
});