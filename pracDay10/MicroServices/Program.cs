using MAL.connected;
using BAL;


var builder = WebApplication.CreateBuilder(args);
var app = builder.Build();

app.MapGet("/", () => "Hello World!");


app.MapGet("/Show", () => {
    DBManager db = new DBManager();
    List<Food> lst = db.GetAllData();
    return lst;
});


app.Run();
