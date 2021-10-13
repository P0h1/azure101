# CLI 

## Create Storage Account

`az storage account create --name <name> --resource-group <rg> --location <server-location> --sku <account-type>`

- **name**: 3-24 lowercase characters or digits
- **location**: get names with `az account list-locations -o table`
- **account-type**: Premium_LRS, Standard_GRS, Standard_LRS, Standard_RAGRS, Standard_ZRS

## Querys

- All blobs in container:
`GET https://[url-for-service-account]/?comp=list&include=metadata`

## REST Endpoints
| | |
| --- | --- |
| Blobs |	`https://[name].blob.core.windows.net/` |
| Queues |	`https://[name].queue.core.windows.net/` |
| Table |	`https://[name].table.core.windows.net/` |
| Files |	`https://[name].file.core.windows.net/` |

## Connection String
- Format:
```text
DefaultEndpointsProtocol=https;AccountName={your-storage};
   AccountKey={your-access-key};
   EndpointSuffix=core.windows.net
```
- Query the String:
```sh
az storage account show-connection-string \
  --resource-group learn-909cb42a-317d-4357-945e-2e86c17db16d \
  --query connectionString \
  --name <name>
```

## Query Containers:

```bash 
az storage container list --account-name <name>
```

## Blob-Lib
https://github.com/Azure/azure-sdk-for-net/tree/Azure.Storage.Blobs_12.7.0/sdk/storage/Azure.Storage.Blobs
