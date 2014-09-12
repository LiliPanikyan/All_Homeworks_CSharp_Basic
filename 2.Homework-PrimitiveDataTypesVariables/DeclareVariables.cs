using System;

namespace DeclareVariables
{
    class DeclareVariables
    {
        static void Main()
        {
            int intField ;       
            sbyte sbyteField ;
            long longField ;
            byte byteField ;
            short shortField;

            intField = 523130;
            sbyteField = -115;
            longField = 4825932;
            byteField = 97;
            shortField = -1000;
            Console.WriteLine("Int varieble: " + intField);
            Console.WriteLine("Sbyte variable: " + sbyteField);
            Console.WriteLine("Long variable: " + longField);
            Console.WriteLine("Byte variable: " + byteField);
            Console.WriteLine("Short variable: " + shortField);
            Console.ReadLine();
        }
    }
}
