using Devflix.Content.Admin.Application.EventHandlers;
using Devflix.Content.Admin.Application.Interfaces;
using Devflix.Content.Admin.Domain.Events;

using Moq;

namespace Devflix.Content.Admin.UnitTests.Application.EventHandlers;

[Trait("Application", "EventHandlers")]
public sealed class SentToEncoderEventHandlerTest
{
    [Fact(DisplayName = nameof(HandleAsync))]
    public async Task HandleAsync()
    {
        var messageProducerMock = new Mock<IMessageProducer>();
        messageProducerMock
            .Setup(x => x.SendMessageAsync(It.IsAny<VideoUploadedEvent>(), It.IsAny<CancellationToken>()))
            .Returns(Task.CompletedTask);
        var handler = new SentToEncoderEventHandler(messageProducerMock.Object);
        VideoUploadedEvent @event = new(Guid.NewGuid(), "medias/video.mp4");

        await handler.HandleAsync(@event, CancellationToken.None);

        messageProducerMock
            .Verify(x => x.SendMessageAsync(@event, It.IsAny<CancellationToken>()), Times.Once);
    }
}