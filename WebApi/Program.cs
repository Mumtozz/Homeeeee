using Infrastructure.AutoMapper;
using Infrastructure.AutoMapper.StudentService;
using Infrastructure.Data;
using Infrastructure.Services.CourseService;
using Infrastructure.Services.GroupService;
using Microsoft.EntityFrameworkCore;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();
builder.Services.AddControllers();
builder.Services.AddScoped<IStudentService,StudentService>();
builder.Services.AddScoped<IGroupService,GroupService>();
builder.Services.AddScoped<ICourseService,CourseService>();

var connection = builder.Configuration.GetConnectionString("Connection");
builder.Services.AddDbContext<DataContext>(e => e.UseNpgsql(connection));


builder.Services.AddAutoMapper(typeof(MapperProfile));

var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseHttpsRedirection();

app.MapControllers();

app.Run();

