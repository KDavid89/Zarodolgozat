<?php  
function dbkapcs() {
    $host="localhost";
    $user="root";
    $pass="";
    $db="zarodolgozat";
    global $kapcs;

    $kapcs=mysqli_connect($host,$user,$pass,$db) or die ('Hiba a kapcsolódáskor!');
    $kapcs -> set_charset("utf8");
    return $kapcs;
}

?>