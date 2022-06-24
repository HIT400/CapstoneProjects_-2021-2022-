<?php
session_start();
ob_start();
include('./functions.php');
include('./db.php');



$ds = DIRECTORY_SEPARATOR;
$storeFolder = 'orgs/docs/';


// if (isset($_GET['l'])) {
// 	$land = getLandById($_GET['l']);
// 	if ($land['eid'] != $eid) {
// 		header("Location: logout.php");
// 	}
// 	$_SESSION["land_list_images_upload"] = $_GET['l'];
// }

if (!empty($_FILES)) {

	$tempFile = $_FILES['file']['tmp_name'];

	$targetPath = dirname(__FILE__) . $ds . $storeFolder . $ds;

	$targetFile =  $targetPath . $_FILES['file']['name'];

	$uploadedFile = $_FILES['file']['name'];
	updateOrgDocsById($_SESSION["org_id"], $uploadedFile);
	move_uploaded_file($tempFile, $targetFile);
}


?>
<!DOCTYPE html>
<html lang="en">

<head>
	<meta charset="UTF-8">
	<meta name="viewport" content="width=device-width, initial-scale=1.0">
	<meta http-equiv="X-UA-Compatible" content="ie=edge">
	<title>Company docs</title>
	<!-- core:css -->
	<link rel="stylesheet" href="assets/vendors/core/core.css">
	<!-- endinject -->
	<!-- plugin css for this page -->
	<!-- end plugin css for this page -->
	<!-- inject:css -->
	<link rel="stylesheet" href="assets/fonts/feather-font/css/iconfont.css">
	<link rel="stylesheet" href="assets/vendors/flag-icon-css/css/flag-icon.min.css">
	<!-- Layout styles -->
	<link rel="stylesheet" href="assets/css/demo_1/style.css">
	<!-- End layout styles -->
	<link rel="shortcut icon" href="../img/favicon.png" />

	<link rel="stylesheet" href="assets/vendors/select2/select2.min.css">
	<link rel="stylesheet" href="assets/vendors/jquery-tags-input/jquery.tagsinput.min.css">
	<link rel="stylesheet" href="assets/vendors/dropzone/dropzone.min.css">
	<link rel="stylesheet" href="assets/vendors/dropify/dist/dropify.min.css">
	<link rel="stylesheet" href="assets/vendors/bootstrap-colorpicker/bootstrap-colorpicker.min.css">
	<link rel="stylesheet" href="assets/vendors/bootstrap-datepicker/bootstrap-datepicker.min.css">
	<link rel="stylesheet" href="assets/vendors/font-awesome/css/font-awesome.min.css">
	<link rel="stylesheet" href="assets/vendors/tempusdominus-bootstrap-4/tempusdominus-bootstrap-4.min.css">
	<!-- core:css -->
	<link rel="shortcut icon" href="../img/favicon.png" />
</head>

<body>
	<div class="main-wrapper" style="background: url('images/main_bg.jpg');background-size: cover;">

		<!-- partial:../../partials/_sidebar.html -->


		<!-- partial -->

		<div class="page-wrapper" style="background: url('images/main_bg.jpg');background-size: cover;" 1>

			<!-- partial:../../partials/_navbar.html -->


			<div class="page-content">

				<div class="row">
					<div class="col-md-8 offset-md-1 stretch-card grid-margin grid-margin-md-0">
						<div class="card">
							<div class="card-body">
								<h6 class="card-title"> Upload company documents/profiles</h6>
								<br>
								<form action="<?php echo $_SERVER['PHP_SELF']; ?>" enctype="multipart/form-data" class="dropzone" id="exampleDropzone">

								</form>
								<br>
								<br>
								<?php
								if (isset($_GET['l'])) {
									echo (' <a href="land_images.php?l=' . $_GET['l'] . '"  class="btn btn-primary mr-2" style="color:black;background:gold;width:150px">Done</a>
								');
								} else {
									echo (' <a href="org-home.php" class="btn btn-primary mr-2" style="color:black;background:gold;width:150px">Next</a>
								');
								}

								?>

							</div>
						</div>
					</div>

				</div>

			</div>


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
	<!-- end custom js for this page -->

	<script type="text/javascript">
		Dropzone.options.exampleDropzone = {
			maxFilesize: 10,
			acceptedFiles: ".pdf,.doc,.docx,.xls,.xlsx,.csv,.txt,.rtf,.html"
		};
	</script>

</body>

</html>