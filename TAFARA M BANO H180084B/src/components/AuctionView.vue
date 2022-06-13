<template>
  <v-container style="margin-left:100px">

    <v-flex sm12 md12 >

      <v-row>
        <v-card>
          <v-card-title>
            Auction List
          </v-card-title>
              <v-select style="margin:10px"
                v-model="search" 
                :items="items"
                item-value="id"
                item-text="title"
                label="Select Auction"
                dense
                solo
                @change="getBids()"
              ></v-select>
              <v-card
                style="margin:10px; padding: 10px">
              <v-row>
                <v-col sm6 md6 xs12>
                  <v-text-field
                    label="Type of Auction"
                    v-model="this.selectedAuction.auctionType"
                    disabled>
                  </v-text-field>
                </v-col>
                <v-col sm6 md6 xs12>
                  <v-text-field
                    label="Amount"
                    v-model="this.selectedAuction.rbzUSDBalance"
                    disabled>
                  </v-text-field>
                </v-col>
              </v-row>
              <v-row>
                <v-col sm6 md6 xs12>
                  <v-text-field
                    label="Start Date and Time"
                    v-model="this.start"
                    disabled>
                  </v-text-field>
                </v-col>
                <v-col sm6 md6 xs12>
                  <v-text-field
                    label="End Date and Time"
                    v-model="this.end"
                    disabled>
                  </v-text-field>
                </v-col>
              </v-row>
              <v-row>
                <v-col sm6 md6 xs12>
                  <v-text-field
                    label="Highest Bid Price"
                    v-model="this.selectedAuction.highestBidPrice"
                    disabled>
                  </v-text-field>
                </v-col>
                <v-col sm6 md6 xs12>
                  <v-text-field
                    label="Lowest Bid Price"
                    v-model="this.selectedAuction.lowestBidPrice"
                    disabled>
                  </v-text-field>
                </v-col>
              </v-row>


              <v-card-actions v-if="getRole() == 'rbz_admin'">
                
                <v-btn
                  color="success"
                  style="margin-bottom: 10px"
                  large
                  block
                  @click="endAuction()" tile>
                  End Auction
                </v-btn>
              </v-card-actions>
              </v-card><v-spacer></v-spacer>
          <v-data-table 
              :headers="headers"
              :items="bidsList"
              :items-per-page="5"
              :search="search"
              class="elevation-1"
          >
          </v-data-table>
        </v-card>
      </v-row>

      <v-dialog
          v-model="showAddExaminations"
          width="500"
      >

      </v-dialog>

    </v-flex>
  </v-container>
</template>

