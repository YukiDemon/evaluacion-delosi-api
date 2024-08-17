using Delosi.BL.IServices;
using Delosi.BL.Services;
using Delosi.DA.Data;
using Delosi.DA.IRepositories;
using Delosi.DA.Repositories;
using evaluacion_delosi_api.Middleware;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();
builder.Services.AddScoped<IMatrizRepository, MatrizRepository>();
builder.Services.AddScoped<IMatrizServices, MatrizServices>();

//En este caso se cambiaría la conexíón para la BD que se fuera a utilizar 
//builder.Services.AddDbContext<ApplicationDbContext>(option =>
//    option.UseMySql.(builder.Configuration.GetConnectionString("")));

builder.Services.AddControllers()
    .AddJsonOptions(options =>
    {
        options.JsonSerializerOptions.PropertyNamingPolicy = null;
        options.JsonSerializerOptions.DefaultIgnoreCondition = System.Text.Json.Serialization.JsonIgnoreCondition.WhenWritingNull;
        options.JsonSerializerOptions.WriteIndented = true;
    });

var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseMiddleware<ErrorHandler>();

app.UseHttpsRedirection();
app.UseAuthorization();

app.MapControllers();

app.Run();
