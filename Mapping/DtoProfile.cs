using AutoMapper;
using DTOs;
using RickNMortyDotnetApi.DTOs;
using RickNMortyDotnetApi.Models.Characters;
using RickNMortyDotnetApi.Models.Episodes;

namespace Mapping;

public class DtoProfile : Profile
{

    public DtoProfile()
    {
        CreateMap<Character, GetCharacterDto>();//.ReverseMap() de kullanabilirim;
        CreateMap<Episode, GetEpisodeDto>();//.ReverseMap() de kullanabilirim;

    }

}