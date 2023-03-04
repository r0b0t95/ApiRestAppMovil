using Microsoft.Data.SqlClient;
using Microsoft.EntityFrameworkCore;
using Api_FinalProject.Models;

internal class Program
{
    private static void Main(string[] args)
    {
        var builder = WebApplication.CreateBuilder(args);

        // Add services to the container.

        builder.Services.AddControllers();


        //------------------------------------------------------------------------------------------
        //add information to database
        //get information from appsetting.json

        var CnnStrBuilder = new SqlConnectionStringBuilder(
            builder.Configuration.GetConnectionString("CNNSTR"));

        //define local variable
        string cnnStr = CnnStrBuilder.ConnectionString;

        //define cnnstring to the project
        builder.Services.AddDbContext<AppNutritionContext>(options => options.UseSqlServer(cnnStr));
        //------------------------------------------------------------------------------------------


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
        //------------------------------------------------------------------------------------------
        app.UseRouting();
        //------------------------------------------------------------------------------------------

        app.UseAuthorization();

        app.MapControllers();

        app.Run();
    }
}