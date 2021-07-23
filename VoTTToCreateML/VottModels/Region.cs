using System.Collections.Generic;

namespace VoTTToCreateML.VottModels
{
    public record Region
    {
        public string Id { get; set; }
        public string Type { get; set; }
        public List<string> Tags { get; set; }
        public BoundingBox BoundingBox { get; set; }
        public List<RecordPoint> Points { get; set; }
    }
}
