namespace Cwiczenia3;

public class GasContainer : ContainerBase, IHazardNotifier
{
    public bool IsHazardous { get; set; }
    public double Pressure { get; set; }
    
    public GasContainer(double loadMass, double height, double emptyMass, double depth, double maxLoad, string containerType, bool isHazardous, double pressure) 
        : base(loadMass, height, emptyMass, depth, maxLoad, containerType)
    {
        IsHazardous = isHazardous;
        Pressure = pressure;
    }

    public void Load(double newLoad)
    {
        if (LoadMass + newLoad > MaxLoad)
        {
            NotifyDanger("load capacity of the gas container has been exceeded");
            throw new OverfillException("Load mass to high!");
        }
    }

    public void UnLoad()
    {
        if (LoadMass>0)
        {
            LoadMass = 0.05 * LoadMass;
        }
        
    }

    public void NotifyDanger(string message)
    {
        Console.WriteLine($"Danger: {message}");
    }
}