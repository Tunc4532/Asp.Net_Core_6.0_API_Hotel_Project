using AutoMapper;
using HotelProject.DTOLayer.Dtos.RoomDto;
using HotelProject.EntityLayer.Concrete;

namespace HotelProject.WebApi.Mapping
{
    public class AutoMapperConfig : Profile
    {
        public AutoMapperConfig()
        {
            CreateMap<CreateGuestDto, Room>().ReverseMap();
            CreateMap<UpdateGuestDto, Room>().ReverseMap();

        }
    }
}
