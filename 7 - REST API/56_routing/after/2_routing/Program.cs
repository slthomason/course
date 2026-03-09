var builder = WebApplication.CreateBuilder(args);

// Add services to the container.


//Attribute routing for REST APIs 1
builder.Services.AddControllers();


//Set up conventional route 1
//builder.Services.AddControllersWithViews();


// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseHttpsRedirection();

app.UseAuthorization();

//Attribute routing for REST APIs 2
app.MapControllers();

//Set up conventional route 2

//app.MapControllerRoute(
//    name: "default",
//    pattern: "{controller=Home}/{action=Index}/{id?}");


// set up Multiple Routes 

//app.MapControllerRoute(name: "blog",
//                pattern: "blog/api/{*article}",
//                defaults: new { controller = "Blog", action = "Article" },
//                constraints: new { article = @"\d+" } //Restriction for article
//                                                 );

//app.MapControllerRoute(name: "default",
//               pattern: "{controller=Home}/{action=Index}/{id:int?}");

//app.MapControllerRoute(name: "customerApi",
//                pattern: "customer/api/{controller}/{action}/{id?}",
//                defaults: new { controller = "Home", action = "Index" },
//                constraints: new { id = @"\d+" } //Restriction for article
//                                                 );

app.Run();
