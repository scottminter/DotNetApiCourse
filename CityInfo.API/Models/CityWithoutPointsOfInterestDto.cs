namespace CityInfo.API.Models
{
    /// <summary>
    /// A DTO for a City without Points of Interest
    /// </summary>
    public class CityWithoutPointsOfInterestDto
    {
        /// <summary>
        /// ID of the City
        /// </summary>
        public int Id { get; set; }

        /// <summary>
        /// The name of the City
        /// </summary>
        public string Name { get; set; } = string.Empty;

        /// <summary>
        /// The Description of the City
        /// </summary>
        public string? Description { get; set; }
    }
}
