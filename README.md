# monobank-dotnet
This is a simple wrapper for the [Monobank API](https://api.monobank.ua/docs/) for .NET

# How to use?
- Obtain your personal access token at [Monobank API](https://api.monobank.ua)
- Set this token in the constructor:
```csharp
var mono = new Monobank("YOUR_TOKEN");

var clientInfo = await mono.GetClientInfoAsync();
```
