using KnowledgeHubPortal.Domain.DTO;
using KnowledgeHubPortal.Domain.Entities;
using KnowledgeHubPortal.Domain.Repositories;

namespace KnowledgeHubPortal.Domain.Managers
{
    public class CategoryManager : ICategoryManager
    {
        private readonly ICategoryRepository categoryRepo;

        public CategoryManager(ICategoryRepository categoryRepo)
        {
            this.categoryRepo = categoryRepo;
        }
        public void CreateCategory(CategoryCreateDTO categoryCreateDto)
        {
            // this is called by api
            // convert dto with entity class - use AutoMapper - DOTO

            // category name should be unique - DOTO


            Category category = new Category();
            category.Name = categoryCreateDto.Name;
            category.Description = categoryCreateDto.Description;
            category.DateCreated = DateTime.Now;

            // call a repository method for creating category
            categoryRepo.Create(category);
        }

        public List<CategoryListDTO> GetAllCategories()
        {
            throw new NotImplementedException();
        }
    }
}
