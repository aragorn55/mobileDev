<?php
header("Cache-Control: no-cache");
if(isset($_POST['upload']) && $_FILES['userfile']['size'] > 0)
{
$fileName = $_FILES['userfile']['name'];
$tmpName  = $_FILES['userfile']['tmp_name'];
$fileSize = $_FILES['userfile']['size'];
$fileType = $_FILES['userfile']['type'];

$fp      = fopen($tmpName, 'r');
$content = fread($fp, filesize($tmpName));
$content = addslashes($content);
fclose($fp);


$con = mysql_connect("itsql.fvtc.edu","teamb","teamb");
$connection = mysql_select_db("teamb", $con); 

$query = "UPDATE tbldev set dev_MainImage ='$content' where dev_Id = 7";

mysql_query($query) or die('Error, query failed'); 

mysql_close($con);

} 
?>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">
<html xmlns="http://www.w3.org/1999/xhtml">
<head>
<meta http-equiv="Content-Type" content="text/html; charset=utf-8" />
<title>Untitled Document</title>
</head>
<body>
<img height="250" width="250" src="getimage.php?id=7" /><br />
<br />

<form method="post" enctype="multipart/form-data">
    <input type="hidden" name="MAX_FILE_SIZE" value="2000000">
    <input name="userfile" type="file" id="userfile"> 
    <input name="upload" type="submit" class="box" id="upload" value=" Upload ">
</form>




</body>
</html>
