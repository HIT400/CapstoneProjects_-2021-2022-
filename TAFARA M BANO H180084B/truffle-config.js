require("dotenv").config();
const HDWalletProvider = require("@truffle/hdwallet-provider");
const privateKeys = process.env.PRIVATE_KEYS || "";

module.exports = {

  networks: {
    ganache_gui: {
      host: "127.0.0.1",
      port: 7545,
      network_id: "*"
    },
    ganache_cli: {
      host: "127.0.0.1",
      port: 8545,
      network_id: "*",
      gas: 5000000
    },

    rinkeby: {
      provider: function () {
        return new HDWalletProvider(
          privateKeys.split(","),
          `https://rinkeby.infura.io/v3/${process.env.INFURA_ID}`
        );
      },
      gas: 5000000,
      gasPrice: 5000000000, // 5 gwei
      network_id: 4,
      skipDryRun: true,
    },

  },
  // Set default mocha options here, use special reporters etc.
  mocha: {
    // timeout: 100000
  },

  contracts_directory: "./contracts/",
  contracts_build_directory: "./src/abis/",
  migrations_directory: "./migrations/",
  test_directory: "./test/",
  // Configure your compilers
  compilers: {
    solc: {
      version: "0.8.12",    // Fetch exact version from solc-bin (default: truffle's version)
      // docker: true,        // Use "0.5.1" you've installed locally with docker (default: false)
      settings: {          // See the solidity docs for advice about optimization and evmVersion
       optimizer: {
         enabled: true,
         runs: 200
       },
      //  evmVersion: "byzantium"
      }
    }
  },
};
