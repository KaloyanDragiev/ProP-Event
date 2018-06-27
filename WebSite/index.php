<?php


session_start();
  
  //include 'registerprocess.php';
  include 'accinfo.php';
   include 'gettext.php';
  
  $logged;
$fronttext;
$account;
$var;
$z;
$formshow;
$regorlogout;
$change;
if (isset($_SESSION['user'])) {
 
$var = $_SESSION["user"];
$z = "1";
$logged = "Logout";
$account = " ".$firstname;
$formshow = "id03";
$regorlogout = "window.location.href='/unset.php'";

$iconaccount = "fa fa-address-card-o";
$iconticket = "";
$checkifadmin;
$getAticket = "";
$eventacc = "document.getElementById('id03').style.display='block'";
 //Check Balance
 $getAticket =  '<a  onclick = "' .$eventacc. '"  class="w3-btn w3-white">Event Account</a>';
}
 else {
	 $var="";
	 $z = "0";
 $logged = " Get Ticket";
 $account = "Login";
$formshow = "id02";
$regorlogout = "document.getElementById('id01').style.display='block'";
$getAticket =  '<a  onclick = "' .$regorlogout. '"  class="w3-btn w3-white">GET A TICKET</a>';


$iconticket = "fa fa-ticket";
 }
 
 
 if($var == "admin")
 {
	 $checkifadmin = "You are the admin";
	 $account = "Change site";
	 $iconaccount = "";
	 $formshow = "id04";
 }
 else{
	 $checkifadmin = "You are NOT the admin";
 }
 
 
 
 $memberstb = '<input class = "specifymembers" type="text" name="" placeholder="member#1"></input>
<input class = "specifymembers" type="text" name="" placeholder="member#2"></input>
<input class = "specifymembers" type="text" name="" placeholder="member#3"></input>
<button class="specifymembersbtn"><i class="fa fa-check"></i></button>';



if($roomtype == 1){
	$roomtype = "Private room";
	$memberstb = "";
}
else if ($roomtype == 2){
	$roomtype = "President room";
	$memberstb = '<input class = "specifymembers" type="text" value= "' .$custid. '"   name="" placeholder="member#1" readonly></input>
<input class = "specifymembers" type="text" name="member2" value= "' .$roommateid. '"placeholder="member#2"></input>
<button class="specifymembersbtn"><i class="fa fa-check"></i></button>';
}
else if ($roomtype == 3){
	$roomtype = "Group room";
	$memberstb = '<input class = "specifymembers" type="text" value= "' .$custid. '"   name="" placeholder="member#1" readonly></input>
<input class = "specifymembers" type="text" name="member2" value= "' .$roommateid. '" placeholder="member#2"></input>
<input class = "specifymembers" type="text" name="member3" value= "' .$roommateid2. '" placeholder="member#3"></input>
<button class="specifymembersbtn"><i class="fa fa-check"></i></button>';
}
else{
	$roomtype = "None";
	$memberstb = "";
}



$alert;









$servername = "studmysql01.fhict.local";
$username = "dbi378522";
$password = "Tia8W8a47Z";
$dbname = "dbi378522";

$conn = new mysqli($servername, $username, $password, $dbname);
$sql = "SELECT * FROM alert Where Id = 4 ";
$result = $conn->query($sql);

if ($result->num_rows > 0) {
    // output data of each row
    while($row = $result->fetch_assoc()) {
	   $alert = $row["Alert"];
        
    }
}

?>
<script>

var check = " <?php echo $checkifadmin ?> ";

var t = " <?php echo $alert ?> ";
var l = " <?php echo $roommateid ?> ";


if( t != 1){
	alert(t);
}
</script>



<?php $con = mysqli_connect("studmysql01.fhict.local","dbi378522","Tia8W8a47Z","dbi378522");
$alert = "1";
$SQL= "UPDATE alert SET Alert = '".$alert."' where Id = 4";
	
	
	$query = mysqli_query($con, $SQL);
?> 
<html>
<head>

