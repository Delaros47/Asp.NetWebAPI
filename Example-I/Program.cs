var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.AddRazorPages();
builder.Services.AddControllers(); // We have add AddControllers(); in order to activate Controller in our projects cause we will be using it

var app = builder.Build();

// Configure the HTTP request pipeline.
if (!app.Environment.IsDevelopment())
{
    app.UseExceptionHandler("/Error");
}
app.UseStaticFiles();

app.UseRouting();

app.MapControllers(); // We have added MapControllers(); in order to use endpoints means method in our Controllers

app.UseAuthorization();

app.MapRazorPages();

app.Run();
