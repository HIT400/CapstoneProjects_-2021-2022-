<?php

function generateEID($username,$address,$phoneNumber,$id_number)
{

    $l = substr($username, 0, 2);
    $a = substr($address, 0, 1);
    $p1 = substr($phoneNumber, 8, 10);
    $p2 = substr($phoneNumber, 3, 6);
    $id = substr($id_number, 8, 11);

    $eid = $l . "-" . $a . "" . $p1 . "" . $id . "/" . $p2;
    $eid =  str_replace(' ', '', $eid);
    return $eid;
}


function getFooter()
{
    return "";
    // return
    //     '
    //  <footer>
    //         <div class="footer-area-bottom" style="background-color: #335d2d;">
    //             <div class="container">
    //                 <p style="color:ghostwhite;font-size:1.1rem">Copyright ©' . date('Y') . ' Umojalands. All rights reserved. Designed by <a href="http://celcest.com" style="color: #f5c551;font-weight:500;">Celcest</a>
    //                 </p>
    //             </div>
    //         </div>
    //     </footer>
    // ';
}

function getSysFooter()
{

    return "";
    // return
    //     '
    //  <footer class="footer d-flex flex-column flex-md-row align-items-center justify-content-between">
    //     <p class="text-muted text-center text-md-left">Copyright © ' . date('Y') . ' Umojalands. All rights reserved</p>
    //     <p class="text-muted text-center text-md-left mb-0 d-none d-md-block">Designed by <a href="http://www.celcest.com">Celcest</a></p>
    //   </footer>
     
    //  ';
}
function getShortcutsNavSeeker()
{
    return
    '
<div class="navbar-content" style="background:#335D2D">

    <ul class="navbar-nav">

        <li class="nav-item dropdown nav-apps">
            <a class="nav-link dropdown-toggle" href="#" id="appsDropdown" role="button" data-toggle="dropdown" aria-haspopup="true" aria-expanded="false">
                <i data-feather="grid" style="color: gold;"></i>
            </a>
            <div class="dropdown-menu" aria-labelledby="appsDropdown">

                <div class="dropdown-body">
                    <div class="d-flex align-items-center apps">
                        <a href="trader.php"><i data-feather="inbox" class="icon-lg" style="color: green;"></i>
                            <p>My stocks</p>
                        </a>
                        <a href="watchlist.php"><i data-feather="eye" class="icon-lg" style="color: green;"></i>
                            <p>Watchlist</p>
                        </a>
                        <a href="account-history.php"><i data-feather="dollar-sign" class="icon-lg" style="color: green;"></i>
                            <p>History</p>
                        </a>
                    </div>
                </div>

            </div>
        </li>
        <li class="nav-item dropdown nav-messages">
            <a class="nav-link dropdown-toggle" href="#" id="messageDropdown" role="button" data-toggle="dropdown" aria-haspopup="true" aria-expanded="false">
                <i data-feather="bell" style="color: gold;"></i>
            </a>
            <div class="dropdown-menu" aria-labelledby="messageDropdown">
                <div class="dropdown-header d-flex align-items-center justify-content-between">
                    <p class="mb-0 font-weight-medium ">0 Notifications</p>
                </div>
                <!-- <div class="dropdown-body">
									<a href="javascript:;" class="dropdown-item">
										<div class="figure">
											<img src="https://via.placeholder.com/30x30" alt="userr">
										</div>
										<div class="content">
											<div class="d-flex justify-content-between align-items-center">
												<p>Leonardo Payne</p>
												<p class="sub-text text-muted">2 min ago</p>
											</div>	
											<p class="sub-text text-muted">Project status</p>
										</div>
                  </a>
                  
							
								</div> -->
                <!-- <div class="dropdown-footer d-flex align-items-center justify-content-center">
									<a href="javascript:;">View all</a>
								</div> -->
            </div>
        </li>

        <li class="nav-item dropdown nav-profile">
            <a class="nav-link dropdown-toggle" href="#" id="profileDropdown" role="button" data-toggle="dropdown" aria-haspopup="true" aria-expanded="false">
                <i data-feather="user" style="color: gold;"></i>
            </a>
            <div class="dropdown-menu" aria-labelledby="profileDropdown">
                
                <div class="dropdown-body">
                    <ul class="profile-nav p-0 pt-3">
                        <li class="nav-item">
                            <a href="profile.php" class="nav-link">
                                <i data-feather="user"></i>
                                <span>Profile</span>
                            </a>
                        </li>


                        <li class="nav-item">
                            <a href="logout.php" class="nav-link">
                                <i data-feather="log-out"></i>
                                <span>Log Out</span>
                            </a>
                        </li>
                    </ul>
                </div>
            </div>
        </li>
    </ul>
</div>';
}
function getShortcutsNav()
{
    return
    '
<div class="navbar-content">

    <ul class="navbar-nav">

        <li class="nav-item dropdown nav-apps">
            <a class="nav-link dropdown-toggle" href="#" id="appsDropdown" role="button" data-toggle="dropdown" aria-haspopup="true" aria-expanded="false">
                <i data-feather="grid" style="color: green;"></i>
            </a>
            <div class="dropdown-menu" aria-labelledby="appsDropdown">

                <div class="dropdown-body">
                    <div class="d-flex align-items-center apps">
                        <a href="land-owner.php"><i data-feather="pocket" class="icon-lg" style="color: green;"></i>
                            <p>Land</p>
                        </a>
                        <a href="land-owner-services.php"><i data-feather="settings" class="icon-lg" style="color: green;"></i>
                            <p>Services</p>
                        </a>
                        <a href="land-owner-profile.php"><i data-feather="instagram" class="icon-lg" style="color: green;"></i>
                            <p>Profile</p>
                        </a>
                    </div>
                </div>

            </div>
        </li>
        <li class="nav-item dropdown nav-messages">
            <a class="nav-link dropdown-toggle" href="#" id="messageDropdown" role="button" data-toggle="dropdown" aria-haspopup="true" aria-expanded="false">
                <i data-feather="bell" style="color: green;"></i>
            </a>
            <div class="dropdown-menu" aria-labelledby="messageDropdown">
                <div class="dropdown-header d-flex align-items-center justify-content-between">
                    <p class="mb-0 font-weight-medium ">0 Notifications</p>
                </div>
                <!-- <div class="dropdown-body">
									<a href="javascript:;" class="dropdown-item">
										<div class="figure">
											<img src="https://via.placeholder.com/30x30" alt="userr">
										</div>
										<div class="content">
											<div class="d-flex justify-content-between align-items-center">
												<p>Leonardo Payne</p>
												<p class="sub-text text-muted">2 min ago</p>
											</div>	
											<p class="sub-text text-muted">Project status</p>
										</div>
                  </a>
                  
							
								</div> -->
                <!-- <div class="dropdown-footer d-flex align-items-center justify-content-center">
									<a href="javascript:;">View all</a>
								</div> -->
            </div>
        </li>

        <li class="nav-item dropdown nav-profile">
            <a class="nav-link dropdown-toggle" href="#" id="profileDropdown" role="button" data-toggle="dropdown" aria-haspopup="true" aria-expanded="false">
                <i data-feather="user" style="color: green;"></i>
            </a>
            <div class="dropdown-menu" aria-labelledby="profileDropdown">
                
                <div class="dropdown-body">
                    <ul class="profile-nav p-0 pt-3">
                        <li class="nav-item">
                            <a href="land-owner-profile.php" class="nav-link">
                                <i data-feather="user"></i>
                                <span>Profile</span>
                            </a>
                        </li>


                        <li class="nav-item">
                            <a href="logout.php" class="nav-link">
                                <i data-feather="log-out"></i>
                                <span>Log Out</span>
                            </a>
                        </li>
                    </ul>
                </div>
            </div>
        </li>
    </ul>
</div>';
}

