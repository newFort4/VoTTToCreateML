using System;
using System.IO;
using System.Linq;
using System.Text.Json;
using VoTTToCreateML.CreateMlModels;
using VoTTToCreateML.VottModels;

var inputFilePath = "../../../Example.json";
var inputFileContent = await File.ReadAllTextAsync(inputFilePath);

var jsonSerializerOptions = new JsonSerializerOptions
{
    PropertyNameCaseInsensitive = true,
    PropertyNamingPolicy =  JsonNamingPolicy.CamelCase
};

var vottModel = JsonSerializer.Deserialize<VottModel>(inputFileContent, jsonSerializerOptions);

var outputModel = vottModel.Assets.Select(x => new CreateMlModel
{
    Image = x.Value.Asset.Name,
    Annotations = x.Value.Regions.Select(x => new Annotation
    {
        Label = x.Tags.First(), // ToDo: Rewrite this to use not single label
        Coordinates = new Coordinates
        {
            X = (int) x.BoundingBox.Left,
            Y = (int) x.BoundingBox.Top,
            Width = (int) x.BoundingBox.Width,
            Height = (int) x.BoundingBox.Height
        }
    }).ToList()
}).ToList();

var outputFilePath = "Output.json";
var outputFileContent = JsonSerializer.Serialize(outputModel, jsonSerializerOptions);

await File.WriteAllTextAsync(outputFilePath, outputFileContent);