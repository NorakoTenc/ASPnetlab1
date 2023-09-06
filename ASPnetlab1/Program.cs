using ASPnetlab1;

var builder = WebApplication.CreateBuilder(args);
var app = builder.Build();
var company = new Company("ORA DORA", 524, 53f);
var random = new Random();
var randomNumb = random.Next(0, 101);
app.UseMiddleware<MiddlewareRandomComp>(randomNumb);

app.Run(async (context) =>
{
    context.Response.ContentType = "text/html; charset=utf-8";
    await context.Response.WriteAsync($"<p>Name: {company.Name}</p>" +
                                      $"<p>Count: {company.StocksCount}</p>" +
                                      $"<p>Price: {company.StocksPrice}</p>" +
                                      $"<p>Number: {randomNumb}</p>");
});

app.Run();

