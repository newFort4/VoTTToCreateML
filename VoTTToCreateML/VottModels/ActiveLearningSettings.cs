namespace VoTTToCreateML.VottModels
{
    public record ActiveLearningSettings
    {
        public bool AutoDetect { get; set; }
        public bool PredictTag { get; set; }
        public string ModelPathType { get; set; }
    }
}