function getStaffShortcutsNav()
{
    return
    '
<div class="navbar-content">

    <ul class="navbar-nav">

        <li class="nav-item dropdown nav-apps">
            <a class="nav-link dropdown-toggle" href="#" id="appsDropdown" role="button" data-toggle="dropdown" aria-haspopup="true" aria-expanded="false">
                <i data-feather="grid" style="color: gold;"></i>
            </a>
            <div class="dropdown-menu" aria-labelledby="appsDropdown">

                <div class="dropdown-body">
                    <div class="d-flex align-items-center apps">
                        <a href="land-owner.php"><i data-feather="pocket" class="icon-lg" style="color: green;"></i>
                            <p>Land</p>
                        </a>
                        <a href="land-owner-services.php"><i data-feather="settings" class="icon-lg" style="color: green;"></i>
                            <p>Services</p>
                        </a>
                        <a href="land-owner-profile.php"><i data-feather="instagram" class="icon-lg" style="color: green;"></i>
                            <p>Profile</p>
                        </a>
                    </div>
                </div>

            </div>
        </li>
        <li class="nav-item dropdown nav-messages">
            <a class="nav-link dropdown-toggle" href="#" id="messageDropdown" role="button" data-toggle="dropdown" aria-haspopup="true" aria-expanded="false">
                <i data-feather="bell" style="color: gold;"></i>
            </a>
            <div class="dropdown-menu" aria-labelledby="messageDropdown">
                <div class="dropdown-header d-flex align-items-center justify-content-between">
                    <p class="mb-0 font-weight-medium ">0 Notifications</p>
                </div>
                <!-- <div class="dropdown-body">
									<a href="javascript:;" class="dropdown-item">
										<div class="figure">
											<img src="https://via.placeholder.com/30x30" alt="userr">
										</div>
										<div class="content">
											<div class="d-flex justify-content-between align-items-center">
												<p>Leonardo Payne</p>
												<p class="sub-text text-muted">2 min ago</p>
											</div>	
											<p class="sub-text text-muted">Project status</p>
										</div>
                  </a>
                  
							
								</div> -->
                <!-- <div class="dropdown-footer d-flex align-items-center justify-content-center">
									<a href="javascript:;">View all</a>
								</div> -->
            </div>
        </li>

        <li class="nav-item dropdown nav-profile">
            <a class="nav-link dropdown-toggle" href="#" id="profileDropdown" role="button" data-toggle="dropdown" aria-haspopup="true" aria-expanded="false">
                <i data-feather="user" style="color: gold;"></i>
            </a>
            <div class="dropdown-menu" aria-labelledby="profileDropdown">
                
                <div class="dropdown-body">
                    <ul class="profile-nav p-0 pt-3">
                        <li class="nav-item">
                            <a href="land-owner-profile.php" class="nav-link">
                                <i data-feather="user"></i>
                                <span>Profile</span>
                            </a>
                        </li>


                        <li class="nav-item">
                            <a href="logout.php" class="nav-link">
                                <i data-feather="log-out"></i>
                                <span>Log Out</span>
                            </a>
                        </li>
                    </ul>
                </div>
            </div>
        </li>
    </ul>
</div>';
}

