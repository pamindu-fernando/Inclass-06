public class EntertainmentRobot : Robot
{
    public string EntertainmentFeature { get; set; }

    public EntertainmentRobot(string modelName, int batteryCapacity, string softwareVersion, string entertainmentFeature)
        : base(modelName, batteryCapacity, softwareVersion)
    {
        EntertainmentFeature = entertainmentFeature;
    }

    public override string GetTaskInfo() => $"entertainmentFeature={EntertainmentFeature}";
}
