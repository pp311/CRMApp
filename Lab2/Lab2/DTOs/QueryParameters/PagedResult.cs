namespace Lab2.DTOs.QueryParameters;

public class PagedResult<T>
{
   public int CurrentPage { get; set; }
   public int TotalPages { get; set; }
   public int PageSize { get; set; }
   public int TotalCount { get; set; }
   public bool HasPrevious => CurrentPage > 1;
   public bool HasNext => CurrentPage < TotalPages;
   public List<T> Data { get; set; }     
   
    public PagedResult(List<T> items, int count, int pageIndex, int pageSize)
    {
        Data = items;
        TotalCount = count;
        CurrentPage = pageIndex;
        PageSize = pageSize;
        TotalPages = (int)Math.Ceiling(count / (double)pageSize);
    }
}