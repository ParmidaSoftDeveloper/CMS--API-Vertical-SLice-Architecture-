using Threenine.Models;

namespace Models.Cms;

public class Content : BaseEntity
{
    public string Title { get; set; }
    public string Summary { get; set; }
    public string Body { get; set; }
   
}