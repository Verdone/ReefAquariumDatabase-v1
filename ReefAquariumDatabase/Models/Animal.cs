namespace ReefAquariumDatabase.Models
{
    public class Animal
    {
        public int Id { get; set; }
        public string AnimalName { get; set; }
        public string Genus { get; set; }
        public string Temperature { get; set; }
        public string Salinity { get; set; }
        public string Diet { get; set; }
        public string MinTankSize { get; set; }
        public string PriceRange { get; set; }
        public Animal()
        {
                
        }
    }
}
