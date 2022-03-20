using WebApplicationTest1.Application;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.AddRazorPages();
string connectionString = builder.Configuration.GetConnectionString("ComplianceViewProto01Context");
builder.Services.AddScoped<IDiLoad>(sp => new DiLoad(connectionString));
builder.Services.AddScoped<IInnerLoad, InnerLoad>();
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

app.UseAuthorization();

app.MapRazorPages();

app.Run();
