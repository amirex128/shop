@ECHO OFF
dotnet.exe ef migrations remove --project Infrastructure\Infrastructure.csproj --startup-project WebAPI\WebAPI.csproj --context Infrastructure.Persistence.ApplicationDbContext --configuration Debug --force
