using System;
using System.Collections.Generic;

namespace ConditionalStatements
{
    class Exercises
    {
        static void Main(string[] args)
        {
            /*
            //1.Write an if-statement that takes two integer variables and exchanges
            //their values if the first one is greater than the second one.
            Console.WriteLine("Zadaj dve cisla a ja ich vypisem v zoradenom poradi.");
            Console.Write("Zadaj prve cislo: ");
            int cisloNaPorovnanie1 = int.Parse(Console.ReadLine());
            Console.Write("Zadaj druhe cislo: ");
            int cisloNaPorovnanie2 = int.Parse(Console.ReadLine());
            if (cisloNaPorovnanie1 > cisloNaPorovnanie2)
            {
                int cisloTmp = cisloNaPorovnanie1;
                cisloNaPorovnanie1 = cisloNaPorovnanie2;
                cisloNaPorovnanie2 = cisloTmp;
            }
            Console.WriteLine($"Cisla od najmensieho po najvacsie: {cisloNaPorovnanie1},{cisloNaPorovnanie2}.");
            KoniecSkriptu();

            //2.Write a program that shows the sign(+or -) of the product of three real
            //numbers, without calculating it.Use a sequence of if operators.
            Console.WriteLine("Zadaj tri cisla a ja ti vypisem, ci ich sucin je kladne, alebo zaporne cislo.");
            Console.Write("Zadaj prve cislo: ");
            double cisloPreZisteniePlusMinus1 = double.Parse(Console.ReadLine());
            Console.Write("Zadaj druhe cislo: ");
            double cisloPreZisteniePlusMinus2 = double.Parse(Console.ReadLine());
            Console.Write("Zadaj tretie cislo: ");
            double cisloPreZisteniePlusMinus3 = double.Parse(Console.ReadLine());
            if ((cisloPreZisteniePlusMinus1 == 0) || (cisloPreZisteniePlusMinus2 == 0) || (cisloPreZisteniePlusMinus3 == 0))
            {
                Console.WriteLine("Sucin zadanych cisel je 0.");
                
            }
            else
            {
                int pocetZapornychVysledkov = 0;
                if (cisloPreZisteniePlusMinus1 < 0)
                {
                    pocetZapornychVysledkov += 1;
                }
                if (cisloPreZisteniePlusMinus2 < 0)
                {
                    pocetZapornychVysledkov += 1;
                }
                if (cisloPreZisteniePlusMinus3 < 0)
                {
                    pocetZapornychVysledkov += 1;
                }
                if (pocetZapornychVysledkov % 2 == 0)
                {
                    Console.WriteLine("Sucin zadanych cisiel je kladny \"+\"");
                }
                else
                {
                    Console.WriteLine("Sucin zadanych cisiel je zaporny \"-\"");
                }
            }            
            KoniecSkriptu();

            //3.Write a program that finds the biggest of three integers, using nested
            //if statements.
            Console.WriteLine("Zadaj tri cele cisla a ja ti vypisem najvacsie.");
            Console.Write("Zadaj prve cislo: ");
            int cisloPreZoradenie1 = int.Parse(Console.ReadLine());
            Console.Write("Zadaj druhe cislo: ");
            int cisloPreZoradenie2 = int.Parse(Console.ReadLine());
            Console.Write("Zadaj tretie cislo: ");
            int cisloPreZoradenie3 = int.Parse(Console.ReadLine());
            if(cisloPreZoradenie1 > cisloPreZoradenie2)
            {
                if (cisloPreZoradenie1 > cisloPreZoradenie3)
                {
                    Console.WriteLine($"Najvacsie cislo je {cisloPreZoradenie1}");
                }
                else
                {
                    if (cisloPreZoradenie2 > cisloPreZoradenie3)
                    {
                        Console.WriteLine($"Najvacsie cislo je {cisloPreZoradenie2}");
                    }
                    else
                    {
                        Console.WriteLine($"Najvacsie cislo je {cisloPreZoradenie3}");
                    }
                }
            }
            else
            {
                if (cisloPreZoradenie2 > cisloPreZoradenie3)
                {
                    Console.WriteLine($"Najvacsie cislo je {cisloPreZoradenie2}");
                }
                else
                {
                    Console.WriteLine($"Najvacsie cislo je {cisloPreZoradenie3}");
                }
            }
            KoniecSkriptu();

            //4.Sort 3 real numbers in descending order. Use nested if statements.

            //5.Write a program that asks for a digit (0 - 9), and depending on the input,
            //shows the digit as a word(in English).Use a switch statement.
            Console.Write("Zadaj cislo od 0 do 9 a ja ti ho vypisem slovne: ");
            int cisloNaPreklad = int.Parse(Console.ReadLine());
            switch (cisloNaPreklad)
            {
                case 1:
                    Console.WriteLine("One");
                    break;
                case 2:
                    Console.WriteLine("Two");
                    break;
                case 3:
                    Console.WriteLine("Three");
                    break;
                case 4:
                    Console.WriteLine("Four");
                    break;
                case 5:
                    Console.WriteLine("Five");
                    break;
                case 6:
                    Console.WriteLine("Six");
                    break;
                case 7:
                    Console.WriteLine("Seven");
                    break;
                case 8:
                    Console.WriteLine("Eight");
                    break;
                case 9:
                    Console.WriteLine("Nine");
                    break;
                default:
                    Console.WriteLine("Nezadal si cislo v rozpati 0 .. 9.");
                    break;
            }
            KoniecSkriptu();

            //6.Write a program that gets the coefficients a, b and c of a quadratic
            //equation: ax2 + bx + c, calculates and prints its real roots(if they exist). 
            //Quadratic equations may have 0, 1 or 2 real roots. 
            Console.WriteLine("Zadaj hodnoty pre kvadraticku rovnicu a*x*x + b*x + c a ja ti najdem x.");
            Console.Write("Zadaj hodnotu pre a: ");
            double cisloA = double.Parse(Console.ReadLine());
            Console.Write("Zadaj hodnotu pre b: ");
            double cisloB = double.Parse(Console.ReadLine());
            Console.Write("Zadaj hodnotu pre c: ");
            double cisloC = double.Parse(Console.ReadLine());
            double cisloX;
            double cisloX1;
            double cisloDiscriminant = (cisloB * cisloB) - (4 * cisloA * cisloC); //najprv vypocitame diskriminant
            if (cisloDiscriminant == 0) //ak je diskriminant 0, vysledok je jeden
            {
                cisloX = (-cisloB) / (2 * cisloA);
                Console.WriteLine($"Rovnica {cisloA}*x2 + {cisloB}*x + {cisloC} ma jeden vysledok. x = {cisloX}");
            }
            else if (cisloDiscriminant > 0) //ak je diskriminant vacsi ako 0 (je kladny), tak vysledky su dva
            {
                cisloX = ((-cisloB) + Math.Sqrt((cisloB * cisloB) - (4 * cisloA * cisloC))) / (2 * cisloA);
                cisloX1 = ((-cisloB) - Math.Sqrt((cisloB * cisloB) - (4 * cisloA * cisloC))) / (2 * cisloA);
                Console.WriteLine($"Rovnica {cisloA}*x2 + {cisloB}*x + {cisloC} ma dva vysledky. x1 = {cisloX} a x2 = {cisloX1}");
            }
            else //ak je diskriminant mansi ako 0 (je zaporny), rovnica nema vysledok
            {
                Console.WriteLine($"Rovnica {cisloA}*x2 + {cisloB}*x + {cisloC} nema vysledok.");
            }
            KoniecSkriptu();

            //7.Write a program that finds the greatest of given 5 numbers.
            //prerobene na najdenie najvacsieho cisla zo zadanych
            Console.WriteLine("Zadaj cisla oddelenie medzerou a ja ti vypisem najvacsie.");
            Console.Write("Zadaj cisla: ");            
            List<int> zadaneCislaTransformedList = new List<int>();            
            foreach (var item in Console.ReadLine().Split(new char[] { ' ' }))
            {
                zadaneCislaTransformedList.Add(int.Parse(item));
            }
            int[] zadaneCislaInt = zadaneCislaTransformedList.ToArray();            
            Array.Sort(zadaneCislaInt);
            Console.WriteLine("Najvacsie cislo je: " + zadaneCislaInt[zadaneCislaInt.Length - 1]);
            KoniecSkriptu();

            //8.Write a program that, depending on the user’s choice, inputs int, double
            //or string variable. If the variable is int or double, the program
            //increases it by 1.If the variable is a string, the program appends "*" at
            //the end.Print the result at the console. Use switch statement.
            Console.WriteLine("Zadaj vstup a nasledne zadaj o aky typ hodnoty ide (int, double, string).");
            Console.Write("Zadaj hodnotu vstupu: ");
            string zadanyVstup = Console.ReadLine();
            Console.Write("Zadaj o aky typ vstupu ide. pre int zadaj 1, pre double 2 a pre string 3: ");
            string typZadanehoVstupu = Console.ReadLine();
            switch (typZadanehoVstupu)
            {
                case ("1"):
                    Console.WriteLine($"Zadal si hodnou {zadanyVstup}. Na zaklade typu vstupu ju menim na " + (int.Parse(zadanyVstup) + 1));
                    break;
                case ("2"):
                    Console.WriteLine($"Zadal si hodnou {zadanyVstup}. Na zaklade typu vstupu ju menim na " + (double.Parse(zadanyVstup) + 1));
                    break;
                case ("3"):
                    Console.WriteLine($"Zadal si hodnou {zadanyVstup}. Na zaklade typu vstupu ju menim na {zadanyVstup}*");
                    break;
                default:
                    Console.WriteLine("Zadal si zlu hodnotu pre typ vstupu.");
                    break;
            }
            KoniecSkriptu();
            */
            //9.We are given 5 integer numbers. Write a program that finds those
            //subsets whose sum is 0.Examples: 
            //-If we are given the numbers { 3, -2, 1, 1, 8}, the sum of - 2, 1 and 1
            //is 0.
            //- If we are given the numbers { 3, 1, -7, 35, 22}, there are no subsets
            //with sum 0.
            Console.WriteLine("Zadaj cele cisla oddelene medzerou a ja z nich vytvorim skupiny, ktorych sucet je nula.");
            Console.Write("cisla: ");
            List<int> zadaneCisla = new List<int>();
            foreach (var item in Console.ReadLine().Split(new char[] { ' '}))
            {
                zadaneCisla.Add(int.Parse(item));
            }
            Array zadaneCislaPole = zadaneCisla.ToArray();
            int sumaCisel = 0;            
            foreach (int item in zadaneCislaPole)
            {
                sumaCisel += item;
            }
            if (sumaCisel == 0)
            {
                foreach (var item in zadaneCislaPole)
                {
                    Console.Write("{0} ", item.ToString());
                }
                Console.WriteLine();
            }
            sumaCisel = 0;
            //pouzijem kombinacie bez opakovania a to tak, ze vytvorim skupiny cisel
            //z dlzky pola zistim pocet vsetkych cisel, to bude n, velkosti skupin cisel budu k
            //takze pri poli o pocte 5 cisel bude skupin k = 2, k = 3, k = 4
            //5!/(2!*(5-2)! , 5!/(3!*(5-3)! , 5!/(4!*(5-4)!
            double pocetSkupin = 0;
            int startIndex = 0;
            int endIndex = 0;
            int dlzkaPola = zadaneCislaPole.Length;
            for (int i = 2; i < zadaneCislaPole.Length; i++)
            {
                pocetSkupin = Factorial(dlzkaPola) / (Factorial(i) * Factorial(dlzkaPola - i));
                Console.WriteLine($"Pocet moznych kombinacii pre k = {i} je {pocetSkupin}");                


            }

            KoniecSkriptu();

            //10.Write a program that applies bonus points to given scores in the range
            //[1…9] by the following rules: 
            //-If the score is between 1 and 3, the program multiplies it by 10.
            //- If the score is between 4 and 6, the program multiplies it by 100.
            //- If the score is between 7 and 9, the program multiplies it by 1000.
            //- If the score is 0 or more than 9, the program prints an error
            //message.

            //11. * Write a program that converts a number in the range[0…999] to
            //words, corresponding to the English pronunciation. Examples:
            //            - 0-- > "Zero"
            //            - 12-- > "Twelve"
            //            - 98-- > "Ninety eight"
            //            - 273-- > "Two hundred seventy three"
            //            - 400-- > "Four hundred"
            //            - 501-- > "Five hundred and one"
            //            - 711-- > "Seven hundred and eleven"
        }

