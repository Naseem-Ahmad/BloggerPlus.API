using BloggerPlus.API.Data;
using BloggerPlus.API.Model.Domain;
using BloggerPlus.API.Repositories.Interface;
using Microsoft.EntityFrameworkCore;

namespace BloggerPlus.API.Repositories
{
    public class CategoryRepository : ICategoryRepository
    {
        private readonly ApplicationDbContext _context;
        public CategoryRepository(ApplicationDbContext dbContext)
        {
             this._context = dbContext;   
        }
        public async Task<Category> CreateAsync(Category category)
        {
            await _context.Categories.AddAsync(category);
            await _context.SaveChangesAsync();
            return category;
        }
    }
}
