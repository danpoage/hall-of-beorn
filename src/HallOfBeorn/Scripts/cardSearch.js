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

    if ($('#Popularity').val() != 'Any') {
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

function getProductCodes() {
    var codes = [];

    codes.push('MEC01');
    codes.push('MEC02');
    codes.push('MEC03');
    codes.push('MEC04');
    codes.push('MEC05');
    codes.push('MEC06');
    codes.push('MEC07');
    codes.push('MEC08');
    codes.push('MEC09');
    codes.push('MEC10');
    codes.push('MEC11');
    codes.push('MEC12');
    codes.push('MEC13');
    codes.push('MEC14');
    codes.push('MEC17');
    codes.push('MEC18');
    codes.push('MEC19');
    codes.push('MEC20');
    codes.push('MEC21');
    codes.push('MEC22');
    codes.push('MEC23');
    codes.push('MEC25');
    codes.push('MEC26');
    codes.push('MEC27');
    codes.push('MEC28');
    codes.push('MEC29');
    codes.push('MEC30');
    codes.push('MEC31');
    codes.push('MEC38');
    codes.push('MEC39');
    codes.push('MEC40');
    codes.push('MEC41');
    codes.push('MEC42');
    codes.push('MEC43');
    codes.push('MEC44');
    codes.push('MEC47');
    codes.push('MEC16');
    codes.push('MEC24');
    codes.push('MEC32');
    codes.push('MEC34');
    codes.push('MEC45');
    codes.push('MEC46');
    codes.push('FA01');
    codes.push('FA02');
    codes.push('FA03');

    return codes;
}

function checkForProductFilters() {
    //console.log('checkForProductFilters');
    
    var codes = getProductCodes(),
        code = '';

    for (var i = 0; i < codes.length; i++) {
        code = codes[i];

        var filterChecked = getLocal(code);
        
        if (filterChecked == null) {
            filterChecked = false;
        }

        $('#' + code).prop('checked', filterChecked);
    }

}

function clearProductCodes() {
    var codes = getProductCodes();
    for (var i = 0; i < codes.length; i++) {
        $('#' + codes[i]).prop('checked', false);
    }
}

$(document).ready(function () {

    //checkForProductFilters();

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

        clearProductCodes();
    });

    $('#Query').keypress(function (e) {
        if (e.which == 13) {
            $('form').submit();
            return false;
        }
    });

    $('#toggleProductFilters').click(function (e) {
        $('#productFiltersContainer').toggle();

        if ($('#productFiltersContainer').is(":visible")) {
            $('#toggleProductFilters').text('Hide Product Filters');
        } else {
            $('#toggleProductFilters').text('Show Product Filters');
        }
    });

    $('.search-select-checkbox').click(function (e) {

        if (e.currentTarget) {
            var value = e.currentTarget.checked;

            items = [];

            switch (e.currentTarget.id) {
                case 'MESOM':
                    items = [ 'MEC02', 'MEC03', 'MEC04', 'MEC05', 'MEC06', 'MEC07' ];
                    break;
                case "MEDWD":
                    items = [ 'MEC09', 'MEC10', 'MEC11', 'MEC12', 'MEC13', 'MEC14' ];
                    break;
                case "MEATS":
                    items = [ 'MEC18', 'MEC19', 'MEC20', 'MEC21', 'MEC22', 'MEC23' ];
                    break;
                case 'MERMK':
                    items = [ 'MEC26', 'MEC27', 'MEC28', 'MEC29', 'MEC30', 'MEC31' ];
                    break;
                case 'MEAAW':
                    items = [ 'MEC39', 'MEC40', 'MEC41', 'MEC42', 'MEC43', 'MEC44' ];
                    break;
                case 'MEDCH':
                    break;
                case 'MEHOB':
                    items = [ 'MEC16', 'MEC24' ];
                    break;
                case 'MELTR':
                    items = [ 'MEC32', 'MEC34', 'MEC45', 'MEC46' ];
                    break;
                case 'FADMS':
                    items = [ 'FA02', 'FA03' ];
                    break;
                default:
                    break;
            }

            //setLocal(e.currentTarget.id, value);

            if (items.length > 0) {
                for (var i = 0; i < items.length; i++) {
                    $('#' + items[i]).prop('checked', value);

                    //setLocal(items[i], value);                    
                    //Disabling child checkboxes hides them from search
                    //$('#' + items[i]).prop('disabled', value);
                }
            }
        }
    });
});