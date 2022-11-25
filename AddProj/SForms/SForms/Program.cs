using Microsoft.EntityFrameworkCore;
using SForms.DbClass;
using SForms.Reposetry;

namespace SForms
{
    public class Program
    {
        public static void Main(string[] args)
        {
            var builder = WebApplication.CreateBuilder(args);

            // Add services to the container.

            builder.Services.AddControllers();
            builder.Services.AddScoped<ICity, CityService>();
            builder.Services.AddScoped<IState, State>();
            builder.Services.AddScoped<IRegistration, RegistrationService>();
            builder.Services.AddScoped<IStandard, StandardName>();
            builder.Services.AddCors(option =>
            {
                option.AddPolicy("AllowOrigin", policy =>
                {
                    policy.WithOrigins("http://localhost:4200/")
                   .AllowAnyOrigin()
                   .AllowAnyHeader()
                   .AllowAnyMethod();
                });
            }) ;        
                //option.AddPolicy("AllowOrgin", policy =>
                //{
                //    policy.WithOrigins("http://localhost:4200/")
                //    .AllowAnyOrigin()
                //    .AllowAnyHeader()
                //    .AllowAnyMethod();
                //}));

            
            builder.Services.AddDbContext<AppDbClass>(options =>
            {
                options.UseSqlServer(builder.Configuration.GetConnectionString("DbConnection"));
            });
            // Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
            builder.Services.AddEndpointsApiExplorer();
            builder.Services.AddSwaggerGen();

            var app = builder.Build();
            app.UseCors("AllowOrgin");

            // Configure the HTTP request pipeline.
            if (app.Environment.IsDevelopment())
            {
                app.UseSwagger();
                app.UseSwaggerUI();
            }

            app.UseAuthorization();


            app.MapControllers();

            app.Run();
        }
    }
}