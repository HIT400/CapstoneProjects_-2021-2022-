;
<?php $__env->startSection('content'); ?>

<div class="container">
    <h1>Vehicle Registration Details</h1>
    <div class="row g-2">
      <div class="col-6">
        <div class="p-3 border bg-light">Owner: <?php echo e(Auth::user()->account->VehicleOwner); ?></div>
      </div>
      <div class="col-6">
        <div class="p-3 border bg-light">Number Plate: <?php echo e(Auth::user()->account->NumberPlate); ?></div>
      </div>
      <div class="col-6">
        <div class="p-3 border bg-light">Card Number: <?php echo e(Auth::user()->account->CardNumber); ?></div>
      </div>
      <div class="col-6">
        <div class="p-3 border bg-light">Phone Number: <?php echo e(Auth::user()->account->PhoneNumber); ?></div>
      </div>
      <div class="col-6">
        <div class="p-3 border bg-light">Vehicle Class: <?php echo e(Auth::user()->account->VehicleClass); ?></div>
      </div>
    </div>
  </div>

  <?php $__env->stopSection(); ?>

<?php echo $__env->make('layouts.master', \Illuminate\Support\Arr::except(get_defined_vars(), ['__data', '__path']))->render(); ?><?php /**PATH C:\Users\dr shelaz\Documents\projects\capstone\driverApp\resources\views/details.blade.php ENDPATH**/ ?>