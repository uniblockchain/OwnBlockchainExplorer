# Own Blockchain Explorer

Own Blockchain Explorer backend (scanner and API)


## Quick Start

- Clone the repository:
    ```bash
    $ git clone https://github.com/OwnMarket/OwnBlockchainExplorer.git OwnBlockchainExplorer
    $ cd OwnBlockchainExplorer
    ```
- Prepare a DB (assumes PostgreSQL installed):
    ```bash
    $ psql -f Dev/reset_db.sql
    ```
- Start API:
    ```bash
    $ cd Source/Own.BlockchainExplorer.Api
    $ dotnet run
    ```
