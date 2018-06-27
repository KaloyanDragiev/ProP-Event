<?php


session_start();

if(isset($_SESSION["name"])){
	
	
header("location:Message.php");

 }


$con = mysqli_connect("studmysql01.fhict.local","dbi392329","password","dbi392329");

// Check connection
if (mysqli_connect_errno())
  {
  echo "Failed to connect to MySQL: " . mysqli_connect_error();
  }
  
 
?>

<html>

<head>
<title>
Tesla News
</title>
<link rel = "stylesheet" type = "text/css" href = "Css/SignUp.css">
</head>

<body>
<nav id = "navbar">
<div class = "subbar" >
	<img class= "logo" src = "Images/TeslaLogo2.jpg"
		alt= "TeslaBlog.com" 
		title = "TeslaBlog.com">
	<ul>
		<li> <span id= "blog">Blog.com</span> </li>
		<li><a href="Index.php">Home</a> </li>
		<li><a href="News.php">News</a></li>
		<li><a href="Models.php">Models</a></li>
		<li><a href="Contact.php">Contact Us</a></li>
		<li><a href="Sign_Up.php">Sign Up</a></li>
		<li><a href="Sign_In.php">Sign In</a></li>
	</ul>
	</div>
</nav>



 <div class= "wholeblock" >
 <div class = "form">
<form class = "form1" action = "registerprocess.php" method = "POST">
<fieldset>
<legend>Sign Up:</legend>
    
	<div class = "firstsent" >
    <p>Please fill in this form to create an account!</p>
	</div>
    
<div class = "input" >
<span class = "username">
    <label ><b>Username</b></label>
    <input type="text" name = "username" placeholder="Enter Username"  required>
</span>
	</div>


<div class = "input" >
<span class = "email">
    <label ><b>E-mail</b></label>
    <input type="text"  placeholder="Enter E-mail" name = "email" required>
</span>
	</div>


<div class = "input" >
<span class = "password" >
    <label ><b>Password</b></label>
    <input type="password"  name = "password" placeholder="Enter Password"  required>
</span>
	</div>	

<div class = "input" >	
<span class = "country">
	<label ><b>Country</b></label>
    <input type="text" placeholder="Enter Country" name ="country" >
</span>
	</div>	

<div class = "input" >	
<span class = "repeatpassword">
	<label ><b>Repeat Password</b></label>
    <input type="password" placeholder="Repeat Password" required >
</span>
	</div>
	
	<div class = "input" >
<span class = "city">	
	<label ><b>City</b></label>
    <input type="text" placeholder="Enter City"  name ="city">
</span>
	</div>

<div class = "input" >
<span class = "firstname">
	<label ><b>First Name</b></label>
    <input type="text" placeholder="Enter First Name"  name ="firstName" required>
</span>
	</div>		
	
<div class = "input" >	
<span class = "Education">
	<label ><b>Education</b></label>
    <input type="text" placeholder="Enter school or university" name ="education" >
	</span>
	</div>

<div class = "input" >
<span class = "lastname">	
	<label ><b>Last Name</b></label>
    <input type="text" placeholder="Enter Last Name" name ="lastName" required >
</span>
	</div>
	
<div class = "input" >	
<span class = "job">		
	<label ><b>Job</b></label>
    <input type="text" placeholder="Enter job position" name ="job" >
</span>
	</div>			

<div class = "button">
	<button type = "submit"><b> Register</b></button>
</span>
	</div>
    
 <div class = "terms" >
    <p>By creating an account you agree to our <a href="#" style="color:dodgerblue">Terms & Privacy</a>.</p>
</div>
    </fieldset>
    
   
</form>
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