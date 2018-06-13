/*! tooltipster v4.2.6 */!function(a,b){"function"==typeof define&&define.amd?define(["jquery"],function(a){return b(a)}):"object"==typeof exports?module.exports=b(require("jquery")):b(jQuery)}(this,function(a){function b(a){this.$container,this.constraints=null,this.__$tooltip,this.__init(a)}function c(b,c){var d=!0;return a.each(b,function(a,e){return void 0===c[a]||b[a]!==c[a]?(d=!1,!1):void 0}),d}function d(b){var c=b.attr("id"),d=c?h.window.document.getElementById(c):null;return d?d===b[0]:a.contains(h.window.document.body,b[0])}function e(){if(!g)return!1;var a=g.document.body||g.document.documentElement,b=a.style,c="transition",d=["Moz","Webkit","Khtml","O","ms"];if("string"==typeof b[c])return!0;c=c.charAt(0).toUpperCase()+c.substr(1);for(var e=0;e<d.length;e++)if("string"==typeof b[d[e]+c])return!0;return!1}var f={animation:"fade",animationDuration:350,content:null,contentAsHTML:!1,contentCloning:!1,debug:!0,delay:300,delayTouch:[300,500],functionInit:null,functionBefore:null,functionReady:null,functionAfter:null,functionFormat:null,IEmin:6,interactive:!1,multiple:!1,parent:null,plugins:["sideTip"],repositionOnScroll:!1,restoration:"none",selfDestruction:!0,theme:[],timer:0,trackerInterval:500,trackOrigin:!1,trackTooltip:!1,trigger:"hover",triggerClose:{click:!1,mouseleave:!1,originClick:!1,scroll:!1,tap:!1,touchleave:!1},triggerOpen:{click:!1,mouseenter:!1,tap:!1,touchstart:!1},updateAnimation:"rotate",zIndex:9999999},g="undefined"!=typeof window?window:null,h={hasTouchCapability:!(!g||!("ontouchstart"in g||g.DocumentTouch&&g.document instanceof g.DocumentTouch||g.navigator.maxTouchPoints)),hasTransitions:e(),IE:!1,semVer:"4.2.6",window:g},i=function(){this.__$emitterPrivate=a({}),this.__$emitterPublic=a({}),this.__instancesLatestArr=[],this.__plugins={},this._env=h};i.prototype={__bridge:function(b,c,d){if(!c[d]){var e=function(){};e.prototype=b;var g=new e;g.__init&&g.__init(c),a.each(b,function(a,b){0!=a.indexOf("__")&&(c[a]?f.debug&&console.log("The "+a+" method of the "+d+" plugin conflicts with another plugin or native methods"):(c[a]=function(){return g[a].apply(g,Array.prototype.slice.apply(arguments))},c[a].bridged=g))}),c[d]=g}return this},__setWindow:function(a){return h.window=a,this},_getRuler:function(a){return new b(a)},_off:function(){return this.__$emitterPrivate.off.apply(this.__$emitterPrivate,Array.prototype.slice.apply(arguments)),this},_on:function(){return this.__$emitterPrivate.on.apply(this.__$emitterPrivate,Array.prototype.slice.apply(arguments)),this},_one:function(){return this.__$emitterPrivate.one.apply(this.__$emitterPrivate,Array.prototype.slice.apply(arguments)),this},_plugin:function(b){var c=this;if("string"==typeof b){var d=b,e=null;return d.indexOf(".")>0?e=c.__plugins[d]:a.each(c.__plugins,function(a,b){return b.name.substring(b.name.length-d.length-1)=="."+d?(e=b,!1):void 0}),e}if(b.name.indexOf(".")<0)throw new Error("Plugins must be namespaced");return c.__plugins[b.name]=b,b.core&&c.__bridge(b.core,c,b.name),this},_trigger:function(){var a=Array.prototype.slice.apply(arguments);return"string"==typeof a[0]&&(a[0]={type:a[0]}),this.__$emitterPrivate.trigger.apply(this.__$emitterPrivate,a),this.__$emitterPublic.trigger.apply(this.__$emitterPublic,a),this},instances:function(b){var c=[],d=b||".tooltipstered";return a(d).each(function(){var b=a(this),d=b.data("tooltipster-ns");d&&a.each(d,function(a,d){c.push(b.data(d))})}),c},instancesLatest:function(){return this.__instancesLatestArr},off:function(){return this.__$emitterPublic.off.apply(this.__$emitterPublic,Array.prototype.slice.apply(arguments)),this},on:function(){return this.__$emitterPublic.on.apply(this.__$emitterPublic,Array.prototype.slice.apply(arguments)),this},one:function(){return this.__$emitterPublic.one.apply(this.__$emitterPublic,Array.prototype.slice.apply(arguments)),this},origins:function(b){var c=b?b+" ":"";return a(c+".tooltipstered").toArray()},setDefaults:function(b){return a.extend(f,b),this},triggerHandler:function(){return this.__$emitterPublic.triggerHandler.apply(this.__$emitterPublic,Array.prototype.slice.apply(arguments)),this}},a.tooltipster=new i,a.Tooltipster=function(b,c){this.__callbacks={close:[],open:[]},this.__closingTime,this.__Content,this.__contentBcr,this.__destroyed=!1,this.__$emitterPrivate=a({}),this.__$emitterPublic=a({}),this.__enabled=!0,this.__garbageCollector,this.__Geometry,this.__lastPosition,this.__namespace="tooltipster-"+Math.round(1e6*Math.random()),this.__options,this.__$originParents,this.__pointerIsOverOrigin=!1,this.__previousThemes=[],this.__state="closed",this.__timeouts={close:[],open:null},this.__touchEvents=[],this.__tracker=null,this._$origin,this._$tooltip,this.__init(b,c)},a.Tooltipster.prototype={__init:function(b,c){var d=this;if(d._$origin=a(b),d.__options=a.extend(!0,{},f,c),d.__optionsFormat(),!h.IE||h.IE>=d.__options.IEmin){var e=null;if(void 0===d._$origin.data("tooltipster-initialTitle")&&(e=d._$origin.attr("title"),void 0===e&&(e=null),d._$origin.data("tooltipster-initialTitle",e)),null!==d.__options.content)d.__contentSet(d.__options.content);else{var g,i=d._$origin.attr("data-tooltip-content");i&&(g=a(i)),g&&g[0]?d.__contentSet(g.first()):d.__contentSet(e)}d._$origin.removeAttr("title").addClass("tooltipstered"),d.__prepareOrigin(),d.__prepareGC(),a.each(d.__options.plugins,function(a,b){d._plug(b)}),h.hasTouchCapability&&a(h.window.document.body).on("touchmove."+d.__namespace+"-triggerOpen",function(a){d._touchRecordEvent(a)}),d._on("created",function(){d.__prepareTooltip()})._on("repositioned",function(a){d.__lastPosition=a.position})}else d.__options.disabled=!0},__contentInsert:function(){var a=this,b=a._$tooltip.find(".tooltipster-content"),c=a.__Content,d=function(a){c=a};return a._trigger({type:"format",content:a.__Content,format:d}),a.__options.functionFormat&&(c=a.__options.functionFormat.call(a,a,{origin:a._$origin[0]},a.__Content)),"string"!=typeof c||a.__options.contentAsHTML?b.empty().append(c):b.text(c),a},__contentSet:function(b){return b instanceof a&&this.__options.contentCloning&&(b=b.clone(!0)),this.__Content=b,this._trigger({type:"updated",content:b}),this},__destroyError:function(){throw new Error("This tooltip has been destroyed and cannot execute your method call.")},__geometry:function(){var b=this,c=b._$origin,d=b._$origin.is("area");if(d){var e=b._$origin.parent().attr("name");c=a('img[usemap="#'+e+'"]')}var f=c[0].getBoundingClientRect(),g=a(h.window.document),i=a(h.window),j=c,k={available:{document:null,window:null},document:{size:{height:g.height(),width:g.width()}},window:{scroll:{left:h.window.scrollX||h.window.document.documentElement.scrollLeft,top:h.window.scrollY||h.window.document.documentElement.scrollTop},size:{height:i.height(),width:i.width()}},origin:{fixedLineage:!1,offset:{},size:{height:f.bottom-f.top,width:f.right-f.left},usemapImage:d?c[0]:null,windowOffset:{bottom:f.bottom,left:f.left,right:f.right,top:f.top}}};if(d){var l=b._$origin.attr("shape"),m=b._$origin.attr("coords");if(m&&(m=m.split(","),a.map(m,function(a,b){m[b]=parseInt(a)})),"default"!=l)switch(l){case"circle":var n=m[0],o=m[1],p=m[2],q=o-p,r=n-p;k.origin.size.height=2*p,k.origin.size.width=k.origin.size.height,k.origin.windowOffset.left+=r,k.origin.windowOffset.top+=q;break;case"rect":var s=m[0],t=m[1],u=m[2],v=m[3];k.origin.size.height=v-t,k.origin.size.width=u-s,k.origin.windowOffset.left+=s,k.origin.windowOffset.top+=t;break;case"poly":for(var w=0,x=0,y=0,z=0,A="even",B=0;B<m.length;B++){var C=m[B];"even"==A?(C>y&&(y=C,0===B&&(w=y)),w>C&&(w=C),A="odd"):(C>z&&(z=C,1==B&&(x=z)),x>C&&(x=C),A="even")}k.origin.size.height=z-x,k.origin.size.width=y-w,k.origin.windowOffset.left+=w,k.origin.windowOffset.top+=x}}var D=function(a){k.origin.size.height=a.height,k.origin.windowOffset.left=a.left,k.origin.windowOffset.top=a.top,k.origin.size.width=a.width};for(b._trigger({type:"geometry",edit:D,geometry:{height:k.origin.size.height,left:k.origin.windowOffset.left,top:k.origin.windowOffset.top,width:k.origin.size.width}}),k.origin.windowOffset.right=k.origin.windowOffset.left+k.origin.size.width,k.origin.windowOffset.bottom=k.origin.windowOffset.top+k.origin.size.height,k.origin.offset.left=k.origin.windowOffset.left+k.window.scroll.left,k.origin.offset.top=k.origin.windowOffset.top+k.window.scroll.top,k.origin.offset.bottom=k.origin.offset.top+k.origin.size.height,k.origin.offset.right=k.origin.offset.left+k.origin.size.width,k.available.document={bottom:{height:k.document.size.height-k.origin.offset.bottom,width:k.document.size.width},left:{height:k.document.size.height,width:k.origin.offset.left},right:{height:k.document.size.height,width:k.document.size.width-k.origin.offset.right},top:{height:k.origin.offset.top,width:k.document.size.width}},k.available.window={bottom:{height:Math.max(k.window.size.height-Math.max(k.origin.windowOffset.bottom,0),0),width:k.window.size.width},left:{height:k.window.size.height,width:Math.max(k.origin.windowOffset.left,0)},right:{height:k.window.size.height,width:Math.max(k.window.size.width-Math.max(k.origin.windowOffset.right,0),0)},top:{height:Math.max(k.origin.windowOffset.top,0),width:k.window.size.width}};"html"!=j[0].tagName.toLowerCase();){if("fixed"==j.css("position")){k.origin.fixedLineage=!0;break}j=j.parent()}return k},__optionsFormat:function(){return"number"==typeof this.__options.animationDuration&&(this.__options.animationDuration=[this.__options.animationDuration,this.__options.animationDuration]),"number"==typeof this.__options.delay&&(this.__options.delay=[this.__options.delay,this.__options.delay]),"number"==typeof this.__options.delayTouch&&(this.__options.delayTouch=[this.__options.delayTouch,this.__options.delayTouch]),"string"==typeof this.__options.theme&&(this.__options.theme=[this.__options.theme]),null===this.__options.parent?this.__options.parent=a(h.window.document.body):"string"==typeof this.__options.parent&&(this.__options.parent=a(this.__options.parent)),"hover"==this.__options.trigger?(this.__options.triggerOpen={mouseenter:!0,touchstart:!0},this.__options.triggerClose={mouseleave:!0,originClick:!0,touchleave:!0}):"click"==this.__options.trigger&&(this.__options.triggerOpen={click:!0,tap:!0},this.__options.triggerClose={click:!0,tap:!0}),this._trigger("options"),this},__prepareGC:function(){var b=this;return b.__options.selfDestruction?b.__garbageCollector=setInterval(function(){var c=(new Date).getTime();b.__touchEvents=a.grep(b.__touchEvents,function(a,b){return c-a.time>6e4}),d(b._$origin)||b.close(function(){b.destroy()})},2e4):clearInterval(b.__garbageCollector),b},__prepareOrigin:function(){var a=this;if(a._$origin.off("."+a.__namespace+"-triggerOpen"),h.hasTouchCapability&&a._$origin.on("touchstart."+a.__namespace+"-triggerOpen touchend."+a.__namespace+"-triggerOpen touchcancel."+a.__namespace+"-triggerOpen",function(b){a._touchRecordEvent(b)}),a.__options.triggerOpen.click||a.__options.triggerOpen.tap&&h.hasTouchCapability){var b="";a.__options.triggerOpen.click&&(b+="click."+a.__namespace+"-triggerOpen "),a.__options.triggerOpen.tap&&h.hasTouchCapability&&(b+="touchend."+a.__namespace+"-triggerOpen"),a._$origin.on(b,function(b){a._touchIsMeaningfulEvent(b)&&a._open(b)})}if(a.__options.triggerOpen.mouseenter||a.__options.triggerOpen.touchstart&&h.hasTouchCapability){var b="";a.__options.triggerOpen.mouseenter&&(b+="mouseenter."+a.__namespace+"-triggerOpen "),a.__options.triggerOpen.touchstart&&h.hasTouchCapability&&(b+="touchstart."+a.__namespace+"-triggerOpen"),a._$origin.on(b,function(b){!a._touchIsTouchEvent(b)&&a._touchIsEmulatedEvent(b)||(a.__pointerIsOverOrigin=!0,a._openShortly(b))})}if(a.__options.triggerClose.mouseleave||a.__options.triggerClose.touchleave&&h.hasTouchCapability){var b="";a.__options.triggerClose.mouseleave&&(b+="mouseleave."+a.__namespace+"-triggerOpen "),a.__options.triggerClose.touchleave&&h.hasTouchCapability&&(b+="touchend."+a.__namespace+"-triggerOpen touchcancel."+a.__namespace+"-triggerOpen"),a._$origin.on(b,function(b){a._touchIsMeaningfulEvent(b)&&(a.__pointerIsOverOrigin=!1)})}return a},__prepareTooltip:function(){var b=this,c=b.__options.interactive?"auto":"";return b._$tooltip.attr("id",b.__namespace).css({"pointer-events":c,zIndex:b.__options.zIndex}),a.each(b.__previousThemes,function(a,c){b._$tooltip.removeClass(c)}),a.each(b.__options.theme,function(a,c){b._$tooltip.addClass(c)}),b.__previousThemes=a.merge([],b.__options.theme),b},__scrollHandler:function(b){var c=this;if(c.__options.triggerClose.scroll)c._close(b);else if(d(c._$origin)&&d(c._$tooltip)){var e=null;if(b.target===h.window.document)c.__Geometry.origin.fixedLineage||c.__options.repositionOnScroll&&c.reposition(b);else{e=c.__geometry();var f=!1;if("fixed"!=c._$origin.css("position")&&c.__$originParents.each(function(b,c){var d=a(c),g=d.css("overflow-x"),h=d.css("overflow-y");if("visible"!=g||"visible"!=h){var i=c.getBoundingClientRect();if("visible"!=g&&(e.origin.windowOffset.left<i.left||e.origin.windowOffset.right>i.right))return f=!0,!1;if("visible"!=h&&(e.origin.windowOffset.top<i.top||e.origin.windowOffset.bottom>i.bottom))return f=!0,!1}return"fixed"==d.css("position")?!1:void 0}),f)c._$tooltip.css("visibility","hidden");else if(c._$tooltip.css("visibility","visible"),c.__options.repositionOnScroll)c.reposition(b);else{var g=e.origin.offset.left-c.__Geometry.origin.offset.left,i=e.origin.offset.top-c.__Geometry.origin.offset.top;c._$tooltip.css({left:c.__lastPosition.coord.left+g,top:c.__lastPosition.coord.top+i})}}c._trigger({type:"scroll",event:b,geo:e})}return c},__stateSet:function(a){return this.__state=a,this._trigger({type:"state",state:a}),this},__timeoutsClear:function(){return clearTimeout(this.__timeouts.open),this.__timeouts.open=null,a.each(this.__timeouts.close,function(a,b){clearTimeout(b)}),this.__timeouts.close=[],this},__trackerStart:function(){var a=this,b=a._$tooltip.find(".tooltipster-content");return a.__options.trackTooltip&&(a.__contentBcr=b[0].getBoundingClientRect()),a.__tracker=setInterval(function(){if(d(a._$origin)&&d(a._$tooltip)){if(a.__options.trackOrigin){var e=a.__geometry(),f=!1;c(e.origin.size,a.__Geometry.origin.size)&&(a.__Geometry.origin.fixedLineage?c(e.origin.windowOffset,a.__Geometry.origin.windowOffset)&&(f=!0):c(e.origin.offset,a.__Geometry.origin.offset)&&(f=!0)),f||(a.__options.triggerClose.mouseleave?a._close():a.reposition())}if(a.__options.trackTooltip){var g=b[0].getBoundingClientRect();g.height===a.__contentBcr.height&&g.width===a.__contentBcr.width||(a.reposition(),a.__contentBcr=g)}}else a._close()},a.__options.trackerInterval),a},_close:function(b,c,d){var e=this,f=!0;if(e._trigger({type:"close",event:b,stop:function(){f=!1}}),f||d){c&&e.__callbacks.close.push(c),e.__callbacks.open=[],e.__timeoutsClear();var g=function(){a.each(e.__callbacks.close,function(a,c){c.call(e,e,{event:b,origin:e._$origin[0]})}),e.__callbacks.close=[]};if("closed"!=e.__state){var i=!0,j=new Date,k=j.getTime(),l=k+e.__options.animationDuration[1];if("disappearing"==e.__state&&l>e.__closingTime&&e.__options.animationDuration[1]>0&&(i=!1),i){e.__closingTime=l,"disappearing"!=e.__state&&e.__stateSet("disappearing");var m=function(){clearInterval(e.__tracker),e._trigger({type:"closing",event:b}),e._$tooltip.off("."+e.__namespace+"-triggerClose").removeClass("tooltipster-dying"),a(h.window).off("."+e.__namespace+"-triggerClose"),e.__$originParents.each(function(b,c){a(c).off("scroll."+e.__namespace+"-triggerClose")}),e.__$originParents=null,a(h.window.document.body).off("."+e.__namespace+"-triggerClose"),e._$origin.off("."+e.__namespace+"-triggerClose"),e._off("dismissable"),e.__stateSet("closed"),e._trigger({type:"after",event:b}),e.__options.functionAfter&&e.__options.functionAfter.call(e,e,{event:b,origin:e._$origin[0]}),g()};h.hasTransitions?(e._$tooltip.css({"-moz-animation-duration":e.__options.animationDuration[1]+"ms","-ms-animation-duration":e.__options.animationDuration[1]+"ms","-o-animation-duration":e.__options.animationDuration[1]+"ms","-webkit-animation-duration":e.__options.animationDuration[1]+"ms","animation-duration":e.__options.animationDuration[1]+"ms","transition-duration":e.__options.animationDuration[1]+"ms"}),e._$tooltip.clearQueue().removeClass("tooltipster-show").addClass("tooltipster-dying"),e.__options.animationDuration[1]>0&&e._$tooltip.delay(e.__options.animationDuration[1]),e._$tooltip.queue(m)):e._$tooltip.stop().fadeOut(e.__options.animationDuration[1],m)}}else g()}return e},_off:function(){return this.__$emitterPrivate.off.apply(this.__$emitterPrivate,Array.prototype.slice.apply(arguments)),this},_on:function(){return this.__$emitterPrivate.on.apply(this.__$emitterPrivate,Array.prototype.slice.apply(arguments)),this},_one:function(){return this.__$emitterPrivate.one.apply(this.__$emitterPrivate,Array.prototype.slice.apply(arguments)),this},_open:function(b,c){var e=this;if(!e.__destroying&&d(e._$origin)&&e.__enabled){var f=!0;if("closed"==e.__state&&(e._trigger({type:"before",event:b,stop:function(){f=!1}}),f&&e.__options.functionBefore&&(f=e.__options.functionBefore.call(e,e,{event:b,origin:e._$origin[0]}))),f!==!1&&null!==e.__Content){c&&e.__callbacks.open.push(c),e.__callbacks.close=[],e.__timeoutsClear();var g,i=function(){"stable"!=e.__state&&e.__stateSet("stable"),a.each(e.__callbacks.open,function(a,b){b.call(e,e,{origin:e._$origin[0],tooltip:e._$tooltip[0]})}),e.__callbacks.open=[]};if("closed"!==e.__state)g=0,"disappearing"===e.__state?(e.__stateSet("appearing"),h.hasTransitions?(e._$tooltip.clearQueue().removeClass("tooltipster-dying").addClass("tooltipster-show"),e.__options.animationDuration[0]>0&&e._$tooltip.delay(e.__options.animationDuration[0]),e._$tooltip.queue(i)):e._$tooltip.stop().fadeIn(i)):"stable"==e.__state&&i();else{if(e.__stateSet("appearing"),g=e.__options.animationDuration[0],e.__contentInsert(),e.reposition(b,!0),h.hasTransitions?(e._$tooltip.addClass("tooltipster-"+e.__options.animation).addClass("tooltipster-initial").css({"-moz-animation-duration":e.__options.animationDuration[0]+"ms","-ms-animation-duration":e.__options.animationDuration[0]+"ms","-o-animation-duration":e.__options.animationDuration[0]+"ms","-webkit-animation-duration":e.__options.animationDuration[0]+"ms","animation-duration":e.__options.animationDuration[0]+"ms","transition-duration":e.__options.animationDuration[0]+"ms"}),setTimeout(function(){"closed"!=e.__state&&(e._$tooltip.addClass("tooltipster-show").removeClass("tooltipster-initial"),e.__options.animationDuration[0]>0&&e._$tooltip.delay(e.__options.animationDuration[0]),e._$tooltip.queue(i))},0)):e._$tooltip.css("display","none").fadeIn(e.__options.animationDuration[0],i),e.__trackerStart(),a(h.window).on("resize."+e.__namespace+"-triggerClose",function(b){var c=a(document.activeElement);(c.is("input")||c.is("textarea"))&&a.contains(e._$tooltip[0],c[0])||e.reposition(b)}).on("scroll."+e.__namespace+"-triggerClose",function(a){e.__scrollHandler(a)}),e.__$originParents=e._$origin.parents(),e.__$originParents.each(function(b,c){a(c).on("scroll."+e.__namespace+"-triggerClose",function(a){e.__scrollHandler(a)})}),e.__options.triggerClose.mouseleave||e.__options.triggerClose.touchleave&&h.hasTouchCapability){e._on("dismissable",function(a){a.dismissable?a.delay?(m=setTimeout(function(){e._close(a.event)},a.delay),e.__timeouts.close.push(m)):e._close(a):clearTimeout(m)});var j=e._$origin,k="",l="",m=null;e.__options.interactive&&(j=j.add(e._$tooltip)),e.__options.triggerClose.mouseleave&&(k+="mouseenter."+e.__namespace+"-triggerClose ",l+="mouseleave."+e.__namespace+"-triggerClose "),e.__options.triggerClose.touchleave&&h.hasTouchCapability&&(k+="touchstart."+e.__namespace+"-triggerClose",l+="touchend."+e.__namespace+"-triggerClose touchcancel."+e.__namespace+"-triggerClose"),j.on(l,function(a){if(e._touchIsTouchEvent(a)||!e._touchIsEmulatedEvent(a)){var b="mouseleave"==a.type?e.__options.delay:e.__options.delayTouch;e._trigger({delay:b[1],dismissable:!0,event:a,type:"dismissable"})}}).on(k,function(a){!e._touchIsTouchEvent(a)&&e._touchIsEmulatedEvent(a)||e._trigger({dismissable:!1,event:a,type:"dismissable"})})}e.__options.triggerClose.originClick&&e._$origin.on("click."+e.__namespace+"-triggerClose",function(a){e._touchIsTouchEvent(a)||e._touchIsEmulatedEvent(a)||e._close(a)}),(e.__options.triggerClose.click||e.__options.triggerClose.tap&&h.hasTouchCapability)&&setTimeout(function(){if("closed"!=e.__state){var b="",c=a(h.window.document.body);e.__options.triggerClose.click&&(b+="click."+e.__namespace+"-triggerClose "),e.__options.triggerClose.tap&&h.hasTouchCapability&&(b+="touchend."+e.__namespace+"-triggerClose"),c.on(b,function(b){e._touchIsMeaningfulEvent(b)&&(e._touchRecordEvent(b),e.__options.interactive&&a.contains(e._$tooltip[0],b.target)||e._close(b))}),e.__options.triggerClose.tap&&h.hasTouchCapability&&c.on("touchstart."+e.__namespace+"-triggerClose",function(a){e._touchRecordEvent(a)})}},0),e._trigger("ready"),e.__options.functionReady&&e.__options.functionReady.call(e,e,{origin:e._$origin[0],tooltip:e._$tooltip[0]})}if(e.__options.timer>0){var m=setTimeout(function(){e._close()},e.__options.timer+g);e.__timeouts.close.push(m)}}}return e},_openShortly:function(a){var b=this,c=!0;if("stable"!=b.__state&&"appearing"!=b.__state&&!b.__timeouts.open&&(b._trigger({type:"start",event:a,stop:function(){c=!1}}),c)){var d=0==a.type.indexOf("touch")?b.__options.delayTouch:b.__options.delay;d[0]?b.__timeouts.open=setTimeout(function(){b.__timeouts.open=null,b.__pointerIsOverOrigin&&b._touchIsMeaningfulEvent(a)?(b._trigger("startend"),b._open(a)):b._trigger("startcancel")},d[0]):(b._trigger("startend"),b._open(a))}return b},_optionsExtract:function(b,c){var d=this,e=a.extend(!0,{},c),f=d.__options[b];return f||(f={},a.each(c,function(a,b){var c=d.__options[a];void 0!==c&&(f[a]=c)})),a.each(e,function(b,c){void 0!==f[b]&&("object"!=typeof c||c instanceof Array||null==c||"object"!=typeof f[b]||f[b]instanceof Array||null==f[b]?e[b]=f[b]:a.extend(e[b],f[b]))}),e},_plug:function(b){var c=a.tooltipster._plugin(b);if(!c)throw new Error('The "'+b+'" plugin is not defined');return c.instance&&a.tooltipster.__bridge(c.instance,this,c.name),this},_touchIsEmulatedEvent:function(a){for(var b=!1,c=(new Date).getTime(),d=this.__touchEvents.length-1;d>=0;d--){var e=this.__touchEvents[d];if(!(c-e.time<500))break;e.target===a.target&&(b=!0)}return b},_touchIsMeaningfulEvent:function(a){return this._touchIsTouchEvent(a)&&!this._touchSwiped(a.target)||!this._touchIsTouchEvent(a)&&!this._touchIsEmulatedEvent(a)},_touchIsTouchEvent:function(a){return 0==a.type.indexOf("touch")},_touchRecordEvent:function(a){return this._touchIsTouchEvent(a)&&(a.time=(new Date).getTime(),this.__touchEvents.push(a)),this},_touchSwiped:function(a){for(var b=!1,c=this.__touchEvents.length-1;c>=0;c--){var d=this.__touchEvents[c];if("touchmove"==d.type){b=!0;break}if("touchstart"==d.type&&a===d.target)break}return b},_trigger:function(){var b=Array.prototype.slice.apply(arguments);return"string"==typeof b[0]&&(b[0]={type:b[0]}),b[0].instance=this,b[0].origin=this._$origin?this._$origin[0]:null,b[0].tooltip=this._$tooltip?this._$tooltip[0]:null,this.__$emitterPrivate.trigger.apply(this.__$emitterPrivate,b),a.tooltipster._trigger.apply(a.tooltipster,b),this.__$emitterPublic.trigger.apply(this.__$emitterPublic,b),this},_unplug:function(b){var c=this;if(c[b]){var d=a.tooltipster._plugin(b);d.instance&&a.each(d.instance,function(a,d){c[a]&&c[a].bridged===c[b]&&delete c[a]}),c[b].__destroy&&c[b].__destroy(),delete c[b]}return c},close:function(a){return this.__destroyed?this.__destroyError():this._close(null,a),this},content:function(a){var b=this;if(void 0===a)return b.__Content;if(b.__destroyed)b.__destroyError();else if(b.__contentSet(a),null!==b.__Content){if("closed"!==b.__state&&(b.__contentInsert(),b.reposition(),b.__options.updateAnimation))if(h.hasTransitions){var c=b.__options.updateAnimation;b._$tooltip.addClass("tooltipster-update-"+c),setTimeout(function(){"closed"!=b.__state&&b._$tooltip.removeClass("tooltipster-update-"+c)},1e3)}else b._$tooltip.fadeTo(200,.5,function(){"closed"!=b.__state&&b._$tooltip.fadeTo(200,1)})}else b._close();return b},destroy:function(){var b=this;if(b.__destroyed)b.__destroyError();else{"closed"!=b.__state?b.option("animationDuration",0)._close(null,null,!0):b.__timeoutsClear(),b._trigger("destroy"),b.__destroyed=!0,b._$origin.removeData(b.__namespace).off("."+b.__namespace+"-triggerOpen"),a(h.window.document.body).off("."+b.__namespace+"-triggerOpen");var c=b._$origin.data("tooltipster-ns");if(c)if(1===c.length){var d=null;"previous"==b.__options.restoration?d=b._$origin.data("tooltipster-initialTitle"):"current"==b.__options.restoration&&(d="string"==typeof b.__Content?b.__Content:a("<div></div>").append(b.__Content).html()),d&&b._$origin.attr("title",d),b._$origin.removeClass("tooltipstered"),b._$origin.removeData("tooltipster-ns").removeData("tooltipster-initialTitle")}else c=a.grep(c,function(a,c){return a!==b.__namespace}),b._$origin.data("tooltipster-ns",c);b._trigger("destroyed"),b._off(),b.off(),b.__Content=null,b.__$emitterPrivate=null,b.__$emitterPublic=null,b.__options.parent=null,b._$origin=null,b._$tooltip=null,a.tooltipster.__instancesLatestArr=a.grep(a.tooltipster.__instancesLatestArr,function(a,c){return b!==a}),clearInterval(b.__garbageCollector)}return b},disable:function(){return this.__destroyed?(this.__destroyError(),this):(this._close(),this.__enabled=!1,this)},elementOrigin:function(){return this.__destroyed?void this.__destroyError():this._$origin[0]},elementTooltip:function(){return this._$tooltip?this._$tooltip[0]:null},enable:function(){return this.__enabled=!0,this},hide:function(a){return this.close(a)},instance:function(){return this},off:function(){return this.__destroyed||this.__$emitterPublic.off.apply(this.__$emitterPublic,Array.prototype.slice.apply(arguments)),this},on:function(){return this.__destroyed?this.__destroyError():this.__$emitterPublic.on.apply(this.__$emitterPublic,Array.prototype.slice.apply(arguments)),this},one:function(){return this.__destroyed?this.__destroyError():this.__$emitterPublic.one.apply(this.__$emitterPublic,Array.prototype.slice.apply(arguments)),this},open:function(a){return this.__destroyed?this.__destroyError():this._open(null,a),this},option:function(b,c){return void 0===c?this.__options[b]:(this.__destroyed?this.__destroyError():(this.__options[b]=c,this.__optionsFormat(),a.inArray(b,["trigger","triggerClose","triggerOpen"])>=0&&this.__prepareOrigin(),"selfDestruction"===b&&this.__prepareGC()),this)},reposition:function(a,b){var c=this;return c.__destroyed?c.__destroyError():"closed"!=c.__state&&d(c._$origin)&&(b||d(c._$tooltip))&&(b||c._$tooltip.detach(),c.__Geometry=c.__geometry(),c._trigger({type:"reposition",event:a,helper:{geo:c.__Geometry}})),c},show:function(a){return this.open(a)},status:function(){return{destroyed:this.__destroyed,enabled:this.__enabled,open:"closed"!==this.__state,state:this.__state}},triggerHandler:function(){return this.__destroyed?this.__destroyError():this.__$emitterPublic.triggerHandler.apply(this.__$emitterPublic,Array.prototype.slice.apply(arguments)),this}},a.fn.tooltipster=function(){var b=Array.prototype.slice.apply(arguments),c="You are using a single HTML element as content for several tooltips. You probably want to set the contentCloning option to TRUE.";if(0===this.length)return this;if("string"==typeof b[0]){var d="#*$~&";return this.each(function(){var e=a(this).data("tooltipster-ns"),f=e?a(this).data(e[0]):null;if(!f)throw new Error("You called Tooltipster's \""+b[0]+'" method on an uninitialized element');if("function"!=typeof f[b[0]])throw new Error('Unknown method "'+b[0]+'"');this.length>1&&"content"==b[0]&&(b[1]instanceof a||"object"==typeof b[1]&&null!=b[1]&&b[1].tagName)&&!f.__options.contentCloning&&f.__options.debug&&console.log(c);var g=f[b[0]](b[1],b[2]);return g!==f||"instance"===b[0]?(d=g,!1):void 0}),"#*$~&"!==d?d:this}a.tooltipster.__instancesLatestArr=[];var e=b[0]&&void 0!==b[0].multiple,g=e&&b[0].multiple||!e&&f.multiple,h=b[0]&&void 0!==b[0].content,i=h&&b[0].content||!h&&f.content,j=b[0]&&void 0!==b[0].contentCloning,k=j&&b[0].contentCloning||!j&&f.contentCloning,l=b[0]&&void 0!==b[0].debug,m=l&&b[0].debug||!l&&f.debug;return this.length>1&&(i instanceof a||"object"==typeof i&&null!=i&&i.tagName)&&!k&&m&&console.log(c),this.each(function(){var c=!1,d=a(this),e=d.data("tooltipster-ns"),f=null;e?g?c=!0:m&&(console.log("Tooltipster: one or more tooltips are already attached to the element below. Ignoring."),console.log(this)):c=!0,c&&(f=new a.Tooltipster(this,b[0]),e||(e=[]),e.push(f.__namespace),d.data("tooltipster-ns",e),d.data(f.__namespace,f),f.__options.functionInit&&f.__options.functionInit.call(f,f,{origin:this}),f._trigger("init")),a.tooltipster.__instancesLatestArr.push(f)}),this},b.prototype={__init:function(b){this.__$tooltip=b,this.__$tooltip.css({left:0,overflow:"hidden",position:"absolute",top:0}).find(".tooltipster-content").css("overflow","auto"),this.$container=a('<div class="tooltipster-ruler"></div>').append(this.__$tooltip).appendTo(h.window.document.body)},__forceRedraw:function(){var a=this.__$tooltip.parent();this.__$tooltip.detach(),this.__$tooltip.appendTo(a)},constrain:function(a,b){return this.constraints={width:a,height:b},this.__$tooltip.css({display:"block",height:"",overflow:"auto",width:a}),this},destroy:function(){this.__$tooltip.detach().find(".tooltipster-content").css({display:"",overflow:""}),this.$container.remove()},free:function(){return this.constraints=null,this.__$tooltip.css({display:"",height:"",overflow:"visible",width:""}),this},measure:function(){this.__forceRedraw();var a=this.__$tooltip[0].getBoundingClientRect(),b={size:{height:a.height||a.bottom-a.top,width:a.width||a.right-a.left}};if(this.constraints){var c=this.__$tooltip.find(".tooltipster-content"),d=this.__$tooltip.outerHeight(),e=c[0].getBoundingClientRect(),f={height:d<=this.constraints.height,width:a.width<=this.constraints.width&&e.width>=c[0].scrollWidth-1};b.fits=f.height&&f.width}return h.IE&&h.IE<=11&&b.size.width!==h.window.document.documentElement.clientWidth&&(b.size.width=Math.ceil(b.size.width)+1),b}};var j=navigator.userAgent.toLowerCase();-1!=j.indexOf("msie")?h.IE=parseInt(j.split("msie")[1]):-1!==j.toLowerCase().indexOf("trident")&&-1!==j.indexOf(" rv:11")?h.IE=11:-1!=j.toLowerCase().indexOf("edge/")&&(h.IE=parseInt(j.toLowerCase().split("edge/")[1]));var k="tooltipster.sideTip";return a.tooltipster._plugin({name:k,instance:{__defaults:function(){return{arrow:!0,distance:6,functionPosition:null,maxWidth:null,minIntersection:16,minWidth:0,position:null,side:"top",viewportAware:!0}},__init:function(a){var b=this;b.__instance=a,b.__namespace="tooltipster-sideTip-"+Math.round(1e6*Math.random()),b.__previousState="closed",b.__options,b.__optionsFormat(),b.__instance._on("state."+b.__namespace,function(a){"closed"==a.state?b.__close():"appearing"==a.state&&"closed"==b.__previousState&&b.__create(),b.__previousState=a.state}),b.__instance._on("options."+b.__namespace,function(){b.__optionsFormat()}),b.__instance._on("reposition."+b.__namespace,function(a){b.__reposition(a.event,a.helper)})},__close:function(){this.__instance.content()instanceof a&&this.__instance.content().detach(),this.__instance._$tooltip.remove(),this.__instance._$tooltip=null},__create:function(){var b=a('<div class="tooltipster-base tooltipster-sidetip"><div class="tooltipster-box"><div class="tooltipster-content"></div></div><div class="tooltipster-arrow"><div class="tooltipster-arrow-uncropped"><div class="tooltipster-arrow-border"></div><div class="tooltipster-arrow-background"></div></div></div></div>');this.__options.arrow||b.find(".tooltipster-box").css("margin",0).end().find(".tooltipster-arrow").hide(),this.__options.minWidth&&b.css("min-width",this.__options.minWidth+"px"),this.__options.maxWidth&&b.css("max-width",this.__options.maxWidth+"px"),
this.__instance._$tooltip=b,this.__instance._trigger("created")},__destroy:function(){this.__instance._off("."+self.__namespace)},__optionsFormat:function(){var b=this;if(b.__options=b.__instance._optionsExtract(k,b.__defaults()),b.__options.position&&(b.__options.side=b.__options.position),"object"!=typeof b.__options.distance&&(b.__options.distance=[b.__options.distance]),b.__options.distance.length<4&&(void 0===b.__options.distance[1]&&(b.__options.distance[1]=b.__options.distance[0]),void 0===b.__options.distance[2]&&(b.__options.distance[2]=b.__options.distance[0]),void 0===b.__options.distance[3]&&(b.__options.distance[3]=b.__options.distance[1]),b.__options.distance={top:b.__options.distance[0],right:b.__options.distance[1],bottom:b.__options.distance[2],left:b.__options.distance[3]}),"string"==typeof b.__options.side){var c={top:"bottom",right:"left",bottom:"top",left:"right"};b.__options.side=[b.__options.side,c[b.__options.side]],"left"==b.__options.side[0]||"right"==b.__options.side[0]?b.__options.side.push("top","bottom"):b.__options.side.push("right","left")}6===a.tooltipster._env.IE&&b.__options.arrow!==!0&&(b.__options.arrow=!1)},__reposition:function(b,c){var d,e=this,f=e.__targetFind(c),g=[];e.__instance._$tooltip.detach();var h=e.__instance._$tooltip.clone(),i=a.tooltipster._getRuler(h),j=!1,k=e.__instance.option("animation");switch(k&&h.removeClass("tooltipster-"+k),a.each(["window","document"],function(d,k){var l=null;if(e.__instance._trigger({container:k,helper:c,satisfied:j,takeTest:function(a){l=a},results:g,type:"positionTest"}),1==l||0!=l&&0==j&&("window"!=k||e.__options.viewportAware))for(var d=0;d<e.__options.side.length;d++){var m={horizontal:0,vertical:0},n=e.__options.side[d];"top"==n||"bottom"==n?m.vertical=e.__options.distance[n]:m.horizontal=e.__options.distance[n],e.__sideChange(h,n),a.each(["natural","constrained"],function(a,d){if(l=null,e.__instance._trigger({container:k,event:b,helper:c,mode:d,results:g,satisfied:j,side:n,takeTest:function(a){l=a},type:"positionTest"}),1==l||0!=l&&0==j){var h={container:k,distance:m,fits:null,mode:d,outerSize:null,side:n,size:null,target:f[n],whole:null},o="natural"==d?i.free():i.constrain(c.geo.available[k][n].width-m.horizontal,c.geo.available[k][n].height-m.vertical),p=o.measure();if(h.size=p.size,h.outerSize={height:p.size.height+m.vertical,width:p.size.width+m.horizontal},"natural"==d?c.geo.available[k][n].width>=h.outerSize.width&&c.geo.available[k][n].height>=h.outerSize.height?h.fits=!0:h.fits=!1:h.fits=p.fits,"window"==k&&(h.fits?"top"==n||"bottom"==n?h.whole=c.geo.origin.windowOffset.right>=e.__options.minIntersection&&c.geo.window.size.width-c.geo.origin.windowOffset.left>=e.__options.minIntersection:h.whole=c.geo.origin.windowOffset.bottom>=e.__options.minIntersection&&c.geo.window.size.height-c.geo.origin.windowOffset.top>=e.__options.minIntersection:h.whole=!1),g.push(h),h.whole)j=!0;else if("natural"==h.mode&&(h.fits||h.size.width<=c.geo.available[k][n].width))return!1}})}}),e.__instance._trigger({edit:function(a){g=a},event:b,helper:c,results:g,type:"positionTested"}),g.sort(function(a,b){if(a.whole&&!b.whole)return-1;if(!a.whole&&b.whole)return 1;if(a.whole&&b.whole){var c=e.__options.side.indexOf(a.side),d=e.__options.side.indexOf(b.side);return d>c?-1:c>d?1:"natural"==a.mode?-1:1}if(a.fits&&!b.fits)return-1;if(!a.fits&&b.fits)return 1;if(a.fits&&b.fits){var c=e.__options.side.indexOf(a.side),d=e.__options.side.indexOf(b.side);return d>c?-1:c>d?1:"natural"==a.mode?-1:1}return"document"==a.container&&"bottom"==a.side&&"natural"==a.mode?-1:1}),d=g[0],d.coord={},d.side){case"left":case"right":d.coord.top=Math.floor(d.target-d.size.height/2);break;case"bottom":case"top":d.coord.left=Math.floor(d.target-d.size.width/2)}switch(d.side){case"left":d.coord.left=c.geo.origin.windowOffset.left-d.outerSize.width;break;case"right":d.coord.left=c.geo.origin.windowOffset.right+d.distance.horizontal;break;case"top":d.coord.top=c.geo.origin.windowOffset.top-d.outerSize.height;break;case"bottom":d.coord.top=c.geo.origin.windowOffset.bottom+d.distance.vertical}"window"==d.container?"top"==d.side||"bottom"==d.side?d.coord.left<0?c.geo.origin.windowOffset.right-this.__options.minIntersection>=0?d.coord.left=0:d.coord.left=c.geo.origin.windowOffset.right-this.__options.minIntersection-1:d.coord.left>c.geo.window.size.width-d.size.width&&(c.geo.origin.windowOffset.left+this.__options.minIntersection<=c.geo.window.size.width?d.coord.left=c.geo.window.size.width-d.size.width:d.coord.left=c.geo.origin.windowOffset.left+this.__options.minIntersection+1-d.size.width):d.coord.top<0?c.geo.origin.windowOffset.bottom-this.__options.minIntersection>=0?d.coord.top=0:d.coord.top=c.geo.origin.windowOffset.bottom-this.__options.minIntersection-1:d.coord.top>c.geo.window.size.height-d.size.height&&(c.geo.origin.windowOffset.top+this.__options.minIntersection<=c.geo.window.size.height?d.coord.top=c.geo.window.size.height-d.size.height:d.coord.top=c.geo.origin.windowOffset.top+this.__options.minIntersection+1-d.size.height):(d.coord.left>c.geo.window.size.width-d.size.width&&(d.coord.left=c.geo.window.size.width-d.size.width),d.coord.left<0&&(d.coord.left=0)),e.__sideChange(h,d.side),c.tooltipClone=h[0],c.tooltipParent=e.__instance.option("parent").parent[0],c.mode=d.mode,c.whole=d.whole,c.origin=e.__instance._$origin[0],c.tooltip=e.__instance._$tooltip[0],delete d.container,delete d.fits,delete d.mode,delete d.outerSize,delete d.whole,d.distance=d.distance.horizontal||d.distance.vertical;var l=a.extend(!0,{},d);if(e.__instance._trigger({edit:function(a){d=a},event:b,helper:c,position:l,type:"position"}),e.__options.functionPosition){var m=e.__options.functionPosition.call(e,e.__instance,c,l);m&&(d=m)}i.destroy();var n,o;"top"==d.side||"bottom"==d.side?(n={prop:"left",val:d.target-d.coord.left},o=d.size.width-this.__options.minIntersection):(n={prop:"top",val:d.target-d.coord.top},o=d.size.height-this.__options.minIntersection),n.val<this.__options.minIntersection?n.val=this.__options.minIntersection:n.val>o&&(n.val=o);var p;p=c.geo.origin.fixedLineage?c.geo.origin.windowOffset:{left:c.geo.origin.windowOffset.left+c.geo.window.scroll.left,top:c.geo.origin.windowOffset.top+c.geo.window.scroll.top},d.coord={left:p.left+(d.coord.left-c.geo.origin.windowOffset.left),top:p.top+(d.coord.top-c.geo.origin.windowOffset.top)},e.__sideChange(e.__instance._$tooltip,d.side),c.geo.origin.fixedLineage?e.__instance._$tooltip.css("position","fixed"):e.__instance._$tooltip.css("position",""),e.__instance._$tooltip.css({left:d.coord.left,top:d.coord.top,height:d.size.height,width:d.size.width}).find(".tooltipster-arrow").css({left:"",top:""}).css(n.prop,n.val),e.__instance._$tooltip.appendTo(e.__instance.option("parent")),e.__instance._trigger({type:"repositioned",event:b,position:d})},__sideChange:function(a,b){a.removeClass("tooltipster-bottom").removeClass("tooltipster-left").removeClass("tooltipster-right").removeClass("tooltipster-top").addClass("tooltipster-"+b)},__targetFind:function(a){var b={},c=this.__instance._$origin[0].getClientRects();if(c.length>1){var d=this.__instance._$origin.css("opacity");1==d&&(this.__instance._$origin.css("opacity",.99),c=this.__instance._$origin[0].getClientRects(),this.__instance._$origin.css("opacity",1))}if(c.length<2)b.top=Math.floor(a.geo.origin.windowOffset.left+a.geo.origin.size.width/2),b.bottom=b.top,b.left=Math.floor(a.geo.origin.windowOffset.top+a.geo.origin.size.height/2),b.right=b.left;else{var e=c[0];b.top=Math.floor(e.left+(e.right-e.left)/2),e=c.length>2?c[Math.ceil(c.length/2)-1]:c[0],b.right=Math.floor(e.top+(e.bottom-e.top)/2),e=c[c.length-1],b.bottom=Math.floor(e.left+(e.right-e.left)/2),e=c.length>2?c[Math.ceil((c.length+1)/2)-1]:c[c.length-1],b.left=Math.floor(e.top+(e.bottom-e.top)/2)}return b}}}),a});


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
        } urunler - ve - hizmetler / mikro - jump
    });
};


