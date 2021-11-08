using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SET_1
{
    class Program
    {
        static void Main(string[] args)
        {
            //p1();
            //p2();
            //p3();
            //p4();
            //p5();
            //p6();
            //p7();
            //p8();
            //p9();
            //p10();
            //p11();
            p12();
        }

        /// <summary>
        /// Determinati cate numere integi divizibile cu n se afla in intervalul [a, b]. 
        /// </summary>
        private static void p12()
        {
            int n , a , b , count=0;
            Console.Write("a= ");
            a = int.Parse(Console.ReadLine());
            Console.Write("b= ");
            b = int.Parse(Console.ReadLine());
            Console.Write("n= ");
            n = int.Parse(Console.ReadLine());
            for (int i = a; i < b + 1; i++)
            {
                if (i % n == 0)
                {
                    count++;
                }
            }
            Console.WriteLine($"{count} numere sunt divizivbile cu {n} din intervalui [{a},{b}]");
        }

        /// <summary>
        /// Afisati in ordine inversa cifrele unui numar n.
        /// </summary>
        private static void p11()
        {
            int n, invers = 0, save;
            Console.Write("n= ");
            n = int.Parse(Console.ReadLine());
            save = n;
            while (n != 0)
            {
                invers = invers*10 + n % 10;
                n = n / 10;
            }
            Console.WriteLine($"inversul numarului {save} este {invers}");
        }

        /// <summary>
        /// Test de primalitate: determinati daca un numar n este prim.
        /// </summary>
        private static void p10()
        {
            int n ,obs=0;
            Console.Write("n= ");
            n = int.Parse(Console.ReadLine());
            for (int i = 2; i*i <= n && obs == 0; i++)
            {
                if (n % i == 0)
                {
                    obs += 1;
                }
            }
            if (obs == 0)
            {
                Console.WriteLine($"numarul {n} este numar prim");
            }
            else
            {
                Console.WriteLine($"numarul {n} nu este numar prim");
            }
        }

        /// <summary>
        /// Afisati toti divizorii numarului n. 
        /// </summary>
        private static void p9()
        {
            Console.Write("n= ");
            int n = int.Parse(Console.ReadLine());
            for (int i = 2; i <= n/2; i++)
            {
                if(n % i == 0)
                {
                    Console.WriteLine($"{i} este divizor al lui {n}");
                }
            }
        }

        /// <summary>
        /// (Swap restrictionat) Se dau doua variabile numerice a si b ale carori valori sunt date de intrare. 
        /// Se cere sa se inverseze valorile lor fara a folosi alte variabile suplimentare.  
        /// </summary>
        private static void p8()
        {
            int a, b;
            Console.Write("a= ");
            a = int.Parse(Console.ReadLine());
            Console.Write("b= ");
            b = int.Parse(Console.ReadLine());

            a = a + b;
            b = a - b;
            a = a - b;
            Console.WriteLine($"valorile interschimbate fara variabile suplimentare sunt, a={a} si b={b}");

        }

        /// <summary>
        /// (Swap) Se dau doua variabile numerice a si b ale carori valori sunt date de intrare. Se cere sa se inverseze valorile lor. 
        /// </summary>
        private static void p7()
        {
            int a, b, schimb = 0;
            Console.Write("a= ");
            a = int.Parse(Console.ReadLine());
            Console.Write("b= ");
            b = int.Parse(Console.ReadLine());

            schimb = a;
            a = b;
            b = schimb;
            Console.WriteLine($"valorile interschimbate sunt a= {a} si b={b}");


        }

        /// <summary>
        /// Detreminati daca trei numere pozitive a, b si c pot fi lungimile laturilor unui triunghi.
        /// </summary>
        private static void p6()
        {
            int a, b, c;
            Console.Write("a= ");
            a = int.Parse(Console.ReadLine());
            Console.Write("b= ");
            b = int.Parse(Console.ReadLine());
            Console.Write("c= ");
            c = int.Parse(Console.ReadLine());

            if(a + b > c && a + c > b && b + c > a)
            {
                Console.WriteLine($" lungimile {a} {b} {c} pot fii laturile unui triunghi");
            }
            else
            {
                Console.WriteLine($" lungimile {a} {b} {c} nu pot fii laturile unui triunghi");
            }
        }

        /// <summary>
        /// Extrageti si afisati a k-a cifra de la sfarsitul unui numar. Cifrele se numara de la dreapta la stanga. 
        /// </summary>
        private static void p5()
        {
            int k, n, u = 0, pastrez;
            
            Console.Write("numarul = ");
            n = int.Parse(Console.ReadLine());
            pastrez = n;
            Console.Write("extrageti cifra numarul = ");
            k = int.Parse(Console.ReadLine());
            for (int i = 0; i < k; i++)
            {
                u = n % 10;
                n = n / 10;
            }
            Console.WriteLine($"cifra {k} a numarului {pastrez} este {u}");
        }

        /// <summary>
        /// Detreminati daca un an y este an bisect. 
        /// </summary>
        private static void p4()
        {
            int y = int.Parse(Console.ReadLine());
            if (y % 4 == 0)
            {
                Console.WriteLine($"{y} este an bisect");
            }
            else
            {
                Console.WriteLine($"{y} nu este an bisect");
            }
        }

        /// <summary>
        /// Determinati daca n se divide cu k, unde n si k sunt date de intrare 
        /// </summary>
        private static void p3()
        {
            int n, k;
            Console.Write("n= ");
            n = int.Parse(Console.ReadLine());
            Console.WriteLine();
            Console.Write("k= ");
            k = int.Parse(Console.ReadLine());

            if(n % k  == 0)
            {
                Console.WriteLine($"numarul {n} se divide cu numarul  {k}");
            }
            else
            {
                Console.WriteLine($"numarul {n} nu se divide cu numarul  {k}");
            }
        }

        /// <summary>
        /// Rezolvati ecuatia de gradul 2 cu o necunoscuta: ax^2 + bx + c = 0, unde a, b si c sunt date de intrare. Tratati toate cazurile posibile. 
        /// </summary>
        private static void p2()
        {
            int a, b, c;
            double x1 , x2;
            a = int.Parse(Console.ReadLine());
            b = int.Parse(Console.ReadLine());
            c = int.Parse(Console.ReadLine());

            if (a == 0 && b !=0)
            {
                x1 = -(c / b);
                Console.WriteLine($"solutia ecuatiei {b}x + {c} = 0, este x = {x1}");
            }
            if (a==0 && b==0)
            {
                Console.WriteLine($"nu exista solutii x1, x2 pentru {c} = 0");
            }
            if (c==0)
            {
                x1 = 0;
                x2 = -(b / a);
                Console.WriteLine($" solutiile x1, x2 pentru ecuatia {a}x + {b} = 0 sunt x1 = {x1} si x2 = {x2}");
            }
            if (a != 0 && b != 0 && c != 0)
            {
                x1 = (-b + Math.Sqrt((b * b) - (4 * a * c))) / 2 * a;
                x2 = (-b - Math.Sqrt((b * b) - (4 * a * c))) / 2 * a;
                Console.WriteLine($"solutiile x1, x2 pentru ecuatia {a}x^2 + {b}x + {c} = 0 , sunt x1 = {x1} , x2 = {x2}");
            }
        }

        /// <summary>
        /// Rezolvati ecuatia de gradul 1 cu o necunoscuta: ax+b = 0, unde a si b sunt date de intrare.
        /// </summary>
        private static void p1()
        {
            int a, b;
            double x;
            a = int.Parse(Console.ReadLine());
            b = int.Parse(Console.ReadLine());

            if (a != 0 && b != 0)
            {
                x = -(b / a);
                Console.WriteLine($"solutia ecuatiei de gr 1 {a}x + {b} = 0, este x = {x}");
            }
            if(a==0)
            {
                Console.WriteLine($"nu exista solutie x pentru {b} = 0");
            }
            if (b==0)
            {
                Console.WriteLine($"solutia ecuatiei de gr 1 {a}x = 0, este x = 0");
            }
        }

    }
}
