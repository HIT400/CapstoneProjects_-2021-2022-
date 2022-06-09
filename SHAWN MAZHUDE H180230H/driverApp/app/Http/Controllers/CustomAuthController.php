<?php

namespace App\Http\Controllers;

use App\Models\Register;
use App\Models\User;
use Exception;
use Illuminate\Http\Request;
use Illuminate\Support\Facades\Auth;
use Illuminate\Support\Facades\Hash;

class CustomAuthController extends Controller
{
    public function authenticate (Request $request) {
        // dd($request->all());
        try {
            $request->validate(
                [
                    "card_number" => "required",
                    "number_plate" => "required"
                ]
            );

            $registeredAccount = Register::where('CardNumber', $request->input('card_number'))->where('NumberPlate', $request->input('number_plate'))->first();

            if ($registeredAccount == null) {
                return back()->with('error', ['message' => 'Account doesnt exist']);
            }

            $user = User::where('register_id', $registeredAccount->id)->first();

            if ($user == null) {
                $user = new User;
                $user->name = $registeredAccount->VehicleOwner;
                $user->email = $registeredAccount->PhoneNumber . "@tollgate.co.zw";
                $user->register_id = $registeredAccount->id;
                $password = $registeredAccount->NumberPlate . "@tollgate";
                $user->password = Hash::make($password);
                $user->save();
            }

            Auth::login($user, true);

            return redirect('/');
        } catch (Exception $ex) {
            dd($ex);
        }
    }
}
