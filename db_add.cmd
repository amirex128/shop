@ECHO OFF
dotnet.exe ef migrations add --project Infrastructure\Infrastructure.csproj --startup-project WebAPI\WebAPI.csproj --context Infrastructure.Persistence.ApplicationDbContext --configuration Debug %1 --output-dir Migrations
