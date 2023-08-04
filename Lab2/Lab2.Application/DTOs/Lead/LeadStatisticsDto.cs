namespace Lab2.Application.DTOs.Lead;

public class LeadStatisticsDto
{
    public int OpenLeadCount { get; set; }
    public int QualifiedLeadCount { get; set; }
    public int DisqualifiedLeadCount { get; set; }
    public double AverageEstimatedRevenue { get; set; }
}