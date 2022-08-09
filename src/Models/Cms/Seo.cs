using Threenine.Models;

namespace Models.Cms;

public class Seo : BaseEntity
{
    public string MetaTitle { get; set; }
    public string MetaDescription { get; set; }
    public string MetaViewPort { get; set; }
    public string MetaRobots { get; set; }

    public virtual ICollection<Content> Contents { get; set; }
    
}