var iletisimJsonData = {
    "iletisim/bize-ulasin": "iletisimFormu_bize-ulasim",
    "/": "iletisimFormu_ana-sayfa"
}


var ussJsonData = {
    "/": "urunSecmeSihirbazı_ana-sayfa",
    "urunler-ve-hizmetler/mikro-run": "urunSecmeSihirbazı_run",
    "urunler-ve-hizmetler/mikro-run/e-donusum-cozumleri": "urunSecmeSihirbazı_run",
    "urunler-ve-hizmetler/mikro-run/satis-ve-musteri-yonetimi": "urunSecmeSihirbazı_run",
    "urunler-ve-hizmetler/mikro-run/gider-ve-parasal-hareketlerin-yonetimi": "urunSecmeSihirbazı_run",
    "urunler-ve-hizmetler/mikro-run/satinalma-ve-tedarikci-yonetimi": "urunSecmeSihirbazı_run",
    "urunler-ve-hizmetler/mikro-run/stok-urun-ve-hizmet-yonetimi": "urunSecmeSihirbazı_run",
    "urunler-ve-hizmetler/mikro-jump": "urunSecmeSihirbazı_jump",
    "urunler-ve-hizmetler/mikro-jump/ana-paket": "urunSecmeSihirbazı_jump",
    "urunler-ve-hizmetler/mikro-jump/e-donusum-cozumleri": "urunSecmeSihirbazı_jump",
    "urunler-ve-hizmetler/mikro-jump/isletme-yonetimi-cozumleri": "urunSecmeSihirbazı_jump",
    "urunler-ve-hizmetler/mikro-jump/sektorel-cozumler": "urunSecmeSihirbazı_jump",
    "urunler-ve-hizmetler/mikro-jump/entegrasyon-cozumleri": "urunSecmeSihirbazı_jump",
    "urunler-ve-hizmetler/mikro-fly": "urunSecmeSihirbazı_fly",
    "urunler-ve-hizmetler/mikro-fly/ana-paket": "urunSecmeSihirbazı_fly",
    "urunler-ve-hizmetler/mikro-fly/e-donusum-cozumleri": "urunSecmeSihirbazı_fly",
    "urunler-ve-hizmetler/mikro-fly/isletme-yonetimi-cozumleri": "urunSecmeSihirbazı_fly",
    "urunler-ve-hizmetler/mikro-fly/sektorel-cozumler": "urunSecmeSihirbazı_fly",
    "urunler-ve-hizmetler/mikro-fly/entegrasyon-cozumleri": "urunSecmeSihirbazı_fly",
    "urunler-ve-hizmetler/mikro-musavir": "urunSecmeSihirbazı_mikro-usvir"
}


