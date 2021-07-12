<!DOCTYPE html>
<html lang="en">
<head>
    <meta charset="UTF-8">
    <meta http-equiv="X-UA-Compatible" content="IE=edge">
    <meta name="viewport" content="width=device-width, initial-scale=1.0">
    <link rel="stylesheet" href="bootstrap-5.0.0-beta1-dist/css/bootstrap.css">
    <link rel="stylesheet" href="shop.css">
    <link id="dark-theme-style" rel="stylesheet" />
    <script type="text/javascript" src="http://code.jquery.com/jquery-1.7.1.min.js"></script>
    <script src="Shop.js"></script>
    <title>Imperium</title>
</head>
<body class="SHOP">
    
<nav class="navbar navbar-expand-lg navbar-dark bg-dark">
        <div class="container-fluid">
            <span class="navbar-brand mb-0 h1">WH40K</span>
          <button class="navbar-toggler" type="button" data-bs-toggle="collapse" data-bs-target="#navbarSupportedContent" aria-controls="navbarSupportedContent" aria-expanded="false" aria-label="Toggle navigation">
            <span class="navbar-toggler-icon"></span>
          </button>
          <div class="collapse navbar-collapse" id="navbarSupportedContent">
            <ul class="navbar-nav me-auto mb-2 mb-lg-0">
              <li class="nav-item">
                <a class="nav-link active" aria-current="page" href="Index.php">Home</a>
              </li>
             
              <li class="nav-item dropdown">
                <a class="nav-link dropdown-toggle" href="#" id="navbarDropdown" role="button" data-bs-toggle="dropdown" aria-expanded="false">
                  Factions
                </a>
                <ul class="dropdown-menu" aria-labelledby="navbarDropdown">
                    <li><span class="dropdown-item-text">Info</span></li>
                    <li><hr class="dropdown-divider"></li>
                  <li><a class="dropdown-item" href="Imperium.php">Imperium of Man</a></li>
                  <li><a class="dropdown-item" href="Xenos.php">Xenos</a></li>
                  <li><a class="dropdown-item" href="Chaos.php">Armies of Chaos</a></li>
                </ul>
              </li>
              <li class="nav-item">
                <a class="nav-link" href="cart.php">Cart</a>
              </li>
             
            </ul>
            <button type="button" class="btn btn-outline-info"  onclick="toggleTheme()" id="theme-toggler"></button>


          </div>
        </div>
      </nav>
       
      <p class="mb-5"></p>

      <div class="card bg-dark text-white mx-auto border border-dark border-2 MainInfo">
  <img src="Pictures/Faction_pics/Imperium2.jpg" class="card-img ms-auto MainInfo Mainkep" alt="...">
  <div class="card-img-overlay MainInfo TxTcard">
    <h3 class="card-title Maintitle"> The Imperium Of Man<br><br></h3>
    <p class="card-text fs-6 fw-light font-monospace Maintext">The Imperium of Man is a galaxy-spanning interstellar Human empire, the ultimate authority for the majority of the Human species in the Milky Way Galaxy in the late 41st Millennium A.D.<br><br>
        It is ruled by the living god who is known as the Emperor of Mankind.
      His badly damaged body is interred within the cybernetic life support mechanisms of the arcane device known as the Golden Throne following His mortal wounding during the ancient interstellar civil war of the Horus Heresy.
    </p>
  </div>
</div>

 <ul class="nav nav-tabs mx-auto" id="myTab" role="tablist">
  <li class="nav-item" role="presentation">
    <a class="nav-link active" id="home-tab" data-bs-toggle="tab" href="#home" role="tab" aria-controls="home" aria-selected="true" onclick="IMPClick()">All</a>
  </li>
  <li class="nav-item" role="presentation">
    <a class="nav-link" id="SM-tab" data-bs-toggle="tab" href="#SM" role="tab" aria-controls="profile" aria-selected="false" onclick="SMClick()">Space Marines</a>
  </li>
  <li class="nav-item" role="presentation">
    <a class="nav-link" id="AC-tab" data-bs-toggle="tab" href="#AC" role="tab" aria-controls="contact" aria-selected="false" onclick="ACClick()">Adeptus Custodes</a>
  </li>
  <li class="nav-item" role="presentation">
    <a class="nav-link" id="AM-tab" data-bs-toggle="tab" href="#AM" role="tab" aria-controls="contact" aria-selected="false" onclick="AMClick()">Adeptus Mechanicus</a>
  </li>
  <li class="nav-item" role="presentation">
    <a class="nav-link" id="IG-tab" data-bs-toggle="tab" href="#IG" role="tab" aria-controls="contact" aria-selected="false" onclick="IGClick()">Imperial Guard</a>
  </li>
