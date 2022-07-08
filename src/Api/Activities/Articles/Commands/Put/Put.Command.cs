using Dtos.Articles.Put;
using MediatR;
using Threenine;
using Threenine.ApiResponse;
using Microsoft.AspNetCore.Mvc;

namespace  Geekiam.Api.Activities.Articles.Commands.Put;

public class Command : IRequest<SingleResponse<Response>>
{
   [FromRoute(Name = "id")] public Guid Id { get; set; }
   [FromBody] public Article Article { get; set; }
}


