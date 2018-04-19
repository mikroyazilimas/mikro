// Function which adds the 'animated' class to any '.animatable' in view
var doAnimations = function() {
    // Calc current offset and get all animatables
    var offset = $(window).scrollTop() + $(window).height();
    var $animatables = $('.animatable');
    // Unbind scroll handler if we have no animatables
    if ($animatables.size() == 0) {
        $(window).off('scroll', doAnimations);
    }
    // Check all animatables and animate them if necessary
    $animatables.each(function(i) {
        var $animatable = $(this);
        if (($animatable.offset().top + $animatable.height() - 20) < offset) {
            $animatable.removeClass('animatable').addClass('animated');
        }
    });
};

var stickySidebar = function(element, stopper){
    console.log( "document ready!" );

  var $sticky = $(element);
  var $stickyrStopper = $(stopper);
  if (!!$sticky.offset()) { // make sure ".sticky" element exists

    var generalSidebarHeight = $sticky.innerHeight();
    var stickyTop = $sticky.offset().top;
    var stickOffset = 100;
    var stickyStopperPosition = $stickyrStopper.offset().top;
    var stopPoint = stickyStopperPosition - generalSidebarHeight - stickOffset;
    var diff = stopPoint + stickOffset;

    $(window).scroll(function(){ // scroll event
      var windowTop = $(window).scrollTop(); // returns number

      if (stopPoint < windowTop) {
          $sticky.css({ top: diff  });
      } else if (stickyTop < windowTop+stickOffset) {
          $sticky.css({ position: 'fixed', top: stickOffset  });
      } else {
          $sticky.css({top: 'initial', position: 'absolute'});
      }
    });

  }
}

$(function() {
    $('[data-number-animate]').each(
        function() {
            $(this).animateNumber({
                number: $(this).attr('data-number'),
                easing: 'easeInQuad'
            }, 3000);
        }
    );

    // setTimeout(function () {
    //     $('[data-number-animate]').each(
    //         function () {
    //             var animationEnd = 'webkitAnimationEnd mozAnimationEnd MSAnimationEnd oanimationend animationend';
    //             var animationName = 'pulse';
    //             $(this).addClass('animated ' + animationName).one(animationEnd, function () {
    //                 $(this).removeClass('animated ' + animationName);
    //             });
    //         });
    // }, 3000);

    /*$('.mega-navigation').click(function() {
        $('.page-open-menu').toggleClass('actived');
        $('.navigation-background').fadeToggle("slow");
    }); */

    $('.page-header-navigation-item__menu').click(function() {
        $('.page-mega-navigation').toggleClass('active');
        $('.open').toggle('slow');
        $('.close').toggle('slow');
    });

    // Hook doAnimations on scroll, and trigger a scroll
    // $(window).on('scroll', doAnimations);
    // $(window).trigger('scroll');

    

    // $(window).scroll(function() {
    //     doAnimations();
    //     var sticky = $('.page-header, .page-open-menu');
    //     var scroll = $(window).scrollTop();
    //     if (scroll >= 1) { sticky.addClass('fixed'); } else { sticky.removeClass('fixed'); }
    // });

    $('.herobanner-owl-carousel').owlCarousel({
        loop: true,
        margin: 0,
        nav: true,
        items: 1,
        autoplay:true,
        autoplayTimeout:5000,
        autoplayHoverPause:false
    });

    $('.modules-owl-carousel').owlCarousel({
        loop: false,
        margin: 0,
        nav: true,
        items: 5,
    });


    //$('.wizard-form-row__select').select2();
    //$('.wizard-bottom-left-content-form-row__select').select2();

    $('.story-group').click(function() {
        $(this).toggleClass('active');
        $(this).next('.story-company').slideToggle('slow');
    });


    // $('.wizard-bottom-left-content-form-row-text').click(function() {
    //     $(".wizard-bottom-left-content-form-row-text__hide").slideToggle('slow');
    // });

    /* Click'lendiğinde seçili hale gelmesi
    $('.container-sub-content-item').click(function() {
        $(this).toggleClass('press-room-select-item');
    });*/

    
    //experience-combobox text degisimi
    $( '.responsive-business-left__title2__text > span' ).click(function() {
        var text = $( this ).text();
        $( '.responsive-business-left__title2__show > span' ).text( text );
    });


        $('.page-mega-navigation-content-section__maintitle').click(function(){
            $('.page-mega-navigation-content-section__subtitle').hide();
            $(this).nextAll('.page-mega-navigation-content-section__subtitle').hide();
        })

    //Contact-telefon son 2 hane
    $('.phone-hide').click(function(){
        $('.phone-hide').text("+90 (850) 225 10 10 (Çağrı Merkezi)");
    });

    $('.page-section-business-left__title2__text > span').click(function(){
        $('.page-section-business-left__title2__text > span').removeClass('products-select-tabs');
        $('.page-section-business-left__text').text($(this).data('text'));
        $('.page-section-business-left__button__detail').attr('href', $(this).data('link'));
        $(this).addClass('products-select-tabs');
    });


    //Demo-request-open
   $('.page-section-demo-request-button__demo').click(function(){
       $('.page-section-demo-request').slideToggle('slow');
        $('.page-section-demo-request-open').slideToggle('slow');
   });

   $('.svg-hide').click(function(){
        $('.page-section-demo-request').slideToggle('slow');
        $('.page-section-demo-request-open').slideToggle('slow');
   });

   $('.page-section-demo-request-open-left__p').click(function(){
       $('.page-section-demo-request-open-left__p-hide').ToggleClass('show-p');
   });

   $('.wizard-bottom-left-content-form-row-text').click(function(){
        
    $('.wizard-bottom-left-content-form-row-text__hide').fadeToggle();
   });


    $(".homepage-new-product-item").hover(
        function() {
      $(this).animate({
        marginLeft: 0,
      }, 500, function() {
        $(this).find('.homepage-new-product-item-link').fadeIn();
      });
      $('.homepage-new-product-right-wrapper > img').attr('src', $(this).data('image'))
    },function() {
       $(this).animate({
        marginLeft: -220,
      }, 500, function() {
        $(this).find('.homepage-new-product-item-link').fadeOut();
      });
    });


   // stickySidebar('.sticky-one', '.sticky-stopper-one')
   stickySidebar('.sticky-two', '.sticky-stopper-two')
   stickySidebar('.sticky-three', '.sticky-stopper-three')
   stickySidebar('.sticky-four', '.sticky-stopper-four')


$(window).scroll(function() {
        var scrollTop = $(window).scrollTop()
        var divOffset = parseInt($('.animatable').offset().top / 2)
        if(divOffset <= scrollTop) {
            $('.animatable').addClass('animated');
        }
        console.log(divOffset + ' - ' + scrollTop)
    });

$('.products-container-content-right-item__title').click(function(){
  $('.products-container-content-right-item__title').removeClass('active');
  $('.products-container-content-right-item__text').hide();
  $(this).addClass('active');
  $(this).next('.products-container-content-right-item__text').fadeIn();
});

});

