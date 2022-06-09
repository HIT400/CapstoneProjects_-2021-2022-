<?php

namespace App\Models;

use Illuminate\Database\Eloquent\Factories\HasFactory;
use Illuminate\Database\Eloquent\Model;
use Illuminate\Foundation\Auth\User as Authenticatable;
use Illuminate\Support\Facades\DB;

class User extends Authenticatable
{
    use HasFactory;

    public function account() {
        return $this->hasOne(Register::class, 'id', 'register_id');
    }

    public function transactions() {
        $transactions = [];

        $account = $this->account;

        $txn1 = DB::table('tollgatea')->select('*')->get();
        $txn2 = DB::table('tollgateb')->select('*')->get();
        $txn3 = DB::table('tollgatec')->select('*')->get();
        $txn4 = DB::table('tollgated')->select('*')->get();

        foreach ($txn1 as $transaction) {
            if ($transaction->CardNumber == $account->CardNumber) {
                array_push($transactions, $transaction);
            }
        }

        foreach ($txn2 as $transaction) {
            if ($transaction->CardNumber == $account->CardNumber) {
                array_push($transactions, $transaction);
            }
        }

        foreach ($txn3 as $transaction) {
            if ($transaction->CardNumber == $account->CardNumber) {
                array_push($transactions, $transaction);
            }
        }

        foreach ($txn4 as $transaction) {
            if ($transaction->CardNumber == $account->CardNumber) {
                array_push($transactions, $transaction);
            }
        }

        return $transactions;
    }
}
