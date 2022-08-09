namespace Models.Cms;

public class ContentSubject
{
    public Guid ContentId { get; set; }
    public Guid SubjectId { get; set; }

    public Content Content { get; set; }
    public Subject Subject { get; set; }

  
    
    
    
}