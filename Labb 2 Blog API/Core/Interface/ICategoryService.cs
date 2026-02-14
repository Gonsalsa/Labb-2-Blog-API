using Labb_2_Blog_API.Data.Enteties;

namespace Labb_2_Blog_API.Core.Interface
{
    public interface ICategoryService
    {
        Task<List<Category>> GetAllCategoriesAsync();
        Task<Category?> GetCategoryByIdAsync(int id);
        Task<bool> AddCategoryAsync(Category category);
    }
}
