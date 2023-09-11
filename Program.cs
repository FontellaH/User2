using Microsoft.EntityFrameworkCore;  //#6 add in the framework
using User2.Models; 


var builder = WebApplication.CreateBuilder(args);
var connectionString = builder.Configuration.GetConnectionString("DefaultConnection");  // #13 Create a variable to hold your connection string from appsetting.json


// Add services to the container.
builder.Services.AddControllersWithViews();
builder.Services.AddHttpContextAccessor();   //#1
builder.Services.AddSession(); 
builder.Services.AddDbContext<MyContext>(options =>  //#14 Accessing mycontext.cs file
{
    options.UseMySql(connectionString, ServerVersion.AutoDetect(connectionString));
});



var app = builder.Build();




// Configure the HTTP request pipeline.
if (!app.Environment.IsDevelopment())
{
    app.UseExceptionHandler("/Home/Error");
}


app.UseStaticFiles();
app.UseRouting();
app.UseAuthorization();
app.UseSession();   //#3 




app.MapControllerRoute(
    name: "default",
    pattern: "{controller=Home}/{action=Index}/{id?}");

app.Run();



//next create the model