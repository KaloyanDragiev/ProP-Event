

<?php
$servername = "studmysql01.fhict.local";
$username = "dbi378522";
$password = "Tia8W8a47Z";
$dbname = "dbi378522";

//session_start();

$age;
$firstname ="";
$lastname= "";
$infobalance;
$custid;
$transactionId = 0;
$roomnr =0;
$roomtype = 0;
$roommateid = "";
$roommateid2 = "";

if (isset($_SESSION['user']))
{
	$email = $_SESSION["user"];
// Create connection
$conn = new mysqli($servername, $username, $password, $dbname);
// Check connection
if ($conn->connect_error) {
    die("Connection failed: " . $conn->connect_error);
} 

$sql = "SELECT * FROM customer Where Email = '" .$email. "' ";
$result = $conn->query($sql);

if ($result->num_rows > 0) {
    // output data of each row
    while($row = $result->fetch_assoc()) {
	   $custid = $row["CustomerId"];
       $age = $row["Age"];
	   $infobalance = $row["Balance"];
	   $firstname = $row["FirstName"];
	   $lastname = $row["LastName"];
	  
    }
} else {
    echo "0 results";
}

$sql = "SELECT * FROM transactions WHERE CustomerId = '" .$custid. "' ";
$result = $conn->query($sql);
if ($result->num_rows > 0) {
    // output data of each row
    while($row = $result->fetch_assoc()) {
	   $transactionId = $row["TransactionId"];
      
	  
    }
}


$sql = "SELECT * FROM roomreservation Where TransactionId = '" .$transactionId. "' ";
$result = $conn->query($sql);
if ($result->num_rows > 0) {
    // output data of each row
    while($row = $result->fetch_assoc()) {
	   $roomnr = $row["RoomNumber"];
      
	  
    }
}

$sql = "SELECT * FROM room Where RoomNumber = '" .$roomnr. "' ";
$result = $conn->query($sql);
if ($result->num_rows > 0) {
    // output data of each row
    while($row = $result->fetch_assoc()) {
	   $roomtype = $row["RoomTypeId"];
      
	  
    }
}


$sql = "SELECT * FROM extrabed WHERE RoomNumber = '" .$roomnr. "'  AND CustomerId <> '" .$custid. "'";
$result = $conn->query($sql);
if ($result->num_rows > 0) {
    // output data of each row
    while($row = $result->fetch_assoc()) {
	   $roommateid = $row["CustomerId"];
      
	  
    }
}

if($roomtype == 3){
$sql = "SELECT * FROM extrabed WHERE RoomNumber = '" .$roomnr. "'  AND CustomerId <> '" .$custid. "' AND CustomerId <> '" .$roommateid. "'";
$result = $conn->query($sql);
if ($result->num_rows > 0) {
    // output data of each row
    while($row = $result->fetch_assoc()) {
	   $roommateid2 = $row["CustomerId"];
      
	  
    }
}


$conn->close();

}
}
?>
