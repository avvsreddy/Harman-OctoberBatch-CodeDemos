using KnowledgeHubPortal.Domain.DTO;

namespace KnowledgeHubPortal.Domain.Managers
{
    public interface IArticleManager
    {
        void SubmitArticle(SubmitArticleDTO submitArticleDto);
        List<ReviewArticleDTO> GetArticlesForReview(int categoryId = 0);
        void ApproveArticles(List<int> articlesId);
        void RejectArticles(List<int> articlesId);
        List<BrowseArticleDTO> GetArticlesForBrowse(int categoryId = 0);
    }
}
