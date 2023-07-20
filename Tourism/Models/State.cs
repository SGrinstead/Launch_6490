namespace Tourism.Models
{
    public class State
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Abbreviation { get; set; }
        public List<City> Cities { get; set; } = new List<City>();
    }
}
