<template>
    <div class="relative flex min-h-screen overflow-hidden">
        <div class="flex-1 overflow-hidden focus:outline-none">
            <main class="relative z-0 flex-1 min-h-screen pb-8 overflow-hidden">
                <div class="h-full mt-8">
                    <div class="">
                        <h2 class="text-lg font-medium leading-6 text-gray-900">
                            Overview
                        </h2>
                        <div
                            class="grid grid-cols-1 gap-5 mt-2  sm:grid-cols-2 lg:grid-cols-3"
                        >
                            <!-- Card -->
                            <div
                                v-if="loadingCount"
                                class="flex items-center justify-center"
                            >
                                <i
                                    class="pi pi-spin pi-spinner"
                                    style="fontsize: 0.5rem"
                                ></i>
                            </div>
                            <div
                                v-else
                                v-for="card in cards"
                                :key="card.name"
                                class="overflow-hidden bg-white rounded-lg shadow "
                            >
                                <div class="p-5">
                                    <div class="flex items-center">
                                        <div class="flex-shrink-0">
                                            <UserGroupIcon
                                                class="flex-shrink-0 w-5 h-5 text-gray-400  group-hover:text-gray-500"
                                                aria-hidden="true"
                                            />
                                        </div>
                                        <div class="flex-1 w-0 ml-5">
                                            <dl>
                                                <dt
                                                    class="text-sm font-medium text-gray-500 truncate "
                                                >
                                                    {{ card.name }}
                                                </dt>
                                                <dd>
                                                    <div
                                                        class="text-lg font-medium text-gray-900 "
                                                    >
                                                        {{ card.amount }}
                                                    </div>
                                                </dd>
                                            </dl>
                                        </div>
                                    </div>
                                </div>
                                <div class="px-5 py-3 bg-gray-50">
                                    <div class="text-sm">
                                        <router-link
                                            :to="`/search?q=${card.href}`"
                                            class="font-medium  text-cyan-700 hover:text-cyan-900"
                                        >
                                            View all
                                        </router-link>
                                    </div>
                                </div>
                            </div>
                        </div>
                    </div>
                    <h2
                        class="mt-16 text-lg font-medium leading-6 text-gray-900 "
                    >
                        The last 30 days
                    </h2>

                    <div class="p-2 mt-2 bg-white rounded-lg">
                        <Chart
                            type="bar"
                            :data="chartData"
                            :options="chartOptions"
                        />
                    </div>

                    <h2
                        class="mt-16 text-lg font-medium leading-6 text-gray-900 "
                    >
                        Recent activity
                    </h2>

                    <!-- Activity list (smallest breakpoint only) -->
                    <div class="shadow sm:hidden">
                        <ul
                            class="mt-2 overflow-hidden divide-y divide-gray-200 shadow  sm:hidden"
                        >
                            <li
                                v-for="transaction in transactions"
                                :key="transaction.id"
                            >
                                <a
                                    :href="transaction.href"
                                    class="block px-4 py-4 bg-white  hover:bg-gray-50"
                                >
                                    <span class="flex items-center space-x-4">
                                        <span
                                            class="flex flex-1 space-x-2 truncate "
                                        >
                                            <UserIcon
                                                class="flex-shrink-0 w-5 h-5 text-gray-400 "
                                                aria-hidden="true"
                                            />
                                            <span
                                                class="flex flex-col text-sm text-gray-500 truncate "
                                            >
                                                <span class="truncate">{{
                                                    transaction.name
                                                }}</span>
                                                <span
                                                    ><span
                                                        class="font-medium text-gray-900 "
                                                        >{{
                                                            transaction.amount
                                                        }}</span
                                                    >
                                                    {{
                                                        transaction.currency
                                                    }}</span
                                                >
                                                <time
                                                    :datetime="
                                                        transaction.datetime
                                                    "
                                                    >{{
                                                        transaction.date
                                                    }}</time
                                                >
                                            </span>
                                        </span>
                                        <ChevronRightIcon
                                            class="flex-shrink-0 w-5 h-5 text-gray-400 "
                                            aria-hidden="true"
                                        />
                                    </span>
                                </a>
                            </li>
                        </ul>

                        <nav
                            class="flex items-center justify-between px-4 py-3 bg-white border-t border-gray-200 "
                            aria-label="Pagination"
                        >
                            <div class="flex justify-between flex-1">
                                <a
                                    href="#"
                                    class="relative inline-flex items-center px-4 py-2 text-sm font-medium text-gray-700 bg-white border border-gray-300 rounded-md  hover:text-gray-500"
                                >
                                    Previous
                                </a>
                                <a
                                    href="#"
                                    class="relative inline-flex items-center px-4 py-2 ml-3 text-sm font-medium text-gray-700 bg-white border border-gray-300 rounded-md  hover:text-gray-500"
                                >
                                    Next
                                </a>
                            </div>
                        </nav>
                    </div>

                    <!-- Activity table (small breakpoint and up) -->
                    <div class="hidden sm:block">
                        <div class="">
                            <div class="flex flex-col mt-2">
                                <div
                                    class="min-w-full overflow-hidden overflow-x-auto align-middle shadow  sm:rounded-lg"
                                >
                                    <table
                                        class="min-w-full divide-y divide-gray-200 "
                                    >
                                        <thead>
                                            <tr>
                                                <th
                                                    class="px-6 py-3 text-xs font-medium tracking-wider text-left text-gray-500 uppercase  bg-gray-50"
                                                >
                                                    Case ID
                                                </th>
                                                <th
                                                    class="px-6 py-3 text-xs font-medium tracking-wider text-right text-gray-500 uppercase  bg-gray-50"
                                                ></th>
                                                <th
                                                    class="hidden px-6 py-3 text-xs font-medium tracking-wider text-left text-gray-500 uppercase  bg-gray-50 md:block"
                                                >
                                                    Status
                                                </th>
                                                <th
                                                    class="px-6 py-3 text-xs font-medium tracking-wider text-right text-gray-500 uppercase  bg-gray-50"
                                                >
                                                    Date
                                                </th>
                                            </tr>
                                        </thead>
                                        <div
                                            v-if="loadingTransactions"
                                            class="flex items-center justify-center "
                                        >
                                            <i
                                                class="pi pi-spin pi-spinner"
                                                style="fontsize: 0.5rem"
                                            ></i>
                                        </div>
                                        <tbody
                                            v-else
                                            class="bg-white divide-y divide-gray-200 "
                                        >
                                            <tr
                                                v-for="transaction in transactions"
                                                :key="transaction.id"
                                                class="bg-white"
                                            >
                                                <td
                                                    class="w-full px-6 py-4 text-sm text-gray-900  max-w-0 whitespace-nowrap"
                                                >
                                                    <div class="flex">
                                                        <a
                                                            :href="
                                                                transaction.href
                                                            "
                                                            class="inline-flex space-x-2 text-sm truncate  group"
                                                        >
                                                            <UserIcon
                                                                class="flex-shrink-0 w-5 h-5 text-gray-400  group-hover:text-gray-500"
                                                                aria-hidden="true"
                                                            />
                                                            <p
                                                                class="text-gray-500 truncate  group-hover:text-gray-900"
                                                            >
                                                                {{
                                                                    transaction.firstName
                                                                }}
                                                            </p>
                                                        </a>
                                                    </div>
                                                </td>
                                                <td
                                                    class="px-6 py-4 text-sm text-right text-gray-500  whitespace-nowrap"
                                                >
                                                    <span
                                                        class="font-medium text-gray-900 "
                                                        ><!-- {{
                                                            transaction.amount
                                                        }} -->
                                                    </span>
                                                </td>
                                                <td
                                                    class="hidden px-6 py-4 text-sm text-gray-500  whitespace-nowrap md:block"
                                                >
                                                    <span
                                                        :class="[
                                                            transaction.deduced ==
                                                            'Critical'
                                                                ? ' bg-red-200  text-red-800'
                                                                : 'bg-green-200 text-green-800',
                                                            'inline-flex items-center px-2.5 py-0.5 rounded-full text-xs font-medium capitalize',
                                                        ]"
                                                    >
                                                        {{
                                                            transaction.deduced
                                                        }}
                                                    </span>
                                                </td>
                                                <td
                                                    class="px-6 py-4 text-sm text-right text-gray-500  whitespace-nowrap"
                                                >
                                                    <time>{{
                                                        Date(
                                                            transaction.date
                                                        ).slice(0, 24)
                                                    }}</time>
                                                </td>
                                            </tr>
                                        </tbody>
                                    </table>
                                    <!-- Pagination -->
                                    <nav
                                        class="flex items-center justify-between px-4 py-3 bg-white border-t border-gray-200  sm:px-6"
                                        aria-label="Pagination"
                                    >
                                        <div class="hidden sm:block">
                                            <p class="text-sm text-gray-700">
                                                Showing
                                                {{ ' ' }}
                                                <span class="font-medium"
                                                    >1</span
                                                >
                                                {{ ' ' }}
                                                to
                                                {{ ' ' }}
                                                <span class="font-medium"
                                                    >10</span
                                                >
                                                {{ ' ' }}
                                                of
                                                {{ ' ' }}
                                                <span class="font-medium"
                                                    >20</span
                                                >
                                                {{ ' ' }}
                                                results
                                            </p>
                                        </div>
                                        <div
                                            class="flex justify-between flex-1  sm:justify-end"
                                        >
                                            <a
                                                href="#"
                                                class="relative inline-flex items-center px-4 py-2 text-sm font-medium text-gray-700 bg-white border border-gray-300 rounded-md  hover:bg-gray-50"
                                            >
                                                Previous
                                            </a>
                                            <a
                                                href="#"
                                                class="relative inline-flex items-center px-4 py-2 ml-3 text-sm font-medium text-gray-700 bg-white border border-gray-300 rounded-md  hover:bg-gray-50"
                                            >
                                                Next
                                            </a>
                                        </div>
                                    </nav>
                                </div>
                            </div>
                        </div>
                    </div>
                </div>
            </main>
        </div>
    </div>
