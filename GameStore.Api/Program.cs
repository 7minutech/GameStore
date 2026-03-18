using GameStore.Api.Dtos;

var builder = WebApplication.CreateBuilder(args);
var app = builder.Build();

List<GameDto> games = [
    new(1, "Street", "Fighting", 19.99M, new DateOnly(1992, 7, 15)),
    new(2, "Street2", "Fighting", 29.99M, new DateOnly(1993, 7, 15)),
    new(3, "Street3", "Fighting", 39.99M, new DateOnly(1994, 7, 15))
];

//Get /games
app.MapGet("/games", () => games);

app.Run();
