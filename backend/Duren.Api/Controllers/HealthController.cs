using Duren.Api.Data;
using Microsoft.AspNetCore.Mvc;

namespace Duren.Api.Controllers;

[ApiController]
[Route("api/health")]
public class HealthController(AppDbContext db) : ControllerBase
{
    [HttpGet]
    public async Task<IActionResult> Get(CancellationToken ct)
    {
        var databaseOk = await db.Database.CanConnectAsync(ct);

        return Ok(new
        {
            status = "ok",
            database = databaseOk,
            serverTime = DateTime.UtcNow
        });
    }
}