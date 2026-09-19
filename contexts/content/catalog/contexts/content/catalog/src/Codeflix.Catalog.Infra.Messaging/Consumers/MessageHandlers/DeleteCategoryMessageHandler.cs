using Codeflix.Catalog.Infra.Messaging.Common;
using Codeflix.Catalog.Infra.Messaging.Models;

using Codeflix.Catalog.Domain.Exceptions;

using MediatR;

using Microsoft.Extensions.Logging;

namespace Codeflix.Catalog.Infra.Messaging.Consumers.MessageHandlers;

internal sealed class DeleteCategoryMessageHandler(ILogger<DeleteCategoryMessageHandler> logger, IMediator mediator)
    : IMessageHandler<CategoryPayloadModel>
{
    public async Task HandleMessageAsync(
        MessageModelPayload<CategoryPayloadModel> messageModel,
        CancellationToken cancellationToken)
    {
        try
        {
            var deleteInput = messageModel.Before!.ToDeleteCategory();
            await mediator.Send(deleteInput, cancellationToken);
        }
        catch (NotFoundException ex)
        {
            logger.LogError(ex, "Category with Id: {CategoryId} was not found. Message: {@Message}",
                messageModel.Before!.Id, messageModel);
        }
    }
}