<html>
<head>
<body>

<table>
<?php 
$conn = new PDO('mysql:host=studmysql01.fhict.local;dbname=dbi378522', 'dbi378522', 'Tia8W8a47Z');
foreach($conn->query("SELECT * FROM `changesite`") as $row)
{
    $abouttxt = $row["AboutText"] ;
	$videourl = $row["VideoURL"] ;
	//echo $abouttxt;
	//$text = $row["Text"] ;
	//$title2 = $row["Title2"] ;
	//$text2 = $row["Text2"] ;
	//$title3 = $row["Title3"] ;
	//$text3 = $row["Text3"] ;
	//$title4 = $row["Title4"] ;
	//$text4 = $row["Text4"] ;
	//$title5 = $row["Title5"] ;
	//$text5 = $row["Text5"] ;
	//$title6 = $row["Title6"] ;
	//$text6 = $row["Text6"] ;
    
}


?>


</table>

</body>
</html>