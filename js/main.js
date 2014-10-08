/*
    -------------
  > Main script <
    -------------
 */

var navSmall = function() {
  $(document).on("scroll", function() {
    if($(document).scrollTop() > 10) {
        $(".navbar").addClass("navbar-small");
        $(".icon-menu").addClass("icon-menu-small");
    } else{
        $(".navbar").removeClass("navbar-small");
        $(".icon-menu").removeClass("icon-menu-small");
    }
  });
};

$(document).ready(navSmall);
