using ElmahCore.Mvc;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.AddRazorPages();

builder.Services.AddElmah();

var app = builder.Build();

app.UseElmahExceptionPage();

app.UseRouting();

app.UseElmah();

app.MapRazorPages();

app.Run();
