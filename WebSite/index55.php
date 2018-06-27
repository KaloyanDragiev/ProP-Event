<html>
<?php


session_start();

$logged;

$account;
 if (isset($_SESSION['user'])) {
$fronttext = 'Welcome, '.$_SESSION['user']; 
$logged = "Account";
$account = "Logout";}
 else { 
 $logged = "Sign Up";
 $account = "Sign In";}
 
 ?>
<head>

<title>MotorSportEvents</title>



	<link rel="stylesheet" href="ionicons/css/ionicons.min.css">
	<link rel = "stylesheet" type = "text/css" href = "css/about.css">
	<link rel = "stylesheet" type = "text/css" href = "css/timeline.css">
	<link href='https://fonts.googleapis.com/css?family=Raleway:400,200' rel='stylesheet' type='text/css'> 
	<link href='http://fonts.googleapis.com/css?family=Arizonia' rel='stylesheet' type='text/css'>
	<link rel="stylesheet" type="text/css" media = "all" href="css/register.css">

	
	
  
  <link rel="stylesheet" type="text/css" media="all" href="css/styles.css">
  <link rel="stylesheet" type="text/css" media="all" href="css/switchery.min.css">
  <script type="text/javascript" src="js/switchery.min.js"></script>
 <link rel="shortcut icon" href="images/icon.png" type="image/gif" sizes="9x16">
 

</head>
<body>
<section id="home">
<header id="js-header">
<nav id = "navbar1">
<li><button onclick="document.getElementById('id02').style.display='block'" style="width:auto;" class = "button"><?php echo $logged?></button></li>
<text> |</text>
<button onclick="document.getElementById('id01').style.display='block'" style="width:auto;" class = "button"><?php echo $account?></button>




<div id="id02" class="modal2">
  <span onclick="document.getElementById('id02').style.display='none'" class="close" title="Close Modal">&times;</span>
  <form class="modal-content" action="loginprocess.php" method = "POST">
    <div class="container">
      <h1>Log In</h1>
      <p style = color: black;>Please fill in this form to create an account.</p>
      <hr>
        
      <label for="email"><b>Email</b></label>
      <input type="text" placeholder="Enter Email" name="email" required>

      <label for="psw"><b>Password</b></label>
      <input type="password" placeholder="Enter Password" name="password" required>

     
		 
		
		</div>


     <button type="button" onclick="document.getElementById('id02').style.display='none'" class="cancelbtn">Cancel</button>
        <button type="submit" class="signupbtn">Sign In</button>
		
  </form>
</div>










<div id="id01" class="modal">
  <span onclick="document.getElementById('id01').style.display='none'" class="close" title="Close Modal">&times;</span>
  <form class="modal-content" action="registerprocess.php" method = "POST">
    <div class="container">
      <h1>Sign Up</h1>
      <p style = color: black;>Please fill in this form to create an account.</p>
      <hr>
      <label for="email"><b>First Name</b></label>
      <input type="text" placeholder="Enter First Name" name="First-Name" required>
        
        <label for="email"><b>Last Name</b></label>
      <input type="text" placeholder="Enter Last Name" name="Last-Name" required>
        
        <label for="phone"><b>Phone Numb</b></label>
      <input type="text" placeholder="Phone Number" name="phone" required>
        
      <label for="email"><b>Email</b></label>
      <input type="text" placeholder="Enter Email" name="email" required>

      <label for="psw"><b>Password</b></label>
      <input type="password" placeholder="Enter Password" name="password" required>

      <label for="psw-repeat"><b>Repeat Password</b></label>
      <input type="password" placeholder="Repeat Password" name="psw-repeat" required>
      
        <label><b>Accomadations</b></label>
      <select  id="test" name="ab" onchange="add_input_fields()">
    <option value="-1">None</option>
    <option value="1">Private room</option> 
    <option value="2">Group room</option>
    <option value="3">President room</option>
      </select>
	  <div id = "add">
	  
	  
	  </div>
	  
	  <script type="text/javascript">
	  //removeElement("add");
		var room = 1;
		function add_input_fields() {
			var x = document.getElementById("test").value;
		  alert(x);
		  if(x > 0 ){
			room++;
			
			var i;
			for (i = 0; i < x; i++) { 
					var objTo = document.getElementById('add')
			var divtest = document.createElement("div");
			divtest.innerHTML = '<div><label style = "color: black;" for="added'+ i +'"><b>Repeat Password</b></label><input id = "added'+ i +'"  type="text" name="width[]" value="" /></div>';
			objTo.appendChild(divtest)
									}
		  }
		}
		
		function removeElement(elementId) {
    // Removes an element from the document
    var element = document.getElementById(elementId);
    element.parentNode.removeChild(element);
}
		
    </script>
	  
	  
	
     
		 
		
		</div>

      <p>By creating an account you agree to our <a href="#" style="color:dodgerblue">Terms & Privacy</a>.</p>

     <button type="button" onclick="document.getElementById('id01').style.display='none'" class="cancelbtn">Cancel</button>
        <button type="submit" class="signupbtn">Sign Up</button>
		
  </form>
