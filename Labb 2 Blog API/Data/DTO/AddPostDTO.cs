namespace Labb_2_Blog_API.Data.DTO
{
    public class AddPostDTO
    {
        public string? Title { get; set; }
        public string? Content { get; set; }
        public int CategoryId { get; set; }
    }
}