<title>MotorSportEvents</title>


	<link rel = "stylesheet" type = "text/css" href = "css/regform.css">
		<link rel = "stylesheet" type = "text/css" href = "css/account.css">
	<link rel="stylesheet" href="ionicons/css/ionicons.min.css">
	<link rel = "stylesheet" type = "text/css" href = "css/about.css">
	<link rel = "stylesheet" type = "text/css" href = "css/timeline.css">
	<link href='https://fonts.googleapis.com/css?family=Raleway:400,200' rel='stylesheet' type='text/css'> 
	<link href='http://fonts.googleapis.com/css?family=Arizonia' rel='stylesheet' type='text/css'>

	
	
  
  
  <link rel="stylesheet" type="text/css" media="all" href="css/switchery.min.css">
  <script type="text/javascript" src="js/switchery.min.js"></script>
 <link rel="shortcut icon" href="images/icon.png" type="image/gif" sizes="9x16">
	
</head>
<body>
<section id="home">
<header id="js-header">
<nav id = "navbar1">
<ul>
<!--<li><a href="index2.html">Log In</a> </li>-->
<!--<li><button onclick="document.getElementById('id03').style.display='block'" style="width:auto;">Account</button></li> -->
<!--<li><button onclick="document.getElementById('id02').style.display='block'" style="width:auto;">Account</button></li> -->
<!--<li><button onclick="document.getElementById('id01').style.display='block'" style="width:auto;">Account</button></li> -->
<span class = "username">

</span>

<span class = "btnsheading">
<li><button class = "btn" onclick="document.getElementById('<?php echo $formshow; ?>').style.display='block'" style="width:auto;"><i class="<?php echo $iconaccount ?>"></i><?php echo $account; ?></button></li>
<text> |</text>
<li><button class = "btn" onclick="<?php echo $regorlogout; ?>" style="width:auto;"><i class="<?php echo $iconticket ?>"></i><?php echo $logged; ?></button></li>
</span>
</ul>
</nav>

<style>
.btn {
    background-color: red; /* Blue background */
    border: none; /* Remove borders */
    color: white; /* White text */
    padding: 12px 16px; /* Some padding */
    font-size: 16px; /* Set a font size */
    cursor: pointer; /* Mouse pointer on hover */
	border-radius:8%;
	margin:auto;
	font-weight:bold;
}

/* Darker background on mouse-over */
.btn:hover {
    background-color: red;
	
}

.username{
	position: fixed;
	
	padding-left:80px;
	
}

.btnsheading{
	position:relative;
	left:330px;
	bottom:10px;
}
#navbar1{
	padding-top: 35px;
	
}


</style>



<div class = "logoandnav">
<div class = "logo">

		<img class= "background" src = "images/MercLogo.jpg"
		alt= "TeslaBlog.com" 
		title = "TeslaBlog.com">
</div>


<nav id = "navbar">
<div class = "subbar" >

	<ul>
		<li><a href="index.php#home">Home</a> </li>
		<li><a href="index.php#about">About</a></li>
		<li><a href="index.php#schedule">Schedule</a></li>
		<li><a href="index.php#accommodation">Accommodation</a></li>
		
		<li><a href="index.php#location">Location</a></li>
		
	</ul>
	</div>
</nav>
</div>
</header>
<div class = "wholeblock">

<div class = "title">
<h1>Mercedes-Benz Summer conference 2018</h1>
</div>
<img class="mySlides" src="images/4k8.jpg">
<img class="mySlides" src="images/4k8.jpg">
<img class="mySlides" src="images/4k8.jpg">
<img class="mySlides" src="images/4k8.jpg">
</section>

<script>
var slideIndex = 0;
carousel();

function carousel() {
    var i;
    var x = document.getElementsByClassName("mySlides");
    for (i = 0; i < x.length; i++) {
      x[i].style.display = "none"; 
    }
    slideIndex++;
    if (slideIndex > x.length) {slideIndex = 1} 
    x[slideIndex-1].style.display = "block"; 
    setTimeout(carousel, 7000); // Change image every 2 seconds
}


