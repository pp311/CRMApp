namespace Lab2.DTOs.Deal;

public class DealStatisticsDto
{
    public int OpenDealCount { get; set; }
    public int WonDealCount { get; set; }
    public int LostDealCount { get; set; }
    public double? AvarageRevenue { get; set; }
    public double? TotalRevenue { get; set; }
}