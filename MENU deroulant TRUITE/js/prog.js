var btn = document.querySelector('.button');
var nav = document.querySelector('.headhide');

btn.onclick = function(){
	nav.classList.toggle('headhide_open');
}