namespace KnowledgeHubPortal.Domain.Entities
{
    public class Article
    {
        public int ArticleID { get; set; }
        public string Title { get; set; }
        public string ArticleUrl { get; set; }
        public string Description { get; set; }
        public string PostedBy { get; set; }
        public Category Category { get; set; }
        public bool IsApproved { get; set; }
        public DateTime DatePosted { get; set; }
        public DateTime DateApproved { get; set; }
    }
}
