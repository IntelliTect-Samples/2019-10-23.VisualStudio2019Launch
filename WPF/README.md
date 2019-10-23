### WPF with .NET Core 3.0

- [try-convert](https://github.com/dotnet/try-convert) - Project conversion dotnt global tool
- [.NET Core runtime identifiers](https://docs.microsoft.com/dotnet/core/rid-catalog)
- Publish self-contained app: `dotnet publish -r <RID>; -c <CONFIGURATION> --self-contained`
- Publish single file executable: `dotnet publish -r <RID> -c <CONFIGURATION> -p:PublishSingleFile=True`
- Publish trimmed single file executable: `dotnet publish -r <RID> -c <CONFIGURATION> -p:PublishSingleFile=True -p:PublishTrimmed=True`
- [ILLink](https://github.com/mono/linker/blob/master/src/ILLink.Tasks/README.md)