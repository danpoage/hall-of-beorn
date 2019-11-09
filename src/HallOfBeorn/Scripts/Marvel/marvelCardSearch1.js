$(document).ready(function () {

    $('#resetButton').click(function () {
        $('#Sort').val('Any');
        $('#View').val('Any');
        $('#Query').focus().val('');

        $('#Product').val('Any');
        
        $('#CardType').val('Any');
        $('#DeckType').val('Any');
        $('#IsUnique').val('Any');

        $('#Trait').val('Any');
        $('#Keyword').val('Any');
        
        $('#ThwartOp').val('=');
        $('#Thwart').val('Any');
        $('#AttackOp').val('=');
        $('#Attack').val('Any');
        $('#DefenseOp').val('=');
        $('#Defense').val('Any');
        $('#RecoverOp').val('=');
        $('#Recover').val('Any');

        $('#HitPointsOp').val('=');
        $('#HitPoints').val('Any');
        $('#HandSizeOp').val('=');
        $('#HandSize').val('Any');
        //$('#CostOp').val('=');
        //$('#Cost').val('Any');
    });

});