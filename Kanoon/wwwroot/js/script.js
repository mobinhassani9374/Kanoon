$(document).ready(function(){
    $('[data-toggle="tooltip"]').tooltip();

    $('.grid').isotope({
        itemSelector: '.grid-item',
        isOriginLeft: false     
    });
});