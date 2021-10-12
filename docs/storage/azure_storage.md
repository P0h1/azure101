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