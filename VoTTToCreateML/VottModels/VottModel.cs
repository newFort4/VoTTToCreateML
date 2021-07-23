using System.Collections.Generic;

namespace VoTTToCreateML.VottModels
{
    public record VottModel
    {
        public string Name { get; set; }
        public string SecurityToken { get; set; }
        public VideoSettings VideoSettings { get; set; }
        public List<Tag> Tags { get; set; }
        public string Id { get; set; }
        public string Version { get; set; }
        public string LastVisitedAssetId { get; set; }
        public Dictionary<string, AssetComponent> Assets { get; set; }
    }
}
