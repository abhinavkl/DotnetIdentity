using DotnetIdentity;
using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
//using DotnetIdentity.Models.AppUser;
//using DotnetIdentity.Models.Note;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.


//builder.Services.AddDbContext<AppUsersContext>(options => options.UseSqlServer(Startup.AppUserDbConnectionString));

//builder.Services.AddDbContext<NotesContext>(options => options.UseSqlServer(Startup.NoteDbConnectionString));

//builder.Services.AddIdentity<User, IdentityRole>(options =>
//{
//    options.Password.RequiredLength = 8;
//    options.Password.RequireLowercase = true;
//    options.Password.RequireUppercase = true;

//    options.Lockout.MaxFailedAccessAttempts = 5;
//    options.Lockout.DefaultLockoutTimeSpan = TimeSpan.FromMinutes(15);
//})
//.AddEntityFrameworkStores<AppUsersContext>()
//.AddDefaultTokenProviders();

builder.Services.ConfigureApplicationCookie(options =>
{
    options.LoginPath = "/Account/Login";
    options.AccessDeniedPath = "/Account/AccessDenied";
});

builder.Services.AddRazorPages();

var app = builder.Build();

// Configure the HTTP request pipeline.
if (!app.Environment.IsDevelopment())
{
    app.UseExceptionHandler("/Error");
    // The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
    app.UseHsts();
}

app.UseHttpsRedirection();
app.UseStaticFiles();

app.UseRouting();

app.UseAuthentication();
app.UseAuthorization();

app.MapRazorPages();

app.Run();


