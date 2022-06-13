import Vue from 'vue';
import App from './App.vue';
import "vuetify/dist/vuetify.min.css";
import Router from "vue-router";
import Vuetify from 'vuetify/lib';
import VueAxios from 'vue-axios';
import web3 from 'web3'

import FXAuction from './abis/FXAuction.json'

import Login from "@/components/Login";
import Dashboard from "@/components/Dashboard";
import BidForm from './components/BidForm'
import AuctionForm from './components/AuctionForm'
import AuctionView from './components/AuctionView'

// Import the Auth0 configuration
import { domain, clientId } from "../auth_config.json";
// Import the plugin here
import { Auth0Plugin } from "./auth";
import { authGuard } from "./auth/authGuard";



Vue.config.productionTip = false;


var Web3 = require('web3')
var VueWeb3 = require('vue-web3')
 
// explicit installation required in module environments
console.log(window.ethereum)
Vue.use(VueWeb3, { web3: new Web3(window.ethereum) })

web3 =  new Web3(window.ethereum)

console.log( web3.eth)

let fxAuction = new web3.eth.Contract(FXAuction.abi, '0x509950aFFa2fBE3f1183D4443A471A117bf911b8')


Vue.use(VueAxios);

Vue.use(Router);
const routes = [

  {
    path: '/',
    component: Dashboard,
    name: 'home',
    beforeEnter: authGuard 
  },
  {
    path: '/login',
    component: Login,
    name: 'login'
  },
  {
    path: '/bid',
    component: BidForm,
    name: 'submitBid',
    beforeEnter: authGuard 
  },
  {
    path: '/auction',
    component: AuctionForm,
    name: 'createAuction',
    beforeEnter: authGuard 
  },
  {
    path: '/auction/list',
    component: AuctionView,
    name: 'viewAuctions',
    beforeEnter: authGuard 
  }
]


const router = new Router({
  mode: 'history',
  routes: routes
});

Vue.use(Vuetify);
const vuetify = new Vuetify();

// Install the authentication plugin here
Vue.use(Auth0Plugin, {
  domain,
  clientId,
  onRedirectCallback: appState => {
    router.push(
      appState && appState.targetUrl
        ? appState.targetUrl
        : window.location.pathname
    );
  }
});



new Vue({
  vuetify,
  router,
  web3: {
    // can bind to calls
    getAllPrimaryBids: {
      contract: fxAuction,
      method: 'getAllPrimaryBids',
      arguments: []
    },
  },
  render: h => h(App),
}).$mount('#app')
