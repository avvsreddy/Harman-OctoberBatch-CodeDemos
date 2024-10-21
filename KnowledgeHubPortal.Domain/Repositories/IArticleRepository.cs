using KnowledgeHubPortal.Domain.Entities;

namespace KnowledgeHubPortal.Domain.Repositories
{
    public interface IArticleRepository
    {
        void SubmitArticle(Article article);
        List<Article> GetArticlesForReview(int categoryId = 0);
        void ApproveArticles(List<int> articlesId);
        void RejectArticles(List<int> articlesId);
        List<Article> GetArticlesForBrowse(int categoryId = 0);
    }
}
