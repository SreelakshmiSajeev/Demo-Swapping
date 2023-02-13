namespace ConsoleApp13
{
    internal class Program
    {
        static void Main(string[] args)
        {
           
            int a = 5, b = 10, temp;
            Console.WriteLine("Before swap a= " + a + " b= " + b);
            temp = a;
            a = b;
            b = temp;
            Console.Write("After swap a= " + a + " b= " + b);
        }
    }
}