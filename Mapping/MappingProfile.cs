using AutoMapper;
using corregidorApi.Controllers.Resources;
using corregidorApi.Models;

namespace corregidorApi.Mapping
{
    public class MappingProfile : Profile
    {
        public MappingProfile()
        {
            CreateMap<UserData, UserDataResource>();
        }
    }
}