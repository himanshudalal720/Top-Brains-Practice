using System;
Class Program
{
    public static void Main(string[] args)
    {
        IPayment payment;
        payment = new CreditCardPayment();
        payment.Refund(1000.0);
        payment.Pay
        // public static void Main(string[] args)
        // {
        //     Furniture furniture;
        //     Bookshelve obj=new Bookshelve();
        //     obj.Accept();
        //     obj.Accept();
        //     furniture = new Char();

        //     Chair chair = new Chair();
        //     chair.Display();
        // }




        double distance=50.00;
        double hour=5.0;
        doule fuel=10.0;
        Vehical vehical = new Vehical(distance,hour,fuel)
        vehical.Average();
        vehical.Speed();

        Car car= new Car(distance,hour,fuel);
        car.Average();
        car.Speed();

    }
    public void Add()
}