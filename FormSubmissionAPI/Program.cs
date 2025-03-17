using FormSubmission.DAL.Repositories;
using FormSubmission.BLL.Services;

namespace FormSubmissionAPI
{
    public class Program
    {
        public static void Main(string[] args)
        {
            var builder = WebApplication.CreateBuilder(args);

            // Register your services
            // Registering FormSubmissionService to handle form submissions
            builder.Services.AddScoped<IFormSubmissionService, FormSubmissionService>();

            // Register FormSubmissionRepository to be used in the FormSubmissionService
            builder.Services.AddSingleton<FormSubmissionRepository>();

            // Enable CORS to allow requests from specific origins
            builder.Services.AddCors(options =>
            {
                options.AddPolicy("AllowVueFrontend", policy =>
                {
                    policy.WithOrigins("http://localhost:5173") // Vue.js frontend
                          .AllowAnyHeader()
                          .AllowAnyMethod();
                });
            });

            // Add controllers (MVC)
            builder.Services.AddControllers();

            // Add Swagger and OpenAPI generation support
            builder.Services.AddEndpointsApiExplorer();
            builder.Services.AddSwaggerGen();

            var app = builder.Build();

            // Configure the HTTP request pipeline for development environment
            if (app.Environment.IsDevelopment())
            {
                app.UseSwagger();
                app.UseSwaggerUI();
            }

            // Use CORS policy for handling frontend requests
            app.UseCors("AllowVueFrontend");

            // Enforce HTTPS redirection
            app.UseHttpsRedirection();

            // Enable authorization middleware
            app.UseAuthorization();

            // Map controllers for routing
            app.MapControllers();

            // Run the application
            app.Run();
        }
    }
}
