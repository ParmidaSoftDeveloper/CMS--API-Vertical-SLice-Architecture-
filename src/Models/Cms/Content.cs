using Threenine.Models;

namespace Models.Cms;

public class Content : BaseEntity
{
    public string Title { get; set; }
    public string Summary { get; set; }
    public string Body { get; set; }

    public Guid SeoId { get; set; }
    public Seo Seo { get; set; }
    public ContentType ContentType { get; set; }

    public ContentStatus Status { get; set; }
   
}