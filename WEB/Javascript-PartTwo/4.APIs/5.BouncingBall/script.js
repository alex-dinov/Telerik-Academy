var ball = document.getElementById("ball");
var directionTop = 1;
var directionLeft = 1;
var leftPos = 20;
var topPos = 100;

setInterval(function () {
    topPos += directionTop;
    leftPos += directionLeft;
    if (topPos == 390) {
        directionTop *= -1;
    }
    if (leftPos==490) {
        directionLeft *= -1;
    }
    if (topPos==10) {
        directionTop *= -1;
    }
    if (leftPos==10) {
        directionLeft *= -1;
    }

    ball.style.left = leftPos + "px";
    ball.style.top = topPos + "px";
}, 5);