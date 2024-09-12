using Microsoft.EntityFrameworkCore;
using Register.API.Controllers;
// using Register.API.Controllers;

namespace Register.API.Models;

public class RegisterDbConntext : DbContext
{
    public RegisterDbConntext(DbContextOptions<RegisterDbConntext> options) : base(options) {}
    public DbSet<Registers> Registers { get; set; }
}