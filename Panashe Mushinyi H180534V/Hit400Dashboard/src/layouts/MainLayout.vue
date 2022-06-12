<template>
    <main class="flex flex-col">
        <Disclosure
            as="nav"
            class="py-3 bg-white shadow border-b-1"
            v-slot="{ open }"
        >
            <div class="max-w-full px-2 mx-auto sm:px-4 lg:px-8">
                <div class="flex justify-between h-16">
                    <div class="flex px-2 lg:px-0">
                        <div class="flex items-center flex-shrink-0">
                            <img
                                class="block w-auto h-16 lg:hidden"
                                src="../assets/logo.png"
                                alt="Workflow"
                            />
                            <img
                                class="hidden w-auto h-16 lg:block"
                                src="../assets/logo.png"
                                alt="Workflow"
                            />
                        </div>
                        <div class="hidden lg:ml-6 lg:flex lg:space-x-8">
                            <!-- Current: "border-indigo-500 text-gray-900", Default: "border-transparent text-gray-500 hover:border-gray-300 hover:text-gray-700" -->
                            <!-- <router-link
                                to="/home"
                                :class="
                                    $route.path == '/home'
                                        ? 'border-b-2 border-indigo-500'
                                        : 'border-b-2 border-transparent '
                                "
                                class="inline-flex items-center px-1 pt-1 text-sm font-medium text-gray-900 "
                            >
                                Dashboard
                            </router-link> -->
                        </div>
                    </div>

                    <div class="flex items-center lg:hidden">
                        <p
                            class="flex items-center justify-center px-2 space-x-2 "
                        >
                            <strong>Logged in as: </strong>
                            <span>{{ username }} </span>
                        </p>
                        <!-- Mobile menu button -->
                        <DisclosureButton
                            class="inline-flex items-center justify-center p-2 text-gray-400 rounded-md  hover:text-gray-500 hover:bg-gray-100 focus:outline-none focus:ring-2 focus:ring-inset focus:ring-indigo-500"
                        >
                            <span class="sr-only">Open main menu</span>
                            <MenuIcon
                                v-if="!open"
                                class="block w-6 h-6"
                                aria-hidden="true"
                            />
                            <XIcon
                                v-else
                                class="block w-6 h-6"
                                aria-hidden="true"
                            />
                        </DisclosureButton>
                    </div>
                    <div class="hidden lg:ml-4 lg:flex lg:items-center">
                        <p
                            class="flex items-center justify-center px-2 space-x-2 "
                        >
                            <strong>Logged in as : </strong>
                            <span>{{ username }} </span>
                        </p>
                        <!-- Profile dropdown -->
                        <Menu as="div" class="relative flex-shrink-0 ml-4">
                            <div>
                                <MenuButton
                                    class="flex text-sm bg-white rounded-full  focus:outline-none focus:ring-2 focus:ring-offset-2 focus:ring-indigo-500"
                                >
                                    <span class="sr-only">Open user menu</span>
                                    <i class="pi pi-user"></i>
                                </MenuButton>
                            </div>
                            <transition
                                enter-active-class="transition duration-100 ease-out"
                                enter-from-class="transform scale-95 opacity-0"
                                enter-to-class="transform scale-100 opacity-100"
                                leave-active-class="transition duration-75 ease-in"
                                leave-from-class="transform scale-100 opacity-100"
                                leave-to-class="transform scale-95 opacity-0"
                            >
                                <MenuItems
                                    class="absolute right-0 z-50 items-center w-48 py-1 mt-2 origin-top-right bg-white rounded-md shadow-lg  ring-1 ring-black ring-opacity-5 focus:outline-none"
                                >
                                    <MenuItem v-slot="{ active }">
                                        <a
                                            @click.prevent="logOut"
                                            href="#"
                                            :class="[
                                                active ? 'bg-gray-100' : '',
                                                'block px-4 py-2 text-sm text-gray-700',
                                            ]"
                                            >Sign out</a
                                        >
                                    </MenuItem>
                                </MenuItems>
                            </transition>
                        </Menu>
                    </div>
                </div>
            </div>

            <DisclosurePanel class="lg:hidden">
                <div class="pt-2 pb-3 space-y-1">
                    <!-- Current: "bg-indigo-50 border-indigo-500 text-indigo-700", Default: "border-transparent text-gray-600 hover:bg-gray-50 hover:border-gray-300 hover:text-gray-800" -->
                    <!--   <router-link
                        to="/home"
                        :class="
                            $route.path == '/home'
                                ? 'border-l-4 border-indigo-500 bg-indigo-50 text-indigo-700 '
                                : 'border-l-4 border-transparent text-gray-600 '
                        "
                        class="block py-2 pl-3 pr-4 text-base font-medium hover:bg-gray-50 hover:border-gray-300 hover:text-gray-800"
                        >Dashboard</router-link
                    > -->
                    <router-link
                        to="/search"
                        :class="
                            $route.path == '/search'
                                ? 'border-l-4 border-indigo-500 bg-indigo-50 text-indigo-700 '
                                : 'border-l-4 border-transparent text-gray-600 '
                        "
                        class="block py-2 pl-3 pr-4 text-base font-medium  hover:bg-gray-50 hover:border-gray-300 hover:text-gray-800"
                        >Search Person</router-link
                    >
                    <!--  <router-link
                        to="/users"
                        :class="
                            $route.path == '/users'
                                ? 'border-l-4 border-indigo-500 bg-indigo-50 text-indigo-700 '
                                : 'border-l-4 border-transparent text-gray-600 '
                        "
                        class="block py-2 pl-3 pr-4 text-base font-medium hover:bg-gray-50 hover:border-gray-300 hover:text-gray-800"
                        >User Management</router-link
                    > -->
                </div>
                <div class="pt-4 pb-3 border-t border-gray-200">
                    <div class="mt-3 space-y-1">
                        <a
                            @click.prevent="logOut"
                            href="#"
                            class="block px-4 py-2 text-base font-medium text-gray-500  hover:text-gray-800 hover:bg-gray-100"
                            >Sign out</a
                        >
                    </div>
                </div>
            </DisclosurePanel>
        </Disclosure>
        <slot />
    </main>
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
import { SearchIcon } from '@heroicons/vue/solid'
import { BellIcon, MenuIcon, XIcon } from '@heroicons/vue/outline'
import jwt_decode from 'jwt-decode'

export default {
    name: 'MainLayout',
    components: {
        Disclosure,
        DisclosureButton,
        DisclosurePanel,
        Menu,
        MenuButton,
        MenuItem,
        MenuItems,
        MenuIcon,
        XIcon,
    },
    data() {
        return {
            username: '',
        }
    },

    computed: {
        currentUser() {
            return this.$store.getters.user
        },
    },
    mounted() {
        if (!this.currentUser) {
            this.$router.push('/')
        } else {
            this.username = jwt_decode(this.currentUser.token).username
        }
    },
    methods: {
        logOut() {
            this.$store.dispatch('logout')
            this.$router.push('/')
        },
    },
    setup() {
        const open = ref(false)

        return {
            open,
        }
    },
}
</script>

<style></style>
