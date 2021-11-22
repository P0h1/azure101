# CLI

- groups as table output
`az group list --output table`

- query a typ of resource
`az group list --query "[?name == '$RESOURCE_GROUP']"`
  - Query language: [JMESPath](https://jmespath.org/)

## Create Service Plan
```bash
az appservice plan create --name $AZURE_APP_PLAN --resource-group $RESOURCE_GROUP --location $AZURE_REGION --sku FREE
```

## Create WebApp
```cmd
az webapp create --name $AZURE_WEB_APP --resource-group $RESOURCE_GROUP --plan $AZURE_APP_PLAN
```

- Deploy GitHub Repo
```powershell
az webapp deployment source config --name $AZURE_WEB_APP \
--resource-group $RESOURCE_GROUP --repo-url "https://github.com/Azure-Samples/php-docs-hello-world" \
--branch master --manual-integration
```

## Azure PowerShell
- prepare: use Version 7
- install dotnet powershell support: `dotnet tool install --global PowerShell`