</template>

<script>
import { ref } from 'vue'
import {
    BellIcon,
    MenuAlt1Icon,
    UserGroupIcon,
    XIcon,
} from '@heroicons/vue/outline'
import {
    CashIcon,
    UserIcon,
    CheckCircleIcon,
    ChevronDownIcon,
    ChevronRightIcon,
    OfficeBuildingIcon,
    SearchIcon,
} from '@heroicons/vue/solid'
import PersonsDataService from '../../services/persons'
export default {
    components: {
        UserIcon,
        UserGroupIcon,

        ChevronRightIcon,
    },
    data() {
        return {
            cards: [],
            transactions: [],
            data: [],
            temp: [],
            loadingCount: false,
            loadingChart: false,
            loadingTransactions: false,
            chartData: {},
            chartOptions: {
                plugins: {
                    legend: {
                        labels: {
                            color: '#495057',
                        },
                    },
                },
                scales: {
                    x: {
                        ticks: {
                            color: '#495057',
                        },
                        grid: {
                            color: '#ebedef',
                        },
                    },
                    y: {
                        ticks: {
                            color: '#495057',
                        },
                        grid: {
                            color: '#ebedef',
                        },
                    },
                },
            },
        }
    },
    async created() {
        await this.fetchChart()
        await this.fetchLatest()
        await this.fetchCount()
    },
    mounted() {},
    watch: {
        temp: function (val) {
            this.chartData.datasets[0].data = val
        },
    },

    methods: {
        fetchLatest() {
            this.loadingTransactions = true
            PersonsDataService.getTen()
                .then((res) => {
                    this.transactions = res.data.apply
                    console.log(res.data.apply)
                    this.loadingTransactions = false
                })
                .catch((error) => {
                    this.loadingTransactions = false
                    console.log(error)
                })
        },
        fetchCount() {
            this.loadingCount = true
            PersonsDataService.getCount()
                .then((res) => {
                    this.cards = res.data.count
                    console.log(res)
                    this.loadingCount = false
                })
                .catch((error) => {
                    this.loadingCount = false
                    console.log(error)
                })
        },
        fetchChart() {
            this.loadingChart = true

            PersonsDataService.getChart()
                .then(async (res) => {
                    res.data.items.forEach((item) => {
                        this.temp.push(item.count)
                    })
                    ;(this.chartData = {
                        labels: [
                            1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11, 12, 13, 14, 15,
                            16, 17, 18, 19, 20, 21, 22, 23, 24, 25, 26, 27, 28,
                            29, 30,
                        ],
                        datasets: [
                            {
                                type: 'bar',
                                label: 'Cases',
                                backgroundColor: '#4438ca',
                                data: this.temp,
                                borderColor: 'white',
                                borderWidth: 2,
                            },
                        ],
                    }),
                        (this.loadingChart = false)
                })
                .catch((error) => {
                    this.loadingChart = false
                    console.log(error)
                })
        },
    },
}
</script>
