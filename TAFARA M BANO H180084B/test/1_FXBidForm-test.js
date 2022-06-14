var FXAuction = artifacts.require("./FxAuction.sol");

contract('FXAuction', function(accounts) {
	it('Should be able to create an auction', async () => {
		await FXAuction.deployed().then(async function(fxAuction) {
			await fxAuction.submitAuction(
				{
					rbzUSDBalance: 100,
					auctionTitle: "2022 April 29 SME Auction",
					auctionType: "SME AUCTION",
					startTime: 2387943850,
					endTime: 2387943850,
					highestBidPrice: 390,
					lowestBidPrice: 110
				}
			)

			await fxAuction.submitAuction(
				{
					rbzUSDBalance: 100,
					auctionTitle: "2022 April 29 SME Auction",
					auctionType: "MAIN AUCTION",
					startTime: 2387943850,
					endTime: 2387943850,
					highestBidPrice: 390,
					lowestBidPrice: 110
				}
			)

			await fxAuction.submitAuction(
				{
					rbzUSDBalance: 100,
					auctionTitle: "2022 April 29 SME Auction",
					auctionType: "SME AUCTION",
					startTime: 2387943850,
					endTime: 2387943850,
					highestBidPrice: 390,
					lowestBidPrice: 110
				}
			)
				let items = await fxAuction.getAllAuctionsCount();

				let itemsList = await fxAuction.getAllAuctions();
				console.log(itemsList)
				assert.equal(items, 1);
			});
	 
	})

	it('Should be able to add a bid', async () => {
		await FXAuction.deployed().then(async function(fxBidForm) {
			await fxBidForm.submitBid(
				{
					fxBidFormListingId: 0,
					auctionId: 0,
					applicantName: "Tafara Mbano 1",
					dateOfIncorporation: "22/01/1994",
					tradingCommencementDate: "05/03/1994",
					identificationNumber: "0497985480",
					categoryOfBidder: "PRIMARY",
					physicalAddress: "6020 Westlea",
					emailAddress: "tmmmbano@gmail.com",
					contactNumber: "0783461408",
					applicantBank: "NMB Bank",
					auctionRef: "378473",
					priorExhangeControlNumber: "N/A",
					date: 1646379440,
			
					economicSector: "Manufacturing",
					purposeOfFunds: "Raw Materials",
					descriptionOfGoods: "Iron ore",
					ultimateBeneficiary: "Zimbabwe",
					bidAmountUSD: 10,
					bidExchangeRate: 124,
					zwlEquivalent: 1240,
					currentBalanceZWL: 1020293944,
					currentNostroBalanceUSD: 9,

					allocatedAmountBlance: 0,
					allocationStatus: false
				}
			)
				let items = await fxBidForm.getAllPrimaryBids(0);
				assert.equal(items.length, 1);
			});
	
	})

		// Test for fetchng details of an Eastate Property by propertyListingId 
		it('Should be able to get all submitted bids',  async () => {
			await FXAuction.deployed().then(async function(fxBidForm) {	
				let bids = await fxBidForm.getAllPrimaryBids(0);
	
				assert.equal(bids.length, 1);

				// Fetches the details of first marketplace item by its propertyListingId
				await fxBidForm.submitBid(
					{
						fxBidFormListingId: 0,
						auctionId: 0,
						applicantName: "Tafara Mbano 2",
						dateOfIncorporation: "22/01/1994",
						tradingCommencementDate: "05/03/1994",
						identificationNumber: "0497985480",
						categoryOfBidder: "PRIMARY",
						physicalAddress: "6020 Westlea",
						emailAddress: "tmmmbano@gmail.com",
						contactNumber: "0783461408",
						applicantBank: "NMB Bank",
						auctionRef: "378473",
						priorExhangeControlNumber: "N/A",
						date: 1646379440,
				
						economicSector: "Manufacturing",
						purposeOfFunds: "Raw Materials",
						descriptionOfGoods: "Iron ore",
						ultimateBeneficiary: "Zimbabwe",
						bidAmountUSD: 17,
						bidExchangeRate: 125,
						zwlEquivalent: 1250,
						currentBalanceZWL: 1020293944,
						currentNostroBalanceUSD: 9,
	
						allocatedAmountBlance: 0,
						allocationStatus: false
					}
				)
				await fxBidForm.submitBid(
					{
						fxBidFormListingId: 0,
						auctionId: 0,
						applicantName: "Tafara Mbano 3",
						dateOfIncorporation: "22/01/1994",
						tradingCommencementDate: "05/03/1994",
						identificationNumber: "0497985480",
						categoryOfBidder: "PRIMARY",
						physicalAddress: "6020 Westlea",
						emailAddress: "tmmmbano@gmail.com",
						contactNumber: "0783461408",
						applicantBank: "NMB Bank",
						auctionRef: "378473",
						priorExhangeControlNumber: "N/A",
						date: 1646379440,
				
						economicSector: "Manufacturing",
						purposeOfFunds: "Raw Materials",
						descriptionOfGoods: "Iron ore",
						ultimateBeneficiary: "Zimbabwe",
						bidAmountUSD: 10,
						bidExchangeRate: 128,
						zwlEquivalent: 1280,
						currentBalanceZWL: 1020293944,
						currentNostroBalanceUSD: 9,
	
						allocatedAmountBlance: 0,
						allocationStatus: false
					}
				)
				await fxBidForm.submitBid(
					{
						fxBidFormListingId: 0,
						auctionId: 0,
						applicantName: "Tafara Mbano 4",
						dateOfIncorporation: "22/01/1994",
						tradingCommencementDate: "05/03/1994",
						identificationNumber: "0497985480",
						categoryOfBidder: "PRIMARY",
						physicalAddress: "6020 Westlea",
						emailAddress: "tmmmbano@gmail.com",
						contactNumber: "0783461408",
						applicantBank: "NMB Bank",
						auctionRef: "378473",
						priorExhangeControlNumber: "N/A",
						date: 1646379440,
				
						economicSector: "Manufacturing",
						purposeOfFunds: "Raw Materials",
						descriptionOfGoods: "Iron ore",
						ultimateBeneficiary: "Zimbabwe",
						bidAmountUSD: 10,
						bidExchangeRate: 134,
						zwlEquivalent: 1340,
						currentBalanceZWL: 1020293944,
						currentNostroBalanceUSD: 9,
	
						allocatedAmountBlance: 0,
						allocationStatus: false
					}
				)

				bids = await fxBidForm.getAllPrimaryBids(0);
				assert.equal(bids.length, 4);
	
			});
		})

		it('Should be able to get a submitted bid by id',  async () => {
			await FXAuction.deployed().then(async function(fxBidForm) {
			
				let bid = await fxBidForm.findPrimaryBidById(1, 0);
				console.log("---------------------BID------------->>>>>>>>>>>>>"+bid)
				assert.equal(bid.bidAmountUSD,"17");
			});
		})

	// Test for creation and sale of an Eastate Property
	// it('Should be able to sort the bids by exchange rate',  async () => {
	// 	await FXAuction.deployed().then(async function(fxBidForm) {
	// 		await fxBidForm.submitBid(
	// 			{
	// 				fxBidFormListingId: 0,
	// 				applicantName: "Tafara Mbano 4",
	// 				dateOfIncorporation: "22/01/1994",
	// 				tradingCommencementDate: "05/03/1994",
	// 				identificationNumber: "0497985480",
	// 				categoryOfBidder: "PRIMARY",
	// 				physicalAddress: "6020 Westlea",
	// 				emailAddress: "tmmmbano@gmail.com",
	// 				contactNumber: "0783461408",
	// 				applicantBank: "NMB Bank",
	// 				auctionRef: "378473",
	// 				priorExhangeControlNumber: "N/A",
	// 				date: 1646379440,
			
	// 				economicSector: "Manufacturing",
	// 				purposeOfFunds: "Raw Materials",
	// 				descriptionOfGoods: "Iron ore",
	// 				ultimateBeneficiary: "Zimbabwe",
	// 				bidAmountUSD: 20,
	// 				bidExchangeRate: 180,
	// 				zwlEquivalent: 3600,
	// 				currentBalanceZWL: 1020293944,
	// 				currentNostroBalanceUSD: 809,

	// 				allocatedAmountBlance: 0,
	// 				allocationStatus: false
	// 			}
	// 		)

	// 		let sortedBids = await fxBidForm.sortBids();
	// 		console.log("-----------------SORTED BIDS--------------")
	// 		console.log(sortedBids)
	// 		assert.equal(sortedBids[0].exchangeRate, 124);
	// 		assert.equal(sortedBids[3].exchangeRate, 134);
	
	// 	});
	// })

	// it('Should be able to allocate funds',  async () => {
	// 	await FXAuction.deployed().then(async function(fxBidForm) {
		
	// 		let sortedBids = await fxBidForm.sortBids();
	// 		await fxBidForm.allocateFunds(sortedBids);

	// 		sortedBids = await fxBidForm.sortBids();
	// 		console.log(sortedBids);

	// 		let bid = await fxBidForm.findPrimaryBidById(0);
	// 		assert.equal(bid.allocationStatus,false);

	// 		let lastBid = await fxBidForm.findPrimaryBidById(4);
	// 		assert.equal(lastBid.allocationStatus,true);
	
	// 	});
	// })

})