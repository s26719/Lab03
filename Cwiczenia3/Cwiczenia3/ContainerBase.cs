using System.Reflection;
using System.Reflection.Metadata.Ecma335;

namespace Cwiczenia3;

public class ContainerBase
{
    public double LoadMass { get; set; }
    public double Height { get; set; }
    public double EmptyMass { get; set; }
    public double Depth { get; set; }
    public string SerialNumber { get; set; }
    public double MaxLoad { get; set; }

    public ContainerBase(double loadMass, double height, double emptyMass, double depth, string serialNumber, double maxLoad)
    {
        LoadMass = 0;
        Height = height;
        EmptyMass = emptyMass;
        Depth = depth;
        SerialNumber = serialNumber;
        MaxLoad = maxLoad;
    }

    public void Load(double newLoad)
    {
        if (LoadMass + newLoad > MaxLoad)
        {
            throw new OverflowException("Container is full!");
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

    public void generateSerialNumber()
    {
        
    }
}

