using lesson25_EF_Core_Blazor.Components;
using lesson25_EF_Core_Blazor.Data;
using lesson25_EF_Core_Blazor.Services;
using Microsoft.EntityFrameworkCore;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.AddRazorComponents()
    .AddInteractiveServerComponents();

//We added this..............................


// Registering EF Core 
//builder.Services.AddDbContext<AppDbContext>(options =>
//    options.UseSqlite("Data Source=app.db"));
builder.Services.AddDbContextFactory<AppDbContext>(options =>
    options.UseSqlite("Data Source=app.db"));
builder.Services.AddScoped<ProductService>();

//,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,

var app = builder.Build();


//we added this...........................


// We will use a simple EF Core feature called EnsureCreated() to create the database
// and the Products table automatically based on your Product model and AppDbContext.
// 🔽 Add this block right after app is built
/*
 * On first run, EF Core will:
 *  1) Create app.db if it doesn’t exist.
 *  2) Create the Products table according to the Product entity.
 *  3) On future runs, it will not drop the database; it will just ensure it exists.
 */
using (var scope = app.Services.CreateScope())
{
    var dbContext = scope.ServiceProvider.GetRequiredService<AppDbContext>();
    dbContext.Database.EnsureCreated();

}

//...................................




// Configure the HTTP request pipeline.
if (!app.Environment.IsDevelopment())
{
    app.UseExceptionHandler("/Error", createScopeForErrors: true);
    // The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
    app.UseHsts();
}
app.UseStatusCodePagesWithReExecute("/not-found", createScopeForStatusCodePages: true);
app.UseHttpsRedirection();

app.UseAntiforgery();

app.MapStaticAssets();
app.MapRazorComponents<App>()
    .AddInteractiveServerRenderMode();

app.Run();
