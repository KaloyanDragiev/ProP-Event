<?php

$con = mysqli_connect("studmysql01.fhict.local","dbi378522","Tia8W8a47Z","dbi378522");

// Check connection
if (mysqli_connect_errno())
  {
  echo "Failed to connect to MySQL: " . mysqli_connect_error();
  }

  $user;
  $pass;
  
if (isset ($_POST["email"]) && isset($_POST["password"])&& $_POST["email"] != ""  && $_POST["password"] != "" )  {
	$user = $_POST['email'];
	$pass = $_POST['password'];
	
	$SQL= "Select * FROM Customer where email = '" .$user. "' and password ='" .$pass. "'";
	
	$query = mysqli_query($con, $SQL);
	if(mysqli_num_rows($query)>0){
		while($row=mysqli_fetch_array($query)){
		session_start();
		$_SESSION["user"] = $user;
		
		
		}
		
	}
		
}
header ("location: index.php");


?>