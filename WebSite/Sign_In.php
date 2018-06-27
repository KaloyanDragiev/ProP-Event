<!doctype html>

<?php
$con = mysqli_connect("studmysql01.fhict.local","dbi392329","password","dbi392329");




// Check connection
if (mysqli_connect_errno())
  {
  echo "Failed to connect to MySQL: " . mysqli_connect_error();
  }
  include 'registerprocess.php';
session_start();


  
  $logged;
$fronttext;
$account;
    
if (isset($_SESSION['name'])) {
 
session_unset();
session_destroy();
header("location:index.php");
$logged = "Logout";
$account = "Change User";}
 else {
 $logged = "Sign Up";
 $account = "Sign In";}
  
 
?>
<html>

<head>

<title>
TeslaBlog
</title>
<link rel = "stylesheet" type = "text/css" href = "Css/SignIn.css">
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

<div class = "block" >
 <div class = "form">
<form action = "process.php" method = "POST">
<fieldset>

<legend>Sign In</legend>
<div class = "insideform" >
<label >Username:</label>
<input type="text" name = "username" required >

<label >Password:</label>
<input type="password" name = "password"  required>

<div class = "button1">
<input class = "button" type="submit" value="Login">
</div>
</div>
</fieldset>
</form>
</div>
</div>

<div class = "footer">
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
