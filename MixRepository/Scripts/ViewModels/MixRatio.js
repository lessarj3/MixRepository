//function CalculateRatio in JavaScript, simplified by JQuery
//function CalculateRatio() {
//    var cfx = $('#CFX')[0].value;
//    $('#SVO')[0].value = cfx / 2;
//};
function MixRatio() {
    var cfx = $('#CFX')[0].value;
    var svo = $('#SVO')[0].value;
    $('#RATIO')[0].value = (((cfx * 786) / (svo * 270)).toFixed(0));
}