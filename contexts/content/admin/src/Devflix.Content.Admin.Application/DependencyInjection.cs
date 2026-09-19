using Devflix.Content.Admin.Application.EventHandlers;
using Devflix.Content.Admin.Application.UseCases.Categories.CreateCategory;
using Devflix.Content.Admin.Domain.Events;
using Devflix.Content.Admin.Domain.SeedWork;

using Microsoft.Extensions.DependencyInjection;

namespace Devflix.Content.Admin.Application;

public static class DependencyInjection
{
    extension(IServiceCollection services)
    {
        public IServiceCollection AddApplicationConfiguration()
        {
            services.AddMediatR(config => config.RegisterServicesFromAssemblyContaining<CreateCategoryUseCase>());

            services.AddScoped<IDomainEventPublisher, DomainEventPublisher>();
            services.AddTransient<IDomainEventPublisher, DomainEventPublisher>();
            services.AddTransient<IDomainEventHandler<VideoUploadedEvent>, SentToEncoderEventHandler>();

            return services;
        }
    }
}