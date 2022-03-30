//Load sample data

using RandomForest;

var sampleData = new RandomForestModel.ModelInput()
{
    Id = 2F,
    SepalLengthCm = 49F,
    SepalWidthCm = 30F,
    PetalLengthCm = 14F,
    PetalWidthCm = 2F,
};

//Load model and predict output
FastForestWithOptions.Example();
var result = RandomForestModel.Predict(sampleData);

Console.WriteLine($"{result.PredictedLabel}");
