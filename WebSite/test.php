
<html>
<head>
<script type = "text/javascript" src = "jquery.js">  </script>
<script type = "text/javascript">
$(document).ready(function(){
	$('#feedback').load('check.php').show();
	
});
</script>
</head>

<body>
<form name = "form">
EMAIL: <br/>
<input type = "text" id="email" name = "email"></input>
</form>

<div id = "feedback"></div>
</body>
</html>

