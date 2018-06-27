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
 
 <html>
<head>
<title>TeslaBlog</title>
<link rel = "stylesheet" type = "text/css" href = "Css/Home.css">
</head>

<body>

<nav id = "navbar">
<div class = "subbar" >
	<img class= "logo" src = "Images/TeslaLogo2.jpg"
		alt= "TeslaBlog.com" 
		title = "TeslaBlog.com">
	<ul>
		<li> <span id= "blog">Blog.com</span> </li>
		<li><a href="index.php">Home</a> </li>
		<li><a href="News.php">News</a></li>
		<li><a href="Models.php">Models</a></li>
		<li><a href="Contact.php">Contact Us</a></li>
		<li><a href="Sign_Up.php"><?php echo $logged ?></a></li>
		<li><a href="Sign_In.php"><?php echo $account ?></a></li>
	</ul>
	</div>
</nav>



<div class = "wholeblock">
	<div class= "firstblock">
	
	<div class = "message">
	<br/>
	<br/>
	<br/>
	<br/>
	<br/>
	<br/>
		<h1> <?php echo $_SESSION['name'] . "'s". " "."Account "?> </h1>
		<br/>
		<h2><?php echo "Username: ".$username?></h2>
		<h2><?php echo "E-mail: ". $email?></h2>
		<h2><?php echo "First Name: ".$firstName?></h2>
		<h2><?php echo "Last Name: ".$lastName?></h2>
		<h2><?php echo "Country: ".$country?></h2>
		<h2><?php echo "City: ".$city?></h2>
		<h2><?php echo "Education: ".$education?></h2>
		<h2><?php echo "Job: ".$job?></h2>
	</div>

	
</div>

<footer>

	<div class= "socialmedia">
		<div class = "fa fa-facebook"></div>
		<div class = "fa fa-twitter"></div>
		<div class = "fa fa-google-plus"></div>
		<div class = "fa fa-linkedin"></div>
	</div>
	<div class = "bottomtext" >
	<p> TeslaBlog.com ©    Copyright 2018. All rights reserved. </p>
	</div>
	
</footer>

</div>
</body>
</html>