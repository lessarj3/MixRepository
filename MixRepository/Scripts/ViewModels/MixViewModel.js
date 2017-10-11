//    This function is called in Index.cshtml and auto populates the ratio field

//function CalculateRatio in JavaScript, simplified by JQuery
function CalculateRatio() {
    var cfx = $('#CFX')[0].value;
    $('#SVO')[0].value = cfx / 2;
};