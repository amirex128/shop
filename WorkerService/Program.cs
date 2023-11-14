using WorkerService;

IHost host = Host.CreateDefaultBuilder(args)
    .ConfigureServices(services =>
    {
        services.AddInfrastructureServices();
        services.AddApplicationServices();
        
        services.AddHostedService<Worker>();
    })
    .Build();

host.Run();