<template>
    <div class="space-y-6">
        <div class="px-4 py-5 bg-white shadow sm:rounded-lg sm:p-6">
            <div class="col-span-6 sm:col-span-3 lg:col-span-2">
                <label
                    for="duration-period"
                    class="block text-sm font-medium text-gray-700"
                    >Select Facility</label
                >
                <select
                    id="duration-period"
                    name="duration-period"
                    v-model="Facility"
                    autocomplete="duration-period"
                    class="block w-full px-3 py-2 mt-1 mb-6 bg-white border border-gray-300 rounded-md shadow-sm  focus:outline-none focus:ring-indigo-500 focus:border-indigo-500 sm:text-sm"
                >
                    <option>Chipinge District Hospital</option>
                    <option>Chipinge Clinic</option>
                    <option>Mt Selinda Mission Hospital</option>
                </select>
            </div>
            <div class="md:grid md:grid-cols-3 md:gap-6">
                <div class="md:col-span-1">
                    <h3 class="text-lg font-medium leading-6 text-gray-900">
                        Patient Personal Information
                    </h3>
                </div>
                <div class="mt-5 md:mt-0 md:col-span-2">
                    <form action="#" method="POST">
                        <div class="grid grid-cols-6 gap-6">
                            <div class="col-span-6 sm:col-span-3">
                                <label
                                    for="first-name"
                                    class="block text-sm font-medium text-gray-700 "
                                    >First name</label
                                >
                                <input
                                    type="text"
                                    name="first-name"
                                    v-model="firstName"
                                    id="first-name"
                                    autocomplete="given-name"
                                    class="block w-full mt-1 border-gray-300 rounded-md shadow-sm  focus:ring-indigo-500 focus:border-indigo-500 sm:text-sm"
                                />
                            </div>

                            <div class="col-span-6 sm:col-span-3">
                                <label
                                    for="last-name"
                                    class="block text-sm font-medium text-gray-700 "
                                    >Last name</label
                                >
                                <input
                                    type="text"
                                    name="last-name"
                                    v-model="lastName"
                                    id="last-name"
                                    autocomplete="family-name"
                                    class="block w-full mt-1 border-gray-300 rounded-md shadow-sm  focus:ring-indigo-500 focus:border-indigo-500 sm:text-sm"
                                />
                            </div>

                            <div class="col-span-6 sm:col-span-3">
                                <label
                                    for="age"
                                    class="block text-sm font-medium text-gray-700 "
                                    >Age</label
                                >
                                <input
                                    type="number"
                                    name="age"
                                    id="age"
                                    v-model="age"
                                    autocomplete="age"
                                    class="block w-full mt-1 border-gray-300 rounded-md shadow-sm  focus:ring-indigo-500 focus:border-indigo-500 sm:text-sm"
                                />
                            </div>

                            <div class="col-span-6 sm:col-span-3">
                                <label
                                    for="period"
                                    class="block text-sm font-medium text-gray-700 "
                                    >Period</label
                                >
                                <select
                                    id="period"
                                    name="period"
                                    v-model="period"
                                    autocomplete="period"
                                    class="block w-full px-3 py-2 mt-1 bg-white border border-gray-300 rounded-md shadow-sm  focus:outline-none focus:ring-indigo-500 focus:border-indigo-500 sm:text-sm"
                                >
                                    <option>Years</option>
                                    <option>Months</option>
                                    <option>Weeks</option>
                                    <option>Days</option>
                                </select>
                            </div>
                            <div class="col-span-6 sm:col-span-3">
                                <label
                                    for="gender"
                                    class="block text-sm font-medium text-gray-700 "
                                    >Gender</label
                                >
                                <select
                                    id="gender"
                                    name="gender"
                                    v-model="gender"
                                    autocomplete="gender"
                                    class="block w-full px-3 py-2 mt-1 bg-white border border-gray-300 rounded-md shadow-sm  focus:outline-none focus:ring-indigo-500 focus:border-indigo-500 sm:text-sm"
                                >
                                    <option>Male</option>
                                    <option>Female</option>
                                    <option>Unknown</option>
                                </select>
                            </div>
                            <div class="col-span-6 sm:col-span-3">
                                <label
                                    for="email-address"
                                    class="block text-sm font-medium text-gray-700 "
                                    >Email address</label
                                >
                                <input
                                    type="text"
                                    name="email-address"
                                    v-model="emailAddress"
                                    id="email-address"
                                    autocomplete="email"
                                    class="block w-full mt-1 border-gray-300 rounded-md shadow-sm  focus:ring-indigo-500 focus:border-indigo-500 sm:text-sm"
                                />
                            </div>
                            <div class="col-span-6">
                                <label
                                    for="Mobile-number"
                                    class="block text-sm font-medium text-gray-700 "
                                    >Mobile Number</label
                                >
                                <input
                                    type="text"
                                    name="Mobile-number"
                                    id="Mobile-number"
                                    v-model="mobileNumber"
                                    autocomplete="Mobile-number"
                                    class="block w-full mt-1 border-gray-300 rounded-md shadow-sm  focus:ring-indigo-500 focus:border-indigo-500 sm:text-sm"
                                />
                            </div>

                            <div class="col-span-6">
                                <label
                                    for="street-address"
                                    class="block text-sm font-medium text-gray-700 "
                                    >Street address</label
                                >
                                <input
                                    type="text"
                                    name="street-address"
                                    id="street-address"
                                    v-model="streetAddress"
                                    autocomplete="street-address"
                                    class="block w-full mt-1 border-gray-300 rounded-md shadow-sm  focus:ring-indigo-500 focus:border-indigo-500 sm:text-sm"
                                />
                            </div>

                            <div class="col-span-6 sm:col-span-6 lg:col-span-2">
                                <label
                                    for="city"
                                    class="block text-sm font-medium text-gray-700 "
                                    >City</label
                                >
                                <input
                                    type="text"
                                    name="city"
                                    v-model="city"
                                    id="city"
                                    class="block w-full mt-1 border-gray-300 rounded-md shadow-sm  focus:ring-indigo-500 focus:border-indigo-500 sm:text-sm"
                                />
                            </div>

                            <div class="col-span-6 sm:col-span-3 lg:col-span-2">
                                <label
                                    for="state"
                                    class="block text-sm font-medium text-gray-700 "
                                    >State / Province</label
                                >
                                <input
                                    type="text"
                                    name="state"
                                    v-model="state"
                                    id="state"
                                    class="block w-full mt-1 border-gray-300 rounded-md shadow-sm  focus:ring-indigo-500 focus:border-indigo-500 sm:text-sm"
                                />
                            </div>

                            <div class="col-span-6 sm:col-span-3 lg:col-span-2">
                                <label
                                    for="postal-code"
                                    class="block text-sm font-medium text-gray-700 "
                                    >Postal</label
                                >
                                <input
                                    type="text"
                                    name="postal-code"
                                    id="postal-code"
                                    v-model="postalCode"
                                    autocomplete="postal-code"
                                    class="block w-full mt-1 border-gray-300 rounded-md shadow-sm  focus:ring-indigo-500 focus:border-indigo-500 sm:text-sm"
                                />
                            </div>
                        </div>
                    </form>
                </div>
            </div>
        </div>

        <div class="px-4 py-5 bg-white shadow sm:rounded-lg sm:p-6">
            <div class="md:grid md:grid-cols-3 md:gap-6">
                <div class="md:col-span-1">
                    <h3 class="text-lg font-medium leading-6 text-gray-900">
                        Patient
                    </h3>
                </div>
                <div class="mt-5 md:mt-0 md:col-span-2">
                    <form class="space-y-6" action="#" method="POST">
                        <fieldset>
                            <legend class="text-base font-medium text-gray-900">
                                Is Patient Pregnant?
                            </legend>
                            <div class="mt-4 space-y-4">
                                <div class="flex items-start">
                                    <div class="flex items-center h-5">
                                        <input
                                            id="pregnant"
                                            name="pregnant"
                                            v-model="pregnant"
                                            type="checkbox"
                                            class="w-4 h-4 text-indigo-600 border-gray-300 rounded-full  focus:ring-indigo-500"
                                        />
                                    </div>
                                </div>
                            </div>
                        </fieldset>
                        <fieldset>
                            <div>
                                <legend
                                    class="text-base font-medium text-gray-900"
                                >
                                    Patient admitted to hospital
                                </legend>
                            </div>
                            <div class="mt-4 space-y-4">
                                <div class="flex items-center">
                                    <input
                                        id="admitted"
                                        name="admitted"
                                        v-model="admitted"
                                        type="checkbox"
                                        class="w-4 h-4 text-indigo-600 border-gray-300 rounded-full  focus:ring-indigo-500"
                                    />
                                    <label
                                        for="admitted"
                                        class="block ml-3 text-sm font-medium text-gray-700 "
                                    >
                                    </label>
                                </div>
                            </div>
                        </fieldset>
                    </form>
                </div>
            </div>
        </div>
        <div class="px-4 py-5 bg-white shadow sm:rounded-lg sm:p-6">
            <div class="md:grid md:grid-cols-3 md:gap-6">
                <div class="md:col-span-1">
                    <h3 class="text-lg font-medium leading-6 text-gray-900">
                        Travel Information
                    </h3>
                </div>
                <div class="mt-5 md:mt-0 md:col-span-2">
                    <form class="space-y-6" action="#" method="POST">
                        <fieldset>
                            <legend class="text-base font-medium text-gray-900">
                                Has the patient traveled or lived outside the
                                Zimbabwe during the past month
                            </legend>
                            <div class="mt-4 space-y-4">
                                <div class="flex items-start">
                                    <div class="flex items-center h-5">
                                        <input
                                            id="travelled"
                                            name="travelled"
                                            v-model="travelled"
                                            type="checkbox"
                                            class="w-4 h-4 text-indigo-600 border-gray-300 rounded-full  focus:ring-indigo-500"
                                        />
                                    </div>
                                </div>
                            </div>
                        </fieldset>
                        <fieldset class="grid grid-cols-6 gap-6">
                            <div class="col-span-6 sm:col-span-6 lg:col-span-2">
                                <label
                                    for="visited-country"
                                    class="block text-sm font-medium text-gray-700 "
                                    >Country/Province/State</label
                                >
                                <input
                                    type="text"
                                    name="visited-country"
                                    v-model="visitedCountry"
                                    id="visited-country"
                                    class="block w-full mt-1 border-gray-300 rounded-md shadow-sm  focus:ring-indigo-500 focus:border-indigo-500 sm:text-sm"
                                />
                            </div>

                            <div class="col-span-6 sm:col-span-3 lg:col-span-2">
                                <label
                                    for="return-date"
                                    class="block text-sm font-medium text-gray-700 "
                                    >Return Date</label
                                >
                                <input
                                    type="date"
                                    name="return-date"
                                    v-model="returnDate"
                                    id="return-date"
                                    class="block w-full mt-1 border-gray-300 rounded-md shadow-sm  focus:ring-indigo-500 focus:border-indigo-500 sm:text-sm"
                                />
                            </div>

                            <div class="col-span-6 sm:col-span-3 lg:col-span-2">
                                <label
                                    for="duration"
                                    class="block text-sm font-medium text-gray-700 "
                                    >Duration of Stay</label
                                >
                                <input
                                    type="number"
                                    name="duration"
                                    v-model="duration"
                                    id="duration"
                                    autocomplete="duration"
                                    class="block w-full mt-1 border-gray-300 rounded-md shadow-sm  focus:ring-indigo-500 focus:border-indigo-500 sm:text-sm"
                                />
                                <label
                                    for="duration-period"
                                    class="block text-sm font-medium text-gray-700 "
                                    >Period</label
                                >
                                <select
                                    id="duration-period"
                                    name="duration-period"
                                    v-model="durationUnit"
                                    autocomplete="duration-period"
                                    class="block w-full px-3 py-2 mt-1 bg-white border border-gray-300 rounded-md shadow-sm  focus:outline-none focus:ring-indigo-500 focus:border-indigo-500 sm:text-sm"
                                >
                                    <option>Weeks</option>
                                    <option>Days</option>
                                    <option>Hours</option>
                                </select>
                            </div>
                        </fieldset>
                        <fieldset>
                            <div>
                                <legend
                                    class="text-base font-medium text-gray-900"
                                >
                                    Visitor
                                </legend>
                                <p class="text-sm text-gray-500">
                                    Is the person a visitor to this
                                    country/state/province
                                </p>
                            </div>
                            <div class="mt-4 space-y-4">
                                <div class="flex items-center">
                                    <input
                                        id="visitor"
                                        name="Visitor"
                                        v-model="visitor"
                                        type="checkbox"
                                        class="w-4 h-4 text-indigo-600 border-gray-300 rounded-full  focus:ring-indigo-500"
                                    />
                                    <label
                                        for="Visitor"
                                        class="block ml-3 text-sm font-medium text-gray-700 "
                                    >
                                        Visitor ?
                                    </label>
                                </div>
                            </div>
                            <fieldset class="grid grid-cols-6 gap-6 mt-8">
                                <div class="col-span-6 sm:col-span-3">
                                    <label
                                        for="reasonfortravel"
                                        class="block text-sm font-medium text-gray-700 "
                                        >Principal reason for travel</label
                                    >
                                    <select
                                        id="reasonfortravel"
                                        name="reasonfortravel"
                                        v-model="reasonForTravel"
                                        autocomplete="reasonfortravel"
                                        class="block w-full px-3 py-2 mt-1 bg-white border border-gray-300 rounded-md shadow-sm  focus:outline-none focus:ring-indigo-500 focus:border-indigo-500 sm:text-sm"
                                    >
                                        <option>Tourism</option>
                                        <option>
                                            Visiting friends/relatives
                                        </option>
                                        <option>Student/teacher</option>
                                        <option>Business</option>
                                    </select>
                                </div>
                            </fieldset>
                        </fieldset>
                    </form>
                </div>
            </div>
        </div>
        <div class="px-4 py-5 bg-white shadow sm:rounded-lg sm:p-6">
            <div class="md:grid md:grid-cols-3 md:gap-6">
                <div class="md:col-span-1">
                    <h3 class="text-lg font-medium leading-6 text-gray-900">
                        Medication
                    </h3>
                </div>
                <div class="mt-5 md:mt-0 md:col-span-2">
                    <form class="space-y-6" action="#" method="POST">
                        <fieldset>
                            <legend class="text-base font-medium text-gray-900">
                                Was malaria chemoprophylaxis taken?
                            </legend>
                            <div class="mt-4 space-y-4">
                                <div class="flex items-start">
                                    <div class="flex items-center h-5">
                                        <input
                                            id="chemoprophylaxis"
                                            name="chemoprophylaxis"
                                            v-model="chemoprophylaxis"
                                            type="checkbox"
                                            class="w-4 h-4 text-indigo-600 border-gray-300 rounded-full  focus:ring-indigo-500"
                                        />
                                    </div>
                                </div>
                            </div>
                        </fieldset>
                        <fieldset class="grid grid-cols-6 gap-6 mt-8">
                            <div class="col-span-6 sm:col-span-3">
                                <label
                                    for="drugsChemoprophylaxis"
                                    class="block text-sm font-medium text-gray-700 "
                                    >If yes, which drugs were taken?</label
                                >
                                <select
                                    id="drugsChemoprophylaxis"
                                    name="drugsChemoprophylaxis"
                                    v-model="drugsChemoprophylaxis"
                                    autocomplete="drugsChemoprophylaxis"
                                    class="block w-full px-3 py-2 mt-1 bg-white border border-gray-300 rounded-md shadow-sm  focus:outline-none focus:ring-indigo-500 focus:border-indigo-500 sm:text-sm"
                                >
                                    <option>Chloroquine</option>
                                    <option>Mefloquine</option>
                                    <option>Doxycycline</option>
                                    <option>Primaquine</option>
                                    <option>Atovaquone/proguanil</option>
                                    <option>Unknown</option>
                                    <option>Other</option>
                                </select>
                            </div>
                        </fieldset>
                    </form>
                </div>
            </div>
        </div>
        <div class="px-4 py-5 bg-white shadow sm:rounded-lg sm:p-6">
            <div class="md:grid md:grid-cols-3 md:gap-6">
                <div class="md:col-span-1">
                    <h3 class="text-lg font-medium leading-6 text-gray-900">
                        Medical History Information
                    </h3>
                </div>
                <div class="mt-5 md:mt-0 md:col-span-2">
                    <form class="space-y-6" action="#" method="POST">
                        <fieldset>
                            <legend class="text-base font-medium text-gray-900">
                                History of malaria in last 12 months
                            </legend>
                            <div class="mt-4 space-y-4">
                                <div class="flex items-start">
                                    <div class="flex items-center h-5">
                                        <input
                                            id="hadMalaria"
                                            name="hadMalaria"
                                            v-model="hadMalaria"
                                            type="checkbox"
                                            class="w-4 h-4 text-indigo-600 border-gray-300 rounded-full  focus:ring-indigo-500"
                                        />
                                    </div>
                                </div>
                            </div>
                        </fieldset>
                        <fieldset class="grid grid-cols-6 gap-6">
                            <div class="col-span-6 sm:col-span-6 lg:col-span-2">
                                <label
                                    for="illnessDate"
                                    class="block text-sm font-medium text-gray-700 "
                                    >Country/Province/State</label
                                >
                                <input
                                    type="date"
                                    name="illnessDate"
                                    v-model="illnessDate"
                                    id="illnessDate"
                                    class="block w-full mt-1 border-gray-300 rounded-md shadow-sm  focus:ring-indigo-500 focus:border-indigo-500 sm:text-sm"
                                />
                            </div>
                            <div class="col-span-6 sm:col-span-6 lg:col-span-2">
                                <label
                                    for="speciesDisease"
                                    class="block text-sm font-medium text-gray-700 "
                                    >If yes, species?</label
                                >
                                <select
                                    id="speciesDisease"
                                    name="speciesDisease"
                                    v-model="speciesDisease"
                                    autocomplete="speciesDisease"
                                    class="block w-full px-3 py-2 mt-1 bg-white border border-gray-300 rounded-md shadow-sm  focus:outline-none focus:ring-indigo-500 focus:border-indigo-500 sm:text-sm"
                                >
                                    <option>Vivax</option>
                                    <option>Falciparum</option>
                                    <option>Malariae</option>
                                    <option>Ovale</option>
                                    <option>Not Determined</option>
                                    <option>Other</option>
                                </select>
                            </div>
                        </fieldset>
                    </form>
                </div>
            </div>
        </div>
        <div class="px-4 py-5 bg-white shadow sm:rounded-lg sm:p-6">
            <div class="md:grid md:grid-cols-3 md:gap-6">
                <div class="md:col-span-1">
                    <h3 class="text-lg font-medium leading-6 text-gray-900">
                        Symptoms Information
                    </h3>
                </div>
                <div class="mt-5 md:mt-0 md:col-span-2">
                    <form class="space-y-6" action="#" method="POST">
                        <fieldset>
                            <legend class="text-base font-medium text-gray-900">
                                Symptoms
                            </legend>
                            <div class="mt-4 space-y-4">
                                <div class="flex items-start">
                                    <div class="flex items-center h-5">
                                        <input
                                            id="fever"
                                            name="fever"
                                            v-model="fever"
                                            type="checkbox"
                                            class="w-4 h-4 text-indigo-600 border-gray-300 rounded-full  focus:ring-indigo-500"
                                        />
                                    </div>
                                    <div class="ml-3 text-sm">
                                        <label
                                            for="comments"
                                            class="font-medium text-gray-700"
                                            >fever</label
                                        >
                                    </div>
                                </div>
                                <div class="flex items-start">
                                    <div class="flex items-center h-5">
                                        <input
                                            id="flu"
                                            name="flu"
                                            v-model="flu"
                                            type="checkbox"
                                            class="w-4 h-4 text-indigo-600 border-gray-300 rounded-full  focus:ring-indigo-500"
                                        />
                                    </div>
                                    <div class="ml-3 text-sm">
                                        <label
                                            for="comments"
                                            class="font-medium text-gray-700"
                                            >flu-like illness</label
                                        >
                                    </div>
                                </div>
                                <div class="flex items-start">
                                    <div class="flex items-center h-5">
                                        <input
                                            id="shaking-chills"
                                            name="shaking-chills"
                                            v-model="shakingChills"
                                            type="checkbox"
                                            class="w-4 h-4 text-indigo-600 border-gray-300 rounded-full  focus:ring-indigo-500"
                                        />
                                    </div>
                                    <div class="ml-3 text-sm">
                                        <label
                                            for="comments"
                                            class="font-medium text-gray-700"
                                            >shaking chills</label
                                        >
                                    </div>
                                </div>
                                <div class="flex items-start">
                                    <div class="flex items-center h-5">
                                        <input
                                            id="headache"
                                            name="headache"
                                            v-model="headache"
                                            type="checkbox"
                                            class="w-4 h-4 text-indigo-600 border-gray-300 rounded-full  focus:ring-indigo-500"
                                        />
                                    </div>
                                    <div class="ml-3 text-sm">
                                        <label
                                            for="comments"
                                            class="font-medium text-gray-700"
                                            >headache</label
                                        >
                                    </div>
                                </div>
                                <div class="flex items-start">
                                    <div class="flex items-center h-5">
                                        <input
                                            id="muscle-pain"
                                            name="muscle-pain"
                                            v-model="musclePain"
                                            type="checkbox"
                                            class="w-4 h-4 text-indigo-600 border-gray-300 rounded-full  focus:ring-indigo-500"
                                        />
                                    </div>
                                    <div class="ml-3 text-sm">
                                        <label
                                            for="comments"
                                            class="font-medium text-gray-700"
                                            >muscle aches</label
                                        >
                                    </div>
                                </div>
                                <div class="flex items-start">
                                    <div class="flex items-center h-5">
                                        <input
                                            id="Nausea"
                                            name="Nausea"
                                            v-model="Nausea"
                                            type="checkbox"
                                            class="w-4 h-4 text-indigo-600 border-gray-300 rounded-full  focus:ring-indigo-500"
                                        />
                                    </div>
                                    <div class="ml-3 text-sm">
                                        <label
                                            for="comments"
                                            class="font-medium text-gray-700"
                                            >Nausea</label
                                        >
                                    </div>
                                </div>
                                <div class="flex items-start">
                                    <div class="flex items-center h-5">
                                        <input
                                            id="vomiting"
                                            name="vomiting"
                                            v-model="vomiting"
                                            type="checkbox"
                                            class="w-4 h-4 text-indigo-600 border-gray-300 rounded-full  focus:ring-indigo-500"
                                        />
                                    </div>
                                    <div class="ml-3 text-sm">
                                        <label
                                            for="comments"
                                            class="font-medium text-gray-700"
                                            >vomiting</label
                                        >
                                    </div>
                                </div>
                                <div class="flex items-start">
                                    <div class="flex items-center h-5">
                                        <input
                                            id="diarrhea"
                                            name="diarrhea"
                                            v-model="diarrhea"
                                            type="checkbox"
                                            class="w-4 h-4 text-indigo-600 border-gray-300 rounded-full  focus:ring-indigo-500"
                                        />
                                    </div>
                                    <div class="ml-3 text-sm">
                                        <label
                                            for="comments"
                                            class="font-medium text-gray-700"
                                            >diarrhea</label
                                        >
                                    </div>
                                </div>
                                <div class="flex items-start">
                                    <div class="flex items-center h-5">
                                        <input
                                            id="tiredness"
                                            name="tiredness"
                                            v-model="tiredness"
                                            type="checkbox"
                                            class="w-4 h-4 text-indigo-600 border-gray-300 rounded-full  focus:ring-indigo-500"
                                        />
                                    </div>
                                    <div class="ml-3 text-sm">
                                        <label
                                            for="comments"
                                            class="font-medium text-gray-700"
                                            >tiredness</label
                                        >
                                    </div>
                                </div>
                            </div>
                        </fieldset>
                        <div>
                            <label
                                for="comments"
                                class="block text-sm font-medium text-gray-700"
                            >
                                Comments
                            </label>
                            <div class="mt-1">
                                <textarea
                                    id="comments"
                                    name="comments"
                                    v-model="comments"
                                    rows="3"
                                    class="block w-full border border-gray-300 rounded-md shadow-sm  focus:ring-indigo-500 focus:border-indigo-500 sm:text-sm"
                                    placeholder="you@example.com"
                                />
                            </div>
                            <p class="mt-2 text-sm text-gray-500">
                                Brief description for of patient symptoms and
                                state.
                            </p>
                        </div>
                        <div>
                            <div class="mt-1">
                                <div class="flex items-start">
                                    <div
                                        class="col-span-6  sm:col-span-6 lg:col-span-2"
                                    >
                                        <label
                                            for="deduced"
                                            class="block text-sm font-medium text-gray-700 "
                                            >Deduced Patient State?</label
                                        >
                                        <select
                                            id="deduced"
                                            name="deduced"
                                            v-model="deduced"
                                            autocomplete="deduced"
                                            class="block w-full px-3 py-2 mt-1 bg-white border border-gray-300 rounded-md shadow-sm  focus:outline-none focus:ring-indigo-500 focus:border-indigo-500 sm:text-sm"
                                        >
                                            <option>Critical</option>
                                            <option>Mild</option>
                                        </select>
                                    </div>
                                </div>
                            </div>
                        </div>
                    </form>
                </div>
            </div>
        </div>

        <div class="flex justify-end">
            <button
                type="button"
                class="px-4 py-2 text-sm font-medium text-gray-700 bg-white border border-gray-300 rounded-md shadow-sm  hover:bg-gray-50 focus:outline-none focus:ring-2 focus:ring-offset-2 focus:ring-indigo-500"
            >
                Cancel
            </button>
            <button
                type="submit"
                @click.prevent="submit()"
                class="inline-flex justify-center px-4 py-2 ml-3 text-sm font-medium text-white bg-indigo-600 border border-transparent rounded-md shadow-sm  hover:bg-indigo-700 focus:outline-none focus:ring-2 focus:ring-offset-2 focus:ring-indigo-500"
            >
                <span>Save</span>
                <div v-if="loading" class="flex items-center justify-center">
                    <i
                        class="pi pi-spin pi-spinner"
                        style="fontsize: 0.5rem"
                    ></i>
                </div>
            </button>
        </div>
    </div>
