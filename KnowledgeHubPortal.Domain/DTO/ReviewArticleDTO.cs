namespace KnowledgeHubPortal.Domain.DTO
{
    public class ReviewArticleDTO
    {
        public int ArticleID { get; set; }
        public string Title { get; set; }
        public string CategoryName { get; set; }
        public string ArticleURL { get; set; }
        public DateTime DateSubmited { get; set; }
    }
}
