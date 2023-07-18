namespace Lab2.DomainModels;

public class DealStatistics
{
    public int OpenDealCount { get; set; }
    public int WonDealCount { get; set; }
    public int LostDealCount { get; set; }
    public double AverageRevenue { get; set; }
    public double TotalRevenue { get; set; }
}