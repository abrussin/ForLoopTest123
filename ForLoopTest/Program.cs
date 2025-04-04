namespace KujunditeArvutus
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Millist kujundit soovid?");
            Console.WriteLine("Valikud: ruut, ristkülik, kolmnurk, teemant");
            string kujund = Console.ReadLine().ToLower();

            switch (kujund)
            {
                case "ruut":
                    Ruut();
                    break;
                case "ristkülik":
                    Ristkylik();
                    break;
                case "kolmnurk":
                    Kolmnurk();
                    break;
                case "teemant":
                    Teemant();
                    break;
                default:
                    Console.WriteLine("Tundmatu kujund");
                    break;
            }

            Console.ReadKey();
        }

        static void Ruut()
        {
            Console.WriteLine("Sisesta ruudu külje pikkus: ");
            int side = Int32.Parse(Console.ReadLine());

            for (int i = 0; i < side; i++)
            {
                for (int j = 0; j < side; j++)
                {
                    Console.Write("*");
                }
                Console.WriteLine();
            }

            int umbermoot = 4 * side;
            int pindala = side * side;

            Console.WriteLine("Ruudu umbermoot on: " + umbermoot);
            Console.WriteLine("Ruudu pindala on: " + pindala);

        }

        static void Ristkylik()
        {
            Console.WriteLine("Sisesta ristküliku laius:");
            int laius = Int32.Parse(Console.ReadLine());

            Console.WriteLine("Sisesta ristküliku kõrgus:");
            int korgus = Int32.Parse(Console.ReadLine());

            for (int i = 0; i < korgus; i++)
            {
                for (int j = 0; j < laius; j++)
                {
                    Console.Write("*");
                }
                Console.WriteLine();
            }

            int umbermoot = 2 * (laius + korgus);
            int pindala = laius * korgus;

            Console.WriteLine("Ristkyliku umbermoot on: " + umbermoot);
            Console.WriteLine("Ristkyliku pindala on: " + pindala);
        }

        static void Kolmnurk()
        {
            Console.WriteLine("Sisesta kolmnurga kõrgus:");
            int korgus = Int32.Parse(Console.ReadLine());

            for (int i = 1; i <= korgus; i++)
            {
                for (int j = 1; j <= i; j++)
                {
                    Console.Write("*");
                }
                Console.WriteLine();
            }

            int umbermoot = 2 * korgus;
            double pindala = 0.5 * korgus * korgus;

            Console.WriteLine("Kolmnurga ümbermõõt on: " + umbermoot);
            Console.WriteLine("Kolmnurga pindala on: " + pindala);

        }


        static void Teemant()
        {
            Console.WriteLine("Sisesta teemanti poolne kõrgus (nt 3):");
            int n = Int32.Parse(Console.ReadLine());

            
            for (int i = 1; i <= n; i++)
            {
                for (int j = 1; j <= n - i; j++)
                    Console.Write(" ");
                for (int j = 1; j <= 2 * i - 1; j++)
                    Console.Write("*");
                Console.WriteLine();
            }

            
            for (int i = n - 1; i >= 1; i--)
            {
                for (int j = 1; j <= n - i; j++)
                    Console.Write(" ");
                for (int j = 1; j <= 2 * i - 1; j++)
                    Console.Write("*");
                Console.WriteLine();
            }

            int umbermoot = 4 * n; 
            int pindala = (2 * n - 1) * n; 

            Console.WriteLine("Teemanti ümbermõõt on (ligikaudne): " + umbermoot);
            Console.WriteLine("Teemanti pindala on (ligikaudne): " + pindala);
        }
    }
}
