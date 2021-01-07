# Myket Rest API Documentation 
![.NET](https://github.com/mabolhasani/Myket/workflows/.NET/badge.svg)
[![NuGet version (MyketApi)](https://img.shields.io/nuget/v/MyketApi.svg?style=flat-square)](https://www.nuget.org/packages/MyketApi/)\
This is a simple C# implantation of Myket Rest API,
for more information you can go to Myket documentation [page](https://myket.ir/kb/en/pages/verification-of-in-app-purchases-on-the-server/) 

# Installation
##### Package Manager
```
Install-Package MyketApi -Version 1.1.0
```
##### .NET CLI
```
dotnet add package MyketApi --version 1.1.0
```
# Usage 
First of all you must create configuration instance and initialize it with proper config
```csharp
var config = new MyketConfiguration(
                "Your Myket AccessToken", "Your Package Name");
```
Then pass it to MyketClient 
```csharp
var client = new MyketClient(config);
```
And then with this function you can verify purchase
```csharp
var result = await client.VerifyPurchaseAsync("SKU Id", "Token");
```
### Usage of the result
```csharp
 if (result.Successful)
 {
	 //use result.PurchaseResult
	 //...
 }
 else
 {
	 //use result.Error
	 //...
 }
```
---
***Feel free to contact me or fork this repository for improvement :)***