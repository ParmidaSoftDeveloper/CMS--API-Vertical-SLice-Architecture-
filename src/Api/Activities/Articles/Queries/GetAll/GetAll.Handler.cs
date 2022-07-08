using AutoMapper;
using Dtos;
using MediatR;
using Threenine.ApiResponse;
using Threenine.Data;
using Dtos.Articles.Get;

namespace  Geekiam.Api.Activities.Articles.Queries.GetAll;

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
        var results = await _unitOfWork.GetReadOnlyRepositoryAsync<Models.Cms.Article>()
            .GetListAsync( size: Int32.MaxValue);
        
        return new SingleResponse<Response>(new Response { Article = _mapper.Map<List<Article>>(results.Items)});
    }
}
