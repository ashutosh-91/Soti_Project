using Microsoft.EntityFrameworkCore;
using project.Models;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

builder.Services.AddTransient<DoctorRepository, DoctorRepositoryImpl>();
builder.Services.AddTransient<SpecializationRepository, SpecializationRepositoryImpl>();
builder.Services.AddTransient<SurgeryRepository, SurgeryRepositoryImpl>();
builder.Services.AddTransient<DoctorSpecializationRepository, DoctorSpecializationRepositoryImpl>();


builder.Services.AddDbContextPool<AppDbContext>(options =>
{
    options.UseSqlServer(builder.Configuration.GetConnectionString("mydb"));
});
builder.Services.AddCors(options =>
{
    options.AddDefaultPolicy(
        policy =>
        {
            policy.WithOrigins("http://localhost:4200").AllowAnyHeader()
                                                  .AllowAnyMethod();
        }
        );

});

var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseCors();

app.UseHttpsRedirection();

app.UseAuthorization();

app.MapControllers();

app.Run();
