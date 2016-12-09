$(window).scroll(function () {
    if ($("img.sequencer").hasClass('animation-finished')) {
        var imageOffset = $('img.sequencer').offset();

        imageOffset.top += 100;
        imageOffset.left = 0;

        $('#scroll-down-notification').hide();
        $('.panel-one').offset(imageOffset).show('slow');
        $('.header, .footer').show('fast');
    } else {
        $('.panel-one').hide('slow');
        $('.header, .footer').hide('fast');
        $('#scroll-down-notification').show();
    }
});