<script>
import FxAuction from '../abis/FXAuction.json'

  export default {
    data () {
      return {
        start: '',
        end: '',
        account:'',
        fxAuction:{},
        fxAuctionAddress:'',
        bidsList: [],
        auctionList: [],
        auctionListB: [],
        items: [
        ],
        showAddExaminations: false,
        selectedAuction: {},
        search: '',
        headers: [
          // {
          //   text: 'ID',
          //   align: 'start',
          //   sortable: true,
          //   value: 'fxBidFormListingId',
          // }, {
          //   text: 'Auction ID',
          //   align: 'start',
          //   sortable: true,
          //   value: 'auctionId',
          // }, 
          {
            text: 'Full Name',
            align: 'start',
            sortable: true,
            value: 'applicantName',
          }, {
            text: 'Date Of Incorporation',
            align: 'start',
            sortable: true,
            value: 'dateOfIncorporation',
          },{
            text: 'Trading Commencement Date',
            align: 'start',
            sortable: true,
            value: 'tradingCommencementDate',
          },{
            text: 'ID Number',
            align: 'start',
            sortable: true,
            value: 'identificationNumber',
          }, {
            text: 'Category Of Bidder',
            align: 'start',
            sortable: true,
            value: 'categoryOfBidder',
          },{
            text: 'Physical Address',
            align: 'start',
            sortable: true,
            value: 'physicalAddress',
          },{
            text: 'Email Address',
            align: 'start',
            sortable: true,
            value: 'emailAddress',
          },{
            text: 'Contact Number',
            align: 'start',
            sortable: true,
            value: 'contactNumber',
          },{
            text: 'Applicant Bank',
            align: 'start',
            sortable: true,
            value: 'applicantBank',
          },{
            text: 'Auction Ref',
            align: 'start',
            sortable: true,
            value: 'auctionRef',
          },{
            text: 'Prior Exhange Control Number',
            align: 'start',
            sortable: true,
            value: 'priorExhangeControlNumber',
          },{
            text: 'Date',
            align: 'start',
            sortable: true,
            value: 'date',
          },{
            text: 'Economic Sector',
            align: 'start',
            sortable: true,
            value: 'economicSector',
          },{
            text: 'Purpose Of Funds',
            align: 'start',
            sortable: true,
            value: 'purposeOfFunds',
          },{
            text: 'Description Of Goods',
            align: 'start',
            sortable: true,
            value: 'descriptionOfGoods',
          },{
            text: 'Ultimate Beneficiary',
            align: 'start',
            sortable: true,
            value: 'ultimateBeneficiary',
          },{
            text: 'Bid Amount USD',
            align: 'start',
            sortable: true,
            value: 'bidAmountUSD',
          },{
            text: 'Bid Exchange Rate',
            align: 'start',
            sortable: true,
            value: 'bidExchangeRate',
          },{
            text: 'ZWL Equivalent',
            align: 'start',
            sortable: true,
            value: 'zwlEquivalent',
          },{
            text: 'Current Balance ZWL',
            align: 'start',
            sortable: true,
            value: 'currentBalanceZWL',
          },{
            text: 'Current Nostro Balance USD',
            align: 'start',
            sortable: true,
            value: 'currentNostroBalanceUSD',
          },{
            text: 'Allocated Amount Balance',
            align: 'start',
            sortable: true,
            value: 'allocatedAmountBlance',
          },{
            text: 'Allocation Status',
            align: 'start',
            sortable: true,
            value: 'allocationStatus',
          },{ text: 'Actions',
            value: 'actions',
            sortable: false
          },
        ]

      };
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

        
        console.log("ACCOUNT------------>>>>>>>>>"+this.account)
        this.auctionList = await this.fxAuction.methods.getAllAuctions().call(); 
        this.orderAuctionList()
        console.log(this.auctionList)
        // await this.getBids();
      },
      async getBids(){
        console.log("GET BIDS ------------ ON CHANGED with id " + this.search)
        console.log("ACCOUNT------------>>>>>>>>>"+this.account)
        this.bidsList = await this.fxAuction.methods.getAllPrimaryBids(parseInt(this.search)).call();
        this.auctionList.find((o, i) => {
          if(o.auctionId == this.search){
            this.selectedAuction = this.auctionList[i]
          }
        });
        this.start = new Date(this.selectedAuction.startTime*1)
        this.end = new Date(this.selectedAuction.endTime*1)
        console.log(this.bidsList)

      },
      
    getRole(){
        if(this.$auth.user.email == 'tmmmbano@gmail.com'){
          return 'rbz_admin'
        }
        else{
          return 'authorised_dealer'
        }
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

      async endAuction(){

            //Move These lines to close autciton trigger
            const sortedBids = this.sortBids(this.bidsList);
            await this.alocateFunds(sortedBids);
            //END OF LINES
      },

      sortBids (bids){
        return bids.slice().sort(function(a, b){
          return (a.bidExchangeRate < b.bidExchangeRate) ? -1 : 1;
        });
      },

      async alocateFunds (sortedBids){
        await this.fxAuction.methods.allocateFunds(sortedBids).send({from:this.account}).on('transactionHash', async (fundsAllocationHash) => {
          console.log("allocating funds "+fundsAllocationHash);
        },30000);
      },

    },

    created() {
      this.loadBlockchainData()
    },
  }
</script>