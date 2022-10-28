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
	public static InsuranceDb CreateInsurance(InsuranceType type, string description, double monthlyPayment, double amountInsured, int insuranceTime)
	{
		return type switch
		{
			InsuranceType.Car => new CarInsuranceDb
			{
				Specifics = "Car",
				Description = description,
				MonthlyPayment = monthlyPayment,
				AmountInsured = amountInsured,
				InsuranceTime = insuranceTime
			},
			InsuranceType.Home => new HomeInsuranceDb
			{
				Specifics = "Home",
				Description = description,
				MonthlyPayment = monthlyPayment,
				AmountInsured = amountInsured,
				InsuranceTime = insuranceTime
			},
			InsuranceType.Life => new LifeInsuranceDb
			{
				Specifics = "Life",
				Description = description,
				MonthlyPayment = monthlyPayment,
				AmountInsured = amountInsured,
				InsuranceTime = insuranceTime
			},
			InsuranceType.Health => new HealthInsuranceDb
			{
				Specifics = "Health",
				Description = description,
				MonthlyPayment = monthlyPayment,
				AmountInsured = amountInsured,
				InsuranceTime = insuranceTime
			},
			_ => throw new ArgumentException("Invalid insurance type", nameof(type))
		};
	}
}

