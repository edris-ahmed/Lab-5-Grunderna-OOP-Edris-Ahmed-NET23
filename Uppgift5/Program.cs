//Edris Ahmed (NET23)

namespace Uppgift5
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Circle myCircle5 = new Circle()
            {
                radius = 5,
            };

            myCircle5.GetArea();
            Console.WriteLine($"Arean för en cirkel med en radius av 5 är {myCircle5.GetArea()}.");

            Circle myCircle6 = new Circle() 
            { 
                radius = 6, 
            };

            myCircle6.GetArea();
            Console.WriteLine($"Arean för en cirkel med en radius av 6 är {myCircle6.GetArea()}.");


        }
    }
}