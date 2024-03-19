namespace Cwiczenia3;

public class CoolContainter : ContainerBase
{
    public string ProductType { get; set; }
    public double Temprature  { get; set; }
    public CoolContainter(double loadMass, double height, double emptyMass, double depth, double maxLoad, string containerType, string productType, double temprature) : 
        base(loadMass, height, emptyMass, depth, maxLoad, containerType)
    {
        ProductType = productType;
        Temprature = temprature;
    }
}