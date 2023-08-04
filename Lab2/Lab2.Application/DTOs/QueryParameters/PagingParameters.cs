namespace Lab2.Application.DTOs.QueryParameters;

public class PagingParameters
{
    private const int MaxPageSize = 1000;
    private const int DefaultPageSize = 10;
    public int PageIndex { get; set; } = 1;
    private int _pageSize = DefaultPageSize;
    public int PageSize
    {
        get => _pageSize;
        set => _pageSize = Enumerable.Range(1, MaxPageSize).Contains(value) ? value : DefaultPageSize;
    }

    // public string? OrderBy { get; set; }
    public bool IsDescending { get; set; }
    public string Search { get; set; } = "";
}
