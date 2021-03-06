// This file was auto-generated by ML.NET Model Builder. 

using Microsoft.ML;
using Microsoft.ML.Data;

namespace GradientBoosting;

public partial class GradientBoosting
{
    private static readonly string MLNetModelPath = Path.GetFullPath("GradientBoosting.zip");

    public static readonly Lazy<PredictionEngine<ModelInput, ModelOutput>> PredictEngine =
        new(() => CreatePredictEngine(), true);

    /// <summary>
    ///     Use this method to predict on <see cref="ModelInput" />.
    /// </summary>
    /// <param name="input">model input.</param>
    /// <returns>
    ///     <seealso cref=" ModelOutput" />
    /// </returns>
    public static ModelOutput Predict(ModelInput input)
    {
        var predEngine = PredictEngine.Value;
        return predEngine.Predict(input);
    }

    private static PredictionEngine<ModelInput, ModelOutput> CreatePredictEngine()
    {
        var mlContext = new MLContext();
        var mlModel = mlContext.Model.Load(MLNetModelPath, out var _);
        return mlContext.Model.CreatePredictionEngine<ModelInput, ModelOutput>(mlModel);
    }

    /// <summary>
    ///     model input class for DemoModel.
    /// </summary>

    #region model input class

    public class ModelInput
    {
        [ColumnName(@"Id")] public float Id { get; set; }

        [ColumnName(@"SepalLengthCm")] public float SepalLengthCm { get; set; }

        [ColumnName(@"SepalWidthCm")] public float SepalWidthCm { get; set; }

        [ColumnName(@"PetalLengthCm")] public float PetalLengthCm { get; set; }

        [ColumnName(@"PetalWidthCm")] public float PetalWidthCm { get; set; }

        [ColumnName(@"Species")] public string Species { get; set; }
    }

    #endregion

    /// <summary>
    ///     model output class for DemoModel.
    /// </summary>

    #region model output class

    public class ModelOutput
    {
        [ColumnName(@"Id")] public float Id { get; set; }

        [ColumnName(@"SepalLengthCm")] public float SepalLengthCm { get; set; }

        [ColumnName(@"SepalWidthCm")] public float SepalWidthCm { get; set; }

        [ColumnName(@"PetalLengthCm")] public float PetalLengthCm { get; set; }

        [ColumnName(@"PetalWidthCm")] public float PetalWidthCm { get; set; }

        [ColumnName(@"Species")] public uint Species { get; set; }

        [ColumnName(@"Features")] public float[] Features { get; set; }

        [ColumnName(@"PredictedLabel")] public string PredictedLabel { get; set; }

        [ColumnName(@"Score")] public float[] Score { get; set; }
    }

    #endregion
}