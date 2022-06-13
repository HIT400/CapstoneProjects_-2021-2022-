<template>
  <div>
    <v-navigation-drawer app
                         v-model="drawer"
                         mini-variant.sync="mini"
                         permanent
                         clipped

    >
      <v-list-item class="px-5">
        <div>
          <v-img :src="logo" width="50px"></v-img>
        </div>

        <v-list-item-title>&nbsp;&nbsp;RBZ Foreign Exchange Auction System</v-list-item-title>

      </v-list-item>
      <v-divider></v-divider>

      <v-list dense>
        <v-list-item-group
            v-model="selectedItem"
        >
          <span v-if="getRole() == 'authorised_dealer'">
            <v-list-item
                v-for="item in items"
                :key="item.title"
                @click="item.action()"
            >
            <v-list-item-icon >
              <v-icon v-text="item.icon"></v-icon>
            </v-list-item-icon>
            <v-list-item-content>
              <v-list-item-title v-text="item.title"></v-list-item-title>
            </v-list-item-content>
          </v-list-item>
           <v-btn  v-if="$auth.isAuthenticated" @click="logout()" block>Logout</v-btn>

          <v-btn  v-if="!$auth.isAuthenticated" @click="login()" block>Login</v-btn>
          </span>
          <span   v-if="getRole() == 'rbz_admin'">
          <v-list-item
                v-for="item in items2"
                :key="item.title"
                @click="item.action()"
            >
            <v-list-item-icon>
              <v-icon v-text="item.icon"></v-icon>
            </v-list-item-icon>
            <v-list-item-content>
              <v-list-item-title v-text="item.title"></v-list-item-title>
            </v-list-item-content>
          </v-list-item>
          <v-btn  v-if="$auth.isAuthenticated" @click="logout()" block>Logout</v-btn>

          <v-btn  v-if="!$auth.isAuthenticated" @click="login()" block>Login</v-btn>
          </span>

        </v-list-item-group>
      </v-list>
    </v-navigation-drawer>

  </div>
</template>

<script>

export default {
  name: "Sidebar",
  data(){
    return {
      selectedItem: -1,
      roleCheck: true,
      menu: false,
      message: false,
      hints: true,
      drawer: true,
      mini: true,
      showAdminExaminerMenu: false,
      items: [
        { title: 'Submit Bid',
          icon: 'mdi-file-question',
          action: ()=>{ this.$router.push({name: 'submitBid'})}
        },
        { title: 'Auction List',
          icon: 'mdi-file-question',
          action: ()=>{ this.$router.push({name: 'viewAuctions'})}
        },
        
      ],

      items2: [
        { title: 'Create Auction',
          icon: 'mdi-file-question',
          action: ()=>{ this.$router.push({name: 'createAuction'})}
        },
        { title: 'Auction List',
          icon: 'mdi-file-question',
          action: ()=>{ this.$router.push({name: 'viewAuctions'})}
        },
      ]

    }
  },
  methods: {
    logout(){
      this.$auth.logout()
    },
    login(){
      this.$auth.login()
    },
    getRole(){

      if(this.$auth.user.username == 'tmmmbano@gmail.com'){
        return 'rbz_admin'
      }
      else{
        return 'authorised_dealer'
      }
    }

  },
}
</script>

<style scoped>

</style>