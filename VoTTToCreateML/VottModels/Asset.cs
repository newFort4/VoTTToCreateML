namespace VoTTToCreateML.VottModels
{
    public record Asset
    {
        public string Format { get; set; }
        public string Id { get; set; }
        public string Name { get; set; }
        public string Path { get; set; }
        public Size Size { get; set; }
        public int State { get; set; }
        public int Type { get; set; }
    }
}
