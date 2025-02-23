﻿namespace Forecaster.Core.Entities.VideoGames
{
    public class Genre
    {
        public int Id { get; set; }
        public required string Name { get; set; }

        public ICollection<VideoGame> VideoGames { get; set; } = new List<VideoGame>();
    }
}
