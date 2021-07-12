<?php
require ('kapcs.php');
dbkapcs();

      $query="INSERT INTO Cart SELECT * FROM Products WHERE ID='$_POST[TID]';
      UPDATE cart SET Quantity='$_POST[Quantity]' WHERE ID='$_POST[TID]';";
      mysqli_multi_query($kapcs,$query);
   ?>
