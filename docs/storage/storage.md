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
    - structure by `777777qqqqqqq`
    - easy human readable
      - but programmer oriented
    - more like key/vaule pairs
  - **YAML**
    - human-friendly
    - 