using KnowledgeHubPortal.Domain.Entities;
using KnowledgeHubPortal.Domain.Repositories;

namespace KnowledgeHubPortal.Data
{
    public class CategoryRepository : ICategoryRepository
    {

        private KBPDbContext _dbContext;
        public CategoryRepository(KBPDbContext _dbContext)
        {
            this._dbContext = _dbContext;
        }
        public void Create(Category category)
        {
            _dbContext.Categories.Add(category);
            _dbContext.SaveChanges();
        }

        public List<Category> GetAll()
        {
            throw new NotImplementedException();
        }
    }
}
