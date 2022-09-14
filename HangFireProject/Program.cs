using Hangfire;
using HangFireProject.MyHangFire;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.AddScoped<ITxtSender, TxtSender>();
builder.Services.AddHangfire(a => a.UseSqlServerStorage(builder.Configuration.GetConnectionString("hangFireConnection")));
builder.Services.AddHangfireServer();
builder.Services.AddControllersWithViews();

var app = builder.Build();

// Configure the HTTP request pipeline.
if (!app.Environment.IsDevelopment())
{
    app.UseExceptionHandler("/Home/Error");
}
app.UseStaticFiles();
app.UseHangfireDashboard("/hangfire");
app.UseRouting();

app.UseAuthorization();

app.MapControllerRoute(
    name: "default",
    pattern: "{controller=Home}/{action=Index}/{id?}");

app.Run();
