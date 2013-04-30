<!DOCTYPE HTML>
<html lang="en-US">
<head>
	<meta charset="UTF-8">	
	<title>Numbers 1 to 1000 divided by 3 and 7</title>
</head>
<body>
	<?php 
		for ($i=0; $i < 1000; $i++) { 
			if ($i % 21 == 0) {
				$arr[] = $i; 		
			}
		}
		foreach ($arr as $value) {
			echo $value." ";
		}
	 ?>
</body>
</html>
