@extends('layouts.master');
@section('content')


<div class="container">
    <h1>Add Money into Account</h1>
    <form action="{{ route('update-balance') }}" method="POST">
        @csrf
        <div class="form-group">
            <label for="Amount">Amount</label>
            <input type="number" class="form-control" name="amount" placeholder="0000" required>
        </div>
        <div class="form-group">
            <button class="btn btn-block btn-primary" type="submit">Submit</button>
        </div>
        <div class="form-group">
            <label for="Amount">New Balance</label>
            <input type="text" class="form-control" placeholder="0000" value="{{ Auth::user()->account->AvailableBalance }}" readonly>
        </div>
    </form>
  </div>

@endsection
