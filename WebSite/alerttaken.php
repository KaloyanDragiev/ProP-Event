<?php 


$con = mysqli_connect("studmysql01.fhict.local","dbi378522","Tia8W8a47Z","dbi378522");
$alert = "Username Taken";
$SQL= "UPDATE alert SET Alert = '".$alert."' where Id = 4";
	
	$query = mysqli_query($con, $SQL);
header ("location: index.php");
?>