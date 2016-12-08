$(window).scroll(function () {
    if ($("img.sequencer").hasClass('animation-finished')) {
        var imageOffset = $('img.sequencer').offset();

        imageOffset.top += 100;
        imageOffset.left = 0;

        $('.panel-one').offset(imageOffset).show('slow');
    } else {
        $('.panel-one').hide('slow');
    }
});