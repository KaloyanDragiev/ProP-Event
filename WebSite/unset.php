<?php if (!isset($_SESSION['user'])) {
 
 session_start();
session_unset();
session_destroy();
header("location:index.php");
$logged = "Logout";
$account = "Change User";}
 else {
	header("location:index.php");
 $logged = "Sign Up";
 $account = "Sign In";}
 ?>