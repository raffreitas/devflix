namespace Devflix.Content.Admin.Application.Interfaces;

public interface IMessageProducer
{
    Task SendMessageAsync<T>(T message, CancellationToken cancellationToken = default);
}