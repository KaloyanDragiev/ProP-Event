<?php

$con = mysqli_connect("studmysql01.fhict.local","dbi378522","Tia8W8a47Z","dbi378522");

// Check connection
if (mysqli_connect_errno())
  {
  echo "Failed to connect to MySQL: " . mysqli_connect_error();
  }

  $firstname;
  $lastname;
  $pass;
  $email;
  $age;
  $id;
  $alert;

	
  
if (isset ($_POST["email"]) && isset($_POST["password"])&& $_POST["email"] != ""  && $_POST["password"] != "" )  {
	$firstname = $_POST['firstname'];
	$lastname = $_POST['lastname'];
	$pass = $_POST['password'];
	$email = $_POST['email'];
	$age = $_POST['age'];
	$hotel = $_POST['hotel'];
	
	
	if($hotel != 0){
	//Check free rooms
	$SQL= "SELECT room.RoomNumber 
	FROM room LEFT JOIN roomreservation ON room.RoomNumber = roomreservation.RoomNumber
	WHERE roomreservation.RoomNumber IS NULL AND room.RoomTypeId = '" .$hotel. "';";
	
	$query = mysqli_query($con, $SQL);
	
	if ($query->num_rows > 0) {
    // output data of each row
    while($row = $query->fetch_assoc()) {
       $freenr = $row["RoomNumber"];
	   echo"FreeRoomNUmbernumber: ";
	   echo $freenr;
	   echo "</br>";
	  
    }
	}
	else{
		
		header ("location: alertroom.php");
		exit();	
	}
	
	
	}
	
	
	
	
	
	$SQLcheck= "Select * FROM Customer where email = '" .$email. "'";
	
	$query = mysqli_query($con, $SQLcheck);
	if(mysqli_num_rows($query)>0){
		
		
		header ("location: alerttaken.php");
		exit();
		}
		
	
	else{
	
	//insert into customer
	
	$SQL= "INSERT INTO `customer` (`CustomerId`, `FirstName`, `LastName`, `Password`, `Email`, `Age`, `Balance`, `TicketNumber`)
	VALUES (NULL, '$firstname', '$lastname', '$pass', '$email', '$age', '0', '13');";
	
	$query = mysqli_query($con, $SQL);
	
	
	
	// get id
	
	$SQL= "Select * FROM Customer where email = '" .$email. "'";
	
	$query = mysqli_query($con, $SQL);
	
	
	if ($query->num_rows > 0) {
    // output data of each row
    while($row = $query->fetch_assoc()) {
       $id = $row["CustomerId"];
		echo $id;
	  
    }
	}
	
	//insert in extrabed
	
	$SQL= "INSERT INTO `extrabed` (`CustomerId`, `RoomNumber`)
	VALUES ('$id', '$freenr');";
	
	$query = mysqli_query($con, $SQL);
	
	
	
	
	
	//create a transaction entry
	
	$SQL= "INSERT INTO `transactions` (`TransactionId`, `CustomerId`)
	VALUES (NULL, '$id');";
	
	$query = mysqli_query($con, $SQL);
	
	//Take values inserted into transaction and store transactionId
	
	$SQL= "Select * FROM transactions where CustomerId = '" .$id. "'";
	
	$query = mysqli_query($con, $SQL);
	
	if ($query->num_rows > 0) {
    // output data of each row
    while($row = $query->fetch_assoc()) {
       $id = $row["TransactionId"];
	   echo "</br>";
		echo $id;
	  
    }
	}
	// INSERT transactionId into roomreservation
	
	$SQL= "INSERT INTO `roomreservation` (`TransactionId`, `RoomNumber`)
	VALUES ('$id', '$freenr');";
	
	$query = mysqli_query($con, $SQL);
	
	
	require 'loginprocess.php';
	

		header ("location: index.php");
		
	}
}
