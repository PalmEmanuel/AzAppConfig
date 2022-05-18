---
external help file: AzAppConfig.PS.dll-Help.xml
Module Name: AzAppConfig
online version:
schema: 2.0.0
---

# Get-AzAppConfig

## SYNOPSIS

Gets the configuration from an Azure App Configuration.

## SYNTAX

### ConnectionString

```plaintext
Get-AzAppConfig -ConnectionString <String> [<CommonParameters>]
```

### EndpointToken

```plaintext
Get-AzAppConfig -Endpoint <Uri> -Token <String> [<CommonParameters>]
```

## DESCRIPTION

Gets the configuration from an Azure App Configuration as a hashtable.

## EXAMPLES

### Example 1

```powershell
PS C:\> Get-AzAppConfig -Connectionstring 'Endpoint=https://pipehow.azconfig.io;Id=fake-id-00:identifier;Secret=onlyanexample'
```

Gets the configuration from the Azure App Configuration using a connection string.

### Example 2

```powershell
PS C:\> Get-AzAppConfig -Endpoint 'https://pipehow.azconfig.io' -Token 'mytoken'
```

Gets the configuration from the Azure App Configuration using an endpoint and a token.

## PARAMETERS

### -ConnectionString

The connection string to use for authentication.

```yaml
Type: String
Parameter Sets: ConnectionString
Aliases:

Required: True
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -Endpoint

The endpoint of the Azure App Configuration.

```yaml
Type: Uri
Parameter Sets: EndpointToken
Aliases:

Required: True
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -Token

The token to use for authentication.

```yaml
Type: String
Parameter Sets: EndpointToken
Aliases:

Required: True
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### CommonParameters

This cmdlet supports the common parameters: -Debug, -ErrorAction, -ErrorVariable, -InformationAction, -InformationVariable, -OutVariable, -OutBuffer, -PipelineVariable, -Verbose, -WarningAction, and -WarningVariable. For more information, see [about_CommonParameters](http://go.microsoft.com/fwlink/?LinkID=113216).

## INPUTS

### None

## OUTPUTS

### System.Collections.Hashtable

## NOTES

## RELATED LINKS
