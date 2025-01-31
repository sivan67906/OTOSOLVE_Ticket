WebApplicationBuilder? builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.AddControllersWithViews();

builder.Services.AddHttpClient("ApiGatewayCall", client =>
{
    //client.BaseAddress = new Uri("http://localhost:6300/"); //Api Gateway
    //client.BaseAddress = new Uri("https://avivgateway.vysncapital.com/"); //ServerApi Gateway
    //client.BaseAddress = new Uri("http://localhost:6201/api/"); //Configuration WebApi
    client.BaseAddress = new Uri("http://localhost:6301/api/"); //Environment WebApi
});

builder.Services.AddAuthentication().AddCookie("AvivClaimCookie", options =>
{
    options.Cookie.Name = "AvivClaimCookie";
    options.LoginPath = "/Account/Login";
    options.AccessDeniedPath = "/Account/AccessDenied";
});

builder.Services.AddAuthorization(options =>
{
    options.AddPolicy("AdminPolicy", policy => policy.RequireRole("Administrator"));
    options.AddPolicy("AdministratorTicketPolicy", policy => policy.RequireRole("Administrator"));
    options.AddPolicy("TeamLeadPolicy", policy => policy.RequireRole("TeamLead"));
    options.AddPolicy("SupportPolicy", policy => policy.RequireRole("SupportTeam"));
    options.AddPolicy("HRPolicy", policy => policy.RequireRole("HR"));
    options.AddPolicy("EmployeePolicy", policy => policy.RequireRole("Employee"));
});


WebApplication? app = builder.Build();

// Configure the HTTP request pipeline.
if (!app.Environment.IsDevelopment())
{
    app.UseExceptionHandler("/Home/Error");
    // The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
    app.UseHsts();
}


app.UseHttpsRedirection();
app.UseRouting();

app.UseAuthentication();
app.UseAuthorization();

app.MapStaticAssets();

//app.MapControllerRoute(
//    name: "Configuration",
//    pattern: "{area:exists}/{controller=Consumer}/{action=Consumer1}/{id?}")
//    .WithStaticAssets();

//app.MapControllerRoute(
//    name: "default",
//    pattern: "{controller=Home}/{action=Index}/{id:int?}")
//    .WithStaticAssets();

app.MapControllerRoute(
    name: "Admin",
    pattern: "{area:exists}/{controller=Dashboard}/{action=Index}/{id?}")
    .WithStaticAssets();

app.MapControllerRoute(
    name: "default",
    pattern: "{controller=Account}/{action=Login}/{id:int?}")
    //pattern: "{area:exists}/{controller=Dashboard}/{action=Index}/{id?}")
    .WithStaticAssets();

app.MapDefaultControllerRoute();

app.Run();