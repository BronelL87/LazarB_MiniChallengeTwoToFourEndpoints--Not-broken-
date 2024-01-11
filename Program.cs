using LazarB_MiniChallengeTwoToFourEndpoints.Services;
using LazarB_MiniChallengeTwoToFourEndpoints.Services.Add;
using LazarB_MiniChallengeTwoToFourEndpoints.Services.Add.GreaterOrLess;
using LazarB_MiniChallengeTwoToFourEndpoints.Services.Add.Time;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();
builder.Services.AddScoped<IAdditionServices, AdditionServices>();
builder.Services.AddScoped<ITimeServices, TimeServices>();
builder.Services.AddScoped<IGreaterOrLessServices, GreaterOrLessServices>();

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