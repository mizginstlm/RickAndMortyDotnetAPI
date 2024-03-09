using AutoMapper;
using DTOs;
using RickNMortyDotnetApi.Models.Characters;

namespace Mapping;

public class DtoProfile : Profile
{

    public DtoProfile()
    {
        CreateMap<Character, GetCharacterDto>();//.ReverseMap() de kullanabilirim;

    }

}