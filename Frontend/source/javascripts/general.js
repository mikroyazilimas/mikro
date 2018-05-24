

// jQuery Mask Plugin v1.14.15
// github.com/igorescobar/jQuery-Mask-Plugin
var $jscomp = { scope: {}, findInternal: function (a, l, d) { a instanceof String && (a = String(a)); for (var p = a.length, h = 0; h < p; h++) { var b = a[h]; if (l.call(d, b, h, a)) return { i: h, v: b } } return { i: -1, v: void 0 } } }; $jscomp.defineProperty = "function" == typeof Object.defineProperties ? Object.defineProperty : function (a, l, d) { if (d.get || d.set) throw new TypeError("ES3 does not support getters and setters."); a != Array.prototype && a != Object.prototype && (a[l] = d.value) };
$jscomp.getGlobal = function (a) { return "undefined" != typeof window && window === a ? a : "undefined" != typeof global && null != global ? global : a }; $jscomp.global = $jscomp.getGlobal(this); $jscomp.polyfill = function (a, l, d, p) { if (l) { d = $jscomp.global; a = a.split("."); for (p = 0; p < a.length - 1; p++) { var h = a[p]; h in d || (d[h] = {}); d = d[h] } a = a[a.length - 1]; p = d[a]; l = l(p); l != p && null != l && $jscomp.defineProperty(d, a, { configurable: !0, writable: !0, value: l }) } };
$jscomp.polyfill("Array.prototype.find", function (a) { return a ? a : function (a, d) { return $jscomp.findInternal(this, a, d).v } }, "es6-impl", "es3");
(function (a, l, d) { "function" === typeof define && define.amd ? define(["jquery"], a) : "object" === typeof exports ? module.exports = a(require("jquery")) : a(l || d) })(function (a) {
    var l = function (b, e, f) {
        var c = {
            invalid: [], getCaret: function () { try { var a, r = 0, g = b.get(0), e = document.selection, f = g.selectionStart; if (e && -1 === navigator.appVersion.indexOf("MSIE 10")) a = e.createRange(), a.moveStart("character", -c.val().length), r = a.text.length; else if (f || "0" === f) r = f; return r } catch (C) { } }, setCaret: function (a) {
                try {
                    if (b.is(":focus")) {
                        var c,
                            g = b.get(0); g.setSelectionRange ? g.setSelectionRange(a, a) : (c = g.createTextRange(), c.collapse(!0), c.moveEnd("character", a), c.moveStart("character", a), c.select())
                    }
                } catch (B) { }
            }, events: function () {
                b.on("keydown.mask", function (a) { b.data("mask-keycode", a.keyCode || a.which); b.data("mask-previus-value", b.val()); b.data("mask-previus-caret-pos", c.getCaret()); c.maskDigitPosMapOld = c.maskDigitPosMap }).on(a.jMaskGlobals.useInput ? "input.mask" : "keyup.mask", c.behaviour).on("paste.mask drop.mask", function () {
                    setTimeout(function () { b.keydown().keyup() },
                        100)
                }).on("change.mask", function () { b.data("changed", !0) }).on("blur.mask", function () { d === c.val() || b.data("changed") || b.trigger("change"); b.data("changed", !1) }).on("blur.mask", function () { d = c.val() }).on("focus.mask", function (b) { !0 === f.selectOnFocus && a(b.target).select() }).on("focusout.mask", function () { f.clearIfNotMatch && !h.test(c.val()) && c.val("") })
            }, getRegexMask: function () {
                for (var a = [], b, c, f, n, d = 0; d < e.length; d++)(b = m.translation[e.charAt(d)]) ? (c = b.pattern.toString().replace(/.{1}$|^.{1}/g, ""), f = b.optional,
                    (b = b.recursive) ? (a.push(e.charAt(d)), n = { digit: e.charAt(d), pattern: c }) : a.push(f || b ? c + "?" : c)) : a.push(e.charAt(d).replace(/[-\/\\^$*+?.()|[\]{}]/g, "\\$&")); a = a.join(""); n && (a = a.replace(new RegExp("(" + n.digit + "(.*" + n.digit + ")?)"), "($1)?").replace(new RegExp(n.digit, "g"), n.pattern)); return new RegExp(a)
            }, destroyEvents: function () { b.off("input keydown keyup paste drop blur focusout ".split(" ").join(".mask ")) }, val: function (a) {
                var c = b.is("input") ? "val" : "text"; if (0 < arguments.length) {
                    if (b[c]() !== a) b[c](a);
                    c = b
                } else c = b[c](); return c
            }, calculateCaretPosition: function () {
                var a = b.data("mask-previus-value") || "", e = c.getMasked(), g = c.getCaret(); if (a !== e) {
                    var f = b.data("mask-previus-caret-pos") || 0, e = e.length, d = a.length, m = a = 0, h = 0, l = 0, k; for (k = g; k < e && c.maskDigitPosMap[k]; k++)m++; for (k = g - 1; 0 <= k && c.maskDigitPosMap[k]; k--)a++; for (k = g - 1; 0 <= k; k--)c.maskDigitPosMap[k] && h++; for (k = f - 1; 0 <= k; k--)c.maskDigitPosMapOld[k] && l++; g > d ? g = 10 * e : f >= g && f !== d ? c.maskDigitPosMapOld[g] || (f = g, g = g - (l - h) - a, c.maskDigitPosMap[g] && (g = f)) : g > f &&
                        (g = g + (h - l) + m)
                } return g
            }, behaviour: function (f) { f = f || window.event; c.invalid = []; var e = b.data("mask-keycode"); if (-1 === a.inArray(e, m.byPassKeys)) { var e = c.getMasked(), g = c.getCaret(); setTimeout(function () { c.setCaret(c.calculateCaretPosition()) }, a.jMaskGlobals.keyStrokeCompensation); c.val(e); c.setCaret(g); return c.callbacks(f) } }, getMasked: function (a, b) {
                var g = [], d = void 0 === b ? c.val() : b + "", n = 0, h = e.length, q = 0, l = d.length, k = 1, r = "push", p = -1, t = 0, y = [], v, z; f.reverse ? (r = "unshift", k = -1, v = 0, n = h - 1, q = l - 1, z = function () {
                    return -1 <
                        n && -1 < q
                }) : (v = h - 1, z = function () { return n < h && q < l }); for (var A; z();) { var x = e.charAt(n), w = d.charAt(q), u = m.translation[x]; if (u) w.match(u.pattern) ? (g[r](w), u.recursive && (-1 === p ? p = n : n === v && n !== p && (n = p - k), v === p && (n -= k)), n += k) : w === A ? (t-- , A = void 0) : u.optional ? (n += k, q -= k) : u.fallback ? (g[r](u.fallback), n += k, q -= k) : c.invalid.push({ p: q, v: w, e: u.pattern }), q += k; else { if (!a) g[r](x); w === x ? (y.push(q), q += k) : (A = x, y.push(q + t), t++); n += k } } d = e.charAt(v); h !== l + 1 || m.translation[d] || g.push(d); g = g.join(""); c.mapMaskdigitPositions(g,
                    y, l); return g
            }, mapMaskdigitPositions: function (a, b, e) { a = f.reverse ? a.length - e : 0; c.maskDigitPosMap = {}; for (e = 0; e < b.length; e++)c.maskDigitPosMap[b[e] + a] = 1 }, callbacks: function (a) { var h = c.val(), g = h !== d, m = [h, a, b, f], q = function (a, b, c) { "function" === typeof f[a] && b && f[a].apply(this, c) }; q("onChange", !0 === g, m); q("onKeyPress", !0 === g, m); q("onComplete", h.length === e.length, m); q("onInvalid", 0 < c.invalid.length, [h, a, b, c.invalid, f]) }
        }; b = a(b); var m = this, d = c.val(), h; e = "function" === typeof e ? e(c.val(), void 0, b, f) : e; m.mask =
            e; m.options = f; m.remove = function () { var a = c.getCaret(); m.options.placeholder && b.removeAttr("placeholder"); b.data("mask-maxlength") && b.removeAttr("maxlength"); c.destroyEvents(); c.val(m.getCleanVal()); c.setCaret(a); return b }; m.getCleanVal = function () { return c.getMasked(!0) }; m.getMaskedVal = function (a) { return c.getMasked(!1, a) }; m.init = function (d) {
                d = d || !1; f = f || {}; m.clearIfNotMatch = a.jMaskGlobals.clearIfNotMatch; m.byPassKeys = a.jMaskGlobals.byPassKeys; m.translation = a.extend({}, a.jMaskGlobals.translation, f.translation);
                m = a.extend(!0, {}, m, f); h = c.getRegexMask(); if (d) c.events(), c.val(c.getMasked()); else { f.placeholder && b.attr("placeholder", f.placeholder); b.data("mask") && b.attr("autocomplete", "off"); d = 0; for (var l = !0; d < e.length; d++) { var g = m.translation[e.charAt(d)]; if (g && g.recursive) { l = !1; break } } l && b.attr("maxlength", e.length).data("mask-maxlength", !0); c.destroyEvents(); c.events(); d = c.getCaret(); c.val(c.getMasked()); c.setCaret(d) }
            }; m.init(!b.is("input"))
    }; a.maskWatchers = {}; var d = function () {
        var b = a(this), e = {}, f = b.attr("data-mask");
        b.attr("data-mask-reverse") && (e.reverse = !0); b.attr("data-mask-clearifnotmatch") && (e.clearIfNotMatch = !0); "true" === b.attr("data-mask-selectonfocus") && (e.selectOnFocus = !0); if (p(b, f, e)) return b.data("mask", new l(this, f, e))
    }, p = function (b, e, f) { f = f || {}; var c = a(b).data("mask"), d = JSON.stringify; b = a(b).val() || a(b).text(); try { return "function" === typeof e && (e = e(b)), "object" !== typeof c || d(c.options) !== d(f) || c.mask !== e } catch (t) { } }, h = function (a) {
        var b = document.createElement("div"), d; a = "on" + a; d = a in b; d || (b.setAttribute(a,
            "return;"), d = "function" === typeof b[a]); return d
    }; a.fn.mask = function (b, d) { d = d || {}; var e = this.selector, c = a.jMaskGlobals, h = c.watchInterval, c = d.watchInputs || c.watchInputs, t = function () { if (p(this, b, d)) return a(this).data("mask", new l(this, b, d)) }; a(this).each(t); e && "" !== e && c && (clearInterval(a.maskWatchers[e]), a.maskWatchers[e] = setInterval(function () { a(document).find(e).each(t) }, h)); return this }; a.fn.masked = function (a) { return this.data("mask").getMaskedVal(a) }; a.fn.unmask = function () {
        clearInterval(a.maskWatchers[this.selector]);
        delete a.maskWatchers[this.selector]; return this.each(function () { var b = a(this).data("mask"); b && b.remove().removeData("mask") })
    }; a.fn.cleanVal = function () { return this.data("mask").getCleanVal() }; a.applyDataMask = function (b) { b = b || a.jMaskGlobals.maskElements; (b instanceof a ? b : a(b)).filter(a.jMaskGlobals.dataMaskAttr).each(d) }; h = {
        maskElements: "input,td,span,div", dataMaskAttr: "*[data-mask]", dataMask: !0, watchInterval: 300, watchInputs: !0, keyStrokeCompensation: 10, useInput: !/Chrome\/[2-4][0-9]|SamsungBrowser/.test(window.navigator.userAgent) &&
        h("input"), watchDataMask: !1, byPassKeys: [9, 16, 17, 18, 36, 37, 38, 39, 40, 91], translation: { 0: { pattern: /\d/ }, 9: { pattern: /\d/, optional: !0 }, "#": { pattern: /\d/, recursive: !0 }, A: { pattern: /[a-zA-Z0-9]/ }, S: { pattern: /[a-zA-Z]/ } }
    }; a.jMaskGlobals = a.jMaskGlobals || {}; h = a.jMaskGlobals = a.extend(!0, {}, h, a.jMaskGlobals); h.dataMask && a.applyDataMask(); setInterval(function () { a.jMaskGlobals.watchDataMask && a.applyDataMask() }, h.watchInterval)
}, window.jQuery, window.Zepto);







