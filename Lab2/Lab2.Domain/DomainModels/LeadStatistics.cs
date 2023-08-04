namespace Lab2.Domain.DomainModels;

public class LeadStatistics
{
    public int OpenLeadCount { get; set; }
    public int QualifiedLeadCount { get; set; }
    public int DisqualifiedLeadCount { get; set; }
    public double AverageEstimatedRevenue { get; set; }
}