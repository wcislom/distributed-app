﻿namespace Forecaster.Core.Entities.VideoGames
{
    public class VideoGame
    {
        public int Id { get; set; }
        public  string? Title { get; set; }
        public string? Platform { get; set; }

        public int? DeveloperId { get; set; }

        public Developer? Developer { get; set; }

        public int? PublisherId { get; set; }

        public Publisher? Publisher { get; set; }

        // One to one relationship
        public VideoGameDetails? VideoGameDetails { get; set; }
    }
}
