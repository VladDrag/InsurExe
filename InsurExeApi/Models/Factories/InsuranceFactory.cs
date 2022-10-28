namespace InsurExeApi.Models.Factories;
using InsurExeApi.Models.DatabaseModels;

public enum InsuranceType
{
	Car,
	Home,
	Life,
	Health
}

public class InsuranceFactory
{
	public InsuranceDb CreateInsurance(InsuranceDb insurance)
	{
		var type = insurance.Type;
		return type switch
		{
			"car" => new CarInsuranceDb
			{
				Specifics = "Car",
				Description = insurance.Description,
				MonthlyPayment = insurance.MonthlyPayment,
				AmountInsured = insurance.AmountInsured,
				InsuranceTime = insurance.InsuranceTime
			},
			"home" => new HomeInsuranceDb
			{
				Specifics = "Home",
				Description = insurance.Description,
				MonthlyPayment = insurance.MonthlyPayment,
				AmountInsured = insurance.AmountInsured,
				InsuranceTime = insurance.InsuranceTime
			},
			"life" => new LifeInsuranceDb
			{
				Specifics = "Life",
				Description = insurance.Description,
				MonthlyPayment = insurance.MonthlyPayment,
				AmountInsured = insurance.AmountInsured,
				InsuranceTime = insurance.InsuranceTime
			},
			"health" => new HealthInsuranceDb
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

