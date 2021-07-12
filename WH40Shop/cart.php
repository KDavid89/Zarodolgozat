
<!doctype html>
<html lang="en">
  <head>
    <meta charset="utf-8">
    <meta name="viewport" content="width=device-width, initial-scale=1">
    <link rel="stylesheet" href="bootstrap-5.0.0-beta1-dist\css\bootstrap.css">
    <link rel="stylesheet" href="Formating.css">
    <link id="dark-theme-style" rel="stylesheet" />
    <title>Cart</title>

    <style>
      .bd-placeholder-img {
        font-size: 1.125rem;
        text-anchor: middle;
        -webkit-user-select: none;
        -moz-user-select: none;
        user-select: none;
      }

      @media (min-width: 768px) {
        .bd-placeholder-img-lg {
          font-size: 3.5rem;
        }
      }
    </style>

    
    
    <link href="cart.css" rel="stylesheet">
  </head>
  <body class="bg-light">

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
    
<div class="container">
  <main>
    <div class="row g-3">
      <div class="col-md-5 col-lg-4 order-md-last">
        <h4 class="d-flex justify-content-between align-items-center mb-3">
          <span class="text-muted">Your cart</span>
          <span class="badge bg-secondary rounded-pill"><?php  
          
                
          require ('kapcs.php');
          dbkapcs();

          $query='SELECT * FROM cart ';
          $eredm=mysqli_query($kapcs,$query);
          echo mysqli_num_rows($eredm);
          ?></span>
        </h4>
        <ul class="list-group mb-3">
         <?php 

          $query='SELECT * FROM Cart ORDER BY Price DESC';
          $eredm=mysqli_query($kapcs,$query);

          while ($sor=mysqli_fetch_array($eredm))
          {
            echo"
            <form action='' method=POST >
            <li class='list-group-item d-flex justify-content-between lh-sm'>
              <div>
                <h6 class='my-0'>".$sor['Name']."</h6>
                <small class='text-muted'>".$sor['Quantity']."X</small>
              </div>
              <span class='text-muted'>".$sor['Price']*$sor['Quantity']."€</span>
              <span class='text-muted'><button type='submit' class='btn btn-outline-secondary' name=Rem>X</button></span>
            </li>
            <input type=hidden name=TID value=".$sor["ID"].">
            </form>"
            ;
          }

         ?>
        </ul>

        
      </div>
      <div class="col-md-7 col-lg-8">
        <h4 class="mb-3">Billing address</h4>
        <form class="needs-validation" method="POST" action="" novalidate>
          <div class="row g-3">
            <div class="col-sm-6">
              <label for="firstName" class="form-label">First name</label>
              <input type="text" class="form-control" id="firstName" name=firstname placeholder="" value="" required>
              <div class="invalid-feedback">
                Valid first name is required.
              </div>
            </div>

            <div class="col-sm-6">
              <label for="lastName" class="form-label">Last name</label>
              <input type="text" class="form-control" id="lastName" name=lastname placeholder="" value="" required>
              <div class="invalid-feedback">
                Valid last name is required.
              </div>
            </div>


            <div class="col-12">
              <label for="email" class="form-label">Email <span class="text-muted">(Optional)</span></label>
              <input type="email" class="form-control" id="email" name=email placeholder="you@example.com">
              <div class="invalid-feedback">
                Please enter a valid email address for shipping updates.
              </div>
            </div>


            <div class="col-12">
              <label for="phone" class="form-label">Phone number <span class="text-muted">(Optional)</span></label>
              <input type="tel" class="form-control" id="phone" name=phone placeholder="06202158899">
            </div>

            <div class="col-md-5">
              <label for="City" class="form-label">City</label>
              <input type="text" class="form-control" id="City" name=city placeholder="" value="" required>
              <div class="invalid-feedback">
              </div>
            </div>

            <div class="col-md-4">
              <label for="street" class="form-label">Street</label>
              <input type="text" class="form-control" id="street" name=street placeholder="" value="" required>
              <div class="invalid-feedback">
                
              </div>
            </div>

            <div class="col-md-3">
              <label for="number" class="form-label">Num.</label>
              <input type="text" class="form-control" id="number" name=number placeholder="" required>
              <div class="invalid-feedback">
              </div>
            </div>
          </div>

          <hr class="my-4">

          <hr class="my-4">

        
          <h4 class="mb-3">Payment</h4>

         
          <div class="my-3">
            <div class="form-check">
              <input id="credit" name="paymentMethod" type="radio" class="form-check-input" value='Paid in Advance' checked onclick="PiA()" required>
              <label class="form-check-label" for="credit" >Paid in Advance</label>
            </div>
            <div class="form-check">
              <input id="debit" name="paymentMethod" type="radio" class="form-check-input"  value='Cash on Delivery' onclick="CoD()" required>
              <label class="form-check-label" for="debit">Cash on Delivery</label>
            </div>
          </div>

          <div id=pay>

          <div class="row gy-3">
            <div class="col-md-6">
              <label for="cc-name" class="form-label">Name on card</label>
              <input type="text" class="form-control" id="cc-name" placeholder="" required>
              <small class="text-muted">Full name as displayed on card</small>
              <div class="invalid-feedback">
                Name on card is required
              </div>
            </div>

            <div class="col-md-6">
              <label for="cc-number" class="form-label">Credit card number</label>
              <input type="text" class="form-control" id="cc-number" placeholder="" required>
              <div class="invalid-feedback">
                Credit card number is required
              </div>
            </div>

            <div class="col-md-3">
              <label for="cc-expiration" class="form-label">Expiration</label>
              <input type="text" class="form-control" id="cc-expiration" placeholder="" required>
              <div class="invalid-feedback">
                Expiration date required
              </div>
            </div>

            <div class="col-md-3">
              <label for="cc-cvv" class="form-label">CVV</label>
              <input type="text" class="form-control" id="cc-cvv" placeholder="" required>
              <div class="invalid-feedback">
                Security code required
              </div>
            </div>
          </div>
        </div>
          <hr class="my-4">

          <button class="w-100 btn btn-primary btn-lg" type="submit" name="Orderbutton">Place my Order</button>
        </form>
      </div>
    </div>
  </main>

  
