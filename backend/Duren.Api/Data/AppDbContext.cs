using Microsoft.EntityFrameworkCore;

namespace Duren.Api.Data;

public class AppDbContext(DbContextOptions<AppDbContext> options) : DbContext(options)
{
    
}