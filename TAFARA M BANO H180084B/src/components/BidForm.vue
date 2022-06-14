<template>
  <v-container style="margin-left:75px">
    <v-card class="">
      <v-card-title class="text-h5 lighten-2">
        Submit Bid
      </v-card-title>
      <v-card-text>
      <v-flex>
          <v-form
              ref="form"
              v-model="valid"
              lazy-validation
          >

            <v-row>
              <v-col sm6 md6 xs12>

                <v-text-field
                      label="Applicant Name"
                      :rules="[v => !!v || 'Applicant Name is required']"
                      v-model="testData.applicantName"
                      required
                  ></v-text-field> 
              </v-col>
              <v-col sm6 md6 xs12>
                <v-select
                  v-model="search" 
                  :items="items"
                  item-value="id"
                  item-text="title"
                  label="Select Auction"
                  dense
                  solo
                  @change="getBids()"
                ></v-select>
              </v-col>
            </v-row>
            <v-row>
              <v-col sm6 md6 xs12>
                    <v-menu
                        v-model="dateOfIncorporationMenu"
                        :close-on-content-click="false"
                        :nudge-right="40"
                        transition="scale-transition"
                        offset-y
                        min-width="auto"
                    >
                        <template v-slot:activator="{ on, attrs }">
                        <v-text-field
                            v-model="testData.dateOfIncorporation"
                            label="Date Of Incorporation"
                            prepend-icon="mdi-calendar"
                            readonly
                            v-bind="attrs"
                            v-on="on"
                        ></v-text-field>
                        </template>
                        <v-date-picker
                        v-model="testData.dateOfIncorporation"
                        @input="dateOfIncorporationMenu = false"
                        ></v-date-picker>
                    </v-menu>     
              </v-col>
              <v-col sm6 md6 xs12>
                    <v-menu
                        v-model="tradingCommencementDateMenu"
                        :close-on-content-click="false"
                        :nudge-right="40"
                        transition="scale-transition"
                        offset-y
                        min-width="auto"
                    >
                        <template v-slot:activator="{ on, attrs }">
                        <v-text-field
                            v-model="testData.tradingCommencementDate"
                            label="Trading Commencement Date"
                            prepend-icon="mdi-calendar"
                            readonly
                            v-bind="attrs"
                            v-on="on"
                        ></v-text-field>
                        </template>
                        <v-date-picker
                        v-model="testData.tradingCommencementDate"
                        @input="tradingCommencementDateMenu = false"
                        ></v-date-picker>
                    </v-menu>     
              </v-col>
            </v-row>
            <v-row>
              <v-col sm6 md6 xs12>
                <v-text-field
                  label="Identification Number"
                  :rules="[v => !!v || 'Identification Number is required']"
                  v-model="testData.identificationNumber"
                  required
                ></v-text-field> 
              </v-col>
              <v-col sm6 md6 xs12>
                <v-select
                  v-model="testData.categoryOfBidder"
                  :items="categoriesOfBidders"
                  item-text="name" 
                  item-value="id"
                  label="Category Of Bidder"
                  persistent-hint
                  ></v-select>
              </v-col>
            </v-row>
            <v-row>
              <v-col sm6 md6 xs12>
                <v-textarea
                  label="Physical Address"
                  :rules="[v => !!v || 'Physical Address is required']"
                  v-model="testData.physicalAddress"
                  required
                ></v-textarea> 
              </v-col>
              <v-col sm6 md6 xs12>
               <v-text-field
                  label="Email Address"
                  :rules="[v => !!v || 'Email Address is required']"
                  v-model="testData.emailAddress"
                  required
                ></v-text-field> 
              </v-col>
            </v-row>

            <v-row>
              <v-col sm6 md6 xs12>
                <v-text-field
                  label="Contact Number"
                  :rules="[v => !!v || 'Contact Number is required']"
                  v-model="testData.contactNumber"
                  required
                ></v-text-field> 
              </v-col>
              <v-col sm6 md6 xs12>
                <v-select
                  v-model="testData.applicantBank"
                  :items="applicantBankList"
                  item-text="name" 
                  item-value="id"
                  label="Applicant Bank"
                  persistent-hint
                  ></v-select>
              </v-col>
            </v-row>
            <v-row>
              <v-col sm6 md6 xs12>
                <v-text-field
                  label="Auction Ref"
                  :rules="[v => !!v || 'Auction Ref is required']"
                  v-model="testData.auctionRef"
                  required
                ></v-text-field> 
              </v-col>
              <v-col sm6 md6 xs12>
                <v-text-field
                  label="Prior Exhange Control Number"
                  :rules="[v => !!v || 'Prior Exhange Control Number is required']"
                  v-model="testData.priorExhangeControlNumber"
                  required
                ></v-text-field> 
              </v-col>
            </v-row>
            <v-row>
              <v-col sm6 md6 xs12>
                <v-text-field
                  label="Date"
                  disabled
                  v-model="today"
                  required
                ></v-text-field> 
              </v-col>
              <v-col sm6 md6 xs12>
                <v-select
                  v-model="testData.economicSector"
                  :items="economicSectorList"
                  item-text="name" 
                  item-value="id"
                  label="Economic Sector"
                  persistent-hint
                  ></v-select>
              </v-col>
            </v-row>
            <v-row>
              <v-col sm6 md6 xs12>
                <v-select
                  v-model="testData.purposeOfFunds"
                  :items="purposeOfFundsList"
                  item-text="name" 
                  item-value="id"
                  label="Purpose Of Funds"
                  persistent-hint
                  ></v-select>
              </v-col>
              <v-col sm6 md6 xs12>
                <v-text-field
                  label="Description Of Goods"
                  :rules="[v => !!v || 'Description Of Goods is required']"
                  v-model="testData.descriptionOfGoods"
                  required
                ></v-text-field> 
              </v-col>
            </v-row>
            <v-row>
              <v-col sm6 md6 xs12>
                <v-text-field
                  label="Ultimate Beneficiary"
                  :rules="[v => !!v || 'Ultimate Beneficiary is required']"
                  v-model="testData.ultimateBeneficiary"
                  required
                ></v-text-field> 
              </v-col>
              <v-col sm6 md6 xs12>
                <v-text-field
                  @change="calculateEqv"
                  label="Bid Amount in USD"
                  :rules="[v => !!v || 'Bid Amount in USD is required']"
                  v-model="testData.bidAmountUSD"
                  required
                ></v-text-field> 
              </v-col>
            </v-row>
            <v-row>
              <v-col sm6 md6 xs12>
                <v-text-field
                  @change="calculateEqv"
                  label="Bid Exchange Rate"
                  :rules="[v => !!v || 'Bid Exchange Rate is required']"
                  v-model="testData.bidExchangeRate"
                  hint="h"
                  required
                ></v-text-field> 
              </v-col>
              <v-col sm6 md6 xs12>
                <v-text-field
                  label="ZWL Equivalent"
                  :rules="[v => !!v || 'ZWL Equivalent is required']"
                  v-model="testData.zwlEquivalent"
                  required
                  disabled
                ></v-text-field> 
    
              </v-col>
            </v-row>
            <v-row>
              <v-col sm6 md6 xs12>
                <v-text-field
                  label="Current Balance (ZWL)"
                  :rules="[v => !!v || 'Current Balance (ZWL) is required']"
                  v-model="testData.currentBalanceZWL"
                  required
                ></v-text-field> 
              </v-col>
              <v-col sm6 md6 xs12>
                <v-text-field
                  label="Current Nostro Balance (USD)"
                  :rules="[v => !!v || 'Current Nostro Balance (USD) is required']"
                  v-model="testData.currentNostroBalanceUSD"
                  required
                ></v-text-field> 
              </v-col>
            </v-row>
            <!-- <v-row>
              <v-col sm6 md6 xs12>
                <v-text-field
                  label="ZWL Account"
                  :rules="[v => !!v || 'ZWL Account is required']"
                  v-model="zwlAccount"
                  required
                ></v-text-field> 
              </v-col>
              <v-col sm6 md6 xs12>
                <v-text-field
                  label="USD Account"
                  :rules="[v => !!v || 'USD Account is required']"
                  v-model="usdAccount"
                  required
                ></v-text-field> 
              </v-col>
            </v-row> -->
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

