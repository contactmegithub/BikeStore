
function arlo_tm_switcher() {

    "use strict";

    var switcherOpener = jQuery('.arlo_tm_resize');
    var switcherIcon = jQuery('.arlo_tm_leftpart_wrap .arlo_tm_resize i');
    var leftPart = jQuery('.arlo_tm_leftpart_wrap');
    var rightPart = jQuery('.arlo_tm_rightpart');

    switcherOpener.on('click', function () {
        if (switcherOpener.hasClass('opened')) {
            switcherOpener.removeClass('opened');
            switcherIcon.removeClass('opened');
            leftPart.removeClass('opened');
            rightPart.removeClass('opened');
        } else {
            switcherOpener.addClass('opened');
            switcherIcon.addClass('opened');
            leftPart.addClass('opened');
            rightPart.addClass('opened');
        }
        //setTimeout(function () { jQuery('#ripple').ripples('updateSize'); }, 101);
        //setTimeout(function () { jQuery('#ripple').ripples('updateSize'); }, 201);
        //setTimeout(function () { jQuery('#ripple').ripples('updateSize'); }, 301);

        if (jQuery('.jarallax').length) {
            jQuery('.jarallax').jarallax('destroy');
            setTimeout(function () { arlo_tm_jarallax(); }, 300);

        }
        return false;

    });


}