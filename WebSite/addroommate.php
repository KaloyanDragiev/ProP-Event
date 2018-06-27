<?php 

session_start();
 include 'accinfo.php';
 echo $roomnr;
$con = mysqli_connect("studmysql01.fhict.local","dbi378522","Tia8W8a47Z","dbi378522");

$check= 0;


if($roomtype == 2)
{
	
	$SQL = "SELECT * FROM extrabed WHERE RoomNumber = '" .$roomnr. "' ";

$query = mysqli_query($con, $SQL);
	if(mysqli_num_rows($query)>0){
		while($row=mysqli_fetch_array($query)){
		
		$check++;
		echo "</br>";
		echo $check;
		}
		
	}

if($check >1){
	
    $SQL= "DELETE FROM extrabed WHERE RoomNumber = '" .$roomnr. "'  ";

	$query = mysqli_query($con, $SQL);
	
	$SQL= "INSERT INTO extrabed (CustomerId, RoomNumber)
VALUES (".$_POST['member2'].", $roomnr)";
$query = mysqli_query($con, $SQL);

$SQL= "INSERT INTO extrabed (CustomerId, RoomNumber)
VALUES (".$custid.", $roomnr)";
$query = mysqli_query($con, $SQL);
}
else{
$SQL= "INSERT INTO extrabed (CustomerId, RoomNumber)
VALUES (".$_POST['member2'].", $roomnr)";

	$query = mysqli_query($con, $SQL);
}

}


else if($roomtype == 3)
{
$SQL = "SELECT * FROM extrabed WHERE RoomNumber = '" .$roomnr. "' ";

$query = mysqli_query($con, $SQL);
	if(mysqli_num_rows($query)>0){
		while($row=mysqli_fetch_array($query)){
		
		$check++;
		echo "</br>";
		echo $check;
		}
		
	}

if($check >1){
	
    $SQL= "DELETE FROM extrabed WHERE RoomNumber = '" .$roomnr. "'  ";

	$query = mysqli_query($con, $SQL);
	
	$SQL= "INSERT INTO extrabed (CustomerId, RoomNumber)
VALUES (".$_POST['member2'].", $roomnr)";
$query = mysqli_query($con, $SQL);

$SQL= "INSERT INTO extrabed (CustomerId, RoomNumber)
VALUES (".$custid.", $roomnr)";
$query = mysqli_query($con, $SQL);


$SQL= "INSERT INTO extrabed (CustomerId, RoomNumber)
VALUES (".$_POST['member3'].", $roomnr)";
$query = mysqli_query($con, $SQL);
}
else{
	$SQL= "INSERT INTO extrabed (CustomerId, RoomNumber)
VALUES (".$_POST['member2'].", $roomnr)";
$query = mysqli_query($con, $SQL);
	
	$SQL= "INSERT INTO extrabed (CustomerId, RoomNumber)
VALUES (".$_POST['member3'].", $roomnr)";
$query = mysqli_query($con, $SQL);
}



}
header ("location: index.php");
?>