        private static double Factorial(int cislo)
        {
            double vysledok = 1;
            while (cislo != 1)
            {
                vysledok = vysledok * cislo;
                cislo--;
            }
            return vysledok;
        }

        
        static void CombinationUtil(int[] arr, int[] data,
                                    int start, int end,
                                    int index, int r)
        {
            // Current combination is  
            // ready to be printed,  
            // print it 
            if (index == r)
            {
                for (int j = 0; j < r; j++)
                    Console.Write(data[j] + " ");
                Console.WriteLine("");
                return;
            }

            // replace index with all 
            // possible elements. The  
            // condition "end-i+1 >=  
            // r-index" makes sure that  
            // including one element 
            // at index will make a  
            // combination with remaining  
            // elements at remaining positions 
            for (int i = start; i <= end &&
                      end - i + 1 >= r - index; i++)
            {
                data[index] = arr[i];
                CombinationUtil(arr, data, i + 1,
                                end, index + 1, r);
            }
        }

        static void PrintCombination(int[] arr, int n, int r)
        {
            // A temporary array to store  
            // all combination one by one 
            int[] data = new int[r];

            // Print all combination  
            // using temprary array 'data[]' 
            CombinationUtil(arr, data, 0, n - 1, 0, r);
        }

        static void KoniecSkriptu()
        {
            Console.WriteLine(new String('#', 60));
            Console.WriteLine();
        }
    }
}
