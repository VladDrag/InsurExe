namespace InsurExeApi.Controllers;
using InsurExeApi.Models.DatabaseModels;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using InsurExeApi.Server;

[Route("/api")]
[ApiController]
public class InsurExeApiController: ControllerBase
{
    [HttpGet()]
    public List<InsuranceDb> GetHello()
    {
        var databaseInfo = new DatabaseContext();
        return databaseInfo.InsuranceDatabase;
    }
}