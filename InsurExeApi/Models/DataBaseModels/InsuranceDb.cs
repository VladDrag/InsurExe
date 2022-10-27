namespace InsurExeApi.Models.DatabaseModels;

public class InsuranceDb
{
    //add unique ID property depending on the database type
    public string? Description { get; set; }
    public double MonthlyPayment { get; set; }
    public double AmmountInsured { get; set; }
    public int InsuranceTime { get; set; }

    public InsuranceDb(string type,  string description, double monthlyPayment, double amountInsured, int insuranceTime)
    {
        Description = description;
        MonthlyPayment = monthlyPayment;
        AmmountInsured = amountInsured;
        InsuranceTime = insuranceTime;
    }
}