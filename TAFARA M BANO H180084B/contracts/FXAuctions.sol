// // SPDX-License-Identifier: MIT
// pragma solidity ^0.8.12;

// // import "./ERC20.sol";

// contract FXAuctions {
//   // mapping (uint => FXBidForm) private primaryBids;
//   // mapping (uint => FXBidForm) private secondaryTraders;
//   // mapping (uint => FXBidForm) private secondaryServices;
//   // mapping (uint => FXBidForm) private secondaryFinished;
//   // mapping (uint => FXBidForm) private secondaryConsumables;
//   // mapping (uint => FXBidForm) private individuals;
//   mapping (uint => uint) _bidAmount;
//   FXBidForm[] private primaryBids;
//   FXBidForm[] private sortedPrimaryBids;
//   FXBidForm[] private secondaryTraders;
//   FXBidForm[] private secondaryServices;
//   FXBidForm[] private secondaryFinished;
//   FXBidForm[] private secondaryConsumables;
//   FXBidForm[] private individuals;

//   uint  head;
//   uint  ind;
//   uint  public found;

//   uint public primaryCount = 0;
//   uint public secondaryTradersCount = 0;
//   uint public secondaryServicesCount = 0;
//   uint public secondaryFinishedCount = 0;
//   uint public secondaryConsumablesCount = 0;
//   uint public individualsCount = 0;


//   uint public numberOfAuctioneers = 0;
//   mapping (uint => FXBidForm) private bids;
//   // FXBidForm[] private bids;
//   uint totalAuctionAmountUSD;
//   uint bidSubmitionCloseTime;
//   uint highestBidPrice;
//   uint lowestBidPrice;
//   address owner;

//     struct FXBidForm {
//         uint _id;
//         string _applicantName;
//         string _dateOfIncorporation;
//         string _tradingCommencementDate;
//         string _identificationNumber;
//         string _categoryOfBidder; //Category
//         string _physicalAddress;
//         string _emailAddress;
//         string _contactNumber;
//         string _applicantBank;
//         string _auctionRef;
//         string _priorExhangeControlNumber;
//         uint _date;


//         string _economicSector;
//         string _purposeOfFunds;
//         string _descriptionOfGoods;
//         string _ultimateBeneficiary;
//         uint _bidAmountUSD;
//         uint _bidExchangeRate;
//         uint _zwlEquivalent;
//         uint _currentBalanceZWL;
//         uint _currentNostroBalanceUSD;

//     }

//     mapping(address=>uint) bidBalance;
//     mapping(address=>FXBidForm) bidInfor;

//     modifier onlyWhileOpen(){
//         require(bidSubmitionCloseTime <= block.timestamp);
//         _;
//     } 

//     constructor (uint _totalAuctionAmountUSD, uint _bidSubmitionCloseTime, uint _highestBidPrice, uint _lowestBidPrice) {
//         totalAuctionAmountUSD = _totalAuctionAmountUSD;
//         bidSubmitionCloseTime = _bidSubmitionCloseTime;
//         highestBidPrice = _highestBidPrice;
//         lowestBidPrice = _lowestBidPrice;
//         bidBalance[msg.sender] = _totalAuctionAmountUSD;

//     }

//     function getAvailableBidBalance() external view  returns (uint) {
//       return bidBalance[msg.sender];
//     }

//     function getNumberOfBidders() external view returns (uint){
//       return primaryCount;
//     }

//     function getPrimaryBids(uint id) external view returns(FXBidForm memory) {
//       require(primaryBids.length > 0, " bids empty");
//       return primaryBids[id];
//     }


//     function getSortedPrimaryBids(uint id) external view returns(FXBidForm memory) {
//       // require(sortedPrimaryBids.length > 0, "Sorted bids empty");
//       // return sortedPrimaryBids[id];
//       return quickSortOffersBidsPrice(primaryBids, true)[id];
//     }
//     function submitBid(FXBidForm memory _fixBiForm) external onlyWhileOpen {
//       require(_fixBiForm._bidExchangeRate >= lowestBidPrice, "Price below starting price");    
//       require(_fixBiForm._bidExchangeRate <= highestBidPrice, "Price above highest price");
//       require(_fixBiForm._zwlEquivalent <= _fixBiForm._currentBalanceZWL, "Insufficient funds in bank account");     
//       require(_fixBiForm._bidAmountUSD >= _fixBiForm._currentNostroBalanceUSD, "Bidder has sufficient USD in nostro accounts");  
//       require(_fixBiForm._bidAmountUSD >= 2500
//               && _fixBiForm._bidAmountUSD <= 500000
//               && !((20000 < _fixBiForm._bidAmountUSD) && (_fixBiForm._bidAmountUSD < 50000)), "Bidder has sufficient USD in nostro accounts");  


