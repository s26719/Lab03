namespace Cwiczenia3;

public class LiquidContainer : ContainerBase, IHazardNotifier
{
    private const double DangerCapacity = 0.5;
    private const double normalCapacity = 0.9;

    private bool _isDangerous;
    private IHazardNotifier _hazardNotifierImplementation;
    private IHazardNotifier _hazardNotifierImplementation1;

    public LiquidContainer(double loadMass, double height, double emptyMass, double depth, string serialNumber,
        double maxLoad, bool isDangerous)
        : base(loadMass, height, emptyMass, depth, serialNumber, maxLoad)
    {
        _isDangerous = isDangerous;
    }

    public void NotifyDanger(string containerNumber)
    {
        _hazardNotifierImplementation1.NotifyDanger(containerNumber);
    }
}