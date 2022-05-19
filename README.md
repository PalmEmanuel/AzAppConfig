# AzAppConfig

[![AzAppConfigDownloads]][AzAppConfigGallery]

AzAppConfig is a module to get configuration from Azure App Configuration.

---

## Examples

Getting config data using a connection string.

```powershell
PS C:\> Get-AzAppConfig -ConnectionString 'Endpoint=https://pipehow.azconfig.io;Id=fake-id-00:identifier;Secret=onlyanexample'
```

Getting config data using an endpoint and a token.

```powershell
PS C:\> Get-AzAppConfig -Endpoint 'https://pipehow.azconfig.io' -Token 'mytoken'
```

<!-- References -->
[AzAppConfigDownloads]: https://img.shields.io/powershellgallery/dt/AzAppConfig
[AzAppConfigGallery]: https://www.powershellgallery.com/packages/AzAppConfig/