//       if(keccak256(abi.encodePacked((_fixBiForm._categoryOfBidder))) == keccak256(abi.encodePacked(("PRIMARY")))){
//         _fixBiForm._id = primaryCount;
//         // primaryBids[primaryCount++] = _fixBiForm;
//         primaryBids.push(_fixBiForm);
//         primaryCount++;
//       }
//       else if (keccak256(abi.encodePacked((_fixBiForm._categoryOfBidder))) == keccak256(abi.encodePacked(("SECONDARY - TRADER/AGENTS/COMMODITY BROKER")))){
//         _fixBiForm._id = secondaryTradersCount;
//         // secondaryTraders[secondaryTradersCount++] = _fixBiForm;
//         secondaryTraders.push(_fixBiForm);
//         secondaryTradersCount++;
//       }
//       else if (keccak256(abi.encodePacked((_fixBiForm._categoryOfBidder))) == keccak256(abi.encodePacked(("SECONDARY - SERVICES")))){
//         _fixBiForm._id = secondaryServicesCount;
//         // secondaryServices[secondaryServicesCount++] = _fixBiForm;
//         secondaryServices.push(_fixBiForm);
//         secondaryServicesCount++;
//       }
//       else if (keccak256(abi.encodePacked((_fixBiForm._categoryOfBidder))) == keccak256(abi.encodePacked(("SECONDARY - FINISHED GOODS")))){
//         _fixBiForm._id = secondaryFinishedCount;
//         // secondaryFinished[secondaryFinishedCount++] = _fixBiForm;
//         secondaryFinished.push(_fixBiForm);
//         secondaryFinishedCount++;
//       }
//       else if (keccak256(abi.encodePacked((_fixBiForm._categoryOfBidder))) == keccak256(abi.encodePacked(("SECONDARY - CONSUMABLES")))){
//         _fixBiForm._id = secondaryConsumablesCount;
//         // secondaryConsumables[secondaryConsumablesCount++] = _fixBiForm;
//         secondaryConsumables.push(_fixBiForm);
//         secondaryConsumablesCount++;
//       }
//       else if (keccak256(abi.encodePacked((_fixBiForm._categoryOfBidder))) == keccak256(abi.encodePacked(("INDIVIDUAL")))){
//         _fixBiForm._id = individualsCount;
//         // individuals[individualsCount++] = _fixBiForm;
//         individuals.push(_fixBiForm);
//         individualsCount++;
//       }
//     }


//     function incrementCount() internal{
//         numberOfAuctioneers++;
//    }

//    function selectWinningBid() external {

//       FXBidForm[] memory f = quickSortOffersBidsPrice(primaryBids, true);

//         for (uint z = 0; z < f.length; z++) {
//           sortedPrimaryBids.push(f[z]);
//         }  

//    }

//   function quickSortOffersBidsPrice(FXBidForm[] memory arr, bool ascending) public pure returns(FXBidForm[] memory) {
//         if(arr.length == 0) return arr;
//         uint[] memory prices = arr_of_prices_offerbids(arr);
//         FXBidForm[] memory sorted = get_indices_and_sort(prices,arr,ascending);
//         return sorted;
//     }

//     function get_indices_and_sort(uint[] memory values, FXBidForm[] memory offers_bids, bool ascending) private pure returns(FXBidForm[] memory) {
//         uint[] memory indices = new uint[](values.length);
//         for (uint z = 0; z < indices.length; z++) {
//             indices[z] = z;
//         }
//         quickSort_indices(values, 0, int(values.length-1), indices);
//         // if(!ascending){
//         //     indices = reverseArray(indices);
//         // }
//         FXBidForm[] memory sorted = new FXBidForm[](values.length);
//         for (uint z = 0; z < indices.length; z++) {
//             sorted[z] = offers_bids[indices[z]];
//         }
//         return sorted;
//     }


//     function quickSort_indices(uint[] memory arr, int left, int right, uint[] memory indices) public pure {
//         int i = left;
//         int j = right;
//         if (i == j) return;

//         uint pivot = arr[uint(left + (right - left) / 2)];

//         while (i <= j) {
//             while (arr[uint(i)] < pivot) i++;
//             while (pivot < arr[uint(j)]) j--;
//             if (i <= j) {
//                 (arr[uint(i)], arr[uint(j)]) = (arr[uint(j)], arr[uint(i)]);
//                 (indices[uint(i)], indices[uint(j)]) = (indices[uint(j)], indices[uint(i)]);
//                 i++;
//                 j--;
//             }
//         }
//         if (left < j)
//             quickSort_indices(arr, left, j, indices);
//         if (i < right)
//             quickSort_indices(arr, i, right, indices);
//     }

//   function arr_of_prices_offerbids(FXBidForm[] memory arr) public pure returns(uint[] memory){
//     uint[] memory arrPrices;
//     for (uint z = 0; z < arr.length; z++) {
//         arrPrices[z] = arr[z]._bidExchangeRate;
//     }  
//     require(arrPrices.length > 0 , "arrPrices < 0");
//     return arrPrices;
//   }

// }