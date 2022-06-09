<?php

namespace App\Http\Controllers;

use Illuminate\Http\Request;
use App\Models\_register;

class CustomerAuthController extends Controller
{
    public function login()
    {
        return view("auth.login");
    }

    public function loginUser(Request $req)
    {
       // $data = $req->input();
        //$req= session()->put('cardnumber',$data['CardNumber']);
        return redirect('/');


    }
}

