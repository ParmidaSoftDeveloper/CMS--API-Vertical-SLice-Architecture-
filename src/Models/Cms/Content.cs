using Threenine.Models;

namespace Models.Cms;

public class Content : BaseEntity
{
    public string Title { get; set; }
    public string Summary { get; set; }
    public string Body { get; set; }

   
    public ContentType ContentType { get; set; }

    public ContentStatus Status { get; set; }
    
    public string MetaTitle { get; set; }
    public string MetaDescription { get; set; }
    public string MetaViewPort { get; set; }
    public string MetaRobots { get; set; }

   
}