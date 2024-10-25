using ThemeInt.BussinesService.ConCreate;
using ThemeInt.BussinesService.Interface;
using ThemeInt.DataBase;
using ThemeInt.Repo.ConCreate;
using ThemeInt.Repo.Interface;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.AddControllersWithViews();

builder.Services.AddScoped<IJobTypeRepo, JobTypeRepo>();
builder.Services.AddScoped<IJobRepo, JobRepo>();
builder.Services.AddScoped<IJobTypeservice, JobTypeService>();
builder.Services.AddScoped<IJobService, JobService>();
builder.Services.AddDbContext<JobPortalEfContext>();

var app = builder.Build();

// Configure the HTTP request pipeline.
if (!app.Environment.IsDevelopment())
{
    app.UseExceptionHandler("/Home/Error");
    // The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
    app.UseHsts();
}

app.UseHttpsRedirection();
app.UseStaticFiles();

app.UseRouting();

app.UseAuthorization();

app.MapControllerRoute(
    name: "default",
    pattern: "{controller=Home}/{action=Index}/{id?}");

app.Run();