</script>
<h1 class = "sectionabout"id = "about">.</h1>
<div class ="block2">
<h1> About Summer Event</h1>

<div class = "block3">

<div class = "titleleft">
<h2>Don't just see what's new. Get inside!</h2>
</div>
<div class= "block3left">

<p><?php echo $abouttxt ?><!-- Whether you are shopping for a vehicle or checking out the latest innovations,
Mercedes-Benz presents the newest of the new at the auto show. You can get inside our latest
models and see previews of the future. It is also an exiting way to explore our breaktroughs
in safety, luxury and performance that lead the industry. Factory-trained product
specialist can answer your questions, from options and features to technical details.
 You can even go home with a valuable incentive toward your next Mercedes-Benz.--></p>
 
<?php echo $getAticket ;?>
</div>
<div class= "block3right">
<iframe width="550" height="300"
src="<?php echo $videourl?>">
</iframe>
</div>	

		
</div>

<section id="facts" class="section bg-image-1 facts text-center">
        <div class="container2">
            <div class="row">
                <div class="col">

                    <i class="ion-ios-calendar"></i>
                    <h3>2018<br>August 25</h3>
                
                </div>
                <div class="col">

                    <i class="ion-ios-location"></i>
                    <h3>Park Kuierpad<br>Holland</h3>
                
                </div>
                <div class="col">

                    <i class="ion-pricetags"></i>
                    <h3>500<br>Tickets</h3>
                
                </div>
                <div class="col">
                
                    <i class="ion-speakerphone"></i>
                    <h3>6<br>New Cars</h3>
                
                </div>
            </div><!-- row -->
        </div><!-- container -->
    </section>
	
	
	
<div id="content">
  <h1>Schedule</h1>
<h1 class = "sectionschedule"id = "schedule">.</h1>
  <ul class="timeline">
  
 
  <span class ="day"><h1>Day 1</h1></span>
    <li class="event" data-date="12:30 - 1:00pm">
      <h3>Registration</h3>
      <p>Get here on time, it's first come first serve. Be late, get turned away.</p>
    </li>
    <li class="event" data-date="2:30 - 4:00pm">
      <h3>Opening Ceremony</h3>
      <p>Get ready for an exciting event, this will kick off in amazing fashion with MOP & Busta Rhymes as an opening show.</p>    
    </li>
    <li class="event" data-date="5:00 - 8:00pm">
      <h3>Main Event</h3>
      <p>This is where it all goes down. You will compete head to head with your friends and rivals. Get ready!</p>    
    </li>
    <li class="event" data-date="8:30 - 9:30pm">
      <h3>Closing Ceremony</h3>
      <p>See how is the victor and who are the losers. The big stage is where the winners bask in their own glory.</p>    
    </li>
  </ul>
  <ul class="timeline">
	<span class ="day"><h1>Day 2</h1></span>
    <li class="event" data-date="12:30 - 1:00pm">
      <h3>Breakfast</h3>
      <p>Get here on time. The breakfast starts at 8:30 a.m.</p>
    </li>
    <li class="event" data-date="2:30 - 4:00pm">
      <h3>Opening Ceremony</h3>
      <p>Get ready for an exciting event, this will kick off in amazing fashion with MOP & Busta Rhymes as an opening show.</p>    
    </li>
    <li class="event" data-date="5:00 - 8:00pm">
      <h3>Main Event</h3>
      <p>This is where it all goes down. You will compete head to head with your friends and rivals. Get ready!</p>    
    </li>
    <li class="event" data-date="8:30 - 9:30pm">
      <h3>Closing Ceremony</h3>
      <p>See how is the victor and who are the losers. The big stage is where the winners bask in their own glory.</p>    
    </li>
  </ul>
  <script src='http://cdnjs.cloudflare.com/ajax/libs/jquery/2.1.3/jquery.min.js'></script>

    <script src="js/index.js"></script>

