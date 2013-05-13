$(document).ready(function()
{
	var container = $('#small-pics');
	var smallContainers = container.find('div.small-pic');
	var nextPictureToShow = 0;
	var refreshedIntervalId;
	var imageArray = ["puppy-1.jpg", "puppy-2.jpg", "puppy-3.jpg", "puppy-4.jpg", "puppy-5.jpg"];
	var imgHolder = document.getElementById('current-picture');
	
	$(smallContainers).each(function(index)
	{
		var $this = $(this);
		$(this).mouseover(function()
		{
			$(this).addClass('hovered-pic');
		});
		
		$(this).mouseout(function()	
		{	
			$(this).removeClass('hovered-pic');
		});
		
		$(this).click(function()
		{
			changePic(index);
		});
	}); 
	
	$("#left-arrow button").click(function()
	{
		showPreviousPic();
	});
	
	$("#right-arrow button").click(function()
	{
		showNextPic();
	});
	
	startChangePic();

	function startChangePic()
	{
		refreshedIntervalId = setInterval(rotatePics, 3500);
	}

	function rotatePics()
	{
		var array = eval("imageArray");
		var container = eval("imgHolder");
		if (nextPictureToShow >= array.length)
		{
			nextPictureToShow = 0;
		}
		var urlToImg = "url(images/" + array[nextPictureToShow] + ")";
		$(container).css("background", urlToImg);
		$(container).css("backgroundRepeat", "no-repeat");
		$(container).css("backgroundPosition", "center");
		$(".small-pic").removeClass('clicked');
		$(".small-pic").eq(nextPictureToShow).addClass('clicked');
		
		nextPictureToShow += 1;
	}

	function showPreviousPic()
	{
		if (nextPictureToShow == 0 || nextPictureToShow == 1)
		{
			nextPictureToShow = (imageArray.length) - 1;
		}
		
		else
		{
			nextPictureToShow = nextPictureToShow - 2;
		}
		
		clearInterval(refreshedIntervalId);
		rotatePics();
		startChangePic();
	}

	function showNextPic()
	{
		if (nextPictureToShow == 0)
		{
			nextPictureToShow += 1;
		}
		clearInterval(refreshedIntervalId);
		rotatePics();	
		startChangePic();
	}

	function changePic(itemNumber)
	{
		nextPictureToShow = itemNumber;
		clearInterval(refreshedIntervalId);
		rotatePics();	
		startChangePic();
	}
}); 

