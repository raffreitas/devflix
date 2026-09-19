using Devflix.Content.Catalog.Infra.Messaging.Models;

namespace Devflix.Content.Catalog.Infra.Messaging.Common;

public interface IMessageHandler<T> where T : class
{
    Task HandleMessageAsync(MessageModelPayload<T> messageModel, CancellationToken cancellationToken);
}