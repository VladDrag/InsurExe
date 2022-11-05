using System.ComponentModel.DataAnnotations;

namespace InsurExeApi.Models.DatabaseModels;

public class InsuranceDb
{
    //add unique ID property depending on the database type
    [Key]
	public string? Id { get; set; }
    public string? Description { get; set; }
	public string? Type { get; set; }
    public double MonthlyPayment { get; set; }
    public double AmountInsured { get; set; }
    public int InsuranceTime { get; set; }
}