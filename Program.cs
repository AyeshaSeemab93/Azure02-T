using Azure02.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Options;

var builder = WebApplication.CreateBuilder(args);


builder.Services.AddDbContext<Myazure02Context>(options =>
options.UseSqlServer(
    "Server=tcp:server-azure02.database.windows.net,1433;Initial Catalog=myazure02;Persist Security Info=False;User ID=tatiana;Password=543210aZ!;MultipleActiveResultSets=False;Encrypt=True;TrustServerCertificate=False;Connection Timeout=30;"
    ));

builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

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

// dotnet ef dbcontext scaffold 'Server=tcp:server-azure02.database.windows.net,1433;Initial Catalog=myazure02;Persist Security Info=False;User ID=tatiana;Password=543210aZ!;MultipleActiveResultSets=False;Encrypt=True;TrustServerCertificate=False;Connection Timeout=30;' Microsoft.EntityFrameworkCore.SqlServer -o Models