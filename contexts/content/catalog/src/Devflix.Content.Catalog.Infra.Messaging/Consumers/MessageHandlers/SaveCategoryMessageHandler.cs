using Devflix.Content.Catalog.Infra.Messaging.Common;
using Devflix.Content.Catalog.Infra.Messaging.Models;

using MediatR;

namespace Devflix.Content.Catalog.Infra.Messaging.Consumers.MessageHandlers;

internal sealed class SaveCategoryMessageHandler(IMediator mediator) : IMessageHandler<CategoryPayloadModel>
{
    public async Task HandleMessageAsync(MessageModelPayload<CategoryPayloadModel> messageModel,
        CancellationToken cancellationToken)
    {
        var saveInput = messageModel.After!.ToSaveCategory();
        await mediator.Send(saveInput, cancellationToken);
    }
}