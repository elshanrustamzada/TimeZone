using Microsoft.AspNetCore.Http;

namespace TimeZone.Helper
{
    public static class Extensions
    {
        public static bool IsImage( this IFormFile file)
        {
            return file.ContentType.Contains("image/");
        }
    }
}
