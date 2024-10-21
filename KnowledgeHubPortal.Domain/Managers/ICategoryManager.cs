using KnowledgeHubPortal.Domain.DTO;

namespace KnowledgeHubPortal.Domain.Managers
{
    public interface ICategoryManager
    {
        void CreateCategory(CategoryCreateDTO categoryCreateDto);
        List<CategoryListDTO> GetAllCategories();
    }
}
