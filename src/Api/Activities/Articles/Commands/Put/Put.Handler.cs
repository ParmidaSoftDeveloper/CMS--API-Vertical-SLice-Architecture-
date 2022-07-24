using System.Threading;
using System.Threading.Tasks;
using Dtos;
using MediatR;
using Threenine;
using Threenine.ApiResponse;
using Dtos.Articles.Put;

namespace  Geekiam.Api.Activities.Articles.Commands.Put;

public class Handler : IRequestHandler<Command, SingleResponse<Response>>
{
    private readonly IDataService _services;

    public Handler(IDataService services)
    {
        _services = services;
    }

    public async Task<SingleResponse<Response>> Handle(Command request, CancellationToken cancellationToken)
    {
        return await _services.Update<Models.Cms.Content, Article, Response>(x =>
            x.Id == request.Id, request.Article);
    }
}
