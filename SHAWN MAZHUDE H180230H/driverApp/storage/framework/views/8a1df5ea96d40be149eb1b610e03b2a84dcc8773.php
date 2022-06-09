<!DOCTYPE html>
<html lang="en">
<head>
    <meta charset="UTF-8">
    <meta name="viewport" content="width=device-width, initial-scale=1.0">
    <meta http-equiv="X-UA-Compatible" content="ie=edge">
    <title>Login</title>

    <!-- CSS only

    <link rel="stylesheet" type="text/css" href="css/style.css">
-->
<style>
    body
    {
        margin: 0;
        padding: 0;
        background: linear-gradient(120deg,#2980b9, #8e44ad);
        font-family: 'Arial';
        height: 100vh;
        overflow: hidden;

    }
    .container{
            position: absolute;
            top: 50%;
            left: 50%;
            transform: translate(-50%, -50%);
            width: 400px;
            background: white;
            border-radius: 10px;


    }
    .container .row h2{
        text-align: center;
        padding: 0 0 20px 0;
        border-bottom: 1px solid silver;

    }
    .container .row form{
        padding: 0 40px;
        box-sizing: border-box;
    }
    form .form-group {
        position: relative;
        border-bottom: 2px solid #adadad;
        margin: 30px;
    }
    .form-group input{
        width: 100%;
        padding: 0 5px;
        height: 40px;
        font-size: 16px;
        border: none;
        background: none;
        outline: none;


    }
    .form-group label{
        position: absolute;
        top: 30%;
        left: 0px;
        color: #adadad;
        font-size: 16px;
        pointer-events: none;
        transition: .5s;
    }
    .form-group span::before{
        content: '';
        position: absolute;
        top: 40px;
        left: 0;
        width: 0%;
        height: 2px;
        background: #2691d9;
        transition: .5s;
    }
    .form-group input:focus ~ label, .form-group input:valid ~ label {
        top: 5px;
        color: #2691d9;
    }
    .form-group input:focus ~ span::before,
    .form-group input:valid ~ span::before{
        width: 100%;
    }
    button[type="submit"]{
        width: 100%;
        height: 50px;
        border: 1px solid;
        background: #2691d9;
        border-radius: 25px;
        font-size: 18px;
        color: #e9f4fb;
        font-weight: 700;
        cursor: pointer;
        outline: none;
    }
    button[type="submit"]:hover{
        border-color: #2691d9;
        transition: .5s;

    }
</style>
</head>
<body>
    <div class="container" >
        <div class="row">
            <div class="col-md-4 col-md-offset-4" style="margin-top:20px ">
                <h2>Login</h2>
                <form action="<?php echo e(route('login-user')); ?>" method="POST">
                    <?php echo csrf_field(); ?>
                    <div class="form-group">
                        <span></span>
                        <label for="CardNumber"></label>
                        <input type="text" class="form-control"  name="card_number" placeholder="Card Number" required>
                    </div>
                    <div class="form-group">
                        <span></span>
                        <label for="NumberPlate"></label>
                        <input type="text" class="form-control"  placeholder="Number Plate" name="number_plate" required>

                    </div>

                        <button class="btn btn-block btn-primary" type="submit">Login</button>

                </form>
            </div>
        </div>
    </div>
</body>
<!-- JavaScript Bundle with Popper -->

</html>
<?php /**PATH C:\Users\dr shelaz\Documents\projects\capstone\driverApp\resources\views/auth/login.blade.php ENDPATH**/ ?>