function getStaffShortcutsNavStaff()
{
    return
    '
<div class="navbar-content" style="background:#335D2D">

    <ul class="navbar-nav">

    
        <li class="nav-item dropdown nav-messages">
            <a class="nav-link dropdown-toggle" href="#" id="messageDropdown" role="button" data-toggle="dropdown" aria-haspopup="true" aria-expanded="false">
                <i data-feather="bell" style="color: gold;"></i>
            </a>
            <div class="dropdown-menu" aria-labelledby="messageDropdown">
                <div class="dropdown-header d-flex align-items-center justify-content-between">
                    <p class="mb-0 font-weight-medium ">0 Notifications</p>
                </div>
                <!-- <div class="dropdown-body">
									<a href="javascript:;" class="dropdown-item">
										<div class="figure">
											<img src="https://via.placeholder.com/30x30" alt="userr">
										</div>
										<div class="content">
											<div class="d-flex justify-content-between align-items-center">
												<p>Leonardo Payne</p>
												<p class="sub-text text-muted">2 min ago</p>
											</div>	
											<p class="sub-text text-muted">Project status</p>
										</div>
                  </a>
                  
							
								</div> -->
                <!-- <div class="dropdown-footer d-flex align-items-center justify-content-center">
									<a href="javascript:;">View all</a>
								</div> -->
            </div>
        </li>

        <li class="nav-item dropdown nav-profile">
            <a class="nav-link dropdown-toggle" href="#" id="profileDropdown" role="button" data-toggle="dropdown" aria-haspopup="true" aria-expanded="false">
                <i data-feather="user" style="color: gold;"></i>
            </a>
            <div class="dropdown-menu" aria-labelledby="profileDropdown">
                
                <div class="dropdown-body">
                    <ul class="profile-nav p-0 pt-3">
                     

                        <li class="nav-item">
                            <a href="logout.php" class="nav-link">
                                <i data-feather="log-out"></i>
                                <span>Log Out</span>
                            </a>
                        </li>
                    </ul>
                </div>
            </div>
        </li>
    </ul>
</div>';
}
