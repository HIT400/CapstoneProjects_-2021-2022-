<?php
session_start();
ob_start();
include('./functions.php');
include('./db.php');

$result = updateUserWatchlist($_GET['id'], $_SESSION["email"]);
header("Location: watchlist.php");

?>