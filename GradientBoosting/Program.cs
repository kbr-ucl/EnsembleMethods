

var sampleData = new GradientBoosting.GradientBoosting.ModelInput()
{
    Id = 2F,
    SepalLengthCm = 49F,
    SepalWidthCm = 30F,
    PetalLengthCm = 14F,
    PetalWidthCm = 2F,
};

//Load model and predict output
var result = GradientBoosting.GradientBoosting.Predict(sampleData);

Console.WriteLine($"{result.PredictedLabel}");
