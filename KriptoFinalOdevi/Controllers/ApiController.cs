using Microsoft.AspNetCore.Mvc;

[Route("api")]
[ApiController]
public class ApiController : ControllerBase
{
    [HttpGet]
    public IActionResult Get()
    {
        return Ok(new { mesaj = "API Basariyla Calisiyor!", sunucu = "Ubuntu 18.04", durum = "Aktif" });
    }
}