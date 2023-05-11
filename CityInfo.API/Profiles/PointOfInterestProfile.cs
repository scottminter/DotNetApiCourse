using AutoMapper;

namespace CityInfo.API.Profiles
{
    public class PointOfInterestProfile: Profile
    {
        public PointOfInterestProfile()
        {
            CreateMap<Entities.PointOfInterests, Models.PointOfInterestDto>();
            CreateMap<Models.PointOfInterestForCreationDto, Entities.PointOfInterests>();
            CreateMap<Models.PointOfInterestForUpdateDto, Entities.PointOfInterests>();
            CreateMap<Entities.PointOfInterests, Models.PointOfInterestForUpdateDto>();
        }
    }
}
