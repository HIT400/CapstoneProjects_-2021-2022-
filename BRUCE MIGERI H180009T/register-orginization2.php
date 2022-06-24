<?php
session_start();
ob_start();
include('functions.php');
include('./db.php');

if ($_SESSION["org_id"] < 0) {
	header("Location: my-account.php");
}




$message = "Almost there";


if (isset($_POST['submit'])) {

	$total_shares = $_POST['total_shares'];
	$shares_on_sale = $_POST['shares_on_sale'];
	$share_value = $_POST['share_value'];
	$details = $_POST['details'];

	$result = updateOrgShares($total_shares,$shares_on_sale,$share_value,$details, $_SESSION["org_id"] );

	if ($result) {

		header("Location: upload-org-images.php");
	}
}

?>


<!DOCTYPE html>
<html lang="en">

<head>
	<meta charset="UTF-8">
	<meta name="viewport" content="width=device-width, initial-scale=1.0">
	<meta http-equiv="X-UA-Compatible" content="ie=edge">
	<title>Trade Insider</title>
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

<body>





	<!-- partial -->

	<div class="page-wrapper" style="background: url('images/main_bg.jpg');height: 1080px;">

		<!-- partial:../../partials/_navbar.html -->


		<div class="page-content">

			<div class="row" style="padding: 6px;">

				<div class="col-md-8 offset-md-2 grid-margin stretch-card">
					<div class="card" style="background:rgba(255, 255, 255, 0.75)">
						<div class="card-body">
							<h6 class="card-title text-center"><?= $message ?></h6>
							<form method="post" action="<?php echo $_SERVER['PHP_SELF']; ?>">
								<br>
								<div class="form-group">
									<label for="total_shares">Company total shares</label>
									<input name="total_shares" type="number" step="0.01" class="form-control" id="total_shares" required>
								</div>

								<div class="form-group">
									<label for="shares_on_sale">Total shares on sale</label>
									<input name="shares_on_sale" type="number" step="0.01" class="form-control" id="shares_on_sale" required>
								</div>
								<div class="form-group">
									<label for="share_value">Value per share in USD</label>
									<input name="share_value" type="number" step="0.01" class="form-control" id="share_value" required>
								</div>

								<div class="form-group">
									<textarea class="form-control" name="details" id="details" rows="12" placeholder="Brief company details"></textarea>
								</div>






								<input type="submit" name="submit" class="btn btn-primary mr-2" style="color:black;background:gold;width:150px" value="NEXT">
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
	<script src="assets/vendors/tinymce/tinymce.min.js"></script>

</body>

</html>