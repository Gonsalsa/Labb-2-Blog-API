using Labb_2_Blog_API.Core.Interface;
using Labb_2_Blog_API.Data.Enteties;

namespace Labb_2_Blog_API.Core.Services
{
    public class CategoryService : ICategoryService
    {
        public Task<bool> AddCategoryAsync(Category category)
        {
            throw new NotImplementedException();
        }

        public Task<List<Category>> GetAllCategoriesAsync()
        {
            throw new NotImplementedException();
        }

        public Task<Category?> GetCategoryByIdAsync(int id)
        {
            throw new NotImplementedException();
        }
    }
}
