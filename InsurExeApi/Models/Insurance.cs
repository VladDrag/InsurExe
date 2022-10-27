namespace InsurExeApi.Models;

public class Insurance
{
    public string? Type {get; set;}
    public string? Description {get; set;}
    public double MonthlyPayment {get; set;}
    public double AmmountInsured {get; set;}
    public int MonthsInsured {get; set;}
}