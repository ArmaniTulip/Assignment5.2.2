namespace Assignment5._2._2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter how many natural numbers to print");
            NaturalNumbers(Convert.ToInt32(Console.ReadLine()));
            
        }

        static void NaturalNumbers(int n)
        {
            if (n == 1)
            {
                Console.WriteLine(n);
            }
            else
            {
                NaturalNumbers(n-1);
                Console.WriteLine("" + n);
            }
        }
        

        


        

    }
}
