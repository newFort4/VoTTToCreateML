namespace VoTTToCreateML.VottModels
{
    /// <summary>
    /// Custom Point representing Native Point but only X, Y
    /// </summary>
    public record RecordPoint
    {
        public decimal X { get; set; }
        public decimal Y { get; set; }
    }
}
