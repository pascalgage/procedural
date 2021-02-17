


function change(){
	var color=document.querySelector("#A").value;
	document.body.style.background = color;
}

var test=document.querySelector("#A");
test.addEventListener("blur",change);


function changeColor(color) { 
                document.body.style.background = color; 
            }

function changing(){

var color ='#'+(document.querySelector("#A").value)+(document.querySelector("#B").value)+(document.querySelector("#C").value);
document.body.style.background = color;

}

var test2=document.querySelector("#C");
test2.addEventListener("blur",changing);