var demoTalepJsonData = {
    "e-donusum/e-fatura": "demoTalebi_e-fatura",
    "e-donusum/e-arsiv": "demoTalebi_e-arsiv",
    "e-donusum/e-defter": "demoTalebi_e-defter",
    "e-donusum/e-bordro": "demoTalebi_e-bordro",
    "e-donusum/e-mutabakat": "demoTalebi_e-mutabakat",
    "e-donusum/mikro-kep": "demoTalebi_mikro-kep",
    "e-donusum/e-irsaliye": "demoTalebi_e-irsaliye",
    "e-donusum/e-mustahsil-makbuzu": "demoTalebi_e-mustahsil-makbuzu",
    "e-donusum/e-serbest-meslek-makbuzu": "demoTalebi_e-serbest-meslek-makbuzu",
    "ucretsiz-demo-talep?product=RUN": "demoTalebi_run",
    "urunler-ve-hizmetler/mikro-run": "demoTalebi_run",
    "ucretsiz-demo-talep?product=JUMP": "demoTalebi_jump",
    "urunler-ve-hizmetler/mikro-jump": "demoTalebi_jump",
    "urunler-ve-hizmetler/genel-bakis": "demoTalebi_fly",
    "urunler-ve-hizmetler/mikro-fly": "demoTalebi_fly",
    "ucretsiz-demo-talep?product=MUSAVIR": "demoTalebi_musavir",
    "urunler-ve-hizmetler/mikro-musavir": "demoTalebi_musavir",
    "/": "demoTalebi_ana-sayfa"
}


