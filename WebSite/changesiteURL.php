<?php 
$servername = "studmysql01.fhict.local";
$username = "dbi378522";
$password = "Tia8W8a47Z";
$dbname = "dbi378522";

$conn = new mysqli($servername, $username, $password, $dbname);



$sql = "UPDATE changesite SET VideoURL= '".$_POST['video']."'";

if ($conn->query($sql) === TRUE) {
    echo "New record created successfully";
	
} else {
    echo "Error: " . $sql . "<br>" . $conn->error;
}

$conn->close();
header ("location: index.php");
?>