namespace KnowledgeHubPortal.Domain.Entities
{
    public class Category
    {
        // Properties
        public int CategoryID { get; set; } // PK
        public string Name { get; set; }
        public string Description { get; set; }
        public DateTime DateCreated { get; set; }
        public DateTime DateUpdated { get; set; }
    }
}