// Function which adds the 'animated' class to any '.animatable' in view
var doAnimations = function () {
    // Calc current offset and get all animatables
    var offset = $(window).scrollTop() + $(window).height();
    var $animatables = $('.animatable');
    // Unbind scroll handler if we have no animatables
    if ($animatables.size() == 0) {
        $(window).off('scroll', doAnimations);
    }
    // Check all animatables and animate them if necessary
    $animatables.each(function (i) {
        var $animatable = $(this);
        if (($animatable.offset().top + $animatable.height() - 20) < offset) {
            $animatable.removeClass('animatable').addClass('animated');
        }
    });
};





function formSubmit(formId, formPost, dataLayerLabel) {

    

    $('#' + formId).submit(function (e) {

 
        $(this).find('input[type="submit"]').attr("disabled", false);

        if (!$(this).attr('validated')) {
            // disabled form post
            e.preventDefault();
            //you code 
            var dt = $('#' + formId + '').serialize();
            var values = {};

            $.each($('#' + formId + '').serializeArray(), function (i, field) {
                values[field.name] = field.value;
            });

            var getValue = function (valueName) {
                return values[valueName];
            };

            var stringPhone = getValue("_phone");
            var phoneReplace = stringPhone.replace("(", "").replace(")", "").replace(" ", "").replace(" ", "").replace(" ", "");
            $('.normal_phone').val('0' + phoneReplace);
                                                                      
            //$(this).find("input[type='checkbox']").on("change", function (e) {
            //    if (!$(this).prop("checked")) {
            //        $(this).prev().css('border', '1px solid red');
            //    }
            //    else {
            //    }
            //});

            dataLayer.push({
                'Category': "form",
                'Action': "gonder",
                'Label': dataLayerLabel,
                'event': 'gaEvent'
            });

            $.ajax({
                type: 'POST',
                url: '/urun-secme-sihirbazi/SendMail?formId=' + formId,
                data: dt,
                success: function (msg) {
                    if (msg == true) {
                        // $('#PostControl').val('true');
                        // return true;
                        $('#' + formId).attr('validated', true);
                        isFormSubmit = false;
                        $('#' + formId).submit();
                    } else {
                        console.log(msg);
                        return false;
                    }
                }
            });
            return false;
        }
        return true;
    });
}




