<?php
session_start();
ob_start();
include('./functions.php');
include('./db.php');

if (empty($_SESSION["auth-user"])) {
  header("Location: my-account.php");
}

switch ($_SESSION["auth-acc-type"]) {
  case 'user':
    header("Location: trader.php");
    break;
  case 'org':
    header("Location: org-home.php");
    break;
  default:
    header("Location: logout.php");
    break;
}



?>
