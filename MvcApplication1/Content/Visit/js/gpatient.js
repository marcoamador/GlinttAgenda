$(document).ready(function () {
    $('#sidebar').height($(document).height() - $("#calendarScroller").outerHeight());

    $('#plusBtn').click(function () {
        var v = $(window).height();
        if ($(window).height() == 0) {
            var v = $(document).height();
        }
        $('#sidebar').css({ "top": (v + $("#sidebar").outerHeight()), "display": "block" });
        $("#content").animate({ "top": -$("#content").outerHeight() });
        $("#calendarScroller").animate({ "bottom": v - $("#calendarScroller").outerHeight() });
        $("#plusBtn").animate({ "bottom": v + $("#plusBtn").outerHeight() });
        $('#sidebar').animate({ "top": "74pt" });

    });

    $('#calendarScroller').click(function () {
        //$('#sidebar').css({"top":($(document).height()+$("#sidebar").outerHeight())});
        var v = $(window).height();
        if ($(window).height() == 0) {
            var v = $(document).height();
        }
        $("#content").animate({ "top": 0 });
        $("#calendarScroller").animate({ "bottom": 0 });
        $('#sidebar').animate({ "top": (v + $("#sidebar").outerHeight()) }, function () {
            $('#sidebar').removeAttr("style");
            $("#content").removeAttr("style");
            $("#calendarScroller").removeAttr("style");
            $("#plusBtn").removeAttr("style");
        });
        $("#plusBtn").animate({ "bottom": "70pt" });
    });

});