</div>

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
    
          <?php
          
          if (isset($_POST['Rem'])) {
            $Delquery="DELETE FROM Cart WHERE ID='$_POST[TID]';";
            mysqli_query($kapcs,$Delquery);
            echo "<meta http-equiv='refresh' content='0'>"; 
          }
          
          if (isset($_POST['Orderbutton'])) 
          {

            $nev=$_POST['firstname']." ".$_POST['lastname'];
            $address=$_POST['city']." ".$_POST['street']." ".$_POST['number'];
            $pay="";
            $order="";
            $datetime_variable = new DateTime('NOW');
            $datetime_formatted = date_format($datetime_variable, 'y-m-d');
            if ($_POST['paymentMethod'] == 'Cash on Delivery') {
              $pay="Cash on Delivery";
            }else {
              $pay="Paid in Advance";
            }


            $query2='SELECT * FROM Cart ORDER BY Price DESC';
            $eredm2=mysqli_query($kapcs,$query2);
  
            while ($sor2=mysqli_fetch_array($eredm2))
            {
             $order=$order.$sor2['Quantity']."x ".$sor2['Name'].";";
            }



                $query="Insert Into orders values
                ('','$nev','$_POST[email]','$_POST[phone]','$address','$pay','$datetime_formatted','$order')";
                mysqli_query($kapcs,$query);

                $queryDelAll="DELETE FROM cart";
                mysqli_query($kapcs,$queryDelAll);
              
                echo '<script language="javascript">';
                echo 'alert("Your order has been sent! \nThanks for choosing us! ")';
                echo '</script>';
                echo "<meta http-equiv='refresh' content='0'>"; 
          }

          ?>

    <script src="bootstrap-5.0.0-beta1-dist\js\bootstrap.bundle.min.js"></script>
    <script src="Theme.js"></script>
    <script src="cart.js"></script>

  </body>
</html>
