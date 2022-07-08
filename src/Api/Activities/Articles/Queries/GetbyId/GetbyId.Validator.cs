using FluentValidation;
namespace Geekiam.Api.Activities.Articles.Queries.GetbyId;

public class Validator : AbstractValidator<Query>
{
    public Validator()
    {
        RuleFor(x => x.Id).NotEmpty();
    }       
}
