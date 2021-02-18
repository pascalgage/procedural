function changing(){

let A=(document.querySelector("#A").value);
let D= A.toUpperCase();
let B=(document.querySelector("#B").value);
let E= B.toUpperCase();
let C=(document.querySelector("#C").value);
let F= C.toUpperCase();
var color ='#'+A+B+C;
document.body.style.background = color;
document.querySelector("#A").value= D;
document.querySelector("#B").value= E;
document.querySelector("#C").value= F;

}
var test1=document.querySelector("#A");
test1.addEventListener("blur",changing);
var test2=document.querySelector("#B");
test2.addEventListener("blur",changing);
var test3=document.querySelector("#C");
test3.addEventListener("blur",changing);



function changeRED(){
	var color='red';
	document.body.style.background = color;
	document.querySelector("#A").value="FF";
	document.querySelector("#B").value="00";
	document.querySelector("#C").value="00";
}
var red=document.querySelector("#red");
red.addEventListener("click",changeRED);


function changeGREEN(){
	var color='green';
	document.body.style.background = color;
	document.querySelector("#A").value="00";
	document.querySelector("#B").value="80";
	document.querySelector("#C").value="00";
}
var green=document.querySelector("#green");
green.addEventListener("click",changeGREEN);


function changeBLUE(){
	var color='blue';
	document.body.style.background = color;
	document.querySelector("#A").value="00";
	document.querySelector("#B").value="00";
	document.querySelector("#C").value="FF";
}
var blue=document.querySelector("#blue");
blue.addEventListener("click",changeBLUE);






