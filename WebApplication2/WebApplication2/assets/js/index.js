$(document).ready(function () {
  $(".app__slider").slick({
    infinite: true,
    autoplay: true,
    prevArrow:
      "<button type='button' class='slick-arrow slick-prev pull-left'><i class='fa-solid fa-arrow-left'></i></button>",
    nextArrow:
      "<button type='button' class='slick-arrow slick-next pull-right'><i class='fa-solid fa-arrow-right'></i></button>",
    dots: true,
  });
});
$(document).ready(function () {
  $(".special-product__slider").slick({
    infinite: true,
    autoplay: true,
    slidesToShow: 4,
    prevArrow:
      "<button type='button' class='slick-arrow slick-prev pull-left'><i class='fa-solid fa-arrow-left'></i></button>",
    nextArrow:
      "<button type='button' class='slick-arrow slick-next pull-right'><i class='fa-solid fa-arrow-right'></i></button>",
    dots: true,
  });
});
