<template>
  <!-- App.vue -->

    <v-app>
      <Sidebar v-if="this.$route.name !== 'login'"/>

      <v-container>
        <router-view></router-view>
      </v-container>


      <!-- Sizes your content based upon application components -->

    </v-app>

</template>

<style>
  .v-toolbar__content, .v-toolbar__extension {
    padding: 0 !important;
  }
</style>

<script>

import Sidebar from './components/Sidebar.vue'

 export default {
  name: 'App',
  data () {
    return {
      fav: true,
      menu: false,
      message: false,
      hints: true,
      drawer: true,
      mini: true,
    }
  },
  methods:{
  },

  components: {
    Sidebar,
  }
 };
</script>
