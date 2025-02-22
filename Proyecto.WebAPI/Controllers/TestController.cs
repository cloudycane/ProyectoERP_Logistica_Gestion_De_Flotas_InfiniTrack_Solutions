using Microsoft.AspNetCore.Mvc;

[Route("api/[controller]")]
[ApiController]
public class TestController : ControllerBase
{
    [HttpGet]
    [Route("test")]  // Makes the endpoint available at /api/test/test
    public IActionResult GetTestMessage()
    {
        return Ok(new { message = "API is working" });
    }
}
