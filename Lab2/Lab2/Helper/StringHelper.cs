using Microsoft.AspNetCore.Identity;

namespace Lab2.Helper;

public static class StringHelper
{
    /// <summary>
    /// Convert IdentityError list to string
    /// </summary>
    /// <param name="errors"></param>
    /// <returns></returns>
    public static string GetIdentityErrorString(IEnumerable<IdentityError> errors)
    {
        var errorList = errors.Select(e => e.Description).ToList();
        return string.Join(" ", errorList);
    } 
    
}