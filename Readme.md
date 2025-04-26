# dotnet core api 101

## Steps

```sh
dotnet new sln
dotnet new webapi -n Api
dotnet new xunit -n Api.Tests

cd Api.Tests
dotnet add reference ../Api/Api.csproj
```
