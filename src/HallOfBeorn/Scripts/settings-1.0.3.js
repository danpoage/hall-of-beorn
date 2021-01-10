
$(function () {
    console.log('Settings Page Init');

    console.log('checking for settings cookie');

    function getCookie(cname) {

        if (!document.cookie) {
            return "";
        }

        var name = cname + "=";
        var ca = document.cookie.split(';');
        for (var i = 0; i < ca.length; i++) {
            var c = ca[i];
            while (c.charAt(0) == ' ') {
                c = c.substring(1);
            }
            if (c.indexOf(name) == 0) {
                return c.substring(name.length, c.length);
            }
        }
        return "";
    };

    var setSearchCookie = getCookie('SetSearch');
    if (setSearchCookie) {
        console.log('Set Search Cookie Found: ' + setSearchCookie);
        $('#' + setSearchCookie).prop('checked', true);
    }

    var initSetSearch = true;
    var searchIds = ['SearchOfficial', 'SearchAlep', 'SearchFirstAge', 'SearchCommunity'];
    searchIds.forEach(function (item, index) {
        if ($('#' + item).prop('checked')) {
            initSetSearch = false;
            console.log(item + ' set search is selected');
        }
    });

    if (initSetSearch) {
        console.log('Default Search to Offical Sets Only');
        $('#SearchOfficial').prop('checked', true);
        document.cookie = 'SetSearch=SearchOffical;path:/';
    }

    $('#SearchOfficial').click(function () {
        console.log('Official Sets Only');
        document.cookie = 'SetSearch=SearchOffical;path:/';
    });
    $('#SearchAlep').click(function () {
        console.log('Official Sets and ALeP Sets');
        document.cookie = 'SetSearch=SearchAlep;path:/';
    });
    $('#SearchFirstAge').click(function () {
        console.log('Official Sets and First Age Sets');
        document.cookie = 'SetSearch=SearchFirstAge;path:/';
    });
    $('#SearchCommunity').click(function () {
        console.log('Offical Sets and All Community Sets');
        document.cookie = 'SetSearch=SearchCommunity;path:/';
    });

    var defaultSortCookie = getCookie('DefaultSort');
    if (defaultSortCookie) {
        console.log('Default Sort Cookie Found: ' + defaultSortCookie);
        $('#' + defaultSortCookie).prop('checked', true);
    }

    var initDefaultSort = true;
    var sortIds = ['SortPopularity', 'SortSetNumber', 'SortAlphabetical', 'SortSphereTypeCost',
    'SortReleased', 'SortStatScore', 'SortStatEfficiency'];
    sortIds.forEach(function (item, index) {
        if ($('#' + item).prop('checked')) {
            initDefaultSort = false;
            console.log(item + ' default sort is selected');
        }
    });

    if (initDefaultSort) {
        console.log('Default Sort to Popularity');
        $('#SortPopularity').prop('checked', true);
        document.cookie = 'DefaultSort=SortPopularity;path:/';
    }

    $('#SortPopularity').click(function () {
        console.log('Default Sort: Popularity');
        document.cookie = 'DefaultSort=SortPopularity;path:/';
    });
    $('#SortSetNumber').click(function () {
        console.log('Default Sort: SetNumber');
        document.cookie = 'DefaultSort=SortSetNumber;path:/';
    });
    $('#SortAlphabetical').click(function () {
        console.log('Default Sort: Alphabetical');
        document.cookie = 'DefaultSort=SortAlphabetical;path:/';
    });
    $('#SortSphereTypeCost').click(function () {
        console.log('Default Sort: Sphere, Type, Cost');
        document.cookie = 'DefaultSort=SortSphereTypeCost;path:/';
    });
    $('#SortReleased').click(function () {
        console.log('Offical Sets and All Community Sets');
        document.cookie = 'DefaultSort=SortReleased;path:/';
    });
    $('#SortStatScore').click(function () {
        console.log('Offical Sets and All Community Sets');
        document.cookie = 'DefaultSort=SortStatScore;path:/';
    });
    $('#SortStatEfficiency').click(function () {
        console.log('Offical Sets and All Community Sets');
        document.cookie = 'DefaultSort=SortStatEfficiency;path:/';
    });

    var defaultLimitCookie = getCookie('DefaultLimit');
    if (defaultLimitCookie) {
        console.log('Default Limit Cookie Found: ' + defaultLimitCookie);
        $('#' + defaultLimitCookie).prop('checked', true);
    }

    var initDefaultLimit = true;
    var limitIds = ['Limit200', 'Limit400', 'Limit600'];
    limitIds.forEach(function (item, index) {
        if ($('#' + item).prop('checked')) {
            initDefaultLimit = false;
            console.log(item + ' default limit is selected');
        }
    });

    if (initDefaultLimit) {
        console.log('init Default Limit: 200');
        $('#Limit200').prop('checked', true);
        document.cookie = 'DefaultLimit=Limit200;path:/';
    }

    $('#Limit200').click(function () {
        console.log('Default Limit: 200');
        document.cookie = 'DefaultLimit=Limit200;path:/';
    });
    $('#Limit400').click(function () {
        console.log('Default Limit: 400');
        document.cookie = 'DefaultLimit=Limit400;path:/';
    });
    $('#Limit600').click(function () {
        console.log('Default Limit: 600');
        document.cookie = 'DefaultLimit=Limit600;path:/';
    });

    $('#ProductAll').click(function () {
        console.log('hiding product filters');
        $('#ProductFilterContainer').toggle();
    });
    $('#ProductSpecific').click(function () {
        console.log('showing product filters');
        $('#ProductFilterContainer').toggle();
    });

    var productFilterCookie = getCookie('ProductFilter');
    if (productFilterCookie) {
        console.log('Product Filter Cookie Found: ' + defaultLimitCookie);
        $('#' + productFilterCookie).prop('checked', true);

        if (productFilterCookie == 'ProductSpecific') {
            $('#ProductFilterContainer').toggle();
        }
    }

    var initProductFilter = true;
    var productFilterIds = ['ProductAll', 'ProductSpecific'];
    productFilterIds.forEach(function (item, index) {
        if ($('#' + item).prop('checked')) {
            initProductFilter = false;
            console.log(item + ' product filter is selected');
        }
    });

    if (initProductFilter) {
        console.log('init Product Filter: All Products');
        $('#ProductAll').prop('checked', true);
        document.cookie = 'ProductFilter=ProductAll;path:/';
    }

    $('#ProductAll').click(function () {
        console.log('Product Filter: All Products');
        document.cookie = 'ProductFilter=ProductAll;path:/';
    });
    $('#ProductSpecific').click(function () {
        console.log('Product Filter: Specific Products');
        document.cookie = 'ProductFilter=ProductSpecific;path:/';
    });
});
