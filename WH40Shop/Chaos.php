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
    <title>Chaos</title>
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
  <img src="Pictures/Faction_pics/MainCA.jpg" class="card-img ms-auto MainInfo Mainkep" alt="...">
  <div class="card-img-overlay MainInfo TxTcard">
    <h3 class="card-title Maintitle"> Chaos<br><br></h3>
    <p class="card-text fs-6 fw-light font-monospace Maintext">
    Chaos, is the universal and usually malign metaphysical force embodied by the malevolent intelligent entities comprised of psychic energy that live in the Immaterium. <br><br>
    The entities who embody Chaos are mostly Daemons, but the term also encompasses those mortals who have thrown in their lot with Chaos, ranging from simple peasants and/or manufactorum labourers who serve as Chaos Cultists, to even the mighty Chaos Space Marines.<br><br>
    Chaos is also itself the turbulent psychic energy that comprises the alternate dimension known as the Immaterium. It gives shape to the nightmare domains of the individual Chaos Gods that are collectively called the Realm of Chaos.
    </p>
  </div>
</div>

 <ul class="nav nav-tabs mx-auto" id="myTab" role="tablist">
  <li class="nav-item" role="presentation">
    <a class="nav-link active" id="home-tab" data-bs-toggle="tab" href="#home" role="tab" aria-controls="home" aria-selected="true" onclick="CHClick()">All</a>
  </li>
  <li class="nav-item" role="presentation">
    <a class="nav-link" id="CSM-tab" data-bs-toggle="tab" href="#CSM" role="tab" aria-controls="profile" aria-selected="false" onclick="CSMClick()">Chaos Space Marines</a>
  </li>
  <li class="nav-item" role="presentation">
    <a class="nav-link" id="CD-tab" data-bs-toggle="tab" href="#CD" role="tab" aria-controls="contact" aria-selected="false" onclick="CDClick()">Chaos Daemons</a>
  </li>
</ul>
<div class="tab-content mx-auto" id="myTabContent">
  <div class="tab-pane fade show active" id="home" role="tabpanel" aria-labelledby="home-tab">
  <?php 
    
    require ('kapcs.php');
    dbkapcs();
    
    $query='SELECT * FROM `products` WHERE Faction LIKE "Chaos Space Marines" OR Faction LIKE "Daemons" ';
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
  <div class="tab-pane fade" id="CSM" role="tabpanel" aria-labelledby="CW-tab">
  <?php 
    

    $query='SELECT * FROM `products` WHERE Faction LIKE "Chaos Space Marines"';
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
  <div class="tab-pane fade" id="CD" role="tabpanel" aria-labelledby="CD-tab">
    
    <?php 
    

    $query='SELECT * FROM `products` WHERE Faction LIKE "Daemons"';
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

  

</div> 


      <script src="bootstrap-5.0.0-beta1-dist\js\bootstrap.bundle.min.js"></script>
     <script src="Theme.js"></script>
      
    </body>
</html>