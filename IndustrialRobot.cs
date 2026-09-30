public class IndustrialRobot : Robot
{
    public string IndustrialTask { get; set; }

    public IndustrialRobot(string modelName, int batteryCapacity, string softwareVersion, string industrialTask)
        : base(modelName, batteryCapacity, softwareVersion)
    {
        IndustrialTask = industrialTask;
    }

    public override string GetTaskInfo() => $"industrialTask={IndustrialTask}";
}
