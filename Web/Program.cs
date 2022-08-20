using Web.Interfaces;
using Web.Services;

var builder = WebApplication.CreateBuilder(args);

ConfigurationManager configuration = builder.Configuration;




builder.Services.AddControllersWithViews();

builder.Services.AddHttpClient<IReservationService, ReservationService>();
builder.Services.AddRazorPages();

var app = builder.Build();

app.UseHttpsRedirection();
app.UseStaticFiles();

app.UseRouting();

app.UseAuthorization();



app.MapControllerRoute(
    name: "default",
    pattern: "{controller=Reservation}/{action=GetAllReservations}/{id?}");

app.MapRazorPages();
app.Run();
