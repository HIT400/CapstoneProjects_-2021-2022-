@extends('layouts.master');
@section('content')

<div class="container">
    <h1>Vehicle Registration Details</h1>
    <div class="row g-2">
      <div class="col-6">
        <div class="p-3 border bg-light">Owner: {{ Auth::user()->account->VehicleOwner }}</div>
      </div>
      <div class="col-6">
        <div class="p-3 border bg-light">Number Plate: {{ Auth::user()->account->NumberPlate }}</div>
      </div>
      <div class="col-6">
        <div class="p-3 border bg-light">Card Number: {{ Auth::user()->account->CardNumber }}</div>
      </div>
      <div class="col-6">
        <div class="p-3 border bg-light">Phone Number: {{ Auth::user()->account->PhoneNumber }}</div>
      </div>
      <div class="col-6">
        <div class="p-3 border bg-light">Vehicle Class: {{ Auth::user()->account->VehicleClass }}</div>
      </div>
    </div>
  </div>

  @endsection
