namespace RelationsApp.Entities.OneToOne
{
    public class Country
    {
        public int Id { get; set; }
        public string Name { get; set; }

        // 1 - to - 1
        public City? City { get; set; }
        public int? CityId { get; set; }
    }
}