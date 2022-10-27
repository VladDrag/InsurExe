namespace InsurExeApi.Models.DTOModels;

public class InsuranceDto
{
    public string? Type { get; set; }
    public string? Description { get; set; }
    public double MonthlyPayment { get; set; }
    public double AmmountInsured { get; set; }
    public int InsuranceTime { get; set; }
}