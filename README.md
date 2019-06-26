# monobank-dotnet
This is a simple wrapper for the [Monobank API](https://api.monobank.ua/docs/) for .NET

# How to use?
- Obtain your personal access token at [Monobank API](https://api.monobank.ua)
- Set HttpClient([why?](https://aspnetmonsters.com/2016/08/2016-08-27-httpclientwrong)) and this token in the constructor:
```csharp
var mono = new Monobank(new HttpClient(), "YOUR_TOKEN");

var currencyInfo = await mono.Currency.GetCurrencyInfoAsync();
var clientInfo = await mono.Personal.GetClientInfoAsync();
```
