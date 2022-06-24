<?php
session_start();
ob_start();
include('./functions.php');
include('./db.php');

if (empty($_SESSION["auth-user"])) {
	header("Location: my-account.php");
}


$user = getUserByEmail($_SESSION["email"]);

$message = "My profile";

if (isset($_POST['submit'])) {

	$phone = $_POST['phone'];
	$email = $_POST['email'];
	$address = $_POST['address'];
	$password = $_POST['password'];

	updateUser($phone, $email, $address, $password, $user['id']);
	updateEID($eid, $email);
	$_SESSION["email"] = $email;
	$user = getUserByEmail($_SESSION["email"]);
	$message = "Profile updated";
}

?>
<!DOCTYPE html>
<html lang="en">

<head>
	<meta charset="UTF-8">
	<meta name="viewport" content="width=device-width, initial-scale=1.0">
	<meta http-equiv="X-UA-Compatible" content="ie=edge">
	<title>Profile</title>
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
	<script type="text/javascript">
		var Tawk_API = Tawk_API || {},
			Tawk_LoadStart = new Date();
		(function() {
			var s1 = document.createElement("script"),
				s0 = document.getElementsByTagName("script")[0];
			s1.async = true;
			s1.src = 'https://embed.tawk.to/5fe54305df060f156a8ff9ec/1eqborjr8';
			s1.charset = 'UTF-8';
			s1.setAttribute('crossorigin', '*');
			s0.parentNode.insertBefore(s1, s0);
		})();
	</script>
</head>

<body class="sidebar-dark">
	<div class="main-wrapper">

		<!-- partial:../../partials/_sidebar.html -->
		<nav class="sidebar">
			<div class="sidebar-header">
				<a href="my-account.php" class="sidebar-brand" style="margin:12px 0px 12px 0px">
					<p class="text-center">

						<img src="../img/logo_white.png" style="width:90%;height:90%">

					</p>
				</a>
				<div class="sidebar-toggler not-active">
					<span style="background-color: gold;"></span>
					<span style="background-color: gold;"></span>
					<span style="background-color: gold;"></span>
				</div>
			</div>

			<div class="sidebar-body" style="border-right: 1px gold solid;">
				<ul class="nav">

					<li class="nav-item nav-category" style="margin-top:60px;color:gold;font-size:1rem;text-transform:capitalize">Hi <?= $user['username'] ?></li>


					<br>
					<li class="nav-item" style="margin-top:30px">
						<a class="nav-link" href="stocks.php">
							<i class="link-icon" data-feather="layers" style="color: gold;"></i>
							<span class="link-title" style="color: ghostwhite;font-size:1.1rem">Stocks</span>
						</a>

					</li>
					<br>
					<li class="nav-item" style="margin-top:30px">
						<a class="nav-link" href="my-stock.php">
							<i class="link-icon" data-feather="inbox" style="color: gold;"></i>
							<span class="link-title" style="color: ghostwhite;font-size:1.1rem">My Stocks</span>
						</a>

					</li>
					<br>
					<li class="nav-item" style="margin-top:30px">
						<a class="nav-link" href="watchlist.php">
							<i class="link-icon" data-feather="eye" style="color: gold;"></i>
							<span class="link-title" style="color: ghostwhite;font-size:1.1rem">Watchlist</span>
						</a>

					</li>

					<br>
					<li class="nav-item" style="margin-top:30px">
						<a href="account-history.php" class="nav-link">
							<i class="link-icon" data-feather="dollar-sign" style="color: gold;"></i>
							<span class="link-title" style="color: ghostwhite;font-size:1.1rem">Account History</span>
						</a>
					</li>


				</ul>
			</div>


		</nav>


		<div class="page-wrapper">

			<!-- partial:../../partials/_navbar.html -->
			<nav class="navbar">
				<a href="#" class="sidebar-toggler">
					<i data-feather="menu"></i>
				</a>
				<?= getShortcutsNavSeeker() ?>
			</nav>
			<!-- partial -->

			<div class="page-content" style="background:gainsboro ">

				<div class="row" style="padding: 6px;">

					<div class="col-md-8 offset-md-2 grid-margin stretch-card">
						<div class="card" style="background: whitesmoke;">
							<div class="card-body">
								<h6 class="card-title"><?= $message ?></h6>
								<form class="forms-sample" method="post" action="<?php echo $_SERVER['PHP_SELF']; ?>">
									<div class="form-group row">
										<div class="col-sm-9">
											<p style="margin-top:12px"><?= $user['username'] ?></p>
										</div>
									</div>
									<div class="form-group row">
										<label for="exampleInputEmail2" class="col-sm-3 col-form-label">Email</label>
										<div class="col-sm-9">
											<input name="email" type="email" class="form-control" id="exampleInputEmail2" autocomplete="off" value="<?= $user['email'] ?>">
										</div>
									</div>
									<div class="form-group row">
										<label for="exampleInputMobile" class="col-sm-3 col-form-label">Mobile</label>
										<div class="col-sm-9">
											<input name="phone" type="number" class="form-control" id="exampleInputMobile" value="<?= $user['phone'] ?>">
										</div>
									</div>
									<div class="form-group row">
										<label for="exampleInputMobile" class="col-sm-3 col-form-label">Address</label>
										<div class="col-sm-9">
											<input name="address" type="text" class="form-control" id="exampleInputMobile" value="<?= $user['address'] ?>">
										</div>
									</div>
									<div class="form-group row">
										<label for="exampleInputPassword2" class="col-sm-3 col-form-label">Password</label>
										<div class="col-sm-9">
											<input name="password" type="password" class="form-control" id="exampleInputPassword2" autocomplete="off" value="<?= $user['password'] ?>">
										</div>
									</div>

									<input type="submit" name="submit" class="btn btn-primary mr-2" style="color:black;background:gold;width:150px" value="Update">
								</form>
							</div>
						</div>
					</div>

				</div>



			</div>

			<!-- partial:../../partials/_footer.html -->
			<?= getSysFooter() ?>
			<!-- partial -->

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
	<script src="assets/js/file-upload.js"></script>
	<!-- end custom js for this page -->
</body>

</html>