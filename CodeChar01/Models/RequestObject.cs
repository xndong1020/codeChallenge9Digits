using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace CodeChar01.Models
{
    public class RequestObject
    {
        public List<Payload> Payload { get; set; }
        public int Skip { get; set; }
        public int Take { get; set; }
        public int TotalRecords { get; set; }
    }

    public class Image
    {
        public string ShowImage { get; set; }
    }

    public class NextEpisode
    {
        public string Channel { get; set; }
        public string ChannelLogo { get; set; }
        public string Date { get; set; }
        public string Html { get; set; }
        public string Url { get; set; }
    }

    public class Season
    {
        public string Slug { get; set; }
    }

    public class Payload
    {
        public string Country { get; set; }
        public string Description { get; set; }
        public bool Drm { get; set; }
        public int EpisodeCount { get; set; }
        public string Genre { get; set; }
        public Image Image { get; set; }
        public string Language { get; set; }
        public NextEpisode NextEpisode { get; set; }
        public string PrimaryColour { get; set; }
        public List<Season> Seasons { get; set; }
        public string Slug { get; set; }
        public string Title { get; set; }
        public string TvChannel { get; set; }
    }
}