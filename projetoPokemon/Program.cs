using Microsoft.Extensions.Options;
using projetoPokemon.Aplication.Configuration;
using projetoPokemon.Aplication.Interfaces;
using projetoPokemon.Aplication.Services;
using projetoPokemon.Helper.Interfaces;

var builder = WebApplication.CreateBuilder(args);


builder.Services.Configure<PokemonApiRoutes>(builder.Configuration.GetSection("PokemonApi"));
builder.Services.AddSingleton<IPokemonApiRoutes>(sp => sp.GetRequiredService<IOptions<PokemonApiRoutes>>().Value);


builder.Services.AddHttpClient<IPokemonService, PokemonService>((serviceProvider, client) =>
{
    var apiRoutes = serviceProvider.GetRequiredService<IPokemonApiRoutes>();
    client.BaseAddress = new Uri(apiRoutes.BaseUrl);
});


builder.Services.AddControllers();
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

var app = builder.Build();

if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI(c => c.SwaggerEndpoint("/swagger/v1/swagger.json", "Pokemon API v1"));
}

app.UseHttpsRedirection();
app.UseAuthorization();
app.MapControllers();
app.Run();