</div>

		</div>
		
		<div class = "block4">
		
		<h1>Accommodation</h1>
		<h1 class = "sectionaccommodation"id = "accommodation">.</h1>
	<div class = "accommodation">
	<img class="mySlides2" src="images/room1.jpg">
	<img class="mySlides2" src="images/room2.jpg">
	<img class="mySlides2" src="images/room1.jpg">
	<img class="mySlides2" src="images/room2.jpg">
	<h2>Private room</h2>
	<p>The room has Wi-Fi, bed, bathroom with a shower, air conditioning and a TV. Room size: 16m2. Bed size: 160cm</p>
	<button class="btnleft" onclick="plusDivs(-1)">&#10094;</button>
	<button class="btnright" onclick="plusDivs(+1)">&#10095;</button>
	</div>
	<div class = "accommodation">
	<img class="mySlides3" src="images/room1.jpg">
	<img class="mySlides3" src="images/room2.jpg">
	<img class="mySlides3" src="images/room1.jpg">
	<img class="mySlides3" src="images/room2.jpg">
	<h2>Group room</h2>
	<p>The room has Wi-Fi, bed, bathroom with a shower, air conditioning and a TV. Room size: 16m2. Bed size: 160cm</p>
	<button class="btnleft" onclick="plusDivs2(-1)">&#10094;</button>
	<button class="btnright" onclick="plusDivs2(+1)">&#10095;</button>
	</div>
	<div class = "accommodation">
	<img class="mySlides4" src="images/room1.jpg">
	<img class="mySlides4" src="images/room2.jpg">
	<img class="mySlides4" src="images/room1.jpg">
	<img class="mySlides4" src="images/room2.jpg">
	<h2>President room</h2>
	<p>The room has Wi-Fi, bed, bathroom with a shower, air conditioning and a TV. Room size: 16m2. Bed size: 160cm</p>
	<button class="btnleft" onclick="plusDivs3(-1)">&#10094;</button>
	<button class="btnright" onclick="plusDivs3(+1)">&#10095;</button>
	</div>
	</div>
	
	
	
	
	<script>
var slideIndex = 1;
showDivs1(slideIndex);

function plusDivs(n) {
    showDivs1(slideIndex += n);
}

function showDivs1(n) {
    var i;
    var x = document.getElementsByClassName("mySlides2");
    if (n > x.length) {slideIndex = 1} 
    if (n < 1) {slideIndex = x.length} ;
    for (i = 0; i < x.length; i++) {
        x[i].style.display = "none"; 
    }
    x[slideIndex-1].style.display = "block"; 
}

var slideIndex = 1;
showDivs2(slideIndex);

function plusDivs2(n) {
    showDivs2(slideIndex += n);
}

function showDivs2(n) {
    var i;
    var x = document.getElementsByClassName("mySlides3");
    if (n > x.length) {slideIndex = 1} 
    if (n < 1) {slideIndex = x.length} ;
    for (i = 0; i < x.length; i++) {
        x[i].style.display = "none"; 
    }
    x[slideIndex-1].style.display = "block"; 
}

var slideIndex = 1;
showDivs3(slideIndex);

function plusDivs3(n) {
    showDivs3(slideIndex += n);
}

function showDivs3(n) {
    var i;
    var x = document.getElementsByClassName("mySlides4");
    if (n > x.length) {slideIndex = 1} 
    if (n < 1) {slideIndex = x.length} ;
    for (i = 0; i < x.length; i++) {
        x[i].style.display = "none"; 
    }
    x[slideIndex-1].style.display = "block"; 
}
</script>
<div class= "locationblock">
	   <h1 class = "sectionlocation"id = "location">.</h1>
	   <h1>Event Location</h3>
                <div class="adress">
                    
                    <address>
                        <p>Eindhoven<br> MAP OF CAMPING “PARK KUIERPAD”<br>Phone: +1159t3764<br> Email: Mercedes-Event@mail.com</p>
                    </address>
                </div>
                <div class="googlemaps">
                    <iframe src="https://www.google.com/maps/embed?pb=!1m18!1m12!1m3!1d96706.50013548559!2d-78.9870674333782!3d40.76030630398601!2m3!1f0!2f0!3f0!3m2!1i1024!2i768!4f13.1!3m3!1m2!1s0x54eab584e432360b%3A0x1c3bb99243deb742!2sUnited+States!5e0!3m2!1sen!2sbd!4v1436299406518" width="100%" height="450" frameborder="0" style="border:0" allowfullscreen></iframe>
               
        </div>
		</div>


