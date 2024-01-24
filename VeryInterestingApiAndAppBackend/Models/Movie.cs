namespace VeryInterestingApiAndAppBackend.Models
{
    public class Movie
    {
        public int Id { get; set; }
        public string Title { get; set; } = null!;
        public string? Description { get; set; }
        public string? Director { get; set; }
        public int Length { get; set; }
        public double Rating { get; set; }
        public DateTime ReleaseDate { get; set; }
        public List<string>? Category { get; set; }
    }
}
