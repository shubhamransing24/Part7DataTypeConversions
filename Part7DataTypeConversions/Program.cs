using System;

namespace Part7DataTypeConversions
{
    class Program
    {
        static void Main(string[] args)
        {
            //Implicit Conversion this conversion is done by the system for ur small data converted to larg data
            //1)if there is no data lose 2)if there is no error occured
            int a = 100;
            float f = a;
            Console.WriteLine("integer to float={0}",f);
            //Explicit conversions:This converstion is done by the devloper larg data type to smaller datatype
            //1)there may be the chance of error 2)and data may be lost
            float b = 100.23f;
            //using type cast operator conversion
            int c = (int)b;
            Console.WriteLine("float to int conversion:{0}", c);
            //using convert class method
            double d = 32.32;
            short s = Convert.ToSByte(d);
            Console.WriteLine(s);




        }
    }
}
