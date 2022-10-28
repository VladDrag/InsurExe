namespace InsurExeApi.Controllers;
using InsurExeApi.Models.DatabaseModels;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using InsurExeApi.Server;
using InsurExeApi.Models.Factories;

[Route("/api")]
[ApiController]
public class InsurExeApiController: ControllerBase
{
    [HttpGet()]
    public List<InsuranceDb> GetAllInsurances()
    {
        var databaseInfo = new DatabaseContext();
		var factory = new InsuranceFactory();
		var insurancesList = new List<InsuranceDb>();
		foreach (var insurance in databaseInfo.InsuranceDatabase)
		{
			var insuranceDb = factory.CreateInsurance(insurance);
			// if (insuranceDb.GetType().Equals(typeof(CarInsuranceDb))) insurancesList.Add(insuranceDb);
			insurancesList.Add(insuranceDb);
		}
		return insurancesList;
	}
}