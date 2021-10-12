# Storage

## Types of Data

### Structured Data

- realational Data
- shared schema
- all data same format

- easy querieable by SQL
- best suited for:
  - CRM, reservations, inventory management

### Semi-Structured Data

- less organized
- not stored in relational format
- tags organise and rank them in hierarchy
  - ex: Key/Value-Pairs
- strucure by **serialization language**

- easy to convert from meory to file, send to other system, and paresed back to memory
- no details about the systems needed, except the serialization standard

- Common Languages:
  - **XML**:
    - first data language
    - support by almost every programming language
    - allows relations
    - structure by tags
    - supports standard schemas (like html)
    - flexible for complex data expression
    - verbose representation, by tags for the structure
      - large files
  - **JSON**:
    - lightweigt specifification
    - less verbose
    - structure by `{`
    - easy human readable
      - but programmer oriented
    - more like key/vaule pairs
  - **YAML**
    - human-friendly
    - structure by line seperation and indentation
    - weakest support by languages
    - from human to machiene

### Unstructured Data
- files
  - like: video, photo, documents (word), text files, etc.


## Who is data used?
- Will you be doing simple lookups using an ID?
- Do you need to query the database for one or more fields?
- How many create, update, and delete operations do you expect?
- Do you need to run complex analytical queries?
- How quickly do these operations need to complete?

## Transaction
- logical group of database operations
- Will a change to one piece of data in your dataset impact another? => need transactions
- ACID:
  - **A**tomicity means a transaction must execute exactly once and must be atomic; either all of the work is done, or none of it is. Operations within a transaction usually share a common intent and are interdependent.
  - **C**onsistency ensures that the data is consistent both before and after the transaction.
  - **I**solation ensures that one transaction is not impacted by another transaction.
  - **D**urability means that the changes made due to the transaction are permanently saved in the system. Committed data is saved by the system so that even in the event of a failure and system restart, the data is available in its correct state.

### Types of transactional Databases

#### OLTP 
- Online Transaction Processing
- a lot of users
- quick response times
- large volumes of data
- highly available
- small/simple transactions

#### OLAP
- Online Analytical Processing
- fewer users
- longer response times
- can be less available
- large and complex transactions


## Azure Storage Solutions

### Azure Cosmos DB
- semi-structured data (NoSQL data)
- SQL for queries 
- every property indexed by default
- ACID-compliant
- easy replication
- 5 consistency levels

### Azure Blob storage
- unstructured Data
- default CDN for most used Data
- 