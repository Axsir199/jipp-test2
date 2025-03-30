namespace ConsoleApp1
{
    internal class Program
    {
        static void Main(string[] args)
        {        
            //Zadanie 1

            Console.WriteLine("Podaj swoje imię:");
            var name = Console.ReadLine();
            Console.WriteLine("Hello " + name);

            //Zadanie2

            int result = 5 + 9;

            {
                //      Operatory
                //  Zadanie 1
                int number = 1;
                float money = 21.37f;
                string text = "Witaj";
                bool isLogged = true;
                char myChar = 'Q';
                decimal price = 1.111m;


                Console.WriteLine("\nNumber: " + number);
                Console.WriteLine("Money: " + money);
                Console.WriteLine("Text: " + text);
                Console.WriteLine("Is Logged: " + isLogged);
                Console.WriteLine("My Char: " + myChar);
                Console.WriteLine("Price: " + price);

                //  Zadanie 2
                string myAge = "Age:22";
                int wifeAge = 18;


                string resultage = myAge + wifeAge;


                Console.WriteLine("\nResult: " + resultage);

                //  Wnioski:
                //W C# nie Można dodawać zmiennej string i int sposób matematyczny
                //Następuje konkatenacja (łączenie) wartości, zamiast dodawania matematycznego

                // Zadanie 3
                bool isTrue = true;
                bool isFalse = false;
                bool isReallyTrue = true;

                bool and = isTrue && isFalse;
                bool or = isTrue || isReallyTrue;
                bool negative = !isFalse;

                Console.WriteLine("\nAND: " + and);
                Console.WriteLine("OR: " + or);
                Console.WriteLine("NEGATIVE: " + negative);

                //  Zadanie 4 
                int a = 5;
                int b = 12;

                int add = a + b;
                int sub = a - b;
                int div = a / b;
                int mul = a * b;
                int mod = a % b;

                Console.WriteLine("\nADD: " + add);
                Console.WriteLine("SUB: " + sub);
                Console.WriteLine("DIV: " + div);
                Console.WriteLine("MUL: " + mul);
                Console.WriteLine("MOD: " + mod);

                //  Zadanie 5
                string aTekst = "Ala";
                string bTekst = "ma";
                string cTekst = "kota.";

                string resultText = aTekst + bTekst + cTekst;

                //  Wynik:
                Console.WriteLine("\nResult: " + resultText);

                // Spostrzeżenia:
                // Wynikiem operacji jest: "Alamakota.". Operacja + dla string łączy je w jeden ciąg znaków
                // Mozna dodać spacje na końcu pierwszych dwóch stringów, aby wynik wyglądał poprawnie





                //  Instrukcje sterujące i pętle

                //  Zadanie 1

                int n1 = 10;
                int n2 = 20;

                if (n1 > n2)
                {
                    Console.WriteLine($"\n{n1} jest większe od {n2}");
                }
                else if (n1 < n2)
                {
                    Console.WriteLine($"{n2} jest większe od {n1}");
                }
                else
                {
                    Console.WriteLine($"{n1} jest równe {n2}");
                }

                //  Zadanie 2

                for (int i = 0; i < 10; i++)
                {
                    Console.WriteLine("\nC#");
                }

                int count = 0;
                while (count < 10)
                {
                    Console.WriteLine("C#");
                    count++;
                }

                // Zadanie3
                int n = 10;
                for (int i = 0; i <= n; i++)
                {
                    if (i % 2 == 0)
                    {
                        Console.WriteLine($"\n{i} - Parzysta");
                    }
                    else
                    {
                        Console.WriteLine($"{i} - Nieparzysta");
                    }
                }
                //  Zadanie 4
                int nx = 5;
                for (int i = 1; i <= nx; i++)
                {
                    for (int j = 1; j <= i; j++)
                    {
                        Console.Write("* ");
                    }
                    Console.WriteLine();
                }
                int ny = 3;
                for (int i = 1; i <= ny; i++)
                {
                    for (int j = 1; j <= i; j++)
                    {
                        Console.Write("* ");
                    }
                    Console.WriteLine();
                }

                // Zadanie 5
                int exam = 67;

                if (exam < 0 || exam > 100)
                {
                    Console.WriteLine("Poza zakresem");
                }
                else if (exam <= 39)
                {
                    Console.WriteLine("Ocena Niedostateczna");
                }
                else if (exam <= 54)
                {
                    Console.WriteLine("Ocena Dopuszczająca");
                }
                else if (exam <= 69)
                {
                    Console.WriteLine("Ocena Dostateczna");
                }
                else if (exam <= 84)
                {
                    Console.WriteLine("Ocena Dobra");
                }
                else if (exam <= 98)
                {
                    Console.WriteLine("Ocena Bardzo Dobra");
                }
                else
                {
                    Console.WriteLine("Ocena Celująca");
                }
                
                
                //      Kolekcje
                //  Zadanie 1 

                string[] colors = { "Biały", "Pomarańczowy", "Magenta", "Cyjan" };
                Console.WriteLine($"Mój pierwszy kolor to: {colors[0]}");
                Console.WriteLine($"Mój ostatni kolor to: {colors[colors.Length - 1]}");

                //  Zadanie 2 

                int[] numbers = { -21, -13, 0, 3, 6, 7, 9, 15, 33, 45 };

                Console.WriteLine("\n************ Pętla for ************");
                for (int i = 0; i < numbers.Length; i++)
                {
                    Console.WriteLine($"Liczba: {numbers[i]}");

                }

                Console.WriteLine("\n************ Pętla foreach ************");
                foreach (int number2 in numbers)
                {
                    Console.WriteLine($"Liczba: {number2}");

                }


                Console.WriteLine("\n************ Pętla while ************");
                int index = 0;
                while (index < numbers.Length)
                {
                    Console.WriteLine($"Liczba: {numbers[index]}");
                    index++;
                }


                //  Zadanie 3 

                List<string> fruits = new List<string> { "Pomidor", "Jabłko", "Marchewka", "Mango" };
                Console.WriteLine("\nLista owoców przed usunięciem:");
                Console.WriteLine(string.Join(", ", fruits));

                // Usuwanie pierwszego i ostatniego elementu listy
                fruits.RemoveAt(0); // usuwa Pomidor
                fruits.RemoveAt(fruits.Count - 1); // usuwa ostatni element Mango

                Console.WriteLine("\nLista owoców po usunięciu:");
                Console.WriteLine(string.Join(", ", fruits));
            }

        }
    }
}