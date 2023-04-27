// navbar
const menu = document.querySelector(".nav-list");

const closeBtn = document.querySelector(".close-btn");

const menuBtn = document.querySelector(".menu-btn");

menuBtn.onclick = () => {
  menu.classList.add("active");
  menuBtn.classList.add("hide");
};
closeBtn.onclick = () => {
  menu.classList.remove("active");
  menuBtn.classList.remove("hide");
};

//banner
// var checkbox = document.querySelector(".glide");

// var glide = new Glide(".glide", {
//   hoverpause: checkbox.checked,
//   autoplay: 2000,
//   perView: 1,
// });

// checkbox.addEventListener("change", function () {
//   glide.update({
//     hoverpause: checkbox.checked,
//   });
// });

// glide.mount();
$(document).ready(function () {
  $(".glide__slides").slick({
    infinite: true,
    autoplay: true,
    prevArrow:
      "<button type='button' class='slick-arrow slick-prev pull-left'><i class='fa-solid fa-arrow-left'></i></button>",
    nextArrow:
      "<button type='button' class='slick-arrow slick-next pull-right'><i class='fa-solid fa-arrow-right'></i></button>",
    dots: true,
  });
});
//product
var glide = new Glide(".glide-product", {
  perView: 4,
  breakpoints: {
    1024: {
      perView: 4,
    },
    767: {
      perView: 2,
    },
    575: {
      perView: 1,
    },
  },
});

glide.mount();

//nghe nhan tra dao
var glide = new Glide(".glide__nghe-nhan", {
  perView: 5,
  breakpoints: {
    1024: {
      perView: 5,
    },
    767: {
      perView: 2,
    },
    575: {
      perView: 1,
    },
  },
});

glide.mount();

glide.mount();
// sp-lien-quan
var glide = new Glide(".glide_2", {
  perView: 4,
  breakpoints: {
    1024: {
      perView: 4,
    },
    767: {
      perView: 2,
    },
    575: {
      perView: 1,
    },
  },
});

glide.mount();
