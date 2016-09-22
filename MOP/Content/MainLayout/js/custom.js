
// Modal popup scripts
(function ($) {
    "use strict";
    function centerModal() {
        $(this).css('display', 'block');
        var $dialog  = $(this).find(".modal-dialog"),
        offset       = ($(window).height() - $dialog.height()) / 2,
        bottomMargin = parseInt($dialog.css('marginBottom'), 10);
		
		
        if(offset < bottomMargin) offset = bottomMargin;
        $dialog.css("margin-top", offset);
    }

    $(document).on('show.bs.modal', '.modal', centerModal);
    $(window).on("resize", function () {
        $('.modal:visible').each(centerModal);
    });
}(jQuery));

$('#MemberList').on('show.bs.modal', function(e) {
    document.querySelector('meta[name="viewport"]').content = 'width=device-width, minimum-scale=1.0, maximum-scale=1.0, initial-scale=1.0';
}); 

$(document).ready(function () {
    $('#LoginScreen').modal('show');
});

//Show hide popups for main navigation toggle
$(function() {
    $(document).on('click', '.main_link', function(e) {
		  e.preventDefault();

      href = $(this).attr('href');
   MyModel=$(this).attr('data-target');
  if($(MyModel).hasClass("in")){
   $(MyModel).modal('hide');
  }else{
    $(".modal").each(function() {
   $(this).modal("hide"); 
     });
     
     $(MyModel).modal('show');
   $.get(href , function(result) {
    $(MyModel+" .modal-content").html(result);
   });
  }
});
});

// Script added for closing child popups seperately and keeping child popups to the top of main
$(document)  
  .on('show.bs.modal', '.modal.main-popup, .modal.child-modal', function(event) {
    $(this).appendTo($('body'));
  })
  .on('shown.bs.modal', '.modal.main-popup.in, .modal.child-modal.in', function(event) {
    setModalsAndBackdropsOrder();
  })
  .on('hidden.bs.modal', '.modal.main-popup, .modal.child-modal', function(event) {
    setModalsAndBackdropsOrder();
  });

function setModalsAndBackdropsOrder() {  
  var modalZIndex = 1024;
  $('.modal.main-popup.in, .modal.child-modal.in').each(function(index) {
    var $modal = $(this);
    modalZIndex++;
    $modal.css('zIndex', modalZIndex);
    $modal.next('.modal-backdrop.in').addClass('hidden').css('zIndex', modalZIndex - 1);
});
  $('.modal.main-popup.in:visible:last, .modal.child-modal.in:visible:last').focus().next('.modal-backdrop.in').removeClass('hidden');
}

// This adds 'placeholder' to the items in ie9 and below. 
jQuery(function() {
   jQuery.support.placeholder = false;
   test = document.createElement('input');
   if('placeholder' in test) jQuery.support.placeholder = true;
});

//$(function() {
//   if(!$.support.placeholder) { 
//      var active = document.activeElement;
//      $(':text, :password').focus(function () {
//         if ($(this).attr('placeholder') != '' && $(this).val() == $(this).attr('placeholder')) {
//            $(this).val('').removeClass('hasPlaceholder');
//         }
//      }).blur(function () {
//         if ($(this).attr('placeholder') != '' && ($(this).val() == '' || $(this).val() == $(this).attr('placeholder'))) {
//            $(this).val($(this).attr('placeholder')).addClass('hasPlaceholder');
//         }
//      });
//      $(':text, :password').blur();
//      $(active).focus();
//      //$('form:eq(0)').submit(function () {
//      //   $(':text.hasPlaceholder, :password.hasPlaceholder').val('');
//      //});
//   }
//});

$('a').mouseup(function(e){
    var button = 'left click';
    if(e.which === 2){
        button = 'middle click';
    }
    else if(e.which == 3){
        button = 'right click';
    }
    $('#log').append('<span>' +button +'('+e.which +')</span><br/>');
    
    e.preventDefault();
    e.stopPropagation();
});


$(document).click(function(e){
            if (e.which != 3) {
                e.preventDefault();
                return false;
            }
});