</script>

       
	   
 
		
		 <div id="id01" class="modal">
  
  <form class="modal-content animate" action="registerprocess.php" Method = "POST">
    <div class="imgcontainer">
      <span onclick="document.getElementById('id01').style.display='none'" class="close" title="Close Modal">&times;</span>
      <img src="images/img_avatar2.png" alt="Avatar" class="avatar">
    </div>

    <div class="container">
      <label for="firstname"><b>First Name</b></label>
      <input type="text" placeholder="Enter Your First Name" name="firstname" required>
	  
	  <label for="lastname"><b>Last Name</b></label>
      <input type="text" placeholder="Enter Your Last Name" name="lastname" required>
	  
	  <label for="email"><b>Email</b></label>
      <input type="text" placeholder="Enter Your E-mail" name="email" id= "email" required>
		<span id = "availability"></span>
		
      <label for="psw"><b>Password</b></label>
      <input type="password" placeholder="Enter Your Password" name="password" required>
	  
	  <label for="age"><b>Age</b></label>
      <input type="number" placeholder="Enter Your Age" name="age" required>
	  
	  <label for="number"><b>Phone Number</b></label>
      <input type="text" placeholder="Enter Your Phone Number" name="number" required>
	  
	  <div class = "container">
	
	<label><b>Accomadation</b></label>
      <select type="number" id="hotel" name="hotel">
    <option value="0">None</option>
    <option value="1">Private room</option> 
    <option value="2">President room</option>
    <option value="3">Group room</option>
      </select>
	  </div>
	  <div id="add">
	  
	  </div>
        
      <button type="submit">Get Ticket ($55)</button>
      <label>
      
      </label>
    </div>

    
	
	  
	  <div class="container" style="background-color:#f1f1f1">
      <button type="button" onclick="document.getElementById('id01').style.display='none'" class="cancelbtn">Cancel</button>
     
    </div>
  </form>
</div>



<script>
// Get the modal
var modal = document.getElementById('id01');

// When the user clicks anywhere outside of the modal, close it
window.onclick = function(event) {
    if (event.target == modal) {
        modal.style.display = "none";
    }
}




</script>


	  <script type="text/javascript">
	 
		var room = 1;
		function add_input_fields() {
			 removeElement("add");
			var x = document.getElementById("test").value;
		  //alert(x);
		  if(x > 0 ){
			room++;
			
			var i;
			for (i = 0; i < x; i++) { 
					var objTo = document.getElementById('add')
			var divtest = document.createElement("div");
			divtest.innerHTML = '<div><label style = "color: black;" for="added'+ i +'"><b>VisitorID</b></label><input id = "added'+ i +'"  type="text" name="width[]" value="" /></div>';
			objTo.appendChild(divtest)
									}
		  }
		}
		
		function removeElement(elementId) {
    // Removes an element from the document
    var element = document.getElementById(elementId);
   
	while (element.firstChild) {
    element.removeChild(element.firstChild);
}
}
		
    </script> 
		
		

		
			 <div id="id02" class="modal">
  
  <form class="modal-content animate" action="loginprocess.php" Method = "POST">
    <div class="imgcontainer">
      <span onclick="document.getElementById('id02').style.display='none'" class="close" title="Close Modal">&times;</span>
      <img src="images/img_avatar2.png" alt="Avatar" class="avatar">
    </div>

    <div class="container">
      <label for="uname"><b>Email</b></label>
      <input type="text" placeholder="Enter Username" name="email" required>

      <label for="psw"><b>Password</b></label>
      <input type="password" placeholder="Enter Password" name="password" required>
	  
	  <div class = "container">
        
      <button type="submit">Login</button>
      <label>
        <input type="checkbox" checked="checked" name="remember"> Remember me
      </label>
    </div>

    
	
	  
	  <div class="container" style="background-color:#f1f1f1">
      <button type="button" onclick="document.getElementById('id01').style.display='none'" class="cancelbtn">Cancel</button>
      <span class="psw">Forgot <a href="#">password?</a></span>
    </div>
  </form>
