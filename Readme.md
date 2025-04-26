# dotnet core api 101

## Prerequisites

- Install .NET SDK 9.0 or later

## Create project Steps

```sh
dotnet new sln
dotnet new webapi -n Api
dotnet new xunit -n Api.Tests

cd Api.Tests
dotnet add reference ../Api/Api.csproj
```
