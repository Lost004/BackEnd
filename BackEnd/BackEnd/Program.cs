var builder = WebApplication.CreateBuilder(args);
builder.Services.AddControllersWithViews();


var app = builder.Build();
app.MapControllerRoute( "default",  "{controller=Home}/{action=index}/{id?}");
app.UseStaticFiles();

app.Run();
