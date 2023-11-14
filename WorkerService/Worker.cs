using Domain.Entities;
using Infrastructure.Persistence;

namespace WorkerService;

public class Worker : BackgroundService
{
    private readonly ILogger<Worker> _logger;
    private readonly ApplicationDbContext _dbContext;

    // get db context from DI
    public Worker(ILogger<Worker> logger, ApplicationDbContext dbContext)
    {
        _logger = logger;
        _dbContext = dbContext;
    }

    protected override async Task ExecuteAsync(CancellationToken stoppingToken)
    {
        _dbContext.Province.Add(new Province { Name = "Ontario" });
        await _dbContext.SaveChangesAsync(stoppingToken);
        
    }
}