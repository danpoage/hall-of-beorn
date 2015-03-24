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

$(document).ready(function () {
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
});