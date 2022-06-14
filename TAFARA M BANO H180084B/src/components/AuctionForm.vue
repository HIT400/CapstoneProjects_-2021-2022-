<template>
  <v-container style="margin-left:75px">
    <v-card class="">
      <v-card-title class="text-h5 lighten-2">
        Create Auction
      </v-card-title>
      <v-card-text>
      <v-flex>
          <v-form
              ref="form"
              v-model="valid"
              lazy-validation
          >

              <v-row>
                <v-col sm12 md12 xs12>
                  <v-text-field
                        label="Auction Title"
                        :rules="[v => !!v || 'Auction Title is required']"
                        v-model="testData.auctionTitle"
                        required
                    ></v-text-field> 
                </v-col>
              </v-row>
              <v-row>
                <v-col sm6 md6 xs12>
                  <v-select
                    v-model="testData.auctionType"
                    :items="auctionTypes"
                    item-text="name" 
                    item-value="id"
                    label="Type of Auction"
                    persistent-hint
                    ></v-select>
                </v-col>
                <v-col sm6 md6 xs12>
                  <v-text-field
                      label="Amount to be Auctioned"
                      :rules="[v => !!v || 'Amount to be auctioned (USD) is required']"
                      v-model="testData.rbzUSDBalance"
                      required
                  ></v-text-field> 
                </v-col>
              </v-row>
              <v-row>
                <v-col sm6 md6 xs12>
                    <v-menu
                        v-model="menu1"
                        :close-on-content-click="false"
                        :nudge-right="40"
                        transition="scale-transition"
                        offset-y
                        min-width="auto"
                    >
                        <template v-slot:activator="{ on, attrs }">
                        <v-text-field
                            @change="changeStartTime"
                            v-model="startDate"
                            label="Start Date"
                            prepend-icon="mdi-calendar"
                            readonly
                            v-bind="attrs"
                            v-on="on"
                        ></v-text-field>
                        </template>
                        <v-date-picker
                        v-model="startDate"
                        @input="menu1 = false"
                        ></v-date-picker>
                    </v-menu>        
                </v-col>
                <v-col sm6 md6 xs12>
                    <v-menu
                        ref="menu"
                        v-model="menu2"
                        :close-on-content-click="false"
                        :nudge-right="40"
                        :return-value.sync="time"
                        transition="scale-transition"
                        offset-y
                        max-width="290px"
                        min-width="290px"
                    >
                        <template v-slot:activator="{ on, attrs }">
                        <v-text-field
                            @change="changeStartTime"
                            v-model="startTime"
                            label="Start Time"
                            prepend-icon="mdi-clock-time-four-outline"
                            readonly
                            v-bind="attrs"
                            v-on="on"
                        ></v-text-field>
                        </template>
                        <v-time-picker
                          v-if="menu2"
                          v-model="startTime"
                          full-width
                          format="24hr"
                          @click:minute="$refs.menu.save(time)"
                        ></v-time-picker>
                    </v-menu>
                </v-col>
              </v-row>
              <v-row>
                <v-col sm6 md6 xs12>
                    <v-menu
                        v-model="menu3"
                        :close-on-content-click="false"
                        :nudge-right="40"
                        transition="scale-transition"
                        offset-y
                        min-width="auto"
                    >
                        <template v-slot:activator="{ on, attrs }">
                        <v-text-field
                            @change="changeEndTime"
                            v-model="endDate"
                            label="End Date"
                            prepend-icon="mdi-calendar"
                            readonly
                            v-bind="attrs"
                            v-on="on"
                        ></v-text-field>
                        </template>
                        <v-date-picker
                        v-model="endDate"
                        :min="startDate"
                        @input="menu3 = false"
                        ></v-date-picker>
                    </v-menu>        
                </v-col>
                <v-col sm6 md6 xs12>
                    <v-menu
                        ref="menu"
                        v-model="menu4"
                        :close-on-content-click="false"
                        :nudge-right="40"
                        :return-value.sync="time"
                        transition="scale-transition"
                        offset-y
                        max-width="290px"
                        min-width="290px"
                    >
                        <template v-slot:activator="{ on, attrs }">
                        <v-text-field
                            v-model="endTime"
                            @change="changeEndTime"
                            label="End Time"
                            prepend-icon="mdi-clock-time-four-outline"
                            readonly
                            v-bind="attrs"
                            v-on="on"
                        ></v-text-field>
                        </template>
                        <v-time-picker
                          v-if="menu4"
                          v-model="endTime"
                          full-width
                          format="24hr"
                          @click:minute="$refs.menu.save(time)"
                        ></v-time-picker>
                    </v-menu>
                </v-col>
              </v-row>
              <v-row>
                <v-col sm6 md6 xs12>
                  <v-text-field
                      label="Highest Bid Price"
                      :rules="[v => !!v || 'Highest Bid Price is required']"
                      v-model="testData.highestBidPrice"
                      required
                  ></v-text-field> 
                </v-col>
                <v-col sm6 md6 xs12>
                  <v-text-field
                      label="Lowest Bid Price"
                      :rules="[v => !!v || 'Lowest Bid Price is required']"
                      v-model="testData.lowestBidPrice"
                      required
                  ></v-text-field> 
                </v-col>
              </v-row>
          </v-form>
      </v-flex>
      </v-card-text>
      <v-card-actions>
        <v-spacer></v-spacer>
        <v-btn color="success" @click="submit" tile large block >Submit</v-btn>
        <v-spacer></v-spacer>
      </v-card-actions>
    </v-card>
  </v-container>
