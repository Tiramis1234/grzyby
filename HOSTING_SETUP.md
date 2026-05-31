# Konfiguracja Hostingu - Grzyby Blazor

## Uruchamianie aplikacji w trybie hostingu

### Lokalne testowanie z profilem Hosting
```bash
dotnet run --launch-profile Hosting
```

### Publikacja do folderu (Windows)
```bash
dotnet publish -c Release -p:PublishProfile=Hosting
```

### Publikacja do folderu (Linux)
```bash
dotnet publish -c Release -p:PublishProfile=HostingLinux
```

## Konfiguracja produkcyjna

### Profil Launch "Hosting"
- **URL**: `http://0.0.0.0:5094` i `https://0.0.0.0:7111`
- **Środowisko**: Production
- **LaunchBrowser**: Disabled (brak otwarcia przeglądarki)

### Pliki publikacji
Aplikacja zostanie opublikowana w:
- **Windows**: `bin\Release\net10.0\publish`
- **Linux**: `bin\Release\net10.0\publish-linux`

## Uruchomienie na serwerze

### Windows Server (IIS)
1. Opublikuj aplikację: `dotnet publish -c Release -p:PublishProfile=Hosting`
2. Skopiuj zawartość folderu `publish` na serwer
3. Skonfiguruj Application Pool w IIS
4. Wskaż folder publikacji jako fyzyczną ścieżkę strony

### Linux Server
1. Opublikuj dla Linux: `dotnet publish -c Release -p:PublishProfile=HostingLinux`
2. Skopiuj zawartość na serwer Linux
3. Zainstaluj .NET 10.0 Runtime
4. Uruchom aplikację: `./grzyby-blazor`
5. Skonfiguruj reverse proxy (nginx/Apache)

## Zmienne środowiska

W pliku `launchSettings.json` profil "Hosting" ustawia:
- `ASPNETCORE_ENVIRONMENT=Production`
- `ASPNETCORE_URLS=http://0.0.0.0:5094;https://0.0.0.0:7111`

Możesz je zmienić na port i adres IP zgodny z konfiguracją hosta.

## Plik konfiguracyjny

Utwórz lub edytuj `appsettings.Hosting.json` do custom configuracji dla hostingu.
