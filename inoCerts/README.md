# inoCerts

inoCerts is a tool that enables an user to install easily certificates into the truststore of Windows and applications using a Mozilla truststores. Special features are to get certificates from WPIA [https://wpia.club](https://wpia.club) powered CA's and to install them to the truststores.

Certificates can currently be installed into these truststores:
* Windows Current User truststore
* Windows Clocal Computer truststore
* Firefox truststore
* PaleMoon truststore
* Thunderbird truststore

From these CA's powered by the World Privacy and Identity Association (WPIA) the root and intermediate certificates can be downloaded and installed and if a valid client certificate is present new certificates can be obtained:
* WPIA Interim CA [https://www.interimca-tc.xyz](https://www.interimca-tc.xyz)
* WPIA Test Server [https://www.test1.backup.dogcraft.de](https://www.test1.backup.dogcraft.de)

## Installation

## Usage
If certificates are should be installed into Windows Truststores the application must be run as administrator.

To generate new certificates from a WPIA CA the following preconditions are met:
* Root and intermediate certificates are installed to Windows Truststore
* A valid account on the CA
* A valid client certificate of the account