</div>

<script>
// Get the modal
var modal = document.getElementById('id01');
var modal2 = document.getElementById('id02');
// When the user clicks anywhere outside of the modal, close it
window.onclick = function(event) {
    if (event.target == modal) {
        modal.style.display = "none";
    }
	if (event.target == modal2){
	modal2.style.display = "none"
	}
}




</script></li>
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
</header>
<div class = "wholeblock">

<div class = "title">
<h1>Mercedes-Benz Summer conference 2018</h1>
</div>
<img class="mySlides" src="images/4k8.jpg">
<img class="mySlides" src="images/4k8.jpg">
<img class="mySlides" src="images/4k8.jpg">
<img class="mySlides" src="images/4k8.jpg">
</div>
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

<p>Whether you are shopping for a vehicle or checking out the latest innovations,
Mercedes-Benz presents the newest of the new at the auto show. You can get inside our latest
models and see previews of the future. It is also an exiting way to explore our breaktroughs
in safety, luxury and performance that lead the industry. Factory-trained product
specialist can answer your questions, from options and features to technical details.
 You can even go home with a valuable incentive toward your next Mercedes-Benz.</p>
 
 <a href="index.html#register" class="w3-btn w3-white">GET A TICKET</a>
</div>
<div class= "block3right">
<iframe width="550" height="300"
src="https://www.youtube.com/embed/5CzbQUCs8sc">
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
                        <p>Eardenia<br> The Grand Hall<br> House # 08, Road #52, Street<br> Phone: +1159t3764<br> Email: example@mail.com</p>
                    </address>
                </div>
                <div class="googlemaps">
                    <iframe src="https://www.google.com/maps/embed?pb=!1m18!1m12!1m3!1d96706.50013548559!2d-78.9870674333782!3d40.76030630398601!2m3!1f0!2f0!3f0!3m2!1i1024!2i768!4f13.1!3m3!1m2!1s0x54eab584e432360b%3A0x1c3bb99243deb742!2sUnited+States!5e0!3m2!1sen!2sbd!4v1436299406518" width="100%" height="450" frameborder="0" style="border:0" allowfullscreen></iframe>
               
        </div>
		</div>

<div id="wrapper">
  <h1 class = "sectionregister"id = "register">.</h1>
  <h1>Register</h1>
  
  <form onsubmit="return false">
  <div class="col-2">
    <label>
      First Name
      <input placeholder="What is your first name?" id="name" name="name" tabindex="1">
    </label>
  </div>
  <div class="col-2">
    <label>
      Last Name
      <input placeholder="What is your last name?" id="company" name="company" tabindex="2">
    </label>
  </div>
  
  <div class="col-3">
    <label>
      Password
      <input placeholder="Type desired password" id="phone" name="phone" tabindex="3">
    </label>
  </div>
  <div class="col-3">
    <label>
      Repeat password
      <input placeholder="Repeat the password?" id="email" name="email" tabindex="4">
    </label>
  </div>
  <div class="col-3">
    <label>
      Accommodation
      <select tabindex="5">
	    <option>None</option>
        <option>Private room</option>
        <option>Group room</option>
        <option>President room</option>
      </select>
    </label>
  </div>
  
  <div class="col-4">
    <label>
      Phone Number
      <input placeholder="Type your phone number" id="skills" name="skills" tabindex="6">
    </label>
  </div>
  <div class="col-4">
    <label>
      Email
      <input placeholder="Type your email" id="experience" name="experience" tabindex="7">
    </label>
  </div>
  <div class="col-4">
    <label>Contact References?</label>
    <center style="position:relative; margin-bottom:8px;"><input type="checkbox" class="js-switch"></center>
  </div>
  <div class="col-4 switch">
    <label>E-mail Updates?</label>
    <center style="position:relative;margin-bottom:8px;"><input type="checkbox" class="js-switch"></center>
  </div>
  
  <div class="col-submit">
  <div class = "ticketbutton">
  
    <button class="submitbtn">Get a ticket! (€55)</button>
  </div>
  </div>
  
  </form>
  </div>
<script type="text/javascript">
var elems = Array.prototype.slice.call(document.querySelectorAll('.js-switch'));

elems.forEach(function(html) {
  var switchery = new Switchery(html);
});
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