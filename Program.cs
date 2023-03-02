using System;

namespace Operators_Hutton_Riley
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("INTEGERS");
            // Initializes an integer that multiplies two integers
            int intMult = 12 * 15;
            // Initializes an integer that adds two integers
            int intAdd = 84 + 68;
            // Prints the maximum and minimum of the two integer variables
            Console.WriteLine($"The max of {intMult} and {intAdd} is {Math.Max(intMult, intAdd)}. " + 
                     $"The min of the two is {Math.Min(intMult, intAdd)}");

            //Initializes boolean to see if intMult is greater than intAdd
            bool isIntGreater = intMult > intAdd;
            // Prints if intMult is greater than intAdd
            Console.WriteLine($"{intMult} is greater than {intAdd}, {isIntGreater}.\n");

            Console.WriteLine("SHORTS");
            // Initializes an short that multiplies two shorts
            short shortMult = 12 * 15;
            // Initializes an short that adds two shorts
            short shortAdd = 84 + 68;
            // Prints the maximum and minimum of the two short variables
            Console.WriteLine($"The max of {shortMult} and {shortAdd} is {Math.Max(shortMult, shortAdd)}. " + 
                     $"The min of the two is {Math.Min(shortMult, shortAdd)}");

            //Initializes boolean to see if shortMult is greater than shortAdd
            bool isshortGreater = shortMult > shortAdd;
            // Prints if shortMult is greater than shortAdd
            Console.WriteLine($"{shortMult} is greater than {shortAdd}, {isshortGreater}.\n");

            Console.WriteLine("LONGS");
            // Initializes an long that multiplies two long
            long longMult = 12 * 15;
            // Initializes an long that adds two long
            long longAdd = 84 + 68;
            // Prints the maximum and minimum of the two long variables
            Console.WriteLine($"The max of {longMult} and {longAdd} is {Math.Max(longMult, longAdd)}. " + 
                     $"The min of the two is {Math.Min(longMult, longAdd)}");

            //Initializes boolean to see if longMult is greater than longAdd
            bool islongGreater = longMult > longAdd;
            // Prints if longMult is greater than longAdd
            Console.WriteLine($"{longMult} is greater than {longAdd}, {islongGreater}.\n");

            Console.WriteLine("FLOATS");
            // Initializes an float that multiplies two float
            float floatMult = 12.5f * 15.8f;
            // Initializes an float that adds two float
            float floatAdd = 84.3f + 68.7f;
            // Prints the maximum and minimum of the two float variables
            Console.WriteLine($"The max of {floatMult} and {floatAdd} is {Math.Max(floatMult, floatAdd)}. " + 
                     $"The min of the two is {Math.Min(floatMult, floatAdd)}");

            //Initializes boolean to see if floatMult is greater than floatAdd
            bool isfloatGreater = floatMult > floatAdd;
            // Prints if floatMult is greater than floatAdd
            Console.WriteLine($"{floatMult} is greater than {floatAdd}, {isfloatGreater}.\n");

            Console.WriteLine("DOUBLES");
            // Initializes an double that multiplies two double
            double doubleMult = 12.69 * 15.51;
            // Initializes an double that adds two double
            double doubleAdd = 84.49 + 68.82;
            // Prints the maximum and minimum of the two double variables
            Console.WriteLine($"The max of {doubleMult} and {doubleAdd} is {Math.Max(doubleMult, doubleAdd)}. " + 
                     $"The min of the two is {Math.Min(doubleMult, doubleAdd)}");

            //Initializes boolean to see if doubleMult is greater than doubleAdd
            bool isdoubleGreater = doubleMult > doubleAdd;
            // Prints if doubleMult is greater than doubleAdd
            Console.WriteLine($"{doubleMult} is greater than {doubleAdd}, {isdoubleGreater}.\n");

            Console.WriteLine("DECIMALS");
            // Initializes an decimal that multiplies two decimal
            decimal decimalMult = (decimal)(12.64 * 15.15);
            // Initializes an decimal that adds two decimal
            decimal decimalAdd = (decimal)(84.55 + 68.49);
            // Prints the maximum and minimum of the two decimal variables
            Console.WriteLine($"The max of {decimalMult} and {decimalAdd} is {Math.Max(decimalMult, decimalAdd)}. " + 
                     $"The min of the two is {Math.Min(decimalMult, decimalAdd)}");

            //Initializes boolean to see if decimalMult is greater than decimalAdd
            bool isdecimalGreater = decimalMult > decimalAdd;
            // Prints if decimalMult is greater than decimalAdd
            Console.WriteLine($"{decimalMult} is greater than {decimalAdd}, {isdecimalGreater}.\n");
        }
    }
}