var stickySidebar = function (element, stopper) {
    console.log("document ready!");

    var $sticky = $(element);
    var $stickyrStopper = $(stopper);
    if (!!$sticky.offset()) { // make sure ".sticky" element exists

        var generalSidebarHeight = $sticky.innerHeight();
        var stickyTop = $sticky.offset().top;
        var stickOffset = 100;
        var stickyStopperPosition = $stickyrStopper.offset().top;
        var stopPoint = stickyStopperPosition - generalSidebarHeight - stickOffset;
        var diff = stopPoint + stickOffset;

        $(window).scroll(function () { // scroll event
            var windowTop = $(window).scrollTop(); // returns number

            if (stopPoint < windowTop) {
                $sticky.css({ top: diff });
            } else if (stickyTop < windowTop + stickOffset) {
                $sticky.css({ position: 'fixed', top: stickOffset });
            } else {
                $sticky.css({ top: 'initial', position: 'absolute' });
            }
        });

    }
}

var isFormSubmit = false;
$(function () {
    $(".phones").mask("(999) 9999999");
    //$( "form" ).submit(function( event ) {
    //    if(!isFormSubmit)
    //    {
    //        $(this).find("input[type='submit']").css("opacity", "0.5").attr("disabled");
    //        isFormSubmit = true;
    //        return true;
    //    }
    //    else
    //        return false;
    //  });

    //   $( "input[type='submit']" ).click(function( event ) {
    //     if(isFormSubmit)
    //         $(this)
    //   });

    //$("body").on("keypress paste change", ".number", function (event) {
    //    event = (event) ? event : window.event
    //    var charCode = (event.which) ? event.which : event.keyCode
    //    if (charCode > 31 && (charCode < 48 || charCode > 57))
    //        return false;
    //    return true;
    //});

    $(".phones").on("keypress, paste, keyup", function (evt) {
        evt = (evt) ? evt : window.event
        var charCode = (evt.which) ? evt.which : evt.keyCode;
        var v = $(this).val();
        if (v[1] == '0') {
         $(this).val("");
            return false;
        }
        if (charCode == 48)
            return false;

        if($(this).val().length > 10)
            return false;   
    });



    $('input, input[required], select[required], textarea[required]').on("invalid", function (e) {
        e.preventDefault();
        $(this).css('border-color', 'red');
        //$(this).parent().css('text-shadow','-1px 0 red, 0 1px red, 1px 0 red, 0 -1px red;');
    });


    $('select[required]').on("change", function (e) {
        if($(this)[0].selectedIndex == 0)
        {
            e.preventDefault();
            $(this).css('border-color', 'red');
        }
    });

    

    //$('[data-number-animate]').each(
    //    function() {
    //        $(this).animateNumber({
    //            number: $(this).attr('data-number'),
    //            easing: 'easeInQuad'
    //        }, 3000);
    //    }
    //);

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

    $('.page-header-navigation-item__menu').click(function () {

        //$('.page-mega-navigation').toggleClass('active');
        var newHeight = $('#form1').height() - 200;
        $('.page-mega-navigation').slideToggle("slow");

        //.animate({

        //     "height":newHeight
        // },500);
        $('.spanx').toggleClass("active");
        //$('.open').toggle("slow");
        //$('.spanx').toggle("slow");


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
        autoplay: true,
        autoplayTimeout: 5000,
        autoplayHoverPause: false
    });

    $('.modules-owl-carousel').owlCarousel({
        loop: false,
        margin: 0,
        nav: true,

        responsive: {
            960: {
                items: 5,
                nav: true
            },
            768: {
                items: 3,
                nav: false
            },
            320: {
                items: 1,
                nav: true
            }
        }

    });


    //$('.wizard-form-row__select').select2();
    //$('.wizard-bottom-left-content-form-row__select').select2();

    $('.story-group').click(function () {
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
    $('.responsive-business-left__title2__text > span').click(function () {
        var text = $(this).text();
        $('.responsive-business-left__title2__show > span').text(text);
    });


    /*$('.page-mega-navigation-content-section__maintitle').click(function(){
        $('.page-mega-navigation-content-section__subtitle').hide();
        $(this).nextAll('.page-mega-navigation-content-section__subtitle').hide();
    })*/

    //Contact-telefon son 2 hane
    $('.phone-hide').click(function () {
        $('.phone-hide').text("+90 (850) 225 10 10 (Çağrı Merkezi)");
    });
    $('.phone-hide-pbx').click(function () {
        $('.phone-hide-pbx').text("+90 (212) 806 45 45 (PBX)");
    });

    $('.page-section-business-left__title2__text > span').click(function () {
        $('.page-section-business-left__title2__text > span').removeClass('products-select-tabs');
        $('.page-section-business-left__text').text($(this).data('text'));
        $('.page-section-business-left__button__detail').attr('href', $(this).data('link'));
        $(this).addClass('products-select-tabs');
    });
    $('.products-container-content-right-item').click(function () {
        $(this).find('.products-container-content-right-item__text').slideToggle('slow');
        $(this).find('.products-container-content-right-item__title').toggleClass('products-detail-select');
    });

    //Ürün detay sayfası ilk item click'leniyor. 
    $(".products-container-content-right-item:nth-child(1)").click();
    //Demo-request-open
    $('.page-section-demo-request-button__demo').click(function () {
        $('.page-section-demo-request').slideToggle('slow');
        $('.page-section-demo-request-open').slideToggle('slow');
    });

    $('.svg-hide').click(function () {
        $('.page-section-demo-request').slideToggle('slow');
        $('.page-section-demo-request-open').slideToggle('slow');
    });

    $('.page-section-demo-request-open-left__p').click(function () {
        $('.page-section-demo-request-open-left__p-hide').ToggleClass('show-p');
    });

    $('.wizard-bottom-left-content-form-row-text').click(function () {

        $('.wizard-bottom-left-content-form-row-text__hide').fadeToggle();
    });

    $(".homepage-new-product-item").hover(function () {
        $(this).animate({
            marginLeft: 0,
        }, 500, function () {
            $(this).find('.homepage-new-product-item-link').fadeIn();
        });
        $('.homepage-new-product-right-wrapper > img').attr('src', $(this).data('image'))
    }, function () {
        $(this).animate({
            marginLeft: -220,
        }, 500, function () {
            $(this).find('.homepage-new-product-item-link').fadeOut();
        });
    });

    function handleEnter(e) {
        if (e.which == 13) {
            e.preventDefault();
            // enter pressed
            var searchKeyWord = $(".page-header-tools__search > input").val();
            window.location = "/arama?indexCatalogue=arama&wordsMode=0&searchQuery=" + searchKeyWord;
        }
    }
    $(".page-header-tools__search > input").keypress(handleEnter);

    $(".detail-product-description-left").next(".products-container-content-right-item__title").addClass("products-detail-select")

    $('select').change(function(){
        $('.wizard-form-left > div').removeClass('wizardshow');
        if($("#00N0Y00000QeR9j option:selected").attr('data-field') != null)
        {
            $("."+$("#00N0Y00000QeR9j option:selected").attr('data-field')).addClass('wizardshow');

        }
        if ($("#00N0Y00000QeNYu option:selected").attr('data-field') != null) {

            $("#retURL").val("https://www.mikro.com.tr/tesekkurler?product=" + $("#00N0Y00000QeNYu option:selected").val());        
        }
    });

    $('.products-container-content-right-item').next('.products-container-content-right-item__text').addClass('products-detail-select');


    //only number ürün seçme sihirbazı
    $("#00N0Y00000QeNYf").keydown(function (e) {
        // Allow: backspace, delete, tab, escape, enter and .
        if ($.inArray(e.keyCode, [46, 8, 9, 27, 13, 110, 190]) !== -1 ||
            // Allow: Ctrl+A, Command+A
            (e.keyCode === 65 && (e.ctrlKey === true || e.metaKey === true)) ||
            // Allow: home, end, left, right, down, up
            (e.keyCode >= 35 && e.keyCode <= 40)) {
            // let it happen, don't do anything
            return;
        }
        // Ensure that it is a number and stop the keypress
        if ((e.shiftKey || (e.keyCode < 48 || e.keyCode > 57)) && (e.keyCode < 96 || e.keyCode > 105)) {
            e.preventDefault();
        }
    });




    //Pop-up
    // The class you click to trigger the popup 
    //RUN-POPUP
    $('#run').on('click', function () {
        // The Overlay fades in
        $(".overlay").fadeIn(500, function () { });
        // The Popup fades in just after
        $(".run-popup > .popup").fadeIn(900, function () { });

    });

    // The class's you click when you want to close the pop
    $('.overlay, .close-popup').on('click', function () {
        // The Overlay fades out slower
        $(".overlay").fadeOut(600, function () { });
        // The Popup fades out faster
        $(".popup").fadeOut(500, function () { });
    });
    //JUMP POPUP
    $('#jump').on('click', function () {
        // The Overlay fades in
        $(".overlay").fadeIn(500, function () { });
        // The Popup fades in just after
        $(".jump-popup > .popup").fadeIn(900, function () { });

    });

    //MUSAVIR POPUP
    $('#musavir').on('click', function () {
        // The Overlay fades in
        $(".overlay").fadeIn(500, function () { });
        // The Popup fades in just after
        $(".musavir-popup > .popup").fadeIn(900, function () { });

    });


    //FLY POPUP
    $('#fly').on('click', function () {
        // The Overlay fades in
        $(".overlay").fadeIn(500, function () { });
        // The Popup fades in just after
        $(".fly-popup > .popup").fadeIn(900, function () { });
    });

    $('.news').on('click', function () {
        // The Overlay fades in
        $(".overlay").fadeIn(500, function () { });
        // The Popup fades in just after
        $(".news-popup > .popup").fadeIn(900, function () { });
        var news_img = $(this).children('img').data('img');
        $('.news-popup > .popup > img').attr('src', news_img);
    });


    //YONETIM SAYFASI
    $(".management-main-item").on('click', function () {
        $(".overlay").fadeIn(600, function () { });
        $(".yonetim-popup > .popup").fadeIn(900, function () { });
        var text = $(this).data('text');
        $('.popup-content-management-right__description').html(text);
        var img = $(this).data('img');
        $('.popup-content-management-left > img').attr('src', img);
        var link = $(this).data('link');
        $('.popup-content-management-left > a').attr('href', link);
    });

    $('input, input[required], select[required], textarea[required]').on("invalid", function (e) {
        e.preventDefault();
        $(this).css('border-color', 'red');
    });



    $('.phones').on('keypress', function (e) {
        if (!$(this).val() && e.which == 48) {
            return false;
        }
    });



});
