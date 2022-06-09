<?php

use Illuminate\Database\Migrations\Migration;
use Illuminate\Database\Schema\Blueprint;
use Illuminate\Support\Facades\Schema;

class CreateRegistersTable extends Migration
{
    /**
     * Run the migrations.
     *
     * @return void
     */
    public function up()
    {
        Schema::create('_register', function (Blueprint $table) {
            $table->id();
            $table->string('VehicleOwner');
            $table->string('PhoneNumber');
            $table->string('NumberPlate');
            $table->string('CardNumber');
            $table->string('VehicleClass');
            $table->string('CardNumber');
            $table->string('AvailableBalance');
            $table->timestamp('Date');
        });
    }

    /**
     * Reverse the migrations.
     *
     * @return void
     */
    public function down()
    {
        Schema::dropIfExists('registers');
    }
}
