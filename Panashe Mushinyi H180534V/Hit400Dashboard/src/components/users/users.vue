<template>
    <div class="relative flex flex-col min-h-screen">
        <!-- Navbar -->

        <!-- 3 column wrapper -->
        <div class="flex-grow w-full max-w-full mx-auto xl:px-0 lg:flex">
            <!-- Left sidebar & main wrapper -->
            <div class="flex-1 min-w-0 bg-white xl:flex">
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
                                                mb-4
                                                text-sm
                                                font-medium
                                                text-gray-700
                                            "
                                        >
                                            Add new user
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
                                                    for="username"
                                                    class="sr-only"
                                                    >username</label
                                                >
                                                <input
                                                    v-model="username"
                                                    id="username"
                                                    name="username"
                                                    type="text"
                                                    placeholder="username"
                                                    class="
                                                        relative
                                                        block
                                                        w-full
                                                        bg-transparent
                                                        border-gray-300
                                                        rounded-none
                                                        focus:ring-indigo-500
                                                        focus:border-indigo-500
                                                        rounded-t-md
                                                        focus:z-10
                                                        sm:text-sm
                                                    "
                                                />
                                            </div>
                                            <div>
                                                <label
                                                    for="password"
                                                    class="sr-only"
                                                    >password</label
                                                >
                                                <input
                                                    v-model="password"
                                                    id="password"
                                                    name="password"
                                                    type="text"
                                                    placeholder="password"
                                                    class="
                                                        relative
                                                        block
                                                        w-full
                                                        bg-transparent
                                                        border-gray-300
                                                        rounded-none
                                                        focus:ring-indigo-500
                                                        focus:border-indigo-500
                                                        focus:z-10
                                                        sm:text-sm
                                                    "
                                                />
                                            </div>
                                            <div>
                                                <label
                                                    for="email"
                                                    class="sr-only"
                                                    >email</label
                                                >
                                                <input
                                                    v-model="email"
                                                    id="email"
                                                    name="email"
                                                    type="email"
                                                    placeholder="email"
                                                    class="
                                                        relative
                                                        block
                                                        w-full
                                                        bg-transparent
                                                        border-gray-300
                                                        rounded-none
                                                        focus:ring-indigo-500
                                                        focus:border-indigo-500
                                                        focus:z-10
                                                        sm:text-sm
                                                    "
                                                />
                                            </div>
                                            <div>
                                                <label
                                                    for="healthFacility"
                                                    class="sr-only"
                                                    >Health Facility</label
                                                >
                                                <input
                                                    v-model="healthFacility"
                                                    type="text"
                                                    name="healthFacility"
                                                    @keyup.enter="addUser()"
                                                    id="healthFacility"
                                                    class="
                                                        relative
                                                        block
                                                        w-full
                                                        bg-transparent
                                                        border-gray-300
                                                        rounded-none
                                                        focus:ring-indigo-500
                                                        focus:border-indigo-500
                                                        rounded-b-md
                                                        focus:z-10
                                                        sm:text-sm
                                                    "
                                                    placeholder="healthFacility"
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
                                            @click="addUser()"
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
                                            Add user
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
                                Users
                                <span
                                    class="
                                        px-2
                                        py-1
                                        text-sm text-indigo-500
                                        bg-gray-200
                                        rounded-full
                                    "
                                    >{{ persons.length }}</span
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
                            @rowExpand="onRowExpand"
                            @rowCollapse="onRowCollapse"
                            :rowHover="true"
                            filterDisplay="menu"
                            v-model:filters="filters"
                            :globalFilterFields="[
                                'firstName',
                                'lastName',
                                'MobileNumber',
                                'passportNumber',
                                'houseNumber',
                                'suburb',
                                'town',
                                'nextOfKinNumber',
                                'nextOfKin',
                                'sex',
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
                                    <h5 class="p-m-0"></h5>
                                    <span class="p-input-icon-left">
                                        <i class="pi pi-search" />
                                        <InputText
                                            v-model="filters['global'].value"
                                            placeholder="Keyword Search"
                                        />
                                    </span>
                                </div>
                            </template>
                            <template #empty> No users found. </template>
                            <template #loading>
                                Loading users data. Please wait.
                            </template>
                            <!-- <Column :exportable="false" style="min-width: 8rem">
                                <template #body="{ data }">
                                    <Button
                                        icon="pi pi-trash"
                                        class="p-button-rounded p-button-danger"
                                        @click="confirmDeleteitem(data)"
                                    />
                                </template>
                            </Column> -->

                            <Column
                                field="username"
                                header="username"
                                sortable
                                style="min-width: 14rem"
                            >
                                <template #body="{ data }">
                                    {{ data.username }}
                                </template>
                                <template #editor="{ data }">
                                    <InputText
                                        v-model="data['username']"
                                        autofocus
                                    />
                                </template>
                            </Column>
                            <Column
                                field="email"
                                header="email"
                                sortable
                                style="min-width: 14rem"
                            >
                                <template #body="{ data }">
                                    {{ data.email }}
                                </template>
                                <template #editor="{ data }">
                                    <InputText
                                        v-model="data['email']"
                                        autofocus
                                    />
                                </template>
                            </Column>
                            <Column
                                field="healthFacility"
                                header="healthFacility"
                                sortable
                                style="min-width: 14rem"
                            >
                                <template #body="{ data }">
                                    {{ data.healthFacility }}
                                </template>
                                <template #editor="{ data }">
                                    <InputText
                                        v-model="data['healthFacility']"
                                        autofocus
                                    />
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
                                <label for="sex">Sex</label>
                                <InputText
                                    id="sex"
                                    v-model.trim="person.sex"
                                    required="true"
                                    autofocus
                                    :class="{
                                        'p-invalid': submitted && !person.sex,
                                    }"
                                />
                                <small
                                    class="p-error"
                                    v-if="submitted && !person.sex"
                                    >Sex is required.</small
                                >
                            </div>
                            <div class="my-2 p-field">
                                <label for="birthdate">birthdate</label>
                                <InputText
                                    id="birthdate"
                                    v-model.trim="person.birthdate"
                                    required="true"
                                    autofocus
                                    :class="{
                                        'p-invalid':
                                            submitted && !person.birthdate,
                                    }"
                                />
                                <small
                                    class="p-error"
                                    v-if="submitted && !person.birthdate"
                                    >Birthdate is required.</small
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
                vaccinated: this.vaccinated,
                name: this.name,
            })
                .then(async (response) => {
                    console.log(response)
                    console.log(response.data.payload.docs)
                    this.persons = response.data.payload.docs
                    this.loading = false
                })
                .catch((e) => {
                    this.loading = false
                    console.log(e)
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
                    console.log(e)
                })
            this.personDialog = false
        },
        onRowEditSave(event) {
            this.loading = true

            let { newData, index } = event

            const data = JSON.parse(JSON.stringify(newData))

            const id = data['_id']
            delete data['_id']
            PersonsDataService.update(id, data)
                .then(async (response) => {
                    this.searchPerson()
                })
                .catch((e) => {
                    this.loading = false
                    console.log(e)
                })

            //this.items2[index] = newData;
        },
        onRowEditSaveVac(event, originalObject) {
            let { newData, index } = event
            const data = JSON.parse(JSON.stringify(newData))
            const objectIndexInOriginal = index
            console.log(index)
            const neworiginalObject = JSON.parse(JSON.stringify(originalObject))
            neworiginalObject.vaccination[index] = data

            const id = neworiginalObject['_id']
            delete neworiginalObject['_id']

            PersonsDataService.update(id, neworiginalObject)
                .then(async (response) => {
                    this.searchPerson()
                    console.log(response)
                })
                .catch((e) => {
                    this.loading = false
                    console.log(e)
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

        paginateResults() {
            var count = 10
            this.currentIndex = count - 1
            for (let i = 0; i <= count; i++) {
                this.persons.push(this.tempPerson[i])
            }
        },
        onRowExpand(event) {
            console.log('expanded row')
        },
        onRowCollapse(event) {
            console.log('collapsed row')
        },
        next() {
            var count = 10
            var temp = []
            for (let i = this.currentIndex; i <= start + 10; i++) {
                temp.push(items[i])
            }
            this.currentIndex = this.currentIndex + count
            this.person = temp
        },
        previous() {
            paginateResults(this.tempPerson, currentIndex)
        },
    },
}
</script>
