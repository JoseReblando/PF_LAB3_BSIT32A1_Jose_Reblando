namespace CardsTournament.Models
{
    public class Card
    {
        public int Id { get; set; }
        public string Name { get; set; } = string.Empty;
        public string Rarity { get; set; } = string.Empty;
        public string CharacterImage { get; set; } = string.Empty;
        public string Description { get; set; } = string.Empty;
    }
}
