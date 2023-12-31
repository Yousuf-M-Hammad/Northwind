using Northwind.Common.Context;
WebApplicationBuilder builder = WebApplication.CreateBuilder(args);
builder.Services.AddRazorPages();
builder.Services.AddNorthwindContext();
WebApplication app = builder.Build();


// Https redirection
if (!app.Environment.IsDevelopment())
{
    app.UseHsts();
    app.UseHttpsRedirection();
}

// loading static files
app.UseDefaultFiles();
app.UseStaticFiles();


// routing
app.MapRazorPages();
// app.MapGet("/", () => "This is the index");

app.Run();