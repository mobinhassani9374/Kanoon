$(document).ready(function(){
    $('[data-toggle="tooltip"]').tooltip();

    $('.grid').isotope({
        itemSelector: '.grid-item',
        isOriginLeft: false     
    });

    toastr.options = {
        "debug": false,
        "positionClass": "toast-bottom-left",
        "onclick": null,
        "fadeIn": 300,
        "fadeOut": 1000,
        "timeOut": 40000,
        "extendedTimeOut": 1000,
      }
});