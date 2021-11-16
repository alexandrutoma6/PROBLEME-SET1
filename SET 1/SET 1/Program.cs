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
            Console.WriteLine("1. Rezolvati ecuatia de gradul 1 cu o necunoscuta: ax+b = 0, unde a si b sunt date de intrare. ");
            Console.WriteLine("2. Rezolvati ecuatia de gradul 2 cu o necunoscuta: ax^2 + bx + c = 0, unde a, b si c sunt date de intrare. Tratati toate cazurile posibile. ");
            Console.WriteLine("3. Determinati daca n se divide cu k, unde n si k sunt date de intrare. ");
            Console.WriteLine("4. Detreminati daca un an y este an bisect. ");
            Console.WriteLine("5. Extrageti si afisati a k-a cifra de la sfarsitul unui numar. Cifrele se numara de la dreapta la stanga. ");
            Console.WriteLine("6. Detreminati daca trei numere pozitive a, b si c pot fi lungimile laturilor unui triunghi. ");
            Console.WriteLine("7. (Swap) Se dau doua variabile numerice a si b ale carori valori sunt date de intrare. Se cere sa se inverseze valorile lor. ");
            Console.WriteLine("8. (Swap restrictionat) Se dau doua variabile numerice a si b ale carori valori sunt date de intrare. Se cere sa se inverseze valorile lor fara a folosi alte variabile suplimentare.  ");
            Console.WriteLine("9. Afisati toti divizorii numarului n. ");
            Console.WriteLine("10. Test de primalitate: determinati daca un numar n este prim.");
            Console.WriteLine("11. Afisati in ordine inversa cifrele unui numar n. ");
            Console.WriteLine("12. Determinati cate numere integi divizibile cu n se afla in intervalul [a, b]. ");
            Console.WriteLine("13. Determianti cati ani bisecti sunt intre anii y1 si y2.");
            Console.WriteLine("14. Determianti daca un numar n este palindrom. (un numar este palindrom daca citit invers obtinem un numar egal cu el, de ex. 121 sau 12321. ");
            Console.WriteLine("15. Se dau 3 numere. Sa se afiseze in ordine crescatoare. ");
            Console.WriteLine("16. Se dau 5 numere. Sa se afiseze in ordine crescatoare. (nu folositi tablouri)");
            Console.WriteLine("17. Determianti cel mai mare divizor comun si cel mai mic multiplu comun a doua numere. Folositi algoritmul lui Euclid.");
            Console.WriteLine("18. Afisati descompunerea in factori primi ai unui numar n.  De ex. pentru n = 1776 afisati2^4 x 3^1 x 37^1. ");
            Console.WriteLine("19. Determinati daca un numar e format doar cu 2 cifre care se pot repeta. De ex. 23222 sau 9009000 sunt astfel de numere, pe cand 593 si 4022 nu sunt. ");
            //Console.WriteLine("20. Afisati fractia m/n in format zecimal, cu perioada intre paranteze (daca e cazul). Exemplu: 13/30 = 0.4(3).");
            Console.WriteLine("21. Ghiciti un numar intre 1 si 1024 prin intrebari de forma ``numarul este mai mare sau egal decat x ?``.");
            Console.WriteLine();
            Console.Write("ALEGETI PROBLEMA NUMARUL: ");
            int problema = int.Parse(Console.ReadLine());

            Console.WriteLine();
            Console.WriteLine("------------------------------------------------------------------------------------------------");
            Console.WriteLine();

            if (problema == 1)
            {
                Console.WriteLine($"Ati ales problema numarul {problema}: ");
                Console.WriteLine();
                Console.WriteLine("1. Rezolvati ecuatia de gradul 1 cu o necunoscuta: ax+b = 0, unde a si b sunt date de intrare. ");
                Console.WriteLine();
                p1();
            }
            if (problema == 2)
            {
                Console.WriteLine($"Ati ales problema numarul {problema}: ");
                Console.WriteLine();
                Console.WriteLine("2. Rezolvati ecuatia de gradul 2 cu o necunoscuta: ax^2 + bx + c = 0, unde a, b si c sunt date de intrare. Tratati toate cazurile posibile. ");
                Console.WriteLine();
                p2();
            }
            if (problema == 3)
            {
                Console.WriteLine($"Ati ales problema numarul {problema}: ");
                Console.WriteLine();
                Console.WriteLine("3. Determinati daca n se divide cu k, unde n si k sunt date de intrare. ");
                Console.WriteLine();
                p3();
            }
            if (problema == 4)
            {
                Console.WriteLine($"Ati ales problema numarul {problema}: ");
                Console.WriteLine();
                Console.WriteLine("4. Detreminati daca un an y este an bisect. ");
                Console.WriteLine();
                p4();
            }
            if (problema == 5)
            {
                Console.WriteLine($"Ati ales problema numarul {problema}: ");
                Console.WriteLine();
                Console.WriteLine("5. Extrageti si afisati a k-a cifra de la sfarsitul unui numar. Cifrele se numara de la dreapta la stanga. ");
                Console.WriteLine();
                p5();
            }
            if (problema == 6)
            {
                Console.WriteLine($"Ati ales problema numarul {problema}: ");
                Console.WriteLine();
                Console.WriteLine("6. Detreminati daca trei numere pozitive a, b si c pot fi lungimile laturilor unui triunghi. ");
                Console.WriteLine();
                p6();
            }
            if (problema == 7)
            {
                Console.WriteLine($"Ati ales problema numarul {problema}: ");
                Console.WriteLine();
                Console.WriteLine("7. (Swap) Se dau doua variabile numerice a si b ale carori valori sunt date de intrare. Se cere sa se inverseze valorile lor. ");
                Console.WriteLine();
                p7();
            }
            if (problema == 8)
            {
                Console.WriteLine($"Ati ales problema numarul {problema}: ");
                Console.WriteLine();
                Console.WriteLine("8. (Swap restrictionat) Se dau doua variabile numerice a si b ale carori valori sunt date de intrare. Se cere sa se inverseze valorile lor fara a folosi alte variabile suplimentare.  ");
                Console.WriteLine();
                p8();
            }
            if (problema == 9)
            {
                Console.WriteLine($"Ati ales problema numarul {problema}: ");
                Console.WriteLine();
                Console.WriteLine("9. Afisati toti divizorii numarului n. ");
                Console.WriteLine();
                p9();
            }
            if (problema == 10)
            {
                Console.WriteLine($"Ati ales problema numarul {problema}: ");
                Console.WriteLine();
                Console.WriteLine("10. Test de primalitate: determinati daca un numar n este prim.");
                Console.WriteLine();
                p10();
            }
            if (problema == 11)
            {
                Console.WriteLine($"Ati ales problema numarul {problema}: ");
                Console.WriteLine();
                Console.WriteLine("11. Afisati in ordine inversa cifrele unui numar n. ");
                Console.WriteLine();
                p11();
            }
            if (problema == 12)
            {
                Console.WriteLine($"Ati ales problema numarul {problema}: ");
                Console.WriteLine();
                Console.WriteLine("12. Determinati cate numere integi divizibile cu n se afla in intervalul [a, b]. ");
                Console.WriteLine();
                p12();
            }
            if (problema == 13)
            {
                Console.WriteLine($"Ati ales problema numarul {problema}: ");
                Console.WriteLine();
                Console.WriteLine("13. Determianti cati ani bisecti sunt intre anii y1 si y2.");
                Console.WriteLine();
                p13();
            }
            if (problema == 14)
            {
                Console.WriteLine($"Ati ales problema numarul {problema}: ");
                Console.WriteLine();
                Console.WriteLine("14. Determianti daca un numar n este palindrom. (un numar este palindrom daca citit invers obtinem un numar egal cu el, de ex. 121 sau 12321. ");
                Console.WriteLine();
                p14();
            }
            if (problema == 15)
            {
                Console.WriteLine($"Ati ales problema numarul {problema}: ");
                Console.WriteLine();
                Console.WriteLine("15. Se dau 3 numere. Sa se afiseze in ordine crescatoare. ");
                Console.WriteLine();
                p15();
            }
            if (problema == 16)
            {
                Console.WriteLine($"Ati ales problema numarul {problema}: ");
                Console.WriteLine();
                Console.WriteLine("16. Se dau 5 numere. Sa se afiseze in ordine crescatoare. (nu folositi tablouri)");
                Console.WriteLine();
                p16();
            }
            if (problema == 17)
            {
                Console.WriteLine($"Ati ales problema numarul {problema}: ");
                Console.WriteLine();
                Console.WriteLine("17. Determianti cel mai mare divizor comun si cel mai mic multiplu comun a doua numere. Folositi algoritmul lui Euclid.");
                Console.WriteLine();
                p17();
            }
            if (problema == 18)
            {
                Console.WriteLine($"Ati ales problema numarul {problema}: ");
                Console.WriteLine();
                Console.WriteLine("18. Afisati descompunerea in factori primi ai unui numar n.  De ex. pentru n = 1776 afisati 2^4 x 3^1 x 37^1. ");
                Console.WriteLine();
                p18();
            }
            if (problema == 19)
            {
                Console.WriteLine($"Ati ales problema numarul {problema}: ");
                Console.WriteLine();
                Console.WriteLine("19. Determinati daca un numar e format doar cu 2 cifre care se pot repeta. De ex. 23222 sau 9009000 sunt astfel de numere, pe cand 593 si 4022 nu sunt. ");
                Console.WriteLine();
                p19();
            }
            if (problema == 21)
            {
                Console.WriteLine($"Ati ales problema numarul {problema}: ");
                Console.WriteLine();
                Console.WriteLine("21. Ghiciti un numar intre 1 si 1024 prin intrebari de forma ``numarul este mai mare sau egal decat x ?``.");
                Console.WriteLine();
                p21();
            }

            Console.WriteLine();
            Console.WriteLine("------------------------------------------------------------------------------------------------");
            Console.WriteLine();
        }

        private static void p21()
        {
            Console.WriteLine("NUMARUL N A FOST GENERAT (1-1024)");
            Random rnd = new Random();
            int numar = rnd.Next(1025);
            Console.WriteLine(numar);
            int x = 512;
            int y = 256;
            while(numar != x)
            {
                Console.WriteLine($"Numarul este mai mare decat {x}?");
                if (numar > x)
                {
                    Console.WriteLine("DA");
                    x = x + y / 2;
                    if (y > 2)
                    {
                        y /= 2;
                    }
                    
                }
                else if (numar < x)
                {
                    Console.WriteLine("NU");
                    x = x - y / 2;
                    if (y > 2)
                    {
                        y /= 2;
                    }
                }
                if(numar == x)
                {
                    break;
                }
            }
            Console.WriteLine($"Numarul N este = {numar}");
            
        }


        /// <summary>
        /// Determinati daca un numar e format doar cu 2 cifre care se pot repeta. De ex. 23222 sau 9009000 sunt astfel de numere, pe cand 593 si 4022 nu sunt.
        /// </summary>
        private static void p19()
        {
            int numar, cifra1 = 10, cifra2 = 10;
            Console.Write("numar = ");
            numar = int.Parse(Console.ReadLine());
            int Obs = 1, save = numar;
            if(numar > 9)
            {
                while (numar != 0 && Obs !=0)
                {
                    if (cifra1 == 10)
                    {
                        cifra1 = numar % 10;
                        numar /= 10;
                    }
                    if (cifra2 == 10 && numar % 10 != cifra1)
                    {
                        cifra2 = numar % 10;
                        numar /= 10;
                    }
                    if (numar % 10 != cifra1 && numar % 10 != cifra2)
                    {
                        Obs = 0;
                        break;
                    }
                    numar /= 10;
                }
                if(Obs == 0)
                {
                    Console.WriteLine($"Numarul {save} este format din mai mult de 2 cifre distincte");
                }
                else
                {
                    Console.WriteLine($"Numarul {save} este format din cel mult 2 cifre distincte");
                }
            }
            else
            {
                Console.WriteLine($"Numarul {save} este format dintr-o cifra ");
            }
        }

        /// <summary>
        /// Afisati descompunerea in factori primi ai unui numar n.  De ex. pentru n = 1776 afisati 2^3 x 3^1 x 7^2.
        /// </summary>
        private static void p18()
        {
            Console.Write("numar = ");
            int numar= int.Parse(Console.ReadLine());
            Console.WriteLine();
            int [] v = new int[numar];
            int save = numar;

            for (int i = 2; i <= save/2 ; i++)
            {
                while (numar % i == 0)
                {
                    v[i]++;
                    numar /= i;
                }
            }
            Console.WriteLine($"Numarul {save} se descompune in: ") ;
            for (int i = 2; i <= save; i++)
            {
                if (v[i] != 0)
                {
                    Console.WriteLine($" {i} ^ {v[i]} ;");
                }
            }
        }

        /// <summary>
        /// Determianti cel mai mare divizor comun si cel mai mic multiplu comun a doua numere. Folositi algoritmul lui Euclid. 
        /// </summary>
        private static void p17()
        {
            int a, b, rest=0, produs=0;
           
            Console.Write("a= ");
            a = int.Parse(Console.ReadLine());
            Console.Write("b= ");
            b = int.Parse(Console.ReadLine());
            int a1 = a, b2 = b; 
            produs = a * b;

            while(b > 0)
            {
                rest = a % b;
                a = b;
                b = rest;
            }
            Console.WriteLine($"cel mai mare divizor comun al numerelor {a1} si {b2} este {a}");
            Console.WriteLine($"cel mai mic multiplu comun al numerelor {a1} si {b2} este {produs/a}");

        }

        /// <summary>
        /// Se dau 5 numere. Sa se afiseze in ordine crescatoare. (nu folositi tablouri)
        /// </summary>
        private static void p16()
        {
            int a, b, c, d, e, aux = 0 ;
            Console.Write("a= ");
            a = int.Parse(Console.ReadLine());
            Console.Write("b= ");
            b = int.Parse(Console.ReadLine());
            Console.Write("c= ");
            c = int.Parse(Console.ReadLine());
            Console.Write("d= ");
            d = int.Parse(Console.ReadLine());
            Console.Write("e= ");
            e = int.Parse(Console.ReadLine());
            int a1, b2, c3, d4, e5;
            a1 = a;
            b2 = b;
            c3 = c;
            d4 = d;
            e5 = e;
            if (a > b)
            {
                aux = a;
                a = b;
                b = aux;
            }
            if (a > c)
            {
                aux = a;
                a = c;
                c = aux;
            }
            if (a > d)
            {
                aux = a;
                a = d;
                d = aux;
            }
            if (a > e)
            {
                aux = a;
                a = e;
                e = aux;
            }

            if (b > c)
            {
                aux = b;
                b = c;
                c = aux;
            }
            if (b > d)
            {
                aux = b;
                b = d;
                d = aux;
            }
            if (b > e)
            {
                aux = b;
                b = e;
                e = aux;
            }

            if (c > d)
            {
                aux = c;
                c = d;
                d = aux;
            }
            if (c > e)
            {
                aux = c;
                c = e;
                e = aux;
            }
            if (d > e)
            {
                aux = d;
                d = e;
                e = aux;
            }

            Console.WriteLine($"numerele {a1} {b2} {c3} {d4} {e5} ordonate crescator sunt {a} {b} {c} {d} {e}");
        }

        /// <summary>
        /// Se dau 3 numere. Sa se afiseze in ordine crescatoare. 
        /// </summary>
        private static void p15()
        {
            int a, b, c, minim, maxim, mijloc = 0;
            minim = int.MaxValue;
            maxim = int.MinValue;
            Console.Write("a= ");
            a = int.Parse(Console.ReadLine());
            Console.Write("b= ");
            b = int.Parse(Console.ReadLine());
            Console.Write("c= ");
            c = int.Parse(Console.ReadLine());

            if (a >= maxim)
            {
                maxim = a;
            }
            if (b >= maxim)
            {
                maxim = b;
            }
            if (c >= maxim)
            {
                maxim = c;
            }
            if (a <= minim)
            {
                minim = a;
            }
            if (b <= minim)
            {
                minim = b;
            }
            if (c <= minim)
            {
                minim = c;
            }
            mijloc = a + b + c  -minim - maxim;
            Console.WriteLine($"numerele {a},{b},{c} ordonate crescator: {minim}, {mijloc}, {maxim}");
        }

        /// <summary>
        /// Determianti daca un numar n este palindrom. (un numar este palindrom daca citit invers obtinem un numar egal cu el, de ex. 121 sau 12321. 
        /// </summary>
        private static void p14()
        {
            int n, invers = 0, save = 0;
            Console.Write("n= ");
            n = int.Parse(Console.ReadLine());
            save = n;
            while(n !=0)
            {
                invers = invers * 10 + (n % 10);
                n = n / 10;
            }
            if (save == invers)
            {
                Console.WriteLine($"numarul {save} este un plindrom");
            }
            else
            {
                Console.WriteLine($"numarul {save} nu este un plindrom");
            }
        }

        /// <summary>
        /// Determianti cati ani bisecti sunt intre anii y1 si y2.
        /// </summary>
        private static void p13()
        {
            int y1, y2, save=0;
            int count = 0;
            Console.Write("anul y1= ");
            y1 = int.Parse(Console.ReadLine());
            Console.Write("anul y2= ");
            y2 = int.Parse(Console.ReadLine());
            save = y1;
            if(y1 % 4 == 1)
            {
                y1 += 3;
            }
            if (y1 % 4 == 2)
            {
                y1 += 2;
            }
            if (y1 % 4 == 3)
            {
                y1 += 1;
            }
            for (int i = y1; i < y2; i+=4) //pentru optimizare se verifica din 4 in 4 ani cati ani sunt
            {
                if (i % 4 == 0)
                {
                    count++;
                }
            }
            Console.WriteLine($"intre anii {save} si {y2} sunt {count} ani bisecti");
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
