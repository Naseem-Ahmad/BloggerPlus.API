using BloggerPlus.API.Model.Domain;

namespace BloggerPlus.API.Repositories.Interface
{
    public interface ICategoryRepository
    {
        Task<Category> CreateAsync(Category category);
    }
}
