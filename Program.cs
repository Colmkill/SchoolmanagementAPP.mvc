using Microsoft.EntityFrameworkCore;
using SchoolmanagementAPP.mvc.Data;

var builder = WebApplication.CreateBuilder(args);
// add services to the (inversion of control (IoC)) contanier
var conn = builder.Configuration.GetConnectionString("SchoolmanagementDbConnection");
builder.Services.AddDbContext<SchoolManagementDbContext>(q =>q.UseSqlServer(conn));
// Add services to the container.
builder.Services.AddControllersWithViews();

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
