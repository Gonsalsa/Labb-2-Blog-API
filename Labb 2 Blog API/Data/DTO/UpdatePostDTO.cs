namespace Labb_2_Blog_API.Data.DTO
{
    public class UpdatePostDTO
    {
        public string? Title { get; set; }
        public string? Content { get; set; }
        public int? categoryId { get; set; }
    }
}
