function isNumber(evt) {
    var charCode = (evt.which) ? evt.which : evt.keyCode
    if (charCode > 31 && (charCode < 48 || charCode > 57))
        return false;
    return true;
}
function isDecimalNumber(evt) {
    var inpValue = $(this).val();
    if (!inpValue.match(/^[0-9]*([.,][0-9]+)?$/))
        return false;
    return true;
}
function isNoSpace(evt) {
    var charCode = (evt.which) ? evt.which : evt.keyCode
    if (charCode == 32)
        return false;
    return true;
}

function isPhone(evt) {
    var charCode = (evt.which) ? evt.which : evt.keyCode
    if (charCode > 31 && (charCode < 48 || charCode > 57) && charCode != 43)
        return false;
    return true;
}