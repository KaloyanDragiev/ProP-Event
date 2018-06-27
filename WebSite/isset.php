<?php


session_start();

$logged;
$fronttext;
$account;
 if (isset($_SESSION['user'])) {
$fronttext = 'Welcome, '.$_SESSION['user']; 
$logged = "Account";
$account = "Logout";}
 else { $fronttext = "TeslaBlog.com: Register now and win prizes!" ;
 $logged = "Sign Up";
 $account = "Sign In";}
 ?>