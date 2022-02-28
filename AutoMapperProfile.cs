using AutoMapper;
using dotnet_app.Dtos.Character;
using dotnet_app.Models;

namespace dotnet_app.Services.CharacterService
{
    public class AutoMapperProfile : Profile

    {
        public AutoMapperProfile()
        {
            CreateMap<Character, GetCharacterDto>();
            CreateMap<AddCharacterDto, Character>();
        }
    }
}