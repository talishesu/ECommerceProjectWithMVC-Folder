// Header
window.onscroll = function () {
  scrollFunction();
};
const navbar = document.getElementById("navbar");
const searchIcon = document.getElementsByClassName("search-icon");
const searchForm = document.getElementsByClassName("search-form");
const searchCloseIcon = document.getElementsByClassName("search-close-icon");
const searchInput = document.getElementsByClassName("search-input");

function scrollFunction() {
  if (document.body.scrollTop > 70 || document.documentElement.scrollTop > 70) {
    navbar.classList.add("navbar-change");
    navbar.classList.add("shadow-lg");
    // navbar.classList.add("rounded-pill");
  } else {
    navbar.classList.remove("navbar-change");
    navbar.classList.remove("shadow-lg");
    // navbar.classList.remove("rounded-pill");
  }
}
function topFunction() {
  document.body.scrollTop = 0;
  document.documentElement.scrollTop = 0;
}

$(searchIcon).on("click", function () {
  $(searchIcon).addClass("d-none");
  $(searchForm).removeClass("d-none");
  $(searchInput).focus();
});
$(searchCloseIcon).on("click", function () {
  $(searchIcon).removeClass("d-none");
  $(searchForm).addClass("d-none");
});

$(searchInput).on("focusout", function () {
  $(searchIcon).removeClass("d-none");
  $(searchForm).addClass("d-none");
});

// Scroll Up
var btn = $("#button");

$(window).scroll(function () {
  if ($(window).scrollTop() > 300) {
    btn.addClass("show");
  } else {
    btn.removeClass("show");
  }
});

btn.on("click", function (e) {
  e.preventDefault();
  $("html, body").animate({ scrollTop: 0 }, "300");
});

// Filter
$(document).ready(function () {
  $(".no-results").hide();

  $("select.w-filter-by").change(function () {
    let filters = $.map($("select.w-filter-by").toArray(), function (e) {
      return $(e).val();
    }).join(".");
    $(".w-results").find("li").hide();
    let results = $(".w-results").find("li." + filters);
    console.log(filters);
    if (results.length) {
      results.show();
      $(".no-results").hide();
    } else {
      $(".no-results").show();
    }
  });
});
// product detail
$(document).ready(function () {
  var slider = $("#slider");
  var thumb = $("#thumb");
  var slidesPerPage = 4; //globaly define number of elements per page
  var syncedSecondary = true;
  slider
    .owlCarousel({
      items: 1,
      slideSpeed: 2000,
      nav: false,
      autoplay: false,
      dots: false,
      loop: true,
      responsiveRefreshRate: 200,
    })
    .on("changed.owl.carousel", syncPosition);
  thumb
    .on("initialized.owl.carousel", function () {
      thumb.find(".owl-item").eq(0).addClass("current");
    })
    .owlCarousel({
      items: slidesPerPage,
      dots: false,
      nav: true,
      item: 4,
      smartSpeed: 200,
      slideSpeed: 500,
      slideBy: slidesPerPage,
      navText: [
        '<svg width="18px" height="18px" viewBox="0 0 11 20"><path style="fill:none;stroke-width: 1px;stroke: #000;" d="M9.554,1.001l-8.607,8.607l8.607,8.606"/></svg>',
        '<svg width="25px" height="25px" viewBox="0 0 11 20" version="1.1"><path style="fill:none;stroke-width: 1px;stroke: #000;" d="M1.054,18.214l8.606,-8.606l-8.606,-8.607"/></svg>',
      ],
      responsiveRefreshRate: 100,
    })
    .on("changed.owl.carousel", syncPosition2);
  function syncPosition(el) {
    var count = el.item.count - 1;
    var current = Math.round(el.item.index - el.item.count / 2 - 0.5);
    if (current < 0) {
      current = count;
    }
    if (current > count) {
      current = 0;
    }
    thumb
      .find(".owl-item")
      .removeClass("current")
      .eq(current)
      .addClass("current");
    var onscreen = thumb.find(".owl-item.active").length - 1;
    var start = thumb.find(".owl-item.active").first().index();
    var end = thumb.find(".owl-item.active").last().index();
    if (current > end) {
      thumb.data("owl.carousel").to(current, 100, true);
    }
    if (current < start) {
      thumb.data("owl.carousel").to(current - onscreen, 100, true);
    }
  }
  function syncPosition2(el) {
    if (syncedSecondary) {
      var number = el.item.index;
      slider.data("owl.carousel").to(number, 100, true);
    }
  }
  thumb.on("click", ".owl-item", function (e) {
    e.preventDefault();
    var number = $(this).index();
    slider.data("owl.carousel").to(number, 300, true);
  });

  $(".qtyminus").on("click", function () {
    var now = $(".qty").val();
    if ($.isNumeric(now)) {
      if (parseInt(now) - 1 > 0) {
        now--;
      }
      $(".qty").val(now);
    }
  });
  $(".qtyplus").on("click", function () {
    var now = $(".qty").val();
    if ($.isNumeric(now)) {
      $(".qty").val(parseInt(now) + 1);
    }
  });
});
// card
$(".minus-btn-card").on("click", function (e) {
  e.preventDefault();
  var $this = $(this);
  var $input = $this.closest("div").find("input");
  var value = parseInt($input.val());

  if (value > 1) {
    value = value - 1;
  } else {
    value = 0;
  }

  $input.val(value);
});

$(".plus-btn-card").on("click", function (e) {
  e.preventDefault();
  var $this = $(this);
  var $input = $this.closest("div").find("input");
  var value = parseInt($input.val());

  if (value < 100) {
    value = value + 1;
  } else {
    value = 100;
  }

  $input.val(value);
});

$(".like-btn-card").on("click", function () {
  $(this).toggleClass("is-active");
});
// login sigup
$(document).ready(function () {
  $("#signup_btn").click(function () {
    $("#main").animate({ left: "22.5%" }, 400);
    $("#main").animate({ left: "30%" }, 500);
    $("#loginform").css("visibility", "hidden");
    $("#loginform").animate({ left: "25%" }, 400);

    $("#signupform").animate({ left: "17%" }, 400);
    $("#signupform").animate({ left: "30%" }, 500);
    $("#signupform").css("visibility", "visible");
  });

  $("#login_btn").click(function () {
    $("#main").animate({ left: "77.5%" }, 400);
    $("#main").animate({ left: "70%" }, 500);
    $("#signupform").css("visibility", "hidden");
    $("#signupform").animate({ left: "75%" }, 400);

    $("#loginform").animate({ left: "83.5%" }, 400);
    $("#loginform").animate({ left: "70%" }, 500);
    $("#loginform").css("visibility", "visible");
  });
});
