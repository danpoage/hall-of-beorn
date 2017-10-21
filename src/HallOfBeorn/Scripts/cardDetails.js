var slug = window.location.href.split('/').pop(),
    url = '/Cards/TopDecks?slug=' + slug;

window.addEventListener('DOMContentLoaded', function () {
    $.ajax({
        url: url,
        type: "get",
        success: function (results) {
            if (results && results.length > 0) {
                $('#deck-section').show();
                var listHtml = '';
                for (var i = 0; i < results.length; i++) {
                    listHtml += '<div><a title="' + results[i].name + '" href="' + results[i].url + '" target="_blank">' + results[i].name + '</a></div>';
                }
                $('#deck-list').html(listHtml);
            }
        }
    });
});