using Labb_2_Blog_API.Context;
using Labb_2_Blog_API.Data.Enteties;
using Labb_2_Blog_API.Data.Interfaces;
using Microsoft.EntityFrameworkCore;

namespace Labb_2_Blog_API.Data.Repos
{
    public class CategoryRepo : ICategoryRepo
    {

        private readonly AppDbContext _context;

        public CategoryRepo(AppDbContext context)
        {
            _context = context;
        }

        public async Task AddCategoryAsync(Category category)
        {
            _context.Categories.Add(category);
            await _context.SaveChangesAsync();
        }

        public async Task<List<Category>> GetAllCategoriesAsync()
        {
            return await _context.Categories.ToListAsync();
        }

        public async Task<Category?> GetCategoryByIdAsync(int id)
        {
            return await _context.Categories.FirstOrDefaultAsync(c => c.CategoryId == id);
        }
    }
}
