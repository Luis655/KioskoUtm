$('.awSlider .carousel').carousel({
	pause: "hover",
  interval: 2000
});

var startImage = $('.awSlider .item.active > img').attr('src');
$('.awSlider').append('<img src="' + startImage + '">');

$('.awSlider .carousel').on('slid.bs.carousel', function () {
 var bscn = $(this).find('.item.active > img').attr('src');
	$('.awSlider > img').attr('src',bscn);
});


/* 
Philips ambilight tv
Üzerine gleince duruyor slide
*/