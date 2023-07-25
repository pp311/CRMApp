using Lab2.Data;
using Lab2.Entities;
using Lab2.Repositories.Interfaces;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace Lab2.Controllers;

[ApiController]
[Route("api/test")]
public class TestController : ControllerBase
{
    private readonly UserManager<User> _userManager;
    private readonly IUserRepository _userRepository;
    private readonly IUnitOfWork _unitOfWork;
    private readonly CRMDbContext _context;

    public TestController(UserManager<User> userManager,
                          IUserRepository userRepository,
                          IUnitOfWork unitOfWork,
                          CRMDbContext context)
    {
        _userManager = userManager;
        _userRepository = userRepository;
        _unitOfWork = unitOfWork;
        _context = context;
    }

    [HttpPost]
    public async Task<IActionResult> Test()
    {
        var user = new User
        {
            Name = "Test",
            Email = "asd@asd.com",
            UserName = "Test"
        };
        using (var transaction = _context.Database.BeginTransaction())
        {
            try
            {
                var result = await _userManager.CreateAsync(user, "Admin@123");
                var errors = result.Errors.Select(e => e.Description).ToList();
                errors.ForEach(Console.WriteLine);
                Console.WriteLine();
                Console.WriteLine(result.Succeeded.ToString());

                _context.SaveChanges();
                throw new Exception();
                transaction.Commit();
            }
            catch (Exception ex)
            {
                transaction.Rollback();
                return BadRequest(ex.Message);
            }
        }

        return Ok();
    }
}



