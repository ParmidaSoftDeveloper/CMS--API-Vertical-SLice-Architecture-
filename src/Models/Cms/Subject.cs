using Threenine;
using Threenine.Models;

namespace Models.Cms;

public class Subject : BaseEntity
{
    
    public string Name { get; set; }
    public string Permalink { get; set; }
    public SubjectType SubjectType { get; set; }
}