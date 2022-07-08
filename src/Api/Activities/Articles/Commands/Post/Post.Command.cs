using Dtos.Articles.Post;
using Threenine;
using MediatR;
using Threenine.ApiResponse;
using Microsoft.AspNetCore.Mvc;

namespace Geekiam.Api.Activities.Articles.Commands.Post;

public class Command : IRequest<SingleResponse<Response>>
{
      [FromBody] public Article Article { get; set; }  
}



