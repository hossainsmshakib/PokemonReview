namespace PokemonReview.Models
{
    public class Owner
    {
        public int Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Gym { get; set; }
        public Country Country { get; set; } // 1-1 realtion
        public ICollection<PokemonOwner> PokemonOwners { get; set; }
    }
}
