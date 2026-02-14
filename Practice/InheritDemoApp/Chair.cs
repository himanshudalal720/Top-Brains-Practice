using system;

class chair : Furniture{
    public overirde void Accept()
    {
        Console.WriteLine("Enter no of chairs");
        num = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine("Enter Color : ");

        color=Convert.ToString(Console.ReadLine());
        Console.WriteLine("Enter Width : ");
        width = Convert.ToInt32(Console.ReadLine());

        Console.WriteLine("Enter Heigth : ");
        height = Convert.ToInt32(Console.ReadLine());

    }

    public override void Display()
    {
      Console.WriteLine("num of chair is :{0}",num);
      Console.WriteLine("color of chair is :{0}",color);
      Console.WriteLine("width of chair is :{0}",width);
      Console.WriteLine("height of chair is :{0}",height);

    }
}