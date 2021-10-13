# Azure Storage

![Azure Storage Image](./img/azure-storage.png)

- Azure Storage Services: 
  - Azure Blobs
  - Azure Files
  - Azure Queues
  - Azure Tables

-  primitive, cloud-based storage

## Storage Account
- container which groups this services together
- managed as a group
- included in **resource group**
- defined policy which is applied to all resoruces in that account

### Account kind
- StorageV2 (general purpose v2): current offering supports all storage types and all of the latest features
- Storage (general purpose v1): a legacy kind that supports all storage types but may not support all features
- Blob storage: a legacy kind that allows only block blobs and append blobs

## Properties of Azure Storage
| Property | Explanation |
| --- | --- |
| Managed | managing maintenance and any critical problems |
|Durable |	Redundancy ensures that your data is safe in the event of transient hardware failures. You can also replicate data across datacenters or geographical regions for extra protection from local catastrophe or natural disaster. Data replicated in this way remains highly available in the event of an unexpected outage. |
| Secure |	All data written to Azure Storage is encrypted by the service. Azure Storage provides you with fine-grained control over who has access to your data. |
| Scalable |	Azure Storage is designed to be massively scalable to meet the data storage and performance needs of today's applications. |

## Types

### Blobs 
- scalabe object store for text and binary
- optimized for massiv amounts of unstructured data
- serving images and docuemnts fpr websites
- distributed file access
- streaming
- backups

#### Blob Types: 
##### Block Blob:
  - files that read from start to end (like web content)
  - files split into 100 MB Blocks (max 50 000 blocks)
    - consolidate after upload to on final block
##### Page Blobs:
  - random access files (up to 8 TB)
  - backup for VHDs
  - random access read/write to 512 byte pages
##### Append blobs:
  - up to 195 GB
  - optimized for appending files
    - like trace, log
    - multiply writers

### Files
- highly available  network file share
- accessed by smb or rest
- unique file URLs
- access controll over any file
- usage:
  - shared configs for Vms, tools
  - log files, metrics, crash dump
  - shared data between On-Premise and Azure

### Queue
- message queue
- size up 64 KB

