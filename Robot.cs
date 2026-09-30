using System;

public abstract class Robot
{
    public string ModelName { get; set; }
    public int BatteryCapacity { get; set; } // hours
    public string SoftwareVersion { get; set; }

    protected Robot(string modelName, int batteryCapacity, string softwareVersion)
    {
        ModelName = modelName;
        BatteryCapacity = batteryCapacity;
        SoftwareVersion = softwareVersion;
    }

    // Prototype: every robot knows how to clone itself
    public Robot Clone() => (Robot)MemberwiseClone();

    public abstract string GetTaskInfo();

    public override string ToString() =>
        $"{GetType().Name} [model={ModelName}, battery={BatteryCapacity}h, software=v{SoftwareVersion}, {GetTaskInfo()}]";
}
