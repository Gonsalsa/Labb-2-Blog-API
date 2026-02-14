using Labb_2_Blog_API.Core.Interface;
using Labb_2_Blog_API.Data.Enteties;
using Labb_2_Blog_API.Data.Interfaces;

namespace Labb_2_Blog_API.Core.Services
{
    public class CategoryService : ICategoryService
    {
        private readonly ICategoryRepo _categoryRepo;


        public async Task<bool> AddCategoryAsync(Category category)
        {
            if (category == null)
            {
                return false;
            }

            if(string.IsNullOrWhiteSpace(category.CategoryName))
            {
                return false;
            }

            await _categoryRepo.AddCategoryAsync(category);
            return true;
        }

        public async Task<List<Category>> GetAllCategoriesAsync()
        {
            return await _categoryRepo.GetAllCategoriesAsync();
        }

        public async Task<Category?> GetCategoryByIdAsync(int id)
        {
            return await _categoryRepo.GetCategoryByIdAsync(id);
        }
    }
}
