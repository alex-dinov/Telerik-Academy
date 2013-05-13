var newItem = document.getElementById('new-item');
var buttonSave = document.getElementById('save-item');
var buttonHide = document.getElementById('hide-item');
var buttonShow = document.getElementById('show-item');
var todoList = document.getElementById('todo-list');

function addItem () {
	if (newItem.value) {
		var li = document.createElement('li');
		var p = document.createElement('p');
		var buttonDelete = document.createElement('button');
		buttonDelete.innerHTML = 'Delete';
		buttonDelete.className = 'button-delete';
		buttonDelete.type = 'button';
		buttonDelete.addEventListener('click', buttonDeleteItem, false);

		var content = document.createTextNode(newItem.value);

		p.appendChild(content);
		li.appendChild(p);
		li.appendChild(buttonDelete);
		todoList.appendChild(li);
	}
}

function buttonDeleteItem(ev) {
	todoList.removeChild(this.parentNode);
}

function showList() {
	todoList.style.display = 'block';
}

function hideList() {
	todoList.style.display = 'none';
}

buttonSave.addEventListener('click', addItem, false);
buttonShow.addEventListener('click', showList, false);
buttonHide.addEventListener('click', hideList, false);
