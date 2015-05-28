$(document).ready(function() {
$(".lead").mouseenter(function() {
$(".lead").animate({
"font-size": "2em"
}, 1000);
});

$(".lead").mouseleave(function() {
$(".lead").animate({
"font-size": "1.5em"
}, 1000);
});

});