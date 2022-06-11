<template>
    <div
        v-if="this.$route.meta.isLayout.toString() == 'yes'"
        class="flex h-screen overflow-hidden bg-gray-100"
    >
        <TransitionRoot as="template" :show="sidebarOpen">
            <Dialog
                as="div"
                static
                class="fixed inset-0 z-40 flex md:hidden"
                @close="open()"
                :open="sidebarOpen"
            >
                <TransitionChild
                    as="template"
                    enter="transition-opacity ease-linear duration-300"
                    enter-from="opacity-0"
                    enter-to="opacity-100"
                    leave="transition-opacity ease-linear duration-300"
                    leave-from="opacity-100"
                    leave-to="opacity-0"
                >
                    <DialogOverlay
                        class="fixed inset-0 bg-gray-600 bg-opacity-75"
                    />
                </TransitionChild>
                <TransitionChild
                    as="template"
                    enter="transition ease-in-out duration-300 transform"
                    enter-from="-translate-x-full"
                    enter-to="translate-x-0"
                    leave="transition ease-in-out duration-300 transform"
                    leave-from="translate-x-0"
                    leave-to="-translate-x-full"
                >
                    <div
                        class="relative flex flex-col flex-1 w-full max-w-xs pt-5 pb-4 bg-indigo-700 "
                    >
                        <TransitionChild
                            as="template"
                            enter="ease-in-out duration-300"
                            enter-from="opacity-0"
                            enter-to="opacity-100"
                            leave="ease-in-out duration-300"
                            leave-from="opacity-100"
                            leave-to="opacity-0"
                        >
                            <div class="absolute top-0 right-0 pt-2 -mr-12">
                                <button
                                    type="button"
                                    class="flex items-center justify-center w-10 h-10 ml-1 rounded-full  focus:outline-none focus:ring-2 focus:ring-inset focus:ring-white"
                                    @click="open()"
                                >
                                    <span class="sr-only">Close sidebar</span>
                                    <XIcon
                                        class="w-6 h-6 text-white"
                                        aria-hidden="true"
                                    />
                                </button>
                            </div>
                        </TransitionChild>
                        <div class="flex items-center flex-shrink-0 px-4">
                            <svg
                                class="h-10 m-auto text-white fill-current"
                                xmlns="http://www.w3.org/2000/svg"
                                enable-background="new 0 0 32 32"
                                viewBox="0 0 32 32"
                            >
                                <path
                                    d="M28.805,21.567c-0.794,1.126-4.061-0.199-7.296-2.96c-1.28-1.093-2.297-2.336-3.038-3.476
	c-0.107,0.232-0.228,0.45-0.365,0.646c0.139,0.531,0.259,1.136,0.368,1.762l5.266,5.789C23.907,23.511,24,23.751,24,24v2.585
	l1.707,1.708c0.391,0.391,0.391,1.024,0,1.414c-0.391,0.391-1.023,0.391-1.414,0l-2-2C22.105,27.519,22,27.265,22,27v-2.613
	l-3.091-3.398c0,0.004,0.001,0.007,0.001,0.011h-5.82c0-0.004,0.001-0.007,0.001-0.011L10,24.387V27c0,0.265-0.105,0.52-0.293,0.707
	l-2,2c-0.391,0.391-1.023,0.391-1.414,0c-0.391-0.39-0.391-1.023,0-1.414L8,26.585V24c0-0.249,0.093-0.489,0.26-0.673l5.266-5.789
	c0.109-0.625,0.229-1.231,0.368-1.762c-0.137-0.196-0.258-0.414-0.365-0.646c-0.741,1.139-1.758,2.383-3.038,3.476
	c-3.235,2.761-6.501,4.087-7.296,2.96c-0.794-1.126,1.184-4.277,4.419-7.039c1.643-1.402,3.389-2.265,4.77-2.717L7.632,9.93
	C7.25,9.779,7,9.41,7,9V5.414L5.293,3.707c-0.391-0.391-0.391-1.023,0-1.414s1.023-0.391,1.414,0l2,2C8.895,4.48,9,4.735,9,5v3.32
	l4.469,1.77c0.137-0.331,0.299-0.634,0.491-0.901C13.373,8.641,13,7.867,13,7c0-1.363,0.914-2.5,2.159-2.866l0.53-2.891
	c0.081-0.324,0.542-0.324,0.623,0l0.53,2.891C18.086,4.5,19,5.637,19,7c0,0.867-0.373,1.641-0.961,2.189
	c0.193,0.267,0.354,0.57,0.491,0.901L23,8.32V5c0-0.265,0.105-0.52,0.293-0.707l2-2c0.391-0.391,1.023-0.391,1.414,0
	s0.391,1.023,0,1.414L25,5.414V9c0,0.41-0.25,0.779-0.632,0.93l-4.753,1.882c1.381,0.452,3.127,1.315,4.77,2.717
	C27.62,17.29,29.599,20.441,28.805,21.567z"
                                />
                                <path
                                    d="M13 23h6c0 .726-.059 1.385-.148 2h-5.704C13.059 24.385 13 23.726 13 23zM13.669 27h4.661c-.523 1.26-1.323 2-2.331 2S14.193 28.26 13.669 27z"
                                />
                            </svg>
                        </div>
                        <div class="flex-1 h-0 mt-5 overflow-y-auto">
                            <nav class="px-2 space-y-1">
                                <router-link
                                    v-for="item in navigation"
                                    @click="item.current = true"
                                    :key="item.name"
                                    :to="item.href"
                                    :class="[
                                        item.current
                                            ? 'bg-indigo-800 text-white'
                                            : 'text-indigo-100 hover:bg-indigo-600',
                                        'group flex items-center px-2 py-2 text-base font-medium rounded-md',
                                    ]"
                                >
                                    <component
                                        :is="item.icon"
                                        class="flex-shrink-0 w-6 h-6 mr-4 text-indigo-300 "
                                        aria-hidden="true"
                                    />
                                    {{ item.name }}
                                </router-link>
                            </nav>
                        </div>
                    </div>
                </TransitionChild>
                <div class="flex-shrink-0 w-14" aria-hidden="true">
                    <!-- Dummy element to force sidebar to shrink to fit close icon -->
                </div>
            </Dialog>
        </TransitionRoot>

        <!-- Static sidebar for desktop -->
        <div class="hidden bg-indigo-700 md:flex md:flex-shrink-0">
            <div class="flex flex-col w-64">
                <!-- Sidebar component, swap this element with another sidebar if you like -->
                <div class="flex flex-col flex-grow pt-5 pb-4 overflow-y-auto">
                    <div class="flex items-center flex-shrink-0 px-4">
                        <svg
                            class="h-10 m-auto text-white fill-current"
                            xmlns="http://www.w3.org/2000/svg"
                            enable-background="new 0 0 32 32"
                            viewBox="0 0 32 32"
                        >
                            <path
                                d="M28.805,21.567c-0.794,1.126-4.061-0.199-7.296-2.96c-1.28-1.093-2.297-2.336-3.038-3.476
	c-0.107,0.232-0.228,0.45-0.365,0.646c0.139,0.531,0.259,1.136,0.368,1.762l5.266,5.789C23.907,23.511,24,23.751,24,24v2.585
	l1.707,1.708c0.391,0.391,0.391,1.024,0,1.414c-0.391,0.391-1.023,0.391-1.414,0l-2-2C22.105,27.519,22,27.265,22,27v-2.613
	l-3.091-3.398c0,0.004,0.001,0.007,0.001,0.011h-5.82c0-0.004,0.001-0.007,0.001-0.011L10,24.387V27c0,0.265-0.105,0.52-0.293,0.707
	l-2,2c-0.391,0.391-1.023,0.391-1.414,0c-0.391-0.39-0.391-1.023,0-1.414L8,26.585V24c0-0.249,0.093-0.489,0.26-0.673l5.266-5.789
	c0.109-0.625,0.229-1.231,0.368-1.762c-0.137-0.196-0.258-0.414-0.365-0.646c-0.741,1.139-1.758,2.383-3.038,3.476
	c-3.235,2.761-6.501,4.087-7.296,2.96c-0.794-1.126,1.184-4.277,4.419-7.039c1.643-1.402,3.389-2.265,4.77-2.717L7.632,9.93
	C7.25,9.779,7,9.41,7,9V5.414L5.293,3.707c-0.391-0.391-0.391-1.023,0-1.414s1.023-0.391,1.414,0l2,2C8.895,4.48,9,4.735,9,5v3.32
	l4.469,1.77c0.137-0.331,0.299-0.634,0.491-0.901C13.373,8.641,13,7.867,13,7c0-1.363,0.914-2.5,2.159-2.866l0.53-2.891
	c0.081-0.324,0.542-0.324,0.623,0l0.53,2.891C18.086,4.5,19,5.637,19,7c0,0.867-0.373,1.641-0.961,2.189
	c0.193,0.267,0.354,0.57,0.491,0.901L23,8.32V5c0-0.265,0.105-0.52,0.293-0.707l2-2c0.391-0.391,1.023-0.391,1.414,0
	s0.391,1.023,0,1.414L25,5.414V9c0,0.41-0.25,0.779-0.632,0.93l-4.753,1.882c1.381,0.452,3.127,1.315,4.77,2.717
	C27.62,17.29,29.599,20.441,28.805,21.567z"
                            />
                            <path
                                d="M13 23h6c0 .726-.059 1.385-.148 2h-5.704C13.059 24.385 13 23.726 13 23zM13.669 27h4.661c-.523 1.26-1.323 2-2.331 2S14.193 28.26 13.669 27z"
                            />
                        </svg>
                    </div>
                    <div class="flex flex-col flex-1 mt-5">
                        <nav class="flex-1 px-2 space-y-1">
                            <router-link
                                v-for="item in navigation"
                                :key="item.name"
                                :to="item.href"
                                :class="[
                                    item.current
                                        ? 'bg-indigo-800 text-white'
                                        : 'text-indigo-100 hover:bg-indigo-600',
                                    'group flex items-center px-2 py-2 text-sm font-medium rounded-md',
                                ]"
                            >
                                <component
                                    :is="item.icon"
                                    class="flex-shrink-0 w-6 h-6 mr-3 text-indigo-300 "
                                    aria-hidden="true"
                                />
                                {{ item.name }}
                            </router-link>
                        </nav>
                    </div>
                </div>
            </div>
        </div>
        <div class="flex flex-col flex-1 w-0 overflow-hidden">
            <div class="relative z-10 flex flex-shrink-0 h-16 bg-white shadow">
                <button
                    type="button"
                    class="px-4 text-gray-500 border-r border-gray-200  focus:outline-none focus:ring-2 focus:ring-inset focus:ring-indigo-500 md:hidden"
                    @click="sidebarOpen = true"
                >
                    <span class="sr-only">Open sidebar</span>
                    <MenuAlt2Icon class="w-6 h-6" aria-hidden="true" />
                </button>
                <div class="flex justify-between flex-1 px-4">
                    <div class="flex flex-1">
                        <form
                            class="flex w-full md:ml-0"
                            action="#"
                            method="GET"
                        >
                            <label for="search-field" class="sr-only"
                                >Search</label
                            >
                            <div
                                class="relative w-full text-gray-400  focus-within:text-gray-600"
                            >
                                <div
                                    class="absolute inset-y-0 left-0 flex items-center pointer-events-none "
                                >
                                    <SearchIcon
                                        class="w-5 h-5"
                                        aria-hidden="true"
                                    />
                                </div>
                                <input
                                    id="search-field"
                                    class="block w-full h-full py-2 pl-8 pr-3 text-gray-900 placeholder-gray-500 border-transparent  focus:outline-none focus:placeholder-gray-400 focus:ring-0 focus:border-transparent sm:text-sm"
                                    placeholder="Search Patient (Press Enter To Search)"
                                    v-on:keyup.enter="search()"
                                    type="search"
                                    name="search"
                                    v-model="searchQuery"
                                />
                            </div>
                        </form>
                    </div>
                    <div class="flex items-center ml-4 md:ml-6">
                        <button
                            class="p-1 text-gray-400 bg-white rounded-full  hover:text-gray-500 focus:outline-none focus:ring-2 focus:ring-offset-2 focus:ring-indigo-500"
                        >
                            <span class="sr-only">View notifications</span>
                            <BellIcon class="w-6 h-6" aria-hidden="true" />
                        </button>

                        <!-- Profile dropdown -->
                        <Menu as="div" class="relative ml-3">
                            <div>
                                <MenuButton
                                    class="flex items-center max-w-xs text-sm bg-white rounded-full  focus:outline-none focus:ring-2 focus:ring-offset-2 focus:ring-indigo-500"
                                >
                                    <span class="sr-only">Open user menu</span>
                                    <img
                                        class="w-8 h-8 rounded-full"
                                        src="https://images.unsplash.com/photo-1472099645785-5658abf4ff4e?ixlib=rb-1.2.1&ixid=eyJhcHBfaWQiOjEyMDd9&auto=format&fit=facearea&facepad=2&w=256&h=256&q=80"
                                        alt=""
                                    />
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
                                    class="absolute right-0 w-48 py-1 mt-2 origin-top-right bg-white rounded-md shadow-lg  ring-1 ring-black ring-opacity-5 focus:outline-none"
                                >
                                    <MenuItem
                                        v-for="item in userNavigation"
                                        :key="item.name"
                                        @click="signOut()"
                                        v-slot="{ active }"
                                    >
                                        <router-link
                                            :to="item.href"
                                            :class="[
                                                active ? 'bg-gray-100' : '',
                                                'block px-4 py-2 text-sm text-gray-700',
                                            ]"
                                            >{{ item.name }}</router-link
                                        >
                                    </MenuItem>
                                </MenuItems>
                            </transition>
                        </Menu>
                    </div>
                </div>
            </div>

            <main class="relative flex-1 overflow-y-auto focus:outline-none">
                <div class="py-6">
                    <div class="px-4 mx-auto max-w-7xl sm:px-6 md:px-8">
                        <h1 class="text-2xl font-semibold text-gray-900">
                            {{ this.$route.meta.title }}
                        </h1>
                    </div>
                    <div class="px-4 mx-auto max-w-7xl sm:px-6 md:px-8">
                        <!-- Replace with your content -->
                        <div class="py-4">
                            <router-view />
                        </div>
                        <!-- /End replace -->
                    </div>
                </div>
            </main>
        </div>
    </div>
    <div v-else>
        <div class="">
            <!-- Replace with your content -->
            <div class="py-4">
                <router-view />
            </div>
            <!-- /End replace -->
        </div>
    </div>
