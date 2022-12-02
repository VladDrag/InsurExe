using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
var builder = WebApplication.CreateBuilder(args);
builder.Services.AddDbContext<InsuranceContext>(options =>
        options.UseSqlite(builder.Configuration.GetConnectionString("InsuranceContext") ?? throw new InvalidOperationException("Connection string 'InsuranceMovieContext' not found.")));

// Add services to the container.
// docker build -t insurexedockimage .
// docker run -it -p 3000:80 -v /Users/vladdragomir/Desktop/SALT/CS/InsurExe/DummyDatabase:/DummyDatabase insurexedockimage -> the mounting must be made in accordance to APPSETTINGS.JSON, meaning that
// if in appsettings the path to the database is ../db_folder/, then that must mimic the structure of the docker file, which starts at / (before the app directory);
// in our case, the path ../DummyDatabase means that we must mount the Database in the  /, instead of the /app path

// https://localhost:7296/swagger/index.html for swagger testing
//dotnet run

builder.Services.AddControllers();

// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();


var app = builder.Build();
app.UseStaticFiles();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

//app.UseHttpsRedirection();

app.UseAuthorization();

app.MapControllers();

app.Run();
