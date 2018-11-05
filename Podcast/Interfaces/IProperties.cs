using System.Collections.Generic;

namespace Podcast.Interfaces
{
    interface IProperties
    {
        Dictionary<string, List<string>> EpisodeSummary { get; set; }
        Dictionary<string, List<string>> Episodes { get; set; }
        string EpisodeCount { get; set; }
        string PodTitle { get; set; }
    }
}
