<!DOCTYPE html>
<html lang="en">
<head>
    <meta charset="UTF-8">
    <meta name="viewport" content="width=device-width, initial-scale=1.0">
    <link rel="stylesheet" href="bootstrap-5.0.0-beta1-dist/css/bootstrap.css">
    <link rel="stylesheet" href="Formating.css">
    <link id="dark-theme-style" rel="stylesheet" />

    <title>WH40K</title>
</head>
<body>
    


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


      <div id="carouselExampleCaptions" class="carousel slide" data-bs-ride="carousel">
        <ol class="carousel-indicators">
          <li data-bs-target="#carouselExampleCaptions" data-bs-slide-to="0" class="active"></li>
          <li data-bs-target="#carouselExampleCaptions" data-bs-slide-to="1"></li>
          <li data-bs-target="#carouselExampleCaptions" data-bs-slide-to="2"></li>
          <li data-bs-target="#carouselExampleCaptions" data-bs-slide-to="3"></li>
          <li data-bs-target="#carouselExampleCaptions" data-bs-slide-to="4"></li>
          <li data-bs-target="#carouselExampleCaptions" data-bs-slide-to="5"></li>
          <li data-bs-target="#carouselExampleCaptions" data-bs-slide-to="6"></li>
          <li data-bs-target="#carouselExampleCaptions" data-bs-slide-to="7"></li>
          <li data-bs-target="#carouselExampleCaptions" data-bs-slide-to="8"></li>
          <li data-bs-target="#carouselExampleCaptions" data-bs-slide-to="9"></li>
          <li data-bs-target="#carouselExampleCaptions" data-bs-slide-to="10"></li>
        </ol>
        <div class="carousel-inner">
          <div class="carousel-item active">
              
            <a href="Imperium.php"><img src="Pictures/carousel_pics/SPM.jpg" class="d-block w-100" alt="..."></a>
            
            <div class="carousel-caption d-none d-md-inline">
              <h5>Space Marines</h5>
              <p>The Space Marines or Adeptus Astartes are foremost amongst the <br> defenders of Humanity, the greatest of the Emperor of Mankind's warriors.<br>
                They are barely Human at all, but superhuman; having been made superior in all respects to a normal man by a harsh regime of genetic modification.</p>
            </div>
          </div>
          <div class="carousel-item">
          <a href="Imperium.php"><img src="Pictures/carousel_pics/AC.jpg" class="d-block w-100" alt="..."></a>
            <div class="carousel-caption d-none d-md-block">
              <h5>Adeptus Custodes</h5>
              <p>The Adeptus Custodes, known as the Legio Custodes during the Great Crusade and Horus Heresy eras, <br>
                is the Imperial adepta responsible for protecting the Imperial Palace and the physical body of the Emperor of Mankind,</p>
            </div>
          </div>
          <div class="carousel-item">
          <a href="Imperium.php"><img src="Pictures/carousel_pics/IG.jpg" class="d-block w-100" alt="..."></a>
            <div class="carousel-caption d-none d-md-block">
              <h5>Imperial Guard</h5>
              <p>The Astra Militarum, also known as the Imperial Guard in colloquial Low Gothic,<br>
                  is the largest coherent fighting force in the galaxy. They serve as the Imperium of Man's primary combat force and first line of defence<br> 
                  from the myriad threats which endanger the existence of the Human race in the 41st Millennium.</p>
            </div>
          </div>
        <div class="carousel-item">
        <a href="Imperium.php"><img src="Pictures/carousel_pics/AM.jpg" class="d-block w-100" alt="..."></a>
            <div class="carousel-caption d-none d-md-block">
              <h5>Adeptus Mechanicus</h5>
              <p>Cult of the Machine based on Mars <br> which provides the Imperium with its scientists, engineers and technicians.</p>
            </div>
          </div>

          <div class="carousel-item">
          <a href="Xenos.php"><img src="Pictures/carousel_pics/CE.jpg" class="d-block w-100" alt="..."></a>
            <div class="carousel-caption d-none d-md-block">
              <h5>Craftworld Eldar</h5>
              <p>Ancient humanoid aliens blessed with powerful psychic abilities<br>
              whose vast empire once extended the width and breadth of the known galaxy.<br>
              After the fall of their empire to the the chaos god Slaanesh now live on vast, city-like starships called craftworlds.</p>
            </div>
          </div>

          <div class="carousel-item">
          <a href="Xenos.php"><img src="Pictures/carousel_pics/DR.png" class="d-block w-100" alt="..."></a>
            <div class="carousel-caption d-none d-md-block">
              <h5>Drukhari</h5>
              <p>The Drukhari are a forsaken and corrupt Aeldari kindred, the sadistic, malicious counterparts of the Asuryani.<br>
                Like their cousins of the craftworlds, the Drukhari are an ancient and highly advanced alien race of fey humanoids.</p>
            </div>
          </div>

          <div class="carousel-item">
          <a href="Xenos.php"><img src="Pictures/carousel_pics/NC.jpg" class="d-block w-100" alt="..."></a>
            <div class="carousel-caption d-none d-md-block">
              <h5>Necrons</h5>
              <p>The Necrons are a mysterious xenos species of humanoid, robotic skeletal warriors <br>
                that have lain dormant in their stasis-tombs for more than 60 million Terran years, though they have begun to awaken at last.<br>
                They are the soulless creations and former servants of the ancient C'tan, the terrible Star Gods of Aeldari myth.</p>
            </div>
          </div>

          <div class="carousel-item">
          <a href="Xenos.php"><img src="Pictures/carousel_pics/ORC.jpg" class="d-block w-100" alt="..."></a>
            <div class="carousel-caption d-none d-md-block">
              <h5>Orks</h5>
              <p>The Orks, also called greenskins, are a savage, warlike, green-skinned species of humanoids.<br>
                They are seen by their enemies (pretty much everyone else in the universe) as savage, violent, and crude, but they are the most successful species in the whole galaxy,<br>
                outnumbering possibly every other intelligent starfaring species</p>
            </div>
          </div>

          <div class="carousel-item">
          <a href="Xenos.php"><img src="Pictures/carousel_pics/TN.jpg" class="d-block w-100" alt="..."></a>
            <div class="carousel-caption d-none d-md-block">
              <h5>Tyranids</h5>
              <p>The Tyranids are an extragalactic composite species of hideous, insectoid xenos.<br>
                  They actually comprise an entire space-faring ecosystem comprised of innumerable different bioforms which are all variations on the same genetic theme.<br>
                  They are the ultimate predators; to them, all living things, from the lowliest insect to the most advanced starfaring civilisation, are mere prey.<br> 
                  Only now are the inhabitants of the galaxy realising the scale of the threat; unless the Tyranids can be stopped, it will mean nothing less than the extinction of all life.</p>
            </div>
          </div>

          <div class="carousel-item">
          <a href="Xenos.php"><img src="Pictures/carousel_pics/TU.jpg" class="d-block w-100" alt="..."></a>
            <div class="carousel-caption d-none d-md-block">
              <h5>T'au</h5>
              <p>The T'au also spelled Tau in older records are a young, humanoid and technologically-advanced intelligent species native to the Eastern Fringes of the Milky Way Galaxy.<br>
                  They are fighting to expand their interstellar empire and extend a philosophical concept they call the "Greater Good" (Tau'va in the T'au Lexicon) to all the intelligent species of the galaxy.<br>
                  The T'au claim to be a peaceful species when possible, asking if others will join their cause voluntarily instead of fighting against them.</p>
            </div>
          </div>

          <div class="carousel-item">
          <a href="Chaos.php"><img src="Pictures/carousel_pics/CH.jpg" class="d-block w-100" alt="..."></a>
            <div class="carousel-caption d-none d-md-block">
              <h5>Chaos</h5>
              <p>Chaos, also known to its servants as the Primordial Truth or the Primordial Annihilator,<br>
                and to the Imperium of Man as the Archenemy, is the universal and usually malign metaphysical force<br> 
                embodied by the malevolent intelligent entities comprised of psychic energy that live in the Immaterium.<br>

                The entities who embody Chaos are mostly Daemons, <br> 
                but the term also encompasses those mortals who have thrown in their lot with Chaos,</p>
            </div>
          </div>

          </div>
        <a class="carousel-control-prev" href="#carouselExampleCaptions" role="button" data-bs-slide="prev">
          <span class="carousel-control-prev-icon" aria-hidden="true"></span>
          <span class="visually-hidden">Previous</span>
        </a>
        <a class="carousel-control-next" href="#carouselExampleCaptions" role="button" data-bs-slide="next">
          <span class="carousel-control-next-icon" aria-hidden="true"></span>
          <span class="visually-hidden">Next</span>
        </a>
      </div>
       
      <p class="mb-5"></p>

      <?php 
    
    require ('kapcs.php');
    dbkapcs();
    $query='SELECT * FROM products ORDER BY ID DESC LIMIT 5';
    $eredm=mysqli_query($kapcs,$query);

    echo "<div class='row row-cols-1 row-cols-md-5 g-4 m-1'>";
    while ($sor=mysqli_fetch_array($eredm))
     {
       echo  "<div class='col'>
       <div class='card h-100'>
         <img src=Pictures/Products/".$sor["Picture"]." class='card-img-top'>
         <div class='card-body'>
           <h5 class='card-title'>".$sor["Name"]."</h5>
           <p class='card-text'><span class='badge bg-secondary'>New</span> <br> Product for the ".$sor["Faction"]."
           Faction. <br> PRICE: ".$sor["Price"]." €</p>
         </div>
         <div class='card-footer'>
           <small class='text-muted'></small>
         </div>
       </div>
     </div>";

    }
    echo "</div>";
    
    ?>








  <p class="mb-5"></p>

  <footer class="footer mt-auto py-3 bg-dark">
    <div class="container">
    <ul id=footerlist>
          <li class=footercell><img src="Pictures/Icons/Wcopyright-symbol.png" class=FooterPic><span class="text-muted text-start">All copyrights to their respective owners.</span></li>
          <li class=footercell><img src="Pictures/Icons/Wemail.png" class=FooterPic><span class="text-start text-muted">Our email address: wh40@shops.com</span></li>
          <li class=footercell><img src="Pictures/Icons/Wpin.png" class=FooterPic><span class="text-start text-muted">Location: Szeged, Király u. 4.</span></li>
          </ul>
    </div>
  </footer>
    
        <script src="bootstrap-5.0.0-beta1-dist\js\bootstrap.bundle.min.js"></script>
        <script src="Theme.js"></script>

</body>
</html>