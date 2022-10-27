namespace InsurExeApi.Models.DatabaseModels;

public class HealthInsuranceDb : InsuranceDb
{
    public string? Specifics { get; set; }
    public HealthInsuranceDb(string type, string description, double monthlyPayment, double amountInsured, int insuranceTime):
                            base(type, description, monthlyPayment, amountInsured, insuranceTime)
    {
        Specifics = "Health insurance specific aspects";
    }
}