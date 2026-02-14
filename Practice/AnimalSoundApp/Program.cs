using System;//nn
namespace AnimalSoundApp
{
    public class Program
    {
        public static void Main(string[] args)
        {
            int count;

            while (true)
            {
                string input = Console.ReadLine();
                if (int.TryParse(input, out count))
                    break;
            }

            if (count <= 0)
            {
                Console.WriteLine("Please enter a valid positive integer.");
                return;
            }

            Animal[] animals = new Animal[count];

            for (int i = 0; i < count; i++)
            {
                while (true)
                {
                    string type = Console.ReadLine().ToLower();

                    if (type == "animal")
                    {
                        animals[i] = new Animal();
                        break;
                    }
                    else if (type == "dog")
                    {
                        animals[i] = new Dog();
                        break;
                    }
                    else if (type == "cat")
                    {
                        animals[i] = new Cat();
                        break;
                    }
                }
            }

            Console.WriteLine("Sounds of the animals in the array:");
            foreach (Animal a in animals)
            {
                a.MakeSound();
            }
        }
    }
}