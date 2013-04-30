<?php
 
if( empty( $_POST['numberOne'] ) || empty( $_POST['sign'] ) || empty( $_POST['numberTwo'])) {
    header("location: PHP-form.html");
}
 
$numberOne = $_POST['numberOne'];
$numberTwo = $_POST['numberTwo'];
$sign = $_POST['sign'];
 
$accepted_signs = array( '+', '-', '*', '/' );

if( ! is_numeric( $numberOne ) || ! is_numeric( $numberTwo ) || ! in_array( $sign, $accepted_signs ) ) {
    header("location: PHP-form.html");
} 
else {
	$result = "";
	switch ($sign) {
	   	case '+':
	        $result = "Result: " . ($numberOne + $numberTwo);
	        break;
	    case '-':
	        $result = "Result: " . ($numberOne - $numberTwo);
	        break;
	    case '*':
	        $result = "Result: " . ($numberOne * $numberTwo);
	        break;
	    case '/': {
	        if($numberTwo != 0) {
	            $result = "Result: " . ($numberOne / $numberTwo);
	            break;
	        }
	        else {
	            $result = "Cannon divide by zero!";
	        }
	    }
	    default : {
	        $result = "No such mathematical symbol";
	    }
	} 
	echo $result;
}