using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

[Route("/api")]
[ApiController]
public class InsurExeApiController: ControllerBase
{
    [HttpGet()]
    public string getHello()
    {
        return "Hello World!";
    }
}