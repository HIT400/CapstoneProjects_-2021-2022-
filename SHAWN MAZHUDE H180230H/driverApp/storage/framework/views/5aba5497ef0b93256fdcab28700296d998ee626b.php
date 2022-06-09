;
<?php $__env->startSection('content'); ?>


<div class="container">
    <h1>Add Money into Account</h1>
    <form action="<?php echo e(route('update-balance')); ?>" method="POST">
        <?php echo csrf_field(); ?>
        <div class="form-group">
            <label for="Amount">Amount</label>
            <input type="number" class="form-control" name="amount" placeholder="0000" required>
        </div>
        <div class="form-group">
            <button class="btn btn-block btn-primary" type="submit">Submit</button>
        </div>
        <div class="form-group">
            <label for="Amount">New Balance</label>
            <input type="text" class="form-control" placeholder="0000" value="<?php echo e(Auth::user()->account->AvailableBalance); ?>" readonly>
        </div>
    </form>
  </div>

<?php $__env->stopSection(); ?>

<?php echo $__env->make('layouts.master', \Illuminate\Support\Arr::except(get_defined_vars(), ['__data', '__path']))->render(); ?><?php /**PATH C:\Users\dr shelaz\Documents\projects\capstone\driverApp\resources\views/acc.blade.php ENDPATH**/ ?>