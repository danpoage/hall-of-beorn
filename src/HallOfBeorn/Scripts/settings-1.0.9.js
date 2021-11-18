
$(function () {
    console.log('Settings Page Init');

    var expiration = 'expires=Fri, 1 Jan 2038 00:00:00 GMT;';

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

    var ringsDbUserCookie = getCookie('RingsDbUserId');
    if (ringsDbUserCookie) {
        console.log('RingsDB User ID Cookie Found: ' + ringsDbUserCookie);
        $('#RingsDbUserId').val(ringsDbUserCookie);
    }

    $('#RingsDbUserId').change(function () {
        var userId = $('#RingsDbUserId').val();
        console.log('RingsDB User ID entered: ' + userId);
        document.cookie = 'RingsDbUserId=' + userId + ';path:/;' + expiration;
    });

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
        document.cookie = 'SetSearch=SearchOffical;path:/;' + expiration;
    }

    $('#SearchOfficial').click(function () {
        console.log('Official Sets Only');
        document.cookie = 'SetSearch=SearchOffical;path:/;' + expiration;
    });
    $('#SearchAlep').click(function () {
        console.log('Official Sets and ALeP Sets');
        document.cookie = 'SetSearch=SearchAlep;path:/;' + expiration
    });
    $('#SearchFirstAge').click(function () {
        console.log('Official Sets and First Age Sets');
        document.cookie = 'SetSearch=SearchFirstAge;path:/;' + expiration;
    });
    $('#SearchCommunity').click(function () {
        console.log('Offical Sets and All Community Sets');
        document.cookie = 'SetSearch=SearchCommunity;path:/;' + expiration;
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
        document.cookie = 'DefaultSort=SortPopularity;path:/;' + expiration;
    }

    $('#SortPopularity').click(function () {
        console.log('Default Sort: Popularity');
        document.cookie = 'DefaultSort=SortPopularity;path:/;' + expiration;
    });
    $('#SortSetNumber').click(function () {
        console.log('Default Sort: SetNumber');
        document.cookie = 'DefaultSort=SortSetNumber;path:/;' + expiration;
    });
    $('#SortAlphabetical').click(function () {
        console.log('Default Sort: Alphabetical');
        document.cookie = 'DefaultSort=SortAlphabetical;path:/;' + expiration;
    });
    $('#SortSphereTypeCost').click(function () {
        console.log('Default Sort: Sphere, Type, Cost');
        document.cookie = 'DefaultSort=SortSphereTypeCost;path:/;' + expiration;
    });
    $('#SortReleased').click(function () {
        console.log('Offical Sets and All Community Sets');
        document.cookie = 'DefaultSort=SortReleased;path:/;' + expiration;
    });
    $('#SortStatScore').click(function () {
        console.log('Offical Sets and All Community Sets');
        document.cookie = 'DefaultSort=SortStatScore;path:/;' + expiration;
    });
    $('#SortStatEfficiency').click(function () {
        console.log('Offical Sets and All Community Sets');
        document.cookie = 'DefaultSort=SortStatEfficiency;path:/;' + expiration;
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
        document.cookie = 'DefaultLimit=Limit200;path:/;' + expiration;
    }

    $('#Limit200').click(function () {
        console.log('Default Limit: 200');
        document.cookie = 'DefaultLimit=Limit200;path:/;' + expiration;
    });
    $('#Limit400').click(function () {
        console.log('Default Limit: 400');
        document.cookie = 'DefaultLimit=Limit400;path:/;' + expiration;
    });
    $('#Limit600').click(function () {
        console.log('Default Limit: 600');
        document.cookie = 'DefaultLimit=Limit600;path:/;' + expiration;
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
        console.log('Product Filter Cookie Found: ' + productFilterCookie);
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
        document.cookie = 'ProductFilter=ProductAll;path:/;' + expiration;
        document.cookie = 'OwnedProducts=;path:/;' + expiration;
    }

    function checkOwnedProducts() {
        var productCodes = [
                'MEC01', 'MEC02', 'MEC03', 'MEC04', 'MEC05', 'MEC06', 'MEC07', 'MEC08', 'MEC09', 'MEC10',
                'MEC11', 'MEC12', 'MEC13', 'MEC14', 'MEC15', 'MEC16', 'MEC17', 'MEC18', 'MEC19', 'MEC20',
                'MEC21', 'MEC22', 'MEC23', 'MEC24', 'MEC25', 'MEC26', 'MEC27', 'MEC28', 'MEC29', 'MEC30',
                'MEC31', 'MEC32', 'MEC33', 'MEC34', 'MEC35', 'MEC36', 'MEC37', 'MEC38', 'MEC39', 'MEC40',
                'MEC41', 'MEC42', 'MEC43', 'MEC44', 'MEC45', 'MEC46', 'MEC47', 'MEC48', 'MEC49', 'MEC50',
                'MEC51', 'MEC52', 'MEC53', 'MEC54', 'MEC55', 'MEC56', 'MEC57', 'MEC58', 'MEC59', 'MEC60',
                'MEC61', 'MEC62', 'MEC65', 'MEC66', 'MEC67', 'MEC68', 'MEC69', 'MEC70',
                'MEC71', 'MEC73', 'MEC75', 'MEC77', 'MEC78', 'MEC79', 'MEC80',
                'MEC81', 'MEC82', 'MEC83', 'MEC86',
                'MEN01', 'MEN02', 'MEN03', 'MEN04', 'MEN05', 'MEN06', 'MEN07', 'MEN08', 'MEN09', 'MEN10',
                'MEN11', 'MEN12', 'MEN13', 'MEN14', 'MEN15', 'MEN16', 'MEN17', 'MEN18', 'MEN19', 'MEN20',
                'MEN21', 'MEN22', 'MEN23', 'MEN24', 'MEN25', 'MEN26', 'MEN27', 'MEN28', 'MEN29', 'MEN30',
                'MEN31', 'MEN32', 'MEN33', 'MEN34', 'MEN35', 'MEN36', 'MEN37', 'MEN38', 'MEN39', 'MEN40',
                'MEN41', 'MEN42', 'MEN43', 'MEN44', 'MEN45', 'MEN46', 'MEN47', 'MEN48', 'MEN49', 'MEN50',
                'OP014', 'OP015', 'OP016', 'OP050', 'OP075', 'OP077',
                'UMEC84', 'UMEC85',
                'MEC78-PRM', 'MEC79-PRM', 'MEC80-PRM', 'MEC81-PRM', 'MEC82-PRM', 'MEC83-PRM', 'UMEC84-PRM', 'UMEC85-PRM',
                'FA01', 'FA02', 'FA03', 'FA04', 'FA05',
                'ALEP01', 'ALEP02', 'ALEP03', 'ALEP08',
        ];

        var ownedProductsValue = '';

        productCodes.forEach(function (item, index) {

            if ($('#' + item).attr('checked')) {
                console.log('Product Marked Owned: ' + item);
                if (ownedProductsValue) {
                    ownedProductsValue += ',';
                }

                ownedProductsValue += item;
            }
        });

        console.log('Settings Owned Products: ' + ownedProductsValue);
        document.cookie = 'OwnedProducts=' + ownedProductsValue + ';path:/;' + expiration;
    };

    $('#ProductAll').click(function () {
        console.log('Product Filter: All Products');
        document.cookie = 'ProductFilter=ProductAll;path:/;' + expiration;
        checkOwnedProducts();
    });
    $('#ProductSpecific').click(function () {
        console.log('Product Filter: Specific Products');
        document.cookie = 'ProductFilter=ProductSpecific;path:/;' + expiration;
        checkOwnedProducts();
    });

    var ownedProductsCookie = getCookie('OwnedProducts');
    if (ownedProductsCookie) {
        console.log('Owned Products: ' + ownedProductsCookie);
        $('#' + ownedProductsCookie).prop('checked', true);

        if (productFilterCookie == 'ProductSpecific') {
            $('.owned-product').prop('checked', false);

            var checkedCodes = ownedProductsCookie.split(',');
            for (var i = 0; i < checkedCodes.length; i++) {
                console.log('Owned Product from Cookie:' + checkedCodes[i]);
                $('#' + checkedCodes[i]).prop('checked', true);
            }
        }
    }

    $('.owned-product').click(function () {
        console.log('owned product clicked');
        checkOwnedProducts();
    });
});
