<?php
function PREMIER(int $N)
{
		$decision=$N." EST PREMIER !";
		$reste;
		$div=1;
		$lim=sqrt(abs($N));
		$N=abs($N);
		$bool=true;
do {
		if($N==1){$decision=$N." N'EST PAS PREMIER !";}
		$div++;
		$reste=$N%$div;
		if($reste == 0 && $N!=2)
		{
		$decision=$N." N'EST PAS PREMIER !";
		$bool=false;
		break;
		}

	} while($div<=$lim);

	return $decision;
}
//echo PREMIER(5);
function GivePremier(int $NBR){
		$TAB=[];
		
		for($i=1;$i<=$NBR;$i++){

			$value=$i;

		if(PREMIER($value)==true && ($value)!=1){
			array_push($TAB, $value);
		}
	}

	return json_encode($TAB);
}
//echo GivePremier(200);
?>