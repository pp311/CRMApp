using Lab2.Data;
using Lab2.Entities;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace Lab2.Controllers;

[ApiController]
[Route("[controller]")]
public class WeatherForecastController : ControllerBase
{
    private static readonly string[] Summaries = new[]
    {
        "Freezing", "Bracing", "Chilly", "Cool", "Mild", "Warm", "Balmy", "Hot", "Sweltering", "Scorching"
    };

    private readonly ILogger<WeatherForecastController> _logger;
    private readonly CRMDbContext _context;

    public WeatherForecastController(ILogger<WeatherForecastController> logger, CRMDbContext context)
    {
        _logger = logger;
        _context = context;
    }

    [HttpGet(Name = "GetWeatherForecast")]
    public IEnumerable<WeatherForecast> Get()
    {
        return Enumerable.Range(1, 5).Select(index => new WeatherForecast
            {
                Date = DateOnly.FromDateTime(DateTime.Now.AddDays(index)),
                TemperatureC = Random.Shared.Next(-20, 55),
                Summary = Summaries[Random.Shared.Next(Summaries.Length)]
            })
            .ToArray();
    }

    private static string RemoveSpace(string txt)
    {
        return txt.Replace(" ", "");
    }
    
    [HttpGet("ClientEval")]
    public async Task<ActionResult<IEnumerable<Product>>> ClientEval()
    {
        var productsName = await _context.Products
            .OrderBy(p => p.Price)
            .Select(p => new {Name = RemoveSpace(p.Name)})
            .ToListAsync();
        return Ok(productsName);
    }
    
    [HttpGet("ClientEvalExp")]
    public async Task<ActionResult<IEnumerable<Product>>> ClientEvalExp()
    {
        var productsName = await _context.Products
            .OrderBy(p => p.Price)
            .Where(p => RemoveSpace(p.Name).Contains("Fish"))
            .Select(p => new {Name = RemoveSpace(p.Name)})
            .ToListAsync();
        return Ok(productsName);
    }
    
    [HttpGet("ClientEvalEnumerable")]
    public async Task<ActionResult<IEnumerable<Product>>> ClientEvalEnumerable()
    {
        var productsName =  _context.Products
            .OrderBy(p => p.Price)
            .AsEnumerable()
            .Where(p => RemoveSpace(p.Name).Contains("Fish"))
            .Select(p => new {Name = RemoveSpace(p.Name)})
            .ToList();
        return Ok(productsName);
    }

    [HttpGet("EntityState")]
    public async Task<ActionResult<string>> EntityState()
    {
        string result = "";
        // Create a new account
        var account1 = new Account { Name = "Acc 1", TotalSales = 123 };
        result += $"Acc 1 state is {_context.Entry(account1).State}\n";
        // Mark the account as Added 
        _context.Add(account1);
        result += $"Acc 1 state is {_context.Entry(account1).State}\n";
        // Save changes to the database 
        await _context.SaveChangesAsync();
        result += $"Acc 1 state is {_context.Entry(account1).State}\n";
        // Mark the account as Modified 
        account1.TotalSales = 234;
        result += $"Acc 1 state is {_context.Entry(account1).State}\n";
        // Mark the account as Deleted 
        _context.Remove(account1);
        result += $"Acc 1 state is {_context.Entry(account1).State}\n";
        // Mark the account as Detached 
        _context.Entry(account1).State = Microsoft.EntityFrameworkCore.EntityState.Detached;
        result += $"Acc 1 state is {_context.Entry(account1).State}\n";
        
        return Ok(result);
    }

    [HttpGet("AddVsAttach")]
    public async Task<ActionResult> AddVsAttach()
    {
        var account1 = await _context.Accounts.SingleAsync(a => a.Id == 1);
        var account2 = await _context.Accounts.SingleAsync(a => a.Id == 2);
        // var account1 = new Account { Name = "Acc 1", TotalSales = 123 };
        // var account2 = new Account { Name = "Acc 2", TotalSales = 234 };
        
        var deal1 = new Deal { Title = "Deal 1", Status = 0 };
        var deal2 = new Deal { Title = "Deal 2", Status = 0 };
        
        account1.Deals = new List<Deal> { deal1 };
        account2.Deals = new List<Deal> { deal2 };

        _context.Add(account1);
        _context.Attach(account2);
        
        string result = "";
        result += $"Account 1 state is {_context.Entry(account1).State}\n";
        result += $"Account 2 state is {_context.Entry(account2).State}\n";
        result += $"Deal 1 state is {_context.Entry(deal1).State}\n";
        result += $"Deal 2 state is {_context.Entry(deal2).State}\n";
        return Ok(result);
    }

    [HttpGet("Tracking")]
    public async Task<ActionResult> Tracking()
    {
        var result = "";
        // var query = _context.Accounts.Where(a => a.Id == 1);
        var query = _context.Accounts.Where(a => a.Id == 1).AsNoTracking();
        
        var account1 = await query.FirstOrDefaultAsync();
        account1.Name = "Acc 1";
        result += $"Account 1 state is {_context.Entry(account1).State}. " +
                  $"Hash code: {account1.GetHashCode()}\n";
        
        var account2 = await query.FirstOrDefaultAsync();
        result += $"Account 2 state is {_context.Entry(account2).State}. " +
                  $"Hash code: {account2.GetHashCode()}\n";
        
        return Ok(result);
    }

    [HttpGet("LoadingStrategies")]
    public async Task<ActionResult> LoadingStrategies()
    {
        Console.WriteLine("Eager loading");
        Console.WriteLine("-----------------");
        var account1 = await _context.Accounts 
            .Include(a => a.Deals)
            .Include(a => a.Contacts)
            // .AsSplitQuery()
            .FirstOrDefaultAsync(a => a.Id == 1);
        
        Console.WriteLine("Lazy loading");
        Console.WriteLine("-----------------");
        var account2 = await _context.Accounts.FirstOrDefaultAsync(a => a.Id == 2);
        var deals = account2.Deals;
        var contacts = account2.Contacts;
        
        Console.WriteLine("Explicit loading");
        Console.WriteLine("-----------------");
        var account3 = await _context.Accounts.Where(a => a.Id == 3).FirstOrDefaultAsync();
        await _context.Entry(account3).Collection(a => a.Deals).LoadAsync();
        await _context.Entry(account3).Collection(a => a.Contacts).LoadAsync();

        return Ok();
    }
    
    [HttpGet("N1Problem")]
    public async Task<ActionResult> N1Problem()
    {
        var result = "";
        var accounts = await _context.Accounts.ToListAsync();
        foreach (var account in accounts)
        {
            result += $"Account {account.Id} has {account.Deals.Count} deals\n";
        }
        return Ok(result);
    }
}