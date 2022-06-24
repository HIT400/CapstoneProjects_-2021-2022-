<?php

session_start();
ob_start();
include('./functions.php');
include('./db.php');

$org = getOrgById($_GET['id']);

if(isset($_GET['id'])){
  $_SESSION["stockID"] = $_GET['id'];
}
$message = "Buy " . $org['org_name'] . " stock";


if (isset($_POST['submit'])) {

  $stockNum = $_POST['stockNum'];
  $_SESSION["stockNum"] = $stockNum;

  
    
      header("Location: buy-stock2.php");
   
}
?>
<!DOCTYPE html>
<html lang="en">

<head>
  <meta charset="UTF-8">
  <meta name="viewport" content="width=device-width, initial-scale=1.0">
  <meta http-equiv="X-UA-Compatible" content="ie=edge">
  <title>Buy shares</title>
  <!-- core:css -->
  <link rel="stylesheet" href="assets/vendors/core/core.css">
  <!-- endinject -->
  <!-- plugin css for this page -->
  <!-- end plugin css for this page -->
  <!-- inject:css -->
  <link rel="stylesheet" href="assets/fonts/feather-font/css/iconfont.css">
  <link rel="stylesheet" href="assets/vendors/flag-icon-css/css/flag-icon.min.css">
  <!-- endinject -->
  <!-- Layout styles -->
  <link rel="stylesheet" href="assets/css/demo_1/style.css">
  <!-- End layout styles -->
  <link rel="shortcut icon" href="../img/favicon.png" />
</head>

<body class="sidebar-dark">
  <div class="main-wrapper">
    <div class="page-wrapper full-page" style="background: url('images/main_bg.jpg');">
      <div class="page-content d-flex align-items-center justify-content-center">

        <div class="row w-100 mx-0 auth-page">
          <div class="col-md-8 col-xl-6 mx-auto">
            <div class="card" style="background: rgba(255, 255, 255, 0.9);">
              <div class="row">

                <div class="col-md-12 pl-md-0 ">
                  <div class="auth-form-wrapper px-4 py-5">

                    <p class="text-center" style="margin-top:-21px">
                      <a href="my-account.php" class="noble-ui-logo d-block mb-2" style="color: #335d2d;">
                        <img src="../img/logo-v2.png" alt="">
                      </a>
                    </p>

                    <h5 class="font-weight-normal mb-4 text-center" style="color:#000;"><?= $message ?></h5>

                    <form class="forms-sample" method="post" action="<?php echo $_SERVER['PHP_SELF']; ?>" style="padding-left:36px;padding-right:24px">
                      <div class="form-group">
                        <label>Number of stocks at US$ <?= $org['share_value'] ?> / stock</label>
                        <input name="stockNum" type="number" class="form-control" placeholder="1" step="0.01"  min="0.1" required max="<?= $org['shares_on_sale'] ?>">
                      </div>


                      <div class="mt-3">
                        <input name="submit" type="submit" class="btn btn-primary mr-2 mb-2 mb-md-0 text-black" style="background:#f5c551;border:0px;padding:15px;width:150px" value="Next">


                      </div>
                    </form>
                  </div>
                </div>
              </div>
            </div>
          </div>
        </div>

      </div>
    </div>
  </div>

  <!-- core:js -->
  <script src="assets/vendors/core/core.js"></script>
  <!-- endinject -->
  <!-- plugin js for this page -->
  <!-- end plugin js for this page -->
  <!-- inject:js -->
  <script src="assets/vendors/feather-icons/feather.min.js"></script>
  <script src="assets/js/template.js"></script>
  <!-- endinject -->
  <!-- custom js for this page -->
  <!-- end custom js for this page -->
</body>

</html>