using System;

namespace NullValue
{
    class NullValue
    {
        static void Main()
        {
            Nullable<int> nullIntValue = null;
            Nullable<double> nullDoubleValue = null;
            Console.WriteLine("Integer value whit assign null values is" + nullIntValue);
            Console.WriteLine("Double value whit assign null values is" + nullDoubleValue);

            nullIntValue = 0;
            nullDoubleValue = 0;
            nullIntValue += 4;
            nullDoubleValue += 4.2222222;
            {
                Console.WriteLine("After assigment Integer value is:" + nullIntValue);
                Console.WriteLine("After assigment Double value is:" + nullDoubleValue);
                Console.ReadLine();
            }
        }
    }
}