import { createRouter, createWebHistory } from 'vue-router'
import Login from '../components/auth/Login.vue'
import SearchPerson from '../components/search/searchperson.vue'
import searchData from '../components/userdata/index.vue'
import MainLayout from '../layouts/MainLayout.vue'
import Home from '../components/dashboard/index.vue'
import AddPatient from '../components/patient/index.vue'
import Chat from '../components/Chat.vue'

const routes = [
    {
        path: '/',
        name: 'login',
        component: Login,
        meta: {
            isLayout: 'none',
            title: 'Search Person',
        },
    },
    {
        path: '/search',
        name: 'searchPerson',
        component: SearchPerson,
        meta: {
            layout: MainLayout,
            isLayout: 'yes',
            title: 'Search Person',
        },
    },

    {
        path: '/home',
        name: 'home',
        component: Home,
        meta: {
            layout: MainLayout,
            isLayout: 'yes',
            title: 'Dashboard',
        },
    },
    {
        path: '/addPatient',
        name: 'addPatient',
        component: AddPatient,
        meta: {
            layout: MainLayout,
            isLayout: 'yes',
            title: 'Malaria Patient Surveillance Form',
        },
    },
    {
        path: '/chat',
        name: 'chat',
        component: Chat,
        meta: {
            layout: MainLayout,
            isLayout: 'yes',
            title: 'Chat',
        },
    },
]

const router = createRouter({
    history: createWebHistory(),
    routes,
})

export default router
