$(document).ready(function () {
    $('#resetButton').click(function () {
        $('#Sort').val('Any');
        $('#View').val('Any');
        $('#Query').focus().val('');
    });
});
