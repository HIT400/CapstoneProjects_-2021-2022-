<?php

session_start();
ob_start();
include('./functions.php');
include('./db.php');

$org = getOrgById($_SESSION["stockID"]);
$user = getUserByEmail($_SESSION["email"]);


$message = "Buy " . $org['org_name'] . " " . $_SESSION["stockNum"] . " stock at  US$ " . ($_SESSION["stockNum"] * $org['share_value']);


if (isset($_POST['submit'])) {

  if ($user['balance'] >= ($_SESSION["stockNum"] * $org['share_value'])) {
    //update user shares 
    $result = updateUserStocks($user["email"], $org["id"], $_SESSION["stockNum"]);

    if ($result) {
      //update company shares 
      $shares_on_sale = $org["shares_on_sale"] - $_SESSION["stockNum"];
      $result1 = updateOrgOnSaleShares($shares_on_sale, $org["id"]);
      $result2 = updateOrgAddOwner($org["id"], $user['id']);


      if($result&&$result2){
        //update user balance
        $result =  updateUserBalance($_SESSION["email"], $user['balance']- ($_SESSION["stockNum"] * $org['share_value']));
        if($result){
          header("Location: my-stock.php");
        }
      }
    }

    

  } else {
    $message = "Your account balance is too low";
  }
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
                        <label>Pay</label>
                        <input type="text" class="form-control" value="US$ <?= ($_SESSION["stockNum"] * $org['share_value']) ?>" disabled>
                      </div>


                      <div class="mt-3">
                        <input name="submit" type="submit" class="btn btn-primary mr-2 mb-2 mb-md-0 text-black" style="background:#f5c551;border:0px;padding:15px;width:150px" value="PAY">


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