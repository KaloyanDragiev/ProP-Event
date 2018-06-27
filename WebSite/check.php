
Dummy DAte


<?php 


$con = mysqli_connect("studmysql01.fhict.local","dbi378522","Tia8W8a47Z","dbi378522");

// Check connection
if (mysqli_connect_errno())
  {
  echo "Failed to connect to MySQL: " . mysqli_connect_error();
  }

  $user ="0";
  $pass;

  echo "Connection so far - so good"
  
	
	
	
	if (isset ($_POST["email"])){
		$user = $_POST['email'];
		$SQL= "Select * FROM Customer where Email = '" .$user. "'";
		
		$query = mysqli_query($con, $SQL);
	if(mysqli_num_rows($query)>0){
		
		echo '<span>Username Taken</span>';
		echo $user;
}
else{
	echo '<span>Username available</span>';
}
	}
	echo $user;
	
	
	




?>