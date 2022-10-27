namespace InsurExeApi.Models.DatabaseModels;

public class LifeInsuranceDb : InsuranceDb
{
    public string? Specifics { get; set; }
    public LifeInsuranceDb(string type, string description, double monthlyPayment, double amountInsured, int insuranceTime):
                            base(type, description, monthlyPayment, amountInsured, insuranceTime)
    {
        Specifics = "Life insurance specific aspects";
    }
}