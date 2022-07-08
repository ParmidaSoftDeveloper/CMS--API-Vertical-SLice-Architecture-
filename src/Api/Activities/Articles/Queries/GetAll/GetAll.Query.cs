using MediatR;
using Microsoft.AspNetCore.Mvc;
using Threenine.ApiResponse;
namespace Geekiam.Api.Activities.Articles.Queries.GetAll;

public class Query : IRequest<SingleResponse<Response>>
{
   [FromRoute]  public Guid Id { get; set; }   
}


