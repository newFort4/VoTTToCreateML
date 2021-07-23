using System.Collections.Generic;

namespace VoTTToCreateML.CreateMlModels
{
    public record CreateMlModel
    {
        public string Image { get; set; }
        public List<Annotation> Annotations { get; set; }
    }
}
