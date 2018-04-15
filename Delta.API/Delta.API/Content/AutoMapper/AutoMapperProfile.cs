using AutoMapper;
using Delta.API.ViewModel;
using Delta.BLL;

namespace Delta.API.AutoMapper
{
    public class AutoMapperProfile : Profile
    {
        public AutoMapperProfile()
        {
            CreateMap<Person, PersonModel>();
        }
    }
}