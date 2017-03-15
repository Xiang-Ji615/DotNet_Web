$(document).ready(function () {

    $("#tbUsername, #tbPassword").on('keydown', function(e){
        if (e.which == 13) {
            //stop submit the form, we will post it manually.
            //alert("Form submit");
            $("#FormSearch").submit();
        }
    });

});