</template>

<script>
import PersonsDataService from '../../services/persons'
export default {
    data() {
        return {
            firstName: '',
            lastName: '',
            age: '',
            period: '',
            gender: '',
            emailAddress: '',
            mobileNumber: '',
            streetAddress: '',
            city: '',
            state: '',
            postalCode: '',
            pregnant: '',
            admitted: '',
            travelled: '',
            visitedCountry: '',
            returnDate: '',
            duration: '',
            durationUnit: '',
            visitor: '',
            reasonForTravel: '',
            chemoprophylaxis: '',
            drugsChemoprophylaxis: '',
            hadMalaria: '',
            illnessDate: '',
            speciesDisease: '',

            fever: '',
            flu: '',
            shakingChills: '',
            Nausea: '',
            vomiting: '',
            headache: '',
            musclePain: '',
            diarrhea: '',
            tiredness: '',
            comments: '',
            deduced: '',
            Facility: '',

            //
            loading: false,
        }
    },
    methods: {
        submit() {
            this.loading = true
            const data = {
                firstName: this.firstName,
                lastName: this.lastName,
                age: this.age,
                period: this.period,
                gender: this.gender,
                emailAddress: this.mobileNumber,
                mobileNumber: this.mobileNumber,
                streetAddress: this.streetAddress,
                city: this.city,
                state: this.state,
                postalCode: this.postalCode,
                pregnant: this.pregnant,
                admitted: this.admitted,
                travelled: this.travelled,
                visitedCountry: this.visitedCountry,
                returnDate: this.returnDate,
                duration: this.duration,
                durationUnit: this.durationUnit,
                visitor: this.visitor,
                reasonForTravel: this.reasonForTravel,
                chemoprophylaxis: this.chemoprophylaxis,
                drugsChemoprophylaxis: this.drugsChemoprophylaxis,
                hadMalaria: this.hadMalaria,
                illnessDate: this.illnessDate,
                speciesDisease: this.speciesDisease,

                fever: this.fever,
                flu: this.flu,
                shakingChills: this.shakingChills,
                Nausea: this.Nausea,
                vomiting: this.vomiting,
                headache: this.headache,
                musclePain: this.musclePain,
                diarrhea: this.diarrhea,
                tiredness: this.tiredness,
                comments: this.comments,
                deduced: this.deduced,
                Facility: this.Facility,
            }

            console.log(data)
            PersonsDataService.create(data)
                .then((res) => {
                    this.loading = false
                    this.$toast.open({
                        message: 'Record successfully saved',
                        type: 'success',
                        position: 'top',
                        duration: 3000,
                    })
                    this.$router.push('/home')
                    console.log(res)
                })
                .catch((error) => {
                    this.loading = false
                    this.$toast.open({
                        message: 'Something Went Wrong',
                        type: 'error',
                        position: 'top',
                        duration: 3000,
                    })
                    console.log(error)
                })
        },
    },
}
</script>

<style></style>
