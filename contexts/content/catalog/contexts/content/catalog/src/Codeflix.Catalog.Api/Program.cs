using Codeflix.Catalog.Api.Categories;
using Codeflix.Catalog.Api.Filters;
using Codeflix.Catalog.Api.Genres;
using Codeflix.Catalog.Application;
using Codeflix.Catalog.Infra.Data.ES;
using Codeflix.Catalog.Infra.Messaging;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
// Learn more about configuring OpenAPI at https://aka.ms/aspnet/openapi
builder.Services.AddControllers();
builder.Services.AddOpenApi();
builder.Services
    .AddUseCases()
    .AddConsumers(builder.Configuration)
    .AddElasticSearch(builder.Configuration)
    .AddRepositories()
    .AddGraphQLServer()
    .AddQueryType()
    .AddMutationType()
    .AddTypeExtension<CategoryQueries>()
    .AddTypeExtension<CategoryMutations>()
    .AddTypeExtension<GenreQueries>()
    .AddErrorFilter<GraphQlErrorFilter>();

var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.MapOpenApi();
}

app.UseHttpsRedirection();

app.MapGraphQL();

app.MapControllers();

await app.RunAsync();

namespace Codeflix.Catalog.Api
{
    public abstract partial class Program
    {
        protected Program()
        {
        }
    }
}