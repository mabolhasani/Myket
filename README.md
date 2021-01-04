# Myket Restful Api
---
This is a simple library for myket restful api
## Installation
---
##### Package Manager
```
Install-Package MyketApi -Version 1.0.1
```
##### .NET CLI
```
dotnet add package kavenegar --version 1.2.4
```
---
### Usage 
---
```csharp
var config= new Configuration("Your Myket AccessToken", "Your Package Name");
var myket = new MyketApi(config);
var result = await myket.VerifyPurchase("Your SKU Id", "Your Token");
if (result.Successful)
{
    //...
}
else
{
    //check the result.Error 
    //...
}
```
---
