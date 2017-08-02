using System;

namespace GigCommunity.Core.Dtos
{
    public class GigDto
    {
        public int Id { get; set; }
        public bool IsCanceled { get; set; }
        public UserDto Artist { get; set; }
        public DateTime DateTime { get; set; }
        public string Venue { get; set; }
        public GenreDto Genre { get; set; }
    }
}