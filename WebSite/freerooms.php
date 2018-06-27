<?php

$servername = "studmysql01.fhict.local";
$username = "dbi378522";
$password = "Tia8W8a47Z";
$dbname = "dbi378522";



$conn = new mysqli($servername, $username, $password, $dbname);


$sql = "SELECT room.RoomNumber FROM room LEFT JOIN roomreservation ON room.RoomNumber = roomreservation.RoomNumber WHERE roomreservation.RoomNumber IS NULL AND room.RoomTypeId = 3;";
$result = $conn->query($sql);

if ($result->num_rows > 0) {
    // output data of each row
    while($row = $result->fetch_assoc()) {
       $freenr = $row["RoomNumber"];
	  
	  
    }
}
echo $freenr;



 ?>