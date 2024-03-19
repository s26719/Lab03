namespace Cwiczenia3;

public class LiquidContainer : ContainerBase, IHazardNotifier
{
    public bool IsHazardous { get; set; }
    

    public LiquidContainer(double height, double emptyMass, double depth, double maxLoad, string containerType, bool isHazardous)
        : base(0, height, emptyMass, depth, maxLoad,containerType)
    {
        IsHazardous = isHazardous;
    }

    public void Load(double newLoad)
    {
        double allowedLoad = IsHazardous ? MaxLoad * 0.5 : MaxLoad * 0.9;
        if (LoadMass+newLoad>allowedLoad)
        {
            NotifyDanger("load capacity of the liquid container has been exceeded");
            throw new OverfillException("Load mass to high!");
        }
        else
        {
            base.Load(newLoad);
        }
    }

    public void NotifyDanger(string message)
    {
        Console.WriteLine(message);
    }
    
}