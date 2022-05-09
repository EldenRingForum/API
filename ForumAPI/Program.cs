using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using ForumAPI.Data;
using ForumAPI.Areas.WebForum.Data.Context;
using System.Security.Claims;
using Microsoft.AspNetCore.Authentication.JwtBearer;
using Microsoft.IdentityModel.Tokens;
using System.Text;

var builder = WebApplication.CreateBuilder(args);
string corsPolicyName = "CorsPolicy";
var Configuration = builder.Configuration;


#region connection strings
var identityConnectionString = builder.Configuration.GetConnectionString("IdentityContextConnection");
builder.Services.AddDbContext<IdentityContext>(options =>
    options.UseSqlServer(identityConnectionString));
var webForumConnectionString = builder.Configuration.GetConnectionString("WebForumContextConnection");
builder.Services.AddDbContext<WebForumContext>(options =>
    options.UseSqlServer(webForumConnectionString));
#endregion

#region Identity
builder.Services.AddIdentity<IdentityUser, IdentityRole>(options =>
{
    // Password settings.
    options.Password.RequireDigit = true;
    options.Password.RequireLowercase = true;
    options.Password.RequireNonAlphanumeric = true;
    options.Password.RequireUppercase = true;
    options.Password.RequiredLength = 8;
    options.Password.RequiredUniqueChars = 1;

    // Lockout settings.
    options.Lockout.DefaultLockoutTimeSpan = TimeSpan.FromMinutes(5);
    options.Lockout.MaxFailedAccessAttempts = 5;
    options.Lockout.AllowedForNewUsers = true;

    // User settings.
    options.User.AllowedUserNameCharacters =
    "abcdefghijklmnopqrstuvwxyzABCDEFGHIJKLMNOPQRSTUVWXYZ0123456789-._@+!";
    options.User.RequireUniqueEmail = true;
})
.AddEntityFrameworkStores<WebForumContext>()
.AddDefaultTokenProviders();

// COOKIE OPTIONS
builder.Services.ConfigureApplicationCookie(options =>
{
    options.Cookie.Name = "ASPNET";
    options.Cookie.SameSite = SameSiteMode.None;
});

// ADDING POLICIES FOR CLAIMS
builder.Services.AddAuthorization(options =>
{
    options.AddPolicy("ADMIN", policy =>
    {
        policy.RequireClaim(ClaimTypes.Role, "ADMIN");
        policy.RequireClaim(ClaimTypes.Role, "USER");
        policy.RequireAuthenticatedUser();
    });
    options.AddPolicy("USER", policy =>
    {
        policy.RequireClaim(ClaimTypes.Role, "USER");
        policy.RequireAuthenticatedUser();
    });
    options.AddPolicy("RequiredAuthenticatedUser", policy =>
    {
        policy.RequireAuthenticatedUser();
    });
});
#endregion

#region JWT
var jwtSettings = Configuration.GetSection("JWTSettings");
builder.Services.AddAuthentication(options =>
{
    options.DefaultAuthenticateScheme = JwtBearerDefaults.AuthenticationScheme;
    options.DefaultChallengeScheme = JwtBearerDefaults.AuthenticationScheme;
    options.DefaultScheme = JwtBearerDefaults.AuthenticationScheme;
}).AddJwtBearer(options =>
{
    options.Events = new JwtBearerEvents
    {
        OnMessageReceived = context =>
        {
            context.Token = context.Request.Cookies["WebForumApi"];
            return Task.CompletedTask;
        }
    };
    options.TokenValidationParameters = new TokenValidationParameters
    {
        ValidateIssuer = true,
        ValidateAudience = true,
        ValidateLifetime = true,
        ValidateIssuerSigningKey = true,

        ValidIssuer = jwtSettings.GetSection("validIssuer").Value,
        ValidAudience = jwtSettings.GetSection("validAudience").Value,
        IssuerSigningKey = new SymmetricSecurityKey(Encoding.UTF8.GetBytes(jwtSettings.GetSection("securityKey").Value))
    };
});
#endregion

#region Cors

builder.Services.AddCors(options =>
{
    options.AddPolicy(name: corsPolicyName,
                      builder =>
                      {
                          builder.WithOrigins("http://localhost:4200")
                            // Should be explained but should be able to just google the definition
                            .AllowAnyHeader()
                            .AllowCredentials();
                      });
});

// TODO: make cors policy
#endregion

// Add services to the container.
builder.Services.AddControllers();
builder.Services.AddMvc();

var app = builder.Build();

// Configure the HTTP request pipeline.
if (!app.Environment.IsDevelopment())
{
    app.UseExceptionHandler("/Home/Error");
    // The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
    app.UseHsts();
}

app.UseHttpsRedirection();
app.UseStaticFiles();

app.UseRouting();
app.UseCors(corsPolicyName);
app.UseAuthentication();
app.UseAuthorization();

app.UseEndpoints(endpoints =>
{
    endpoints.MapControllers();
});

app.Run();
