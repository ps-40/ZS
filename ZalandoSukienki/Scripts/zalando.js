$(document).ready(function () {
    $('.dresses').after('to jest tekst z Scripts/zalando.js');
});
$(document).ready(function () {
    $(".dresses > li > div").click(function () {

        /*if (false == $(this).next().is(':visible')) {
            $('.dresses ul').slideUp(300);
        }*/
        $(this).next().slideToggle(300);
    });

    $('.dresses ul:eq(0)').show();
});