
var dir     = { up: 0, down: 1, left: 2, right: 3};
var canvas  = document.getElementById('canvas');
var width   = canvas.width;
var height  = canvas.height;
var ctx     = canvas.getContext('2d');
var nx      = 40;
var ny      = 29;
var dx      = width  / nx;
var dy      = height / ny;
var playing = false;
var score   = 0;
var snake, direction, length, head, tail, food;

function play() { start(); playing = true;  };
function lose() { alert('\nGame Over\n' + '\nYour Score: ' + score); playing = false; score=0; };

function start() {
  snake = [];
  direction = dir.right;
  head = tail = { x: 0, y: 10 };
  length = 5;
  while(--length) increase();
  food = newFood();
  paint(ctx);
};

function update() {
  if (playing) {

    increase(snake.shift());
    decrease();
    if (checkCollision(head)) lose();
    else if (food.x == head.x && food.y == head.y) {
      length += 1;
      food = newFood();
      score += 10;
    }
    paint(ctx);
  }
};

function paint(ctx) {
  ctx.fillStyle = "white";
  ctx.fillRect(0, 0, width, height);
  ctx.strokeStyle = "black";
  ctx.strokeRect(0, 0, width, height);
  ctx.fillStyle = "green";
  ctx.fillRect(food.x * dx, food.y * dy, dx, dy);
  var box = head;
  while(box = box.next) {
    ctx.fillStyle = "blue";
    ctx.fillRect(box.x * dx + 1, box.y * dy + 1, dx - 2, dy - 2);
  }
  ctx.font = "15px Verdana";
  var scoreText = "Score:" + score;
  ctx.fillText(scoreText, 10, 390);
};

function push(dir) {
  head.prev = dir;
  dir.next = head;
  head = dir;
};

function pop() {
  tail = tail.prev;
  tail.next = null;
};

function increase(changeDir) {
  direction  = (typeof changeDir != "undefined") ? changeDir : direction;
  switch(direction) {
    case dir.left:  push({x: head.x == 0 ? nx-1 : head.x-1, y: head.y }); break;
    case dir.right: push({x: head.x == nx-1 ? 0 : head.x+1, y: head.y }); break;
    case dir.up:    push({x: head.x, y: head.y == 0 ? ny-1 : head.y-1 }); break;
    case dir.down:  push({x: head.x, y: head.y == ny-1 ? 0 : head.y+1 }); break;
  }
};

function decrease() {
  if(length) length--;
  else pop();
};

function pressedButton(e) {
  if(e.keyCode == "37" && direction != dir.right)     snake.push(dir.left);
  else if(e.keyCode == "38" && direction != dir.down) snake.push(dir.up); 
  else if(e.keyCode == "39" && direction != dir.left) snake.push(dir.right);
  else if(e.keyCode == "40" && direction != dir.up)   snake.push(dir.down);
  else if (e.keyCode == "32") play();
  else if (e.keyCode == "27") lose();
};

function checkCollision(pos) {
  var box = head;
  while (box = box.next) {
    if (box.x == pos.x && box.y == pos.y) return true; 
  }
  return false;
};

function newFood() {
  var pos = [];
  pos.x = Math.round(Math.random()*(nx-1));
  pos.y = Math.round(Math.random()*(ny-1));
  return pos;
};

document.addEventListener('keydown', pressedButton, false);

function game() {

  if(typeof gameLoop != "undefined") clearInterval(gameLoop);
  gameLoop = setInterval(update, 65);
};

start();
game();
