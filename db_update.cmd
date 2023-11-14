@ECHO OFF
dotnet.exe ef database update --project Infrastructure\Infrastructure.csproj --startup-project WebAPI\WebAPI.csproj --context Infrastructure.Persistence.ApplicationDbContext --configuration Debug
