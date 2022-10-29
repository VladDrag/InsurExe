namespace InsurExeApi.Models.DTOModels;

public class InsuranceDto
{
    public string? Description { get; set; }
    public double MonthlyPayment { get; set; }
    public double AmountInsured { get; set; }
    public int InsuranceTime { get; set; }
}