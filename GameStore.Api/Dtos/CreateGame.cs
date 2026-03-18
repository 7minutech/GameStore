namespace GameStore.Api.Dtos;

public record class CreateGame
(
    string Name, 
    string Genre, 
    decimal Price, 
    DateOnly ReleaseDate 

);