<!--
  This example requires Tailwind CSS v2.0+

  This example requires some changes to your config:

  ```
  // tailwind.config.js
  module.exports = {
    // ...
    plugins: [
      // ...
      require('@tailwindcss/forms'),
    ]
  }
  ```
-->
<template>
    <div class="relative flex flex-col min-h-screen">
        <!-- Navbar -->

        <!-- 3 column wrapper -->
        <div class="flex-grow w-full max-w-full mx-auto xl:px-0 lg:flex">
            <!-- Left sidebar & main wrapper -->
            <div
                class="
                    flex-1
                    min-w-0
                    bg-white
                    xl:flex
                    rounded-lg
                    overflow-hidden
                "
            >
                <!-- Account profile -->
                <div
                    class="
                        bg-white
                        xl:flex-shrink-0 xl:w-64 xl:border-r xl:border-gray-200
                    "
                >
                    <div class="py-6 pl-4 pr-6 sm:pl-6 lg:pl-8 xl:pl-4">
                        <div class="flex items-center justify-between">
                            <div class="flex-1 space-y-8">
                                <div>
                                    <fieldset class="mt-6 bg-white">
                                        <legend
                                            class="
                                                block
                                                text-sm
                                                font-medium
                                                text-gray-700
                                            "
                                        >
                                            Search Person
                                        </legend>
                                        <div
                                            class="
                                                mt-1
                                                -space-y-px
                                                rounded-md
                                                shadow-sm
                                            "
                                        >
                                            <div>
                                                <label
                                                    for="searchname"
                                                    class="sr-only"
                                                    >Persons Name</label
                                                >
                                                <input
                                                    v-model="name"
                                                    type="text"
                                                    name="searchname"
                                                    @keyup.enter="
                                                        searchPerson()
                                                    "
                                                    id="searchname"
                                                    class="
                                                        relative
                                                        block
                                                        w-full
                                                        bg-transparent
                                                        border-gray-300
                                                        rounded-none
                                                        focus:ring-indigo-500
                                                        focus:border-indigo-500
                                                        rounded-md
                                                        focus:z-10
                                                        sm:text-sm
                                                    "
                                                    placeholder="Search by name"
                                                />
                                            </div>
                                        </div>
                                    </fieldset>
                                </div>
                                <div
                                    class="
                                        space-y-8
                                        sm:space-y-0
                                        sm:flex
                                        sm:justify-between
                                        sm:items-center
                                        xl:block xl:space-y-8
                                    "
                                >
                                    <!-- Action buttons -->
                                    <div
                                        class="
                                            flex flex-col
                                            sm:flex-row
                                            xl:flex-col
                                        "
                                    >
                                        <button
                                            @click="searchPerson()"
                                            type="button"
                                            class="
                                                inline-flex
                                                items-center
                                                justify-center
                                                px-4
                                                py-2
                                                text-sm
                                                font-medium
                                                text-white
                                                bg-indigo-600
                                                border border-transparent
                                                rounded-md
                                                shadow-sm
                                                hover:bg-indigo-700
                                                focus:outline-none
                                                focus:ring-2
                                                focus:ring-offset-2
                                                focus:ring-indigo-500
                                                xl:w-full
                                            "
                                        >
                                            search Person
                                        </button>
                                    </div>
                                </div>
                            </div>
                        </div>
                    </div>
                </div>

                <!-- persons List -->
                <div class="bg-white lg:min-w-0 lg:flex-1">
                    <div
                        class="
                            pt-4
                            pb-4
                            pl-4
                            pr-6
                            border-t border-b border-gray-200
                            sm:pl-6
                            lg:pl-8
                            xl:pl-6 xl:pt-6 xl:border-t-0
                        "
                    >
                        <div class="flex items-center">
                            <h1 class="flex-1 text-lg font-medium">
                                search results
                                <span
                                    class="
                                        px-2
                                        py-1
                                        text-sm text-indigo-500
                                        bg-gray-200
                                        rounded-full
                                    "
                                    >{{ persons.length }} results</span
                                >
                            </h1>
                            <div
                                v-if="loading"
                                class="flex items-center justify-center"
                            >
                                <i
                                    class="pi pi-spin pi-spinner"
                                    style="fontsize: 2rem"
                                ></i>
                            </div>
                        </div>
                    </div>

                    <div class="card">
                        <DataTable
                            :value="persons"
                            :paginator="true"
                            showGridlines
                            :rows="10"
                            dataKey="_id"
                            :rowHover="true"
                            filterDisplay="menu"
                            v-model:filters="filters"
                            :globalFilterFields="[
                                'firstName',
                                'lastName',
                                'MobileNumber',
                                'passportNumber',
                                'pregnant',
                                'suburb',
                                'town',
                                'sex',
                                'deduced',
                                'nationality',
                            ]"
                            editMode="row"
                            v-model:editingRows="editingRows"
                            v-model:expandedRows="expandedRows"
                            @row-edit-save="onRowEditSave"
                            :loading="loading"
                            paginatorTemplate="FirstPageLink PrevPageLink PageLinks NextPageLink LastPageLink CurrentPageReport RowsPerPageDropdown"
                            :rowsPerPageOptions="[10, 25, 50]"
                            currentPageReportTemplate="Showing {first} to {last} of {totalRecords} entries"
                            responsiveLayout="scroll"
                        >
                            <template #header>
                                <div
                                    class="
                                        flex flex-col
                                        items-start
                                        justify-between
                                        space-y-2
                                    "
                                >
                                    <h5 class="p-m-0">Persons</h5>
                                    <span class="p-input-icon-left">
                                        <i class="pi pi-search" />
                                        <InputText
                                            v-model="filters['global'].value"
                                            placeholder="Keyword Search"
                                        />
                                    </span>
                                </div>
                            </template>
                            <template #empty> No persons found. </template>
                            <template #loading>
                                Loading persons data. Please wait.
                            </template>

                            <Column
                                field="firstname"
                                header="FirstName"
                                sortable
                                style="min-width: 14rem"
                            >
                                <template #body="{ data }">
                                    {{ data.firstName }}
                                </template>
                                <template #editor="{ data }">
                                    <InputText
                                        v-model="data['firstName']"
                                        autofocus
                                    />
                                </template>
                            </Column>
                            <Column
                                field="lastname"
                                header="LastName"
                                sortable
                                style="min-width: 14rem"
                            >
                                <template #body="{ data }">
                                    {{ data.lastName }}
                                </template>
                                <template #editor="{ data }">
                                    <InputText
                                        v-model="data['lastName']"
                                        autofocus
                                    />
                                </template>
                            </Column>
                            <Column
                                field="gender"
                                header="Gender"
                                sortable
                                style="min-width: 14rem"
                            >
                                <template #body="{ data }">
                                    {{ data.gender }}
                                </template>
                                <template #editor="{ data }">
                                    <InputText
                                        v-model="data['gender']"
                                        autofocus
                                    />
                                </template>
                            </Column>

                            <Column
                                field="deduced"
                                header="Deduced"
                                sortable
                                style="min-width: 14rem"
                            >
                                <template #body="{ data }">
                                    {{ data.deduced }}
                                </template>
                            </Column>
                            <Column :exportable="false" style="min-width: 8rem">
                                <template #body="slotProps">
                                    <Button
                                        icon="pi pi-pencil"
                                        class="
                                            p-button-rounded
                                            p-button-success
                                            p-mr-2
                                        "
                                        @click="editPerson(slotProps.data)"
                                    />
                                </template>
                            </Column>
                        </DataTable>

                        <Dialog
                            v-model:visible="personDialog"
                            :style="{ width: '800px' }"
                            header="Person Details"
                            :modal="true"
                            class="p-fluid"
                        >
                            <div class="my-2 p-field">
                                <label for="name">FirstName</label>
                                <InputText
                                    id="name"
                                    v-model.trim="person.firstName"
                                    required="true"
                                    autofocus
                                    :class="{
                                        'p-invalid':
                                            submitted && !person.firstName,
                                    }"
                                />
                                <small
                                    class="p-error"
                                    v-if="submitted && !person.firstName"
                                    >FirstName is required.</small
                                >
                            </div>
                            <div class="my-2 p-field">
                                <label for="name">LastName</label>
                                <InputText
                                    id="name"
                                    v-model.trim="person.lastName"
                                    required="true"
                                    autofocus
                                    :class="{
                                        'p-invalid':
                                            submitted && !person.lastName,
                                    }"
                                />
                                <small
                                    class="p-error"
                                    v-if="submitted && !person.lastName"
                                    >LastName is required.</small
                                >
                            </div>
                            <div class="my-2 p-field">
                                <label for="gender">Gender</label>
                                <InputText
                                    id="gender"
                                    v-model.trim="person.gender"
                                    required="true"
                                    autofocus
                                    :class="{
                                        'p-invalid':
                                            submitted && !person.gender,
                                    }"
                                />
                                <small
                                    class="p-error"
                                    v-if="submitted && !person.gender"
                                    >Gender is required.</small
                                >
                            </div>
                            <div class="my-2 p-field">
                                <label for="age">age</label>
                                <InputText
                                    id="age"
                                    v-model.trim="person.age"
                                    required="true"
                                    autofocus
                                    :class="{
                                        'p-invalid': submitted && !person.age,
                                    }"
                                />
                                <small
                                    class="p-error"
                                    v-if="submitted && !person.age"
                                    >Age is required.</small
                                >
                            </div>
                            <div class="my-2 p-field">
                                <label for="mobileNumber">mobileNumber</label>
                                <InputText
                                    id="mobileNumber"
                                    v-model.trim="person.mobileNumber"
                                    required="true"
                                    autofocus
                                    :class="{
                                        'p-invalid':
                                            submitted && !person.mobileNumber,
                                    }"
                                />
                                <small
                                    class="p-error"
                                    v-if="submitted && !person.mobileNumber"
                                    >Mobile Number is required.</small
                                >
                            </div>
                            <div class="my-2 p-field">
                                <label for="state">State</label>
                                <InputText
                                    id="state"
                                    v-model.trim="person.state"
                                    required="true"
                                    autofocus
                                    :class="{
                                        'p-invalid': submitted && !person.state,
                                    }"
                                />
                                <small
                                    class="p-error"
                                    v-if="submitted && !person.state"
                                    >State is required.</small
                                >
                            </div>
                            <div class="my-2 p-field">
                                <label for="city">City</label>
                                <InputText
                                    id="city"
                                    v-model.trim="person.city"
                                    required="true"
                                    autofocus
                                    :class="{
                                        'p-invalid': submitted && !person.city,
                                    }"
                                />
                                <small
                                    class="p-error"
                                    v-if="submitted && !person.city"
                                    >City is required.</small
                                >
                            </div>
                            <div class="my-2 p-field">
                                <label for="comments">Comments</label>
                                <InputText
                                    id="comments"
                                    v-model.trim="person.comments"
                                    required="true"
                                    autofocus
                                    :class="{
                                        'p-invalid':
                                            submitted && !person.comments,
                                    }"
                                />
                                <small
                                    class="p-error"
                                    v-if="submitted && !person.comments"
                                    >comments is required.</small
                                >
                            </div>

                            <template #footer>
                                <Button
                                    label="Cancel"
                                    icon="pi pi-times"
                                    class="p-button-text"
                                    @click="hideDialog"
                                />
                                <Button
                                    label="Save"
                                    icon="pi pi-check"
                                    class="p-button-text"
                                    @click="savePerson"
                                />
                            </template>
                        </Dialog>

                        <Dialog
                            v-model:visible="deleteitemDialog"
                            :style="{ width: '450px' }"
                            header="Confirm"
                            :modal="true"
                        >
                            <div
                                class="
                                    flex
                                    items-center
                                    space-x-4
                                    confirmation-content
                                "
                            >
                                <i
                                    class="pi pi-exclamation-triangle p-mr-3"
                                    style="font-size: 2rem"
                                />
                                <span v-if="item"
                                    >Are you sure you want to delete
                                    <b
                                        >{{ item.firstName
                                        }}{{ item.lastName }}</b
                                    >?</span
                                >
                            </div>
                            <template #footer>
                                <Button
                                    label="No"
                                    icon="pi pi-times"
                                    class="p-button-text"
                                    @click="deleteitemDialog = false"
                                />
                                <Button
                                    label="Yes"
                                    icon="pi pi-check"
                                    class="p-button-text"
                                    @click="deleteitem()"
                                />
                            </template>
                        </Dialog>
                    </div>
                </div>
            </div>
        </div>
    </div>
