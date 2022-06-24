<?php

session_start();
ob_start();
include('./functions.php');
include('./db.php');

$message = "Welcome back! Log in to your account.";

if (!empty($_SESSION["auth-user"])) {
  header("Location: dashboard.php");
}

if (isset($_POST['submit'])) {


  $email = $_POST['u_email'];
  $password = $_POST['u_password'];

  if (userIsRegistered($email, $password)) {
    $loginUser = loginUser($email, $password);

    if ($loginUser) {
      $_SESSION["auth-user"] = TRUE;
      $_SESSION["auth-acc-type"] = 'user';
      $user = getUserByEmail($email);
      $_SESSION["email"] = $email;

      header("Location: trader.php");
    }
  } elseif (orgIsRegistered($email, $password)) {
    $loginOrg = loginOrganization($email, $password);
    if ($loginOrg) {

        $_SESSION["auth-user"] = TRUE;
        $_SESSION["email"] = $email;
        
        header("Location: org-home.php");
      }

      $message = "Wrong email address or password";
    }
  } else {
    $message = "Wrong email address or password";
  }


?>

<!DOCTYPE html>
<html lang="en">

<head>
  <meta charset="UTF-8">
  <meta name="viewport" content="width=device-width, initial-scale=1.0">
  <meta http-equiv="X-UA-Compatible" content="ie=edge">
  <title>My account</title>
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
  <link rel="shortcut icon" href="img/favicon.png" />
</head>

<body class="sidebar-dark">
  <div class="main-wrapper">
    <div class="page-wrapper full-page" style="background: url('images/main_bg.jpg');">
      <div class="page-content d-flex align-items-center justify-content-center">

        <div class="row w-100 mx-0 auth-page">
          <div class="col-md-8 col-xl-6 mx-auto">
            <div class="card">
              <div class="row">
                <div class="col-md-5 pr-md-0">
                  <div class="auth-left-wrapper" style="background-image: url('images/login-bg.jpg');">

                  </div>
                </div>
                <div class="col-md-7 pl-md-0">
                  <div class="auth-form-wrapper px-4 py-5">
                   
                    <p class="text-center">
                      <a href="../index.php" class="noble-ui-logo d-block mb-2" style="color: #335d2d;">
                        <img src="../img/logo-v2.png" alt="">
                      </a>
                    </p>
                    <h5 class="font-weight-normal mb-4 text-center" style="color:#000;margin:24px;font-size:0.95rem"><?= $message ?></h5>
                    <form class="forms-sample" method="post" action="<?php echo $_SERVER['PHP_SELF']; ?>">
                      <div class="form-group">
                        <label>Email address</label>
                        <input name="u_email" type="email" class="form-control" placeholder="Email address" required>
                      </div>
                      <div class="form-group">
                        <label for="exampleInputPassword1">Password</label>
                        <input name="u_password" type="password" class="form-control" id="exampleInputPassword1" autocomplete="current-password" placeholder="Password" required minlength="8">
                      </div>

                      <div class="form-check form-check-flat form-check-primary">
                        <label class="form-check-label">
                          <input type="checkbox" class="form-check-input">
                          Remember me
                        </label>
                      </div>

                      <div class="mt-3">
                        <input type="submit" name="submit" class="btn btn-primary mr-2 mb-2 mb-md-0 text-black" style="background:#f5c551;border:0px;padding:15px;width:150px" value="Login">
                        <a href="register.php" class="btn btn-primary mr-2 mb-2 mb-md-0 text-white" style="background:#335d2d;border:0px;padding:15px;width:120px">Register</a>

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