public class ServiceRobot : Robot
{
    public string ServiceTask { get; set; }

    public ServiceRobot(string modelName, int batteryCapacity, string softwareVersion, string serviceTask)
        : base(modelName, batteryCapacity, softwareVersion)
    {
        ServiceTask = serviceTask;
    }

    public override string GetTaskInfo() => $"serviceTask={ServiceTask}";
}
