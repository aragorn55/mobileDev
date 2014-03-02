<?php
header("Cache-Control: no-cache");
if(isset($_GET['id'])) 
{
$con = mysql_connect("itsql.fvtc.edu","teamb","teamb");
$connection = mysql_select_db("teamb", $con); 

$id    = $_GET['id'];
$query = "SELECT dev_MainImage " .
         "FROM tbldev WHERE dev_Id = '$id'";

$result = mysql_query($query) or die('Error, query failed');
list($dev_MainImage) = mysql_fetch_array($result);

if(strlen($dev_MainImage) < 10){
	$dev_MainImage = file_get_contents('avatar.png');
}

echo $dev_MainImage;

mysql_close($con); 
exit;
}

