namespace VoTTToCreateML.VottModels
{
    public record BoundingBox
    {
        public decimal Height { get; set; }
        public decimal Width { get; set; }
        public decimal Left { get; set; }
        public decimal Top { get; set; }
    }
}
