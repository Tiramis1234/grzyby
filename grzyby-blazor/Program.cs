using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using grzyby.Data;
using grzyby.Models;

var builder = WebApplication.CreateBuilder(args);

// 1. Dodanie obsługi komponentów Blazora
builder.Services.AddRazorComponents()
    .AddInteractiveServerComponents();

// 2. Konfiguracja bazy danych (Domyślnie SQLite)
builder.Services.AddDbContext<ApplicationDbContext>(options =>
    options.UseSqlite(builder.Configuration.GetConnectionString("DefaultConnection") 
        ?? "Data Source=grzyby.db"));

// 3. Konfiguracja autoryzacji i stanu
builder.Services.AddCascadingAuthenticationState();

builder.Services.AddAntiforgery();

builder.Services.AddAuthentication(options =>
    {
        options.DefaultScheme = IdentityConstants.ApplicationScheme;
        options.DefaultSignInScheme = IdentityConstants.ExternalScheme;
    })
    .AddIdentityCookies();

builder.Services.AddIdentityCore<User>(options =>
    {
        options.SignIn.RequireConfirmedAccount = false;
        options.Password.RequireDigit = false;
        options.Password.RequiredLength = 6;
        options.Password.RequireNonAlphanumeric = false;
        options.Password.RequireUppercase = false;
    })
    .AddEntityFrameworkStores<ApplicationDbContext>()
    .AddSignInManager()
    .AddDefaultTokenProviders();

var app = builder.Build();

if (!app.Environment.IsDevelopment())
{
    app.UseExceptionHandler("/Error", createScopeForErrors: true);
    app.UseHsts();
}

app.UseHttpsRedirection();
app.UseStaticFiles();

// 4. KOLEJNOŚĆ MIDDLEWARE (BARDZO WAŻNE!)
app.UseAuthentication();
app.UseAuthorization();
app.UseAntiforgery(); // Musi być pod autoryzacją

// 5. Mapowanie komponentów
app.MapRazorComponents<grzyby.Components.App>()
    .AddInteractiveServerRenderMode();

// 6. Endpoint do wylogowywania (wywoływany z formularza w navbarze)
app.MapPost("/logout", async (SignInManager<User> signInManager) =>
{
    await signInManager.SignOutAsync();
    return Results.Redirect("/");
});



app.Run();