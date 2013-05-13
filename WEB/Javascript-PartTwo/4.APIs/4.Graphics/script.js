var canvas = document.getElementById('canvas');

var ctx = canvas.getContext('2d');
ctx.fillStyle="#975B5B";

// House
drawRect(600, 150, 200, 160);

	// Roof
	ctx.beginPath();
	ctx.moveTo(800,150);
	ctx.lineTo(700,50);
	ctx.lineTo(600,150);
	ctx.closePath();
	ctx.fill();
	ctx.stroke();

	// Chimney
	ctx.beginPath();
	ctx.moveTo(760, 120);
	ctx.lineTo(760, 70);
	ctx.lineTo(740, 70);
	ctx.lineTo(740, 120);
	ctx.stroke();
	ctx.fill();
	ctx.closePath();

	ctx.strokeStyle = "#000";
	ctx.lineWidth = 1;
	drawEllipse(740, 70, 20, 5);

	// Windows
	ctx.strokeStyle = "#975B5B";
	ctx.fillStyle = "#000";
	drawWindow(615, 170, 70, 50);
	drawWindow(715, 170, 70, 50);
	drawWindow(715, 240, 70, 50);

	// Door
	ctx.strokeStyle = "#000";
	ctx.fillStyle = "#975B5B";
	drawRect(620, 245, 60, 65);
	ctx.moveTo(650, 245);
	ctx.lineTo(650, 310);
	ctx.moveTo(640, 290);
	ctx.arc(640, 290, 3, 0, Math.PI * 2, true);
	ctx.moveTo(660, 290);
	ctx.arc(660, 290, 3, 0, Math.PI * 2, true);
	ctx.stroke();
	ctx.fill();

// Head and Bike
ctx.fillStyle = '90CAD7';
ctx.strokeStyle = '1F515C';
ctx.lineWidth = 4;
	// Head
	drawEllipse(200, 150, 100, 90);
		// Eyes
		drawEllipse(220, 170, 20, 10);
		ctx.fillStyle = '1F515C';
		drawEllipse(225, 170, 4, 10);
		ctx.fill();
		ctx.fillStyle = '90CAD7';
		drawEllipse(260, 170, 20, 10);
		ctx.fillStyle = '1F515C';
		drawEllipse(265, 170, 4, 10);
		ctx.fill();
		// Nouse
		ctx.moveTo(250, 185);
		ctx.lineTo(235, 210);
		ctx.moveTo(235, 210);
		ctx.lineTo(250, 210);
		ctx.stroke();
		// Mouth
		ctx.fillStyle = '90CAD7';
		drawEllipse(230, 220, 30, 10);
		// Hat
		ctx.fillStyle = '396693';
		drawEllipse(190, 138, 120, 20);
		drawRect(225, 80, 50, 60);
		drawEllipse(225, 138, 50, 10);
		ctx.strokeStyle = '396693';
		drawRect(228, 138, 44, 5);
		ctx.strokeStyle = '1F515C';
		drawEllipse(225, 70, 50, 15);
	// Bike
	ctx.fillStyle = '90CAD7';
	ctx.strokeStyle = '1F515C';
	ctx.lineWidth = 3;
		// Tires
		drawEllipse(140, 300, 100, 100);
		drawEllipse(340, 300, 100, 100);
		// Frames
		ctx.moveTo(190, 350);
		ctx.lineTo(250, 280);
		ctx.lineTo(375, 280);
		ctx.lineTo(275, 350);
		ctx.lineTo(190, 350);
		// Chain wheel
		ctx.moveTo(290, 350);
		ctx.arc(278, 350, 10, 0, Math.PI * 2, true);
		// Pedals
		ctx.moveTo(275, 343);
		ctx.lineTo(260, 330);
		ctx.moveTo(283, 358);
		ctx.lineTo(295, 367);
		// Seat
		ctx.moveTo(280, 350);
		ctx.lineTo(240, 250);
		ctx.moveTo(220, 250);
		ctx.lineTo(260, 250);
		// Steering wheel
		ctx.moveTo(390, 350);
		ctx.lineTo(370, 240);
		ctx.lineTo(330, 250);
		ctx.moveTo(370, 240);
		ctx.lineTo(400, 210);
		ctx.stroke();

function drawLine(from, to) {
	ctx.moveTo(from.left, from.top);
	ctx.lineTo(to.left, to.top);
}

function drawEllipse(x, y, w, h) {
	var kappa = .5522848,
	  ox = (w / 2) * kappa, 
	  oy = (h / 2) * kappa, 
	  xe = x + w,           
	  ye = y + h,           
	  xm = x + w / 2,       
	  ym = y + h / 2;       

	ctx.beginPath();
	ctx.moveTo(x, ym);
	ctx.bezierCurveTo(x, ym - oy, xm - ox, y, xm, y);
	ctx.bezierCurveTo(xm + ox, y, xe, ym - oy, xe, ym);
	ctx.bezierCurveTo(xe, ym + oy, xm + ox, ye, xm, ye);
	ctx.bezierCurveTo(xm - ox, ye, x, ym + oy, x, ym);
	ctx.stroke();
	ctx.fill();
	ctx.closePath();
}

function drawWindow(left, top, width, height) {
	drawRect(left, top, width, height);
	ctx.moveTo(left, top + height / 2);
	ctx.lineTo(left + width, top + height / 2);
	ctx.moveTo(left + width / 2, top);
	ctx.lineTo(left + width / 2, top + height);
	ctx.stroke();
}

function drawRect(left, top, width, height) {
	ctx.strokeRect(left,top,width, height);
	ctx.fillRect(left + 1, top + 1, width - 2, height - 2);
}