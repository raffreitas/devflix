using Codeflix.Catalog.Infra.Messaging.Models;

namespace Codeflix.Catalog.Infra.Messaging.Common;

public interface IMessageHandler<T> where T : class
{
    Task HandleMessageAsync(MessageModelPayload<T> messageModel, CancellationToken cancellationToken);
}