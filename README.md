# TDES DUKPT Tool
TDES DUKPT encryption, decryption, and key part utility for Windows.

Features:
* Data encryption and decryption.
* Key part/component XOR merging.

[Download the installer here!](https://github.com/rbonestell/TDESDUKPTTool/releases/download/1.0/SetupTDESDUKPTTool.msi)

### Resources
* [How To Decrypt Credit Card Data, Part I - IDTECH](https://idtechproducts.com/how-to-decrypt-credit-card-data-part-i/)
* [How To Decrypt Credit Card Data, Part II - IDTECH](https://idtechproducts.com/how-to-decrypt-credit-card-data-part-ii/)
* [How To Decrypt Magnetic Card Data With DUKPT - Parthenon Software Group, Travis Hoffman](https://www.parthenonsoftware.com/blog/how-to-decrypt-magnetic-stripe-scanner-data-with-dukpt/)
* [ANSI X9.24 - Retail Financial Services Set](https://webstore.ansi.org/Standards/ASCX9/ANSIX924RetailFinancial)
* [Dukpt.NET - Scott Batary (sgbj)](http://sgbj.github.io/Dukpt.NET/)
* [Derived unique key per transaction - Wikipedia](https://en.wikipedia.org/wiki/Derived_unique_key_per_transaction)

#### About the project
Visual Studio 2017 Solution

Setup project requires [Microsoft Visual Studio 2017 Installer Projects Plugin](https://marketplace.visualstudio.com/items?itemName=VisualStudioClient.MicrosoftVisualStudio2017InstallerProjects)

This project utilizes [Dukpt.NET by sgbj](https://github.com/sgbj/Dukpt.NET), modified to encrypt and decrypt utilizing a DEK mask for the session key.

## Contributing

1. Fork it!
2. Create your feature branch: `git checkout -b my-new-feature`
3. Commit your changes: `git commit -am 'Add some feature'`
4. Push to the branch: `git push origin my-new-feature`
5. [Submit a pull request!](https://github.com/rbonestell/TDESDUKPTTool/pull/new/master)
