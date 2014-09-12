using System;


namespace Globul
{

    class Gravitation
    {
        static void Main(string[] args)
        {
            Console.WriteLine("This program calculate what will be your weight on the Moon,\nbaced on your weight on the Earth");
            Console.Write("Please enter your weight:");
            string str = Console.ReadLine();
            double weightEarth = double.Parse(str);
            double weightMoon = (weightEarth * 0.17);
            Console.WriteLine("Your weight on the Moon will be:" + weightMoon);
            Console.ReadLine();

        }
    }
}      
