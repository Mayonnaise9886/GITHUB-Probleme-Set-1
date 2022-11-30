using System;
using System.Collections.Specialized;
using System.Reflection.PortableExecutable;

namespace Tema2
{
    class Program
    {
        static void Main(string[] args)
        {


            string DN = "DA";
            while (DN == "DA")
            {

                Console.ForegroundColor = ConsoleColor.Green;
                Console.WriteLine("Introduceti numarul problemei: \n");
                Console.ForegroundColor = ConsoleColor.White;


                int nrpb = Convert.ToInt32(Console.ReadLine());
                switch (nrpb)
                {
                    case 1:

                        Console.WriteLine("Cerinta este: Rezolvati ecuatia de gradul 1 cu o necunoscuta: ax+b = 0, unde a si b sunt date de intrare.\n");

                        double a, b, x;
                        Console.WriteLine("a: ");
                        a = Convert.ToDouble(Console.ReadLine());
                        Console.WriteLine("b: ");
                        b = Convert.ToDouble(Console.ReadLine());

                        if (a == 0)
                            if (b == 0)
                                Console.WriteLine("Imposibil");
                            else
                                Console.WriteLine("Imposibil");
                        else
                        {
                            x = -b / a;
                            Console.WriteLine("x = " + x);
                        }

                        Console.ForegroundColor = ConsoleColor.Green;
                        Console.WriteLine("Doriti sa mai verificati probleme? (DA/NU)\n");
                        Console.ForegroundColor = ConsoleColor.White;

                        DN = Console.ReadLine().ToUpper();
                        break;

                    case 2:

                        Console.WriteLine("Cerinta este: Rezolvati ecuatia de gradul 2 cu o necunoscuta: ax^2 + bx + c = 0\n");

                        double a1, b1, c, x1, x2, delta;
                        Console.WriteLine("a: ");
                        a1 = Convert.ToDouble(Console.ReadLine());
                        Console.WriteLine("b: ");
                        b1 = Convert.ToDouble(Console.ReadLine());
                        Console.WriteLine("c: ");
                        c = Convert.ToDouble(Console.ReadLine());
                        if (a1 == 0)
                            if (b1 == 0)
                                if (c == 0)
                                    Console.WriteLine("Imposibil");
                                else
                                    Console.WriteLine("Imposibil");
                            else
                            {
                                x1 = -c / b1;
                                Console.WriteLine("Ecgr1 cu x = " + x1);
                            }
                        else
                        {
                            delta = b1 * b1 - 4 * a1 * c;
                            if (delta < 0)
                                Console.WriteLine("X nu apartine multimii numerelor reale");
                            else
                            {
                                if (delta == 0)
                                {
                                    x1 = x2 = -b1 / (2 * a1);
                                    Console.WriteLine("Solutia este :" + x1);
                                }

                                else
                                {
                                    x1 = (-b1 + Math.Sqrt(delta)) / (2 * a1);
                                    x2 = (-b1 - Math.Sqrt(delta)) / (2 * a1);
                                    Console.WriteLine("Solutiile sunt: " + x1 + ", " + x2);
                                }
                            }
                        }
                        Console.ForegroundColor = ConsoleColor.Green;
                        Console.WriteLine("Doriti sa mai verificati probleme? (DA/NU)\n");
                        Console.ForegroundColor = ConsoleColor.White;

                        DN = Console.ReadLine().ToUpper();
                        break;

                    case 3:

                        Console.WriteLine("Cerinta este: Determinati daca n se divide cu k, unde n si k sunt date de intrare\n");

                        double n, k;
                        Console.WriteLine("n: ");
                        n = Convert.ToDouble(Console.ReadLine());
                        Console.WriteLine("k: ");
                        k = Convert.ToDouble(Console.ReadLine());
                        if (n % k == 0)
                            Console.WriteLine("n se divide cu k\n");
                        else
                            Console.WriteLine("n nu se divide cu k\n");

                        Console.ForegroundColor = ConsoleColor.Green;
                        Console.WriteLine("Doriti sa mai verificati probleme? (DA/NU)\n");
                        Console.ForegroundColor = ConsoleColor.White;

                        DN = Console.ReadLine().ToUpper();

                        break;

                    case 4:

                        Console.WriteLine("Cerinta este: Determinati daca un an este bisect sau nu\r\nIntroduceti anul");

                        int an;
                        Console.WriteLine("An: ");
                        an = Convert.ToInt32(Console.ReadLine());
                        if (an % 4 == 0 && an % 100 != 0 && an % 400 != 0)
                            Console.WriteLine("anul este bisect");
                        else
                            Console.WriteLine("anul nu este bisect");

                        Console.ForegroundColor = ConsoleColor.Green;
                        Console.WriteLine("Doriti sa mai verificati probleme? (DA/NU)\n");
                        Console.ForegroundColor = ConsoleColor.White;

                        DN = Console.ReadLine().ToUpper();

                        break;

                    case 5:

                        Console.WriteLine("Cerinta este: Extrageti si afisati a k-a cifra de la sfarsitul unui numar");

                        int n3, n2, elim = 0, k1, nrcf = 0, c1, p = 1;
                        Console.WriteLine("n: ");

                        n3 = Convert.ToInt32(Console.ReadLine());
                        Console.WriteLine("k: ");

                        k = Convert.ToInt32(Console.ReadLine());
                        n2 = n3;

                        while (n2 != 0)
                        {
                            n2 /= 10;
                            nrcf++;
                        }

                        for (int i = 1; i <= nrcf; i++)
                        {
                            if (i == k)
                            {
                                Console.WriteLine("cifra eliminata este: " + n3 % 10);
                            }
                            n3 /= 10;
                        }

                        Console.ForegroundColor = ConsoleColor.Green;
                        Console.WriteLine("Doriti sa mai verificati probleme? (DA/NU)\n");
                        Console.ForegroundColor = ConsoleColor.White;

                        DN = Console.ReadLine().ToUpper();

                        break;

                    case 6:

                        Console.WriteLine("Cerinta este: Determinati daca trei numere pozitive a, b si c pot fi lungimile laturilor unui triunghi.");

                        int a3, b3, c3;
                        Console.WriteLine("a: ");
                        a3 = Convert.ToInt32(Console.ReadLine());

                        Console.WriteLine("b: ");
                        b3 = Convert.ToInt32(Console.ReadLine());

                        Console.WriteLine("c: ");
                        c3 = Convert.ToInt32(Console.ReadLine());

                        if (a3 + b3 > c3 && b3 + c3 > a3 && a3 + c3 > b3)
                            Console.WriteLine("a, b, c formeaza un triunghi");
                        else
                            Console.WriteLine("a, b, c nu formeaza un triunghi");

                        Console.ForegroundColor = ConsoleColor.Green;
                        Console.WriteLine("Doriti sa mai verificati probleme? (DA/NU)\n");
                        Console.ForegroundColor = ConsoleColor.White;

                        DN = Console.ReadLine().ToUpper();

                        break;

                    case 7:

                        Console.WriteLine("Cerinta este: Inversati valorile a doua date de intrare\r\nIntroduceti cele doua valori:");

                        int a4 = Convert.ToInt32(Console.ReadLine());
                        int b4 = Convert.ToInt32(Console.ReadLine());

                        (a4, b4) = (b4, a4);

                        Console.WriteLine("Valorile inversate sunt: " + a4 + " si " + b4);

                        Console.ForegroundColor = ConsoleColor.Green;
                        Console.WriteLine("Doriti sa mai verificati probleme? (DA/NU)\n");
                        Console.ForegroundColor = ConsoleColor.White;

                        DN = Console.ReadLine().ToUpper();

                        break;

                    case 8:
                        Console.WriteLine("Cerinta este: Inversati valorile a doua date de intrare fara a folosi valori aditionale\r\nIntroduceti cele doua valori:");

                        int a5 = Convert.ToInt32(Console.ReadLine());
                        int b5 = Convert.ToInt32(Console.ReadLine());

                        (a5, b5) = (b5, a5);

                        Console.WriteLine("Valorile inversate sunt: " + a5 + " si " + b5);

                        Console.ForegroundColor = ConsoleColor.Green;
                        Console.WriteLine("Doriti sa mai verificati probleme? (DA/NU)\n");
                        Console.ForegroundColor = ConsoleColor.White;

                        DN = Console.ReadLine().ToUpper();

                        break;

                    case 9:

                        Console.WriteLine("Cerinta este: Afisati toti divizorii numarului n.\r\nIntroduceti numarul n:\n");

                        int n4 = Convert.ToInt32(Console.ReadLine());

                        Console.WriteLine("Divizorii lui n sunt: ");

                        for(int i2 = 1; i2 <= n4/2; i2++)
                            if(n4 % i2 == 0)
                                Console.WriteLine(i2 + " ");
                        Console.WriteLine(n4);


                        Console.ForegroundColor = ConsoleColor.Green;
                        Console.WriteLine("Doriti sa mai verificati probleme? (DA/NU)\n");
                        Console.ForegroundColor = ConsoleColor.White;

                        DN = Console.ReadLine().ToUpper();

                        break;

                    case 10:

                        Console.WriteLine("Cerinta este: Determinati daca un numar n este prim.\r\nIntroduceti numarul n");

                        int n5 = Convert.ToInt32(Console.ReadLine()), nrdiv = 0;

                        for (int i3 = 1; i3 <= n5 / 2; i3++)
                            if (n5 % i3 == 0)
                                nrdiv++;

                        if(nrdiv == 1)
                            Console.WriteLine("Numarul este prim\n");
                        else
                            Console.WriteLine("Numarul nu este prim\n");

                        Console.ForegroundColor = ConsoleColor.Green;
                        Console.WriteLine("Doriti sa mai verificati probleme? (DA/NU)\n");
                        Console.ForegroundColor = ConsoleColor.White;

                        DN = Console.ReadLine().ToUpper();

                        break;

                    case 11:

                        Console.WriteLine("Cerinta este: Afisati in ordine inversa cifrele unui numar n\r\nIntroduceti numarul n:");

                        int n6 = Convert.ToInt32(Console.ReadLine());

                        Console.WriteLine("Cifrele lui n scrise in ordine inversa sunt:");

                        while(n6 != 0)
                        {
                            Console.WriteLine(n6 % 10);
                            n6 = n6 / 10;
                        }

                        Console.ForegroundColor = ConsoleColor.Green;
                        Console.WriteLine("Doriti sa mai verificati probleme? (DA/NU)\n");
                        Console.ForegroundColor = ConsoleColor.White;

                        DN = Console.ReadLine().ToUpper();

                        break;

                    case 12:

                        Console.WriteLine("Cerinta este: Determinati cate numere integi divizibile cu n se afla in intervalul [a, b]\r\nIntroduceti numarul n:\n");

                        int n7 = Convert.ToInt32(Console.ReadLine());

                        Console.WriteLine("Introduceti numerele a si b:\n");

                        int a6 = Convert.ToInt32(Console.ReadLine());
                        int b6 = Convert.ToInt32(Console.ReadLine());

                        for(int i4 = a6; i4 <= b6; i4++)
                        {
                            if(i4 % n7 == 0)
                                Console.WriteLine(i4);
                        }

                        Console.ForegroundColor = ConsoleColor.Green;
                        Console.WriteLine("Doriti sa mai verificati probleme? (DA/NU)\n");
                        Console.ForegroundColor = ConsoleColor.White;

                        DN = Console.ReadLine().ToUpper();

                        break;

                    case 13:

                        Console.WriteLine("Cerinta este: Determinati cati ani bisecti sunt intre anii y1 si y2\r\nIntroduceti anii y1 si y2:");

                        int y1 = Convert.ToInt32(Console.ReadLine());
                        int y2 = Convert.ToInt32(Console.ReadLine());
                        int nrani = 0;
                        
                        for(int i5 = y1; i5 <= y2; i5++)
                        {
                            if (i5 % 4 == 0 && i5 % 100 != 0 && i5 % 400 != 0)
                                nrani++;
                        }
                        Console.WriteLine("Sunt " + nrani + " ani bisecti in intervalul [" + y1 + ", " + y2 + "]");

                        Console.ForegroundColor = ConsoleColor.Green;
                        Console.WriteLine("Doriti sa mai verificati probleme? (DA/NU)\n");
                        Console.ForegroundColor = ConsoleColor.White;

                        DN = Console.ReadLine().ToUpper();

                        break;

                    case 14:

                        Console.WriteLine("Cerinta este: Determianti daca un numar n este palindrom\n");

                        int n8, r, sum = 0, temp;
                        Console.Write("Introduceti numarul:\n");
                        n8 = int.Parse(Console.ReadLine());
                        temp = n8;
                        while (n8 > 0)
                        {
                            r = n8 % 10;
                            sum = (sum * 10) + r;
                            n8 = n8 / 10;
                        }
                        if (temp == sum)
                            Console.Write("Numarul este un palindrom\n");
                        else
                            Console.Write("Numarul nu este un palindrom\n");

                        Console.ForegroundColor = ConsoleColor.Green;
                        Console.WriteLine("Doriti sa mai verificati probleme? (DA/NU)\n");
                        Console.ForegroundColor = ConsoleColor.White;

                        DN = Console.ReadLine().ToUpper();

                        break;

                    case 15:

                        Console.WriteLine("Cerinta este: Se dau 3 numere. Sa se afiseze in ordine crescatoare.\r\nIntroduceti cele 3 numere");

                        int a9 = Convert.ToInt32(Console.ReadLine());
                        int b9 = Convert.ToInt32(Console.ReadLine());
                        int c9 = Convert.ToInt32(Console.ReadLine());

                        int max = Math.Max(a9, Math.Max(b9, c9));
                        int min = Math.Min(a9, Math.Min(b9, c9));
                        Console.WriteLine($"{min}, {a9 + b9 + c9 - max - min}, {max}");

                        Console.ForegroundColor = ConsoleColor.Green;
                        Console.WriteLine("Doriti sa mai verificati probleme? (DA/NU)\n");
                        Console.ForegroundColor = ConsoleColor.White;

                        DN = Console.ReadLine().ToUpper();
                        break;

                    case 16:
                        Console.WriteLine("Cerinta este: Se dau 5 numere. Sa se afiseze in ordine crescatoare.\r\nintroduceti cele 5 numere");
                        
                        int a10 = Convert.ToInt32(Console.ReadLine());
                        int b10 = Convert.ToInt32(Console.ReadLine());
                        int c10 = Convert.ToInt32(Console.ReadLine());
                        int d10 = Convert.ToInt32(Console.ReadLine());
                        int e10 = Convert.ToInt32(Console.ReadLine());

                        bool ok;
                        do
                        {
                            ok = true;
                            if (a10 > b10) 
                            { 
                                (a10, b10) = (b10, a10); 
                                ok = false; 
                            }
                            if (b10 > c10) 
                            { 
                                (b10, c10) = (c10, b10); 
                                ok = false; 
                            }
                            if (c10 > d10) 
                            { 
                                (c10, d10) = (d10, c10); 
                                ok = false; 
                            }
                            if (d10 > e10) 
                            { 
                                (d10, e10) = (e10, d10); 
                                ok = false; 
                            }

                        } while (ok == false);

                        Console.WriteLine(a10 + " " + b10 + " " + c10 + " " + d10 + " " + e10);

                        Console.ForegroundColor = ConsoleColor.Green;
                        Console.WriteLine("Doriti sa mai verificati probleme? (DA/NU)\n");
                        Console.ForegroundColor = ConsoleColor.White;

                        DN = Console.ReadLine().ToUpper();

                        break;
                    case 17:

                        Console.WriteLine("Cerinta este: Determianti cel mai mare divizor comun si cel mai mic multiplu comun a doua numere\r\nIntroduceti cele 2 numere:\n");

                        int a11 = Convert.ToInt32(Console.ReadLine());
                        int b11 = Convert.ToInt32(Console.ReadLine());

                        int prA = a11, prB = b11, c11;
                        while (b11 != 0)
                        {
                            c11 = a11 % b11;
                            a11 = b11;
                            b11 = c11;
                        }

                        int CMMDC = a11;
                        int CMMMC = (prA * prB) / CMMDC;

                        Console.WriteLine($"CMMDC: {CMMDC}, CMMMC: {CMMMC}");

                        Console.ForegroundColor = ConsoleColor.Green;
                        Console.WriteLine("Doriti sa mai verificati probleme? (DA/NU)\n");
                        Console.ForegroundColor = ConsoleColor.White;

                        DN = Console.ReadLine().ToUpper();

                        break;

                    case 18:

                        Console.WriteLine("Cerinta este: Afisati descompunerea in factori primi ai unui numar n\r\nIntroduceti numarul n");

                        int n12 = Convert.ToInt32(Console.ReadLine());

                        int d = 2, p2 = 0;

                        while (n12 > 1)
                        {
                            p2 = 0;
                            while (n12 % d == 0)
                            {
                                ++p2;
                                n12 /= d;
                            }
                            if (p2 != 0)
                                Console.WriteLine(d + "^" + p2);
                            ++d;
                            if (n12 > 1 && d * d > n12)

                                d = n12;
                        }
                        Console.ForegroundColor = ConsoleColor.Green;
                        Console.WriteLine("Doriti sa mai verificati probleme? (DA/NU)\n");
                        Console.ForegroundColor = ConsoleColor.White;

                        DN = Console.ReadLine().ToUpper();
                        break;

                    case 19:

                        Console.WriteLine("Cerinta este: Determinati daca un numar e format doar cu 2 cifre care se pot repeta\r\nIntroduceti numarul:");

                        int n13 = Convert.ToInt32(Console.ReadLine());

                        bool ok3 = true;

                        int i6 = 0;
                        int[] cif = new int[10];
                        while (n13 != 0)
                        {
                            i6++;
                            cif[n13 % 10]++;
                            n13 /= 10;
                        }

                        int s = 0;
                        for (int i5 = 0; i5 < 10; i5++)
                        {
                            if (cif[i5] > 0) s++;
                        }

                        if (s > 2) 
                            ok3 = false;

                        if (ok3 == true)
                            Console.WriteLine("Numarul este valid");
                        else
                            Console.WriteLine("Numarul nu este valid");

                        Console.ForegroundColor = ConsoleColor.Green;
                        Console.WriteLine("Doriti sa mai verificati probleme? (DA/NU)\n");
                        Console.ForegroundColor = ConsoleColor.White;

                        DN = Console.ReadLine().ToUpper();

                        break;

                    case 21:

                        Console.WriteLine("Cerinta este: Ghiciti un numar intre 1 si 1024 prin intrebari de forma \"numarul este mai mare sau egal decat x?\"");

                        int m = 512, i7 = 1, s7 = 1024;

                        Console.WriteLine("Numarul este mai mare, mai mic sau egal cu 512?");
                        String adf = Console.ReadLine();
                        bool ok7 = true;


                        while (ok7 == true)
                        {
                            adf = adf.ToUpper();
                            switch (adf)
                            {
                                case "MAI MARE":
                                    i7 = m;
                                    m = (m + s7) / 2;
                                    Console.WriteLine("Numarul este mai mare, mai mic sau egal cu " + m + "?");
                                    break;

                                case "MAI MIC":
                                    s = m;
                                    m = (m + i7) / 2;
                                    Console.WriteLine("Numarul este mai mare, mai mic sau egal cu " + m + "?");
                                    break;

                                case "EGAL":
                                    Console.WriteLine("Se pare ca am ghicit numarul " + m);
                                    ok = false;
                                    break;
                            }
                            adf = Console.ReadLine();
                        }
                        Console.ForegroundColor = ConsoleColor.Green;
                        Console.WriteLine("Doriti sa mai verificati probleme? (DA/NU)\n");
                        Console.ForegroundColor = ConsoleColor.White;

                        DN = Console.ReadLine().ToUpper();

                        break;
                }

            }
        }
    }
}

