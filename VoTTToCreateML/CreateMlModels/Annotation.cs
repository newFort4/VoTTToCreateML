namespace VoTTToCreateML.CreateMlModels
{
    public record Annotation
    {
        public string Label { get; set; }
        public Coordinates Coordinates { get; set; }
    }
}
