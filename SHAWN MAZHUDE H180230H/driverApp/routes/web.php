<?php

use App\Http\Controllers\AccountController;
use App\Http\Controllers\CustomAuthController;
use App\Http\Controllers\CustomerAuthController;
use Illuminate\Support\Facades\Auth;
use Illuminate\Support\Facades\Route;

/*
|--------------------------------------------------------------------------
| Web Routes
|--------------------------------------------------------------------------
|
| Here is where you can register web routes for your application. These
| routes are loaded by the RouteServiceProvider within a group which
| contains the "web" middleware group. Now create something great!
|
*/

Route::post('logout', function() {
    Auth::logout();
    return back();
})->middleware('auth')->name('logout');

Route::get('/', function () {
    return view('welcome');
})->middleware('auth');

Route::get('/login', [CustomerAuthController::class, 'login'])->name('login');
Route::post('login-user', [CustomAuthController::class, 'authenticate'])->name('login-user');
Route::get('/details', function () {
    return view('details');
})->middleware('auth');
Route::get('/acc', function () {
    return view('acc');
})->middleware('auth');

Route::post('update-balance', [AccountController::class, 'addBalance'])->name('update-balance');
