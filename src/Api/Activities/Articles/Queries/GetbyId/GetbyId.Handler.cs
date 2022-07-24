using AutoMapper;
using MediatR;
using Threenine.ApiResponse;
using Threenine.Data;
using Dtos.Articles.Get;

namespace Geekiam.Api.Activities.Articles.Queries.GetbyId;

public class Handler : IRequestHandler<Query, SingleResponse<Response>>
{
    private readonly IUnitOfWork _unitOfWork;
    private readonly IMapper _mapper;

    public Handler(IUnitOfWork unitOfWork, IMapper mapper)
    {
        _unitOfWork = unitOfWork;
        _mapper = mapper;
    }

    public async Task<SingleResponse<Response>> Handle(Query request, CancellationToken cancellationToken)
    {
        var result = await _unitOfWork.GetReadOnlyRepositoryAsync<Models.Cms.Content>()
            .SingleOrDefaultAsync(predicate: x => x.Id == request.Id);
        
        return new SingleResponse<Response>(_mapper.Map<Response>(new Response { Article = _mapper.Map<Article>(result)}));
    }
}
