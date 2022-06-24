<?php
session_start();
ob_start();
include('./functions.php');
include('./db.php');


$user = getUserByEmail($_SESSION["email"]);
$org = getOrgById($_GET['id']);
$orgImages = explode('/', $org['images']);
array_shift($orgImages);
$orgDocs = explode('/', $org['docs']);
array_shift($orgDocs);
$_SESSION["org_id"]= $_GET['id'];
$_SESSION["share_val"]= $_GET['shares'];
?>
<!DOCTYPE html>
<html lang="en">

<head>
	<meta charset="UTF-8">
	<meta name="viewport" content="width=device-width, initial-scale=1.0">
	<meta http-equiv="X-UA-Compatible" content="ie=edge">
	<title>View Org</title>
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

	<link rel="stylesheet" href="assets/vendors/core/core.css">
	<!-- endinject -->
	<!-- plugin css for this page -->
	<link rel="stylesheet" href="assets/vendors/select2/select2.min.css">
	<link rel="stylesheet" href="assets/vendors/jquery-tags-input/jquery.tagsinput.min.css">
	<link rel="stylesheet" href="assets/vendors/dropzone/dropzone.min.css">
	<link rel="stylesheet" href="assets/vendors/dropify/dist/dropify.min.css">
	<link rel="stylesheet" href="assets/vendors/bootstrap-colorpicker/bootstrap-colorpicker.min.css">
	<link rel="stylesheet" href="assets/vendors/bootstrap-datepicker/bootstrap-datepicker.min.css">
	<link rel="stylesheet" href="assets/vendors/font-awesome/css/font-awesome.min.css">
	<link rel="stylesheet" href="assets/vendors/tempusdominus-bootstrap-4/tempusdominus-bootstrap-4.min.css">
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
						<a class="nav-link" href="trader.php">
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
		<!-- partial -->

		<div class="page-wrapper">

			<!-- partial:../../partials/_navbar.html -->
			<nav class="navbar">
				<a href="#" class="sidebar-toggler">
					<i data-feather="menu"></i>
				</a>
				<?= getShortcutsNavSeeker() ?>
			</nav>
			<!-- partial -->

			<div class="page-content">

				<div class="row">
					<div class="col-md-12 main-content pl-xl-4 pr-xl-5">



						<div class="example">
							<div class="row">
								<div class="col-md-12 text-center">
									<h6 style="margin:12px;font-weight:750;font-size:1.1rem">></h6>
								</div>

								<br>


								<div class="col-md-12" style="margin-top:12px">
									<div id="carouselExampleIndicators" class="carousel slide" data-ride="carousel" style="padding:12px">

										<?php
										if (count($orgImages) > 0) {
											echo ('<ol class="carousel-indicators">');
											echo ('<li data-target="#carouselExampleIndicators" data-slide-to="0" class="active"></li>');

											for ($i = 1; $i < count($orgImages); $i++) {
												echo ('<li data-target="#carouselExampleIndicators" data-slide-to="' . $i . '"></li>');
											}
											echo ('</ol>');

											echo ('<div class="carousel-inner">');
											echo ('<div class="carousel-item active">
														<img src="orgs/images/' . $orgImages[0] . '" class="d-block w-100" alt="...">
													</div>');


											for ($i = 1; $i < count($orgImages); $i++) {
												echo ('<div class="carousel-item">
														<img src="land/images/' . $orgImages[$i] . '" class="d-block w-100" alt="...">
													</div>');
											}
											echo ('</div> ');;
										}

										?>







										<a class="carousel-control-prev" href="#carouselExampleIndicators" role="button" data-slide="prev">
											<span class="carousel-control-prev-icon" aria-hidden="true"></span>
											<span class="sr-only">Previous</span>
										</a>
										<a class="carousel-control-next" href="#carouselExampleIndicators" role="button" data-slide="next">
											<span class="carousel-control-next-icon" aria-hidden="true"></span>
											<span class="sr-only">Next</span>
										</a>
									</div>
								</div>

								<br>

							</div>

							<br>

							<div class="row">


								<div class="col-md-8">
									<h5 class="text-left lead">
										<br>
										Company details
									</h5>
								</div>
								<div class="col-md-2" style="margin-top: 24px;">
									<p class="text-right">
										<a style="padding: 12px;color: darkgreen" <?php
																					$url = "company-docs.php?id=" . $org['id'];
																					echo ('href="' . $url . '"')

																					?>>
											<i data-feather="file"></i>Documents
										</a>

									</p>
								</div>
								<div class="col-md-2" style="margin-top: 24px;">
									<p class="text-right">
										<a style="padding: 12px;color: darkgreen" <?php
																					$url =  $org['site_url'];
																					echo ('href="' . $url . '"')

																					?>>
											<i data-feather="link"></i>Website
										</a>

									</p>
								</div>


								<table class="table table-striped" style="margin-top:30px">
									<thead>

									</thead>
									<tbody>
										<?php

										echo ('
											<tr>
											<td class="text-left">Company Name:</td>
											<td>' . $org['org_name'] . '</td>
										</tr>
											');

										echo ('
											<tr>
											<td class="text-left">
											Market Value:    
											</td>
											<td>US$' . $org['total_shares'] * $org['share_value'] . '</td>
										</tr>
											');

										echo ('
											<tr>
											<td class="text-left">
											Stock on sale:   
											</td>
											<td>US$' . $org['shares_on_sale'] . '</td>
										</tr>
											');



										?>


									</tbody>
								</table>
								<div class="col-md-12">
									<p class="text-justify">
										<br>
										<?php echo ($org['details']); ?>
									</p>
								</div>
							</div>
							<div class="row" style="padding: 0px;">


								<div class="col-md-2 text-left " style="margin-top:36px">
									<a <?php
										
										echo ('href="sell-stock.php?id=' . $_GET['id'] . '&&shares='. $_GET['shares'].'"');


										?> class="btn btn-primary mr-2" style="color:white;background:green;width:150px;padding:16px;font-weight:750">Sell</a>
								</div>


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
	<script src="assets/vendors/jquery-validation/jquery.validate.min.js"></script>
	<script src="assets/vendors/bootstrap-maxlength/bootstrap-maxlength.min.js"></script>
	<script src="assets/vendors/inputmask/jquery.inputmask.min.js"></script>
	<script src="assets/vendors/select2/select2.min.js"></script>
	<script src="assets/vendors/typeahead.js/typeahead.bundle.min.js"></script>
	<script src="assets/vendors/jquery-tags-input/jquery.tagsinput.min.js"></script>
	<script src="assets/vendors/dropzone/dropzone.min.js"></script>
	<script src="assets/vendors/dropify/dist/dropify.min.js"></script>
	<script src="assets/vendors/bootstrap-colorpicker/bootstrap-colorpicker.min.js"></script>
	<script src="assets/vendors/bootstrap-datepicker/bootstrap-datepicker.min.js"></script>
	<script src="assets/vendors/moment/moment.min.js"></script>
	<script src="assets/vendors/tempusdominus-bootstrap-4/tempusdominus-bootstrap-4.js"></script>
	<!-- end plugin js for this page -->
	<!-- inject:js -->
	<script src="assets/vendors/feather-icons/feather.min.js"></script>
	<script src="assets/js/template.js"></script>
	<!-- endinject -->
	<!-- custom js for this page -->
	<script src="assets/js/form-validation.js"></script>
	<script src="assets/js/bootstrap-maxlength.js"></script>
	<script src="assets/js/inputmask.js"></script>
	<script src="assets/js/select2.js"></script>
	<script src="assets/js/typeahead.js"></script>
	<script src="assets/js/tags-input.js"></script>
	<script src="assets/js/dropzone.js"></script>
	<script src="assets/js/dropify.js"></script>
	<script src="assets/js/bootstrap-colorpicker.js"></script>
	<script src="assets/js/datepicker.js"></script>
	<script src="assets/js/timepicker.js"></script>
	<script src="js/land-listing.js"></script>
</body>

</html>