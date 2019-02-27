$(document).ready(function(e) {


	$(function(){
	
	var sure_slider_box = 3000;
	var toplamli_slider_box = $(".slider ul li").length;
	
	var liwidth_slider_box = 985;
	var toplamwidth_slider_box = liwidth_slider_box * toplamli_slider_box ;
	var lideger_slider_box = 0;
	$(".slider ul").css("width", toplamwidth_slider_box + "px")
	
	
	$(".slider_degis_icons_right").click(function(){
	if(lideger_slider_box < toplamli_slider_box - 1){
	lideger_slider_box++;
	yeniwidth_slider_box = liwidth_slider_box * lideger_slider_box;
	$(".slider ul").animate({marginLeft: "-" + yeniwidth_slider_box + "px"}, 500)
	
	$('.slider_degis_box ul li').removeClass("actt");
	$('.slider_degis_box ul li:eq('+lideger_slider_box+')').addClass("actt");
	
	}
	else
	{
	lideger_slider = 0 ;
	$(".slider ul").animate({marginLeft: "0"}, 500)
	}
	})
	
	
	
	$(".slider_degis_icons_left").click(function(){
	if(lideger_slider_box > 0){
	lideger_slider_box--;
	yeniwidth_slider_box = liwidth_slider_box * lideger_slider_box;
	$(".slider ul").animate({marginLeft: "-" + yeniwidth_slider_box + "px"}, 500)
	
	$('.slider_degis_box ul li').removeClass("actt");
	$('.slider_degis_box ul li:eq('+lideger_slider_box+')').addClass("actt");
	
	}
	})
	
	
	
	$('.slider_degis_box ul li:first').addClass("actt");
	
	$('.slider_degis_box ul li').click(function(){
	var indis_slider_box = $(this).index();
		
	
	$('.slider_degis_box ul li').removeClass("actt");
	$(this).addClass("actt");
	
	deger_slider_box=indis_slider_box;
	
	var yenideger_slider_box = deger_slider_box * 985;
	$(".slider ul").animate({marginLeft: "-" + yenideger_slider_box + "px"}, 500)
	
	return false;  // Fonksiyonunun daha işlem yapmasına gerek kalmadığını belirtiyoruz.
	 });
	
	
	$.oto_slider_box = function(){
	if(lideger_slider_box < toplamli_slider_box -1)
	{
	lideger_slider_box++;
	yeniwidth_slider_box = liwidth_slider_box * lideger_slider_box;
	$(".slider ul").animate({marginLeft: "-" + yeniwidth_slider_box + "px"}, 500)
	$('.slider_degis_box ul li').removeClass("actt");
	$('.slider_degis_box ul li:eq('+lideger_slider_box+')').addClass("actt");
	}
	else
	{
	lideger_slider_box = 0 ;
	$(".slider ul").animate({marginLeft: "0"}, 500)
	$('.slider_degis_box ul li').removeClass("actt");
	$('.slider_degis_box ul li:eq('+lideger_slider_box+')').addClass("actt");
	}
	
	}
	
	var don_slider_box = setInterval("$.oto_slider_box()", sure_slider_box);
	
	$(".slider").hover(function(){
	
	clearInterval(don_slider_box)
	
	}, function(){
	don_slider_box = setInterval("$.oto_slider_box()", sure_slider_box);
	})

	$(".slider_degis_box").hover(function(){
	
	clearInterval(don_slider_box)
	
	}, function(){
	don_slider_box = setInterval("$.oto_slider_box()", sure_slider_box);
	})
	
	});

//////////////////////////////////////////////////////////////////////////

	$(function(){
	
	var sure_bronz = 4000;
	var toplamli_bronz = $(".duyuru ul li").length;
	
	
	var liwidth_bronz = 910;
	var toplamwidth_bronz = liwidth_bronz * toplamli_bronz ;
	var lideger_bronz = 0;
	$(".duyuru ul").css("width", toplamwidth_bronz + "px")
	
	$(".duyuru_degis_right").click(function(){
	if(lideger_bronz < toplamli_bronz - 1){
	lideger_bronz++;
	yeniwidth_bronz = liwidth_bronz * lideger_bronz;
	$(".duyuru ul").animate({marginLeft: "-" + yeniwidth_bronz + "px"}, 500)
	}
	else
	{
	lideger_bronz = 0 ;
	$(".duyuru ul").animate({marginLeft: "0"}, 500)
	}
	})
	
	
	
	$(".duyuru_degis_left").click(function(){
	if(lideger_bronz > 0){
	lideger_bronz--;
	yeniwidth_bronz = liwidth_bronz * lideger_bronz;
	$(".duyuru ul").animate({marginLeft: "-" + yeniwidth_bronz + "px"}, 500)
	}
	})
	
	
	$.oto_bronz = function(){
	if(lideger_bronz < toplamli_bronz - 1)
	{
	lideger_bronz++;
	yeniwidth_bronz = liwidth_bronz * lideger_bronz;
	$(".duyuru ul").animate({marginLeft: "-" + yeniwidth_bronz + "px"}, 500)
	}
	else
	{
	lideger_bronz = 0 ;
	$(".duyuru ul").animate({marginLeft: "0"}, 500)
	}
	
	}
	
	var don_bronz = setInterval("$.oto_bronz()", sure_bronz);
	
	$(".duyuru").hover(function(){
	
	clearInterval(don_bronz)
	
	}, function(){
	don_bronz = setInterval("$.oto_bronz()", sure_bronz);
	})

	$(".duyuru_degis_bg").hover(function(){
	
	clearInterval(don_bronz)
	
	}, function(){
	don_bronz = setInterval("$.oto_bronz()", sure_bronz);
	})
	
	
	
	});





});