</ul>
<div class="tab-content mx-auto" id="myTabContent">
  <div class="tab-pane fade show active" id="home" role="tabpanel" aria-labelledby="home-tab">
  <?php 
    
    require ('kapcs.php');
    dbkapcs();
    
    $query='SELECT * FROM `products` WHERE Faction LIKE "Space Marines" OR Faction LIKE "Adeptus Mechanicus" OR Faction LIKE "Adeptus Custodes" OR Faction LIKE "Imperial Guard"';
    $eredm=mysqli_query($kapcs,$query);

    echo "<div class='row row-cols-1 row-cols-md-3 g-4'>";
    while ($sor=mysqli_fetch_array($eredm))
     {
       echo  "<form action='' method='POST' onsubmit='' id=".$sor["ID"]."><div class='col'>
       <div class='card h-100'>
         <img src=Pictures/Products/".$sor["Picture"]." class='card-img-top'>
         <div class='card-body'>
           <h5 class='card-title'>".$sor["Name"]."</h5>
           <p class='card-text'><span class='badge bg-secondary'>".$sor["Faction"]."</span> <br> Product for the ".$sor["Faction"]." Faction. <br>ROLE: ".$sor["Role"]." <br> PRICE: ".$sor["Price"]." € </p>
           <div class='row g-2'>
           <div class='col-sm-6'>
           <button type='submit' class='btn btn-primary gomb' name=gomb>Add to Cart</button>
           </div>

           <div class='col-sm'>
           <input type='number' name=Quantity class='form-control' placeholder='Quantity' min=1 aria-label='Quantity'>
         </div>
       
          </div>
         </div>
         <div class='card-footer'>
           <small class='text-muted'><input type=hidden name='TID' value=".$sor["ID"]."></small>
         </div>
       </div>
     </div></form>";

    }
    echo "</div>";
    
    ?>
  </div>
  <div class="tab-pane fade" id="SM" role="tabpanel" aria-labelledby="SM-tab">
  <?php 
    

    $query='SELECT * FROM `products` WHERE Faction LIKE "Space Marines"';
    $eredm=mysqli_query($kapcs,$query);

    echo "<div class='row row-cols-1 row-cols-md-3 g-4'>";
    while ($sor=mysqli_fetch_array($eredm))
     {
       echo  "<form action='' method='POST' onsubmit='' id=".$sor["ID"]."><div class='col'>
       <div class='card h-100'>
         <img src=Pictures/Products/".$sor["Picture"]." class='card-img-top'>
         <div class='card-body'>
           <h5 class='card-title'>".$sor["Name"]."</h5>
           <p class='card-text'><span class='badge bg-secondary'>".$sor["Faction"]."</span> <br> Product for the ".$sor["Faction"]." 
           Faction. <br>ROLE: ".$sor["Role"]." <br> PRICE: ".$sor["Price"]." € </p>
           <div class='row g-2'>
           <div class='col-sm-6'>
          <button type='submit' class='btn btn-primary gomb' name=gomb >Add to Cart</button>
           </div>

           <div class='col-sm'>
           <input type='number' name='Quantity' class='form-control' placeholder='Quantity' min=1 aria-label='Quantity'>
         </div>
       
          </div>
         </div>
         <div class='card-footer'>
           <small class='text-muted'><input type=hidden  name='TID' value=".$sor["ID"]."></small>
         </div>
       </div>
     </div></form>";

    }
    echo "</div>";
    
    ?>
   
  </div>
  <div class="tab-pane fade" id="AC" role="tabpanel" aria-labelledby="AC-tab">
    
    <?php 
    

    $query='SELECT * FROM `products` WHERE Faction LIKE "Adeptus Custodes"';
    $eredm=mysqli_query($kapcs,$query);

    echo "<div class='row row-cols-1 row-cols-md-3 g-4'>";
    while ($sor=mysqli_fetch_array($eredm))
     {
       echo  "<form action='' method='POST' onsubmit='' id=".$sor["ID"]."><div class='col'>
       <div class='card h-100'>
         <img src=Pictures/Products/".$sor["Picture"]." class='card-img-top'>
         <div class='card-body'>
           <h5 class='card-title'>".$sor["Name"]."</h5>
           <p class='card-text'><span class='badge bg-secondary'>".$sor["Faction"]."</span> <br> Product for the ".$sor["Faction"]." 
           Faction. <br>ROLE: ".$sor["Role"]." <br> PRICE: ".$sor["Price"]." € </p>
           <div class='row g-2'>
           <div class='col-sm-6'>
          <button type='submit' class='btn btn-primary gomb' name=gomb >Add to Cart</button>
           </div>

           <div class='col-sm'>
           <input type='number' name='Quantity' class='form-control' placeholder='Quantity' min=1 aria-label='Quantity'>
         </div>
       
          </div>
         </div>
         <div class='card-footer'>
           <small class='text-muted'><input type=hidden  name='TID' value=".$sor["ID"]."></small>
         </div>
       </div>
     </div></form>";

    }
    echo "</div>";
    
    ?>

  </div>

  <div class="tab-pane fade" id="AM" role="tabpanel" aria-labelledby="AM-tab">
    
    <?php 
    

    $query='SELECT * FROM `products` WHERE Faction LIKE "Adeptus Mechanicus"';
    $eredm=mysqli_query($kapcs,$query);

    echo "<div class='row row-cols-1 row-cols-md-3 g-4'>";
    while ($sor=mysqli_fetch_array($eredm))
     {
       echo  "<form action='' method='POST' onsubmit='' id=".$sor["ID"]."><div class='col'>
       <div class='card h-100'>
         <img src=Pictures/Products/".$sor["Picture"]." class='card-img-top'>
         <div class='card-body'>
           <h5 class='card-title'>".$sor["Name"]."</h5>
           <p class='card-text'><span class='badge bg-secondary'>".$sor["Faction"]."</span> <br> Product for the ".$sor["Faction"]." 
           Faction. <br>ROLE: ".$sor["Role"]." <br> PRICE: ".$sor["Price"]." € </p>
           <div class='row g-2'>
           <div class='col-sm-6'>
          <button type='submit' class='btn btn-primary gomb' name=gomb >Add to Cart</button>
           </div>

           <div class='col-sm'>
           <input type='number' name='Quantity' class='form-control' placeholder='Quantity' min=1 aria-label='Quantity'>
         </div>
       
          </div>
         </div>
         <div class='card-footer'>
           <small class='text-muted'><input type=hidden  name='TID' value=".$sor["ID"]."></small>
         </div>
       </div>
     </div></form>";

    }
    echo "</div>";
    
    ?>

  </div>

  <div class="tab-pane fade" id="IG" role="tabpanel" aria-labelledby="IG-tab">
    
    <?php 
    

    $query='SELECT * FROM `products` WHERE Faction LIKE "Imperial Guard"';
    $eredm=mysqli_query($kapcs,$query);

    echo "<div class='row row-cols-1 row-cols-md-3 g-4'>";
    while ($sor=mysqli_fetch_array($eredm))
     {
       echo  "<form action='' method='POST' onsubmit='' id=".$sor["ID"]."><div class='col'>
       <div class='card h-100'>
         <img src=Pictures/Products/".$sor["Picture"]." class='card-img-top'>
         <div class='card-body'>
           <h5 class='card-title'>".$sor["Name"]."</h5>
           <p class='card-text'><span class='badge bg-secondary'>".$sor["Faction"]."</span> <br> Product for the ".$sor["Faction"]." 
           Faction. <br>ROLE: ".$sor["Role"]." <br> PRICE: ".$sor["Price"]." € </p>
           <div class='row g-2'>
           <div class='col-sm-6'>
          <button type='submit' class='btn btn-primary gomb' name=gomb >Add to Cart</button>
           </div>

           <div class='col-sm'>
           <input type='number' name='Quantity' class='form-control' placeholder='Quantity' min=1 aria-label='Quantity'>
         </div>
       
          </div>
         </div>
         <div class='card-footer'>
           <small class='text-muted'><input type=hidden  name='TID' value=".$sor["ID"]."></small>
         </div>
       </div>
     </div></form>";

    }
    echo "</div>";
    
    ?>

  </div>

<!--</div>--> 


      <script src="bootstrap-5.0.0-beta1-dist\js\bootstrap.bundle.min.js"></script>
     <script src="Theme.js"></script>
      
    </body>
</html>