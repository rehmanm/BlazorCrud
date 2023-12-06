namespace BlazorCrud.Shared.Entities
{
    public class Game
    {
        public int Id { get; set; }
        public required string Name { get; set; }

        public string? Description { get; set; }
    }
}
