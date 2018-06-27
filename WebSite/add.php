<?php
$servername = "studmysql01.fhict.local";
$username = "dbi378522";
$password = "Tia8W8a47Z";
$dbname = "dbi378522";



session_start();
include'accinfo.php';
// Create connection
$conn = new mysqli($servername, $username, $password, $dbname);
// Check connection
if ($conn->connect_error) {
    die("Connection failed: " . $conn->connect_error);
} 

$total = $infobalance + $_POST['amount'];
$sql = "UPDATE customer SET Balance= ".$total." WHERE Email= '".$_SESSION["user"]."'";



if ($conn->query($sql) === TRUE) {
    echo "New record created successfully";
	echo $total;
} else {
    echo "Error: " . $sql . "<br>" . $conn->error;
}



$con = mysqli_connect("studmysql01.fhict.local","dbi378522","Tia8W8a47Z","dbi378522");
$alert = "€".$_POST['amount'] ." Added sucessfully to your account";
$SQL= "UPDATE alert SET Alert = '".$alert."' where Id = 4";
	
	
	$query = mysqli_query($con, $SQL);
header ("location: index.php");
?>