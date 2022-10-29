namespace InsurExeApi.Controllers;
using InsurExeApi.Models.DatabaseModels;
using InsurExeApi.Models.DTOModels;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using InsurExeApi.Server;
using InsurExeApi.Models.Factories;

[Route("/api")]
[ApiController]
public class InsurExeApiController: ControllerBase
{
	private InsuranceFactory _factory = new InsuranceFactory();
    [HttpGet()]
    public List<InsuranceDto> GetAllInsurances()
    {
        var databaseInfo = new DatabaseContext();
		var insurancesList = new List<InsuranceDto>();
		foreach (var insurance in databaseInfo.InsuranceDatabase)
		{
			var insuranceDto = _factory.CreateInsurance(insurance);
			// if (insuranceDb.GetType().Equals(typeof(CarInsuranceDb))) insurancesList.Add(insuranceDb);
			insurancesList.Add(insuranceDto);
		}
		return insurancesList;
	}
}