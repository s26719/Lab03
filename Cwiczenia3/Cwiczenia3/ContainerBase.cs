using System.Reflection;
using System.Reflection.Metadata.Ecma335;

namespace Cwiczenia3;

public class ContainerBase
{

    private static int LastSerialNumber = 0;
    public double LoadMass { get; set; }
    public double Height { get; set; }
    public double EmptyMass { get; set; }
    public double Depth { get; set; }
    public string SerialNumber { get; set; }
    public double MaxLoad { get; set; }

    public ContainerBase(double loadMass, double height, double emptyMass, double depth, double maxLoad, string containerType)
    {
        LoadMass = 0;
        Height = height;
        EmptyMass = emptyMass;
        Depth = depth;
        SerialNumber = GenerateSerialNumber(containerType);
        MaxLoad = maxLoad;
    }

    public void Load(double newLoad)
    {
        if (LoadMass + newLoad > MaxLoad)
        {
            throw new OverfillException("Container is full!");
        }
        else
        {
            LoadMass += newLoad;
        }
    }

    public void UnLoad()
    {
        LoadMass = 0;
    }

    private string GenerateSerialNumber(string containerType)
    {
        LastSerialNumber++;
        return $"KON-{containerType}-{LastSerialNumber}";
    }

    public class OverfillException : Exception
    {
        public OverfillException(string message) : base(message) {}
    }
}