import axios from 'axios'
import Vue from 'vue'
import VueAxios from'vue-axios'
Vue.use(VueAxios,axios)

import FxAuction from '../abis/FXAuction.json'

export default ({
    data(){
      return {
        search: '',
        accountList: [],
        dateOfIncorporationMenu: false,
        tradingCommencementDateMenu: false,
        auctionList: [],
        items: [],
        auctionListB: [],
        economicSectorList: [
          "AGRICULTURE-Forestry",
          "AGRICULTURE-Horticulture",
          "AGRICULTURE-Livestock and Game Farming",
          "AGRICULTURE-Fishery",
          "AGRICULTURE-General Agriculture",
          "MANUFACTURING-Manufacturing",
          "MANUFACTURING-Engineering",
          "MANUFACTURING-Motor Vehicle Assembly",
          "MANUFACTURING-Leather and Footwear",
          "MANUFACTURING-Clothing and Textiles",
          "MANUFACTURING-Food and Beverages",
          "MANUFACTURING-Paper and Packaging",
          "MANUFACTURING-Metals/Steel and Jewellery",
          "MANUFACTURING-Chemicals and Pharmaceuticals",
          "MANUFACTURING-Tobacco Processing",
          "MANUFACTURING-Timber and Wood",
          "MANUFACTURING-Electricals",
          "MANUFACTURING-General",
          "MINING-Precious Minerals",
          "MINING-Base Minerals",
          "MINING-Industrial Minerals",
          "RETAIL AND DISTRIBUTION",
          "INDIVIDUALS",
          "SERVICES-Transport & Storage",
          "SERVICES-Tourism",
          "SERVICES-Communication",
          "SERVICES-Finance and Insurance",
          "SERVICES-Information Technology",
          "SERVICES-Health and Education",
          "SERVICES-Energy",
          "SERVICES-Real Estate/Property",
          "SERVICES-Professional Scientific & Technical Activities",
          "SERVICES-Construction",
        ],

        purposeOfFundsList: [
          "CONSUMABLES (SPARE PARTS, TYRES, ELECTRICALS, ETC)",
          "ELECTRICITY",
          "FUEL",
          "GAS",
          "LUBRICANTS",
          "MACHINERY & EQUIPMENT",
          "PAPER & PACKAGING",
          "PHARMACEUTICALS & CHEMICALS",
          "RAW MATERIALS",
          "RETAIL & DISTRIBUTION (FOOD, BEVERAGES, ETC)",
          "SERVICES (INCL. LOANS, DIVIDENDS & DISINVESTMENTS)"
        ],
        categoriesOfBidders:[
          "PRIMARY",
          "SECONDARY - TRADER/AGENTS/COMMODITY BROKER",
          "SECONDARY - SERVICES",
          "SECONDARY - FINISHED GOODS",
          "SECONDARY - CONSUMABLES",
          "INDIVIDUAL"
        ],
        applicantBankList: [
          "ACL",
          "AGRIBANK",
          "BANC ABC",
          "BARCLAYS",
          "CABS",
          "CBZ",
          "ECOBANK",
          "EMPOWER BANK",
          "FBC",
          "GETBUCKS",
          "IDBZ",
          "LION MICROFINANCE",
          "MYCASH",
          "NEDBANK",
          "NBS",
          "NMB BANK",
          "POSB",
          "RESERVE BANK",
          "STANBIC BANK",
          "STANDARD CHARTED",
          "STEWARD BANK",
          "SUCCESS MICROFINANCE",
          "ZB BANK"
        ],
       
        today: new Date().toDateString(),
        testData: {
          fxBidFormListingId: 0,
          applicantName: "",
          auctionId: 0,
          dateOfIncorporation: "",
          tradingCommencementDate: "",
          identificationNumber: "",
          categoryOfBidder: "",
          physicalAddress: "",
          emailAddress: "",
          contactNumber: "",
          applicantBank: "",
          auctionRef: "",
          priorExhangeControlNumber: "",
          date: new Date().getTime(),

          economicSector: "",
          purposeOfFunds: "",
          descriptionOfGoods: "",
          ultimateBeneficiary: "",
          bidAmountUSD: 0,
          bidExchangeRate: 0,
          zwlEquivalent: 0,
          currentBalanceZWL: 0,
          currentNostroBalanceUSD: 89,

          allocatedAmountBlance: 0,
          allocationStatus: false
        },
        account:'',
        fxAuction:{},
        fxAuctionBids:[],
        bnkaccounts: [],
        fxAuctionAddress:''

      }
    },

  created() {
    this.loadBlockchainData()
  },
  mounted() {


    },
    methods: {

      calculateEqv(){
        this.testData.zwlEquivalent = this.testData.bidAmountUSD * this.testData.bidExchangeRate
      },
   
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


        this.auctionList = await this.fxAuction.methods.getAllAuctions().call(); 
        this.orderAuctionList()
        console.log(this.auctionList)



      },

      
      async orderAuctionList(){
        console.log("auction length ------------->>>>>>>>>>" + this.auctionList.length)
        for(let i = 0; i < this.auctionList.length; i++){ 
          this.auctionListB[i] = {
              'title': this.auctionList[i].auctionTitle + " " + this.auctionList[i].auctionType ,
              'id': this.auctionList[i].auctionId
          }
          console.log("item number "+ i + "   "+this.auctionListB[i])
          this.items = this.auctionListB
        }
      },


      handleResponse(response){
        return response.text().then(text => {
          const data = text && JSON.parse(text);
          console.log("DATA: " + data)
          if(!response.ok){
            if(response.status === 401){
              console.log("Session Expired")
            }
            if(response.status === 400){
              console.log("Bad Request")

            }
            else{
              console.log("Bad Request else")
              return data;

            }
          }
          return data;
        })
      },

      async submit(){

        console.log("ACCOUNT------------>>>>>>>>>"+this.account)
        this.testData.auctionId = parseInt(this.search)
        await this.fxAuction.methods.submitBid(this.testData).send({from:this.account}).on('transactionHash', async (bidSubmitHash) => {
            console.log("submitting new bid  "+bidSubmitHash);
        },30000); 
      },

    }
})
</script>