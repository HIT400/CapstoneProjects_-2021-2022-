<?php
session_start();
ob_start();
include('./functions.php');
include('./db.php');



$user = getUserByEmail($_SESSION["email"]);


?>

<!DOCTYPE html>
<html lang="en">

<head>
    <meta charset="UTF-8">
    <meta name="viewport" content="width=device-width, initial-scale=1.0">
    <meta http-equiv="X-UA-Compatible" content="ie=edge">
    <title>My Stocks</title>
    <!-- core:css -->
    <link rel="stylesheet" href="assets/vendors/core/core.css">
    <!-- endinject -->
    <!-- plugin css for this page -->
    <link rel="stylesheet" href="assets/vendors/datatables.net-bs4/dataTables.bootstrap4.css">
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


        <div class="page-wrapper">

            <!-- partial:../../partials/_navbar.html -->
            <nav class="navbar">
                <a href="#" class="sidebar-toggler">
                    <i data-feather="menu"></i>
                </a>
                <?= getShortcutsNavSeeker() ?>
            </nav>
            <!-- partial -->

            <div class="page-content" style="background:whitesmoke">

                <br>
                <div class="row">
                    <div class="col-md-12 grid-margin stretch-card">
                        <div class="card">
                            <div class="card-body">
                                <div class="row">
                                    <div class="col-md-6">
                                        <h6 class="card-title">My Stocks</h6>
                                    </div>
                                </div>

                                <div class="table-responsive" style="margin-top: 30px;">
                                    <table id="dataTableExample" class="table">
                                        <thead>
                                            <tr>
                                                <th style="color:#335D2D;font-weight:750">Company name</th>
                                                <th style="color:#335D2D;font-weight:750">Number of stock you own</th>
                                                <th style="color:#335D2D;font-weight:750">Value per stock </th>
                                                <th style="color:#335D2D;font-weight:750">Stocks value</th>
                                                <th style="color:#335D2D;font-weight:750">View</th>
                                            </tr>
                                        </thead>
                                        <tbody>
                                            <?php

                                            $userStocks = explode("/", $user['stocks']);
                                            if ($userStocks[0] == '/' || $userStocks[0] == '' ) {
                                               array_shift($userStocks);
                                            }
                                       
                                       
                                        if(count( $userStocks)>0){
                                                $i = 0;
                                                foreach ($userStocks  as $stock) {
                                                    if($userStocks[$i]==""){
                                                        continue;
                                                    }
                                                    $shares = explode('-', $stock);
                                                    $org  = getOrgById($shares[0]);
                                                    $watch_url  = "view-my-stock.php?id=" . $org['id'] . "&&shares=" . $shares[1];
                                                    echo ('<tr>');
                                                    echo ('<td>' . $org['org_name'] . '</td>');
                                                    echo ('<td>' . $shares[1] . '</td>');
                                                    echo ('<td>' . $org['share_value'] . '</td>');
                                                    echo ('<td>US$ ' . $shares[1] * $org['share_value'] . '</td>');
                                                    echo ('<td><a target="blank"  href="' . $watch_url . '" class=" mr-2" style="color:darkgreen;"><i data-feather="eye"></i></a></td>');
                                                    echo ('</tr>');
                                                    $i++;
                                                }
                                        }

                                           



                                            ?>
                                        </tbody>
                                    </table>
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
    <script src="assets/vendors/datatables.net/jquery.dataTables.js"></script>
    <script src="assets/vendors/datatables.net-bs4/dataTables.bootstrap4.js"></script>
    <!-- end plugin js for this page -->
    <!-- inject:js -->
    <script src="assets/vendors/feather-icons/feather.min.js"></script>
    <script src="assets/js/template.js"></script>
    <!-- endinject -->
    <!-- custom js for this page -->
    <script src="assets/js/data-table.js"></script>
    <!-- end custom js for this page -->
</body>

</html>