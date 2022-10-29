namespace InsurExeApi.Models.Factories;
using InsurExeApi.Models.DatabaseModels;
using InsurExeApi.Models.DTOModels;

public enum InsuranceType
{
	Car,
	Home,
	Life,
	Health
}

public class InsuranceFactory
{
	public InsuranceDto CreateInsurance(InsuranceDb insurance)
	{
		var type = insurance.Type;
		return type switch
		{
			"car" => new CarInsuranceDto
			{
				Specifics = "Car",
				Description = insurance.Description,
				MonthlyPayment = insurance.MonthlyPayment,
				AmountInsured = insurance.AmountInsured,
				InsuranceTime = insurance.InsuranceTime
			},
			"home" => new HomeInsuranceDto
			{
				Specifics = "Home",
				Description = insurance.Description,
				MonthlyPayment = insurance.MonthlyPayment,
				AmountInsured = insurance.AmountInsured,
				InsuranceTime = insurance.InsuranceTime
			},
			"life" => new LifeInsuranceDto
			{
				Specifics = "Life",
				Description = insurance.Description,
				MonthlyPayment = insurance.MonthlyPayment,
				AmountInsured = insurance.AmountInsured,
				InsuranceTime = insurance.InsuranceTime
			},
			"health" => new HealthInsuranceDto
			{
				Specifics = "Health",
				Description = insurance.Description,
				MonthlyPayment = insurance.MonthlyPayment,
				AmountInsured = insurance.AmountInsured,
				InsuranceTime = insurance.InsuranceTime
			},
			_ => throw new ArgumentException("Invalid insurance type")
		};
	}
}

