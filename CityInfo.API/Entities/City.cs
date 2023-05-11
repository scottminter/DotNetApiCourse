using System.ComponentModel.DataAnnotations;

namespace CityInfo.API.Entities
{
    public class City
    {
        public int Id { get; set; }

        [Required]
        [MaxLength(50)]
        public string Name { get; set; } = string.Empty;

        [MaxLength(200)]
        public string? Description { get; set; }
        
        public ICollection<PointOfInterests> PointOfInterests { get; set; } = new List<PointOfInterests>();

        public City(string name)
        {
            Name = name;
        }
    }
}
