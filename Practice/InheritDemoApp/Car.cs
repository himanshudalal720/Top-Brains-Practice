using System;
Class Car:Vehical//Create a child class Car form base class vehical
{
    public Car(double distance,double hour,double fuel):base(distance,hour,fuel)
    {

    }
    public new void Averaeg()
    {
        double average =0.0;
        average=distance/fuel;
        Console.WriteLine("Average of the Car is {0:0.0}",averag);

    }
    public override void Speed()
    {
        double speed=0.0;
        speed=distance/hour;
        Console
    }
}