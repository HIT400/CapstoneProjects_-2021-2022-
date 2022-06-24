<?php

session_start();
ob_start();
include('./functions.php');
include('./db.php');

$message = "Welcome, create an account.";

if (!empty($_SESSION["auth-user"])) {
  header("Location: my-account.php");
}

if (isset($_POST['submit'])) {

  $org_name = $_POST['orgName'];
  $phone = $_POST['phone'];
  $email = $_POST['email'];
  $address = $_POST['address'];
  $websiteUrl = $_POST['websiteUrl'];
  $password = $_POST['password'];


  if (!orgIsRegistered($email)) {
    $result = registerOrganization($org_name, $phone, $email, $address, $websiteUrl, $password);

    if ($result>0) {
      $_SESSION["org_id"]= $result;
      header("Location: register-orginization2.php");
    }
    else{
      $message = "You are";
    }
  } else {
    $message = "You are already registered, login";
  }
}
?>
<!DOCTYPE html>
<html lang="en">

<head>
  <meta charset="UTF-8">
  <meta name="viewport" content="width=device-width, initial-scale=1.0">
  <meta http-equiv="X-UA-Compatible" content="ie=edge">
  <title>Register</title>
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
                      <a href="../index.php" class="noble-ui-logo d-block mb-2" style="color: #335d2d;">
                        <img src="../img/logo-v2.png" alt="">
                      </a>
                    </p>

                    <h5 class="font-weight-normal mb-4 text-center" style="color:#000;"><?= $message ?></h5>

                    <form class="forms-sample" method="post" action="<?php echo $_SERVER['PHP_SELF']; ?>" style="padding-left:36px;padding-right:24px">
                      <div class="form-group">
                        <label>Organization name</label>
                        <input name="orgName" type="text" class="form-control" placeholder="Name" required>
                      </div>
                   
                      <div class="form-group">
                        <label>Phone number</label>
                        <input name="phone" type="number" class="form-control" placeholder="Phone number" required>
                      </div>
                      <div class="form-group">
                        <label>Email address</label>
                        <input name="email" type="email" class="form-control" placeholder="Email Address" required>
                      </div>
                      <div class="form-group">
                        <label>Address</label>
                        <input name="address" type="text" class="form-control" placeholder="Address" required>
                      </div>
                      <div class="form-group">
                        <label>Website link</label>
                        <input name="websiteUrl" type="text" class="form-control" placeholder="Address">
                      </div>

                      <div class="form-group">
                        <label for="exampleInputPassword1">Password</label>
                        <input name="password" type="password" class="form-control" id="exampleInputPassword1" autocomplete="current-password" placeholder="Password" required minlength="8">
                      </div>
                      <div class="form-check form-check-flat form-check-primary">
                        <label class="form-check-label">
                          <input type="checkbox" class="form-check-input" required>

                        </label>
                        <a href="../terms.php" style="color:green">I agree to the terms and conditions.</a>

                      </div>
                      <div class="mt-3">
                        <input name="submit" type="submit" class="btn btn-primary mr-2 mb-2 mb-md-0 text-black" style="background:#f5c551;border:0px;padding:15px;width:150px" value="Register">

                        <a href="my-account.php" class="btn btn-primary mr-2 mb-2 mb-md-0 text-white" style="background:#335d2d;border:0px;padding:15px;width:120px">Login</a>

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