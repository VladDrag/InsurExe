namespace InsurExeApi.Models.DatabaseModels;

public class HomeInsuranceDb : InsuranceDb
{
    public string? Specifics { get; set; }
    public HomeInsuranceDb(string type, string description, double monthlyPayment, double amountInsured, int insuranceTime):
                            base(type, description, monthlyPayment, amountInsured, insuranceTime)
    {
        Specifics = "Home insurance specific aspects";
    }
}