@extends('layouts.master');
@section('content')
<main class="col-md-9 ms-sm-auto col-lg-10 px-md-4">
    <div class="d-flex justify-content-between flex-wrap flex-md-nowrap align-items-center pt-3 pb-2 mb-3 border-bottom">
      <h1 class="h2">Dashboard</h1>

    </div>
<!-- Card bodies -->
<div class="row row-cols-1 row-cols-md-3 mb-3 text-center">
  <div class="col">
    <div class="card mb-4 rounded-3 shadow-sm border-primary">
      <div class="card-header py-3 text-white bg-primary border-primary">
        <h4 class="my-0 fw-normal">Available</h4>
      </div>
      <div class="card-body">
        <ul class="list-unstyled mt-3 mb-4">
          <li>{{ Auth::user()->account->AvailableBalance }}</li>
        </ul>
      </div>
    </div>
  </div>
</div>

<!--end card body-->


    <h2>Previous Toll Transactions</h2>
    <div class="table-responsive">
      <table class="table table-striped table-sm">
        <thead>
          <tr>
         <!--   <th scope="col">#</th> -->
            <th scope="col">PhoneNumber</th>
            <th scope="col">Amount</th>
            <th scope="col">Date</th>
          </tr>
        </thead>
        <tbody>
            @foreach (Auth::user()->transactions() as $transaction)
            <tr>
               <!-- <td>{{ $transaction->id }}</td> -->
                <td>{{ $transaction->PhoneNumber }}</td>
                <td>{{ $transaction->AmountPaid }}</td>
                <td>{{ $transaction->Date }}</td>
            </tr>
            @endforeach
        </tbody>
      </table>
    </div>
  </main>
</div>
</div>

@endsection
