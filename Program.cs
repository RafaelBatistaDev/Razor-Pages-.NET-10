using Microsoft.EntityFrameworkCore;
using RazorPagesMovie.Data;

var builder = WebApplication.CreateBuilder(args);

// ──────────────────────────────────────────────
// Services
// ──────────────────────────────────────────────

builder.Services.AddRazorPages();

builder.Services.AddDbContext<MovieDbContext>(options =>
    options.UseSqlite(builder.Configuration.GetConnectionString("DefaultConnection")));

// Health checks for production monitoring
builder.Services.AddHealthChecks();

// Response caching & compression for performance
builder.Services.AddResponseCompression(options =>
{
    options.EnableForHttps = true;
});

var app = builder.Build();

// ──────────────────────────────────────────────
// Middleware Pipeline
// ──────────────────────────────────────────────

app.UseResponseCompression();

if (!app.Environment.IsDevelopment())
{
    app.UseExceptionHandler("/Error");
    app.UseHsts();
}
else
{
    app.UseDeveloperExceptionPage();
}

app.UseHttpsRedirection();
app.UseStaticFiles();
app.UseRouting();
app.UseAuthorization();

app.MapStaticAssets();
app.MapRazorPages().WithStaticAssets();

// Health check endpoint
app.MapHealthChecks("/health");

// ──────────────────────────────────────────────
// Database Initialization
// ──────────────────────────────────────────────

using (var scope = app.Services.CreateScope())
{
    var db = scope.ServiceProvider.GetRequiredService<MovieDbContext>();
    db.Database.EnsureCreated();
}

app.Run();