var hangiFormAction = null;


var formtetik = 0;

function formSubmit(formId, formPost, formType, dataLayerLabel) {

    hangiFormAction = formType;




    $('#' + formId).submit(function (e) {


        if (formtetik == 0) {

            formtetik = 1;

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

                function getPath(s) {
                    var i = s.indexOf('://') + 3, j;
                    i = s.indexOf('/', i) + 1;  // find first / (ie. after .com) and start at the next char
                    if (i === 0) return '';
                    j = s.indexOf('?', i); // find first ? after first / (as before doesn't matter anyway)
                    if (j == -1) j = s.length; // if no ?, use until end of string
                    while (s[j - 1] === '/') j = j - 1; // get rid of ending /s
                    return s.slice(i, j); // return what we've ended up at
                }

                var pushDataLayerContent = null;
                var getmon = (getPath(document.referrer) == "" ? "mikro/anasayfa" : getPath(document.referrer))

                dataLayer.push({
                    'Category': "form",
                    'Action': "gonder",
                    'Label': formType + ' + ' + getmon,
                    'event': 'gaEvent'
                });

                $('#' + formId).attr('validated', true);
                isFormSubmit = false;
                $('#' + formId).submit();
                formtetik = 0;

                //$.ajax({
                //    type: 'POST',
                //    url: '/urun-secme-sihirbazi/SendMail?formId=' + formId,
                //    data: dt,
                //    success: function (msg) {
                //        if (msg == true) {
                //            // $('#PostControl').val('true');
                //            // return true;
                //            $('#' + formId).attr('validated', true);
                //            isFormSubmit = false;
                //            $('#' + formId).submit();
                //            formtetik = 0;
                //        } else {
                //            console.log(msg);
                //            return false;
                //        }
                //    }
                //});
                //return false;
            }
            return true;

        }
        else {
            console.log('form tetiklenemez');
        }

        
    });
}