</template>

<script>
import { ref } from 'vue'
import {
    Dialog,
    DialogOverlay,
    Menu,
    MenuButton,
    MenuItem,
    MenuItems,
    TransitionChild,
    TransitionRoot,
} from '@headlessui/vue'
import {
    BellIcon,
    CalendarIcon,
    ChartBarIcon,
    FolderIcon,
    HomeIcon,
    InboxIcon,
    MenuAlt2Icon,
    UsersIcon,
    XIcon,
    PlusIcon,
    ChatAlt2Icon,
} from '@heroicons/vue/outline'
import { SearchIcon } from '@heroicons/vue/solid'
import { CometChat } from '@cometchat-pro/chat'

const navigation = [
    { name: 'Dashboard', href: '/home', icon: HomeIcon, current: false },
    {
        name: 'Search Patient',
        href: '/search',
        icon: SearchIcon,
        current: false,
    },

    {
        name: 'Add Patient',
        href: '/addPatient',
        icon: PlusIcon,
        current: false,
    },
    {
        name: 'Chat',
        href: '/chat',
        icon: ChatAlt2Icon,
        current: false,
    },
]
const userNavigation = [{ name: 'Sign out', href: '#' }]

export default {
    components: {
        Dialog,
        DialogOverlay,
        Menu,
        MenuButton,
        MenuItem,
        MenuItems,
        TransitionChild,
        TransitionRoot,
        BellIcon,
        MenuAlt2Icon,
        SearchIcon,
        XIcon,
    },
    data() {
        return {
            sidebarOpen: false,
            navigation,
            userNavigation,
            searchQuery: '',
            messagesCount: 0,
        }
    },
    mounted() {
        CometChat.addMessageListener(
            'UNIQUE_LISTENER_ID',
            new CometChat.MessageListener({
                onTextMessageReceived: (textMessage) => {
                    CometChat.getUnreadMessageCount().then(
                        (array) => {
                            console.log('Message count fetched', array)

                            let sumUsers = 0
                            let sumGroups = 0

                            for (const key in array.users) {
                                sumUsers += array.users[key]
                            }
                            for (const key in array.groups) {
                                sumGroups += array.groups[key]
                            }

                            console.log(sumUsers + sumGroups)
                            this.messageCount = sumGroups + sumUsers
                        },
                        (error) => {
                            console.log('Error in getting message count', error)
                        }
                    )
                },
                onMediaMessageReceived: (mediaMessage) => {
                    CometChat.getUnreadMessageCount().then(
                        (array) => {
                            console.log('Message count fetched', array)
                            let sumUsers = 0
                            let sumGroups = 0

                            for (const key in array.users) {
                                sumUsers += array.users[key]
                            }
                            for (const key in array.groups) {
                                sumGroups += array.groups[key]
                            }

                            console.log(sumUsers + sumGroups)
                            this.messageCount = sumGroups + sumUsers
                        },
                        (error) => {
                            console.log('Error in getting message count', error)
                        }
                    )
                },
            })
        )
    },
    methods: {
        open() {
            console.log('clicked')
            this.sidebarOpen = !this.sidebarOpen
        },
        search() {
            this.$router.replace(`/search?q=${this.searchQuery}`)
        },
        signOut() {
            this.$store.dispatch('logout')
            this.$router.push('/')
        },
    },
}
</script>
