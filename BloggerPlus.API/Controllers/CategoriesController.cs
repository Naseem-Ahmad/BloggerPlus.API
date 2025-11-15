using BloggerPlus.API.Data;
using BloggerPlus.API.Model.Domain;
using BloggerPlus.API.Model.DTO;
using BloggerPlus.API.Repositories.Interface;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace BloggerPlus.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CategoriesController : ControllerBase
    {
        public readonly ICategoryRepository _categoryRepository;
        public CategoriesController(ICategoryRepository categoryRepository)
        {
            _categoryRepository = categoryRepository;
        }


        [HttpPost]
        public async Task<IActionResult> CreateCategory(CreateCategoryRequestDTO request)
        {
            // Map DTO to Domain Model
            var category = new Category
            {
                Title = request.Title,
                UrlHandle = request.UrlHandle
            };

            await _categoryRepository.CreateAsync(category);

            // Domain model to Dto
            var response = new CategoryDto
            {
                Id = category.Id,
                Title = category.Title,
                UrlHandle = category.UrlHandle

            };
            return Ok(response);

        }
    }
}
