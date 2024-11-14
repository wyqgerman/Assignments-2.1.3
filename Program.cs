namespace Assignments_2._1._3
{
    class Maths
    {
        public static int Add(int num1, int num2)
        {
            return num1 + num2;
        }

        public static decimal Add(decimal num1, decimal num2, decimal num3)
        {
            return num1 + num2 + num3;
        }

        public static float Multiply(float num1, float num2)
        {
            return num1 * num2;
        }

        public static float Multiply(float num1, float num2, float num3)
        {
            return num1 * num2 * num3;
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Choose an operation:");
            Console.WriteLine("1. Add(int num1, int num2)");
            Console.WriteLine("2. Add(decimal num1, decimal num2, decimal num3)");
            Console.WriteLine("3. Multiply(float num1, float num2)");
            Console.WriteLine("4. Multiply(float num1, float num2, float num3)");

            Console.Write("Enter your choice (1-4): ");
            int choice = int.Parse(Console.ReadLine());

            switch (choice)
            {
                case 1:
                    Console.Write("Enter first integer: ");
                    int int1 = int.Parse(Console.ReadLine());
                    Console.Write("Enter second integer: ");
                    int int2 = int.Parse(Console.ReadLine());
                    Console.WriteLine("Result: " + Maths.Add(int1, int2));
                    break;

                case 2:
                    Console.Write("Enter first decimal: ");
                    decimal dec1 = decimal.Parse(Console.ReadLine());
                    Console.Write("Enter second decimal: ");
                    decimal dec2 = decimal.Parse(Console.ReadLine());
                    Console.Write("Enter third decimal: ");
                    decimal dec3 = decimal.Parse(Console.ReadLine());
                    Console.WriteLine("Result: " + Maths.Add(dec1, dec2, dec3));
                    break;

                case 3:
                    Console.Write("Enter first float: ");
                    float float1 = float.Parse(Console.ReadLine());
                    Console.Write("Enter second float: ");
                    float float2 = float.Parse(Console.ReadLine());
                    Console.WriteLine("Result: " + Maths.Multiply(float1, float2));
                    break;

                case 4:
                    Console.Write("Enter first float: ");
                    float float3 = float.Parse(Console.ReadLine());
                    Console.Write("Enter second float: ");
                    float float4 = float.Parse(Console.ReadLine());
                    Console.Write("Enter third float: ");
                    float float5 = float.Parse(Console.ReadLine());
                    Console.WriteLine("Result: " + Maths.Multiply(float3, float4, float5));
                    break;

                default:
                    Console.WriteLine("Invalid choice.");
                    break;
            }
        }
    }
}

