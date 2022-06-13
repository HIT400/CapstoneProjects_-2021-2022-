const FxAuction = artifacts.require("./FxAuction.sol");

module.exports = function (deployer) {
  deployer.deploy(FxAuction);
};
