using MediatR;

namespace Devflix.Content.Admin.Application.UseCases.CastMembers.ListCastMembers;
public interface IListCastMembers
    : IRequestHandler<ListCastMembersInput, ListCastMembersOutput>
{
}
