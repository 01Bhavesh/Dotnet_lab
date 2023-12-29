using DAL.connection;
using BAL;
var builder = WebApplication.CreateBuilder(args);
var app = builder.Build();

app.MapGet("/", () => "Hello World!");
app.MapGet("/api/pmp/activities",   ( ) =>{

    List<Food> items= BDManager.GetAllData();
    return items;
});

app.Run();
