using KnowledgeHubPortal.Domain.DTO;

namespace KnowledgeHubPortal.Domain.Managers
{
    public class ArticleManager : IArticleManager
    {
        public void ApproveArticles(List<int> articlesId)
        {
            throw new NotImplementedException();
        }

        public List<BrowseArticleDTO> GetArticlesForBrowse(int categoryId = 0)
        {
            throw new NotImplementedException();
        }

        public List<ReviewArticleDTO> GetArticlesForReview(int categoryId = 0)
        {
            throw new NotImplementedException();
        }

        public void RejectArticles(List<int> articlesId)
        {
            throw new NotImplementedException();
        }

        public void SubmitArticle(SubmitArticleDTO submitArticleDto)
        {
            throw new NotImplementedException();
        }
    }
}
