using Autofac;
using Autofac.Extensions.DependencyInjection;
using Jazani.Senace.Reuniones.Aplicacion.Aplicacion.Contextos;
using Jazani.Senace.Reuniones.Infraestructura.Infraestructura.Contextos;
using Microsoft.AspNetCore.Mvc;

var builder = WebApplication.CreateBuilder(args);

//CORS
string[] corsOrigins = builder.Configuration.GetSection("CorsOrigins:urls").Get<String[]>()!;

var ProyectoApp = "SENACEV1";

// Add services to the container.

builder.Services.AddControllers();
builder.Services.Configure<ApiBehaviorOptions>(options =>
{
    options.SuppressModelStateInvalidFilter = true;
});

builder.Services.Configure<RouteOptions>(options =>
{
    options.LowercaseUrls = true;// urls minuscula
    options.LowercaseQueryStrings = true;
});
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

// Infrastructure
builder.Services.addInfrastructureServices(builder.Configuration);

// Applications
builder.Services.AddApplicationServices();

// Autofac
builder.Host.UseServiceProviderFactory(new AutofacServiceProviderFactory())
    .ConfigureContainer<ContainerBuilder>(options =>
    {
        options.RegisterModule(new InfraestructuraAutofacModule());
        options.RegisterModule(new AplicacionAutofacModulo());
    });

builder.Services.AddHttpClient();

builder.Services.AddCors(op =>
{
    op.AddPolicy(ProyectoApp, builder =>
    {
        builder.WithOrigins(corsOrigins)
        .SetIsOriginAllowedToAllowWildcardSubdomains()
        .AllowAnyMethod()
        .AllowAnyHeader()
        .WithMethods("GET", "POST", "PUT", "DELETE");
    });
});

var app = builder.Build();

app.UseSwagger();
app.UseSwaggerUI();

app.UseHttpsRedirection();
app.UseStaticFiles();
app.UseRouting();

app.UseCors(ProyectoApp);

app.UseAuthorization();

app.MapControllers();

app.Run();