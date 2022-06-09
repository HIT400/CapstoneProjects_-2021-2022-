<?php

namespace App\Http\Controllers;

use Illuminate\Http\Request;
use Illuminate\Support\Facades\Auth;

class AccountController extends Controller
{
    public function __construct()
    {
        $this->middleware('auth');
    }

    public function addBalance(Request $request) {
        $account = Auth::user()->account;

        $balance = $account->AvailableBalance;

        $newBalance = floatval($balance) + $request->input('amount');

        // dd($newBalance);

        $account->AvailableBalance = "" . $newBalance;
        $account->save();

        return back();
    }
}
