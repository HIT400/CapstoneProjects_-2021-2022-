<template>
    <div class="space-y-6">
        <div class="px-4 py-5 bg-white shadow sm:rounded-lg sm:p-6">
            <div class="md:grid md:grid-cols-3 md:gap-6">
                <div class="md:col-span-1">
                    <h3 class="text-lg font-medium leading-6 text-gray-900">
                        Personal Information
                    </h3>
                    <p class="mt-1 text-sm text-gray-500">
                        Use a permanent address where you can receive mail.
                    </p>
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
                                    id="last-name"
                                    autocomplete="family-name"
                                    class="block w-full mt-1 border-gray-300 rounded-md shadow-sm  focus:ring-indigo-500 focus:border-indigo-500 sm:text-sm"
                                />
                            </div>

                            <div class="col-span-6 sm:col-span-4">
                                <label
                                    for="email-address"
                                    class="block text-sm font-medium text-gray-700 "
                                    >Email address</label
                                >
                                <input
                                    type="text"
                                    name="email-address"
                                    id="email-address"
                                    autocomplete="email"
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
                                    id="state"
                                    class="block w-full mt-1 border-gray-300 rounded-md shadow-sm  focus:ring-indigo-500 focus:border-indigo-500 sm:text-sm"
                                />
                            </div>

                            <div class="col-span-6 sm:col-span-3 lg:col-span-2">
                                <label
                                    for="postal-code"
                                    class="block text-sm font-medium text-gray-700 "
                                    >ZIP / Postal</label
                                >
                                <input
                                    type="text"
                                    name="postal-code"
                                    id="postal-code"
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
                        Vaccinations Information
                    </h3>
                </div>
                <div class="mt-5 md:mt-0 md:col-span-2">
                    <form action="#" method="POST">
                        <div class="grid grid-cols-6 gap-6">
                            <div class="col-span-6 sm:col-span-6 lg:col-span-2">
                                <label
                                    for="vaccine"
                                    class="block text-sm font-medium text-gray-700 "
                                    >Vaccine Name</label
                                >
                                <input
                                    type="text"
                                    name="vaccine"
                                    id="vaccine"
                                    class="block w-full mt-1 border-gray-300 rounded-md shadow-sm  focus:ring-indigo-500 focus:border-indigo-500 sm:text-sm"
                                />
                            </div>

                            <div class="col-span-6 sm:col-span-3 lg:col-span-2">
                                <label
                                    for="batch"
                                    class="block text-sm font-medium text-gray-700 "
                                    >Batch Number</label
                                >
                                <input
                                    type="text"
                                    name="batch"
                                    id="batch"
                                    class="block w-full mt-1 border-gray-300 rounded-md shadow-sm  focus:ring-indigo-500 focus:border-indigo-500 sm:text-sm"
                                />
                            </div>

                            <div class="col-span-6 sm:col-span-3 lg:col-span-2">
                                <label
                                    for="vaccinateddate"
                                    class="block text-sm font-medium text-gray-700 "
                                    >Vaccinated Date</label
                                >
                                <input
                                    type="text"
                                    name="vaccinateddate"
                                    id="vaccinateddate"
                                    autocomplete="vaccinateddate"
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
                                    id="city"
                                    class="block w-full mt-1 border-gray-300 rounded-md shadow-sm  focus:ring-indigo-500 focus:border-indigo-500 sm:text-sm"
                                />
                            </div>

                            <div class="col-span-6 sm:col-span-3 lg:col-span-2">
                                <label
                                    for="supplier"
                                    class="block text-sm font-medium text-gray-700 "
                                    >Supplier Name</label
                                >
                                <input
                                    type="text"
                                    name="supplier"
                                    id="supplier"
                                    class="block w-full mt-1 border-gray-300 rounded-md shadow-sm  focus:ring-indigo-500 focus:border-indigo-500 sm:text-sm"
                                />
                            </div>

                            <div class="col-span-6 sm:col-span-3 lg:col-span-2">
                                <label
                                    for="numberofdoses"
                                    class="block text-sm font-medium text-gray-700 "
                                    >Number Of Doses
                                </label>
                                <input
                                    type="number"
                                    name="numberofdoses"
                                    id="numberofdoses"
                                    autocomplete="numberofdoses"
                                    class="block w-full mt-1 border-gray-300 rounded-md shadow-sm  focus:ring-indigo-500 focus:border-indigo-500 sm:text-sm"
                                />
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
                class="inline-flex justify-center px-4 py-2 ml-3 text-sm font-medium text-white bg-indigo-600 border border-transparent rounded-md shadow-sm  hover:bg-indigo-700 focus:outline-none focus:ring-2 focus:ring-offset-2 focus:ring-indigo-500"
            >
                Save
            </button>
        </div>
    </div>
</template>

<script>
import MainLayout from '../../layouts/MainLayout.vue'
export default {
    components: {
        // eslint-disable-next-line vue/no-unused-components
        MainLayout,
    },
}
</script>

<style></style>
