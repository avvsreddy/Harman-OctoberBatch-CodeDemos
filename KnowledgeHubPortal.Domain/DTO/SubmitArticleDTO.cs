namespace KnowledgeHubPortal.Domain.DTO
{
    public class SubmitArticleDTO
    {
        public string Title { get; set; }
        public string ArticleUrl { get; set; }
        public string Description { get; set; }
        public int CategoryID { get; set; }
    }
}
