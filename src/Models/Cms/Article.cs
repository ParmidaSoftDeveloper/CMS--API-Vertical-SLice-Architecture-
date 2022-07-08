using Threenine.Models;

namespace Models.Cms;

public class Article : BaseEntity
{
    public string Title { get; set; }
    public string Summary { get; set; }
    public string Content { get; set; }
   
}