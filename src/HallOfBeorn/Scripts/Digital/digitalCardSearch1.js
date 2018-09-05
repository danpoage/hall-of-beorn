$(document).ready(function () {
    $('#resetButton').click(function () {
        $('#Sort').val('Any');
        $('#View').val('Any');
        $('#Query').focus().val('');
        $('#CardSet').val('Any');
        $('#CardType').val('Any');
        $('#Sphere').val('Any');
        $('#Trait').val('Any');
        $('#Keyword').val('Any');
        $('#Slot').val('Any');
        $('#Cost').val('Any');
        $('#ThreatCost').val('Any');
        $('#Rarity').val('Any');
        $('#Attack').val('Any');
        $('#Willpower').val('Any');
        $('#HitPoints').val('Any');
    });
});
