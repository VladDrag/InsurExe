namespace InsurExeApi.Models.DatabaseModels;

public class CarInsuranceDb : InsuranceDb
{
    public string? Specifics { get; set; }
    public CarInsuranceDb(string type, string description, double monthlyPayment, double amountInsured, int insuranceTime):
                         base(type, description, monthlyPayment, amountInsured, insuranceTime)
    {
        Specifics = "Car insurance specific aspects";
    }
}