<html>
<?php 

include 'registerprocess.php';
session_start();
$logged;
$account;

if (isset($_SESSION['name'])) {
$fronttext = 'Welcome, '.$_SESSION['name']; 
$logged = "Account";
$account = "Logout";

$SQL= "Select * FROM usersregistered where username = '" .$_SESSION['name']. "'";
$query = mysqli_query($con, $SQL);

$conn = new PDO('mysql:host=studmysql01.fhict.local;dbname=dbi392329', 'dbi392329', 'password');
foreach($conn->query("SELECT * FROM `usersregistered` where username = '" .$_SESSION['name']. "'") as $row)
{
    $email = $row["Email"] ;
	$username = $row["Username"] ;
	$firstName = $row["FirstName"] ;
	$lastName = $row["LastName"] ;
	$country = $row["Country"] ;
	$education = $row["Education"] ;
	$job = $row["Job"] ;
	$city = $row["City"] ;
	
    
}

}
 else if(!isset($_SESSION['name'])){ $fronttext = "TeslaBlog.com: Register now and win prizes!" ;
 $logged = "Sign Up";
 $account = "Sign In";
 header("location:Sign_Up.php");}
 ?>
<head>

<title>MotorSportEvents</title>
<link rel = "stylesheet" type = "text/css" href = "Css/account.css">

<link href='https://fonts.googleapis.com/css?family=Raleway:400,200' rel='stylesheet' type='text/css'> 
<link rel="shortcut icon" href="images/Merclogo.jpg" type="image/gif" sizes="9x16">
</head>
<body>

<nav id = "navbar1">
<li><a href="index.php">Log In</a> </li>
<text> |</text>
<li><a href="News.php">Register</a></li>
</nav>
<div class = "logoandnav">
<div class = "logo">

		<img class= "background" src = "images/Merclogo.jpg"
		alt= "TeslaBlog.com" 
		title = "TeslaBlog.com">
</div>


<nav id = "navbar">
<div class = "subbar" >

	<ul>
		<li><a href="index.html#home">Home</a> </li>
		<li><a href="index.html#about">About</a></li>
		<li><a href="index.html#schedule">Schedule</a></li>
		<li><a href="index.html#accommodation">Accommodation</a></li>
		
		<li><a href="index.html#location">Location</a></li>
	</ul>
	</div>
</nav>
</div>

<div class = "wholeblock">
<h1 class = "title">Event-Account</h1>

<div class = "info">



<div class = "balance">
<h2>Peter Peterson</h2>
<label>Balance:</label>
<label>Add money:</label> <input type="text" name="fname"> </br>
<button class="add">Add Funds</button>
</div>
<h3>More information</h3>
<label>Email:</label>
<label>Age:</label>
<label>Accommodation:</label>

</div>

</div>
		
		
</body>

<footer>

	  <div class="me">  
         <p>Created by: <p><h1>MotorSportEvents®</h1>
        </div>
	<div class= "socialmedia">
		<div class = "fa fa-facebook"></div>
		<div class = "fa fa-twitter"></div>
		<div class = "fa fa-google-plus"></div>
		<div class = "fa fa-linkedin"></div>
	</div>
	<div class = "bottomtext" >
	
	</div>
</footer>
</html>