</template>

<script>
import { ref } from 'vue'
import {
    Disclosure,
    DisclosureButton,
    DisclosurePanel,
    Menu,
    MenuButton,
    MenuItem,
    MenuItems,
} from '@headlessui/vue'
import {
    BadgeCheckIcon,
    ChevronDownIcon,
    ChevronRightIcon,
    CollectionIcon,
    SearchIcon,
    CheckCircleIcon,
    XCircleIcon,
    SortAscendingIcon,
    StarIcon,
    ArrowNarrowLeftIcon,
    ArrowNarrowRightIcon,
} from '@heroicons/vue/solid'
import { MenuAlt1Icon, XIcon } from '@heroicons/vue/outline'
import PersonsDataService from '../../services/persons'
import { FilterMatchMode, FilterOperator } from 'primevue/api'
import Button from 'primevue/button'
import Toolbar from 'primevue/toolbar'
import Dialog from 'primevue/dialog'
export default {
    components: {
        Button,
        Dialog,
    },

    data() {
        return {
            open: false,
            submitted: false,
            persons: [],
            person: {},
            personDialog: false,
            item: {},
            editingRows: [],
            editingRowsVac: [],
            expandedRows: [],
            deleteitemDialog: false,
            tempPerson: [],
            currentIndex: 0,
            vaccinated: true,
            name: '',
            loading: false,
            filters: {
                global: { value: null, matchMode: FilterMatchMode.CONTAINS },
            },
        }
    },
    methods: {
        searchPerson() {
            this.loading = true
            this.persons = []
            PersonsDataService.getAll({
                name: this.name,
            })
                .then(async (response) => {
                    this.persons = response.data.items
                    console.log(response)
                    this.loading = false
                })
                .catch((e) => {
                    this.loading = false
                })
        },
        editPerson(person) {
            this.person = { ...person }
            this.personDialog = true
        },
        hideDialog() {
            this.personDialog = false
        },
        savePerson() {
            this.loading = true
            const data = JSON.parse(JSON.stringify(this.person))

            const id = data['_id']
            delete data['_id']
            PersonsDataService.update(id, data)
                .then(async (response) => {
                    this.searchPerson()
                    this.$toast.open({
                        message: 'Record Changed, Check to make sure',
                        type: 'success',
                        position: 'top',
                        duration: 3000,
                    })
                    this.personDialog = false
                })
                .catch((e) => {
                    this.loading = false
                    this.$toast.open({
                        message: 'Something went wrong!',
                        type: 'error',
                        position: 'top',
                        duration: 3000,
                    })
                    this.personDialog = false
                    console.log(e.message)
                })
            this.personDialog = false
        },
        onRowEditSave(event) {
            this.loading = true

            let { newData, index } = event
            console.log(newData)
            const data = JSON.parse(JSON.stringify(newData))

            const id = data['_id']
            delete data['_id']
            PersonsDataService.update(id, data)
                .then(async (response) => {
                    this.searchPerson()
                })
                .catch((e) => {
                    this.loading = false
                })

            //this.items2[index] = newData;
        },
        onRowEditSaveVac(event, originalObject) {
            let { newData, index } = event
            const data = JSON.parse(JSON.stringify(newData))
            const objectIndexInOriginal = index
            const neworiginalObject = JSON.parse(JSON.stringify(originalObject))
            neworiginalObject.vaccination[index] = data

            const id = neworiginalObject['_id']
            delete neworiginalObject['_id']

            PersonsDataService.update(id, neworiginalObject)
                .then(async (response) => {
                    this.searchPerson()
                })
                .catch((e) => {
                    this.loading = false
                })
        },
        confirmDeleteitem(item) {
            console.log(JSON.parse(JSON.stringify(item)))
            this.item = item
            this.deleteitemDialog = true
        },
        deleteitem() {
            this.deleteitemDialog = false
            console.log(JSON.parse(JSON.stringify(this.item)))

            this.$toast.add({
                severity: 'success',
                summary: 'Successful',
                detail: 'item Deleted',
                life: 3000,
            })
        },
    },
}
</script>
