using GameStore.Api.Dtos;

const string GetGameEndpointName = "GetGame";

var builder = WebApplication.CreateBuilder(args);
var app = builder.Build();

List<GameDto> games = [
    new(1, "Street", "Fighting", 19.99M, new DateOnly(1992, 7, 15)),
    new(2, "Street2", "Fighting", 29.99M, new DateOnly(1993, 7, 15)),
    new(3, "Street3", "Fighting", 39.99M, new DateOnly(1994, 7, 15))
];

//Get /games
app.MapGet("/games", () => games);


//Get /games 
app.MapGet("/games/{id}", (int id) => games.Find(game => game.Id == id)).WithName(GetGameEndpointName);

//Post /games
app.MapPost("/games", (CreateGame newGame) =>
{
    var game = new GameDto(games.Count + 1, newGame.Name, newGame.Genre, newGame.Price, newGame.ReleaseDate);
    games.Add(game);
    return Results.CreatedAtRoute("GetGame", new {id = game.Id}, game);
} 
);

app.Run();
