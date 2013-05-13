 	function allowDrop(ev) {
	  		ev.stopPropagation();
	        ev.preventDefault();
	    }

	    function drag(ev) {
	        ev.dataTransfer.setData("dragged-id", ev.target.id);
	    }

	    function drop(ev) {
	        ev.preventDefault();
	        var data = ev.dataTransfer.getData("dragged-id");
	        document.body.removeChild(document.getElementById(data));
	        counterTrash++;
	        ev.target.style.backgroundImage = "url(images/bucket-closed.jpg)";
	        if (counterTrash == trashCount) {
	        	endGame();
	        }
	    }

	    function dragEnter (ev) {
	    	ev.target.style.backgroundImage = "url(images/bucket-open.jpg)";
	    }

	    function dragLeave (ev) {
	    	ev.target.style.backgroundImage = "url(images/bucket-closed.jpg)";
	    }

		
		var minutes = 0;
		var seconds = 0;
		var milliseconds = 0;
		var start = 0;
		var interval = 0;
		var trashCount = 0;
		var counterTrash = 0;
		var points = 0;

		function timer () {
			if (start == 1) {
				milliseconds += 1;
				points += 7;

				if (milliseconds > 9) {
					milliseconds = 0;
					seconds += 1;
					if (seconds > 9) {
						seconds = 0;
						minutes += 1;
					}
				}

				document.getElementById('timer').innerHTML = minutes + ":" + seconds + ":" + milliseconds;

				interval = setTimeout("timer()", 100);
			}
		}

		function startTimer () {
			start = 1;
			timer();
		}

		function stopTimer () {
			start = 0;
		}

		function resetTimer () {
			start = 0;
			clearTimeout(interval);

			minutes = 0;
			seconds = 0;
			milliseconds = 0;
			points = 0;

			document.getElementById('timer').innerHTML = minutes + ":" + seconds + ":" + milliseconds;
		}


		function newGame () {
			function resetField() {
		        var trashElements = document.querySelectorAll("div.trash");
		        for (var i = 0; i < trashElements.length; i++) {
		            document.body.removeChild(trashElements[i]);
		        }

		        counterTrash = 0;
		    }

		    function createTrash () {
				function getRandomInteger(min, max) {
					return Math.floor(Math.random() * (max - min) + min);
				}
				trashCount = getRandomInteger(1,10);
				for (var i = 0; i < trashCount; i++) {
					var left = getRandomInteger(200, 800);
					var top = getRandomInteger(70, 470);

					var trash = document.createElement("div");
					trash.id = "trash_" + i;
					trash.className = "trash";
					trash.style.left = left + "px";
					trash.style.top = top + "px";
					trash.style.backgroundImage = "url(images/trash.png)";
					trash.setAttribute("draggable", "true");
					trash.addEventListener('dragstart', drag, false);
					document.body.appendChild(trash);
				}
			}
		resetField();
		resetTimer();
		createTrash();
		startTimer();
		}

		function endGame () {
			stopTimer();
			var score = document.getElementById('score');
			score.innerHTML = points * 10;
			counterTrash = 0;
			document.getElementById('endGame').style.display = "block";
		}

		function saveUser () {
			var user = document.getElementById('name').value;
			var score = document.getElementById('score').innerHTML;
			localStorage.setItem(score, user);
			document.getElementById('endGame').style.display = "none";
		}

		function addUserToLeaderboard () {
			var highScores = [];
			for (var i = 0; i < localStorage.length; i++) {
				highScores.push(localStorage.key(i));
			}

			 var sortedHighScores =Object.keys(localStorage).sort(function (a, b) {
		        return a - b;
		    });

			var leaderboard = document.getElementById('leaderboard');
		 	leaderboard.innerHTML = "";
			var userPlace = 1;
			for(user in sortedHighScores) {
				if (userPlace > 5) {
					break;
				}

				var userScore = sortedHighScores[user];
				var userName = localStorage.getItem(userScore);

				if (userScore === "" || userScore === "undefined") {
		            continue;
		        }

		        var currentUser = document.createElement("span");
	        	currentUser.innerHTML += userPlace + ". " + userName + "    " + userScore;
	        	currentUser.style.display = "block";

		        leaderboard.appendChild(currentUser);
		        userPlace++;
			}
		}

		function showLeaderboard () {
			addUserToLeaderboard();
			var leaderboard = document.getElementById('leaderboard');
			leaderboard.style.display = "block";
		}

		function hideLeaderboard () {
			var leaderboard = document.getElementById('leaderboard');
			leaderboard.style.display = "none";
		}