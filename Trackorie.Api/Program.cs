using Trackorie.DataInterface;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

switch(builder.Configuration.GetValue<string>("FoodRepository"))
{
    case "EFCore": 
        builder.Services.AddScoped<IFoodItemRepository, Trackorie.ORM.EntityFrameworkDemo.Service.FoodItemRepository>();
        break;
    case "Dapper":
        builder.Services.AddScoped<IFoodItemRepository, Trackorie.ORM.DapperDemo.Service.FoodItemRepository>();
        break;
    default:
        builder.Services.AddScoped<IFoodItemRepository, Trackorie.ORM.EntityFrameworkDemo.Service.FoodItemRepository>();
        break;
}

var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseHttpsRedirection();

app.UseAuthorization();

app.MapControllers();

app.Run();
