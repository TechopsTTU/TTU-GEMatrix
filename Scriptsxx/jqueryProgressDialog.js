$(document).ready(function () {

    Sys.WebForms.PageRequestManager.getInstance().add_beginRequest(showProgressDialog);
    Sys.WebForms.PageRequestManager.getInstance().add_endRequest(hideProgressDialog);
});
function showProgressDialog() {

    $("#progressDialog").dialog({
        autoOpen: false,
        modal: true,
        bgiframe: true
    });

    $('#progressDialog').dialog('open');

}

function hideProgressDialog() {

    if ($('#progressDialog').dialog('isOpen')) {

        $('#progressDialog').dialog('close');
    }
}