</template>


<script>


import FxAuction from '../abis/FXAuction.json'

export default ({
    data(){
      return {
        startTime: '',
        startDate: '',
        endTime: '',
        endDate: '',
        menu1: false,
        menu2: false,
        menu3: false,
        menu4: false,
        auctionTypes: [
          "MAIN AUCTION",
          "SME AUCTION"
        ],

       

        testData: {
          rbzUSDBalance: 0,
					auctionTitle: "",
					auctionType: "",
					startTime: '',
					endTime: '',
					highestBidPrice: 0,
					lowestBidPrice: 0
        },
        account:'',
        fxAuction:{},
        fxAuctionAddress:''

      }
    },

  created() {
    this.loadBlockchainData()
  },

    methods: {
   
      async loadBlockchainData() {
        const web3 = window.web3;

        const accounts = await web3.eth.getAccounts();
        console.log( accounts)

        const networkId = await web3.eth.net.getId();
        const fxAuctionData = await FxAuction.networks[networkId];


        const fxAuction = new web3.eth.Contract(FxAuction.abi, fxAuctionData.address);

        this.account = accounts[0];
        this.fxAuction = fxAuction;
        this.fxAuctionAddress= fxAuctionData.address;
      },

      changeStartTime(){
        if(this.startTime == '' || this.startDate == '') return null
        const [year, month, day] = this.startDate.split('-')
        const [hour, minutes] = this.startTime.split(':')
        let date =  new Date(parseInt(year), parseInt(month), parseInt(day), parseInt(hour), parseInt(minutes), 0, 0)
        this.testData.startTime = date.getTime()
      },
      changeEndTime(){
        if(this.endTime == '' || this.endDate == '') return null
        const [year, month, day] = this.endDate.split('-')
        const [hour, minutes] = this.endTime.split(':')
        let date =  new Date(parseInt(year), parseInt(month), parseInt(day), parseInt(hour), parseInt(minutes), 0, 0)
        this.testData.endTime = date.getTime()
      },
      async submit(){
        console.log("ACCOUNT------------>>>>>>>>>"+this.account)
        await this.fxAuction.methods.submitAuction(this.testData).send({from:this.account}).on('transactionHash', async (auctionSubmitHash) => {
            console.log("creating new auction "+auctionSubmitHash);
       },30000); },


    }
})
</script>