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
	private List<InsuranceDb>? _insurDb = new DatabaseContext().InsuranceDatabase;
    [HttpGet()]
    public List<InsuranceDto> GetAllInsurances()
    {
		var insurancesList = new List<InsuranceDto>();
		foreach (var insurance in _insurDb)
		{
			var insuranceDto = _factory.CreateInsurance(insurance);
			// if (insuranceDb.GetType().Equals(typeof(CarInsuranceDb))) insurancesList.Add(insuranceDb);
			insurancesList.Add(insuranceDto);
		}
		return insurancesList;
	}

	[HttpGet("{id}")]
	public async Task<ActionResult<InsuranceDto>> GetInsurance(string id)
	{
		var insurance = _insurDb.Find(ins => ins.Id == id);
		if (insurance == null)
		{
			return NotFound();
		}
		var insuranceDto = _factory.CreateInsurance(insurance);
		return insuranceDto;
	}
}