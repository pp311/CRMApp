namespace Lab2.Application.Helpers;

public static class CacheKeyHelper
{
    public static string GetKey(string className , string values)
    {
        return $"{className}-{values}";
    }
}