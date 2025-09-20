namespace _19._15
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<int> numeri = new List<int>();
            Random rnd = new Random();
            for (int i = 0; i < 10; i++)
            {
                numeri.Add(rnd.Next(1, 11));
            }

            foreach (int n in numeri)
                Console.WriteLine(n);

            int sommapari = 0;
            int sommadispari = 0;
            foreach (int n in numeri)
            {
                if (n % 2 == 0)
                    sommapari += n;
                else
                    sommadispari += n;
            }
            Console.WriteLine($"La somma dei numeri pari è {sommapari}");
            Console.WriteLine($"La somma dei numeri dispari è {sommadispari}");
        }
    }
}
