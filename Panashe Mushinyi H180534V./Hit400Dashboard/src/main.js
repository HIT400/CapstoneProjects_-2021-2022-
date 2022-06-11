import { createApp } from 'vue'
import App from './App.vue'
import PrimeVue from 'primevue/config'
import DataTable from 'primevue/datatable'
import Column from 'primevue/column'
import ColumnGroup from 'primevue/columngroup'
import ProgressSpinner from 'primevue/progressspinner'
import InputText from 'primevue/inputtext'
import Button from 'primevue/button'
import VueToast from 'vue-toast-notification'
import PanelMenu from 'primevue/panelmenu'
import Chart from 'primevue/chart'
// Import one of the available themes
//import 'vue-toast-notification/dist/theme-default.css';
import 'vue-toast-notification/dist/theme-sugar.css'

import 'primevue/resources/themes/tailwind-light/theme.css'
import 'primevue/resources/primevue.min.css'
import 'primeicons/primeicons.css'
import './index.css'
import router from './router'
import store from './store'
import AppLayout from './layouts/AppLayout.vue'

import { CometChat } from '@cometchat-pro/chat'

const appID = '210925413cd0b693'
const region = 'us'
const appSetting = new CometChat.AppSettingsBuilder()
    .subscribePresenceForAllUsers()
    .setRegion(region)
    .build()

CometChat.init(appID, appSetting).then(
    () => {
        console.log('Initialization completed successfully')
        // You can now call login function.
    },
    (error) => {
        console.log('Initialization failed with error:', error)
        // Check the reason for error and take appropriate action.
    }
)

createApp(App)
    .use(router)
    .use(store)
    .use(PrimeVue)
    .use(VueToast)
    .component('AppLayout', AppLayout)
    .component('Chart', Chart)
    .component('DataTable', DataTable)
    .component('Column', Column)
    .component('InputText', InputText)
    .component('Button', Button)
    .component('ProgressSpinner', ProgressSpinner)
    .component('ColumnGroup', ColumnGroup)
    .mount('#app')