function contactFormSubmit(formId) {

    hangiFormAction = "iletişim-form-anasayfa";

    $('#' + formId).submit(function (e) {
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

            dataLayer.push({
                'Category': "form",
                'Action': "gonder",
                'Label': "iletisimFormu_ana-sayfa",
                'event': 'gaEvent'
            });

            $.ajax({
                type: 'POST',
                url: '/urun-secme-sihirbazi/ContactSendMail?formId=' + formId,
                data: dt,
                success: function (msg) {
                    if (msg == true) {
                        window.location.href = "/tesekkurler";

                    } else {
                        $(".errorMessage").show();
                        $(".errorMessage").html("Teknik bir hata oluştu daha sonra tekrar deneyiniz");
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

function validateNumber(event) {
    var key = window.event ? event.keyCode : event.which;
    if (event.keyCode === 8 || event.keyCode === 46) {
        return true;
    } else if ( key < 48 || key > 57 ) {
        return false;
    } else {
        return true;
    }
};

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

        if ($(this).val().length > 10)
            return false;
    });
    
    $('[class^=just]').keypress(validateNumber);

    $('input, input[required], select[required], textarea[required]').on("invalid", function (e) {

        e.preventDefault();

        $(this).each(function () {
            console.log($(this).attr("message"))
            $(".data-message").append('<span id="message">' + $(this).data("message") + "</span>")
        })
    
    //    // $(this).css('border-color', 'red');
    //    //$(this).parent().css('text-shadow','-1px 0 red, 0 1px red, 1px 0 red, 0 -1px red;');
    });


    $('body').append(
        '<div class="modal-alert">' +
            '<div class="modal-content"></div>'+
            '<span id="modal-close">Tamam</a>' +
        '</div>' +
        '<div class="modal-bg"></div>'
    );

    $("input, select, textarea").on("invalid", function (t) {
        t.preventDefault();

        formtetik = 0;
        $(this).each(function () {
            $('.modal-content').append('<span>' + $(this).attr("message") + '</span>');

            dataLayer.push({
                'Category': hangiFormAction,
                'Action': "formError",
                'Label': $(this).attr("message"),
                'event': 'gaEvent'
            });

        });
        $('.modal-bg').show();
        $(".modal-alert").fadeIn();
        // $(this).css("border-color", "red") 
    });

    $('body').on("click", "#modal-close", function () {

        $('.modal-bg').hide();
        $(".modal-alert").hide();
        $('.modal-content').html("");
        
    })

    //$('select[required]').on("change", function (e) {
    //    if ($(this)[0].selectedIndex == 0) {
    //        e.preventDefault();
    //        $(this).css('border-color', 'red');
    //    }
    //});



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
        //$('.phone-hide').text("+90 (850) 225 10 10 (Çağrı Merkezi)");
        var phone = $(this).data('phone');
        $(this).text(phone);
        dataLayer.push({
            'Category': "telefon",
            'Action': "tiklama",
            'Label': "cagriMerkezi",
            'event': 'gaEvent'
        });
    });

    $('.phone-hide-pbx').click(function () {
        var pbx = $(this).data('pbx');
        //$('.phone-hide-pbx').text("+90 (212) 806 45 45 (PBX)");
        $(this).text(pbx);
        dataLayer.push({
            'Category': "telefon",
            'Action': "tiklama",
            'Label': "pbx",
            'event': 'gaEvent'
        });
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

    $('select').change(function () {
        $('.wizard-form-left > div').removeClass('wizardshow');
        if ($("#00N0Y00000QeR9j option:selected").attr('data-field') != null) {
            $("." + $("#00N0Y00000QeR9j option:selected").attr('data-field')).addClass('wizardshow');

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

    //$('input, input[required], select[required], textarea[required]').on("invalid", function (e) {
    //    e.preventDefault();
    //    $(this).css('border-color', 'red');
    //});
    


    $('.phones').on('keypress', function (e) {
        if (!$(this).val() && e.which == 48) {
            return false;
        }
    });

    $('.phones').tooltipster({
        trigger: 'click'
    });
    

    
});
