using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace RickNMortyDotnetApi.DTOs
{
    public class GetEpisodeDto
    {
        public int EpisodeNumber { get; set; }
        public string Title { get; set; } = null!;
        public string Description { get; set; } = null!;
        public DateTime ReleaseDate { get; set; }
    }
}