using System.Collections.Generic;

namespace VoTTToCreateML.VottModels
{
    public record AssetComponent
    {
        public Asset Asset { get; set; }
        public List<Region> Regions { get; set; }
        public string Version { get; set; }
    }
}
