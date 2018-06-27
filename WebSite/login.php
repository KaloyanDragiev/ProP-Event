<html>
<head>
<body>

<table>
<?php 
$user = $_POST['user'];
$pass = $_POST['pass'];

$conn = new PDO('mysql:host=studmysql01.fhict.local;dbname=dbi392329', 'dbi392329', 'password');
foreach($conn->query("SELECT * FROM `usersregistered`") as $row)
{
    
	if($row["Username"] == $user && $row["Password"] == $pass){
		echo "Login successful!" . $row["Username"];
	}
	else{
		echo "didn't work";
	}
	
    
}
?>
</table>

</body>
</html>