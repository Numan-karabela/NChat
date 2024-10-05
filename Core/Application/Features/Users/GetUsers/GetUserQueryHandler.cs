using MediatR;
using NChat.Application.Abstractions.Repositorys;

namespace NChat.Application.Features.Users.GetUsers
{
    public class GetUserQueryHandler(IUserRepository nChatDb): IRequestHandler<GetUserQueryRequest, List<GetUserQueryResponse>> 
    {
       

        public async Task<List<GetUserQueryResponse>> Handle(GetUserQueryRequest request, CancellationToken cancellationToken)
        { 
            return await nChatDb.GetUsersAsync();
        }
        
    }
}
