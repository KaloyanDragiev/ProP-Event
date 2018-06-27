<?php
$servername = "studmysql01.fhict.local";
$username = "dbi378522";
$password = "Tia8W8a47Z";
$dbname = "dbi378522";

//session_start();

$age;

$infobalance;


if (isset($_SESSION['user']))
{
	$email = $_SESSION["user"];
// Create connection
$conn = new mysqli($servername, $username, $password, $dbname);
// Check connection
if ($conn->connect_error) {
    die("Connection failed: " . $conn->connect_error);
} 

$sql = "SELECT Age, Balance FROM customer Where Email = '" .$email. "' ";
$result = $conn->query($sql);

if ($result->num_rows > 0) {
    // output data of each row
    while($row = $result->fetch_assoc()) {
       $age = $row["Age"];
	   $infobalance = $row["Balance"];
	  
    }
} else {
    echo "0 results";
}
$conn->close();

}
?>