</div>

</div>

<script>
// Get the modal
var modal = document.getElementById('id02');

// When the user clicks anywhere outside of the modal, close it
window.onclick = function(event) {
    if (event.target == modal) {
        modal.style.display = "none";
    }
}
</script>






<div id="id03" class="modal">
  
  <form class="modal-content animate" action="add.php" Method = "POST">
    <div class="imgcontainer">
      <span onclick="document.getElementById('id03').style.display='none'" class="close" title="Close Modal">&times;</span>
      <img src="images/accounticon2.png" alt="Avatar" class="avatar">
    </div>

    <div class="container">
  
<div class = "accblock">  
<h2><?php echo $firstname; ?> <?php echo " ".$lastname.  " (CustomerID#"  .$custid .")"?></h2>
<p>Balance: <?php echo "€" . $infobalance?></p>
<label><b>Add Funds:</b></label>
      <select  id="moneychoice" name="amount" onchange="">
    <option value="10">€10</option>
    <option value="20">€20</option> 
    <option value="50">€50</option>
    <option value="100">€100</option>
      </select>
<button class="add" >Add Funds</button>
</div>
<div class = "accblock">
<div class = "accblock2">
 </form>

 
  <form class="" action="addroommate.php" Method = "POST">
<h3>More information</h3>
<div class = "emailandage">
	<div class = "infoemail">
<p class = "infoemailinside">Email:</p>
<p class = "infolbemail"><?php echo $email?></p>
	</div>


			<div class = "infoage">
<p class = "infoageinside">Age:</p>
<p><?php echo $age?></p>
			</div>
</div>


<div class = "infoaccommodation">
<p class = "infoaccommodationinside">Hotel:</p>
<p><?php echo $roomtype ?></p></br>

<div id = >
<?php echo $memberstb ?>
</div>

</div>
	
	</div>
</div>
    </form>
	
	
	
	<style>
.specifymembers {
   width: 110px!important;
}
.specifymembersbtn{
	width: 40px!important;
	    display: inline-block !important;
		padding-left:0px !important;
		padding-right:0px !important;
	
}

</style>
	 
	
	
	
	
	
	
	

 
</div>

</div>

<script>
// Get the modal
var modal = document.getElementById('id03');

// When the user clicks anywhere outside of the modal, close it
window.onclick = function(event) {
    if (event.target == modal) {
        modal.style.display = "none";
    }
}


		function addmoney(){
			alert("TEST");
	var b = document.getElementById("moneychoice").value;
			alert(b);
	
	
	
		}
</script>



<div id="id04" class="modal">
  
  <form class="modal-content animate" action="changesite.php" Method = "POST">
    <div class="imgcontainer">
      <span onclick="document.getElementById('id03').style.display='none'" class="close" title="Close Modal">&times;</span>
      <img src="images/avataradmin.png" alt="Avatar" class="avatar">
    </div>

    <div class="container">
  
<div class = "accblock">  
<h2>Change About Block</h2>

<h3>Text</h3>
 <span class = "changetext"><textarea name="abouttext" >Enter text here...</textarea></span>
<button class="add">Make Changes</button>
</div>
 </form>
 

<div class = "accblock">

 <form action="changesiteURL.php" Method = "POST">
<h3>Video URL</h3>

  
  <p><b>Video URL:</b></p>
	 <input type="text" name="video" accept="image/*">
	<button class="add" action="changesiteURL.php">Make Changes</button>
</div>
    
	 </form>

</div>

</div>








<script>
// Get the modal
var modal = document.getElementById('id04');

// When the user clicks anywhere outside of the modal, close it
window.onclick = function(event) {
    if (event.target == modal) {
        modal.style.display = "none";
    }
}
</script>
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