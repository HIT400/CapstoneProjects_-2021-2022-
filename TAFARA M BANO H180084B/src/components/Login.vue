<template>
  <div style="display: flex;
              justify-content: center;
              align-items: center;
              height: 100vh">
    <v-row>
      <div class="col-sm-12 col-md-6">
        <v-layout align-center justify-center v-if="this.$router.history.current['path'] !== '/proctoring/external/*' || !$msal.isAuthenticated() ">
            <v-flex>

              <div style="text-align: center">
                <v-spacer></v-spacer>
                <img :src="logo" :alt="logo" height="60px" style="display: inline-block"/><h1 style="display: block">&nbsp;Reserve Bank of Zimbabwe</h1>
                <h1>Foreign Currency Auction System</h1>
                <v-spacer></v-spacer>

              </div>

              <br>

            </v-flex>


        </v-layout>
      </div>
      <div class="col-sm-12">
        <v-card class="col-sm-8 col-md-8">
          <v-card-title class="text-h5 lighten-2">
            Login
          </v-card-title>
          <v-card-text>
          <v-flex>
              <v-form
                  ref="form"
                  v-model="valid"
                  lazy-validation
              >

                <v-text-field
                      label="Username"
                      :rules="[v => !!v || 'Username is required']"
                      v-model="username"
                      required
                  ></v-text-field> 
                  <v-text-field
                      label="Password"
                      :rules="[v => !!v || 'Password is required']"
                      v-model="password"
                      required
                      :append-icon="show1 ? 'mdi-eye' : 'mdi-eye-off'"
                      :type="show1 ? 'text' : 'password'"
                      class="input-group--focused"
                      @click:append="show1 = !show1"
                  ></v-text-field> 
              </v-form>
          </v-flex>
          </v-card-text>
          <v-card-actions>
                      <v-spacer></v-spacer>
                      <v-btn color="primary" @click="login" tile >Login</v-btn>
                      <v-spacer></v-spacer>
          </v-card-actions>
        </v-card>
      </div>
    </v-row>
  </div>
</template>

<script>

export default ({
    data() {
        return {
            logo: require("../assets/logo.svg"),
            show1: false
        }
    },
    methods: {
        dashboard(){
            this.$router.push('/')
        },
      login(){
        this.$router.push({name: 'home'})
      },
    },
    mounted() {
      // if(this.$msal.isAuthenticated() == true){
      //   this.$router.push({ name: 'home' })      }
    },
})
</script>

